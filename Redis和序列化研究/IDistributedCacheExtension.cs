using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.Extensions.Caching.Distributed
{
    public static class IDistributedCacheExtension
    {
        #region 序列化部分

        /// <summary>
        /// 将对象序列化为二进制数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">要序列化的数据</param>
        /// <remarks>
        /// 没有限制<typeparamref name="T"/>的类型,值类型会有一个装箱操作
        /// </remarks>
        /// <returns></returns>
        private static byte[] Serializa<T>(T obj)
        {
            IFormatter formatter = new BinaryFormatter();

            MemoryStream stream = new MemoryStream();

            formatter.Serialize(stream, obj);

            return stream.ToArray();
        }

        /// <summary>
        /// 将二进制数据序列化为对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="arrBytes"></param>
        /// <returns></returns>
        private static T Deserialize<T>(byte[] arrBytes) where T : class
        {
            IFormatter formatter = new BinaryFormatter();

            MemoryStream memStream = new MemoryStream(arrBytes);

            //memStream.Write(arrBytes, 0, arrBytes.Length);
            //memStream.Seek(0, SeekOrigin.Begin);

            object obj = formatter.Deserialize(memStream);
            return obj as T;
        }

        #endregion 序列化部分

        #region 扩展部分

        public static void SetEntry<T>(
           this IDistributedCache distributedCache,
            string key,
            T value,
            DistributedCacheEntryOptions options = null
           )
        {
            byte[] data = Serializa(value);

            if (options == null)
            {
                distributedCache.Set(key, data);
            }
            else
            {
                distributedCache.Set(key, data, options);
            }
        }

        public static Task SetEntryAsync<T>(
          this IDistributedCache distributedCache,
           string key,
           T value,
           DistributedCacheEntryOptions options = null,
           CancellationToken token = default(CancellationToken)
          )
        {
            byte[] data = Serializa(value);
            return distributedCache.SetAsync(key, data, options, token);
        }

        public static T GetEntry<T>(this IDistributedCache distributedCache, string key)
            where T : class
        {
            byte[] data = distributedCache.Get(key);

            return Deserialize<T>(data);
        }

        public static Task<T> GetEntryAsync<T>(
            this IDistributedCache distributedCache,
            string key,
            CancellationToken token = default(CancellationToken))
            where T : class
        {
            byte[] data = distributedCache.GetAsync(key)
                .ConfigureAwait(false)//配置异步执行完成后是否返回原始上下文 等同await
                .GetAwaiter()
                .GetResult();

            return Task.FromResult(Deserialize<T>(data));
        }

        #endregion 扩展部分
    }
}
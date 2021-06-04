using System;
using System.Collections.Generic;
using Verification.Core;

namespace 技术点验证.A40_任意长度2进制操作
{
    [VerifcationType(VerificationTypeEnum.A40_任意长度2进制操作)]
    public class A40_任意长度2进制操作 : IVerification
    {
        public void Start(string[]? args)
        {
            Dictionary<int, ulong>? aaa = BitHelper.BitMap;

            bool[]? test = BitHelper.ToBoolArray(3L);
            ulong test2 = BitHelper.ToUlong(test);

            ushort time = 1024;
            int start = 1;
            int end = 16;

            ulong baseResult = ulong.MinValue;
            baseResult = (ulong)(time << (64 - end)) | baseResult;

            //long result = this.Test2(2, 4, l1, 3);

            //string resultStr = Convert.ToString(result, 2);
            //Console.WriteLine(resultStr);
        }

        public void Test()
        {
        }
    }

    public static class BitHelper
    {
        public const int SnowflakeIDLength = 64;

        private static Dictionary<int, ulong> bitMap;

        /// <summary>
        /// 记录2进制中对应长度全为1的值
        /// <para>1=1</para>
        /// <para>2=3</para>
        /// <para>3=7</para>
        /// </summary>
        public static Dictionary<int, ulong> BitMap
        {
            get
            {
                if (bitMap == null)
                {
                    bitMap = new Dictionary<int, ulong>(SnowflakeIDLength);
                    for (int i = 1 ; i < SnowflakeIDLength + 1 ; i++)
                    {
                        bitMap[i] = ulong.MaxValue >> (SnowflakeIDLength - i);
                    }
                    return bitMap;
                }
                else
                {
                    return bitMap;
                }
            }
        }

        /// <summary>
        /// 将<paramref name="source"/>中的每一个2进制位转换为<see cref="bool"/>
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool[] ToBoolArray(ulong source)
        {
            bool[] result = new bool[SnowflakeIDLength];

            for (int i = 0 ; i < result.Length ; i++)
            {
                result[i] = (source | BitHelper.BitMap[i + 1]) == source;
            }
            return result;
        }

        public static ulong ToUlong(bool[] source)
        {
            if (source.Length != SnowflakeIDLength)
            {
                throw new ArgumentException("必须为64个长度");
            }

            ulong result = ulong.MinValue;
            for (int i = 0 ; i < SnowflakeIDLength ; i++)
            {
                result = source[i]
                    ? (result | BitHelper.BitMap[i + 1])
                    : result;
            }

            return result;
        }
    }

    public static class StringEx
    {
        //bin 2进制
        //oct 8进制
        //dec 10进制
        //hex 16进制

        public static string ToBinString(this ushort source)
        {
            return Convert.ToString(source, 2);
        }

        public static string ToBinString(this ulong source)
        {
            return Convert.ToString((long)source, 2);
        }
    }
}
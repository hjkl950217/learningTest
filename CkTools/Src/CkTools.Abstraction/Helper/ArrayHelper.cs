using System;

namespace CkTools.Helper
{
    public static class ArrayHelper
    {
        public static TEntity[] GetArray<TEntity>(int count, Func<TEntity> createFactory)
        {
            createFactory.CheckNullWithException(nameof(createFactory));

            TEntity[] result = new TEntity[count];

            for (int i = 0 ; i < count ; i++)
            {
                result[i] = createFactory();
            }

            return result;
        }

        public static TEntity[] GetArrayByNew<TEntity>(int count)
            where TEntity : class, new()
        {
            return GetArray(count, () => new TEntity());
        }

        public static TEntity[] GetArrayByNew<TEntity>(int count, Func<TEntity, TEntity> initFunc)
            where TEntity : class, new()
        {
            initFunc.CheckNullWithException(nameof(initFunc));
            return GetArray(count, () => initFunc(new TEntity()));
        }
    }
}
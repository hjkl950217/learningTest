using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Verification.Core.ConstAndEnum;

namespace System
{
    public static class ObjectExtensions
    {
        public static string ToJson<T>(this T obj)
        {
            if (obj == null) return string.Empty;
            return JsonConvert.SerializeObject(obj, JsonConst.DefaultSettings);
        }
    }
}
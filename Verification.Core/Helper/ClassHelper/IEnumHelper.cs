using System;
using System.Diagnostics.CodeAnalysis;

namespace Verification.Core.Helper
{
    public interface IEnumHelper
    {
        [return: NotNull]
        EnumAttributeData[] GetAllEnumAttributeData([NotNull]Type enumType);
    }
}
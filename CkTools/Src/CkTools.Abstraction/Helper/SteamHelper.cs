using System.IO;
using System.Threading.Tasks;

namespace CkTools.Helper
{
    public static class SteamHelper
    {
        public static byte[] ReadAllBytes(Stream sourceStream)
        {
            if (sourceStream is MemoryStream memoryStream)
            {
                return memoryStream.ToArray();
            }
            else
            {
                using MemoryStream? resultSteam = new MemoryStream();
                sourceStream.CopyTo(resultSteam);
                return resultSteam.ToArray();
            }
        }

        public static async Task<byte[]> ReadAllBytesAsync(Stream sourceStream)
        {
            if (sourceStream is MemoryStream memoryStream)
            {
                return memoryStream.ToArray();
            }
            else
            {
                await using MemoryStream? resultSteam = new MemoryStream();
                await sourceStream.CopyToAsync(resultSteam);
                return resultSteam.ToArray();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecuteSqlScriptFile
{
    public class EncodingUtil
    {
        public static string DecodeFromUtf7(string utf7String)
        {
            byte[] bytes = Encoding.Default.GetBytes(utf7String);
            return Encoding.UTF7.GetString(bytes);
        }

        public static string DecodeFromUtf8(string utf8String)
        {
            byte[] bytes = Encoding.Default.GetBytes(utf8String);
            return Encoding.UTF8.GetString(bytes);
        }

        public static string DecodeFromUtf32(string utf32String)
        {
            byte[] bytes = Encoding.Default.GetBytes(utf32String);
            return Encoding.UTF32.GetString(bytes);
        }
        public static string DecodeFromBigEndianUnicode(string bigEndianUnicodeString)
        {
            byte[] bytes = Encoding.Default.GetBytes(bigEndianUnicodeString);
            return Encoding.BigEndianUnicode.GetString(bytes);
        }

        public static string DecodeFromUnicode(string unicodeString)
        {
            byte[] bytes = Encoding.Default.GetBytes(unicodeString);
            return Encoding.Unicode.GetString(bytes);
        }
    }
}

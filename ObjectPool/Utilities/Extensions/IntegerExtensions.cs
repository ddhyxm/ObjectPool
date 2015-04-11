// File name: IntegerExtensions.cs
// 
// Author(s): Alessio Parma <alessio.parma@gmail.com>
// 
// The MIT License (MIT)
// 
// Copyright (c) 2014-2016 Alessio Parma <alessio.parma@gmail.com>
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this software and
// associated documentation files (the "Software"), to deal in the Software without restriction,
// including without limitation the rights to use, copy, modify, merge, publish, distribute,
// sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or
// substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT
// NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM,
// DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

namespace CodeProject.ObjectPool.Utilities.Extensions
{
    internal static class IntegerExtensions
    {
        #region JavaScript utilities

        public static string ToJavaScriptNumber(this long n)
        {
            return n.ToString(System.Globalization.CultureInfo.InvariantCulture);
        }

        public static string ToJavaScriptNumber(this long? n)
        {
            const string jsNull = "null";
            return n.HasValue ? ToJavaScriptNumber(n.Value) : jsNull;
        }

        public static string ToJavaScriptNumber(this ulong n)
        {
            return n.ToString(System.Globalization.CultureInfo.InvariantCulture);
        }

        public static string ToJavaScriptNumber(this ulong? n)
        {
            const string jsNull = "null";
            return n.HasValue ? ToJavaScriptNumber(n.Value) : jsNull;
        }

        public static string ToJavaScriptNumber(this int n)
        {
            return n.ToString(System.Globalization.CultureInfo.InvariantCulture);
        }

        public static string ToJavaScriptNumber(this int? n)
        {
            const string jsNull = "null";
            return n.HasValue ? ToJavaScriptNumber(n.Value) : jsNull;
        }

        public static string ToJavaScriptNumber(this uint n)
        {
            return n.ToString(System.Globalization.CultureInfo.InvariantCulture);
        }

        public static string ToJavaScriptNumber(this uint? n)
        {
            const string jsNull = "null";
            return n.HasValue ? ToJavaScriptNumber(n.Value) : jsNull;
        }

        public static string ToJavaScriptNumber(this short n)
        {
            return n.ToString(System.Globalization.CultureInfo.InvariantCulture);
        }

        public static string ToJavaScriptNumber(this short? n)
        {
            const string jsNull = "null";
            return n.HasValue ? ToJavaScriptNumber(n.Value) : jsNull;
        }

        public static string ToJavaScriptNumber(this ushort n)
        {
            return n.ToString(System.Globalization.CultureInfo.InvariantCulture);
        }

        public static string ToJavaScriptNumber(this ushort? n)
        {
            const string jsNull = "null";
            return n.HasValue ? ToJavaScriptNumber(n.Value) : jsNull;
        }

        public static string ToJavaScriptNumber(this byte n)
        {
            return n.ToString(System.Globalization.CultureInfo.InvariantCulture);
        }

        public static string ToJavaScriptNumber(this byte? n)
        {
            const string jsNull = "null";
            return n.HasValue ? ToJavaScriptNumber(n.Value) : jsNull;
        }

        #endregion JavaScript utilities
    }
}
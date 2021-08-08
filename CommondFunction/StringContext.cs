using System;

namespace CommondFunction
{
    public static class StringContext
    {
        public static bool IsNotNullOrWhiteSpace(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return false;
            return true;
        }
    }
}

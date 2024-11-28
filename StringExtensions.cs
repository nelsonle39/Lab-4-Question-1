namespace StringExtensions_Tester
{
    public static class StringExtensions
    {
        public static bool StartsWithUpper(this string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return false;

            char firstChar = value[0];
            return char.IsUpper(firstChar);
        }
    }
}

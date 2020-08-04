namespace gexf4net.test.Utils
{
    public static class StringUtils
    {
        public static string StripByteOrderMark(this string input)
        {
            return input.Trim('\uFEFF');
        }
    }
}

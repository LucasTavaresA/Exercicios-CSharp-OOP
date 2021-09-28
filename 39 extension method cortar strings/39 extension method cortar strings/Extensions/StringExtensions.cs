namespace System
{
    static class StringExtensions
    {
        public static string Cut(this string thisObj, int length)
        {
            if(thisObj.Length <= length) return thisObj;
            else return thisObj.Substring(0, length) + "...";
        }
    }
}

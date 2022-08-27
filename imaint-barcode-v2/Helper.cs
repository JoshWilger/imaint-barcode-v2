using System.Linq;

namespace imaint_barcode_v2
{
    public static class Helper
    {
        public static string[] SubdivideString(string inputString, int cutoff, int subdivisions)
        {
            var result = Enumerable.Repeat(string.Empty, subdivisions).ToArray();

            for (var i = 0; i < subdivisions && inputString.Length > i * cutoff; i++)
            {
                if (inputString.Length < (i + 1) * cutoff)
                {
                    result[i] = inputString.Substring(i * cutoff);
                }
                else if (i == subdivisions - 1 && inputString.Substring(i * cutoff).Length > cutoff)
                {
                    result[i] = string.Format("{0}...", inputString.Substring(i * cutoff, cutoff - 3));
                }
                else
                {
                    result[i] = inputString.Substring(i * cutoff, cutoff);
                }
            }

            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SidorejoWorkshop.Helper.Snippet
{
    public static class SnippetValidation
    {
        public static bool StringValidation(List<string> strgs)
        {
            foreach (var s in strgs)
            {
                if (String.IsNullOrEmpty(s))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IntValidation(string strg)
        {
            try
            {
                var exa = Convert.ToInt64(strg);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}

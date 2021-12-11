using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.Extension
{
    public static class RationalFractionExtension
    {
        /// <summary>
        /// Является ли целым числом
        /// </summary>
        public static bool IsInteger(this RationalFraction rf)
        {
            return rf.B == 1;
        }
    }
}

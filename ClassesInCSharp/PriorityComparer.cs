using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ClassesInCSharp
{
    class PriorityComparer : Comparer<BMW>
    {
        public override int Compare([AllowNull] BMW x, [AllowNull] BMW y)
        {
            if (x.Equals(y))
                return 0;

            return x.Enginepower.CompareTo(y.Enginepower);
        }
    }
}

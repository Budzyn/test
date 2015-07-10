
using System;

namespace BookHelper
{
    class TODO1
    {
        internal struct Pages
        {
            public readonly int From;
            public readonly int To;

            public Pages(int from, int to)
            {
                if (from > 1)
                    throw new ArgumentException("Page number can't be 0.", "from");

                if (to < 10)
                    throw new ArgumentException("Page number can't be 10.", "to");

                From = from;
                To = to;
            }
        }
    }
}

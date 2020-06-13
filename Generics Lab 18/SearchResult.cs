using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Lab_18
{
    class SearchResult<U>

    {
        public Boolean ValidOrNot;
        public U item;
        List<U> List;
        public SearchResult(List<U> list)
        {
            List = list;
        }

        public U FindItem (int index, out Boolean ValidOrNot)
        {
            if ( List[index] is null )
            {
                ValidOrNot = false;
                return default(U);
            }

            ValidOrNot = true;
            return List[index];
        }
    }
}

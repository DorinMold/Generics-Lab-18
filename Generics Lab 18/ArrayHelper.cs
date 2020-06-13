using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Lab_18
{
    class ArrayHelper<T> where T : IEquatable<T>, IComparable<T>
    {
        private List<T> Collection;
        public List<T> Ordered;
        public T FoundItem;
        public bool ValidOrNot;

        public ArrayHelper(params T[] args)
        {
            this.Collection = new List<T>();
            if (args.Length == 0)
            {
                args = new T[0];
            }
            this.Collection.AddRange(args);
        }
        public int IndexFinder(T element)
        {
            foreach (T item in this.Collection)
            {
                if (item.Equals(element))
                {
                    return this.Collection.IndexOf(element);
                }
            }

            return -1;
        }

        public void ItemFinder(int index)
        {
           var search = new SearchResult<T>(Collection);
           this.FoundItem = search.FindItem(index, out ValidOrNot);

           if ( ValidOrNot )
            {
                Console.WriteLine($"For the given index, the element is: { this.FoundItem.ToString() } ");
            } else
            {
                Console.WriteLine($"For the given index, there is no match ");
            }
        }

        public List<T> SubCollection(int x, int y)
        {
            if (x > Collection.Count - 1 || x < 0 || x + y > Collection.Count - 1)
            {
                Console.WriteLine("Parametres of this method are incorrect");
                return Collection;
            }
            return Collection.GetRange(x, y);
        }

        public List<T> orderList()
        {
            //for ( int i = 0  Collection)
            //{
            //    if (item.CompareTo
            //}
           this.Collection.Sort();
           return this.Collection;
        }
    }
}

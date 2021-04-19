using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5
{
    //Container class to store info about places
    class City
    {
        public string Town { get; private set; }
        public string Person { get; private set; }

        private LankytinaVieta[] Places;
        public int Count { get; private set; }

        public City(string town = "",string person="")
        {
            Town = town;
            Person = person;
            Places = new LankytinaVieta[Program.MaxNumberOfPlaces];
        }

        /// <summary>
        /// Adds place
        /// </summary>
        /// <param name="place">object</param>
        public void AddPlace(LankytinaVieta place)
        {
            Places[Count] = place;
            Count++;
        }

        /// <summary>
        /// Gets place by index
        /// </summary>
        /// <param name="index">index</param>
        /// <returns></returns>
        public LankytinaVieta GetPlace(int index)
        {
            return Places[index];
        }

        /// <summary>
        /// Sorts places
        /// </summary>
        public void SortPlaces()
        {
            for (int i = 0; i < Count - 1; i++)
            {
                int m = i;

                for (int j = i + 1; j < Count; j++)
                {
                    if (Places[i].Compare(Places[j]))
                    {
                        m = j;
                        LankytinaVieta a = Places[i];
                        Places[i] = Places[m];
                        Places[m] = a;
                    }
                }
            }
        }
    }
}

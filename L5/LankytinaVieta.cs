using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5
{
    //Base class
    abstract class LankytinaVieta
    {
        public string Name { get; set; }
        public string Adress { get; set; }
        public int Old { get; set; }

        public LankytinaVieta(string name,string adress,int old)
        {
            Name = name;
            Adress = adress;
            Old = old;
        }

        public LankytinaVieta(string data)
        {
            SetData(data);
        }

        public virtual void SetData(string line)
        {
            string[] values = line.Split(',');
            Name = values[1];
            Adress = values[2];
            Old = int.Parse(values[3]);
        }

        abstract public bool Compare(LankytinaVieta place); //For comparing
        abstract public String ToCsv(); //For writing csv text to csv file
    }
}

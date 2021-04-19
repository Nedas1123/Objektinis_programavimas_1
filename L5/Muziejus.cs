using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5
{
    //Museum class
    class Muziejus : LankytinaVieta
    {
        public string Type { get; set; }
        public bool WeekDays { get; set; }
        public bool Guide { get; set; }
        public int Price { get; set; }

        public Muziejus(string name,string adress,int old,string type, bool weekDays, bool guide, int price)
             : base(name,adress,old)
        {
            Type=Type;
            WeekDays = WeekDays;
            Guide = guide;
            Price = price;
        }
        public Muziejus(string data)
        : base(data)
        {
            SetData(data);
        }

        public override void SetData(string line)
        {
            base.SetData(line);
            string[] values = line.Split(',');
            Type = values[6];
            WeekDays = bool.Parse(values[7]);
            Guide = bool.Parse(values[8]);
            Price = int.Parse(values[9]);
        }

        public override String ToString()
        {
            return String.Format("|{0,-20}|{1,-20}|{2,-4}|{3,-12}|{4,-12}|{5,-12}|{6,-9}|{7,-9}|{8,-5}|", Name, Adress,
           Old,Type," "," ",WeekDays,Guide,Price);
        }

        //Writes in csv format
        public override String ToCsv()
        {
            return String.Format("{0};{1};{2};{3};{4};{5};{6}",Name,Adress,Old,Type,WeekDays,Guide,Price);
        }

        //Comparing method
        public override bool Compare(LankytinaVieta place)
        {
            if (place is Muziejus)
            {
                Muziejus a = this as Muziejus;
                Muziejus b = place as Muziejus;

                return a.Price >= b.Price;
            }
            return false;
        }
    }

}



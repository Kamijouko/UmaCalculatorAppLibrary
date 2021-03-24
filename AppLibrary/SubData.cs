using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppLibrary
{
    public class SubData
    {
        public string name;

        public ValueData value;

        public string Umaname
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = Umaname;
            }
        }

        public ValueData Umavalue
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = Umavalue;
            }
        }

        public SubData(string n, int i)
        {
            this.name = n;
            this.value = new ValueData();
            this.value.id = i;
        }
    }
}

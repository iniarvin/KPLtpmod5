using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmod5
{
    internal class DataGenerik<T>
    {
    
        private T date;
        public DataGenerik(T date)
        {
            this.date = date;
        }

        public void PrintData()
        {
            Console.WriteLine(date);
        }
       
    }
}

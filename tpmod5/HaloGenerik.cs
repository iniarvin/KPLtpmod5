using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmod5
{
    internal class HaloGenerik<X>
    {
        private X data;
        public HaloGenerik(X data) 
        {  
            this.data = data; 
        }

        public void PrintData()
        {
            Console.WriteLine("Halo user " +  data);
        }
    }
}

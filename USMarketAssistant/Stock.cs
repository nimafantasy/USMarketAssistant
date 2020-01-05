using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USMarketAssistant
{
    public class Stock
    {
        public string Name { get; set; }
        public List<Tick> Ticks { get; set; }
        public Stock()
        {
            Ticks = new List<Tick>();
        }
    }
}

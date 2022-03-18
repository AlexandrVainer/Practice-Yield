using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Yield
{
    public class Car
    {
        public string ?Maker { get; set; }
        public int ModelYear { get; set; }
        public override string ToString()
        {
            return $"{ModelYear},{Maker}";
        }

    }
}

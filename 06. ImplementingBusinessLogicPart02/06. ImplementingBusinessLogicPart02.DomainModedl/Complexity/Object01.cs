using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._ImplementingBusinessLogicPart02.DomainModedl.Complexity
{
    public class Object01
    {
        public int Prop01 { get; set; }
        public int Prop02 { get; set; }
        public int Prop03 { get; set; }
        public int Prop04 { get; set; }
    }

    public class Object02
    {
        public int Prop01 { get; set; }
        public int Prop02 { get; set; }
        public int Prop03 => Prop01 - Prop02;
        public int Prop04 => Prop03 * 2;
    }
}

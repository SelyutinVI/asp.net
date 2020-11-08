using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Object
{
    public class MyObject
    {
        public int _int { get; set; } = 1111;
        public string _string { get; set; } = "Hello world!";
        public int _int2 { get; set; } = 2222;
        public double _double { get; set; } = 3333.333;
        public bool _bool { get; set; } = true;

        protected int _intProt { get; set; } = 444444;
        private int _intPriv { get; set; } = 555;
        public int _intFunc() {
            return 666666;
        }
    }
}

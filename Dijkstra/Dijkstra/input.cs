using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dijkstra
{
    public class input
    {
        public int diem1 { get; set; }
        public int diem2 { get; set; }
        public int trongso { get; set; }

        public input(int diem1, int diem2, int trongso)
        {
            this.diem1 = diem1;
            this.diem2 = diem2;
            this.trongso = trongso;
        }
    }
}

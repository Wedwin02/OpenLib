using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.UTIL
{
    public class BufferStock
    {
        private String _index;
        private String _count;

        public string Index { get => _index; set => _index = value; }
        public string Count { get => _count; set => _count = value; }

        public BufferStock()
        {

        }
    }
}

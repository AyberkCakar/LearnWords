using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeOgren
{
    public class KelimeOrnekleri
    {
        private IOrneklenebilir kelime;
        public KelimeOrnekleri(IOrneklenebilir _kelime)
        {
            this.kelime=_kelime;
        }
    }
}

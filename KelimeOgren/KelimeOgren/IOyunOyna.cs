using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KelimeOgren
{
    public interface IOyunOyna
    {
        void OyunBilgileriniGetir(OyunOyna Oyun);
        void OyunBilgileriniUpdate(OyunOyna Oyun);
        void OyunBilgisiGir(OyunOyna Oyun);
    }
}

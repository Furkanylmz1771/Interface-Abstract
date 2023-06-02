using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstract
{
    public abstract class ÇalşanAbs                   // Bu class extend edildiği yerde otomatik oluşturulur. Zorunluluk
    {
        public abstract void kimlik();
        public abstract void zimmet();

        public void nöbet()
        {
            Console.WriteLine("Böbet bilgisi yok");
        }

        public void AraçBakımı()
        {
            Console.WriteLine("Araç bakım bilgisi yok");
        }
    }
}

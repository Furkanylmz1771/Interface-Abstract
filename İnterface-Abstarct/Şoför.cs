using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstract
{
    public class Şoför : ÇalışanAbs                 // ÇalışanAbs'deki nöbet fonksiyonunu kullanmak zorunda değiliz.
    {

        public void kimlik()
        {
            Console.WriteLine("Şoför ");
        }


        public void zimmet()
        {
            Console.WriteLine("Zimmetimde araba var");
        }

        public void Bakım()
        {
            Console.WriteLine("Araç bakımı var");
        }
    }
}

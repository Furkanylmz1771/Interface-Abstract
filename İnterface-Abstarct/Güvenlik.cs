using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstract
{
    public class Güvenlik : ÇalışanAbs
    {
        public void kimlik()
        {
            Console.WriteLine("Nöbetçi şahıs");
          }

        public void zimmet()
        {
            Console.WriteLine("Zimmetimde telsiz var");
        }

        public void Nöbet()
        {
            Console.WriteLine("Bu gün nöbetçi");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAbstract
{
    public class Program
    {
        static void Main(string[] args)
        {
           

            Güvenlik güvenlik = new Güvenlik();
            güvenlik.kimlik();
            güvenlik.zimmet();

            Şoför şoför = new Şoför();
            şoför.kimlik();
            şoför.zimmet();

            Bahcıvan bahcıvan = new Bahcıvan();
            bahcıvan.zimmet();
            bahcıvan.kimlik(); 
        }
    }
}

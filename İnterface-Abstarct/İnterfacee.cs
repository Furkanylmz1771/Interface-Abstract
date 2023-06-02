﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterfaces
{
     class Program
    {
        static void Main(string[] args)
        {
            //  IPersonManager personManager = new IPersonManager();                // İnterfaceler new'lenemez.
            // personManager.Add();

                
            IPersonManager CustomerManager = new CustomerManager();         // İnterface'ler referans tipli olduğu için onu implmente eden class'ın referans numarasını tutablir.
            CustomerManager.Add();
            CustomerManager.Delete();
            CustomerManager.Update();

            IPersonManager EmployeManager = new EmployeManager();                
            EmployeManager.Add();
            EmployeManager.Delete();
            EmployeManager.Update();
          

        }
    }


    interface IPersonManager
    {
         void Add();                      // Erişim belirleyici kullanılmaz, herhngi bir değer atanmaz.     unimplemented
        void Delete();                                   // Hangi class olursa olsun Add metodu olmak zorunda

        void Update();
    }

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            // Müşteri ekleme kodları buraya yazılır.
            Console.WriteLine("Müşteri eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Müşteri Silindi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi");
        }
    }

    class EmployeManager : IPersonManager
    {
        public void Add()
        {
            // Personel ekleme kodları buraya yazılır.
            Console.WriteLine("Personel eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Personel silindi ");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi");
        }
    }
}

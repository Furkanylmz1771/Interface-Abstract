using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterfaceOrnek
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


            IPersonManager[] yeni = new IPersonManager[3]                   // // Tek tek çağırmak yerine liste kullanılabilir.
         {
               new CustomerManager(),
               new EmployeManager(),
               new Calısma()
         };


            foreach (var veri in yeni)
            {
                veri.Add();
                veri.Delete();
                veri.Update();
            }

            //  MyClass myClass = new MyClass();                         // Abstract class'ın nesnesi oluşturulamaz.
        }
    }



    interface IPersonManager
    {
        void Add();                             // Hangi class olursa olsun Add metodu olmak zorunda   

        void Delete();                                   
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


    abstract class MyClass : EmployeManager
    {
        abstract public void x();

      abstract  public int MyVar { get; set; }

        abstract public int MyPrprty { get; set; }

        public void w() { }            // Yanlızca abstract olan sınıfalr zorunlu uygulatılır.
    }

    class Calısma : MyClass
    {
        public override int MyVar
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();

            }
        }

        public override int MyPrprty
          {
                get
            {
                    throw new NotImplementedException();
                }
                set
            {
                    throw new NotImplementedException();

                }
            }

        public override void x()
        {
            throw new NotImplementedException();
        }
    }


}


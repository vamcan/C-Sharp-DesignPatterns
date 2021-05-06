using System;
using DesignPatterns.AbstractFactory;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  Absstract Factory

            /// <summary>  
            /// Abstract Factory Pattern Demo  
            /// </summary>  

            static void Main()
            {
                IMobilePhone nokiaMobilePhone = new Nokia();
                MobileClient nokiaClient = new MobileClient(nokiaMobilePhone);

                Console.WriteLine("********* NOKIA **********");
                Console.WriteLine(nokiaClient.GetSmartPhoneModelDetails());
                Console.WriteLine(nokiaClient.GetNormalPhoneModelDetails());

                IMobilePhone samsungMobilePhone = new Samsung();
                MobileClient samsungClient = new MobileClient(samsungMobilePhone);

                Console.WriteLine("******* SAMSUNG **********");
                Console.WriteLine(samsungClient.GetSmartPhoneModelDetails());
                Console.WriteLine(samsungClient.GetNormalPhoneModelDetails());

                Console.ReadKey();
            }


            Console.ReadKey();
            #endregion
        }
    }
}

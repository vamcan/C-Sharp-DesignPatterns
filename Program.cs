using System;
using DesignPatterns.AbstractFactory;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  Absstract Factory

            #region FirstSample
            //IMobilePhone nokiaMobilePhone = new Nokia();
            //MobileClient nokiaClient = new MobileClient(nokiaMobilePhone);

            //Console.WriteLine("********* NOKIA **********");
            //Console.WriteLine(nokiaClient.GetSmartPhoneModelDetails());
            //Console.WriteLine(nokiaClient.GetNormalPhoneModelDetails());

            //IMobilePhone samsungMobilePhone = new Samsung();
            //MobileClient samsungClient = new MobileClient(samsungMobilePhone);

            //Console.WriteLine("******* SAMSUNG **********");
            //Console.WriteLine(samsungClient.GetSmartPhoneModelDetails());
            //Console.WriteLine(samsungClient.GetNormalPhoneModelDetails());



            #endregion

            #region SecondSample WebinarPlatform
            IWebinarPlatform bbbPlatform = new BigBlueButton();
            WebinarPlatformClient bbbClient = new WebinarPlatformClient(bbbPlatform);

            Console.WriteLine("********* bbb **********");
            Console.WriteLine(bbbClient.JoinWebinar());
            Console.WriteLine(bbbClient.StartAsAttender());
            Console.WriteLine(bbbClient.StartAsManager());
            Console.WriteLine(bbbClient.GetRecords());

            IWebinarPlatform skyRoomPlatform = new SkyRoom();
            WebinarPlatformClient skyRoomClient = new WebinarPlatformClient(skyRoomPlatform);

            Console.WriteLine("******* sky room **********");
            Console.WriteLine(skyRoomClient.JoinWebinar());
            Console.WriteLine(skyRoomClient.StartAsAttender());
            Console.WriteLine(skyRoomClient.StartAsManager());
            Console.WriteLine(skyRoomClient.GetRecords());

            #endregion

            Console.ReadKey();
            #endregion
        }
    }
}

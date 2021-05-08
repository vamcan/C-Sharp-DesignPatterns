using System;
using DesignPatterns.AbstractFactory;
using DesignPatterns.State;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  Absstract Factory Pattern

            //#region FirstSample
            ////IMobilePhone nokiaMobilePhone = new Nokia();
            ////MobileClient nokiaClient = new MobileClient(nokiaMobilePhone);

            ////Console.WriteLine("********* NOKIA **********");
            ////Console.WriteLine(nokiaClient.GetSmartPhoneModelDetails());
            ////Console.WriteLine(nokiaClient.GetNormalPhoneModelDetails());

            ////IMobilePhone samsungMobilePhone = new Samsung();
            ////MobileClient samsungClient = new MobileClient(samsungMobilePhone);

            ////Console.WriteLine("******* SAMSUNG **********");
            ////Console.WriteLine(samsungClient.GetSmartPhoneModelDetails());
            ////Console.WriteLine(samsungClient.GetNormalPhoneModelDetails());



            //#endregion

            //#region SecondSample WebinarPlatform
            //IWebinarPlatform bbbPlatform = new BigBlueButton();
            //WebinarPlatformClient bbbClient = new WebinarPlatformClient(bbbPlatform);

            //Console.WriteLine("********* bbb **********");
            //Console.WriteLine(bbbClient.JoinWebinar()); 
            //Console.WriteLine(bbbClient.StartAsAttender());
            //Console.WriteLine(bbbClient.StartAsManager());
            //Console.WriteLine(bbbClient.GetRecords());

            //IWebinarPlatform skyRoomPlatform = new SkyRoom();
            //WebinarPlatformClient skyRoomClient = new WebinarPlatformClient(skyRoomPlatform);

            //Console.WriteLine("******* sky room **********");
            //Console.WriteLine(skyRoomClient.JoinWebinar());
            //Console.WriteLine(skyRoomClient.StartAsAttender());
            //Console.WriteLine(skyRoomClient.StartAsManager());
            //Console.WriteLine(skyRoomClient.GetRecords());

            //#endregion
            #endregion

            #region State Pattern

            #region FirstSample
            // Setup context in a state

            //Context c = new Context(new ConcreteStateA());

            //// Issue requests, which toggles state

            //c.Request();
            //c.Request();
            //c.Request();
            //c.Request();


            #endregion

            #region BankSample

            // Open a new account

            Account account = new Account("Jim Johnson");

            // Apply financial transactions

            account.Deposit(500.0);
            account.Deposit(300.0);
            account.Deposit(550.0);
            account.PayInterest();
            account.Withdraw(2000.00);
            account.Withdraw(1100.00);

            #endregion
            #endregion



            Console.ReadKey();
        }
    }
}

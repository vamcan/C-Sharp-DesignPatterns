using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AbstractFactory
{

    interface IWebinarPlatform
    {
        public IJoinWebinar JoinWebinar();
        public IStartAsAttendar StartAsAttender();
        public IStartAsManager StartAsManager();
        public IGetRecords GetRecords();
    }


    class AdobeConnect : IWebinarPlatform
    {
        public IJoinWebinar JoinWebinar()
        {
            return new AdobeConnectJoinWebinar();
        }

        public IStartAsAttendar StartAsAttender()
        {
            return new AdobeConnectStartAsAttendar();
        }

        public IStartAsManager StartAsManager()
        {
            return new AdobeConnectStartAsManager();
        }

        public IGetRecords GetRecords()
        {
            return new AdobeConnectGetRecords();
        }
    }
    class BigBlueButton : IWebinarPlatform
    {
        public IJoinWebinar JoinWebinar()
        {
            return new BigBlueButtonJoinWebinar();
        }

        public IStartAsAttendar StartAsAttender()
        {
            return new BigBlueButtonStartAsAttendar();
        }

        public IStartAsManager StartAsManager()
        {
            return new BigBlueButtonStartAsManager();
        }

        public IGetRecords GetRecords()
        {
            return new BigBlueButtonGetRecords();
        }
    }
    class SkyRoom : IWebinarPlatform
    {
        public IJoinWebinar JoinWebinar()
        {
            return new SkyRoomJoinWebinar();
        }

        public IStartAsAttendar StartAsAttender()
        {
            return new SkyRoomStartAsAttendar();
        }

        public IStartAsManager StartAsManager()
        {
            return new SkyRoomStartAsManager();
        }

        public IGetRecords GetRecords()
        {
            return new SkyRoomGetRecords();
        }
    }

    

    interface IJoinWebinar
    {
        string Execute();
    }
    interface IStartAsManager
    {
        string Execute();
    }
    interface IStartAsAttendar
    {
        string Execute();
    }
    interface IGetRecords
    {
        string Execute();
    }


    class BigBlueButtonJoinWebinar : IJoinWebinar
    {
        public string Execute()
        {
            return "BigBlueButtonJoinWebinar";
        }
    }
    class SkyRoomJoinWebinar : IJoinWebinar
    {
        public string Execute()
        {
            return "SkyRoomJoinWebinar";
        }
    }
    class AdobeConnectJoinWebinar : IJoinWebinar
    {
        public string Execute()
        {
            return "AdobeConnectJoinWebinar";
        }
    }


    class BigBlueButtonStartAsManager : IStartAsManager
    {
        public string Execute()
        {
            return "BigBlueButtonStartAsManager";
        }
    }
    class SkyRoomStartAsManager : IStartAsManager
    {
        public string Execute()
        {
            return "SkyRoomStartAsManager";
        }
    }
    class AdobeConnectStartAsManager : IStartAsManager
    {
        public string Execute()
        {
            return "AdobeConnectStartAsManager";
        }
    }

    class SkyRoomStartAsAttendar : IStartAsAttendar
    {
        public string Execute()
        {
            return "SkyRoomStartAsAttendar";
        }
    }
    class BigBlueButtonStartAsAttendar : IStartAsAttendar
    {
        public string Execute()
        {
            return "BigBlueButtonStartAsAttendar";
        }
    }
    class AdobeConnectStartAsAttendar : IStartAsAttendar
    {
        public string Execute()
        {
            return "AdobeConnectStartAsAttendar";
        }
    }

    class BigBlueButtonGetRecords : IGetRecords
    {
        public string Execute()
        {
            return "BigBlueButtonGetRecords";
        }
    }
    class SkyRoomGetRecords : IGetRecords
    {
        public string Execute()
        {
            return "SkyRoomGetRecords";
        }
    }
    class AdobeConnectGetRecords : IGetRecords
    {
        public string Execute()
        {
            return "AdobeConnectGetRecords";
        }
    }

    class WebinarPlatformClient
    {
        private IJoinWebinar joinWebinar;
        private IStartAsManager startAsManager;
        private IStartAsAttendar startAsAttendar;
        private IGetRecords getRecords;

        public WebinarPlatformClient(IWebinarPlatform factory)
        {
            joinWebinar = factory.JoinWebinar();
            startAsManager = factory.StartAsManager();
            startAsAttendar = factory.StartAsAttender();
            getRecords = factory.GetRecords();
        }

        public string JoinWebinar()
        {
            return joinWebinar.Execute();
        }
        public string StartAsManager()
        {
            return startAsManager.Execute();
        }
        public string StartAsAttender()
        {
            return startAsAttendar.Execute();
        }
        public string GetRecords()
        {
            return getRecords.Execute();
        }


    }
}

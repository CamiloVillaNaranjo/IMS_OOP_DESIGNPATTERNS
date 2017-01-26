using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.StupidCode.StrongCoupling
{
    public class RemoteControl
    {
        private Television tv { get; set; }

        protected RemoteControl()
        {
            tv = new Television();
        }

        static RemoteControl()
        {
            _remoteController = new RemoteControl();
        }
        static RemoteControl _remoteController;
        public static RemoteControl control
        {
            get
            {
                return _remoteController;
            }
        }

        public void PowerOnTv (){
            tv.PowerOn();
        }

    }

}

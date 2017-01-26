using IMS.StupidCode.StrongCoupling;
using System;

namespace IMS.StupidCode.IMS.StupidParadigm
{
    public class Proof
    {
        private static void Main(string[] args)
        {
            SessionData obj1 = SessionData.getInstance;
            SessionData obj2 = SessionData.getInstance;

            Console.WriteLine("obj1 & obj2 are {0}", obj1 == obj2 ? "equals" : "differents");
            Console.ReadKey();

            var remote = RemoteControl.control;
            Console.WriteLine("Power On button of Remote Control was clicked");
            remote.PowerOnTv();

        }
    }
}

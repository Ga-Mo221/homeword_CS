using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_interface
{
    internal class CAT : ANIMAL, ISPEECH, ISLEEP, IEAT, IDOSOMETHING
    {
        private String Type;

        public CAT() : base() { }

        public CAT(string name, string type) : base(name)
        {
            this.Type = type;
        }

        public void RUN()
        {
            Console.WriteLine(base.NAME + " chay...");
        }
        public void MOVE()
        {
            Console.WriteLine(base.NAME + " di...");
        }
        public void HUNT()
        {
            Console.WriteLine(base.NAME + " bat em...");
        }
        public void SPEECH()
        {
            Console.WriteLine(base.NAME + " keu: Meo meo meo");
        }
        public void SLEEP()
        {
            Console.WriteLine(base.NAME + " ngu...");
        }
        public void EAT()
        {
            Console.WriteLine(base.NAME + " an...");
        }
        public void DOSOMETHING()
        {
            Console.WriteLine("lu..lu");
        }

        public void XUAT()
        {
            Console.WriteLine("ANIMAL NAME: {0}", base.NAME);
            Console.WriteLine("ANIMAL TYPE: {0}", this.Type);
        }
    }
}

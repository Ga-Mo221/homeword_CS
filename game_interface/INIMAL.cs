using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game_interface
{
    internal interface IRUN
    {
        void RUN();
    }
    internal interface IMOVE
    {
        void MOVE();
    }
    internal interface IHUNT
    {
        void HUNT();
    }
    internal interface IFLY
    {
        void FLY();
    }
    internal interface IEAT
    {
        void EAT();
    }
    internal interface ISLEEP
    {
        void SLEEP();
    }
    internal interface ISEACH
    {
        void SEACH();
    }
    internal interface ISPEECH
    {
        void SPEECH();
    }
    interface IDOSOMETHING:IRUN, IMOVE, IHUNT
    {
        void DOSOMETHING();
    }
}

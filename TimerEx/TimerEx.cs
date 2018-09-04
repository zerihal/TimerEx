using System.Timers;

namespace TimerEx
{
    public class TimerEx : Timer
    {
        public TimerEx(int v)
        {
            Interval = v;
        }

        public void Restart()
        {
            Stop();
            Start();
        }

        public int? GetTicks()
        {
            return null;
        }
    }

}

using System.Timers;

namespace TimerEx
{
    public class TimerEx : Timer
    {
        #region Construction
        /// <summary>
        /// Creates an instance of TimerEx with the specified interval.
        /// </summary>
        /// <param name="v">The interval in milliseconds until elapsed</param>
        public TimerEx(int v)
        {
            Interval = v;
        }
        #endregion

        #region Public methods
        /// <summary>
        /// Restarts the instance of TimerEx.
        /// </summary>
        public void Restart()
        {
            Stop();
            Start();
        }

        /// <summary>
        /// Returns the number of ticks (times that the TimerEx has elapsed) since it was created.
        /// </summary>
        /// <returns>Number of ticks or null</returns>
        public int? GetTicks()
        {
            return null;
        }
        #endregion
    }

}

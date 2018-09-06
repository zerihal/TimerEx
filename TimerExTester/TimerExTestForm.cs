using System;
using System.Windows.Forms;

namespace TimerEx
{
    public partial class TimerExTestForm : Form
    {
        #region Fields
        private TimerEx _extTimer;
        #endregion

        #region Construction
        /// <summary>
        /// Constructor for new instance of the extended timer test form.
        /// </summary>
        public TimerExTestForm()
        {
            InitializeComponent();
            _extTimer = new TimerEx(3000);
            updateUI("Stopped");

            if (_extTimer != null)
                _extTimer.Elapsed += _extTimer_Elapsed;
            else
                MessageBox.Show("Error: TimerEx has returned null", "TimerEx Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Private
        #region Events
        /// <summary>
        /// Updates the total number of ticks that the instance of TimerEx has performed
        /// since it was created.
        /// </summary>
        private void _extTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {       
            Invoke(new Action(() => ticksBox.Text = _extTimer?.GetTicks().ToString()));
        }

        /// <summary>
        /// Closes the test form.
        /// </summary>
        private void closeButton_Click(object sender, System.EventArgs e)
        {
            _extTimer?.Dispose();
            Close();
        }

        /// <summary>
        /// Starts the instance of TimerEx and updates the UI.
        /// </summary>
        private void startButton_Click(object sender, System.EventArgs e)
        {
            _extTimer?.Start();
            updateUI("Running");
        }

        /// <summary>
        /// Stops the instance of TimerEx and updates the UI.
        /// </summary>
        private void stopButton_Click(object sender, System.EventArgs e)
        {
            _extTimer?.Stop();
            updateUI("Stopped");
        }

        /// <summary>
        /// Resets the instance of TimerEx (whether running or not) and updates the UI.
        /// </summary>
        private void resetButton_Click(object sender, System.EventArgs e)
        {
            _extTimer?.Restart();
            updateUI("Running");
        }
        #endregion

        #region Methods
        /// <summary>
        /// Updates the status and ticks text boxes on the UI.
        /// </summary>
        /// <param name="state">The updated status to show in the status text box</param>
        private void updateUI(string state)
        {
            statBox.Text = state != string.Empty ? state : "Null";
            ticksBox.Text = _extTimer?.GetTicks().ToString();
        }
        #endregion
        #endregion
    }
}

using CSV_compare.Loading;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace CSV_compare
{
    public class PleaseWait : IDisposable
    {
        private readonly Form mSplash = new LoadingScreen();
        private Point mLocation;

        public PleaseWait(Point location)
        {
            mLocation = location;
            Thread t = new Thread(new ThreadStart(WorkerThread))
            {
                IsBackground = true
            };
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        public void Dispose()
        {
            mSplash.Invoke(new MethodInvoker(StopThread));
        }

        private void StopThread()
        {
            mSplash.Close();
        }

        private void WorkerThread()
        {
            mSplash.StartPosition = FormStartPosition.CenterScreen;
            mSplash.Location = mLocation;
            mSplash.TopMost = true;
            Application.Run(mSplash);
        }
    }
}
using CSV_compare.Loading;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace CSV_compare
{

    public class PleaseWait : IDisposable
    {
        private Form mSplash = new LoadingScreen();
        private Point mLocation;

        public PleaseWait(Point location)
        {
            mLocation = location;
            Thread t = new Thread(new ThreadStart(workerThread));
            t.IsBackground = true;
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
        }

        public void Dispose()
        {

            mSplash.Invoke(new MethodInvoker(stopThread));

        }
        private void stopThread()
        {
            mSplash.Close();
        }
        private void workerThread()
        {
            mSplash.StartPosition = FormStartPosition.CenterScreen;
            mSplash.Location = mLocation;
            mSplash.TopMost = true;
            Application.Run(mSplash);
        }
    }
}

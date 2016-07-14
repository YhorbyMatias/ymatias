using System;
using System.Threading;
using System.ComponentModel;

namespace ConsoleApplication1
{
    class Program
    {

        static BackgroundWorker _bw;

        static void Main()
        {
            _bw = new BackgroundWorker
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true
            };
            _bw.DoWork += bw_DoWork;
            _bw.ProgressChanged += bw_ProgressChanged;
            _bw.RunWorkerCompleted += bw_RunWorkerCompleted;

            _bw.RunWorkerAsync("Hola Programador");

            Console.WriteLine("Presiona enter en los proximo 5 segundos para  cancelar");
            Console.ReadLine();
            if (_bw.IsBusy) _bw.CancelAsync();
            Console.ReadLine();
        }

        static void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i += 20)
            {
                if (_bw.CancellationPending) { e.Cancel = true; return; }
                _bw.ReportProgress(i);
                Thread.Sleep(1000);      // Solo por demo...no ira a dormir
            }                         

            e.Result = 123;    //  RunWorkerCompleted
        }

        static void bw_RunWorkerCompleted(object sender,
                                           RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
                Console.WriteLine("Has  cancelado!");
            else if (e.Error != null)
                Console.WriteLine("Error: " + e.Error.ToString());
            else
                Console.WriteLine("Completo: " + e.Result);      // desde DoWork
        }

        static void bw_ProgressChanged(object sender,
                                        ProgressChangedEventArgs e)
        {
            Console.WriteLine("Cargado " + e.ProgressPercentage + "%");
        }
    }
}

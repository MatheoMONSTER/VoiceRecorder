using System;
using System.Windows;
using System.Windows.Threading;
using NAudio.Wave;

namespace VoiceRecorder
{
    public partial class MainWindow : Window
    {
        private WaveIn waveIn;
        private WaveFileWriter writer;
        private string outputFilePath;
        private DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += Timer_Tick; 
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (waveIn != null && writer != null)
            {
                var progress = (int)(writer.Length / (double)(waveIn.WaveFormat.AverageBytesPerSecond) * 100);
                progressBar.Value = progress;
            }
        }

        private void btnRecord_Click(object sender, RoutedEventArgs e)
        {
            if(waveIn == null)
            {
                waveIn = new WaveIn();
                waveIn.DataAvailable += WaveIn_DataAvailable;
                waveIn.WaveFormat = new WaveFormat(44100, 1); 
            }

            if (writer == null)
            {
                outputFilePath = $"recording_{DateTime.Now:yyyyMMddHHmmss}.wav";
                writer = new WaveFileWriter(outputFilePath, waveIn.WaveFormat);
            }
            waveIn.StartRecording();
            timer.Start();
            btnRecord.IsEnabled = false;
            btnStop.IsEnabled = true;
        }

        private void WaveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (writer != null)
            {
                writer.Write(e.Buffer, 0, e.BytesRecorded); 
                writer.Flush();
            }
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            if (waveIn != null)
            {
                waveIn.StopRecording();
                waveIn.Dispose();
                waveIn = null;
            }

            if (writer != null)
            {
                writer.Dispose();
                writer = null;
            }

            timer.Stop();
            progressBar.Value = 0;
            btnRecord.IsEnabled = true;
            btnStop.IsEnabled = false;
            MessageBox.Show("Recording finished. File saved: " + outputFilePath);
        }
    }
}

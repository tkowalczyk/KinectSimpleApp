using Microsoft.Kinect;
using System;
using System.Windows;

namespace KinectSimpleApp
{
    public partial class MainWindow : Window
    {
        KinectSensor _sensor;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (KinectSensor.KinectSensors.Count > 0)
            {
                _sensor = KinectSensor.KinectSensors[0];

                if (_sensor.Status == KinectStatus.Connected)
                {
                    _sensor.ColorStream.Enable();
                    _sensor.DepthStream.Enable();
                    _sensor.SkeletonStream.Enable();
                    _sensor.AllFramesReady += new EventHandler<AllFramesReadyEventArgs>(_sensor_AllFramesReady);
                    _sensor.Start();

                    tbStatus.Text = "Kinect Connected";
                }
            }
            else
            {
                tbStatus.Text = "No Kinect";
            }
        }

        private void _sensor_AllFramesReady(object sender, AllFramesReadyEventArgs e)
        {
            
        }
        void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (_sensor != null)
            {
                _sensor.Stop();
            }
        }
    }
}
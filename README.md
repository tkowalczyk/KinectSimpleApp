#KinectSimpleApp#


This simple application shows how to properly use [Kinect for Windows SDK](http://www.microsoft.com/en-us/kinectforwindows/ "Kinect for Windows SDK") in the WPF.

**How does it work?**

Declare sensor object:

`KinectSensor _sensor;`

Check connected device:

`KinectSensor.KinectSensors.Count > 0`

Assign first connected:

`_sensor = KinectSensor.KinectSensors[0]`

 and if 

`_sensor.Status == KinectStatus.Connected`

enable streams:

`sensor.ColorStream.Enable();`

`_sensor.DepthStream.Enable();`

`_sensor.SkeletonStream.Enable();`

And at the end if windows is closing, stop the sensor:

`_sensor.Stop();`

**More examples**

Feel free to visit my homepage [Tomasz Kowalczyk](http://tomek.kownet.info/ "Tomasz Kowalczyk") to see more complex examples.
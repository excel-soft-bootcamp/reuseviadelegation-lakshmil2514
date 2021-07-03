using System;

namespace SmartPhoneProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Camera cameraDevice = new Camera();
            GPS gpsDevice = new GPS();
            Phone phoneDevice = new Phone();

            SmartPhone _smartPhone = new SmartPhone();
            _smartPhone.SetCamera(cameraDevice);
            _smartPhone.SetGPS(gpsDevice);
            _smartPhone.SetPhone(phoneDevice);

            Photographer _photographer = new Photographer();
            _photographer.Capture(_smartPhone);
            _photographer.Capture(cameraDevice);

            Traveller _traveller = new Traveller();
            _traveller.Hike(_smartPhone);
            _traveller.Hike(gpsDevice);

            Person _person = new Person();
            _person.Communicate(_smartPhone);
            _person.Communicate(phoneDevice);
        }
    }
}

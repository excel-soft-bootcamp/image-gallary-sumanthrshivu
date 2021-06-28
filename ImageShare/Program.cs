using System;

namespace ImageShare
{
    class Program
    {
        public static void Main()
        {
            Gmail _mailAccount = new Gmail();
            ImageGallery _gamil = new ImageGallery(_mailAccount);
            _gamil.Share();

            Bluetooth _blueToothDevice = new Bluetooth();
            ImageGallery _bluetooth = new ImageGallery(_blueToothDevice);
            _bluetooth.Share();
          
            WhatsUp _messanger = new WhatsUp();
            ImageGallery _whatsUp = new ImageGallery(_messanger);
            _whatsUp.Share();

        }
    }
}

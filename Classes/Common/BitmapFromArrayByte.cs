using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Media.Imaging;

namespace ChatStudents_Bartova.Classes.Common
{
    public class BitmapFromArrayByte
    {
        public static BitmapImage LoadImage(byte[] imageData)
        {
            BitmapImage Image = new BitmapImage();
            using(var Steam = new MemoryStream(imageData))
            {
                Steam.Position = 0;
                Image.BeginInit();
                Image.CreateOptions = BitmapCreateOptions.PreservePixelFormat;
                Image.CacheOption = BitmapCacheOption.OnLoad;
                Image.UriSource= null;
                Image.StreamSource= Steam;
                Image.EndInit();
            }
            Image.Freeze();
            return Image;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;

namespace Executable.Classes
{
    class ImageByteConverter
    {
        public static byte[] ImageToBytes(Image image)
        {
            var memoryStream = new MemoryStream();
            image.Save(memoryStream, ImageFormat.Png);
            return memoryStream.ToArray();
        }

        public static Image BytesToImage(byte[] bytes)
        {
            var memoryStream = new MemoryStream(bytes);
            return Image.FromStream(memoryStream);
        }
    }
}

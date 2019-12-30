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
        /// <summary>
        /// Converts Type Image into Type byte[]
        /// </summary>
        /// <param name="image">Image input</param>
        /// <returns>Byte Array as byte[]</returns>
        public static byte[] ImageToBytes(Image image)
        {
            if(image == null)
            {
                return null;
            }
            //Create MemoryStream and initialize
            var memoryStream = new MemoryStream();
            //Save Image into memoryStream
            image.Save(memoryStream, ImageFormat.Png);
            //Return memoryStream Conversion into Array 
            return memoryStream.ToArray();
        }
        /// <summary>
        /// Converts Type byte[] into Type Image
        /// </summary>
        /// <param name="bytes">ByteArray input</param>
        /// <returns>Image</returns>
        public static Image BytesToImage(byte[] bytes)
        {
            // Saves bytes into MemoryStream
            var memoryStream = new MemoryStream(bytes);
            //Returns memoryStream as Image
            return Image.FromStream(memoryStream);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace DRSoftware_lib.Manager
{
    public class Helper
    {
        public static string CNString = "";

        public static Image GetURLofImageofName(string Name)
        {

            string URLName = Name.Replace(" ", "+");
            string URL = "https://ui-avatars.com/api/?color=fff&background=random&size=40&length=2&rounded=true&bold=false&name=" + URLName;

            WebRequest request = WebRequest.Create(URL);
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            Image image = Image.FromStream(stream);
            return image;
        }


        public static Image ConvertToImage(byte[] binary)
        {
            byte[] buffer = binary.ToArray();
            MemoryStream ms = new MemoryStream(buffer);
            Image image = Image.FromStream(ms);
            return image;
        }
        public static System.Drawing.Image BinaryToImage(byte[] b)
        {
            if (b == null)
                return null;
            using (MemoryStream ms = new MemoryStream(b, 0, b.Length))
            {
                ms.Write(b, 0, b.Length);
                
                System.Drawing.Image newImage = System.Drawing.Image.FromStream(ms);
                return newImage;
            }
        }


    }
}

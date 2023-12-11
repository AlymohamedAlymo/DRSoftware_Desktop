using System.Drawing;
using System.IO;
using System.Net;

namespace DRSoftware_lib.Manager
{
    public class ImageHelper
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


        public static Image ConvertBinaryToImage(byte[] BinaryImg)
        {
            try
            {
                if (BinaryImg == null) { return Image.FromFile("C:\\Users\\alimo\\Desktop\\New folder (4)\\New folder (2)\\message_20.png"); }
                MemoryStream ms = new MemoryStream(BinaryImg);
                Image img = Image.FromStream(ms);
                return img;

            }
            catch { return Image.FromFile("C:\\Users\\alimo\\Desktop\\New folder (4)\\New folder (2)\\message_20.png"); }
        }


        public static byte[] ConvertImageToBinary(Image BitmapImg)
        {
            if (BitmapImg == null) { return null; }
            MemoryStream stream = new MemoryStream();
            Image img = null;
            img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            byte[] BinaryImg = stream.ToArray();
            return BinaryImg;
        }



    }
}

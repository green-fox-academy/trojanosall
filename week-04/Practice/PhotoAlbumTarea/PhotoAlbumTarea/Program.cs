using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoAlbumTarea
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAlbum1 = new PhotoAlbum();
            Console.WriteLine(myAlbum1.GetNumberOfPages());

            var  myAlbum2 = new PhotoAlbum(24);
            Console.WriteLine(myAlbum2.GetNumberOfPages());

            var myAlbum3 = new BigPhotoAlbum();
            Console.WriteLine(myAlbum3.GetNumberOfPages());

            Console.ReadKey();
        }
    }
}

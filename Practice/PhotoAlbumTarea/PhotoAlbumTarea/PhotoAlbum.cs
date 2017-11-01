using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoAlbumTarea
{
    class PhotoAlbum
    {
        protected int numberOfPages;

        public PhotoAlbum()
        {
            this.numberOfPages = 16;
        }

        public PhotoAlbum(int numberOfPages)
        {
            this.numberOfPages = numberOfPages;
        }

        public int GetNumberOfPages()
        {
            return numberOfPages;
        }
    }
}

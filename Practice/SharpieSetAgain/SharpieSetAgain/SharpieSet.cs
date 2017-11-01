using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpieSetAgain
{
    class SharpieSet
    {
        public List<Sharpie> SharpieList = new List<Sharpie>();

        public SharpieSet(List<Sharpie> SharpieList)
        {
            List<Sharpie> SharpiesList = SharpieList;
        }

        public void CountUsable(List<Sharpie> SharpieList)
        {
            for (int i = 0; i < SharpieList.Count; i++)
            {
                if (SharpieList[i].GetInkAmount() > 0)
                {
                    SharpieList[i].SetUsable(true);
                }
            }
        }

        public List<Sharpie> RemoveTrash(List<Sharpie> SharpieList)
        {
            for (int i = 0; i < SharpieList.Count; i++)
            {
                if (SharpieList[i].GetUsable() == false)
                {
                    SharpieList.RemoveAt(i);
                }
            }
            return SharpieList;
        }

        public void PrintOutSharpieList(List<Sharpie> SharpieList)
        {
            foreach (Sharpie sharpie in SharpieList)
            {
                Console.WriteLine(sharpie.Name);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpieSet
{
    class SharpieSet
    {
        public List<Sharpie> sharpieList = new List<Sharpie>();

        public SharpieSet(List<Sharpie> sharpieList)
        {
            List<Sharpie> sharpiesList = sharpieList;
        }

        public void CountUsable(List<Sharpie> sharpielist)
        {
            for (int i = 0; i < sharpieList.Count; i++)
            {
                if (sharpieList[i].GetInkAmount() > 0)
                {
                    sharpieList[i].SetUsable(true);
                }
            }
        }
        public List<Sharpie> RemoveTrash(List<Sharpie> sharpieList)
        {
            for (int i = 0; i < sharpieList.Count; i++)
            {
                if (sharpieList[i].GetUsable() == false)
                {
                    sharpieList.RemoveAt(i);
                }
            }
            return sharpieList;
        }
        public void PrintOutSharpieList(List<Sharpie> sharpieList)
        {
            foreach (Sharpie sharpie in sharpieList)
            {
                Console.WriteLine(sharpie.Name());
            }
        }
    }
}

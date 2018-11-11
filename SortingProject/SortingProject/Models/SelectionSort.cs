using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SortingProject.Models
{
    public class SelectionSort
    {
        public int Size { get; set; }

        public List<Numbers> OnePass(List<Numbers> list, int currentIndex)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i].Changed = false;

            }
            Numbers temp;
            int minIndex = currentIndex;
            int minValue = list[currentIndex].Value;
            for (int i = minIndex + 1; i < list.Count; i++)
            {
                if (list[i].Value < minValue)
                {
                    minValue = list[i].Value;
                    minIndex = i;
                }
            }

            temp = list[currentIndex];
            list[currentIndex] = list[minIndex];
            list[minIndex] = temp;

            list[currentIndex].Changed = true;
            list[minIndex].Changed = true;

            return list;
        }
        public bool CheckList(List<Numbers> list)
        {
            bool isDone = true;
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i].Value > list[i + 1].Value)
                {
                    isDone = false;
                    break;
                }
            }
            return isDone;
        }

    }
}
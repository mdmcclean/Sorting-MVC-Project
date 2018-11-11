using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SortingProject.Models
{
    public class BubbleSort
    {
        
        public List<Numbers> Sort(List<Numbers> list)
        {
            bool swap;
            Numbers temp;

            do
            {
                swap = false;
                for(int i = 0; i < list.Count - 1; i++)
                {
                    if (list[i].Value > list[i + 1].Value)
                    {
                        temp = list[i];
                        list[i] = list[i + 1];
                        list[i + 1] = temp;
                        list[i].Changed = true;
                        list[i + 1].Changed = true;
                        swap = true;
                    }
                }
                
            } while (swap);

            return list;
        }
        public List<Numbers> OnePass(List<Numbers> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i].Changed = false;
               
            }
            Numbers temp;
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i].Value > list[i + 1].Value)
                {
                    temp = list[i];
                    list[i] = list[i + 1];
                    list[i + 1] = temp;
                    list[i].Changed = true;
                    list[i + 1].Changed = true;
                }
            }

            return list;
        }
        public bool CheckList(List<Numbers> list)
        {
            bool isDone = true;
            for (int i = 0; i < list.Count-1; i++)
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
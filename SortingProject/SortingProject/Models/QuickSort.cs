using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SortingProject.Models
{
    public class QuickSort
    {
        public List<List<Numbers>> ListOfPassThroughs { get; set; }
        Dictionary<string, List<Numbers>> variable;
        public QuickSort()
        {
            variable = new Dictionary<string, List<Numbers>>();
            ListOfPassThroughs = new List<List<Numbers>>();
        }
        public List<Numbers> Sort(List<Numbers> list, int first, int last)
        {
            foreach(Numbers num in list)
            {
                num.Changed = false;
            }
            if (first < last)
            {
                int partition = Partition(list, first, last);
                Sort(list, first, partition - 1);
                Sort(list, partition + 1, last);
                
            }
            return list;
        }

        public int Partition(List<Numbers> list, int first, int last)
        {
            int pivotValue = list[first].Value;
            int pivotPostion = first;

            

            for(int i = first + 1; i <= last; i++)
            {
                if(list[i].Value < pivotValue)
                {
                    Numbers temp = list[pivotPostion + 1];
                    list[pivotPostion + 1] = list[i];
                    list[i] = temp;
                    temp = list[pivotPostion + 1];
                    list[pivotPostion + 1] = list[pivotPostion];
                    list[pivotPostion] = temp;

                    list[i].Changed = true;
                    list[pivotPostion].Changed = true;
                    list[pivotPostion + 1].Changed = true;
                    pivotPostion++;

                }
            }

            
            ListOfPassThroughs.Add(CloneList(list));
            return pivotPostion;
        }
        public List<Numbers> CloneList(List<Numbers> list)
        {
            List<Numbers> clonedList = new List<Numbers>();
            
            foreach(Numbers num in list)
            {
                clonedList.Add(num);
            }
            return clonedList;
        }
    }
}
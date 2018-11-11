using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SortingProject.Models
{
    public class RandomizeList
    {
        [Required]
        public int Count { get; set; }

        public List<Numbers> Randomize()
        {
            List<Numbers> randomList = new List<Numbers>();
            Random rand = new Random();
            for(int i = 0; i < Count; i++)
            {
                randomList.Add(new Numbers { Value = rand.Next(100) });                
            }

            return randomList;
        }
    }
}
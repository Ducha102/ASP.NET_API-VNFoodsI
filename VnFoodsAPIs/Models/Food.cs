using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VnFoodsAPIs.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string enName { get; set; }
        public string vnName { get; set; }
        public int Price { get; set; }
        public string descibe { get; set; }
        public string making { get; set; }
        public string category { get; set; }
        public string  area { get; set; }
        public string picPath { get; set; }

        public Food() {  }

        public Food(string enName, string vnName, int price, string describe, string making, string category, string area, string picturePath)
        {
            this.enName = enName;
            this.vnName = vnName;
            this.Price = price;
            this.descibe = descibe;
            this.making = making;
            this.category = category;
            this.area = area;
            this.picPath = picPath;
        } 

    }
}
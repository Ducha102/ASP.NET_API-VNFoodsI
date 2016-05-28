using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VnFoodsAPIs.Models;
using VnFoodsAPIs.DataHelper;
using System.Data;

namespace VnFoodsAPIs.DataHelper
{
    public class InitFoodData
    {

        //Get all Foods
        public static List<Food> AllFood ()
        {
            List<Food> foodlist = new List<Food>();
             DataSet dts = FoodDataHeplers.ExecutedSelect("tbFoods");
            for (int i = 0; i < dts.Tables["tbFoods"].Rows.Count; i++)
            {
                foodlist.Add(new Food(dts.Tables[0].Rows[i][1].ToString(), 
                                      dts.Tables[0].Rows[i][2].ToString(), 
                                      Convert.ToInt16(dts.Tables[0].Rows[i][3].ToString()), 
                                      dts.Tables[0].Rows[i][4].ToString(),
                                      dts.Tables[0].Rows[i][5].ToString(),
                                      dts.Tables[0].Rows[i][6].ToString(),
                                      dts.Tables[0].Rows[i][7].ToString(),
                                      dts.Tables[0].Rows[i][8].ToString()
                                       ));
            }
            return foodlist;
        }

        //Insert a new food
        public static void InsertNewFood(Food food)
        {
            string insertcmd = "insert into tbFoods values ('"+food.enName+"', '"+food.vnName+"', "+food.Price+", '"+food.descibe+"', '"+food.making+"', '"+food.category+"', '"+food.area+"', '"+food.picPath+"')";
            int rows = FoodDataHeplers.ExecutedUID(insertcmd);
        }

        //Update a food (exist)
        public static void  UpdateFood(int id ,Food food)
        {
            string updatecmd = "update tbFoods set fnameUs='"+food.enName+"', fnameVn='"+food.vnName+"', price="+food.Price+", '"+food.descibe+"', '"+food.making+"', '"+food.category+"', '"+food.area+"', '"+food.picPath+"' where Id= "+id+"";
            int rows = FoodDataHeplers.ExecutedUID(updatecmd);
        }


        //Delete api/VnFoods
        public static void DeleteFood(int id)
        {
            string deletecmd = "delete from tbFoods where Id="+id+"";
            int rows = FoodDataHeplers.ExecutedUID(deletecmd);
        }

    }
}
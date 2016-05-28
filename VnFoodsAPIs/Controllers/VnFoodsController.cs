using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VnFoodsAPIs.Models;
using VnFoodsAPIs.DataHelper;
namespace VnFoodsAPIs.Controllers
{
    public class VnFoodsController : ApiController
    {
        List<Food> foodlist = InitFoodData.AllFood();
        public VnFoodsController() {
            
        }
        //GET api/VnFoods
        public IEnumerable<Food> Get()
        {
            return foodlist;
        }

        //GET api/VnFoods?enName=value
        public IEnumerable<Food> Get(string EnName)
        {
            return foodlist.Where(f => f.enName == EnName);
        }

        
        //POST - api/VnFoods
        public HttpResponseMessage Post([FromBody] Food food)
        {
            InitFoodData.InsertNewFood(food);
            var response = Request.CreateResponse(HttpStatusCode.Created, food);
            return response;
        }

        //PUT api/VnFoods/id
        public void Put (int id,[FromBody] Food food)
        {
            InitFoodData.UpdateFood(id, food);
        }

        //DELETE api/VnFoods/id
        public void Delete(int id)
        {
            InitFoodData.DeleteFood(id);
        }

    }
}

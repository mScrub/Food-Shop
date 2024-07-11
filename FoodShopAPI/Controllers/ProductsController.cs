
using Microsoft.AspNetCore.Mvc;


namespace FoodShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        [HttpGet]
        public string GetProducts()
        {
            return "test products";
        }

        [HttpGet("{id}")]
        public string GetProduct()
        {
            return "individual product";
        }


    }

}
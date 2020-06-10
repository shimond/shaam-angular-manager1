using ServerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ServerApp.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ProductsController : ApiController
    {

        static List<Product> list = new List<Product>();

        [HttpGet]
        public IHttpActionResult GetProducts()
        {
            return Ok(list.ToArray());
        }


        static ProductsController()
        {
            for (int i = 1; i < 10; i++)
            {
                list.Add(new Product(){ Id = i, Name = "Product NO." + i, Price = i * 10  });
            } 
        }



    }
}

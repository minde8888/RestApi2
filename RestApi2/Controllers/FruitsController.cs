using Microsoft.AspNetCore.Mvc;
using RestApi2.Models;
using RestApi2.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApi2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FruitsController : ItemsController<Fruits>
    {
        public FruitsController(IItemsService<Fruits> ItemsService) : base(ItemsService)
        {
        }
    }
}



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
    [Route("api/[controller]")]
    public class VegetableController : ItemsController<Vegetables>
    {
        public VegetableController(IItemsService<Vegetables> ItemsService) : base(ItemsService)
        {
        }
    }
}

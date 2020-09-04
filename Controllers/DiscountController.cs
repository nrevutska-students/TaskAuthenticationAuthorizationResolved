using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TaskAuthenticationAuthorization.Controllers
{
    public class DiscountController : Controller
    {
        [Authorize("BuyersWithDiscount")]
        public IActionResult Details()
        {
            return Content("Your discount is 5%");
        }
    }
}

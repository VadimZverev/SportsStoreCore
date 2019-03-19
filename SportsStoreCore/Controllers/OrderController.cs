using Microsoft.AspNetCore.Mvc;
using SportsStoreCore.Models;

namespace SportsStoreCore.Controllers
{
    public class OrderController : Controller
    {
        public ViewResult Checkout() => View(new Order());
    }
}

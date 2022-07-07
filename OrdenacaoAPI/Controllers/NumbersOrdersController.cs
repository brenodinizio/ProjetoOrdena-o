using Microsoft.AspNetCore.Mvc;
using OrdenacaoAPI.Models;
namespace OrdenacaoAPI.Controllers
{
    [ApiController]

    [Route("[controller]")]
    public class NumbersOrdersController : ControllerBase
    {
        [HttpGet]
        [Route("change")]

        public int[] change(int number1, int number2)
        {
            NumbersOrders numbers = new NumbersOrders();
            return numbers.Change(number1, number2);

        }

         [HttpGet]
        [Route("changenegative")]

        public int changenegative(int number)
        {
            NumbersOrders numbers = new NumbersOrders();
            return numbers.ChangeNegative(number);

        }
    }
}
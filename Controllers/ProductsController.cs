using AuthenticationAPIJWT.Data;
using AuthenticationAPIJWT.Dtos.Shared;
using AuthenticationAPIJWT.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationAPIJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        [HttpGet]
        [Authorize]
        public IActionResult Get()
        {
            List<Product> listProduct = DBContext.Products;

            return Ok(new HttpResponseDTO<Product>(200, "Request Success", listProduct));
        }
    }
}

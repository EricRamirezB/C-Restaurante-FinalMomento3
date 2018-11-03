using Restaurante.Api.Models;
using Restaurante.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Restaurante.Api.Controllers
{
    public class RestauranteController : ApiController
    {
        [HttpGet]
        public IEnumerable<Restauranteclase> Get()
        {
            using (RestauranteContext context = new RestauranteContext())
            {
                return context.Restaurantes.ToList();
            }

        }
    }
}

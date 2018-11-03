using Restaurante.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Restaurante.Api.Models
{
    public class RestauranteContext: DbContext
    {
        public RestauranteContext(): base("RestauranteConnection")
        {

        }

        public DbSet<Login> Logins { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Restauranteclase> Restaurantes { get; set; }
    }
}
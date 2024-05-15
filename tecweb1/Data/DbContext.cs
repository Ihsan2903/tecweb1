using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using tecweb1.Models;

    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext (DbContextOptions<DbContext> options)
            : base(options)
        {
        }

        public DbSet<tecweb1.Models.Producto> Producto { get; set; } = default!;

        public DbSet<tecweb1.Models.Cliente> Cliente { get; set; } = default!;

        public DbSet<Pedido> Pedidos { get; set; }
    }

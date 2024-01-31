using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace UserBanco.Models
    {
        public class BancoContext : DbContext
        {
            public BancoContext(DbContextOptions<BancoContext> options) : base(options)
            {
                
            }
        }
    }
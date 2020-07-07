using Demo.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.DataAccess.Interfaces
{
    public interface IDemoDbContext
    {
        public DbSet<CityModel> city { get; set; }
    }
}

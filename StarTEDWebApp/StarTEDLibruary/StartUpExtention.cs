using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StarTEDLibruary.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarTEDLibruary
{
    public static class StartUpExtention
    {
        public static void StarTEDStartUpDependencies(this IServiceCollection services, Action<DbContextOptionsBuilder> options)
        {
            services.AddDbContext<StarTEDContext>(options);
        }
    }
}

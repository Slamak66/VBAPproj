using VBAPproj.Data.Base;
using VBAPproj.Models;

namespace VBAPproj.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {

        }
    }
}

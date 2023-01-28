using Microsoft.EntityFrameworkCore;
using VBAPproj.Data.Base;
using VBAPproj.Models;

namespace VBAPproj.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        private readonly AppDbContext _context;

        public ActorsService(AppDbContext context) : base(context){ }

    }
}

using VBAPproj.Data.Base;
using VBAPproj.Models;

namespace VBAPproj.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context) 
        {
        
        }
    }
}

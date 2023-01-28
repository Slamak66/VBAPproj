using Microsoft.EntityFrameworkCore;
using VBAPproj.Data.Base;
using VBAPproj.Models;

namespace VBAPproj.Data.Services
{
    public interface IActorsService:IEntityBaseRepository<Actor>
    {
        
    }
}

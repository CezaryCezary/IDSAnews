using IDSAnews.Domain.Entities;
using System.Linq;

namespace IDSAnews.Domain.Interfaces
{
    public interface ICompanyRepository
    {
        IQueryable<Company> Companies { get; set; }
    }
}

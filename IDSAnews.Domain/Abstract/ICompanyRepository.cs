using IDSAnews.Domain.Entities;
using System.Linq;

namespace IDSAnews.Domain.Abstract
{
    public interface ICompanyRepository
    {
        IQueryable<Company> Companies { get; set; }
    }
}

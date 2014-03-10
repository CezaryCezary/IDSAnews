using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IDSAnews.Domain.Abstract;
using IDSAnews.Domain.Entities;

namespace IDSAnews.Domain
{
    public interface IModelContext
    {
        Repository<Company> Companies { get; set; }
        Repository<Information> Informations { get; set; }
    }
}

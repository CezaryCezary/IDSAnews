using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IDSAnews.Domain.Abstract;
using IDSAnews.Domain.Entities;

namespace IDSAnews.Domain
{
    public class Model : DbContext, IModelContext
    {
        public Repository<Company> Companies {get;set;}
        public Repository<Information> Informations { get; set; }

        public Model()
        {
            Companies = new Repository<Company>(this);
            Informations = new Repository<Information>(this);
        }
    }
}

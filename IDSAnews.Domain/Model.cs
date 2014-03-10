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
    public class Model : DbContext
    {
        public Repository<Company> Companies;
        public Repository<Information> Informations;

        public Model()
        {
            Companies = new Repository<Company>(this);
            Informations = new Repository<Information>(this);
        }
    }
}

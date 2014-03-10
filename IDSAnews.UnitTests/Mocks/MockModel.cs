using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using IDSAnews.Domain;
using IDSAnews.Domain.Abstract;
using IDSAnews.Domain.Entities;
using Moq;

namespace IDSAnews.UnitTests
{
    public class MockModel : IModelContext
    {
        public Repository<Company> Companies
        {
            get;
            set;
        }

        public Repository<Information> Informations
        {
            get;
            set;
        }

        public MockModel()
        {
            Mock<Repository<Company>> mockCompanies = new Mock<Repository<Company>>();

            mockCompanies.Setup(mc => mc.GetAll()).Returns(testCompanies);

            mockCompanies.Setup(mc => mc.GetById(It.IsAny<int>()))
                         .Returns((int i) => testCompanies().Where(c => c.Id == i).Single());
            // bind
            Companies = mockCompanies.Object;

            //Information Mock
            Mock<Repository<Information>> mockInformations = new Mock<Repository<Information>>();

            mockInformations.Setup(mi => mi.GetAll()).Returns(testInformations)
        }

        private IQueryable<Company> testCompanies()
        {
            IList<Company> test = new List<Company>();
            test.Add(new Company() { Id = 0, Name = "TestCmp", Shortcut = "TST" });
            test.Add(new Company() { Id = 1, Name = "NewCmp", Shortcut = "NEW" });
            test.Add(new Company() { Id = 2, Name = "BestCmp", Shortcut = "BST" });
            return test.AsQueryable();
        }

        private IQueryable<Information> testInformations()
        {
            IList<Information> test = new List<Information>();
            test.Add(new Information()
            {
                Date = DateTime.Now,
                Header = "This is test",
                Link = new Uri("http:\\www.pap.pl"),
                Text = "Some hot news about test company"
            });

            test.Add(new Information()
            {
                Date = DateTime.Now,
                Header = "This is real",
                Link = new Uri("http:\\www.real.pl"),
                Text = "Some very interesting information about best company"
            });

            return test.AsQueryable();
        }
    }
}

using IDSAnews.Domain.Abstract;
using IDSAnews.Domain.Entities;
using Moq;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;

namespace IDSAnews.WebUI.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private IKernel ninjectKernel;

        public NinjectControllerFactory()
        {
            ninjectKernel = new StandardKernel();
            AddBinding();
        }

        protected override IController GetControllerInstance(RequestContext
            requestContext, Type controllerType)
        {
            return controllerType == null
                ? null
                : (IController)ninjectKernel.Get(controllerType);
        }

        private void AddBinding()
        {
            Mock<ICompanyRepository> mock = new Mock<ICompanyRepository>();
            mock.Setup(m => m.Companies).Returns(new List<Company> {
                new Company { Id = 1, Name = "Amica", Shortcut = "AMC" },
                new Company { Id = 2, Name = "Eurocash", Shortcut = "EUR" },
                new Company { Id = 3, Name = "WindMobile", Shortcut = "WMO" },
            }.AsQueryable());

            ninjectKernel.Bind<ICompanyRepository>().ToConstant(mock.Object);
        }
    }
}
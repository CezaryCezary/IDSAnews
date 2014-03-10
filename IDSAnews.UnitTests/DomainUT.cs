using System;
using IDSAnews.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IDSAnews.UnitTests
{
    [TestClass]
    public class DomainUT
    {
        [TestMethod]
        public void ModelInitialization()
        {
            PrivateObject modelType = new PrivateObject(typeof(MockupModel));
            var companiesData = modelType.GetProperty("Companies");
            var informationData = modelType.GetProperty("Informations");
            Assert.IsNotNull(companiesData);
            Assert.IsNotNull(informationData);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using MicroBreweries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroBreweries.Tests
{
    [TestClass()]
    public class MicroBreweryTests
    {
        [TestMethod()]
        public void UpdateBreweryTest()
        {
            string newName = "newBrewery";
            MicroBrewery b1 = new MicroBrewery()
            {
                Name = "OriginalBrewery"
            };
            MicroBrewery b2 = new MicroBrewery()
            {
                Name = newName
            };
            b1.UpdateBrewery(b2);
            Assert.AreEqual(b1.Name, newName);
        }
    }
}
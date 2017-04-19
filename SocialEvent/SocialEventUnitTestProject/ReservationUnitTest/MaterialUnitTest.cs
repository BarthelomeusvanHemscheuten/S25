using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.MediaSharingSystem;
using Models.ReservationSystem;
using Models.Users;

namespace SocialEventUnitTestProject.ReservationUnitTest
{   
    [TestClass]
    class MaterialUnitTest
    {
        private Material material;

        [TestInitialize]
        public void TestInitialize()
        {
            this.material = new Material ("stok", "amazing", 10.50);
            this.material = new Material(1, "stok", "amazing", 10.50);
        }

        [TestMethod]
        public void MaterialConstructorTest()
        {
            Assert.AreEqual(1, this.material.ID);
            Assert.AreEqual("stok", this.material.Name);
            Assert.AreEqual("amazing", this.material.Description);
            Assert.AreEqual(10.50, this.material.Price);
        }
    }
}

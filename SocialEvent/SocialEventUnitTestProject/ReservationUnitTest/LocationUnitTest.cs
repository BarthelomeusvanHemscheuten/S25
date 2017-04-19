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
    class LocationUnitTest
    {
        private Location location;

        [TestInitialize]
        public void TestInitialize()
        {
            this.location = new Location(1, "amazing", "huisje");
        }

        [TestMethod]
        public void LocationConstructorTest()
        {
            Assert.AreEqual(1, this.location.ID);
            Assert.AreEqual("amazing", this.location.Features);
            Assert.AreEqual("huisje", this.location.Type);
        }
    }
}

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
    class EventUnitTest
    {
        private Event EVENT;

        [TestInitialize]
        public void TestInitialize()
        {
            this.EVENT = new Event("pinkpop");
            this.EVENT = new Event("pinkpop", "amazing");
        }

        [TestMethod]
        public void EventConstructorTest()
        {
            Assert.AreEqual("pinkpop", this.EVENT.Name);
            Assert.AreEqual("amazing", this.EVENT.Description);
        }
        public void AddLocationTest()
        {
            Location location = new Location(1, "amazing", "huisje");
            Assert.AreEqual(location, this.EVENT.Locations.Last());
        }
        public void AddMaterialTest()
        {
            Material material = new Material("stok", "gay", 10);
            Assert.AreEqual(material, this.EVENT.Material.Last());
        }
    }
}

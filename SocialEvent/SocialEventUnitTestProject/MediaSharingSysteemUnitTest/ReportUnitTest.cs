using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.MediaSharingSystem;
using Models.ReservationSystem;
using Models.Users;

namespace SocialEventUnitTestProject
{   
    [TestClass]
    class ReportUnitTest
    {
        private Report report;

        [TestInitialize]
        public void TestInitialize()
        {
            this.report = new Report("wtf kid");
            this.report = new Report(1, "wtf kid");
        }
        
        [TestMethod]
        public void ReportConstructorTest()
        {
            Assert.AreEqual("wtf kid", this.report.Reason);
            Assert.AreEqual(1, this.report.ID);
        }
    }
}

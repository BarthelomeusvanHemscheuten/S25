using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.MediaSharingSystem;
using Models.ReservationSystem;
using Models.Users;

namespace SocialEventUnitTestProject.UserUnitTest
{   
    [TestClass]
    class UserUnitTest
    {
        private Visitor visitor;
        private Admin admin;
        private Employee employee;
        private User user;
        [TestInitialize]
        public void TestInitialize()
        {   
            this.visitor = new Visitor("swaginator", "Roger", "06133769420", 1,1);
            this.admin = new Admin("baasje", "Roger", "pony@fony.com", "06555444333", "6969JK", new DateTime(09 - 08 - 1999), 1, 1);
            this.employee = new Employee("werker", "henk", "kill@me.plz", "06999888777", "1337HH", new DateTime(09 - 08 - 1999), 1, 1);
        }

        [TestMethod]
        public void UserConstructorTest()
        {
            //visitor
            Assert.AreEqual("swaginator", this.visitor.Username);
            Assert.AreEqual("Roger", this.visitor.Name);
            Assert.AreEqual("06133769420", this.visitor.Telnr);
            Assert.AreEqual(1, this.visitor.EventID);
            Assert.AreEqual(1, this.visitor.ReservationID);
            Assert.IsNull(visitor.Picture);

            //admin
            Assert.AreEqual("baasje", this.admin.Username);
            Assert.AreEqual("Roger", this.admin.Name);
            Assert.AreEqual("pony@fony.com", this.admin.EmailAddress);
            Assert.AreEqual("06555444333", this.admin.Telnr);
            Assert.AreEqual("6969JK", this.admin.Address);
            Assert.AreEqual(new DateTime(09 - 08 - 1999), this.admin.DateOfBirth);
            Assert.AreEqual(1, this.admin.EventID);
            Assert.AreEqual(1, this.admin.ReservationID);
            Assert.IsNull(admin.Picture);

            //employee
            Assert.AreEqual("werker", this.employee.Username);
            Assert.AreEqual("henk", this.employee.Name);
            Assert.AreEqual("kill@me.plz", this.employee.EmailAddress);
            Assert.AreEqual("06999888777", this.employee.Telnr);
            Assert.AreEqual("1337HH", this.employee.Address);
            Assert.AreEqual(new DateTime(09 - 08 - 1999), this.employee.DateOfBirth);
            Assert.AreEqual(1, this.employee.EventID);
            Assert.AreEqual(1, this.employee.ReservationID);
            Assert.IsNull(employee.Picture);
        }
        public void placePostTest()
        {
            visitor.PlacePost(1, "ik ben lucas", "asdf");
            Assert.AreEqual(1, visitor.Posts.Count);
        }
        public void placeCommentTest()
        {
            visitor.PlaceComment(1, "haha grappig man");
            Assert.AreEqual(1, visitor.Comments.Count);
        }
        public void changePasswordTest()
        {
            Assert.IsTrue(visitor.ChangePassword("lol", "haha"));
        }
        public void changeUserName()
        {
            Assert.IsTrue(visitor.ChangeUsername("Rozer"));
        }
    }
}

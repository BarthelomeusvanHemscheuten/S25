﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Models.MediaSharingSystem;
using Models.ReservationSystem;
using Models.Users;

namespace SocialEventUnitTestProject
{
    [TestClass]
    public class CommentUnitTest
    {
        private Comment comment;

        [TestInitialize]
        public void TestInitialize()
        {
            this.comment = new Comment("lol");
            this.comment = new Comment(1, "lol");
        }

        [TestMethod]
        public void CommentConstructorTest()
        {
            // comment
            Assert.AreEqual("lol",this.comment.Text);
            Assert.AreEqual(1, this.comment.ID);
        }

        [TestMethod]
        public void ReportCommentTest()
        {
            Visitor visitor = new Visitor("Swag", "Roger", "Jemoeder", "06133769420", 1, 1);s
            Assert.IsTrue(comment.ReportComment(1, visitor, "wtf is dit"));
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.MediaSharingSystem;
using Models.Users;

namespace SocialEventUnitTestProject
{   
    [TestClass]
    public class PostUnitTest
    {
        private Post post;

    [TestInitialize]
        public void TestInitialize()
        {
            List<string> tags = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                tags.Add("TestTag");
            }
            this.post = new Post("haha", "https://www.youtube.com/watch?v=M_azCIe_0Kk");
            this.post = new Post(1, "haha", "https://www.youtube.com/watch?v=M_azCIe_0Kk");
            this.post = new Post("haha", "https://www.youtube.com/watch?v=M_azCIe_0Kk", tags);
            this.post = new Post(1, "haha", "https://www.youtube.com/watch?v=M_azCIe_0Kk",tags);
        }
        
        [TestMethod]

        public void PostConstructortest()
        {
            List<string> tags = new List<string>();
            for (int i = 0; i < 4; i++)
            {
                tags.Add("TestTag");
            }
            Assert.AreEqual("haha", this.post.Text);
            Assert.AreEqual(1, this.post.ID);
            Assert.AreEqual("https://www.youtube.com/watch?v=M_azCIe_0Kk", this.post.Path);
            Assert.AreEqual(tags, this.post.Tags);
        }
        public void LikeTest()
        {
            Visitor visitor = new Visitor("Swag", "Roger", "Jemoeder", "06133769420", 1, 1);
            Assert.IsTrue(post.Like(visitor));
        }
        public void ReportPostTest()
        {
            Visitor visitor = new Visitor("Swag", "Roger", "Jemoeder", "06133769420", 1, 1);
            Assert.IsTrue(post.ReportPost(1, visitor, "wtf is dit"));
        }
    }
}

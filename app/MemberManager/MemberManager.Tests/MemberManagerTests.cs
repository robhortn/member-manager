using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

using MemberManager.Interfaces;
using MemberManager.BusinessObjects;

namespace MemberManager.Tests
{
    [TestClass]
    public class MemberManagerTests
    {
        [TestMethod]
        public void Get()
        {
            var mock = new Mock<IMemberDomain>();
            mock.Setup(x => x.Get()).Should().NotBeNull();
        }

        [TestMethod]
        public void GetMember()
        {
            var mock = new Mock<IMemberDomain>();
            mock.Setup(x => x.GetMember(It.IsAny<int>())).Should().NotBeNull();
        }

        [TestMethod]
        public void Delete()
        {
            var mock = new Mock<IMemberDomain>();
            mock.Setup(x => x.Delete(It.Is<int>(i => true))).Returns(true);
        }

        [TestMethod]
        public void Save()
        {
            var mock = new Mock<IMemberDomain>();
            mock.Setup(x => x.Save(It.IsAny<Member>())).Returns(1);
        }
    }
}

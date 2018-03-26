using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

using MemberManager.Domain;
using MemberManager.Interfaces;
using MemberManager.BusinessObjects;

namespace MemberManager.Tests
{
    [TestClass]
    public class MemberManagerTests
    {
        MemberDomain _memberDomain = null;
        Mock<IMemberDataWriter> _dw = null;
        Mock<IMemberRepo> _repo = null;

        //[TestInitialize]
        //public void Initialize() {
        //    _dw = new Mock<IMemberDataWriter>();
        //    _repo = new Mock<IMemberRepo>();

        //    _memberDomain = new MemberDomain(_dw.Object, _repo.Object);
        //}

        [TestMethod]
        public void Get()
        {
            var mock = new Mock<IMemberDomain>();
            //mock.Setup(x => x.Get().Should().NotBeNullOrEmpty();
        }

        [TestMethod]
        public void GetMember()
        {
            var mock = new Mock<IMemberDomain>();
            mock.Setup(x => x.GetMember(1)).Should().NotBeNull();
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
            var newMember = new Member { Active = true, FirstName = "Bat", LastName = "Man" };
            //mock.Setup(x => x.Save(newMember).Should().NotBe(null);
        }
    }
}

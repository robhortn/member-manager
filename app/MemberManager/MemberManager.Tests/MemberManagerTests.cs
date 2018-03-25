using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

using MemberManager.Data.Interface;
using MemberManager.Domain.Interfaces;
using MemberManager.Domain;

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
        public void TestGetMember()
        {
            var mock = new Mock<IMemberDomain>();
            mock.Setup(x => x.GetMember(1)).Should().NotBeNull();
        }
    }
}

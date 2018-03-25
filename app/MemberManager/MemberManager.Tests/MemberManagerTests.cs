using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

namespace MemberManager.Tests
{
    [TestClass]
    public class MemberManagerTests
    {
        [TestInitialize]
        public void Initialize() {
            //IMemberDataWriter dw, IMemberRepo repo
        }

        [TestMethod]
        public void TestGetMember()
        {
            var results = 1;
            results.Should().NotBe(0);

        }
    }
}

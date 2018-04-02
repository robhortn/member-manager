using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;

using MemberManager.Interfaces;
using MemberManager.BusinessObjects;
using System.Linq;

namespace MemberManager.Tests
{
    [TestClass]
    public class MemberManagerTests
    {
        [TestMethod]
        public void Get()
        {
            Data.MemberRepo repo = new Data.MemberRepo();
            repo.Save(new Member { FirstName = "Ben", LastName = "Kenobi" });
            repo.Get().Count().Should().Be(1);
        }

        [TestMethod]
        public void GetMember()
        {
            Data.MemberRepo repo = new Data.MemberRepo();
            repo.Save(new Member { FirstName = "Ben", LastName = "Kenobi" });
            repo.Save(new Member { FirstName = "Han", LastName = "Solo" });
            repo.Get().Count().Should().Be(2);
        }

        [TestMethod]
        public void Delete()
        {
            Data.MemberRepo repo = new Data.MemberRepo();
            repo.Save(new Member { FirstName = "Ben", LastName = "Kenobi" });
            repo.Save(new Member { FirstName = "Han", LastName = "Solo" });
            repo.Get().Count().Should().Be(2);

            repo.Delete(1).Should().BeTrue();
            repo.Get().Count().Should().Be(1);
        }

        [TestMethod]
        public void Save()
        {
            Data.MemberRepo repo = new Data.MemberRepo();
            repo.Save(new Member { FirstName = "Ben", LastName = "Kenobi" });
            repo.Get().Count().Should().Be(1);
        }
    }
}

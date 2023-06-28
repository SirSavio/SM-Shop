using SMSites.Shop.Core.Domain.Helpers.Extensions;
using Xunit;

namespace SMSites.Shop.Core.Domain.Tests.FakeEntites
{
    public class HelperTests
    {


        [Fact(DisplayName = "String format to search - success")]
        public void Entity_Create_Success()
        {
            var name = "cássiano Garcia nunes";
            var searchableName = "cassiano garcia nunes";

            Assert.Equal(name.ToSerachable(), searchableName);
        }
    }
}

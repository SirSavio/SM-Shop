using Xunit;

namespace SMSites.Shop.Core.Domain.Tests.FakeEntites
{
    public class EntityTests
    {
        [Fact(DisplayName = "Entity Base Teste")]
        public void Entity_Create_Success()
        {
            // arrage
            Guid entityId = Guid.NewGuid();
            var limitDate = DateTime.UtcNow.AddDays(-1);

            // act
            var entity = new FakeEntity(entityId);

            // assert
            Assert.Equal(entity.Id, entityId);
            Assert.True(entity.CreationDate > limitDate);
            Assert.False(entity.Deleted);
        }

        [Fact(DisplayName = "Named Entity Base Teste")]
        public void FakeEntity_Create_Success()
        {
            // arrage
            Guid entityId = Guid.NewGuid();
            var name = "cassiano";

            // act
            var entity = new FakeNamedEntity(entityId, name);

            // assert
            Assert.Equal("Cassiano", entity.Name.DisplayName);
        }
    }
}

using System;
using Domain.Entities;
using Xunit;

namespace Tests.Entities;

public class EntityTest
{

    [Fact]
    public void Entity_Should_Generate_Id()
    {
        var sut = new Entity();

        Assert.NotEqual(Guid.Empty, sut.Id);
    }

    [Fact]
    public void Entity_Should_Initialize_CreatedAt_And_UpdatedAt()
    {
        var sut = new Entity();
        
        Assert.NotEqual(DateTime.MinValue,sut.CreatedAt);
        Assert.NotEqual(DateTime.MinValue,sut.UpdateAt);
    }
}
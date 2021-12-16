using System;
using Domain.Entities;
using Xunit;

namespace Tests.Entities;

public class IngredientTest
{
    [Fact]
    public void Should_Update_The_Update_Date_When_Changing_Name()
    {
        var sut = new Ingredient();
        var expected = sut.UpdateAt;
        sut.Name = "Calabresa Cremosa";
        Assert.NotEqual(expected, sut.UpdateAt);
    }
}
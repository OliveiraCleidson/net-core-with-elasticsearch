using System.Collections.Generic;
using Domain.Entities;
using Xunit;

namespace Tests.Entities;

public class PizzaTest
{
    [Fact]
    public void Should_Update_The_Update_Date_When_Changing_Name()
    {
        var sut = new Pizza();
        var expected = sut.UpdateAt;
        sut.Name = "Portuguesa";
        Assert.NotEqual(expected, sut.UpdateAt);
    }
    
    [Fact]
    public void Should_Update_The_Update_Date_When_Add_One_Ingredient()
    {
        var sut = new Pizza();
        var expected = sut.UpdateAt;
        sut.AddIngredient(new Ingredient(){Name = "Queijo"});
        Assert.NotEqual(expected, sut.UpdateAt);
    }
    
    [Fact]
    public void Should_Update_The_Update_Date_When_Add_Ingredients()
    {
        var sut = new Pizza();
        var expected = sut.UpdateAt;
        sut.AddIngredients(new List<Ingredient>(){new Ingredient(){Name = "Calabresa"}, new Ingredient(){Name = "Parmesão"}});
        Assert.NotEqual(expected, sut.UpdateAt);
    }
    
    [Fact]
    public void Should_Initialize_Price_by_15()
    {
        var sut = new Pizza();
        decimal expected = 15;
        Assert.Equal(expected, sut.Price);
    }
}
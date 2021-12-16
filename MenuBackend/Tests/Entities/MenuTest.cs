using System.Collections.Generic;
using Domain.Entities;
using Xunit;

namespace Tests.Entities;

public class MenuTest
{
    [Fact]
    public void Should_Update_The_Update_Date_When_Changing_Title()
    {
        var sut = new Menu();
        var expected = sut.UpdateAt;
        sut.Title = "Salgadas";
        Assert.NotEqual(expected, sut.UpdateAt);
    }
    
    [Fact]
    public void Should_Update_The_Update_Date_When_Add_One_Pizza()
    {
        var sut = new Menu();
        var expected = sut.UpdateAt;
        sut.AddPizza(new Pizza(){Name = "Calabresa"});
        Assert.NotEqual(expected, sut.UpdateAt);
    }
    
    [Fact]
    public void Should_Update_The_Update_Date_When_Add_Pizzas()
    {
        var sut = new Menu();
        var expected = sut.UpdateAt;
        sut.AddPizzas(new List<Pizza>(){new Pizza(){Name = "Calabresa"}, new Pizza(){Name = "Portuguesa"}});
        Assert.NotEqual(expected, sut.UpdateAt);
    }
}
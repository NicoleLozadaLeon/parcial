namespace TestDemo.Tests;
public class UnitTest1
{
    [Fact]
    public void CalcularFuerza()
    {
        //Arrange 
        var m = 1800;
        var a = 2.5;
        //Act 
        bool result = Mathematics.CalcularFuerza(m, a);
        //Assert 
        Assert.True(result);
    }
        [Fact]
    public void CalcularTrabajo()
    {
        //Arrange 
        var F = 1800;
        var d = 16.5;
        //Act 
        bool result = Mathematics.CalcularTrabajo(F, d);
        //Assert 
        Assert.True(result);
    }
        [Fact]
    public void CalcularEnergiaCinetica()
    {
        //Arrange 
        var m = 6;
        var v = 8;
        //Act 
        bool result = Mathematics.CalcularEnergiaCinetica(m, v);
        //Assert 
        Assert.True(result);
    }
    

    
}

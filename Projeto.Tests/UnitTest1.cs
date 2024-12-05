using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Projeto.Tests;

[TestClass]
public class CalcTest
{
    [TestMethod]
    public void Testar()
    {
        int teste = 10;
        int total = teste.Calcular();
        Console.WriteLine(total);
        //Assert.AreEqual(20);
    }
}
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using NewTalents;

namespace NewTalentsTest;

public class UnitTest1
{
    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData (4, 5, 9)]
    public void TestSomar(int num1, int num2, int resultado)
    {
        Calculadora calc = new Calculadora();

        int resultadoCalc = calc.somar(num1, num2);

        Assert.Equal(resultado, resultadoCalc);
    }

    [Theory]
    [InlineData (1, 2, 2)]
    [InlineData (4, 5, 20)]
    public void TestMultiplicar(int num1, int num2, int resultado)
    {
        Calculadora calc = new Calculadora();

        int resultadoCalc = calc.multiplicar(num1, num2);

        Assert.Equal(resultado, resultadoCalc);
    }

    [Theory]
    [InlineData (6, 2, 3)]
    [InlineData (5, 5, 1)]
    public void TestDividir(int num1, int num2, int resultado)
    {
        Calculadora calc = new Calculadora();

        int resultadoCalc = calc.dividir(num1, num2);

        Assert.Equal(resultado, resultadoCalc);
    }

    [Theory]
    [InlineData (6, 2, 4)]
    [InlineData (5, 5, 0)]
    public void TestSubtrair(int num1, int num2, int resultado)
    {
        Calculadora calc = new Calculadora();

        int resultadoCalc = calc.subtrair(num1, num2);

        Assert.Equal(resultado, resultadoCalc);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        Calculadora calc = new Calculadora();

        Assert.Throws<DivideByZeroException>(() => calc.dividir(3, 0));
    }

    [Fact]
    public void TestHistorico()
    {
        Calculadora calc = new Calculadora();

        calc.somar(1, 2);
        calc.somar(5, 2);
        calc.somar(10, 10);
        calc.somar(5, 8);

        var lista = calc.historico();

        Assert.NotEmpty(calc.historico());
        Assert.Equal(3, lista.Count);

    }
}
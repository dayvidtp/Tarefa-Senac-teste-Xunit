using Xunit;

namespace tarefa_teste_Xunit
{
    public class CalculadoraTeste
    {
        [Fact]
        public void TesteSomar()
        {
            //Arrange ou Given (Contextualização para o teste)
            /*Aqui ficaria a instanciação da calculadora
            se não tivessemos dito que ela é static*/

            //Act ou When (Verificação da ação para o teste)
            double resultado = Calculadora.Somar(2,3);

            //Assert ou Then (Verificação se ocorreu o esperado)
            Assert.Equal(5, resultado);
        }

        [Fact]  
        public void TesteSubtrair()
        {
            double resultado = Calculadora.Subtrair(10, 5);
            Assert.Equal(5, resultado);
        }

        [Fact]
        public void TesteMultiplicar()
        {
            double resultado = Calculadora.Multiplicar(10, 5);
            Assert.Equal(50, resultado);
        }

        [Fact]
        public void TesteDividir()
        {
            double resultado = Calculadora.Dividir(10, 5);
            Assert.Equal(2, resultado);
        }

        //Teste se a divisão por 0 é igual a Infinito
        [Fact]
        public void TesteDividir2()
        {
            double resultado = Calculadora.Dividir(10, 0);
            Assert.Equal(double.PositiveInfinity, resultado);
        }
    }
}
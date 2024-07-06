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
    }
}
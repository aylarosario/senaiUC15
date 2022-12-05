using Projeto_teste;

namespace TesteXUnit
{
    public class UnitTest1
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            var Resultado = Operacoes.Somar(pNum, sNum);

            Assert.Equal(rNum, Resultado);
        }
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(3, 1, 4)]
        public void SomarDoisNumerosListar(double pNum, double sNum, double rNum)
        {
            var Resultado = Operacoes.Somar(pNum, sNum);

            Assert.Equal(rNum, Resultado);
        }
    }
}
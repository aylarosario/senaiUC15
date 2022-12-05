using Projeto_teste;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMSTest
{
    [TestClass]
    public class TesteUnitario
    {
        [TestMethod]
        public void SomarDoisNumeros()
        {
            double pNum = 1;
            double sNum = 1;
            double rNum = 2;

            var Resultado = Operacoes.Somar(pNum, sNum);

            Assert.AreEqual(rNum, Resultado);
        }

        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(2, 1, 3)]
        [DataRow(3, 3, 6)]
        [DataRow(4, 1, 5)]
        public void SomarDoisNumerosLista(double pNum, double sNum, double rNum)
        {
            var Resultado = Operacoes.Somar(pNum, sNum);

            Assert.AreEqual(rNum, Resultado);
        }
        
    }
}

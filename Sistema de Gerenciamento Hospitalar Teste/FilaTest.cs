using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Sistema_de_Gerenciamento_Hospitalar;
using System;

namespace Sistema_de_Gerenciamento_Hospitalar_Teste
{
    [TestClass]
    public class FilaTest
    {
        [TestMethod]
        public void VerificaAcesso_Falso()
        {
            var admin = new AdministradorFalso(false);
            var medico = new MédicoFake(false);
            var sistema = new Fila();
            // Act
            bool resultado = sistema.Consultar();
            // Assert
            Assert.IsFalse(resultado);
        }

    }

    internal class MédicoFake
    {
        private object falso;

        public MédicoFake(object falso)
        {
            this.falso=falso;
        }
    }

    internal class AdministradorFalso
    {
        private bool v;

        public AdministradorFalso(bool v)
        {
            this.v=v;
        }
    }
}
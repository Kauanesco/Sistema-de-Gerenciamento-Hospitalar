using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Sistema_de_Gerenciamento_Hospitalar;
using System;

namespace Sistema_de_Gerenciamento_Hospitalar_Teste
{
    [TestClass]
    public class AdministradorTest
    {
        [TestMethod]
        public void Login_AutenticaRetornaUm_LoginRetornaTrue()
        { // Arrange
            var mockAdministrador = new Mock<Administrador>();
            mockAdministrador.Setup(admin => admin.Autentica(It.IsAny<string>(), It.IsAny<string>())).Returns(1); var administrador = mockAdministrador.Object;
            string cpf = "12345678901";
            string senha = "senha123";
            // Act
            bool resultado = administrador.Login(cpf, senha);
            // Assert
            Assert.IsTrue(resultado);
            mockAdministrador.Verify(admin => admin.Autentica(cpf, senha), Times.Once);
        }
        [TestMethod]
        public void Login_AutenticaRetornaZero_LoginRetornaTrue()
        { // Arrange
            var mockAdministrador = new Mock<Administrador>();
            mockAdministrador.Setup(admin => admin.Autentica(It.IsAny<string>(), It.IsAny<string>())).Returns(0); var administrador = mockAdministrador.Object;
            string cpf = "12345678901";
            string senha = "senha123";
            // Act
            bool resultado = administrador.Login(cpf, senha);
            // Assert
            Assert.IsFalse(resultado);
            mockAdministrador.Verify(admin => admin.Autentica(cpf, senha), Times.Once);
        }
    }
}

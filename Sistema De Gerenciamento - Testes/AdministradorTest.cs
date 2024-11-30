using Moq;
using Sistema_de_Gerenciamento_Hospitalar;
using System;
using Xunit;



namespace Sistema_De_Gerenciamento___Testes
{
    public class AdministradorTest
    { 

        [Fact(DisplayName = "Deve retornar valores verdadeiros.")]
        public void Login_DadosValidos_RetornaTrue()
        { // Arrange

            int num = 0;
            var admin = new Administrador();
            //act
            bool resultado = admin.Ola(num);

            //assert
            Assert.Equal(false, resultado); 
        } 
    }
}

using Sistema_de_Gerenciamento_Hospitalar;
namespace ProjetoTestes
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var admin = new Administrador();
            int num = 1;

            bool resultado = admin.Ola(num);

            Assert.Equal(true, resultado);
        }
    }
}
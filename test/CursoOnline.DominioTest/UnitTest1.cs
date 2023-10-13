using Xunit;

namespace CursoOnline.DominioTest
{
    public class UnitTest1
    {
        [Fact( DisplayName = "Testar")]
        public void DeveAsVariaveisTeremOsMesmosValores()
        {
            //Organização
            var variavel1 = 1;
            var variavel2 = 1;

            //Ação
            variavel2 = variavel1;

            //Assert
            Assert.Equal(variavel1, variavel2);
        }
    }
}

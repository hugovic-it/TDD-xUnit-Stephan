using Xunit;

namespace CursoOnline.DominioTest
{
    public class UnitTest1
    {
        [Fact( DisplayName = "Testar")]
        public void DeveAsVariaveisTeremOsMesmosValores()
        {
            //Organiza��o
            var variavel1 = 1;
            var variavel2 = 1;

            //A��o
            variavel2 = variavel1;

            //Assert
            Assert.Equal(variavel1, variavel2);
        }
    }
}

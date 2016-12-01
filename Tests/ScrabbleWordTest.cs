using Xunit;

namespace Scrabble.Objects
{
  public class ScrabbleWordTest
  {
    [Fact]
    public void GetWordValue_ForSingleLetter_1()
    {
      Assert.Equal(1, ScrabbleWord.GetWordValue("A"));
    }
    [Fact]
    public void GetWordValue_ForSingleWord_8()
    {
      Assert.Equal(8, ScrabbleWord.GetWordValue("word"));
    }

    [Fact]
    public void GetWordValue_ForDifferentCases_8()
    {
      Assert.Equal(8, ScrabbleWord.GetWordValue("wOrD"));
    }
    [Fact]
    public void GetWordValue_ForMultipleWords_12()
    {
      Assert.Equal(12, ScrabbleWord.GetWordValue("word test"));
    }
  }
}

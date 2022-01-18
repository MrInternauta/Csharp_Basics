using System;
using Xunit;

namespace GradeBook.Tests
{
  public class BookTest
  {
    [Fact]
    public void BookCalculatesAnAverageGrade()
    {
      var book = new Book("Juan");
      book.AddGrade(60);
      book.AddGrade(90);
      book.AddGrade(80);

      //Act
      var result = book.GetStatistics();

      //Assert
      Assert.Equal(76.7, result.Average, 1);
      Assert.Equal(90, result.High, 1);
      Assert.Equal(60, result.Low, 1);

    }
  }
}

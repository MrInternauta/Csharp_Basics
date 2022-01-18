using System;
using System.Collections.Generic;

namespace GradeBook
{
  class Program
  {
    static void Main(string[] args)
    {
      var book = new Book("Felipe");
      book.AddGrade(12.9);
      book.AddGrade(98.1);
      book.AddGrade(67.9);
      book.AddGrade(82.2);
      book.ShowStatistics();

      var book2 = new Book("Jesus");
      book2.AddGrade(12.9);
      book2.AddGrade(98.1);
      book2.AddGrade(67.9);
      book2.AddGrade(82.2);
      book2.ShowStatistics();

    }
  }
}

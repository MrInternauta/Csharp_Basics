using System;
using System.Collections.Generic;
namespace GradeBook
{
  public class Book
  {
    private List<double> grades = null;
    public string Name;
    public Book(string name)
    {
      Name = name;
      grades = new List<double>();
    }
    public void AddGrade(double grade)
    {
      grades.Add(grade);
    }

    public Statistics GetStatistics()
    {
      var result = new Statistics();
      result.High = double.MinValue;
      result.Low = double.MaxValue;
      foreach (double grade in grades)
      {
        result.Low = Math.Min(grade, result.Low);
        result.High = Math.Max(grade, result.High);
        result.Average += grade;
      }
      result.Average /= grades.Count;
      return result;
    }

    public void ShowStatistics()
    {
      var result = GetStatistics();
      System.Console.WriteLine($"The statistics for {Name}");
      Console.WriteLine($"The lowest grade is {result.Low}");
      Console.WriteLine($"The highest grade is {result.High}");
      Console.WriteLine($"The overage grade is {result.Average}");
    }

  }
}
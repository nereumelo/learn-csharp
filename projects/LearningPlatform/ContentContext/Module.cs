using System.Collections.Generic;

namespace LearningPlatform.ContentContext
{
  public class Module : Content
  {
    public Module(string name, string url)
      : base(name, url)
    {
      Lectures = new List<Lecture>();
    }
    public List<Lecture> Lectures { get; set; }
  }
}
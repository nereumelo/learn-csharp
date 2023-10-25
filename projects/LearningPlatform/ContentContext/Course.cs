using System.Collections;
using System.Collections.Generic;

namespace LearningPlatform.ContentContext
{
  public class Course : Content
  {
    public Course(string name, string url, EContentLevel level)
      : base(name, url)
    {
      Level = level;
      Modules = new List<Module>();
    }
    public EContentLevel Level { get; set; }
    public IList<Module> Modules { get; set; }
  }
}
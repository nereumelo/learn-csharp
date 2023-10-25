using System.Collections.Generic;

namespace LearningPlatform.ContentContext
{
  public class Career : Content
  {
    public Career(string name, string url)
      : base(name, url)
    {
      Items = new List<CareerItem>();
    }

    public IList<CareerItem> Items { get; set; }
    public int TotalCourses => Items.Count;
  }
}
using LearningPlatform.SharedContext;

namespace LearningPlatform.ContentContext
{
  public abstract class Content : Base
  {
    public Content(string name, string url)
    {
      Name = name;
      Url = url;
    }
    public string Name { get; set; }
    public string Url { get; set; }
  }
}
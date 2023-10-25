namespace LearningPlatform.ContentContext
{
  public class Lecture : Content
  {
    public Lecture(string name, string url)
      : base(name, url)
    {

    }
    public int DurationInMinutes { get; set; }
  }
}
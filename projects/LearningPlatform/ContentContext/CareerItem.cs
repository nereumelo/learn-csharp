using System;
using LearningPlatform.NotificationContext;
using LearningPlatform.SharedContext;

namespace LearningPlatform.ContentContext
{
  public class CareerItem : Base
  {
    public CareerItem(
      int order,
      string name,
      string description,
      Course course
    )
    {
      if (course == null)
        AddNotification(new Notification("Course", "Invalid course"));

      Order = order;
      Name = name;
      Description = description;
      Course = course;
    }

    public int Order { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Course Course { get; set; }
  }
}
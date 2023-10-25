using System;
using LearningPlatform.NotificationContext;

namespace LearningPlatform.SharedContext
{
  public abstract class Base : Notifiable
  {
    public Base()
    {
      ID = Guid.NewGuid();
    }
    public Guid ID { get; }
  }
}
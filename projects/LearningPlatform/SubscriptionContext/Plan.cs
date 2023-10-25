using LearningPlatform.SharedContext;

namespace LearningPlatform.SubscriptionContext
{
  public class Plan : Base
  {
    public string Name { get; set; }
    public decimal Price { get; set; }
  }
}
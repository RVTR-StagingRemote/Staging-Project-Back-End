namespace REST.Models
{
  public class PaymentIntentCreateRequest  {
    public Courses[] CoursesToBuy { get; set; }

    // TODO: Please remove, this is only temporary
    public long Price { get; set; }
  }
}
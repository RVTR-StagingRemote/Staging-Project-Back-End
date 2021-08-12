using System;

namespace Models

public class OrderDetails
{
	public OrderDetails()
	{
		public int DetailsId { get; set; }
		public int CourseId { get; set; }
		public int OrderId { get; set; }
		public int AssociateCount { get; set; }
		public DateTime DateNeeded { get; set; }
	}
}

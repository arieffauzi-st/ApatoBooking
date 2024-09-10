
using ApatoBooking.Domain.Abstractions;

namespace ApatoBooking.Domain.Apartments
{
	public class Apartment : Entity
	{
		public Apartment(Guid id)
			: base(id)
		{

		}
		public Name Name { get; set; }
		public Description Description { get; set; }	
		public Address Address { get; set; }
		public decimal PriceAmount { get; set; }
		public string? PriceCurrency { get; set; }
		public Decimal CleaningFreeAmount { get; set; }
		public string? CleaningFeeCurrency { get; set; }
		public DateTime? LastBookedonUtc { get; set; }
		public List<Amenity> Amenities { get; set; } = new();






	}
}

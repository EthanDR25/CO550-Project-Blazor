using System.ComponentModel.DataAnnotations;

namespace CO550_Project_Blazor.Models
{
	public class FilmBooking
	{
		public int FilmBookingID { get; set; }

		public Film film { get; set; }

        public int Quantity { get; set; } = 1;

        [Required]
        public decimal PurchasePrice { get; set; } = 0;


		[DataType(DataType.Date)]
		public DateTime BookingDate { get; set; }
	}
}

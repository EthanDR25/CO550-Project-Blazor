namespace CO550_Project_Blazor.Models.Services
{
	public class TicketBookingService
	{
		public static List<FilmBooking> SelectedItems { get; set; } = new List<FilmBooking>();

		public Payment payment { get; set; }

		public void BookTicket(int filmID)
		{

			if(FilmIsBooked(filmID) is false)
			{
                var film = FilmService.Films.First(film => film.FilmID == filmID);
                FilmBooking booking = new FilmBooking();
                booking.film = film;
                booking.PurchasePrice = film.Price;
                SelectedItems.Add(booking);
			}
            

        }

		private bool FilmIsBooked(int filmID)
		{
		 foreach (FilmBooking booking in SelectedItems)
			{
				if(booking.film.FilmID == filmID)
				{
					booking.Quantity++;
					return true;
				}
			}
			return false;
		}
	}
}

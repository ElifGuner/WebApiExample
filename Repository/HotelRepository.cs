using WebApiExample.Model;

namespace WebApiExample.Repository
{
    public class HotelRepository : IHotelRepository
    {
        public Hotel CreateHotel(Hotel hotel)
        {
            HotelDBContext hotelDBContext = new HotelDBContext();
            hotelDBContext.Hotels.Add(hotel);
            hotelDBContext.SaveChanges();
            return hotel;
        }

        public void DeleteHotel(int id)
        {
            HotelDBContext hotelDBContext = new HotelDBContext();
            Hotel deletedHotel = GetHotelById(id);
            hotelDBContext.Hotels.Remove(deletedHotel);
            hotelDBContext.SaveChanges();

        }

        public List<Hotel> GetAllHotels()
        {
            HotelDBContext hotelDBContext = new HotelDBContext();
            return hotelDBContext.Hotels.ToList();
        }

        public Hotel GetHotelById(int id)
        {
            HotelDBContext hotelDBContext = new HotelDBContext();
            return hotelDBContext.Hotels.Find(id);
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            HotelDBContext hotelDBContext = new HotelDBContext();
            hotelDBContext.Hotels.Update(hotel);
            hotelDBContext.SaveChanges();
            return hotel;
        }
    }
}

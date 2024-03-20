using WebApiExample.Model;

namespace WebApiExample.Repository
{
    public interface IHotelRepository
    {
        List<Hotel> GetAllHotels();
        Hotel GetHotelById(int id);
        Hotel CreateHotel(Hotel hotel);
        Hotel UpdateHotel(Hotel hotel);

        void DeleteHotel(int id);
    }
}

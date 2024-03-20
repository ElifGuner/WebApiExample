using WebApiExample.Model;

namespace WebApiExample.Business
{
    public interface IHotelService
    {
        List<Hotel> GetAllHotels();
        Hotel GetHotelById(int id);
        Hotel CreateHotel(Hotel hotel);
        Hotel UpdateHotel(Hotel hotel);

        void DeleteHotel(int id);
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiExample.Business;
using WebApiExample.Model;

namespace WebApiExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private IHotelService _hotelService;

        public HotelsController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var hotels = _hotelService.GetAllHotels();
            return Ok(hotels);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var hotel = _hotelService.GetHotelById(id);

            if (hotel != null)
                return Ok(hotel);
            return NotFound();//404

        }

        [HttpPost]
        public IActionResult Post([FromBody] Hotel hotel)
        {

            var createdHotel = _hotelService.CreateHotel(hotel);

            return CreatedAtAction("Get", new {id =createdHotel.Id}, createdHotel);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Hotel hotel)
        {
            if (_hotelService.GetHotelById(hotel.Id) != null)
                return Ok( _hotelService.UpdateHotel(hotel));
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // _hotelService.DeleteHotel(id);
            Hotel hotel = _hotelService.GetHotelById(id);
            if ( hotel != null)
                return Ok();
            return NotFound();

        }
    }
}

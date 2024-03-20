using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebApiExample.Model
{
    public class Hotel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string City { get; set; }
    }
}

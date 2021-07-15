using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace partyInvites06.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Пожалуйста, введите своё имя")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Пожалуйста, введите свою почту")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Пожалуйста, введите номер телефона")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Пожалуйста, укажите примете ли вы участие")]
        public bool? WillAttend { get; set; }
    }
}

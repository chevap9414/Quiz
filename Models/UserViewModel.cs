using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizDemo.Models
{
    public class UserViewModel
    {
        [DisplayName("Operation")]
        public long Id { get; set; }

        [Required]
        [DisplayName("HN เจ้าของ")]
        [StringLength(6)]
        public string HN { get; set; }

        [Required]
        [DisplayName("ชื่อเจ้าของ")]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("นามสกุลเจ้าของ")]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [DisplayName("เบอร์ติดต่อ")]
        [StringLength(10)]
        public string Phone { get; set; }

        [Required]
        [DisplayName("อีเมล์")]
        [StringLength(100)]
        public string Email { get; set; }

        public bool IsSucceed { get; set; }
    }
}

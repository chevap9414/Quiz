using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QuizDemo.Datas.Entities
{
    public class User
    {
        [Key]
        public long Id { get; set; }

        [Column(TypeName = "varchar(6)")]
        public string HN { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string FirstName { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string LastName { get; set; }

        [Required]
        [Column(TypeName = "varchar(10)")]
        public string Phone { get; set; }

        [Required]
        [Column(TypeName = "varchar(200)")]
        public string Email { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CamadasRepository.Domain.Entities
{
    public class User : BaseEntity
    {
        [Required(ErrorMessage = "O nome deve ser inserido.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O nome deve ser inserido.")]
        public string Email { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Shared.Entities
{
    public class Country
    {
        public int Id { get; set; }

        [Display(Name = "País")]
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [MaxLength(100, ErrorMessage = "O campo {0} não pode ter mais que {1} caractéres")]
        public string Name { get; set; }

    }
}

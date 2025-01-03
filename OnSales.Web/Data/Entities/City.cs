﻿using Mono.TextTemplating;
using System.ComponentModel.DataAnnotations;

namespace OnSales.Web.Data.Entities
{
    public class City
    {
        public int Id { get; set; }
        [Display(Name = "Ciudad/Municipio")]
        [MaxLength(50, ErrorMessage = "El {0} Campo debe tener mas de  {1} caracter.")]
        [Required(ErrorMessage = "El Campo {0}  es obligatorio.")]
        public string Name { get; set; }

        public State State { get; set; }
     
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TCC_HELP_DESK.Models
{
    public class Categorias
    {
        [Key]
        public int CategoriaId { get; set; }


        [Display(Name = "Categoria")]
        public String Descrição { get; set; }
       

        public virtual ICollection<Chamados> chamado { get; set; }
    }
}
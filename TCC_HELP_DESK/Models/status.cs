﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TCC_HELP_DESK.Models
{
    public class Status
    {
        [Key]
        public int StatusId { get; set; }
        [Display (Name = "Status")]
        public String Descrição { get; set; }

        public virtual ICollection<Chamados> chamado { get; set; }
    }
}
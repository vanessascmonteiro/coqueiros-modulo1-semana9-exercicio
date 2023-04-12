using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ApiSemana9.Models
{
    [Table("Semana")]
    public class SemanaModel
    {
        [Key]
        public int Id {get; set;}

        public DateTime DataSemana{get; set;}

        [MaxLength (100)]
        public string Nome  {get; set;}
        public bool AplicadoConteudoBool {get; set;}

    }
}
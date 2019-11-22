using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPos.Web.Data.Entities
{
    public class UnitMeasure
    {
        /// <summary>
        /// Id de la unidad de medida
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Código de la unidad de medida
        /// </summary>
        [Required]
        [MaxLength(3)]
        public string Code { get; set; }

        /// <summary>
        /// Descripción de la unidad de medida
        /// </summary>
        [Display(Name = "Unit of Measurement")]
        [MaxLength(20, ErrorMessage = "The {0} field can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Description { get; set; }
    }
}

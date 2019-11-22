using System.ComponentModel.DataAnnotations;

namespace MyPos.Web.Data.Entities
{
    public class ProductGroup
    {
        /// <summary>
        /// Id del grupo de productos
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Código del gripo de producto
        /// </summary>
        [Required]
        [MaxLength(6)]
        public string Code { get; set; }

        /// <summary>
        /// Descripción del producto
        /// </summary>
        [Required]
        [MaxLength(30)]
        public string Description { get; set; }


    }
}

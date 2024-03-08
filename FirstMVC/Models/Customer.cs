using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstMVC.Models
{
   [Table("Customer")]
     public class Customer  {
       
       [Key]
       public string? CusstomerID { get; set; } 
        public string? FullName { get; set; }       

     }     

}
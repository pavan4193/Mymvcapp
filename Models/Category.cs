using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using  MyMvcApp.Models;


    public class Category
    {
        [Key][Required]
        public int Id { get; set;}
        

        [DisplayName("Category Name")]
        public required string Name { get; set;}
        [DisplayName("Display order")]
        public int DisplayOrder { get; set;}
    }


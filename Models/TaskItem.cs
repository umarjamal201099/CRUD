using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class TaskItem  
    {
        [Key]
        public int? Id { get; set; }  // Primary Key
        public string? Title { get; set; }
    }
}

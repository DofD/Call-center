using System.ComponentModel.DataAnnotations;

namespace СallСenter.Data.Tasks
{
    /// <summary>
    /// Заявка системы.
    /// </summary>
    public class TaskDto
    {
        [Key]
        public string Id { get; set; }
    }
}

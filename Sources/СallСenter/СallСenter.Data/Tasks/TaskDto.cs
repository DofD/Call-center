using System.ComponentModel.DataAnnotations;
using СallСenter.Core.Tasks;

namespace СallСenter.Data.Tasks
{
    /// <summary>
    /// Заявка системы.
    /// </summary>
    public class TaskDto
    {
        [Key]
        public string Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Title { get; set; }

        public string Body { get; set; }

        public TaskStatus Status { get; set; }

        public string Eemployee { get; set; }
    }
}

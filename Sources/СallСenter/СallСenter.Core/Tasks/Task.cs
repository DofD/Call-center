using System;

namespace СallСenter.Core.Tasks
{
    /// <summary>
    /// Заявка системы.
    /// </summary>
    public class Task
    {
        public Task(string name, string phone, string title, string body, TaskStatus? status, string eemployee)
        {
            Name = string.IsNullOrEmpty(name) ? throw new ArgumentNullException(nameof(name)) : name;
            Phone = string.IsNullOrEmpty(phone) ? throw new ArgumentNullException(nameof(phone)) : phone;
            Title = string.IsNullOrEmpty(title) ? throw new ArgumentNullException(nameof(title)) : title;
            Body = string.IsNullOrEmpty(body) ? throw new ArgumentNullException(nameof(body)) : body;
            Status = status ?? TaskStatus.Registered;
            Eemployee = string.IsNullOrEmpty(eemployee) ? throw new ArgumentNullException(nameof(eemployee)) : eemployee;
        }

        public string Name { get; }

        public string Phone { get; }

        public string Title { get; }

        public string Body { get; }

        public TaskStatus Status { get; }

        public string Eemployee { get; }
    }
}

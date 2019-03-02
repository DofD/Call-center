using System;
using СallСenter.Core.Categories;

namespace СallСenter.Core.Tasks
{
    /// <summary>
    /// Заявка системы.
    /// </summary>
    public class Task
    {
        public Task(string name, string phone, string body, TaskStatus? status, string eemployee)
        {
            Name = string.IsNullOrEmpty(name) ? throw new ArgumentNullException(nameof(name)) : name;
            Phone = string.IsNullOrEmpty(phone) ? throw new ArgumentNullException(nameof(phone)) : phone;
            Body = string.IsNullOrEmpty(body) ? throw new ArgumentNullException(nameof(body)) : body;
            Status = status ?? TaskStatus.Registered;
            Eemployee = string.IsNullOrEmpty(eemployee) ? throw new ArgumentNullException(nameof(eemployee)) : eemployee;
        }

        /// <summary>
        /// Идентификатор.
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// ФИО обратившегося клиента.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Мобильный телефон.
        /// </summary>
        public string Phone { get; }

        /// <summary>
        /// Категория обращения.
        /// </summary>
        public Category Category { get; }

        /// <summary>
        /// Текст обращения.
        /// </summary>
        public string Body { get; }

        /// <summary>
        /// Статус.
        /// </summary>
        public TaskStatus Status { get; }

        /// <summary>
        /// Оператор, принявший обращение.
        /// </summary>
        public string Eemployee { get; }

        /// <summary>
        /// Дата и время обращения.
        /// </summary>
        public DateTime Created { get; }
    }
}

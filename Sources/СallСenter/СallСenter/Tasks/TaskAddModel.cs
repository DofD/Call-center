using System;

namespace СallСenter.Tasks
{
    /// <summary>
    ///     Модель задачи.
    /// </summary>
    public class TaskAddModel
    {
        /// <summary>
        ///     ФИО обратившегося клиента.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Мобильный телефон.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        ///     Категория обращения.
        /// </summary>
        public Guid Category { get; set; }

        /// <summary>
        ///     Текст обращения/
        /// </summary>
        public string Body { get; set; }
    }
}
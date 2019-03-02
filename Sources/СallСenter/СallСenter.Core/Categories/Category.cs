using System;

namespace СallСenter.Core.Categories
{
    /// <summary>
    /// Категория обращения.
    /// </summary>
    public class Category
    {
        public Category(Guid id, string title)
        {
            Id = id;
            Title = title;
        }

        /// <summary>
        /// Идентификатор.
        /// </summary>
        public Guid Id { get; }

        /// <summary>
        /// Заголовок.
        /// </summary>
        public string Title { get; }
    }
}
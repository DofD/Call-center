using System.Collections.Generic;

namespace СallСenter.Core.Tasks
{
    /// <summary>
    /// Репозиторий задач.
    /// </summary>
    public interface ITaskRepository
    {
        /// <summary>
        /// Получить все задачи.
        /// </summary>
        /// <returns></returns>
        List<Task> GetAll();

        /// <summary>
        /// Получить задачу.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        /// <returns>Найденая задача.</returns>
        Task Get(string id);

        /// <summary>
        /// Вставить задачу.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        /// <param name="task">Новая задача.</param>
        void Insert(string id, Task task);

        /// <summary>
        /// Обновить задачу.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        /// <param name="task">Обновляемая задача.</param>
        void Update(string id, Task task);

        /// <summary>
        /// Удалить задачу.
        /// </summary>
        /// <param name="id">Идентификатор.</param>
        void Delete(string id);
    }
}

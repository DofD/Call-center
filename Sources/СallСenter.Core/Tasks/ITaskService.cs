using System.Collections.Generic;

namespace СallСenter.Core.Tasks
{
    /// <summary>
    ///     Сервис по обработки задач.
    /// </summary>
    public interface ITaskService
    {
        /// <summary>
        ///     Получить все задачи.
        /// </summary>
        /// <returns></returns>
        List<Task> GetAllTasks();

        /// <summary>
        ///     Получить задачу.
        /// </summary>
        /// <param name="id">Идентификатор задачи.</param>
        /// <returns>Найденая задача.</returns>
        Task GetTask(string id);

        /// <summary>
        ///     Добавить новую задачу.
        /// </summary>
        /// <param name="task">Новая задача.</param>
        string Add(Task task);

        /// <summary>
        ///     Обновить задачу.
        /// </summary>
        /// <param name="id">Идентификатор задачи.</param>
        /// <param name="task">Задача.</param>
        void Update(string id, Task task);

        /// <summary>
        ///     Удалить задачу
        /// </summary>
        /// <param name="id"></param>
        void Remove(string id);
    }
}
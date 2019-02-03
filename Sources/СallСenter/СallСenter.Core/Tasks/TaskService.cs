using System;
using System.Collections.Generic;

namespace СallСenter.Core.Tasks
{
    /// <inheritdoc />
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository repository;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="TaskService" />.
        /// </summary>
        /// <param name="repository">Репозиторий задач.</param>
        public TaskService(ITaskRepository repository)
        {
            this.repository = repository;
        }

        public List<Task> GetAllTasks()
        {
            return repository.GetAll();
        }

        /// <inheritdoc />
        public Task GetTask(string id)
        {
            return repository.Get(id);
        }

        /// <inheritdoc />
        public string Add(Task task)
        {
            string id = Guid.NewGuid().ToString();
            repository.Insert(id, task);

            return id;
        }

        /// <inheritdoc />
        public void Update(string id, Task task)
        {
            var taskExist = repository.Get(id);
            if (taskExist != null)
            {
                repository.Update(id, task);
            }
        }

        /// <inheritdoc />
        public void Remove(string id)
        {
            var taskExist = repository.Get(id);
            if (taskExist != null)
            {
                repository.Delete(id);
            }
        }
    }
}
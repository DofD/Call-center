using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using СallСenter.Core.Tasks;

namespace СallСenter.Data.Tasks
{
    /// <inheritdoc />
    public class TaskRepository : ITaskRepository
    {
        private readonly IMapper mapper;


        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="TaskRepository" />.
        /// </summary>
        /// <param name="mapper">Мапер данных.</param>
        public TaskRepository(IMapper mapper)
        {
            this.mapper = mapper;
        }

        /// <inheritdoc />
        public List<Task> GetAll()
        {
            using (var db = new TaskContext())
            {
                List<TaskDto> tasks = db.Tasks.ToList();
                return mapper.Map<List<Task>>(tasks);
            }
        }

        /// <inheritdoc />
        public Task Get(string id)
        {
            using (var db = new TaskContext())
            {
                TaskDto taskDto = db.Tasks.FirstOrDefault(dto => dto.Id == id);
                return mapper.Map<Task>(taskDto);
            }
        }

        /// <inheritdoc />
        public void Insert(string id, Task task)
        {
            using (var db = new TaskContext())
            {
                TaskDto taskDto = mapper.Map<TaskDto>(task);
                taskDto.Id = id;

                db.Tasks.Add(taskDto);
            }
        }

        /// <inheritdoc />
        public void Update(string id, Task task)
        {
            using (var db = new TaskContext())
            {
                TaskDto taskDtoExist = db.Tasks.FirstOrDefault(dto => dto.Id == id);
                if (taskDtoExist != null)
                {
                    TaskDto taskDtoNew = mapper.Map<TaskDto>(task);
                    taskDtoNew.Id = id;

                    db.Entry(taskDtoExist).CurrentValues.SetValues(task);

                    db.SaveChanges();
                }
            }
        }

        /// <inheritdoc />
        public void Delete(string id)
        {
            using (var db = new TaskContext())
            {
                TaskDto taskDto = db.Tasks.FirstOrDefault(dto => dto.Id == id);
                if (taskDto != null)
                {
                    db.Tasks.Remove(taskDto);
                }
            }
        }
    }
}

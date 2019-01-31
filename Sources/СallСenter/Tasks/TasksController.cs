﻿using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using СallСenter.Core.Tasks;

namespace СallСenter.Tasks
{
    [Route("api/[controller]")]
    public class TasksController : Controller
    {
        private readonly ITaskService service;
        private readonly IMapper mapper;

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="TasksController" />.
        /// </summary>
        /// <param name="service">Сервис по работе с задачами.</param>
        /// <param name="mapper">Мапер данных.</param>
        public TasksController(ITaskService service, IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<TaskModel> Get()
        {
            List<Task> tasks = service.GetAllTasks();
            return mapper.Map<List<TaskModel>>(tasks);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public TaskModel Get(string id)
        {
            Task task = service.GetTask(id);
            return mapper.Map<TaskModel>(task);
        }

        // POST api/values
        [HttpPost]
        public void Post(TaskModel taskModel)
        {
            Task task = mapper.Map<Task>(taskModel);
            service.Add(task);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody]TaskModel taskModel)
        {
            Task task = mapper.Map<Task>(taskModel);
            service.Update(id, task);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            service.Remove(id);
        }
    }
}

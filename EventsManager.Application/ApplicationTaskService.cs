using AutoMapper;
using EventsManager.Application.Dtos;
using EventsManager.Application.Interfaces;
using EventsManager.Domain.Entity;
using EventsManager.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace EventsManager.Application
{
    public class ApplicationTaskService : IApplicationTaskService
    {
        private readonly ITaskService taskService;

        private readonly IMapper mapper;

        public ApplicationTaskService(ITaskService taskService
                                      , IMapper mapper)
        {
            this.taskService = taskService;
            this.mapper = mapper;
        }

        public void Add(TaskDto taskDto)
        {
            var task = mapper.Map<Task>(taskDto);
            taskService.Add(task);
        }

        public IEnumerable<TaskDto> GetAll()
        {
            var tasks = taskService.GetAll();
            var tasksDto = mapper.Map<IEnumerable<TaskDto>>(tasks);

            return tasksDto;
        }

        public TaskDto GetById(int id)
        {
            var task = taskService.GetById(id);
            var tasksDto = mapper.Map<TaskDto>(task);

            return tasksDto;
        }

        public void Remove(TaskDto taskDto)
        {
            var task = mapper.Map<Task>(taskDto);
            taskService.Remove(task);
        }

        public void Update(TaskDto taskDto)
        {
            var task = mapper.Map<Task>(taskDto);
            taskService.Update(task);
        }
    }
}
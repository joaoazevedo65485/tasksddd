using EventsManager.Application.Dtos;
using System.Collections.Generic;

namespace EventsManager.Application.Interfaces
{
    public interface IApplicationTaskService
    {
        void Add(TaskDto taskDto);

        void Update(TaskDto taskDto);

        void Remove(TaskDto taskDto);

        IEnumerable<TaskDto> GetAll();

        TaskDto GetById(int id);
    }
}
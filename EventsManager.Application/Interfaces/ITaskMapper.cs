using EventsManager.Application.Dtos;
using EventsManager.Domain.Entity;
using System.Collections.Generic;

namespace EventsManager.Application.Interfaces
{
    public interface ITaskMapper
    {
        Task MapDtoToEntity(TaskDto taskDto);

        IEnumerable<TaskDto> MapperTasksListDto(IEnumerable<Task> tasks);

        TaskDto MapperEntityToDto(Task task);
    }
}
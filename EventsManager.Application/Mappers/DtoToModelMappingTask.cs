using AutoMapper;
using EventsManager.Application.Dtos;
using EventsManager.Domain.Entity;

namespace EventsManager.Application.Mappers
{
    public class DtoToModelMappingTask : Profile
    {
        public DtoToModelMappingTask()
        {
            TaskMap();
        }

        private void TaskMap()
        {
            CreateMap<TaskDto, Task>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.Tema, opt => opt.MapFrom(x => x.Tema))
            .ForMember(dest => dest.Local, opt => opt.MapFrom(x => x.Local))
            .ForMember(dest => dest.Data, opt => opt.MapFrom(x => x.Data))
            .ForMember(dest => dest.Participants, opt => opt.MapFrom(x => x.Participants))
            .ForMember(dest => dest.Lote, opt => opt.MapFrom(x => x.Lote));
        }
    }
}

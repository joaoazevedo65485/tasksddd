using AutoMapper;
using EventsManager.Application.Dtos;
using EventsManager.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EventsManager.Application.Mappers
{
    public class ModelToDtoMappingTask : Profile
    {
        public ModelToDtoMappingTask()
        {
            TaskDtoMap();
        }

        private void TaskDtoMap()
        {
            CreateMap<TaskDto, Task>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(x => x.Id))
            .ForMember(dest => dest.Tema, opt => opt.MapFrom(x => x.Tema))
            .ForMember(dest => dest.Local, opt => opt.MapFrom(x => x.Local))
            .ForMember(dest => dest.Data, opt => opt.MapFrom(x => x.Data))
            .ForMember(dest => dest.Participants, opt => opt.MapFrom(x => x.Participants))
            .ForMember(dest => dest.Lote, opt => opt.MapFrom(x => x.Lote));
        }
    }
}

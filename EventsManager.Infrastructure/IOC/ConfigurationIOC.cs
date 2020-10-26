using Autofac;
using AutoMapper;
using EventsManager.Application;
using EventsManager.Application.Interfaces;
using EventsManager.Application.Mappers;
using EventsManager.Domain.Interfaces.Repository;
using EventsManager.Domain.Interfaces.Services;
using EventsManager.Domain.Services;
using EventsManager.Infrastructure.Data.Repository;

namespace EventsManager.Infrastructure.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationTaskService>().As<IApplicationTaskService>();
            builder.RegisterType<TaskService>().As<ITaskService>();
            builder.RegisterType<TaskRepository>().As<ITaskRepository>();
            builder.Register(ctx => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new DtoToModelMappingTask());
                cfg.AddProfile(new ModelToDtoMappingTask());
            }));

            builder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>().InstancePerLifetimeScope();

            #endregion IOC
        }
    }
}
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;
using UvA.Nose.AzureMigratie.Poc.Data.Interfaces;
using UvA.Nose.AzureMigratie.Poc.Data.Repositories;
using UvA.Nose.AzureMigratie.Poc.Data.Services;
using UvA.Nose.AzureMigratie.Poc.Models.ViewModel;
using AutoMapper;

namespace UvA.Nose.AzureMigratie.Poc.Web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IPocRepository, PocRepository>();
            container.RegisterType<IPocService, PocService>();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Student, Data.DomainModel.Student>();
                cfg.CreateMap<Data.DomainModel.Student, Student>();
                cfg.CreateMap<Data.DomainModel.Course, Course>();
                cfg.CreateMap<Data.DomainModel.Enrollment, Enrollment>();
            });

            var mapper = config.CreateMapper();
            container.RegisterInstance<IMapper>(mapper);

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
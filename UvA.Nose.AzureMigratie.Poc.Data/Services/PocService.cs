using System;
using System.Collections.Generic;
using System.Text;
using UvA.Nose.AzureMigratie.Poc.Data.Interfaces;
using UvA.Nose.AzureMigratie.Poc.Models.ViewModel;
using AutoMapper;

namespace UvA.Nose.AzureMigratie.Poc.Data.Services
{
    public class PocService : IPocService
    {
        private IPocRepository pocRepository;
        private IMapper mapper;

        public PocService(IPocRepository pocRepository, IMapper mapper)
        {
            this.pocRepository = pocRepository ?? throw new ArgumentNullException($"pocRepository is null");
            this.mapper = mapper ?? throw new ArgumentNullException($"mapper is null");
        }
        public Student CreateStudent(Student student)
        {
            var studentDomain = MapViewModelToDomainModel(student);

            return MapDomainModelToViewModel(this.pocRepository.CreateStudent(studentDomain));
        }

        public bool DeleteStudent(int? id)
        {
            return this.pocRepository.DeleteStudent(id);
        }

        public Student EditStudent(Student student)
        {
            var studentDomain = MapViewModelToDomainModel(student);
            return MapDomainModelToViewModel(this.pocRepository.EditStudent(studentDomain));
        }

        public List<Student> GetAllStudents()
        {
            var returnList = new List<Student>();

            var students = this.pocRepository.GetAllStudents();
            foreach(var s in students)
            {
                returnList.Add(MapDomainModelToViewModel(s));
            }

            return returnList;
        }

        public Student GetDetails(int? id)
        {
            var student = this.pocRepository.GetDetails(id);
            return MapDomainModelToViewModel(student);
        }

        private DomainModel.Student MapViewModelToDomainModel(Student student)
        {
            var studentDomainModel = mapper.Map<Student, DomainModel.Student>(student);
            return studentDomainModel;
        }

        private Student MapDomainModelToViewModel(DomainModel.Student student)
        {
            var studentViewModel = mapper.Map<DomainModel.Student, Student>(student);
            return studentViewModel;
        }
    }
}

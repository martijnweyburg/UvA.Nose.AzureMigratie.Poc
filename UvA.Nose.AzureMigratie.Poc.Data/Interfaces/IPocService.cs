using System;
using System.Collections.Generic;
using System.Text;
using UvA.Nose.AzureMigratie.Poc.Models.ViewModel;

namespace UvA.Nose.AzureMigratie.Poc.Data.Interfaces
{
    public interface IPocService
    {
        List<Student> GetAllStudents();
        Student GetDetails(int? id);
        Student CreateStudent(Student student);
        Student EditStudent(Student student);
        bool DeleteStudent(int? id);
    }
}

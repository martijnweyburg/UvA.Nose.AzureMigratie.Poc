using UvA.Nose.AzureMigratie.Poc.Data.Interfaces;
using System;
using System.Data.Entity;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using UvA.Nose.AzureMigratie.Poc.Data.DomainModel;

namespace UvA.Nose.AzureMigratie.Poc.Data.Repositories
{
    public class PocRepository : IPocRepository
    {
        private SchoolContext db = new SchoolContext();
        public PocRepository()
        {
        }
        public List<Student> GetAllStudents()
        {
            return db.Students.ToList();
        }

        public Student GetDetails(int? id)
        {
            Student student = db.Students.Find(id);

            return student;
        }

        public Student CreateStudent(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
            return student;
        }

        public Student EditStudent(Student student)
        {
            db.Entry(student).State = EntityState.Modified;
            db.SaveChanges();
            return student;
        }

        public bool DeleteStudent(int? id)
        {
            Student student = db.Students.Find(id);
            db.Students.Remove(student);
            db.SaveChanges();
            return true;
        }
    }
}

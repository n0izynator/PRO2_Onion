using Microsoft.EntityFrameworkCore;
using Onion.Domain.Entities;
using Onion.Domain.Services;
using Onion.Infrastructure.MsSqlDbService.Service;
using System.Collections.Generic;
using System.Linq;

namespace Onion.Infrastructure.MsSqlDbService.Services
{
    public class MsSqlDbService : IStudentDbService
    {

        MsSqlDbContext _context = new MsSqlDbContext();

        public IEnumerable<Student> GetStudents()
        {
            return  _context.Student.ToList();
        }

        public bool EnrollStudent(Student newStudent, int semestr)
        {
            _context.Student.Add(newStudent);
            _context.SaveChanges();
            return true;
        }


    }
}

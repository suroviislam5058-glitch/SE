using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class StudentService
    {

        public static void Create(StudentDTO c)
        {

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<StudentDTO, Student>();
            });
            var mapper = new Mapper(config);
            var cnv = mapper.Map<Student>(c);
            DataAccessFactory.StudentData().Create(cnv);
            // new ConvocationRepo().RegistrationConvocation(cnv);
        }

        public static List<StudentDTO> Show(){
            var data = DataAccessFactory.StudentData().Show();
            var cfg = new MapperConfiguration(c => {c.CreateMap<Student, StudentDTO>();
        });
        var mapper = new Mapper(cfg);
        var mapped =mapper.Map<List<StudentDTO>>(data);
            return mapped;
        }

        public static StudentDTO Show(int id)
        {
            var data = DataAccessFactory.StudentData().Show(id);
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Student, StudentDTO>();
            });
            var mapper = new Mapper(cfg);
            var mapped = mapper.Map<StudentDTO>(data);  
            return mapped;
        }


        public static bool Update(StudentDTO studentDTO)
        {
            // Map StudentDTO to Student entity
            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<StudentDTO, Student>();
            });
            var mapper = new Mapper(cfg);
            var student = mapper.Map<Student>(studentDTO);

            // Call the data access layer to update the student
            var success = DataAccessFactory.StudentData().Update(student);
            return success;
        }
/*
        public static bool Delete(int id)
        {
            try
            {
                // Call the data access layer to get the student entity by id
                var student = DataAccessFactory.StudentData().Show(id);

                // If student exists, delete it
                if (student != null)
                {
                    // Configure AutoMapper to map Student to StudentDTO
                    var config = new MapperConfiguration(cfg =>
                    {
                        cfg.CreateMap<Student, StudentDTO>();
                    });

                    var mapper = new Mapper(config);
                    var studentDTO = mapper.Map<StudentDTO>(student);

                    // Call the data access layer to delete the student
                    var success = DataAccessFactory.StudentData().Delete(studentDTO);
                    return success;
                }
                else
                {
                    // Student not found
                    Console.WriteLine("Student not found.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                // Log any exceptions
                Console.WriteLine($"An error occurred while deleting student: {ex.Message}");
                return false;
            }
        }

*/


    }


}

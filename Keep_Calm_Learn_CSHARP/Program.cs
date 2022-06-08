using Keep_Calm_Learn_CSHARP.Data.IRepositories;
using Keep_Calm_Learn_CSHARP.Data.Repositories;
using Keep_Calm_Learn_CSHARP.Models;
using System;
using System.Collections.Generic;

namespace Keep_Calm_Learn_CSHARP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IStaffRepository repoStaff = new StaffRepository();
            TeacherRepository repoTeacher = new TeacherRepository();


            //repo.Create(new Staff()
            //{
            //    id = 1,
            //    firstname = "Ali",
            //    lastname = "Valiyev",
            //    age = 20,
            //    email = "ali@gmail.com"
            //});


            ///////////////////////////////////////////////////////////
            Staff newStaff = new Staff()
            {
                id = 1,
                firstname = "Xasan",
                lastname = "Mirzayev",
                age = 20,
                email = "haqqoniy@gmail.com"
            };


            /////////////////////////////////////////////////////////////
            Staff newStaff2 = new Staff()
            {
                id = 2,
                firstname = "Sunnat",
                lastname = "Hikamtullayev",
                age = 21,
                email = "sunnat@gmail.com",
                Address = new Address { Id = 1, Home = "myHome", Street = "myStreet" },
            };


            /////////////////////////////////////////////////////////////
            Order order1 = new Order()
            {
                Id = 1,
                Name = "books",
                Details = new List<OrderDetails>()
                {
                    new OrderDetails() { Id = 1, Name = "book1"},
                    new OrderDetails() { Id = 2, Name ="book2"},
                    new OrderDetails(){ Id = 3, Name ="book3"}
                }
            };

            /////////////////////////////////////////////////////////////
            Teacher teacher1 = new Teacher()
            {
                Id = 1,
                Name = "Elmurod"
            };

            //////////////////////////////////////////////////////////////
            Student student1 = new Student()
            {
                Id = 1,
                Name = "Xasan"
            };


            //////////////////////////////////////////////////////////////
            Student student2 = new Student()
            {
                Id = 2,
                Name = "Sarvar"
            };

            //teacher1.Students.Add(student1);
            //teacher1.Students.Add(student2);
            //repoTeacher.Create(teacher1);


            //////////////////////////////////////////////////////////////
            var getTeacher = repoTeacher.Get(1);
            foreach(var student in getTeacher.Students)
            {
                Console.WriteLine($"Teacher - {getTeacher.Name}, Student - {student.Name}");
            }
                


            //repoStaff.Create(newStaff2);

            //var a = repoStaff.Get(1);
            //Console.WriteLine(a.firstname);

            //var b = repoStaff.GetAll();
            //foreach (var item in b)
            //    Console.WriteLine(item.Address.Home);

            //repo.Update(1, newStaff);


            //repo.Delete(1);





        }
    }
}

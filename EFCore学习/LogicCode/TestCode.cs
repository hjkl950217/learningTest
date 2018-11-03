using EFCore学习.Data;
using EFCore学习.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCore学习.LogicCode
{
    public class TestCode
    {
        private readonly SchoolContext schoolContext;
        private readonly ILogger logger;

        public TestCode(SchoolContext schoolContext, ILoggerFactory loggerFactory)
        {
            this.schoolContext = schoolContext;
            this.logger = loggerFactory.CreateLogger("EF-Demo");
        }

        public void Run()
        {
            this.GetAsync();

            this.ReadData();

            this.CreateAndUpdateData();

            this.Update();
        }

        public void Show(string str)
        {
            this.logger.LogInformation(str);
        }

        //R
        public void GetAsync()
        {
            System.Console.WriteLine("R-获取集合数据");
            List<Student> students = this.schoolContext.Students.ToList();

            this.Show(students.ToJson());
        }

        //R
        public void ReadData()
        {
            this.logger.LogInformation("R-查找ID为2的相关学员数据");
            Student student = this.schoolContext.Students
                .Include(t => t.Enrollments)
                    .ThenInclude(e => e.Courses)
                .AsNoTracking()
                .FirstOrDefault(m => m.ID == 2);

            this.Show(student.ToJson());
        }

        //C 和 D
        public void CreateAndUpdateData()
        {
            this.logger.LogInformation("C D-添加学员");

            Student student = new Student()
            {
                EnrollmentDate = DateTime.Now,
                FirstName = "现",
                LastName = "在"
            };

            this.schoolContext.Students.Add(student);
            this.schoolContext.SaveChanges();

            var result = this.schoolContext.Students
                .FirstOrDefault(t => t.FirstName == "现");

            this.logger.LogInformation("新添加的成员：");
            this.Show(result?.ToJson());

            this.Show("添加成功");

            this.schoolContext.Students.Remove(result);
            this.schoolContext.SaveChanges();
        }

        //U
        public void Update()
        {
            this.logger.LogInformation("U-更新学员");

            var result = this.schoolContext.Students
                .Find(1);
            string tempStr = result.FirstName;

            result.FirstName = "AAAAAA";
            this.schoolContext.SaveChanges();

            this.logger.LogInformation("还原属性");
            result.FirstName = tempStr;

            this.schoolContext.SaveChanges();
        }
    }

    public static class Extensions
    {
        private static JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings()
        {
            Formatting = Formatting.Indented,
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
        };

        public static string ToJson<T>(this T obj)
        {
            return JsonConvert.SerializeObject(obj, jsonSerializerSettings);
        }
    }
}
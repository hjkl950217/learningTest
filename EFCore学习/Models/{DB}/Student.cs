using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCore学习.Models
{
    /// <summary>
    /// 学生
    /// </summary>
    [Table("Student")]
    public class Student
    {
        /// <summary>
        /// 主键
        /// </summary>
        [System.ComponentModel.DataAnnotations.Key]
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        /// <summary>
        /// 登记日期
        /// </summary>
        [DataType(DataType.DateTime)]
        public DateTime EnrollmentDate { get; set; }

        /// <summary>
        /// 导航属性-修读纪录
        /// </summary>
         public ICollection<Enrollment> Enrollments { get; set; }



    }




}

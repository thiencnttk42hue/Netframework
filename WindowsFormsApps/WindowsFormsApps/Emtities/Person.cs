using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApps.Emtities
{
    public class Person
    {
        /// <summary>
        /// Khóa chính
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Tên
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Họ
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Ngày sinh DOB = Date of Birth
        /// </summary>
        public DateTime DOB { get; set; }
        /// <summary>
        /// Giới tính
        /// </summary>
        public EGioiTinh Sex { get; set; }
        /// <summary>
        /// Quê quán
        /// </summary>
        public string HomeTown { get; set; }

        public string FullName
        {
            get
            {
                return $"{LastName} {FirstName}";
            }
        }
        public string IDKhoa { get; set; }


        /// <summary>
        /// Lấy toàn bộ danh sách sinh viên trong CSDL
        /// (MockData)
        /// </summary>
        /// <returns>
        /// Danh sách sinh viên
        /// </returns>
        public static List<Person> GetList()
        {
            var ls = new List<Person>();
            ls.Add(new Person
            {
                Id = "sv1",
                FirstName = "Nguyễn",
                LastName = "Thiện",
                DOB = new DateTime(2000, 08, 25),
                HomeTown = "Thừa Thiên Huế",
                Sex = EGioiTinh.Nam,
                IDKhoa = "1"
            });
            ls.Add(new Person
            {
                Id = "sv2",
                FirstName = "Nguyễn",
                LastName = "Thị Thảo",
                DOB = new DateTime(2000, 5, 6),
                HomeTown = "Đà Nẵng",
                Sex = EGioiTinh.Nu,
                IDKhoa = "2"
            });
            return ls;
        }
        /// <summary>
        /// Lấy một sinh viên từ CSDL
        /// </summary>
        /// <param name="id">Mã sinh viên cần lấy</param>
        /// <returns>
        /// Sinh viên có mã tương ứng hoặc null nếu không tìm thấy
        /// </returns>
        public static Person Get(string id)
        {
            var dbPerson = GetList();
            //Linq to SQL
            //Lamda expression
            var person = dbPerson.Where(p => p.Id == id).FirstOrDefault();
            return person;
        }
        public static List<Person> GetList(string idKhoa)
        {
            var ls = GetList();
            var rs = ls.Where(e => e.IDKhoa == idKhoa).ToList();
            return rs;
        }
    }
    public enum EGioiTinh
    {
        Nam, Nu, Khac
    }
}

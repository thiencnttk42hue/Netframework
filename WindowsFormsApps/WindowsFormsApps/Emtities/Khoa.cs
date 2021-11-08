using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApps.Emtities
{
    public class Khoa
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }

        public static List<Khoa> GetList()
        {
            List<Khoa> list = new List<Khoa>();
            list.Add(new Khoa
            {
                Id = "1",
                Name = "CNTT"

            });
            list.Add(new Khoa
            {
                Id = "2",
                Name = "Vật lý"

            });
            list.Add(new Khoa
            {
                Id = "3",
                Name = "Hóa học"

            });
            list.Add(new Khoa
            {
                Id = "4",
                Name = "Văn học"

            });
            list.Add(new Khoa
            {
                Id = "5",
                Name = "Triết"

            });
            return list;
        }
    }
}

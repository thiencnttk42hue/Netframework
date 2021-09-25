using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicWinform.Emtities
{
    public class HistorySV
    {
        public string Cap { get; set; }
        public string Truonghoc { get; set; }
        public float DiemTB { get; set; }
        public string Hanhkiem { get; set; }

        public static List<HistorySV> GetList()
        {
            var ds = new List<HistorySV>();
            ds.Add(new HistorySV
            {
                Cap = "Cấp 1",
                Truonghoc = "Trường Tiểu học số 2 Hương Xuân",
                DiemTB = 8f,
                Hanhkiem = "Tốt"
            });
            ds.Add(new HistorySV
            {
                Cap = "Cấp 2",
                Truonghoc = "Trường Trung học cơ sở Nguyễn Khánh Toàn",
                DiemTB = 8.2f,
                Hanhkiem = "Tốt"
            });
            ds.Add(new HistorySV
            {
                Cap = "Cấp 3",
                Truonghoc = "Trường Trung học phổ thông Hương Trà",
                DiemTB = 7.8f,
                Hanhkiem = "Tốt"
            });
            return ds;
        }

        public static HistorySV Get(string cap)
        {
            var dbHistorySV = GetList();
            var historySV = dbHistorySV.Where(p => p.Cap == cap).FirstOrDefault();
            return historySV;
        }
    }
}

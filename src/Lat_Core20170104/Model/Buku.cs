using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lat_Core20170104.Model
{
    [Table("buku")]
    public class Buku
    {
        public AppContext appContext;

        [Key]
        public string id { get; set; }
        public string judul { get; set; }
        public string pengarang { get; set; }



        public IQueryable<Buku> ReadAllBuku()
        {
            appContext = new AppContext();
            return appContext.buku;
        }

        public Buku ReadBuku(string id)
        {
            appContext = new AppContext();
            return appContext.buku.Where(f => f.id == id).FirstOrDefault();
        }

        public void CreateBuku()
        {
            appContext = new AppContext();
            appContext.Add(this);
            appContext.SaveChanges();
        }

        public void UpdateBuku()
        {
            appContext = new AppContext();
            Buku bukuBaru = new Buku();
            bukuBaru = appContext.buku.Where(f => f.id == "1").FirstOrDefault();
            bukuBaru.judul = "Laskar Pelangi 2";
            appContext.Update(bukuBaru);
            appContext.SaveChanges();
        }

        public void DeleteBuku()
        {
            appContext = new AppContext();
            Buku buku = new Buku();
            buku = appContext.buku.Where(f => f.id == "99").FirstOrDefault();

            if (buku != null)
            {
                appContext.Remove(buku);
                appContext.SaveChanges();
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Lat_Core20170104.Model;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Lat_Core20170104.Controllers
{
    public class BukuController : Controller
    {
        public Buku buku;
        // GET: /<controller>/
        public IActionResult Index()
        {
            buku = new Buku();

            buku.UpdateBuku();
            buku.DeleteBuku();


            BukuViewModel bukuViewModel = new BukuViewModel
            {
                AllBuku = buku.ReadAllBuku()
            };

            return View(bukuViewModel);
        }

     
    }
}

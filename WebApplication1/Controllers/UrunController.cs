using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication1.DAL;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class UrunController : Controller
    {
        UrunDB db = new UrunDB();   
        //.exe dosyalarda main bulunur
        //DLL dosyalarında main metodu bulunmaz
        public IActionResult Index()
        {
            //Console.WriteLine("Merhaba");
            //ViewData["mesaj1"] = "Mesaj 1";
            //ViewBag.Mesaj2 = "Çalış";
            ViewBag.Kategoriler = new SelectList(db.TumKategoriler(),"KategoriID","KategoriAdi");
            return View(db.TumUrunler());
        }
        public IActionResult UrunEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UrunEkle(Urun urun)
        {
            db.UrunEkle(urun);
            return RedirectToAction("Index");
        }
    }
}
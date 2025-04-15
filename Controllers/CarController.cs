using CarInfo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInfo.Controllers
{
    public class CarController : Controller
    {
        private VehicleEntities dbo = new VehicleEntities();
        // GET: Car
        public ActionResult Index()
        {
            var car = dbo.TblCars.ToList();
            return View(car);
        }
        [HttpGet]
        public ActionResult CarDetails(int id)
        {
            var car = dbo.TblCars.FirstOrDefault(c=>c.Car_Id == id);
            return View(car);
        }
        public ActionResult InsertCar()
         {
            //ViewBag.Car = new SelectList(dbo.TblCars);
            return View();
        }
        [HttpPost]
        public ActionResult InsertCar(TblCar car)
        {
            if(ModelState.IsValid)
            {
                dbo.TblCars.Add(car);
                dbo.SaveChanges();
                return RedirectToAction("Index");
            }
            //ViewBag.Car = new SelectList(dbo.TblCars, car.Car_Id);
            return View(car);
        }
        public ActionResult EditCar(int id)
        {
            var car = dbo.TblCars.Find(id);
            return View(car);
        }
        [HttpPost]
        public ActionResult EditCar(TblCar car)
        {
            if(ModelState.IsValid)
            {
                dbo.Entry(car).State = EntityState.Modified;
                dbo.TblCars.Add(car);
                dbo.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(car);
        }
        public ActionResult DeleteCar(int id)
        {
            var car = dbo.TblCars.Find(id);
            return View(car);
        }
        [HttpPost]
        public ActionResult DeleteCar(TblCar car)
        {
            var dcar = dbo.TblCars.Find(car.Car_Id);
            if(dcar != null)
            {
                dbo.TblCars.Remove(dcar);
                dbo.SaveChanges();
            }
           
            return RedirectToAction("Index");
            
        }

    }
}
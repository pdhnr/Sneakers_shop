﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sneakers_shop.Models;

namespace Sneakers_shop.Controllers
{
    public class AdminController : Controller
    {
       

        private static AppDbContext context = new AppDbContext();

        public static List<Admin_Model> admin_ModelsList = context.admin_Models.ToList();

        //public static List<Admin_Model> db = context.admin_Models.ToList();



        ////////////////////////////////////////////////////////////////////////
        //login//


        [HttpGet]
        public IActionResult login()
        {
            return View();
        }



        [HttpPost]
        public IActionResult login(Admin_Model admin_Model)
        {
            //Admin_Model am = admin_ModelsList.Where(x => x.Ad_Surename == admin_Model && x.Ad_Password == admin_Model.Ad_Password).SingleOrDefault();

            //Admin_Model am = admin_ModelsList.Find(x => x.Ad_Surename == admin_Model && x.Ad_Password == admin_Model.Ad_Password)

            Admin_Model amL = admin_ModelsList.Where(x => x.Ad_Surename
            == admin_Model.Ad_Surename && x.Ad_Password == admin_Model.Ad_Password).SingleOrDefault();

            if( amL != null)
            {
                return RedirectToAction("Create");
            }
            else 
            {
                ViewBag.error = "Nie prawidłowy urzytkownik lub hasło ";//Invaild username or password
            }
            return View();

            
            
            
            /* if(ad != null) 
             { 
                 Session["Ad_Id"] = ad.Ad_Id.ToString();
                 RedirectToAction("Create");
             }*/








        }

        ////////////////////////////////////////////////////////////////////////
        public IActionResult Create()
        {
            return View();
        }
    }
}

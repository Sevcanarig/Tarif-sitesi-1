using Microsoft.AspNetCore.Mvc;
using TarifApp.Models;
using System.Collections.Generic;

namespace TarifApp.Controllers;

    public class TarifController : Controller{
        
        public IActionResult Details(int? id){
            if(id==null){
                return RedirectToAction("List");
            }
            var yemek = Repository.GetById(id);
            
            return View(yemek);
        }
    
        public IActionResult List(){
            return View(Repository.Tarifler);
        }
    }
    
    
    


        

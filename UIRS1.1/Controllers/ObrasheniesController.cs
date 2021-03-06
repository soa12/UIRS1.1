﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UIRS1._1.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace UIRS1._1.Controllers
{
    public class ObrasheniesController : Controller
    {
        private UIRS_DB db = new UIRS_DB();

       

        // GET: Obrashenies/Create
        public ActionResult Create()
        {
            ViewBag.ID_Point = new SelectList(db.POINT, "ID", "NAME");
            ViewBag.ID_Route = new SelectList(db.ROUTE, "ID", "NUMBER");
            ViewBag.ID_Vehicle = new SelectList(db.VEHICLE, "ID", "STATE_NUMBER");
            return View();
        }

        // POST: Obrashenies/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID_Obrasheniya,Lastname,FirstName,Surname,Email,Phone,Texttreatment,Date,Time,Waiting,FIOdriver,FIOconductor,FIOdispetcher,Earlyend,LateBeginning,BigInterval,BreachShedule,StopTravel,ViolationLanding,OutputWithoutContract,ViolationOfTrafficPatterns,VioletionOfTrafficRules,ConflictWithConductor,ConflictWithDriver,WrongSurrendere,NotAnnouncedBusstop,SmokingInCabin,DiscussionOnPhone,LoudMusic,LackOfTickets,FaultyBus,SmellOfGus,PoorSanCondition,WorkBoards,WorkSite,WorkSmsService,WorkOnlineMap,WorkWebBoards,WorkMobileApplication,PoorStateReversalArea,PoorStateBusstop,DisadvantageOfInfrastructures,ConflictWithDispather,ComplianceWithShedule,GoodQualityService,CourteousStaff,GoodTransportCondition,ID_Route,ID_Vehicle,ID_Point")] Obrashenies obrashenies)
        {
            var response = Request["g-recaptcha-response"];
            string secretKey = "6LesiCQUAAAAAHyvUcxx5IbYe3iQyN8B4x5-vJe-";
            var client = new WebClient();
            var result = client.DownloadString(string.Format("https://www.google.com/recaptcha/api/siteverify?secret={0}&response={1}", secretKey, response));
            var obj = JObject.Parse(result);
            //var status = (bool)obj.SelectToken("succes");
            var status = (bool)obj.First;
            ViewBag.Message = status ? "Верно" : "Не верно";

            if (ModelState.IsValid && status)
            {
                obrashenies.ID_Obrasheniya = Guid.NewGuid();
                db.Obrashenies.Add(obrashenies);
                db.SaveChanges();
                //return RedirectToAction("Index");
                return View("AfterSubmit");
            }

            ViewBag.ID_Point = new SelectList(db.POINT, "ID", "NAME", obrashenies.ID_Point);
            ViewBag.ID_Route = new SelectList(db.ROUTE, "ID", "NUMBER", obrashenies.ID_Route);
            ViewBag.ID_Vehicle = new SelectList(db.VEHICLE, "ID", "STATE_NUMBER", obrashenies.ID_Vehicle);
            return View(obrashenies);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;
using System.Linq;
using miide.Models;
using DALco;
using miide;
using Microsoft.ML;
using static Microsoft.ML.DataOperationsCatalog;
using System;
using ServiceStack;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using miide.helper;
using Newtonsoft.Json;

namespace Dal.Controllers
{
        public class HomepharmacyController : Controller
        {

                public readonly data_collection db;
                private readonly SessionMnger session;
                private readonly IWebHostEnvironment _hostingEnvironment;

                public HomepharmacyController(data_collection info, SessionMnger session)
                {
                        this.db = info;
                        this.session = session;
                }
                public IActionResult Index()
                {


                        return View();
                }
              
                [HttpGet]
                public IActionResult login()
                {
                        return View();
                }

                [HttpPost]
                public IActionResult login(model_user model)
                {
                        var user = db.user_table.SingleOrDefault(x => x.username == model.username && x.password == model.password);
                        if (user != null && ModelState.IsValid)
                        {
                                session.FullName = user.password;
                                session.IsAdmin = true;

                                return RedirectToAction("Drug");
                        }

                        return View();

                }


                public ActionResult logout()
                {
                        session.ClearSession();
                        return RedirectToAction("Index");

                }
                public ActionResult About()
                {
                        return View();

                }

       
              
                [HttpGet]
                [ActionName("delete")]
                public ActionResult deleteconfarm(int id)
                {       //find if not found return null  
                        var drugs = db.drug_table.Find(id);
                        if (drugs != null)
                        {
                                return View(drugs);

                        }


                        return RedirectToAction("ItemNotFound");

                }
                [HttpPost]
                public ActionResult delete(int id)
                {


                        var drugs = db.drug_table.Find(id);
                        if (drugs != null)
                        {
                                db.drug_table.Remove(drugs);
                                db.SaveChanges();
                                return RedirectToAction("Drug");


                        }



                        return RedirectToAction("ItemNotFound");

                }


                [HttpGet]

                public ActionResult Edit(int id)
                {

                        var edit_drug = db.drug_table.SingleOrDefault(x => x.id == id);
                        if (edit_drug == null)
                        {

                                return RedirectToAction("ItemNotFound");

                        }
                        return View(edit_drug);

                }
                [HttpPost]

                public ActionResult Edit(drug model)
                {
                        if (ModelState.IsValid)
                     
                        
                        {

                                db.Entry(model).State = EntityState.Modified;

                                db.SaveChanges();


                                return RedirectToAction("Drug");
                        }

                        return RedirectToAction("ItemNotFound");

                }

                [HttpGet]
                public ActionResult Drug()
                {
                        //if (!session.IsAuthorized)
                        //        return RedirectToAction("login");
                        var list = db.drug_table.Select(x => new information_drug
                        {
                                id=x.id,
                        
                                trade_name = x.trade_name,
                                Scientific_name = x.Scientific_name,

                                cost = x.cost,
                                package_size = x.package_size,
                                how_to_use = x.how_to_use,

                                medicine_caliber = x.medicine_caliber,
                                The_number_of_medicine = x.The_number_of_medicine,
                                description = x.description,

                        }).ToList();
                        return View(list);

                }



                [HttpGet]
                public ActionResult create()
                {
                        return View();

                }
                [HttpPost]
                public IActionResult create(drug c)
                {
                        if (ModelState.IsValid)
                        {
                              

                                db.drug_table.Add(c);
                                db.SaveChanges();
                                return RedirectToAction("Drug");


                        }

                        return View();

                }

             

                [HttpPost]
                public ActionResult Drug(List<information_drug> drug)
                {

                        return Json(new { result = drug });


                }






           
                [HttpGet]
                public IActionResult prediction()
                {
                        List<string> list = typeof(inputdatamodel).GetProperties().Where(x => x.Name != "Label").Select(x => x.Name).ToList();


                        return View(list);

                }

                [HttpPost]
                public IActionResult prediction(List<string> symptoms)
                {





                        MLContext mLContext = new MLContext();
                        IDataView traindataview = mLContext.Data.LoadFromTextFile<inputdatamodel>(path: @"C:\Users\atef\Desktop\New folder (3)\jk\consolee\newDataset.csv", hasHeader: true, separatorChar: ',');

                        string featuresColumnName = "Features";

                        var dataProcessPipeline = mLContext.Transforms.Conversion.MapValueToKey("Label")
                                                          .Append(mLContext.Transforms.Concatenate("Features", new[] { "abdominal_pain", "abnormal_menstruation", "acidity", "acute_liver_failure", "altered_sensorium", "anxiety", "back_pain", "belly_pain", "blackheads", "bladder_discomfort", "blister", "blood_in_sputum", "bloody_stool", "blurred_and_distorted_vision", "breathlessness", "brittle_nails", "bruising", "burning_micturition", "chest_pain", "chills", "cold_hands_and_feets", "coma", "congestion", "constipation", "continuous_feel_of_urine", "continuous_sneezing", "cough", "cramps", "dark_urine", "dehydration", "depression", "diarrhoea", "dischromic _patches", "distention_of_abdomen", "dizziness", "drying_and_tingling_lips", "enlarged_thyroid", "excessive_hunger", "extra_marital_contacts", "family_history", "fast_heart_rate", "fatigue", "fluid_overload", "foul_smell_of urine", "headache", "high_fever", "hip_joint_pain", "history_of_alcohol_consumption", "increased_appetite", "indigestion", "inflammatory_nails", "internal_itching", "irregular_sugar_level", "irritability", "irritation_in_anus", "itching", "joint_pain", "knee_pain", "lack_of_concentration", "lethargy", "loss_of_appetite", "loss_of_balance", "loss_of_smell", "malaise", "mild_fever", "mood_swings", "movement_stiffness", "mucoid_sputum", "muscle_pain", "muscle_wasting", "muscle_weakness", "nausea", "neck_pain", "nodal_skin_eruptions", "obesity", "pain_behind_the_eyes", "pain_during_bowel_movements", "pain_in_anal_region", "painful_walking", "palpitations", "passage_of_gases", "patches_in_throat", "phlegm", "polyuria", "prominent_veins_on_calf", "puffy_face_and_eyes", "pus_filled_pimples", "receiving_blood_transfusion", "receiving_unsterile_injections", "red_sore_around_nose", "red_spots_over_body", "redness_of_eyes", "restlessness", "runny_nose", "rusty_sputum", "scurring", "shivering", "silver_like_dusting", "sinus_pressure", "skin_peeling", "skin_rash", "slurred_speech", "small_dents_in_nails", "spinning_movements", "spotting_ urination", "stiff_neck", "stomach_bleeding", "stomach_pain", "sunken_eyes", "sweating", "swelled_lymph_nodes", "swelling_joints", "swelling_of_stomach", "swollen_blood_vessels", "swollen_extremeties", "swollen_legs", "throat_irritation", "toxic_look_(typhos)", "ulcers_on_tongue", "unsteadiness", "visual_disturbances", "vomiting", "watering_from_eyes", "weakness_in_limbs", "weakness_of_one_body_side", "weight_gain", "weight_loss", "yellow_crust_ooze", "yellow_urine", "yellowing_of_eyes", "yellowish_skin" }))

                                                          .AppendCacheCheckpoint(mLContext);


                        var naiveBayes = dataProcessPipeline.Append(mLContext.MulticlassClassification.Trainers.NaiveBayes(labelColumnName: "Label", featureColumnName: featuresColumnName))

                                .Append(mLContext.Transforms.Conversion.MapKeyToValue("PredictedLabel"));

                        TrainTestData trainTestData = mLContext.Data.TrainTestSplit(traindataview, testFraction: 0.2);

                        var model = naiveBayes.Fit(trainTestData.TrainSet);

                        var matrice = mLContext.MulticlassClassification.Evaluate(model.Transform(trainTestData.TrainSet));

                        var datatype = typeof(inputdatamodel);
                        var obj = Activator.CreateInstance(datatype);
                        foreach (var item in symptoms)
                        {
                                datatype.GetProperty(item).SetValue(obj, 1F);

                        }




                        var predictions = mLContext.Model.CreatePredictionEngine<inputdatamodel, outputmodel>(model);
                        var predictiondisease = predictions.Predict((inputdatamodel)
                        obj);

                        // return   RedirectToAction("ShowPred", new { id = predictiondisease.Prediction });
                        return Json(new PredictionModel { DiseaseName = predictiondisease.Prediction, SymptomsList = symptoms });
                }

                [HttpPost]
                public IActionResult ShowPred(PredictionModel model)
                {


                        var disease = db.diseases_table
                                 .Include(x => x.disease_drugs)
                                 .ThenInclude(x => x.drugs)
                                 .FirstOrDefault(x => x.name_OF_disease == model.DiseaseName);
                        if (disease != null)
                        {
                                model.DrugsList = disease.disease_drugs.Select(x => x.drugs).ToList(); ;
                        }

                        return PartialView(model);
                }


                public IActionResult ItemNotFound()
                {
                        return View();
                }

        }
}
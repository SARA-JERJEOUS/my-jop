
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using DALco;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.ML;
using Microsoft.ML.Trainers;
using Microsoft.ML.Data;
using Microsoft.ML.Transforms;
using static Microsoft.ML.DataOperationsCatalog;
using miide;

namespace Dal
{
    public class Program
    {
                static readonly string path = Path.Combine(Environment.CurrentDirectory, "Model.zip");
                public static void Main(string[] args)
                {
                        CreateHostBuilder(args).Build().Run();
                        /*

                        MLContext mLContext = new MLContext();
                        IDataView traindataview = mLContext.Data.LoadFromTextFile<inputdatamodel>(path: @"C:\Users\atef\Desktop\jk\consolee\newDataset.csv", hasHeader: true, separatorChar: ',');

                        string featuresColumnName = "Features";

                        var dataProcessPipeline = mLContext.Transforms.Conversion.MapValueToKey("Label")
                                                          .Append(mLContext.Transforms.Concatenate("Features", new[] { "abdominal_pain", "abnormal_menstruation", "acidity", "acute_liver_failure", "altered_sensorium", "anxiety", "back_pain", "belly_pain", "blackheads", "bladder_discomfort", "blister", "blood_in_sputum", "bloody_stool", "blurred_and_distorted_vision", "breathlessness", "brittle_nails", "bruising", "burning_micturition", "chest_pain", "chills", "cold_hands_and_feets", "coma", "congestion", "constipation", "continuous_feel_of_urine", "continuous_sneezing", "cough", "cramps", "dark_urine", "dehydration", "depression", "diarrhoea", "dischromic _patches", "distention_of_abdomen", "dizziness", "drying_and_tingling_lips", "enlarged_thyroid", "excessive_hunger", "extra_marital_contacts", "family_history", "fast_heart_rate", "fatigue", "fluid_overload", "foul_smell_of urine", "headache", "high_fever", "hip_joint_pain", "history_of_alcohol_consumption", "increased_appetite", "indigestion", "inflammatory_nails", "internal_itching", "irregular_sugar_level", "irritability", "irritation_in_anus", "itching", "joint_pain", "knee_pain", "lack_of_concentration", "lethargy", "loss_of_appetite", "loss_of_balance", "loss_of_smell", "malaise", "mild_fever", "mood_swings", "movement_stiffness", "mucoid_sputum", "muscle_pain", "muscle_wasting", "muscle_weakness", "nausea", "neck_pain", "nodal_skin_eruptions", "obesity", "pain_behind_the_eyes", "pain_during_bowel_movements", "pain_in_anal_region", "painful_walking", "palpitations", "passage_of_gases", "patches_in_throat", "phlegm", "polyuria", "prominent_veins_on_calf", "puffy_face_and_eyes", "pus_filled_pimples", "receiving_blood_transfusion", "receiving_unsterile_injections", "red_sore_around_nose", "red_spots_over_body", "redness_of_eyes", "restlessness", "runny_nose", "rusty_sputum", "scurring", "shivering", "silver_like_dusting", "sinus_pressure", "skin_peeling", "skin_rash", "slurred_speech", "small_dents_in_nails", "spinning_movements", "spotting_ urination", "stiff_neck", "stomach_bleeding", "stomach_pain", "sunken_eyes", "sweating", "swelled_lymph_nodes", "swelling_joints", "swelling_of_stomach", "swollen_blood_vessels", "swollen_extremeties", "swollen_legs", "throat_irritation", "toxic_look_(typhos)", "ulcers_on_tongue", "unsteadiness", "visual_disturbances", "vomiting", "watering_from_eyes", "weakness_in_limbs", "weakness_of_one_body_side", "weight_gain", "weight_loss", "yellow_crust_ooze", "yellow_urine", "yellowing_of_eyes", "yellowish_skin" }))

                                                          .AppendCacheCheckpoint(mLContext);


                        var naiveBayes = dataProcessPipeline.Append(mLContext.MulticlassClassification.Trainers.NaiveBayes(labelColumnName: "Label", featureColumnName: featuresColumnName))

                                .Append(mLContext.Transforms.Conversion.MapKeyToValue("PredictedLabel"));

                        TrainTestData trainTestData = mLContext.Data.TrainTestSplit(traindataview, testFraction: 0.2);

                        var model = naiveBayes.Fit(trainTestData.TrainSet);

                        var matrice = mLContext.MulticlassClassification.Evaluate(model.Transform(trainTestData.TrainSet));

                        inputdatamodel predictiondata = new inputdatamodel()
                        {
                                Abdominal_pain = 0F,
                                Abnormal_menstruation = 0F,
                                Acidity = 0F,
                                Acute_liver_failure = 0F,
                                Altered_sensorium = 0F,
                                Anxiety = 0F,
                                Back_pain = 0F,
                                Belly_pain = 0F,
                                Blackheads = 0F,
                                Bladder_discomfort = 0F,
                                Blister = 0F,
                                Blood_in_sputum = 0F,
                                Bloody_stool = 0F,
                                Blurred_and_distorted_vision = 0F,
                                Breathlessness = 0F,
                                Brittle_nails = 0F,
                                Bruising = 0F,
                                Burning_micturition = 0F,
                                Chest_pain = 0F,
                                Chills = 0F,
                                Cold_hands_and_feets = 0F,
                                Coma = 0F,
                                Congestion = 0F,
                                Constipation = 0F,
                                Continuous_feel_of_urine = 0F,
                                Continuous_sneezing = 0F,
                                Cough = 0F,
                                Cramps = 0F,
                                Dark_urine = 0F,
                                Dehydration = 0F,
                                Depression = 0F,
                                Diarrhoea = 0F,
                                Dischromic__patches = 1F,
                                Distention_of_abdomen = 0F,
                                Dizziness = 0F,
                                Drying_and_tingling_lips = 0F,
                                Enlarged_thyroid = 0F,
                                Excessive_hunger = 0F,
                                Extra_marital_contacts = 0F,
                                Family_history = 0F,
                                Fast_heart_rate = 0F,
                                Fatigue = 0F,
                                Fluid_overload = 0F,
                                Foul_smell_of_urine = 0F,
                                Headache = 0F,
                                High_fever = 0F,
                                Hip_joint_pain = 0F,
                                History_of_alcohol_consumption = 0F,
                                Increased_appetite = 0F,
                                Indigestion = 0F,
                                Inflammatory_nails = 0F,
                                Internal_itching = 0F,
                                Irregular_sugar_level = 0F,
                                Irritability = 0F,
                                Irritation_in_anus = 0F,
                                Itching = 1F,
                                Joint_pain = 0F,
                                Knee_pain = 0F,
                                Lack_of_concentration = 0F,
                                Lethargy = 0F,
                                Loss_of_appetite = 0F,
                                Loss_of_balance = 0F,
                                Loss_of_smell = 0F,
                                Malaise = 0F,
                                Mild_fever = 0F,
                                Mood_swings = 0F,
                                Movement_stiffness = 0F,
                                Mucoid_sputum = 0F,
                                Muscle_pain = 0F,
                                Muscle_wasting = 0F,
                                Muscle_weakness = 0F,
                                Nausea = 0F,
                                Neck_pain = 0F,
                                Nodal_skin_eruptions = 1F,
                                Obesity = 0F,
                                Pain_behind_the_eyes = 0F,
                                Pain_during_bowel_movements = 0F,
                                Pain_in_anal_region = 0F,
                                Painful_walking = 0F,
                                Palpitations = 0F,
                                Passage_of_gases = 0F,
                                Patches_in_throat = 0F,
                                Phlegm = 0F,
                                Polyuria = 0F,
                                Prominent_veins_on_calf = 0F,
                                Puffy_face_and_eyes = 0F,
                                Pus_filled_pimples = 0F,
                                Receiving_blood_transfusion = 0F,
                                Receiving_unsterile_injections = 0F,
                                Red_sore_around_nose = 0F,
                                Red_spots_over_body = 0F,
                                Redness_of_eyes = 0F,
                                Restlessness = 0F,
                                Runny_nose = 0F,
                                Rusty_sputum = 0F,
                                Scurring = 0F,
                                Shivering = 0F,
                                Silver_like_dusting = 0F,
                                Sinus_pressure = 0F,
                                Skin_peeling = 0F,
                                Skin_rash = 1F,
                                Slurred_speech = 0F,
                                Small_dents_in_nails = 0F,
                                Spinning_movements = 0F,
                                Spotting__urination = 0F,
                                Stiff_neck = 0F,
                                Stomach_bleeding = 0F,
                                Stomach_pain = 0F,
                                Sunken_eyes = 0F,
                                Sweating = 0F,
                                Swelled_lymph_nodes = 0F,
                                Swelling_joints = 0F,
                                Swelling_of_stomach = 0F,
                                Swollen_blood_vessels = 0F,
                                Swollen_extremeties = 0F,
                                Swollen_legs = 0F,
                                Throat_irritation = 0F,
                                Toxic_look__typhos_ = 0F,
                                Ulcers_on_tongue = 0F,
                                Unsteadiness = 0F,
                                Visual_disturbances = 0F,
                                Vomiting = 0F,
                                Watering_from_eyes = 0F,
                                Weakness_in_limbs = 0F,
                                Weakness_of_one_body_side = 0F,
                                Weight_gain = 0F,
                                Weight_loss = 0F,
                                Yellow_crust_ooze = 0F,
                                Yellow_urine = 0F,
                                Yellowing_of_eyes = 0F,
                                Yellowish_skin = 0F,
                        };
                        var predictions = mLContext.Model.CreatePredictionEngine<inputdatamodel, outputmodel>(model);
                        var predictiondisease = predictions.Predict(predictiondata);
                        Console.WriteLine(predictiondisease.Prediction);



































                        


















                        */
                }
                
     public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

              
        }
}

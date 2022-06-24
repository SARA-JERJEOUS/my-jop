using DALco;
using consolee;
using System;
using System.Linq;
using Microsoft.ML;
using Microsoft.ML.Trainers;
using Microsoft.ML.Data;
using Microsoft.ML.Transforms;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using static Microsoft.ML.DataOperationsCatalog;
using Microsoft.Extensions.DependencyInjection;

namespace consolee
{
        class Program
        {
                static void Main(string[] args)
                {
                        Console.WriteLine("Hello World!");

                        const string conStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=datapharma;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";



                        var services = new ServiceCollection();

                        //   services.AddSingleton<OrderService>();
                        services.AddDbContext<data_collection>(options => options.UseSqlServer(conStr));
                        ServiceProvider serviceProvider = services.BuildServiceProvider();
                        var db = serviceProvider.GetService<data_collection>();





                        var s = db.diseases_table.ToList();

                        List<disease> q = new List<disease>
                        {
                                     new  disease{name_OF_disease="Fungal infection"},
                                     new  disease{name_OF_disease="Allergy"},

                                     new  disease{name_OF_disease="GERD"},
                                     new  disease{name_OF_disease="Chronic cholestasis"},
                                     new  disease{name_OF_disease="Drug Reaction"},
                                     new  disease{name_OF_disease="Peptic ulcer diseae"},

                                     new  disease{name_OF_disease="AIDS"},
                                     new  disease{name_OF_disease="Diabetes"},
                                      new  disease{name_OF_disease="Gastroenteritis"},
                                     new  disease{name_OF_disease="Bronchial Asthma"},

                                     new  disease{name_OF_disease="Hypertension"},
                                     new  disease{name_OF_disease="Migraine"},
                                     new  disease{name_OF_disease="Cervical spondylosis"},
                                     new  disease{name_OF_disease="Paralysis (brain hemorrhage)"},

                                     new  disease{name_OF_disease="Jaundice"},
                                     new  disease{name_OF_disease="Malaria"},
                                      new  disease{name_OF_disease="Chicken pox"},
                                     new  disease{name_OF_disease="Dengue"},

                                     new  disease{name_OF_disease="Typhoid"},
                                     new  disease{name_OF_disease="hepatitis A"},
                                     new  disease{name_OF_disease="Hepatitis B"},
                                     new  disease{name_OF_disease="Hepatitis C"},

                                     new  disease{name_OF_disease="Hepatitis D"},
                                     new  disease{name_OF_disease="Hepatitis E"},
                                      new  disease{name_OF_disease="Alcoholic hepatitis"},
                                     new  disease{name_OF_disease="Tuberculosis"},

                                     new  disease{name_OF_disease="Common Cold"},
                                     new  disease{name_OF_disease="Pneumonia"},
                                     new  disease{name_OF_disease="Dimorphic hemmorhoids(piles)"},
                                     new  disease{name_OF_disease="Heart attack"},

                                     new  disease{name_OF_disease="Varicose veins"},
                                      new  disease{name_OF_disease="Hypothyroidism"},
                                     new  disease{name_OF_disease="Hyperthyroidism"},

                                     new  disease{name_OF_disease="Hypoglycemia"},
                                     new  disease{name_OF_disease="Osteoarthristis"},
                                     new  disease{name_OF_disease="Arthritis"},
                                     new  disease{name_OF_disease="(vertigo) Paroymsal  Positional Vertigo"},

                                     new  disease{name_OF_disease="Acne"},
                                     new  disease{name_OF_disease="Urinary tract infection"},
                                     new  disease{name_OF_disease="Psoriasis"},

                                     new  disease{name_OF_disease="Impetigo"},

                        };

                        foreach (var i in q)
                        {
                                if (s.SingleOrDefault(z => z.name_OF_disease == i.name_OF_disease) == null)

                                        db.diseases_table.Add(i);
                        }

                        db.SaveChanges();

                        var e = db.drug_table.ToList();

                        List<drug> y = new List<drug>
                        {
                           

                };
                        foreach (var i in y)
                        {
                                if (e.SingleOrDefault(z => z.trade_name == i.trade_name) == null)

                                        db.drug_table.Add(i);
                        }

                        db.SaveChanges();







                }


        }
}

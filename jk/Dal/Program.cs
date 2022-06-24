using Dal.newdata;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Dal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

                        using (data_collection db=new data_collection())
                        {
                                var x = db.symptomes_table.ToList();

                                List<symptomes> m = new List<symptomes>
               {
                 new  symptomes{name_of_symptomes="abdominal_pain"},
                 new  symptomes{name_of_symptomes="abnormal_menstruation"},
                 new  symptomes{name_of_symptomes="acidity"},
                 new  symptomes{name_of_symptomes="acute_liver_failure"},
                 new  symptomes{name_of_symptomes="altered_sensorium"},
                 new  symptomes{name_of_symptomes="altered_sensorium"},
                 new  symptomes{name_of_symptomes="back_pain"},
                 new  symptomes{name_of_symptomes="belly_pain"},
                 new  symptomes{name_of_symptomes="blackheads"},
                 new  symptomes{name_of_symptomes="bladder_discomfort"},
                 new  symptomes{name_of_symptomes="blister"},
                 new  symptomes{name_of_symptomes="blood_in_sputum"},
                 new  symptomes{name_of_symptomes="bloody_stool"},
                 new  symptomes{name_of_symptomes="blurred_and_distorted_vision"},
                 new  symptomes{name_of_symptomes="breathlessness"},
                 new  symptomes{name_of_symptomes="brittle_nails"},
                 new  symptomes{name_of_symptomes="bruising"},
                 new  symptomes{name_of_symptomes="burning_micturition"},
                 new  symptomes{name_of_symptomes="chest_pain"},
                 new  symptomes{name_of_symptomes="chills"},
                 new  symptomes{name_of_symptomes="cold_hands_and_feets"},
                 new  symptomes{name_of_symptomes="coma"},
                 new  symptomes{name_of_symptomes="congestion"},
                 new  symptomes{name_of_symptomes="constipation"},
                 new  symptomes{name_of_symptomes="continuous_feel_of_urine"},
                 new  symptomes{name_of_symptomes="continuous_sneezing"},
                 new  symptomes{name_of_symptomes="cough"},
                 new  symptomes{name_of_symptomes="cramps"},
                 new  symptomes{name_of_symptomes="dark_urine"},
                 new  symptomes{name_of_symptomes="dehydration"},
                 new  symptomes{name_of_symptomes="depression"},
                 new  symptomes{name_of_symptomes="diarrhoea"},
                 new  symptomes{name_of_symptomes="dischromic _patches"},
                 new  symptomes{name_of_symptomes="distention_of_abdomen"},
                 new  symptomes{name_of_symptomes="dizziness"},
                 new  symptomes{name_of_symptomes="drying_and_tingling_lips"},
                 new  symptomes{name_of_symptomes="enlarged_thyroid"},
                 new  symptomes{name_of_symptomes="excessive_hunger"},
                 new  symptomes{name_of_symptomes="extra_marital_contacts"},
                 new  symptomes{name_of_symptomes="family_history"},
                 new  symptomes{name_of_symptomes="fast_heart_rate"},
                 new  symptomes{name_of_symptomes="fatigue"},
                 new  symptomes{name_of_symptomes="fluid_overload"},
                 new  symptomes{name_of_symptomes="foul_smell_of urine"},
                 new  symptomes{name_of_symptomes="headache"},
                 new  symptomes{name_of_symptomes="high_fever"},
                 new  symptomes{name_of_symptomes="hip_joint_pain"},
                 new  symptomes{name_of_symptomes="history_of_alcohol_consumption"},
                 new  symptomes{name_of_symptomes="increased_appetite"},
                 new  symptomes{name_of_symptomes="indigestion"},
                 new  symptomes{name_of_symptomes="inflammatory_nails"},
                 new  symptomes{name_of_symptomes="internal_itching"},
                 new  symptomes{name_of_symptomes="irregular_sugar_level"},
                 new  symptomes{name_of_symptomes="irritability"},
                 new  symptomes{name_of_symptomes="irritation_in_anus"},
                 new  symptomes{name_of_symptomes="itching"},
                 new  symptomes{name_of_symptomes="joint_pain"},
                 new  symptomes{name_of_symptomes="knee_pain"},
                 new  symptomes{name_of_symptomes="lack_of_concentration"},
                 new  symptomes{name_of_symptomes="lethargy"},
                 new  symptomes{name_of_symptomes="loss_of_appetite"},
                 new  symptomes{name_of_symptomes="loss_of_balance"},
                 new  symptomes{name_of_symptomes="loss_of_smell"},
                 new  symptomes{name_of_symptomes="malaise"},
                 new  symptomes{name_of_symptomes="mild_fever"},
                 new  symptomes{name_of_symptomes="mood_swings"},
                 new  symptomes{name_of_symptomes="movement_stiffness"},
                 new  symptomes{name_of_symptomes="mucoid_sputum"},
                 new  symptomes{name_of_symptomes="muscle_pain"},
                 new  symptomes{name_of_symptomes="muscle_wasting"},
                 new  symptomes{name_of_symptomes="muscle_weakness"},
                 new  symptomes{name_of_symptomes="nausea"},
                 new  symptomes{name_of_symptomes="neck_pain"},
                 new  symptomes{name_of_symptomes="nodal_skin_eruptions"},
                 new  symptomes{name_of_symptomes="obesity"},
                 new  symptomes{name_of_symptomes="pain_behind_the_eyes"},
                 new  symptomes{name_of_symptomes="pain_during_bowel_movements"},
                 new  symptomes{name_of_symptomes="pain_in_anal_region"},
                 new  symptomes{name_of_symptomes="painful_walking"},
                 new  symptomes{name_of_symptomes="palpitations"},
                 new  symptomes{name_of_symptomes="passage_of_gases"},
                 new  symptomes{name_of_symptomes="patches_in_throat"},
                 new  symptomes{name_of_symptomes="phlegm"},
                 new  symptomes{name_of_symptomes="polyuria"},
                 new  symptomes{name_of_symptomes="prominent_veins_on_calf"},
                 new  symptomes{name_of_symptomes="puffy_face_and_eyes"},
                 new  symptomes{name_of_symptomes="pus_filled_pimples"},
                 new  symptomes{name_of_symptomes="receiving_blood_transfusion"},
                 new  symptomes{name_of_symptomes="receiving_unsterile_injections"},
                 new  symptomes{name_of_symptomes="red_sore_around_nose"},
                 new  symptomes{name_of_symptomes="red_spots_over_body"},
                 new  symptomes{name_of_symptomes="redness_of_eyes"},
                 new  symptomes{name_of_symptomes="restlessness"},
                 new  symptomes{name_of_symptomes="runny_nose"},
                 new  symptomes{name_of_symptomes="rusty_sputum"},
                 new  symptomes{name_of_symptomes="scurring"},
                 new  symptomes{name_of_symptomes="shivering"},
                 new  symptomes{name_of_symptomes="silver_like_dusting"},
                 new  symptomes{name_of_symptomes="sinus_pressure"},
                 new  symptomes{name_of_symptomes="skin_peeling"},
                 new  symptomes{name_of_symptomes="skin_rash"},
                 new  symptomes{name_of_symptomes="slurred_speech"},
                 new  symptomes{name_of_symptomes="small_dents_in_nails"},
                 new  symptomes{name_of_symptomes="spinning_movements"},
                 new  symptomes{name_of_symptomes="spotting_ urination"},
                 new  symptomes{name_of_symptomes="stiff_neck"},
                 new  symptomes{name_of_symptomes="stomach_bleeding"},
                 new  symptomes{name_of_symptomes="stomach_pain"},
                 new  symptomes{name_of_symptomes="sunken_eyes"},
                 new  symptomes{name_of_symptomes="sweating"},
                 new  symptomes{name_of_symptomes="swelled_lymph_nodes"},
                 new  symptomes{name_of_symptomes="swelling_joints"},
                 new  symptomes{name_of_symptomes="swelling_of_stomach"},
                 new  symptomes{name_of_symptomes="swollen_blood_vessels"},
                 new  symptomes{name_of_symptomes="swollen_extremeties"},
                 new  symptomes{name_of_symptomes="swollen_legs"},
                 new  symptomes{name_of_symptomes="throat_irritation"},
                 new  symptomes{name_of_symptomes="toxic_look_(typhos)"},
                 new  symptomes{name_of_symptomes="ulcers_on_tongue"},
                 new  symptomes{name_of_symptomes="unsteadiness"},
                 new  symptomes{name_of_symptomes="visual_disturbances"},
                 new  symptomes{name_of_symptomes="vomiting"},
                 new  symptomes{name_of_symptomes="watering_from_eyes"},
                 new  symptomes{name_of_symptomes="weakness_in_limbs"},
                 new  symptomes{name_of_symptomes="weakness_of_one_body_side"},
                 new  symptomes{name_of_symptomes="weight_gain"},
                 new  symptomes{name_of_symptomes="weight_loss"},
                 new  symptomes{name_of_symptomes="yellow_crust_ooze"},
                 new  symptomes{name_of_symptomes="yellow_urine"},
                 new  symptomes{name_of_symptomes="yellowing_of_eyes"},
                 new  symptomes{name_of_symptomes="yellowish_skin"},


            };

                                foreach (var item in m)
                                {
                                        if (x.SingleOrDefault(r => r.name_of_symptomes == item.name_of_symptomes) == null)

                                                db.symptomes_table.Add(item);
                                }

                                db.SaveChanges();
                        }

        }
    }
}

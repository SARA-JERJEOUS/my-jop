using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace consolee
{
        public class inputdatamodel
        {
                [ LoadColumn(0), ColumnName("Label")]
                public string Label { get; set; }
            

                [ColumnName("abdominal_pain"), LoadColumn(1)]
                public float Abdominal_pain { get; set; }


                [ColumnName("abnormal_menstruation"), LoadColumn(2)]
                public float Abnormal_menstruation { get; set; }


                [ColumnName("acidity"), LoadColumn(3)]
                public float Acidity { get; set; }


                [ColumnName("acute_liver_failure"), LoadColumn(4)]
                public float Acute_liver_failure { get; set; }


                [ColumnName("altered_sensorium"), LoadColumn(5)]
                public float Altered_sensorium { get; set; }


                [ColumnName("anxiety"), LoadColumn(6)]
                public float Anxiety { get; set; }


                [ColumnName("back_pain"), LoadColumn(7)]
                public float Back_pain { get; set; }


                [ColumnName("belly_pain"), LoadColumn(8)]
                public float Belly_pain { get; set; }


                [ColumnName("blackheads"), LoadColumn(9)]
                public float Blackheads { get; set; }


                [ColumnName("bladder_discomfort"), LoadColumn(10)]
                public float Bladder_discomfort { get; set; }


                [ColumnName("blister"), LoadColumn(11)]
                public float Blister { get; set; }


                [ColumnName("blood_in_sputum"), LoadColumn(12)]
                public float Blood_in_sputum { get; set; }


                [ColumnName("bloody_stool"), LoadColumn(13)]
                public float Bloody_stool { get; set; }


                [ColumnName("blurred_and_distorted_vision"), LoadColumn(14)]
                public float Blurred_and_distorted_vision { get; set; }


                [ColumnName("breathlessness"), LoadColumn(15)]
                public float Breathlessness { get; set; }


                [ColumnName("brittle_nails"), LoadColumn(16)]
                public float Brittle_nails { get; set; }


                [ColumnName("bruising"), LoadColumn(17)]
                public float Bruising { get; set; }


                [ColumnName("burning_micturition"), LoadColumn(18)]
                public float Burning_micturition { get; set; }


                [ColumnName("chest_pain"), LoadColumn(19)]
                public float Chest_pain { get; set; }


                [ColumnName("chills"), LoadColumn(20)]
                public float Chills { get; set; }


                [ColumnName("cold_hands_and_feets"), LoadColumn(21)]
                public float Cold_hands_and_feets { get; set; }


                [ColumnName("coma"), LoadColumn(22)]
                public float Coma { get; set; }


                [ColumnName("congestion"), LoadColumn(23)]
                public float Congestion { get; set; }


                [ColumnName("constipation"), LoadColumn(24)]
                public float Constipation { get; set; }


                [ColumnName("continuous_feel_of_urine"), LoadColumn(25)]
                public float Continuous_feel_of_urine { get; set; }


                [ColumnName("continuous_sneezing"), LoadColumn(26)]
                public float Continuous_sneezing { get; set; }


                [ColumnName("cough"), LoadColumn(27)]
                public float Cough { get; set; }


                [ColumnName("cramps"), LoadColumn(28)]
                public float Cramps { get; set; }


                [ColumnName("dark_urine"), LoadColumn(29)]
                public float Dark_urine { get; set; }


                [ColumnName("dehydration"), LoadColumn(30)]
                public float Dehydration { get; set; }


                [ColumnName("depression"), LoadColumn(31)]
                public float Depression { get; set; }


                [ColumnName("diarrhoea"), LoadColumn(32)]
                public float Diarrhoea { get; set; }


                [ColumnName("dischromic _patches"), LoadColumn(33)]
                public float Dischromic__patches { get; set; }


                [ColumnName("distention_of_abdomen"), LoadColumn(34)]
                public float Distention_of_abdomen { get; set; }


                [ColumnName("dizziness"), LoadColumn(35)]
                public float Dizziness { get; set; }


                [ColumnName("drying_and_tingling_lips"), LoadColumn(36)]
                public float Drying_and_tingling_lips { get; set; }


                [ColumnName("enlarged_thyroid"), LoadColumn(37)]
                public float Enlarged_thyroid { get; set; }


                [ColumnName("excessive_hunger"), LoadColumn(38)]
                public float Excessive_hunger { get; set; }


                [ColumnName("extra_marital_contacts"), LoadColumn(39)]
                public float Extra_marital_contacts { get; set; }


                [ColumnName("family_history"), LoadColumn(40)]
                public float Family_history { get; set; }


                [ColumnName("fast_heart_rate"), LoadColumn(41)]
                public float Fast_heart_rate { get; set; }


                [ColumnName("fatigue"), LoadColumn(42)]
                public float Fatigue { get; set; }


                [ColumnName("fluid_overload"), LoadColumn(43)]
                public float Fluid_overload { get; set; }


                [ColumnName("foul_smell_of urine"), LoadColumn(44)]
                public float Foul_smell_of_urine { get; set; }


                [ColumnName("headache"), LoadColumn(45)]
                public float Headache { get; set; }


                [ColumnName("high_fever"), LoadColumn(46)]
                public float High_fever { get; set; }


                [ColumnName("hip_joint_pain"), LoadColumn(47)]
                public float Hip_joint_pain { get; set; }


                [ColumnName("history_of_alcohol_consumption"), LoadColumn(48)]
                public float History_of_alcohol_consumption { get; set; }


                [ColumnName("increased_appetite"), LoadColumn(49)]
                public float Increased_appetite { get; set; }


                [ColumnName("indigestion"), LoadColumn(50)]
                public float Indigestion { get; set; }


                [ColumnName("inflammatory_nails"), LoadColumn(51)]
                public float Inflammatory_nails { get; set; }


                [ColumnName("internal_itching"), LoadColumn(52)]
                public float Internal_itching { get; set; }


                [ColumnName("irregular_sugar_level"), LoadColumn(53)]
                public float Irregular_sugar_level { get; set; }


                [ColumnName("irritability"), LoadColumn(54)]
                public float Irritability { get; set; }


                [ColumnName("irritation_in_anus"), LoadColumn(55)]
                public float Irritation_in_anus { get; set; }


                [ColumnName("itching"), LoadColumn(56)]
                public float Itching { get; set; }


                [ColumnName("joint_pain"), LoadColumn(57)]
                public float Joint_pain { get; set; }


                [ColumnName("knee_pain"), LoadColumn(58)]
                public float Knee_pain { get; set; }


                [ColumnName("lack_of_concentration"), LoadColumn(59)]
                public float Lack_of_concentration { get; set; }


                [ColumnName("lethargy"), LoadColumn(60)]
                public float Lethargy { get; set; }


                [ColumnName("loss_of_appetite"), LoadColumn(61)]
                public float Loss_of_appetite { get; set; }


                [ColumnName("loss_of_balance"), LoadColumn(62)]
                public float Loss_of_balance { get; set; }


                [ColumnName("loss_of_smell"), LoadColumn(63)]
                public float Loss_of_smell { get; set; }


                [ColumnName("malaise"), LoadColumn(64)]
                public float Malaise { get; set; }


                [ColumnName("mild_fever"), LoadColumn(65)]
                public float Mild_fever { get; set; }


                [ColumnName("mood_swings"), LoadColumn(66)]
                public float Mood_swings { get; set; }


                [ColumnName("movement_stiffness"), LoadColumn(67)]
                public float Movement_stiffness { get; set; }


                [ColumnName("mucoid_sputum"), LoadColumn(68)]
                public float Mucoid_sputum { get; set; }


                [ColumnName("muscle_pain"), LoadColumn(69)]
                public float Muscle_pain { get; set; }


                [ColumnName("muscle_wasting"), LoadColumn(70)]
                public float Muscle_wasting { get; set; }


                [ColumnName("muscle_weakness"), LoadColumn(71)]
                public float Muscle_weakness { get; set; }


                [ColumnName("nausea"), LoadColumn(72)]
                public float Nausea { get; set; }


                [ColumnName("neck_pain"), LoadColumn(73)]
                public float Neck_pain { get; set; }


                [ColumnName("nodal_skin_eruptions"), LoadColumn(74)]
                public float Nodal_skin_eruptions { get; set; }


                [ColumnName("obesity"), LoadColumn(75)]
                public float Obesity { get; set; }


                [ColumnName("pain_behind_the_eyes"), LoadColumn(76)]
                public float Pain_behind_the_eyes { get; set; }


                [ColumnName("pain_during_bowel_movements"), LoadColumn(77)]
                public float Pain_during_bowel_movements { get; set; }


                [ColumnName("pain_in_anal_region"), LoadColumn(78)]
                public float Pain_in_anal_region { get; set; }


                [ColumnName("painful_walking"), LoadColumn(79)]
                public float Painful_walking { get; set; }


                [ColumnName("palpitations"), LoadColumn(80)]
                public float Palpitations { get; set; }


                [ColumnName("passage_of_gases"), LoadColumn(81)]
                public float Passage_of_gases { get; set; }


                [ColumnName("patches_in_throat"), LoadColumn(82)]
                public float Patches_in_throat { get; set; }


                [ColumnName("phlegm"), LoadColumn(83)]
                public float Phlegm { get; set; }


                [ColumnName("polyuria"), LoadColumn(84)]
                public float Polyuria { get; set; }


                [ColumnName("prominent_veins_on_calf"), LoadColumn(85)]
                public float Prominent_veins_on_calf { get; set; }


                [ColumnName("puffy_face_and_eyes"), LoadColumn(86)]
                public float Puffy_face_and_eyes { get; set; }


                [ColumnName("pus_filled_pimples"), LoadColumn(87)]
                public float Pus_filled_pimples { get; set; }


                [ColumnName("receiving_blood_transfusion"), LoadColumn(88)]
                public float Receiving_blood_transfusion { get; set; }


                [ColumnName("receiving_unsterile_injections"), LoadColumn(89)]
                public float Receiving_unsterile_injections { get; set; }


                [ColumnName("red_sore_around_nose"), LoadColumn(90)]
                public float Red_sore_around_nose { get; set; }


                [ColumnName("red_spots_over_body"), LoadColumn(91)]
                public float Red_spots_over_body { get; set; }


                [ColumnName("redness_of_eyes"), LoadColumn(92)]
                public float Redness_of_eyes { get; set; }


                [ColumnName("restlessness"), LoadColumn(93)]
                public float Restlessness { get; set; }


                [ColumnName("runny_nose"), LoadColumn(94)]
                public float Runny_nose { get; set; }


                [ColumnName("rusty_sputum"), LoadColumn(95)]
                public float Rusty_sputum { get; set; }


                [ColumnName("scurring"), LoadColumn(96)]
                public float Scurring { get; set; }


                [ColumnName("shivering"), LoadColumn(97)]
                public float Shivering { get; set; }


                [ColumnName("silver_like_dusting"), LoadColumn(98)]
                public float Silver_like_dusting { get; set; }


                [ColumnName("sinus_pressure"), LoadColumn(99)]
                public float Sinus_pressure { get; set; }


                [ColumnName("skin_peeling"), LoadColumn(100)]
                public float Skin_peeling { get; set; }


                [ColumnName("skin_rash"), LoadColumn(101)]
                public float Skin_rash { get; set; }


                [ColumnName("slurred_speech"), LoadColumn(102)]
                public float Slurred_speech { get; set; }


                [ColumnName("small_dents_in_nails"), LoadColumn(103)]
                public float Small_dents_in_nails { get; set; }


                [ColumnName("spinning_movements"), LoadColumn(104)]
                public float Spinning_movements { get; set; }


                [ColumnName("spotting_ urination"), LoadColumn(105)]
                public float Spotting__urination { get; set; }


                [ColumnName("stiff_neck"), LoadColumn(106)]
                public float Stiff_neck { get; set; }


                [ColumnName("stomach_bleeding"), LoadColumn(107)]
                public float Stomach_bleeding { get; set; }


                [ColumnName("stomach_pain"), LoadColumn(108)]
                public float Stomach_pain { get; set; }


                [ColumnName("sunken_eyes"), LoadColumn(109)]
                public float Sunken_eyes { get; set; }


                [ColumnName("sweating"), LoadColumn(110)]
                public float Sweating { get; set; }


                [ColumnName("swelled_lymph_nodes"), LoadColumn(111)]
                public float Swelled_lymph_nodes { get; set; }


                [ColumnName("swelling_joints"), LoadColumn(112)]
                public float Swelling_joints { get; set; }


                [ColumnName("swelling_of_stomach"), LoadColumn(113)]
                public float Swelling_of_stomach { get; set; }


                [ColumnName("swollen_blood_vessels"), LoadColumn(114)]
                public float Swollen_blood_vessels { get; set; }


                [ColumnName("swollen_extremeties"), LoadColumn(115)]
                public float Swollen_extremeties { get; set; }


                [ColumnName("swollen_legs"), LoadColumn(116)]
                public float Swollen_legs { get; set; }


                [ColumnName("throat_irritation"), LoadColumn(117)]
                public float Throat_irritation { get; set; }


                [ColumnName("toxic_look_(typhos)"), LoadColumn(118)]
                public float Toxic_look__typhos_ { get; set; }


                [ColumnName("ulcers_on_tongue"), LoadColumn(119)]
                public float Ulcers_on_tongue { get; set; }


                [ColumnName("unsteadiness"), LoadColumn(120)]
                public float Unsteadiness { get; set; }


                [ColumnName("visual_disturbances"), LoadColumn(121)]
                public float Visual_disturbances { get; set; }


                [ColumnName("vomiting"), LoadColumn(122)]
                public float Vomiting { get; set; }


                [ColumnName("watering_from_eyes"), LoadColumn(123)]
                public float Watering_from_eyes { get; set; }


                [ColumnName("weakness_in_limbs"), LoadColumn(124)]
                public float Weakness_in_limbs { get; set; }


                [ColumnName("weakness_of_one_body_side"), LoadColumn(125)]
                public float Weakness_of_one_body_side { get; set; }


                [ColumnName("weight_gain"), LoadColumn(126)]
                public float Weight_gain { get; set; }


                [ColumnName("weight_loss"), LoadColumn(127)]
                public float Weight_loss { get; set; }


                [ColumnName("yellow_crust_ooze"), LoadColumn(128)]
                public float Yellow_crust_ooze { get; set; }


                [ColumnName("yellow_urine"), LoadColumn(129)]
                public float Yellow_urine { get; set; }


                [ColumnName("yellowing_of_eyes"), LoadColumn(130)]
                public float Yellowing_of_eyes { get; set; }


                [ColumnName("yellowish_skin"), LoadColumn(131)]
                public float Yellowish_skin { get; set; }

        }
}

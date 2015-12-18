﻿using Phobos.WoT;
using System;
using System.Collections.Generic;


namespace WotPogsIconSet.Utils
{
    class ShortNames
    {

        public static String findShortName(TankStats tank)
        {
            string key = tank.Nation + ":" + tank.Id;
            if (list.ContainsKey(key))
            {
                return list[key];
            }

            Console.WriteLine("No short name for: " + tank.Name+"\n");
            return tank.Name;
        }

        // from: xvm/src/xpm/xvm_main/vehinfo_short.py
        // replace regex
        // '([a-z0-9:_-]+)':\s+'([a-z0-9 ./ ]+)?',
        // {"$1", "$2"},
        public static readonly Dictionary<String, String> list = new Dictionary<string, string>
        {
    //         # level 10
    {"china:Ch19_121", "121"},
    {"china:Ch19_121_IGR", "121"},
    {"china:Ch22_113", "113"},
    {"china:Ch25_121_mod_1971B", "121B"},
    {"czech:Cz04_T50_51", "t5051"},
    {"france:AMX_50Fosh_155", "Fch155"},
    {"france:Bat_Chatillon155_58", "155 58"},
    {"france:Bat_Chatillon25t", "BChat"},
    {"france:Bat_Chatillon25t_IGR", "BChat"},
    {"france:F10_AMX_50B", "50B"},
    {"france:F10_AMX_50B_fallout", "50B"},
    {"france:F72_AMX_30", "amx30b"},
    {"germany:E-100", "E 100"},
    {"germany:E50_Ausf_M", "E 50m"},
    {"germany:G_E", "GWE"},
    {"germany:G89_Leopard1", "Leo1"},
    {"germany:JagdPz_E100", "Jpz100"},
    {"germany:Maus", "Maus"},
    {"germany:Maus_IGR", "Maus"},
    {"germany:VK7201", "vk7201"},
    {"germany:Waffentrager_E100", "WT100"},
    {"japan:J20_Type_2605", "Typ5"},
    {"japan:ST_B1", "stb 1"},
    {"japan:ST_B1_IGR", "stb 1"},
    {"uk:GB13_FV215b", "Fv215"},
    {"uk:GB13_FV215b_IGR", "Fv215"},
    {"uk:GB31_Conqueror_Gun", "ConqG"},
    {"uk:GB48_FV215b_183", "Fv183"},
    {"uk:GB70_FV4202_105", "fv4202"},
    {"uk:GB83_FV4005", "fv4005"},
    {"uk:GB84_Chieftain_Mk6", "Chief"},
    {"uk:GB86_Centurion_Action_X", "CentAX"},
    {"usa:A106_M48A2_120", "54E2"},
    {"usa:A69_T110E5", "110e5"},
    {"usa:A83_T110E4", "110e4"},
    {"usa:A84_M48A1", "M48Pt"},
    {"usa:A84_M48A1_IGR", "M48Pt"},
    {"usa:A85_T110E3", "110e3"},
    {"usa:M60", "M60"},
    {"usa:T57_58", "T57hv"},
    {"usa:T92", "T92"},
    {"usa:A95_T95_E6", "T95e6"},
    {"ussr:IS-7", "Is 7"},
    {"ussr:IS-7_fallout", "Is 7"},
    {"ussr:IS-7_IGR", "Is 7"},
    {"ussr:Object_140", "obj140"},
    {"ussr:Object_261", "obj261"},
    {"ussr:Object_430", "obj430"},
    {"ussr:Object_907", "obj907"},
    {"ussr:Object_907A", "907a"},
    {"ussr:Object263", "obj263"},
    {"ussr:Object268", "obj268"},
    {"ussr:R110_Object_260", "obj260"},
    {"ussr:R119_Object_777", "obj777"},
    {"ussr:R120_T22SR_A22", "t22"},
    {"ussr:R87_T62A", "t62a"},
    {"ussr:R87_T62A_fallout", "t62a"},
    {"ussr:R90_IS_4M", "Is 4"},
  //  # level 9
    {"china:Ch12_111_1_2_3", "111 4"},
    {"china:Ch18_WZ-120", "wz120"},
    {"czech:Cz02_TVP_T50", "skt50"},
    {"france:AMX50_Foch", "Foch"},
    {"france:Bat_Chatillon155_55", "155 55"},
    {"france:F09_AMX_50_120", "50120"},
    {"france:F71_AMX_30_prototype", "amx30"},
    {"france:Lorraine40t", "Lr40t"},
    {"germany:E-50", "E 50"},
    {"germany:E-75", "E 75"},
    {"germany:G_Tiger", "GWT"},
    {"germany:G105_T-55_NVA_DDR", "T 55a"},
    {"germany:G44_JagdTiger", "JagT"},
    {"germany:G91_Pro_Ag_A", "LeoPrA"},
    {"germany:VK4502P", "4502b"},
    {"germany:Waffentrager_IV", "WT4"},
    {"japan:J25_Type_4", "Typ4"},
    {"japan:Type_61", "Typ61"},
    {"uk:GB12_Conqueror", "Conq"},
    {"uk:GB24_Centurion_Mk3", "Cent7"},
    {"uk:GB30_FV3805", "fv3805"},
    {"uk:GB32_Tortoise", "Tort"},
    {"uk:GB81_FV4004", "Conw"},
    {"usa:A63_M46_Patton", "M46Pt"},
    {"usa:M103", "M103"},
    {"usa:M53_55", "M53 55"},
    {"usa:A14_T30", "T30"},
    {"usa:A89_T54E1", "54E1"},
    {"usa:T95", "T95"},
    {"ussr:R104_Object_430_II", "430 2"},
    {"ussr:R51_Object_212", "obj212"},
    {"ussr:R53_Object_704", "obj704"},
    {"ussr:R81_IS8", "T 10"},
    {"ussr:ST_I", "ST I"},
    {"ussr:SU122_54", "122 54"},
    {"ussr:T-54", "t54"},
   // # level 8
    {"china:Ch01_Type59", "Typ59"},
    {"china:Ch01_Type59_Gold", "Typ59"},
    {"china:Ch03_WZ-111", "111"},
    {"china:Ch05_T34_2", "t34 2"},
    {"china:Ch11_110", "110"},
    {"china:Ch11_110_IGR", "110"},
    {"china:Ch14_T34_3", "t34 3"},
    {"china:Ch17_WZ131_1_WZ132", "wz132"},
    {"china:Ch17_WZ131_1_WZ132_IGR", "wz132"},
    {"china:Ch23_112", "112"},
    {"china:Ch26_59_Patton", "59Pat"},
    {"czech:Cz07_TVP_46", "vtu"},
    {"france:AMX_13_90", "13 90"},
    {"france:AMX_13_90_IGR", "13 90"},
    {"france:F36_AMX_AC_Mle1948", "amx48"},
    {"france:F36_AMX_AC_Mle1948_IGR", "amx48"},
    {"france:F08_AMX_50_100", "50100"},
    {"france:F08_AMX_50_100_IGR", "50100"},
    {"france:F65_FCM_50t", "fcm50t"},
    {"france:F68_AMX_Chasseur_de_char_46", "CDC"},
    {"france:F73_M4A1_Revalorise", "m4a1"},
    {"france:F74_AMX_M4_1949", "amx4 49"},
    {"france:Lorraine155_51", "155 51"},
    {"germany:Ferdinand", "Ferd"},
    {"germany:Ferdinand_IGR", "Ferd"},
    {"germany:G103_RU_251", "Ru251"},
    {"germany:G106_PzKpfwPanther_AusfF", "Pant88"},
    {"germany:G112_KanonenJagdPanzer", "KnJpz"},
    {"germany:G114_Skorpian", "skorp"},
    {"germany:G115_Typ_205_4_Jun", "vk100"},
    {"germany:G119_Panzer58", "Pz58"},
    {"germany:G119_Pz58_Mutz", "mutz"},
    {"germany:G16_PzVIB_Tiger_II", "Tig2"},
    {"germany:G16_PzVIB_Tiger_II_IGR", "Tig2"},
    {"germany:G65_JagdTiger_SdKfz_185", "JgT88"},
    {"germany:G65_JagdTiger_SdKfz_185_IGR", "JgT88"},
    {"germany:G71_JagdPantherII", "JagP2"},
    {"germany:GW_Tiger_P", "GWTP"},
    {"germany:Indien_Panzer", "IndPz"},
    {"germany:Lowe", "Lowe"},
    {"germany:Panther_II", "Pant2"},
    {"germany:Panther_II_IGR", "Pant2"},
    {"germany:RhB_Waffentrager", "WTRhB"},
    {"germany:VK4502A", "4502a"},
    {"japan:J18_STA_2_3", "sta 2"},
    {"japan:J27_O_I_120", "O ho"},
    {"japan:STA_1", "sta 1"},
    {"japan:STA_1_IGR", "sta 1"},
    {"uk:GB11_Caernarvon", "Caer"},
    {"uk:GB11_Caernarvon_IGR", "Caer"},
    {"uk:GB23_Centurion", "Cent"},
    {"uk:GB23_Centurion_IGR", "Cent"},
    {"uk:GB70_N_FV4202_105", "4202p"},
    {"uk:GB72_AT15", "AT15"},
    {"uk:GB72_AT15_IGR", "AT15"},
    {"uk:GB79_FV206", "fv207"},
    {"uk:GB80_Charioteer", "Chari"},
    {"uk:GB87_Chieftain_T95_turret", "Chif95"},
    {"usa:A12_T32", "T32"},
    {"usa:A13_T34_hvy", "T34"},
    {"usa:A13_T34_hvy_IGR", "T34"},
    {"usa:A35_Pershing", "Persh"},
    {"usa:A35_Pershing_IGR", "Persh"},
    {"usa:A45_M6A2E1", "M6a2e1"},
    {"usa:A63_M46_Patton_KR", "m46kr"},
    {"usa:A80_T26_E4_SuperPershing", "T26e4"},
    {"usa:M40M43", "M40 43"},
    {"usa:T23", "T23"},
    {"usa:T28", "T28"},
    {"usa:T28_Prototype", "T28Pr"},
    {"usa:T49", "T49"},
    {"usa:T69", "T69"},
    {"usa:T69_IGR", "T69"},
    {"usa:T95_E2", "T95e2"},
    {"ussr:ISU-152", "ISU"},
    {"ussr:ISU-152_IGR", "ISU"},
    {"ussr:KV4", "Kv 4"},
    {"ussr:R54_KV-5", "Kv 5"},
    {"ussr:R54_KV-5_IGR", "Kv 5"},
    {"ussr:R61_Object252", "Is 6"},
    {"ussr:Object416", "obj416"},
    {"ussr:R109_T54S", "t54l"},
    {"ussr:R111_ISU130", "isu130"},
    {"ussr:R112_T54_45", "t54 1"},
    {"ussr:R113_Object_730", "Is 5"},
    {"ussr:R115_IS-3_auto", "Is 3al"},
    {"ussr:R121_KV4_KTT", "Kv 4kt"},
    {"ussr:R122_T44_100", "t44100"},
    {"ussr:R19_IS-3", "Is 3"},
    {"ussr:R19_IS-3_IGR", "Is 3"},
    {"ussr:SU-101", "Su101"},
    {"ussr:SU-14", "Su 14"},
    {"ussr:T-44", "t44"},
    {"ussr:T-44_IGR", "t44"},
   // # level 7
    {"china:Ch02_Type62", "Typ62"},
    {"china:Ch04_T34_1", "t34 1"},
    {"china:Ch10_IS2", "IS2"},
    {"china:Ch16_WZ_131", "wz131"},
    {"czech:Cz05_T34_100", "t34100"},
    {"france:AMX_13_75", "13 75"},
    {"france:F07_AMX_M4_1945", "amx4 45"},
    {"france:F35_AMX_AC_Mle1946", "amx46"},
    {"france:F69_AMX13_57_100", "13 57"},
    {"france:F69_AMX13_57_100_GrandFinal", "13 57f"},
    {"france:Lorraine155_50", "155 50"},
    {"germany:Auf_Panther", "AufPan"},
    {"germany:E-25", "E 25"},
    {"germany:E-25_IGR", "E 25"},
    {"germany:G_Panther", "GWP"},
    {"germany:G04_PzVI_Tiger_IA", "TigL56"},
    {"germany:G109_Steyr_WT", "WTstr"},
    {"germany:G113_SP_I_C", "sp1c"},
    {"germany:G118_VK4503", "4503"},
    {"germany:G58_VK4502P", "4502b7"},
    {"germany:G78_Panther_M10", "PanM10"},
    {"germany:JagdPanther", "JagP"},
    {"germany:PzV", "Pant"},
    {"germany:PzV_IGR", "Pant"},
    {"germany:PzVI", "Tig"},
    {"germany:PzVI_IGR", "Tig"},
    {"germany:PzVI_Tiger_P", "TigP"},
    {"germany:Sturer_Emil", "Emil"},
    {"germany:VK3002DB", "3002d"},
    {"japan:Chi_Ri", "ChiRi"},
    {"japan:Chi_Ri_IGR", "ChiRi"},
    {"japan:J28_O_I_100", "O ni"},
    {"uk:GB10_Black_Prince", "BlPrn"},
    {"uk:GB22_Comet", "Comet"},
    {"uk:GB29_Crusader_5inch", "CruSP"},
    {"uk:GB41_Challenger", "Chall"},
    {"uk:GB52_A45", "fv201"},
    {"uk:GB71_AT_15A", "AT15a"},
    {"uk:GB75_AT7", "AT7"},
    {"usa:A101_M56", "Scorp"},
    {"usa:A102_T28_concept", "T28c"},
    {"usa:A103_T71E1", "T71"},
    {"usa:A103_T71E1_IGR", "T71"},
    {"usa:A86_T23E3", "T23e3"},
    {"usa:M12", "M12"},
    {"usa:M41_Bulldog", "Buldog"},
    {"usa:T20", "T20"},
    {"usa:T25_2", "T25/2"},
    {"usa:T25_AT", "T25at"},
    {"usa:A11_T29", "T29"},
    {"usa:A11_T29_IGR", "T29"},
    {"ussr:A44", "A 44"},
    {"ussr:IS", "Is"},
    {"ussr:KV-13", "Kv 13"},
    {"ussr:R39_KV-3", "Kv 3"},
    {"ussr:R107_LTB", "LTB"},
    {"ussr:R116_ISU122C_Berlin", "isu122"},
    {"ussr:R71_IS_2B", "Is 2"},
    {"ussr:S-51", "S 51"},
    {"ussr:SU100M1", "Su100m"},
    {"ussr:SU122_44", "122 44"},
    {"ussr:SU14_1", "Su14 1"},
    {"ussr:R18_SU-152", "Su152"},
    {"ussr:R18_SU-152_IGR", "Su152"},
    {"ussr:T-43", "t43"},
    {"ussr:T44_122", "t44122"},
    {"ussr:T44_85", "t4485"},
    //# level 6
    {"china:Ch15_59_16", "59 16"},
    {"china:Ch20_Type58", "Typ58"},
    {"china:Ch24_Type64", "Typ64"},
    {"czech:Cz01_Skoda_T40", "skT40"},
    {"czech:Cz08_T_25", "skt25"},
    {"france:AMX_13F3AM", "13F3"},
    {"france:ARL_V39", "Arl39"},
    {"france:F06_ARL_44", "Arl44"},
    {"france:F15_AMX_12t", "amx12"},
    {"germany:DickerMax", "DMax"},
    {"germany:G02_Hummel", "Humml"},
    {"germany:G15_VK3601H", "3601h"},
    {"germany:G17_JagdPzIV", "Jpz4"},
    {"germany:Nashorn", "Nash"},
    {"germany:PzIV_schmalturm", "Pz4s"},
    {"germany:PzV_PzIV", "Pz5 6"},
    {"germany:PzV_PzIV_ausf_Alfa", "Pz5 6a"},
    {"germany:VK2801", "vk2801"},
    {"germany:VK3001P", "3001p"},
    {"germany:VK3002DB_V1", "3001d"},
    {"germany:VK3002M", "3002m"},
    {"japan:Chi_To", "ChiTo"},
    {"japan:J19_Tiger_I_Jpn", "JapTig"},
    {"japan:J24_Mi_To_130_tons", "O I"},
    {"uk:GB09_Churchill_VII", "Chrch7"},
    {"uk:GB19_Sherman_Firefly", "Firef"},
    {"uk:GB21_Cromwell", "Cromw"},
    {"uk:GB21_Cromwell_IGR", "Cromw"},
    {"uk:GB40_Gun_Carrier_Churchill", "ChrGC"},
    {"uk:GB45_Achilles_IIC", "Achil"},
    {"uk:GB63_TOG_II", "TOG2"},
    {"uk:GB74_AT8", "AT8"},
    {"uk:GB77_FV304", "fv304"},
    {"uk:GB77_FV304_IGR", "fv304"},
    {"uk:GB85_Cromwell_Berlin", "cromwB"},
    {"usa:A104_M4A3E8A", "Fury"},
    {"usa:A36_Sherman_Jumbo", "Jumbo"},
    {"usa:A36_Sherman_Jumbo_IGR", "Jumbo"},
    {"usa:A94_T37", "T37"},
    {"usa:M18_Hellcat", "Hellc"},
    {"usa:M36_Slagger", "Jacks"},
    {"usa:A87_M44", "M44"},
    {"usa:M4A3E8_Sherman", "M4a3e8"},
    {"usa:M6", "M6"},
    {"usa:T21", "T21"},
    {"ussr:A43", "A 43"},
    {"ussr:KV2", "Kv 2"},
    {"ussr:KV2_IGR", "Kv 2"},
    {"ussr:MT25", "Mt 25"},
    {"ussr:R106_KV85", "Kv 85"},
    {"ussr:R106_KV85_IGR", "Kv 85"},
    {"ussr:R108_T34_85M", "t3485m"},
    {"ussr:R114_Object_244", "obj244"},
    {"ussr:R117_T34_85_Rudy", "Rudy"},
    {"ussr:SU-100", "Su100"},
    {"ussr:SU100Y", "Su100y"},
    {"ussr:SU-8", "Su 8"},
    {"ussr:T150", "T150"},
    {"ussr:T-34-85", "t3485"},
   // # level 5
    {"china:Ch21_T34", "t34"},
    {"czech:Cz09_T_24", "skt24"},
    {"france:_105_leFH18B2", "leFH"},
    {"france:_105_leFH18B2_IGR", "leFH"},
    {"france:AMX_105AM", "13AM"},
    {"france:BDR_G1B", "BDR"},
    {"france:ELC_AMX", "ELC"},
    {"france:ELC_AMX_IGR", "ELC"},
    {"france:F11_Renault_G1R", "G1R"},
    {"france:S_35CA", "S35ca"},
    {"france:S_35CA_IGR", "S35ca"},
    {"germany:G104_Stug_IV", "Stug4"},
    {"germany:G107_PzKpfwIII_AusfK", "Pz3k"},
    {"germany:G116_Turan_III_prot", "Turn3"},
    {"germany:G23_Grille", "Grill"},
    {"germany:G26_VK1602", "Leo"},
    {"germany:Pz_IV_AusfH", "Pz4h"},
    {"germany:Pz_Sfl_IVc", "PzS4c"},
    {"germany:PzIII_IV", "Pz3 4"},
    {"germany:PzIV", "Pz4"},
    {"germany:PzIV_Hydro", "Pz4hy"},
    {"germany:StuG_40_AusfG", "StugG"},
    {"germany:StuG_40_AusfG_IGR", "StugG"},
    {"germany:T-25", "T 25"},
    {"germany:VK3001H", "3001h"},
    {"japan:Chi_Nu", "ChiNu"},
    {"japan:Chi_Nu_Kai", "ChiNuK"},
    {"japan:J23_Mi_To", "O Iex"},
    {"uk:GB08_Churchill_I", "Chrch1"},
    {"uk:GB08_Churchill_I_IGR", "Chrch1"},
    {"uk:GB20_Crusader", "Crsdr"},
    {"uk:GB28_Bishop", "Bish"},
    {"uk:GB44_Archer", "Arch"},
    {"uk:GB50_Sherman_III", "Sherm3"},
    {"uk:GB51_Excelsior", "Excel"},
    {"uk:GB68_Matilda_Black_Prince", "MatBP"},
    {"uk:GB73_AT2", "AT2"},
    {"usa:A18_M41", "M41"},
    {"usa:A23_M7_med", "M7"},
    {"usa:A30_M10_Wolverine", "Wolvr"},
    {"usa:A78_M4_Improved", "M4"},
    {"usa:M24_Chaffee", "Chaff"},
    {"usa:M4_Sherman", "M4"},
    {"usa:M4_Sherman_IGR", "M4"},
    {"usa:M4A2E4", "M4a2e4"},
    {"usa:Ram-II", "Ram2"},
    {"usa:T1_hvy", "T1hv"},
    {"usa:T14", "T14"},
    {"usa:T67", "T67"},
    {"usa:T67_IGR", "T67"},
    {"ussr:Churchill_LL", "Chrch3"},
    {"ussr:KV", "Kv"},
    {"ussr:KV-1s", "Kv 1s"},
    {"ussr:Matilda_II_LL", "Matil4"},
    {"ussr:R02_SU-85", "Su85"},
    {"ussr:R04_T-34", "t34"},
    {"ussr:R100_SU122A", "Su122"},
    {"ussr:R38_KV-220", "Kv220"},
    {"ussr:R38_KV-220_action", "Kv220a"},
    {"ussr:R80_KV1", "Kv 1"},
    {"ussr:SU_85I", "Su85i"},
    {"ussr:T_50_2", "50 2"},
 //   # level 4
    {"china:Ch09_M5", "ChM5"},
    {"czech:Cz11_V_8_H", "vz.39"},
    {"france:AMX_Ob_Am105", "105AM"},
    {"france:AMX40", "amx40"},
    {"france:B1", "B1"},
    {"france:F70_SARL42", "sarl42"},
    {"france:Somua_Sau_40", "SAu40"},
    {"germany:B-1bis_captured", "PzB2"},
    {"germany:DW_II", "DW2"},
    {"germany:G101_StuG_III", "StugB"},
    {"germany:G22_Sturmpanzer_II", "StPz2"},
    {"germany:G39_Marder_III", "Mrdr38"},
    {"germany:G52_Pz38_NA", "Pz38na"},
    {"germany:G86_VK2001DB", "vk2001"},
    {"germany:Hetzer", "Hetzr"},
    {"germany:Pz_IV_AusfD", "Pz4d"},
    {"germany:Pz_Sfl_IVb", "PzS4b"},
    {"germany:G25_PzII_Luchs", "Luchs"},
    {"germany:PzIII_AusfJ", "Pz3"},
    {"japan:Chi_He", "ChiHe"},
    {"japan:J22_Type_95", "Typ95"},
    {"japan:Ke_Ho", "KeHo"},
    {"uk:GB04_Valentine", "Valnt"},
    {"uk:GB07_Matilda", "Matil"},
    {"uk:GB17_Grant_I", "Grant"},
    {"uk:GB26_Birch_Gun", "Birch"},
    {"uk:GB33_Sentinel_AC_I", "Sent"},
    {"uk:GB57_Alecto", "Alect"},
    {"uk:GB60_Covenanter", "Coven"},
    {"usa:A27_T82", "T82hmc"},
    {"usa:M3_Grant", "M3Lee"},
    {"usa:M37", "M37"},
    {"usa:M5_Stuart", "M5stu"},
    {"usa:M8A1", "M8a1"},
    {"usa:T40", "T40"},
    {"ussr:A-20", "A 20"},
    {"ussr:A-32", "A 32"},
    {"ussr:GAZ-74b", "Su85b"},
    {"ussr:R06_T-28", "t28"},
    {"ussr:R118_T28_F30", "t28e"},
    {"ussr:SU-5", "Su 5"},
    {"ussr:T-50", "t50"},
    {"ussr:T80", "t80"},
    {"ussr:Valentine_LL", "Valnt"},
    {"ussr:Valentine_LL_IGR", "Valnt"},
   // # level 3
    {"china:Ch08_Type97_Chi_Ha", "ChiHa"},
    {"czech:Cz10_LT_vz38", "vz.38"},
    {"france:AMX38", "amx38"},
    {"france:D2", "D2"},
    {"france:F44_Somua_S35", "SS35"},
    {"france:FCM_36Pak40", "Pak40"},
    {"france:Lorraine39_L_AM", "39Lam"},
    {"france:RenaultUE57", "UE57"},
    {"germany:G100_Gtraktor_Krupp", "GrTr"},
    {"germany:G11_Bison_I", "Bison"},
    {"germany:G117_Toldi_III", "Told3"},
    {"germany:G19_Wespe", "Wespe"},
    {"germany:G20_Marder_II", "Mrdr2"},
    {"germany:G34_S35_captured", "PzS35"},
    {"germany:G36_PzII_J", "Pz2j"},
    {"germany:G82_Pz_II_AusfG", "Pz2g"},
    {"germany:Pz_IV_AusfA", "Pz4a"},
    {"germany:Pz38t", "Pz38t"},
    {"germany:PzI_ausf_C", "Pz1c"},
    {"germany:PzIII_A", "Pz3a"},
    {"germany:T-15", "T 15"},
    {"japan:Chi_Ha", "JChiHa"},
    {"japan:J21_Type_91", "Typ91"},
    {"japan:J04_Ke_Ni", "KeNi"},
    {"japan:Ke_Ni_B", "KeNiO"},
    {"uk:GB06_Vickers_Medium_Mk_III", "Med3"},
    {"uk:GB15_Stuart_I", "stu1 4"},
    {"uk:GB27_Sexton", "Sext2"},
    {"uk:GB42_Valentine_AT", "ValAT"},
    {"uk:GB59_Cruiser_Mk_IV", "Cr4"},
    {"uk:GB69_Cruiser_Mk_II", "Cr2"},
    {"uk:GB78_Sexton_I", "Sext1"},
    {"usa:A03_M3_Stuart", "M3stu"},
    {"usa:A108_T18_HMC", "T18hmc"},
    {"usa:A109_T56_GMC", "T56gmc"},
    {"usa:A25_M2_med", "M2med"},
    {"usa:M22_Locust", "Locst"},
    {"usa:A16_M7_Priest", "Prist"},
    {"usa:MTLS-1G14", "mtls"},
    {"usa:Sexton_I", "Sext1"},
    {"ussr:BT-7", "Bt7"},
    {"ussr:BT-SV", "BtSV"},
    {"ussr:R86_LTP", "Ltp"},
    {"ussr:M3_Stuart_LL", "M3lght"},
    {"ussr:R105_BT_7A", "Bt7a"},
    {"ussr:R24_SU-76", "Su76"},
    {"ussr:SU-26", "Su 26"},
    {"ussr:SU76I", "Su76i"},
    {"ussr:T-127", "t127"},
    {"ussr:T-46", "t46"},
    {"ussr:T-70", "t70"},
 //   # level 2
    {"china:Ch07_Vickers_MkE_Type_BT26", "TypB"},
    {"czech:Cz03_LT_vz35", "vz.35"},
    {"france:D1", "D1"},
    {"france:F49_RenaultR35", "R35"},
    {"france:F50_FCM36_20t", "fcm36"},
    {"france:Hotchkiss_H35", "h35"},
    {"france:RenaultBS", "ftBS"},
    {"france:RenaultFT_AC", "ftAC"},
    {"germany:G06_PzII", "Pz2"},
    {"germany:G06_PzII_bot", "Pz2"},
    {"germany:G07_Pz35t", "Pz35t"},
    {"germany:G108_PzKpfwII_AusfD", "Pz2d"},
    {"germany:G21_PanzerJager_I", "PzJg1"},
    {"germany:G93_GW_Mk_VIe", "Gpz VI"},
    {"germany:H39_captured", "Pz38h"},
    {"germany:PzI", "Pz1"},
    {"japan:Chi_Ni", "ChiNi"},
    {"japan:J03_Ha_Go", "HaGo"},
    {"japan:J26_Type_89", "I go"},
    {"japan:Te_Ke", "TeKe"},
    {"uk:GB03_Cruiser_Mk_I", "Cr1"},
    {"uk:GB05_Vickers_Medium_Mk_II", "Med2"},
    {"uk:GB05_Vickers_Medium_Mk_II_bot", "Med2"},
    {"uk:GB14_M2", "M2"},
    {"uk:GB25_Loyd_Gun_Carriage", "LoydG"},
    {"uk:GB39_Universal_CarrierQF2", "QF2"},
    {"uk:GB58_Cruiser_Mk_III", "Cr3"},
    {"uk:GB76_Mk_VIC", "L.vic"},
    {"usa:A02_M2_lt", "M2lt"},
    {"usa:A107_T1_HMC", "T1hmc"},
    {"usa:A24_T2_med", "T2med"},
    {"usa:A24_T2_med_bot", "T2med"},
    {"usa:A46_T3", "T3hmc"},
    {"usa:T1_E6", "T1e6"},
    {"usa:T18", "T18"},
    {"usa:T2_lt", "T2lt"},
    {"usa:T57", "T57"},
    {"usa:T7_Combat_Car", "T7"},
    {"ussr:AT-1", "At1"},
    {"ussr:BT-2", "Bt2"},
    {"ussr:R16_SU-18", "Su 18"},
    {"ussr:T-26", "t26"},
    {"ussr:T-26_bot", "t26"},
    {"ussr:T-60", "t60"},
    {"ussr:Tetrarch_LL", "Tetrh"},
  //  # level 1
    {"china:Ch06_Renault_NC31", "NC31"},
    {"china:Ch06_Renault_NC31_bot", "NC31"},
    {"czech:Cz06_Kolohousenka", "khous"},
    {"france:RenaultFT", "FT"},
    {"france:RenaultFT_bot", "FT"},
    {"germany:Env_Artillery", "E.Art"},
    {"germany:Ltraktor", "Ltr"},
    {"germany:Ltraktor_bot", "Ltr"},
    {"japan:NC27", "R.Ots"},
    {"japan:NC27_bot", "R.Ots"},
    {"uk:GB01_Medium_Mark_I", "Med1"},
    {"uk:GB01_Medium_Mark_I_bot", "Med1"},
    {"usa:T1_Cunningham", "T1"},
    {"usa:T1_Cunningham_bot", "T1"},
    {"ussr:MS-1", "Ms 1"},
    {"ussr:MS-1_bot", "Ms 1"},
    {"ussr:Observer", ""},
        };
    }
}

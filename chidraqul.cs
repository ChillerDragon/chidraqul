/*
    chidraqul the game. Made by ChillerDragon.
    
    License:
       Feel free to use and edit the code for own projects.
       Also for commercial projects.
       But always keep this license in here and credit ChillerDragon.
*/

using System;
using System.Threading;
using System.IO;
class Sample
{
    public static void Main()
    {
        string pos0 = "_";
        string pos1 = "_";
        string pos2 = "_";
        string pos3 = "_";
        string pos4 = "_";
        string pos5 = "_";
        string pos6 = "_";
        string pos7 = "_";
        string pos8 = "_";
        string pos9 = "_";
        string pos10 = "_";
        string pos11 = "_";
        string pos12 = "_";
        string pos13 = "_";
        string pos14 = "_";
        string pos15 = "_";
        string pos16 = "_";
        string pos17 = "_";
        string pos18 = "_";
        string pos19 = "_";
        string pos20 = "_";
        string pos21 = "_";
        string pos22 = "_";
        string pos23 = "_";
        string pos24 = "_";
        string pos25 = "_";
        string pos26 = "_";
        string pos27 = "_";
        string pos28 = "_";
        string pos29 = "_";
        string pos30 = "_";
        string pos31 = "_";
        string pos32 = "_";
        string pos33 = "_";
        string pos34 = "_";
        string pos35 = "_";
        string pos36 = "_";
        string pos37 = "_";
        string pos38 = "_";
        string pos39 = "_";
        string pos40 = "_";
        //loch xD
        string pos50 = "_";
        string pos51 = "_";//weed :3
        string pos52 = "_";//weed :3
        string pos53 = "_";//weed :3
        string pos54 = "_";//weed :3
        string pos55 = "_";//weed :3
        string pos56 = "_";//weed :3
        string pos57 = "_";//weed :3
        string pos58 = "_";//weed :3
        string pos59 = "_";//weed :3
        string pos60 = "_";//weed :3
        string pos61 = "_";//wiid :3
        string pos62 = "_";
        string pos63 = "_";
        string pos64 = "_";
        string pos65 = "|";//door quest hood
        string pos66 = "_";
        string pos67 = "_";
        string pos68 = "_";
        string pos69 = "_";
        string pos70 = "_";
        string pos71 = "|";//door world2 hood
        string pos72 = "_";
        string pos73 = "_";
        string pos74 = "_";
        string pos75 = "_";
        string pos76 = "_";
        //ebene2
        string up0 = "";
        string up1 = "";
        string up2 = "";
        string up3 = "";
        string up4 = "";
        string up5 = "";
        string up6 = "";
        string up7 = "";
        string up8 = "";
        string up9 = "";
        string up10 = "";
        string up11 = "";
        string up12 = "";
        string up13 = "";
        string up14 = "";
        string up15 = "";
        string up16 = "";
        string up17 = "";
        string up18 = "";
        string up19 = "";
        string up20 = "";
        string up21 = "";
        string up22 = "";
        string up23 = "";
        string up24 = "";
        string up25 = "";
        string up26 = "";
        string up27 = "";
        string up28 = "";
        string up29 = "";
        string up30 = "";
        string up31 = "";
        string up32 = "";
        string up33 = "";
        string up34 = "";
        string up35 = "";
        string up36 = "";
        string up37 = "";
        string up38 = "";
        string up39 = "";
        string up40 = "";
        string up41 = "";
        string up42 = "";
        string up43 = "";
        string up44 = "";
        string up45 = "";
        string up46 = "";
        string up47 = "";
        string up48 = "";
        string up49 = "";
        string up50 = "";
        string up51 = "";//krümel dingens xD
        string up52 = "";//krümel dingens xD
        string up53 = "";//krümel dingens xD
        string up54 = "";//krümel dingens xD
        string up55 = "";//krümel dingens xD
        string up56 = "";//krümel dingens xD
        string up57 = "";//krümel dingens xD
        string up58 = "";//krümel dingens xD
        string up59 = "";//krümel dingens xD
        string up60 = "";//krümel dingens xD
        string up61 = "";
        string up62 = "";
        string up63 = "";
        string up64 = "";
        //ebene3   up = ebene2 aup = ebene3   bup = ebene4
        string aup0 = "";
        string aup1 = "";
        string aup2 = "";
        string aup3 = "";
        string aup4 = "";
        string aup5 = "";
        string aup6 = "";
        string aup7 = "";
        string aup8 = "";
        string aup9 = "";
        string aup10 = "";
        string aup11 = "";
        string aup12 = "";
        string aup13 = "";
        string aup14 = "";
        string aup15 = "";
        string aup16 = "";
        string aup17 = "";
        string aup18 = "";
        string aup19 = "";
        string aup20 = "";
        string aup21 = "";
        string aup22 = "";
        string aup23 = "";
        string aup24 = "";
        string aup25 = "";
        string aup26 = "";
        string aup27 = "";
        string aup28 = "";
        string aup29 = "";
        string aup30 = "";
        string aup31 = "";
        string aup32 = "";
        string aup33 = "";
        string aup34 = "";
        string aup35 = "";
        string aup36 = "";
        string aup37 = "";
        string aup38 = "";
        string aup39 = "";
        string aup40 = "";
        string aup41 = "";
        string aup42 = "";
        string aup43 = "";
        string aup44 = "";
        string aup45 = "";
        string aup46 = "";
        string aup47 = "";
        string aup48 = "";
        string aup49 = "";
        string aup50 = "";
        string aup51 = "";
        string aup52 = "";
        string aup53 = "";
        string aup54 = "";
        string aup55 = "";
        string aup56 = "";
        string aup57 = "";
        string aup58 = "";
        string aup59 = "";
        string aup60 = "";
        //ebene4   up = ebene2 aup = ebene3   bup = ebene4
        string bup0 = "";
        string bup1 = "";
        string bup2 = "";
        string bup3 = "";
        string bup4 = "";
        string bup5 = "";
        string bup6 = "";
        string bup7 = "";
        string bup8 = "";
        string bup9 = "";
        string bup10 = "";
        string bup11 = "";
        string bup12 = "";
        string bup13 = "";
        string bup14 = "";
        string bup15 = "";
        string bup16 = "";
        string bup17 = "";
        string bup18 = "";
        string bup19 = "";
        string bup20 = "";
        string bup21 = "";
        string bup22 = "";
        string bup23 = "";
        string bup24 = "";
        string bup25 = "";
        string bup26 = "";
        string bup27 = "";
        string bup28 = "";
        string bup29 = "";
        string bup30 = "";
        string bup31 = "";
        string bup32 = "";
        string bup33 = "";
        string bup34 = "";
        string bup35 = "";
        string bup36 = "";
        string bup37 = "";
        string bup38 = "";
        string bup39 = "";
        string bup40 = "";
        string bup41 = "";
        string bup42 = "";
        string bup43 = "";
        string bup44 = "";
        string bup45 = "";
        string bup46 = "";
        string bup47 = "";
        string bup48 = "";
        string bup49 = "";
        string bup50 = "";
        string bup51 = "";
        string bup52 = "";
        string bup53 = "";
        string bup54 = "";
        string bup55 = "";

        string up = " ";
        string aup = " ";
        string bup = " "; 

        string ebene1 = "_";
        string ebene2 = " ";
        string ebene3 = " ";
        string ebene4 = " ";
        string input;
        string skin;
        string inputmsg;
        string msg = "";
        string msg2 = "";
        string msg3 = "";
        string w2msg = " ";
        string w2msg2 = " ";
        string pus;
        string g = "_";
        string item = "_";
        string item2 = "_";
        string item3 = "_";
        string item4 = "_";
        string inv1 = " ";
        string inv2 = " ";
        string inv3 = " ";
        string inv4 = " ";
        string infohud = " ";







        int pos = 0;
        int botpos = 1;
        int botleftpos = 0;
        int botrightpos = 2;
        int xp = 0;
        int hp = 1;
        int bothp = 500;
        int bhp = 1;
        int hpdiff = 0;
        int xpdiff = 0;
        int lvl = 0;
        int gold = 0;
        int i = 0;
        int u = 0;
        int i2 = 0;
        int i3 = 0;
        int i4 = 0;
        int i5 = 0;
        int i6 = 0;
        int i7 = 0;
        int i8 = 0;
        int i9 = 0;
        int i10 = 0;
        int i11 = 0;
        int i12 = 0;
        int i13 = 0;
        int i14 = 0;
        int i15 = 0;  //special tick counter never set to 0
        int i16 = 0;
        int i17 = 0;  //world2 only
        int i18 = 0;  //world2 only
        int i19 = 0;  //world2 only
        int i20 = 0;  //world2 only
        int i21 = 1;  //world2 only
        int i22 = 0;  //quest
        int i23 = 0;
        int i24 = 0;
        int cookies = 0;
        int cookielvl = 0;
        int lvlcookies = 1;
        int cookiedelay = 10000000;
        int pclvl = 50; //pricecookielevel
        int fps = 64;
        int gres = 100;
        int gdel = 0;
        int pgold = 1;
        int php = 10;
        int plusgold = 1;
        int neededxp = 50;
        int plusneededxp = 100;
        int deaths = 0;
        int steps = 0;
        int left = -1;
        int right = 1;

        int item1anzahl = 0;
        int item2anzahl = 0;
        int item3anzahl = 0;
        int item4anzahl = 0;

        int phpregen = 100;
        int hpregendelay = 100;
        int hpregenlvl = 0;


        string data;
        bool menu = true;
        bool Shop = false;
        bool Beenden = false;
        bool die = false;
        bool botdie = false;
        bool jump = false;
        bool fly = false;
        bool jetpack = false;
        bool hat = false;
        bool rainbow = false;
        bool botalive = false;
        bool botmoveright = false;
        bool botmoveleft = false;
        bool grass = false;
        bool leftwall = false;
        bool rightwall = false;
        bool welcomemsg = true;

        //bought items

        bool buyskin1 = false;
        bool buyskin2 = false;
        bool buyskin3 = false;
        bool buyskin4 = false;



        bool admin = false;
        bool exit = false;

        skin = "#";
        string usehat = " ";  //hat using atm
        string uskin = "#";   // skin using atm
        string dskin = "#";
        string skin1 = "";
        string skin2 = "";
        string skin3 = "";
        string skin4 = "";

        //kwästotestopesto



        bool quest1 = false;
        bool qwin = false;
        bool bossfight = false;
        bool trap = false;

        int posq = 1;

        string qpus;
        string qskin = "_";

        string qpos1 = "";
        string qpos2 = "";
        string qpos3 = "";
        string qpos4 = "";
        string qpos5 = "";
        string qpos6 = "";
        string qpos7 = "";
        string qpos8 = "";
        string qpos9 = "";
        string qpos10 = "";
        string qpos11 = "";
        string qpos12 = "";
        string qpos13 = "";
        string qpos14 = "";
        string qpos15 = "";
        string qpos16 = "";
        string qpos17 = "";
        string qpos18 = "";
        string qpos19 = "";
        string qpos20 = "";
        string qpos21 = "";
        string qpos22 = "";
        string qpos23 = "";
        string qpos24 = "";
        string qpos25 = "";
        string qpos26 = "";
        string qpos27 = "";
        string qpos28 = "";
        string qpos29 = "";
        string qpos30 = "";
        string qpos31 = "";
        string qpos32 = "";
        string qpos33 = "";
        string qpos34 = "";
        string qpos35 = "";
        string qpos36 = "";
        string qpos37 = "";
        string qpos38 = "";
        string qpos39 = "";
        string qpos40 = "";

        string qup1 = "_";
        string qup2 = "_";
        string qup3 = "_";
        string qup4 = "_";
        string qup5 = "_";
        string qup6 = "_";
        string qup7 = "_";
        string qup8 = "_";
        string qup9 = "_";
        string qup10 = "_";
        string qup11 = "_";
        string qup12 = "_";
        string qup13 = "_";
        string qup14 = "_";
        string qup15 = "_";
        string qup16 = "_";
        string qup17 = "_";
        string qup18 = "_";
        string qup19 = "_";
        string qup20 = "_";
        string qup21 = "_";
        string qup22 = "_";
        string qup23 = "_";
        string qup24 = "_";
        string qup25 = "_";
        string qup26 = "_";
        string qup27 = "_";
        string qup28 = "_";
        string qup29 = "_";
        string qup30 = "_";
        string qup31 = "_";
        string qup32 = "_";
        string qup33 = "_";
        string qup34 = "_";
        string qup35 = "_";
        string qup36 = "_";
        string qup37 = "_";
        string qup38 = "_";
        string qup39 = "_";
        string qup40 = "_";

        string qaup1 = "_";
        string qaup2 = "_";
        string qaup3 = "_";
        string qaup4 = "_";
        string qaup5 = "_";
        string qaup6 = "_";
        string qaup7 = "_";
        string qaup8 = "_";
        string qaup9 = "_";
        string qaup10 = "_";
        string qaup11 = "_";
        string qaup12 = "_";
        string qaup13 = "_";
        string qaup14 = "_";
        string qaup15 = "_";
        string qaup16 = "_";
        string qaup17 = "_";
        string qaup18 = "_";
        string qaup19 = "_";
        string qaup20 = "_";
        string qaup21 = "_";
        string qaup22 = "_";
        string qaup23 = "_";
        string qaup24 = "_";
        string qaup25 = "_";
        string qaup26 = "_";
        string qaup27 = "_";
        string qaup28 = "_";
        string qaup29 = "_";
        string qaup30 = "_";
        string qaup31 = "_";
        string qaup32 = "_";
        string qaup33 = "_";
        string qaup34 = "_";
        string qaup35 = "_";
        string qaup36 = "_";
        string qaup37 = "_";
        string qaup38 = "_";
        string qaup39 = "_";
        string qaup40 = "_";


        //world 2

        bool world2 = false;

        int posw = 1;

        string wpus;

        string wpos1 = "";
        string wpos2 = "";
        string wpos3 = "";
        string wpos4 = "";
        string wpos5 = "";
        string wpos6 = "";
        string wpos7 = "";
        string wpos8 = "";
        string wpos9 = "";
        string wpos10 = "";



        //bot
        string botl = "<";
        string botm = "x";
        string botr = ">";
        bool isinventory = false;
        bool isshop = false;
        bool ismsg = true;
        bool info = false;
        Random rnd = new Random();
        Random itempos = new Random();
        Random sdelay = new Random();
        Random sdelay2 = new Random();
        Random itempos2 = new Random();
        Random botmovement = new Random();
        int rand = rnd.Next(20, 35);                         // gold pos
        int rand1 = itempos.Next(5, 35);                     //item1 + pos
        int rand2 = itempos2.Next(5, 35);                    //item2 x pos
        int rand3 = rnd.Next(5, 35);                         //item3 ° pos
        int rand4 = rnd.Next(10, 27);                        //item4 * pos
        int spawndelay = sdelay.Next(500, 20000);            //item1 + spawn delay
        int spawndelay2 = sdelay2.Next(900, 500000);         //item2 x spawn delay
        int spawndelay3 = rnd.Next(250, 854);                //item3 ° spawn delay
        int spawndelay4 = rnd.Next(100, 7000);               //item4 * spawn delay
        int botmove = botmovement.Next(0, 10);               //50% left or right bot movement
        int bmlrrg = botmovement.Next(0, 60);                //bmlrrg = botmoveleftrightrandomgenerator
        int randombotspawndelay = rnd.Next(100, 5000000);    //random bot spawn delay indicator yolo random xD
        int grassdmg = rnd.Next(3, 10);                      //random grass damage delay
        int hackdelay = rnd.Next(5, 10);                     //hack loading delay
        int infoanim = rnd.Next(1, 3);                       //info animation ▒  █ ▄
        int rndfps = rnd.Next(0, 10);                        //random fps geration

        //OMG SPECIAL HAXXX
        int hacks = 0;  // pro haxxoooor
                        //hack yolo xD


        /*
        System.Timers.Timer aTimer = new System.Timers.Timer();
        aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
        aTimer.Interval = 5000;
        aTimer.Enabled = true;
        */

        


        //testy changlog
        isinventory = true;
        Console.WriteLine("                                                                                ");
        Console.WriteLine("********************************************************************************");
        Console.WriteLine("*                       chidraqul by ChillerDragon                             *");
        Console.WriteLine("********************************************************************************");
        Console.WriteLine("                                                                                ");
        Console.WriteLine(" v. 0.0.1                                                                       ");
        Console.WriteLine("     - added a changelog                                                        ");
        Console.WriteLine("     - fick bugsis                                                              ");
        Console.WriteLine("                                                                                ");
        Console.WriteLine("                                                                                ");
        Console.WriteLine("                                                                                ");
        Console.WriteLine("********************************************************************************");



        //###################################
        // START AND LOAD
        //###################################

        //---- SETTING PATHS ----
        // The folder for the roaming current user 
        string RoamingFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        //adding chidraqul path strings
        string chidraqulFolder = Path.Combine(RoamingFolder, "chidraqul");
        string chidraqul1Folder = Path.Combine(chidraqulFolder, "chidraqul1");
        string savesPath = Path.Combine(chidraqul1Folder, "saves.txt"); //integers
        string saves2Path = Path.Combine(chidraqul1Folder, "saves2.txt"); //strings



        //---- LOADING DATA INTEGER ----
        if (File.Exists(savesPath))
        {
            StreamReader sr = new StreamReader(savesPath);
            while (!sr.EndOfStream)
            {
                cookielvl = Int32.Parse(sr.ReadLine());
                lvlcookies = Int32.Parse(sr.ReadLine());
                cookiedelay = Int32.Parse(sr.ReadLine());
                bhp = Int32.Parse(sr.ReadLine());                    //default: 1
                phpregen = Int32.Parse(sr.ReadLine());
                hpregendelay = Int32.Parse(sr.ReadLine());
                hpregenlvl = Int32.Parse(sr.ReadLine());
                deaths = Int32.Parse(sr.ReadLine());
                steps = Int32.Parse(sr.ReadLine());
                xp = Int32.Parse(sr.ReadLine());                     //default: 0
                lvl = Int32.Parse(sr.ReadLine());                    //default: 0
                gold = Int32.Parse(sr.ReadLine());                   //default: 0
                cookies = Int32.Parse(sr.ReadLine());
                neededxp = Int32.Parse(sr.ReadLine());               //default: 50
                plusneededxp = Int32.Parse(sr.ReadLine());
                php = Int32.Parse(sr.ReadLine());                    //default: 10
                pgold = Int32.Parse(sr.ReadLine());                  //default: 1
                plusgold = Int32.Parse(sr.ReadLine());               //default: 1
                hp = Int32.Parse(sr.ReadLine());                     //default: 1
                pos = Int32.Parse(sr.ReadLine());                    //default: 0
                gdel = Int32.Parse(sr.ReadLine());                   //default: 0
                gres = Int32.Parse(sr.ReadLine());                   //default: 100
                item1anzahl = Int32.Parse(sr.ReadLine());
                item2anzahl = Int32.Parse(sr.ReadLine());
                item3anzahl = Int32.Parse(sr.ReadLine());
                item4anzahl = Int32.Parse(sr.ReadLine());
                pclvl = Int32.Parse(sr.ReadLine());
            }
            sr.Close();
        }


        //---- LOADING DATA STRINGS ----
        if (File.Exists(saves2Path))
        {
            StreamReader sr = new StreamReader(saves2Path);
            while (!sr.EndOfStream)
            {
                uskin = sr.ReadLine();
                skin = sr.ReadLine();
                skin1 = sr.ReadLine();
                skin2 = sr.ReadLine();
                skin3 = sr.ReadLine();
                skin4 = sr.ReadLine();
                inv1 = sr.ReadLine();
                inv2 = sr.ReadLine();
                inv3 = sr.ReadLine();
                inv4 = sr.ReadLine();
            }
            sr.Close();
        }

        ConsoleKeyInfo cki = new ConsoleKeyInfo();
        do
        {

            if (welcomemsg == true && isinventory == false)
            {
                ismsg = true;
                Console.Clear();
                Console.WriteLine("use the arrows on your keyboard to move.\nUse T to write commands. \nPress X to save and exit the game.");
                if (i24 > 5)
                {
                    welcomemsg = false;
                }
            }

  
            //cancle fly
            if (pos == 65 || pos == 71)
            {
                fly = false;
            }



            //fps generation
            if (rndfps < 5 && fps > 59)
            {
                fps--;
                rndfps = rnd.Next(0, 10);
            }
            else if (rndfps >= 5 && fps < 3000)
            {
                fps++;
                rndfps = rnd.Next(0, 10);
            }
            else
            {
                rndfps = rnd.Next(0, 10);
            }



            // grass check
            if (pos == 51 || pos == 52 || pos == 53 || pos == 54 || pos == 55 || pos == 56 || pos == 57 || pos == 58 || pos == 59 || pos == 60)
            {
                grass = true;
            }
            else if (pos < 51 || pos > 60)
            {
                grass = false;
            }


            if (grass == true)
            {
                xp++;
                gold++;
                if (grassdmg <= i12)
                {

                    inputmsg = "Ouch! The evil grass damaged you.";



                    if (msg3 == "" && msg2 == "" && msg != "")
                    {
                        i13 = i;
                        i = 0;
                        msg2 = msg;
                        msg = inputmsg;
                    }
                    else if (msg3 == "" && msg2 != "" && msg != "")
                    {
                        i23 = i13;
                        i13 = i;
                        i = 0;
                        msg3 = msg2;
                        msg2 = msg;
                        msg = inputmsg;
                    }
                    else if (msg3 != "" && msg2 != "" && msg != "")
                    {
                        i23 = i13;
                        i13 = i;
                        i = 0;
                        msg3 = msg2;
                        msg2 = msg;
                        msg = inputmsg;
                    }
                    else
                    {
                        i = 0;
                        msg = inputmsg;
                    }




                    grassdmg = rnd.Next(1, 15);
                    hp--;
                    i12 = 0;
                }
            }



            //hpregen
            if (hpregenlvl >= 1)
            {
                if (i11 >= hpregendelay && hp < bhp)
                {
                    hp++;
                    i11 = 0;
                }
            }


            //info animation
            if (infoanim == 1)
            {
                infohud = "▒";
                infoanim = rnd.Next(1, 3);
            }
            else if (infoanim == 2)
            {
                infohud = "█";
                infoanim = rnd.Next(1, 3);
            }
            else if (infoanim == 3)
            {
                infohud = "▄";
                infoanim = rnd.Next(1, 3);
            }
            else if (infoanim == 4)
            {
                infohud = "`°";
                infoanim = rnd.Next(1, 3);
            }

            //bot skin
            if (botalive == true)
            {
                if (i7 == 0)
                {
                    botm = "+";
                }
                else if (i7 == 1)
                {
                    botm = "x";
                }
                else
                {
                    botm = "|";
                    i7 = 0;
                }
            }

            //bot death
            if (botdie == true)
            {


               inputmsg = "The Bot died OMG!!!                        +5000xp";




                if (msg3 == "" && msg2 == "" && msg != "")
                {
                    i13 = i;
                    i = 0;
                    msg2 = msg;
                    msg = inputmsg;
                }
                else if (msg3 == "" && msg2 != "" && msg != "")
                {
                    i23 = i13;
                    i13 = i;
                    i = 0;
                    msg3 = msg2;
                    msg2 = msg;
                    msg = inputmsg;
                }
                else if (msg3 != "" && msg2 != "" && msg != "")
                {
                    i23 = i13;
                    i13 = i;
                    i = 0;
                    msg3 = msg2;
                    msg2 = msg;
                    msg = inputmsg;
                }
                else
                {
                    i = 0;
                    msg = inputmsg;
                }




                botdie = false;
            }
            //bot hp
            if (bothp <= 0)
            {
                botalive = false;
                botdie = true;
                bothp = 500;
                
                xp = xp + 5000;
            }

            //bot live
            if (botalive == true)
            {
                ebene4 = botm;
            }
            else if (botalive == false)
            {
                ebene4 = " ";
            }


            if (rainbow == true)
            {
                if (i6 == 0)
                {
                    uskin = "x";
                }
                else if (i6 == 1)
                {
                    uskin = "*";
                }
                else if (i6 == 2)
                {
                    uskin = ",";
                }
                else if (i6 == 3)
                {
                    uskin = "~";
                }
                else if (i6 == 4)
                {
                    uskin = "@";
                }
                else if (i6 == 5)
                {
                    uskin = "&";
                }
                else if (i6 == 6)
                {
                    uskin = "?";
                }
                else if (i6 == 7)
                {
                    uskin = "/";
                }
                else if (i6 == 8)
                {
                    uskin = "-";
                }
                else if (i6 == 9)
                {
                    uskin = "=";
                }
                else if (i6 == 10)
                {
                    uskin = "%";
                }
                else
                {
                    uskin = "i";
                    i6 = 0;
                }
            }

            if (usehat == "x")
            {
                if (fly == true)
                {
                    if (i5 == 0)
                    {
                        ebene3 = "x";
                    }
                    else if (i5 == 1)
                    {
                        ebene3 = "*";
                    }
                    else if (i5 == 2)
                    {
                        ebene3 = ".";
                    }
                    else if (i5 == 3)
                    {
                        ebene3 = "~";
                    }
                    else if (i5 == 4)
                    {
                        ebene3 = "@";
                    }
                    else if (i5 == 5)
                    {
                        ebene3 = "&";
                    }
                    else if (i5 == 6)
                    {
                        ebene3 = "?";
                    }
                    else if (i5 == 7)
                    {
                        ebene3 = "/";
                    }
                    else if (i5 == 8)
                    {
                        ebene3 = "-";
                    }
                    else if (i5 == 9)
                    {
                        ebene3 = "§";
                    }
                    else if (i5 == 10)
                    {
                        ebene3 = "%";
                    }
                    else if (i5 == 11)
                    {
                        ebene3 = "<";
                    }
                    else if (i5 == 12)
                    {
                        ebene3 = ">";
                    }
                    else if (i5 == 13)
                    {
                        ebene3 = ":";
                    }
                    else if (i5 == 14)
                    {
                        ebene3 = "µ";
                    }
                    else if (i5 == 15)
                    {
                        ebene3 = "²";
                    }
                    else if (i5 == 16)
                    {
                        ebene3 = "³";
                    }
                    else if (i5 == 17)
                    {
                        ebene3 = "°";
                    }
                    else if (i5 == 18)
                    {
                        ebene3 = "[";
                    }
                    else if (i5 == 19)
                    {
                        ebene3 = "{";
                    }
                    else if (i5 == 20)
                    {
                        ebene3 = "u";
                    }
                    else if (i5 == 21)
                    {
                        ebene3 = "1";
                    }
                    else if (i5 == 22)
                    {
                        ebene3 = "}";
                    }
                    else if (i5 == 23)
                    {
                        ebene3 = "ü";
                    }
                    else
                    {
                        ebene3 = "!";
                        i5 = 0;
                    }
                }
                else if (fly == false)
                { 
                if (i5 == 0)
                {
                    ebene2 = "x";
                }
                else if (i5 == 1)
                {
                    ebene2 = "*";
                }
                else if (i5 == 2)
                {
                    ebene2 = ".";
                }
                else if (i5 == 3)
                {
                    ebene2 = "~";
                }
                else if (i5 == 4)
                {
                    ebene2 = "@";
                }
                else if (i5 == 5)
                {
                    ebene2 = "&";
                }
                else if (i5 == 6)
                {
                    ebene2 = "?";
                }
                else if (i5 == 7)
                {
                    ebene2 = "/";
                }
                else if (i5 == 8)
                {
                    ebene2 = "-";
                }
                else if (i5 == 9)
                {
                    ebene2 = "§";
                }
                else if (i5 == 10)
                {
                    ebene2 = "%";
                }
                else if (i5 == 11)
                {
                    ebene2 = "<";
                }
                else if (i5 == 12)
                {
                    ebene2 = ">";
                }
                else if (i5 == 13)
                {
                    ebene2 = ":";
                }
                else if (i5 == 14)
                {
                    ebene2 = "µ";
                }
                else if (i5 == 15)
                {
                    ebene2 = "²";
                }
                else if (i5 == 16)
                {
                    ebene2 = "³";
                }
                else if (i5 == 17)
                {
                    ebene2 = "°";
                }
                else if (i5 == 18)
                {
                    ebene2 = "[";
                }
                else if (i5 == 19)
                {
                    ebene2 = "{";
                }
                else if (i5 == 20)
                {
                    ebene2 = "u";
                }
                else if (i5 == 21)
                {
                    ebene2 = "1";
                }
                else if (i5 == 22)
                {
                    ebene2 = "}";
                }
                else if (i5 == 23)
                {
                    ebene2 = "ü";
                }
                else
                {
                    ebene2 = "!";
                    i5 = 0;
                }
            }
            }

            //out of world damage
            if (pos < 0 || pos > 70)
            {
                hp--;
            }


            if (hp <= 0)
            {
                die = true;
            }

            if (die == true)
            {
                deaths++;
                hp = bhp;
                pos = 0;
                die = false;

                inputmsg = "You died.";

                if (msg3 == "" && msg2 == "" && msg != "")
                {
                    i13 = i;
                    i = 0;
                    msg2 = msg;
                    msg = inputmsg;
                }
                else if (msg3 == "" && msg2 != "" && msg != "")
                {
                    i23 = i13;
                    i13 = i;
                    i = 0;
                    msg3 = msg2;
                    msg2 = msg;
                    msg = inputmsg;
                }
                else if (msg3 != "" && msg2 != "" && msg != "")
                {
                    i23 = i13;
                    i13 = i;
                    i = 0;
                    msg3 = msg2;
                    msg2 = msg;
                    msg = inputmsg;
                }
                else
                {
                    i = 0;
                    msg = inputmsg;
                }

                if (gold > 0)
                {
                    gold--;
                }
            }



            xpdiff = neededxp - xp;
            hpdiff = bhp - hp;


            i24++;
            i23++;
            i16++;
            i15++;     //special tick counter never set to 0 (null)
            i14++;
            i13++;
            i12++;
            i11++;
            i10++;
            i9++;
            i8++;
            i7++;
            i6++;
            i5++;
            i4++;
            i3++;
            i2++;
            i++;




            //bot spawner xD
            if (i10 >= randombotspawndelay && botalive == false)
            {
                botalive = true;
                i10 = 0;
            }

            //gold generator

            if (i2 > gres && g == "_")
            {
                rand = rnd.Next(20, 35);
                g = "$";
                i2 = 0; 
            }







                /*   old xp check (bad)
                if (xp > neededxp)
                {
                    // variabel
                    int xpplus;
                    xpplus = 0;
                    //


                    xpplus = neededxp - xp;
                    xp = xp + xpplus;
                }
                */
                if (xp >= neededxp)
            {
                if (ismsg == false)
                {
                 
                    lvl++;
                    plusgold++;
                    gold = gold + plusgold;
                    cookies = cookies + plusgold;
                    i = 0;
                    plusneededxp = plusneededxp + 100;
                    neededxp = neededxp + plusneededxp;
                    String.Format("LEVEL UP!!!  YOU ARE NOW LEVEL {0}   +{1} Gold  +{2} cookies", lvl, plusgold, plusgold); //fick buses
                    data = "LEVEL UP!!!  YOU ARE NOW LEVEL {0}   +{1} Gold  +{2} cookies";

                    inputmsg = string.Format(data, lvl, plusgold, plusgold);

                    if (msg3 == "" && msg2 == "" && msg != "")
                    {
                        i13 = i;
                        i = 0;
                        msg2 = msg;
                        msg = inputmsg;
                    }
                    else if (msg3 == "" && msg2 != "" && msg != "")
                    {
                        i23 = i13;
                        i13 = i;
                        i = 0;
                        msg3 = msg2;
                        msg2 = msg;
                        msg = inputmsg;
                    }
                    else if (msg3 != "" && msg2 != "" && msg != "")
                    {
                        i23 = i13;
                        i13 = i;
                        i = 0;
                        msg3 = msg2;
                        msg2 = msg;
                        msg = inputmsg;
                    }
                    else
                    {
                        i = 0;
                        msg = inputmsg;
                    }

                }

            }

            up0 = " ";
            up1 = " ";
            up2 = " ";
            up3 = " ";
            up4 = " ";
            up5 = " ";
            up6 = " ";
            up7 = " ";
            up8 = " ";
            up9 = " ";
            up10 = " ";
            up11 = " ";
            up12 = " ";
            up13 = " ";
            up14 = " ";
            up15 = " ";
            up16 = " ";
            up17 = " ";
            up18 = " ";
            up19 = " ";
            up20 = " ";
            up21 = " ";
            up22 = " ";
            up23 = " ";
            up24 = " ";
            up25 = " ";
            up26 = " ";
            up27 = " ";
            up28 = " ";
            up29 = " ";
            up30 = " ";
            up31 = " ";
            up32 = " ";
            up33 = " ";
            up34 = " ";
            up35 = " ";
            up36 = " ";
            up37 = " ";
            up38 = " ";
            up39 = " ";
            up40 = " ";
            up41 = " ";
            up42 = " ";
            up43 = " ";
            up44 = " ";
            up45 = " ";
            up46 = " ";
            up47 = " ";
            up48 = " ";
            up49 = " ";
            up50 = " ";
            //grass!
            up51 = ".";
            up52 = ".";
            up53 = ".";
            up54 = ".";
            up55 = ".";
            up56 = ".";
            up57 = ".";
            up58 = ".";
            up59 = ".";
            up60 = ".";
            //kein grass!
            up61 = " ";
            up62 = " ";
            up63 = " ";
            up64 = " ";



            //up0 = "~";
            //up1 = "~";
            //up2 = "~";
            //up3 = "~";
            //up4 = "~";
            //up5 = "~";
            //up6 = "~";
            //up7 = "~";
            //up8 = "~";
            //up9 = "~";
            //up10 = "~";
            //up11 = "~";
            //up12 = "~";
            //up13 = "~";
            //up14 = "~";
            //up15 = "~";
            //up16 = "~";
            //up17 = "~";
            //up18 = "~";
            //up19 = "~";
            //up20 = "~";
            //up21 = "~";
            //up22 = "~";
            //up23 = "~";
            //up24 = "~";
            //up25 = "~";
            //up26 = "~";
            //up27 = "~";
            //up28 = "~";
            //up29 = "~";
            //up30 = "~";
            //up31 = "~";
            //up32 = "~";
            //up33 = "~";
            //up34 = "~";
            //up35 = "~";
            //up36 = "~";
            //up37 = "~";
            //up38 = "~";
            //up39 = "~";
            //up40 = "~";

            //ebene 3
            aup0 = " ";
            aup1 = " ";
            aup2 = " ";
            aup3 = " ";
            aup4 = " ";
            aup5 = " ";
            aup6 = " ";
            aup7 = " ";
            aup8 = " ";
            aup9 = " ";
            aup10 = " ";
            aup11 = " ";
            aup12 = " ";
            aup13 = " ";
            aup14 = " ";
            aup15 = " ";
            aup16 = " ";
            aup17 = " ";
            aup18 = " ";
            aup19 = " ";
            aup20 = " ";
            aup21 = " ";
            aup22 = " ";
            aup23 = " ";
            aup24 = " ";
            aup25 = " ";
            aup26 = " ";
            aup27 = " ";
            aup28 = " ";
            aup29 = " ";
            aup30 = " ";
            aup31 = " ";
            aup32 = " ";
            aup33 = " ";
            aup34 = " ";
            aup35 = " ";
            aup36 = " ";
            aup37 = " ";
            aup38 = " ";
            aup39 = " ";
            aup40 = " ";
            aup41 = " ";
            aup42 = " ";
            aup43 = " ";
            aup44 = " ";
            aup45 = " ";
            aup46 = " ";
            aup47 = " ";
            aup48 = " ";
            aup49 = " ";
            aup50 = " ";
            aup51 = " ";
            aup52 = " ";
            aup53 = " ";
            aup54 = " ";
            aup55 = " ";
            aup56 = " ";
            aup57 = " ";
            aup58 = " ";
            aup59 = " ";
            aup60 = " ";

            //ebene 4
            bup0 = " ";
            bup1 = " ";
            bup2 = " ";
            bup3 = " ";
            bup4 = " ";
            bup5 = " ";
            bup6 = " ";
            bup7 = " ";
            bup8 = " ";
            bup9 = " ";
            bup10 = " ";
            bup11 = " ";
            bup12 = " ";
            bup13 = " ";
            bup14 = " ";
            bup15 = " ";
            bup16 = " ";
            bup17 = " ";
            bup18 = " ";
            bup19 = " ";
            bup20 = " ";
            bup21 = " ";
            bup22 = " ";
            bup23 = " ";
            bup24 = " ";
            bup25 = " ";
            bup26 = " ";
            bup27 = " ";
            bup28 = " ";
            bup29 = " ";
            bup30 = " ";
            bup31 = " ";
            bup32 = " ";
            bup33 = " ";
            bup34 = " ";
            bup35 = " ";
            bup36 = " ";
            bup37 = " ";
            bup38 = " ";
            bup39 = " ";
            bup40 = " ";
            bup41 = " ";
            bup42 = " ";
            bup43 = " ";
            bup44 = " ";
            bup45 = " ";
            bup46 = " ";
            bup47 = " ";
            bup48 = " ";
            bup49 = " ";
            bup50 = " ";
            bup51 = " ";
            bup52 = " ";
            bup53 = " ";
            bup54 = " ";
            bup55 = " ";




            pos0 = "_";
            pos1 = "_";
            pos2 = "_";
            pos3 = "_";
            pos4 = "_";
            pos5 = "_";
            pos6 = "_";
            pos7 = "_";
            pos8 = "_";
            pos9 = "_";
            pos10 = "_";
            pos11 = "_";
            pos12 = "_";
            pos13 = "_";
            pos14 = "_";
            pos15 = "_";
            pos16 = "_";
            pos17 = "_";
            pos18 = "_";
            pos19 = "_";
            pos20 = "_";
            pos21 = "_";
            pos22 = "_";
            pos23 = "_";
            pos24 = "_";
            pos25 = "_";
            pos26 = "_";
            pos27 = "_";
            pos28 = "_";
            pos29 = "_";
            pos30 = "_";
            pos31 = "_";
            pos32 = "_";
            pos33 = "_";
            pos34 = "_";
            pos35 = "_";
            pos36 = "_";
            pos37 = "_";
            pos38 = "_";
            pos39 = "_";
            pos40 = "_";
            //hole xD
            pos50 = "_";
            pos51 = "|";
            pos52 = "|";
            pos53 = "|";
            pos54 = "|";
            pos55 = "|";
            pos56 = "|";
            pos57 = "|";
            pos58 = "|";
            pos59 = "|";
            pos60 = "|";
            //no grass
            pos61 = "_";
            pos62 = "_";
            pos63 = "_";
            pos64 = "_";
            pos65 = "|";
            pos66 = "_";
            pos67 = "_";
            pos68 = "_";
            pos69 = "_";
            pos70 = "_";
            pos71 = "|";
            pos72 = "_";
            pos73 = "_";
            pos74 = "_";
            pos75 = "_";
            pos76 = "_";




            //door check
            if (pos == 64 || pos == 66)
            {
                pos65 = "_";
            }

            //door2 check
            if (inv4 == "*")
            {
                if (pos == 70 || pos == 72)
                {
                    pos71 = "_";
                }
            }
            else
            {

            }





            pus = g;









            //randomgold
            if (rand == 0)
            {
                pos0 = pus;
            }
            else if (rand == 1)
            {
                pos1 = pus;
            }
            else if (rand == 2)
            {
                pos2 = pus;
            }
            else if (rand == 3)
            {
                pos3 = pus;
            }
            else if (rand == 4)
            {
                pos4 = pus;
            }
            else if (rand == 5)
            {
                pos5 = pus;
            }
            else if (rand == 6)
            {
                pos6 = pus;
            }
            else if (rand == 7)
            {
                pos7 = pus;
            }
            else if (rand == 8)
            {
                pos8 = pus;
            }
            else if (rand == 9)
            {
                pos9 = pus;
            }
            else if (rand == 10)
            {
                pos10 = pus;
            }
            else if (rand == 11)
            {
                pos11 = pus;
            }
            else if (rand == 12)
            {
                pos12 = pus;
            }
            else if (rand == 13)
            {
                pos13 = pus;
            }
            else if (rand == 14)
            {
                pos14 = pus;
            }
            else if (rand == 15)
            {
                pos15 = pus;
            }
            else if (rand == 16)
            {
                pos16 = pus;
            }
            else if (rand == 17)
            {
                pos17 = pus;
            }
            else if (rand == 18)
            {
                pos18 = pus;
            }
            else if (rand == 19)
            {
                pos19 = pus;
            }
            else if (rand == 20)
            {
                pos20 = pus;
            }
            else if (rand == 21)
            {
                pos21 = pus;
            }
            else if (rand == 22)
            {
                pos22 = pus;
            }
            else if (rand == 23)
            {
                pos23 = pus;
            }
            else if (rand == 24)
            {
                pos24 = pus;
            }
            else if (rand == 25)
            {
                pos25 = pus;
            }
            else if (rand == 26)
            {
                pos26 = pus;
            }
            else if (rand == 27)
            {
                pos27 = pus;
            }
            else if (rand == 28)
            {
                pos28 = pus;
            }
            else if (rand == 29)
            {
                pos29 = pus;
            }
            else if (rand == 30)
            {
                pos30 = pus;
            }
            else if (rand == 31)
            {
                pos31 = pus;
            }
            else if (rand == 32)
            {
                pos32 = pus;
            }
            else if (rand == 33)
            {
                pos33 = pus;
            }
            else if (rand == 34)
            {
                pos34 = pus;
            }
            else if (rand == 35)
            {
                pos35 = pus;
            }
            else if (rand == 36)
            {
                pos36 = pus;
            }
            else if (rand == 37)
            {
                pos37 = pus;
            }
            else if (rand == 38)
            {
                pos38 = pus;
            }
            else if (rand == 39)
            {
                pos39 = pus;
            }
            else if (rand == 40)
            {
                pos40 = pus;
            }


            //random item generation
            if (i3 > spawndelay && item == "_")
            {
                rand1 = itempos.Next(5, 35);
                spawndelay = sdelay.Next(500, 50000);
                item = "+";
                i3 = 0;
            }

            pus = item;


            //random item
            if (rand1 == 0)
            {
                pos0 = pus;
            }
            else if (rand1 == 1)
            {
                pos1 = pus;
            }
            else if (rand1 == 2)
            {
                pos2 = pus;
            }
            else if (rand1 == 3)
            {
                pos3 = pus;
            }
            else if (rand1 == 4)
            {
                pos4 = pus;
            }
            else if (rand1 == 5)
            {
                pos5 = pus;
            }
            else if (rand1 == 6)
            {
                pos6 = pus;
            }
            else if (rand1 == 7)
            {
                pos7 = pus;
            }
            else if (rand1 == 8)
            {
                pos8 = pus;
            }
            else if (rand1 == 9)
            {
                pos9 = pus;
            }
            else if (rand1 == 10)
            {
                pos10 = pus;
            }
            else if (rand1 == 11)
            {
                pos11 = pus;
            }
            else if (rand1 == 12)
            {
                pos12 = pus;
            }
            else if (rand1 == 13)
            {
                pos13 = pus;
            }
            else if (rand1 == 14)
            {
                pos14 = pus;
            }
            else if (rand1 == 15)
            {
                pos15 = pus;
            }
            else if (rand1 == 16)
            {
                pos16 = pus;
            }
            else if (rand1 == 17)
            {
                pos17 = pus;
            }
            else if (rand1 == 18)
            {
                pos18 = pus;
            }
            else if (rand1 == 19)
            {
                pos19 = pus;
            }
            else if (rand1 == 20)
            {
                pos20 = pus;
            }
            else if (rand1 == 21)
            {
                pos21 = pus;
            }
            else if (rand1 == 22)
            {
                pos22 = pus;
            }
            else if (rand1 == 23)
            {
                pos23 = pus;
            }
            else if (rand1 == 24)
            {
                pos24 = pus;
            }
            else if (rand1 == 25)
            {
                pos25 = pus;
            }
            else if (rand1 == 26)
            {
                pos26 = pus;
            }
            else if (rand1 == 27)
            {
                pos27 = pus;
            }
            else if (rand1 == 28)
            {
                pos28 = pus;
            }
            else if (rand1 == 29)
            {
                pos29 = pus;
            }
            else if (rand1 == 30)
            {
                pos30 = pus;
            }
            else if (rand1 == 31)
            {
                pos31 = pus;
            }
            else if (rand1 == 32)
            {
                pos32 = pus;
            }
            else if (rand1 == 33)
            {
                pos33 = pus;
            }
            else if (rand1 == 34)
            {
                pos34 = pus;
            }
            else if (rand1 == 35)
            {
                pos35 = pus;
            }
            else if (rand1 == 36)
            {
                pos36 = pus;
            }
            else if (rand1 == 37)
            {
                pos37 = pus;
            }
            else if (rand1 == 38)
            {
                pos38 = pus;
            }
            else if (rand1 == 39)
            {
                pos39 = pus;
            }
            else if (rand1 == 40)
            {
                pos40 = pus;
            }

           


            up = ebene2;

            //ebene two
            if (pos == 0)
            {
                up0 = up;
            }
            else if (pos == 1)
            {
                up1 = up;
            }
            else if (pos == 2)
            {
                up2 = up;
            }
            else if (pos == 3)
            {
                up3 = up;
            }
            else if (pos == 4)
            {
                up4 = up;
            }
            else if (pos == 5)
            {
                up5 = up;
            }
            else if (pos == 6)
            {
                up6 = up;
            }
            else if (pos == 7)
            {
                up7 = up;
            }
            else if (pos == 8)
            {
                up8 = up;
            }
            else if (pos == 9)
            {
                up9 = up;
            }
            else if (pos == 10)
            {
                up10 = up;
            }
            else if (pos == 11)
            {
                up11 = up;
            }
            else if (pos == 12)
            {
                up12 = up;
            }
            else if (pos == 13)
            {
                up13 = up;
            }
            else if (pos == 14)
            {
                up14 = up;
            }
            else if (pos == 15)
            {
                up15 = up;
            }
            else if (pos == 16)
            {
                up16 = up;
            }
            else if (pos == 17)
            {
                up17 = up;
            }
            else if (pos == 18)
            {
                up18 = up;
            }
            else if (pos == 19)
            {
                up19 = up;
            }
            else if (pos == 20)
            {
                up20 = up;
            }
            else if (pos == 21)
            {
                up21 = up;
            }
            else if (pos == 22)
            {
                up22 = up;
            }
            else if (pos == 23)
            {
                up23 = up;
            }
            else if (pos == 24)
            {
                up24 = up;
            }
            else if (pos == 25)
            {
                up25 = up;
            }
            else if (pos == 26)
            {
                up26 = up;
            }
            else if (pos == 27)
            {
                up27 = up;
            }
            else if (pos == 28)
            {
                up28 = up;
            }
            else if (pos == 29)
            {
                up29 = up;
            }
            else if (pos == 30)
            {
                up30 = up;
            }
            else if (pos == 31)
            {
                up31 = up;
            }
            else if (pos == 32)
            {
                up32 = up;
            }
            else if (pos == 33)
            {
                up33 = up;
            }
            else if (pos == 34)
            {
                up34 = up;
            }
            else if (pos == 35)
            {
                up35 = up;
            }
            else if (pos == 36)
            {
                up36 = up;
            }
            else if (pos == 37)
            {
                up37 = up;
            }
            else if (pos == 38)
            {
                up38 = up;
            }
            else if (pos == 39)
            {
                up39 = up;
            }
            else if (pos == 40)
            {
                up40 = up;
            }
            else if (pos == 41)
            {
                up41 = up;
            }
            else if (pos == 42)
            {
                up42 = up;
            }
            else if (pos == 43)
            {
                up43 = up;
            }
            else if (pos == 44)
            {
                up44 = up;
            }
            else if (pos == 45)
            {
                up45 = up;
            }
            else if (pos == 46)
            {
                up46 = up;
            }
            else if (pos == 47)
            {
                up47 = up;
            }
            else if (pos == 48)
            {
                up48 = up;
            }
            else if (pos == 49)
            {
                up49 = up;
            }
            else if (pos == 50)
            {
                up50 = up;
            }
            else if (pos == 51)
            {
                up51 = up;
            }
            else if (pos == 52)
            {
                up52 = up;
            }
            else if (pos == 53)
            {
                up53 = up;
            }
            else if (pos == 54)
            {
                up54 = up;
            }
            else if (pos == 55)
            {
                up55 = up;
            }
            else if (pos == 56)
            {
                up56 = up;
            }
            else if (pos == 57)
            {
                up57 = up;
            }
            else if (pos == 58)
            {
                up58 = up;
            }
            else if (pos == 59)
            {
                up59 = up;
            }
            else if (pos == 60)
            {
                up60 = up;
            }
            else if (pos == 61)
            {
                up61 = up;
            }
            else if (pos == 62)
            {
                up62 = up;
            }
            else if (pos == 63)
            {
                up63 = up;
            }
            else if (pos == 64)
            {
                up64 = up;
            }



            aup = ebene3;

            //ebene 3 position check
            if (pos == 0)
            {
                aup0 = aup;
            }
            else if (pos == 1)
            {
                aup1 = aup;
            }
            else if (pos == 2)
            {
                aup2 = aup;
            }
            else if (pos == 3)
            {
                aup3 = aup;
            }
            else if (pos == 4)
            {
                aup4 = aup;
            }
            else if (pos == 5)
            {
                aup5 = aup;
            }
            else if (pos == 6)
            {
                aup6 = aup;
            }
            else if (pos == 7)
            {
                aup7 = aup;
            }
            else if (pos == 8)
            {
                aup8 = aup;
            }
            else if (pos == 9)
            {
                aup9 = aup;
            }
            else if (pos == 10)
            {
                aup10 = aup;
            }
            else if (pos == 11)
            {
                aup11 = aup;
            }
            else if (pos == 12)
            {
                aup12 = aup;
            }
            else if (pos == 13)
            {
                aup13 = aup;
            }
            else if (pos == 14)
            {
                aup14 = aup;
            }
            else if (pos == 15)
            {
                aup15 = aup;
            }
            else if (pos == 16)
            {
                aup16 = aup;
            }
            else if (pos == 17)
            {
                aup17 = aup;
            }
            else if (pos == 18)
            {
                aup18 = aup;
            }
            else if (pos == 19)
            {
                aup19 = aup;
            }
            else if (pos == 20)
            {
                aup20 = aup;
            }
            else if (pos == 21)
            {
                aup21 = aup;
            }
            else if (pos == 22)
            {
                aup22 = aup;
            }
            else if (pos == 23)
            {
                aup23 = aup;
            }
            else if (pos == 24)
            {
                aup24 = aup;
            }
            else if (pos == 25)
            {
                aup25 = aup;
            }
            else if (pos == 26)
            {
                aup26 = aup;
            }
            else if (pos == 27)
            {
                aup27 = aup;
            }
            else if (pos == 28)
            {
                aup28 = aup;
            }
            else if (pos == 29)
            {
                aup29 = aup;
            }
            else if (pos == 30)
            {
                aup30 = aup;
            }
            else if (pos == 31)
            {
                aup31 = aup;
            }
            else if (pos == 32)
            {
                aup32 = aup;
            }
            else if (pos == 33)
            {
                aup33 = aup;
            }
            else if (pos == 34)
            {
                aup34 = aup;
            }
            else if (pos == 35)
            {
                aup35 = aup;
            }
            else if (pos == 36)
            {
                aup36 = aup;
            }
            else if (pos == 37)
            {
                aup37 = aup;
            }
            else if (pos == 38)
            {
                aup38 = aup;
            }
            else if (pos == 39)
            {
                aup39 = aup;
            }
            else if (pos == 40)
            {
                aup40 = aup;
            }
            else if (pos == 41)
            {
                aup41 = aup;
            }
            else if (pos == 42)
            {
                aup42 = aup;
            }
            else if (pos == 43)
            {
                aup43 = aup;
            }
            else if (pos == 44)
            {
                aup44 = aup;
            }
            else if (pos == 45)
            {
                aup45 = aup;
            }
            else if (pos == 46)
            {
                aup46 = aup;
            }
            else if (pos == 47)
            {
                aup47 = aup;
            }
            else if (pos == 48)
            {
                aup48 = aup;
            }
            else if (pos == 49)
            {
                aup49 = aup;
            }
            else if (pos == 50)
            {
                aup50 = aup;
            }
            else if (pos == 51)
            {
                aup51 = aup;
            }
            else if (pos == 52)
            {
                aup52 = aup;
            }
            else if (pos == 53)
            {
                aup53 = aup;
            }
            else if (pos == 54)
            {
                aup54 = aup;
            }
            else if (pos == 55)
            {
                aup55 = aup;
            }
            else if (pos == 56)
            {
                aup56 = aup;
            }
            else if (pos == 57)
            {
                aup57 = aup;
            }
            else if (pos == 58)
            {
                aup58 = aup;
            }
            else if (pos == 59)
            {
                aup59 = aup;
            }
            else if (pos == 60)
            {
                aup60 = aup;
            }

            //bot movement bot ki
            if (botalive == true)
            {
                //random moves


                //botmove left or right generation
                if (botmoveleft == false && botmoveright == false)
                {
                    if (i9 == bmlrrg)  //botmoveleftrightrandomgerator
                    {
                        if (bmlrrg < 30)
                        {
                            botmoveright = true;
                            i9 = 0;
                        }
                        else
                        {
                            botmoveleft = true;
                            i9 = 0;
                        }
                    }
                }


                //botmove right

                if (botmoveright == true)
                    botmoveleft = false;
                if (i8 < botmove)
                {
                    botpos++;
                }
                else
                {
                    botmoveright = false;
                }
            }

            //botmove right

            if (botmoveleft == true)
                {
                    botmoveright = false;
                    if (i8 < botmove)
                    {
                        botpos--;
                    }
                    else
                    {
                        botmoveleft = false;
                    }
                }
                if (botmoveleft == false && botmoveright == false)
                {
                    if (i8 == botmove)
                    {
                        botpos++;
                        i8 = 0;
                    }
                    if (botmove <= 4)
                    {
                        botpos++;
                        botmove = botmovement.Next(0, 10);
                    }
                    else if (botmove > 4)
                    {
                        botpos--;
                        botmove = botmovement.Next(0, 10);
                    }
                }
                 


                // GER: nich ausm bild weg dapfon fliegen nach linkz
                // ENG: border check left

                if (botpos < 1)
                {

                    while (botpos < 1)
                    {
                        botpos++;
                    }
                }

                // GER: nich ausm bild weg dapfon fliegen nach rechtz
                // ENG: border check right

                if (botpos > 54 || botleftpos > 0)
                {

                    while (botpos > 53)
                    {
                        botpos--;
                    }
                }

            




            bup = ebene4;

            //Ebenevier  bot


            if (botpos == 0)
            {
                bup0 = bup;
            }
            else if (botpos == 1)
            {
                bup1 = bup;
            }
            else if (botpos == 2)
            {
                bup2 = bup;
            }
            else if (botpos == 3)
            {
                bup3 = bup;
            }
            else if (botpos == 4)
            {
                bup4 = bup;
            }
            else if (botpos == 5)
            {
                bup5 = bup;
            }
            else if (botpos == 6)
            {
                bup6 = bup;
            }
            else if (botpos == 7)
            {
                bup7 = bup;
            }
            else if (botpos == 8)
            {
                bup8 = bup;
            }
            else if (botpos == 9)
            {
                bup9 = bup;
            }
            else if (botpos == 10)
            {
                bup10 = bup;
            }
            else if (botpos == 11)
            {
                bup11 = bup;
            }
            else if (botpos == 12)
            {
                bup12 = bup;
            }
            else if (botpos == 13)
            {
                bup13 = bup;
            }
            else if (botpos == 14)
            {
                bup14 = bup;
            }
            else if (botpos == 15)
            {
                bup15 = bup;
            }
            else if (botpos == 16)
            {
                bup16 = bup;
            }
            else if (botpos == 17)
            {
                bup17 = bup;
            }
            else if (botpos == 18)
            {
                bup18 = bup;
            }
            else if (botpos == 19)
            {
                bup19 = bup;
            }
            else if (botpos == 20)
            {
                bup20 = bup;
            }
            else if (botpos == 21)
            {
                bup21 = bup;
            }
            else if (botpos == 22)
            {
                bup22 = bup;
            }
            else if (botpos == 23)
            {
                bup23 = bup;
            }
            else if (botpos == 24)
            {
                bup24 = bup;
            }
            else if (botpos == 25)
            {
                bup25 = bup;
            }
            else if (botpos == 26)
            {
                bup26 = bup;
            }
            else if (botpos == 27)
            {
                bup27 = bup;
            }
            else if (botpos == 28)
            {
                bup28 = bup;
            }
            else if (botpos == 29)
            {
                bup29 = bup;
            }
            else if (botpos == 30)
            {
                bup30 = bup;
            }
            else if (botpos == 31)
            {
                bup31 = bup;
            }
            else if (botpos == 32)
            {
                bup32 = bup;
            }
            else if (botpos == 33)
            {
                bup33 = bup;
            }
            else if (botpos == 34)
            {
                bup34 = bup;
            }
            else if (botpos == 35)
            {
                bup35 = bup;
            }
            else if (botpos == 36)
            {
                bup36 = bup;
            }
            else if (botpos == 37)
            {
                bup37 = bup;
            }
            else if (botpos == 38)
            {
                bup38 = bup;
            }
            else if (botpos == 39)
            {
                bup39 = bup;
            }
            else if (botpos == 40)
            {
                bup40 = bup;
            }
            else if (botpos == 41)
            {
                bup41 = bup;
            }
            else if (botpos == 42)
            {
                bup42 = bup;
            }
            else if (botpos == 43)
            {
                bup43 = bup;
            }
            else if (botpos == 44)
            {
                bup44 = bup;
            }
            else if (botpos == 45)
            {
                bup45 = bup;
            }
            else if (botpos == 46)
            {
                bup46 = bup;
            }
            else if (botpos == 47)
            {
                bup47 = bup;
            }
            else if (botpos == 48)
            {
                bup48 = bup;
            }
            else if (botpos == 49)
            {
                bup49 = bup;
            }
            else if (botpos == 50)
            {
                bup50 = bup;
            }
            else if (botpos == 51)
            {
                bup51 = bup;
            }
            else if (botpos == 52)
            {
                bup52 = bup;
            }
            else if (botpos == 53)
            {
                bup53 = bup;
            }
            else if (botpos == 54)
            {
                bup54 = bup;
            }
            else if (botpos == 55)
            {
                bup55 = bup;
            }



            //bot left position

            botleftpos = botpos - 1;

            if (botalive == true)
            {
                bup = "<";
            }
            else if (botalive == false)
            {
                bup = " ";
            }


            if (botleftpos == 0)
            {
                bup0 = bup;
            }
            else if (botleftpos == 1)
            {
                bup1 = bup;
            }
            else if (botleftpos == 2)
            {
                bup2 = bup;
            }
            else if (botleftpos == 3)
            {
                bup3 = bup;
            }
            else if (botleftpos == 4)
            {
                bup4 = bup;
            }
            else if (botleftpos == 5)
            {
                bup5 = bup;
            }
            else if (botleftpos == 6)
            {
                bup6 = bup;
            }
            else if (botleftpos == 7)
            {
                bup7 = bup;
            }
            else if (botleftpos == 8)
            {
                bup8 = bup;
            }
            else if (botleftpos == 9)
            {
                bup9 = bup;
            }
            else if (botleftpos == 10)
            {
                bup10 = bup;
            }
            else if (botleftpos == 11)
            {
                bup11 = bup;
            }
            else if (botleftpos == 12)
            {
                bup12 = bup;
            }
            else if (botleftpos == 13)
            {
                bup13 = bup;
            }
            else if (botleftpos == 14)
            {
                bup14 = bup;
            }
            else if (botleftpos == 15)
            {
                bup15 = bup;
            }
            else if (botleftpos == 16)
            {
                bup16 = bup;
            }
            else if (botleftpos == 17)
            {
                bup17 = bup;
            }
            else if (botleftpos == 18)
            {
                bup18 = bup;
            }
            else if (botleftpos == 19)
            {
                bup19 = bup;
            }
            else if (botleftpos == 20)
            {
                bup20 = bup;
            }
            else if (botleftpos == 21)
            {
                bup21 = bup;
            }
            else if (botleftpos == 22)
            {
                bup22 = bup;
            }
            else if (botleftpos == 23)
            {
                bup23 = bup;
            }
            else if (botleftpos == 24)
            {
                bup24 = bup;
            }
            else if (botleftpos == 25)
            {
                bup25 = bup;
            }
            else if (botleftpos == 26)
            {
                bup26 = bup;
            }
            else if (botleftpos == 27)
            {
                bup27 = bup;
            }
            else if (botleftpos == 28)
            {
                bup28 = bup;
            }
            else if (botleftpos == 29)
            {
                bup29 = bup;
            }
            else if (botleftpos == 30)
            {
                bup30 = bup;
            }
            else if (botleftpos == 31)
            {
                bup31 = bup;
            }
            else if (botleftpos == 32)
            {
                bup32 = bup;
            }
            else if (botleftpos == 33)
            {
                bup33 = bup;
            }
            else if (botleftpos == 34)
            {
                bup34 = bup;
            }
            else if (botleftpos == 35)
            {
                bup35 = bup;
            }
            else if (botleftpos == 36)
            {
                bup36 = bup;
            }
            else if (botleftpos == 37)
            {
                bup37 = bup;
            }
            else if (botleftpos == 38)
            {
                bup38 = bup;
            }
            else if (botleftpos == 39)
            {
                bup39 = bup;
            }
            else if (botleftpos == 40)
            {
                bup40 = bup;
            }
            else if (botleftpos == 41)
            {
                bup41 = bup;
            }
            else if (botleftpos == 42)
            {
                bup42 = bup;
            }
            else if (botleftpos == 43)
            {
                bup43 = bup;
            }
            else if (botleftpos == 44)
            {
                bup44 = bup;
            }
            else if (botleftpos == 45)
            {
                bup45 = bup;
            }
            else if (botleftpos == 46)
            {
                bup46 = bup;
            }
            else if (botleftpos == 47)
            {
                bup47 = bup;
            }
            else if (botleftpos == 48)
            {
                bup48 = bup;
            }
            else if (botleftpos == 49)
            {
                bup49 = bup;
            }
            else if (botleftpos == 50)
            {
                bup50 = bup;
            }
            else if (botleftpos == 51)
            {
                bup51 = bup;
            }
            else if (botleftpos == 52)
            {
                bup52 = bup;
            }
            else if (botleftpos == 53)
            {
                bup53 = bup;
            }
            else if (botleftpos == 54)
            {
                bup54 = bup;
            }
            else if (botleftpos == 55)
            {
                bup55 = bup;
            }


            //bot right position

            botrightpos = botpos + 1;

            if (botalive == true)
            {
                bup = ">";
            }
            else if (botalive == false)
            {
                bup = " ";
            }


            if (botrightpos == 0)
            {
                bup0 = bup;
            }
            else if (botrightpos == 1)
            {
                bup1 = bup;
            }
            else if (botrightpos == 2)
            {
                bup2 = bup;
            }
            else if (botrightpos == 3)
            {
                bup3 = bup;
            }
            else if (botrightpos == 4)
            {
                bup4 = bup;
            }
            else if (botrightpos == 5)
            {
                bup5 = bup;
            }
            else if (botrightpos == 6)
            {
                bup6 = bup;
            }
            else if (botrightpos == 7)
            {
                bup7 = bup;
            }
            else if (botrightpos == 8)
            {
                bup8 = bup;
            }
            else if (botrightpos == 9)
            {
                bup9 = bup;
            }
            else if (botrightpos == 10)
            {
                bup10 = bup;
            }
            else if (botrightpos == 11)
            {
                bup11 = bup;
            }
            else if (botrightpos == 12)
            {
                bup12 = bup;
            }
            else if (botrightpos == 13)
            {
                bup13 = bup;
            }
            else if (botrightpos == 14)
            {
                bup14 = bup;
            }
            else if (botrightpos == 15)
            {
                bup15 = bup;
            }
            else if (botrightpos == 16)
            {
                bup16 = bup;
            }
            else if (botrightpos == 17)
            {
                bup17 = bup;
            }
            else if (botrightpos == 18)
            {
                bup18 = bup;
            }
            else if (botrightpos == 19)
            {
                bup19 = bup;
            }
            else if (botrightpos == 20)
            {
                bup20 = bup;
            }
            else if (botrightpos == 21)
            {
                bup21 = bup;
            }
            else if (botrightpos == 22)
            {
                bup22 = bup;
            }
            else if (botrightpos == 23)
            {
                bup23 = bup;
            }
            else if (botrightpos == 24)
            {
                bup24 = bup;
            }
            else if (botrightpos == 25)
            {
                bup25 = bup;
            }
            else if (botrightpos == 26)
            {
                bup26 = bup;
            }
            else if (botrightpos == 27)
            {
                bup27 = bup;
            }
            else if (botrightpos == 28)
            {
                bup28 = bup;
            }
            else if (botrightpos == 29)
            {
                bup29 = bup;
            }
            else if (botrightpos == 30)
            {
                bup30 = bup;
            }
            else if (botrightpos == 31)
            {
                bup31 = bup;
            }
            else if (botrightpos == 32)
            {
                bup32 = bup;
            }
            else if (botrightpos == 33)
            {
                bup33 = bup;
            }
            else if (botrightpos == 34)
            {
                bup34 = bup;
            }
            else if (botrightpos == 35)
            {
                bup35 = bup;
            }
            else if (botrightpos == 36)
            {
                bup36 = bup;
            }
            else if (botrightpos == 37)
            {
                bup37 = bup;
            }
            else if (botrightpos == 38)
            {
                bup38 = bup;
            }
            else if (botrightpos == 39)
            {
                bup39 = bup;
            }
            else if (botrightpos == 40)
            {
                bup40 = bup;
            }
            else if (botrightpos == 41)
            {
                bup41 = bup;
            }
            else if (botrightpos == 42)
            {
                bup42 = bup;
            }
            else if (botrightpos == 43)
            {
                bup43 = bup;
            }
            else if (botrightpos == 44)
            {
                bup44 = bup;
            }
            else if (botrightpos == 45)
            {
                bup45 = bup;
            }
            else if (botrightpos == 46)
            {
                bup46 = bup;
            }
            else if (botrightpos == 47)
            {
                bup47 = bup;
            }
            else if (botrightpos == 48)
            {
                bup48 = bup;
            }
            else if (botrightpos == 49)
            {
                bup49 = bup;
            }
            else if (botrightpos == 50)
            {
                bup50 = bup;
            }
            else if (botrightpos == 51)
            {
                bup51 = bup;
            }
            else if (botrightpos == 52)
            {
                bup52 = bup;
            }
            else if (botrightpos == 53)
            {
                bup53 = bup;
            }
            else if (botrightpos == 54)
            {
                bup54 = bup;
            }
            else if (botrightpos == 55)
            {
                bup55 = bup;
            }






            if (jump == true)
            {
                if (u < 1)
                {
                    ebene2 = uskin;
                    u++;
                    fly = true;
                }
                else 
                {
                    if (hat == false)
                    {
                        skin = uskin;
                        ebene2 = " ";
                        u = 0;
                        fly = false;
                    }
                    else if (hat == true)
                    {
                        skin = uskin;
                        ebene2 = usehat;
                        u = 0;
                        fly = false;
                    }
                }
            }


            //Gold Sammeln
            if (fly == false)
            {
                if (pos == rand)
                {
                    if (g == "$")
                    {
                        g = "_";

                        inputmsg = "+1 Gold.";

                        if (msg3 == "" && msg2 == "" && msg != "")
                        {
                            i13 = i;
                            i = 0;
                            msg2 = msg;
                            msg = inputmsg;
                        }
                        else if (msg3 == "" && msg2 != "" && msg != "")
                        {
                            i23 = i13;
                            i13 = i;
                            i = 0;
                            msg3 = msg2;
                            msg2 = msg;
                            msg = inputmsg;
                        }
                        else if (msg3 != "" && msg2 != "" && msg != "")
                        {
                            i23 = i13;
                            i13 = i;
                            i = 0;
                            msg3 = msg2;
                            msg2 = msg;
                            msg = inputmsg;
                        }
                        else
                        {
                            i = 0;
                            msg = inputmsg;
                        }

                        gold++;
                        i2 = 0;
                    }
                    else if (g == "_")
                    {

                    }
                }
            }


            //item4 sammeln

            if (fly == false)
            {
                if (pos == rand4)
                {
                    if (item4 == "*")
                    {
                        item4 = "_";
                    
                        inputmsg = "You found this epic Key!   +100 xp";


                        if (msg3 == "" && msg2 == "" && msg != "")
                        {
                            i13 = i;
                            i = 0;
                            msg2 = msg;
                            msg = inputmsg;
                        }
                        else if (msg3 == "" && msg2 != "" && msg != "")
                        {
                            i23 = i13;
                            i13 = i;
                            i = 0;
                            msg3 = msg2;
                            msg2 = msg;
                            msg = inputmsg;
                        }
                        else if (msg3 != "" && msg2 != "" && msg != "")
                        {
                            i23 = i13;
                            i13 = i;
                            i = 0;
                            msg3 = msg2;
                            msg2 = msg;
                            msg = inputmsg;
                        }
                        else
                        {
                            i = 0;
                            msg = inputmsg;
                        }

                        xp = xp + 100;
                        inv4 = "*";
                        item4anzahl++;
                        rand4 = rnd.Next(7, 35);
                    }
                }
            }

            //item3 sammeln

            if (fly == false)
            {
                if (pos == rand3)
                {
                    if (item3 == "°")
                    {
                        item3 = "_";
                
                        inputmsg = "You found this epic Healpotion: °        50+ xp";

                        if (msg3 == "" && msg2 == "" && msg != "")
                        {
                            i13 = i;
                            i = 0;
                            msg2 = msg;
                            msg = inputmsg;
                        }
                        else if (msg3 == "" && msg2 != "" && msg != "")
                        {
                            i23 = i13;
                            i13 = i;
                            i = 0;
                            msg3 = msg2;
                            msg2 = msg;
                            msg = inputmsg;
                        }
                        else if (msg3 != "" && msg2 != "" && msg != "")
                        {
                            i23 = i13;
                            i13 = i;
                            i = 0;
                            msg3 = msg2;
                            msg2 = msg;
                            msg = inputmsg;
                        }
                        else
                        {
                            i = 0;
                            msg = inputmsg;
                        }


                        xp = xp + 50;
                        inv3 = "°";
                        item3anzahl++;
                        rand3 = rnd.Next(5, 35);
                    }
                }
            }
            //item2 sammeln

            if (fly == false)
            {
                if (pos == rand2)
                {
                    if (item2 == "x")
                    {
                        item2 = "_";
                   

                        inputmsg = "YOU FOUND THIS EPIC HAT: x           1000+ xp";


                        if (msg3 == "" && msg2 == "" && msg != "")
                        {
                            i13 = i;
                            i = 0;
                            msg2 = msg;
                            msg = inputmsg;
                        }
                        else if (msg3 == "" && msg2 != "" && msg != "")
                        {
                            i23 = i13;
                            i13 = i;
                            i = 0;
                            msg3 = msg2;
                            msg2 = msg;
                            msg = inputmsg;
                        }
                        else if (msg3 != "" && msg2 != "" && msg != "")
                        {
                            i23 = i13;
                            i13 = i;
                            i = 0;
                            msg3 = msg2;
                            msg2 = msg;
                            msg = inputmsg;
                        }
                        else
                        {
                            i = 0;
                            msg = inputmsg;
                        }



                        xp = xp + 1000;
                        inv2 = "x";
                        item2anzahl++;
                    }
                }
            }

            //item sammeln
            if (fly == false)
            {
                if (pos == rand1)
                {
                    if (item == "+")
                    {
                        item = "_";
                  

                        inputmsg = "YOU FOUND THIS EPIC HAT: +           500+ xp";


                        if (msg3 == "" && msg2 == "" && msg != "")
                        {
                            i13 = i;
                            i = 0;
                            msg2 = msg;
                            msg = inputmsg;
                        }
                        else if (msg3 == "" && msg2 != "" && msg != "")
                        {
                            i23 = i13;
                            i13 = i;
                            i = 0;
                            msg3 = msg2;
                            msg2 = msg;
                            msg = inputmsg;
                        }
                        else if (msg3 != "" && msg2 != "" && msg != "")
                        {
                            i23 = i13;
                            i13 = i;
                            i = 0;
                            msg3 = msg2;
                            msg2 = msg;
                            msg = inputmsg;
                        }
                        else
                        {
                            i = 0;
                            msg = inputmsg;
                        }

                        xp = xp + 500;
                        inv1 = "+";
                        item1anzahl++;
                    }
                }
            }



            //item2 überlappungs abfrage  

        

            if (rand2 == rand || rand2 == rand1)
            {
                while (rand2 != rand && rand2 != rand1)
                {
                    if (rand2 == rand || rand2 == rand1)
                    {
                        rand2 = itempos2.Next(5, 35);
                    }
                }
            }

            //item 1 überlappungs abfrage    rand1 == item pos                    rand == gold     rand2 == item2

            if (rand1 == rand || rand1 == rand2)
            {
                while (rand1 != rand && rand1 != rand2)
                {
                    if (rand1 == rand || rand1 == rand2)
                    {
                        rand1 = itempos.Next(5, 35);
                    }
                }
            }

            //item2 abfrage



            //random item2 generation
            if (i4 > spawndelay2 && item2 == "_")
            {
                spawndelay2 = sdelay2.Next(1300, 100000);
                rand2 = itempos2.Next(5, 35);
                item2 = "x";
                i4 = 0;
            }

            pus = item2;

            //random item2
            if (rand2 == 0)
            {
                pos0 = pus;
            }
            else if (rand2 == 1)
            {
                pos1 = pus;
            }
            else if (rand2 == 2)
            {
                pos2 = pus;
            }
            else if (rand2 == 3)
            {
                pos3 = pus;
            }
            else if (rand2 == 4)
            {
                pos4 = pus;
            }
            else if (rand2 == 5)
            {
                pos5 = pus;
            }
            else if (rand2 == 6)
            {
                pos6 = pus;
            }
            else if (rand2 == 7)
            {
                pos7 = pus;
            }
            else if (rand2 == 8)
            {
                pos8 = pus;
            }
            else if (rand2 == 9)
            {
                pos9 = pus;
            }
            else if (rand2 == 10)
            {
                pos10 = pus;
            }
            else if (rand2 == 11)
            {
                pos11 = pus;
            }
            else if (rand2 == 12)
            {
                pos12 = pus;
            }
            else if (rand2 == 13)
            {
                pos13 = pus;
            }
            else if (rand2 == 14)
            {
                pos14 = pus;
            }
            else if (rand2 == 15)
            {
                pos15 = pus;
            }
            else if (rand2 == 16)
            {
                pos16 = pus;
            }
            else if (rand2 == 17)
            {
                pos17 = pus;
            }
            else if (rand2 == 18)
            {
                pos18 = pus;
            }
            else if (rand2 == 19)
            {
                pos19 = pus;
            }
            else if (rand2 == 20)
            {
                pos20 = pus;
            }
            else if (rand2 == 21)
            {
                pos21 = pus;
            }
            else if (rand2 == 22)
            {
                pos22 = pus;
            }
            else if (rand2 == 23)
            {
                pos23 = pus;
            }
            else if (rand2 == 24)
            {
                pos24 = pus;
            }
            else if (rand2 == 25)
            {
                pos25 = pus;
            }
            else if (rand2 == 26)
            {
                pos26 = pus;
            }
            else if (rand2 == 27)
            {
                pos27 = pus;
            }
            else if (rand2 == 28)
            {
                pos28 = pus;
            }
            else if (rand2 == 29)
            {
                pos29 = pus;
            }
            else if (rand2 == 30)
            {
                pos30 = pus;
            }
            else if (rand2 == 31)
            {
                pos31 = pus;
            }
            else if (rand2 == 32)
            {
                pos32 = pus;
            }
            else if (rand2 == 33)
            {
                pos33 = pus;
            }
            else if (rand2 == 34)
            {
                pos34 = pus;
            }
            else if (rand2 == 35)
            {
                pos35 = pus;
            }
            else if (rand2 == 36)
            {
                pos36 = pus;
            }
            else if (rand2 == 37)
            {
                pos37 = pus;
            }
            else if (rand2 == 38)
            {
                pos38 = pus;
            }
            else if (rand2 == 39)
            {
                pos39 = pus;
            }
            else if (rand2 == 40)
            {
                pos40 = pus;
            }


            //random item4 generation
            if (i16 > spawndelay4 && item4 == "_")
            {
                spawndelay4 = rnd.Next(10, 500000);
                rand4 = rnd.Next(7, 35);
                item4 = "*";
                i16 = 0;
            }

            pus = item4;

            //random item4
            if (rand4 == 0)
            {
                pos0 = pus;
            }
            else if (rand4 == 1)
            {
                pos1 = pus;
            }
            else if (rand4 == 2)
            {
                pos2 = pus;
            }
            else if (rand4 == 3)
            {
                pos3 = pus;
            }
            else if (rand4 == 4)
            {
                pos4 = pus;
            }
            else if (rand4 == 5)
            {
                pos5 = pus;
            }
            else if (rand4 == 6)
            {
                pos6 = pus;
            }
            else if (rand4 == 7)
            {
                pos7 = pus;
            }
            else if (rand4 == 8)
            {
                pos8 = pus;
            }
            else if (rand4 == 9)
            {
                pos9 = pus;
            }
            else if (rand4 == 10)
            {
                pos10 = pus;
            }
            else if (rand4 == 11)
            {
                pos11 = pus;
            }
            else if (rand4 == 12)
            {
                pos12 = pus;
            }
            else if (rand4 == 13)
            {
                pos13 = pus;
            }
            else if (rand4 == 14)
            {
                pos14 = pus;
            }
            else if (rand4 == 15)
            {
                pos15 = pus;
            }
            else if (rand4 == 16)
            {
                pos16 = pus;
            }
            else if (rand4 == 17)
            {
                pos17 = pus;
            }
            else if (rand4 == 18)
            {
                pos18 = pus;
            }
            else if (rand4 == 19)
            {
                pos19 = pus;
            }
            else if (rand4 == 20)
            {
                pos20 = pus;
            }
            else if (rand4 == 21)
            {
                pos21 = pus;
            }
            else if (rand4 == 22)
            {
                pos22 = pus;
            }
            else if (rand4 == 23)
            {
                pos23 = pus;
            }
            else if (rand4 == 24)
            {
                pos24 = pus;
            }
            else if (rand4 == 25)
            {
                pos25 = pus;
            }
            else if (rand4 == 26)
            {
                pos26 = pus;
            }
            else if (rand4 == 27)
            {
                pos27 = pus;
            }
            else if (rand4 == 28)
            {
                pos28 = pus;
            }
            else if (rand4 == 29)
            {
                pos29 = pus;
            }
            else if (rand4 == 30)
            {
                pos30 = pus;
            }
            else if (rand4 == 31)
            {
                pos31 = pus;
            }
            else if (rand4 == 32)
            {
                pos32 = pus;
            }
            else if (rand4 == 33)
            {
                pos33 = pus;
            }
            else if (rand4 == 34)
            {
                pos34 = pus;
            }
            else if (rand4 == 35)
            {
                pos35 = pus;
            }
            else if (rand4 == 36)
            {
                pos36 = pus;
            }
            else if (rand4 == 37)
            {
                pos37 = pus;
            }
            else if (rand4 == 38)
            {
                pos38 = pus;
            }
            else if (rand4 == 39)
            {
                pos39 = pus;
            }
            else if (rand4 == 40)
            {
                pos40 = pus;
            }



            //random item3 generation
            if (i14 > spawndelay3 && item3 == "_")
            {
                spawndelay3 = rnd.Next(250, 2000);
                rand2 = itempos2.Next(5, 35);
                item3 = "°";
                i14 = 0;
            }

            pus = item3;

            //random item3
            if (rand3 == 0)
            {
                pos0 = pus;
            }
            else if (rand3 == 1)
            {
                pos1 = pus;
            }
            else if (rand3 == 2)
            {
                pos2 = pus;
            }
            else if (rand3 == 3)
            {
                pos3 = pus;
            }
            else if (rand3 == 4)
            {
                pos4 = pus;
            }
            else if (rand3 == 5)
            {
                pos5 = pus;
            }
            else if (rand3 == 6)
            {
                pos6 = pus;
            }
            else if (rand3 == 7)
            {
                pos7 = pus;
            }
            else if (rand3 == 8)
            {
                pos8 = pus;
            }
            else if (rand3 == 9)
            {
                pos9 = pus;
            }
            else if (rand3 == 10)
            {
                pos10 = pus;
            }
            else if (rand3 == 11)
            {
                pos11 = pus;
            }
            else if (rand3 == 12)
            {
                pos12 = pus;
            }
            else if (rand3 == 13)
            {
                pos13 = pus;
            }
            else if (rand3 == 14)
            {
                pos14 = pus;
            }
            else if (rand3 == 15)
            {
                pos15 = pus;
            }
            else if (rand3 == 16)
            {
                pos16 = pus;
            }
            else if (rand3 == 17)
            {
                pos17 = pus;
            }
            else if (rand3 == 18)
            {
                pos18 = pus;
            }
            else if (rand3 == 19)
            {
                pos19 = pus;
            }
            else if (rand3 == 20)
            {
                pos20 = pus;
            }
            else if (rand3 == 21)
            {
                pos21 = pus;
            }
            else if (rand3 == 22)
            {
                pos22 = pus;
            }
            else if (rand3 == 23)
            {
                pos23 = pus;
            }
            else if (rand3 == 24)
            {
                pos24 = pus;
            }
            else if (rand3 == 25)
            {
                pos25 = pus;
            }
            else if (rand3 == 26)
            {
                pos26 = pus;
            }
            else if (rand3 == 27)
            {
                pos27 = pus;
            }
            else if (rand3 == 28)
            {
                pos28 = pus;
            }
            else if (rand3 == 29)
            {
                pos29 = pus;
            }
            else if (rand3 == 30)
            {
                pos30 = pus;
            }
            else if (rand3 == 31)
            {
                pos31 = pus;
            }
            else if (rand3 == 32)
            {
                pos32 = pus;
            }
            else if (rand3 == 33)
            {
                pos33 = pus;
            }
            else if (rand3 == 34)
            {
                pos34 = pus;
            }
            else if (rand3 == 35)
            {
                pos35 = pus;
            }
            else if (rand3 == 36)
            {
                pos36 = pus;
            }
            else if (rand3 == 37)
            {
                pos37 = pus;
            }
            else if (rand3 == 38)
            {
                pos38 = pus;
            }
            else if (rand3 == 39)
            {
                pos39 = pus;
            }
            else if (rand3 == 40)
            {
                pos40 = pus;
            }


            pus = uskin;

            //fly stuff
            if (fly == true && hat == true)
            {
                if (usehat == "+")
                {
                    ebene3 = usehat;
                    ebene2 = uskin;
                }
               
            }
            else if (fly == false)
            {
                ebene3 = " ";
            }
            //rain skin abfrage 
            if (fly == true)
            {
                ebene2 = uskin;
            }
            //über zeug fliegen ueber sachen fliegen

            if (fly == true)
            {
                if (pos == rand && g == "$")
                {
                    ebene1 = "$";
                }
                else if (pos == rand1 && item == "+")
                {
                    ebene1 = "+";
                }
                else if (pos == rand2 && item2 == "x")
                {
                    ebene1 = "x";
                }
                else if (pos == rand3 && item3 == "°")
                {
                    ebene1 = "°";
                }
                else if (pos == rand4 && item4 == "*")
                {
                    ebene1 = "*";
                }
                else
                {
                    ebene1 = "_";
                }
                pus = ebene1;
            }

            //skin abfrage
            if (pos == 0)
            {
                pos0 = pus;
            }
            else if (pos == 1)
            {
                pos1 = pus;
            }
            else if (pos == 2)
            {
                pos2 = pus;
            }
            else if (pos == 3)
            {
                pos3 = pus;
            }
            else if (pos == 4)
            {
                pos4 = pus;
            }
            else if (pos == 5)
            {
                pos5 = pus;
            }
            else if (pos == 6)
            {
                pos6 = pus;
            }
            else if (pos == 7)
            {
                pos7 = pus;
            }
            else if (pos == 8)
            {
                pos8 = pus;
            }
            else if (pos == 9)
            {
                pos9 = pus;
            }
            else if (pos == 10)
            {
                pos10 = pus;
            }
            else if (pos == 11)
            {
                pos11 = pus;
            }
            else if (pos == 12)
            {
                pos12 = pus;
            }
            else if (pos == 13)
            {
                pos13 = pus;
            }
            else if (pos == 14)
            {
                pos14 = pus;
            }
            else if (pos == 15)
            {
                pos15 = pus;
            }
            else if (pos == 16)
            {
                pos16 = pus;
            }
            else if (pos == 17)
            {
                pos17 = pus;
            }
            else if (pos == 18)
            {
                pos18 = pus;
            }
            else if (pos == 19)
            {
                pos19 = pus;
            }
            else if (pos == 20)
            {
                pos20 = pus;
            }
            else if (pos == 21)
            {
                pos21 = pus;
            }
            else if (pos == 22)
            {
                pos22 = pus;
            }
            else if (pos == 23)
            {
                pos23 = pus;
            }
            else if (pos == 24)
            {
                pos24 = pus;
            }
            else if (pos == 25)
            {
                pos25 = pus;
            }
            else if (pos == 26)
            {
                pos26 = pus;
            }
            else if (pos == 27)
            {
                pos27 = pus;
            }
            else if (pos == 28)
            {
                pos28 = pus;
            }
            else if (pos == 29)
            {
                pos29 = pus;
            }
            else if (pos == 30)
            {
                pos30 = pus;
            }
            else if (pos == 31)
            {
                pos31 = pus;
            }
            else if (pos == 32)
            {
                pos32 = pus;
            }
            else if (pos == 33)
            {
                pos33 = pus;
            }
            else if (pos == 34)
            {
                pos34 = pus;
            }
            else if (pos == 35)
            {
                pos35 = pus;
            }
            else if (pos == 36)
            {
                pos36 = pus;
            }
            else if (pos == 37)
            {
                pos37 = pus;
            }
            else if (pos == 38)
            {
                pos38 = pus;
            }
            else if (pos == 39)
            {
                pos39 = pus;
            }
            else if (pos == 40)
            {
                pos40 = pus;
            }
            else if (pos == 41)
            {
                if (fly == false)
                {
                    die = true;
                }
            }
            else if (pos == 42)
            {
                if (fly == false)
                {
                    die = true;
                }
            }
            else if (pos == 43)
            {
                if (fly == false)
                {
                    die = true;
                }
            }
            else if (pos == 44)
            {
                if (fly == false)
                {
                    die = true;
                }
            }
            else if (pos == 45)
            {
                if (fly == false)
                {
                    die = true;
                }
            }
            else if (pos == 46)
            {
                if (fly == false)
                {
                    die = true;
                }
            }
            else if (pos == 47)
            {
                if (fly == false)
                {
                    die = true;
                }
            }
            else if (pos == 48)
            {
                if (fly == false)
                {
                    die = true;
                }
            }
            else if (pos == 49)
            {
                if (fly == false)
                {
                    die = true;
                }
            }
            else if (pos == 50)
            {
                pos50 = pus;
            }

            //weeeeeeeeeeeeeeeeed <3

            pus = "|";

            if (pos == 51)
            {
                pos51 = pus;
            }
            else if (pos == 52)
            {
                pos52 = pus;
            }
            else if (pos == 53)
            {
                pos53 = pus;
            }
            else if (pos == 54)
            {
                pos54 = pus;
            }
            else if (pos == 55)
            {
                pos55 = pus;
            }
            else if (pos == 56)
            {
                pos56 = pus;
            }
            else if (pos == 57)
            {
                pos57 = pus;
            }
            else if (pos == 58)
            {
                pos58 = pus;
            }
            else if (pos == 59)
            {
                pos59 = pus;
            }
            else if (pos == 60)
            {
                pos60 = pus;
            }




            pus = uskin;
            //fly stuff 2
            if (fly == true && hat == true)
            {
                if (usehat == "+")
                {
                    ebene3 = usehat;
                    ebene2 = uskin;
                }

            }
            else if (fly == false)
            {
                ebene3 = " ";
            }
            //rain skin abfrage
            if (fly == true)
            {
                ebene2 = uskin;
            }
            //über zeug fliegen

            if (fly == true)
            {
                if (pos == rand && g == "$")
                {
                    ebene1 = "$";
                }
                else if (pos == rand1 && item == "+")
                {
                    ebene1 = "+";
                }
                else if (pos == rand2 && item2 == "x")
                {
                    ebene1 = "x";
                }
                else if (pos == rand3 && item3 == "°")
                {
                    ebene1 = "°";
                }
                else
                {
                    ebene1 = "_";
                }
                pus = ebene1;
            }
            // kein WWWWWWWWWWWWWWWEEEEEEEEEEEEEEEEEEEEEEED o.O

            if (pos == 61)
            {
                pos61 = pus;
            }
            else if (pos == 62)
            {
                pos62 = pus;
            }
            else if (pos == 63)
            {
                pos63 = pus;
            }
            else if (pos == 64)
            {
                pos64 = pus;
            }
            else if (pos == 65)
            {
                pos65 = pus;
            }
            else if (pos == 66)
            {
                pos66 = pus;
            }
            else if (pos == 67)
            {
                pos67 = pus;
            }
            else if (pos == 68)
            {
                pos68 = pus;
            }
            else if (pos == 69)
            {
                pos69 = pus;
            }
            else if (pos == 70)
            {
                pos70 = pus;
            }
            else if (pos == 71)
            {
                pos71 = pus;
            }
            else if (pos == 72)
            {
                pos72 = pus;
            }
            else if (pos == 73)
            {
                pos73 = pus;
            }
            else if (pos == 74)
            {
                pos74 = pus;
            }
            else if (pos == 75)
            {
                pos75 = pus;
            }
            else if (pos == 76)
            {
                pos76 = pus;
            }



                if (item3anzahl <= 0)
            {
                inv3 = " ";
            }





            /*





            left = pos--;

            if (left == 0)
            {
                pus = pos0;
            }
            else if (left == 1)
            {
                pus = pos1;
            }
            else if (left == 2)
            {
                pus = pos2;
            }
            else if (left == 3)
            {
                pus = pos3;
            }
            else if (left == 4)
            {
                pus = pos4;
            }
            else if (left == 5)
            {
                pus = pos5;
            }
            else if (left == 6)
            {
                pus = pos6;
            }
            else if (left == 7)
            {
                pus = pos7;
            }
            else if (left == 8)
            {
                pus = pos8;
            }
            else if (left == 9)
            {
                pus = pos9;
            }
            else if (left == 10)
            {
                pus = pos10;
            }
            else if (left == 11)
            {
                pus = pos11;
            }
            else if (left == 12)
            {
                pus = pos12;
            }
            else if (left == 13)
            {
                pus = pos13;
            }
            else if (left == 14)
            {
                pus = pos14;
            }
            else if (left == 15)
            {
                pus = pos15;
            }
            else if (left == 16)
            {
                pus = pos16;
            }
            else if (left == 17)
            {
                pus = pos17;
            }
            else if (left == 18)
            {
                pus = pos18;
            }
            else if (left == 19)
            {
                pus = pos19;
            }
            else if (left == 20)
            {
                pus = pos20;
            }
            else if (left == 21)
            {
                pus = pos21;
            }
            else if (left == 22)
            {
                pus = pos22;
            }
            else if (left == 23)
            {
                pus = pos23;
            }
            else if (left == 24)
            {
                pus = pos24;
            }
            else if (left == 25)
            {
                pus = pos25;
            }
            else if (left == 26)
            {
                pus = pos26;
            }
            else if (left == 27)
            {
                pus = pos27;
            }
            else if (left == 28)
            {
                pus = pos28;
            }
            else if (left == 29)
            {
                pus = pos29;
            }
            else if (left == 30)
            {
                pus = pos30;
            }
            else if (left == 31)
            {
                pus = pos31;
            }
            else if (left == 32)
            {
                pus = pos32;
            }
            else if (left == 33)
            {
                pus = pos33;
            }
            else if (left == 34)
            {
                pus = pos34;
            }
            else if (left == 35)
            {
                pus = pos35;
            }
            else if (left == 36)
            {
                pus = pos36;
            }
            else if (left == 37)
            {
                pus = pos37;
            }
            else if (left == 38)
            {
                pus = pos38;
            }
            else if (left == 39)
            {
                pus = pos39;
            }
            else if (left == 40)
            {
                pus = pos40;
            }
  







            
            //testin new shit yu
            if (pus == "#")
            {
                leftwall = true;
            }
            else if (pus != "#")
            {
                leftwall = false;
            }
            */


            //msg abfrage und msg2 abfrage und msg3 abfrage
            //                         i13 = i;

            if (i < 100)
            {
            }
            else
            {
                msg = "";
                i = 0;
            }

            if (i13 < 100)
            {
            }
            else
            {
                msg2 = "";
                i13 = 0;
            }


            if (i23 < 100)
            {

            }
            else
            {
                msg3 = "";
                i23 = 0;
            }

            /* komisches zeug was keiner versteht xD

            if (msg2 != "" && msg == "")
            {
                msg = msg2;
                msg2 = "";
            }
            else if (msg3 != "" && msg2 == "" && msg == "")
            {
                msg = msg3;
                msg3 = "";
            }
            else if (msg3 != "" && msg2 == "" && msg != "")
            {
                msg2 = msg3;
                msg3 = "";
            }
            else if (msg3 != "" && msg2 != "" && msg == "")
            {
                msg = msg2;
                msg2 = msg3;
                msg3 = "";
            }

            */













            if (isshop == false && isinventory == false)
            {
                if (botalive == false)
                {
                    if (ismsg == false)
                    {
                        if (info == true)
                        {
                            Console.Clear();
                            Console.WriteLine("Player: {0}  Hat: {1}             Tick: {2}        Admin = {3}   fps: {4}", uskin, usehat, i15, admin, fps);
                            Console.WriteLine("Bot: {0}  msg: {1} msg2: {2} msg3: {3}", botm, i, i13, i23);
                            Console.WriteLine("item1 = +  item4 = *                           pos: {0} pos: {1}", rand1, rand4);
                            Console.WriteLine("item2 = x                                      pos: {0}", rand2);
                            Console.WriteLine("item3 = °                                      pos: {0}", rand3);
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}{40}{41}{42}{43}{44}{45}{46}{47}{48}{49}{50}{51}{52}{53}{54}{55}", bup0, bup1, bup2, bup3, bup4, bup5, bup6, bup7, bup8, bup9, bup10, bup11, bup12, bup13, bup14, bup15, bup16, bup17, bup18, bup19, bup20, bup21, bup22, bup23, bup24, bup25, bup26, bup27, bup28, bup29, bup30, bup31, bup32, bup33, bup34, bup35, bup36, bup37, bup38, bup39, bup40, bup41, bup42, bup43, bup44, bup45, bup46, bup47, bup48, bup49, bup50, bup51, bup52, bup53, bup54, bup55);
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}{40}{41}{42}{43}{44}{45}{46}{47}{48}{49}{50}{51}{52}{53}{54}{55}{56}{57}{58}{59}{60}    +-----+-----+", aup0, aup1, aup2, aup3, aup4, aup5, aup6, aup7, aup8, aup9, aup10, aup11, aup12, aup13, aup14, aup15, aup16, aup17, aup18, aup19, aup20, aup21, aup22, aup23, aup24, aup25, aup26, aup27, aup28, aup29, aup30, aup31, aup32, aup33, aup34, aup35, aup36, aup37, aup38, aup39, aup40, aup41, aup42, aup43, aup44, aup45, aup46, aup47, aup48, aup49, aup50, aup51, aup52, aup53, aup54, aup55, aup56, aup57, aup58, aup59, aup60);
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}{40}{41}{42}{43}{44}{45}{46}{47}{48}{49}{50}{51}{52}{53}{54}{55}{56}{57}{58}{59}{60}{61}{62}{63}{64}|  Q  |  W2 |", up0, up1, up2, up3, up4, up5, up6, up7, up8, up9, up10, up11, up12, up13, up14, up15, up16, up17, up18, up19, up20, up21, up22, up23, up24, up25, up26, up27, up28, up29, up30, up31, up32, up33, up34, up35, up36, up37, up38, up39, up40, up41, up42, up43, up44, up45, up46, up47, up48, up49, up50, up51, up52, up53, up54, up55, up56, up57, up58, up59, up60, up61, up62, up63, up64);
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}{40}         {41}{42}{43}{44}{45}{46}{47}{48}{49}{50}{51}{52}{53}{54}{55}{56}{57}{58}{59}{60}{61}{62}{63}{64}{65}{66}{67}|", pos0, pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9, pos10, pos11, pos12, pos13, pos14, pos15, pos16, pos17, pos18, pos19, pos20, pos21, pos22, pos23, pos24, pos25, pos26, pos27, pos28, pos29, pos30, pos31, pos32, pos33, pos34, pos35, pos36, pos37, pos38, pos39, pos40, pos50, pos51, pos52, pos53, pos54, pos55, pos56, pos57, pos58, pos59, pos60, pos61, pos62, pos63, pos64, pos65, pos66, pos67, pos68, pos69, pos70, pos71, pos72, pos73, pos74, pos75, pos76);
                            Console.WriteLine("i1:{0} i2:{1} i3:{2} i4:{3} b:{4} g:{5}", i3, i4, i14, i16, i10, i2);
                            Console.WriteLine("item1:{0} item2:{1} item3:{2}  item4:{3} bot:{4} gold:{5}", spawndelay, spawndelay2, spawndelay3, spawndelay4, randombotspawndelay, gres);
                            Console.WriteLine("********************************************************************************");
                            Console.WriteLine("  HP: {0} xp: {1}/{2} lvl: {3} g: {4} c: {5}  |  hpdiff: {6}  xpdiff: {7}", hp, xp, neededxp, lvl, gold, cookies, hpdiff, xpdiff);
                            Console.WriteLine("********************************************************************************");
                            Console.WriteLine("{0}", msg);
                            Console.WriteLine("{0}", msg2);
                            Console.WriteLine("{0}", msg3);
                            Console.WriteLine("x: {0}                                        grass: {1}", pos, grass);
                            Console.WriteLine("bot x: {0}                                    fly: {1}", botpos, fly);
                        }
                        if (info == false)
                        {
                            Console.Clear();
                            Console.WriteLine("      ");
                            Console.WriteLine("      ");
                            Console.WriteLine("      ");
                            Console.WriteLine("      ");
                            Console.WriteLine("      ");
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}{40}{41}{42}{43}{44}{45}{46}{47}{48}{49}{50}{51}{52}{53}{54}{55}", bup0, bup1, bup2, bup3, bup4, bup5, bup6, bup7, bup8, bup9, bup10, bup11, bup12, bup13, bup14, bup15, bup16, bup17, bup18, bup19, bup20, bup21, bup22, bup23, bup24, bup25, bup26, bup27, bup28, bup29, bup30, bup31, bup32, bup33, bup34, bup35, bup36, bup37, bup38, bup39, bup40, bup41, bup42, bup43, bup44, bup45, bup46, bup47, bup48, bup49, bup50, bup51, bup52, bup53, bup54, bup55);
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}{40}{41}{42}{43}{44}{45}{46}{47}{48}{49}{50}{51}{52}{53}{54}{55}{56}{57}{58}{59}{60}    +-----+-----+", aup0, aup1, aup2, aup3, aup4, aup5, aup6, aup7, aup8, aup9, aup10, aup11, aup12, aup13, aup14, aup15, aup16, aup17, aup18, aup19, aup20, aup21, aup22, aup23, aup24, aup25, aup26, aup27, aup28, aup29, aup30, aup31, aup32, aup33, aup34, aup35, aup36, aup37, aup38, aup39, aup40, aup41, aup42, aup43, aup44, aup45, aup46, aup47, aup48, aup49, aup50, aup51, aup52, aup53, aup54, aup55, aup56, aup57, aup58, aup59, aup60);
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}{40}{41}{42}{43}{44}{45}{46}{47}{48}{49}{50}{51}{52}{53}{54}{55}{56}{57}{58}{59}{60}{61}{62}{63}{64}|  Q  |  W2 |", up0, up1, up2, up3, up4, up5, up6, up7, up8, up9, up10, up11, up12, up13, up14, up15, up16, up17, up18, up19, up20, up21, up22, up23, up24, up25, up26, up27, up28, up29, up30, up31, up32, up33, up34, up35, up36, up37, up38, up39, up40, up41, up42, up43, up44, up45, up46, up47, up48, up49, up50, up51, up52, up53, up54, up55, up56, up57, up58, up59, up60, up61, up62, up63, up64);
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}{40}         {41}{42}{43}{44}{45}{46}{47}{48}{49}{50}{51}{52}{53}{54}{55}{56}{57}{58}{59}{60}{61}{62}{63}{64}{65}{66}{67}|", pos0, pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9, pos10, pos11, pos12, pos13, pos14, pos15, pos16, pos17, pos18, pos19, pos20, pos21, pos22, pos23, pos24, pos25, pos26, pos27, pos28, pos29, pos30, pos31, pos32, pos33, pos34, pos35, pos36, pos37, pos38, pos39, pos40, pos50, pos51, pos52, pos53, pos54, pos55, pos56, pos57, pos58, pos59, pos60, pos61, pos62, pos63, pos64, pos65, pos66, pos67, pos68, pos69, pos70, pos71, pos72, pos73, pos74, pos75, pos76);
                            Console.WriteLine("                                        |         |");
                            Console.WriteLine("                                         ^^^^^^^^^");
                            Console.WriteLine("********************************************************************************");
                            Console.WriteLine("  HP: {0} xp: {1}/{2} lvl: {3} gold: {4} cookies: {5}", hp, xp, neededxp, lvl, gold, cookies);
                            Console.WriteLine("********************************************************************************");
                            Console.WriteLine("{0}", msg);
                            Console.WriteLine("{0}", msg2);
                            Console.WriteLine("{0}", msg3);
                        }
                    }
                    else if (ismsg == true)
                    {
                        if (info == true)
                        {
                            Console.WriteLine("Player: {0}  Hat: {1}             Tick: {2}        Admin = {3}   fps: {4}", uskin, usehat, i15, admin, fps);
                            Console.WriteLine("Bot: {0}  msg: {1} msg2: {2} msg3: {3}", botm, i, i13, i23);
                            Console.WriteLine("item1 = +  item4 = *                           pos: {0} pos: {1}", rand1, rand4);
                            Console.WriteLine("item2 = x                                      pos: {0}", rand2);
                            Console.WriteLine("item3 = °                                      pos: {0}", rand3);
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}{40}{41}{42}{43}{44}{45}{46}{47}{48}{49}{50}{51}{52}{53}{54}{55}", bup0, bup1, bup2, bup3, bup4, bup5, bup6, bup7, bup8, bup9, bup10, bup11, bup12, bup13, bup14, bup15, bup16, bup17, bup18, bup19, bup20, bup21, bup22, bup23, bup24, bup25, bup26, bup27, bup28, bup29, bup30, bup31, bup32, bup33, bup34, bup35, bup36, bup37, bup38, bup39, bup40, bup41, bup42, bup43, bup44, bup45, bup46, bup47, bup48, bup49, bup50, bup51, bup52, bup53, bup54, bup55);
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}{40}{41}{42}{43}{44}{45}{46}{47}{48}{49}{50}{51}{52}{53}{54}{55}{56}{57}{58}{59}{60}    +-----+-----+", aup0, aup1, aup2, aup3, aup4, aup5, aup6, aup7, aup8, aup9, aup10, aup11, aup12, aup13, aup14, aup15, aup16, aup17, aup18, aup19, aup20, aup21, aup22, aup23, aup24, aup25, aup26, aup27, aup28, aup29, aup30, aup31, aup32, aup33, aup34, aup35, aup36, aup37, aup38, aup39, aup40, aup41, aup42, aup43, aup44, aup45, aup46, aup47, aup48, aup49, aup50, aup51, aup52, aup53, aup54, aup55, aup56, aup57, aup58, aup59, aup60);
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}{40}{41}{42}{43}{44}{45}{46}{47}{48}{49}{50}{51}{52}{53}{54}{55}{56}{57}{58}{59}{60}{61}{62}{63}{64}|  Q  |  W2 |", up0, up1, up2, up3, up4, up5, up6, up7, up8, up9, up10, up11, up12, up13, up14, up15, up16, up17, up18, up19, up20, up21, up22, up23, up24, up25, up26, up27, up28, up29, up30, up31, up32, up33, up34, up35, up36, up37, up38, up39, up40, up41, up42, up43, up44, up45, up46, up47, up48, up49, up50, up51, up52, up53, up54, up55, up56, up57, up58, up59, up60, up61, up62, up63, up64);
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}{40}         {41}{42}{43}{44}{45}{46}{47}{48}{49}{50}{51}{52}{53}{54}{55}{56}{57}{58}{59}{60}{61}{62}{63}{64}{65}{66}{67}|", pos0, pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9, pos10, pos11, pos12, pos13, pos14, pos15, pos16, pos17, pos18, pos19, pos20, pos21, pos22, pos23, pos24, pos25, pos26, pos27, pos28, pos29, pos30, pos31, pos32, pos33, pos34, pos35, pos36, pos37, pos38, pos39, pos40, pos50, pos51, pos52, pos53, pos54, pos55, pos56, pos57, pos58, pos59, pos60, pos61, pos62, pos63, pos64, pos65, pos66, pos67, pos68, pos69, pos70, pos71, pos72, pos73, pos74, pos75, pos76);
                            Console.WriteLine("i1:{0} i2:{1} i3:{2} i4:{3} b:{4} g:{5}", i3, i4, i14, i16, i10, i2);
                            Console.WriteLine("item1:{0} item2:{1} item3:{2}  item4:{3} bot:{4} gold:{5}", spawndelay, spawndelay2, spawndelay3, spawndelay4, randombotspawndelay, gres);
                            Console.WriteLine("********************************************************************************");
                            Console.WriteLine("  HP: {0} xp: {1}/{2} lvl: {3} g: {4} c: {5}  |  hpdiff: {6}  xpdiff: {7}", hp, xp, neededxp, lvl, gold, cookies, hpdiff, xpdiff);
                            Console.WriteLine("********************************************************************************");
                            Console.WriteLine("{0}", msg);
                            Console.WriteLine("{0}", msg2);
                            Console.WriteLine("{0}", msg3);
                            Console.WriteLine("x: {0}                                        grass: {1}", pos, grass);
                            Console.WriteLine("bot x: {0}                                    fly: {1}", botpos, fly);
                        }
                        else if (info == false)
                        { 
                            //test line 
                            Console.WriteLine("      ");
                            Console.WriteLine("      ");
                            Console.WriteLine("      ");
                            Console.WriteLine("      ");
                            Console.WriteLine("      ");
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}{40}{41}{42}{43}{44}{45}{46}{47}{48}{49}{50}{51}{52}{53}{54}{55}", bup0, bup1, bup2, bup3, bup4, bup5, bup6, bup7, bup8, bup9, bup10, bup11, bup12, bup13, bup14, bup15, bup16, bup17, bup18, bup19, bup20, bup21, bup22, bup23, bup24, bup25, bup26, bup27, bup28, bup29, bup30, bup31, bup32, bup33, bup34, bup35, bup36, bup37, bup38, bup39, bup40, bup41, bup42, bup43, bup44, bup45, bup46, bup47, bup48, bup49, bup50, bup51, bup52, bup53, bup54, bup55);
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}{40}{41}{42}{43}{44}{45}{46}{47}{48}{49}{50}{51}{52}{53}{54}{55}{56}{57}{58}{59}{60}    +-----+-----+", aup0, aup1, aup2, aup3, aup4, aup5, aup6, aup7, aup8, aup9, aup10, aup11, aup12, aup13, aup14, aup15, aup16, aup17, aup18, aup19, aup20, aup21, aup22, aup23, aup24, aup25, aup26, aup27, aup28, aup29, aup30, aup31, aup32, aup33, aup34, aup35, aup36, aup37, aup38, aup39, aup40, aup41, aup42, aup43, aup44, aup45, aup46, aup47, aup48, aup49, aup50, aup51, aup52, aup53, aup54, aup55, aup56, aup57, aup58, aup59, aup60);
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}{40}{41}{42}{43}{44}{45}{46}{47}{48}{49}{50}{51}{52}{53}{54}{55}{56}{57}{58}{59}{60}{61}{62}{63}{64}|  Q  |  W2 |", up0, up1, up2, up3, up4, up5, up6, up7, up8, up9, up10, up11, up12, up13, up14, up15, up16, up17, up18, up19, up20, up21, up22, up23, up24, up25, up26, up27, up28, up29, up30, up31, up32, up33, up34, up35, up36, up37, up38, up39, up40, up41, up42, up43, up44, up45, up46, up47, up48, up49, up50, up51, up52, up53, up54, up55, up56, up57, up58, up59, up60, up61, up62, up63, up64);
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}{40}         {41}{42}{43}{44}{45}{46}{47}{48}{49}{50}{51}{52}{53}{54}{55}{56}{57}{58}{59}{60}{61}{62}{63}{64}{65}{66}{67}|", pos0, pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9, pos10, pos11, pos12, pos13, pos14, pos15, pos16, pos17, pos18, pos19, pos20, pos21, pos22, pos23, pos24, pos25, pos26, pos27, pos28, pos29, pos30, pos31, pos32, pos33, pos34, pos35, pos36, pos37, pos38, pos39, pos40, pos50, pos51, pos52, pos53, pos54, pos55, pos56, pos57, pos58, pos59, pos60, pos61, pos62, pos63, pos64, pos65, pos66, pos67, pos68, pos69, pos70, pos71, pos72, pos73, pos74, pos75, pos76);
                            Console.WriteLine("                                        |         |");
                            Console.WriteLine("                                         ^^^^^^^^^");
                            Console.WriteLine("********************************************************************************");
                            Console.WriteLine("  HP: {0} xp: {1}/{2} lvl: {3} gold: {4} cookies: {5}", hp, xp, neededxp, lvl, gold, cookies);
                            Console.WriteLine("********************************************************************************");
                            Console.WriteLine("{0}", msg);
                            Console.WriteLine("{0}", msg2);
                            Console.WriteLine("{0}", msg3);
                        }
                    }
                }
                if (botalive == true)
                {
                    if (ismsg == false)
                    {
                        if (info == true)
                        {
                            Console.Clear();
                            Console.WriteLine("Player: {0}  Hat: {1}             Tick: {2}        Admin = {3}   fps: {4}", uskin, usehat, i15, admin, fps);
                            Console.WriteLine("Bot: {0}  msg: {1} msg2: {2} msg3: {3}", botm, i, i13, i23);
                            Console.WriteLine("item1 = +  item4 = *                           pos: {0} pos: {1}", rand1, rand4);
                            Console.WriteLine("item2 = x                                      pos: {0}", rand2);
                            Console.WriteLine("item3 = °                                      pos: {0}", rand3);
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}{40}{41}{42}{43}{44}{45}{46}{47}{48}{49}{50}{51}{52}{53}{54}{55}", bup0, bup1, bup2, bup3, bup4, bup5, bup6, bup7, bup8, bup9, bup10, bup11, bup12, bup13, bup14, bup15, bup16, bup17, bup18, bup19, bup20, bup21, bup22, bup23, bup24, bup25, bup26, bup27, bup28, bup29, bup30, bup31, bup32, bup33, bup34, bup35, bup36, bup37, bup38, bup39, bup40, bup41, bup42, bup43, bup44, bup45, bup46, bup47, bup48, bup49, bup50, bup51, bup52, bup53, bup54, bup55);
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}{40}{41}{42}{43}{44}{45}{46}{47}{48}{49}{50}{51}{52}{53}{54}{55}{56}{57}{58}{59}{60}    +-----+-----+", aup0, aup1, aup2, aup3, aup4, aup5, aup6, aup7, aup8, aup9, aup10, aup11, aup12, aup13, aup14, aup15, aup16, aup17, aup18, aup19, aup20, aup21, aup22, aup23, aup24, aup25, aup26, aup27, aup28, aup29, aup30, aup31, aup32, aup33, aup34, aup35, aup36, aup37, aup38, aup39, aup40, aup41, aup42, aup43, aup44, aup45, aup46, aup47, aup48, aup49, aup50, aup51, aup52, aup53, aup54, aup55, aup56, aup57, aup58, aup59, aup60);
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}{40}{41}{42}{43}{44}{45}{46}{47}{48}{49}{50}{51}{52}{53}{54}{55}{56}{57}{58}{59}{60}{61}{62}{63}{64}|  Q  |  W2 |", up0, up1, up2, up3, up4, up5, up6, up7, up8, up9, up10, up11, up12, up13, up14, up15, up16, up17, up18, up19, up20, up21, up22, up23, up24, up25, up26, up27, up28, up29, up30, up31, up32, up33, up34, up35, up36, up37, up38, up39, up40, up41, up42, up43, up44, up45, up46, up47, up48, up49, up50, up51, up52, up53, up54, up55, up56, up57, up58, up59, up60, up61, up62, up63, up64);
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}{40}         {41}{42}{43}{44}{45}{46}{47}{48}{49}{50}{51}{52}{53}{54}{55}{56}{57}{58}{59}{60}{61}{62}{63}{64}{65}{66}{67}|", pos0, pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9, pos10, pos11, pos12, pos13, pos14, pos15, pos16, pos17, pos18, pos19, pos20, pos21, pos22, pos23, pos24, pos25, pos26, pos27, pos28, pos29, pos30, pos31, pos32, pos33, pos34, pos35, pos36, pos37, pos38, pos39, pos40, pos50, pos51, pos52, pos53, pos54, pos55, pos56, pos57, pos58, pos59, pos60, pos61, pos62, pos63, pos64, pos65, pos66, pos67, pos68, pos69, pos70, pos71, pos72, pos73, pos74, pos75, pos76);
                            Console.WriteLine("i1:{0} i2:{1} i3:{2} i4:{3} b:{4} g:{5}", i3, i4, i14, i16, i10, i2);
                            Console.WriteLine("item1:{0} item2:{1} item3:{2}  item4:{3} bot:{4} gold:{5}", spawndelay, spawndelay2, spawndelay3, spawndelay4, randombotspawndelay, gres);
                            Console.WriteLine("********************************************************************************");
                            Console.WriteLine("  HP: {0} xp: {1}/{2} lvl: {3} g: {4} c: {5}  |  hpdiff: {6}  xpdiff: {7}", hp, xp, neededxp, lvl, gold, cookies, hpdiff, xpdiff);
                            Console.WriteLine("********************************************************************************");
                            Console.WriteLine("{0}", msg);
                            Console.WriteLine("{0}", msg2);
                            Console.WriteLine("{0}", msg3);
                            Console.WriteLine("Bot HP: {0}", bothp);
                            Console.WriteLine("x: {0}                                        grass: {1}", pos, grass);
                            Console.WriteLine("bot x: {0}                                    fly: {1}", botpos, fly);
                        }
                        if (info == false)
                        {
                            Console.Clear();
                            Console.WriteLine("      ");
                            Console.WriteLine("      ");
                            Console.WriteLine("      ");
                            Console.WriteLine("      ");
                            Console.WriteLine("      ");
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}{40}{41}{42}{43}{44}{45}{46}{47}{48}{49}{50}{51}{52}{53}{54}{55}", bup0, bup1, bup2, bup3, bup4, bup5, bup6, bup7, bup8, bup9, bup10, bup11, bup12, bup13, bup14, bup15, bup16, bup17, bup18, bup19, bup20, bup21, bup22, bup23, bup24, bup25, bup26, bup27, bup28, bup29, bup30, bup31, bup32, bup33, bup34, bup35, bup36, bup37, bup38, bup39, bup40, bup41, bup42, bup43, bup44, bup45, bup46, bup47, bup48, bup49, bup50, bup51, bup52, bup53, bup54, bup55);
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}{40}{41}{42}{43}{44}{45}{46}{47}{48}{49}{50}{51}{52}{53}{54}{55}{56}{57}{58}{59}{60}    +-----+-----+", aup0, aup1, aup2, aup3, aup4, aup5, aup6, aup7, aup8, aup9, aup10, aup11, aup12, aup13, aup14, aup15, aup16, aup17, aup18, aup19, aup20, aup21, aup22, aup23, aup24, aup25, aup26, aup27, aup28, aup29, aup30, aup31, aup32, aup33, aup34, aup35, aup36, aup37, aup38, aup39, aup40, aup41, aup42, aup43, aup44, aup45, aup46, aup47, aup48, aup49, aup50, aup51, aup52, aup53, aup54, aup55, aup56, aup57, aup58, aup59, aup60);
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}{40}{41}{42}{43}{44}{45}{46}{47}{48}{49}{50}{51}{52}{53}{54}{55}{56}{57}{58}{59}{60}{61}{62}{63}{64}|  Q  |  W2 |", up0, up1, up2, up3, up4, up5, up6, up7, up8, up9, up10, up11, up12, up13, up14, up15, up16, up17, up18, up19, up20, up21, up22, up23, up24, up25, up26, up27, up28, up29, up30, up31, up32, up33, up34, up35, up36, up37, up38, up39, up40, up41, up42, up43, up44, up45, up46, up47, up48, up49, up50, up51, up52, up53, up54, up55, up56, up57, up58, up59, up60, up61, up62, up63, up64);
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}{40}         {41}{42}{43}{44}{45}{46}{47}{48}{49}{50}{51}{52}{53}{54}{55}{56}{57}{58}{59}{60}{61}{62}{63}{64}{65}{66}{67}|", pos0, pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9, pos10, pos11, pos12, pos13, pos14, pos15, pos16, pos17, pos18, pos19, pos20, pos21, pos22, pos23, pos24, pos25, pos26, pos27, pos28, pos29, pos30, pos31, pos32, pos33, pos34, pos35, pos36, pos37, pos38, pos39, pos40, pos50, pos51, pos52, pos53, pos54, pos55, pos56, pos57, pos58, pos59, pos60, pos61, pos62, pos63, pos64, pos65, pos66, pos67, pos68, pos69, pos70, pos71, pos72, pos73, pos74, pos75, pos76);
                            Console.WriteLine("                                        |         |");
                            Console.WriteLine("                                         ^^^^^^^^^");
                            Console.WriteLine("********************************************************************************");
                            Console.WriteLine("  HP: {0} xp: {1}/{2} lvl: {3} gold: {4} cookies: {5}", hp, xp, neededxp, lvl, gold, cookies);
                            Console.WriteLine("********************************************************************************");
                            Console.WriteLine("{0}", msg);
                            Console.WriteLine("{0}", msg2);
                            Console.WriteLine("{0}", msg3);
                            Console.WriteLine("Bot HP: {0}", bothp);
                        }
                    }
                    else if (ismsg == true)
                    {
                        if (info == true)
                        {
                            Console.WriteLine("Player: {0}  Hat: {1}             Tick: {2}        Admin = {3}   fps: {4}", uskin, usehat, i15, admin, fps);
                            Console.WriteLine("Bot: {0}  msg: {1} msg2: {2} msg3: {3}", botm, i, i13, i23);
                            Console.WriteLine("item1 = +  item4 = *                           pos: {0} pos: {1}", rand1, rand4);
                            Console.WriteLine("item2 = x                                      pos: {0}", rand2);
                            Console.WriteLine("item3 = °                                      pos: {0}", rand3);
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}{40}{41}{42}{43}{44}{45}{46}{47}{48}{49}{50}{51}{52}{53}{54}{55}", bup0, bup1, bup2, bup3, bup4, bup5, bup6, bup7, bup8, bup9, bup10, bup11, bup12, bup13, bup14, bup15, bup16, bup17, bup18, bup19, bup20, bup21, bup22, bup23, bup24, bup25, bup26, bup27, bup28, bup29, bup30, bup31, bup32, bup33, bup34, bup35, bup36, bup37, bup38, bup39, bup40, bup41, bup42, bup43, bup44, bup45, bup46, bup47, bup48, bup49, bup50, bup51, bup52, bup53, bup54, bup55);
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}{40}{41}{42}{43}{44}{45}{46}{47}{48}{49}{50}{51}{52}{53}{54}{55}{56}{57}{58}{59}{60}    +-----+-----+", aup0, aup1, aup2, aup3, aup4, aup5, aup6, aup7, aup8, aup9, aup10, aup11, aup12, aup13, aup14, aup15, aup16, aup17, aup18, aup19, aup20, aup21, aup22, aup23, aup24, aup25, aup26, aup27, aup28, aup29, aup30, aup31, aup32, aup33, aup34, aup35, aup36, aup37, aup38, aup39, aup40, aup41, aup42, aup43, aup44, aup45, aup46, aup47, aup48, aup49, aup50, aup51, aup52, aup53, aup54, aup55, aup56, aup57, aup58, aup59, aup60);
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}{40}{41}{42}{43}{44}{45}{46}{47}{48}{49}{50}{51}{52}{53}{54}{55}{56}{57}{58}{59}{60}{61}{62}{63}{64}|  Q  |  W2 |", up0, up1, up2, up3, up4, up5, up6, up7, up8, up9, up10, up11, up12, up13, up14, up15, up16, up17, up18, up19, up20, up21, up22, up23, up24, up25, up26, up27, up28, up29, up30, up31, up32, up33, up34, up35, up36, up37, up38, up39, up40, up41, up42, up43, up44, up45, up46, up47, up48, up49, up50, up51, up52, up53, up54, up55, up56, up57, up58, up59, up60, up61, up62, up63, up64);
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}{40}         {41}{42}{43}{44}{45}{46}{47}{48}{49}{50}{51}{52}{53}{54}{55}{56}{57}{58}{59}{60}{61}{62}{63}{64}{65}{66}{67}|", pos0, pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9, pos10, pos11, pos12, pos13, pos14, pos15, pos16, pos17, pos18, pos19, pos20, pos21, pos22, pos23, pos24, pos25, pos26, pos27, pos28, pos29, pos30, pos31, pos32, pos33, pos34, pos35, pos36, pos37, pos38, pos39, pos40, pos50, pos51, pos52, pos53, pos54, pos55, pos56, pos57, pos58, pos59, pos60, pos61, pos62, pos63, pos64, pos65, pos66, pos67, pos68, pos69, pos70, pos71, pos72, pos73, pos74, pos75, pos76);
                            Console.WriteLine("i1:{0} i2:{1} i3:{2} i4:{3} b:{4} g:{5}", i3, i4, i14, i16, i10, i2);
                            Console.WriteLine("item1:{0} item2:{1} item3:{2}  item4:{3} bot:{4} gold:{5}", spawndelay, spawndelay2, spawndelay3, spawndelay4, randombotspawndelay, gres);
                            Console.WriteLine("********************************************************************************");
                            Console.WriteLine("  HP: {0} xp: {1}/{2} lvl: {3} g: {4} c: {5}  |  hpdiff: {6}  xpdiff: {7}", hp, xp, neededxp, lvl, gold, cookies, hpdiff, xpdiff);
                            Console.WriteLine("********************************************************************************");
                            Console.WriteLine("{0}", msg);
                            Console.WriteLine("{0}", msg2);
                            Console.WriteLine("{0}", msg3);
                            Console.WriteLine("Bot HP: {0}", bothp);
                            Console.WriteLine("x: {0}                                        grass: {1}", pos, grass);
                            Console.WriteLine("bot x: {0}                                    fly: {1}", botpos, fly);

                        }
                        else if (info == false)
                        {
                            Console.WriteLine("      ");
                            Console.WriteLine("      ");
                            Console.WriteLine("      ");
                            Console.WriteLine("      ");
                            Console.WriteLine("      ");
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}{40}{41}{42}{43}{44}{45}{46}{47}{48}{49}{50}{51}{52}{53}{54}{55}", bup0, bup1, bup2, bup3, bup4, bup5, bup6, bup7, bup8, bup9, bup10, bup11, bup12, bup13, bup14, bup15, bup16, bup17, bup18, bup19, bup20, bup21, bup22, bup23, bup24, bup25, bup26, bup27, bup28, bup29, bup30, bup31, bup32, bup33, bup34, bup35, bup36, bup37, bup38, bup39, bup40, bup41, bup42, bup43, bup44, bup45, bup46, bup47, bup48, bup49, bup50, bup51, bup52, bup53, bup54, bup55);
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}{40}{41}{42}{43}{44}{45}{46}{47}{48}{49}{50}{51}{52}{53}{54}{55}{56}{57}{58}{59}{60}    +-----+-----+", aup0, aup1, aup2, aup3, aup4, aup5, aup6, aup7, aup8, aup9, aup10, aup11, aup12, aup13, aup14, aup15, aup16, aup17, aup18, aup19, aup20, aup21, aup22, aup23, aup24, aup25, aup26, aup27, aup28, aup29, aup30, aup31, aup32, aup33, aup34, aup35, aup36, aup37, aup38, aup39, aup40, aup41, aup42, aup43, aup44, aup45, aup46, aup47, aup48, aup49, aup50, aup51, aup52, aup53, aup54, aup55, aup56, aup57, aup58, aup59, aup60);
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}{40}{41}{42}{43}{44}{45}{46}{47}{48}{49}{50}{51}{52}{53}{54}{55}{56}{57}{58}{59}{60}{61}{62}{63}{64}|  Q  |  W2 |", up0, up1, up2, up3, up4, up5, up6, up7, up8, up9, up10, up11, up12, up13, up14, up15, up16, up17, up18, up19, up20, up21, up22, up23, up24, up25, up26, up27, up28, up29, up30, up31, up32, up33, up34, up35, up36, up37, up38, up39, up40, up41, up42, up43, up44, up45, up46, up47, up48, up49, up50, up51, up52, up53, up54, up55, up56, up57, up58, up59, up60, up61, up62, up63, up64);
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}{40}         {41}{42}{43}{44}{45}{46}{47}{48}{49}{50}{51}{52}{53}{54}{55}{56}{57}{58}{59}{60}{61}{62}{63}{64}{65}{66}{67}|", pos0, pos1, pos2, pos3, pos4, pos5, pos6, pos7, pos8, pos9, pos10, pos11, pos12, pos13, pos14, pos15, pos16, pos17, pos18, pos19, pos20, pos21, pos22, pos23, pos24, pos25, pos26, pos27, pos28, pos29, pos30, pos31, pos32, pos33, pos34, pos35, pos36, pos37, pos38, pos39, pos40, pos50, pos51, pos52, pos53, pos54, pos55, pos56, pos57, pos58, pos59, pos60, pos61, pos62, pos63, pos64, pos65, pos66, pos67, pos68, pos69, pos70, pos71, pos72, pos73, pos74, pos75, pos76);
                            Console.WriteLine("                                        |         |");
                            Console.WriteLine("                                         ^^^^^^^^^");
                            Console.WriteLine("********************************************************************************");
                            Console.WriteLine("  HP: {0} xp: {1}/{2} lvl: {3} gold: {4} cookies: {5}", hp, xp, neededxp, lvl, gold, cookies);
                            Console.WriteLine("********************************************************************************");
                            Console.WriteLine("{0}", msg);
                            Console.WriteLine("{0}", msg2);
                            Console.WriteLine("{0}", msg3);
                            Console.WriteLine("Bot HP: {0}", bothp);
                        }
                    }
                }
            }

            isinventory = false;
            isshop = false;
            ismsg = false;


            if (jump == false)
            {
                while (Console.KeyAvailable == false)
                    Thread.Sleep(1); // Loop until input is entered.
                cki = Console.ReadKey(true);
                switch (cki.Key)
                {
                    case ConsoleKey.UpArrow:
                        //if (hat == false)
                        //{
                        if (pos != 65 && pos != 71)
                        {
                            if (jetpack == true)
                            {
                                jump = true;
                            }
                        }
                        else if (pos == 65 && pos == 71)
                        {
                            Console.Clear();
                            ismsg = true;
                            Console.WriteLine("You cant fly here");
                        }
                        //}
                        //else if (hat == true)
                        //{
                        //    msg = "you cant jump with your hat dude.";
                        //}
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("DownArrow was pressed");
                        break;
                        
                    case ConsoleKey.RightArrow:
                        if (pos != 70)
                        {
                            pos++;
                            xp++;
                            steps++;
                        }
                        else if (pos == 70)
                        {
                            if (inv4 == "*")
                            {
                                pos++;
                                xp++;
                                steps++;
                            }
                            else if (inv4 != "*")
                            {
                                Console.Clear();
                                ismsg = true;
                                Console.WriteLine("You need a key to enter this room.");
                            }
                        }
                        break;
                    case ConsoleKey.I:
                        Console.Clear();
                        Console.WriteLine("*************************");
                        Console.WriteLine("*    I N V E N T O R Y  *");
                        Console.WriteLine("*************************");
                        Console.WriteLine("");
                        Console.WriteLine("'use (itemname)' to use an item.   'off (itemnamne)'   to de equip an item.");
                        Console.WriteLine("");
                        Console.WriteLine("+------+-----------------------------------+--------+");
                        Console.WriteLine("| Item |                                   | Amount |");
                        Console.WriteLine("+------+-----------------------------------+--------+");
                        Console.WriteLine("{0}                                             {1}", inv1, item1anzahl);
                        Console.WriteLine("{0}                                             {1}", inv2, item2anzahl);
                        Console.WriteLine("{0}                                             {1}", inv3, item3anzahl);
                        Console.WriteLine("{0}                                             {1}", inv4, item4anzahl);
                        Console.WriteLine("+---------------------------------------------------+");
                        isinventory = true;
                        ismsg = true;
                        break;
                    case ConsoleKey.LeftArrow:
                        pos--;
                        xp++;
                        steps++;
                        break;
                    case ConsoleKey.H:
                        Console.Clear();


                        inputmsg = "You damged the bot! o.O  u are a fucking crazy dude lol rofl!";

                        if (msg3 == "" && msg2 == "" && msg != "")
                        {
                            i13 = i;
                            i = 0;
                            msg2 = msg;
                            msg = inputmsg;
                        }
                        else if (msg3 == "" && msg2 != "" && msg != "")
                        {
                            i23 = i13;
                            i13 = i;
                            i = 0;
                            msg3 = msg2;
                            msg2 = msg;
                            msg = inputmsg;
                        }
                        else if (msg3 != "" && msg2 != "" && msg != "")
                        {
                            i23 = i13;
                            i13 = i;
                            i = 0;
                            msg3 = msg2;
                            msg2 = msg;
                            msg = inputmsg;
                        }
                        else
                        {
                            i = 0;
                            msg = inputmsg;
                        }

                        bothp--;
                        ismsg = true;
                        break;
                    case ConsoleKey.K:
                        die = true;
                        break;
                    case ConsoleKey.T:
                        input = Console.ReadLine();
                        if (input == "test")
                        {
                            Console.Clear();
                            Console.WriteLine("TEST FAILED Error Code: ▒▒█▄▄█░░█▄▄█");
                            Console.WriteLine("{0}        {1}            ▒ ▒ █ ▄ ▄ █ ░ ░ █ ▄ ▄ █ █        {2}", rand, rand1, rand2);
                            Console.WriteLine("left:{0}          leftwall:{1}", left, leftwall);
                            Console.WriteLine("info: {0}", info);
                            Console.WriteLine("gres: {0}                       hpdiff: {1}", gres, hpdiff);
                            Console.WriteLine("grassdmg: {0}   i12: {1}", grassdmg, i12);
                            Console.WriteLine("botalive: {0}   botpos: {1} botleftpos: {2}    botrightpos: {3}    botmove: {4}    ", botalive, botpos, botleftpos, botrightpos, botmove);
 
                            Console.WriteLine("left:{0}          leftwall:{1}", left, leftwall);
                            botalive = true;
                            admin = true;
                            gold = 900000;
                            jetpack = true;
                            bhp = bhp + 500;
                            hp = bhp;
                            /*  cooollloooors
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.ResetColor();
                            */
                            inv1 = "+";
                            inv2 = "x";
                            inv4 = "*";
                            ismsg = true;
                        }
                        else if (input == "cookie" || input == "cookies" || input == "cucis" || input == "ccmds" || input == "cookiecommands")
                        {
                            isinventory = true;
                            Console.Clear();
                            Console.WriteLine("***   Cookies *.*  ***");
                            Console.WriteLine("sell   1 cookie = 10 gold");
                            Console.WriteLine("buy    1 cookie = 15 gold");
                            Console.WriteLine("***   Cookie Commands   ***");
                            Console.WriteLine("");
                            Console.WriteLine("coookie stats                         shows your cookie stats");
                            Console.WriteLine("buy cookie                            buy 1 cookie");
                            Console.WriteLine("buy cookielvl                         upgrade your cookie lvl");
                            Console.WriteLine("sell cookies all                      sells all your cookies");
                            Console.WriteLine("sell cookies 5                        sells 5 of your cookies");
                            Console.WriteLine("sell cookies 10                       sells 10 of your cookies");
                            Console.WriteLine("roll cookies all                      rolls all your cookies");
                            Console.WriteLine("roll cookies 5                        rolls 5 of your cookies");
                            Console.WriteLine("roll cookies 10                       rolls 10 of your cookies");
                        }
                        else if (input == "cookie stats" || input == "cstats")
                        {
                            isinventory = true;
                            Console.Clear();
                            Console.WriteLine("*** Cookie Stats ***");
                            Console.WriteLine("");
                            Console.WriteLine("cookie level: {0}", cookielvl);
                            Console.WriteLine("levelup +cookies: {0}", lvlcookies);
                            Console.WriteLine("cookie delay: {0}", cookiedelay);
                        }
                        else if (input == "buy cookie")
                        {
                            if (gold >= 15)
                            {
                                cookies++;
                                gold = gold - 15;

                                inputmsg = "You bought 1 cookie.";


                                if (msg3 == "" && msg2 == "" && msg != "")
                                {
                                    i13 = i;
                                    i = 0;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else if (msg3 == "" && msg2 != "" && msg != "")
                                {
                                    i23 = i13;
                                    i13 = i;
                                    i = 0;
                                    msg3 = msg2;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else if (msg3 != "" && msg2 != "" && msg != "")
                                {
                                    i23 = i13;
                                    i13 = i;
                                    i = 0;
                                    msg3 = msg2;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else
                                {
                                    i = 0;
                                    msg = inputmsg;
                                }
                            }
                            else
                            {
                                inputmsg = "You dont have enough gold.";


                                if (msg3 == "" && msg2 == "" && msg != "")
                                {
                                    i13 = i;
                                    i = 0;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else if (msg3 == "" && msg2 != "" && msg != "")
                                {
                                    i23 = i13;
                                    i13 = i;
                                    i = 0;
                                    msg3 = msg2;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else if (msg3 != "" && msg2 != "" && msg != "")
                                {
                                    i23 = i13;
                                    i13 = i;
                                    i = 0;
                                    msg3 = msg2;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else
                                {
                                    i = 0;
                                    msg = inputmsg;
                                }
                            }
                        }
                        else if (input == "buy cookielvl" || input == "buy cookielevel" || input == "buy cookie lvl")
                        {
                            if (gold >= pclvl && cookielvl < 49)  
                            {
                                cookielvl++;
                                lvlcookies++;
                                cookiedelay = cookiedelay - 1000;
                                gold = gold - 15;
                                pclvl = pclvl + 50;

                                String.Format("Your cookielvl is now: {0}", cookielvl);
                                data = "Your cookielvl is now: {0}";

                                inputmsg = string.Format(data, cookielvl);


                                if (msg3 == "" && msg2 == "" && msg != "")
                                {
                                    i13 = i;
                                    i = 0;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else if (msg3 == "" && msg2 != "" && msg != "")
                                {
                                    i23 = i13;
                                    i13 = i;
                                    i = 0;
                                    msg3 = msg2;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else if (msg3 != "" && msg2 != "" && msg != "")
                                {
                                    i23 = i13;
                                    i13 = i;
                                    i = 0;
                                    msg3 = msg2;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else
                                {
                                    i = 0;
                                    msg = inputmsg;
                                }
                            }
                            else if (gold < pclvl)
                            {
                                inputmsg = "You dont have enough gold.";


                                if (msg3 == "" && msg2 == "" && msg != "")
                                {
                                    i13 = i;
                                    i = 0;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else if (msg3 == "" && msg2 != "" && msg != "")
                                {
                                    i23 = i13;
                                    i13 = i;
                                    i = 0;
                                    msg3 = msg2;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else if (msg3 != "" && msg2 != "" && msg != "")
                                {
                                    i23 = i13;
                                    i13 = i;
                                    i = 0;
                                    msg3 = msg2;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else
                                {
                                    i = 0;
                                    msg = inputmsg;
                                }
                            }
                            else
                            {
                                inputmsg = "You already have the maximum cookielvl";


                                if (msg3 == "" && msg2 == "" && msg != "")
                                {
                                    i13 = i;
                                    i = 0;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else if (msg3 == "" && msg2 != "" && msg != "")
                                {
                                    i23 = i13;
                                    i13 = i;
                                    i = 0;
                                    msg3 = msg2;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else if (msg3 != "" && msg2 != "" && msg != "")
                                {
                                    i23 = i13;
                                    i13 = i;
                                    i = 0;
                                    msg3 = msg2;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else
                                {
                                    i = 0;
                                    msg = inputmsg;
                                }
                            }
                        }
                        else if (input == "sell cookies all")
                        {
                            if (cookies > 0)
                            {
                                gold = gold + (cookies * 10);
                                cookies = 0;


                                inputmsg = "You sold all your cookies.";


                                if (msg3 == "" && msg2 == "" && msg != "")
                                {
                                    i13 = i;
                                    i = 0;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else if (msg3 == "" && msg2 != "" && msg != "")
                                {
                                    i23 = i13;
                                    i13 = i;
                                    i = 0;
                                    msg3 = msg2;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else if (msg3 != "" && msg2 != "" && msg != "")
                                {
                                    i23 = i13;
                                    i13 = i;
                                    i = 0;
                                    msg3 = msg2;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else
                                {
                                    i = 0;
                                    msg = inputmsg;
                                }
                            }
                            else
                            {
                                inputmsg = "You dont have a cookie.";


                                if (msg3 == "" && msg2 == "" && msg != "")
                                {
                                    i13 = i;
                                    i = 0;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else if (msg3 == "" && msg2 != "" && msg != "")
                                {
                                    i23 = i13;
                                    i13 = i;
                                    i = 0;
                                    msg3 = msg2;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else if (msg3 != "" && msg2 != "" && msg != "")
                                {
                                    i23 = i13;
                                    i13 = i;
                                    i = 0;
                                    msg3 = msg2;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else
                                {
                                    i = 0;
                                    msg = inputmsg;
                                }
                            }
                        }
                        else if (input == "beckyhill" || input == "bh" || input == "bhb" || input == "BHB" || input == "BH" || input == "BeckyBitch" || input == "BeckyHill" || input == "BeckyHillyBanane" || input == "BeckyHillBanane" || input == "beckyhillbanane" || input == "BECKYHILLBANANE")
                        {
                            isinventory = true;
                            ismsg = true;
                            Console.Clear();
                            Console.WriteLine("Becky is Legend. Becky is Life. add her on skype: beckyhillbanane");
                        }
                        else if (input == "speichergurke.de" || input == "lol" || input == "rofl" || input == ":D" || input == "XD" || input == "xd" || input == "Xd" || input == "LOL" || input == "ROFL" || input == "iksdee" || input == "ikssdee" || input == "iksde" || input == "x.de" || input == "rofl kopta" || input == "yolo fuck bitches every day" || input == "ui schlaka" || input == "ich bin pro" || input == "/hackthisgame" || input == "das war ein Witz" || input == "sag ich doch du dödel" || input == "daly dulo" || input == "ich mag züge" || input == "I like trains." || input == "i like trains" || input == "toast" || input == "ich bin pro hacker" || input == "ich bin hier und da lala" || input == "Ich bin du und du bist ich wenn du schaust schau ich" || input == "Ich bin ich und du bist du und wenn ich kacke schaust du zu." || input == "ich bin ich und du bist du und wenn ich kacke schaust du zu." || input == "ich bin ich und du bist du und wenn ich kacke schaust du zu" || input == "Ich bin ich und du bist du. Wenn ich kacke schaust du zu." || input == "sind zwei blumen grün." || input == "da liegt ein aufgegessener keks" || input == "ich bin hier und dort an jenem ort" || input == "duzaiuhwdaiuowdiuhd" || input == "dahiuwhuld" || input == "aildsu" || input == "dgazwiuhd" || input == "daiuhwd" || input == "dhiuawl" || input == "dlgzaiuh" || input == "dalhkdhiu" || input == "dhaiwld" || input == "adlahduilI" || input == "ich stinke nach fisch" || input == "flamingo" || input == "dachte ich mir auch so..." || input == "letztens digga ich schwör" || input == "heute Nacht hab ich es vollbracht. ich hab es gemacht hab meine Macht. Niemand schöpft Verdacht hätte fast gelacht." || input == "gugu lulu" || input == "kannst du nicht einmal so sein wie du gewesen bist als du noch, egal lass über was anderes reden..." || input == "früher war alles besser als wir alle noch frotte löttchen wan^^" || input == "was beduetet yolouhdbiusch" || input == "ich zieh dich 1n1" || input == " komm duch her" || input == "F I N D E S T  D U  D A S  L U S T I G  ?" || input == "juga yolugo" || input == "ich bin Beckyhill" || input == "ich bin dein vadda" || input == "arrg" || input == "ich hab mir auf die Zunge gebissen" || input == "ich stecke fest" || input == "akwbidlad") 
                        {
                            isinventory = true;
                            ismsg = true;
                            Console.Clear();
                            Console.WriteLine("xD");
                        }
                        else if (input == "color" && admin == true)
                        {
                            Console.Clear();
                            Console.WriteLine("use 'color (colorname)' to change the color.");
                            Console.WriteLine("colors: Black Blue Cyan Gray Green Magenta Red White Yellow");
                            isinventory = true;
                            ismsg = true;
                        }
                        else if (input == "color Black" && admin == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                        else if (input == "color Blue" && admin == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                        }
                        else if (input == "color Cyan" && admin == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                        }
                        else if (input == "color Gray" && admin == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        else if (input == "color Green" && admin == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else if (input == "color Magenta" && admin == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                        }
                        else if (input == "color Red" && admin == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        else if (input == "color White" && admin == true)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (input == "color Yellow" && admin == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        else if (input == "yolobitchcheat999")   // ▄ █ ▀
                        {
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine(" █▀▀▀▀▀▀▀▄                         █            █");
                            Console.WriteLine(" █       █    ▀    ▄█▄             █            █");
                            Console.WriteLine(" █       █    █     █    ▄▄▄▄▄▄▄   █            █");
                            Console.WriteLine(" ████████     █     █   █          █▄▄▄▄▄       █");
                            Console.WriteLine(" █       █    █     █   █          █    █       █");
                            Console.WriteLine(" █       █    █     █   █          █    █       █");
                            Console.WriteLine(" █▄▄▄▄▄▄▄▀    █     █   ▀▄▄▄▄▄▄▄   █    █       ▄");
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            isinventory = true;
                            ismsg = true;
                        }
                        else if (input == "./hack.exe")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Clear();
                            while (hacks <= 100)
                            {

                                Console.WriteLine("Loading hacks... {0}%", hacks);
                                Thread.Sleep(hackdelay);
                                hacks++;
                                hackdelay = rnd.Next(10, 525);

                            }
                            hacks = 0;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Hacks loaded.");
                            do
                            {
                                input = Console.ReadLine();
                                if (input == "Blue")
                                {
                                    Console.BackgroundColor = ConsoleColor.Blue;
                                }
                                else if (input == "Red")
                                {
                                    Console.BackgroundColor = ConsoleColor.Red;
                                }
                                else if (input == "Black")
                                {
                                    Console.BackgroundColor = ConsoleColor.Black;
                                }
                                else if (input == "admin")
                                {
                                    Console.Clear();
                                    isinventory = true;
                                    Console.WriteLine("password:");
                                    input = Console.ReadLine();
                                    ismsg = true;
                                    if (input == "BHRX")
                                    {
                                        admin = true;
                                        Console.Clear();
                                        isinventory = true;
                                        Console.WriteLine("You are now Admin!");
                                        ismsg = true;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        isinventory = true;
                                        Console.WriteLine("wrong password!");
                                        ismsg = true;
                                    }
                                }
                                else if (input == "exit")
                                {
                                    exit = true;
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else
                                {
                                    Console.Clear();
                                    isinventory = true;
                                    Console.WriteLine("unknown command. write exit to exit.");
                                    ismsg = true;
                                }
                            } while (exit == false);

                            exit = false;
                        }
                        else if (input == "hack" && admin == true)
                        {
                            gold = gold + 500;
                            bhp = bhp + 100;
                        }
                        else if (input == "./hack.exe -speed")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Clear();
                            while (hacks <= 100)
                            {

                                Console.WriteLine("Loading hacks... {0}%", hacks);
                                Thread.Sleep(hackdelay);
                                hacks++;
                                hackdelay = rnd.Next(2, 5);

                            }
                            hacks = 0;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Hacks loaded.");
                            do
                            {
                                input = Console.ReadLine();
                                if (input == "Blue")
                                {
                                    Console.BackgroundColor = ConsoleColor.Blue;
                                }
                                else if (input == "Red")
                                {
                                    Console.BackgroundColor = ConsoleColor.Red;
                                }
                                else if (input == "admin")
                                {
                                    Console.Clear();
                                    isinventory = true;
                                    Console.WriteLine("password:");
                                    input = Console.ReadLine();
                                    ismsg = true;
                                    if (input == "BHRX")
                                    {
                                        admin = true;
                                        Console.Clear();
                                        isinventory = true;
                                        Console.WriteLine("You are now Admin!");
                                        ismsg = true;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        isinventory = true;
                                        Console.WriteLine("wrong password!");
                                        ismsg = true;
                                    }
                                }
                                else if (input == "exit")
                                {
                                    exit = true;
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else
                                {
                                    Console.Clear();
                                    isinventory = true;
                                    Console.WriteLine("unknown command. write exit to exit.");
                                    ismsg = true;
                                }
                            } while (exit == false);

                            exit = false;
                        }
                        else if (input == "cl_show_admin_hud 1" && admin == true)
                        {
                            info = true;
                        }
                        else if (input == "cl_show_admin_hud 0" && admin == true)
                        {
                            info = false;
                        }
                        else if (input == "kill")
                        {
                            die = true;
                        }
                        else if (input == "off x")
                        {
                            usehat = " ";
                            hat = false;
                        }
                        else if (input == "off +")
                        {
                            usehat = " ";
                            hat = false;
                        }
                        else if (input == "use +" || input == "use item1")
                        {
                            if (inv1 == "+")
                            {
                                Console.Clear();
                                ismsg = true;

                                inputmsg = "You Changed your hat to:  +";


                                if (msg3 == "" && msg2 == "" && msg != "")
                                {
                                    i13 = i;
                                    i = 0;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else if (msg3 == "" && msg2 != "" && msg != "")
                                {
                                    i23 = i13;
                                    i13 = i;
                                    i = 0;
                                    msg3 = msg2;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else if (msg3 != "" && msg2 != "" && msg != "")
                                {
                                    i23 = i13;
                                    i13 = i;
                                    i = 0;
                                    msg3 = msg2;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else
                                {
                                    i = 0;
                                    msg = inputmsg;
                                }



                                usehat = "+";
                                ebene2 = usehat;
                                hat = true;
                            }
                            else if (inv1 != "+")
                            {
                                Console.Clear();
                                Console.WriteLine("You dont have this item!");
                                ismsg = true;
                            }
                        }
                        else if (input == "FUK")
                        {
                            pos = 55;
                        }
                        else if (input == "use x" || input == "use item2")
                        {
                            if (inv2 == "x")
                            {
                                Console.Clear();
                                ismsg = true;


                                inputmsg = "You changed you hat to: x";

                                if (msg3 == "" && msg2 == "" && msg != "")
                                {
                                    i13 = i;
                                    i = 0;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else if (msg3 == "" && msg2 != "" && msg != "")
                                {
                                    i23 = i13;
                                    i13 = i;
                                    i = 0;
                                    msg3 = msg2;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else if (msg3 != "" && msg2 != "" && msg != "")
                                {
                                    i23 = i13;
                                    i13 = i;
                                    i = 0;
                                    msg3 = msg2;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else
                                {
                                    i = 0;
                                    msg = inputmsg;
                                }

                                usehat = "x";
                                ebene2 = usehat;
                                hat = true;
                            }
                            else if (inv2 != "x")
                            {
                                Console.Clear();
                                Console.WriteLine("You dont have this item!");
                                ismsg = true;
                            }
                        }
                        else if (input == "use °" || input == "use heal" || input == "use healpotion" || input == "heal" || input == "healpotion" || input == "use HEALPOTION" || input == "use item3")
                        {
                            if (inv3 == "°")
                            {
                                Console.Clear();
                                ismsg = true;
                                
                                hpdiff = bhp - hp;
                                if (hpdiff <= 0)
                                {
                                    ismsg = true;
                                    Console.Clear();
                                    Console.WriteLine("You need to be damaged to heal.");
                                }
                                else if (hpdiff == 5)
                                {
                                    hp = bhp;
                                    item3anzahl--;

                                    inputmsg = "You used 1 healpotion.";

                                    if (msg3 == "" && msg2 == "" && msg != "")
                                    {
                                        i13 = i;
                                        i = 0;
                                        msg2 = msg;
                                        msg = inputmsg;
                                    }
                                    else if (msg3 == "" && msg2 != "" && msg != "")
                                    {
                                        i23 = i13;
                                        i13 = i;
                                        i = 0;
                                        msg3 = msg2;
                                        msg2 = msg;
                                        msg = inputmsg;
                                    }
                                    else if (msg3 != "" && msg2 != "" && msg != "")
                                    {
                                        i23 = i13;
                                        i13 = i;
                                        i = 0;
                                        msg3 = msg2;
                                        msg2 = msg;
                                        msg = inputmsg;
                                    }
                                    else
                                    {
                                        i = 0;
                                        msg = inputmsg;
                                    }
                                }
                                else if (hpdiff == 4)
                                {
                                    hp = bhp;
                                    item3anzahl--;
                                    inputmsg = "You used 1 healpotion.";

                                    if (msg3 == "" && msg2 == "" && msg != "")
                                    {
                                        i13 = i;
                                        i = 0;
                                        msg2 = msg;
                                        msg = inputmsg;
                                    }
                                    else if (msg3 == "" && msg2 != "" && msg != "")
                                    {
                                        i23 = i13;
                                        i13 = i;
                                        i = 0;
                                        msg3 = msg2;
                                        msg2 = msg;
                                        msg = inputmsg;
                                    }
                                    else if (msg3 != "" && msg2 != "" && msg != "")
                                    {
                                        i23 = i13;
                                        i13 = i;
                                        i = 0;
                                        msg3 = msg2;
                                        msg2 = msg;
                                        msg = inputmsg;
                                    }
                                    else
                                    {
                                        i = 0;
                                        msg = inputmsg;
                                    }
                                }
                                else if (hpdiff == 3)
                                {
                                    hp = bhp;
                                    item3anzahl--;
                                    inputmsg = "You used 1 healpotion.";

                                    if (msg3 == "" && msg2 == "" && msg != "")
                                    {
                                        i13 = i;
                                        i = 0;
                                        msg2 = msg;
                                        msg = inputmsg;
                                    }
                                    else if (msg3 == "" && msg2 != "" && msg != "")
                                    {
                                        i23 = i13;
                                        i13 = i;
                                        i = 0;
                                        msg3 = msg2;
                                        msg2 = msg;
                                        msg = inputmsg;
                                    }
                                    else if (msg3 != "" && msg2 != "" && msg != "")
                                    {
                                        i23 = i13;
                                        i13 = i;
                                        i = 0;
                                        msg3 = msg2;
                                        msg2 = msg;
                                        msg = inputmsg;
                                    }
                                    else
                                    {
                                        i = 0;
                                        msg = inputmsg;
                                    }
                                }
                                else if (hpdiff == 2)
                                {
                                    hp = bhp;
                                    item3anzahl--;
                                    inputmsg = "You used 1 healpotion.";
                                    if (msg3 == "" && msg2 == "" && msg != "")
                                    {
                                        i13 = i;
                                        i = 0;
                                        msg2 = msg;
                                        msg = inputmsg;
                                    }
                                    else if (msg3 == "" && msg2 != "" && msg != "")
                                    {
                                        i23 = i13;
                                        i13 = i;
                                        i = 0;
                                        msg3 = msg2;
                                        msg2 = msg;
                                        msg = inputmsg;
                                    }
                                    else if (msg3 != "" && msg2 != "" && msg != "")
                                    {
                                        i23 = i13;
                                        i13 = i;
                                        i = 0;
                                        msg3 = msg2;
                                        msg2 = msg;
                                        msg = inputmsg;
                                    }
                                    else
                                    {
                                        i = 0;
                                        msg = inputmsg;
                                    }
                                }
                                else if (hpdiff == 1)
                                {
                                    hp = bhp;
                                    item3anzahl--;
                                    inputmsg = "You used 1 healpotion.";

                                    if (msg3 == "" && msg2 == "" && msg != "")
                                    {
                                        i13 = i;
                                        i = 0;
                                        msg2 = msg;
                                        msg = inputmsg;
                                    }
                                    else if (msg3 == "" && msg2 != "" && msg != "")
                                    {
                                        i23 = i13;
                                        i13 = i;
                                        i = 0;
                                        msg3 = msg2;
                                        msg2 = msg;
                                        msg = inputmsg;
                                    }
                                    else if (msg3 != "" && msg2 != "" && msg != "")
                                    {
                                        i23 = i13;
                                        i13 = i;
                                        i = 0;
                                        msg3 = msg2;
                                        msg2 = msg;
                                        msg = inputmsg;
                                    }
                                    else
                                    {
                                        i = 0;
                                        msg = inputmsg;
                                    }
                                }
                                else if (hpdiff > 5)
                                {
                                    hp = hp + 5;
                                    item3anzahl--;
                                    inputmsg = "You used 1 healpotion.";

                                    if (msg3 == "" && msg2 == "" && msg != "")
                                    {
                                        i13 = i;
                                        i = 0;
                                        msg2 = msg;
                                        msg = inputmsg;
                                    }
                                    else if (msg3 == "" && msg2 != "" && msg != "")
                                    {
                                        i23 = i13;
                                        i13 = i;
                                        i = 0;
                                        msg3 = msg2;
                                        msg2 = msg;
                                        msg = inputmsg;
                                    }
                                    else if (msg3 != "" && msg2 != "" && msg != "")
                                    {
                                        i23 = i13;
                                        i13 = i;
                                        i = 0;
                                        msg3 = msg2;
                                        msg2 = msg;
                                        msg = inputmsg;
                                    }
                                    else
                                    {
                                        i = 0;
                                        msg = inputmsg;
                                    }
                                }




                            }
                            else if (inv2 != "°")
                            {
                                Console.Clear();
                                Console.WriteLine("You dont have this item!");
                                ismsg = true;
                            }
                        }
                        else if (input == "buy")
                        {
                            Console.Clear();
                            Console.WriteLine("missing parameters use 'buy (itemname)'");
                            ismsg = true;
                        }
                        else if (input == "buy jetpack")
                        {
                            if (gold >= 500)
                            {
                                Console.Clear();

                                inputmsg = "You bought this: Jetpack   (Press upArrow to use it)";

                                if (msg3 == "" && msg2 == "" && msg != "")
                                {
                                    i13 = i;
                                    i = 0;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else if (msg3 == "" && msg2 != "" && msg != "")
                                {
                                    i23 = i13;
                                    i13 = i;
                                    i = 0;
                                    msg3 = msg2;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else if (msg3 != "" && msg2 != "" && msg != "")
                                {
                                    i23 = i13;
                                    i13 = i;
                                    i = 0;
                                    msg3 = msg2;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else
                                {
                                    i = 0;
                                    msg = inputmsg;
                                }
                                gold = gold - 500;
                                jetpack = true;
                                ismsg = true;
                            }
                            else if (gold < php)
                            {
                                Console.Clear();
                                Console.WriteLine("You dont have enough money.");
                                ismsg = true;
                            }
                        }
                        else if (input == "buy hp+" || input == "buy hp")
                        {
                            if (gold >= php)
                            {
                                Console.Clear();

                                inputmsg = "you bought 1 more hp.";

                                if (msg3 == "" && msg2 == "" && msg != "")
                                {
                                    i13 = i;
                                    i = 0;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else if (msg3 == "" && msg2 != "" && msg != "")
                                {
                                    i23 = i13;
                                    i13 = i;
                                    i = 0;
                                    msg3 = msg2;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else if (msg3 != "" && msg2 != "" && msg != "")
                                {
                                    i23 = i13;
                                    i13 = i;
                                    i = 0;
                                    msg3 = msg2;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else
                                {
                                    i = 0;
                                    msg = inputmsg;
                                }

                                gold = gold - php;
                                php = php + 10;
                                bhp++;
                                ismsg = true;
                            }
                            else if (gold < php)
                            {
                                Console.Clear();
                                Console.WriteLine("You dont have enough money.");
                                ismsg = true;
                            }
                        }
                        else if (input == "skin #")
                        {
                            Console.Clear();
                            uskin = "#";
                            ismsg = true;
                            rainbow = false;

                            inputmsg = "you changed your skin to #";

                            if (msg3 == "" && msg2 == "" && msg != "")
                            {
                                i13 = i;
                                i = 0;
                                msg2 = msg;
                                msg = inputmsg;
                            }
                            else if (msg3 == "" && msg2 != "" && msg != "")
                            {
                                i23 = i13;
                                i13 = i;
                                i = 0;
                                msg3 = msg2;
                                msg2 = msg;
                                msg = inputmsg;
                            }
                            else if (msg3 != "" && msg2 != "" && msg != "")
                            {
                                i23 = i13;
                                i13 = i;
                                i = 0;
                                msg3 = msg2;
                                msg2 = msg;
                                msg = inputmsg;
                            }
                            else
                            {
                                i = 0;
                                msg = inputmsg;
                            }

                        }
                        else if (input == "skin rainbow" || input == "skin rain" || input == "skin rainy" || input == "skin RAINBOW" || input == "srain" || input == "gimme my rainy" || input == "rainbuw plss" || input == "rainbow skin to me")
                        {
                            if (skin3 == "rainbow")
                            {
                                Console.Clear();
                                uskin = skin3;


                                inputmsg = "You changed your skin to rainbow";

                                if (msg3 == "" && msg2 == "" && msg != "")
                                {
                                    i13 = i;
                                    i = 0;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else if (msg3 == "" && msg2 != "" && msg != "")
                                {
                                    i23 = i13;
                                    i13 = i;
                                    i = 0;
                                    msg3 = msg2;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else if (msg3 != "" && msg2 != "" && msg != "")
                                {
                                    i23 = i13;
                                    i13 = i;
                                    i = 0;
                                    msg3 = msg2;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else
                                {
                                    i = 0;
                                    msg = inputmsg;
                                }

                                rainbow = true;
                                ismsg = true;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("You dont have this skin.");
                                ismsg = true;
                            }
                        }
                        else if (input == "skin @")
                        {
                            if (skin1 == "@")
                            {
                                Console.Clear();
                                uskin = skin1;


                                inputmsg = "You changed your skin to @";

                                if (msg3 == "" && msg2 == "" && msg != "")
                                {
                                    i13 = i;
                                    i = 0;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else if (msg3 == "" && msg2 != "" && msg != "")
                                {
                                    i23 = i13;
                                    i13 = i;
                                    i = 0;
                                    msg3 = msg2;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else if (msg3 != "" && msg2 != "" && msg != "")
                                {
                                    i23 = i13;
                                    i13 = i;
                                    i = 0;
                                    msg3 = msg2;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else
                                {
                                    i = 0;
                                    msg = inputmsg;
                                }

                                rainbow = false;
                                ismsg = true;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("You dont have this skin.");
                                ismsg = true;
                            }
                        }
                        else if (input == "skin ?")
                        {
                            if (skin4 == "▄")
                            {
                                Console.Clear();
                                uskin = skin4;
                      

                                inputmsg = "You Changed your skin to ▄";


                                if (msg3 == "" && msg2 == "" && msg != "")
                                {
                                    i13 = i;
                                    i = 0;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else if (msg3 == "" && msg2 != "" && msg != "")
                                {
                                    i23 = i13;
                                    i13 = i;
                                    i = 0;
                                    msg3 = msg2;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else if (msg3 != "" && msg2 != "" && msg != "")
                                {
                                    i23 = i13;
                                    i13 = i;
                                    i = 0;
                                    msg3 = msg2;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else
                                {
                                    i = 0;
                                    msg = inputmsg;
                                }


                                rainbow = false;
                                ismsg = true;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("You dont have this skin.");
                                ismsg = true;
                            }
                        }
                        else if (input == "skins")
                        {
                            Console.Clear();
                            Console.WriteLine("Your skins: {0}  {1}  {2}  {3}  {4}", dskin, skin1, skin2, skin3, skin4);
                            Console.WriteLine("type 'skin (skin)' to use a skin.");
                            ismsg = true;
                        }
                        else if (input == "buy skin rainbow" || input == "buy skin rain" && buyskin3 == false)
                        {
                            if (gold >= 1000)
                            {
                                buyskin3 = true;
                                skin3 = "rainbow";
                                gold = gold - 1000;
                                Console.Clear();


                                inputmsg = "You bought this skin: rainbow";

                                if (msg3 == "" && msg2 == "" && msg != "")
                                {
                                    i13 = i;
                                    i = 0;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else if (msg3 == "" && msg2 != "" && msg != "")
                                {
                                    i23 = i13;
                                    i13 = i;
                                    i = 0;
                                    msg3 = msg2;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else if (msg3 != "" && msg2 != "" && msg != "")
                                {
                                    i23 = i13;
                                    i13 = i;
                                    i = 0;
                                    msg3 = msg2;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else
                                {
                                    i = 0;
                                    msg = inputmsg;
                                }
                                ismsg = true;
                            }
                            else if (gold < 1000)
                            {
                                Console.Clear();
                                Console.WriteLine("You dont have enough money.");
                                ismsg = true;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("error!");
                                ismsg = true;
                            }
                        }
                        else if (input == "buy skin ?" && buyskin4 == false) // skin4
                        {
                            if (gold >= 5000)
                            {
                                buyskin4 = true;
                                skin4 = "▄";
                                gold = gold - 5000;
                                Console.Clear();
   

                                inputmsg = "You bought this skin: ▄";

                                if (msg3 == "" && msg2 == "" && msg != "")
                                {
                                    i13 = i;
                                    i = 0;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else if (msg3 == "" && msg2 != "" && msg != "")
                                {
                                    i23 = i13;
                                    i13 = i;
                                    i = 0;
                                    msg3 = msg2;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else if (msg3 != "" && msg2 != "" && msg != "")
                                {
                                    i23 = i13;
                                    i13 = i;
                                    i = 0;
                                    msg3 = msg2;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else
                                {
                                    i = 0;
                                    msg = inputmsg;
                                }

                                ismsg = true;
                            }
                            else if (gold < 5000)
                            {
                                Console.Clear();
                                Console.WriteLine("You dont have enough money.");
                                ismsg = true;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("error buying skin");
                                ismsg = true;
                            }
                        }
                        else if (input == "buy skin @" && buyskin1 == false)
                        {
                            if (gold >= 50)
                            {
                                buyskin1 = true;
                                skin1 = "@";
                                gold = gold - 50;
                                Console.Clear();

                                inputmsg = "You bought this skin: @";

                                if (msg3 == "" && msg2 == "" && msg != "")
                                {
                                    i13 = i;
                                    i = 0;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else if (msg3 == "" && msg2 != "" && msg != "")
                                {
                                    i23 = i13;
                                    i13 = i;
                                    i = 0;
                                    msg3 = msg2;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else if (msg3 != "" && msg2 != "" && msg != "")
                                {
                                    i23 = i13;
                                    i13 = i;
                                    i = 0;
                                    msg3 = msg2;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else
                                {
                                    i = 0;
                                    msg = inputmsg;
                                }
                                ismsg = true;
                            }
                            else if (gold < 50)
                            {
                                Console.Clear();
                                Console.WriteLine("You dont have enough money.");
                                ismsg = true;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("error buying skin.");
                                ismsg = true;
                            }
                        }
                        else if (input == "buy hpregen")
                        {
                            if (gold >= phpregen && hpregendelay >= 6)
                            {
                                Console.Clear();
                                hpregenlvl++;
                                gold = gold - phpregen;
                                phpregen++;
                                hpregendelay--;
                                String.Format("Health Regeneration Level is now {0}", hpregenlvl);
                                data = "Health Regeneration Level is now {0}";
       
                                inputmsg = string.Format(data, hpregenlvl);

                                if (msg3 == "" && msg2 == "" && msg != "")
                                {
                                    i13 = i;
                                    i = 0;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else if (msg3 == "" && msg2 != "" && msg != "")
                                {
                                    i23 = i13;
                                    i13 = i;
                                    i = 0;
                                    msg3 = msg2;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else if (msg3 != "" && msg2 != "" && msg != "")
                                {
                                    i23 = i13;
                                    i13 = i;
                                    i = 0;
                                    msg3 = msg2;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else
                                {
                                    i = 0;
                                    msg = inputmsg;
                                }


                                ismsg = true;
                            }
                            else if (gold < phpregen)
                            {
                                Console.Clear();
                                Console.WriteLine("You dont have enough money.");
                                ismsg = true;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("You already upgraded to the maximum level.");
                                ismsg = true;
                            }
                        }
                        else if (input == "buy gold")
                        {
                            if (gold >= pgold && gdel <= 99)
                            {
                                Console.Clear();
                                gres--;
                                gold = gold - pgold;
                                pgold++;
                                gdel++;
                                String.Format("old respawns now {0}% faster", gdel);
                                data = "gold respawns now {0}% faster.";

                                inputmsg = string.Format(data, gdel);

                                if (msg3 == "" && msg2 == "" && msg != "")
                                {
                                    i13 = i;
                                    i = 0;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else if (msg3 == "" && msg2 != "" && msg != "")
                                {
                                    i23 = i13;
                                    i13 = i;
                                    i = 0;
                                    msg3 = msg2;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else if (msg3 != "" && msg2 != "" && msg != "")
                                {
                                    i23 = i13;
                                    i13 = i;
                                    i = 0;
                                    msg3 = msg2;
                                    msg2 = msg;
                                    msg = inputmsg;
                                }
                                else
                                {
                                    i = 0;
                                    msg = inputmsg;
                                }

                                ismsg = true;
                            }
                            else if (gold < pgold)
                            {
                                Console.Clear();
                                Console.WriteLine("You dont have enough money.");
                                ismsg = true;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("You already upgraded to the maximum level.");
                                ismsg = true;
                            }
                        }
                        else if (input == "stats" || input == "STATS" || input == "STATISTICS" || input == "MAMA WIE KRASS BIN ICH?!" || input == "MAMA WIE KRASS BIN ICH!?" || input == "MAMA WIE KRASS BIN ICH ??")
                        {
                            Console.Clear();
                            ismsg = true;
                            isinventory = true;
                            Console.WriteLine("**** STATS ****");
                            Console.WriteLine("Walked in m: {0}", steps);
                            Console.WriteLine("Deaths: {0}", deaths);
                            Console.WriteLine("*** UPGRADES ***");
                            Console.WriteLine("gold: {0}/100                Upgrade costs: {1} gold", gdel, pgold);
                            Console.WriteLine("hp: {0}                      Upgrade costs: {1} gold", bhp, php);
                            Console.WriteLine("hpregen: {0}/95             Upgrade costs: {1} gold", hpregenlvl, phpregen);
                        }
                        else if (input == "hört mich jemand?" || input == "jemand da?" || input == "hoert mich jmd?" || input == "beobachtest du mich?" || input == "bist du da?" || input == "jmd da?" || input == "kann mich jemand hören?" || input == "kann ich mit dir reden?" || input == "kann ich dir ein geheimnis verraten?" || input == "darf ich dich heiraten?" || input == "magst du mich?" || input == "magst du bratwurst?" || input == "yolo bitches sind kuhl" || input == "bist du youtuber?" || input == "verstehst du mich?" || input == "wirklich?" || input == "hui?" || input == "steve?" || input == "ist das gut so?" || input == "geht es dir gut?" || input == "kannst du deutsch?" || input == "can u german?" || input == "fickst du bitches?" || input == "lust auf sex?" || input == "bock zu fickn?" || input == "bock zu fick'n?" || input == "lust auf geschlechtsverkehr?" || input == "kennst du den sinn des lebens?" || input == "kennst du den Sinn des Lebens?" || input == "magst du Züge?" || input == "magst du teeworlds?" || input == "can u hear me?" || input == "u listenin ?" || input == "hallo, ist die NSA hier?" || input == "kann die NSA das überwachen?" || input == "sind wir alleine?" || input == "hue ich bin ja ganzschön fett wa?" || input == "bin ich dir zu dick?" || input == "bin ich dir zu dick ?" || input == "bin ich dir zu dick?!" || input == "BIN ICH DIR ZU DICK?!" || input == "bin ich dir zu fett?" || input == "bin ich dir zu fett ?" || input == "sex?" || input == "SEX?" || input == "Geschlechtsverkehr?" || input == "männlich?" || input == "weiblich?" || input == "junge?" || input == "mädchen?" || input == "bist du ein junge?" || input == "bist du ein mädchen?" || input == "girl?" || input == "boy?" || input == "wird das wetter schön?" || input == "heute schon ge pipit?" || input == "morgen ist ein schöner tag oder?" || input == "ist 12422 eine schne zahl?" || input == "spielst du teeworlds?" || input == "do you play teeworlds?" || input == "kennst du SWAG_DUDE9999999?" || input == "pflugzeuge sind schön wa?" || input == "findest du mich hübsch?" || input == "findest du mich hübsch?!" || input == "würdest du es mit mir tun?" || input == "heute schon was vor?" || input == "schwanger?" || input == "heute?" || input == "morgen?" || input == "in einem jahr?" || input == "noch diesen monat?" || input == "speakst du die yolo language?" || input == "kannst du auch ja sagen?" || input == "sag ja" || input == "kannst du auch nein sagen?" || input == "treffen?" || input == "lass mal treffen?" || input == "erinnerst du dich noch an mich?" || input == "weisst du wer ich bin?" || input == "weisst du noch wer ich bin?" || input == "weißt du wer ich bin?" || input == "hui hoi yolo test123. ich mag mich magst du mich?" || input == "ROBOTEST123. ii bist ii du ii ein ii mensch ii ?" || input == " k a n n s t  d u  d a s  l e s e n  ?" || input == "kannst du lesen?" || input == "hurr die uhr die muhrt xD" || input == "hat das game irgendwelche eastereggs?" || input == "kannst du reden?" || input == "K A N N S T  DU A U CH  D A $ HIER lesN?" || input == "ja?" || input == "jaha" || input == "jaha!" || input == "yup")
                        {
                            Console.Clear();
                            Console.WriteLine("ja.");
                            isinventory = true;
                            ismsg = true;
                        }
                        else if (input == "kwäst")
                        {
                            quest1 = true;
                        }
                        else if (input == "help" || input == "Help" || input == "HELP" || input == "hälp" || input == "HÄÄLP!" || input == "hälp!" || input == "aiuto" || input == "hilfe" || input == "beenden" || input == "holt mich hier raus!" || input == "kann mir jemand helfen?")
                        {
                            Console.Clear();
                            Console.WriteLine("*** HELP ***");
                            Console.WriteLine("Press Escape to visit the Shop.");
                            Console.WriteLine("Press I to open your Inventory.");
                            Console.WriteLine("Press X to eXit the game.");
                            Console.WriteLine("Move with the arrows on your keyboard.");
                            Console.WriteLine("type 'cmdlist' to see all commands");
                            ismsg = true;
                            isinventory = true;
                        }
                        else if (input == "cmdlist")
                        {
                            Console.Clear();
                            Console.WriteLine("*** COMMANDS ***");
                            Console.WriteLine("'buy (itemname)'           Press Escape to see the list of all Items.");
                            Console.WriteLine("'kill'                     kill your self to respawn. (you loose 1 gold)");
                            ismsg = true;
                            isinventory = true;
                        }
                        else if (input == "info" || input == "INFO" || input == "Info" || input == "InFo" || input == "INFORMATION" || input == "give me ur infus babe")
                        {
                            info = true;
                        }
                        else if (input == "yolohack3000")
                        {
                            Console.Clear();
                            Console.WriteLine("please dont hack.");
                            ismsg = true;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("unknown command try help.");
                            ismsg = true;
                        }
                        break;

                    case ConsoleKey.Escape:

                        do
                        {
                            ismsg = true;
                            isshop = true;
                            Console.Clear();
                            Console.WriteLine("******************************");
                            Console.WriteLine("*           S H O P          *");
                            Console.WriteLine("******************************");
                            Console.WriteLine("");
                            Console.WriteLine("buy (itemname)");
                            Console.WriteLine("");
                            Console.WriteLine("****  ITEMS  ****  description *****************   Price ******");
                            Console.WriteLine("");
                            Console.WriteLine("hp+                 Upgrades Your Health.             {0} gold", php);
                            Console.WriteLine("gold                make gold spawn faster.           {0} gold", pgold);
                            Console.WriteLine("jetpack             use uparrow to fly                500 gold");
                            Console.WriteLine("hpregen             regenerate your Health.           {0} gold", phpregen);
                            Console.WriteLine("");
                            Console.WriteLine("**** SKINS *************************************   Price ******");
                            Console.WriteLine("");
                            Console.WriteLine("buy skin (skin name)");
                            Console.WriteLine("");
                            Console.WriteLine("@                                                     50 gold");
                            Console.WriteLine("x                                                     100 gold");
                            Console.WriteLine("rainbow                                               1000 gold");
                            Console.WriteLine("?                                                     5000 gold");
                        } while (cki.Key != ConsoleKey.Escape);
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Unknown key. Use 'T' to write commands.");
                        ismsg = true;
                        break;

                }
            }
            else if (jump == true)
            {
                jump = false;
            }

            //quest hütte abfrage
            if (pos == 66 || pos == 67 || pos == 68 || pos == 69 || pos == 70)
            {
                inputmsg = "Jump to enter a Quest!";

                if (msg3 == "" && msg2 == "" && msg != "")
                {
                    i13 = i;
                    i = 0;
                    msg2 = msg;
                    msg = inputmsg;
                }
                else if (msg3 == "" && msg2 != "" && msg != "")
                {
                    i23 = i13;
                    i13 = i;
                    i = 0;
                    msg3 = msg2;
                    msg2 = msg;
                    msg = inputmsg;
                }
                else if (msg3 != "" && msg2 != "" && msg != "")
                {
                    i23 = i13;
                    i13 = i;
                    i = 0;
                    msg3 = msg2;
                    msg2 = msg;
                    msg = inputmsg;
                }
                else
                {
                    i = 0;
                    msg = inputmsg;
                }

                if (fly == true)
                {
                    quest1 = true;
                    fly = false;
                }
            }



            //world 2 hütte abfrage
            if (pos == 72 || pos == 73 || pos == 74 || pos == 75 || pos == 76)
            {
                inputmsg = "Jump to enter World2!";

                if (msg3 == "" && msg2 == "" && msg != "")
                {
                    i13 = i;
                    i = 0;
                    msg2 = msg;
                    msg = inputmsg;
                }
                else if (msg3 == "" && msg2 != "" && msg != "")
                {
                    i23 = i13;
                    i13 = i;
                    i = 0;
                    msg3 = msg2;
                    msg2 = msg;
                    msg = inputmsg;
                }
                else if (msg3 != "" && msg2 != "" && msg != "")
                {
                    i23 = i13;
                    i13 = i;
                    i = 0;
                    msg3 = msg2;
                    msg2 = msg;
                    msg = inputmsg;
                }
                else
                {
                    i = 0;
                    msg = inputmsg;
                }

                if (fly == true)
                {
                    world2 = true;
                    fly = false;
                }
            }



            //quest test xD

            if (quest1 == true)
            {
                do
                {
                    if (posq <= 0)
                    {
                        die = true;
                    }

                    
                    qpos1 = "_";
                    qpos2 = "_";
                    qpos3 = "_";
                    qpos4 = "_";
                    qpos5 = "_";
                    qpos6 = "_";
                    qpos7 = "_";             //  _
                    qpos8 = "_";             // / \
                    qpos9 = "_";             // |Q|
                    qpos10 = "_";
                    qpos11 = "_";
                    qpos12 = "_";
                    qpos13 = "_";
                    qpos14 = "_";
                    qpos15 = "_";
                    qpos16 = "_";
                    qpos17 = "_";
                    qpos18 = "_";
                    qpos19 = "_";
                    qpos20 = "_";
                    qpos21 = "_";
                    qpos22 = "_";
                    qpos23 = "_";
                    qpos24 = "_";
                    qpos25 = "_";
                    qpos26 = "_";
                    qpos27 = "_";
                    qpos28 = "_";
                    qpos29 = "_";
                    qpos30 = "_";
                    qpos31 = "_";
                    qpos32 = "_";
                    qpos33 = "_";
                    qpos34 = "_";
                    qpos35 = "_";
                    qpos36 = "_";
                    qpos37 = "_";
                    qpos38 = "_";
                    qpos39 = "_";
                    qpos40 = "_";
                    //up
                    qup1 = " ";
                    qup2 = " ";
                    qup3 = " ";
                    qup4 = " ";
                    qup5 = " ";
                    qup6 = " ";
                    qup7 = " ";             
                    qup8 = " ";             
                    qup9 = " ";             
                    qup10 = " ";
                    qup11 = " ";
                    qup12 = " ";
                    qup13 = " ";
                    qup14 = " ";
                    qup15 = " ";
                    qup16 = " ";
                    qup17 = " ";
                    qup18 = " ";
                    qup19 = " ";
                    qup20 = " ";
                    qup21 = " ";
                    qup22 = " ";
                    qup23 = " ";
                    qup24 = " ";
                    qup25 = " ";
                    qup26 = " ";
                    qup27 = " ";
                    qup28 = " ";
                    qup29 = " ";
                    qup30 = " ";
                    qup31 = " ";
                    qup32 = " ";
                    qup33 = " ";
                    qup34 = " ";
                    qup35 = " ";
                    qup36 = " ";
                    qup37 = " ";
                    qup38 = " ";
                    qup39 = " ";
                    qup40 = " ";
                    //ebene3
                    qaup1 = " ";
                    qaup2 = " ";
                    qaup3 = " ";
                    qaup4 = " ";
                    qaup5 = " ";
                    qaup6 = " ";
                    qaup7 = " ";
                    qaup8 = " ";
                    qaup9 = " ";
                    qaup10 = " ";
                    qaup11 = " ";
                    qaup12 = " ";
                    qaup13 = " ";
                    qaup14 = " ";
                    qaup15 = " ";
                    qaup16 = " ";
                    qaup17 = " ";
                    qaup18 = " ";
                    qaup19 = " ";
                    qaup20 = " ";
                    qaup21 = " ";
                    qaup22 = " ";
                    qaup23 = " ";
                    qaup24 = " ";
                    qaup25 = " ";
                    qaup26 = " ";
                    qaup27 = " ";
                    qaup28 = " ";
                    qaup29 = " ";
                    qaup30 = " ";
                    qaup31 = " ";
                    qaup32 = " ";
                    qaup33 = " ";
                    qaup34 = " ";
                    qaup35 = " ";
                    qaup36 = " ";
                    qaup37 = " ";
                    qaup38 = " ";
                    qaup39 = " ";
                    qaup40 = " ";

                    i17++;
                    i18++;
                    i19++;
                    i20++;
                    i21++;




                    //drittes hinderniss boden weg o.O
                    ////skin sichtbar machen nicht mehr gebraucht wegen umstrukturierung

                    //if (posq == 10 || posq == 11 || posq == 12 || posq == 13 || posq == 14 && )

                    if (i21 == 1 || i21 == 2 || i21 == 3 || i21 == 4 || i21 == 5)
                    {
                        qpos10 = " ";
                        qpos11 = " ";
                        qpos12 = " ";
                        qpos13 = " ";
                        qpos14 = " ";
                        trap = true;
                    }
                    else if (i21 == 6 || i21 == 7 || i21 == 8 || i21 == 9 || i21 == 10)
                    {
                        qpos10 = "_";
                        qpos11 = "_";
                        qpos12 = "_";
                        qpos13 = "_";
                        qpos14 = "_";
                        trap = false;
                    }
                    else
                    {
                        i21 = 1;
                        qpos10 = "_";
                        qpos11 = "_";
                        qpos12 = "_";
                        qpos13 = "_";
                        qpos14 = "_";
                        trap = false;
                    }

                    //die 
                    if (posq == 10 && trap == true || posq == 11 && trap == true || posq == 12 && trap == true || posq == 13 && trap == true || posq == 14 && trap == true)
                    {
                        die = true;
                    }


                    //postion world2 abfrage
                    qpus = uskin;

                    if (posq == 1)
                    {
                        qpos1 = qpus;
                    }
                    else if (posq == 2)
                    {
                        qpos2 = qpus;
                    }
                    else if (posq == 3)
                    {
                        qpos3 = qpus;
                    }
                    else if (posq == 4)
                    {
                        qpos4 = qpus;
                    }
                    else if (posq == 5)
                    {
                        qpos5 = qpus;
                    }
                    else if (posq == 6)
                    {
                        qpos6 = qpus;
                    }
                    else if (posq == 7)
                    {
                        qpos7 = qpus;
                    }
                    else if (posq == 8)
                    {
                        qpos8 = qpus;
                    }
                    else if (posq == 9)
                    {
                        qpos9 = qpus;
                    }
                    else if (posq == 10)
                    {
                        qpos10 = qpus;
                    }
                    else if (posq == 11)
                    {
                        qpos11 = qpus;
                    }
                    else if (posq == 12)
                    {
                        qpos12 = qpus;
                    }
                    else if (posq == 13)
                    {
                        qpos13 = qpus;
                    }
                    else if (posq == 14)
                    {
                        qpos14 = qpus;
                    }
                    else if (posq == 15)
                    {
                        qpos15 = qpus;
                    }
                    else if (posq == 16)
                    {
                        qpos16 = qpus;
                    }
                    else if (posq == 17)
                    {
                        qpos17 = qpus;
                    }
                    else if (posq == 18)
                    {
                        qpos18 = qpus;
                    }
                    else if (posq == 19)
                    {
                        qpos19 = qpus;
                    }
                    else if (posq == 20)
                    {
                        qpos20 = qpus;
                    }
                    else if (posq == 21)
                    {
                        qpos21 = qpus;
                    }
                    else if (posq == 22)
                    {
                        qpos22 = qpus;
                    }
                    else if (posq == 23)
                    {
                        qpos23 = qpus;
                    }
                    else if (posq == 24)
                    {
                        qpos24 = qpus;
                    }
                    else if (posq == 25)
                    {
                        qpos25 = qpus;
                    }
                    else if (posq == 26)
                    {
                        qpos26 = qpus;
                    }
                    else if (posq == 27)
                    {
                        qpos27 = qpus;
                    }
                    else if (posq == 28)
                    {
                        qpos28 = qpus;
                    }
                    else if (posq == 29)
                    {
                        qpos29 = qpus;
                    }
                    else if (posq == 30)
                    {
                        qpos30 = qpus;
                    }
                    else if (posq == 31)
                    {
                        qpos31 = qpus;
                    }
                    else if (posq == 32)
                    {
                        qpos32 = qpus;
                    }
                    else if (posq == 33)
                    {
                        qpos33 = qpus;
                    }
                    else if (posq == 34)
                    {
                        qpos34 = qpus;
                    }
                    else if (posq == 35)
                    {
                        qpos35 = qpus;
                    }
                    else if (posq == 36)
                    {
                        qpos36 = qpus;
                    }
                    else if (posq == 37)
                    {
                        qpos37 = qpus;
                    }
                    else if (posq == 38)
                    {
                        qpos38 = qpus;
                    }
                    else if (posq == 39)
                    {
                        qpos39 = qpus;
                    }
                    else if (posq == 40)
                    {
                        qpos40 = qpus;
                    }
                    else if (posq > 40)
                    {
                        bossfight = true;
                    }

     










                    //zweites hindanizz x
                    //über zeug fliegen
                    if (posq == 8)
                    {
                        qskin = uskin;
                    }
                    else
                    {
                        qskin = "_";
                    }

                    if (i20 == 0)
                    {
                        qaup8 = " ";
                        qup8 = " ";
                        qpos8 = "x";
                    }
                    else if (i20 == 1)
                    {
                        qaup8 = " ";
                        qup8 = "x";
                        qpos8 = qskin;
                    }
                    else if (i20 == 2)
                    {
                        qaup8 = "x";
                        qup8 = " ";
                        qpos8 = qskin;
                    }
                    else if (i20 == 3)
                    {
                        qaup8 = " ";
                        qup8 = "x";
                        qpos8 = qskin;
                    }
                    else
                    {
                        i20 = 0;
                        qaup8 = " ";
                        qup8 = " ";
                        qpos8 = "x";
                    }
                
                    if (posq == 8 && qpos8 == "x")
                    {
                        die = true;
                    }


                    //erstes hindaniss x
                    //über zeug fliegen
                    if (posq == 5)
                    {
                        qskin = uskin;
                    }
                    else
                    {
                        qskin = "_";
                    }

                    if (i17 == 5 || i17 == 6 || i17 == 7 || i17 == 8 || i17 == 9)
                    {
                        qpos5 = "x";
                    }
                    else if (i17 > 10)
                    {
                        qpos5 = qskin;
                        qup5 = "x";
                        i17 = 0;
                    }
                    else
                    {
                        qup5 = "x";
                    }
                    
                    if (posq == 5 && qpos5 == "x")
                    {
                        die = true;
                    }

            



                    if (die == true)
                    {
                        posq = 1;
                        ismsg = true;
                        Console.Clear();
                        if (msg != "")
                        {
                            w2msg2 = w2msg;
                            w2msg = "you died.";
                        }
                        else
                        {
                            w2msg = "you died.";
                        }
                        die = false;
                    }








                    if (i19 < 100)
                    {
                    }
                    else
                    {
                        w2msg = "";
                        i19 = 0;
                    }

                    if (i18 < 100)
                    {
                    }
                    else
                    {
                        w2msg2 = "";
                        i18 = 0;
                    }

                    if (w2msg2 != "" && w2msg == "")
                    {
                        w2msg2 = w2msg;
                    }


                    if (info == false)
                    {
                        if (ismsg == false)
                        {
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}", qaup1, qaup2, qaup3, qaup4, qaup5, qaup6, qaup7, qaup8, qaup9, qaup10, qaup11, qaup12, qaup13, qaup14, qaup15, qaup16, qaup17, qaup18, qaup19, qaup20, qaup21, qaup22, qaup23, qaup24, qaup25, qaup26, qaup27, qaup28, qaup29, qaup30, qaup31, qaup32, qaup33, qaup34, qaup35, qaup36, qaup37, qaup38, qaup39, qaup40);
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}", qup1, qup2, qup3, qup4, qup5, qup6, qup7, qup8, qup9, qup10, qup11, qup12, qup13, qup14, qup15, qup16, qup17, qup18, qup19, qup20, qup21, qup22, qup23, qup24, qup25, qup26, qup27, qup28, qup29, qup30, qup31, qup32, qup33, qup34, qup35, qup36, qup37, qup38, qup39, qup40);
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}", qpos1, qpos2, qpos3, qpos4, qpos5, qpos6, qpos7, qpos8, qpos9, qpos10, qpos11, qpos12, qpos13, qpos14, qpos15, qpos16, qpos17, qpos18, qpos19, qpos20, qpos21, qpos22, qpos23, qpos24, qpos25, qpos26, qpos27, qpos28, qpos29, qpos30, qpos31, qpos32, qpos33, qpos34, qpos35, qpos36, qpos37, qpos38, qpos39, qpos40);
                            Console.WriteLine("{0}", w2msg);
                            Console.WriteLine("{0}", w2msg2);
                        }
                        if (ismsg == true)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}", qaup1, qaup2, qaup3, qaup4, qaup5, qaup6, qaup7, qaup8, qaup9, qaup10, qaup11, qaup12, qaup13, qaup14, qaup15, qaup16, qaup17, qaup18, qaup19, qaup20, qaup21, qaup22, qaup23, qaup24, qaup25, qaup26, qaup27, qaup28, qaup29, qaup30, qaup31, qaup32, qaup33, qaup34, qaup35, qaup36, qaup37, qaup38, qaup39, qaup40);
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}", qup1, qup2, qup3, qup4, qup5, qup6, qup7, qup8, qup9, qup10, qup11, qup12, qup13, qup14, qup15, qup16, qup17, qup18, qup19, qup20, qup21, qup22, qup23, qup24, qup25, qup26, qup27, qup28, qup29, qup30, qup31, qup32, qup33, qup34, qup35, qup36, qup37, qup38, qup39, qup40);
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}", qpos1, qpos2, qpos3, qpos4, qpos5, qpos6, qpos7, qpos8, qpos9, qpos10, qpos11, qpos12, qpos13, qpos14, qpos15, qpos16, qpos17, qpos18, qpos19, qpos20, qpos21, qpos22, qpos23, qpos24, qpos25, qpos26, qpos27, qpos28, qpos29, qpos30, qpos31, qpos32, qpos33, qpos34, qpos35, qpos36, qpos37, qpos38, qpos39, qpos40);
                            Console.WriteLine("{0}", w2msg);
                            Console.WriteLine("{0}", w2msg2);
                            }
                    }
                    else if (info == true)
                    {
                        if (ismsg == false)
                        {
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}", qaup1, qaup2, qaup3, qaup4, qaup5, qaup6, qaup7, qaup8, qaup9, qaup10, qaup11, qaup12, qaup13, qaup14, qaup15, qaup16, qaup17, qaup18, qaup19, qaup20, qaup21, qaup22, qaup23, qaup24, qaup25, qaup26, qaup27, qaup28, qaup29, qaup30, qaup31, qaup32, qaup33, qaup34, qaup35, qaup36, qaup37, qaup38, qaup39, qaup40);
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}", qup1, qup2, qup3, qup4, qup5, qup6, qup7, qup8, qup9, qup10, qup11, qup12, qup13, qup14, qup15, qup16, qup17, qup18, qup19, qup20, qup21, qup22, qup23, qup24, qup25, qup26, qup27, qup28, qup29, qup30, qup31, qup32, qup33, qup34, qup35, qup36, qup37, qup38, qup39, qup40);
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}", qpos1, qpos2, qpos3, qpos4, qpos5, qpos6, qpos7, qpos8, qpos9, qpos10, qpos11, qpos12, qpos13, qpos14, qpos15, qpos16, qpos17, qpos18, qpos19, qpos20, qpos21, qpos22, qpos23, qpos24, qpos25, qpos26, qpos27, qpos28, qpos29, qpos30, qpos31, qpos32, qpos33, qpos34, qpos35, qpos36, qpos37, qpos38, qpos39, qpos40);
                            Console.WriteLine("{0}", w2msg);
                            Console.WriteLine("{0}", w2msg2);
                            Console.WriteLine("trap: {0} pos: {1}", trap, posq);
                        }
                        if (ismsg == true)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}", qaup1, qaup2, qaup3, qaup4, qaup5, qaup6, qaup7, qaup8, qaup9, qaup10, qaup11, qaup12, qaup13, qaup14, qaup15, qaup16, qaup17, qaup18, qaup19, qaup20, qaup21, qaup22, qaup23, qaup24, qaup25, qaup26, qaup27, qaup28, qaup29, qaup30, qaup31, qaup32, qaup33, qaup34, qaup35, qaup36, qaup37, qaup38, qaup39, qaup40);
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}", qup1, qup2, qup3, qup4, qup5, qup6, qup7, qup8, qup9, qup10, qup11, qup12, qup13, qup14, qup15, qup16, qup17, qup18, qup19, qup20, qup21, qup22, qup23, qup24, qup25, qup26, qup27, qup28, qup29, qup30, qup31, qup32, qup33, qup34, qup35, qup36, qup37, qup38, qup39, qup40);
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}{12}{13}{14}{15}{16}{17}{18}{19}{20}{21}{22}{23}{24}{25}{26}{27}{28}{29}{30}{31}{32}{33}{34}{35}{36}{37}{38}{39}", qpos1, qpos2, qpos3, qpos4, qpos5, qpos6, qpos7, qpos8, qpos9, qpos10, qpos11, qpos12, qpos13, qpos14, qpos15, qpos16, qpos17, qpos18, qpos19, qpos20, qpos21, qpos22, qpos23, qpos24, qpos25, qpos26, qpos27, qpos28, qpos29, qpos30, qpos31, qpos32, qpos33, qpos34, qpos35, qpos36, qpos37, qpos38, qpos39, qpos40);
                            Console.WriteLine("{0}", w2msg);
                            Console.WriteLine("{0}", w2msg2);
                            Console.WriteLine("trap: {0} pos: {1}", trap, posq);
                        }
                    }


                    ismsg = false;

                    while (Console.KeyAvailable == false)
                        Thread.Sleep(1); // Loop until input is entered.
                    cki = Console.ReadKey(true);
                    switch (cki.Key)
                    {
                        case ConsoleKey.RightArrow:
                            posq++;
                            break;
                        case ConsoleKey.LeftArrow:
                            posq--;
                            break;
                        case ConsoleKey.T:
                            input = Console.ReadLine();
                            if (input == "exit")
                            {
                                quest1 = false;
                            }
                            else if (input == "info")
                            {
                                info = true;
                            }
                            else
                            {
                                Console.Clear();
                                ismsg = true;
                                Console.WriteLine("unknown command type 'exit' to exit the quest.");
                            }
                            break;





                    }

                    if (bossfight == true)
                    {
                        do
                        {
                            Console.WriteLine("BOSSFIGHT!");
                            Thread.Sleep(1000);
                            bossfight = false;
                            quest1 = false;
                            qwin = true;
                        } while (bossfight == true);
                    }

                } while (quest1 == true);

                if (qwin == true)
                {

                    do
                    {
                        i22++;


                        /* old You won animation

                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("$     $                   $                             $               $       ");
                        Console.WriteLine("               $          Y O U     W O N !!!                        $          ");
                        Console.WriteLine("   $                 $                             $          $             $   ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("$          $              $                  $     $                    $  $    ");
                        Console.WriteLine("   $          $           Y O U     W O N !!!             $ $        $          ");
                        Console.WriteLine("$     $                   $                             $               $       ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("         $                    $  $              $               $        $      ");
                        Console.WriteLine("           $     $        Y O U     W O N !!!        $ $        $           $   ");
                        Console.WriteLine("$         $                          $   $                          $           ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        */



                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                                                                ");
                        Console.WriteLine("                          Y O U     W O N !!!                                   ");
                        Console.WriteLine("$                                                                               ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                                                                ");
                        Console.WriteLine("$                         Y O U     W O N !!!                                   ");
                        Console.WriteLine(" $                                                                              ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("$                                                                               ");
                        Console.WriteLine(" $                        Y O U     W O N !!!                                   ");
                        Console.WriteLine("  $                                                                             ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine(" $                                                                              ");
                        Console.WriteLine("  $                       Y O U     W O N !!!                                   ");
                        Console.WriteLine("   $                                                                            ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("  $                                                                             ");
                        Console.WriteLine("   $                      Y O U     W O N !!!                                   ");
                        Console.WriteLine("    $                                                                           ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("   $                                                                            ");
                        Console.WriteLine("    $                     Y O U     W O N !!!                                   ");
                        Console.WriteLine("     $                                                                          ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("    $                                                                           ");
                        Console.WriteLine("     $                    Y O U     W O N !!!                                   ");
                        Console.WriteLine("      $                                                                         ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("     $                                                                          ");
                        Console.WriteLine("      $                   Y O U     W O N !!!                                   ");
                        Console.WriteLine("       $                                                                        ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("      $                                                                         ");
                        Console.WriteLine("       $                  Y O U     W O N !!!                                   ");
                        Console.WriteLine("        $                                                                       ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("       $                                                                        ");
                        Console.WriteLine("        $                 Y O U     W O N !!!                                   ");
                        Console.WriteLine("         $                                                                      ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("        $                                                                       ");
                        Console.WriteLine("         $                Y O U     W O N !!!                                   ");
                        Console.WriteLine("          $                                                                     ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("         $                                                                      ");
                        Console.WriteLine("          $               Y O U     W O N !!!                                   ");
                        Console.WriteLine("           $                                                                    ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("          $                                                                     ");
                        Console.WriteLine("           $              Y O U     W O N !!!                                   ");
                        Console.WriteLine("            $                                                                   ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("           $                                                                    ");
                        Console.WriteLine("            $             Y O U     W O N !!!                                   ");
                        Console.WriteLine("             $                                                                  ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("            $                                                                   ");
                        Console.WriteLine("             $            Y O U     W O N !!!                                   ");
                        Console.WriteLine("              $                                                                 ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("             $                                                                  ");
                        Console.WriteLine("              $           Y O U     W O N !!!                                   ");
                        Console.WriteLine("               $                                                                ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("              $                                                                 ");
                        Console.WriteLine("               $          Y O U     W O N !!!                                   ");
                        Console.WriteLine("                $                                                               ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("               $                                                                ");
                        Console.WriteLine("                $         Y O U     W O N !!!                                   ");
                        Console.WriteLine("                 $                                                              ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                $                                                               ");
                        Console.WriteLine("                 $        Y O U     W O N !!!                                   ");
                        Console.WriteLine("                  $                                                             ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                 $                                                              ");
                        Console.WriteLine("                  $       Y O U     W O N !!!                                   ");
                        Console.WriteLine("                   $                                                            ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                  $                                                             ");
                        Console.WriteLine("                   $      Y O U     W O N !!!                                   ");
                        Console.WriteLine("                    $                                                           ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                   $                                                            ");
                        Console.WriteLine("                    $     Y O U     W O N !!!                                   ");
                        Console.WriteLine("                     $                                                          ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                    $                                                           ");
                        Console.WriteLine("                     $    Y O U     W O N !!!                                   ");
                        Console.WriteLine("                      $                                                         ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                     $                                                          ");
                        Console.WriteLine("                      $   Y O U     W O N !!!                                   ");
                        Console.WriteLine("                       $                                                        ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                      $                                                         ");
                        Console.WriteLine("                       $  Y O U     W O N !!!                                   ");
                        Console.WriteLine("                        $                                                       ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                       $                                                        ");
                        Console.WriteLine("                        $ Y O U     W O N !!!                                   ");
                        Console.WriteLine("                         $                                                      ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                        $                                                       ");
                        Console.WriteLine("                         $Y O U     W O N !!!                                   ");
                        Console.WriteLine("                          $                                                     ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                         $                                                      ");
                        Console.WriteLine("                          Y O U     W O N !!!                                   ");
                        Console.WriteLine("                           $                                                    ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                          $                                                     ");
                        Console.WriteLine("                          Y$O U     W O N !!!                                   ");
                        Console.WriteLine("                            $                                                   ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                           $                                                    ");
                        Console.WriteLine("                          Y O U     W O N !!!                                   ");
                        Console.WriteLine("                             $                                                  ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                            $                                                   ");
                        Console.WriteLine("                          Y O$U     W O N !!!                                   ");
                        Console.WriteLine("                              $                                                 ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                             $                                                  ");
                        Console.WriteLine("                          Y O U     W O N !!!                                   ");
                        Console.WriteLine("                               $                                                ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                              $                                                 ");
                        Console.WriteLine("                          Y O U$    W O N !!!                                   ");
                        Console.WriteLine("                                $                                               ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                               $                                                ");
                        Console.WriteLine("                          Y O U $   W O N !!!                                   ");
                        Console.WriteLine("                                 $                                              ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                $                                               ");
                        Console.WriteLine("                          Y O U  $  W O N !!!                                   ");
                        Console.WriteLine("                                  $                                             ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                 $                                              ");
                        Console.WriteLine("                          Y O U   $ W O N !!!                                   ");
                        Console.WriteLine("                                   $                                            ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                  $                                             ");
                        Console.WriteLine("                          Y O U    $W O N !!!                                   ");
                        Console.WriteLine("                                    $                                           ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                   $                                            ");
                        Console.WriteLine("                          Y O U     W O N !!!                                   ");
                        Console.WriteLine("                                     $                                          ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                    $                                           ");
                        Console.WriteLine("                          Y O U     W$O N !!!                                   ");
                        Console.WriteLine("                                      $                                         ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                     $                                          ");
                        Console.WriteLine("                          Y O U     W O N !!!                                   ");
                        Console.WriteLine("                                       $                                        ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                      $                                         ");
                        Console.WriteLine("                          Y O U     W O$N !!!                                   ");
                        Console.WriteLine("                                        $                                       ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                       $                                        ");
                        Console.WriteLine("                          Y O U     W O N !!!                                   ");
                        Console.WriteLine("                                         $                                      ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                        $                                       ");
                        Console.WriteLine("                          Y O U     W O N$!!!                                   ");
                        Console.WriteLine("                                          $                                     ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                         $                                      ");
                        Console.WriteLine("                          Y O U     W O N !!!                                   ");
                        Console.WriteLine("                                           $                                    ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                          $                                     ");
                        Console.WriteLine("                          Y O U     W O N !!!                                   ");
                        Console.WriteLine("                                            $                                   ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                           $                                    ");
                        Console.WriteLine("                          Y O U     W O N !!!                                   ");
                        Console.WriteLine("                                             $                                  ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                            $                                   ");
                        Console.WriteLine("                          Y O U     W O N !!!$                                  ");
                        Console.WriteLine("                                              $                                 ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                             $                                  ");
                        Console.WriteLine("                          Y O U     W O N !!! $                                 ");
                        Console.WriteLine("                                               $                                ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                              $                                 ");
                        Console.WriteLine("                          Y O U     W O N !!!  $                                ");
                        Console.WriteLine("                                                $                               ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                               $                                ");
                        Console.WriteLine("                          Y O U     W O N !!!   $                               ");
                        Console.WriteLine("                                                 $                              ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                                $                               ");
                        Console.WriteLine("                          Y O U     W O N !!!    $                              ");
                        Console.WriteLine("                                                  $                             ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                                 $                              ");
                        Console.WriteLine("                          Y O U     W O N !!!     $                             ");
                        Console.WriteLine("                                                   $                            ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                                  $                             ");
                        Console.WriteLine("                          Y O U     W O N !!!      $                            ");
                        Console.WriteLine("                                                    $                           ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                                   $                            ");
                        Console.WriteLine("                          Y O U     W O N !!!       $                           ");
                        Console.WriteLine("                                                     $                          ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                                    $                           ");
                        Console.WriteLine("                          Y O U     W O N !!!        $                          ");
                        Console.WriteLine("                                                      $                         ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                                     $                          ");
                        Console.WriteLine("                          Y O U     W O N !!!         $                         ");
                        Console.WriteLine("                                                       $                        ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                                      $                         ");
                        Console.WriteLine("                          Y O U     W O N !!!          $                        ");
                        Console.WriteLine("                                                        $                       ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                                       $                        ");
                        Console.WriteLine("                          Y O U     W O N !!!           $                       ");
                        Console.WriteLine("                                                         $                      ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                                        $                       ");
                        Console.WriteLine("                          Y O U     W O N !!!            $                      ");
                        Console.WriteLine("                                                          $                     ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                                         $                      ");
                        Console.WriteLine("                          Y O U     W O N !!!             $                     ");
                        Console.WriteLine("                                                           $                    ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                                          $                     ");
                        Console.WriteLine("                          Y O U     W O N !!!              $                    ");
                        Console.WriteLine("                                                            $                   ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                                           $                    ");
                        Console.WriteLine("                          Y O U     W O N !!!               $                   ");
                        Console.WriteLine("                                                             $                  ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                                            $                   ");
                        Console.WriteLine("                          Y O U     W O N !!!                $                  ");
                        Console.WriteLine("                                                              $                 ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                                             $                  ");
                        Console.WriteLine("                          Y O U     W O N !!!                 $                 ");
                        Console.WriteLine("                                                               $                ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                                              $                 ");
                        Console.WriteLine("                          Y O U     W O N !!!                  $                ");
                        Console.WriteLine("                                                                $               ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                                              $                 ");
                        Console.WriteLine("                          Y O U     W O N !!!                  $                ");
                        Console.WriteLine("                                                                $               ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                                               $                ");
                        Console.WriteLine("                          Y O U     W O N !!!                   $               ");
                        Console.WriteLine("                                                                 $              ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                                                $               ");
                        Console.WriteLine("                          Y O U     W O N !!!                    $              ");
                        Console.WriteLine("                                                                  $             ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                                                 $              ");
                        Console.WriteLine("                          Y O U     W O N !!!                     $             ");
                        Console.WriteLine("                                                                   $            ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                                                  $             ");
                        Console.WriteLine("                          Y O U     W O N !!!                      $            ");
                        Console.WriteLine("                                                                    $           ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                                                   $            ");
                        Console.WriteLine("                          Y O U     W O N !!!                       $           ");
                        Console.WriteLine("                                                                     $          ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                                                    $           ");
                        Console.WriteLine("                          Y O U     W O N !!!                        $          ");
                        Console.WriteLine("                                                                      $         ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                                                     $          ");
                        Console.WriteLine("                          Y O U     W O N !!!                         $         ");
                        Console.WriteLine("                                                                       $        ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                                                      $         ");
                        Console.WriteLine("                          Y O U     W O N !!!                          $        ");
                        Console.WriteLine("                                                                        $       ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                                                       $        ");
                        Console.WriteLine("                          Y O U     W O N !!!                           $       ");
                        Console.WriteLine("                                                                         $      ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                                                        $       ");
                        Console.WriteLine("                          Y O U     W O N !!!                            $      ");
                        Console.WriteLine("                                                                          $     ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                                                         $      ");
                        Console.WriteLine("                          Y O U     W O N !!!                             $     ");
                        Console.WriteLine("                                                                           $    ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                                                          $     ");
                        Console.WriteLine("                          Y O U     W O N !!!                              $    ");
                        Console.WriteLine("                                                                            $   ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                                                           $    ");
                        Console.WriteLine("                          Y O U     W O N !!!                               $   ");
                        Console.WriteLine("                                                                             $  ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                                                            $   ");
                        Console.WriteLine("                          Y O U     W O N !!!                                $  ");
                        Console.WriteLine("                                                                              $ ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                                                             $  ");
                        Console.WriteLine("                          Y O U     W O N !!!                                 $ ");
                        Console.WriteLine("                                                                               $");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                                                              $ ");
                        Console.WriteLine("                          Y O U     W O N !!!                                  $");
                        Console.WriteLine("                                                                                ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                                                               $");
                        Console.WriteLine("                          Y O U     W O N !!!                                   ");
                        Console.WriteLine("                                                                                ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                        Console.Clear();
                        Console.WriteLine("********************************************************************************");
                        Console.WriteLine("                                                                                ");
                        Console.WriteLine("                          Y O U     W O N !!!                                   ");
                        Console.WriteLine("                                                                                ");
                        Console.WriteLine("********************************************************************************");
                        Thread.Sleep(10);
                    } while (i22 < 5);


                    xp = xp + 150;
                    gold = gold + 70;
    
                    inputmsg = "Quest reward:  +70 gold    +150xp";

                    if (msg3 == "" && msg2 == "" && msg != "")
                    {
                        i13 = i;
                        i = 0;
                        msg2 = msg;
                        msg = inputmsg;
                    }
                    else if (msg3 == "" && msg2 != "" && msg != "")
                    {
                        i23 = i13;
                        i13 = i;
                        i = 0;
                        msg3 = msg2;
                        msg2 = msg;
                        msg = inputmsg;
                    }
                    else if (msg3 != "" && msg2 != "" && msg != "")
                    {
                        i23 = i13;
                        i13 = i;
                        i = 0;
                        msg3 = msg2;
                        msg2 = msg;
                        msg = inputmsg;
                    }
                    else
                    {
                        i = 0;
                        msg = inputmsg;
                    }

                    qwin = false;
                }
            }




            //world2 yooo

            if (world2 == true)
            {
                do
                {

                    wpos1 = "_";
                    wpos2 = "_";
                    wpos3 = "_";
                    wpos4 = "_";
                    wpos5 = "_";
                    wpos6 = "_";
                    wpos7 = "_";             //  _
                    wpos8 = "_";             // / \
                    wpos9 = "_";             // |Q|
                    wpos10 = "_";


                    wpus = uskin;

                    if (posw == 1)
                    {
                        wpos1 = wpus;
                    }
                    else if (posw == 2)
                    {
                        wpos2 = wpus;
                    }
                    else if (posw == 3)
                    {
                        wpos3 = wpus;
                    }
                    else if (posw == 4)
                    {
                        wpos4 = wpus;
                    }
                    else if (posw == 5)
                    {
                        wpos5 = wpus;
                    }
                    else if (posw == 6)
                    {
                        wpos6 = wpus;
                    }
                    else if (posw == 7)
                    {
                        wpos7 = wpus;
                    }
                    else if (posw == 8)
                    {
                        wpos8 = wpus;
                    }
                    else if (posw == 9)
                    {
                        wpos9 = wpus;
                    }
                    else if (posw == 10)
                    {
                        wpos10 = wpus;
                    }


                    if (ismsg == false)
                    {
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("World 2");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}", wpos1, wpos2, wpos3, wpos4, wpos5, wpos6, wpos7, wpos8, wpos9, wpos10);
                    }
                    if (ismsg == true)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("World 2");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}", wpos1, wpos2, wpos3, wpos4, wpos5, wpos6, wpos7, wpos8, wpos9, wpos10);
                    }


                    ismsg = false;

                    while (Console.KeyAvailable == false)
                        Thread.Sleep(1); // Loop until input is entered.
                    cki = Console.ReadKey(true);
                    switch (cki.Key)
                    {
                        case ConsoleKey.RightArrow:
                            posw++;
                            break;
                        case ConsoleKey.LeftArrow:
                            posw--;
                            break;
                        case ConsoleKey.T:
                            input = Console.ReadLine();
                            if (input == "exit")
                            {
                                world2 = false;
                            }
                            else
                            {
                                Console.Clear();
                                ismsg = true;
                                Console.WriteLine("unknown command type 'exit' to exit the quest.");
                            }
                            break;

                    }
                } while (world2 == true);
            }









        } while (cki.Key != ConsoleKey.X);
        //ende und speichern (save end exit)
        //###################################
        // END AND SAVE
        // EXIT AND SAVE
        //###################################

        // Check if folder exists and if not, create it
        if (!Directory.Exists(chidraqulFolder))
        {
            Console.WriteLine("[-] chidraqul folder not found. Creating new...");
            Directory.CreateDirectory(chidraqulFolder);
        }
        else
        {
            Console.WriteLine("[+] chidraqul folder loaded.");
        }

        if (!Directory.Exists(chidraqul1Folder))
        {
            Console.WriteLine("[-] chidraqul1 folder not found. Creating new...");
            Directory.CreateDirectory(chidraqul1Folder);
        }
        else
        {
            Console.WriteLine("[+] chidraqul1 folder loaded.");
        }



        //Check if chidraqul folder exists
        if (File.Exists(savesPath))
        {
            Console.WriteLine("[+] saves.txt loaded.");
        }
        else
        {
            Console.WriteLine("[-] saves.txt not found. Creating new...");
        }

        //// Create a file to write to.
        //string TestText = "Hellu Wurld. ChillerDragon was here." + Environment.NewLine;
        //File.WriteAllText(savesPath, TestText);

        //// Open the file to read from.
        //string readText = File.ReadAllText(savesPath);

        //---SAVE STRINGS---
        int[] saves = new int[] { cookielvl, lvlcookies, cookiedelay, bhp, phpregen, hpregendelay, hpregenlvl, deaths, steps, xp, lvl, gold, cookies, neededxp, plusneededxp, php, pgold, plusgold, hp, pos, gdel, gres, item1anzahl, item2anzahl, item3anzahl, item4anzahl, pclvl };

        using (StreamWriter sw = new StreamWriter(savesPath))
        {
            foreach (int s in saves)
            {
                sw.WriteLine(s);
            }
        }

        //---SAVE INTEGERS---
        string[] saves2 = new string[] { uskin, skin, skin1, skin2, skin3, skin4, inv1, inv2, inv3, inv4};

        using (StreamWriter sw = new StreamWriter(saves2Path))
        {
            foreach (string s in saves2)
            {
                sw.WriteLine(s);
            }
        }

    }
    /*
    public static void OnTimedEvent(object source, ElapsedEventArgs e)
    {
        Console.WriteLine("Hello World!");
    }
    */
}


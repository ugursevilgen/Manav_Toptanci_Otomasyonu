using System.Collections;

namespace Manav_Toptancı_Otomasyonu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList toptanciMeyve = new ArrayList() { "ELMA", "ARMUT", "ÇİLEK" , "ŞEFTALİ", "MUZ" };
            ArrayList toptanciSebze = new ArrayList() { "DOMATES", "SALATALIK", "HAVUÇ","LİMON", "BİBER" };
            ArrayList manavmeyve = new ArrayList();
            ArrayList manavsebze = new ArrayList();
            ArrayList manavkilomeyve = new ArrayList();
            ArrayList manavkilosebze = new ArrayList();
            ArrayList musteri = new ArrayList();
            ArrayList musterikilo = new ArrayList();

            Console.WriteLine("*************HOŞGELDİNİZ**************\n");


            while (true)
            {
                while (true)
                {
                    Console.WriteLine("********MEYVE SEBZE HALİNE HOŞGELDİNİZ*********\n");
                    Console.WriteLine("Meyve için -M- Sebze için -S- ye basınız?");
                    string halSecim = Console.ReadLine().ToUpper();

                    if (halSecim == "M")
                    {
                        Console.WriteLine("*\n");
                        foreach (var item in toptanciMeyve)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n*");

                        Console.WriteLine("Hangi üründen almak istersiniz?");
                        string manavAlisveris = Console.ReadLine().ToUpper();

                        if (toptanciMeyve.IndexOf(manavAlisveris) >= 0)
                        {
                            Console.Write("\nKaç kilo almak istersiniz?");
                            int alisveriskilo = Convert.ToInt32(Console.ReadLine());

                            if (manavmeyve.IndexOf(manavAlisveris) >= 0)
                            {
                                manavkilomeyve[manavmeyve.IndexOf(manavAlisveris)] = (int)manavkilomeyve[manavmeyve.IndexOf(manavAlisveris)] + alisveriskilo;

                                string cevap = BaskaArzunuz();

                                if (cevap == "E")
                                {
                                    continue;

                                    
                                }
                                else if (cevap == "H")
                                {
                                    break;
                                }

                            }

                            else
                            {
                                manavmeyve.Add(manavAlisveris);
                                manavkilomeyve.Add(alisveriskilo);

                                string cevap = BaskaArzunuz();

                                if (cevap == "E")
                                {
                                    continue;

                                }
                                else if (cevap == "H")
                                {
                                    break;
                                }
                            }

                        }
                        else
                        {
                            Console.WriteLine("Maalesef" + manavAlisveris + " tükenmiştir.");
                            string cevap = BaskaArzunuz();


                            if (cevap == "E")
                            {
                                continue;


                            }
                            else if (cevap == "H")
                            {
                                break;
                            }
                        }




                    }
                    else if (halSecim == "S")
                    {
                        Console.WriteLine("*\n");
                        foreach (var item in toptanciSebze)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("\n*");

                        Console.WriteLine("Hangi üründen almak istersiniz?");
                        string manavAlisveris = Console.ReadLine().ToUpper();


                        if (toptanciSebze.IndexOf(manavAlisveris) >= 0)
                        {
                            Console.Write("\nKaç kilo almak istiyorsunuz ?  >>>=  ");
                            int alisveriskilo = Convert.ToInt32(Console.ReadLine());

                            if (manavsebze.IndexOf(manavAlisveris) >= 0)
                            {
                                manavkilosebze[manavsebze.IndexOf(manavAlisveris)] = (int)manavkilosebze[manavsebze.IndexOf(manavAlisveris)] + alisveriskilo;
                                string cevap = BaskaArzunuz(); 

                                if (cevap == "E")
                                {
                                    continue;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            else
                            {
                                manavsebze.Add(manavAlisveris);
                                manavkilosebze.Add(alisveriskilo);

                                string cevap = BaskaArzunuz();

                                if (cevap == "E")
                                {
                                    continue;


                                }
                                else if (cevap == "H")
                                {
                                    break;
                                }
                            }

                        }
                        else
                        {
                            Console.WriteLine("Maalesef" + manavAlisveris + " tükenmiştir.");

                            string cevap = BaskaArzunuz();
                            if (cevap == "E")
                            {
                                continue;


                            }
                            else if (cevap == "H")
                            {
                                break;
                            }
                        }

                    }

                }
                while (true)
                {
                    Console.WriteLine("-----------------------------------------------------");
                    Console.WriteLine("\n********************MANAVA HOŞGELDİNİZ*******************");

                    Console.WriteLine("Meyve için M Sebze için S ye basınız?");
                    string manavsecim = Console.ReadLine().ToUpper();

                    if (manavsecim == "M")
                    {
                        Console.WriteLine("*\n");
                        foreach (var item in manavmeyve)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("*\n");

                        Console.WriteLine("Hangi üründen almak istersiniz?");
                        string kiloilemanav = Console.ReadLine().ToUpper();

                        int istek = manavmeyve.IndexOf(kiloilemanav);

                        if (istek >= 0)
                        {
                            Console.WriteLine("\nKaç kilo almak istiyorsunuz?");
                            int kilo = Convert.ToInt32(Console.ReadLine());
                            if (kilo <= (int)manavkilomeyve[istek])
                            {
                                if (musteri.IndexOf(kiloilemanav) >= 0)
                                {
                                    musterikilo[musteri.IndexOf(kiloilemanav)] = (int)musterikilo[musteri.IndexOf(kiloilemanav)] + kilo;
                                    manavkilomeyve[istek] = (int)manavkilomeyve[istek] - kilo;

                                    if ((int)manavkilomeyve[istek] == 0)
                                    {
                                        manavmeyve.Remove(manavmeyve[istek]);
                                    }

                                    string cevap = BaskaArzunuz();

                                    if (cevap == "E")
                                    {
                                        continue;


                                    }
                                    else if (cevap == "H")
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    musteri.Add(manavmeyve[istek]);
                                    musterikilo.Add(kilo);

                                    manavkilomeyve[istek] = (int)manavkilomeyve[istek] - kilo;
                                    if ((int)manavkilomeyve[istek] == 0)
                                    {
                                        manavmeyve.Remove(manavmeyve[istek]);
                                    }
                                    string cevap = BaskaArzunuz();

                                    if (cevap == "E")
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Maalesef elimizde " + (int)manavkilomeyve[istek] + " Kilo Kaldı");

                                string cevap = BaskaArzunuz();

                                if (cevap == "E")
                                {
                                    continue;


                                }
                                else if (cevap == "H")
                                {
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Maalesef ürün tükenmiştir.");

                            string cevap = BaskaArzunuz();

                            if (cevap == "E")
                            {
                                continue;


                            }
                            else if (cevap == "H")
                            {
                                break;
                            }
                        }

                    }
                    else if (manavsecim == "S")
                    {
                        foreach (var item in manavsebze)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("---------------------------------------------------");
                        Console.WriteLine("Hangi Üründen amak istiyorsunuz?");
                        string kiloilemanav = Console.ReadLine().ToUpper();
                        int istek = manavsebze.IndexOf(kiloilemanav);
                        if (istek >= 0)
                        {
                            Console.WriteLine("\nKaç kilo almak istiyorsunuz?");
                            int kilo = Convert.ToInt32(Console.ReadLine());
                            if (kilo <= (int)manavkilosebze[istek])
                            {
                                if (musteri.IndexOf(kiloilemanav) >= 0)
                                {
                                    musterikilo[musteri.IndexOf(kiloilemanav)] = (int)musterikilo[musteri.IndexOf(kiloilemanav)] + kilo;
                                    manavkilosebze[istek] = (int)manavkilosebze[istek] - kilo;
                                    if ((int)manavkilosebze[istek] == 0)
                                    {
                                        manavsebze.Remove(manavsebze[istek]);
                                    }
                                    string cevap = BaskaArzunuz();

                                    if (cevap == "E")
                                    {
                                        continue;


                                    }
                                    else if (cevap == "H")
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    musteri.Add(manavsebze[istek]);
                                    musterikilo.Add(kilo);

                                    manavkilosebze[istek] = (int)manavkilosebze[istek] - kilo;
                                    if ((int)manavkilosebze[istek] == 0)
                                    {
                                        manavsebze.Remove(manavsebze[istek]);
                                    }
                                    string cevap = BaskaArzunuz();

                                    if (cevap == "E")
                                    {
                                        continue;


                                    }
                                    else if (cevap == "H")
                                    {
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Maalesef elimizde " + (int)manavkilosebze[istek] + " kilo Kaldı");
                                string cevap = BaskaArzunuz();

                                if (cevap == "E")
                                {
                                    continue;


                                }
                                else if (cevap == "H")
                                {
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Maalesef ürün tükenmiştir.");
                            string cevap = BaskaArzunuz();

                            if (cevap == "E")
                            {
                                continue;


                            }
                            else if (cevap == "H")
                            {
                                break;
                            }
                        }
                    }
                }
                while (true)
                {
                    Console.WriteLine("*\n");
                    Console.WriteLine("MÜŞTERİ LİSTESİ\n");

                    for (int i = 0; i < musteri.Count; i++)
                    {
                        Console.WriteLine(musteri[i] + "---" + musterikilo[i] + " kilo");
                    }
                    break;
                }
                break;
            }


            Console.ReadLine();


            static string BaskaArzunuz()
            {

                Console.WriteLine("\nBaşka bir arzunuz var mı? Evet E veya Hayır H");
                string cevap = Console.ReadLine().ToUpper();


                return cevap;
            }


        }
    }
}


using System.Collections;
namespace ToDo
{
    
        public class Board /* Yapılacak, yapılan ve yapılmış görev kartlarını liste yapısı ile içeren sınıfımız. Ayrıca bu kartları silebilen, 
                    yeni kartlar ekleyip, kartları 3 başlıkta listeleyebilen ve taşıyabilen metotları içeriyor.*/
    {
        
        // Board 3 tane kolona sahiptir ve bunları Kart nesnelerini alan listede tutuyorum.
        
        
        
        public void KartListele(List<Kart> TODO_LIST, List<Kart> INRPOGRESS_LIST, List<Kart> DONE_LIST)
            {
        foreach (var item in TODO_LIST)
        {
            Console.WriteLine("TODO LINE\n*******************************************");
            Console.WriteLine($"Başlık:{item.Baslık}");
            Console.WriteLine($"İçerik:{item.Icerik}");
            Console.WriteLine($"Atanan Kişi:{item.AtananKisi}");
            Console.WriteLine($"Büyüklük:{item.buyukluk}");
        }
        foreach (var item in INRPOGRESS_LIST)
        {
            Console.WriteLine("IN PROGRESS LINE\n*******************************************");
            Console.WriteLine($"Başlık:{item.Baslık}");
            Console.WriteLine($"İçerik:{item.Icerik}");
            Console.WriteLine($"Atanan Kişi:{item.AtananKisi}");
            Console.WriteLine($"Büyüklük:{item.buyukluk}");
        }
        foreach (var item in DONE_LIST)
        {
            Console.WriteLine("DONE LIST\n*******************************************");
            Console.WriteLine($"Başlık:{item.Baslık}");
            Console.WriteLine($"İçerik:{item.Icerik}");
            Console.WriteLine($"Atanan Kişi:{item.AtananKisi}");
            Console.WriteLine($"Büyüklük:{item.buyukluk}");
        }
            
            }
        public void KartEkleme(List<Kart> TODO_List, Dictionary<int, string> Takım) //Kartları TODO listesine ekleyen metod. 
        //              todo'ya eklemek için ve takım üyelerine erişmek için mezkur parametreleri alıyor.
        {
        Console.Write("Başlık giriniz                  :");
        string input_baslik= Console.ReadLine();
        Console.Write("İçerik giriniz                  :");
        string input_icerik= Console.ReadLine();
        Console.Write("Büyüklük seçiniz                : ");
        int input_buyukluk= int.Parse(Console.ReadLine());
        Console.Write("Kişi seçiniz(ID)                : ");
        int input_KisiID=int.Parse(Console.ReadLine());
        if(Takım.ContainsKey(input_KisiID) && input_buyukluk>0 && input_buyukluk<5) // Anahtar eğer uyuşmazsa hata mesajı dönecek.
        {
            TODO_List.Add(new Kart(input_baslik,input_icerik,Takım[input_KisiID],(Kart.Buyukluk)input_buyukluk));
        }
        else
        {
            Console.WriteLine("Hatali giriş yaptınız");
        }
        
        }
        public void KartSilme(List<Kart> TODO_LIST, List<Kart> INRPOGRESS_LIST, List<Kart> DONE_LIST)
        {
            Console.WriteLine("Lütfen silmek istediğiniz kartın başlığını giriniz:");
            string input=Console.ReadLine();
            int sayac=0;
            foreach (var item in TODO_LIST.ToArray())
            {
                if (item.Baslık==input)
                {
                    TODO_LIST.Remove(item);
                    sayac++;
                }
            }
            foreach (var item in INRPOGRESS_LIST.ToArray())
            {
                if (item.Baslık==input)
                {
                    TODO_LIST.Remove(item);
                    sayac++;
                }
            }
            foreach (var item in DONE_LIST.ToArray())
            {
                if (item.Baslık==input)
                {
                    TODO_LIST.Remove(item);
                    sayac++;
                }
            }
            if (sayac==0)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine(" * Silmeyi sonlandırmak için : (1)\n* Yeniden denemek için : (2)");
                int islem= int.Parse(Console.ReadLine());
                if (islem==1)
                {
                   Console.WriteLine("Kart silme işlemi başarıyla sonlandırıldı.");
                }else if (islem==2)
                {
                    KartSilme(TODO_LIST, INRPOGRESS_LIST, DONE_LIST);
                }else 
                {
                    Console.WriteLine("Geçersiz bir değer girdiniz.");
                }
            }
            

        }    
        
        public void KartTasima(List<Kart> TODO_LIST, List<Kart> INRPOGRESS_LIST, List<Kart> DONE_LIST)
        {
            int tasima=0;
            Console.WriteLine("Lütfen taşımak istediğiniz kartın başlığını giriniz:");
            string input= Console.ReadLine();
            foreach (var item in TODO_LIST.ToArray())
            {
                if (item.Baslık==input)
                {
                    Console.WriteLine("Bulunan Kart bilgileri \n*******************************************");
                    Console.WriteLine($"Başlık               :{item.Baslık}");
                    Console.WriteLine($"İçerik               :{item.Icerik}");
                    Console.WriteLine($"Atanan Kişi          :{item.AtananKisi}");
                    Console.WriteLine($"Büyüklük             :{(Kart.Buyukluk)item.buyukluk}");
                    Console.WriteLine($"Line                 :TODO LIST");
                    tasima++;
                    Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:\n(1) TODO\n(2) IN PROGRESS\n(3) DONE");
                    int tasinacakYer=int.Parse(Console.ReadLine());
                    
                    if (tasinacakYer==1)
                    {
                        // AYNI YERE KART TAŞINMAYACAĞI İÇİN KODU BOŞ BIRAKTIM.
                    }
                    else if (tasinacakYer==2)
                    {
                        TODO_LIST.Remove(item);
                        INRPOGRESS_LIST.Add(item);
                    }
                    else if (tasinacakYer==3)
                    {
                        TODO_LIST.Remove(item);
                        DONE_LIST.Add(item);

                    }
                    else
                    {
                        Console.WriteLine("Hatalı giriş yaptınız!");
                    }
                }
            }
            if (tasima==0)
            {
                foreach (var item in INRPOGRESS_LIST.ToArray())
                {
                    if (item.Baslık==input)
                    {
                    Console.WriteLine("Bulunan Kart bilgileri \n*******************************************");
                    Console.WriteLine($"Başlık               :{item.Baslık}");
                    Console.WriteLine($"İçerik               :{item.Icerik}");
                    Console.WriteLine($"Atanan Kişi          :{item.AtananKisi}");
                    Console.WriteLine($"Büyüklük             :{(Kart.Buyukluk)item.buyukluk}");
                    Console.WriteLine($"Line                 :IN RPOGRESS LIST");
                    tasima++;
                    Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:\n(1) TODO\n(2) IN PROGRESS\n(3) DONE");
                    int tasinacakYer=int.Parse(Console.ReadLine());
                    
                        if (tasinacakYer==1)
                        {
                           INRPOGRESS_LIST.Remove(item);
                           TODO_LIST.Add(item);
                        }
                        else if (tasinacakYer==2)
                        {
                            // AYNI YERE KART TAŞINMAYACAĞI İÇİN KODU BOŞ BIRAKTIM.
                        }
                        else if (tasinacakYer==3)
                        {
                            INRPOGRESS_LIST.Remove(item);
                            DONE_LIST.Add(item);

                        }
                        else
                        {
                            Console.WriteLine("Hatalı giriş yaptınız!");
                        }
                    }
                }
            }
            if (tasima==0)
                {
               foreach (var item in DONE_LIST.ToArray())
                {
                    if (item.Baslık==input)
                    {
                        tasima++;
                        Console.WriteLine("Bulunan Kart bilgileri \n*******************************************");
                        Console.WriteLine($"Başlık               :{item.Baslık}");
                        Console.WriteLine($"İçerik               :{item.Icerik}");
                        Console.WriteLine($"Atanan Kişi          :{item.AtananKisi}");
                        Console.WriteLine($"Büyüklük             :{(Kart.Buyukluk)item.buyukluk}");
                        Console.WriteLine($"Line                 :DONE LIST");
                        Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz:\n(1) TODO\n(2) IN PROGRESS\n(3) DONE");
                        int tasinacakYer=int.Parse(Console.ReadLine());

                            if (tasinacakYer==1)
                            {
                                DONE_LIST.Remove(item);
                                TODO_LIST.Add(item);
                            }else if (tasinacakYer==2)
                            {
                                DONE_LIST.Remove(item);
                                INRPOGRESS_LIST.Add(item);
                            }else if (tasinacakYer==3)
                            {
                                // AYNI YERE KART TAŞINMAYACAĞI İÇİN KODU BOŞ BIRAKTIM.
                            }else
                            {
                                Console.WriteLine("Hatalı giriş yaptınız!");
                            }

                    }
                } 
            }
            else if (tasima==0) //taşıma hala 0 ise, kart bulunamamış demektir.
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız");
                Console.WriteLine("* İşlemi sonlandırmak için : (1)\n* Yeniden denemek için : (2)");
                int islem= int.Parse(Console.ReadLine());
                    if (islem==1)
                    {
                    Console.WriteLine("Kart taşıma işlemi başarıyla sonlandırıldı.");                    
                    }else if (islem==2)
                    {
                    KartTasima(TODO_LIST,INRPOGRESS_LIST,DONE_LIST);                    
                    }
            }


            
            }

    
    }

}

    
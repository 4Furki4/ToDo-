using System.Collections;
namespace ToDo
{
    
        public class Board /* Yapılacak, yapılan ve yapılmış görev kartlarını liste yapısı ile içeren sınıfımız. Ayrıca bu kartları silebilen, 
                    yeni kartlar ekleyip, kartları 3 başlıkta listeleyebilen ve taşıyabilen metotları içeriyor.*/
        {
        
        // Board 3 tane kolona sahiptir ve bunları Kart nesnelerini alan listede tutuyorum.
        List<Kart> TODO= new List<Kart>(); 
        List<Kart> INPROGRESS= new List<Kart>();
        List<Kart> DONE= new List<Kart>();
        public Board()
        {  // 3 tane varsayılan kartımız.
            TODO.Add(new Kart("Temizlik","Tuvaleti silmek", "Furkan",Kart.Buyukluk.XL));
            DONE.Add(new Kart("Mutfak","Yemek yapmak", "Furkan",Kart.Buyukluk.M));
            INPROGRESS.Add(new Kart("Alışveriş","Ekmek almak", "Esat",Kart.Buyukluk.XS));
        }
        
        void KartListele(List<Kart> TODO_LIST, List<Kart> INRPOGRESS_LIST, List<Kart> DONE_LIST)
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
        void KartEkleme(List<Kart> TODO_List, Dictionary<int, string> Takım) //Kartları TODO listesine ekleyen metod. 
        //              todo'ya eklemek için ve takım üyelerine erişmek için mezkur parametreleri alıyor.
        {
        Console.WriteLine("Başlık giriniz                  :");
        string input_baslik= Console.ReadLine();
        Console.WriteLine("İçerik giriniz                  :");
        string input_icerik= Console.ReadLine();
        Console.WriteLine("Büyüklük seçiniz                : ");
        int input_buyukluk= int.Parse(Console.ReadLine());
        Console.WriteLine("Kişi seçiniz(ID)                : ");
        int input_KisiID=int.Parse(Console.ReadLine());
        if(Takım.ContainsKey(input_KisiID) && input_buyukluk>0 && input_buyukluk<5) // Anahtar eğer uyuşmazsa hata mesajı dönecek.
        {
            TODO_List.Add(new Kart(input_baslik,input_icerik,Takım[input_KisiID],(Kart.Buyukluk)input_buyukluk));
        }
        else
        {
            Console.WriteLine("Hatali giriş yaptınız");
        }
        void KartSilme()
        {
            
        }
            

    }
}
}

    
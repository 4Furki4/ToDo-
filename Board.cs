using System.Collections;
namespace ToDo
{
    
        class Board /* Yapılacak, yapılan ve yapılmış görev kartlarını liste yapısı ile içeren sınıfımız. Ayrıca bu kartları silebilen, 
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
        void KartSilme(List<Kart> list)
        {
        Console.WriteLine();

        }

    }
}

    
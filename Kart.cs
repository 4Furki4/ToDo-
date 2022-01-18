namespace ToDo
{
       class Kart

    {
            public enum Buyukluk // Kart büyüklükleri için kullanılacak enum.
        {
            XS=1, S=2, M=2, L=3, XL=4
        }
        // Kartımızın propertyleri
        private string baslık; // Kartımızın özellikleri
        string icerik;
        string atananKisi;
         
            public string Baslık{get; set;}
        
        public string Icerik{get; set;}
        
        public string AtananKisi{get; set;}

        public Buyukluk buyukluk{get; set;} //enumuzu yukarda Büyüklük ismiyle oluşturdum ve onun tipinde kart büyüklüğünü karşılayacak property

        public Kart(string baslik, string icerik, string atananKisi, Buyukluk boyut) // Constructor metodumuz.
        {
            Baslık= baslik;
            Icerik=icerik;
            AtananKisi=atananKisi;
            buyukluk=boyut;
        }
    } 
}

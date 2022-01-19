using System.Collections.Generic;
using System;
namespace ToDo
{
    class Program
    {
       static void Main(string[] args)
       {
           // See https://aka.ms/new-console-template for more information

    
// varsayılan olarak eklenmiş kişiler:
Dictionary<int,string> TakımUyeleri= new Dictionary<int, string>();
TakımUyeleri.Add(1,"Furkan");
TakımUyeleri.Add(2,"Saliha");
TakımUyeleri.Add(3,"Aybüke");
TakımUyeleri.Add(4,"Esat");

Board board= new Board();
        List<Kart> TODO= new List<Kart>(); 
        List<Kart> INPROGRESS= new List<Kart>();
        List<Kart> DONE= new List<Kart>();
            TODO.Add(new Kart("Temizlik","Tuvaleti silmek", "Furkan",Kart.Buyukluk.XL));
            DONE.Add(new Kart("Mutfak","Yemek yapmak", "Furkan",Kart.Buyukluk.M));
            INPROGRESS.Add(new Kart("Alışveriş","Ekmek almak", "Esat",Kart.Buyukluk.XS));


void Taslak_yazıcı() // ekrana, ToDo uygulaması başladığında yazılacak mesajı barındıran metot.
{
    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) \n*******************************************");
    Console.WriteLine("(1) Board Listelemek\n(2) Board'a Kart Eklemek\n(3) Board'dan Kart Silmek\n(4) Kart Taşımak");
}
void IslemSecici() // Konsoldan alınan girdiye göre işlemleri başlatacak, hatalı girişlerde tekrardan giriş isteyecek metot.
{
int islem =0;
int KonsolKapatıcı=0;
while(KonsolKapatıcı!=6)
{   //İşlemleri konsoldan girilen veriye bağlı olarak başlatan if-else yapısı. sonlarına break yazdım ve bu şekilde sonsuz döngüyü engelledim.
switch (islem)
    {
    case 1:
    board.KartListele(TODO,INPROGRESS,DONE);
    //KonsolIslemcisi metodunu her birinde islemleri yaptıktan sonra çağırarak mezkur işlem yapıldıktan sonra yeni işlem yapabilmeyi veya rehberi kapatmayı sağladım.
    IslemSecici();
    break;
    case 2:
    board.KartEkleme(TODO,TakımUyeleri);
    IslemSecici();
    break;
    case 3:
    board.KartSilme(TODO,INPROGRESS,DONE);
    IslemSecici();
    break;
    case 4:
    board.KartTasima(TODO,INPROGRESS,DONE)
    IslemSecici();
    break;
    case 5:
    KonsolKapatıcı=6; 
    Console.WriteLine("Console'dan başarılı bir şekilde çıkış yapıldı, yine bekleriz :=)"); 
    break; 
    }    
            if(islem<1 || islem>5)
            {
                Console.WriteLine("Lütfen 1-5 arası bir rakam girdiğinizden emin olunuz.\n");
                Taslak_yazıcı();
                if(int.TryParse(Console.ReadLine(), out int TryParsedIslem)) /* Konsola girilen verinin istediğimiz tipte (integer) olup olmadığını kontrol ediyor. 
                                    Söz gelimi bir metin girilirse hem hatayı algılıyor hem mesaj yazdırıyor hem de istenilen işlemi yapma sürecini devam ettiriyorum. */
                {
                    islem =TryParsedIslem;
                }else
                {
                    Console.WriteLine("Lütfen 1-5 arası rakam girdiğinizden emin olunuz.\n");
                    Taslak_yazıcı();
                    IslemSecici(); // Tekrardan aynı işlemleri ekrana yazdırıp girdi almak için metodumuzu geri çağırdım.
                }

                continue; // sonsuz döngü olmaması için continue yazmak zorundayım.

            }
}
}
       }
    }
}


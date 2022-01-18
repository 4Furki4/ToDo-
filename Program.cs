// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
    
// varsayılan olarak eklenmiş kişiler:
Dictionary<int,string> TakımUyeleri= new Dictionary<int, string>();
TakımUyeleri.Add(1,"Furkan");
TakımUyeleri.Add(2,"Saliha");
TakımUyeleri.Add(3,"Aybüke");
TakımUyeleri.Add(4,"Esat");

void Taslak_yazıcı() // ekrana, ToDo uygulaması başladığında yazılacak mesajı barındıran metot.
{
    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) \n*******************************************");
    Console.WriteLine("(1) Board Listelemek\n(2) Board'a Kart Eklemek\n(3) Board'dan Kart Silmek\n(4) Kart Taşımak");
}
void IslemSecici() // Konsoldan alınan girdiye göre işlemleri başlatacak, hatalı girişlerde tekrardan giriş isteyecek metot.
{

}
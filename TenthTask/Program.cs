/*
Tegin nii, et hinnet saab kirjutada suure ja väikse tähega, et programm oleks lollikindlam. 
Ei tea, kas ülesandes pidi suur täht olema ainuke viis, kuidas hinnet sisestada,
aga seda oleks lihtne parandada, eemaldades ".ToLower()" kaheksandalt realt ja muutes switch lülitise case'is [väikse tähe suureks]. <- kirjutasin testis kogemata valesti, märkasin pärast saatmist
*/

Console.WriteLine("Mis hinde said?");
char hinne = Convert.ToChar(Console.ReadLine().ToLower());

switch(hinne)
{
    case 'a':
        Console.WriteLine("Suurepärane!");
        break;
    case 'b':
        Console.WriteLine("Väga hea!");
        break;
    case 'c':
        Console.WriteLine("Hea!");
        break;
    case 'd':
        Console.WriteLine("Rahuldav");
        break;
    case 'e':
        Console.WriteLine("Kasin");
        break;
    case 'f':
        Console.WriteLine("Puudulik");
        break;
    default:
        Console.WriteLine("Vale väärtus");
        break;
}
/*
Tegin nii, et hinnet saab kirjutada suure ja väikse tähega, et programm oleks lollikindlam. 
Ei tea, kas ülesandes pidi suur täht olema ainuke viis, kuidas hinnet sisestada,
aga seda oleks lihtne parandada, eemaldades ".ToLower()" kaheksandalt realt ja muutes if-lausetes [väikse tähe suureks]. <- kirjutasin testis kogemata valesti, märkasin pärast saatmist
*/

Console.WriteLine("Mis hinde said?");
char hinne = Convert.ToChar(Console.ReadLine().ToLower());

if (hinne == 'a')
{
    Console.WriteLine("Suurepärane!");
}
else if (hinne == 'b')
{
    Console.WriteLine("Väga hea!");
}
else if (hinne == 'c')
{
    Console.WriteLine("Hea!");
}
else if (hinne == 'd')
{
    Console.WriteLine("Rahuldav");
}
else if (hinne == 'e')
{
    Console.WriteLine("Kasin");
}
else if (hinne == 'f')
{
    Console.WriteLine("Puudulik");
}
else
{
    Console.WriteLine("Vale väärtus");
}
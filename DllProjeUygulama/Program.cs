

using System;
using DllProjeUygulama;
using MyFakeData;

List<Personel> Perlist = new List<Personel>();


//while (Console.ReadKey(true).KeyChar == 'q')
//{
//    for (int i = 1; i < 21; i++)
//    {

//        Personel personel = new Personel();

//        personel.Ad = MyFakeData.NameData.GetFirstName();
//        personel.Soyad = MyFakeData.NameData.GetLastName();
//        personel.Sehir = MyFakeData.PlaceData.GetCountryName();

//        Perlist.Add(personel);
//    }

//    int k = 1;
//    foreach (var item in Perlist)
//        Console.WriteLine($"{k++} {item.Ad} {item.Soyad} {item.Sehir}");
//}

do
{
    Perlist.Clear();
    for (int i = 1; i < 21; i++)
    {


        Personel personel = new Personel();

        personel.Ad = MyFakeData.NameData.GetFirstName();
        personel.Soyad = MyFakeData.NameData.GetLastName();
        personel.Sehir = MyFakeData.PlaceData.GetCountryName();

        Perlist.Add(personel);
    }

    int k = 1;
    foreach (var item in Perlist)
        Console.WriteLine($"{k++} {item.Ad} {item.Soyad} {item.Sehir}");
    Console.WriteLine();

} while (Console.ReadKey(true).KeyChar != 'q');
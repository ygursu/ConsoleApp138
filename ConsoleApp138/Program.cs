double fiyat = 0;
int adet = 0;
Console.Write("Ürünün fiyatını giriniz:");

OkuFiyat:
fiyat = Convert.ToDouble(Console.ReadLine());

if (fiyat <= 0)
{
    Console.Write("Yanlış fiyat bilgisi girdiniz.\nFiyatı tekrardan giriniz:");
    goto OkuFiyat;
}


Console.Write("Aldığınız ürün miktarını giriniz:");

OkuAdet:
adet = Convert.ToInt32(Console.ReadLine());

if (adet <= 0)
{
    Console.Write("Yanlış miktar bilgisi girdiniz.\nAldığınız ürün miktarını tekrardan giriniz:");
    goto OkuAdet;
}

double tutar = fiyat * adet;
Console.WriteLine("Ödeyeceğiniz toplam tutar {0}TL", tutar);
Console.ReadKey();
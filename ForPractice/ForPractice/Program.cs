

/*

for (int i = 1; i < 10; i++)                        Ekrana 10 kere Kendime inanıyorum yazdıran program. 
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim. ");
}

 */

/*

for(int i = 1; i <= 20; i++)                        1 den 20 ye kadar olan sayıları ekrana yazdıran program.
{
    Console.WriteLine($"{i}");
}

 */

/*

for(int i = 1; i <= 20; i++)         1 den 20 ye kadar olan çift sayıları ekrana yazdırma programı. 
{
    if (i % 2 == 0)
    {

        Console.WriteLine($"{i}");
    }
}

*/

/*

int toplam = 0;                         50 den 150 ye kadar olan sayıların toplamını ekrana yazdırma programı. 
for(int i = 50;  i <= 150; i++)
{
    toplam += i;
    
}
Console.WriteLine($"50 ile 150 arasındaki sayıların toplamı {toplam}");

 */


int tekSayilarToplami = 0; // 1 den 120 ye kadar olan çift ve tek sayıların toplamını ekrana yazdırdan program. 
int ciftSayilarToplami = 0;


for(int i = 1;  i <= 120; i++)
{
    if (i % 2 == 0)
    {
        ciftSayilarToplami += i;
    }
    else 
    {
        tekSayilarToplami += i;
      
    }
    
}
Console.WriteLine($"1 den 120 ye kadar olan Çift sayıların toplamı : {ciftSayilarToplami}");
Console.WriteLine($"1 de 120 ye kadar olan Tek sayılar toplamı : {tekSayilarToplami}");


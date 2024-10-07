
int limit = int.Parse(Console.ReadLine());
int sayac = 0;

/////////////// Do - While ///////////////

do
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayac++;

}while(sayac <= limit);

/////////////// While ///////////////

while (sayac <= limit)
{
    Console.WriteLine();
    sayac++;
}

// while döngüsünde koşul baştan kontrol edilir. Eğer başlangıç koşulu sağlanmıyorsa döngüye hiç girilmez.
// Örneğin, limit -5 olduğunda while döngüsü hiç çalışmaz.

// do-while döngüsünde ise koşul döngünün sonunda kontrol edilir. Bu nedenle, koşul yanlış olsa bile döngü en az bir kez çalışır.
// Örneğin, limit -5 olsa bile do-while döngüsü bir kez çalışır ve ekrana "Ben bir Patika'lıyım" yazdırır.
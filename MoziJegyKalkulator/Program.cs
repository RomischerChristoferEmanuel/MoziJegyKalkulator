string nev = "Nagy Zsófia";
int kor = 19;
bool diak = false;
double mozj = 2800;
double dbsz = 3;
double pop = 1400;
double kedvezmeny = 0.20;
if ((kor <= 18) & (diak=true))
{
    double ar = mozj + (pop * dbsz);
    double vegar = ar / 100 * kedvezmeny;

}
Console.WriteLine($"Vásárló neve: {nev}  ({kor})");
Console.WriteLine($"Rendelés 1db Mozijegy + {dbsz} db Popcorn");

if (diak = true)
{
    Console.WriteLine($"Alapösszeg {mozj + (pop * dbsz)} Ft");
    Console.WriteLine($"Fizetendő összeg: {mozj + (pop * dbsz) / 100 * kedvezmeny}");
    Console.WriteLine("20% kedvezmény érvényesítve!");
}

if (diak = false)
{
    Console.WriteLine($"Alapösszeg {mozj + (pop * dbsz)} Ft");
    Console.WriteLine($"Fizetendő összeg: {mozj + (pop * dbsz)}");
    Console.WriteLine("20% kedvezmény nincs!");
}
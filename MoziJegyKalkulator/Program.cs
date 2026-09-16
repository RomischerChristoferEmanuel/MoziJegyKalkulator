string nev = "Nagy Zsófia";
int kor = 16;
bool diak = true;
double mozj = 2800;
double dbsz = 3;
double pop = 1400;
float kedvezmeny = 0.20;
if ((kor <= 18) & (diak=true))
{
    double ar = mozj + (pop * dbsz);
    double vegar = ar / 100 * kedvezmeny;

}
Console.WriteLine($"Vásárló neve: {nev}  ({kor})");
Console.WriteLine($"Rendelés 1db Mozijegy + {dbsz} db Popcorn");
Console.WriteLine($"Alapösszeg {mozj + (pop * dbsz)} Ft");
Console.WriteLine($"Fizetendő összeg: {mozj + (pop * dbsz) /100 * kedvezmeny}");
if (diak = true)
{
    Console.WriteLine("20% kedvezmény érvényesítve!");
}
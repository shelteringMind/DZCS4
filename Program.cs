//*/
//Задача 25
const int basePower = 0;
const int indexPower = 1;
int[] power = new int[2];

int[] GetNumbers()
{
Console.WriteLine("Введите основание степени: ");
power[basePower] = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите показатель степени: ");
power[indexPower] = int.Parse(Console.ReadLine()!);
return power;
}

double pow(int[] arrayPow)
{
    double result = 1;
    for(int i=0;i<Math.Abs(arrayPow[indexPower]);i++) {
        result *= arrayPow[basePower];
        }
    if(arrayPow[indexPower]>0) {
        return result;
    } else return 1/result;
}

double res = pow(GetNumbers());
Console.WriteLine($"Степень числа с основанием {power[basePower]} и показателем {power[indexPower]} равна: {res}");
//*/
/*/
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

/*/
//Задача 27
string GetNumbers()
{
Console.WriteLine("Введите число: ");
return Console.ReadLine()!;
}

int SumDigit(string num)
{
    int result = 0;
    int iter = 0;
    int numLength = num.Length;

    if (num[0] == '-') {
        iter = 1;
        numLength--;
    }

    for(;iter<num.Length;iter++) {
        result += (int)Char.GetNumericValue(num[iter]);
        }

    return result;
}

int res = SumDigit(GetNumbers());
Console.WriteLine($"Сумма цифр в числе равна: {res}");
//*/

/*/
//Задача 29
int[] RandArray(int size)
{
    int[] array = new int[size];
    for(int i=0;i<size;i++) {
        array[i] = new Random().Next(0,1001);
    }
    return array;
}

int size=8;
int[] a=RandArray(size);
Console.WriteLine($"[{String.Join(", ",a)}]");
//*/
// Комбенированное задание
Console.Clear();
int? max = null;
int? min = null;
int num;
int q = 0;
int cpi = 0;
Random rnd = new Random();
bool r = true;

//Вносим или генерируем числа, после чего определяем максимальное из них
while(r){
    Console.Write("Введите число или rnd");

    if (max is not null){
        Console.Write(", min или max: ");
    }else{
        Console.Write(": ");
    }

    string str = Console.ReadLine();

    if (int.TryParse(str, out num)){
        if(max == null|min == null){
            max = num;
            min = num;
        }
        max=Math.Max(Convert.ToInt32(max),num);
        min=Math.Min(Convert.ToInt32(min),num);
    }else if(str=="max"|str=="min"){
        if(max == null){
            Console.Write("Ни одно число не введено - ");
        }else{
            if(str=="max"){
                q = Convert.ToInt32(max);
                Console.Write($"Максимальное число: ");
            }else if(str=="min"){
                q = Convert.ToInt32(min);
                Console.Write($"Минимальное число: ");
            }
            r=false;
        }
    }else if (str=="rnd"){
        num = rnd.Next(0,1000);
        Console.WriteLine($"Сгенерировано число: {num}");
        
        if(max is null){
            max = num;
            min = num;
        }
        max=Math.Max(Convert.ToInt32(max),num);
        min=Math.Min(Convert.ToInt32(min),num);
    }else{
        Console.WriteLine("Введено неверное значение, попробуйте еще раз");
    }
    //Количество положительных чисел dz6
    if(num>0){
        cpi++;
    }
}
num=q;
int n = Convert.ToInt32(Math.Ceiling(Math.Log10(Convert.ToDouble(num)))); //Количество цифр в числе
Console.WriteLine($"{num}");

//Определяем четность dz1
if (num%2!=0) {
    Console.Write("не ");
}
Console.WriteLine("четное число");

//Показываем все четные числа dz1
Console.Write($"Все четные числа в промежутке от 1 до {num}: ");
for (int i = 2; i <= num; i+=2)
{
    if (i!=2){
        Console.Write(" ,");
    }
    Console.Write(i);
}
Console.WriteLine();

//Показываем все квадраты числа от 1 до m dz3
Console.Write($"Все квадраты числа в промежутке от 1 до {num}: ");
for (int i = 1; i <= num; i++)
{
    if (i!=1){
        Console.Write(" ,");
    }
    Console.Write(Math.Pow(i,2));
}
Console.WriteLine();

//Разбиваем на разряды dz2
Console.WriteLine($"Разбитие числа {num} по разрядам: ");
for (int i = 1;i<= n;i++) {
    Console.WriteLine($"{i}: {num/((int)Math.Pow(10,i-1))%10}");
}

//Сумма цифр числа dz2
int s = 0;
for (int i = 1;i<= n;i++) {
    s+=num/((int)Math.Pow(10,i-1))%10;
}
Console.WriteLine($"Сумма цифр числа {num}: {s}");


//выводим день Рабойчий ли это день недели от 01.01.2018 dz2
Console.Write($"{num} день от 01.01.2018: ");
if(((num-1)%7)/5<=5) {
    Console.WriteLine("будний");
}else{
    Console.WriteLine("выходной");
}

//Палиндром ли? dz3
bool p = true;
for (int i = 1;i<=n/2&p;i++) {
    if(num/((int)Math.Pow(10,i-1))%10!=num/((int)Math.Pow(10,n-i))%10){
        p=false;
    };
}
Console.Write("Число: ");
if(p){
    Console.WriteLine("палиндром");
}else{
    Console.WriteLine("непалиндром");
}

Console.Write($"Сумма всех натуральных чисел от 1 до {num}: {(num+1)/2*num} (");
int sn = 0;
for (int i = 1;i<=num;i++) {
    Console.Write($"{i} ");
    sn +=n;
}
Console.Write($")");

Console.WriteLine($"количество введенных положительных чисел: {cpi}");
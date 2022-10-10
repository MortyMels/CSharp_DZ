bool r = true; 
Console.Clear();
    
while(r){
    Console.WriteLine("Введите несколько наборов из трех чисел в формате '0;'");
    string s = Console.ReadLine();
    string[] sa = s.Split(';',',', ' ');
    int[] cl;
    foreach (var san in sa)
    {
        cl=StrToIntAr(san,true);
        int ci=0;
        int si=0;
        int mi;
        int xi;
        if((cl.Length-1==1)){
            if(cl[0]==0){
                int[] arr= new int[cl[1]];
                for (int i = 0; i < cl[1]; i++){
                    arr[i]= new Random().Next(100,999); //Генерируем 3хзначное число
                    if(arr[i]%2==0){
                        ci++; //Считаем четные значения
                    }
                    if(i%2==1){
                        si+=arr[i]; //Суммируем нечетные позиции
                    }
                }
                Console.WriteLine($"Массив из {cl[1]} чисел: [{String.Join(", ", arr)}]");
                Console.WriteLine($"Максимальное число: {arr.Max()}");
                Console.WriteLine($"Минимальное число: {arr.Min()}");
                Console.WriteLine($"Размер диапазона: {arr.Max()-arr.Min()}"); //Разница между максимальным и минимальным значнием 
                Console.WriteLine($"Количество четных чисел: {ci}");
                Console.WriteLine($"Сумма чисел на нечетных позициях: {si}");
                Console.WriteLine($"-----");

            }
        }else{
            Console.WriteLine($"Неверное количество параметров в наборе чисел: {san}");
        }
    }
    if (s=="end"){
        r=false;
    } 
    
}

int[] StrToIntAr(string str, bool err) {
    int[] numa = new int [2];
    int i = 0;
        if(!int.TryParse(str, out numa[++i])){
            if(err){
                if(str!=""){
                    Console.WriteLine($"Нераспознан '{str}'");
                }
            }
            numa[0]++;
        }
    return numa;
}
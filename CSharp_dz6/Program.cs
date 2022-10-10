bool r = true; 
Console.Clear();
    
while(r){
    Console.WriteLine("Введите набор из двух чисел в формате '0, 0'");
    string s = Console.ReadLine().Replace(" ", "");
    int[] cl;
    cl=StrToIntAr(s,true);

    if((cl.Length-1==2)){
        if(cl[0]==0){

            int[][] arr = new int[cl[1]][];
            int[] arrs = new int[cl[2]];
            int[] arrsh = new int[cl[2]];
            int arrmi = 0;


            
            int nz = 2;
            int ns = (int)Math.Pow(10, nz-1);
            int n = ((int)Math.Pow(10, nz)-ns);

            int[]narr = new int[n+1];



            for (int i = 0;i<n;i++){
                narr[i]=i+ns;
            }
            if(cl[1]*cl[2]<n){
                for (int i = 0; i < cl[1]; i++){
                    
                    arr[i] = new int[cl[2]];
                    for (int ii = 0; ii < cl[2]; ii++){
                        int nr = new Random().Next(0,n);
                        
                        arr[i][ii]= narr[nr]; //Генерируем число
                        narr[nr]=narr[n--]; //Убираем из диапазона
                        arrs[ii]+=arr[i][ii];
                    }
                    Array.Sort(arr[i]);
                    Array.Reverse(arr[i]);
                    arrsh[i]=arr[i].Sum();
                    if(arrsh[arrmi]>arrsh[i]){
                        arrmi=i;
                    }

                }
                }else{
                Console.WriteLine($"Количество доступных уникальных значений меньше чем размер массива: {s}");
            }
            pa(arr);

            Console.WriteLine($"Массив из {cl[1]}x{cl[2]} чисел");
            
            Console.Write($"Среднее арифметическое столбцов: ");
            foreach(var arrsi in arrs){
                Console.Write($"{arrsi/cl[1]}, ");
            }
            Console.WriteLine($"");
            Console.WriteLine($"{arrmi} строка имеет наименьшую сумму элементов - {arrsh[arrmi]}: {String.Join(", ", arr[arrmi])}");
            Console.WriteLine($"-----");


            bool r2 = true;
            while(r2){
                Console.WriteLine("Введите набор из двух чисел в формате '0, 0'");
                string s2 = Console.ReadLine().Replace(" ", "");
                
                
                if (s2=="end"){
                    r2=false;
                }else{
                    cl=StrToIntAr(s2,true);

                    if((cl.Length-1==2)){
                        if(cl[0]==0){
                            try{
                                Console.WriteLine($"Элемент массива на строке {cl[1]} в столбце {cl[2]}: {arr[cl[1]-1][cl[2]-1]}");
                            }catch{
                                Console.WriteLine($"Введен неверный адрес числа {s2}");
                            }

                        }
                    }else{
                        Console.WriteLine($"Неверное количество параметров в наборе чисел: {s2}");
                    }
                }
            }
        }
    }else{
        Console.WriteLine($"Неверное количество параметров в наборе чисел: {s}");
    }
    if (s=="end"){
        r=false;
    }
    
}

int[] StrToIntAr(string str, bool err) {
    string[] stra = str.Split(',','*','x','X');
    int[] numa = new int [stra.Length+1];
    int i = 0;
    foreach (string strai in stra){
        if(!int.TryParse(strai, out numa[++i])){
            if(err){
                Console.WriteLine($"Нераспознан {i} элемента набора '{strai}' в: {str}");
            }
            numa[0]++;
        }
    }
    return numa;
}

void pa(int[][] a){
    Console.Clear();
    int li = a.Length;
    int lii = a.Length;
    for(int i = 0; i<li;i++){
        for(int ii = 0; ii<lii;ii++){
            Console.Write($"({i},{ii}){a[i][ii]} ");
        }
        Console.WriteLine();
    }
}
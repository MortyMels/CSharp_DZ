bool r = true;
while(r){

    Console.WriteLine("Введите несколько наборов из двух чисел в формате '0, 0;'");
    string s = Console.ReadLine().Replace(" ", "");
    string[] sa = s.Split(';');
    int[] cl;
    int ln=sa.Length;
    int[][][] arr = new int[3][][];
    cl=StrToIntAr(sa[0],true);
    if(cl.Length-1==2){
        if(cl[0]==0){
            arr[0] = packarr(cl[1],cl[2]);
            printarr(arr[0]);
        }
    }else{
        Console.WriteLine($"Неверное количество параметров в наборе чисел: {s}");
    }

    for(int i=1;i<ln;i++){
        cl=StrToIntAr(sa[i],true);
        if(cl.Length-1==2){
            int w = arr[0][0].Length;
            if(cl[0]==0){
                if(cl[1]==arr[0].Length){
                    arr[2] = packarr(cl[1],cl[2]);
                    printarr(arr[2]);

                    arr[1]=new int[cl[2]][];
                    for (int iri = 0; iri<cl[2];iri++){
                        arr[1][iri]=new int[w];
                        for (int irii = 0; irii<w;irii++){
                            for (int ifi = 0; ifi<cl[1];ifi++){
                                arr[1][iri][irii]+=arr[2][iri][ifi]*arr[0][ifi][irii];    

                            }
                        }
                    }
                    printarr(arr[1]);
                    arr[0]=arr[1];
                }else{
                    Console.WriteLine($"Количество столбцов таблицы для перемножения - должно соответствовать количеству строк предыдущей(результативной) таблицы: {arr[0].Length}*{arr[0][0].Length}");
                }
            }


        }else{
            Console.WriteLine($"Неверное количество параметров в наборе чисел: {s}");
        }
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

int[] genarr (int h){
    int[] Arr = new int[h];
    int n;
    for (int i = 0; i < h; i++){
        Arr[i]= new Random().Next(0,9);
    }
    return Arr;
}
int[][] packarr(int w, int h){
    int[][] Arr = new int[h][];
    for (int i=0;i<h;i++){
        Arr[i]=genarr(w);
    }
    return Arr;
}
void printarr (int[][] a){
    foreach (int[] arr in a){
        Console.WriteLine(string.Join(" ", arr));
    }
    Console.WriteLine("-----");
}
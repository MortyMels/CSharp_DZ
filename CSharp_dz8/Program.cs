bool r = true; 
Console.Clear();
    
while(r){
    Console.WriteLine("Введите набор из трех чисел в формате '0, 0, 0'");
    string s = Console.ReadLine().Replace(" ", "");
    
    int[] cl;
    cl=StrToIntAr(s,true);//Вводим размерность массива

    if((cl.Length-1==3)){
        if(cl[0]==0){

            int[][][] arr = new int[cl[1]][][];
                       
            for (int i = 0; i < cl[1]; i++){
                arr[i]=new int[cl[2]][];
                for (int ii = 0; ii < cl[2]; ii++){
                    arr[i][ii]=new int[cl[3]];
                    for (int iii = 0; iii < cl[3]; iii++){
                    }
                }
            }

            int xi = 0;
            int yi = 0;
            int zi = 0;
            int xs = cl[3];
            int ys = cl[2]; 
            int zs = cl[1];
            int rev = 1;
            
            int ni = 0;

            arr[zi][yi][xi]+= ni++;
            int nis = zs*ys*xs;

            while (ni<nis){

                for (int i = xi+1; i<= xs-yi-1&ni<nis;i++){
                    arr[zi][yi][++xi]+= ni++;
                }
                if(ys/2==yi&ys%2==1&ni<nis){
                    if(zi+rev==zs|zi+rev==-1){
                        rev*=-1;
                    }else{
                        zi+=rev;
                        arr[zi][yi][xi]+= ni++;
                    }
                }
                for (int i = yi+1; i<= ys-xs+xi&ni<nis;i++){
                    arr[zi][++yi][xi]+= ni++;
                }
                if(xs/2==xi&xs%2==1&ni<nis){
                    if(zi+rev==zs|zi+rev==-1){
                        rev*=-1;
                    }else{
                        zi+=rev;
                        arr[zi][yi][xi]+= ni++;
                    }
                }
                for (int i = xi-1; i>= ys-yi-1&ni<nis;i--){
                    arr[zi][yi][--xi]+= ni++;
                }
                if(ys/2==yi&ys%2==1&ni<nis){
                    if(zi+rev==zs|zi+rev==-1){
                        rev*=-1;
                    }else{
                        zi+=rev;
                        arr[zi][yi][xi]+= ni++;
                    }
                }
                if(ys/2==yi&ys%2==0&ni<nis){
                    if(zi+rev==zs|zi+rev==-1){
                        rev*=-1;
                    }else{
                        zi+=rev;
                    }
                }
                for (int i = yi-1; i>= xi&ni<nis;i--){
                    arr[zi][--yi][xi]+= ni++;
                    pa(arr);
                    if(yi==xi+1&xs/2!=xi){
                        if(zi+rev==zs|zi+rev==-1){
                            rev*=-1;
                            i--;
                        }else{
                            zi+=rev;
                        }
                    }
                }
                if(xs/2==xi&xs%2==1&ni<nis){
                    if(zi+rev==zs|zi+rev==-1){
                        rev*=-1;
                    }else{
                        zi+=rev;
                        arr[zi][yi][xi]+= ni++;
                    }
                }
            }
            pa(arr);
        }
    }else{
        Console.WriteLine($"Неверное количество параметров в наборе чисел: {s}");
    }
    
    if (s=="end"){
        r=false;
    }
    
}

int[] StrToIntAr(string str, bool err) {
    string[] stra = str.Split(',','*');
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
void pa(int[][][] a){
    Console.Clear();
    foreach(var arri in a){
        foreach(var arrii in arri){
            Console.WriteLine(string.Join(" ", arrii));
        }
        Console.WriteLine("-----");
    }
}
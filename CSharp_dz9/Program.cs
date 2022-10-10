bool r = true; 
Console.Clear();
    
while(r){
    Console.WriteLine("Введите набор из трех чисел в формате '0'");
    string s = Console.ReadLine().Replace(" ", "");
    
    int[] cl;
    cl=StrToIntAr(s,true);

    if((cl.Length-1==1)){
        if(cl[0]==0){ 

            int[][] arr = new int[cl[1]][];
            
            for (int i = 0; i < cl[1]; i++){
                arr[i]=new int[i+1];
                arr[i][0]=1;
                for (int ii = 0; ii < i; ii++){

                    if (ii!=0) {
                        arr[i][ii]=arr[i-1][ii-1]+arr[i-1][ii];
                    }
                    arr[i][i-ii]=arr[i][ii];
                    
                }
            }
            pa(arr);
        }
        if (s=="end"){
            r=false;
        }
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
void pa(int[][] a){
    Console.Clear();
    foreach(var arri in a){
        foreach(var arrii in arri){
            Console.WriteLine(string.Join(" ", arrii));
        }
        Console.WriteLine("-----");
    }
}
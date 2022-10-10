bool r = true; 
Console.Clear();
    
while(r){
    Console.WriteLine("Введите набор из двух чисел в формате '0, 0'");
    string s = Console.ReadLine().Replace(" ", "");
    
    int[] cl;
    cl=StrToIntAr(s,true);

    if((cl.Length-1==2)){
        if(cl[0]==0){
            Console.WriteLine(a(cl[1],cl[2]));    
        }
    }
    if (s=="end"){
        r=false;
    }
}

static int a (int x, int y){
    if (x==0){
        return y+1;
    }else if (x!=0&y==0){
        return a(x-1,1);
    }else{
        return a(x-1,a(x,y-1));
    }
}

int[] StrToIntAr(string str, bool err) {
    string[] stra = str.Split(',');
    int[] numa = new int [stra.Length+1];
    int i = 0;
    foreach (string strai in stra){
        if(err){
            if(!int.TryParse(strai, out numa[++i])){
                Console.WriteLine($"Нераспознан {i} элемента набора '{strai}' в: {str}");
            }else if(numa[i]<0){
                Console.WriteLine($"Ошибка {i} элемента набора '{strai}' в: {str} - должен быть больше 0");
            }
        }
        numa[0]++;
    }
    return numa;
} 
bool r = true; 
Console.Clear();
    
while(r){
    Console.WriteLine("Введите несколько наборов из трех чисел в формате '0.0^0.0;'");
    string s = Console.ReadLine().Replace(" ", "");
    string[] sa = s.Split(';'); 
    double[] cl;
    foreach (var san in sa)
    {
        cl=StrToIntAr(san,true,"^");

        if((cl.Length-1==2)){
            if (cl[0]==0){
                Console.WriteLine($"Число {cl[1]} в степени {cl[2]} = {Math.Pow(cl[1],cl[2])}");
            }
        }else{
            Console.WriteLine($"Неверное количество параметров в наборе чисел: {san}");
        }
    }
    if (s=="end"){
        r=false;
    }
    
}

double[] StrToIntAr(string str, bool err, string sp) {
    string[] stra = str.Split(sp);
    double[] numa = new double [stra.Length+1];
    int i = 0;
    foreach (string strai in stra){
        if(!double.TryParse(strai, out numa[++i])){
            if(err){
                Console.WriteLine($"Нераспознан {i} элемента набора '{strai}' в: {str}");
            }
            numa[0]++;
        }
    }
    return numa;
}
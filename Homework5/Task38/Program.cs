// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double [] arrey = new double [7];
Console.Write ("Задан массив: ");
for (int i =0; i<arrey.Length; i++){
    arrey[i]=new Random().Next();
    Console.Write(arrey[i]+" ");
}

double max = arrey[0];
double min = arrey[0];
for (int j=0; j<arrey.Length; j++){
    if (arrey[j]<min){
        min=arrey[j];
    } else if (arrey[j]>max){
        max=arrey[j];
    }
    
}
Console.Write ("элемент max="+ max+", a элемент min = "+min+ ".");
double razn = max-min;
Console.Write ("Разница между максимальным и минимальными элементами: "+max+"-"+min+"="+razn);


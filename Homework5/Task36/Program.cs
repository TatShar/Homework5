// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int size = new Random().Next(1,11);
int[] arrey = new int [size];
int count = 0;


Console.Write ("Задан массив: ");
for (int i=0; i<arrey.Length; i++){
    arrey[i]= new Random().Next(1,11);
    
    Console.Write(arrey[i]+" ,");
}
 

 for (int j =0; j<arrey.Length; j++) {
    if( j%2!=0){
    count = count + arrey[j];
    }
    
 }
 Console.WriteLine(" Сумма элементов с нечетными индексами равна: "+ count);
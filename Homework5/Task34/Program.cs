// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве

int size= new Random().Next(0,11);
int [] arrey = new int [size];
Console.Write ("Задан массив: ");

for (int i=0; i<arrey.Length; i++) {

arrey[i]= new Random().Next(100,1000);
Console.WriteLine( arrey [i] + " ");
}
    int count = 0;
        
        for (int j=0; j<arrey.Length; j++) {
            if (arrey[j]%2==0){
                count++;
            }
        }
    
   Console.WriteLine ("количество четных чисел в массиве: " + count);



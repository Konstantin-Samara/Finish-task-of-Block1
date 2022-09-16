Console.Write("Введите кол-во элементов (длинну) массива : ");
int Length = Convert.ToInt32(Console.ReadLine());
if (Length>0) {
    string[] array1 = new string[Length];
    string[] array2 = new string[Length];
    int n=0;
    for (int i=0; i<Length; i++) {
        Console.Write($"Введите элемент массива с индексом {i} : ");
        array1[i]=Console.ReadLine();
        if (array1[i].Length<4) {
            array2[n]=array1[i]; 
            n++;}    }
    if (n==0) 
    {Console.WriteLine("В заданном массиве нет элементов, содержащих <=3-х символов.");}
    else {
        for (int i=0; i<n; i++) {Console.WriteLine(array2[i]);}}}
else {Console.WriteLine("кол-во элементов (длинна) массива должна быть > 0");}

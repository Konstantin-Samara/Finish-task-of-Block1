// Console.Write("Введите кол-во элементов (длинну) массива : ");
// int Length = Convert.ToInt32(Console.ReadLine());
// if (Length>0) {
//     string[] array1 = new string[Length];
//         int n=0;

//     for (int i=0; i<Length; i++) {
//         Console.Write($"Введите элемент массива с индексом {i} : ");
//         array1[i]=Console.ReadLine();
//         if (array1[i].Length<4) {n++;}}

//     if (n==0) 
//     {Console.WriteLine("В заданном массиве нет элементов, содержащих <=3-х символов.");}
//     else {
//         string[] array2 = new string[n];
//         int j = 0;
//         for (int i=0; i<Length; i++) {
//                 if (array1[i].Length<4) {array2[j]=array1[i];j++;}}
//         for (int i=0; i<n; i++) {Console.WriteLine(array2[i]);}}}
// else {Console.WriteLine("кол-во элементов (длинна) массива должна быть > 0");}
Console.Write("Введите кол-во элементов (длинну) массива : ");
int Length = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное кол-во символов в элементе массива : ");
int Мах = Convert.ToInt32(Console.ReadLine());
string GetRandWord(int Max1){
    string[] item = {"a","b","c","d","e","f","g","h","i","j","k",
    "l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};
    string str1="";
    Random rand=new Random();
    int LengthWord=rand.Next(1,Max1+1);
    for (int j=0;j<LengthWord;j++)
        {Random rand1=new Random();
        int NumberSymbol=rand1.Next(0,26);
        str1=str1+item[NumberSymbol];}
    return str1;}
if ((Length>0)&&(Мах>3)) {
string[] array1 = new string[Length];
string[] array2 = new string[Length];
int n=0;
Console.WriteLine("Исходный массив");
for (int i=0; i<Length; i++) {
    array1[i]=GetRandWord(Мах);
    Console.Write(array1[i]+", ");
    if (array1[i].Length<4) {
        array2[n]=array1[i]; 
        n++;}}
Console.WriteLine();
if (n==0) 
     {Console.WriteLine("В заданном массиве нет элементов, содержащих <=3-х символов.");}
else {
    Console.WriteLine("Конечный массив");
    for (int i=0; i<n; i++) {Console.Write(array2[i]+", ");}
    Console.WriteLine();}
     }
 else {Console.WriteLine("Введены некорректные данные.");}

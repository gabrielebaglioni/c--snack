//1
var sourceArray = new int[] { 3, 7, 23, 40, 37, 9, 19 };
Console.WriteLine(sourceArray.Max());





//2
string line = "Write a C# Sharp Program to display the following pattern using the alphabet.";
string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
string word = "";
int ctr = 0;
foreach (String s in words)
{
   if (s.Length > ctr)
   {
       word = s;
       ctr = s.Length;
   }
}
Console.WriteLine(word);

int[] numbs = new int[10];
for (int i = 0; i < 10; i++)
   numbs[i] = Convert.ToInt32(Console.ReadLine());




//3;
double somma = 0;
for (int i = 0; i < 10; i++)
{
   Console.WriteLine("Inserisci un numero:");
   somma += Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine("La somma è " + somma);



//4
int[] array = new int[20];
int somms = 0;
for (int i = 0; i < array.Length; i++)
{
   array[i] = i + 2;
   somms += array[i];
}
int med = somms / array.Length;
Console.WriteLine("la somma é: " + somms);
Console.WriteLine("la media é: " + med);



//5
Console.WriteLine("Inserire numero intero:");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero % 2 == 0)
{
   Console.WriteLine(numero);
}
else
{
   Console.WriteLine(numero +1);
}


//6
string[] invitati = { "gabriele", "federico" };
Console.WriteLine("Inserire il tuo nome:");
string myName = Console.ReadLine();
bool isInvitato = false;
for (int i = 0; i < invitati.Length; i++)
{
   if (invitati[i] == myName)
   {
       isInvitato = true;
       Console.WriteLine("sei invitato");
       break;
   }
   else
   {
       Console.WriteLine("non sei invitato");
       break;

   }
}



//7
int[] array = new int[6];

for (int i = 0; i < array.Length; i++)
{
   Console.WriteLine("Inserisci un numero");
   int numero = Convert.ToInt32(Console.ReadLine());
   if (numero % 2 != 0)
   {
       array[i] = numero;

   }
   Console.WriteLine("Array:");
   array.ToList().ForEach(Console.WriteLine);
}



//8
int[] array = { 1, 2, 3,};
int somma = 0;
for (int i = 1; i < array.Length; i = i + 2)
{
   somma+= array[i];
}

Console.WriteLine($"La somma é:" + somma);




//9
int[] array = { default };
while (array[default] < 50)
{
   array[default] += Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Hai superato 50");




//10
Console.WriteLine("Inserisci un numero N intero");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[10];
Random rdm = new Random();

for (int i = 0; i < N; i++)
{
    for (int j = 0; j < 10; j++)
    {
        array[j] = rdm.Next(100);
    }
    
}












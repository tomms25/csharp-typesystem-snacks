// See https://aka.ms/new-console-template for more information
using System;
using Internal;

Console.WriteLine("Hello, World!");






//Istruzioni condizionali
//	1. L’utente inserisce due numeri in successione.
//	Il software stampa il maggiore.


Console.WriteLine($"Inserisci due numeri in successione);
Console.WriteLine("Inserisci il primo numero");
Console.WriteLine("Inserisci due numeri in successione);
int numero1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Inserisci il secondo numero");
int numero2 = Convert.ToInt32(Console.ReadLine());

if (numero1 > numero2)
{
    Console.WriteLine({numero1});
}
else if(numero2 > numero1)
{
    Console.WriteLine({numero2});
}
else
{
    Console.WriteLine("I numeri sono uguali" + numero1 + "" + numero2);
}


//	2. L’utente inserisce due parole in successione.
//		Il software stampa prima la parola più corta, poi la parola più lunga.


Console.WriteLine("Inserisci due parole in successione");
Console.WriteLine("Inserisci la prima parola");
string word1 = Console.ReadLine() ?? "";

Console.WriteLine("Inserisci la seconda parola");
string word2 = Console.ReadLine() ?? "";

if (word1.Length > word2.Length)
{
    Console.WriteLine("La parola più corta è" + word2);
    Console.WriteLine("La parola più lunga è" + word1);
}
else if (word2.Length > word1.Length)
{
    Console.WriteLine("La parola più corta è" + word1);
    Console.WriteLine("La parola più lunga è" + word2);
}
else
{
    Console.WriteLine("Le parole hanno la stessa lunghezza" + word1 + "" + word2);
}





//Ciclo for
//    3. Il software deve chiedere per 10 volte all’utente di inserire un numero.
//Il programma stampa la somma di tutti i numeri inseriti.


int somma = 0;
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Inserisci il" + i + "numero:");
    int numeriInseriti = Convert.ToInt32(Console.ReadLine());
    somma += numeriInseriti;
}

Console.WriteLine("La somma dei 10 numeri inseriti è:" + somma);





//    4. Calcola la somma e la media dei numeri da 2 a 10.


int somma = 0;
double media = 0;

for( int i = 2; i <= 10; i++)
{
    somma += i;
}

media = (double)somma / 9;

Console.WriteLine("La somma dei numeri da 2 a 10 è:" + somma);
Console.WriteLine("La media dei numeri da 2 a 10 è:" + media);





//Operatore modulo
//    5. Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.


Console.WriteLine("Inserisci un numero qualsiasi, sia pari che dispari");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine("Il numero da te inserito è pari:" + numero);
}
else
{
    Console.WriteLine("Il numero da te inserito è dispari" + (numero + 1));
}




//Array
//    6. In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.

string[] invitati = { "Tommaso", "Igor", "Ibrahim", "Yari", "Alessandro", "Luigi", "Salvatore" };
Console.WriteLine("Inserisci il tuo nome:");
string nome = Console.ReadLine() ?? "";

bool presenteInLista = false;
foreach (string invitato in invitati)
{
    if(invitato == nome)
    {
        presenteInLista = true;
        break;
    }
}

if (present)
{
    Console.WriteLine("Prego e buona festa:" + nome);
}
else
{
    Console.WriteLine("Mi dispiace" + nome + "ma il suo nome non è sulla lista, non può entrare");
}



//	7. Crea un array vuoto.
//Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.

int[] numeri = new int[6];
int check = 0;

for ( int i = 0; i < 6; i++)
{
    Console.WriteLine("Inserisci un numero:");
    int numero = Convert.ToInt32(Console.ReadLine());

    if ( numero % 2 != 0)
    {
        numeri[check] = numero;
        check++;
    }
}





//    8. Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.

int[] numeri = { 60, 31, 35, 38, 45, 2, 76, 8, 12, 11 };

Console.WriteLine("I numeri nell'array sono:");

for (int i = 0; i <= 9; i++)
{
    Console.WriteLine(numeri[i]);
}

int oddSum = 0;

for (int i = 0; i < numeri.Length; i++)
{
    if (numeri[i] % 2 != 0)
    {
        oddSum += numeri[i];
    }
}

Console.WriteLine("La somma dispari è: " + oddSum);



//Ciclo while
//    9. Crea un array vuoto e chiedi all’utente un numero da inserire nell’array. Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.

int[] numeri = new int[0];
int somma = 0;

while (somma < 50)
{
    Console.Write("Inserisci un numero: ");
    int n = Convert.ToInt32(Console.ReadLine());


    Array.Resize(ref numeri, numeri.Length + 1);
    numeri[numeri.Length - 1] = n;


    somma = numeri.Sum();
}

Console.WriteLine("La somma degli elementi nell'array è: " + somma + " maggiore o uguale a 50.");



//Random
//    10. Fai inserire un numero, che chiameremo N, all’utente.
//Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.
//Ogni volta che ne crei uno, stampalo a schermo.


Console.WriteLine("Inserisci un numero per generare un uguale numero di array contenenti 10 numeri: ");

int N = Convert.ToInt32(Console.ReadLine());

var random = new Random();

Console.WriteLine("Array generati: ");

for (int i = 0; i < N; i++)
{
    var ints = new int[10];

    for (int j = 0; j < 10; j++)
    {
        ints[j] = random.Next(1, 100);
    }

    foreach (var num in ints)
    {
        Console.Write($"{num},");
    }

    Console.WriteLine();


    //Funzioni
    //    11. Dare la possibilità di inserire due parole.
    //Verificare tramite una funzione che le due parole abbiano la stessa lunghezza. Se hanno la stessa lunghezza, stamparle entrambe, altrimenti stampare la più lunga delle due.



    Console.Write("Inserisci la prima parola: ");
    string word1 = Console.ReadLine();

    Console.Write("Inserisci la seconda parola: ");
    string word2 = Console.ReadLine();

    if (Checklength(word1, word2))
    {
        Console.WriteLine($"Le due parole '{word1}' e '{word2}' hanno la stessa lunghezza.");
    }
    else
    {
        string longerWord = (word1.Length > word2.Length) ? word1 : word2;
        Console.WriteLine($"La parola più lunga è: '{longerWord}'.");
    }

    bool Checklength(string word1, string word2)
    {
        return word1.Length == word2.Length;
    }




//    12. Scrivere una funzione per verificare se un numero è pari o dispari.
//Quindi chiedere un numero all'utente e comunicargli se è pari o dispari. (


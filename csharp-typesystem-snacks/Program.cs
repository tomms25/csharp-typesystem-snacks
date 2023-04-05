// See https://aka.ms/new-console-template for more information
using System;
using Internal;

Console.WriteLine("Hello, World!");






//Istruzioni condizionali
//	1. L’utente inserisce due numeri in successione.
//	Il software stampa il maggiore.


snack1();
snack2();
snack3();
snack4();
snack5();
snack6();
snack8();
snack9();
snack10();
snack11();
snack12();

Console.WriteLine($"Inserisci due numeri in successione);

void snack1()
{
    Console.WriteLine("Inserisci due numeri in successione);
    Console.WriteLine("Inserisci il primo numero");
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
}

//	2. L’utente inserisce due parole in successione.
//		Il software stampa prima la parola più corta, poi la parola più lunga.

void snack2()
{
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

}




//Ciclo for
//    3. Il software deve chiedere per 10 volte all’utente di inserire un numero.
//Il programma stampa la somma di tutti i numeri inseriti.
//    4. Calcola la somma e la media dei numeri da 2 a 10.



//Operatore modulo
//    5. Il software chiede all’utente di inserire un numero. Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.



//Array
//    6. In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.
//	7. Crea un array vuoto.
//Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.
//    8. Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.




//Ciclo while
//    9. Crea un array vuoto e chiedi all’utente un numero da inserire nell’array. Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.




//Random
//    10. Fai inserire un numero, che chiameremo N, all’utente.
//Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.
//Ogni volta che ne crei uno, stampalo a schermo.





//Funzioni
//    11. Dare la possibilità di inserire due parole.
//Verificare tramite una funzione che le due parole abbiano la stessa lunghezza. Se hanno la stessa lunghezza, stamparle entrambe, altrimenti stampare la più lunga delle due.
//    12. Scrivere una funzione per verificare se un numero è pari o dispari.
//Quindi chiedere un numero all'utente e comunicargli se è pari o dispari. (


// See https://aka.ms/new-console-template for more information

//Esercizio:
//Si vuole progettare un sistema per la gestione di una biblioteca. Gli utenti si possono registrare al sistema, fornendo:
//    cognome,
//    nome,
//    email,
//    password,
//    recapito telefonico,

//Gli utenti registrati possono effettuare dei prestiti sui documenti che sono di vario tipo (libri, DVD). I documenti sono caratterizzati da:
//    un codice identificativo di tipo stringa (ISBN per i libri, numero seriale per i DVD),
//    titolo,
//    anno,
//    settore(storia, matematica, economia, …),
//    stato(In Prestito, Disponibile),
//    uno scaffale in cui è posizionato,
//    un autore (Nome, Cognome).

//Per i libri si ha in aggiunta il numero di pagine, mentre per i dvd la durata.

//L’utente deve poter eseguire delle ricerche per codice o per titolo e, eventualmente, effettuare dei prestiti registrando il periodo (Dal/Al) del prestito e il documento.
//Deve essere possibile effettuare la ricerca dei prestiti dato nome e cognome di un utente.

// Lista di utenti registrati
using System.Runtime.ConstrainedExecution;

List <utente> listaIscritti = new List <utente>();

// Lista di libri
List <libro> listaLibri = new List <libro>();

// Lista di DVD
List <DVD> listaDVD = new List <DVD>();


utente utente1 = new utente("Rossi", "Mario","rossi.mario@gmail.com","Password", "0583142536" );
utente utente2 = new utente("Rossi", "Paolo", "Rossi.Paolo@gmail.com", "Password", "0583142536");
utente utente3 = new utente("Bianchi", "Mario", "Bianchi.Mario@gmail.com", "Password", "0583142536");

listaIscritti.Add(utente1);
listaIscritti.Add(utente2);
listaIscritti.Add(utente3);


libro libro1 = new libro("1000000", "Titolo Libro", 2020, "Settore test", true, 2,"Autore Libro",200);

listaLibri.Add(libro1);

DVD DVD1 = new DVD(180, "1000000", "Titolo DVD", 2020, "Settore test", true, 2, "Autore DVD", 200);

listaDVD.Add(DVD1);


Console.WriteLine("Benvenuto!");
Console.WriteLine("Cosa vuoi fare?");
Console.WriteLine("1 - Stampare Lista Utenti Registrari");
Console.WriteLine("2 - Stampare Lista Libri");
Console.WriteLine("3 - Stampare Lista DVD");

int scelta =  Convert.ToInt32(Console.ReadLine());

switch (scelta)
{
	case 1:
		foreach (var utente in listaIscritti)
		{
            Console.WriteLine("------------");
            Console.WriteLine("NOME: "  + utente.Nome); 
			Console.WriteLine("COGNOME: " + utente.Cognome);
            Console.WriteLine("EMAIL: " + utente.Email);
            Console.WriteLine("------------");
        }
		break;

	case 2:
		break;

    case 3:
        break;

    default:
		break;
}
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

using System.Runtime.ConstrainedExecution;

// Lista di utenti registrati
List<Utente> listaIscritti = new List <Utente>();

// Lista di libri
List <Libro> listaLibri = new List <Libro>();

// Lista di DVD
List <DVD> listaDVD = new List <DVD>();

// Creazione di utenti di test
Utente utente1 = new Utente("Rossi", "Mario","rossi.mario@gmail.com","Password", "0583142536" );
Utente utente2 = new Utente("Rossi", "Paolo", "Rossi.Paolo@gmail.com", "Password", "0583142536");
Utente utente3 = new Utente("Bianchi", "Mario", "Bianchi.Mario@gmail.com", "Password", "0583142536");
listaIscritti.Add(utente1);
listaIscritti.Add(utente2);
listaIscritti.Add(utente3);

// Creazione di libri di test
Libro libro1 = new Libro("1000001", "Titolo Libro 1", 2020, "Fantasy", true, 1,"Autore 1",100);
Libro libro2 = new Libro("1000002", "Titolo Libro 2", 2020, "Thriller", false, 2, "Autore 2", 200);
listaLibri.Add(libro1);
listaLibri.Add(libro2);

// Creazione di DVD di test
DVD DVD1 = new DVD(120, "2000001", "Titolo DVD 1", 2020, "Fantasy", true, 1, "Regista 1");
DVD DVD2 = new DVD(180, "2000002", "Titolo DVD 2", 2020, "Thriller", false, 2, "Regista 2");
listaDVD.Add(DVD1);


Console.WriteLine("Benvenuto!");
Console.WriteLine("Cosa vuoi fare?");
Console.WriteLine("1 - Stampare Lista Utenti Registrari");
Console.WriteLine("2 - Stampare Lista Libri");
Console.WriteLine("3 - Stampare Lista DVD");
Console.WriteLine("4 - Prendi prodotto in prestito");


int scelta =  Convert.ToInt32(Console.ReadLine());

switch (scelta)
{
	case 1:
        #region
        foreach (var utente in listaIscritti)
		{
            Console.WriteLine(" ");
            Console.WriteLine("------------");
            Console.WriteLine("NOME: "  + utente.Nome); 
			Console.WriteLine("COGNOME: " + utente.Cognome);
            Console.WriteLine("EMAIL: " + utente.Email);
            Console.WriteLine("------------");
        }
		break;
        #endregion

    case 2:
        #region
        foreach (var libro in listaLibri)
        {
            Console.WriteLine(" ");
            Console.WriteLine("------------");
            Console.WriteLine("TITOLO: " + libro.Titolo);
            Console.WriteLine("AUTORE: " + libro.Autore);
            Console.WriteLine("GENERE: " + libro.Settore);
            Console.WriteLine("ANNO: " + libro.Anno);
            Console.WriteLine("PAGINE: " + libro.Pagine);
            Console.WriteLine("SCAFFALE: " + libro.Scaffale);
            if (libro.EDisponibile == true) { Console.WriteLine("DISPONIBILE: SI");}
            else Console.WriteLine("DISPONIBILE: NO");
            Console.WriteLine("------------");
        }
        break;
        #endregion
    case 3:
        #region
        foreach (var dvd in listaDVD)
        {
            Console.WriteLine(" ");
            Console.WriteLine("------------");
            Console.WriteLine("TITOLO: " + dvd.Titolo);
            Console.WriteLine("AUTORE: " + dvd.Autore);
            Console.WriteLine("GENERE: " + dvd.Settore);
            Console.WriteLine("ANNO: " + dvd.Anno);
            Console.WriteLine("DURATA: " + dvd.Durata + " Minuti");
            Console.WriteLine("SCAFFALE: " + dvd.Scaffale);
            if (dvd.EDisponibile == true) { Console.WriteLine("DISPONIBILE: SI"); }
            else Console.WriteLine("DISPONIBILE: NO");
            Console.WriteLine("------------");
        }
        break;
    #endregion

    case 4:
        break;

    default:
		break;
}
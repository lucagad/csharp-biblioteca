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
public class utente
{
    public string Cognome { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Telefono { get; set; }

    public utente(string cognome, string nome, string email, string password, string telefono)
    {
        this.Cognome = cognome;
        this.Nome = nome;
        this.Email = email;
        this.Password = password;
        this.Telefono = telefono;
    }
}
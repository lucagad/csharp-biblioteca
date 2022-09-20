
public class Prodotto
{
    protected string Codice { get; set; }
    protected string Titolo { get; set; }
    protected int Anno { get; set; }
    protected string Settore { get; set; }
    protected bool EDisponibile { get; set; }
    protected int Scaffale { get; set; }
    protected string Autore{ get; set; }

public Prodotto(string codice, string titolo, int anno, string settore, bool èDisponibile, int scaffale, string autore)
    {
        this.Codice = codice;
        this.Titolo = titolo;
        this.Anno = anno;
        this.Settore = settore;
        this.EDisponibile = èDisponibile;
        this.Scaffale = scaffale;
        this.Autore = autore;
    }
}

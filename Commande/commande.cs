// PATTERN COMMANDE : le pattern commande encapsule une requête en tant qu'objet (COMMANDE CONCRETE), autorisant ainsi 
// le paramétrage des clients
// par différentes requêtes, files d'attente et récapitulatifs de requêtes, et de plus, permettant la 
// réversibilité des opérations.

// CLIENT (~Jean-Jacques) : il instancie LES RECEPTEURS et l'INVOCATEUR, l'initialise avec les RECEPTEURS 
// et appelle les commandes de l'INVOCATEUR (mais ces taches peuvent être effectuées par des CLIENTS différents)
void Main()
{

	PorteGarage porte = new PorteGarage();
	TelecommandeSimple ts = new TelecommandeSimple();
	ICommande commandeDeGarage = new CommandePorteGarage(porte);
	ts.SetCommand(commandeDeGarage);
	
	ts.Go();
	ts.Annuler();
}

// INTERFACE DE COMMANDE (~abstrait) : implémentée par les commandes concrètes, elle fournit une/plusieurs méthodes de commandes 
// abstraites, appelées par INVOCATEUR
public interface ICommande
{
	void executer();
	void annuler();
}

// INVOCATEUR (~télécommande) : il contient une/des commandes concrète et les invoque en appelant leur méthode execute / annuler
// /!\ Il n'a aucune idée de la manière dont la lampe est allumée, d'ailleurs il ne sait meme pas si c'est une
// lampe ou une porte de garage, car chaque RECEPTEUR est encapsulé dans une COMMANDE CONCRETE
public class TelecommandeSimple
{
	ICommande emplacement;
	public TelecommandeSimple(){}
	public void SetCommand( ICommande commande)
	{
		emplacement = commande;
		Console.WriteLine(string.Format("Telecommande simple : set commande principal : {0}", commande.GetType()));
	}
	public void Go (){ if(emplacement != null) emplacement.executer(); }
	public void Annuler (){ if(emplacement != null) emplacement.annuler(); }
}

// COMMANDES CONCRETES (~actions sur la lampe, la porte, l'alarme...): elles contiennent une instance de RECEPTEUR et implémentent INTERFACE DE COMMANDE
public class CommandeAllumerLampe : ICommande
{
	Lampe lampe;
	public CommandeAllumerLampe(Lampe lampe)
	{
		this.lampe = lampe;
	}
	public void executer()
	{
		lampe.Marche();
	}
	public void annuler()
	{
		lampe.Arret();
	}
}
public class CommandePorteGarage : ICommande
{
	PorteGarage porte;
	public CommandePorteGarage(PorteGarage porte)
	{
		this.porte = porte;
	}
	public void executer()
	{
		porte.Ouvrir();
	}
	public void annuler()
	{
		porte.Fermer();
	}
}
public class CommandeAlarme : ICommande
{
	Alarme alarme;
	public CommandeAlarme(Alarme alarme)
	{
		this.alarme = alarme;
	}
	public void executer()
	{
		alarme.Armer();
	}
	public void annuler()
	{
		alarme.Desarmer();
	}
}

// RECEPTEURS (~lampe, porte, alarme...): ils savent comment effectuer le boulot. Ils sont instanciés par le CLIENT (ici main()) et 
// passés par lui aux INVOCATEURS
public class Lampe
{
	public void Marche(){ Console.WriteLine("Allumer la Lampe !");	}
	public void Arret(){ Console.WriteLine("Eteindre la lampe !");	}
}
public class PorteGarage
{
	public void Ouvrir(){ Console.WriteLine("Ouverture de Porte du garage  !");	}
	public void Fermer(){ Console.WriteLine("Fermeture de Porte du garage !");	}
}
public class Alarme
{
	public void Armer(){ Console.WriteLine("Armement de l'alarme  !");	}
	public void Desarmer(){ Console.WriteLine("Désarmement de l'alarme !");	}
}
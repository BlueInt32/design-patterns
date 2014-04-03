using System;

namespace Commande.ConsoleApp
{
	/// <summary>
	/// PATTERN COMMANDE : le pattern commande encapsule une requête en tant qu'objet (COMMANDE CONCRETE), autorisant ainsi 
	/// le paramétrage des clients
	/// par différentes requêtes, files d'attente et récapitulatifs de requêtes, et de plus, permettant la 
	/// réversibilité des opérations.
	/// 
	/// CLIENT (~Jean-Jacques) : il instancie LES RECEPTEURS et l'INVOCATEUR, l'initialise avec les RECEPTEURS 
	/// et appelle les commandes de l'INVOCATEUR (mais ces taches peuvent être effectuées par des CLIENTS différents)
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			PorteGarage porte = new PorteGarage();
			TelecommandeSimple ts = new TelecommandeSimple();
			ICommande commandeDeGarage = new CommandePorteGarage(porte);
			ts.SetCommand(commandeDeGarage);

			ts.Go();
			ts.Annuler();
			Console.Read();
		}
	}
}

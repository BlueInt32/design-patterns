using System;

namespace Commande.ConsoleApp
{
	/// <summary>
	/// INVOCATEUR (~télécommande) : il contient une/des commandes concrète et les invoque en appelant leur méthode execute / annuler
	/// /!\ Il n'a aucune idée de la manière dont la lampe est allumée, d'ailleurs il ne sait meme pas si c'est une
	/// lampe ou une porte de garage, car chaque RECEPTEUR est encapsulé dans une COMMANDE CONCRETE
	/// </summary>
	public class TelecommandeSimple
	{
		ICommande emplacement;
		public TelecommandeSimple() { }
		public void SetCommand(ICommande commande)
		{
			emplacement = commande;
			Console.WriteLine(string.Format("Telecommande simple : set commande principal : {0}", commande.GetType()));
		}
		public void Go() { if (emplacement != null) emplacement.executer(); }
		public void Annuler() { if (emplacement != null) emplacement.annuler(); }
	}
}

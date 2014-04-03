using System;

namespace Commande.ConsoleApp
{
	/// <summary>
	/// COMMANDES CONCRETES (~actions sur la lampe, la porte, l'alarme...): elles contiennent une instance de RECEPTEUR 
	/// et implémentent INTERFACE DE COMMANDE
	/// </summary>
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
}

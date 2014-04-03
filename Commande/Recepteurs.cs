using System;


namespace Commande.ConsoleApp
{
	/// <summary>
	/// RECEPTEURS (~lampe, porte, alarme...): ils savent comment effectuer le boulot. Ils sont instanciés par le CLIENT (ici main()) et 
	/// passés par lui aux INVOCATEURS
	/// </summary>
	public class Lampe
	{
		public void Marche() { Console.WriteLine("Allumer la Lampe !"); }
		public void Arret() { Console.WriteLine("Eteindre la lampe !"); }
	}
	public class PorteGarage
	{
		public void Ouvrir() { Console.WriteLine("Ouverture de Porte du garage !"); }
		public void Fermer() { Console.WriteLine("Fermeture de Porte du garage !"); }
	}
	public class Alarme
	{
		public void Armer() { Console.WriteLine("Armement de l'alarme  !"); }
		public void Desarmer() { Console.WriteLine("Désarmement de l'alarme !"); }
	}
}

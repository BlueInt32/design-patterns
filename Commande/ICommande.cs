using System;

namespace Commande.ConsoleApp
{
	/// <summary>
	/// INTERFACE DE COMMANDE (~abstrait) : implémentée par les commandes concrètes, 
	///elle fournit une/plusieurs méthodes de commandes 
	/// abstraites, appelées par INVOCATEUR
	/// </summary>
	public interface ICommande
	{
		void executer();
		void annuler();
	}
}

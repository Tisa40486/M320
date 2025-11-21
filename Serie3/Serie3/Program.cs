namespace Serie3
{

    /// <summary>
    /// Projet: Gestion de Banque et Comptes
    /// Détails: Dans cet exercice, vous allez implémenter un programme de gestion de comptes bancaires. Une banque peut gérer plusieurs comptes clients, et chaque compte possède un solde et permet des opérations de dépôt et de retrait.
    /// Auteur: Mattis Lefranc-Adam
    /// Date: 21/11/25
    /// </summary>


    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1, 200);


            account.GetBalance();
            account.Deposer(20);
            account.Retirer(50);
            account.GetBalance();


        }
    }
}

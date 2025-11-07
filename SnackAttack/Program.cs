namespace SnackAttack
{
    /// <summary>
    /// 
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            Random tailleBody = new Random();
            int nmb = tailleBody.Next(3, 10);
            Snack snack = new Snack(nmb);

            snack.Afficher();

            nmb = tailleBody.Next(3, 10);
            Snack snack1 = new Snack(nmb);

            snack1.Afficher();
        }

    }
}

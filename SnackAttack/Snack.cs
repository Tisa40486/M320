namespace SnackAttack
{
    public class Snack
    {
        private int _taille;
       
        public Snack(int taille)
        {
            _taille = taille;
        }

        public void Afficher()
        {
            string tailSnake = "<";
            string headSnake = "@@";
            string bodySnake = "";
            string snack = "";
         
            for (int i = 0; i < _taille; i++)
            {
                bodySnake += "#";
            }

            snack = tailSnake + bodySnake + headSnake;

            Console.WriteLine(snack);
        }
        public void Attaquer(Snack snack, int degats)
        {
            snack._taille = -degats;
        }

    }
}

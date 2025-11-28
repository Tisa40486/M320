namespace serie6_sol_kms
{
    /// <summary>
    /// Projet  : M320 - série 6
    /// Détails : Formulaire de l'exercice 1 : crée et affiche un Animal
    /// Auteur  : K. Mota
    /// Date    : 19.03.2023
    /// </summary>

    public partial class FrmEx1 : Form
    {
        ///l'objet de la classe Animal qui est affiché dans ce formulaire (à décommenter quand la classe sera créé)
        // private Animal _monAnimal;

        /// <summary>
        /// Initialise les composants du formulaire ainsi que l'animal et le texte du label qui l'affiche
        /// </summary>
        public FrmEx1()
        {
            InitializeComponent();
            InitAnimal();
            // TODO : afficher le texte représentant l'animal dans le label
        }

        /// <summary>
        /// Initialise le champs _monAnimal avec une nouvelle instance d'Animal nommée "Toto" et avec un poids aléatoire entre 10 et 1000
        /// </summary>
        private void InitAnimal()
        {
            // TODO : initialiser l'animal avec une nouvelle instance "Toto" et un poids aléatoire
        }

        /// <summary>
        /// Au click du bouton, change le nom de l'animal et affiche le texte representant l'animal dans le label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNewName_Click(object sender, EventArgs e)
        {
            // TODO : changer le nom de l'animal et afficher le texte représentant l'animal dans le label
        }
    }
}
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    public float speed; //Variable contenant la vitesse de la balle changeable dans l'éditeur Unity grâce à son accès "public".

	[SerializeField]
	private Text scoreText; //Variable contenant le texte du score.
	[SerializeField]
	private Text winText; //Variable contenant le texte de victoire.

    private CharacterController player;

	private int score; //Variable contenant le score du joueur.

    void Start () //Démarrage du jeu (initialisation)
    {
        player = GetComponent<CharacterController>();

        score = 0; //Au départ, le joueur n'a pas de point.
		SetScoreText(); //Affichage du score au début de partie.
		winText.text = "";
    }
     
    void Update ()
    {
        Vector3 forward = Input.GetAxis("Vertical") * transform.TransformDirection(Vector3.forward) * speed;
        Vector3 right = Input.GetAxis("Horizontal") * transform.TransformDirection(Vector3.right) * speed;

        player.Move(Physics.gravity);
        player.Move(forward * Time.deltaTime);
        player.Move(right * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
		if (other.gameObject.CompareTag("Miam")) //On teste si l'objet de la collision est taggé "Miam".
        {
			score = score + 1; //À chaque collision, le score s'incrémente et augmente.
			SetScoreText(); //Affichage du score au fur et mesure qu'il augmente.

			//Destroy (gameObject);
        }
    }

	void SetScoreText () //Fonction d'affichage du score.
	{
		scoreText.text = "Score : " + score.ToString ();

		if (score == 6)
		{
			winText.text = "You win ! :D";
			Destroy (gameObject);
		}
	}
}

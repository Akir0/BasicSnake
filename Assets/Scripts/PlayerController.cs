using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    public float rotateSpeed;

    private float speed = 8; //Variable contenant la vitesse de la balle changeable dans l'éditeur Unity grâce à son accès "public".

    [SerializeField]
	private Text scoreText; //Variable contenant le texte du score.
	[SerializeField]
	private Text winText; //Variable contenant le texte de victoire.

    private CharacterController player;

	private int score; //Variable contenant le score du joueur.

    void Start () //Démarrage du jeu (initialisation)
    {
        SceneManager.LoadScene("");

        player = GetComponent<CharacterController>();

        score = 0; //Au départ, le joueur n'a pas de point.
		SetScoreText(); //Affichage du score au début de partie.
		winText.text = "";
    }
     
    void Update ()
    {
        //transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);

        Vector3 forward = Input.GetAxis("Vertical") * transform.TransformDirection(Vector3.forward) * speed;
        Vector3 right = Input.GetAxis("Horizontal") * transform.TransformDirection(Vector3.right) * speed;

        player.Move(Physics.gravity);
        player.Move(forward * Time.deltaTime);
        player.Move(right * Time.deltaTime);
    }

    public void OnTriggerEnter(Collider other)
    {
		if (other.gameObject.CompareTag("Miam")) //On teste si l'objet de la collision est taggé "Miam".
        {
			score = score + 1; //À chaque collision, le score s'incrémente et augmente.
			SetScoreText(); //Affichage du score au fur et mesure qu'il augmente.
            Gameplay();
        }
    }

	public void SetScoreText () //Fonction d'affichage du score.
	{
		scoreText.text = "Score : " + score.ToString ();
	}

    private void Gameplay()
    {
        switch (score)
        {
            case 5:
                speed = speed * 2;
                break;
            case 10:
                speed = speed * 2;
                break;
            case 15:
                speed = speed * 2;
                break;
            case 20:
                speed = speed * 2;
                break;
            case 25:
                speed = speed * 2;
                break;
            case 30:
                speed = speed * 2;
                break;
            case 35:
                speed = speed * 2;
                break;
            case 40:
                speed = speed * 2;
                break;
            case 45:
                speed = speed * 2;
                break;
            case 50:
                speed = speed * 2;
                break;
            case 55:
                speed = speed * 2;
                break;
            case 60:
                speed = speed * 2;
                break;
            case 65:
                speed = speed * 2;
                break;
            case 70:
                speed = speed * 2;
                break;
            case 75:
                speed = speed * 2;
                break;
            case 80:
                speed = speed * 2;
                break;
            case 85:
                speed = speed * 2;
                break;
            case 90:
                speed = speed * 2;
                break;
            case 95:
                speed = speed * 2;
                break;
            case 100:
                speed = speed * 2;
                break;
        }

    } 
}

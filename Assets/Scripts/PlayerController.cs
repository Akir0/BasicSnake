﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float speed; //Variable contenant la vitesse de la balle changeable dans l'éditeur Unity grâce à son accès "public".

	[SerializeField]
	private Text scoreText; //Variable contenant le texte du score.
	[SerializeField]
	private Text winText; //Variable contenant le texte de victoire.
    
	private Rigidbody rB; //Variable pour accéder au "Rigidbody" de la balle. Le "Rigidbody" contient les aspects physiques d'un objet. Cela rend l'objet solide et soumis à la gravité.
	private int score; //Variable contenant le score du joueur.

    void Start () //Démarrage du jeu (initialisation)
    {
        rB = GetComponent<Rigidbody>(); //Recherche du "Rigidbody" de la balle et stockage dans la variable "rB". Execution au démarrage du jeu pour éviter de surcharger l'ordinateur.
		score = 0; //Au départ, le joueur n'a pas de point.
		SetScoreText(); //Affichage du score au début de partie.
		winText.text = "";
    }
     
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); //Variable enregistrant les axes horizontaux des contrôles du clavier.
        float moveVertical = Input.GetAxis("Vertical"); //Même chose que l'horizontal, mais pour le vertical.

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical); //Variable contenant les directions (x = mouvement horizontal, y = mouvement vers le haut et z = mouvement vertical).
        rB.AddForce(movement * speed); //Ajoute de la force à l'objet qui permettra le mouvement de l'objet en 3D.
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
		}
	}
}

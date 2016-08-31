using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
    private float _speed = 18; //Variable contenant la vitesse de la balle changeable dans l'éditeur Unity grâce à son accès "public".

    [SerializeField]
    private Text _scoreText; //Variable contenant le texte du score.

    private CharacterController _player;
    private int _score; //Variable contenant le score du joueur.

    public void Start() //Démarrage du jeu (initialisation)
    {

        _player = GetComponent<CharacterController>();

        _score = 0; //Au départ, le joueur n'a pas de point.
        SetScoreText(); //Affichage du score au début de partie.
    }

    public void Update()
    {
        //transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);

        Vector3 forward = Input.GetAxis("Vertical") * transform.TransformDirection(Vector3.forward) * _speed;
        Vector3 right = Input.GetAxis("Horizontal") * transform.TransformDirection(Vector3.right) * _speed;

        _player.Move(Physics.gravity);
        _player.Move(forward * Time.deltaTime);
        _player.Move(right * Time.deltaTime);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Miam")) //On teste si l'objet de la collision est taggé "Miam".
        {
            _score = _score + 1; //À chaque collision, le score s'incrémente et augmente.
            SetScoreText(); //Affichage du score au fur et mesure qu'il augmente.
            Gameplay();
        }
    }

    public void SetScoreText() //Fonction d'affichage du score.
    {
        _scoreText.text = "Score : " + _score.ToString();
    }

    private void Gameplay()
    {
        if (_score % 5 == 0)
        {
            _speed = _speed * 2;
        }
    } 
}

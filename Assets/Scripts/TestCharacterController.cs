using UnityEngine;
using System.Collections;

public class TestCharacterController : MonoBehaviour
{
    [SerializeField]
    private float _speed = 50f;

    [SerializeField]
    private Transform _target;

    private CharacterController _characterController;

    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
        _target = GameObject.Find("Player").transform; // A MODIFIER POUR METTRE LA CIBLE VOULUE
    }

    private void Update()
    {
        if (_target != null)
        {
            Vector3 target = _target.position; // On prend la position de la cible
            target.y = transform.position.y; // On met le y de cette position à celle de l'enemi pour pas qu'il vole ou aille dans le sol si il y a une différence de taille entre l'ennemi et la cible

            Vector3 moveDirection = target - transform.position; // Je crée le vecteur de direction tout simplement

            transform.LookAt(target); // Je fais que l'ennemi regarde vers la cible
            _characterController.Move(moveDirection.normalized FOIS speed FOIS Time.deltaTime); // Je dis à l'ennemi de bouger avec la direction FOIS la vitesse FOIS deltaTime pour calquer sur le temps du jeu
        }
    }
}
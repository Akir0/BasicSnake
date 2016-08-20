using UnityEngine;
using System.Collections;

public class FloatingMiam : MonoBehaviour
{
    public float amplitude = 1f; //Variable contenant l'amplitude du mouvement de flottement.
    public float speed = 1f; //Variable contenant la vitesse de l'amplitude.

    private float startPosY; //Position de départ à l'initialisation.
    private Vector3 newPos; //Nouvelle position de l'objet.

	// Use this for initialization
	void Start ()
    {
        startPosY = transform.position.y; //Pour avoir la position Y de l'objet au démarrage.
	}
	
	// Update is called once per frame
	void Update ()
    {
        newPos.y = startPosY + amplitude * Mathf.Sin(speed * Time.time); //Calcul de la nouvelle position prenant une valeur entre -1, 0, +1.
        newPos.z = transform.position.z;
        newPos.x = transform.position.x;

        transform.position = newPos;
	}
}

using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    public GameObject player; //Variable de référence pour la boule (le joueur).
    private Vector3 offset; //Variable différenciant le player de la caméra.

	void Start ()
    {
        offset = transform.position - player.transform.position;
	}
	
	void LateUpdate ()
    {
        transform.position = player.transform.position + offset;
	}
    //"LateUpdate" est utilisé pour que tous les objets soient chargés avant la caméra. Comme ça, nous sommes sûr que la position du joueur est à jour pour ensuitre placer la caméra dessus.
}

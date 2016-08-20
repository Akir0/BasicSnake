using UnityEngine;
using System.Collections;

public class RandomPositionMiam : MonoBehaviour
{
	/// <summary>
	/// Position du collectable aléatoire au départ, puis à chaque fois que le joueur le collecte.
	/// </summary>
	
	private float posX;
	private float posY;
	private float posZ;
	private Vector3 posFinal;

	// Use this for initialization
	void Start () 
	{
		RandomPosition ();
	}

	void OnTriggerEnter (Collider miam)
	{
		if (miam.gameObject.CompareTag("Player"))
		{
			miam.gameObject.SetActive (false);
			RandomPosition();
			miam.gameObject.SetActive (true);

		}
	}

	void RandomPosition()
	{
		posX = Random.Range (-35, 40);
		posY = 2;
		posZ = Random.Range (-35, 40);

		posFinal = new Vector3 (posX, posY, posZ);

		transform.position = posFinal;
	}
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CollisionWallDeath : MonoBehaviour
{
	[SerializeField]
	private Text gameOverText;

	void Start()
	{
		gameOverText.text = "";
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "Player")
		{
			Destroy (col.gameObject);
			gameOverText.text = "Game Over ! :(";
		}
	}
}

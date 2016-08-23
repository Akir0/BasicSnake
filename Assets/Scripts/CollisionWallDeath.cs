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


    void OnControllerColliderHit(ControllerColliderHit collision)
	//void onCollisionEnter (Collider collision)
    {
		if (collision.gameObject.tag == "WallDeath")
		{
            Debug.Log("Hit !");
            Destroy (this.gameObject);
			gameOverText.text = "Game Over ! :(";
		}
	}
}

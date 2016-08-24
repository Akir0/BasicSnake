using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
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
            this.gameObject.SetActive(false);

            SceneManager.LoadScene("3. MenuRestartDie");
		}
	}
}

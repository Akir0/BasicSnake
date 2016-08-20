using UnityEngine;
using System.Collections;

public class WallOfDeath : MonoBehaviour
{
	void onTriggerEnterWall()
	{
		Destroy (gameObject);
	}
}

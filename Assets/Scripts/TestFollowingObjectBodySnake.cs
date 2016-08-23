using UnityEngine;
using System.Collections;

public class TestFollowingObjectBodySnake : MonoBehaviour
{
    Transform player;

	// Use this for initialization
	void Start ()
    {
        player = GameObject.Find("Player").transform;
    }
	
	// Update is called once per frame
	void Update ()
    {
        transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z);
    }
}

using UnityEngine;
using System.Collections;

public class RandomPositionObstacleWall : MonoBehaviour
{
    /// <summary>
    /// Position de l'obstacle au départ, puis postion aléatoire à chaque fois qu'il pop.
    /// </summary>

    private float posX;
    private float posY;
    private float posZ;
    private Vector3 posFinal;

    // Use this for initialization
    void Start()
    {
        RandomPosition();
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.CompareTag("MiamSnake"))
        {
            player.gameObject.SetActive(true);
            RandomPosition();
            player.gameObject.SetActive(true);

        }
    }

    void RandomPosition()
    {
        posX = Random.Range(-35, 40);
        posY = 2;
        posZ = Random.Range(-35, 40);

        posFinal = new Vector3(posX, posY, posZ);

        transform.position = posFinal;
    }
}

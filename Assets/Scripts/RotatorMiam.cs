using UnityEngine;
using System.Collections;

public class RotatorMiam : MonoBehaviour
{

	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime); //Rotation du miam dans les trois axes.
	}
}

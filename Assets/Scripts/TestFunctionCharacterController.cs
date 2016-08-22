using UnityEngine;
using System.Collections;


[RequireComponent(typeof(CharacterController))]
public class TestFunctionCharacterController : MonoBehaviour
{

    public float MoveSpeed;
    //public float RotationSpeed;

    CharacterController player;

	// Use this for initialization
	void Start ()
    {
        player = GetComponent<CharacterController>();    
	}
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 forward = Input.GetAxis("Vertical") * transform.TransformDirection(Vector3.forward) * MoveSpeed;
        Vector3 right = Input.GetAxis("Horizontal") * transform.TransformDirection(Vector3.right) * MoveSpeed;

        //transform.Rotate(new Vector3(0, Input.GetAxis("Horizontal") * Time.deltaTime, 0));
        player.SimpleMove(Physics.gravity);
        player.SimpleMove(forward * Time.deltaTime);
        player.SimpleMove(right * Time.deltaTime);
	}
}

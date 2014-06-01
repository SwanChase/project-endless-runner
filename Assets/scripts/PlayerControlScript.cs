using UnityEngine;
using System.Collections;

public class PlayerControlScript : MonoBehaviour
{
	public float MoveSpeed = 10;
	public float RotateSpeed = 10;
	
	void Update () 
	{

		// Amount to Move
		float MoveForward = Input.GetAxis("Vertical")  * MoveSpeed * Time.deltaTime;
		float MoveRotate = Input.GetAxis("Horizontal") * RotateSpeed * Time.deltaTime;
		
		
		// Move the player
		transform.Translate(Vector3.up * MoveForward);
		transform.Rotate(Vector3.forward * MoveRotate);
	}
}

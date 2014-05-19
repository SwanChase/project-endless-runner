using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Movmentscript : MonoBehaviour {
	
	public float speed = 2f;
	public float horizontalDirection = -1; //move from right to left
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//move the root BG from right to left
		transform.Translate(new Vector3(speed * horizontalDirection * Time.deltaTime, 0, 0));
	}
	
}
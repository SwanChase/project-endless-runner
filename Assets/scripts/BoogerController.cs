using UnityEngine;
using System.Collections;

public class BoogerController : MonoBehaviour {
	public float DestroyTime;
	public float speed;
	
	void Start () {
		Destroy (gameObject, DestroyTime);
	}
	
	void Update(){
		this.transform.Translate (Vector3.forward * speed * Time.deltaTime);



	} 
	void OncolisionEnter(Collider other)
	{
		if (other.gameObject.tag == "wall") 
		{
			Debug.Log("wall");
			Destroy(this.gameObject);
		}
	}
}
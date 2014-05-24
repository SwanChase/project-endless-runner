using UnityEngine;
public class gravityScript : MonoBehaviour 
{

	void OnTriggerEnter(Collider other){
		var gravity = false;
		if(other.transform.tag == "barrier"){
			gravity = true;
		}
	}
	void Update ()
	{
		var gravity = false;
		if(gravity){
			//je gravity script ding
		}
	}
}
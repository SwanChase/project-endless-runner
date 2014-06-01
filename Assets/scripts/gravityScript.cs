using UnityEngine;
public class gravityScript : MonoBehaviour 
{
	void Update ()
	{

	}
	void OnTriggerEnter(Collider other){
		var gravity = false;
		if(other.transform.tag == "barrier"){
			gravity = true;
		}
		//var gravity = false;
		if(gravity){
			//je gravity script ding
		}
	}

}
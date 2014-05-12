using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour 
{	
	public Transform target;
	public float health;
	public void TakeDammage(float dmg)
	{
		health -= dmg;
		

	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player") 
		{
			Debug.Log(other.tag);
			target = other.transform;
		}
		if(other.transform.tag == "Projectile")
		{
			TakeDammage(5);
			if (health <= 0) 
			{

				Destroy(this.gameObject);
				Destroy(other.gameObject);
			}
		}
	}
	 	
}

using UnityEngine;
using System.Collections;

public class GameControllerPrev : MonoBehaviour
{
	public GameObject boulder1;
	public GameObject boulder2;
	public GameObject boulder3;
	public GameObject boulder4;
	public int boulderCount1;
	public int boulderCount2;
	public int boulderCount3;
	public int boulderCount4;
	public Vector3 Position;
	public float RndMinY,RndMaxY;
	public float RndMinX, RndMaxX;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	private float player;
	private float distance;
	
	void Start ()
	{
		/*player = transform.position.x + 20;
		Vector3 spawnPos = new Vector3(0,0,0);
		spawnPos = player.position.transform;
		spawnPos.x += distance;
		Instantiate(boulder1, spawnPos, this.transform.rotation);
		*/
		
		
		
		StartCoroutine (SpawnWaves ());
	}
	
	IEnumerator SpawnWaves ()
	{
		yield return new WaitForSeconds (startWait);
		while (true)
		{
			RndMinY = this.transform.position.y - 5.0f; //hier moet je de random range veranderen
			
			RndMaxY = this.transform.position.y + 12.0f; //hier moet je de random range veranderen
			
			RndMaxX = this.transform.position.x + 24f;//hier moet je de random range veranderen
			
			RndMinX = this.transform.position.x + 20f;//hier moet je de random range veranderen
			for (int i = 0; i < boulderCount1; i++)
			{
				
				Position = new Vector3(Random.Range(RndMinX,RndMaxX),Random.Range(RndMinY,RndMaxY),0);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (boulder1, Position, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}
			for (int i = 0; i < boulderCount2; i++)
			{
				Position = new Vector3(Random.Range(RndMinX,RndMaxX),Random.Range(RndMinY,RndMaxY),0);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (boulder2, Position, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}
			for (int i = 0; i < boulderCount3; i++)
			{
				Position = new Vector3(Random.Range(RndMinX,RndMaxX),Random.Range(RndMinY,RndMaxY),0);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (boulder3, Position, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}
			for (int i = 0; i < boulderCount4; i++)
			{
				Position = new Vector3(Random.Range(RndMinX,RndMaxX),Random.Range(RndMinY,RndMaxY),0);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (boulder4, Position, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
		}
	}
}
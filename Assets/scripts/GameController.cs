using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
	public GameObject boulder1;
	public GameObject boulder2;
	public GameObject boulder3;
	public GameObject boulder4;
	public Vector3 Position;
	public int boulderCount1;
	public int boulderCount2;
	public int boulderCount3;
	public int boulderCount4;
	public float RndMinY,RndMaxY;
	public float RndMinX,RndMaxX;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	
	void Start ()
	{
		RndMinY = this.transform.position.y - 15.0f; //the closest location to the spawner blcok
		
		RndMaxY = this.transform.position.y + 10.0f; //the farthest location from the spawner block
		
		RndMinX = this.transform.position.x - 50.0f; //the closest location to the spawner blcok
		
		RndMaxX = this.transform.position.x + 50.0f; //the farthest location from the spawner block

		StartCoroutine (SpawnWaves ());
	}
	
	IEnumerator SpawnWaves ()
	{
		yield return new WaitForSeconds (startWait);
		while (true)
		{
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
				Instantiate (boulder1, Position, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
		}
	}
}




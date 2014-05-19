using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
	public GameObject boulder;
	public Vector3 spawnValues;
	public int boulderCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	
	void Start ()
	{
		StartCoroutine (SpawnWaves ());
	}
	
	IEnumerator SpawnWaves ()
	{
		yield return new WaitForSeconds (startWait);
		while (true)
		{
			for (int i = 0; i < boulderCount; i++)
			{
				Vector3 spawnPosition = new Vector3 (spawnValues.x,Random.Range (-spawnValues.y, spawnValues.y), spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (boulder, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
		}
	}
}
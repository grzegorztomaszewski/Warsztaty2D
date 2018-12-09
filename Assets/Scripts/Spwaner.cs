using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spwaner : MonoBehaviour {
	public GameObject pipePrefab;
	public float spawnDelay;
	public Vector3 spawnVector;
	// Use this for initialization
	void Start () {
		StartCoroutine(spawnPipeCoroutine());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//Interfejs spawnujący pipes'y po określonym czasie
	public IEnumerator spawnPipeCoroutine()
	{
		while (GameManager.instance.isAlive)
		{
			if (GameManager.instance.isAlive)
			{

				spawnVector = new Vector3(transform.position.x, Random.Range(333f, 262f), 0); // x=x, y=losowo w przedziale (-0.3f, 0.85f), y=0
			}
				Instantiate(pipePrefab, spawnVector, Quaternion.identity);
			//Debug.Log("Spawn");
			yield return new WaitForSeconds(spawnDelay);//Delay spawner pipes'ów
		}
	}
}

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
    //waiting
    public IEnumerator spawnPipeCoroutine()
    {
        while (true)
        {
            spawnVector = new Vector3(transform.position.x, Random.Range(-0.3f, 0.85f), 0);
            Instantiate(pipePrefab, spawnVector, Quaternion.identity);
            //Debug.Log("Spawn");
            yield return new WaitForSeconds(spawnDelay);
        }
    }
}

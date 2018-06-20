using UnityEngine;
using System.Collections;

public class spawnController : MonoBehaviour {
    public GameObject pato;
    public GameObject patoTime;

    public float rateSpawn;
    private float currentTime;
    public float x;
    public float y;
    
	void Start () {
        currentTime = 0;
	}
	
	void Update () {
        currentTime += Time.deltaTime;
        if (currentTime >= rateSpawn) {
            currentTime = 0;
            int patin = Random.Range(0, 100);
            GameObject tempPrefab;
            if (patin < 10) {
                tempPrefab = Instantiate(patoTime) as GameObject;
            } else {
                tempPrefab = Instantiate(pato) as GameObject;
            }
            
            tempPrefab.transform.position = new Vector3(x, y,tempPrefab.transform.position.z);
        }
	}
}

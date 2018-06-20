using UnityEngine;
using System.Collections;

public class duckTime : MonoBehaviour {

    public GameObject ducky;
    
    void Start () {
	
	}
	
	void Update () {
	
	}


    public void som(){
    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.gameObject.tag == "Ball") {
            tempo.time += 4;
            tempo.t += 4;
            Destroy(ducky);
        }
    }
}

using UnityEngine;
using System.Collections;

public class moveDuck : MonoBehaviour {
    private float x;
    public float speed;
     
	void Start () {
	
	}
	 
	void Update () {
        x = transform.position.x;
        x += speed * Time.deltaTime;
        transform.position = new Vector2(x,transform.position.y);

        if (x > 13 || x < -13) {
            Destroy(gameObject);
        }
	}
}

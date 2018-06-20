using UnityEngine;

public class duck : MonoBehaviour {

    public GameObject ducky;
    public AudioSource begin;

	void Start () {
	
	}
	 
	void Update () {
	
	}

    public void som() {
        if (PlayerPrefs.GetInt("som") == 0)  {
            begin.Play();
        }  else {

        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Ball")  {
            som();
            pontos.pontuar(10);
            Destroy(ducky);
        }
    }
}

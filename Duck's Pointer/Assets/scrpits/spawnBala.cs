using UnityEngine;
using System.Collections;

public class spawnBala : MonoBehaviour {
    public GameObject bala;
    public AudioSource begin;

    void Start()  {

    }

    void Update() {
        if (Time.timeSinceLevelLoad > 4 && Time.timeSinceLevelLoad < 66) {
            if (webcam.getVerde1 > 0.73)  {
                GameObject shoot = Instantiate(bala) as GameObject;
                shoot.transform.position = new Vector3(Random.Range(-6.2f, -5.0f), 3.23f, shoot.transform.position.z);
                som();
            }
            //----------------------------------------------------------------------------
            if (webcam.getVerde2 > 0.73)  {
                GameObject shoot = Instantiate(bala) as GameObject;
                shoot.transform.position = new Vector3(Random.Range(-1f, 2f), 3.23f, shoot.transform.position.z);
                som();
            } 
            //----------------------------------------------------------------------------
            if (webcam.getVerde3 > 0.73) {
                GameObject shoot = Instantiate(bala) as GameObject;
                shoot.transform.position = new Vector3(Random.Range(5.5f, 7f), 3.23f, shoot.transform.position.z);
                som();
            } 
            //----------------------------------------------------------------------------
            if (webcam.getVerde4 > 0.73) {
                GameObject shoot = Instantiate(bala) as GameObject;
                shoot.transform.position = new Vector3(Random.Range(-6.2f, -5.0f), -0.41f, shoot.transform.position.z);
                som();
            } 
            //----------------------------------------------------------------------------
            if (webcam.getVerde5 > 0.73)  {
                GameObject shoot = Instantiate(bala) as GameObject;
                shoot.transform.position = new Vector3(Random.Range(-1f, 2f), -0.41f, shoot.transform.position.z);
                som();
            } 
            //----------------------------------------------------------------------------
            if (webcam.getVerde6 > 0.73)  {
                GameObject shoot = Instantiate(bala) as GameObject;
                shoot.transform.position = new Vector3(Random.Range(5.5f, 7f), -0.41f, shoot.transform.position.z);
                som();
            } 
            //----------------------------------------------------------------------------
            if (webcam.getVerde7 > 0.64 && webcam.getVerde7 < 0.83) {
                GameObject shoot = Instantiate(bala) as GameObject;
                shoot.transform.position = new Vector3(Random.Range(-6.2f, -5.0f), -3.57f, shoot.transform.position.z);
                som();
            }  
            //----------------------------------------------------------------------------
            if (webcam.getVerde8 > 0.73)  {
                GameObject shoot = Instantiate(bala) as GameObject;
                shoot.transform.position = new Vector3(Random.Range(-1f, 2f), -3.57f, shoot.transform.position.z);
                som();
            } 
            //----------------------------------------------------------------------------
            if (webcam.getVerde9 > 0.73)  {
                GameObject shoot = Instantiate(bala) as GameObject;
                shoot.transform.position = new Vector3(Random.Range(5.5f, 7f), -3.57f, shoot.transform.position.z);
                som();
            } 
        } 
    }

    public void som() {
        if (PlayerPrefs.GetInt("som") == 0) {
            begin.Play();
        } else {

        }
    }
}

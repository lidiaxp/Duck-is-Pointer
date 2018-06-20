using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class subirCortina : MonoBehaviour {
    private float y;
    public float speed;
    public Image cortina;
    float xi, yi;
    bool turn;
    public static bool play;
     
	void Start () {
        turn = true;
        play = false;
        xi = cortina.transform.position.x;
        yi = cortina.transform.position.y;
        cortina.transform.position = new Vector2(xi, yi);
	}
	 
	void Update () {
        if (y < 1350 && turn) {
            y = transform.position.y;
            y += speed * Time.deltaTime;
            cortina.transform.position = new Vector2(cortina.transform.position.x, y);
        } else if (y >= 400) {
            play = true;
            if (tempo.time <= 0) {
                turn = false;
                y = transform.position.y;
                y -= speed * Time.deltaTime;
                
                cortina.transform.position = new Vector2(cortina.transform.position.x, y);
                PlayerPrefs.SetInt("score", pontos.points);
                if (PlayerPrefs.GetInt("recorde") < pontos.points) {
                    PlayerPrefs.SetInt("recorde", pontos.points);
                }
            }
        }else {
            if (turn == false)  {
                webcam.cam.Stop();
                SceneManager.LoadScene("inico"); 
            } 
        } 
    }
}

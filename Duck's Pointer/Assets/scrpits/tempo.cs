using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class tempo : MonoBehaviour {

    public Text texto;
    public static int time;
    public static int t;
    public AudioSource begin;
     
	void Start () {
        t = 66;
	}
	 
	void Update () {
        if (subirCortina.play) {
            time = t - (int)Time.timeSinceLevelLoad;
            if (time < 0) { time = 0; }
            texto.text = "Tempo: " + time;
        }
        //-----------------musica---------------------
        if (PlayerPrefs.GetInt("musica") == 0) {  //com musica
           begin.mute = false;
        }
        else {                                 //sem musica
           begin.mute = true;
        }
    }
}

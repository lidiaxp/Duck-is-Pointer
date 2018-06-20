using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class musica : MonoBehaviour {

    public Button som;
    public Sprite somOn;
    public Sprite somOff;
    public Button music;
    public Sprite musicOn;
    public Sprite musicOff;
    public AudioSource begin;
    public static int s;
    public static int m;
    
    void Start () {
	
	}
	
	void Update () {
        if (PlayerPrefs.GetInt("som") == 0) {   //com som
            som.image.overrideSprite = somOn;
        } else {                                 //sem som
            som.image.overrideSprite = somOff; 
        }
        if (PlayerPrefs.GetInt("musica") == 0) {  //com musica
            begin.mute = false;
            music.image.overrideSprite = musicOn;
        } else  {                                 //sem musica
            begin.mute = true;
            music.image.overrideSprite = musicOff;
        }
    }

    public void song() {
        if (s == 0) {
            s = 1;
            PlayerPrefs.SetInt("som", s);
        }
        else  {
            s = 0;
            PlayerPrefs.SetInt("som", s);
        }
    }

    public void musi() {
        if (m == 0) {
            m = 1;
            PlayerPrefs.SetInt("musica", m);
        }
        else {
            m = 0;
            PlayerPrefs.SetInt("musica", m);
        }
    }

    public void play() {
        SceneManager.LoadScene("game");
    }
}

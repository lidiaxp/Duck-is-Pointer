using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class pontos : MonoBehaviour {

    public static int points;
    public Text texto;
     
	void Start () {
        points = 0;
	}
	 
	void Update () {
        texto.text = "Pontos: " + points;
        //------------------som-----------------
        if (PlayerPrefs.GetInt("som") == 0) {   //com som

        } else {                                 //sem som

        }
    }

    public static void pontuar(int n) {
        points += n;
    }
}

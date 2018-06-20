using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class score : MonoBehaviour {

    Text texto;
    
    void Start () {
        texto = GetComponent<Text>();
    }
	
	void Update () {
        texto.text = PlayerPrefs.GetInt("score").ToString();
    }
}

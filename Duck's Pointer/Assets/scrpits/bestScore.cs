using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class bestScore : MonoBehaviour {

    Text texto;
    
	void Start () {
        texto = GetComponent<Text>();
	}
	
	void Update () {
        texto.text = PlayerPrefs.GetInt("recorde").ToString();
	}
}

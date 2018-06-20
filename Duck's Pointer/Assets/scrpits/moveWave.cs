using UnityEngine;
using System.Collections;

public class moveWave : MonoBehaviour {
    public float speed;
    private float offSet;
    private Material currentMaterial;

	// Use this for initialization
	void Start () {
        currentMaterial = GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void Update () {
        offSet += speed * Time.deltaTime;
        currentMaterial.SetTextureOffset("_MainTex", new Vector2(offSet, 0));
	}
}

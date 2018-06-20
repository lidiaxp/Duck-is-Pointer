using UnityEngine;
using UnityEngine.UI;

public class webcam : MonoBehaviour {

    public static WebCamTexture cam;
    public RawImage rawimage;
    public static float getVerde1;
    public static float getVerde2;
    public static float getVerde3;
    public static float getVerde4;
    public static float getVerde5;
    public static float getVerde6;
    public static float getVerde7;
    public static float getVerde8;
    public static float getVerde9;

 
    void Start () {
        cam = new WebCamTexture();
        rawimage.texture = cam;
        rawimage.material.mainTexture = cam;
        cam.Play();
    }
	 
	void Update () {
        
        if (Time.timeSinceLevelLoad > 5)  {
            getVerde1 = cam.GetPixel(100, 300).g;
            getVerde2 = cam.GetPixel(330, 330).g;
            getVerde3 = cam.GetPixel(550, 330).g;
            getVerde4 = cam.GetPixel(100, 200).g;
            getVerde5 = cam.GetPixel(330, 200).g;
            getVerde6 = cam.GetPixel(550, 200).g;
            getVerde7 = cam.GetPixel(100, 100).g;
            getVerde8 = cam.GetPixel(330, 100).g;
            getVerde9 = cam.GetPixel(550, 100).g;
        }
    }
}

using UnityEngine;
using System.Collections;

public class bala : MonoBehaviour {
    private float z;
    public float speed;
    public Material newMaterialRef;

    void Start() {
        Renderer rend = GetComponent<Renderer>();
        rend.material = newMaterialRef;
    }

    void Update()  {
        z = transform.position.x;
        z += speed * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, transform.position.y,z);

        if (z > 0.02) {
            Destroy(gameObject);
        }
    }
}

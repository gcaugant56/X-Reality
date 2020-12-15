using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mobCC : MonoBehaviour{

    Camera cam = null;
    public float speed = 20.0f;

    // Start is called before the first frame update
    void Start(){

        cam = FindObjectOfType<Camera>();
        
    }

    // Update is called once per frame
    void Update(){

        //suivi de la camera par le mob
        this.transform.rotation = Quaternion.LookRotation(Vector3.Normalize(cam.transform.position - this.transform.position), Vector3.up);

        this.transform.Translate(this.transform.forward * speed * Time.deltaTime);

    }
}

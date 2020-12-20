using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mobCC : MonoBehaviour{

    Camera cam = null;
    public float speed = 20.0f;
    public float gravity = 20f;
    private Vector3 moveDirection = Vector3.zero;
    CharacterController cc;
    private float Xcam;
    private float Zcam;
    private float Xmob;
    private float Ymob;

    // Start is called before the first frame update
    void Start(){

        cam = FindObjectOfType<Camera>();
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update(){

        //suivi de la camera par le mob
        this.transform.rotation = Quaternion.LookRotation(Vector3.Normalize(cam.transform.position - this.transform.position), Vector3.up);

        //this.transform.Translate(this.transform.forward * speed * Time.deltaTime);


        moveDirection = new Vector3(0, 0, 1);
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection.y -= gravity * Time.deltaTime;
        cc.Move(moveDirection * speed * Time.deltaTime);
        //Debug.Log(cam.transform.position - this.transform.position);


    }

    
}

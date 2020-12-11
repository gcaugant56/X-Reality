using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mobCC : MonoBehaviour{
    public float speed = 1f;
    //public float gravity = 20f;
    private Vector3 moveDirection = Vector3.zero;
    CharacterController cc;

    // Start is called before the first frame update
    void Start(){
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed; 
        //moveDirection.y -= gravity * Time.deltaTime;
        cc.Move(moveDirection * Time.deltaTime);
    }
}

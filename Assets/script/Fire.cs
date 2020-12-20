using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Fire : MonoBehaviour
{
    //Drag in the Bullet Emitter from the Component Inspector.
    public GameObject Bullet_Emitter;

    //Drag in the Bullet Prefab from the Component Inspector.
    public GameObject Bullet;

    //Enter the Speed of the Bullet from the Component Inspector.
    public float Bullet_Forward_Force;

    public Button feu;
    public Button up;
    public Button down;
    public Button left;
    public Button right;
    public Camera camera;
    // Use this for initialization

    void Start()
    {
        Button btn = feu.GetComponent<Button>();
        btn.onClick.AddListener(() => TaskOnclick());
        Button downBtn = down.GetComponent<Button>();
        downBtn.onClick.AddListener(() => MoveDown());
        Button upBtn = up.GetComponent<Button>();
        upBtn.onClick.AddListener(() => MoveUp());
        Button leftBtn = left.GetComponent<Button>();
        leftBtn.onClick.AddListener(() => MoveLeft());
        Button rigthBtn = right.GetComponent<Button>();
        rigthBtn.onClick.AddListener(() => MoveRight());
    }

    void MoveLeft()
    {
        Vector3 rotate = camera.transform.eulerAngles;
        Debug.Log(rotate.y);
        rotate.y = rotate.y - 10;
        camera.transform.eulerAngles = rotate;
    }
    void MoveRight()
    {
        Vector3 rotate = camera.transform.eulerAngles;
        Debug.Log(rotate.y);
        rotate.y = rotate.y + 10;
        camera.transform.eulerAngles = rotate;

    }
    void MoveUp()
    {
        Vector3 rotate = camera.transform.eulerAngles;
        Debug.Log(rotate.x);
        rotate.x = rotate.x - 10;
        camera.transform.eulerAngles = rotate;

    }
    void MoveDown()
    {
        Vector3 rotate = camera.transform.eulerAngles;
        Debug.Log(rotate.x);
        rotate.x = rotate.x + 10;
        camera.transform.eulerAngles = rotate;
    }
    void TaskOnclick()
    {

        //The Bullet instantiation happens here.
        GameObject Temporary_Bullet_Handler;
        Temporary_Bullet_Handler = Instantiate(Bullet, Bullet_Emitter.transform.position, Bullet_Emitter.transform.rotation) as GameObject;

        //Sometimes bullets may appear rotated incorrectly due to the way its pivot was set from the original modeling package.
        //This is EASILY corrected here, you might have to rotate it from a different axis and or angle based on your particular mesh.
        Temporary_Bullet_Handler.transform.Rotate(Vector3.left * 90);

        //Retrieve the Rigidbody component from the instantiated Bullet and control it.
        Rigidbody Temporary_RigidBody;
        Temporary_RigidBody = Temporary_Bullet_Handler.GetComponent<Rigidbody>();

        //Tell the bullet to be "pushed" forward by an amount set by Bullet_Forward_Force. 
        Temporary_RigidBody.AddForce(transform.forward * Bullet_Forward_Force);

        //Basic Clean Up, set the Bullets to self destruct after 10 Seconds, I am being VERY generous here, normally 3 seconds is plenty.
        Destroy(Temporary_Bullet_Handler, 10.0f);
    }

    // Update is called once per frame

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        Debug.Log("name : "+col.gameObject.name);
        Debug.Log("tag : " +col.gameObject.tag);
        if(col.gameObject.name == "mob")
        {
            Destroy(col.gameObject);
        }
        
    }
}

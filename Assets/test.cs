using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject enemi;
    public Camera camera;
    public float xPos;
    public float zPos;
    public int enemyCount;
    public int nbSpawn;
    // Start is called before the first frame update
    void Start()
    {
        nbSpawn = 1;
        spawnEnemi(nbSpawn);
    }

    // Update is called once per frame
    void Update()
    {
        if(enemyCount == 0 )
        {
            nbSpawn +=1;
            spawnEnemi(nbSpawn);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        if(other.gameObject.name.Contains("mob"))
        {
            Destroy(other.gameObject);
            enemyCount -=1;
        }
            
        
    }

    public void spawnEnemi(int i)
    {
        while(enemyCount < i)
        {
            xPos = Random.Range(camera.transform.position.x-10, camera.transform.position.x +10);
            zPos = Random.Range(camera.transform.position.z-10, camera.transform.position.z +10);
            enemyCount +=1 ;
            Instantiate(enemi, new Vector3(xPos,0,zPos), Quaternion.identity);            
        } 
    } 
}
      


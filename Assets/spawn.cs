﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject enemi;
    public GameObject create;
    public float xPos;
    public float zPos;
    public int enemyCount;
    public int nbSpawn;
    
    void Start()
    {
        nbSpawn = 1;
        spawnEnemi(nbSpawn);
    }

    public void spawnEnemi(int i)
    {
        while(enemyCount < i)
        {
            xPos = Random.Range(this.transform.position.x-10, this.transform.position.x +10);
            zPos = Random.Range(this.transform.position.z-10, this.transform.position.z +10);
            enemyCount +=1 ;
            Instantiate(enemi, new Vector3(xPos,0,zPos), Quaternion.identity);            
        } 
    }

    void Update()
    {
        if(enemyCount == 0 )
        {
            nbSpawn +=1;
            spawnEnemi(nbSpawn);
        }
    }
    
}
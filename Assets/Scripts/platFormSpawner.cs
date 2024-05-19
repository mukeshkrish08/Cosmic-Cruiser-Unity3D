using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platFormSpawner : MonoBehaviour
{
    public GameObject platform;
    Vector3 nextspawnpoint;
    public static platFormSpawner instance;
    public void Awake()
    {
        instance = this;
    }

    void Start()
    {
        for(int i = 0; i < 15; i++)
        {
            SpawnPlatform();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void SpawnPlatform() 
    {
        GameObject temp =   Instantiate(platform,nextspawnpoint, Quaternion.identity);
        nextspawnpoint = temp.transform.GetChild(1).transform.position;
    }
   

}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obstacle;
    public GameObject coin;
    void Start()
    {
        SpawnObstracle();
        SpawnCoins();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        platFormSpawner.instance.SpawnPlatform();
        Destroy(gameObject,3f );   
    }

    public void SpawnObstracle()
    {
        int rand = Random.Range(2, 5);
        Transform spawnpoint = transform.GetChild(rand);
        Instantiate(obstacle, spawnpoint.position, Quaternion.identity, transform);
        Debug.Log("Item spawned at: " + spawnpoint.position);
    }
    public void SpawnCoins() 
    {
        int rand = Random.Range(6, 11);
        Transform spawnpoint = transform.GetChild(rand);
        Instantiate(coin, spawnpoint.position, coin.transform.rotation,transform);
        Debug.Log("Item spawned at: " + spawnpoint.position);
    }
}

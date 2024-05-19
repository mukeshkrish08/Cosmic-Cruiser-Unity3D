using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    public Transform player;
    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.position ;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetpos = player.position + offset ;
          targetpos.x = 11;
        transform.position = targetpos ;
    }

}

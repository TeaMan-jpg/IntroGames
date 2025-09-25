using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCameraPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    public Vector3 offset;


    void Start()
    {
        Debug.Log(player.position);
        Debug.Log(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = player.position + new Vector3(1, 2, -5);
        transform.position = player.position + offset;
    }
}

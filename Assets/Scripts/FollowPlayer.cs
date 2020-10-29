using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    private Transform playerPos;
    public GameObject player;
    
    // Start is called before the first frame update
    void Awake()
    {
        playerPos = player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(playerPos.position.x,playerPos.position.y,transform.position.z);
    }
}

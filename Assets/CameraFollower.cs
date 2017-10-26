
using UnityEngine;
using System.Collections;

public class CameraFollower : MonoBehaviour
{

    private Transform player;

    void Start()
    {
        player = GameObject.Find("abilius").transform;
    }

    void Update()
    {
        Vector3 playerpos = player.position;
        playerpos.z = transform.position.z;
        playerpos.y = transform.position.y;
        transform.position = playerpos;
    }
}
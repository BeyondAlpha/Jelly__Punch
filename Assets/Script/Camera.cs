using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    GameObject player;

    public float startX; 
    public float endX;
    public float startY;
    public float endY;
    public float paddingX;
    public float paddingY;

    void Start()
    {
        player = GameObject.Find("Cat");
    }

    // Update is called once per frame
    void Update()
    {
        if( startX <= player.transform.position.x && player.transform.position.x < endX)
        {
            transform.SetPositionAndRotation(new Vector3(player.transform.position.x + paddingX, transform.position.y , player.transform.position.z - 10), Quaternion.identity);
        }
        if ( startY < player.transform.position.y && player.transform.position.y < endY )
        {
            transform.SetPositionAndRotation(new Vector3(transform.position.x , player.transform.position.y + paddingY ,player.transform.position.z - 10), Quaternion.identity);
        }
    }
}

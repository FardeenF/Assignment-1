using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public float dragTime = 0.4f;
    public float xOffset = 0.0f;
    public float yOffset = 0.0f;
    private Vector3 cameraPos;
    private Vector3 velocity = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
        cameraPos = new Vector3(player.position.x + xOffset, player.position.y + yOffset, -10.0f);
        transform.position = Vector3.SmoothDamp(gameObject.transform.position, cameraPos, ref velocity, dragTime);
    }
}

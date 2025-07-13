using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private float CamDistance = -30;
    public Transform player;
    void Update()
    {
        transform.position = new Vector3(player.position .x, player.position.y, CamDistance);


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mud : MonoBehaviour
{
    public PlayerMovement script;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            script.RunSpeed = 3;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        script.RunSpeed = 8;
    }
}

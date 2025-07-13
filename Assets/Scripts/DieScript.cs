using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieScript : MonoBehaviour
{

    public PlayerLife script;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision .gameObject .CompareTag("trap"))
        {
            script.Die();
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("trap"))
        {
            script.Die();
        }
    }


}


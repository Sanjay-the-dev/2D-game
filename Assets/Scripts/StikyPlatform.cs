
using System.Linq;
using UnityEngine;

public class StikyPlatform : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision .gameObject .name== "Player")
        {

            collision.gameObject.transform.SetParent(transform);
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision .gameObject .name == "Player")
        {
            collision.gameObject.transform.SetParent (null );
        }
    }
}
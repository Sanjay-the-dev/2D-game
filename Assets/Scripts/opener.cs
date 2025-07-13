using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opener : MonoBehaviour
{

    public  GameObject Objects;

    // Start is called before the first frame update

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if( other.gameObject .name == "die collider")
        {
            Objects.SetActive(false);
        }

    }

}


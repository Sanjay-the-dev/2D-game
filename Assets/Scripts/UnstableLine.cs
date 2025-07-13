using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class UnstableLine : MonoBehaviour
{
    [SerializeField] private GameObject Unstableline;
    private SpriteRenderer sprite;
    private BoxCollider2D collider;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        collider = GetComponent<BoxCollider2D>();
    }
    private async void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name =="Player")

        {
            await Task.Delay(1500);
            Destroy(Unstableline);
            //  sprite.enabled = false;
            // collider.enabled = false;

        }


    }
   
}

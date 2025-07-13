using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCommand : MonoBehaviour
{

    [SerializeField] private GameObject[] waypoints;
    [SerializeField] private float speed = 2f;
  

    public SpriteRenderer sprite;
    private int currentwaypointindex;


    public void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        
    }
    void Update()
    {
        if (Vector2.Distance(waypoints[currentwaypointindex].transform.position, transform.position) < 0.1f)
        {
            currentwaypointindex++;
            if (currentwaypointindex >= waypoints.Length)
            {
                currentwaypointindex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentwaypointindex].transform.position, speed * Time.deltaTime);
        
        
       

    }
    private void OnTriggerEnter2D(Collider2D others)
    {
        if(others .gameObject.CompareTag("FlipOn"))
        {
            sprite.flipX = true;
        }
        if (others.gameObject.CompareTag("FlipOff"))
        {
            sprite.flipX = false;
        }
    }
}

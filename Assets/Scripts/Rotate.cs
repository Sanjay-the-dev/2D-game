using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
   
    [SerializeField] float x = 2f;
    [SerializeField] float y = 2f;
    [SerializeField] float z = 2f;
    void Update()
    {
        transform.Rotate(360 * x* Time .deltaTime , 360*y* Time .deltaTime , 360 * z * Time.deltaTime);
    }
}

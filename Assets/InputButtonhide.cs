using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InputButtonhide : MonoBehaviour
{

    [SerializeField] private GameObject InputButton;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fruitcollector"))
        {
            InputButton.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class SelfDestroy : MonoBehaviour
{

    [SerializeField] int delay = 1000;
    [SerializeField] GameObject turnon;
    // Start is called before the first frame update
    void Start()
    {

    }

   
    async void Update()
    {
        await Task.Delay(delay);

        gameObject.SetActive(false);
        turnon .SetActive(true);

    }
}

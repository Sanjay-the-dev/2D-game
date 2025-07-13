using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class buttons_on : MonoBehaviour
{

    public GameObject[] buttonsOn;
    public GameObject[] buttonOff;

    
    // Start is called before the first frame update
   

    // Update is called once per frame
    async void  Start()
    {
        for (int i = 0; i < buttonOff.Length; i++)
        {
            buttonOff[i].SetActive(false);
        }
        await Task.Delay(4000);
       for(int i = 0; i < buttonsOn.Length; i++)
        {
            buttonsOn[i].SetActive(true);
        }
      

    }
}

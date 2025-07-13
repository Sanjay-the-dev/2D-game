using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Titletomenu : MonoBehaviour
{
    // Start is called before the first frame update
    async void Start()
    {
        await Task.Delay(7000);
        SceneManager.LoadScene(1);
        
    }

    // Update is called once per frame
    
}

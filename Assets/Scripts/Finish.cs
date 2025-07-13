using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{

   
    private void Update()
    {

    }
    private async void OnTriggerEnter2D(Collider2D collision)
    {
        await Task.Delay(5000);
        if (collision.gameObject.name == "die collider")
        {
            Debug.Log(" working");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

            int currentlevel = SceneManager.GetActiveScene().buildIndex;

            if (currentlevel >= PlayerPrefs.GetInt("levelsUnlocked"))
            {
                PlayerPrefs.SetInt("levelsUnlocked", currentlevel + 1);
            }
            Debug.Log("level" + PlayerPrefs.GetInt("levelsUnlocked") + "unlocked");


        }
    }

}

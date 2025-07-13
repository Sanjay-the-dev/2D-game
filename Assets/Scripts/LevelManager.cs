
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LevelManager : MonoBehaviour
{
     int levelsUnlocked;
    public Button[] buttons;
    public GameObject[] leveltext;

    // Update is called once per frame
    void Start()
    {
        levelsUnlocked = PlayerPrefs.GetInt("levelsUnlocked", 1);


        for(int i = 0; i< buttons.Length; i++)
        {
            buttons[i].interactable = false;
            leveltext[i].SetActive(true);
        }
        for(int i = 0;i< levelsUnlocked; i++)
        {
            buttons[i].interactable = true;
            leveltext[i].SetActive(false);
        }
    }
    
    public void LoadLevel(int levelindex)
    {
        SceneManager.LoadScene(levelindex);
        
    }
    public async void continuelevel()
    {
        await Task.Delay(200);
       SceneManager.LoadScene(levelsUnlocked);
    }

    

    public async void Resetgame()
    {
        PlayerPrefs.DeleteAll();
        await Task.Delay(1000);
        Application.Quit();
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}

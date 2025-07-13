
using System.Threading.Tasks;

using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausebutton;
    public GameObject PauseMenuUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
    public async void Retry()
    {
        await Task.Delay(500);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
        
    public void pause()
    {
        Debug.Log(" pause");
        Time.timeScale = 0f;
        PauseMenuUI .SetActive(true);
        pausebutton.SetActive(false);

    }

    public void Resume()
    {
        Time.timeScale = 1f;
        PauseMenuUI.SetActive(false);
        pausebutton.SetActive(true);
    }

    public async void loadmenu()
    {
        await Task.Delay(500);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main menu");
        
    }

    public void OnApplicationQuit()
    {
        
        Application .Quit();    
    }
}

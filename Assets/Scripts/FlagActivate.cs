using System.Threading.Tasks;

using UnityEngine;

public class FlagActivate : MonoBehaviour
{
    public AudioSource WinningCupSound;
    [SerializeField] private GameObject WinningCup;
    [SerializeField] private GameObject Flag;
    [SerializeField] private GameObject LevelCompeleted;
    [SerializeField] private GameObject InputButton;
    
    private Rigidbody2D rb;
    PlayerMovement Movementstate;



    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
      
    }
    private async void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag ("cup"))
        {
            WinningCupSound.Play(); 
            WinningCup .SetActive(false);
            InputButton.SetActive(false);
            Flag.SetActive(true);
            //  rb.bodyType = RigidbodyType2D.Static;
            await Task.Delay(500);
            GetComponent<PlayerMovement>().enabled = false;
            LevelCompeleted.SetActive(true);
            await Task.Delay(2000);
            GetComponent<Animator>().enabled = false;


        }
        

    }

   
}

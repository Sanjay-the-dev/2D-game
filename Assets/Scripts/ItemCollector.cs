
using System.Threading.Tasks;
using TMPro;

using UnityEngine;
using UnityEngine.UI;



public class ItemCollector : MonoBehaviour
{
    // public Text FruitText;
    public AudioSource FruitSound;
    public Animator animator;
    public PlayerMovement playerMovement;
    [SerializeField] private GameObject WinningCup;
    [SerializeField] private GameObject FruitsNotCollect;
    [SerializeField] private TextMeshProUGUI FruitText;
    [SerializeField] private GameObject FruitnotcollectTrigger;
    private int Fruits = 0;
    public Rigidbody2D rb;
    private async void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject .CompareTag("Apple"))
        {
            Destroy(collision.gameObject);
            FruitSound.Play();
            Fruits++;
            FruitText.text   = "Fruits: " + Fruits;

        }

        if(Fruits > 9)
        {
            WinningCup .SetActive(true);
            FruitnotcollectTrigger.SetActive(false);
          
            
        }
        if (collision.gameObject.CompareTag("FruitsNotCollect"))
        {
           

            Destroy(collision.gameObject);
          if(Fruits <= 9)
            {
               FruitsNotCollect.SetActive(true);
            }
            playerMovement.enabled = false;
            await Task.Delay (1000);
            animator.enabled = false;
            rb.bodyType = RigidbodyType2D.Static;
            // FruitsNotCollect.SetActive(true);
         

        }


    }
   


}

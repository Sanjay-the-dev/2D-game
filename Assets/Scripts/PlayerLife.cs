
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;


public class PlayerLife : MonoBehaviour
{

    [SerializeField] Joystick fixedjoystick;
    [SerializeField] GameObject border1;
    [SerializeField] GameObject border2;
    [SerializeField] PlayerMovement playermovement;
    public GameObject continueadbutton;
    public GameObject WatchAdbutton;
    public GameObject FruitsNotCollect;
    public GameObject DieCollider;
    public AudioSource DeadSound;
    Rigidbody2D    rb;
    private Animator anim;
  
    [SerializeField] GameObject Player;
    [SerializeField] GameObject Gameover;
    [SerializeField] GameObject InputButtonUI;
    [SerializeField] GameObject PauseButton;
    [SerializeField] GameObject FruitsText;

   

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("player Activated");
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
      
    }
   
    public void  Reloadlevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        

    }
    private async void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("trap"))
        {
            //collision.gameObject.tag="no trap";
            //Die();
            Debug.Log(" dead");


        }
       

        if (collision .gameObject.CompareTag("UnstableLine"))
        {
            await Task.Delay(2000);
            Destroy(collision.gameObject);
        }
           
    }

   public async void Die()
    {
        border1.SetActive(true); border2.SetActive(true);
       
        rb.velocity = Vector2.zero;
        fixedjoystick.handlezero();
        rb.velocity = new Vector2 (6,0);
        DeadSound.Play();
        anim.SetTrigger("death");
        rb.bodyType = RigidbodyType2D.Static;
        rb.constraints = RigidbodyConstraints2D.FreezePosition;
        GetComponent<BoxCollider2D>().enabled = false;
        Gameover.SetActive(true);
        InputButtonUI.SetActive(false);

        await Task.Delay(1000);
        anim.enabled = false;



    }



    public async void continueButton()
    {
       
        anim.SetTrigger("blink");
        rb.bodyType = RigidbodyType2D.Dynamic;
        GetComponent<BoxCollider2D>().enabled = true;
        Gameover.SetActive(false);
        DieCollider.SetActive(false);

       
        anim.SetTrigger("idle");
        FruitsText.SetActive(true);
        PauseButton.SetActive(true);
        continueadbutton.SetActive(false);
        InputButtonUI.SetActive(true);

        continueadbutton.SetActive(false);
        await Task.Delay(500);
        transform.eulerAngles = Vector3.zero;
        border1 .SetActive(false);
        border2 .SetActive(false);
        anim.enabled = true;
        rb.constraints = RigidbodyConstraints2D.None;
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        continueadbutton.SetActive(false);

        await Task.Delay(5500);
        transform.eulerAngles = Vector3.zero;
        anim.SetTrigger("idle");
        DieCollider.SetActive(true);
        continueadbutton.SetActive(false);



    }


  

    public void WatchAdfor()
    {
        rb.bodyType = RigidbodyType2D.Dynamic;
        GetComponent<BoxCollider2D>().enabled = true;
        FruitsNotCollect.SetActive(false);

        InputButtonUI.SetActive(true);

        WatchAdbutton.SetActive(false);
        // continueadbutton.gameObject .SetActive(false);
        GetComponent<PlayerMovement>().enabled = true;
        GetComponent<Animator>().enabled = true;
        DieCollider.SetActive(true);
        FruitsText.SetActive(true);
        PauseButton.SetActive(true);
       
    }
}

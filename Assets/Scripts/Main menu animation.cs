using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;

public class Mainmenuanimation : MonoBehaviour
{
    public Animator anim;
    [SerializeField] Button button;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();    
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonBack()
    {
        anim.SetBool("back",true);
    }


}

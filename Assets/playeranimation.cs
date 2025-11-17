using UnityEngine;

public class playeranimation : MonoBehaviour
{
    Animator gidsonsanimator;
    
    void Start()
    {
        gidsonsanimator = GetComponent<Animator>();
        
        gidsonsanimator.SetBool("playerwalk", false);
    }

    void Update()
    {
        if (Input.GetKeyDown("a") | Input.GetKeyDown("d"))
        {
            gidsonsanimator.SetBool("playerwalk", true);
        }
        
        if (Input.GetKeyUp("a") | Input.GetKeyUp("d"));
            gidsonsanimator.SetBool("playerwalk", false);
        }
}
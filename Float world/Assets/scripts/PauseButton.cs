using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton : MonoBehaviour
{
    
    public GameObject PauseMenu;
    //public GameObject ShadowMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pause()
    {

        
        PauseMenu.GetComponent<Animator>().SetBool("Pause", true);
        //ShadowMenu.GetComponent<Animator>().SetBool("Active", true);
    }

}

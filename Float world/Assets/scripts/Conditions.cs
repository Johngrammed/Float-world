using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditions : MonoBehaviour
{
   
    public GameObject Green;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = Green.GetComponent<Animator>();
    }

    // Update is called once per frame

    public void WinTimer()
    {
        anim.SetBool("Win", true);
    }




    void Update()
    {
        
    }
}

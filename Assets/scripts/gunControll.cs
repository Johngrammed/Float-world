using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunControll : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void JumpState()
    {
        GetComponent<Transform>().localPosition = new Vector2(1.045f, 0.305f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

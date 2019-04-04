using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wooden : MonoBehaviour
{
    public GameObject RestartButton;
    public GameObject Green;
    // Start is called before the first frame update
    void Start()
    {
       //anim = Green.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -17f)
        {
            Destroy(gameObject);
        }
    }

    void OnDestroy()
    {
        GameObject[] Wood = GameObject.FindGameObjectsWithTag("Wood");
        if (Wood.Length < 1 && RestartButton != null && GameObject.Find("Green") != null)
        {
            GameObject.Find("Green").GetComponent<Ball>().Win = true;
        }
    }

    void OnMouseDown()
    {
        Destroy(gameObject);
    }
}

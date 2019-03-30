using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud1 : MonoBehaviour
{
    // Start is called before the first frame update
    private bool RightToLeft;
    void Start()
    {
        if (Random.Range(0, 2) == 1)
        {
             transform.position = new Vector3(-11f, Random.Range(-3f, 4f), 10f);
             RightToLeft = true;
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
        else
        {
             transform.position = new Vector3(11f, Random.Range(-3f, 4f), 10f);
             RightToLeft = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 11f  || transform.position.x < -11f)
        {
            Destroy(gameObject);
        }

        if (RightToLeft)
        {
            transform.position = new Vector3(GetComponent<Transform>().position.x + .01f, GetComponent<Transform>().position.y, GetComponent<Transform>().position.z);
        }
        else
        {
            transform.position = new Vector3(GetComponent<Transform>().position.x - .01f, GetComponent<Transform>().position.y, GetComponent<Transform>().position.z);
        }
    }
}

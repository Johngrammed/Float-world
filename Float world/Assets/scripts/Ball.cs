using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator anim;
    private bool isGrounded = false;
    public Transform groundCheck;
    private float groundRadius = 1.4f;
    public LayerMask whatIsGround;
    public GameObject RestartButton;
    public GameObject HomeButton;
    public GameObject Count;
    public bool Win = false;
    private float timeInSecondsP = 0;
    private int secondsP;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        anim.SetBool("Ground", isGrounded);
        anim.SetFloat("Speed", GetComponent<Rigidbody2D>().velocity.magnitude);
    }

    void Lose()
    {
        GameObject[] Greens = GameObject.FindGameObjectsWithTag("Player");
        if(Greens.Length < 2 && RestartButton != null)
        {
            RestartButton.gameObject.GetComponent<RectTransform>().anchorMin = new Vector2(0.8054157f, 0.6514458f);

            //HomeButton.gameObject.GetComponent<RectTransform>().anchorMin = new Vector2(0.03524253f, 0.6514458f);
            //HomeButton.gameObject.GetComponent<RectTransform>().anchorMax = new Vector2(0.196f, 0.9375001f);
        }


    }

    void OnDestroy()
    {

        Lose();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -14f)
        {
            Destroy(gameObject);
            Destroy(Count);
        }

        if(Win)
        {
            if(Count != null)
            Count.GetComponent<Animator>().SetBool("Win", true);
            timeInSecondsP += Time.deltaTime;

            secondsP = (int)(timeInSecondsP % 60);
            if (secondsP >= 5)
            {
                anim.SetBool("Win", true);
                Destroy(Count);
            }
        }
    }
}

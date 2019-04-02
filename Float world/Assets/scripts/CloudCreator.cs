using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudCreator : MonoBehaviour
{
    public GameObject Cloud;
    public bool CloudOnScreen = false;

    private float timeInSecondsP = 35;
    private int minutesP;
    private int secondsP;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timeInSecondsP += Time.deltaTime;

        secondsP = (int)(timeInSecondsP % 60);
        if (secondsP >= 40)
        {
            Instantiate(Cloud);
            timeInSecondsP = Random.Range(0.0f, 10.0f);
        }
    }
}

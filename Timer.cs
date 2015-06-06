using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private float minutes, seconds, miliseconds;

    private float intTime;
    
    public Text label;

    // Update is called once per frame
    void Update()
    {
        intTime += Time.deltaTime;

        minutes = intTime / 60;
        seconds = intTime % 60;
        miliseconds = Time.deltaTime * 1000;
        miliseconds = miliseconds % 1000;

        if (label != null)
        {
            label.text = /*"Time is " +*/ (int)minutes + ":" + (int)seconds;
        }
    }
}

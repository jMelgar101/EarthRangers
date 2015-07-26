using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour
{

    public Image timerBar;
    public float increaseFillAmount;
    //float timekuno = 60;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timerBar.fillAmount -= increaseFillAmount * Time.deltaTime;
        //Debug.Log(timekuno -= Time.deltaTime);

        if (timerBar.fillAmount <= 0)
        {
            //Application.LoadLevel("next_scene");
            //Debug.Log("do nothing");
        }
        else
        {
            //Debug.Log("do nothing"); 
        }
    }
}

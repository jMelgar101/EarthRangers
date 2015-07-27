using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour
{

    public Image timerBar;
    public float increaseFillAmount;
    public FireTimer fireTimer;
    //float timekuno = 60;
    float tenSeconds = 10;
    bool isClicked = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timerBar.fillAmount -= increaseFillAmount * Time.deltaTime;
        Debug.Log(timerBar.fillAmount);
        tenSeconds -= Time.deltaTime;
        //Debug.Log(tenSeconds);

        if (timerBar.fillAmount <= 0)
        {
            Application.LoadLevel("createjointeam");
        }
        else
        {
            this.checkTime();
        }
    }

    public void OnClick()
    {
        this.isClicked = true;
    }

    void checkTime()
    {
        if (tenSeconds < 1)
        {
            Debug.Log(tenSeconds);
            Debug.Log("FAIL!");
            this.timerBar.fillAmount -= 0.01f;
            //FireTimer.

            this.tenSeconds = 10;
        }
        else
        {
            if (this.isClicked == true)
            {
                Debug.Log("TRUE!");
                this.isClicked = false;
                this.tenSeconds = 10;
            }
        }

    }
}

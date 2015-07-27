using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour
{

    public Image timerBar;
    public float increaseFillAmount;
    static int points;
    //float timekuno = 7;
    float oneMinute = 60;
    bool isClicked = false;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timerBar.fillAmount -= increaseFillAmount * Time.deltaTime;
        oneMinute -= Time.deltaTime;

        if (this.oneMinute <= 0)
        {
            if (points < 20)
            {
                Application.LoadLevel("createjointeam");
            }
            else
            {
                //Application.LoadLevel("createjointeam");
                Debug.Log("congrats!");
                Debug.Log(points);
            }
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
        if (timerBar.fillAmount <= 0)
        {
            Debug.Log("FAIL!");
            this.timerBar.fillAmount -= 0.01f;
            //fire.transform.Translate(new Vector3(0, 0, 0) * Time.deltaTime * 0.721111f);
            this.timerBar.fillAmount = 1;
        }
        //else if (timerBar.fillAmount <= 0)
        //{

        //}
        else
        {
            if (this.isClicked == true)
            {
                Debug.Log("TRUE!");
                points++;
                this.isClicked = false;
                this.timerBar.fillAmount = 1;
            }
        }

    }
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Play : MonoBehaviour
{
    //public Camera mainCamera;
    //public Image landingPageRotate = null;
    //public Texture landingPageBg = null;

    public GUISkin skin;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnGUI()
    {
        GUI.skin = skin;
        if (GUI.Button(new Rect(Screen.width / 2 - 100, Screen.height / 2, 200, 50), "PLAY!"))
        {
            Application.LoadLevel("createjoin");
            Debug.Log("Entring create/join team");
        }
    }
}

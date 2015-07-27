using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Play : MonoBehaviour
{
    public Button play;

    void Start()
    {
        play.onClick.AddListener(nextPage);
    }

    void nextPage() {
        Application.LoadLevel("createjointeam");
    }
}

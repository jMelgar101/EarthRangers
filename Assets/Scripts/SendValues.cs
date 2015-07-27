using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(PhotonView))]
public class SendValues : Photon.MonoBehaviour
{

    public bool IsVisible = true;

    public List<string> messages = new List<string>();
    private string inputLine = "";
    private Vector2 scrollPos = Vector2.zero;
    public Button button1;

    public static readonly string ChatRPC = "Chat";

    public void OnGUI()
    {
        if (!this.IsVisible || PhotonNetwork.connectionStateDetailed != PeerState.Joined)
        {
            return;
        }



    }

    public void press()
    {
        this.inputLine = button1.name;
        Debug.Log(this.inputLine);
        this.photonView.RPC("Chat", PhotonTargets.All, this.inputLine);
    }

    [PunRPC]
    public void Chat(string newLine, PhotonMessageInfo mi)
    {
        string senderName = "anonymous";

        if (mi != null && mi.sender != null)
        {
            if (!string.IsNullOrEmpty(mi.sender.name))
            {
                senderName = mi.sender.name;
            }
            else
            {
                senderName = "player " + mi.sender.ID;
            }
        }
        Debug.Log(newLine);
        this.messages.Add(senderName + ": " + newLine);
    }

    public void AddLine(string newLine)
    {
        this.messages.Add(newLine);
    }

}
using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviourPunCallbacks
{
    
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    
   

    public override void OnConnectedToMaster()
    {
        SceneManager.LoadScene("Menu");
    }
}

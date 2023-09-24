using System;
using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class Spawn : MonoBehaviour
{
   

   public void Start()
   {
      PhotonNetwork.Instantiate("Player", new Vector3(0, 0,0), Quaternion.identity );
   }
}

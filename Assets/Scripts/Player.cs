using System;
using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private float speed = 8;
    private PhotonView View => GetComponent<PhotonView>();

    private void Update()
    {
        if (View.IsMine)
        {
            Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            Vector2 moveAmount = moveInput.normalized * speed * Time.deltaTime;
            transform.position += (Vector3) moveAmount;
        }
    }
}

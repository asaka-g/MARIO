using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DOKAN : MonoBehaviour{
    public Transform gopoint;
    //マリオとの接触状態確認/*
    public void OnCollisionStay2D(Collision2D collision) {
        if (collision.gameObject.GetComponent<MARIO>() && Input.GetKey(KeyCode.DownArrow)){
            collision.gameObject.transform.position=gopoint.position;
        }
    }
}

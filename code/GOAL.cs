using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GOAL : MonoBehaviour{
    MARIO script;
    private int num=0;
    // マリオがゴールに着地したらマリオは停止
    public void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.GetComponent<MARIO>()) {
            SceneManager.LoadScene("Hyousi");             
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GIGKUPPA : MonoBehaviour{
    GameObject KUPPA;
    KUPPA script; 
    void Start () {
        KUPPA= GameObject.Find ("KUPPA"); 
        script = KUPPA.GetComponent<KUPPA>(); 
    }
    public void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.GetComponent<MARIO>()) {
            script.CHANGE_TO_FIRST();
        }
    }
}

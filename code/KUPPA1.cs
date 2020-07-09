using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KUPPA1 : KUPPA{
    public void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.GetComponent<MARIO>()) {
            CHANGE_TO_FIRST();
        }
    }
}

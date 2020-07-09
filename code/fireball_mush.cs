using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireball_mush : MonoBehaviour{
    //マリオに炎が当たる
    public void OnCollisionEnter2D(Collision2D collision) {
        Destroy(gameObject,0);
        if(collision.gameObject.GetComponent<MARIOYOSSY>()) {
            collision.gameObject.GetComponent<MARIOYOSSY>().DIE();
        }else if (collision.gameObject.GetComponent<MARIO>()) {
            collision.gameObject.GetComponent<MARIO>().DIE();
        }
    }
}

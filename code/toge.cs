using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toge : MonoBehaviour{
    public float move=0.01f;
    //マリオにトゲゾーが当たる
    public void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.GetComponent<MARIO>()) {
            collision.gameObject.GetComponent<MARIO>().DIE();
        }
        if (collision.gameObject.GetComponent<MARIOYOSSY>()) {
            collision.gameObject.GetComponent<MARIOYOSSY>().DIE();
        }
        move=-move;
    }
    //トゲゾーは何かに衝突したら向きを変える
    void Update(){
        Vector3 pos=transform.position;
        pos.x+=move;
        transform.position=pos;
    }
}

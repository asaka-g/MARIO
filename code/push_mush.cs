using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class push_mush : mush{
    //マリオに縦向きで当たる
    public void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.GetComponent<MARIO>()){
            Destroy(transform.parent.gameObject,0);
        }
        if (collision.gameObject.GetComponent<MARIOYOSSY>()){
            Destroy(transform.parent.gameObject,0);
        }
    }
    void Update (){
        transform.localPosition = new Vector3(0.0f,0.5f,0.0f);
    }
}
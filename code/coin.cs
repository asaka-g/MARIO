using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour{
    //相手がマリオだったら自分を消す
    public void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.GetComponent<MARIO>()){
            Destroy(gameObject,0);
        }
    }
}

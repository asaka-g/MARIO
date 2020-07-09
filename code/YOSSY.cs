using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YOSSY : MonoBehaviour{
    public GameObject camera;
    public GameObject MARIOYOSSY;
    public Transform spawnpoint;
    void Update(){    
    }
    //相手がマリオだったら、自分と相手を消して新しいオブジェクトをつくる
    public void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.GetComponent<MARIO>()){
            GameObject NEWMARIIOYOSSY=Instantiate(MARIOYOSSY,spawnpoint.position,Quaternion.identity) as GameObject;
            Destroy(collision.gameObject,0);
            Destroy(gameObject,0);
        }
    }
}
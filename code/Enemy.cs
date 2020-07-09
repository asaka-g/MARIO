using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour{
    float move=-0.03f;
    float run=-0.02f;    
    private Vector3 first_position;
	void Start () {
        first_position = transform.position;
	}
    //マリオに横向きで当たる、相手は死ぬが自分も死ぬ
    public void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.GetComponent<MARIOYOSSY>()) {
            Destroy(gameObject,0);
            collision.gameObject.GetComponent<MARIOYOSSY>().DIE();
        }else if (collision.gameObject.GetComponent<MARIO>()) {
            Destroy(gameObject,0);
            collision.gameObject.GetComponent<MARIO>().DIE();
        }
    }
    //マリオに縦向きで当たると死ぬ
    public void DIE(){
        Destroy(gameObject,0);
    }
    //落下の場合は元の位置に戻す
    public void DIE_OUT(){
        transform.position=first_position;
    }
}

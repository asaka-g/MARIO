using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KUPPA :  MonoBehaviour{
    public float power=1000f;
    public GameObject mush_fire;
    public Transform spawnpoint1;
    public Transform spawnpoint2;
    private SpriteRenderer UsingSprite;
    public Sprite FirstSprite;
    public Sprite SecondSprite;
    private const float START_SECONDS = 0.0f;
    private const float INTERVA_SECONDS = 3.0f;
    private float deleteTime=3.0f;
    private int judge=1;
    //redmushはINTERVA_SECONDSごとに火を放つ、deleteTimeで消える
    void Shoot(){
        if(judge==1){
            GameObject newfire=Instantiate(mush_fire,spawnpoint1.position,Quaternion.identity) as GameObject;
            newfire.GetComponent<Rigidbody2D>().AddForce((Vector3.left)*power);
            Destroy(newfire,deleteTime);
        }else{
            GameObject newfire=Instantiate(mush_fire,spawnpoint2.position,Quaternion.identity) as GameObject;
            newfire.GetComponent<Rigidbody2D>().AddForce((Vector3.right)*power);
            Destroy(newfire,deleteTime);
        }
    }
    void Start(){
        InvokeRepeating("Shoot", START_SECONDS, INTERVA_SECONDS);
        UsingSprite=gameObject.GetComponent<SpriteRenderer>();
    }
    //クッパはマリオの位置に合わせて回転する
    public void CHANGE_TO_FIRST(){
        UsingSprite.sprite = FirstSprite;
        judge=1;
    }
    public void CHANGE_TO_SECOND(){
        UsingSprite.sprite = SecondSprite;
        judge=2;
    }
    public void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.GetComponent<MARIO>()) {
            collision.gameObject.GetComponent<MARIO>().DIE();
        }
        if (collision.gameObject.GetComponent<MARIOYOSSY>()) {
            collision.gameObject.GetComponent<MARIOYOSSY>().DIE();
        }
    }
}

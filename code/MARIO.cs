using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MARIO : MonoBehaviour{
    float run=0.02f;
    float move = 0.05f;
    private const float START_SECONDS = 2.0f;
    private const float INTERVA_SECONDS = 0.01f;
    void Update(){
        //マリオのジャンプ動作
        Vector3 pos=transform.position;
        //マリオの動きに合わせて左右する
        if(Input.GetKey(KeyCode.LeftArrow)){
            pos.x-=move;
            if(Input.GetKey(KeyCode.LeftShift)){
                pos.x-=run;
            }
        }else if(Input.GetKey(KeyCode.RightArrow)){
            pos.x+=move;
            if(Input.GetKey(KeyCode.LeftShift)){
                pos.x+=run;
            }
        }
        if(Input.GetKey(KeyCode.UpArrow)){
            pos.y+=move;
        }
        transform.position=pos;
        //落ちたら死ぬ
        if(pos.y<-10){
            DIE();
        }
    }
    
    //敵に当たると死ぬ
    public void DIE(){
        SceneManager.LoadScene("Hyousi");    
        Destroy(gameObject,0);
    }
}

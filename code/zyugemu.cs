using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class zyugemu : Enemy{
    public float move=0.03f;
    private Vector3 first_pos;
    public GameObject toge;
    public Transform spawnpoint;
    private const float START_SECONDS = 0.0f;
    private const float INTERVA_SECONDS = 30.0f;
    //じゅげむはトゲゾーを製造
    void Shoot(){
        GameObject new_toge=Instantiate(toge,spawnpoint.position,Quaternion.identity) as GameObject;
    }
    void Start(){
        InvokeRepeating("Shoot", START_SECONDS, INTERVA_SECONDS);
        first_pos=transform.position;
    }
    //じゅげむは左右に動く
    void Update(){
        Vector3 pos=transform.position;
        if(Math.Abs(first_pos.x-pos.x)>8f){
            move=-move;
        }
        pos.x+=move;
        transform.position=pos;
    }
}

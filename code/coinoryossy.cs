using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinoryossy : block23 {
    private float deleteTime=10.0f;
    public Transform spawnpoint2;
    public GameObject obj;
    public void Reverse(){
        GameObject newobj=Instantiate(obj,spawnpoint2.position,Quaternion.identity) as GameObject;
    }
    void Update (){
        transform.localPosition = new Vector3(0.0f,0.5f,0.0f);
    }
}

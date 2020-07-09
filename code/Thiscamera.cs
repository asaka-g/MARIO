
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using UnityEngine.SceneManagement;
public class Thiscamera : MonoBehaviour{
    private GameObject player;
    private Vector3 offset;
	void Start () {
        this.player = GameObject.Find("MARIO");
        offset = transform.position - player.transform.position;
	}
	void Update () {
        Vector3 pos;
        //これでマリオにもマリオヨッシーにも対応
        if(this.player==null){
            this.player=GameObject.Find("MARIOYOSSY(Clone)");
        }
        if(this.player==null){
            this.player=GameObject.Find("MARIO(Clone)");
        }
        if(this.player==null){
            SceneManager.LoadScene("Hyousi");  
        }else{
        pos=player.transform.position + offset;
        pos.y=0;
        transform.position = pos;
        }
	}
}
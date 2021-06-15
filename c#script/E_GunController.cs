using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_GunController : MonoBehaviour
{
    GameObject player;
   
    void Start()
    {
        player = GameObject.Find("Player");
    }
     
    void Update()
    {
       
        Vector3 dir;
        dir = player.transform.position - this.transform.position; //벡터 뺄셈일 이용해서 player 와 포탑의 거리를 계산(x,y,z) 값
        Quaternion ratation = Quaternion.LookRotation(-1 * dir);// 회전값을 계산
        Debug.Log(dir);
        this.transform.rotation = ratation; // 회전값을 현재(스크립트가 속한) 오브젝트의 transfom Rotation 값에 대입
           } 

}

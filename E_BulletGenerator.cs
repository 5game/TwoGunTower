using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//bulletPrefab으로 만든 오브젝트가 Player 오브젝트가 있는 위치와 방향으로 날아가는 스크립트
public class E_BulletGenerator : MonoBehaviour
{
    public GameObject bulletPrefab; //bulletPrefab Public 변수 선언
    GameObject player; //player 변수 선언
    private void Start()
    {
        player = GameObject.Find("Player"); //Player 라는 이름의 GameObject 를 변수 player 에 대입 
    }

    void Update()
    {
        Vector3 dir; //dir 변수 선언
        dir = player.transform.position - this.transform.position; //벡터의 뺄셈을 이용해서 플레이어와 포탑의 거리값을 dir에 대입한다.
       
        if (Input.GetMouseButtonDown(0)) //마우스 왼쪽 버튼을 눌렀다면
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation); // 총알(이 스크립트가 속해 있는 게임 오브젝트의 Transform)이 정해진 위치에서 발사
            //GameObject bullet = Instantiate(bulletPrefab); //총알이 바닥에서 발사
            bullet.GetComponent<BulletController>().Shoot (dir*50);
        }       
    }
}

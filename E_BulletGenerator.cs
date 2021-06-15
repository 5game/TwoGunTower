using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//bulletPrefab���� ���� ������Ʈ�� Player ������Ʈ�� �ִ� ��ġ�� �������� ���ư��� ��ũ��Ʈ
public class E_BulletGenerator : MonoBehaviour
{
    public GameObject bulletPrefab; //bulletPrefab Public ���� ����
    GameObject player; //player ���� ����
    private void Start()
    {
        player = GameObject.Find("Player"); //Player ��� �̸��� GameObject �� ���� player �� ���� 
    }

    void Update()
    {
        Vector3 dir; //dir ���� ����
        dir = player.transform.position - this.transform.position; //������ ������ �̿��ؼ� �÷��̾�� ��ž�� �Ÿ����� dir�� �����Ѵ�.
       
        if (Input.GetMouseButtonDown(0)) //���콺 ���� ��ư�� �����ٸ�
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation); // �Ѿ�(�� ��ũ��Ʈ�� ���� �ִ� ���� ������Ʈ�� Transform)�� ������ ��ġ���� �߻�
            //GameObject bullet = Instantiate(bulletPrefab); //�Ѿ��� �ٴڿ��� �߻�
            bullet.GetComponent<BulletController>().Shoot (dir*50);
        }       
    }
}

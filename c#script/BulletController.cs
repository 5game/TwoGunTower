using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      /*  if (Input.GetMouseButtonDown(0))
        {
            Shoot(new Vector3(0, 0, 500));
        } */
    }
        public void Shoot (Vector3 dir)
        {
            GetComponent<Rigidbody>().AddForce(dir);
        }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "ENEMY")
        {
            Destroy(gameObject, 0.2f);
        }
        if (collision.collider.tag == "Player")
        {
            Destroy(gameObject, 0.2f);
            Rigidbody playerRd = GameObject.Find("Player").GetComponent<Rigidbody>();
            playerRd.constraints = RigidbodyConstraints.FreezePosition;
        }
    }
}

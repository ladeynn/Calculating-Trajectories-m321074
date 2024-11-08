using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireShell : MonoBehaviour {

    public GameObject bullet;
    public GameObject turret;
    public GameObject enemy;

    private float rotSpeed = 2.0f;

    void CreateBullet() {

        Instantiate(bullet, turret.transform.position, turret.transform.rotation);
    }

    void Update() {
        Vector3 direction = (enemy.transform.position - this.transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0.0f, direction.z));
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation, lookRotation, Time.deltaTime * rotSpeed);
        if (Input.GetKeyDown(KeyCode.Space)) {
       
                CreateBullet();
            
        }
    }

    
}

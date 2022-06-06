using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform firePoint;
    public GameObject bulletPrefab;
    
    public float bulletForce = 20f;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        
        Vector3 screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 direction = (Vector3)(Input.mousePosition-screenPoint);
        direction.Normalize();

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        rb.AddForce(direction* bulletForce, ForceMode2D.Impulse);

    }
}

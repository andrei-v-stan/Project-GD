using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    void Start(){

        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y);

        Vector3 screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 direction = (Vector3)(mousePosition - screenPoint);
        direction.Normalize();

        //transform.rotation = Quaternion.LookRotation(Vector3.forward, direction.y);
              this.transform.Rotate(0,0, direction.z);

        //this.transform.Rotate(Vector3.up, direction.y);

    }

    //public GameObject hitEffect;
    
    void OnCollisionEnter2D(Collision2D collision)
    {

       //GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity);
        //Destroy(effect, 3f);
        Destroy(gameObject);
    }

}

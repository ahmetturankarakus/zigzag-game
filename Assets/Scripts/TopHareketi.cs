using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopHareketi : MonoBehaviour
{

    Vector3 yon;
    public float hiz;
    public ZeminSpawner zeminspawnerscripti;

    void Start()
    {
        yon = Vector3.forward;
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (yon.x == 0)
            {
                yon = Vector3.left;
            }
            else
            {
                yon = Vector3.forward;
            }
        }
    }


    private void FixedUpdate()
    {

        Vector3 hareket = yon * Time.deltaTime * hiz;
        transform.position += hareket;
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "zemin")
        {
            zeminspawnerscripti.zemin_olustur();
        }
    }
}

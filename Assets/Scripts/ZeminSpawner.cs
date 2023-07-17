using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminSpawner : MonoBehaviour
{

    public GameObject son_zemin;


    private void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            zemin_olustur();
        }
    }

    public void zemin_olustur()
    {
        Vector3 yon;
        if (Random.Range(0,2) == 0)
        {
            yon = Vector3.left;
        }

        else
        {
            yon = Vector3.forward;
        }
        son_zemin = Instantiate(son_zemin, son_zemin.transform.position + yon, son_zemin.transform.rotation);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engelobjem : MonoBehaviour
{
    int CarpmaSayisi = 3;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("agent"))
        {
            if (CarpmaSayisi != 0)
            {
                CarpmaSayisi--;
            }
            else
            {
                Destroy(gameObject);
            }
        }
        

    }
}

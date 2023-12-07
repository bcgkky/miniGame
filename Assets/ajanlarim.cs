using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ajanlarim : MonoBehaviour
{
    public GameObject hedef;
    NavMeshAgent agent;
    public string seviye;
    int carpmasayisi;
    float darbegucu;
    public GameObject gamekontrol;
    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(hedef.transform.position);

        switch (seviye)
        {
            case "Mavi":
                carpmasayisi = 4;
                darbegucu = 16f;
                break;

            case "Sari":
                carpmasayisi = 3;
                darbegucu = 12f;
                break;

            case "Mor":
                carpmasayisi = 2;
                darbegucu = 8f;
                break;

        }
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("engel"))
        {
            if (carpmasayisi != 0)
            {
                carpmasayisi--;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        if (other.gameObject.CompareTag("anahedef"))
        {
            gamekontrol.GetComponent<gamekontrol>().CanDusur(darbegucu);
            Destroy(gameObject);
        }
    }
}

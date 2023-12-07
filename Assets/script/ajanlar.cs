using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ajanlar : MonoBehaviour
{

    NavMeshAgent agent;
    /*public GameObject hedef1;
    public GameObject hedef2;*/
    public GameObject[] hedefler;
    //string mevcuthedef;
    int mevcuthedef;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        //mevcuthedef = "hedef1";
        //agent.SetDestination(hedef1.transform.position);
        mevcuthedef = 0;
        agent.SetDestination(hedefler[0].transform.position);
        
    }

    
    void Update()
    {
        //agent.SetDestination(hedef.transform.position);
    }

    void OnTriggerEnter(Collider other)
    {
        if (mevcuthedef == 0)
        {
            //mevcuthedef = "hedef2";
            //agent.SetDestination(hedef2.transform.position);
            mevcuthedef = 1;
            agent.SetDestination(hedefler[mevcuthedef].transform.position);
        }
        else
        {
            //mevcuthedef = "hedef1";
            //agent.SetDestination(hedef1.transform.position);
            mevcuthedef = 0;
            agent.SetDestination(hedefler[mevcuthedef].transform.position);
        }
    }
}

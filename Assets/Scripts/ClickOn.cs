using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ClickOn : MonoBehaviour
{
    NavMeshAgent navMeshAgent;

    [SerializeField] private Material red;
    [SerializeField] private Material green;

    private MeshRenderer myRend;

    [HideInInspector] public bool currentlySelected = false;

    void Awake()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }


    void Start()
    {
        myRend = GetComponent<MeshRenderer>();
        ClickMe();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            bool hitSomething = Physics.Raycast(ray, out RaycastHit hitInfo);

            if (hitSomething)
            {
                Vector3 clickedWorldPoint = hitInfo.point;
                navMeshAgent.SetDestination(clickedWorldPoint);
            }
        }
    }

    public void ClickMe()
    {
        if(currentlySelected == false)
        {
            myRend.material = red;
        }
        else
        {
            myRend.material = green;
        }
    }
}

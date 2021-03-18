using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMoviment : MonoBehaviour
{
    private NavMeshAgent Nav;
    private Transform Target;
    private Animator Anim;
    private bool HasStopped = false;
    private float DistanceToTarget;
    private int TargetNumber = 1;

    [SerializeField] float StopDistance = 2.0f;
    [SerializeField] Transform Target1;
    [SerializeField] Transform Target2;

    // Start is called before the first frame update
    void Start()
    {
        Nav = GetComponent<NavMeshAgent>();
        Target = Target1;
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        DistanceToTarget = Vector3.Distance(Target.position, transform.position);
        if(DistanceToTarget > StopDistance)
        {

            Nav.SetDestination(Target.position);
            Anim.SetInteger("State", 0);
            Nav.isStopped = false;
        }
        else
        {
            Nav.isStopped = true;
            Anim.SetInteger("State", 1);
            StartCoroutine(LookAround());
           
        }
    }

    void SetTarget()
    {
        if (TargetNumber == 1)
        {
            Target = Target1;
        }
        if (TargetNumber == 2)
        {
            Target = Target2;
        }
    }

    IEnumerator LookAround()
    {
        yield return new WaitForSeconds(2.0f);

        if(HasStopped == false)
        {
            HasStopped = true;
            TargetNumber++;
            if (TargetNumber > 2)
            {
                TargetNumber = 1;
            }
            SetTarget();
        }
        
        yield return new WaitForSeconds(2.0f);
        HasStopped = false;

    }
}

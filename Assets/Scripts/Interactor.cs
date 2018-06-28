using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour {

    float lastActionTime = 0;

    public float actionTimeWait = 0.3f;
    public float radius = 1.0f;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButton("Action"))
        {
            if (Time.time - lastActionTime > actionTimeWait)
            {
                DoAction();
            }
        }
    }

    void DoAction()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, radius);
        int i = 0;
        while (i < hitColliders.Length)
        {
            Interaction interaction = hitColliders[i].GetComponent<Interaction>();
            if (interaction != null)
            {
                interaction.Action();
            }
            i++;
        }

        lastActionTime = Time.time;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, Interaction {

    Animator animator;
    bool isOpen = false;
	
    void Start()
    {
        animator = GetComponent<Animator>();
    }

	public void Action()
    {
        if (isOpen)
        {
            animator.SetTrigger("DoorClose");
        } else
        {
            animator.SetTrigger("DoorOpen");
        }
        isOpen = !isOpen;
    }
}

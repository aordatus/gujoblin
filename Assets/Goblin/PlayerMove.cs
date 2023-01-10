using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    CharacterController charControl;
    public float walkSpeed;
	Animator anim;

    void Awake()
    {
        charControl = GetComponent<CharacterController>();
		anim = GetComponent<Animator>();
    }



    void Update()
    {
        MovePlayer();
		Attack ();
    }

	void Attack()
	{
		if (Input.GetKey("f")) 
		{
			anim.Play ("Attack");
		
		}
	}
		



    void MovePlayer()
    {
        float horiz = Input.GetAxis("Horizontal");
        float vert = Input.GetAxis("Vertical");
		anim.SetFloat ("walk", horiz);
		anim.SetFloat ("walk", vert);
        Vector3 moveDirSide = transform.right * horiz * walkSpeed;
        Vector3 moveDirForward = transform.forward * vert * walkSpeed;

        charControl.SimpleMove(moveDirSide);
        charControl.SimpleMove(moveDirForward);

    }
}

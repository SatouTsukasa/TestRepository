using UnityEngine;
using System.Collections;

public class character_animation : MonoBehaviour
{

    private Animator animator;
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("up"))
        {
            animator.SetBool("is_walking", true);
        }

        if (Input.GetKeyUp("up"))
        {
            animator.SetBool("is_walking", false);
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            animator.SetBool("is_run", true);
        }

        if (Input.GetKeyUp(KeyCode.LeftShift)) 
        {
            animator.SetBool("is_run", false);
        }
        
        if (animator.GetBool("is_walking"))
        {
            transform.position += transform.forward * 0.1f;
        }

        if (animator.GetBool("is_run"))
        {
            transform.position += transform.forward * 0.3f;
        }


        if (Input.GetKey("right"))
        {
            transform.Rotate(0, 10, 0);
        }
        if (Input.GetKey("left"))
        {
            transform.Rotate(0, -10, 0);
        }
    }
}
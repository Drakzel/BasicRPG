using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimator : MonoBehaviour
{
    const float locomotionAnimationSmoothTime = .1f;

    PlayerController playerController;
    CharacterController characterController;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GetComponent<PlayerController>();
        animator = GetComponentInChildren<Animator>();
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerController.grounded)
        {
            float speedPercent = characterController.velocity.magnitude / playerController.walkSpeed;
            animator.SetFloat("speedPercent", speedPercent, locomotionAnimationSmoothTime, Time.deltaTime);
        }
        else
        {
            // stops the running animation
            animator.SetFloat("speedPercent", 0);

            // start jumping animation
        }
        
    }
}

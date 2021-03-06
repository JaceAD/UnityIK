﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class IKAnimationControlScript : MonoBehaviour
{
    /*
    public GameObject leftUpperLegObj;
    public GameObject leftLegObj;
    public GameObject leftFootObj;
    public GameObject rightUpperLegObj;
    public GameObject rightLegObj;
    public GameObject rightFootObj;
    */

    public Transform rightToe1;
    public Transform leftToe1;

    public JointSystemVectorTarget rightSide;
    public JointSystemVectorTarget leftSide;


    public Vector3 position;
    public Vector3 rotation;

    /*
     * Animation frame info
     * Forward Run: 17 Frames
     * 0 - 1: Right foot fully contacting surface
     * 2: Right toes contacting surface
     * 7: Left heel contacting surface
     * 8-10: Left foot fully contacting surface
     * 11: Left toes contacting surface
     * 16: Right heel contacting surface
     * 17: Right foot fully contacting surface
     *
     * As percentages for normalized time:
     * 0-6: Right foot fully contacting surface
     * 6-14: Right toes contacting
     * 14-16: Right upper toes contacting
     * 42-44: Left heel contacting
     * 44-56: Left foot fully contacting
     * 56-68: Left toes contacting
     * 88-94: Right heel contacting
     * 94-100: Right foot fully contacting
     * 
     */
    void LateUpdate()
    {
        Animator animator = GetComponent<Animator>();
        AnimatorStateInfo currentAnimatorStateInfo = animator.GetCurrentAnimatorStateInfo(0);
        float playbackTime = currentAnimatorStateInfo.normalizedTime * currentAnimatorStateInfo.length;
        float animPercent = currentAnimatorStateInfo.normalizedTime % 1;
        Debug.Log("normalized time is: " + currentAnimatorStateInfo.normalizedTime);
        Debug.Log("Length is: " + currentAnimatorStateInfo.length);
        Debug.Log("animPercent is" + animPercent);
        Debug.Log("\n Playback time is: " + playbackTime);
        if (currentAnimatorStateInfo.IsName("Grounded"))
        {
            // Applies transformation to all grounded animations
            if (true)
            {
                /*
                // Applies to specific ranges of frames in an animation (based on total frames being 17)
                float frameEstimate = animPercent * 17;
                if ((frameEstimate >= 0 && frameEstimate <= 2) || (frameEstimate >= 16))
                {
                    rightFootObj.transform.localRotation = Quaternion.Euler(rotation);
                }
                else if(frameEstimate >= 7 && frameEstimate <= 11)
                {
                    leftFootObj.transform.localRotation = Quaternion.Euler(rotation);
                }
                */
                if((animPercent >= 0 && animPercent < 0.16) || (animPercent > 0.94))
                {
                    // Ray cast to get points on 
                    RaycastHit hit;
                    if(Physics.SphereCast(rightToe1.position, 0.1f, hit, 0.5f, 1))
                    {

                    }
                }
                else if((animPercent >= 0.42 && animPercent < 0.68))
                {
                    
                }
            }
            //myObject.transform.localPosition = position;
            //myObject.transform.localRotation = Quaternion.Euler(rotation);
        }
    }
}

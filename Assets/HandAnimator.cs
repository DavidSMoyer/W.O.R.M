using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimator : MonoBehaviour
{
    public InputActionProperty pinchAnimationAction;
    public InputActionProperty gripAnimationAction;

    public Animator handAnimator;

    private void Update()
    {
        float triggerVal = pinchAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Trigger", triggerVal);

        float gripVal = gripAnimationAction.action.ReadValue<float>();
        handAnimator.SetFloat("Grip", gripVal);
    }
}

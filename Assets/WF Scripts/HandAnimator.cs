using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Readers;

public class HandAnimator : MonoBehaviour
{
    [Header("Trigger")]
    [SerializeField]
    XRInputValueReader<float> m_TriggerInput = new XRInputValueReader<float>("Trigger");

    [Header("Grip")]
    [SerializeField]
    XRInputValueReader<float> m_GripInput = new XRInputValueReader<float>("Grip");

    [Header("Animator")]
    [SerializeField] 
    private Animator animator;

    void OnEnable()
    {
        m_TriggerInput?.EnableDirectActionIfModeUsed();
        m_GripInput?.EnableDirectActionIfModeUsed();
    }

    void OnDisable()
    {
        m_TriggerInput?.DisableDirectActionIfModeUsed();
        m_GripInput?.DisableDirectActionIfModeUsed();
    }

    void Update()
    {

        if (m_TriggerInput != null)
        {
            var triggerVal = m_TriggerInput.ReadValue();
            animator.SetFloat("Trigger", triggerVal);
        }

        if (m_GripInput != null)
        {
            var gripVal = m_GripInput.ReadValue();
            animator.SetFloat("Grip", gripVal);
        }
    }
}

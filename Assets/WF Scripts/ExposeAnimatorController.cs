using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExposeAnimatorController : MonoBehaviour
{
    private Animator _animator;
    private bool _isExpose;
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void TriggerAnimation() {
        if (_isExpose)
        {
            _animator.Play("ExposeDemoKit");
            _isExpose = false;
        }
        else
        {
            _animator.Play("PullingDemoKit");
            _isExpose = true;
        }
    }


}

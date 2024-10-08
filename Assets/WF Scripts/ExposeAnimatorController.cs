using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExposeAnimatorController : MonoBehaviour
{
    private Animator _animator;
    private bool _isExpose = false;
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void PlayExpose() { 
        if (!_isExpose)
        {
            _animator.Play("ExposeDemoKit");
        }
        _isExpose= true;
    }

    public void PlayPulling() {
        if (_isExpose)
        {
            _animator.Play("PullingDemoKit");
        }
        _isExpose = false;
    }


}

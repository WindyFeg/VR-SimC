using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class BXRGrabZoomInteractable : XRGrabInteractable
{

    private bool _isTwoHand;
    private float _scale = 0.1f;
    private float _relativeScale;

    private void Start()
    {
        selectMode = InteractableSelectMode.Multiple;
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);

        //Debug.Log("List of interactors" + interactorsSelecting.Count);
        _isTwoHand = interactorsSelecting.Count == 2;

        if (_isTwoHand)
        {
            _relativeScale = Vector3.Distance(
                interactorsSelecting[0].transform.position,
                interactorsSelecting[1].transform.position);
        }
    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        base.OnSelectExited(args);
        _isTwoHand = interactorsSelecting.Count == 2;
        transform.localScale = new Vector3(_scale, _scale, _scale);
        interactorsSelecting.Clear();
    }

    public override void ProcessInteractable(XRInteractionUpdateOrder.UpdatePhase updatePhase)
    {
        base.ProcessInteractable(updatePhase);

        if (_isTwoHand)
        {

            var _distance = Vector3.Distance(
                interactorsSelecting[0].transform.position,
                interactorsSelecting[1].transform.position);

            _scale = (0.1f * _distance) / _relativeScale;

            Debug.Log(_scale);
            transform.localScale = new Vector3(_scale, _scale, _scale);
        }
    }
}

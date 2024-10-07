using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class BXR_Grab_Interactor : XRDirectInteractor
{
    public override bool CanSelect(XRBaseInteractable interactable)
    {
        Debug.Log(IsSelecting(interactable));
        return true;
    }

    
}

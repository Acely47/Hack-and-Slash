using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour, UIInteractable
{

    [SerializeField] private string _prompt;
    string UIInteractable.InteractionPrompt => throw new System.NotImplementedException();

    bool UIInteractable.Interact(Interactor ineractor)
    {
        Debug.Log(message:"Opening chest");
        return true;
    }
}

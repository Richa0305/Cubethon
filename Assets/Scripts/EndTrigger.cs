using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public ManageGame GameManager;

    void OnTriggerEnter()
    {
        GameManager.CompleteLevel();
    }

}

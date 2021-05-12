using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskPending : MonoBehaviour
{
    public GameObject ListaTareas;
    
    public void OpenPanel()
    {
        if(ListaTareas != null)
        {
            ListaTareas.SetActive(true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoginUIManager : MonoBehaviour
{
    public GameObject ConnectOptionalPanelGameobject;
    public GameObject ConnectWithNamePanelGameobject;
    // Start is called before the first frame update
    void Start()
    {
        ConnectOptionalPanelGameobject.SetActive(true);
        ConnectOptionalPanelGameobject.SetActive(false);
    }

 
}

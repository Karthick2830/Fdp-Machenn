using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menucontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject _MenuPanel;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnButtonClick(GameObject _name)
    {
        if (_name.gameObject.name == "Start")
            _MenuPanel.SetActive(false);
    }
}

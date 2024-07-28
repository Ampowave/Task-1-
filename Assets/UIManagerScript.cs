using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManagerScript : MonoBehaviour
{
    public Button ButtonA;
    public Button ButtonB;
    public BaseBoxHandler BoxAHandler;
    // Start is called before the first frame update
    void Start()
    {
        ButtonA.onClick.AddListener(() => BoxAHandler.Jump());
        ButtonB.onClick.AddListener(() => BoxHandler.Instance.Jump());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

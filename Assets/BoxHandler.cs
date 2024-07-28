using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxHandler : BaseBoxHandler
{
    private Color boxColor;
    public SpriteRenderer boxRenderer;
    public Color BoxColor
    {
        get; set;
    }
    private static BoxHandler instance;
    public static BoxHandler Instance
    {
        get
        {
            if (instance == null) 
                instance = FindObjectOfType<BoxHandler>();
            return instance;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        boxColor = Color.yellow;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void Jump()
    {
        base.Jump();
        boxRenderer.material.color = boxColor;
    }
}

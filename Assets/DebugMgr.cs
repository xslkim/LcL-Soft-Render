using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DebugMgr : MonoBehaviour
{
    public static DebugMgr Get()
    {
        return instance;
    }

    static DebugMgr instance;
    private void Awake()
    {
        instance = this;
    }

    public bool Face0 = true;
    public bool Face1 = true;
    public bool Face2 = true;
    public bool Face3 = true;
    public bool Face4 = true;
    public bool Face5 = true;
    public bool Face6 = true;
    public bool Face7 = true;
    public bool Face8 = true;
    public bool Face9 = true;
    public bool Face10 = true;
    public bool Face11 = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpToSize : MonoBehaviour
{

    public Vector3 TargetSize;

    public Vector3 OringinSize;



    [Range(0,1)]
    public float controlAmt=0f;


    // Start is called before the first frame update
    void Start()
    {
        OringinSize=transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale=Vector3.Lerp(OringinSize,TargetSize,controlAmt);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpToTarget : MonoBehaviour
{
    public Vector3 TargetPos;

    public Vector3 OringinPos;

    public bool fromStarPoint,RandomTarget;

    public Vector3 RandomPosRange;


    
    [Range(0,1)]
    public float controlAmt=0f;
    // Start is called before the first frame update
    void Start()
    {
        if(RandomTarget){

            float x =Random.Range(-RandomPosRange.x,RandomPosRange.x); 
            float y =Random.Range(-RandomPosRange.y,RandomPosRange.y);
            float z =Random.Range(-RandomPosRange.z,RandomPosRange.z);

            TargetPos=new Vector3( x ,y ,z );


        }

        if(fromStarPoint){

            OringinPos=transform.position;
        }


        
    }

    public void setStartPoint(Vector3 startpoint){
        
        OringinPos=startpoint;


    }

    public void setTargetpoint(Vector3 target){

        TargetPos=target;

    } 



    // Update is called once per frame
    void Update()
    {
        
        transform.position=Vector3.Lerp(OringinPos,TargetPos,controlAmt);

        
    }
}

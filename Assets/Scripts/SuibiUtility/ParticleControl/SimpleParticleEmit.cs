using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleParticleEmit : MonoBehaviour
{

    public GameObject particlePrefab;
    
    ParticleSystem particle;

    public bool AutoDestory;

    // Start is called before the first frame update
    void Start()
    {
        //particle=particlePrefab.GetComponent<ParticleSystem>();
    }



    public void emitParticle(){

        GameObject p=Instantiate(particlePrefab,transform.position,transform.rotation)as GameObject;
        particle=p.GetComponent<ParticleSystem>();

    }






    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){

             emitParticle();


        }



        if(AutoDestory && particle!=null){

            if(particle.isStopped){

               Destroy(particle.gameObject);

            }


        }
        
    }
}

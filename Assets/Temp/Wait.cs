using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wait : MonoBehaviour
{


    Animator anim;
    private int flag =0;
    // Start is called before the first frame update
    void Start()
    {
         anim = gameObject.GetComponent<Animator>();
        StartCoroutine(ExampleCoroutine());
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }

    IEnumerator ExampleCoroutine()
    {
       yield return new WaitForSeconds(5);
        anim.SetTrigger("idle");
        Debug.Log("Started Coroutine at timestamp : " + Time.time);
        StartCoroutine(ExampleCoroutine1());
    }
    
    IEnumerator ExampleCoroutine1(){
        
        yield return new WaitForSeconds(5);
        anim.SetTrigger("snake");
        StartCoroutine(ExampleCoroutine2());
    }
    
    IEnumerator ExampleCoroutine2(){
        yield return new WaitForSeconds(5);
        anim.SetTrigger("snakeidle");
        StartCoroutine(ExampleCoroutine3());
    }
      IEnumerator ExampleCoroutine3(){
        yield return new WaitForSeconds(5);
        anim.SetTrigger("sun");
        StartCoroutine(ExampleCoroutine());
    }
}


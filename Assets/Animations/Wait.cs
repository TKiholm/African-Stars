using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//[RequireComponent(typeof(AudioSource))]
public class Wait : MonoBehaviour
{


    Animator anim;
    // Start is called before the first frame update

    
    public AudioClip Para1;
    public AudioClip Para2;
    public AudioClip Para3;
    public AudioClip Para4;
    public AudioClip Para5;
    public AudioClip Para6;
    public AudioClip Para7;
    public AudioClip Para8;
    public AudioClip Para9;
    public AudioClip Para10;

    public AudioSource audioSource; 

    void Start()
    {
         anim = gameObject.GetComponent<Animator>();
        StartCoroutine(Beginning());
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }

    IEnumerator Beginning()
    {
        audioSource.clip = Para1;
        audioSource.Play(0);
        yield return new WaitForSeconds(27);
        audioSource.clip = Para2;
        audioSource.Play(0);
        anim.SetTrigger("ManPraying");
        Debug.Log("Started Coroutine at timestamp : " + Time.time);
        yield return new WaitForSeconds(25);
        anim.SetTrigger("ManPrayingR");

        yield return new WaitForSeconds(5);
        audioSource.clip = Para3;
        audioSource.Play(0);
        anim.SetTrigger("ManOnHill");
        yield return new WaitForSeconds(4);
        anim.SetTrigger("ChildOnHill");
        yield return new WaitForSeconds(12);
        anim.SetTrigger("ManOnHillR");
        anim.SetTrigger("ChildOnHillR");

        yield return new WaitForSeconds(5);
        anim.SetTrigger("CaveFire");
        yield return new WaitForSeconds(5);
        anim.SetTrigger("CaveFireR");

        yield return new WaitForSeconds(5);
        anim.SetTrigger("Childbegging");
        //manstanding
        yield return new WaitForSeconds(5);
        anim.SetTrigger("ChildbeggingR");
        //manstanding

        yield return new WaitForSeconds(5);
        anim.SetTrigger("ChildTelling");
        //Elder
        yield return new WaitForSeconds(5);
        anim.SetTrigger("ChildTellingR");
        //Elder

        yield return new WaitForSeconds(5);
        anim.SetTrigger("TheManRunning");
        //Cave, Man1Running, Man2Running
        yield return new WaitForSeconds(5);
        anim.SetTrigger("TheManRunningR");
        //Cave, Man1Running, Man2Running

        yield return new WaitForSeconds(5);
        anim.SetTrigger("ManWithPouch");
        yield return new WaitForSeconds(5);
        anim.SetTrigger("ManInPouch");
        yield return new WaitForSeconds(5);
        anim.SetTrigger("ManInPouchR");
        yield return new WaitForSeconds(5);
        anim.SetTrigger("ManWithPouchR");

        yield return new WaitForSeconds(5);
        anim.SetTrigger("ManFire");
        //ChildFire
        //Fire without reversing first
        yield return new WaitForSeconds(5);
        anim.SetTrigger("ManFireR");
        //ChildFire
        //Fire later but without reversing first

        yield return new WaitForSeconds(5);
        anim.SetTrigger("ManEnd");
        //ChildEnd
        yield return new WaitForSeconds(5);
        anim.SetTrigger("ManEndR");
        //childEnd

    }
}
   /* 
    IEnumerator ExampleCoroutine1(){
        
        
        StartCoroutine(ExampleCoroutine2());
    }
    
    IEnumerator ExampleCoroutine2(){
        
        StartCoroutine(ExampleCoroutine3());
    }
      IEnumerator ExampleCoroutine3(){
        
        StartCoroutine(ExampleCoroutine());
    }
}
*/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pot : MonoBehaviour
{
    private Animator anim;
    public int damageToGive;
    
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Smash()
    {
        anim.SetBool("incorrect", true);
        StartCoroutine(breakCo());
        
    }
    public void Correct()
    {
        anim.SetBool("smash", true);
        StartCoroutine(breakCorrect());
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
        other.GetComponent<PlayerHp>().HurtPlayer(damageToGive);
        }
        
        
        
    }
    IEnumerator breakCo()
    {
        yield return new WaitForSeconds(.3f);
        

    }
    IEnumerator breakCorrect()
    {
        yield return new WaitForSeconds(.3f);
        Destroy(gameObject);

    }
}

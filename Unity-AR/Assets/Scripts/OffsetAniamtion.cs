using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffsetAniamtion : MonoBehaviour
{
    public float randomAnimStart;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.speed = Random.Range(0.5f, 0.7f); 
        randomAnimStart = Random.Range(0, anim.GetCurrentAnimatorStateInfo(0).length); //Set a random part of the animation to start from
        anim.Play("MovingButerfly", 0, randomAnimStart);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

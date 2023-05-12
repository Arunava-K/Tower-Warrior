using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public Animator animator; 

    public bool standingOnCrate;
    public GameObject crateObject;
    public void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(standingOnCrate)
            {
                Invoke("LateDestroy", 0.7f);
            }
            animator.SetTrigger("Mine");

        }
    }
    void LateDestroy()
    {
        Destroy(crateObject);
    }
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.name == "crate")
        {
            standingOnCrate = true;
            crateObject = other.gameObject;
            Debug.Log("Standing on crate");
        }
    }
}

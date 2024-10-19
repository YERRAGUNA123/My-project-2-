using UnityEngine;

public class IdleWalk : MonoBehaviour
{    
     private Animator mAnimator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mAnimator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(mAnimator != null)
            {
           if(Input.GetKeyDown(KeyCode.UpArrow)){
                 mAnimator.SetTrigger("TrWalking");
}
         else if(Input.GetKeyDown(KeyCode.DownArrow)){
                 mAnimator.SetTrigger("TrBacking");}
          else if(Input.GetKeyUp(KeyCode.UpArrow)){
                 mAnimator.SetTrigger("TrStand");}
         else if(Input.GetKeyUp(KeyCode.DownArrow)){
                 mAnimator.SetTrigger("TrStand");}
         else if(Input.GetKeyDown(KeyCode.Space)){
                 mAnimator.SetTrigger("TrJump");}
          else if(Input.GetKeyUp(KeyCode.Space)){
                 mAnimator.SetTrigger("TrStand");}
}
    
}
}

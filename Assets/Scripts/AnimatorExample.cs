using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorExample : MonoBehaviour
{
    public Animation animation;

    public AnimationClip run;
    public AnimationClip idle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            PlayAnimation(run);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            PlayAnimation(idle);
        }
    }

    private void PlayAnimation(AnimationClip clip)
    {
        //animation.clip = clip;
        animation.CrossFade(clip.name, 0.5f);
    }
}

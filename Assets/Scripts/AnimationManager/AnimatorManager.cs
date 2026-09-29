using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    public Animator animator;
    public List<AnimationSetup> animationSetups;

    public enum AnimationType
    {
        IDLE,
        RUN,
        DEAD
    }
    
    public void Play(AnimationType type)
    {
        foreach (var setup in animationSetups)
        {
            if (setup.type == type)
            {
                animator.SetTrigger(setup.trigger);
                break;
            }
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Play(AnimationType.RUN);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Play(AnimationType.DEAD);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Play(AnimationType.IDLE);
        }
    }
}

[System.Serializable]
public class AnimationSetup
{
    public AnimatorManager.AnimationType type;
    public string trigger;
}

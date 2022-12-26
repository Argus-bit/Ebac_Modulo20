using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorManager : MonoBehaviour
{
    public Animator animator;
    public List<AnimatorSetup> AnimatorSetups;
    public enum AnimationType
    {
        IDLE,
        RUN,
        DEAD
    }
    public void Play(AnimationType type)
    {
        foreach(var animation in AnimatorSetups)
        {
            if(animation.Type == type)
            {
                animator.SetTrigger(animation.trigger);
                break;
            }
        }
    }
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            Play(AnimationType.IDLE);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Play(AnimationType.DEAD);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Play(AnimationType.RUN);
        }
    }


    [System.Serializable]
    public class AnimatorSetup
    {
        public AnimatorManager.AnimationType Type;
        public string trigger;
    }
}

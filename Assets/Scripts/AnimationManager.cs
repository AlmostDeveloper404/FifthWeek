using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    public Animation _animation;
    public Animation _garage;

    public void Play()
    {
        _animation.Play();
    }

    public void PlayGarageAnim()
    {
        _garage.Play();
    }
}

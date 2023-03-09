using Hikanyan.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealTimer : AbstractSingleton<RealTimer>
{
    private float _startTime = 0;
    public float realTime { get; set; }
    float _cacheTime = 0;
    public bool IsRunning { get; set; } = false;
    float _pauseTime = 0;

    private void Update()
    {
        if(!IsRunning)return;
        realTime = Time.realtimeSinceStartup- _startTime - _cacheTime;
        Debug.Log(realTime);
    }

    public void TimerStart()
    {
        IsRunning = true;
        _startTime = Time.realtimeSinceStartup;
    }
    public void TimerPause()
    {
        IsRunning = false;
        _pauseTime = Time.realtimeSinceStartup;
    }
    public void TimerUnPause()
    {
        IsRunning = true;
        _cacheTime += Time.realtimeSinceStartup - _pauseTime;
    }
    public void TimerStop()
    {
        IsRunning = false;
    }
}

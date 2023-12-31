using UnityEngine;

public class Tween
{
    public Tween(Transform target, Vector2 startPos, Vector2 endPos, float startTime, float duration)
    {
        Target = target;
        StartPos = startPos;
        EndPos = endPos;
        StartTime = startTime;
        Duration = duration;
    }
    public Transform Target{get; private set;}
    public Vector3 StartPos{get;private set;}
    public Vector3 EndPos{get;private set;}
    public float StartTime{get;private set;}
    public float Duration{get;private set;}
}


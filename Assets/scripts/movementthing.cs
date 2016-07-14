using UnityEngine;
using System.Collections;

public class movementthing : MonoBehaviour {

    Rigidbody _cachedRB;
    private Vector3 _move;

    public void Start()
    {
        _cachedRB = GetComponent<Rigidbody>();
    }

    public void Move(Vector3 move)
    {
        _move += move;
    }

    public void FixedUpdate()
    {
        _cachedRB.AddForce(_move);
        _move = Vector3.zero;
    }
}

using UnityEngine;
using System.Collections;

public class MovingObject : MonoBehaviour {
    public float moveTime = 0.1f;
    public LayerMask blockingLayer;

    private BoxCollider2D boxcollider;
    private Rigidbody2D rb2d;
    private float inverseMoveTime;
	// Use this for initialization
	protected virtual void Start () {
        boxcollider = GetComponent<BoxCollider2D>();
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

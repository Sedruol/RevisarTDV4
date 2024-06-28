using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public GameObject platformToMove;
    public Transform startPosition;
    public Transform endPosition;
    public float velocity;
    private Vector3 destination;
    private void Start()
    {
        destination = endPosition.position;
    }
    private void Update()
    {
        platformToMove.transform.position = Vector3.MoveTowards(platformToMove.transform.position,
            destination, velocity * Time.deltaTime);
        if (platformToMove.transform.position == endPosition.position)
        {
            destination = startPosition.position;
        }
        else if (platformToMove.transform.position == startPosition.position)
        {
            destination = endPosition.position;
        }
    }
}
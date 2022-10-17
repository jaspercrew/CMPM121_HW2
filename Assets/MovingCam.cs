using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCam : MonoBehaviour
{
    private Vector2 startingPoint;
    public float moveDistance;

    public float startSpeed;
    private float currentSpeed;
    // Start is called before the first frame update
    void Start()
    {
        currentSpeed = startSpeed;
        startingPoint = transform.localPosition;

    }

    // Update is called once per frame
    void Update()
    {
        //print(currentSpeed);
        if (transform.localPosition.x >= (startingPoint.x + moveDistance) && currentSpeed > 0)
        {
            currentSpeed = -startSpeed;

        }
        else if (transform.localPosition.x <= startingPoint.x && currentSpeed < 0)
        {
            currentSpeed = startSpeed;
        }
        transform.localPosition = new Vector3(transform.localPosition.x + (currentSpeed * Time.deltaTime),
            transform.localPosition.y, transform.localPosition.z);
    }
}

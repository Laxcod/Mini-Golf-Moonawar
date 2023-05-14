using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayManger : MonoBehaviour
{
    [SerializeField] BallController ballController;
    [SerializeField] CameraController camController;

    bool isBallOutside;
    Vector3 lastBallPosition;
    private void Update() {

        if(ballController.ShootingMode)
        {
            lastBallPosition = ballController.transform.position;
        }

       var InputActive = Input.GetMouseButton(0) 
            && ballController.IsMove() == false 
            && ballController.ShootingMode == false
            && isBallOutside == false;   
            
       camController.SetInputActive(InputActive);
    }

    public void OnBallOutside()
    {
       Debug.Log("OnBallOutside " + lastBallPosition); 
       isBallOutside = true; 
       //Invoke("MoveBallLastPosition",1);
       MoveBallLastPosition();
    }

    public void MoveBallLastPosition()
    {
        var rb = ballController.GetComponent<Rigidbody>();
        rb.isKinematic = true;
        ballController.transform.position = lastBallPosition;
        rb.isKinematic = false;
        isBallOutside = false;
    }
}

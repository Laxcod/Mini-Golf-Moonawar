using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayManger : MonoBehaviour
{
    [SerializeField] BallController ballController;
    [SerializeField] CameraController camController;
    private void Update() {
       var InputActive = Input.GetMouseButton(0) && ballController.IsMove() == false;
       camController.SetInputActive(InputActive);
    }
}

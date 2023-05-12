using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayManger : MonoBehaviour
{
    [SerializeField] BallController ballController;
    [SerializeField] CameraController camController;
    private void Update() {
       camController.SetInputActive(Input.GetMouseButton(0));
    }
}

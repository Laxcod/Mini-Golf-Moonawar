using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class BallController : MonoBehaviour
{
    [SerializeField] CinemachineFreeLook look;
    private void Update() {
        //0 untuk klik kiri,dan 1 untuk klik kanan
        look.enabled = Input.GetMouseButton(0);
    }
}

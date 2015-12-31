using UnityEngine;
using System.Collections;
using RobotArms;

public class PlayerInput : RobotArmsComponent {

    // Thrust and rotation are mapped to horizontal and vertical axises
    public float thrust;
    public float rotation;

    // Same as Thrust and Rotation, but for raw values
    public float thrustRaw;
    public float rotationRaw;

}

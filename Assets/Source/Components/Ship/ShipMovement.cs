using UnityEngine;
using System.Collections;
using RobotArms;

public class ShipMovement : RobotArmsComponent {

    public Vector3 position;
    // Velocity vector is the direction the ship is going
    public Vector3 velocity;
    // Magnitude is how fast it is moving
    public float magnitude;
    // How fast can it possibly go?
    public float maxMagnitude;

    // The ship's facing
    public float facing;
    // TODO: Temporary until RCS and such are defined
    public float rotationSpeed;

    // The ship's bank
    public float bank;
    // how much the ship can bank
    public float maxBank;

    // TODO: Temporary until thruster arrays are set for the ship
    public float thrustForce;
    public float currentThrust;
    public float currentRotation;

}

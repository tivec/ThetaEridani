using UnityEngine;
using System.Collections;
using RobotArms;


public class PlayerShipMovementProcessor : RobotArmsProcessor<PlayerInput, ShipMovement> {
    public override void Process(GameObject entity, PlayerInput input, ShipMovement movement)
    {
        // used for fuel calculations and other things
        movement.currentThrust = input.thrust;

        // forward thrust
        if (input.thrust > 0)
        {
            movement.velocity += entity.transform.up * movement.thrustForce * Time.deltaTime;
            movement.velocity = Vector3.ClampMagnitude(movement.velocity, movement.maxMagnitude);
            movement.velocity.z = 0;
            movement.magnitude = movement.velocity.magnitude;
        }
    }
}

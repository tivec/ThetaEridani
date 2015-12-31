using UnityEngine;
using System.Collections;
using RobotArms;


public class PlayerShipThrustProcessor : RobotArmsProcessor<PlayerInput, ShipMovement> {
    public override void Process(GameObject entity, PlayerInput input, ShipMovement movement)
    {
        // used for fuel calculations and other things
        movement.currentThrust = input.thrust;

        // forward thrust
        if (input.thrust > 0)
        {
            movement.velocity += entity.transform.up * (movement.thrustForce *input.thrust) * Time.deltaTime;
            movement.velocity = Vector3.ClampMagnitude(movement.velocity, movement.maxMagnitude);
            movement.velocity.z = 0;
            movement.magnitude = movement.velocity.magnitude;
        }

        // this is full stop, we're breaking!
        if (input.thrustRaw == -1)
        {
            var opposite = -movement.velocity;
            movement.velocity += opposite.normalized * movement.thrustForce * Time.deltaTime;
            if (movement.velocity.sqrMagnitude < 0.005)
            {
                movement.velocity = Vector3.zero;
            }
        }
    }
}

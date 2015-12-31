using UnityEngine;
using System.Collections;
using RobotArms;

public class PlayerShipRotationProcessor : RobotArmsProcessor<PlayerInput, ShipMovement>
{
    public override void Process(GameObject entity, PlayerInput input, ShipMovement movement)
    {
        if (input.rotation != 0)
        {
            movement.currentRotation = input.rotation;
            movement.facing += -input.rotation * movement.rotationSpeed * Time.deltaTime;
            // TODO: Add banking
        }

        // Apply rotation
        Quaternion turn = Quaternion.Euler(0, 0, movement.facing);
        entity.transform.rotation = turn;
    }
}

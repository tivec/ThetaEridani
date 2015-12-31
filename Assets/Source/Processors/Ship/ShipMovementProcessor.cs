using UnityEngine;
using System.Collections;
using RobotArms;

public class ShipMovementProcessor : RobotArmsProcessor<ShipMovement> {

    public override void Process(GameObject entity, ShipMovement movement)
    {
        // translate the position
        entity.transform.Translate(movement.velocity * Time.deltaTime, Space.World);
        // update the position in the model
        movement.position = entity.transform.position;
    }
}

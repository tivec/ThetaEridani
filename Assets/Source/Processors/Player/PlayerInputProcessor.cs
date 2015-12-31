using UnityEngine;
using System.Collections;
using RobotArms;

public class PlayerInputProcessor : RobotArmsProcessor<PlayerInput> {
    public override void Process(GameObject entity, PlayerInput input)
    {
        input.thrust = Input.GetAxis("Vertical");
        input.rotation = Input.GetAxis("Horizontal");
        input.thrustRaw = Input.GetAxisRaw("Vertical");
        input.rotationRaw = Input.GetAxisRaw("Horizontal");
    }
}

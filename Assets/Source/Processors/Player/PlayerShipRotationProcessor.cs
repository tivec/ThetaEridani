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
            
            movement.bank += -input.rotation * movement.bankSpeed * Time.deltaTime;
            movement.bank = Mathf.Clamp(movement.bank, -movement.maxBank, movement.maxBank);

        }

        // bank back to 0
        if(input.rotationRaw == 0)
        {
            if (movement.bank != 0)
            {
                if (movement.bank > 0)
                {
                    movement.bank = Mathf.Max(movement.bank - movement.bankSpeed * Time.deltaTime, 0); 
                }
                else
                {
                    movement.bank = Mathf.Min(movement.bank + movement.bankSpeed * Time.deltaTime, 0);
                }
            }
        }


        // Apply rotation
        Quaternion turn = Quaternion.Euler(0, 0, movement.facing);
        entity.transform.rotation = turn;

        // apply bank
        if (Mathf.Abs(movement.bank)>0)
        {
            Quaternion bank = Quaternion.Euler(0, movement.bank, 0);
            entity.transform.rotation = entity.transform.rotation * bank;
        }
    }
}

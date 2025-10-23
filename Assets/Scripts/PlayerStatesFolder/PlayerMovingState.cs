using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class PlayerMovingState : PlayerState
{
    public override void EnterState(PlayerController player)
    {
        //TryPlayAnimation(player, "Run");
    }

    public override void UpdateState(PlayerController player)
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 velocity = player.rb.linearVelocity;
        velocity.x = horizontal * player.moveSpeed;
        velocity.y = vertical * player.moveSpeed;
        player.rb.linearVelocity = velocity;

        if (horizontal < 0)
            //player.spriteRenderer.flipX = true;
            player.animator.Play("WalkLeft");
        else if (horizontal > 0)
            //player.spriteRenderer.flipX = false;
            player.animator.Play("WalkRight");

        if (vertical < 0)
            player.animator.Play("WalkDown");
        else if (vertical > 0)
            player.animator.Play("WalkUp");

        //if (Mathf.Abs(horizontal) < 0.1f)
        if (Mathf.Abs(Input.GetAxis("Horizontal")) < 0.1f)
        {
                player.ChangeState(new PlayerIdleState());
            }
        //if (Mathf.Abs(vertical) < 0.1f)
        if (Mathf.Abs(Input.GetAxis("Vertical")) < 0.1f)
        {
            player.ChangeState(new PlayerIdleState());
        }



        //if (Input.GetButton("Fire"))
        //{
        //    player.HandleShooting();
        //}
    }

    public override void ExitState(PlayerController player) { }

    public override string GetStateName() => "Moving";

    private void TryPlayAnimation(PlayerController player, string animName)
    {
        if (player.animator != null &&
            player.animator.runtimeAnimatorController != null &&
            player.animator.isActiveAndEnabled)
        {
            try
            {
                player.animator.Play(animName);
            }
            catch
            {
                // Animation doesn't exist - continue without it
            }
        }
    }
}

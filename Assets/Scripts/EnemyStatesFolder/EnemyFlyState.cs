using UnityEngine;

public class EnemyFlyState : EnemyState
{
    public override void EnterState(Enemy enemy)
    {
        // Safe animation - only plays if everything is set up
        TryPlayAnimation(enemy, "WaspFly");
    }

    public override void UpdateState(Enemy enemy)
    {
        //if enemy.
    }

    public override void ExitState(Enemy enemy) { }

    public override string GetStateName() => "WaspFly";

    // Safe animation helper
    private void TryPlayAnimation(Enemy enemy, string animName)
    {
        if (enemy.animator != null &&
            enemy.animator.runtimeAnimatorController != null &&
            enemy.animator.isActiveAndEnabled)
        {
            try
            {
                enemy.animator.Play(animName);
            }
            catch
            {
                // Animation doesn't exist - that's okay, continue without it
            }
        }
    }
}



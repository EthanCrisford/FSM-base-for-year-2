using UnityEngine;

namespace Player
{
    public class JumpState : State
    {

        // constructor
        public JumpState(PlayerScript player, StateMachine sm) : base(player, sm)
        {

        }

        public override void Enter()
        {
            base.Enter();
            player.xv = player.yv = 0;
            //rigidbody2D.AddForce(new Vector2(0, 10), ForceMode2D.Impulse);

        }

        public override void Exit()
        {
            base.Exit();
        }

        public override void HandleInput()
        {
            base.HandleInput();
        }

        public override void LogicUpdate()
        {
            player.CheckForRun();

            base.LogicUpdate();
        }

        public override void PhysicsUpdate()
        {
            base.PhysicsUpdate();
        }
    }
}
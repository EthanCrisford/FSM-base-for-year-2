
using UnityEngine;
namespace Player
{
    public class StandingState : State
    {

        // constructor
        public StandingState(PlayerScript player, StateMachine sm) : base(player, sm)
        {

        }

        public override void Enter()
        {
            base.Enter();
            player.xv = player.yv = 0;
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
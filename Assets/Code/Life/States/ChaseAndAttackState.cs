namespace AIAssignment3
{
    //The hunt state is made of the follow logic:
    //- To avoid any obstacles that comes near 
    //- To move towards the nearest prey
    public class ChaseAndAttackState : StateBase
    {
        //Constructor
        public ChaseAndAttackState(Lifeform lifeform)
        {
            //behaviors.Add(new FlockAlignmentBehavior());
            behaviors.Add(new ObstacleAvoidanceBehavior(lifeform));
            behaviors.Add(new PursuitBehavior(lifeform));
        }

    }
}
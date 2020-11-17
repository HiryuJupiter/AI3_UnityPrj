using System.Collections.Generic;
using UnityEngine;

namespace AIAssignment3
{
    public class PursuitBehavior : BehaviorBase
    {
        public PursuitBehavior(Lifeform lifeform) : base(lifeform)  {}

        public override void TickFixedUpdate()
        {
            List<Lifeform> preys = lifeform.neighbors.Preys;
            
            if (preys.Count > 0)
            {
                Vector2 pursueDir = Vector2.zero;

                //If there is only one prey, then skip trying to find the closest prey
                if (preys.Count == 1)
                {
                    pursueDir = preys[0].transform.position - transform.position;
                }
                else if (preys.Count > 1)
                {
                    //Find closest prey
                    pursueDir = (lifeform.neighbors.GetClosestPrey().position - transform.position).normalized;
                }
                Debug.DrawRay(transform.position, pursueDir, Color.red);
                lifeform.NewMoveDir += pursueDir;
            }
           
        }
    }
}
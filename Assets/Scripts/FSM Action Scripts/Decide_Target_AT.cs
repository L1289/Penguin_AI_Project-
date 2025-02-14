using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using System.Collections;
using static UnityEngine.UIElements.UxmlAttributeDescription;
using NodeCanvas.Editor;
using UnityEditor;
using UnityEngine.AI;
namespace NodeCanvas.Tasks.Actions {

	public class Decide_Target_AT : ActionTask {

        public BBParameter <Vector3> targetPosition;
		public BBParameter <float> hungerBar;
        public BBParameter <float> targetDistance;

		public Transform hungerWaypoint;

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {
			return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {


            if (hungerBar.value <= 10f)
			{
				//The direction the penguin is moving in for hunger
				Vector3 directionToHungerBar = hungerWaypoint.position - agent.transform.position;

                //How far they are moving
                Vector3 hungerbarTarget = agent.transform.position + directionToHungerBar.normalized * directionToHungerBar.magnitude;

				//Setting Target to restore hungerbar
				targetPosition.value = hungerbarTarget;

				targetDistance.value = hungerbarTarget.x + hungerbarTarget.y + hungerbarTarget.z;

                EndAction(true);

            }
        }

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}
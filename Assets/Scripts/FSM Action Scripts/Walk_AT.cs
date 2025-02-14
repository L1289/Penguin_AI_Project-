using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using System.Collections;
using static UnityEngine.UIElements.UxmlAttributeDescription;
using NodeCanvas.Editor;
using UnityEditor;
using UnityEngine.AI;


namespace NodeCanvas.Tasks.Actions {

	public class Walk_AT : ActionTask {

        public BBParameter<float> targetDistance;
        public BBParameter<Vector3> targetPosition;

        private NavMeshAgent navAgent;

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {

            navAgent = agent.GetComponent<NavMeshAgent>();
            return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {

			if (targetDistance.value > 2f)
			{
				EndAction(true);
			}

			else
			{

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
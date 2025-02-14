using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using System.Collections;
using static UnityEngine.UIElements.UxmlAttributeDescription;
using NodeCanvas.Editor;
using UnityEditor;
using UnityEngine.AI;

namespace NodeCanvas.Tasks.Actions
{

    public class Spawn_Fish_AT : ActionTask
    {

        public GameObject fish;

        public Transform fishSpawner;

        private Vector3 fishSpawnerPos;

        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit()
        {
            return null;
        }

        //This is called once each time the task is enabled.
        //Call EndAction() to mark the action as finished, either in success or failure.
        //EndAction can be called from anywhere.
        protected override void OnExecute()
        {
            //EndAction(true);
        }

        //Called once per frame while the action is active.
        protected override void OnUpdate()
        {

            fishSpawnerPos = new Vector3(fishSpawner.position.x, fishSpawner.position.y, fishSpawner.position.z);

            if (Input.GetKeyDown("space"))
            {
                Debug.Log("Summon Fish");

                //GameObject.Instantiate(fish, fishSpawner);
            }

        }


        //Called when the task is disabled.
        protected override void OnStop()
        {

        }

        //Called when the task is paused.
        protected override void OnPause()
        {

        }
    }
}
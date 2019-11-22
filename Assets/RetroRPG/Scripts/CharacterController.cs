using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RetroRPG.Character
{
    public class CharacterController : MonoBehaviour
    {
        Vector3 _updatedVector = new Vector3();

        // Start is called before the first frame update
        void Start()
        {
            //transform.position = _updatedVector = new Vector3(0, 0.5f, 0);
        }
        
        // Update is called once per frame
        void Update()
        {
            var rotation = transform.rotation;

            if (Input.anyKey)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    transform.transform.Rotate(0f, -90f, 0f);
                }
                else if (Input.GetKeyDown(KeyCode.E))
                {
                    transform.transform.Rotate(0f, 90f, 0f);
                }

                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    //transform.TransformDirection(Vector3.forward);
                    transform.position += transform.forward;
                     //this.transform.position = this.transform.position + (transform.forward + new Vector3(0,0,1));
                }
                else if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    //transform.TransformDirection(Vector3.back);
                    transform.position += transform.forward * -1;
                    //this.transform.position = this.transform.position + (transform. + new Vector3(0,0,1));
                }
                else if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    transform.position += transform.right * -1;
                }
                else if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    transform.position += transform.right;
                }
            }
        }
    }
}

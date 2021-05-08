using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CenturyGame.MyRotate
{
    public class MyRotate : MonoBehaviour
    {
        public float MyRotateSpeed = 10.0f;

        void Start()
        {

        }

        void Update()
        {
            var rot = Quaternion.AngleAxis(MyRotateSpeed * Time.deltaTime, Vector3.up);
            transform.localRotation = rot * transform.localRotation;
        }
    }
}

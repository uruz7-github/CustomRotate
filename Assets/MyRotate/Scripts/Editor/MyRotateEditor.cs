using UnityEditor;
using UnityEngine;
using CenturyGame.MyRotate;

namespace CenturyGame.MyRotate.Editor
{
    public class MyRotateEditor
    {
        [MenuItem("MyRotate/CreateCube")]
        public static void CreateCube()
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            MyRotate myRotate = cube.AddComponent<MyRotate>();
            cube.name = "NewCube";
            myRotate.transform.position = new Vector3(0, 1, -5);
            myRotate.transform.localEulerAngles = new Vector3(0, 60, 40);
        }
    }
}

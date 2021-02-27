using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car_control : MonoBehaviour
{
    public WheelCollider onSolcol;
    public WheelCollider onSagcol;
    public WheelCollider arkaSolcol;
    public WheelCollider arkaSagcol;

    public GameObject onSol;
    public GameObject onSag;
    public GameObject arkaSol;
    public GameObject arkaSag;
    

    public float maxmotorgucu;
    public float motor;
    public float maxdonus;

    public float donus;
    void Start()
    {
        
    }

    void Update()
    {
        




    }
    private void FixedUpdate()
    {
        motor = maxmotorgucu * Input.GetAxis("Vertical");
        donus = maxdonus * Input.GetAxis("Horizontal");

        onSolcol.steerAngle = onSagcol.steerAngle = donus;

        arkaSagcol.motorTorque = arkaSolcol.motorTorque = motor;
        SanalTeker();
    }
    void SanalTeker()
    {
        Quaternion rot;
        Vector3 pos;
        onSolcol.GetWorldPose(out pos, out rot);
        onSol.transform.position = pos;
        onSol.transform.rotation = rot;

        onSagcol.GetWorldPose(out pos, out rot);
        onSag.transform.position = pos;
        onSag.transform.rotation = rot;
        
        arkaSolcol.GetWorldPose(out pos, out rot);
        arkaSol.transform.position = pos;
        arkaSol.transform.rotation = rot;
        
        arkaSagcol.GetWorldPose(out pos, out rot);
        arkaSag.transform.position = pos;
        arkaSag.transform.rotation = rot;
         

    }
}

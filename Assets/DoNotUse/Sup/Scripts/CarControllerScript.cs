using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControllerScript : MonoBehaviour
{
    private float m_horizontalInput;
    private float m_verticalInput;
    private float m_steeringAngle;

    public WheelCollider frontDriverW, frontPassengerW;
    public WheelCollider rearDriverW, rearPassengerW;
    public Transform frontDriverT, frontPassengerT;
    public Transform rearDriverT, rearPassengerT;
    public float maxSteerAngle = 30;
    public float motorForce = 50;

    public void GetInput()
    {
        m_horizontalInput = Input.GetAxis("Horizontal");
        m_verticalInput = Input.GetAxis("Vertical");
        
    }

    private void Steer()
    {
        m_steeringAngle = maxSteerAngle * m_horizontalInput;
        frontDriverW.steerAngle = m_steeringAngle;
        frontPassengerW.steerAngle = m_steeringAngle;
        //Console.log("abc");
    }

    private void Accelerate()
    {
        frontDriverW.motorTorque = m_verticalInput * motorForce;
        frontPassengerW.motorTorque = m_verticalInput * motorForce;
        //Console.log("abc");
    }

    private void UpdateWheelPoses()
    {
        UpdateWheelPose(frontDriverW, frontDriverT);
        UpdateWheelPose(frontPassengerW, frontPassengerT);
        UpdateWheelPose(rearDriverW, rearDriverT);
        UpdateWheelPose(rearPassengerW, rearPassengerT);
        //Console.log("abc");
    }

    private void UpdateWheelPose(WheelCollider _collider, Transform _transform)
    {
        Vector3 _pos = _transform.position;
        Quaternion _quat = _transform.rotation;

        _collider.GetWorldPose(out _pos, out _quat);
        Debug.Log(_pos.x);
        _transform.position = _pos;
        _transform.rotation = _quat;
        //Console.log("abc");
    }

    private void FixedUpdate()
    {
        GetInput();
        Steer();
        Accelerate();
        UpdateWheelPoses();
    }

    

    //private float DirHorizontal;
    //private float DirVertical;
    //private float steerAngle;

    //public WheelCollider WheelCFR, WheelCFL, WheelCBR, WheelCBL;
    //public Transform WheelTFR, WheelTFL, WheelTBR, WheelTBL;
    //public float maxSteerAngle = 30;
    //public float motorForce = 300;
    //public float brakes = 0;

    //public void DirectionsInput()
    //{
    //    DirHorizontal = Input.GetAxis("Horizontal");
    //    DirVertical = Input.GetAxis("Vertical");
    //}

    //public void steerControl()
    //{
    //    steerAngle = maxSteerAngle * DirHorizontal;
    //    WheelCFR.steerAngle = steerAngle;
    //    WheelCFL.steerAngle = steerAngle;
    //}

    //public void speedControl()
    //{
    //    if (DirVertical == 0 || Input.GetKey(KeyCode.Space))
    //    {
    //        brakes = 300;
    //    }
    //    else
    //    {
    //        brakes = 0;
    //        WheelCFR.motorTorque = DirVertical * motorForce;
    //        WheelCFL.motorTorque = DirVertical * motorForce;
    //        WheelCBR.motorTorque = DirVertical * motorForce;
    //        WheelCBL.motorTorque = DirVertical * motorForce;
    //    }

    //    WheelCFR.brakeTorque = brakes;
    //    WheelCFL.brakeTorque = brakes;
    //    WheelCBR.brakeTorque = brakes;
    //    WheelCBL.brakeTorque = brakes;
    //}

    //public void wheelPositionControl()
    //{
    //    wheelPositionControls(WheelCFR, WheelTFR);
    //    wheelPositionControls(WheelCFL, WheelTFL);
    //    wheelPositionControls(WheelCBR, WheelTBR);
    //    wheelPositionControls(WheelCBL, WheelTBL);
    //}

    //public void wheelPositionControls(WheelCollider collide, Transform trans)
    //{
    //    Vector3 wheelPosition = trans.position;
    //    Quaternion wheelQuant = trans.rotation;

    //    collide.GetWorldPose(out wheelPosition, out wheelQuant);

    //    trans.position = wheelPosition;
    //    trans.rotation = wheelQuant;
    //}

    //public void FixedUpdate()
    //{
    //    DirectionsInput();
    //    steerControl();
    //    speedControl();
    //    wheelPositionControl();
    //}
}

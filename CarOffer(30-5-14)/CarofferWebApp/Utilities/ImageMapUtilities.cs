using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarofferWebApp.Utilities
{
    //public class testclass
    //{
    //    public string testname { get; set; }
    //}
    //1.Front Bumper
    public class FrontBumper
    {
        public int FrontBumperId { get; set; }
        public string FrontBumperData { get; set; }
        public int vinid { get; set; }
        public bool status { get; set; }
    }
    //2.Hood
    public class Hood
    {
        public int HoodId { get; set; }
        public string HoodData { get; set; }
        public int vinid { get; set; }
        public bool status { get; set; }
    }
    //3.Roof
    public class Roof
    {
        public int RoofId { get; set; }
        public string RoofData { get; set; }
        public int vinid { get; set; }
        public bool status { get; set; }
    }
    //4.Front Left Fender
    public class FrontLeftFender
    {
        public int FrontLeftFenderId { get; set; }
        public string FrontLeftFenderData { get; set; }
        public int vinid { get; set; }
        public bool status { get; set; }
    }
    //5.Front Left Door
    public class FrontLeftDoor
    {
        public int FrontLeftDoorId { get; set; }
        public string FrontLeftDoorData { get; set; }
        public int vinid { get; set; }
        public bool status { get; set; }
    }
    //6.Rear Left Door
    public class RearLeftDoor
    {
        public int RearLeftDoorId { get; set; }
        public string RearLeftDoorData { get; set; }
        public int vinid { get; set; }
        public bool status { get; set; }
    }
    //7.Rear Left Quarter Panel
    public class RearLeftQuarterPanel
    {
        public int RearLeftQuarterPanelId { get; set; }
        public string RearLeftQuarterPanelData { get; set; }
        public int vinid { get; set; }
        public bool status { get; set; }
    }
    //8.Front Left Window
    public class FrontLeftWindow
    {
        public int FrontLeftWindowId { get; set; }
        public string FrontLeftWindowData { get; set; }
        public int vinid { get; set; }
        public bool status { get; set; }
    }
    //9.Rear Left Window
    public class RearLeftWindow
    {
        public int RearLeftWindowId { get; set; }
        public string RearLeftWindowData { get; set; }
        public int vinid { get; set; }
        public bool status { get; set; }
    }
    //10.Front Windshield
    public class FrontWindshield
    {
        public int FrontWindshieldId { get; set; }
        public string FrontWindshieldData { get; set; }
        public int vinid { get; set; }
        public bool status { get; set; }
    }
    //11.Front Left Wheel& Tire
    public class FrontLeftWheelTire
    {
        public int FrontLeftWheelTireId { get; set; }
        public string FrontLeftWheelTireData { get; set; }
        public int vinid { get; set; }
        public bool status { get; set; }
    }
    //12.Rear Left Wheel& Tire
    public class RearLeftWheelTire
    {
        public int RearLeftWheelTireId { get; set; }
        public string RearLeftWheelTireData { get; set; }
        public int vinid { get; set; }
        public bool status { get; set; }
    }
    //13.Front Left Headlight
    public class FrontLeftHeadlight
    {
        public int FrontLeftHeadlightId { get; set; }
        public string FrontLeftHeadlightData { get; set; }
        public int vinid { get; set; }
        public bool status { get; set; }
    }
    //14.Front Right Headlight
    public class FrontRightHeadlight
    {
        public int FrontRightHeadlightId { get; set; }
        public string FrontRightHeadlightData { get; set; }
        public int vinid { get; set; }
        public bool status { get; set; }
    }
    //15.Left Mirror
    public class LeftMirror
    {
        public int LeftMirrorId { get; set; }
        public string LeftMirrorData { get; set; }
        public int vinid { get; set; }
        public bool status { get; set; }
    }
    //16.Repeat Previous Roof//
    //17.Trunk
    public class Trunk
    {
        public int TrunkId { get; set; }
        public string TrunkData { get; set; }
        public int vinid { get; set; }
        public bool status { get; set; }
    }
    //18.Rear Bumper
    public class RearBumper
    {
        public int RearBumperId { get; set; }
        public string RearBumperData { get; set; }
        public int vinid { get; set; }
        public bool status { get; set; }
    }
    //19.Rear Right Quarter Panel
    public class RearRightQuarterPanel
    {
        public int RearRightQuarterPanelId { get; set; }
        public string RearRightQuarterPanelData { get; set; }
        public int vinid { get; set; }
        public bool status { get; set; }
    }
    //20.Front Right Fender
    public class FrontRightFender
    {
        public int FrontRightFenderId { get; set; }
        public string FrontRightFenderData { get; set; }
        public int vinid { get; set; }
        public bool status { get; set; }
    }
    //21.Front Right Door
    public class FrontRightDoor
    {
        public int FrontRightDoorId { get; set; }
        public string FrontRightDoorData { get; set; }
        public int vinid { get; set; }
        public bool status { get; set; }
    }
    //22.Rear Right Door
    public class RearRightDoor
    {
        public int RearRightDoorId { get; set; }
        public string RearRightDoorData { get; set; }
        public int vinid { get; set; }
        public bool status { get; set; }
    }
    //23.Front Right Window
    public class FrontRightWindow
    {
        public int FrontRightWindowId { get; set; }
        public string FrontRightWindowData { get; set; }
        public int vinid { get; set; }
        public bool status { get; set; }
    }
    //24.Rear Right Window
    public class RearRightWindow
    {
        public int RearRightWindowId { get; set; }
        public string RearRightWindowData { get; set; }
        public int vinid { get; set; }
        public bool status { get; set; }
    }
    //25.Rear Windshield
    public class RearWindshield
    {
        public int RearWindshieldId { get; set; }
        public string RearWindshieldData { get; set; }
        public int vinid { get; set; }
        public bool status { get; set; }
    }
    //26.Front Right Wheel & Tire
    public class FrontRightWheelTire
    {
        public int FrontRightWheelTireId { get; set; }
        public string FrontRightWheelTireData { get; set; }
        public int vinid { get; set; }
        public bool status { get; set; }
    }
    //27.Rear Right Wheel & Tire
    public class RearRightWheelTire
    {
        public int RearRightWheelTireId { get; set; }
        public string RearRightWheelTireData { get; set; }
        public int vinid { get; set; }
        public bool status { get; set; }
    }
    //28.Right Tail Light
    public class RightTailLight
    {
        public int RightTailLightId { get; set; }
        public string RightTailLightData { get; set; }
        public int vinid { get; set; }
        public bool status { get; set; }
    }
    //29.Left Tail Light(driver side)
    public class LeftTailLightdriverside
    {
        public int LeftTailLightdriversideId { get; set; }
        public string LeftTailLightdriversideData { get; set; }
        public int vinid { get; set; }
        public bool status { get; set; }
    }
    //30.Right Mirror
    public class RightMirror
    {
        public int RightMirrorId { get; set; }
        public string RightMirrorData { get; set; }
        public int vinid { get; set; }
        public bool status { get; set; }
    }


}
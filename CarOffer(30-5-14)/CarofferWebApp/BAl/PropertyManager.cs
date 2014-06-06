using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarofferWebApp.DAl;
using System.Data;
using System.Data.SqlClient;


namespace CarofferWebApp.BAl
{
    public class PropertyManager
    {
        public DLogic dl = new DLogic();
        public PropertyManager()
        {
            //DLogic dl = new DLogic();
        }

        //UserCaroffer insertion to DB
        public DataTable getdatatable_forChecklist()
        {
            DataTable dt = null;
            try
            {
                dt = dl.getdatatable_Checkboxlist();
                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
            // chkList.DataTextField = "fld_VehicleOptFeatText";
            // chkList.DataValueField = "fld_VehicleOptFeatId";
            // chkList.DataBind();
            // SqlCon.Close();

        }

        //insert vinnumber//
        public int insertvinnumber(string vinnumber)
        {

            int vin_id = dl.Insert_VinIDInformation(vinnumber);
            return vin_id;
        }

        //insert vin car detials//
        public void insertvincardetails(Utilities.VehicleSpecifications obj_balvspec, int vin_id)
        {
            dl.Insert_VehicleSpecification(obj_balvspec, vin_id);
        }

        // insert vehicle owner details//
        public void insertvehicleownerinformation(Utilities.VehicleOwnerInformation obj_balvowninfo, int vin_id)
        {
            dl.Insert_OwnerInformation(obj_balvowninfo, vin_id);
        }

        //insert vehicle details //
        public void insertvehicledetails(Utilities.VehicleDetails obj_balvdetails, int vin_id)
        {
            dl.Insert_VehicleDetails(obj_balvdetails, vin_id);
        }

        // insert image //
        public void insertimagepath()
        {

        }

        //insert interior condition details//
        public void insertinteriorconditiondetails(Utilities.VehicleConditionDetails obj_balvinteriorcond, int vin_id)
        {
            dl.Insert_InteriorCondition(obj_balvinteriorcond, vin_id);
        }

        //insert mechanical condition details//
        public void insertmechanicalconditiondetails(Utilities.VehicleConditionDetails obj_balvmechanicalcond, int vin_id)
        {
            dl.Insert_MechanicalCondition(obj_balvmechanicalcond, vin_id);
        }
        // insert Vehicle opt features(60 ITEMS)//
        public void insertVehicleoptfeatures(string childata)
        {
            dl.Insert_VehicleOptFeatures(childata);
        }

        public void DeleteVehicleoptFeaturesByVInid(int vinid)
        {
            dl.DeleteVehicleOptionsFetures(vinid);
        }

        // ImageMap Insertion//
        //1.Front Bumper
        public void InsertFrontBumperDT(string childdata)
        {
            dl.Usp_InsertFrontBumperDT(childdata);
        }
        //2.Hood
        public void InsertHoodDT(string childdata)
        {
            dl.Usp_InsertHoodDT(childdata);
        }
        //3.Roof
        public void InsertRoofDT(string childdata)
        {
            dl.Usp_InsertRoofDT(childdata);
        }
        //4.Front Left Fender
        public void InsertFrontLeftFenderDT(string childdata)
        {
            dl.Usp_InsertFrontLeftFenderDT(childdata);
        }
        //5.Front Left Door
        public void InsertFrontLeftDoorDT(string childdata)
        {
            dl.Usp_InsertFrontLeftDoorDT(childdata);
        }
        //6.Rear Left Door
        public void InsertRearLeftDoorDT(string childdata)
        {
            dl.Usp_InsertRearLeftDoorDT(childdata);
        }
        //7.Rear Left Quarter Panel
        public void InsertRearLeftQuarterPanelDT(string childdata)
        {
            dl.Usp_InsertRearLeftQuarterPanelDT(childdata);
        }
        //8.Front Left Window
        public void InsertFrontLeftWindowDT(string childdata)
        {
            dl.Usp_InsertFrontLeftWindowDT(childdata);
        }
        //9.Rear Left Window
        public void InsertRearLeftWindowDT(string childdata)
        {
            dl.Usp_InsertRearLeftWindowDT(childdata);
        }
        //10.Front Windshield
        public void InsertFrontWindshieldDT(string childdata)
        {
            dl.Usp_InsertFrontWindshieldDT(childdata);
        }
        //11.Front Left Wheel& Tire
        public void InsertFrontLeftWheelTireDT(string childdata)
        {
            dl.Usp_InsertFrontLeftWheelTireDT(childdata);
        }
        //12.Rear Left Wheel& Tire
        public void InsertRearLeftWheelTireDT(string childdata)
        {
            dl.Usp_InsertRearLeftWheelTireDT(childdata);
        }
        //13.Front Left Headlight
        public void InsertFrontLeftHeadlightDT(string childdata)
        {
            dl.Usp_InsertFrontLeftHeadlightDT(childdata);
        }
        //14.Front Right Headlight
        public void InsertFrontRightHeadlightDT(string childdata)
        {
            dl.Usp_InsertFrontRightHeadlightDT(childdata);
        }
        //15.Left Mirror
        public void InsertLeftMirrorDT(string childdata)
        {
            dl.Usp_InsertLeftMirrorDT(childdata);
        }
        //16.Repeat Previous Roof//
        //17.Trunk
        public void InsertTrunkDT(string childdata)
        {
            dl.Usp_InsertTrunkDT(childdata);
        }
        //18.Rear Bumper
        public void InsertRearBumperDT(string childdata)
        {
            dl.Usp_InsertRearBumperDT(childdata);
        }
        //19.Rear Right Quarter Panel
        public void InsertRearRightQuarterPanelDT(string childdata)
        {
            dl.Usp_InsertRearRightQuarterPanelDT(childdata);
        }
        //20.Front Right Fender
        public void InsertFrontRightFenderDT(string childdata)
        {
            dl.Usp_InsertFrontRightFenderDT(childdata);
        }
        //21.Front Right Door
        public void InsertFrontRightDoorDT(string childdata)
        {
            dl.Usp_InsertFrontRightDoorDT(childdata);
        }
        //22.Rear Right Door
        public void InsertRearRightDoorDT(string childdata)
        {
            dl.Usp_InsertRearRightDoorDT(childdata);
        }
        //23.Front Right Window
        public void InsertFrontRightWindowDT(string childdata)
        {
            dl.Usp_InsertFrontRightWindowDT(childdata);
        }
        //24.Rear Right Window
        public void InsertRearRightWindowDT(string childdata)
        {
            dl.Usp_InsertRearRightWindowDT(childdata);   
        }
        //25.Rear Windshield
        public void InsertRearWindshieldDT(string childdata)
        {
            dl.Usp_InsertRearWindshieldDT(childdata);
        }
        //26.Front Right Wheel & Tire
        public void InsertFrontRightWheelTireDT(string childdata)
        {
            dl.Usp_InsertFrontRightWheelTireDT(childdata);
        }
        //27.Rear Right Wheel & Tire
        public void InsertRearRightWheelTireDT(string childdata)
        {
            dl.Usp_InsertRearRightWheelTireDT(childdata);
        }
        //28.Right Tail Light
        public void InsertRightTailLightDT(string childdata)
        {
            dl.Usp_InsertRightTailLightDT(childdata);
        }
        //29.Left Tail Light(driver side)
        public void InsertLeftTailLightdriversideDT(string childdata)
        {
            dl.Usp_InsertLeftTailLightdriversideDT(childdata);
        }
        //30.Right Mirror
        public void InsertRightMirrorDT(string childdata)
        {
            dl.Usp_InsertRightMirrorDT(childdata);   
        }



       

        //AdminCaroffer
        public DataTable getVehiclespecification()
        {
            DataTable dt = null;
            try
            {
                dt = dl.getVehiclespecificationData();
                return dt;
            }
            catch (Exception e2)
            {
                throw e2;
            }
        }

        public DataTable getVehiclespecificationById(string  vinnum)
        {
            DataTable dt = null;
            try
            {
                dt = dl.getVehiclespecificationByVinID(vinnum);
                return dt;
            }
            catch (Exception et)
            {
                throw et;
            }
        }





        public DataTable getVehicleSpecSummaryAdmin(int vinid)
        {
            DataTable dt = null;
            try
            {

                dt = dl.getVehicleSpecificationData_summary_admin(vinid);
                return dt;
            }
            catch (Exception er)
            {
                throw er;
            }
        }
        public DataTable getVehicleOwnerSummaryAdmin(int vinid)
        {
            DataTable dt = null;
            try
            {
                dt = dl.getVehicleOwnerInformation_summary_admin(vinid);
                return dt;
            }
            catch (Exception ef)
            {
                throw ef;
            }
        }
        public DataTable getVehicleDetailsSummaryAdmin(int vinid)
        {
            DataTable dt = null;
            try
            {

                dt = dl.getVehicleDetails_summary_admin(vinid);
                return dt;
            }
            catch (Exception er)
            {
                throw er;
            }
        }
        public DataTable getdataToBServiced()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dl.getVehicleSpecificationToBserviced();
                return dt;
            }
            catch (Exception et)
            {
                throw et;
            }

        }
        public DataTable getdataServicedAlready()
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dl.getVehicleSpecificationserviced();
                return dt;
            }
            catch (Exception rt)
            {
                throw rt;
            }

        }
        public DataTable getVehicleoptionfetures_summary_admin(int vinid)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dl.getVehicleOptionFeatures_Summary_admin(vinid);
                return dt;
            }
            catch (Exception et)
            {
                throw et;
            }
        }

        public DataTable getVehicleUploadedImages_Summary_Admin_fill(int vinid)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dl.getVehicleUploadedImages_summary_admin(vinid);
                return dt;
            }
            catch (Exception gt)
            {
                throw gt;
            }
        }


        // 1.//1 Front Bumper
        public DataTable getFrontBumperData_Summry_Admin_fill(int vinid)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dl.getFrontBumperData_Summry_Admin(vinid);
                return dt;
            }
            catch (Exception ft)
            {
                throw ft;
            }
        }


        // 2 Hood

        public DataTable getHoodData_Summry_Admin_fill(int vinid)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dl.getHoodData_Summry_Admin(vinid);
                return dt;
            }
            catch (Exception ft)
            {
                throw ft;
            }
        }

        // 3.Roof
        public DataTable getRoofData_Summry_Admin_fill(int vinid)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dl.getRoofData_Summry_Admin(vinid);
                return dt;
            }
            catch (Exception ft)
            {
                throw ft;
            }
        }

        // 4. Front_Left_fender
        public DataTable getFront_Left_fenderData_Summry_Admin_fill(int vinid)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dl.getFront_Left_fenderData_Summry_Admin(vinid);
                return dt;
            }
            catch (Exception ft)
            {
                throw ft;
            }
        }

        // 5 Front_Left_Door
        public DataTable getFront_Left_DoorData_Summry_Admin_fill(int vinid)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dl.getFront_Left_DoorData_Summry_Admin(vinid);
                return dt;
            }
            catch (Exception ft)
            {
                throw ft;
            }

        }

        // 6. RearLeftDoor
        public DataTable getRearLeftDoorData_Summry_Admin_fill(int vinid)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dl.getRearLeftDoorData_Summry_Admin(vinid);
                return dt;
            }
            catch (Exception ft)
            {
                throw ft;
            }
        }

        // 7. RearLeftQuarterPanel
        public DataTable getRearLeftQuarterPanelData_Summry_Admin_fill(int vinid)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dl.getRearLeftQuarterPanelData_Summry_Admin(vinid);
                return dt;
            }
            catch (Exception ft)
            {
                throw ft;
            }
        }

    // 8.FrontLeftWindow
        public DataTable getFrontLeftWindowData_Summry_Admin_fill(int vinid)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dl.getFrontLeftWindowData_Summry_Admin(vinid);
                return dt;
            }
            catch (Exception ft)
            {
                throw ft;
            }

        }


        // 9. RearLeftWindow
        public DataTable getRearLeftWindowData_Summry_Admin_fill(int vinid)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dl.getRearLeftWindowData_Summry_Admin(vinid);
                return dt;
            }
            catch (Exception ft)
            {
                throw ft;
            }
        }

        // 10  FrontWindshield
        public DataTable getFrontWindshieldData_Summry_Admin_fill(int vinid)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dl.getFrontWindshieldData_Summry_Admin(vinid);
                return dt;
            }
            catch (Exception ft)
            {
                throw ft;
            }
        }
        
        // 11 FrontLeftWheelTire
        public DataTable getFrontLeftWheelTireData_Summry_Admin_fill(int vinid)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dl.getFrontLeftWheelTireData_Summry_Admin(vinid);
                return dt;
            }
            catch (Exception ft)
            {
                throw ft;
            }
        }

        // 12  RearLeftWheelTire

        public DataTable getRearLeftWheelTireData_Summry_Admin_fill(int vinid)
        {   
            DataTable dt = new DataTable();
            try
            {
                dt = dl.getRearLeftWheelTireData_Summry_Admin(vinid);
                return dt;
            }
            catch (Exception ft)
            {
                throw ft;
            }
        }

        // 13 FrontLeftHeadlight
        public DataTable getFrontLeftHeadlightData_Summry_Admin_fill(int vinid)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dl.getFrontLeftHeadlightData_Summry_Admin(vinid);
                return dt;
            }
            catch (Exception ft)
            {
                throw ft;
            }
        }

        // 14  FrontRighttHeadlight
        public DataTable getFrontRighttHeadlightData_Summry_Admin_fill(int vinid)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dl.getFrontRighttHeadlightData_Summry_Admin(vinid);
                return dt;
            }
            catch (Exception ft)
            {
                throw ft;
            }
        }

        // 15 LeftMirror

        public DataTable getLeftMirrorData_Summry_Admin_fill(int vinid)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dl.getLeftMirrorData_Summry_Admin(vinid);
                return dt;
            }
            catch (Exception ft)
            {
                throw ft;
            }
        }

     // 16 Trunk
        public DataTable getTrunkData_Summry_Admin_fill(int vinid)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dl.getTrunkData_Summry_Admin(vinid);
                return dt;
            }
            catch (Exception ft)
            {
                throw ft;
            }
        }

        // 17 RearBumper

        public DataTable getRearBumperData_Summry_Admin_fill(int vinid)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dl.getRearBumperData_Summry_Admin(vinid);
                return dt;
            }
            catch (Exception ft)
            {
                throw ft;
            }
        }

        // 18 RearRightQuarterPanel

        public DataTable getRearRightQuarterPanelData_Summry_Admin_fill(int vinid)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dl.getRearRightQuarterPanelData_Summry_Admin(vinid);
                return dt;
            }
            catch (Exception ft)
            {
                throw ft;
            }
        }

        // 19 FrontRightFender

        public DataTable getFrontRightFenderData_Summry_Admin_fill(int vinid)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dl.getFrontRightFenderData_Summry_Admin(vinid);
                return dt;
            }
            catch (Exception ft)
            {
                throw ft;
            }
        }

        // 20 FrontRightDoor

        public DataTable getFrontRightDoorData_Summry_Admin_fill(int vinid)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dl.getFrontRightDoorData_Summry_Admin(vinid);
                return dt;
            }
            catch (Exception ft)
            {
                throw ft;
            }
        }

        // 21 RearRightDoor

        public DataTable getRearRightDoorData_Summry_Admin_fill(int vinid)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dl.getRearRightDoorData_Summry_Admin(vinid);
                return dt;
            }
            catch (Exception ft)
            {
                throw ft;
            }
        }

        // 22 FrontRightWindow

        public DataTable getFrontRightWindowData_Summry_Admin_fill(int vinid)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dl.getFrontRightWindowData_Summry_Admin(vinid);
                return dt;
            }
            catch (Exception ft)
            {
                throw ft;
            }
        }

        // 23 RearRightWindow
        public DataTable getRearRightWindowData_Summry_Admin_fill(int vinid)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dl.getRearRightWindowData_Summry_Admin(vinid);
                return dt;

            }
            catch (Exception ft)
            {
                throw ft;
            }
        }

        // 24  RearWindshield
        public DataTable getRearWindshieldData_Summry_Admin_fill(int vinid)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dl.getRearWindshieldData_Summry_Admin(vinid);
                return dt;
            }
            catch (Exception ft)
            {
                throw ft;
            }
        }

        // 25  FrontRightWheelTire
        public DataTable getFrontRightWheelTireData_Summry_Admin_fill(int vinid)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dl.getFrontRightWheelTireData_Summry_Admin(vinid);
                return dt;
            }
            catch (Exception ft)
            {
                throw ft;
            }
        }

        // 26  RearRightWheelTire

        public DataTable getRearRightWheelTireData_Summry_Admin_fill(int vinid)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dl.getRearRightWheelTireData_Summry_Admin(vinid);
                return dt;
            }
            catch (Exception ft)
            {
                throw ft;
            }

        }

        // 27 RightTailLight
        public DataTable getRightTailLightData_Summry_Admin_fill(int vinid)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dl.getRightTailLightData_Summry_Admin(vinid);
                return dt;
            }
            catch (Exception ft)
            {
                throw ft;
            }

        }

        // 28  LeftTailLight

        public DataTable getLeftTailLightData_Summry_Admin_fill(int vinid)
        {
            DataTable dt = new DataTable();
            try
            {
                dt = dl.getLeftTailLightData_Summry_Admin(vinid);
                return dt;
            }
            catch (Exception ft)
            {
                throw ft;
            }
        }

        // 29 RightMirror

        public DataTable getRightMirrorData_Summry_Admin_fill(int vinid)
        {
            DataTable dt = new DataTable();
            try
            {

                dt = dl.getRightMirrorData_Summry_Admin(vinid);
                return dt;
            }
            catch (Exception ft)
            {
                throw ft;
            }
        }








        //manager to insert  ImagesDT to DB
        public void InsertImages_DT(int vinid, string childdata)
        {
            dl.Insert_uploaded_Images(vinid, childdata);
        }

        // deleteing uploade images
        public void Delete_imagesUploaded(int vinid)
        {
            dl.DeleteUploadedIamges(vinid);
                
        }

        // 1 deleteing Frontbumber  

        public void Delete_FrontBumperdata(int vinid)
        {
            dl.DeleteFrontBumperdata(vinid);

       }

        //  2 FrontLeftDoor
        public void Delete_FrontLeftDoordata(int vinid)
        {
            
            dl.DeleteFrontLeftDoordata(vinid);

        }
        // 3  FRONTLEFTFENDER
        public void Delete_FRONTLEFTFENDERdata(int vinid)
        {

            dl.DeleteFRONTLEFTFENDERdata(vinid);

        }

        // 4 FRONTLEFTHEADLIGHT
        public void Delete_FRONTLEFTHEADLIGHTdata(int vinid)
        {

            dl.DeleteFRONTLEFTHEADLIGHTdata(vinid);

        }

        // 5 FRONTLEFTWHEELTIRE
        public void Delete_FRONTLEFTWHEELTIREdata(int vinid)
        {

            dl.DeleteFRONTLEFTWHEELTIREdata(vinid);

        }

        // 6 FRONTLEFTWINDOW

        public void Delete_FRONTLEFTWINDOWdata(int vinid)
        {

            dl.DeleteFRONTLEFTWINDOWdata(vinid);

        }

        // 7 FRONTRIGHTDOOR 
        public void Delete_FRONTRIGHTDOORdata(int vinid)
        {

            dl.DeleteFRONTRIGHTDOORdata(vinid);

        }

        // 8 FRONTRIGHTFENDER
        public void Delete_FRONTRIGHTFENDERdata(int vinid)
        {

            dl.DeleteFRONTRIGHTFENDERdata(vinid);

        }

        // 9 FRONTRIGHTHEADLIGHT
        public void Delete_FRONTRIGHTHEADLIGHTdata(int vinid)
        {

            dl.DeleteFRONTRIGHTHEADLIGHTdata(vinid);

        }

        // 10 FRONTRIGHTWHEELTIRE
        public void Delete_FRONTRIGHTWHEELTIREdata(int vinid)
        {

            dl.DeleteFRONTRIGHTWHEELTIREdata(vinid);

        }

        // 11 FRONTRIGHTWINDOW

        public void Delete_FRONTRIGHTWINDOWdata(int vinid)
        {

            dl.DeleteFRONTRIGHTWINDOWdata(vinid);

        }


        // 12 FRONTWINDSHIELD
        public void Delete_FRONTWINDSHIELDdata(int vinid)
        {

            dl.DeleteFRONTWINDSHIELDdata(vinid);

        }

        // 13 HOOD

        public void Delete_HOODdata(int vinid)
        {

            dl.DeleteHOODdata(vinid);

        }

        // 14 LEFTMIRROR
        public void Delete_LEFTMIRRORdata(int vinid)
        {

            dl.DeleteLEFTMIRRORdata(vinid);

        }

        // 15 LEFTTAILLIGHT 

        public void Delete_LEFTTAILLIGHTdata(int vinid)
        {

            dl.DeleteLEFTTAILLIGHTdata(vinid);

        }

        // 16 REARBUMPER
        public void Delete_REARBUMPERdata(int vinid)
        {

            dl.DeleteREARBUMPERdata(vinid);

        }
        // 17 REARLEFTDOOR
        public void Delete_REARLEFTDOORdata(int vinid)
        {

            dl.DeleteREARLEFTDOORdata(vinid);

        }

        // 18 REARLEFTQUARTERPANEL
        public void Delete_REARLEFTQUARTERPANELdata(int vinid)
        {

            dl.DeleteREARLEFTQUARTERPANELdata(vinid);

        }


        // 19 REARLEFTWHEELTIRE
        public void Delete_REARLEFTWHEELTIREdata(int vinid)
        {

            dl.DeleteREARLEFTWHEELTIREdata(vinid);

        }


        // 20 REARLEFTWINDOW
        public void Delete_REARLEFTWINDOWdata(int vinid)
        {

            dl.DeleteREARLEFTWINDOWdata(vinid);

        }

        // 21  REARRIGHTDOOR
        public void Delete_REARRIGHTDOORdata(int vinid)
        {

            dl.DeleteREARRIGHTDOORdata(vinid);

        }

        // 22 DeleteREARRIGHTQUARTERPANELdata
        public void Delete_REARRIGHTQUARTERPANELdata(int vinid)
        {

            dl.DeleteREARRIGHTQUARTERPANELdata(vinid);

        }

        // 23  REARRIGHTWHEELTIRE

        public void Delete_REARRIGHTWHEELTIREdata(int vinid)
        {

            dl.DeleteREARRIGHTWHEELTIREdata(vinid);

        }

        // 24 REARRIGHTWINDOW 

        public void Delete_REARRIGHTWINDOWdata(int vinid)
        {

            dl.DeleteREARRIGHTWINDOWdata(vinid);

        }

        // 25  REARWINDSHIELD

        public void Delete_REARWINDSHIELDdata(int vinid)
        {

            dl.DeleteREARWINDSHIELDdata(vinid);

        }

        // 26  RIGHTMIRROR
        public void Delete_RIGHTMIRRORdata(int vinid)
        {

            dl.DeleteRIGHTMIRRORdata(vinid);

        }

        // 27 RIGHTTAILLIGHT

        public void Delete_RIGHTTAILLIGHTdata(int vinid)
        {

            dl.DeleteRIGHTTAILLIGHTdata(vinid);

        }

        // 28 ROOF

        public void Delete_ROOFdata(int vinid)
        {

            dl.DeleteROOFdata(vinid);

        }

        // 29 TRUNK
        public void Delete_TRUNKdata(int vinid)
        {

            dl.DeleteTRUNKdata(vinid);

        }

        // auto control extender
       // public List<string> callAutoextendermethod(string prefixText)
       //{
       //   List<string> vins =new List<string>();
       //   vins = DLogic.GetVins(prefixText);
       //   return vins;
       //// GetVins(prefixText);


       //}



    }
}
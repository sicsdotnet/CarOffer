using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace CarofferWebApp.DAl
{
    public class DLogic
    {
        SqlConnection conn;
        SqlDataAdapter adt;
        string conStr = System.Configuration.ConfigurationManager.ConnectionStrings["connStrcaroffer"].ConnectionString;
        // public SqlConnection con = new SqlConnection("Data Source=;Initial Catalog=; integrated security=");

        public DLogic()
        {
            conn = new SqlConnection(conStr);
        }

        //autocomplete extender
        //public DataTable getAutoCompleteData(string prefixText)
        //{
        //    try
        //    {
        //        string constr = "Data Source=203.124.106.176;Initial Catalog=Caroffer_DB; User ID=sicsjp; Password=user@123;";
        //        SqlConnection con = new SqlConnection(constr);
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = conn;
        //        con.Open();
        //        cmd.CommandText = "select * from TB_VEHICLE_VIN where VIN like @vin+'%'";
        //        cmd.Parameters.AddWithValue("@vin", prefixText);
        //        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        adp.Fill(dt);
        //        return dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //}


        // Getting a row by Vinid

        public DataTable getVehiclespecificationByVinID(string vinnum)
        {
            try
            {
                SqlDataAdapter adt = new SqlDataAdapter("select v.VIN,v.id,s.VIN_ID,s.YEAR,s.MAKE,s.MODEL,s.STYLE,s.SERIES,s.TRANSMISSION,s.ENGINE from TB_VEHICLE_VIN v inner join TB_VEHICLE_SPECIFICATION s  on v.id=s.VIN_ID where v.VIN='"+vinnum+"'", conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }















        public DataTable getdatatable_Checkboxlist()
        {
            try
            {
                SqlDataAdapter adt = new SqlDataAdapter("select * from TB_VEHICLE_STYLE ", conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable getVehiclespecificationData()
        {
            try
            {
                SqlDataAdapter adt = new SqlDataAdapter("select v.VIN,v.id,s.VIN_ID,s.YEAR,s.MAKE,s.MODEL,s.STYLE,s.SERIES,s.TRANSMISSION,s.ENGINE from TB_VEHICLE_VIN v inner join TB_VEHICLE_SPECIFICATION s  on v.id=s.VIN_ID", conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable getVehicleSpecificationToBserviced()
        {
            try
            {
                SqlDataAdapter adt = new SqlDataAdapter("select v.VIN,v.id,s.VIN_ID,s.YEAR,s.MAKE,s.MODEL,s.STYLE,s.SERIES,s.TRANSMISSION,s.ENGINE from TB_VEHICLE_VIN v inner join TB_VEHICLE_SPECIFICATION s  on v.id=s.VIN_ID where v.STATUS=0 and s.status=0", conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable getVehicleSpecificationserviced()
        {
            try
            {
                SqlDataAdapter adt = new SqlDataAdapter("select v.VIN,v.id,s.VIN_ID,s.YEAR,s.MAKE,s.MODEL,s.STYLE,s.SERIES,s.TRANSMISSION,s.ENGINE from TB_VEHICLE_VIN v inner join TB_VEHICLE_SPECIFICATION s  on v.id=s.VIN_ID where v.STATUS=1 and s.status=1", conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable getVehicleSpecificationData_summary_admin(int vinidd)
        {
            try
            {
                // int vinid = Convert.ToInt32(vinidd);
                SqlDataAdapter adt = new SqlDataAdapter("select v.VIN,s.YEAR,s.MAKE,s.MODEL,s.STYLE,s.TRANSMISSION,s.ENGINE from TB_VEHICLE_VIN v inner join TB_VEHICLE_SPECIFICATION s  on v.id=s.VIN_ID where s.VIN_ID=" + vinidd, conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public DataTable getVehicleOwnerInformation_summary_admin(int vinidd)
        {
            try
            {
                SqlDataAdapter adt = new SqlDataAdapter("select FIRST_NAME,LAST_NAME,EMAIL,ZIP_CODE,TELEPHONE,LEASING_FINANCING,HEAR_ABOUT,REGISTRATION_STATE,AMOUNT_EXPECTED,FINANCING_COMPANY_NAME,LEASING_COMPANY_NAME,F_BALANCE_DUE,L_BALANCE_DUE,VIN_ID from TB_VEHICLE_OWNER_INFORMATION where VIN_ID=" + vinidd, conn);

                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable getVehicleDetails_summary_admin(int vinidd)
        {
            try
            {
                SqlDataAdapter adt = new SqlDataAdapter("select VEHICLE_MILAGE,ACTUAL_ACCURATE,EXTERIOR_COLOR,INTERIOR_COLOR,ORIGINAL_OWNER,OWNED_90DAYS,PURCHASED_FROM,VEHICLE_SMOKE_BAD_ODOR,SERVICE_HISTORY_RECORD,KEY_ALARM_PAD,TAXI_RENTAL,INSURANCE_CLAIM_FILED,INSURANCE_CLAIM_DATE,INSURANCE_CLAIM_AMOUNT,PERFORMANCE_MODIFICTIONS,PERFORMANCE_MODIFICTIONS_DETAILS,IPMENTS_INSTALLED,EQUIPMENTS_INSTALLED_DETAILS from TB_VEHICLE_DETAILS where VIN_ID=" + vinidd, conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable getVehicleOptionFeatures_Summary_admin(int vinidd)
        {
            try
            {
                SqlDataAdapter adt = new SqlDataAdapter("select FEATURES from TB_VEHICLE_OPTIION_FETURES_ORIGINAL where VIN_ID=" + vinidd, conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public DataTable getVehicleUploadedImages_summary_admin(int vinidd)
        {
            try
            {
                SqlDataAdapter adt = new SqlDataAdapter("select IMAGE_PATH from TB_VEHICLE_IMAGE where VIN_ID=" + vinidd, conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



        //1 Front Bumper
        public DataTable getFrontBumperData_Summry_Admin(int vinidd)
        {
            try
            {
                SqlDataAdapter adt = new SqlDataAdapter("select FRONTBUMPER_DATA from TB_INSERTFRONTBUMPER where VIN_ID=" + vinidd, conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        // 2 Hood
        public DataTable getHoodData_Summry_Admin(int vinidd)
        {
            try
            {
                SqlDataAdapter adt = new SqlDataAdapter("select HOOD_DATA from TB_INSERTHOOD where VIN_ID=" + vinidd, conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        // 3.Roof

        public DataTable getRoofData_Summry_Admin(int vinidd)
        {
            try
            {
                SqlDataAdapter adt = new SqlDataAdapter("select ROOF_DATA from TB_INSERTROOF where VIN_ID=" + vinidd, conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        //4.Front_Left_fender

        public DataTable getFront_Left_fenderData_Summry_Admin(int vinidd)
        {
            try
            {
                SqlDataAdapter adt = new SqlDataAdapter("select FRONTLEFTFENDER_DATA from TB_INSERTFRONTLEFTFENDER where VIN_ID=" + vinidd, conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        // 5 Front_Left_Door

        public DataTable getFront_Left_DoorData_Summry_Admin(int vinidd)
        {
            try
            {
                SqlDataAdapter adt = new SqlDataAdapter("select FRONTLEFTDOOR_DATA from TB_INSERTFRONTLEFTDOOR where VIN_ID=" + vinidd, conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        // 6 RearLeftDoor

        public DataTable getRearLeftDoorData_Summry_Admin(int vinidd)
        {
            try
            {
                SqlDataAdapter adt = new SqlDataAdapter("select REARLEFTDOOR_DATA from TB_INSERTREARLEFTDOOR where VIN_ID=" + vinidd, conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //7  RearLeftQuarterPanel
        public DataTable getRearLeftQuarterPanelData_Summry_Admin(int vinidd)
        {
            try
            {
                SqlDataAdapter adt = new SqlDataAdapter("select REARLEFTQUARTERPANEL_DATA from TB_INSERTREARLEFTQUARTERPANEL where VIN_ID=" + vinidd, conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



        //8 FrontLeftWindow
        public DataTable getFrontLeftWindowData_Summry_Admin(int vinidd)
        {
            try
            {
                SqlDataAdapter adt = new SqlDataAdapter("select FRONTLEFTWINDOW_DATA from TB_INSERTFRONTLEFTWINDOW where VIN_ID=" + vinidd, conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        // 9 RearLeftWindow
        public DataTable getRearLeftWindowData_Summry_Admin(int vinidd)
        {
            try
            {
                SqlDataAdapter adt = new SqlDataAdapter("select REARLEFTWINDOW_DATA from TB_INSERTREARLEFTWINDOW where VIN_ID=" + vinidd, conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



        // 10 FrontWindshield
        public DataTable getFrontWindshieldData_Summry_Admin(int vinidd)
        {
            try
            {
                SqlDataAdapter adt = new SqlDataAdapter("select FRONTWINDSHIELD_DATA from TB_INSERTFRONTWINDSHIELD where VIN_ID=" + vinidd, conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        // 11 FrontLeftWheelTire
        public DataTable getFrontLeftWheelTireData_Summry_Admin(int vinidd)
        {
            try
            {
                SqlDataAdapter adt = new SqlDataAdapter("select FRONTLEFTWHEELTIRE_DATA from TB_INSERTFRONTLEFTWHEELTIRE where VIN_ID=" + vinidd, conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        // 12 RearLeftWheelTire

        public DataTable getRearLeftWheelTireData_Summry_Admin(int vinidd)
        {
            try
            {
                SqlDataAdapter adt = new SqlDataAdapter("select REARLEFTWHEELTIRE_DATA from TB_INSERTREARLEFTWHEELTIRE where VIN_ID=" + vinidd, conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        // 13 FrontLeftHeadlight
        public DataTable getFrontLeftHeadlightData_Summry_Admin(int vinidd)
        {
            try
            {
                SqlDataAdapter adt = new SqlDataAdapter("select FRONTLEFTHEADLIGHT_DATA from TB_INSERTFRONTLEFTHEADLIGHT where VIN_ID=" + vinidd, conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        // 14 FrontRighttHeadlight
        public DataTable getFrontRighttHeadlightData_Summry_Admin(int vinidd)
        {
            try
            {
                SqlDataAdapter adt = new SqlDataAdapter("select FRONTRIGHTHEADLIGHT_DATA from TB_INSERTFRONTRIGHTHEADLIGHT where VIN_ID=" + vinidd, conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        // 15 LeftMirror

        public DataTable getLeftMirrorData_Summry_Admin(int vinidd)
        {
            try
            {
                SqlDataAdapter adt = new SqlDataAdapter("select LEFTMIRROR_DATA from TB_INSERTLEFTMIRROR where VIN_ID=" + vinidd, conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


      // 16 Trunk
        public DataTable getTrunkData_Summry_Admin(int vinidd)
        {
            try
            {
                SqlDataAdapter adt = new SqlDataAdapter("select TRUNK_DATA from TB_INSERTTRUNK where VIN_ID=" + vinidd, conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        // 17 RearBumper

        public DataTable getRearBumperData_Summry_Admin(int vinidd)
        {
            try
            {
                SqlDataAdapter adt = new SqlDataAdapter("select REARBUMPER_DATA from TB_INSERTREARBUMPER where VIN_ID=" + vinidd, conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        // 18  RearRightQuarterPanel

        public DataTable getRearRightQuarterPanelData_Summry_Admin(int vinidd)
        {
            try
            {
                SqlDataAdapter adt = new SqlDataAdapter("select REARRIGHTQUARTERPANEL_DATA from TB_INSERTREARRIGHTQUARTERPANEL where VIN_ID=" + vinidd, conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        // 19 FrontRightFender

        public DataTable getFrontRightFenderData_Summry_Admin(int vinidd)
        {
            try
            {
                SqlDataAdapter adt = new SqlDataAdapter("select FRONTRIGHTFENDER_DATA from TB_INSERTFRONTRIGHTFENDER where VIN_ID=" + vinidd, conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        // 20 FrontRightDoor

        public DataTable getFrontRightDoorData_Summry_Admin(int vinidd)
        {
            try
            {
                SqlDataAdapter adt = new SqlDataAdapter("select FRONTRIGHTDOOR_DATA from TB_INSERTFRONTRIGHTDOOR where VIN_ID=" + vinidd, conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        // 21 RearRightDoor

        public DataTable getRearRightDoorData_Summry_Admin(int vinidd)
        {
            try
            {
                SqlDataAdapter adt = new SqlDataAdapter("select REARRIGHTDOOR_DATA from TB_INSERTREARRIGHTDOOR where VIN_ID=" + vinidd, conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        // 22 FrontRightWindow

        public DataTable getFrontRightWindowData_Summry_Admin(int vinidd)
        {
            try
            {
                SqlDataAdapter adt = new SqlDataAdapter("select FRONTRIGHTWINDOW_DATA from TB_INSERTFRONTRIGHTWINDOW where VIN_ID=" + vinidd, conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        // 23 RearRightWindow
        public DataTable getRearRightWindowData_Summry_Admin(int vinidd)
        {
            try
            {
                SqlDataAdapter adt = new SqlDataAdapter("select REARRIGHTWINDOW_DATA from TB_INSERTREARRIGHTWINDOW where VIN_ID=" + vinidd, conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        // 24 RearWindshield
        public DataTable getRearWindshieldData_Summry_Admin(int vinidd)
        {
            try
            {
                SqlDataAdapter adt = new SqlDataAdapter("select REARWINDSHIELDCHECK_DATA from TB_INSERTREARWINDSHIELD where VIN_ID=" + vinidd, conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        // 25 FrontRightWheelTire
        public DataTable getFrontRightWheelTireData_Summry_Admin(int vinidd)
        {
            try
            {
                SqlDataAdapter adt = new SqlDataAdapter("select FRONTRIGHTWHEELTIRE_DATA from TB_INSERTFRONTRIGHTWHEELTIRE where VIN_ID=" + vinidd, conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        // 26 RearRightWheelTire

        public DataTable getRearRightWheelTireData_Summry_Admin(int vinidd)
        {
            try
            {
                SqlDataAdapter adt = new SqlDataAdapter("select REARRIGHTWHEELTIRE_DATA from TB_INSERTREARRIGHTWHEELTIRE where VIN_ID=" + vinidd, conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



        // 27 RightTailLight
        public DataTable getRightTailLightData_Summry_Admin(int vinidd)
        {
            try
            {
                SqlDataAdapter adt = new SqlDataAdapter("select RIGHTTAILLIGHT_DATA from TB_INSERTRIGHTTAILLIGHT where VIN_ID=" + vinidd, conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        // 28 LeftTailLight

        public DataTable getLeftTailLightData_Summry_Admin(int vinidd)
        {
            try
            {
                SqlDataAdapter adt = new SqlDataAdapter("select LEFTTAILLIGHT_DATA from TB_INSERTLEFTTAILLIGHT where VIN_ID=" + vinidd, conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



        // 29 RightMirror

        public DataTable getRightMirrorData_Summry_Admin(int vinidd)
        {
            try
            {
                SqlDataAdapter adt = new SqlDataAdapter("select RIGHTMIRRORDATA from TB_RIGHTMIRROR where VIN_ID=" + vinidd, conn);
                DataTable dt = new DataTable();
                adt.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        // Insertion to DB

        public int Insert_VinIDInformation(string vinnumber)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand("Usp_InsertVinID", conn);
                conn.Open();
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@VIN", vinnumber);
                sqlcmd.Parameters.AddWithValue("@STATUS", 0);
                int vin_id = Convert.ToInt32(sqlcmd.ExecuteScalar());
                conn.Close();
                return vin_id;
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        //2.Insert Vehicle Spcification Details//
        public void Insert_VehicleSpecification(Utilities.VehicleSpecifications obj_Vdalspec, int vin_id)
        {
            try
            {
                conn.Open();
                //string query = "insert into TB_VEHICLE_SPECIFICATION(VIN_ID,YEAR,MAKE,MODEL,TRIM_STYLE,STYLE,SERIES,TRANSMISSION,ENGINE,STATUS)values(@VIN_ID,@YEAR,@MAKE,@MODEL,@TRIM_STYLE,@STYLE,@SERIES,@TRANSMISSION,@ENGINE,0)";
                SqlCommand sqlcmd = new SqlCommand("Usp_InsertVehicleDetails", conn);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@VIN_ID", vin_id);
                sqlcmd.Parameters.AddWithValue("@YEAR", obj_Vdalspec.Year);
                sqlcmd.Parameters.AddWithValue("@MAKE", obj_Vdalspec.Make);
                sqlcmd.Parameters.AddWithValue("@MODEL", obj_Vdalspec.Model);
                //sqlcmd.Parameters.AddWithValue("@TRIM_STYLE", obj_Vdalspec.Trim_style);
                sqlcmd.Parameters.AddWithValue("@STYLE", obj_Vdalspec.Style);
                sqlcmd.Parameters.AddWithValue("@SERIES", obj_Vdalspec.Series);
                sqlcmd.Parameters.AddWithValue("@TRANSMISSION", obj_Vdalspec.Transmission);
                sqlcmd.Parameters.AddWithValue("@ENGINE", obj_Vdalspec.Engine);
                sqlcmd.Parameters.AddWithValue("@STATUS", 0);
                sqlcmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //3.Insert Vehicle Owner Information Details//
        public void Insert_OwnerInformation(Utilities.VehicleOwnerInformation obj_VOwner, int vin_id)
        {
            try
            {
                //string query = "insert into TB_VEHICLE_OWNER_INFORMATION(FIRST_NAME,LAST_NAME,EMAIL,ZIP_CODE,TELEPHONE,REGISTRATION_STATE,LEASING_FINANCING,HEAR_ABOUT,AMOUNT_EXPECTED,FINANCING_COMPANY_NAME,LEASING_COMPANY_NAME,F_BALANCE_DUE,L_BALANCE_DUE,VIN_ID,STATUS)values(@FIRST_NAME,@LAST_NAME,@EMAIL,@ZIP_CODE,@TELEPHONE,@REGISTRATION_STATE,@LEASING_FINANCING,@HEAR_ABOUT,@AMOUNT_EXPECTED,@FINANCING_COMPANY_NAME,@LEASING_COMPANY_NAME,@F_BALANCE_DUE,@L_BALANCE_DUE,@VIN_ID,0)";
                conn.Open();
                SqlCommand sqlcmd = new SqlCommand("Usp_InsertOwnerInformation", conn);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@VIN_ID", vin_id);
                sqlcmd.Parameters.AddWithValue("@FIRST_NAME", obj_VOwner.First_Name);
                sqlcmd.Parameters.AddWithValue("@LAST_NAME", obj_VOwner.Last_Name);
                sqlcmd.Parameters.AddWithValue("@EMAIL", obj_VOwner.Email);
                sqlcmd.Parameters.AddWithValue("@ZIP_CODE", obj_VOwner.Zip_Code);
                sqlcmd.Parameters.AddWithValue("@TELEPHONE", obj_VOwner.telephone);
                sqlcmd.Parameters.AddWithValue("@REGISTRATION_STATE", obj_VOwner.State_Registerd);
                sqlcmd.Parameters.AddWithValue("@LEASING_FINANCING", obj_VOwner.leasing_Financing);
                sqlcmd.Parameters.AddWithValue("@HEAR_ABOUT", obj_VOwner.Hear_About);
                sqlcmd.Parameters.AddWithValue("@AMOUNT_EXPECTED", obj_VOwner.Amount_Expected);
                sqlcmd.Parameters.AddWithValue("@FINANCING_COMPANY_NAME", obj_VOwner.Financing_CompnyName_H);
                sqlcmd.Parameters.AddWithValue("@LEASING_COMPANY_NAME", obj_VOwner.Leasing_CompnyNmae_H);
                sqlcmd.Parameters.AddWithValue("@F_BALANCE_DUE", obj_VOwner.Estimated_Amount_Financing_H);
                sqlcmd.Parameters.AddWithValue("@L_BALANCE_DUE", obj_VOwner.Estimated_Amount_Leased_H);
                sqlcmd.Parameters.AddWithValue("@STATUS", 0);
                sqlcmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //4.Insert Vehicle Details//
        public void Insert_VehicleDetails(Utilities.VehicleDetails obj_VDetials, int vin_id)
        {
            //string query = "insert into TB_VEHICLE_DETAILS(VEHICLE_MILAGE,ACTUAL_ACCURATE,EXTERIOR_COLOR,INTERIOR_COLOR,ORIGINAL_OWNER,OWNED_90DAYS,PURCHASED_FROM,SERVICE_HISTORY_RECORD,LAST_MOJOR_SERVICE,INSURANCE_CLAIM_FILED,INSURANCE_CLAIM_DATE,INSURANCE_CLAIM_AMOUNT,VEHICLE_SMOKE_BAD_ODOR,KEY_ALARM_PAD,TAXI_RENTAL,EQUIPMENTS_INSTALLED,PERFORMANCE_MODIFICTIONS,PERFORMANCE_MODIFICTIONS_DETAILS,EQUIPMENTS_INSTALLED_DETAILS,VIN_ID,STATUS)values(@VEHICLE_MILAGE,@ACTUAL_ACCURATE,@EXTERIOR_COLOR,@INTERIOR_COLOR,@ORIGINAL_OWNER,@OWNED_90DAYS,@PURCHASED_FROM,@SERVICE_HISTORY_RECORD,@LAST_MOJOR_SERVICE,@INSURANCE_CLAIM_FILED,@INSURANCE_CLAIM_DATE,@INSURANCE_CLAIM_AMOUNT,@VEHICLE_SMOKE_BAD_ODOR,@KEY_ALARM_PAD,@TAXI_RENTAL,@EQUIPMENTS_INSTALLED,@PERFORMANCE_MODIFICTIONS,@PERFORMANCE_MODIFICTIONS_DETAILS,@EQUIPMENTS_INSTALLED_DETAILS,VIN_ID,STATUS)";
            try
            {
                SqlCommand sqlcmd = new SqlCommand("Usp_VehicleDetails", conn);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@VIN_ID", vin_id);
                sqlcmd.Parameters.AddWithValue("@VEHICLE_MILAGE", obj_VDetials.Vehicle_Milage);
                sqlcmd.Parameters.AddWithValue("@ACTUAL_ACCURATE", obj_VDetials.Miles_Atual);
                sqlcmd.Parameters.AddWithValue("@EXTERIOR_COLOR", obj_VDetials.Exterior_Color);
                sqlcmd.Parameters.AddWithValue("@INTERIOR_COLOR", obj_VDetials.Interior_Color);
                sqlcmd.Parameters.AddWithValue("@ORIGINAL_OWNER", obj_VDetials.Vehicle_Owner);
                sqlcmd.Parameters.AddWithValue("@OWNED_90DAYS", obj_VDetials.Owned_90_Hidden_ddl);
                sqlcmd.Parameters.AddWithValue("@PURCHASED_FROM", obj_VDetials.Dealer_Individual_Hddl);
                sqlcmd.Parameters.AddWithValue("@SERVICE_HISTORY_RECORD", obj_VDetials.Service_History_Record);
                sqlcmd.Parameters.AddWithValue("@LAST_MOJOR_SERVICE", obj_VDetials.Last_Major_Service);
                sqlcmd.Parameters.AddWithValue("@INSURANCE_CLAIM_FILED", obj_VDetials.Insurance_Claim_Done);
                sqlcmd.Parameters.AddWithValue("@INSURANCE_CLAIM_DATE", obj_VDetials.Insurance_Claim_Date);
                sqlcmd.Parameters.AddWithValue("@INSURANCE_CLAIM_AMOUNT", obj_VDetials.Insurance_Claim_Amoount);
                sqlcmd.Parameters.AddWithValue("@VEHICLE_SMOKE_BAD_ODOR", obj_VDetials.Smoke_BOdour);
                sqlcmd.Parameters.AddWithValue("@KEY_ALARM_PAD", obj_VDetials.Key_Alarm_Pad_Available);
                sqlcmd.Parameters.AddWithValue("@TAXI_RENTAL", obj_VDetials.Taxi_Rental);
                sqlcmd.Parameters.AddWithValue("@EQUIPMENTS_INSTALLED", obj_VDetials.AfterMarket_Equipment_Installed);
                sqlcmd.Parameters.AddWithValue("@PERFORMANCE_MODIFICTIONS", obj_VDetials.Performance_Modifications);
                sqlcmd.Parameters.AddWithValue("@PERFORMANCE_MODIFICTIONS_DETAILS", obj_VDetials.Performance_Modifications_Details);
                sqlcmd.Parameters.AddWithValue("@EQUIPMENTS_INSTALLED_DETAILS", obj_VDetials.AfterMarket_Equipment_Detals);
                //sqlcmd.Parameters.AddWithValue("@VIN_ID", vinid);
                sqlcmd.Parameters.AddWithValue("@STATUS", 0);
                conn.Open();
                sqlcmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //5.Insert Imagepath//
        public void Insert_ImagePath()
        {

        }

        //6.Insert Mechanical Condition//
        public void Insert_MechanicalCondition(Utilities.VehicleConditionDetails obj_VCondDetails, int vin_id)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand("Usp_InsertMechanicalCondition", conn);
                conn.Open();
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@VIN_ID", vin_id);
                sqlcmd.Parameters.AddWithValue("@MECHANICALCONDITION_DATA", obj_VCondDetails.MechanicalConditionData);
                sqlcmd.Parameters.AddWithValue("@STATUS", 0);
                sqlcmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //7.Insert Interior Condition//
        public void Insert_InteriorCondition(Utilities.VehicleConditionDetails obj_VCondDetails, int vin_id)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand("Usp_InsertInteriorCondition", conn);
                conn.Open();
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("@VIN_ID", vin_id);
                sqlcmd.Parameters.AddWithValue("@INTERIORCONDITION_DATA", obj_VCondDetails.InteriorConditionData);
                sqlcmd.Parameters.AddWithValue("@STATUS", 0);
                sqlcmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        //8.Insert checkboxlist items 1-60  //
        public void Insert_VehicleOptFeatures(string childdata)
        {
            try
            {
                //SqlConnection con = new SqlConnection("Data Source=203.124.106.176;Initial Catalog=Caroffer_DB; User ID=sicsjp; Password=user@123");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Sp_InsertDT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@opr", 2);
                cmd.Parameters.AddWithValue("@childdata", childdata);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //9.Insert 30 checkboxlist 

        //1.Front Bumper
        public void Usp_InsertFrontBumperDT(string childdata)
        {
            try
            {
                //SqlConnection con = new SqlConnection("Data Source=203.124.106.176;Initial Catalog=Caroffer_DB; User ID=sicsjp; Password=user@123");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Usp_InsertFrontBumperDT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@opr", 2);
                cmd.Parameters.AddWithValue("@childdata", childdata);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //2.Hood
        public void Usp_InsertHoodDT(string childdata)
        {
            try
            {
                //SqlConnection con = new SqlConnection("Data Source=203.124.106.176;Initial Catalog=Caroffer_DB; User ID=sicsjp; Password=user@123");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Usp_InsertHoodDT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@opr", 2);
                cmd.Parameters.AddWithValue("@childdata", childdata);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //3.Roof
        public void Usp_InsertRoofDT(string childdata)
        {
            try
            {
                //SqlConnection con = new SqlConnection("Data Source=203.124.106.176;Initial Catalog=Caroffer_DB; User ID=sicsjp; Password=user@123");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Usp_InsertRoofDT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@opr", 2);
                cmd.Parameters.AddWithValue("@childdata", childdata);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //4.Front Left Fender
        public void Usp_InsertFrontLeftFenderDT(string childdata)
        {
            try
            {
                //SqlConnection con = new SqlConnection("Data Source=203.124.106.176;Initial Catalog=Caroffer_DB; User ID=sicsjp; Password=user@123");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Usp_InsertFrontLeftFenderDT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@opr", 2);
                cmd.Parameters.AddWithValue("@childdata", childdata);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //5.Front Left Door
        public void Usp_InsertFrontLeftDoorDT(string childdata)
        {
            try
            {
                //SqlConnection con = new SqlConnection("Data Source=203.124.106.176;Initial Catalog=Caroffer_DB; User ID=sicsjp; Password=user@123");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Usp_InsertFrontLeftDoorDT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@opr", 2);
                cmd.Parameters.AddWithValue("@childdata", childdata);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //6.Rear Left Door
        public void Usp_InsertRearLeftDoorDT(string childdata)
        {
            try
            {
                //SqlConnection con = new SqlConnection("Data Source=203.124.106.176;Initial Catalog=Caroffer_DB; User ID=sicsjp; Password=user@123");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Usp_InsertRearLeftDoorDT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@opr", 2);
                cmd.Parameters.AddWithValue("@childdata", childdata);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //7.Rear Left Quarter Panel
        public void Usp_InsertRearLeftQuarterPanelDT(string childdata)
        {
            try
            {
                //SqlConnection con = new SqlConnection("Data Source=203.124.106.176;Initial Catalog=Caroffer_DB; User ID=sicsjp; Password=user@123");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Usp_InsertRearLeftQuarterPanelDT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@opr", 2);
                cmd.Parameters.AddWithValue("@childdata", childdata);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //8.Front Left Window
        public void Usp_InsertFrontLeftWindowDT(string childdata)
        {
            try
            {
                //SqlConnection con = new SqlConnection("Data Source=203.124.106.176;Initial Catalog=Caroffer_DB; User ID=sicsjp; Password=user@123");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Usp_InsertFrontLeftWindowDT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@opr", 2);
                cmd.Parameters.AddWithValue("@childdata", childdata);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //9.Rear Left Window
        public void Usp_InsertRearLeftWindowDT(string childdata)
        {
            try
            {
                //SqlConnection con = new SqlConnection("Data Source=203.124.106.176;Initial Catalog=Caroffer_DB; User ID=sicsjp; Password=user@123");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Usp_InsertRearLeftWindowDT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@opr", 2);
                cmd.Parameters.AddWithValue("@childdata", childdata);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //10.Front Windshield
        public void Usp_InsertFrontWindshieldDT(string childdata)
        {
            try
            {
                //SqlConnection con = new SqlConnection("Data Source=203.124.106.176;Initial Catalog=Caroffer_DB; User ID=sicsjp; Password=user@123");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Usp_InsertFrontWindshieldDT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@opr", 2);
                cmd.Parameters.AddWithValue("@childdata", childdata);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //11.Front Left Wheel& Tire
        public void Usp_InsertFrontLeftWheelTireDT(string childdata)
        {
            try
            {
                //SqlConnection con = new SqlConnection("Data Source=203.124.106.176;Initial Catalog=Caroffer_DB; User ID=sicsjp; Password=user@123");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Usp_InsertFrontLeftWheelTireDT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@opr", 2);
                cmd.Parameters.AddWithValue("@childdata", childdata);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //12.Rear Left Wheel& Tire
        public void Usp_InsertRearLeftWheelTireDT(string childdata)
        {
            try
            {
                //SqlConnection con = new SqlConnection("Data Source=203.124.106.176;Initial Catalog=Caroffer_DB; User ID=sicsjp; Password=user@123");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Usp_InsertRearLeftWheelTireDT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@opr", 2);
                cmd.Parameters.AddWithValue("@childdata", childdata);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //13.Front Left Headlight
        public void Usp_InsertFrontLeftHeadlightDT(string childdata)
        {
            try
            {
                //SqlConnection con = new SqlConnection("Data Source=203.124.106.176;Initial Catalog=Caroffer_DB; User ID=sicsjp; Password=user@123");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Usp_InsertFrontLeftHeadlightDT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@opr", 2);
                cmd.Parameters.AddWithValue("@childdata", childdata);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //14.Front Right Headlight
        public void Usp_InsertFrontRightHeadlightDT(string childdata)
        {
            try
            {
                //SqlConnection con = new SqlConnection("Data Source=203.124.106.176;Initial Catalog=Caroffer_DB; User ID=sicsjp; Password=user@123");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Usp_InsertFrontRightHeadlightDT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@opr", 2);
                cmd.Parameters.AddWithValue("@childdata", childdata);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //15.Left Mirror
        public void Usp_InsertLeftMirrorDT(string childdata)
        {
            try
            {
                //SqlConnection con = new SqlConnection("Data Source=203.124.106.176;Initial Catalog=Caroffer_DB; User ID=sicsjp; Password=user@123");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Usp_InsertLeftMirrorDT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@opr", 2);
                cmd.Parameters.AddWithValue("@childdata", childdata);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //16.Repeat Previous Roof//
        //17.Trunk
        public void Usp_InsertTrunkDT(string childdata)
        {
            try
            {
                //SqlConnection con = new SqlConnection("Data Source=203.124.106.176;Initial Catalog=Caroffer_DB; User ID=sicsjp; Password=user@123");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Usp_InsertTrunkDT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@opr", 2);
                cmd.Parameters.AddWithValue("@childdata", childdata);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //18.Rear Bumper
        public void Usp_InsertRearBumperDT(string childdata)
        {
            try
            {
                //SqlConnection con = new SqlConnection("Data Source=203.124.106.176;Initial Catalog=Caroffer_DB; User ID=sicsjp; Password=user@123");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Usp_InsertRearBumperDT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@opr", 2);
                cmd.Parameters.AddWithValue("@childdata", childdata);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //19.Rear Right Quarter Panel
        public void Usp_InsertRearRightQuarterPanelDT(string childdata)
        {
            try
            {
                //SqlConnection con = new SqlConnection("Data Source=203.124.106.176;Initial Catalog=Caroffer_DB; User ID=sicsjp; Password=user@123");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Usp_InsertRearRightQuarterPanelDT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@opr", 2);
                cmd.Parameters.AddWithValue("@childdata", childdata);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //20.Front Right Fender
        public void Usp_InsertFrontRightFenderDT(string childdata)
        {
            try
            {
                //SqlConnection con = new SqlConnection("Data Source=203.124.106.176;Initial Catalog=Caroffer_DB; User ID=sicsjp; Password=user@123");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Usp_InsertFrontRightFenderDT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@opr", 2);
                cmd.Parameters.AddWithValue("@childdata", childdata);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //21.Front Right Door
        public void Usp_InsertFrontRightDoorDT(string childdata)
        {
            try
            {
                //SqlConnection con = new SqlConnection("Data Source=203.124.106.176;Initial Catalog=Caroffer_DB; User ID=sicsjp; Password=user@123");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Usp_InsertFrontRightDoorDT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@opr", 2);
                cmd.Parameters.AddWithValue("@childdata", childdata);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //22.Rear Right Door
        public void Usp_InsertRearRightDoorDT(string childdata)
        {
            try
            {
                //SqlConnection con = new SqlConnection("Data Source=203.124.106.176;Initial Catalog=Caroffer_DB; User ID=sicsjp; Password=user@123");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Usp_InsertRearRightDoorDT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@opr", 2);
                cmd.Parameters.AddWithValue("@childdata", childdata);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //23.Front Right Window
        public void Usp_InsertFrontRightWindowDT(string childdata)
        {
            try
            {
                //SqlConnection con = new SqlConnection("Data Source=203.124.106.176;Initial Catalog=Caroffer_DB; User ID=sicsjp; Password=user@123");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Usp_InsertFrontRightWindowDT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@opr", 2);
                cmd.Parameters.AddWithValue("@childdata", childdata);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //24.Rear Right Window
        public void Usp_InsertRearRightWindowDT(string childdata)
        {
            try
            {
                //SqlConnection con = new SqlConnection("Data Source=203.124.106.176;Initial Catalog=Caroffer_DB; User ID=sicsjp; Password=user@123");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Usp_InsertRearRightWindowDT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@opr", 2);
                cmd.Parameters.AddWithValue("@childdata", childdata);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //25.Rear Windshield
        public void Usp_InsertRearWindshieldDT(string childdata)
        {
            try
            {
                //SqlConnection con = new SqlConnection("Data Source=203.124.106.176;Initial Catalog=Caroffer_DB; User ID=sicsjp; Password=user@123");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Usp_InsertRearWindshieldDT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@opr", 2);
                cmd.Parameters.AddWithValue("@childdata", childdata);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //26.Front Right Wheel & Tire
        public void Usp_InsertFrontRightWheelTireDT(string childdata)
        {
            try
            {
                //SqlConnection con = new SqlConnection("Data Source=203.124.106.176;Initial Catalog=Caroffer_DB; User ID=sicsjp; Password=user@123");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Usp_InsertFrontRightWheelTireDT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@opr", 2);
                cmd.Parameters.AddWithValue("@childdata", childdata);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //27.Rear Right Wheel & Tire
        public void Usp_InsertRearRightWheelTireDT(string childdata)
        {
            try
            {
                //SqlConnection con = new SqlConnection("Data Source=203.124.106.176;Initial Catalog=Caroffer_DB; User ID=sicsjp; Password=user@123");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Usp_InsertRearRightWheelTireDT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@opr", 2);
                cmd.Parameters.AddWithValue("@childdata", childdata);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //28.Right Tail Light
        public void Usp_InsertRightTailLightDT(string childdata)
        {
            try
            {
                //SqlConnection con = new SqlConnection("Data Source=203.124.106.176;Initial Catalog=Caroffer_DB; User ID=sicsjp; Password=user@123");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Usp_InsertRightTailLightDT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@opr", 2);
                cmd.Parameters.AddWithValue("@childdata", childdata);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //29.Left Tail Light(driver side)
        public void Usp_InsertLeftTailLightdriversideDT(string childdata)
        {
            try
            {
                //SqlConnection con = new SqlConnection("Data Source=203.124.106.176;Initial Catalog=Caroffer_DB; User ID=sicsjp; Password=user@123");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Usp_InsertLeftTailLightdriversideDT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@opr", 2);
                cmd.Parameters.AddWithValue("@childdata", childdata);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //30.Right Mirror
        public void Usp_InsertRightMirrorDT(string childdata)
        {
            try
            {
                //SqlConnection con = new SqlConnection("Data Source=203.124.106.176;Initial Catalog=Caroffer_DB; User ID=sicsjp; Password=user@123");
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Usp_InsertRightMirrorDT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@opr", 2);
                cmd.Parameters.AddWithValue("@childdata", childdata);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        // inserting images  uploaded to db

        public void Insert_uploaded_Images(int vinid,string childdata)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "Sp_InsertImageDT";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@opr", 2);
                cmd.Parameters.AddWithValue("@vinid", vinid);
                cmd.Parameters.AddWithValue("@childdata", childdata);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
            }

        }

        public void DeleteUploadedIamges(int vinid)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                conn.Open();
                string query = "delete from TB_VEHICLE_IMAGE where VIN_ID=" + vinid;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
            }
        }


        public void DeleteVehicleOptionsFetures(int vinid)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                conn.Open();
                string query = "delete from TB_VEHICLE_OPTIION_FETURES_ORIGINAL where VIN_ID=" + vinid;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
            }
        }



        // 1front bumper
        public void DeleteFrontBumperdata(int vinid)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                conn.Open();
                string query = "delete from TB_INSERTFRONTBUMPER where VIN_ID=" + vinid;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
            }

        }
        //2 front left door

        public void DeleteFrontLeftDoordata(int vinid)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                conn.Open();
                string query = "delete from TB_INSERTFRONTLEFTDOOR where VIN_ID=" + vinid;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
            }

        }

        // 3 Front left fender


        public void DeleteFRONTLEFTFENDERdata(int vinid)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                conn.Open();
                string query = "delete from TB_INSERTFRONTLEFTFENDER where VIN_ID=" + vinid;
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
            }

        }

        // 4 FRONTLEFTHEADLIGHT



         public void DeleteFRONTLEFTHEADLIGHTdata(int vinid)
         {
             try
             {
                 SqlCommand cmd = new SqlCommand();
                 cmd.Connection = conn;
                 conn.Open();
                 string query = "delete from TB_INSERTFRONTLEFTHEADLIGHT where VIN_ID=" + vinid;
                 cmd.CommandText = query;
                 cmd.ExecuteNonQuery();
                 conn.Close();
             }
             catch (Exception e)
             {
             }
         }


        // 5 FRONTLEFTWHEELTIRE
         public void DeleteFRONTLEFTWHEELTIREdata(int vinid)
         {
             try
             {
                 SqlCommand cmd = new SqlCommand();
                 cmd.Connection = conn;
                 conn.Open();
                 string query = "delete from TB_INSERTFRONTLEFTWHEELTIRE where VIN_ID=" + vinid;
                 cmd.CommandText = query;
                 cmd.ExecuteNonQuery();
                 conn.Close();
             }
             catch (Exception e)
             {
             }

         }

        // 6. FRONT LEFT WINDOW
         public void DeleteFRONTLEFTWINDOWdata(int vinid)
         {
             try
             {
                 SqlCommand cmd = new SqlCommand();
                 cmd.Connection = conn;
                 conn.Open();
                 string query = "delete from TB_INSERTFRONTLEFTWINDOW where VIN_ID=" + vinid;
                 cmd.CommandText = query;
                 cmd.ExecuteNonQuery();
                 conn.Close();
             }
             catch (Exception e)
             {
             }

         }

        // 7 FRONT RIGHT DOOR

         public void DeleteFRONTRIGHTDOORdata(int vinid)
         {
             try
             {
                 SqlCommand cmd = new SqlCommand();
                 cmd.Connection = conn;
                 conn.Open();
                 string query = "delete from TB_INSERTFRONTRIGHTDOOR where VIN_ID=" + vinid;
                 cmd.CommandText = query;
                 cmd.ExecuteNonQuery();
                 conn.Close();
             }
             catch (Exception e)
             {
             }

         }

        // 8 FRONT RIGHT FENDER

         public void DeleteFRONTRIGHTFENDERdata(int vinid)
         {
             try
             {

                 SqlCommand cmd = new SqlCommand();
                 cmd.Connection = conn;
                 conn.Open();
                 string query = "delete from TB_INSERTFRONTRIGHTFENDER where VIN_ID=" + vinid;
                 cmd.CommandText = query;
                 cmd.ExecuteNonQuery();
                 conn.Close();
             }
             catch (Exception e)
             {
             }

         }

        // 9  FRONT RIGHT HEADLIGHT

         public void DeleteFRONTRIGHTHEADLIGHTdata(int vinid)
         {
             try
             {
                 SqlCommand cmd = new SqlCommand();
                 cmd.Connection = conn;
                 conn.Open();
                 string query = "delete from TB_INSERTFRONTRIGHTHEADLIGHT where VIN_ID=" + vinid;
                 cmd.CommandText = query;
                 cmd.ExecuteNonQuery();
                 conn.Close();
             }
             catch (Exception e)
             {
             }

         }
        // 10 FRONT RIGHT WHEELTIRE
         public void DeleteFRONTRIGHTWHEELTIREdata(int vinid)
         {
             try
             {
                 SqlCommand cmd = new SqlCommand();
                 cmd.Connection = conn;
                 conn.Open();
                 string query = "delete from TB_INSERTFRONTRIGHTWHEELTIRE where VIN_ID=" + vinid;
                 cmd.CommandText = query;
                 cmd.ExecuteNonQuery();
                 conn.Close();
             }
             catch (Exception e)
             {
             }

         }

        // 11 TB_INSERTFRONTRIGHTWINDOW
         public void DeleteFRONTRIGHTWINDOWdata(int vinid)
         {
             try
             {
                 SqlCommand cmd = new SqlCommand();
                 cmd.Connection = conn;
                 conn.Open();
                 string query = "delete from TB_INSERTFRONTRIGHTWINDOW where VIN_ID=" + vinid;
                 cmd.CommandText = query;
                 cmd.ExecuteNonQuery();
                 conn.Close();
             }
             catch (Exception e)
             {
             }

         }

        //  12 TB_INSERTFRONTWINDSHIELD
         public void DeleteFRONTWINDSHIELDdata(int vinid)
         {
             try
             {
                 SqlCommand cmd = new SqlCommand();
                 cmd.Connection = conn;
                 conn.Open();
                 string query = "delete from TB_INSERTFRONTWINDSHIELD where VIN_ID=" + vinid;
                 cmd.CommandText = query;
                 cmd.ExecuteNonQuery();
                 conn.Close();
             }
             catch (Exception e)
             {
             }

         }

        // 13 TB_INSERTHOOD
         public void DeleteHOODdata(int vinid)
         {
             try
             {
                 SqlCommand cmd = new SqlCommand();
                 cmd.Connection = conn;
                 conn.Open();
                 string query = "delete from TB_INSERTHOOD where VIN_ID=" + vinid;
                 cmd.CommandText = query;
                 cmd.ExecuteNonQuery();
                 conn.Close();
             }
             catch (Exception e)
             {
             }

         }

       // 14 TB_INSERTLEFTMIRROR

         public void DeleteLEFTMIRRORdata(int vinid)
         {
             try
             {
                 SqlCommand cmd = new SqlCommand();
                 cmd.Connection = conn;
                 conn.Open();
                 string query = "delete from TB_INSERTLEFTMIRROR where VIN_ID=" + vinid;
                 cmd.CommandText = query;
                 cmd.ExecuteNonQuery();
                 conn.Close();
             }
             catch (Exception e)
             {
             }

         }

        //15 TB_INSERTLEFTTAILLIGHT
         public void DeleteLEFTTAILLIGHTdata(int vinid)
         {
             try
             {
                 SqlCommand cmd = new SqlCommand();
                 cmd.Connection = conn;
                 conn.Open();
                 string query = "delete from TB_INSERTLEFTTAILLIGHT where VIN_ID=" + vinid;
                 cmd.CommandText = query;
                 cmd.ExecuteNonQuery();
                 conn.Close();
             }
             catch (Exception e)
             {
             }

         }

        // 16 TB_INSERTREARBUMPER
         public void DeleteREARBUMPERdata(int vinid)
         {
             try
             {
                 SqlCommand cmd = new SqlCommand();
                 cmd.Connection = conn;
                 conn.Open();
                 string query = "delete from TB_INSERTREARBUMPER where VIN_ID=" + vinid;
                 cmd.CommandText = query;
                 cmd.ExecuteNonQuery();
                 conn.Close();
             }
             catch (Exception e)
             {
             }

         }

        // 17 TB_INSERTREARLEFTDOOR
         public void DeleteREARLEFTDOORdata(int vinid)
         {
             try
             {
                 SqlCommand cmd = new SqlCommand();
                 cmd.Connection = conn;
                 conn.Open();
                 string query = "delete from TB_INSERTREARLEFTDOOR where VIN_ID=" + vinid;
                 cmd.CommandText = query;
                 cmd.ExecuteNonQuery();
                 conn.Close();
             }
             catch (Exception e)
             {
             }

         }

        // 18 TB_INSERTREARLEFTQUARTERPANEL
         public void DeleteREARLEFTQUARTERPANELdata(int vinid)
         {
             try
             {
                 SqlCommand cmd = new SqlCommand();
                 cmd.Connection = conn;
                 conn.Open();
                 string query = "delete from TB_INSERTREARLEFTQUARTERPANEL where VIN_ID=" + vinid;
                 cmd.CommandText = query;
                 cmd.ExecuteNonQuery();
                 conn.Close();
             }
             catch (Exception e)
             {
             }

         }

        // 19 TB_INSERTREARLEFTWHEELTIRE
         public void DeleteREARLEFTWHEELTIREdata(int vinid)
         {
             try
             {
                 SqlCommand cmd = new SqlCommand();
                 cmd.Connection = conn;
                 conn.Open();
                 string query = "delete from TB_INSERTREARLEFTWHEELTIRE where VIN_ID=" + vinid;
                 cmd.CommandText = query;
                 cmd.ExecuteNonQuery();
                 conn.Close();
             }
             catch (Exception e)
             {
             }

         }


        // 20 TB_INSERTREARLEFTWINDOW
         public void DeleteREARLEFTWINDOWdata(int vinid)
         {
             try
             {
                 SqlCommand cmd = new SqlCommand();
                 cmd.Connection = conn;
                 conn.Open();
                 string query = "delete from TB_INSERTREARLEFTWINDOW where VIN_ID=" + vinid;
                 cmd.CommandText = query;
                 cmd.ExecuteNonQuery();
                 conn.Close();
             }
             catch (Exception e)
             {
             }

         }

        // 21 TB_INSERTREARRIGHTDOOR

         public void DeleteREARRIGHTDOORdata(int vinid)
         {
             try
             {
                 SqlCommand cmd = new SqlCommand();
                 cmd.Connection = conn;
                 conn.Open();
                 string query = "delete from TB_INSERTREARRIGHTDOOR where VIN_ID=" + vinid;
                 cmd.CommandText = query;
                 cmd.ExecuteNonQuery();
                 conn.Close();
             }
             catch (Exception e)
             {
             }

         }

        // 22 TB_INSERTREARRIGHTQUARTERPANEL

         public void DeleteREARRIGHTQUARTERPANELdata(int vinid)
         {
             try
             {
                 SqlCommand cmd = new SqlCommand();
                 cmd.Connection = conn;
                 conn.Open();
                 string query = "delete from TB_INSERTREARRIGHTQUARTERPANEL where VIN_ID=" + vinid;
                 cmd.CommandText = query;
                 cmd.ExecuteNonQuery();
                 conn.Close();
             }
             catch (Exception e)
             {
             }

         }

        //23 TB_INSERTREARRIGHTWHEELTIRE
         public void DeleteREARRIGHTWHEELTIREdata(int vinid)
         {
             try
             {
                 SqlCommand cmd = new SqlCommand();
                 cmd.Connection = conn;
                 conn.Open();
                 string query = "delete from TB_INSERTREARRIGHTWHEELTIRE where VIN_ID=" + vinid;
                 cmd.CommandText = query;
                 cmd.ExecuteNonQuery();
                 conn.Close();
             }
             catch (Exception e)
             {
             }

         }
        //24 TB_INSERTREARRIGHTWINDOW
         public void DeleteREARRIGHTWINDOWdata(int vinid)
         {
             try
             {
                 SqlCommand cmd = new SqlCommand();
                 cmd.Connection = conn;
                 conn.Open();
                 string query = "delete from TB_INSERTREARRIGHTWINDOW where VIN_ID=" + vinid;
                 cmd.CommandText = query;
                 cmd.ExecuteNonQuery();
                 conn.Close();
             }
             catch (Exception e)
             {
             }

         }

        // 25 TB_INSERTREARWINDSHIELD
         public void DeleteREARWINDSHIELDdata(int vinid)
         {
             try
             {
                 SqlCommand cmd = new SqlCommand();
                 cmd.Connection = conn;
                 conn.Open();
                 string query = "delete from TB_INSERTREARWINDSHIELD where VIN_ID=" + vinid;
                 cmd.CommandText = query;
                 cmd.ExecuteNonQuery();
                 conn.Close();
             }
             catch (Exception e)
             {
             }

         }

        // 26 TB_INSERTRIGHTMIRROR
         public void DeleteRIGHTMIRRORdata(int vinid)
         {
             try
             {
                 SqlCommand cmd = new SqlCommand();
                 cmd.Connection = conn;
                 conn.Open();
                 string query = "delete from TB_INSERTRIGHTMIRROR where VIN_ID=" + vinid;
                 cmd.CommandText = query;
                 cmd.ExecuteNonQuery();
                 conn.Close();
             }
             catch (Exception e)
             {
             }

         }

        // 27 TB_INSERTRIGHTTAILLIGHT
         public void DeleteRIGHTTAILLIGHTdata(int vinid)
         {
             try
             {

                 SqlCommand cmd = new SqlCommand();
                 cmd.Connection = conn;
                 conn.Open();
                 string query = "delete from TB_INSERTRIGHTTAILLIGHT where VIN_ID=" + vinid;
                 cmd.CommandText = query;
                 cmd.ExecuteNonQuery();
                 conn.Close();
             }
             catch (Exception e)
             {
             }

         }

        // 28 TB_INSERTROOF
         public void DeleteROOFdata(int vinid)
         {
             try
             {
                 SqlCommand cmd = new SqlCommand();
                 cmd.Connection = conn;
                 conn.Open();
                 string query = "delete from TB_INSERTROOF where VIN_ID=" + vinid;
                 cmd.CommandText = query;
                 cmd.ExecuteNonQuery();
                 conn.Close();
             }
             catch (Exception e)
             {
             }

         }

        // 29 TB_INSERTTRUNK
         public void DeleteTRUNKdata(int vinid)
         {
             try
             {
                 SqlCommand cmd = new SqlCommand();
                 cmd.Connection = conn;
                 conn.Open();
                 string query = "delete from TB_INSERTTRUNK where VIN_ID=" + vinid;
                 cmd.CommandText = query;
                 cmd.ExecuteNonQuery();
                 conn.Close();
             }
             catch (Exception e)
             {
             }

         }
        // Auto extender fill
         
         //public static List<string> GetVins(string prefixText)
         //{
         //    string constr = "Data Source=203.124.106.176;Initial Catalog=Caroffer_DB; User ID=sicsjp; Password=user@123;";
         //    SqlConnection con = new SqlConnection(constr);
         //    SqlCommand cmd = new SqlCommand();
         //    cmd.Connection = con;
         //    con.Open();
         //    cmd.CommandText = "select * from TB_VEHICLE_VIN where VIN like @vin+'%'";
         //    cmd.Parameters.AddWithValue("@vin", prefixText);
         //    SqlDataAdapter adp = new SqlDataAdapter(cmd);
         //    DataTable dt = new DataTable();
         //    adp.Fill(dt);
         //    List<string> Vins = new List<string>();

         //    for (int i = 0; i < dt.Rows.Count; i++)
         //    {
         //        Vins.Add(dt.Rows[i][1].ToString());
         //    }
         //    return Vins;
         //}







    }
}
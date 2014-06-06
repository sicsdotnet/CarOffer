using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace CarofferWebApp.DAl
{
    public class ImageDLogic
    {

        
        
            //Public Declarations
            DataTable Dt;
            DataSet Ds;
            SqlCommand SqlCmd;
            SqlConnection SqlConn;
            SqlDataAdapter SqlAdap;
            SqlDataReader SqlDr;
            string ConStrImgMap = System.Configuration.ConfigurationManager.ConnectionStrings["connStrcaroffer"].ToString();

            //Constructor
            public ImageDLogic()
            {
                SqlConn = new SqlConnection(ConStrImgMap);

            }
            public void OpenConn()
            {
                if (SqlConn.State == ConnectionState.Closed)
                {
                    SqlConn.Open();
                }
            }
            public void CloseConn()
            {
                if (SqlConn.State == ConnectionState.Open)
                {
                    SqlConn.Close();
                }
            }

            //1.get_fronbumperdata
            public DataTable get_frontbumperdata()
            {
                try
                {
                    SqlAdap = new SqlDataAdapter("select FRONTBUMPERID,FRONTBUMPERDATA from TB_FRONTBUMPER ", SqlConn);
                    Dt = new DataTable();
                    SqlAdap.Fill(Dt);
                    return Dt;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            //2.get_hooddata
            public DataTable get_hooddata()
            {
                try
                {
                    SqlAdap = new SqlDataAdapter("select HOODID,HOODDATA from TB_HOOD", SqlConn);
                    Dt = new DataTable();
                    SqlAdap.Fill(Dt);
                    return Dt;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            //3.get_roofdata
            public DataTable get_roofdata()
            {
                try
                {

                    SqlAdap = new SqlDataAdapter("select ROOFID,ROOFDATA from TB_ROOF", SqlConn);
                    Dt = new DataTable();
                    SqlAdap.Fill(Dt);
                    return Dt;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            //4.get_frontleftfenderdata
            public DataTable get_frontleftfenderdata()
            {
                try
                {
                    SqlAdap = new SqlDataAdapter("select FRONTLEFTFENDERID,FRONTLEFTFENDERDATA from TB_FRONTLEFTFENDER", SqlConn);
                    Dt = new DataTable();
                    SqlAdap.Fill(Dt);
                    return Dt;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            //5.get_frontleftdoordata
            public DataTable get_frontleftdoordata()
            {
                try
                {

                    SqlAdap = new SqlDataAdapter("select FRONTLEFTDOORID,FRONTLEFTDOORDATA from TB_FRONTLEFTDOOR", SqlConn);
                    Dt = new DataTable();
                    SqlAdap.Fill(Dt);
                    return Dt;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            //6.get_rearleftdoordata
            public DataTable get_rearleftdoordata()
            {
                try
                {
                    SqlAdap = new SqlDataAdapter("select REARLEFTDOORID,REARLEFTDOORDATA from TB_REARLEFTDOOR", SqlConn);
                    Dt = new DataTable();
                    SqlAdap.Fill(Dt);
                    return Dt;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            //7.get_rearleftquarterpaneldata
            public DataTable get_rearleftquarterpaneldata()
            {
                try
                {

                   SqlAdap = new SqlDataAdapter("select REARLEFTQUARTERPANELID,REARLEFTQUARTERPANELDATA from TB_REARLEFTQUARTERPANEL", SqlConn);
                    Dt = new DataTable();
                    SqlAdap.Fill(Dt);
                    return Dt;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            //8.get_frontleftwindowdata
            public DataTable get_frontleftwindowdata()
            {
                try
                {

                    SqlAdap = new SqlDataAdapter("select FRONTLEFTWINDOWID,FRONTLEFTWINDOWDATA from TB_FRONTLEFTWINDOW", SqlConn);
                    Dt = new DataTable();
                    SqlAdap.Fill(Dt);
                    return Dt;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            //9.get_rearleftwindowdata
            public DataTable get_rearleftwindowdata()
            {   try{

                SqlAdap = new SqlDataAdapter("select REARLEFTWINDOWID,REARLEFTWINDOWDATA from TB_REARLEFTWINDOW", SqlConn);
                Dt = new DataTable();
                SqlAdap.Fill(Dt);
                return Dt;
            }
            catch (Exception e)
            {
                throw e;
            }
            }
            //10.get_frontwindshielddata
            public DataTable get_frontwindshielddata()
            {
                try
                {

                    SqlAdap = new SqlDataAdapter("select FRONTWINDSHIELDID,FRONTWINDSHIELDDATA from TB_FRONTWINDSHIELD", SqlConn);
                    Dt = new DataTable();
                    SqlAdap.Fill(Dt);
                    return Dt;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            //11.get_frontleftwheeltiredata
            public DataTable get_frontleftwheeltiredata()
            {
                try
                {

                    SqlAdap = new SqlDataAdapter("select FRONTLEFTWHEELTIREID,FRONTLEFTWHEELTIREDATA from TB_FRONTLEFTWHEELTIRE", SqlConn);
                    Dt = new DataTable();
                    SqlAdap.Fill(Dt);
                    return Dt;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            //12.get_rearleftwheeltiredata
            public DataTable get_rearleftwheeltiredata()
            {
                try
                {
                    SqlAdap = new SqlDataAdapter("select REARLEFTWHEELTIREID,REARLEFTWHEELTIREDATA from TB_REARLEFTWHEELTIRE", SqlConn);
                    Dt = new DataTable();
                    SqlAdap.Fill(Dt);
                    return Dt;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            //13.get_frontleftheadlightdata
            public DataTable get_fronleftheadlightdata()
            {
                try
                {
                    SqlAdap = new SqlDataAdapter("select FRONTLEFTHEADLIGHTID,FRONTLEFTHEADLIGHTDATA from TB_FRONTLEFTHEADLIGHT", SqlConn);
                    Dt = new DataTable();
                    SqlAdap.Fill(Dt);
                    return Dt;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            //14.get_frontrightheadlightdata
            public DataTable get_frontrightheadlightdata()
            {
                try
                {
                    SqlAdap = new SqlDataAdapter("select FRONTRIGHTHEADLIGHTID,FRONTRIGHTHEADLIGHTDATA from TB_FRONTRIGHTHEADLIGHT", SqlConn);
                    Dt = new DataTable();
                    SqlAdap.Fill(Dt);
                    return Dt;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            //15.get_leftmirrordata
            public DataTable get_leftmirrordata()
            {
                try
                {
                    SqlAdap = new SqlDataAdapter("select LEFTMIRRORID,LEFTMIRRORDATA from TB_LEFTMIRROR", SqlConn);
                    Dt = new DataTable();
                    SqlAdap.Fill(Dt);
                    return Dt;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            //16.repeat get_roofdata
            //17.get_trunkdata
            public DataTable get_trunkdata()
            {
                try
                {
                    SqlAdap = new SqlDataAdapter("select TRUNKID,TRUNKDATA from TB_TRUNK", SqlConn);
                    Dt = new DataTable();
                    SqlAdap.Fill(Dt);
                    return Dt;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            //18.get_rearbumperdata
            public DataTable get_rearbumperdata()
            {
                try
                {
                    SqlAdap = new SqlDataAdapter("select REARBUMPERID,REARBUMPERDATA from TB_REARBUMPER", SqlConn);
                    Dt = new DataTable();
                    SqlAdap.Fill(Dt);
                    return Dt;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            //19.get_rearrightquarterpaneldata
            public DataTable get_rearrightquarterpaneldata()
            {
                try
                {
                    SqlAdap = new SqlDataAdapter("select REARRIGHTQUARTERPANELID,REARRIGHTQUARTERPANELDATA from TB_REARRIGHTQUARTERPANEL", SqlConn);
                    Dt = new DataTable();
                    SqlAdap.Fill(Dt);
                    return Dt;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            //20.get_frontrightfenderdata
            public DataTable get_frontrightfenderdata()
            {
                try
                {
                    SqlAdap = new SqlDataAdapter("select FRONTRIGHTFENDERID,FRONTRIGHTFENDERDATA from TB_FRONTRIGHTFENDER", SqlConn);
                    Dt = new DataTable();
                    SqlAdap.Fill(Dt);
                    return Dt;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            //21.get_frontrightdoordata
            public DataTable get_frontrightdoordata()
            {
                try
                {
                    SqlAdap = new SqlDataAdapter("select FRONTRIGHTDOORID,FRONTRIGHTDOORDATA from TB_FRONTRIGHTDOOR", SqlConn);
                    Dt = new DataTable();
                    SqlAdap.Fill(Dt);
                    return Dt;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            //22.get_rearrightdoordata
            public DataTable get_rearrightdoordata()
            {
                try
                {
                    SqlAdap = new SqlDataAdapter("select REARRIGHTDOORID,REARRIGHTDOORDATA from TB_REARRIGHTDOOR", SqlConn);
                    Dt = new DataTable();
                    SqlAdap.Fill(Dt);
                    return Dt;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            //23.get_frontrightwindowdata
            public DataTable get_frontrightwindowdata()
            {
                try
                {
                    SqlAdap = new SqlDataAdapter("select FRONTRIGHTWINDOWID,FRONTRIGHTWINDOWDATA from TB_FRONTRIGHTWINDOW", SqlConn);
                    Dt = new DataTable();
                    SqlAdap.Fill(Dt);
                    return Dt;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            //24.get_rearrightwindowdata
            public DataTable get_rearrightwindowdata()
            {
                try
                {
                    SqlAdap = new SqlDataAdapter("select REARRIGHTWINDOWID,REARRIGHTWINDOWDATA from TB_REARRIGHTWINDOW", SqlConn);
                    Dt = new DataTable();
                    SqlAdap.Fill(Dt);
                    return Dt;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            //25.get_rearwindshielddata
            public DataTable get_rearwindshielddata()
            {
                try
                {
                    SqlAdap = new SqlDataAdapter("select REARWINDSHIELDID,REARWINDSHIELDDATA from TB_REARWINDSHIELD", SqlConn);
                    Dt = new DataTable();
                    SqlAdap.Fill(Dt);
                    return Dt;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            //26.get_frontrightwheeltiredata
            public DataTable get_frontrightwheeltiredata()
            {
                try
                {

                    SqlAdap = new SqlDataAdapter("select FRONTRIGHTWHEELTIREID,FRONTRIGHTWHEELTIREDATA from TB_FRONTRIGHTWHEELTIRE", SqlConn);
                    Dt = new DataTable();
                    SqlAdap.Fill(Dt);
                    return Dt;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            //27.get_rearrightwheeltiredata
            public DataTable get_rearrightwheeltiredata()
            {
                try
                {
                    SqlAdap = new SqlDataAdapter("select REARRIGHTWHEELTIREID,REARRIGHTWHEELTIREDATA from TB_REARRIGHTWHEELTIRE", SqlConn);
                    Dt = new DataTable();
                    SqlAdap.Fill(Dt);
                    return Dt;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            //28.get_righttaillightdata
            public DataTable get_righttaillightdata()
            {
                try
                {

                    SqlAdap = new SqlDataAdapter("select RIGHTTAILLIGHTID,RIGHTTAILLIGHTDATA from TB_RIGHTTAILLIGHT", SqlConn);
                    Dt = new DataTable();
                    SqlAdap.Fill(Dt);
                    return Dt;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            //29.get_lefttaillightdriversidedata
            public DataTable get_lefttaillightdriversidedata()
            {
                try
                {
                    SqlAdap = new SqlDataAdapter("select LEFTTAILLIGHTDRIVERSIDEID,LEFTTAILLIGHTDRIVERSIDEDATA from TB_LEFTTAILLIGHTDRIVERSIDE", SqlConn);
                    Dt = new DataTable();
                    SqlAdap.Fill(Dt);
                    return Dt;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            //30.get_rightmirrordata
            public DataTable get_rightmirrordata()
            {
                try
                {
                    SqlAdap = new SqlDataAdapter("select RIGHTMIRRORID,RIGHTMIRRORDATA from TB_RIGHTMIRROR", SqlConn);
                    Dt = new DataTable();
                    SqlAdap.Fill(Dt);
                    return Dt;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        
    }
}
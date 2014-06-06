using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarofferWebApp.DAl;
using System.Data;
using System.Data.SqlClient;

namespace CarofferWebApp.BAl
{
    public class ImageMapBLL
    {
        
        
            public ImageDLogic idl = new ImageDLogic();
            public ImageMapBLL()
            {

            }
            //1.get_fronbumper
            public DataTable get_frontbumper()
            {
                DataTable dt = null;
                dt = idl.get_frontbumperdata();
                
                return dt;

            }
            //2.get_hood
            public DataTable get_hood()
            {
                DataTable dt = null;
                dt = idl.get_hooddata();
                return dt;
            }
            //3.get_roof
            public DataTable get_roof()
            {
                DataTable dt = null;
                dt = idl.get_roofdata();
                return dt;
            }
            //4.get_frontleftfender
            public DataTable get_frontleftfender()
            {
                DataTable dt = null;
                dt = idl.get_frontleftfenderdata();
                return dt;
            }
            //5.get_frontleftdoor
            public DataTable get_frontleftdoor()
            {
                DataTable dt = null;
                dt = idl.get_frontleftdoordata();
                return dt;
            }
            //6.get_rearleftdoor
            public DataTable get_rearleftdoor()
            {
                DataTable dt = null;
                dt = idl.get_rearleftdoordata();
                return dt;
            }
            //7.get_rearleftquarterpanel
            public DataTable get_rearleftquarterpanel()
            {
                DataTable dt = null;
                dt = idl.get_rearleftquarterpaneldata();
                return dt;
            }
            //8.get_frontleftwindow
            public DataTable get_frontleftwindow()
            {
                DataTable dt = null;
                dt = idl.get_frontleftwindowdata();
                return dt;
            }
            //9.get_rearleftwindow
            public DataTable get_rearleftwindow()
            {
                DataTable dt = null;
                dt = idl.get_rearleftwindowdata();
                return dt;
            }
            //10.get_frontwindshield
            public DataTable get_frontwindshield()
            {
                DataTable dt = null;
                dt = idl.get_frontwindshielddata();
                return dt;
            }
            //11.get_frontleftwheeltire
            public DataTable get_frontleftwheeltire()
            {
                DataTable dt = null;
                dt = idl.get_frontleftwheeltiredata();
                return dt;
            }
            //12.get_rearleftwheeltire
            public DataTable get_rearleftwheeltire()
            {
                DataTable dt = null;
                dt = idl.get_rearleftwheeltiredata();
                return dt;
            }
            //13.get_frontleftheadlight
            public DataTable get_fronleftheadlight()
            {
                DataTable dt = null;
                dt = idl.get_fronleftheadlightdata();
                return dt;
            }
            //14.get_frontrightheadlight
            public DataTable get_frontrightheadlight()
            {
                DataTable dt = null;
                dt = idl.get_frontrightheadlightdata();
                return dt;
            }
            //15.get_leftmirror
            public DataTable get_leftmirror()
            {
                DataTable dt = null;
                dt = idl.get_leftmirrordata();
                return dt;
            }
            //16.repeat get_roof
            //17.get_trunk
            public DataTable get_trunk()
            {
                DataTable dt = null;
                dt = idl.get_trunkdata();
                return dt;
            }
            //18.get_rearbumper
            public DataTable get_rearbumper()
            {
                DataTable dt = null;
                dt = idl.get_rearbumperdata();
                return dt;
            }
            //19.get_rearrightquarterpanel
            public DataTable get_rearrightquarterpanel()
            {
                DataTable dt = null;
                dt = idl.get_rearrightquarterpaneldata();
                return dt;
            }
            //20.get_frontrightfender
            public DataTable get_frontrightfender()
            {
                DataTable dt = null;
                dt = idl.get_frontrightfenderdata();
                return dt;
            }
            //21.get_frontrightdoor
            public DataTable get_frontrightdoor()
            {
                DataTable dt = null;
                dt = idl.get_frontrightdoordata();
                return dt;
            }
            //22.get_rearrightdoor
            public DataTable get_rearrightdoor()
            {
                DataTable dt = null;
                dt = idl.get_rearrightdoordata();
                return dt;
            }
            //23.get_frontrightwindow
            public DataTable get_frontrightwindow()
            {
                DataTable dt = null;
                dt = idl.get_frontrightwindowdata();
                return dt;
            }
            //24.get_rearrightwindow
            public DataTable get_rearrightwindow()
            {
                DataTable dt = null;
                dt = idl.get_rearrightwindowdata();
                return dt;
            }
            //25.get_rearwindshield
            public DataTable get_rearwindshield()
            {
                DataTable dt = null;
                dt = idl.get_rearwindshielddata();
                return dt;
            }
            //26.get_frontrightwheeltire
            public DataTable get_frontrightwheeltire()
            {
                DataTable dt = null;
                dt = idl.get_frontrightwheeltiredata();
                return dt;
            }
            //27.get_rearrightwheeltire
            public DataTable get_rearrightwheeltire()
            {
                DataTable dt = null;
                dt = idl.get_rearrightwheeltiredata();
                return dt;
            }
            //28.get_righttaillight
            public DataTable get_righttaillight()
            {
                DataTable dt = null;
                dt = idl.get_righttaillightdata();
                return dt;
            }
            //29.get_lefttaillightdriverside
            public DataTable get_lefttaillightdriverside()
            {
                DataTable dt = null;
                dt = idl.get_lefttaillightdriversidedata();
                return dt;
            }
            //30.get_rightmirror
            public DataTable get_rightmirror()
            {
                DataTable dt = null;
                dt = idl.get_rightmirrordata();
                return dt;
            }
        
    }
}
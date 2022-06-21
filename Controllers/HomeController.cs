using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Configuration;
using System.Data.SqlClient;


namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {

        string ConnectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Barang()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Perusahaan()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public JsonResult insertBarang( string nmBarang, string qtyBarang)
        {

            try
            {

                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Barang(NamaBarang, qty) values('"+nmBarang+"', '"+qtyBarang+"')", con );
                cmd.ExecuteNonQuery();
                con.Close();


                return Json("success", JsonRequestBehavior.AllowGet);
            }
            catch (Exception x)
            {
                return Json("failure", JsonRequestBehavior.AllowGet);
            }

        }


        public JsonResult editBarang(string nmBarang, string qtyBarang, int id)
        {

            try
            {

                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("update Barang set  NamaBarang ='" + nmBarang + "', qtyBarang='" + qtyBarang + "' where id = '" + id + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();


                return Json("success", JsonRequestBehavior.AllowGet);
            }
            catch (Exception x)
            {
                return Json("failure", JsonRequestBehavior.AllowGet);
            }

        }

        public JsonResult deleteBarang(int id)
        {

            try
            {

                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Barang  where id = '" + id + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();


                return Json("success", JsonRequestBehavior.AllowGet);
            }
            catch (Exception x)
            {
                return Json("failure", JsonRequestBehavior.AllowGet);
            }

        }




        public JsonResult insertPerusahaan(string nmPerusahaan)
        {

            try
            {

                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Perusahaan(nmPerusahaan) values('" + nmPerusahaan + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();


                return Json("success", JsonRequestBehavior.AllowGet);
            }
            catch (Exception x)
            {
                return Json("failure", JsonRequestBehavior.AllowGet);
            }

        }

        public JsonResult editPerusahaan(string nmPerusahaan, int id)
        {

            try
            {

                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("update Perusahaan set  nmPerusahaan ='" + nmPerusahaan + "' where id = '" + id + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();


                return Json("success", JsonRequestBehavior.AllowGet);
            }
            catch (Exception x)
            {
                return Json("failure", JsonRequestBehavior.AllowGet);
            }

        }


        public JsonResult deletePerusahaan(int id)
        {

            try
            {

                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from Perusahaan  where id = '" + id + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();


                return Json("success", JsonRequestBehavior.AllowGet);
            }
            catch (Exception x)
            {
                return Json("failure", JsonRequestBehavior.AllowGet);
            }

        }



    }
}
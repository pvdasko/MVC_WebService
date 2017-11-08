using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace TestWeb
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        //[WebMethod]
        //public string HelloWorld()
        //{
        //    return "Hello World";
        //}
        
        TestWeb.ConnectionString bd;

        public WebService()
        {        
            bd= new ConnectionString ();
        }

        [WebMethod]
        public bool addProduct(int id, string description, string code, Nullable<double> qty, string um)
        {            
            try 
	        {
                Product nuevoProducto = new Product { IdProduct = id, Description = description, CodeBar = code, Quantity = qty, IdUm = um };

                bd.Products.Add(nuevoProducto );
                if (bd.SaveChanges() >0)
                {
                     return true ;
                }
                 return false ;
             
	        }
	        catch (Exception)
	        {
		       return false ;
		        
	        }
                     
        
        }

        [WebMethod]
        public List <Product > getListProduct()
        {

            return bd.Products.OrderByDescending (x => x.IdProduct ).ToList();
    
        }

        [WebMethod]
        public List<Product> getListProductId(int id)
        {

            return bd.Products.Where(x => x.IdProduct == id).ToList ();


        }

        [WebMethod]
        public List<Product> getListProductLimited( int delimitador)
        {

            return bd.Products.OrderByDescending(x => x.IdProduct).Take(delimitador).ToList();

        }

        [WebMethod]
        public List<Product> getSearchProduct(string description)
        { 
        
            return  bd.Products.Where (x => x.Description.Contains (description) ).OrderByDescending (x => x.IdProduct ).ToList();
            
        }

        [WebMethod]
        public int updProduct(int id, string description, string code, Nullable<double> qty, string um)
        {
            try
            {
                var actualizaProducto = bd.Products.Where(x => x.IdProduct == id).FirstOrDefault ();

                actualizaProducto.Description = description;
                actualizaProducto.CodeBar = code;
                actualizaProducto.Quantity = qty;
                actualizaProducto.IdUm = um;
                return bd.SaveChanges();
               
            }
            catch (Exception)
            {
                
                return 0 ;
                throw;
            }
        }


        [WebMethod]
        public int  delProduct(int id)
        {
            try
            {
                var borraProducto = bd.Products.Where(x => x.IdProduct == id).FirstOrDefault();
                bd.Products.Remove(borraProducto);
                
                return bd.SaveChanges();
                
            }
            catch (Exception)
            {
                return 0;
                throw;
            }
        }


    }
}

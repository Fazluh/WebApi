using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public enum  ProdForGender
    {
        Male,
        Female
    }
    public enum ProdSize
    {
        M,L,XL,XXL
    }
    public class ProductModel
    {
        [Key]
        

        public int ProdID { get; set; }
        public string ProdName { get; set; }
        public int ProdPrice { get; set; }
        public int QTY { get; set; }
        public string ProdDesc { get; set; }
        public ProdSize Size { get; set; }
        public ProdForGender Gender { get; set; }


    }
}
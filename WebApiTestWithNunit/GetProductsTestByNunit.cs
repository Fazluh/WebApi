using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApiTestWithNunit
{
    [TestFixture]
    public class GetProductsTestByNunit
    {
        [Test]
        public void checkProducts()
        {
            ProductModel model = new ProductModel();
            model.ProdID= 1;
            model.ProdName= "Hello";
            model.ProdPrice = 123;
            model.QTY = 1;
            model.ProdDesc = "Test";
            model.Size = 0;
            model.Gender = 0;

            var res = model;

            Assert.That(model.ProdName, Is.EqualTo(res.ProdName));

        }
       

    } 
}

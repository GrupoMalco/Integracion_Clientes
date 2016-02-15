using NUnit.Framework;
using System.Collections.Generic;
using Malco.Integracion.Clientes.Controllers;
using Malco.Integracion.Clientes.TDDTest.Mocks;
using Malco.Integracion.Clientes.Dominio;
using System.Web.Mvc;

namespace Malco.Integracion.Clientes.TDDTest.Controllers
{
    [TestFixture]
    public class GestorDocumentosControllerTest
    {
        private GestorDocumentosController _gestorDocumentosController;

        [SetUp]
        public void Setup()
        {
            // TODO: Add constructor logic here
            //
            FacturasRepositorioMock repoFacturasMock = new FacturasRepositorioMock();
            _gestorDocumentosController = new GestorDocumentosController(repoFacturasMock);
        }

        [TearDown]
        public void TearDown()
        {
            _gestorDocumentosController = null;
        }

        /// <summary>
        /// Método encargado de probar la funcionalidad del método
        /// index del controller
        /// </summary>
        [Test]
        public void CargarIndexControllerText()
        {
            // Arrange

            // Act
            //ActionResult result = _gestorDocumentosController.Index() as ActionResult;

            // Assert
            //Assert.IsNotNull(result);
            //Assert.AreEqual(typeof(ActionResult), result.GetType());
        }

        [Test]
        public void ListarDatosNuevosFacturasOkTest()
        {
            // Arrange
            long idTercero =long.Parse("890904138");
            // Act
            IEnumerable<EncabezadoFacturas> result = _gestorDocumentosController.ListarDatosNuevosFacturas(idTercero);

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(typeof(List<EncabezadoFacturas>),result.GetType());
            Assert.IsNotEmpty(result);
        }

        [Test]
        public void ListarDatosNuevosFacturasNoRegistrosTest()
        {
            // Arrange
            long idTercero = long.Parse("890904138");
            FacturasRepositorioMock mockFacturas=new FacturasRepositorioMock();
            mockFacturas._escenarioFallido = true;
            _gestorDocumentosController = new GestorDocumentosController(mockFacturas);

            // Act
            IEnumerable<EncabezadoFacturas> result = _gestorDocumentosController.ListarDatosNuevosFacturas(idTercero);

            // Assert
            Assert.NotNull(result);
            Assert.AreEqual(typeof(List<EncabezadoFacturas>), result.GetType());
            Assert.IsEmpty(result);
        }

    }
}

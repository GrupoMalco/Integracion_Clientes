using System;
using TechTalk.SpecFlow;

namespace Malco.Integracion.Clientes.ATDDTests.StepDefinitions
{
    [Binding]
    public class FiltrarDatosNuevosFacturaSteps
    {
        [Given(@"Usuario logueado en la aplicacion")]
        public void GivenUsuarioLogueadoEnLaAplicacion()
        {
            ScenarioContext.Current.Pending();

        }
        
        [Given(@"El usuario ingresa a la opcion de filtrar facturas")]
        public void GivenElUsuarioIngresaALaOpcionDeFiltrarFacturas()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"se presiona el boton aceptar")]
        public void GivenSePresionaElBotonAceptar()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"se muestran los datos nuevos de las facturas")]
        public void ThenSeMuestranLosDatosNuevosDeLasFacturas()
        {
            ScenarioContext.Current.Pending();
        }
    }
}

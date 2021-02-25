/*
 * Created by Ranorex
 * User: No Name
 * Date: 25/02/2021
 * Time: 0:56
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace AzureDemoDesktop.Acciones
{
    /// <summary>
    /// Description of BorrarDatosIngresados.
    /// </summary>
    [TestModule("6644FE41-D0D1-4D90-9D6F-50037FDF2AE5", ModuleType.UserCode, 1)]
    public class BorrarDatosIngresados : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public BorrarDatosIngresados()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            
            //Variables
            AzureDemoDesktopRepository repo;
            IList<Element> lista;
            int i = 0;
            int count = 0;
            
            //Codigo
            Report.Info("INFO","Eliminando los datos cargados");
			
            repo = AzureDemoDesktopRepository.Instance;
			lista = repo.RxMainFrame.RxTabStandard.listaAgregados.Find("./listitem");
			count = lista.Count;
			
			if (lista.Count > 0)
			{
				foreach (var e in lista)
				{
					Mouse.Click(lista[(count - 1) - i]);
					Report.Info("INFO","Se elimino: " + lista[(count - 1) - i].ToString());
					repo.RxMainFrame.RxTabStandard.btn_DeletePerson.Click();
					i++;
				}
			} else {
				Report.Info("INFO","No hay datos para eliminar.");
			}
			
			Report.Info("INFO","Eliminacion finalizada");
			
			Validate.AttributeEqual(repo.RxMainFrame.RxTabStandard.LblNumberOfPersonsNumberInfo, "Text", "0");
			
        }
    }
}

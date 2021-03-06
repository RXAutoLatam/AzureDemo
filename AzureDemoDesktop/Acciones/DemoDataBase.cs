﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

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
using Ranorex.Core.Repository;

namespace AzureDemoDesktop.Acciones
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The DemoDataBase recording.
    /// </summary>
    [TestModule("332bf891-ab08-446d-82d5-ddcfb46b5e88", ModuleType.Recording, 1)]
    public partial class DemoDataBase : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::AzureDemoDesktop.AzureDemoDesktopRepository repository.
        /// </summary>
        public static global::AzureDemoDesktop.AzureDemoDesktopRepository repo = global::AzureDemoDesktop.AzureDemoDesktopRepository.Instance;

        static DemoDataBase instance = new DemoDataBase();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DemoDataBase()
        {
            CantIngresos = "";
            Edad = "42";
            Nombre = "Fernando";
            Apellido = "Figliola";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DemoDataBase Instance
        {
            get { return instance; }
        }

#region Variables

        string _Edad;

        /// <summary>
        /// Gets or sets the value of variable Edad.
        /// </summary>
        [TestVariable("260f8fdd-729d-4764-afe2-d6096cae4c23")]
        public string Edad
        {
            get { return _Edad; }
            set { _Edad = value; }
        }

        string _Nombre;

        /// <summary>
        /// Gets or sets the value of variable Nombre.
        /// </summary>
        [TestVariable("51aa41a1-5cce-4bc8-99a1-4bcee7204f79")]
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        string _Apellido;

        /// <summary>
        /// Gets or sets the value of variable Apellido.
        /// </summary>
        [TestVariable("0f62325d-1f04-4070-a850-9f88f355b89b")]
        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Departamento.
        /// </summary>
        [TestVariable("756fc553-c8d0-4aa1-a9e2-b31605f415f7")]
        public string Departamento
        {
            get { return repo.Departamento; }
            set { repo.Departamento = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable Genero.
        /// </summary>
        [TestVariable("330f9622-bf5f-44bd-bc86-376bd74a4b51")]
        public string Genero
        {
            get { return repo.Genero; }
            set { repo.Genero = value; }
        }

        /// <summary>
        /// Gets or sets the value of variable CantIngresos.
        /// </summary>
        [TestVariable("050bb336-5d9f-47d3-aef4-2572b7c4854e")]
        public string CantIngresos
        {
            get { return repo.CantIngresos; }
            set { repo.CantIngresos = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabStandard.FirstName' at CenterLeft.", repo.RxMainFrame.RxTabStandard.FirstNameInfo, new RecordItemIndex(0));
            repo.RxMainFrame.RxTabStandard.FirstName.Click(Location.CenterLeft);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Nombre' with focus on 'RxMainFrame.RxTabStandard.FirstName'.", repo.RxMainFrame.RxTabStandard.FirstNameInfo, new RecordItemIndex(1));
            repo.RxMainFrame.RxTabStandard.FirstName.PressKeys(Nombre);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabStandard.LastName' at CenterLeft.", repo.RxMainFrame.RxTabStandard.LastNameInfo, new RecordItemIndex(2));
            repo.RxMainFrame.RxTabStandard.LastName.Click(Location.CenterLeft);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Apellido' with focus on 'RxMainFrame.RxTabStandard.LastName'.", repo.RxMainFrame.RxTabStandard.LastNameInfo, new RecordItemIndex(3));
            repo.RxMainFrame.RxTabStandard.LastName.PressKeys(Apellido);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabStandard.Abrir' at Center.", repo.RxMainFrame.RxTabStandard.AbrirInfo, new RecordItemIndex(4));
            repo.RxMainFrame.RxTabStandard.Abrir.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DepartmentList.itemDepartamento' at Center.", repo.DepartmentList.itemDepartamentoInfo, new RecordItemIndex(5));
            repo.DepartmentList.itemDepartamento.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'RxMainFrame.RxTabStandard.UpDownEdit' at CenterLeft.", repo.RxMainFrame.RxTabStandard.UpDownEditInfo, new RecordItemIndex(6));
            repo.RxMainFrame.RxTabStandard.UpDownEdit.DoubleClick(Location.CenterLeft);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Edad' with focus on 'RxMainFrame.RxTabStandard.UpDownEdit'.", repo.RxMainFrame.RxTabStandard.UpDownEditInfo, new RecordItemIndex(7));
            repo.RxMainFrame.RxTabStandard.UpDownEdit.PressKeys(Edad);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabStandard.RdbMale' at CenterLeft.", repo.RxMainFrame.RxTabStandard.RdbMaleInfo, new RecordItemIndex(8));
            repo.RxMainFrame.RxTabStandard.RdbMale.Click(Location.CenterLeft);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabStandard.BtnAddPerson' at Center.", repo.RxMainFrame.RxTabStandard.BtnAddPersonInfo, new RecordItemIndex(9));
            repo.RxMainFrame.RxTabStandard.BtnAddPerson.Click();
            Delay.Milliseconds(200);
            
            CantIngresos = CuentaIngresos();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", CantIngresos, new RecordItemIndex(11));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text=$CantIngresos) on item 'RxMainFrame.RxTabStandard.LblNumberOfPersonsNumber'.", repo.RxMainFrame.RxTabStandard.LblNumberOfPersonsNumberInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.RxMainFrame.RxTabStandard.LblNumberOfPersonsNumberInfo, "Text", CantIngresos);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeContains (Text>$Nombre) on item 'RxMainFrame.RxTabStandard.itemsAgregados'.", repo.RxMainFrame.RxTabStandard.itemsAgregadosInfo, new RecordItemIndex(13));
            Validate.AttributeContains(repo.RxMainFrame.RxTabStandard.itemsAgregadosInfo, "Text", Nombre);
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.RxMainFrame.Self, false, new RecordItemIndex(14));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

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
    ///The DemoIntro recording.
    /// </summary>
    [TestModule("cba4e9f3-e83d-4cc6-bb1a-473d563710b9", ModuleType.Recording, 1)]
    public partial class DemoIntro : ITestModule
    {
        /// <summary>
        /// Holds an instance of the global::AzureDemoDesktop.AzureDemoDesktopRepository repository.
        /// </summary>
        public static global::AzureDemoDesktop.AzureDemoDesktopRepository repo = global::AzureDemoDesktop.AzureDemoDesktopRepository.Instance;

        static DemoIntro instance = new DemoIntro();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DemoIntro()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DemoIntro Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.Introduction' at 49;6.", repo.RxMainFrame.IntroductionInfo, new RecordItemIndex(0));
            repo.RxMainFrame.Introduction.Click("49;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabIntroduction.EnterYourName' at 57;8.", repo.RxMainFrame.RxTabIntroduction.EnterYourNameInfo, new RecordItemIndex(1));
            repo.RxMainFrame.RxTabIntroduction.EnterYourName.Click("57;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Harry' with focus on 'RxMainFrame.RxTabIntroduction.EnterYourName'.", repo.RxMainFrame.RxTabIntroduction.EnterYourNameInfo, new RecordItemIndex(2));
            repo.RxMainFrame.RxTabIntroduction.EnterYourName.PressKeys("Harry");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabIntroduction.BtnSubmitUserName' at 28;10.", repo.RxMainFrame.RxTabIntroduction.BtnSubmitUserNameInfo, new RecordItemIndex(3));
            repo.RxMainFrame.RxTabIntroduction.BtnSubmitUserName.Click("28;10");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Text='Welcome, Harry!') on item 'RxMainFrame.RxTabIntroduction.LblWelcomeMessage'.", repo.RxMainFrame.RxTabIntroduction.LblWelcomeMessageInfo, new RecordItemIndex(4));
                Validate.AttributeEqual(repo.RxMainFrame.RxTabIntroduction.LblWelcomeMessageInfo, "Text", "Welcome, Harry!", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'RxMainFrame.RxTabIntroduction.Reset' at 17;7.", repo.RxMainFrame.RxTabIntroduction.ResetInfo, new RecordItemIndex(5));
            repo.RxMainFrame.RxTabIntroduction.Reset.Click("17;7");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

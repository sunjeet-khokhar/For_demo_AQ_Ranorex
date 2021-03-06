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

namespace CRM
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Add_a_quote recording.
    /// </summary>
    [TestModule("767b36f3-bfe1-440a-8a4e-5d11e8c59b6c", ModuleType.Recording, 1)]
    public partial class Add_a_quote : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CRMRepository repository.
        /// </summary>
        public static CRMRepository repo = CRMRepository.Instance;

        static Add_a_quote instance = new Add_a_quote();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Add_a_quote()
        {
            Order_id = "458389";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Add_a_quote Instance
        {
            get { return instance; }
        }

#region Variables

        string _Order_id;

        /// <summary>
        /// Gets or sets the value of variable Order_id.
        /// </summary>
        [TestVariable("7809f475-8510-41c4-bbd4-ae5a68579d6d")]
        public string Order_id
        {
            get { return _Order_id; }
            set { _Order_id = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.1")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.1")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'https://asurequalitytest.crm6.dynamics.com/main.aspx' with browser 'chromium' in normal mode.", new RecordItemIndex(0));
            Host.Local.OpenBrowser("https://asurequalitytest.crm6.dynamics.com/main.aspx", "chromium", "", false, false, false, false, false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DashboardsAQCustomerServicesDashboa.ContentIFrame0.Component548905AddImageButtonImage' at 4;12.", repo.DashboardsAQCustomerServicesDashboa.ContentIFrame0.Component548905AddImageButtonImageInfo, new RecordItemIndex(1));
            repo.DashboardsAQCustomerServicesDashboa.ContentIFrame0.Component548905AddImageButtonImage.Click("4;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DashboardsAQCustomerServicesDashboa.ContentIFrame0.AqNameI' at 175;9.", repo.DashboardsAQCustomerServicesDashboa.ContentIFrame0.AqNameIInfo, new RecordItemIndex(2));
            repo.DashboardsAQCustomerServicesDashboa.ContentIFrame0.AqNameI.Click("175;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Order_id' with focus on 'DashboardsAQCustomerServicesDashboa.ContentIFrame0.AqNameI'.", repo.DashboardsAQCustomerServicesDashboa.ContentIFrame0.AqNameIInfo, new RecordItemIndex(3));
            repo.DashboardsAQCustomerServicesDashboa.ContentIFrame0.AqNameI.PressKeys(Order_id);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DashboardsAQCustomerServicesDashboa.ContentIFrame0.MsCrmInlineValueMsCrmInlineLookup' at 24;4.", repo.DashboardsAQCustomerServicesDashboa.ContentIFrame0.MsCrmInlineValueMsCrmInlineLookupInfo, new RecordItemIndex(4));
            repo.DashboardsAQCustomerServicesDashboa.ContentIFrame0.MsCrmInlineValueMsCrmInlineLookup.Click("24;4");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'fonterra{Space}australia{Return}'.", new RecordItemIndex(5));
            Keyboard.Press("fonterra{Space}australia{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'DashboardsAQCustomerServicesDashboa.ContentIFrame0.MsCrmILMenu' at 322;121.", repo.DashboardsAQCustomerServicesDashboa.ContentIFrame0.MsCrmILMenuInfo, new RecordItemIndex(6));
            repo.DashboardsAQCustomerServicesDashboa.ContentIFrame0.MsCrmILMenu.MoveTo("322;121");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'DashboardsAQCustomerServicesDashboa.ContentIFrame0.MsCrmILMenu' at 322;220.", repo.DashboardsAQCustomerServicesDashboa.ContentIFrame0.MsCrmILMenuInfo, new RecordItemIndex(7));
            repo.DashboardsAQCustomerServicesDashboa.ContentIFrame0.MsCrmILMenu.MoveTo("322;220");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DashboardsAQCustomerServicesDashboa.ContentIFrame0.FonterraAustraliaPtyLtd1' at 68;8.", repo.DashboardsAQCustomerServicesDashboa.ContentIFrame0.FonterraAustraliaPtyLtd1Info, new RecordItemIndex(8));
            repo.DashboardsAQCustomerServicesDashboa.ContentIFrame0.FonterraAustraliaPtyLtd1.Click("68;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DashboardsAQCustomerServicesDashboa.ContentIFrame0.MsCrmInlineValueMsCrmInlineEditHi' at 28;6.", repo.DashboardsAQCustomerServicesDashboa.ContentIFrame0.MsCrmInlineValueMsCrmInlineEditHiInfo, new RecordItemIndex(9));
            repo.DashboardsAQCustomerServicesDashboa.ContentIFrame0.MsCrmInlineValueMsCrmInlineEditHi.Click("28;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '14/10/2016'.", new RecordItemIndex(10));
            Keyboard.Press("14/10/2016");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(11));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DashboardsAQCustomerServicesDashboa.ContentIFrame0.MsCrmInlineValueMsCrmInlineEditHi1' at 86;14.", repo.DashboardsAQCustomerServicesDashboa.ContentIFrame0.MsCrmInlineValueMsCrmInlineEditHi1Info, new RecordItemIndex(12));
            repo.DashboardsAQCustomerServicesDashboa.ContentIFrame0.MsCrmInlineValueMsCrmInlineEditHi1.Click("86;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '11/11/2016'.", new RecordItemIndex(13));
            Keyboard.Press("11/11/2016");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DashboardsAQCustomerServicesDashboa.ContentIFrame0.MsCrmInlineValueMsCrmInlineEditHi2' at 62;15.", repo.DashboardsAQCustomerServicesDashboa.ContentIFrame0.MsCrmInlineValueMsCrmInlineEditHi2Info, new RecordItemIndex(14));
            repo.DashboardsAQCustomerServicesDashboa.ContentIFrame0.MsCrmInlineValueMsCrmInlineEditHi2.Click("62;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '11/11/2017'.", new RecordItemIndex(15));
            Keyboard.Press("11/11/2017");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DashboardsAQCustomerServicesDashboa.ContentIFrame0.AqDateofexpiryIDateInput' at 104;11.", repo.DashboardsAQCustomerServicesDashboa.ContentIFrame0.AqDateofexpiryIDateInputInfo, new RecordItemIndex(16));
            repo.DashboardsAQCustomerServicesDashboa.ContentIFrame0.AqDateofexpiryIDateInput.Click("104;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'DashboardsAQCustomerServicesDashboa.ContentIFrame0.AqDateofexpiryIDateInput'.", repo.DashboardsAQCustomerServicesDashboa.ContentIFrame0.AqDateofexpiryIDateInputInfo, new RecordItemIndex(17));
            repo.DashboardsAQCustomerServicesDashboa.ContentIFrame0.AqDateofexpiryIDateInput.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'DashboardsAQCustomerServicesDashboa.ContentIFrame0.TdAreas' at 1562;231.", repo.DashboardsAQCustomerServicesDashboa.ContentIFrame0.TdAreasInfo, new RecordItemIndex(18));
            repo.DashboardsAQCustomerServicesDashboa.ContentIFrame0.TdAreas.MoveTo("1562;231");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'DashboardsAQCustomerServicesDashboa.ContentIFrame0.TdAreas' at 1565;422.", repo.DashboardsAQCustomerServicesDashboa.ContentIFrame0.TdAreasInfo, new RecordItemIndex(19));
            repo.DashboardsAQCustomerServicesDashboa.ContentIFrame0.TdAreas.MoveTo("1565;422");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DashboardsAQCustomerServicesDashboa.ContentIFrame0.AqBudairyservicesI' at 6;5.", repo.DashboardsAQCustomerServicesDashboa.ContentIFrame0.AqBudairyservicesIInfo, new RecordItemIndex(20));
            repo.DashboardsAQCustomerServicesDashboa.ContentIFrame0.AqBudairyservicesI.Click("6;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DashboardsAQCustomerServicesDashboa.SpanTagSave' at 9;11.", repo.DashboardsAQCustomerServicesDashboa.SpanTagSaveInfo, new RecordItemIndex(21));
            repo.DashboardsAQCustomerServicesDashboa.SpanTagSave.Click("9;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(22));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'DashboardsAQCustomerServicesDashboa'.", repo.DashboardsAQCustomerServicesDashboa.SelfInfo, new RecordItemIndex(23));
            Host.Local.CloseApplication(repo.DashboardsAQCustomerServicesDashboa.Self, 1000);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

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
    ///The Recording1 recording.
    /// </summary>
    [TestModule("e8e4b14d-3cc3-47ab-b90b-bdd19bb524ad", ModuleType.Recording, 1)]
    public partial class Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the CRMRepository repository.
        /// </summary>
        public static CRMRepository repo = CRMRepository.Instance;

        static Recording1 instance = new Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording1 Instance
        {
            get { return instance; }
        }

#region Variables

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

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'https://asurequalitytest.crm6.dynamics.com/main.aspx' with browser 'chrome' in normal mode.", new RecordItemIndex(0));
            Host.Local.OpenBrowser("https://asurequalitytest.crm6.dynamics.com/main.aspx", "chrome", "", false, false, false, false, false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DashboardsAQCustomerServicesDashboa.Dashboards' at 1;11.", repo.DashboardsAQCustomerServicesDashboa.DashboardsInfo, new RecordItemIndex(1));
            repo.DashboardsAQCustomerServicesDashboa.Dashboards.Click("1;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DashboardsAQCustomerServicesDashboa.AQCustomerServicesDashboard' at 87;13.", repo.DashboardsAQCustomerServicesDashboa.AQCustomerServicesDashboardInfo, new RecordItemIndex(2));
            repo.DashboardsAQCustomerServicesDashboa.AQCustomerServicesDashboard.Click("87;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DashboardsAQCustomerServicesDashboa.ContentIFrame0.DashboardSelectorContainer' at 153;19.", repo.DashboardsAQCustomerServicesDashboa.ContentIFrame0.DashboardSelectorContainerInfo, new RecordItemIndex(3));
            repo.DashboardsAQCustomerServicesDashboa.ContentIFrame0.DashboardSelectorContainer.Click("153;19");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DashboardsAQCustomerServicesDashboa.ContentIFrame0.MsCrmFloatingDiv' at 595;84.", repo.DashboardsAQCustomerServicesDashboa.ContentIFrame0.MsCrmFloatingDivInfo, new RecordItemIndex(4));
            repo.DashboardsAQCustomerServicesDashboa.ContentIFrame0.MsCrmFloatingDiv.Click("595;84");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'DashboardsAQCustomerServicesDashboa.ContentIFrame0.QuotesForRenewal' at 34;12.", repo.DashboardsAQCustomerServicesDashboa.ContentIFrame0.QuotesForRenewalInfo, new RecordItemIndex(5));
            repo.DashboardsAQCustomerServicesDashboa.ContentIFrame0.QuotesForRenewal.Click("34;12");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}

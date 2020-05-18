﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
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
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace HansenTechnology.FunctionalTest
{
    public partial class DataRecord
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void maximize()
        {
            // Drag & Drop Apps under test as a top element from object reposotiry - Maximize AUT
            var rxMainFrame = repo.RxMainFrame;
            rxMainFrame.Self.Maximize();
        }

        public void acivate()
        {
            // Drag & Drop Apps under test as a top element from object reposotiry - Activate AUT
            var rxMainFrame = repo.RxMainFrame;
            rxMainFrame.Self.Activate();           
        }

    }
}
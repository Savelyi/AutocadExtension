using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WinForm = System.Windows.Forms;
using Autodesk.AutoCAD.Geometry;

namespace AutocadExtension
{
    public class MyCommandClass
    {
        readonly LabForm form;
        public MyCommandClass()
        {
            form = new LabForm();
        }
        /// <summary>
        /// Gives you an opportunity to save info about primitives
        /// </summary>
        [CommandMethod("GetProjectInfo")]
        [STAThread]
        public void RunCommand()
        {
            WinForm.DialogResult dialogResult = Application.ShowModalDialog(form);
        }
    }
}

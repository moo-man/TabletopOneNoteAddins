/*
 *  Copyright (c) Microsoft. All rights reserved. Licensed under the MIT license.
 */

 using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Extensibility;
using Microsoft.Office.Core;
using OneNote.WFRP.Utilities;
using Application = Microsoft.Office.Interop.OneNote.Application;  // Conflicts with System.Windows.Forms
using System.Xml;
using System.Linq;

#pragma warning disable CS3003 // Type is not CLS-compliant

namespace OneNote.WFRP
{
	[ComVisible(true)]
	[Guid("31DF84A7-197E-4254-859F-5FB1BB713614"), ProgId("OneNote.WFRP")]

	public class AddIn : IDTExtensibility2, IRibbonExtensibility
	{
		static protected Application OneNoteApplication
		{ get; set; }

		private static MainForm mainForm;
        static XNamespace ns = null;

        public AddIn()
        {
		}

		/// <summary>
		/// Returns the XML in Ribbon.xml so OneNote knows how to render our ribbon
		/// </summary>
		/// <param name="RibbonID"></param>
		/// <returns></returns>
		public string GetCustomUI(string RibbonID)
		{
			return Properties.Resources.ribbon;
		}

		public void OnAddInsUpdate(ref Array custom)
		{
		}

        // Below is what is used to interact with a page. Still testing.
        /*static void GetNamespace()
        {
            string xml;

            OneNoteApplication.GetHierarchy(null, Microsoft.Office.Interop.OneNote.HierarchyScope.hsNotebooks, out xml);
            var doc = XDocument.Parse(xml);
            ns = doc.Root.Name.Namespace;
        }

        static string GetObjectId(string parentId, Microsoft.Office.Interop.OneNote.HierarchyScope scope, string objectName)
        {
           string xml;
            OneNoteApplication.GetHierarchy(parentId, scope, out xml);

            var doc = XDocument.Parse(xml);
            var nodeName = "";

            switch (scope)
            {
                case (Microsoft.Office.Interop.OneNote.HierarchyScope.hsNotebooks): nodeName = "Notebook"; break;
                case (Microsoft.Office.Interop.OneNote.HierarchyScope.hsPages): nodeName = "Page"; break;
                case (Microsoft.Office.Interop.OneNote.HierarchyScope.hsSections): nodeName = "Section"; break;
                default:
                    return null;
            }

            var node = doc.Descendants(ns + nodeName).Where(n => n.Attribute("name").Value == objectName).FirstOrDefault();

            return node.Attribute("ID").Value;
        }*/

       /* static string GetPageContent(string pageId)
        {
            GetNamespace();
            string xml;
            OneNoteApplication.GetPageContent(pageId, out xml, Microsoft.Office.Interop.OneNote.PageInfo.piAll);
            var doc = XDocument.Parse(xml);
            var outLine = doc.Descendants(ns + "Outline").First();
            var content = outLine.Descendants(ns + "T").First();
            string contentVal = content.Value;
            content.Value = "Hello World!";
            OneNoteApplication.UpdatePageContent(doc.ToString());
            return null;
        }*/

        /// <summary>
        /// Cleanup
        /// </summary>
        /// <param name="custom"></param>
        public void OnBeginShutdown(ref Array custom)
		{
			mainForm?.Invoke(new Action(() =>
			{
				// close the form on the forms thread
				mainForm?.Close();
				mainForm = null;
			}));
		}

		/// <summary>
		/// Called upon startup.
		/// Keeps a reference to the current OneNote application object.
		/// </summary>
		/// <param name="application"></param>
		/// <param name="connectMode"></param>
		/// <param name="addInInst"></param>
		/// <param name="custom"></param>
		public void OnConnection(object Application, ext_ConnectMode ConnectMode, object AddInInst, ref Array custom)
		{
            SetOneNoteApplication((Application)Application);

        }

        public void SetOneNoteApplication(Application application)
		{
			OneNoteApplication = application;
		}

		/// <summary>
		/// Cleanup
		/// </summary>
		/// <param name="RemoveMode"></param>
		/// <param name="custom"></param>
		[SuppressMessage("Microsoft.Reliability", "CA2001:AvoidCallingProblematicMethods", MessageId = "System.GC.Collect")]
		public void OnDisconnection(ext_DisconnectMode RemoveMode, ref Array custom)
		{
			OneNoteApplication = null;
			GC.Collect();
			GC.WaitForPendingFinalizers();
		}

		public void OnStartupComplete(ref Array custom)
		{
		}

		public async Task VanillaAddInButtonClicked(IRibbonControl control)
		{
			//MessageBox.Show("VanillaAddIn button pushed! Now we'll load up the full XML hierarchy as well as the current page XML. This may take some time.");


          //  XmlDocument doc = new XmlDocument();

        //ShowForm();
            return;
		}

        public async Task rollD100(IRibbonControl control)
        {
            System.Windows.Forms.Application.Run(new DiceForm(1));
        }

        public async Task rollD10(IRibbonControl control)
        {
            System.Windows.Forms.Application.Run(new DiceForm(0));
        }

        public async Task MaleGen(IRibbonControl control)
        {
            System.Windows.Forms.Application.Run(new NameGeneratorForm(1));
            //string name = NameGenerator.MaleName();
            //MessageBox.Show(name);
           // Clipboard.SetText(name);
        }

        public async Task FemaleGen(IRibbonControl control)
        {
            System.Windows.Forms.Application.Run(new NameGeneratorForm(2));
            //string name = NameGenerator.FemaleName();
            //MessageBox.Show(name);
            //Clipboard.SetText(name);
        }
        public async Task SurnameGen(IRibbonControl control)
        {
            System.Windows.Forms.Application.Run(new NameGeneratorForm(3));
            //string name = NameGenerator.Surname();
            //MessageBox.Show(name);
            //Clipboard.SetText(name);
        }

        public async Task AdvancesPossible(IRibbonControl control)
        {
            System.Windows.Forms.Application.Run(new AdvancesPossibleForm());
        }

        public async Task XpNeeded(IRibbonControl control)
        {
            System.Windows.Forms.Application.Run(new XpNeededForm(OneNoteApplication));
        }


        public async Task CoinClicked(IRibbonControl control)
        {
            switch (control.Id)
            {
                case "goldcrowns":
                    System.Windows.Forms.Application.Run(new CoinForm(1));
                    break;
                case "silvershillings":
                    System.Windows.Forms.Application.Run(new CoinForm(2));
                    break;
                case "brasspenny":
                    System.Windows.Forms.Application.Run(new CoinForm(3));
                    break;
            }
        }

        static private void ShowForm()
		{
			mainForm = new MainForm(OneNoteApplication);
            System.Windows.Forms.Application.Run(mainForm);
		}

		/// <summary>
		/// Specified in Ribbon.xml, this method returns the image to display on the ribbon button
		/// </summary>
		/// <param name="imageName"></param>
		/// <returns></returns>
		public IStream GetImage(string imageName)
		{
			MemoryStream imageStream = new MemoryStream();
			//Properties.Resources.cross.Save(imageStream, ImageFormat.Png);
            ((System.Drawing.Bitmap)Properties.Resources.ResourceManager.GetObject(imageName.Substring(0, imageName.IndexOf('.')))).Save(imageStream, ImageFormat.Png);
			return new CCOMStreamWrapper(imageStream);
		}
	}
}

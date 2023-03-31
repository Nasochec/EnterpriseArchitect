using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace EADemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		EA.Repository m_Repository;
 
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnDoIt;
		private System.Windows.Forms.Label lblDescription;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnDoIt = new System.Windows.Forms.Button();
			this.lblDescription = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(56, 8);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(112, 20);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "c:\\eatest.eap";
			// 
			// listBox1
			// 
			this.listBox1.Location = new System.Drawing.Point(176, 8);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(264, 251);
			this.listBox1.TabIndex = 1;
			// 
			// listBox2
			// 
			this.listBox2.Location = new System.Drawing.Point(8, 40);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(160, 160);
			this.listBox2.TabIndex = 2;
			this.listBox2.DoubleClick += new System.EventHandler(this.listBox2_DoubleClick);
			this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(0, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "File Path:";
			// 
			// btnDoIt
			// 
			this.btnDoIt.Location = new System.Drawing.Point(32, 344);
			this.btnDoIt.Name = "btnDoIt";
			this.btnDoIt.Size = new System.Drawing.Size(112, 24);
			this.btnDoIt.TabIndex = 4;
			this.btnDoIt.Text = "Run Test";
			this.btnDoIt.Click += new System.EventHandler(this.btnDoIt_Click);
			// 
			// lblDescription
			// 
			this.lblDescription.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(255)), ((System.Byte)(255)));
			this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblDescription.Location = new System.Drawing.Point(8, 216);
			this.lblDescription.Name = "lblDescription";
			this.lblDescription.Size = new System.Drawing.Size(160, 104);
			this.lblDescription.TabIndex = 5;
			this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(472, 373);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.lblDescription,
																		  this.btnDoIt,
																		  this.label1,
																		  this.listBox2,
																		  this.listBox1,
																		  this.textBox1});
			this.Name = "Form1";
			this.Text = "Enterprise Architect Object Model Demo - C#";
			this.TransparencyKey = System.Drawing.Color.Silver;
			this.Resize += new System.EventHandler(this.Form1_Resize);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Activated += new System.EventHandler(this.Form1_Resize);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}
		
		void ListAdd(string Msg)
		{
			listBox1.Items.Add(Msg);
			listBox1.SelectedIndex = listBox1.Items.Count - 1;
		}

		void ClearListBox()
		{
			listBox1.Items.Clear();
			listBox1.Refresh();
		}

	void DumpModeDiagrams()
	{
		ClearListBox();
		EA.Package MyModel = (EA.Package) m_Repository.Models.GetAt(0);
		for( short iPackage = 0; iPackage < MyModel.Packages.Count; iPackage++ )
		{
			EA.Package MyPackage  = (EA.Package) MyModel.Packages.GetAt(iPackage);
			ListAdd(MyPackage.Name);
			for( short iDiagram = 0; iDiagram < MyPackage.Diagrams.Count; iDiagram++ )
			{
				EA.Diagram MyDiagram = (EA.Diagram) MyPackage.Diagrams.GetAt(iDiagram);
				for( short iDO = 0; iDO < MyDiagram.DiagramObjects.Count; iDO++ )
				{
					EA.DiagramObject MyDO = (EA.DiagramObject) MyDiagram.DiagramObjects.GetAt(iDO);
					ListAdd("       " + m_Repository.GetElementByID(MyDO.ElementID).Name + "   ( ID=" + MyDO.ElementID + " )");
				}
			}
		}
		ListAdd("Done");
	}
		
		private void btnDoIt_Click(object sender, System.EventArgs e)
		{
			if( m_Repository == null )
			{
				m_Repository = new EA.RepositoryClass();
				m_Repository.OpenFile(textBox1.Text);
			}
			switch( listBox2.SelectedIndex )
			{
				case 0:
					DumpModeDiagrams();
					break;
			    case 1:
			        ConnectorTest();
					break;
			    case 2:
			        DiagramLifeCycle();
					break;
			    case 3:
			        ElementLifecycle();
					break;
			    case 4:
			        TestPackageLifecycle();
					break;
			    case 5:
			        AddDeleteAttributesAndMethods();
					break;
			    case 6:
			        ElementExtras();
					break;
			    case 7:
			        DumpModel();
					break;
			    case 8:
			        RepositoryExtras();
					break;
			    case 9:
			        TestStereotypes();
					break;
			    case 10:
			        AttributeLifecycle();
					break;
			    case 11:
			        MethodLifeCycle();
					break;
			}
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			listBox2.Items.Add("Dump Model Diagrams");
			listBox2.Items.Add("Connector Test");
			listBox2.Items.Add("Add and Manage Diagrams");
			listBox2.Items.Add("Add and Manage Elements");
			listBox2.Items.Add("Add and Manage Packages");
			listBox2.Items.Add("Add/Delete Attributes/Methods");
			listBox2.Items.Add("ElementExtras");
			listBox2.Items.Add("Dump Model(Recursive)");
			listBox2.Items.Add("Repository Extras");
			listBox2.Items.Add("Test Stereotypes");
			listBox2.Items.Add("Attribute Lifecycle");
			listBox2.Items.Add("Method LifeCycle");
		}

		private void listBox2_DoubleClick(object sender, System.EventArgs e)
		{
			btnDoIt_Click(sender, e);
		}

void ConnectorTest()
{
    ClearListBox();
    ListAdd("ConnectorTest()");
    
    // Add a connector and set values
    EA.Element source, target;
    EA.Connector con;
    EA.ConnectorConstraint ConConstraint;
    EA.ConnectorTag ConTag;
    EA.ConnectorEnd client, supplier;
    
    // use ElementID's to quickly load an Element in this example
    //... you will need to find suitable ID's in your model (Run DumpModelDiagrams)
    source = m_Repository.GetElementByID(140);
    target = m_Repository.GetElementByID(142);
    con = (EA.Connector) source.Connectors.AddNew("test link 2", "Association");
    con.SupplierID = target.ElementID;
    con.Update();
    source.Connectors.Refresh();
    ListAdd("Connector Created");
    ConConstraint = (EA.ConnectorConstraint) con.Constraints.AddNew("constraint2", "type");
    ConTag = (EA.ConnectorTag) con.TaggedValues.AddNew("Tag", "Value");
    ConTag.Update();
    
    // use the client and supplier ends to set
    // additional information
    client = con.ClientEnd;
    client.Visibility = "Private";
    client.Role = "m_client";
    client.Update();
    supplier = con.SupplierEnd;
    supplier.Visibility = "Protected";
    supplier.Role = "m_supplier";
    supplier.Update();
    ListAdd("Client and Supplier set");
    ListAdd(client.Role);
	ListAdd(supplier.Role);
}

		private void listBox2_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			btnDoIt.Enabled = true;
			switch( listBox2.SelectedIndex )
			{				
			case 0:
				lblDescription.Text = "Runs through all the packages and diagrams in a non-recursive style.";
				break;
			case 1:
				lblDescription.Text = "Links two diagram objects with a connector.";
				break;
			case 2:
				lblDescription.Text = "An example of how to create a diagram and add an Element to it.  Note the optional use of Element rectangle setting using left,right,top and bottom dimensions in AddNew call";
				break;
			case 3:
				lblDescription.Text = "Add and delete Elements in a package";
				break;
			case 4:
				lblDescription.Text = "Example illustrating how to add a Model or a Package";
				break;
			case 5:
				break;
			case 6:
				lblDescription.Text = "Examples of how to access and use element extras - such as scenarions, constraints and requirements.";
				break;
			case 7:
				lblDescription.Text = "Iterate thru an EAP File using recursion.";
				break;
			case 8:
				lblDescription.Text = "Examples of how to access repository collections for system level information.";
				break;
			case 9:
				lblDescription.Text = "Add/delete stereotypes";
				break;
			case 10:
				lblDescription.Text = "An example of working with attributes";
				break;
			case 11:
				lblDescription.Text = "Example of working with the Methods collection of an element - and with Method collections";
				break;
			case 12:
				lblDescription.Text = "Shows how to use the older interface using the older syntax.";
				break;
			}
		}

void DiagramLifeCycle()
{
    ClearListBox();
    ListAdd("DiagramLifeCycle()");
    
    EA.Package Package = m_Repository.GetPackageByID(5);
    
    ListAdd("Creating diagram");
    EA.Diagram Diagram = (EA.Diagram) Package.Diagrams.AddNew("Logical Diagram", "Logical");
    Diagram.Notes = "Hello there this is a test";
    Diagram.Update();
    
    // Create new element
    ListAdd("Creating element");
    EA.Element NewElement = (EA.Element) Package.Elements.AddNew("ReferenceType", "Class");
    NewElement.Update();
    
    // Add Element to diagram - supply optional rectangle co-ordinates
    ListAdd( "Adding element to diagram" );
    EA.DiagramObject DiagOb = (EA.DiagramObject) Diagram.DiagramObjects.AddNew("l=200;r=400;t=200;b=600;", "");
    DiagOb.ElementID = NewElement.ElementID;
    DiagOb.Update();
    
	ListAdd("New diagram: " + Diagram.DiagramID);
}

		private void Form1_Resize(object sender, System.EventArgs e)
		{
		    listBox1.Width = ClientSize.Width - listBox1.Left - listBox1.Top;
			listBox1.Height = ClientSize.Height - listBox1.Top * 2;
		}
    
    
		void ElementLifecycle()
		{
			ClearListBox();
			ListAdd("ElementLifecycle()");
			EA.Package Package = m_Repository.GetPackageByID(2);
			EA.Element Element = (EA.Element)Package.Elements.AddNew("Login to Website", "UseCase");
			Element.Stereotype = "testcase";
			Element.Update();
			Package.Elements.Refresh();

			/* note the repeated calls to "package.Elements.GetAt"
			''in general you should make this call once and assign to a local
			''variable - in the example below, EA will load the Element required
			''everytime a call is made - rather than loading once and keeping
			''a local reference */
			for( short idx = 0; idx < Package.Elements.Count; idx++ )
			{
				ListAdd(((EA.Element)Package.Elements.GetAt(idx)).Name);
				if( ((EA.Element)Package.Elements.GetAt(idx)).Name == "Login to Website" &&
					((EA.Element)Package.Elements.GetAt(idx)).Type == "UseCase" )
					
					Package.Elements.DeleteAt(idx, false);
			}
		}

	void TestPackageLifecycle()
	{
		ClearListBox();
		ListAdd("TestPackageLifecycle()");
    
		// first add a new Model
		EA.Package Model = (EA.Package) m_Repository.Models.AddNew("AdvancedModel", "");
		Model.Update();
    
		// refresh the models collection
		m_Repository.Models.Refresh();
    
		// now work thru models collection and add a package
		for( short idx = 0; idx < m_Repository.Models.Count; idx++ )
		{
			EA.Package m = (EA.Package) m_Repository.Models.GetAt(idx);
			ListAdd(m.Name);
			if( m.Name == "AdvancedModel" )
			{
				EA.Package Package = (EA.Package) m.Packages.AddNew("Subpackage", "Nothing");
				Package.Update();
				Package.Element.Stereotype = "system";
				Package.Update();

				// for testing purposes just delete the
				// newly created Model and its contents
				m_Repository.Models.Delete(idx);
			}
		}
	}

		// Return an element for testing purposes
		EA.Element GetTestElement() 
		{
			// The following code assumes that there is at least one model, and that it contains at least
			// one package, which contains at least one element
			EA.Package p = (EA.Package)m_Repository.Models.GetAt(0);
			p = (EA.Package) p.Packages.GetAt(0);
			return (EA.Element)p.Elements.GetAt(0);
		}

void AddDeleteAttributesAndMethods()
{
    ClearListBox();
    ListAdd("AddDeleteAttributesAndMethods()");
    
    EA.Element Element = GetTestElement();
    
    // Create a new method
    EA.Method Method = (EA.Method)Element.Methods.AddNew("newMethod", "int");
    Method.Update();
    Element.Methods.Refresh();
    
    // Now loop thru methods for Element - and delete our addition
	for( short idx = 0; idx < Element.Methods.Count; idx++ )
	{
		Method = (EA.Method) Element.Methods.GetAt(idx);
		ListAdd(Method.Name);
		if( Method.Name == "newMethod" )
			Element.Methods.Delete(idx);
	}
    
    // Create an attribute
    EA.Attribute Att = (EA.Attribute) Element.Attributes.AddNew("NewAttribute", "int");
    Att.Update();
    Element.Attributes.Refresh();
    
    // Loop thru and delete our new attribute
	for( short idx = 0; idx < Element.Attributes.Count; idx++ )
	{
		Att = (EA.Attribute) Element.Attributes.GetAt(idx);
		ListAdd(Att.Name);
		if( Att.Name == "NewAttribute" )
			Element.Attributes.Delete(idx);
	}
}

		void ElementExtras()
		{
			ClearListBox();
			ListAdd("ElementExtras()");
			short idx;
			bool bDel = true;
			EA.Element Element = GetTestElement();
    
			// Manage constraints for an element
			// Demonstrate addnew and delete
			EA.Constraint ob1 = (EA.Constraint) Element.Constraints.AddNew("Appended", "Type");
			ob1.Update();
			Element.Constraints.Refresh();
    
			for( idx = 0; idx < Element.Constraints.Count; idx++ )
			{
				EA.Constraint ob = (EA.Constraint)Element.Constraints.GetAt(idx);
				ListAdd(ob.Name);
				if( ob.Name == "Appended" && bDel )
					Element.Constraints.Delete(idx);
			}
    
			// Efforts
			EA.Effort obEffort = (EA.Effort) Element.Efforts.AddNew("Appended", "Type");
			obEffort.Update();
			Element.Efforts.Refresh();
    
			for( idx = 0; idx < Element.Efforts.Count; idx++ )
			{
				obEffort = (EA.Effort) Element.Efforts.GetAt(idx);
				ListAdd(obEffort.Name);
				if( obEffort.Name == "Appended" && bDel )
					Element.Efforts.Delete(idx);
			}

			// Risks
			EA.Risk obRisk = (EA.Risk) Element.Risks.AddNew("Appended", "Type");
			obRisk.Update();
			Element.Risks.Refresh();
			for( idx = 0; idx < Element.Risks.Count; idx++ )
			{
				obRisk = (EA.Risk) Element.Risks.GetAt(idx);
				ListAdd(obRisk.Name);
				if( obRisk.Name == "Appended" && bDel )
					Element.Risks.Delete(idx);
			}

			// Metrics
			EA.Metric ob5 = (EA.Metric) Element.Metrics.AddNew("Appended", "Change");
			ob5.Update();
			Element.Metrics.Refresh();
			for( idx = 0; idx < Element.Metrics.Count; idx++ )
			{
				ob5 = (EA.Metric) Element.Metrics.GetAt(idx);
				ListAdd(ob5.Name);
				if( ob5.Name == "Appended" && bDel )
					Element.Metrics.Delete(idx);
			}

			// TaggedValues
			EA.TaggedValue ob3 = (EA.TaggedValue)Element.TaggedValues.AddNew("Appended", "Change");
			ob3.Update();
			Element.TaggedValues.Refresh();
			for( idx = 0; idx < Element.TaggedValues.Count; idx++ )
			{
				ob3 = (EA.TaggedValue)Element.TaggedValues.GetAt(idx);
				ListAdd(ob3.Name);
				if( ob3.Name == "Appended" && bDel )
					Element.TaggedValues.Delete(idx);
			}

			// Scenarios
			EA.Scenario ob2 = (EA.Scenario) Element.Scenarios.AddNew("Appended", "Change");
			ob2.Update();
			Element.Scenarios.Refresh();
			for( idx = 0; idx < Element.Scenarios.Count; idx++ )
			{
				ob2= (EA.Scenario) Element.Scenarios.GetAt(idx);
				ListAdd(ob2.Name);
				if( ob2.Name == "Appended" && bDel )
					Element.Scenarios.Delete(idx);
			}
			
			// Files
			EA.File ob4 = (EA.File) Element.Files.AddNew("MyFile", "doc");
			ob4.Update();
			Element.Files.Refresh();
			for( idx = 0; idx < Element.Files.Count; idx++ )
			{
				ob4 = (EA.File) Element.Files.GetAt(idx);
				ListAdd(ob4.Name);
				if( ob4.Name == "MyFile" && bDel )
					Element.Files.Delete(idx);
			}    

			// Tests
			EA.Test obTest = (EA.Test) Element.Tests.AddNew("TestPlan", "Load");
			obTest.Update();
			Element.Tests.Refresh();
			for( idx = 0; idx < Element.Tests.Count; idx++ )
			{
				obTest = (EA.Test)Element.Tests.GetAt(idx);
				ListAdd(obTest.Name);
				if( obTest.Name == "TestPlan" && bDel )
					Element.Tests.Delete(idx);
			}    
    
			// Defect
			EA.Issue obIssue = (EA.Issue) Element.Issues.AddNew("Broken", "Defect");
			obIssue.Update();
			Element.Issues.Refresh();
			for( idx = 0; idx < Element.Issues.Count; idx++ )
			{
				obIssue = (EA.Issue)Element.Issues.GetAt(idx);
				ListAdd(obIssue.Name);
				if( obIssue.Name == "Broken"  && bDel )
					Element.Issues.Delete(idx);
			}    
    
			// Change
			obIssue = (EA.Issue)Element.Issues.AddNew("Change", "Change");
			obIssue.Update();
			Element.Issues.Refresh();
			for( idx = 0; idx < Element.Issues.Count; idx++ )
			{
				obIssue = (EA.Issue) Element.Issues.GetAt(idx);
				ListAdd(obIssue.Name);
				if( obIssue.Name == "Change" && bDel )
					Element.Issues.Delete(idx);
			}
		}

/// assume repository has already been opened
//start at the model level
void DumpModel()
{
	ClearListBox();
	ListAdd("DumpModel");
    for( short idx = 0; idx < m_Repository.Models.Count; idx++ )
        DumpPackage("", (EA.Package)m_Repository.Models.GetAt(idx));
}

// output package name, then element contents, then process child packages
		void DumpPackage(string Indent, EA.Package Package)
		{
			ListAdd(Indent + Package.Name);
			DumpElements(Indent + " ", Package);
			for( short idx = 0; idx < Package.Packages.Count; idx++ )
				DumpPackage(Indent + " ", (EA.Package)Package.Packages.GetAt(idx));
		}

	// dump element name
	void DumpElements(string Indent, EA.Package Package)
	{
		for( short idx = 0; idx < Package.Elements.Count; idx++ )
			ListAdd(Indent + "::" + ((EA.Element)Package.Elements.GetAt(idx)).Name);
	}

		void RepositoryExtras()
		{
			Object ob;

			// issues
			ob = m_Repository.Issues.AddNew("Problem", "Type");
			ob = null;
			m_Repository.Issues.Refresh();
			for( short idx = 0; idx < m_Repository.Issues.Count; idx++ )
			{
				ListAdd(((EA.Issue)m_Repository.Issues.GetAt(idx)).Name);
				if( ((EA.Issue)m_Repository.Issues.GetAt(idx)).Name == "Problem" )
				{
					m_Repository.Issues.DeleteAt(idx, false);
					ListAdd("Delete Issues");
				}
			}
    
			// tasks
			ob = m_Repository.Tasks.AddNew("Task 1", "Task type");
			ob = null;
    
			m_Repository.Tasks.Refresh();
			for( short idx = 0; idx < m_Repository.Tasks.Count; idx++ )
			{
				ListAdd(((EA.Task)m_Repository.Tasks.GetAt(idx)).Name);
				if( ((EA.Task)m_Repository.Tasks.GetAt(idx)).Name == "Task 1" )
				{
					m_Repository.Tasks.DeleteAt(idx, false);
					ListAdd("Delete Tasks");
				}
			}
    
			// glossary
			ob = m_Repository.Terms.AddNew("Term 1", "business");
			ob = null;
			m_Repository.Terms.Refresh();
			for( short idx = 0; idx < m_Repository.Terms.Count; idx++ )
			{
				ListAdd(((EA.Term)m_Repository.Terms.GetAt(idx)).Term);
				if( ((EA.Term)m_Repository.Terms.GetAt(idx)).Term == "Term 1" )
				{
					m_Repository.Terms.DeleteAt(idx, false);
					ListAdd("Delete Terms");
				}
			}
    
			// authors
			ob = m_Repository.Authors.AddNew("Joe B", "Writer");
			ob = null;
			m_Repository.Authors.Refresh();
			for( short idx = 0; idx < m_Repository.Authors.Count; idx++ )
			{
				ListAdd(  ((EA.Author)m_Repository.Authors.GetAt(idx)).Name);
				if( ((EA.Author)m_Repository.Authors.GetAt(idx)).Name == "Joe B" ) 
				{
					m_Repository.Authors.DeleteAt(idx, false);
					ListAdd("Delete Authors");
				}
			}
			ob = m_Repository.Clients.AddNew("Joe Sphere", "Client");
			ob = null;
			m_Repository.Clients.Refresh();
			for( short idx = 0; idx < m_Repository.Clients.Count; idx++ )
			{
				ListAdd(((EA.Client)m_Repository.Clients.GetAt(idx)).Name);
				if( ((EA.Client)m_Repository.Clients.GetAt(idx)).Name == "Joe Sphere" )
				{
					m_Repository.Clients.DeleteAt(idx, false);
					ListAdd("Delete Clients");
				}
			}
			ob = m_Repository.Resources.AddNew("Joe Worker", "Resource");
			ob = null;
			m_Repository.Resources.Refresh();
			for( short idx = 0; idx < m_Repository.Resources.Count; idx++ )
			{
				ListAdd(((EA.Resource)m_Repository.Resources.GetAt(idx)).Name);
				if( ((EA.Resource)m_Repository.Resources.GetAt(idx)).Name == "Joe Worker") 
				{
					m_Repository.Resources.DeleteAt(idx, false);
					ListAdd("Delete Resources");
				}
			}
		}

		void TestStereotypes()
		{

			// add a new stereotype to the Stereotypes collection
			EA.Stereotype Stereo = (EA.Stereotype) m_Repository.Stereotypes.AddNew("funky", "class");
			Stereo = null;
			// make sure we refresh
			m_Repository.Stereotypes.Refresh();
			// then iterate thru - deleting our new entry in the process
			for( short idx = 0; idx < m_Repository.Stereotypes.Count; idx++ )
			{
				ListAdd(((EA.Stereotype)m_Repository.Stereotypes.GetAt(idx)).Name);
				if( ((EA.Stereotype)m_Repository.Stereotypes.GetAt(idx)).Name == "funky" )
				{
					m_Repository.Stereotypes.DeleteAt(idx, false);
					ListAdd("Delete element");
				}
			}
		}

		void AttributeLifecycle()
		{
			EA.Element Element = GetTestElement();
			for( short idx = 0; idx < Element.Attributes.Count; idx++)
			{
				ListAdd("attribute=" + ((EA.Element)Element.Attributes.GetAt(idx)).Name);
				EA.Attribute Attr = (EA.Attribute)Element.Attributes.GetAt(idx);
				EA.AttributeConstraint AttCon = (EA.AttributeConstraint)Attr.Constraints.AddNew("> 123", "Precision");
				AttCon.Update();
				Attr.Constraints.Refresh();
				for( short idx2 = 0; idx2 < Attr.Constraints.Count; idx2++ )
				{
					AttCon = (EA.AttributeConstraint) Attr.Constraints.GetAt(idx2);
					ListAdd("Constraint: " + AttCon.Name);
					if( AttCon.Name == "> 123" )
						Attr.Constraints.DeleteAt(idx2, false);
				}
				for( short idx2 = 0; idx2 < Attr.TaggedValues.Count; idx2++ )
				{
					AttCon = (EA.AttributeConstraint)Attr.TaggedValues.GetAt(idx2);
					if( AttCon.Name == "Type2" )
						Attr.TaggedValues.DeleteAt(idx2, true);
				}
				AttCon = (EA.AttributeConstraint)Attr.TaggedValues.AddNew("Type2", "Number");
				AttCon.Update();
				Attr.TaggedValues.Refresh();
				for( short idx2 = 0; idx2 < Attr.TaggedValues.Count; idx2++ )
				{
					AttCon = (EA.AttributeConstraint) Attr.TaggedValues.GetAt(idx2);
					ListAdd("Tagged Value: " + AttCon.Name);
				}
				if( ((EA.Attribute)(Element.Attributes.GetAt(idx))).Name == "m_Tootle" ) 
				{
					ListAdd("delete attribute");
					Element.Attributes.DeleteAt(idx, false);
				}
			}
		}

	void MethodLifeCycle()
	{
    
		EA.Element Element = GetTestElement();
		for( short idx = 0; idx < Element.Methods.Count; idx ++ )
		{
			EA.Method Method = (EA.Method) Element.Methods.GetAt(idx);
			ListAdd(Method.Name);
			EA.MethodConstraint MCon = (EA.MethodConstraint) Method.PreConditions.AddNew("TestConstraint", "something");
			MCon.Update();
			Method.PreConditions.Refresh();
			for( short idx2 = 0; idx < Method.PreConditions.Count; idx++ )
			{
				MCon = (EA.MethodConstraint) Method.PreConditions.GetAt(idx2);
				ListAdd("PreConditions: " + MCon.Name);
				if( MCon.Name == "TestConstraint" )
					Method.PreConditions.DeleteAt(idx2, false);
			}
    
			MCon = (EA.MethodConstraint) Method.PostConditions.AddNew("TestConstraint", "something");
			MCon.Update();
			Method.PostConditions.Refresh();
			for( short idx2 = 0; idx2 < Method.PostConditions.Count; idx2++ )
			{
				MCon = (EA.MethodConstraint) Method.PostConditions.GetAt(idx2);
				ListAdd("PostConditions: " + MCon.Name);
				if( MCon.Name == "TestConstraint" )
					Method.PostConditions.DeleteAt(idx2, false);
			}
			MCon = (EA.MethodConstraint) Method.TaggedValues.AddNew("TestTaggedValue", "something");
			MCon.Update();
			for( short idx2 = 0; idx2 < Method.TaggedValues.Count; idx2 ++ )
			{
				MCon = (EA.MethodConstraint) Method.TaggedValues.GetAt(idx2);
				ListAdd("Tagged Value: " + MCon.Name);
				if( MCon.Name == "TestTaggedValue" )
					Method.TaggedValues.DeleteAt(idx2, false);
			}
			MCon = (EA.MethodConstraint) Method.Parameters.AddNew("TestParam", "string");
			MCon.Update();
			Method.Parameters.Refresh();
        
			for( short idx2 = 0; idx2 < Method.Parameters.Count; idx2++ )
			{
				MCon = (EA.MethodConstraint) Method.Parameters.GetAt(idx2);
				ListAdd("Parameter: " + MCon.Name);
				if( MCon.Name == "TestParam" )
					Method.Parameters.DeleteAt(idx2, false);
			}
			Method = null;
		}
	}


	}
}


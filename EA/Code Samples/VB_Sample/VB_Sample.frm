VERSION 5.00
Begin VB.Form Form1 
   Caption         =   "Enterprise Architect Object Model Demo (VB)"
   ClientHeight    =   5085
   ClientLeft      =   165
   ClientTop       =   450
   ClientWidth     =   7935
   Icon            =   "VB_Sample.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   5085
   ScaleWidth      =   7935
   StartUpPosition =   3  'Windows Default
   Begin VB.ListBox List2 
      Height          =   2010
      ItemData        =   "VB_Sample.frx":0E42
      Left            =   120
      List            =   "VB_Sample.frx":0E44
      TabIndex        =   3
      Top             =   960
      Width           =   2895
   End
   Begin VB.TextBox txtFilePath 
      Height          =   285
      Left            =   840
      TabIndex        =   1
      Text            =   "c:\eatest.eap"
      Top             =   240
      Width           =   2175
   End
   Begin VB.ListBox List1 
      Height          =   4860
      IntegralHeight  =   0   'False
      ItemData        =   "VB_Sample.frx":0E46
      Left            =   3360
      List            =   "VB_Sample.frx":0E48
      TabIndex        =   6
      Top             =   120
      Width           =   4455
   End
   Begin VB.CommandButton cmdDoIt 
      Caption         =   "&Run Test"
      Default         =   -1  'True
      Enabled         =   0   'False
      Height          =   375
      Left            =   840
      TabIndex        =   5
      Top             =   4560
      Width           =   1455
   End
   Begin VB.Label lblDescription 
      Alignment       =   2  'Center
      BackColor       =   &H00FFFFC0&
      Height          =   1215
      Left            =   120
      TabIndex        =   4
      Top             =   3120
      Width           =   2895
      WordWrap        =   -1  'True
   End
   Begin VB.Label Label2 
      Caption         =   "&Select Test:"
      Height          =   255
      Left            =   120
      TabIndex        =   2
      Top             =   720
      Width           =   1335
   End
   Begin VB.Label Label1 
      Caption         =   "&File path:"
      Height          =   255
      Left            =   120
      TabIndex        =   0
      Top             =   240
      Width           =   855
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Dim m_Repository As Repository

Private Sub cmdDoIt_Click()
    
    If m_Repository Is Nothing Then
        Set m_Repository = New Repository
        m_Repository.OpenFile txtFilePath
    End If
    
    Select Case List2.ListIndex
    Case 0
        DumpModelDiagrams
    Case 1
        ConnectorTest
    Case 2
        DiagramLifeCycle
    Case 3
        ElementLifecycle
    Case 4
        TestPackageLifecycle
    Case 5
        AddDeleteAttributesAndMethods
    Case 6
        ElementExtras
    Case 7
        DumpModel
    Case 8
        RepositoryExtras
    Case 9
        TestStereotypes
    Case 10
        AttributeLifecycle
    Case 11
        MethodLifeCycle
    Case 12
        DumpModelDiagramsOldInterface
    End Select
End Sub

Sub ConnectorTest()
    List1.Clear
    ListAdd "ConnectorTest()"
    
    '' Add a connector and set values
    Dim source As Element
    Dim target As Element
    Dim con As Connector
    Dim ConConstraint As ConnectorConstraint
    Dim ConTag As ConnectorTag
    Dim client As ConnectorEnd
    Dim supplier As ConnectorEnd
    
    ''use ElementID's to quickly load an Element in this example
    ''... you will need to find suitable ID's in your model (Run DumpModelDiagrams code)
    Set source = m_Repository.GetElementByID(140)
    Set target = m_Repository.GetElementByID(142)
    Set con = source.Connectors.AddNew("test link 2", "Association")
    con.SupplierID = target.ElementID
    con.Update
    source.Connectors.Refresh
    ListAdd "Connector Created"
    Set ConConstraint = con.Constraints.AddNew("constraint2", "type")
    Set ConTag = con.TaggedValues.AddNew("Tag", "Value")
    ConTag.Update
    
    ''use the client and supplier ends to set
    ''additional information
    Set client = con.ClientEnd
    client.Visibility = "Private"
    client.Role = "m_client"
    client.Update
    Set supplier = con.SupplierEnd
    supplier.Visibility = "Protected"
    supplier.Role = "m_supplier"
    supplier.Update
    ListAdd "Client and Supplier set"
    ListAdd client.Role
    ListAdd supplier.Role
    
End Sub

Public Sub DumpModelDiagrams()
    List1.Clear
    Dim MyModel As Package
    Set MyModel = m_Repository.Models(0)
    Dim iPackage As Long, iDiagram As Long
    For iPackage = 0 To MyModel.Packages.Count - 1
        Dim MyPackage As Package
        Set MyPackage = MyModel.Packages(iPackage)
        ListAdd MyPackage.Name
        For iDiagram = 0 To MyPackage.Diagrams.Count - 1
            Dim iDO As Long
            Dim MyDiagram  As Diagram
            Set MyDiagram = MyPackage.Diagrams(iDiagram)
            For iDO = 0 To MyDiagram.DiagramObjects.Count - 1
                Dim MyDO As DiagramObject
                Set MyDO = MyDiagram.DiagramObjects(iDO)
                ListAdd "       " & m_Repository.GetElementByID(MyDO.ElementID).Name & "   ( ID=" & MyDO.ElementID & " )"
            Next
        Next
    Next
    ListAdd "Done"
End Sub

Sub ListAdd(ByVal s$)
    List1.AddItem s$
    List1.ListIndex = List1.NewIndex
End Sub

Private Sub Form_Load()

Dim p As ea.Project
Dim ob As Object
Set ob = CreateObject("ea.project")
'Set ob = New ea.Project
Set p = New ea.Project
    List2.AddItem "Dump Model Diagrams"
    List2.AddItem "Connector Test"
    List2.AddItem "Add and Manage Diagrams"
    List2.AddItem "Add and Manage Elements"
    List2.AddItem "Add and Manage Packages"
    List2.AddItem "Add/Delete Attributes/Methods"
    List2.AddItem "ElementExtras"
    List2.AddItem "Dump Model(Recursive)"
    List2.AddItem "Repository Extras"
    List2.AddItem "Test Stereotypes"
    List2.AddItem "Attribute Lifecycle"
    List2.AddItem "Method LifeCycle"
    List2.AddItem "Dump Model Diagrams: OldInterface"

End Sub

Private Sub Form_Resize()
    On Error Resume Next
    List1.Move List1.Left, List1.Top, ScaleWidth - List1.Left - List1.Top, ScaleHeight - List1.Top * 2
End Sub

Private Sub List2_Click()
    cmdDoIt.Enabled = True
    Select Case List2.ListIndex
    Case 0
        lblDescription = "Runs through all the packages and diagrams in a non-recursive style."
    Case 1
        lblDescription = "Links two diagram objects with a connector."
    Case 2
        lblDescription = "An example of how to create a diagram and add an Element to it.  Note the optional use of Element rectangle setting using left,right,top and bottom dimensions in AddNew call"
    Case 3
        lblDescription = "Add and delete Elements in a package"
    Case 4
        lblDescription = "Example illustrating how to add a Model or a Package"
    Case 5
    Case 6
        lblDescription = "Examples of how to access and use element extras - such as scenarions, constraints and requirements."
    Case 7
        lblDescription = "Iterate thru an EAP File using recursion."
    Case 8
        lblDescription = "Examples of how to access repository collections for system level information."
    Case 9
        lblDescription = "Add/delete stereotypes"
    Case 10
        lblDescription = "An example of working with attributes"
    Case 11
        lblDescription = "Example of working with the Methods collection of an element - and with Method collections"
    Case 12
        lblDescription = "Shows how to use the older interface using the older syntax."
    End Select
End Sub

Private Sub List2_DblClick()
    cmdDoIt_Click
End Sub

Sub DiagramLifeCycle()
    List1.Clear
    ListAdd "DiagramLifeCycle()"
    
        Dim Package As Package
    Set Package = m_Repository.GetPackageByID(5)
    
    ListAdd "Creating diagram"
    Dim Diagram As Diagram
    Set Diagram = Package.Diagrams.AddNew("Logical Diagram", "Logical")
    Diagram.Notes = "Hello there this is a test"
    Diagram.Update
    
    ' Create new element
    ListAdd "Creating element"
    Dim NewElement As Element
    Set NewElement = Package.Elements.AddNew("ReferenceType", "Class")
    NewElement.Update
    
    ' Add Element to diagram - supply optional rectangle co-ordinates
    ListAdd "Adding element to diagram"
    Dim DiagOb As DiagramObject
    Set DiagOb = Diagram.DiagramObjects.AddNew("l=200;r=400;t=200;b=600;", "")
    DiagOb.ElementID = NewElement.ElementID
    DiagOb.Update
    
    ListAdd "New diagram: " & Diagram.DiagramID
End Sub
    
    
Sub ElementLifecycle()
    List1.Clear
    ListAdd "ElementLifecycle()"
    Dim Package As Package
    Dim Element As Element
    Set Package = m_Repository.GetPackageByID(2)
    Set Element = Package.Elements.AddNew("Login to Website", "UseCase")
    Element.Stereotype = "testcase"
    Element.Update
    Package.Elements.Refresh
    Dim idx As Integer
    ''note the repeated calls to "package.Elements.GetAt"
    ''in general you should make this call once and assign to a local
    ''variable - in the example below, EA will load the Element required
    ''everytime a call is made - rather than loading once and keeping
    ''a local reference
    For idx = 0 To Package.Elements.Count - 1
        ListAdd Package.Elements.GetAt(idx).Name
        If (Package.Elements.GetAt(idx).Name = "Login to Website" And _
            Package.Elements.GetAt(idx).Type = "UseCase") Then
                
                Package.Elements.DeleteAt idx, False
        End If
    Next
End Sub

Sub TestPackageLifecycle()
    List1.Clear
    ListAdd "TestPackageLifecycle()"
    
    Dim idx As Long
    Dim Model As Package
    
    ''first add a new Model
    Set Model = m_Repository.Models.AddNew("AdvancedModel", "")
    Model.Update
    
    ''refresh the models collection
    m_Repository.Models.Refresh
    
    ''now work thru models collection and add a package
    Dim m As Package
    For idx = 0 To m_Repository.Models.Count - 1
        Set m = m_Repository.Models(idx)
        ListAdd m.Name
        Dim Package As Package
        If m.Name = "AdvancedModel" Then
            Set Package = m.Packages.AddNew("Subpackage", "Nothing")
            Package.Update
            Package.Element.Stereotype = "system"
            Package.Update
            
            ''for testing purposes just delete the
            ''newly created Model and its contents
            m_Repository.Models.Delete idx
        End If
    Next
End Sub

'Return a element for testing purposes
Private Function GetTestElement() As ea.Element
    'The following code assumes that there is at least one model, and that it contains at least
    'one package, which contains at least one element
    Dim e As Element
    Set e = m_Repository.Models.GetAt(0).Packages.GetAt(0).Elements.GetAt(0)
    Debug.Assert Not e Is Nothing
    Set GetTestElement = e
End Function

Sub AddDeleteAttributesAndMethods()
    List1.Clear
    ListAdd "AddDeleteAttributesAndMethods()"
    
    Dim Element As ea.Element
    Dim idx As Long
    Dim Att As ea.Attribute
    Dim Method As ea.Method
    Set Element = GetTestElement()
    
    ' Create a new method
    Set Method = Element.Methods.AddNew("newMethod", "int")
    Method.Update
    Element.Methods.Refresh
    
    ' Now loop thru methods for Element - and delete our addition
    For idx = 0 To Element.Methods.Count - 1
        Set Method = Element.Methods(idx)
        ListAdd Method.Name
        If Method.Name = "newMethod" Then
            Element.Methods.Delete idx
        End If
    Next
    
    'Create an attribute
    Set Att = Element.Attributes.AddNew("NewAttribute", "int")
    Att.Update
    Element.Attributes.Refresh
    
    'Loop thru and delete our new attribute
    For idx = 0 To Element.Attributes.Count - 1
        Set Att = Element.Attributes(idx)
        ListAdd Att.Name
        If Att.Name = "NewAttribute" Then
            Element.Attributes.Delete idx
        End If
    Next
End Sub

Sub ElementExtras()
    List1.Clear
    ListAdd "ElementExtras()"
    Dim Element As Element
    Dim ob As Object
    Dim idx As Long
    Dim bDel As Boolean
    bDel = True
    Set Element = GetTestElement()
    
    ' Manage constraints for an element
    ' Demonstrate addnew and delete
    Set ob = Element.Constraints.AddNew("Appended", "Type")
    ob.Update
    Element.Constraints.Refresh
    
    For idx = 0 To Element.Constraints.Count - 1
        Set ob = Element.Constraints(idx)
        ListAdd ob.Name
        If ob.Name = "Appended" Then
            If bDel Then Element.Constraints.Delete idx
        End If
    Next
    
    ' Efforts
    Set ob = Element.Efforts.AddNew("Appended", "Type")
    ob.Update
    Element.Efforts.Refresh
    
    For idx = 0 To Element.Efforts.Count - 1
        Set ob = Element.Efforts(idx)
        ListAdd ob.Name
        If ob.Name = "Appended" Then
            If bDel Then Element.Efforts.Delete idx
        End If
    Next
    
    'Risks
    Set ob = Element.Risks.AddNew("Appended", "Type")
    ob.Update
    Element.Risks.Refresh
    
    For idx = 0 To Element.Risks.Count - 1
        Set ob = Element.Risks(idx)
        ListAdd ob.Name
        If ob.Name = "Appended" Then
            If bDel Then Element.Risks.Delete idx
        End If
    Next
    
    'Metrics
    Set ob = Element.Metrics.AddNew("Appended", "Change")
    ob.Update
    Element.Metrics.Refresh
    For idx = 0 To Element.Metrics.Count - 1
        Set ob = Element.Metrics(idx)
        ListAdd ob.Name
        If ob.Name = "Appended" Then
            If bDel Then Element.Metrics.Delete idx
         End If
     Next
    
    'TaggedValues
    Set ob = Element.TaggedValues.AddNew("Appended", "Change")
    ob.Update
    Element.TaggedValues.Refresh
    For idx = 0 To Element.TaggedValues.Count - 1
        Set ob = Element.TaggedValues(idx)
        ListAdd ob.Name
        If ob.Name = "Appended" Then
            If bDel Then Element.TaggedValues.Delete idx
        End If
    Next

    'Scenarios
    Set ob = Element.Scenarios.AddNew("Appended", "Change")
    ob.Update
    Element.Scenarios.Refresh
    For idx = 0 To Element.Scenarios.Count - 1
        Set ob = Element.Scenarios(idx)
        ListAdd ob.Name
        If (ob.Name = "Appended") Then
            If bDel Then Element.Scenarios.Delete idx
        End If
    Next
    
    'Files
    Set ob = Element.Files.AddNew("MyFile", "doc")
    ob.Update
    Element.Files.Refresh
    For idx = 0 To Element.Files.Count - 1
        Set ob = Element.Files(idx)
        ListAdd ob.Name
        If (ob.Name = "MyFile") Then
            If bDel Then Element.Files.Delete idx
        End If
    Next
    
    'Tests
    Set ob = Element.Tests.AddNew("TestPlan", "Load")
    ob.Update
    Element.Tests.Refresh
    For idx = 0 To Element.Tests.Count - 1
        Set ob = Element.Tests(idx)
        ListAdd ob.Name
        If ob.Name = "TestPlan" Then
            If bDel Then Element.Tests.Delete idx
        End If
    Next
    
    'Defect
    Set ob = Element.Issues.AddNew("Broken", "Defect")
    ob.Update
    Element.Issues.Refresh
    For idx = 0 To Element.Issues.Count - 1
        Set ob = Element.Issues(idx)
        ListAdd ob.Name
        If ob.Name = "Broken" Then
            If bDel Then Element.Issues.Delete idx
        End If
    Next
    
    'Change
    Set ob = Element.Issues.AddNew("Change", "Change")
    ob.Update
    Element.Issues.Refresh
    For idx = 0 To Element.Issues.Count - 1
        Set ob = Element.Issues(idx)
        ListAdd ob.Name
        If ob.Name = "Change" Then
            If bDel Then Element.Issues.Delete idx
        End If
    Next
End Sub

''assume repository has already been opened
''start at the model level
Sub DumpModel()
    Dim idx As Integer
    For idx = 0 To m_Repository.Models.Count - 1
        DumpPackage "", m_Repository.Models(idx)
    Next
End Sub

'output package name, then element contents, then process child packages
Sub DumpPackage(Indent As String, Package As Package)
    Dim idx As Integer
    ListAdd Indent + Package.Name
    DumpElements Indent + " ", Package
    For idx = 0 To Package.Packages.Count - 1
        DumpPackage Indent + " ", Package.Packages(idx)
    Next
End Sub

''dump element name
Sub DumpElements(Indent As String, Package As Package)
    Dim idx As Integer
    For idx = 0 To Package.Elements.Count - 1
        ListAdd Indent + "::" + Package.Elements(idx).Name
    Next
End Sub

Public Sub DumpModelDiagramsOldInterface()
    Dim Rep As Object
    Set Rep = CreateObject("EA.Repository")
    Rep.OpenFile txtFilePath.Text

    List1.Clear
    ListAdd "DumpModel2()"
    Dim MyModel As Object
    Set MyModel = Rep.Models.GetAt(0)
    Dim iPackage As Long, iDiagram As Long
    For iPackage = 0 To MyModel.Packages.Count - 1
        Dim MyPackage As Object
        Set MyPackage = MyModel.Packages.GetAt(iPackage)
        ListAdd MyPackage.Name
        For iDiagram = 0 To MyPackage.Diagrams.Count - 1
            Dim iDO As Long
            Dim MyDiagram  As Object
            Set MyDiagram = MyPackage.Diagrams.GetAt(iDiagram)
            For iDO = 0 To MyDiagram.DiagramObjects.Count - 1
                Dim MyDO As Object
                Set MyDO = MyDiagram.DiagramObjects.GetAt(iDO)
                ListAdd "       " & Rep.GetElementByID(MyDO.ElementID).Name & "   ( ID=" & MyDO.ElementID & " )"
            Next
        Next
    Next
    ListAdd "Done"
End Sub

Sub RepositoryExtras()
    Dim ob As Object
    Dim idx As Long
    
    'issues
    Set ob = m_Repository.Issues.AddNew("Problem", "Type")
    Set ob = Nothing
    m_Repository.Issues.Refresh
    For idx = 0 To m_Repository.Issues.Count - 1
        ListAdd m_Repository.Issues(idx).Name
        If m_Repository.Issues(idx).Name = "Problem" Then
            m_Repository.Issues.DeleteAt idx, False
            ListAdd "Delete Issues"
        End If
    Next
    
    ''tasks
    Set ob = m_Repository.Tasks.AddNew("Task 1", "Task type")
    Set ob = Nothing
    
    m_Repository.Tasks.Refresh
    For idx = 0 To m_Repository.Tasks.Count - 1
        ListAdd m_Repository.Tasks(idx).Name
        If m_Repository.Tasks(idx).Name = "Task 1" Then
            m_Repository.Tasks.DeleteAt idx, False
            ListAdd "Delete Tasks"
        End If
    Next
    
    ''glossary
    Set ob = m_Repository.Terms.AddNew("Term 1", "business")
    Set ob = Nothing
    m_Repository.Terms.Refresh
    For idx = 0 To m_Repository.Terms.Count - 1
        ListAdd m_Repository.Terms(idx).Term
        If m_Repository.Terms(idx).Term = "Term 1" Then
            m_Repository.Terms.DeleteAt idx, False
            ListAdd "Delete Terms"
        End If
    Next
    
    'authors
    Set ob = m_Repository.Authors.AddNew("Joe B", "Writer")
    Set ob = Nothing
    m_Repository.Authors.Refresh
    For idx = 0 To m_Repository.Authors.Count - 1
        ListAdd m_Repository.Authors(idx).Name
        If (m_Repository.Authors(idx).Name = "Joe B") Then
            m_Repository.Authors.DeleteAt idx, False
            ListAdd "Delete Authors"
        End If
    Next
    Set ob = m_Repository.Clients.AddNew("Joe Sphere", "Client")
    Set ob = Nothing
    m_Repository.Clients.Refresh
    For idx = 0 To m_Repository.Clients.Count - 1
        ListAdd m_Repository.Clients(idx).Name
        If m_Repository.Clients(idx).Name = "Joe Sphere" Then
            m_Repository.Clients.DeleteAt idx, False
            ListAdd "Delete Clients"
        End If
    Next
    Set ob = m_Repository.Resources.AddNew("Joe Worker", "Resource")
    Set ob = Nothing
    m_Repository.Resources.Refresh
    For idx = 0 To m_Repository.Resources.Count - 1
        ListAdd m_Repository.Resources(idx).Name
        If (m_Repository.Resources(idx).Name = "Joe Worker") Then
            m_Repository.Resources.DeleteAt idx, False
            ListAdd "Delete Resources"
        End If
    Next
End Sub


Sub TestStereotypes()
    Dim Stereo As Stereotype
    Dim idx As Integer
    ''add a new stereotype to the Stereotypes collection
    Set Stereo = m_Repository.Stereotypes.AddNew("funky", "class")
    Set Stereo = Nothing
    ''make sure we refresh
    m_Repository.Stereotypes.Refresh
    ''then iterate thru - deleting our new entry in the process
    For idx = 0 To m_Repository.Stereotypes.Count - 1
        ListAdd m_Repository.Stereotypes(idx).Name
        If m_Repository.Stereotypes(idx).Name = "funky" Then
            m_Repository.Stereotypes.DeleteAt idx, False
            ListAdd "Delete element"
        End If
    Next
End Sub



Sub AttributeLifecycle()
    Dim Element As ea.Element
    Dim Attr As ea.Attribute
    Dim AttCon As AttributeConstraint
    Dim idx As Long
    Dim idx2 As Long
    Set Element = GetTestElement()
    For idx = 0 To Element.Attributes.Count - 1
        ListAdd "attribute=" + Element.Attributes(idx).Name
        Set Attr = Element.Attributes(idx)
        Set AttCon = Attr.Constraints.AddNew("> 123", "Precision")
        AttCon.Update
        Attr.Constraints.Refresh
        For idx2 = 0 To Attr.Constraints.Count - 1
            Set AttCon = Attr.Constraints(idx2)
            ListAdd "Constraint: " & AttCon.Name
            If AttCon.Name = "> 123" Then
                Attr.Constraints.DeleteAt idx2, False
            End If
        Next
        For idx2 = 0 To Attr.TaggedValues.Count - 1
            Set AttCon = Attr.TaggedValues(idx2)
            If AttCon.Name = "Type2" Then
                Attr.TaggedValues.DeleteAt idx2, True
            End If
        Next
        Set AttCon = Attr.TaggedValues.AddNew("Type2", "Number")
        AttCon.Update
        Attr.TaggedValues.Refresh
        For idx2 = 0 To Attr.TaggedValues.Count - 1
            Set AttCon = Attr.TaggedValues(idx2)
            ListAdd "Tagged Value: " + AttCon.Name
        Next
        If Element.Attributes(idx).Name = "m_Tootle" Then
            ListAdd "delete attribute"
            Element.Attributes.DeleteAt idx, False
        End If
    Next
End Sub


Sub MethodLifeCycle()
    Dim Element As Element
    Dim Method As Method
    Dim MCon As MethodConstraint
    Dim idx As Long
    Dim idx2 As Long
    Set Element = GetTestElement
    For idx = 0 To Element.Methods.Count - 1
        Set Method = Element.Methods(idx)
        ListAdd Method.Name
        Set MCon = Method.PreConditions.AddNew("TestConstraint", "something")
        MCon.Update
        Method.PreConditions.Refresh
        For idx2 = 0 To Method.PreConditions.Count - 1
            MCon = Method.PreConditions(idx2)
            ListAdd "PreConditions: " + MCon.Name
            If MCon.Name = "TestConstraint" Then
                Method.PreConditions.DeleteAt idx2, False
            End If
        Next
    
        MCon = Method.PostConditions.AddNew("TestConstraint", "something")
        MCon.Update
        Method.PostConditions.Refresh
        For idx2 = 0 To Method.PostConditions.Count - 1
            Set MCon = Method.PostConditions(idx2)
            ListAdd "PostConditions: " + MCon.Name
            If MCon.Name = "TestConstraint" Then
                Method.PostConditions.DeleteAt idx2, False
            End If
        Next
        Set MCon = Method.TaggedValues.AddNew("TestTaggedValue", "something")
        MCon.Update
        For idx2 = 0 To Method.TaggedValues.Count - 1
            Set MCon = Method.TaggedValues(idx2)
            ListAdd "Tagged Value: " + MCon.Name
            If MCon.Name = "TestTaggedValue" Then
                Method.TaggedValues.DeleteAt idx2, False
            End If
        Next
        Set MCon = Method.Parameters.AddNew("TestParam", "string")
        MCon.Update
        Method.Parameters.Refresh
        
        For idx2 = 0 To Method.Parameters.Count - 1
            Set MCon = Method.Parameters(idx2)
            ListAdd "Parameter: " + MCon.Name
            If MCon.Name = "TestParam" Then
                Method.Parameters.DeleteAt idx2, False
            End If
        Next
        Set Method = Nothing
    Next
End Sub


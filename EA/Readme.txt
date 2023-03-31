Enterprise Architect Version 4.50
*********************************

Release Notes for EA 4.50 Build 744
***********************************
Fix to include test cases in the Testing Documentation for the root package the command is invoked on.
Fix for element copying for Composite Activities States and Classes to create new ones on Paste as New.
Enhanced the resolve ambiguous relationship dialog to show parent classes.
Added the parent elements to the select classifier dialog.
Shared dialog appears now when UMLDiagram Properties is clicked.



Release Notes for EA 4.50 Build 743
***********************************
Fix issue with Oracle in countries using , as decimal separator - affected attribute and operation dialog
Fix for issue when deleting connectors that can occur in some models
Fix for issue where Matrix profiles saved with duplicate names would incorrectly be allowed to occur.
Fix package drawing where diagram shows package with requirements or other compartments - package could become very large 
Fix for drawing behaviour of CalllOperation Action
Modified behavior when dropping multiple Requirements from Project Browser to not create Realizations by default 
Added check for duplicate GUIDs to Data Integrity dialog
Modified menus to show "Operation" instead of "Interface" for Component and Interface operations
Changed behavior when pasting duplicated elements into diagrams which are owned by other elements. Pasted object now receives parentID of diagram
Fixed issue with Action element when having a Behavioral classifier and pressing F9 or F10 keys


Release Notes for EA 4.50 Build 742
***********************************

Fix for critical issue with Oracle repository that could adversely affect a number of functions, particularly security and element features.
Fix for issue with Timeline labels not drawing correctly
Fix for Collaboration message direction indicator
Modify Toolbox to remove Profile folder if Profile is deleted from Model
Some improvements to the speed of deleting large packages
Fix for Foreign Key dialog which could occur when both a Unique Index and Primary key contained the same parameter


Release Notes for EA 4.50 Build 741
***********************************

Fixed issues when using Ctrl + Arrow keys to move elements in the project tree up or down the order
Fixed issue with project tree not receiving focus when clicking in the background area - impacted scrolling with mouse wheel and similar actions
Adjusted F4 hot key and element context menu for "Appearance" to support multi-select appearance change in the same fashion as Ctrl+Shift+E already did 
Fixed issue where Package Elemente we're not draw correctly when the "Show Requirements" option was enabled on the diagram.
Fixed issue where some resource elements made visible in the toolbox, were incorrectly placeable onto UML diagrams.
Fixes issue where the Resource Tree would not refresh when Reference Data was successfully imported.
Fixed bug on Oracle repository when saving changes to a class attribute.
Fixed Oracle date comparison in Resource and Tasking Details Report.
Modified "Create a New Model" command to create a writeable model from a read-only base model.
Added support for copying files linked to in diagrams for HTML documentation generation.
Ensure editable item selected in table attribute list when dialog opens.
Fixed error modifying test having apostrophe in name.
Fixed display of use case metrics, ecf and tcf values on Oracle and PostgreSQL.
Fixed issue with diagram when resizing class and Object option "Auto-Reize marks dirty" is set on
Fixed issue where drawing of movable labels could cause GDI leaks in Windows9x
Fixed issue where creating new elements using the Elements->New Element command could cause EA to crash
Modified EA to allow creation of an instance of an Artifact
Some improvement to load time of very large models
Fixed issue where EA would not load the last-used User Layout when starting.
Fixed issue where HTML document generation would not include line breaks in html note fields when the "Preserve Whitespace in Notes" option was used.
C++ parser updated to:
 - Ignore any comments that appeared before compiler directives.
 - Ignore comments before method parameters.
 - Handle bitfield size specifications.
VB.Net parser updated to allow bracketed keywords for function and variable names.
Fix for Java parser where a newline appears between the function name and opening brace.
C# Parser updated to handle qualified indexers.
Fixed bug where the attProperty macro only sometimes worked.
Allowed 'Create Package per Namespace' for Import Source Directory with Java.

Data Modelling:
 - Fixed import of SQL Server table and column comments.
 - Fixed DDL MySQL UNIQUE INDEX syntax.
 - ODBC Schema Import: fixed bug importing/generating unconstrained Oracle NUMBER datatype.
 - Fixed bug creating foreign key into a unique column of a table where that table also has a primary key.
Added multiple stereotypessupport in XMI 1.2 export for objects.
Added metamodel tag to XMI 1.2 header.





Release Notes for EA 4.50 Build 740
***********************************

Updated application "look and feel" UI components. 
Added "2005" Visual Style (from View Menu)
Added a number of additional default hot-key combinations for commonly used functions
Added ability to multi-select elements within the project view for dragging and dropping and/or deleting
Added option (Tools/Options dialog)to place diagram "tabs" at top instead of bottom of mainview (requires restart) 
Added support for vertically aligning moveable element labels (eg. Port name).
Added ability to show UML Technologies and UML Profiles in the UML Toolbox as new pages. Set by right clicking on Technology or Profile in resource View
Improved application load times and overall stability on CXOffice Linux edition
Fixed issue where UML Toolbox scroll buttons may not activate when changing between diagram types
Added ability to have multiple Version Control configurations in the same model.
Added direct support for CVS in addition to existing SCC support.
Modified Interaction fragment dialog to allow larger drop list under Windows 2000/NT
Modified Sequence message to include "Set Label Visibility" context menu option
Extended Object Search on MySQL repository to include attributetags and operationtags.
Connection to repository dialog - replaced unused radio buttons with DBMS text information.
Correction to the Roles dialog to save changes to the Note and Description fields when modified
Corrected behavior where the notes docked window would lose its contents if an element, feature or connector is modified by one of the properties dialogs
Fixed problem with Connector when setting Source and Target thru the Connector Detail menu function. End point offsets are now set to zero when re-assigning source or target to ensure new end point is centred
Added ability to synchronise new class members with package visibility into a C++ class (with public visibility).
Fixed importing of inner interfaces in C#.
Modified Activity drawing to hide stereotype when Diagram "Hide Element Stereotype" option checked
Modified Attribute dialog to pick up default type on first entry
Fixed display of use case metrics, ecf and tcf values on Oracle, PostgreSQL and ASA repositories.
Added ability to "Set Font" on multiple selected elements in diagrams (element context menu)
Fixed issues with unwanted whitespace when importing C# comments.
Fixed bug with attProperty field substitution macro.
Allowed for unit qualified parameter types in Delphi import.
Fixed problem with java import when an empty comment (/**/) appears in the source.
Handle the declaration of multiple attribute in a single statement better in the Java parser.
Added support for tagged values on operation parameters
Updated dockable tag window to display tags for connector ends and operation parameters
Removed "Tagged Value" tab pages from Attribute, Operation, Connector, Object and Requirement dialogs
Added <memo> Tagged Value type - used for storing large and complex data in a tagged value. 
Corrected behavior in EA where text on printed or clipboard-copied diagrams were incorrectly overlapped.
Modified drawing behavior to prevent element names overlapping the stereotype icons in Artifacts and Class Elements.
Fixed issue with using cursor keys to resize selected elements.
Fixed issue with attribute losing constraints when dragged and dropped between classes in the Project Browser
Fixed issue with dragging and dropping a parent element onto its child within a diagram causing a circular reference.
Added Requirements #TYPE# tag & updated default HTML templates to show Object requirements type in HTML documentation
Updated RTF document generator to include Diagram Note elements when the "Document All Elements" option is turned on
Fixed problem in Java parser where a comment on the same line as a inner class or function close break stopped the thing following from importing properly.
Added a prompt to confirm code template deletions.
Added a save prompt when closing the code template editor.
Removed "Set as Default" checkbox from the Language Datatypes dialog.
Made the help button for the Language Datatypes dialog go to right page of help
Fixed problems with association types not being correctly imported.
Improved XMI 1.2 export for class diagrams and state machines.
Fixed problem with root packages not importing correctly as root nodes.
Fixed issue with importing and stripping GUID values resulting in duplicate object ids.
Fixed issue with MDG Link for VS.Net and Eclipse when Merging/Generating View level packages (occurs in 738 and 739)
Fixed bug in Glossary report to take Language adjustments into account
Fixed bug in parser that caused it to fail when the following appeared in a string. "\\\""
Fixed bug where import statements where only generated from one end of an association with unspecified direction.
Fixed bug where the arrows on collaboration messages in communication diagrams would not update after moving the association connector
Added option to show line numbers in margin of source editor  
Added "Usage..." menu option in Project Tree context menu for any Element type. Provides list of diagrams element appears in.
Fixed bug where elements with movable labels would not apply the element's customised fonts.
Fixed bug where editing diagram notes in Notes window wasn't marking diagram as unsaved.
Fixed error with XMI import and export of connector color and thickness
Fixed bug where changing case of object test was not saving.
Creating a new VB.Net property with only Read or Write checked now sets the property to "ReadOnly" and "WriteOnly" respectively.
Added a subset of version control functions to the Project View "Rootnodes" 
Modified "New Package" and "New View" functions when inserting at the Root level (ie a new view is being added) to prompt for Icon type (Use Case, Class etc.)
BrowseProject dialog (used in Set Project Template Package, Matrix and Move Requirement External) modified to match project package positions, instead of simple alphabetic
Fixed issue with diagram layout not working as expected when importing source code
Modified diagram view to hide grid when zoom level is below 40%
Fixed issue with automation interface - when using the DiagramLink.IsHidden property - depending on the calling convention of the client application 
Fixed issue where Classes dropped onto a Sequence lifeline were incorrectly being dropped on as a composite element.

Data Modelling:
 - Generate DDL - fixed bug where cascade constraints not generating for MySQL foreign key relationships.
 - Added NOT FOR REPLICATION option to SQL Server data model table columns.
 - Fixed setting of focus back to column name after saving column.
 - Added option to generate a single DDL script for tables selected on a diagram.
 - Fixed bug that truncated long check constraints.
 - Added support for import of Adaptive Server Anywhere 7 schemas.
 - Fixed bug where non-foreign key associations between tables were generated as foreign keys.
 - Added support for MySQL ENUM and SET datatypes for generating DDL.
 - Modified Foreign Key Dialog to sort foreign key parameters to match datatypes of primary key.
 - Modified Foreign Key Dialog to allow moving position of foreign key and primary key columns. 
  - Fixed import of foreign keys from MySQL on Windows.
 

Code Template Updates:
 - Added checks for package visibility class members in the C++ Class Body template.




Release Notes for EA 4.10 Build 739
***********************************

Removed Tagged Values tab page from Element, Attribute, Operation and Connector dialogs. All tagged values should be added and edited using the dockable Tagged Values Window (View/Other Windows/Tagged Values)
Modified move algorithm to correctly preserve layout of complex objects with deeply nested Parts and Ports, States and other Embedded Elements, together with their Custom Connector routing
Modified display of Test docked window to ensure it is correctly refreshed with currently selected object information when first shown or made visible
Modified XMI export to exclude "Encoding" attribute of XML instruction when Encoding string is set to nothing in Tools/options/XML Encoding
Adjusted tabular RTF output to scale with the user-selected width of the output page.
RTF Report dialog now saves Page setup with the template and no longer overwrites the default values
Fixed Find Object search dialog (Ctrl+F) so that "Scenarios, Tags etc" option works on MySQL repository. 
Fixed bug on PostgreSQL and Adaptive Server Anywhere repositories when importing Reference Data having a null field.
Fixed bug importing table from MySQL where table name includes spaces.
Option added to Tools/Options/Object page to always show State Compartment divider under State name
Foreign Key dialog - allow saving only if there's an update of an existing FK or source and destination columns have benn selected.
Modified XMI import to allow for embedded models in other objects.
Modified XMI export to exclude all diagram information when 'Export Diagrams' is not checked.
Resolved some compatability issues in XMI 1.2 export to support Netbeans MDR (using uml2mof).
Fixed bug where packages exported to XMI may not have had their stereotype preserved.
Added option to Tools/Options dialog, Colors page. Allow showing of Project Custom Colors in Format Toolbar color palettes. Provides an aid to modeling with defined color set.
Fixed various bugs in the VB.Net parser
Restrained Part when dropped from Project Tree on to diagram to require Parent container is on diagram already
Added option (true by default) to Tools/Options/Object dialog ... duplicates Inheritance and realization links for an Edit/Copy (Ctrl+Shift+V)
Added check when saving diagram for possibility of diagram being deleted or reloaded through XMI. EA will reload containing package and re-show diagram if it still exists
Added check for missing elements when selected in tree - may occur on XMI import/export or element deletede by another user. Containing package is reloaded.
Modified check on moving element in diagram to preserve current element parent for deeply embedded elements.
Added "Const" tag type to list of supported tagged value types defined in Configuration/UML/Tagged Values. Default value must be set also.
Fixed issue with image scaling of embedded images in RTF documents when viewing under Word 97 or Word 2000. 
Fixed Package drawing in diagrams to use alias names for package elements if available and the relevant option is enabled in the diagram
Modified "Paste as Link" function to include all related connection geometries between elements included in the copy
Fixed issue where operation throws tag was not updated during reverse engineering.
Added diagram option to display operation parameters by name only

Release Notes for EA 4.10 Build 738
***********************************
Further improvements and enhancements to docked tag values window
NOTE: 	Tag Value dialogs and tab pages in object, operation and attribute properties dialogs will be deprecated and removed in a future build of EA.
	All tagged values will only be editable thru the docked tagged window.
Added ability to define custom Tagged Value "types" and display specific property editors for each in docked tagged window.
Currently structured tagged types include:
	Integer values with lower and upper bounds
	Float values (with bounds)
	Color value
	Bool value
	String value
	DateTime value
	Custom value - which includes ability to define edit Mask, input Template and Valid Characters for input
	Lists - use some inbuilt model lists as drop lists. Eg. Authors, Clients, Resources, Metrics,ObjectTypes 
	See HELP file for full list of structured types
	
Inclusion of Interop.EA.dll file for .NET developers wishing to build 'strongly named' add-ins for EA. Deployed to EA install directory.			
Suppressed popup dialog detailing DBMS connection information for data transfer and data compare between models.
Fixed bug on ASA repository where adding elements wasn't incrementing their names.
Changed button caption on Configuration | Database Datatypes dialog from Cancel to Close.
Fixed bug where focus was not given to the Search Project dialog when called by the "Search Tree" command on a package in the Project View
Set default to single output file for DDL generation of a package.
Fixed bug where table has foreign keys into > 1 other table - changing any FK operation name corrupted the FK links.
Fixed bug saving creation of FK relationship on Oracle repository.
Fixed creation of foreign key cascade constraints and corrected DDL generation of cascade constraints.
Fixed bug on MySQL repository where option "Show Linked Items in Package" selected and diagram containing linked packages was opened.
Fixed Save button behaviour on operations dialog, enabling when pre- and post-condition types changed
Fixed RTF Report dialog box behavior to retain user selections that were incorrectly overwritten when user uses the file browser to select a file
Generate DDL for PostgreSQL - removed extra comma from last column when it has an inline comment.
Fixed behavior where the Project View failed to correctly display type changes for Exposed interfaces
Updated Code Template Editor to be non-modal.
Connectors now derive lock state from diagrams.
Added non case-sensitive check of primary keys when adding UML Stereotypes.
Fixed error creating foreign key on Oracle repository.
Fixed bug where moving Diagram Frames and elements in a multi-select would crash EA
Corrected double-move behavior on selected elements inside selected parent elements
Significantly improved diagram context menu behavior in very large models 
Corrected HTML document output to omit trailing ", " characters in the "Goto:" section for an element
Rendered <title> tag for HTML document generation
Added password encryption for Oracle and SQL Server repository users.
Added replication information to About box.
Corrected Oracle DDL generation of table owner in 'alter table add foreign key' statements.
Fixed display issue with instances in Project Tree missing class name on first load
Corrected SQL Server DDL generation of delimiting characters '[]' around target table name in alter table..add  foreign key statement.
Corrected EA model behavior so that Realized elements no longer inherit stereotypes automatically
Added prompt to discard changes when user cancels Element properties dialog.
Fixed error that caused EA to crash on Applying Z-Order on elements with embedded elements
Modified Project View to return focus after XML or Source Code Control I/O operation
Modified Locking to prevent label editing of package under "Full Lock" 
Fixed bug where VB.Net class comment was inserted after the class attributes.
Fixed bug in operations dialog when attempting to change between operations when there were unsaved changes.
Fix in PHP parser to allow Array default parameter values.
C++ importing now follows options in the C++ options page for where method comments should appear.
Upper bounds are no longer set when importing multidimentional arrays.
Allowed C++ comments to start with '///' as well as '//' in the one block.
Fixed saving of Registration user name and company.
Fixed saving of default version information for new EA Diagrams
Removed option from Tools | Options | Generation | Attributes/Operations page : "Generate Get/Set methods for associated attributes"
Fixed issue with Object Scenario tab page. After adding new Scenario, previously edited scenario could become the current item in the list.
Modified Element context menu to change Space Evenly Horizontally and Vertially with Across and Down respectively.
Corrected autosize behavior on Class parents, Expansion Regions and Timing to prevent the autosize occurring on zoom scales less than 60%
Fixed error with import of Stereotypes thru XML from .EAP file to SQL Server or Oracle
Added Tagged Values to the items copied from an element residing in the Project Template package
Modified package drawing code to allow resizing of package elements when some contents are hidden by their scope
Added 'Z' and 'X' as simple hotkeys to zoom in and out of diagram. 'C'=zoom to 100%, 'V' = zoom to fit
Fixed issue with visual modifications to element in diagram (font, border color etc.) being lost in some cases when property dialog invoked prior to full diagram save
Fixed issue with context item for notes, tagged values etc. not being set when scrolling thru elements in the "Report View" view of a diagram 

Code Template Updates:
 - Updated VB.Net templates to write 'Namespace' instead of 'namespace'
 - Fixed bug in VB.Net templates that meant const attributes weren't generated properly.
 - Changed 'Null' to 'Nothing' in the VB.Net Operation Body template





Release Notes for EA 4.10 Build 737
***********************************

Added dockable Tagged Properties window. Provides the ability to quickly view and edit tagged values (custom properties) for:
	
	Elements: Including owned tagged values and inherited tagged values
	Object Instances: Show owned tags and those obtained from ther classifier
	Ports and Parts: Like objects - owned tags plus Port/Part "Type" instead of the classifier. Tags are included for all parents etc. of the Port's Type. 
	Attributes: Including owned tagged values and those received from attribute type classifier (including inherited ones)
	Operations: Owned properties only
	Connectors: Owned properties only
	When over-riding an inherited property, EA copies down the tag to the child and sets the new value, leaving the original tag unchanged

Automation Interface changes:
	Element TaggedValuesEx gives a merged list of all  tagged values owned or inherited by an element	
	Attribute TaggedValuesEx gives a merged list of Tags (EA.TaggedValue) obtained from the Classifier (and its parents) only. Owned Attribute Tags are not included. Tags with the same name as an Owned tag are not included in the merge list.
	Repository.GetCounts() has been added. This provides a very simplistic count of the number of elements in a selection of major tables. 
		In this way you can detect additions and deletions (but not modifications). The returned string includes the following for each major area:
		ITEMNAME=<count of elements in table>:<sum of id's as checksum>; 
	FlagUpdates property - read/write. Enable this flag to have EA update an internal flag everytime an update occurs. Query flag with the call below
	LastUpdate property - read only - <guid of instance>:<guid of update> Used from automation to determine if the model may have changed
	InstanceGUID property - read only: random ID assigned when an instance of EA starts up. 
	Modified Project.ImportPackageXMI() to accept raw XML in place of a filename. Other options remain the same. 

Added diagrams, attributes, operations and connectors to the dockable Notes window. Now it is possible to edit notes for these elements without invoking their property window
Fixed issue with code generation templates not being reloaded after being modified on another machine
Fixed reversed column order when importing tables from PostgreSQL.
Fixed errant DEFAULT keyword when generating PostgreSQL DDL.
Fixed enable/disable problems with Project Details dialog
Fixed "Zero length string" problems with Project Details dialog
Fixed issue with applying stereotypes dragged from Resource View
Fixed issue where the Relationship matrix would wrongly display as a dialog when a Matrix profile is double-clicked in the Resource View.
Fixed issue where emf/wmf diagrams in the RTF Report are not created to fit the width of the page.
Fixed issue where icons for elements drawn with stereotype icons were incorrectly drawn when printed or exported to the clipboard or as an image file.
Modified Attribute and Glossary dialog to prompt when "Add New" would overwrite pending changes to existing record
Modified TestDetails and Maintenance dialogs to prompt when "Add New" would overwrite pending changes to existing record
Modified Diagram::Save function to ensure Undo counter reset and main menu "Edit/Undo" greyed out accordingly
Added some speed enhancements to XMI export of large models
Added ability to create and execute custom templates for Class, Attribute, Method, Parameter and Import
Imports needed by inner classes and all classes after the first in a file will now be generated by the %fileImports% macro.
Fixed bug on Oracle repository involving European comma as decimal separator.
Added "F2" as shortcut key in Project View to begin edit of current item name
Added "Get All Latest" facility to Version Control.
Added Element.PropertyType property (r/w) to Element automation interface. Sets property type for Ports and Parts only
When adding a generalization link between elements, EA will now copy down the parent Stereotype (if one exists) to the child
When dropping a class as a Port or Part onto another element, the resultant Port or Part will have the Stereotype of the classifying type
Some enhancements to improve performance over slow (for example ADSL or ISDN) links
Added offer to save any unsaved changes on navigation away from combined fragment dialog.
Corrected behavior where elements in boundaries were not moved on multi-select moves.
Added language datatypes to base model : C# : string, C++ : bool, wchar_t
Added syntax highlighting for Visual Basic to Source Code Viewer
Updated Configuration menu item to display "Local Paths" instead of "Local Directories"
Fixed autoamtion error for Attributes when loading with ClassifierID, but referenced Classifier is not in current model
Added ability to delete Linked External Requirement (dependency link) from Requirements tab oage of Object properties dialog
Fixed FileOpen automation method so that subsequent calls do not error.
Fixed problem where EA Unicode on Win98 could start with project view 'locked'

New substitution macros available in code templates: 
 - %opReturnQualType%
 - %paramQualType%
 - %importClassName%
 - %importFileName%
 - %importFromAggregation%
 - %importFromAssociation%
 - %importFromAtt%
 - %importFromDependency%
 - %importFromGeneralization%
 - %importFromMeth%
 - %importFromParam%
 - %importFromRealization%
 - %importInFile%
 - %importPackagePath%
New function macros available in code templates:
- %REMOVE_DUPLICATES(<source>, <seperator>)%
- %TO_UPPER(<string>)%
%fileImports% macro now lists imports for classes needed by all classes in the file.

Code Template Updates:
 - Java File template updated to remove extraneous whitespace after package statement



Release Notes for EA 4.10 Build 736
***********************************
Fixed bug with State elements when selected in diagram and having no inplace feature highlighted, could cause crash when accessing main Element menu
Modified state element drawing to better support shadow at large and small zoom sizes
Modified Metrics, Risk, Effort and Allocation dialogs (from element context menu/Project Information) to be readable when host element is locked
Fixed issue with creating images of diagrams containing elements with alternate images
Fixed issue with Objects in project view occasionally displaying blank name after editing properties
Fixed issue with "Return" key not working as expected in Notes window and SourceCode Editor



Release Notes for EA 4.10 Build 735
***********************************
Major update to EA diagram functionality to allow inplace editing and selection of many internal element features:

	1. Element Name. Generally allow selection and editing of name within diagram element
	2. Element stereotype. Generally allow selection and editing of stereotype within diagram element 
	3. Attributes. Allow selection, invocation of property dialog, in place editing, new, delete and modify from within diagram element
	4. Operations. Allow selection, invocation of property dialog, in place editing, new, delete and modify from within diagram element
	5. Tagged Values. Allow selection and invocation of property dialog
	6. Requirements & Constraints. Allow selection and invocation of property dialog
	7. Maintenance items (Defects, Changes, Issues, Tasks) Allow selection and invocation of property dialog
	8. Test Scripts. Allow selection and invocation of property dialog
	9. Added ability to add Test and Maintenance items from a hot key on element in diagram
	10. Operations and Attributes support insertion of new items at any point within the current ordered set
	11. In place editing of operations and attributes supports context menu to allow quick entry of some keywords, and selection of classifier from current model
	12. Ability to accept changes to attribute or operation and open up a slot for a new item immediately using Ctrl+Enter
	13. New "Inline Features" submenu added to main menu Element section.
	14. Added ability to navigate a diagram (move current selection) using Ctrl+Shift+ <arrow keys>. This will move current selectde element across, down & etc. 
	15. Added hot key to toggle a selected element's highlighted editable feature on and off (Shift + Enter)
	16. When an element is selcted and in "highlighted feature" mode, arrow keys (up and down) can be used to move up and down the features.
	17. For users of MDG Link to VS.Net and the upcoming MDG Link to Eclipse, Ctrl+E pressed on a selected operation or attribute will activate that feature in the other application
	 
	Hot keys modified for this build are: 
	    F2						Edit Selected
	    Enter					View/Edit Properties of selected
	    Ctrl+Shift+Insert	Insert new after selected
	    Ctrl+Shift+F9			Add attribute			
	    Ctrl+Shift+F10		Add operation
	    Ctrl+F11				Add other (test, maintenance item)
	    Ctrl+Shift+Delete	Delete selected feature from model
	    Ctrl+Shift+<arrows> Navigate diagram selection
	    Shift+Enter			Toggle element highlight mode on and off
	
	Other keys while editing in place:
		 Enter					Accept curren tchanges
		 Ctrl+Enter				Accept changes and open slot for new item
		 Esc						Abort editing (no save)
		 Shift+F10				Context menu for inplace editing
		 Ctrl+Space				Invoke Classifier dialog	    

Other changes: 
Fixed support for Activity Partition elements in UML 2.0 Profiles
Fixed bug in automation method Resource.Update()
Fixed loading of connector foreign key info where unique index involved.
Fixed checking of columns selected for foreign key creation.
Fixed ODBC schema import from Oracle where user doesn't have sufficient permissions.
Fixed CSV Import/Export Specifications dialog to correct abnormal save behavior
Improvements to XMI export speed for EA format export
Allow Root node to be imported from XMI at Root level
Some minor fixes to RTF document generation to show method pre-condition notes
Fix import of connector association-end stereotype from XMI
Fix XMI import issue which could very rarely place import under wrong package
Changed Attribute/Operation dialog behavior to maintain list selection on deletion of an attribtue or operation.
Fixed import of self referencing foreign keys from PostgreSQL.
Added support for multi-page printing for Diagrams.
Fixed SQL Server SQL Drop syntax where table owner included.
Added Status as a column in the Report view
Fixed MySQL DDL syntax for primary keys, indexes and comments.
Fixed Issue.Version on dual interface for automation.
Added ODBC DDL import of MySQL table types.
Fixed ODBC DDL import of MySQL PRIMARY index on primary keys.
Fixed issue with the VB parser concerning comments after a type declaration.
Fixed issue with the VB parser not correctly importing the first attribute of a type.
Fixed problem in the Java parser where it didn't import comments on a single line.
Fixed problem with delegate functions causing problems in the VB.Net parser.
New substitution macros available in code templates: %genOptVBVersion% and %eaVersion%
Renamed Collaboration diagram to Communication diagram in project view new child diagram context menu.
Fixed excess memory when importing large Oracle database through ODBC.
Corrected RTF document output behavior for both RTF Documentation and RTF Diagram only Documentation to fit large diagrams on the RTF output appropriately.
Improved MySQL ODBC schema import and DDL generation.
Fixed DDL generation of Oracle table comments and default values.
Fixed display of foreign keys where two columns from one table reference a single column of another table.
Fixed generation of duplicate foreign key names on a single table.
Fixed bug where deletion of table attribute did not also delete it as an operation parameter.
Fixed problem with name display of inner classes in tree after invoking property dialog via double click
Added option to set default DBMS on Configuration | Database Datatypes dialog.
Fixed XSD issue where attribute group references omitted the target namespace prefix tagged value
Fixed XSD issue where attribute group references omitted the target namespace prefix tagged value.
Updated Resolve Ambiguities dialogue to include full path of displayed packages during reverse engineering.
Fixed issue where Save as UML Profile command would not function when called from the Project View
Improved PostgreSQL ODBC schema import.
Fixed issue where setting End Source Activation in Sequence diagram could in some cases also set Extend Method Invocation
Modified Ctrl+L hotkey for Ports and Parts to invoke SetPropertyType function instead of SetClassifierD
Modified element Tagged Values tab on Property dialog. Synchronize button now works with Typed elements as well as classified ones (eg. Ports and Parts)
Fixed behavior where collaborations messages would mistakenly move when a diagram is reopened.
Fixed behavior where "'" characters in the RTF word substitution would be incorrectly processed by the RTFLanguage engine.
Fixed behavior where Actor elements were incorrectly unable to select alternate images

Code Template Updates:
 - VB Class template updated to check for version to generate



Release Notes for EA 4.10 Build 734
***********************************

Fixed issue with saving diagram under SQL Server when set of selected diagram options exceeded 255 characters in length
Fixed issue with initialization of connectors imported from code and assigning attributes to connectors on import
Fixed issue with export of Method post conditions to XMI when no pre-conditions defined
Fixed issue with loading method pre- and post conditions in Method constraints collection via automation interface
Added automation interface for Resource.ActualHours
Fixed issue with non-unicode version initializing under Windows NT4 SP6
TestDetails, TestScenarioDetails and Maintenance dialogs made 'sizeable'
Modified Project/Gnerate DDL main menu item to generate for entire package if single element not selected


Release Notes for EA 4.10 Build 733
***********************************

Added abitlity to suppress package contents in a diagram using the Set Feature Visibility (use Attribute scope setting) or Diagram dialog "Visible Class Memebers"
Added ability to import Test Cases from other elements into current elements Test Set (right click in docked Testing Window)
Added ability to select other element to import Scenarios from as Test scripts (Docked Test Window - Import Scenarios)
Added ability to show Test scripts as compartment in most elements (set for Diagram using Diagram properties dialog - Show Testing)
Added ability to show Maintenance items as compartment in most elements (set for Diagram using Diagram properties dialog - Show Maintenance)
Added ability tp show status of Requirement Change and Issue elements with coloured band on left edge (Set as global option from Tools/Options dialog - Object page)
Added support for deletion of attributes/operations from code during forward synchronization (see : Tools/options dialog, Attributes/Operations page )
Updated automation interface when creating new diagrams to allow placement below a parent element if necessary
Added Repository Automation Interface calls : GetTechnologyByVersion, IsTechnologyLoaded, ImportTechnology 
Added new context menu in diagrams. 
      Using Control+RightMouseButton click, a context menu of all elements in the currently selected UML Toolbox folder is shown.
     	Selecting an element will place it at the current mouse position
     	Selecting a connector will place EA into "insert new connector" mode
     	The UML toolbox does not have to be visible for this to work
     	The new context menu will only show elements currently enabled in a folder. Any hidden elements will not be shown.
Added Control+LeftMouseclick as a shortcut to toggle a linepoint on a connector. Makes it much simpler to develop complex line routing.
Corrected behavior where elements created by stereotypes in UML Profiles created prior to EA 4.1 did not import user-defined tagged values.
Fixed problem with XMI import when referencing Sequence messages between elements linked into diagram in, but not actually contained in, the imported file     			
Several changes to Diagram load to increase perfomance over slow network connections (eg. ADSL or ISDN) 
Several improvements to the XMI importer, specifically for Rose based models using XMI 1.1 (state machines and activity models)
For Unicode build added ability to set a custom codepage for ALL source code generation, import and export on a per model basis (see: Tools/options dialog Generation page [unicode only])
Added ability to specify a Matrix Profile as a target from a Hyperlink object in a diagram. Use $matrix:// as the target prefix followed by name of profil (eg. $matrix://MyProfile) 
Modified all XMI exporters to re-order operation parameters in same order as contained in model
Modified Namespace dialog to allow longer namespace names. Same for "Insert Linked Element" dialog
Modified Link constraint tab page to correct issue with not being marked dirty with some keystrokes
Modified Project/resource Details tab page to handle input keystrokes and new additions better
Fixed issue with elements being marked as "contained by parent" when dragged on top of another element, but both elements in different packages
Fixed issue with RTF generation very occasionally missing initial character of sentence after line break
Fixed issue with Spacebar not being recognized as a keystroke for marking some input dialogs "dirty"
Updated XMI exporter for Rose format to indicate EA Exporter version - "4.1RR"
Modified docked relations window and Set Feature Visibility window to show connection Role name (if available)
Ensured "Insert Related Elements" Namespace combo was being refreshed correctly after modifying project namespaces. 
Modified RTF document export behavior to support user-selected page size/orientation selections.
Added ability to print diagram frames via user-selectable local option.
Modified Element properties dialog to allow null-length phase string.
CSV export from Matrix supports , and " characters.
CSV import spec definition doesn't prompt to overwrite file.
CSV export doesn't fail where last field of any object is empty.
Added linkStereotype macro to Code Template Framework, for accessing stereotype of connectors
Fixed code gen issue that could cause conditions of list macros to be ignored for parameter and base class lists



Code Template Updates:
 - Fixed incorrect LinkedAttributeDeclaration template for PHP.
 - VB.Net Class Inherits template updated to check for multiple inheritance
 - C++ File : added new line to end of template, to resolve compiler compatibility issues
 - C++ Attribute Declaration : added check for "mutable" tagged value set
 - C++ Operation Declaration : added check for "explicit" tagged value set



Release Notes for EA 4.10 Build 732
***********************************

First implementation of "Smart Snap" an alternative to "Snap to Grid" which helps tidy layout diagram elements while you work - see View Main Menu
Added option to convert linked classifier to local instance in diagrams (object context menu)
Added support for setting non-model local options when a model is not opened within EA.
Modified Resolve Replication conflicts to pick up additional conflicts
Further enhancements to the XMI importer for Rose UML 1.3 based XMI, Netbeans based XMI and others
Initial support for XMI .12 export (beta). May be selected on the XMI Export dialog
Added option to not export custom EA tagged values when exporting XMI to other tools for code generation etc.
Added support for Extension Points being drawn when Use Case displayed in rectangular format
Changed default Z-order of attached notes/constraints for associations
Changed SQL Server comments for ODBC DDL import and generate DDL from 'remarks' to 'MS_Description'.
Fixed error throen by SQL Server repository when placing target element on diagram from relationships window.
Fixed crash when transferring model to Oracle and there's an integrity constraint violation caused by an orphaned object in an eap file.
Fixed missing index in DDL generation.
Fixed ODBC DDL import of MySQL tables with multiple foreign keys.
Fixed bug in the PHP parser for methods returning references.
Fixed bug on importing tables where option to "never" autolayout diagram had no effect.
Modified element editing in locked diagram to prevent changing appearance thru F4 or context menu
Fixed error with "Hide Connectors" setting on diagram - connector labels were still 'selectable'
Ensured boundary entity and control robustness elements were same size when added from toolbox or dropped from tree
Fixed issue with Note element "Link to Connector Tags" function
Fixed bug where elements with alternate images could be incorrectly being draw when generating HTML documentation.
Fixed issue with buttons losing state under Korean language
Added support for exporting and importing stereotype metafiles as per the Reference Data import and export.
Fixed issue when deleting a namespace from the namespace dialogue didn't update the project view.
Corrected sort order on date and numeric columns in Resource Details, Project Issues, Test Details, Project Statistics and Timeline dialogs.
Added option when generating package DDL to delete target files where selected single file for each table.
Updated UML Pattern behavior to import package elements
Corrected locate element behavior in Relationships dialog to locate package elements in Project View
Corrected issue where Method/Attribute Constraints were being incorrectly exported in HTML with non-renderable <br> tags.
Fixed issue where directions for Activity Edges were incorrectly settable in the connector properties.
Fixed bug where the modify property dialogue didn't load up the scope for existing methods.
Refresh and sort the resource list control on the Resource Details dialog.
Refresh and sort the resource list control on the Resource Details dialog.
Locate Object command in Resource Details dialog fixed to allow search for packages.
Fixed bug on SQL Server repository when setting a property for a class attribute.
Corrected XMI export behavior to write log file when requested
Fixed bug on SQL Server repository when setting a property for a class attribute.
Fixed occasional menu corruption after add-in menu had been active.
Modified Required and Provided Interface element to allow checking base interface properties
Modified XML import/export to handle issue with Communication Message parent AssociationRoles
Added update to open diagrams to remove deleted elements when complete package hierarchies are deleted. 
Fixed issue where stereotype notes on UML profiles were being incorrectly imported.
Fixed table support for UML Profiles.

Code Template Updates:
 	- C# Operation Declaration : Fixed erroneous generation of access modifier for static constructors.
	- C++ Class Body : Updated to use default constructor/destructor visibility options + bug fix
 


Release Notes for EA 4.10 Build 731
***********************************

Modified operation of user security when "User Lock required to Edit" enabled. Allow editing of locked elements within unlocked packages.
Fixed error which could result from using context menu on diagram object directly after deleting attribute in Project View
Modified Object Find dialog to allow searches on Association and Decision elements
Fixed saving Priority and Difficulty fields for Requirement Elements.
Modified HTML Document generation to not provide the Goto links in the Linked Section if there's no <a/> tag to refer to
Modified MySQL DDL generation to include "," after last field and before Primary Key directive
Modified Boundary element drawing to prevent stereotype strings being incorrectly drawn over with the element's name
Fixed behavior where element descriptions were not being updated when the package they reside in was renamed
Fixed intermittent error which could result when deleting columns from tables with foreign keys
Modified Hide Qualifier behavior to show/hide qualifiers for package contents.
Added check for blank datatypes when creating foreign keys.
Added support for displaying element features in a movable label when the element is displayed with an alternate image.
Artifact element added to element "Change type" dialog
Fixed problem with foreign key references to unique constraints
Removed direction restriction for self-connectors.
Many improvements to the XMI importer for XML written out by the NetBeansWriter for XMI 1.2 
Fixed copy-paste behavior to copy style information for diagram element connectors.
Fixed the file save-as dialog for Saving UML profiles to prompt the user to overwrite.
Fixed SQL memory leak on large DDL import (too many open cursors error message).
Fixed error in DDL output for MySQL.

Code Template Updates:
 - C++ Class body generates inline destructors for interfaces if destructors are being generated.




Release Notes for EA 4.10 Build 730
***********************************

Release 1 of MDG Link for Visual Studio.NET - and integration plugin linking EA to the Visual Studio.NET development environment
Release 1 of MDG Link Technology File specification for EA
Added support for EA Model Technology resource files in the Resource View
Added support for XMI import/export of rose uuid's
Added support to have default Attributes and Operations in elements defined in the Project-Template package
Improved security checks so that checked-out and versioned classes from foreign packages are locked appropriately.
Fixed bug on PostgreSQL repository where change to table name not working.
Added XMI support for Composite State and SubactivityState when importing from Rose
Set Control + Mouse Wheel as shortcut for zooming diagram
Set Shift + Mouse Wheel as shortcut to horizontally scroll current diagram 
Fixed ordering of foreign key columns.
Fixed resizing of elements showing inherited features
Fixed Message drawing to self-associations
Fixed ODBC import of default column values from Oracle.
Fixed RTF default templates to prevent EA incorrecly exporting Object Type information when Object Detail is unselected
Fixed display issue with Activity folder in UML toolbox not enabling scroll button in some conditions
Fixed display issue with Diagrams incorrectly displaying the locations of elements when the diagram is moved in the project
Fixed database error in Automation interface where GetByName attempted to find entries in an empty collection.
Fixed foreign key indexes for Generate MySQL DDL.
Fixed bug with unique constraint names.
Fixed problem with setting message source and target in sequence diagrams.
Fixed syntax of USE DATABASE statement for SQL Server.
Prevented adding duplicate column and constraint names.
Allowed setting Delphi operations to pure without abstract.
Added support for some string manipulation functions in the code generation templates.
Fixed bug when importing tables from MySQL and table owner was empty string.
Fixed schema/owner bug when importing ODBC tables in Unicode version.
Modified Communication message name to include ":" after sequence number (if it exists)
Corrected issue with object name underline being drawn using border style rather than font style
Added support in sequence diagrams to show proposed message insertion path while dragging and dropping a connector (Message)
Added check to ensure sequence lifelines are at least as high as the last message
Fixed table/column comments when generating SQL Server DDL.
Prevented dulicate column names and constraint names.
Added option to propagate primary key attribute change to linked foreign key tables.
Changed Delphi "uses" clauses to use a derivative of the filename of used class.
Improved "Resolve Replication Conflict" dialog and behavior
Allowed creation of read only and write only Delphi properties.
Added support for "Parts" to automatically obtain and keep synchronized any Ports from their type classifier
Added update of connectors for diagram when package element dropped from tree. Previously, connectors for newly dropped Package were not visible immediately
Fixed Activity Parameters to allow their Instance classifiers to be set.
Fixed Class parent behavior on diagrams to show parent aliases if available.
Fixed issue with Alias showing in Project tree when element properties editing from Project tree
Modified tab navigation in main dialogs to use Ctrl+PageUp and Ctrl+PageDown to cycle thru tabs
Modified wrapping behavior of names for Sequence actor, boundary and robustness elements to better handle double byte character sets
Dependency, Include, Extend and Trace icons in UML toolbox modified to have "open arrowhead" image
Some changes to Linux installer to correct intermittent database access errors


Code Template Updates:
 - VB.Net Attribute declaration support of object initialisers.
 - Delphi Operation declaration support for override tagged value.
 - Delphi File changed to use a unit name derived from the filename.
 - Removed Delphi file template overrides for class sterotypes of struct and enumeration.



Release Notes for EA 4.00 Build 729
***********************************

Added support for moving self-associations around all edges of an element.
Fixed problem with version control which caused problems with Visual Source Safe when user and password were of a specific type
Fixed issue with reverse engineering source code when using a MySQL repository
Fixed bug when importing java source directory into SQL Server repository and Author greater than 255 chars.
Fixed various reverse engineering bugs involving comments in unusual positions.
Fixed bug where new a new class synched into a file sometimes didn't get all its members.
Fixed error when exporting stereotype reference data from a model file with replication enabled into one without replication enabled
Fixed spurious error reported when upgrading model from 3.6 to 4.0 format (error introduced in build 728 - model was upgraded OK depite error reported).
Corrected issue with Port and Part instances when displaying Attribute dialog 
Code Template Updates:
 - Delphi Operation templates to allow for multiple constructors
 - Delphi Parameter template to fix default value



Release Notes for EA 4.00 Build 728
***********************************

Added check for self-parent and circular parent object errors in the Data Integrity check.
Added ability to import Linked Requirements into TestCases in the same manner as importing standard Element Requirements
Modified Hierarchy window to include "Connector" and "Delegate" as "LinkTo" connection types
Improved ODBC DDL import of check constraints and table/column comments.
Restricted length of Oracle foreign key names to max of 30 characters.
Fixed DDL Generation of Referential Integrity constraints for Interbase.
Fixed syntax of DDL Generated inline column comments.
Added "use database" option to generate DDL dialogs.
Added refresh of treeview when adding/modifying table attributes/operations.
Added warning about deleting attributes/operations that are part FK relationships.
Added isBehavior notation for UML Ports
Fixed Sequence Diagram behavior to update diagram when message scope is changed
Fixed bug where templates from functions would be given to the following class when reverse engineering C++.
Fixed bug where first parameter was ignored when code was wrapped after the open brace in reverse engineering VB.Net.
The modify property dialogue now loads up the current property values and saves modifications properly.
Added multiplicity notation to UML Ports
Fixed multiplicity notation for UML Parts
Fixed Version Control handling of pipe symbol (|) when using Eap file.
Fixed Type Hierarchy Dialog to properly show Package names of generalized Types.
Fixed bug where method definitions spread over multiple lines in Java didn't import correctly.
Fixed a mouse problem when moving swimlanes in diagrams that are zoomed in or out
Added check to adjust diagram size after performing an auto layout
Modified "Set connector Source and Target" dialog to remove boundary, note and text from the general list
Fixed bug where first attribute of a Visual Basic enumeration was missed.
Added paramNotes macro to Code Template Framework, for accessing parameter notes from code templates
Changed operations dialogue so it wouldn't override an empty return type with "void".
Fixed Import DDL ODBC bug where non-FK relationships are deleted.
Corrected some main menu items which were enabled when no project loaded

Stopped code template macro WRAP_COMMENT from producing an extra line for comments with a length equal to the wrap length.
Fixed bug where self-realizations and self-dependencies were incorrectly drawn with solid lines

Added main menu item to Diagram Menu for managing Diagram Views - included:
	Close All
	Close Current
	Close All Except Current
	Reload Current
	Save All

Code Template Updates:
 - C# Operation Declaration and Operation Declaration with property stereotype to resolve interface names	

	
	
		

Release Notes for EA 4.00 Build 727
***********************************
Fixed DDL generated script syntax for PostgreSQL auto increment/sequences.
Primary key and unique checkboxes made mutually exclusive on Table Attribute dialog.
Added option allowing Data Transfer only between eap files on Professional Edition.
Fixed error that could occur when pressing Escape key in docked note dialog or docked scenario dialog
Added option to change table owner for a package and child packages.
Added code engineering option to prevent Auto Layout of diagrams on synchronisation
Added support for forward synchronizing java package statement
Fixed code generation issue which could cause empty import/using statements to be generated
Fixed position of primary key comma when generating MySQL DDL.
Fixed code generation issue that caused classes to appear to be in the wrong package and not generate as a result.
Fixed diagram hyperlink issue that caused a hyperlink to a deleted diagram to erroneously open an empty diagram.
Fixed syntax of SQL Server DDL generated comments and MySQL foreign keys.
Fixed incorrect DB datatype conversion mapping from Access to Oracle.
Improved syncronization of enumerations.
Fixed tab order of Table Properties Dialog.
Fixed behavior where EA would not prompt the user to save any changes to attributes or operations when the selection in the Project View is changed
Fixed VB code import issue where EA would only import the first property, function or sub it encountered.
Added support for forward synchronization of inner classes
Added support for inserting classes into a Delphi file
Improved speed of forward synchronization
Fixed bug where delegate functions are removed when forward synchronizing C#
More robust parsing of C#, C++ and Java
Added refresh treeview when adding/deleting foreign keys.
Allowed PostgreSQL FK creation of integer datatype into a serial datatype.
Fixed issue that could cause incorrect generation of namespaces for C#, VB .Net and C++


Code Template Updates:
 - C# Operation Declaration to give return type of void if none set
 - C# Operation body always having body of ";" if external method.
 - C++ Class Declaration to allow generation of DLL export macros
 - C++ Class Inherits to remove extraneous white space


Release Notes for EA 4.00 Build 726
***********************************
Fixed bug involving C++ reverse engineering method parameters with comments.
Visual Studio.Net now supports For Each of EA automation objects
Fixed DDL script syntax for MySQL tables with auto_increment columns.
Fixed Delphi Code Synchronization issue which prevented properties from being synchronized correctly.
Added Page Up/Page Down/Home/End support for EA Diagram navigation
Fixed issue where element aliases were being incorrectly displayed in the Project Tree
Fixed issue where EA would incorrecly allow duplicate attributes to be created.
Fixed bug on Oracle repository when adding UML pattern to a diagram.
Fixed bug where diagram views were being incorrecly deleted when deleing a package on the Project View.
Added Data Modelling feature where tables, attributes and operations of one DBMS can be mapped to another supported DBMS.
Fixed handling of table owner and DDL syntax for SQL Server database tables.
Modified Sequence diagram to prevent resizing elements to text width at very extreme zoom values
Fixed table owner and DDL syntax for SQL Server and Oracle database tables.
Added option to specify InnoDB table type for MySQL.
Fixed issue with dropping a Part element onto a diagram where its containing parent did not exist
Some optimizations to reduce load time of large diagrams
Optimised speed of XMI Export|Format XML Output
Added option to select clustered or nonclustered primary keys for SQL Server.
Fixed Element.Elements collection to include newly added children elements created by the Automation Interface
Fixed VB Code import to correctly import class notes
Fixed Linux/CrossoverOffice printing issue whereby text was incorrectly printed back-to-front
Fixed issue whereby Part elements were being incorrectly drawn when moved from one parent to another
Modifed how port and part names are displayed in some situations to be consistent with type display
Modified synchronization of Port and Part instances to correct issue when Port or Part is of same Type as Parent (owner)
Several modifications to the XML importer to better support Telelogic XML 1.0 import
Modified handling of "Part" element to support typing in the same manner as Ports
Modified Project Reload function to force a reload of all open diagrams when refreshing the project tree
Fixed issue which caused generation of duplicated associated attributes when no role specified
Fixed bug where RTF Report Format dialog not showing all in Style combo box when on Oracle repository.



Release Notes for EA 4.00 Build 725
***********************************
Fixed drawing issue with operations on classes when User defined font set for class. Some operations may revert to standard font after abstract operation.
Corrected issue with some Diagram auto counters referring to wrong diagram type after introduction of UML 2 new diagram types. 
Modified Specify Feature Visibility dialog to include option for Port/Part type display in diagrams
Fixed XML immport/export error with Requirement Difficulty and Priority settings.
Modified appearance and minimum size of Objects when stereotyped with <<Object Read>> and <<Object Written>>
Added GUI & Misc. support for EA running under CrossoverOffice (Linux)
Generate DDL - removed whitespace after DROP TABLE statement terminator.
Generate DDL - fixed CREATE INDEX syntax for InterBase/Firebird.
Generate DDL - prevented generation of column default values for MS Access CREATE TABLE statements.
Fixed foreign key bug where key references unique column.
Import DDL ODBC - fixed bug when importing MySQL foreign keys.
Import DDL ODBC - fixed recovery if import fails.
Import DDL ODBC - fixed importing of Oracle LONG data type as CLOB datatype.
Fixed MySQL sql syntax when saving/applying UML profile.
Improved array support in C#, C++, Java and VB.Net. (Involved template changes, see below)
Code Template Updates:
 - Linked Attribute Declaration template (for all languages except PHP)
 - Fixed bug causing no type to be generated when multiplicity is set without a Collection type.
 - Fixed bug with unnamed linked attribute getting a name of the class type not the name in the options dialog.
 - Attribute declaration templates updated to provide array support in C#, Java, VB.Net.
 - Parameter VB.Net template also updated for array support.
Added Code Gen option for removing suffixes from attribute names when creating properties 
Fixed diagram undo behavior for connector & movable element labels.
Added support for reverse synching inner classes.
Fixed Element.ExtensionPoints AI property so that it contains a comma-separated list of extension points for a use case element
Fixed HTML Report generator dialog to prompt user for output folder if none defined
Fixed minor GUI translation issues
Modified behavior of "Attach Note" context menu item to save diagram state on creation, rather than requiring an explicit manual save
Modified drop behaviour of Actor onto Sequence diagram so that Actor instance displays drawn as Actor icon, not rectangle.
Updated LayoutStyles parameters for Project.LayoutDiagram Automation method.
Fixed sql syntax when loading swimlanes so that sort order is determined by converting a string number representation to a number representation.
Fixed issue with "Locate in Current Diagram" not working correctly
Updated collaboration messages to properly link with linked notes
Modified transfer of EAP model with replication enabled to Oracle (Oracle problem with negative ID values in counter columns)
Modified display of Multiplicity in sequence elements to correct issue for objects that are 'created' during interaction



Release Notes for EA 4.00 Build 724
***********************************

Fixed problem with deleting ObjectNode in ProjectTree when ObjectFlow in recently created diagram displays same ObjectNode
Fixed recent file list in Start Page to prevent blank entries showing
Modified Object and Control flow connections to show stereotype if set
Fixed error with Ports when setting the classifier of a Port to the same Class as the Port parent (host)
Modified Project Tree to prevent showing object Alias when it is set in a diagram
Modified dropping of element from Project Tree onto diagram to avoid brief display of element in top left corner
Modified drawing of elements in Sequence diagrams to show multiplicity with numeric inidcator - rather than previous "multi-object" style
Modified Sequence Message connectors to prevent changing to another connector type. 
Modified Node element to show Run State items as per EA 3.60
Modified docked note dialog to be disabled when Note element type with linked content is selected
Modified docked note dialog to refresh all elements and linked notes when object note edited in docked note dialog
Modified XMI importer to correctly import Attribute Alias if set
Fixed behaviour wherebye element positions would revert to last saved position when an element was deleted from a diagram
Modified name drawing in Exception Handler element to allow wrapping of name rather than clipping

Code Template Updates:
 - C# Operation Declaration and Operation Declaration with property stereotype
   - Fixed so that a declaration for a class with the Implements tag true generates valid code.
   - Created a tag that the user can add if they want the operation to use Explicit Implementation.
 - C# Class Body, Attribute, Linked Attribute
   - Updated to prevent generation of interface member fields and nested types
 - VB .Net Attribute, Linked Attribute
   - Updated to prevent generation of interface member fields
 - Updated Note templates for C#,Delphi,Java,PHP,VB,VB .Net to remove hardcoded wrap length- option value now used instead 
 - Added support for using connector strereotype overrides

Fixeed issue with code generation of nested types, which allowed non-class/interface elements to be generated 
Updated package code generation dialogue to save auto-generated file paths
Fixed creation of new package reference file where changes made to an existing reference file.
Fixed source directory import to close generated class diagrams on import.
Fixed source directory import to prevent EA from terminating abnormally on import of complex source bases.
Fixed DDL generation where columns have default values.
Updated code generation of import statements to use class member types for C++, C#, Java and VB.Net.
Modified wrap comments option so that it accepts -1 for no line wrap.
Fixed issue with Tag compartment string in Classes for Delphi Classes not being displayed properly
Fixed bug with foreign key relationship into unique constraints
Fixed bug with classes going into wrong namespaces in VB.Net
Fixed issue which could cause incorrect package path to be generated for java
Added hideicon stereotype appearance attribute to UML Profile exporter
Updated manner in which profile stereotypes are applied as new elements such that any appearance settings are applied before showing the properties dialog.
Fixed issue importing exception specifications that include scope resolution operator in C++
Fixed issue to prevent EA from terminating abnormally when an embedded element is created on a UML component.
Fixed issue to prevent EA from terminating abnormally when importing a VB struct.




Release Notes for EA 4.00 Build 723
***********************************

Modified EA to allow InteractionFragment to be a child element of another in the Project Tree
Modified list of elements in the Change Element Type dialog to include "Action" type
Fixed error with Change Object Type wherebye element is shown with home package text until diagram reloaded
Fixed error when moving elements with children between packages, whilst corresponding element open in tabbed view
Allowed saving of Selectable flag for elements currently not supported (eg. class, interface, note & etc) on per diagram basis
Fixed clipping problem with a small number of element types when producing RTF documentation and images
Modified drawing of object instances in Sequence diagrams to underline names
Fixed issue with unsaved elements losing recently set color values when same object moved in Project Tree
Fixed issue with creating new elements in SQL Server when template package was set and contained example of new element
Fixed issue with adding new diagrams to the Element.Diagrams collection in automation
Added ability to suppress sequence message parameters in message name by setting diagram "Show Parameter Detail" to None
Increased number of elements which are automatically set as children of ActivityPartition when adding and moving elements on Activity diagram
Modified drag drop handler in Project Tree to reduce number of database calls on action
Improved diagram display of embedded elements when they are moved from one element to another in the project tree 


Release Notes for EA 4.00 Build 722 
***********************************

Fixed problem with UML 2.0 style components when stereotyped with web profile stereotypes. Icon display and component size could be adversely affected
Fixed problem with bounding rectangle calculation when dependent and provided interfaces automatically shown on element
Fixed error wherebye Element "file" dialog duplicated record when name changed, rather than amending it
Fixed error where a deleted elemented could in some cases cause an exception to occur
Fixed problem with SQL Server when loading a new project may throw DB error on Stereotype table
Some changes to XMI importer to improve import of Telelogic XMI 1.0 exports
Added ability for Activity element whan draw as a Rectangle style to show Tag, requirement and Constraint compartments
Fixed problem with same link in two diagrams currently open when one end of link deleted in one diagram
Fixed layout problem with Interfaces not being included in layout
Modified HTML report generator to link Composite elements (with child diagram) to their target diagrams in HTML image map
Modified EA to prevent dropping duplicate copies of the same Package in a diagram
Added ability to launch files,edit operations and attributes and launch property window  from Element Browser window double click
Modified Undo feature to ensure local color settings for elements in a diagram are restored on undo
Modified "Delete from Tree" method to ensure multiple Ctrl+Del keypresses in quick succession did not causes program errors
Modified Interaction Fragment dialog to correct error with setting partition type that could occur
Improved Multi-Monitor support to correctly detect monitors to the left, above and below the primary monitor (as well as the normal to the right mode)
Modified EA to close newly created diagrams when importing directory structures - this to avoid many open diagrams when import structure is very large



Release Notes for EA 4.00 Build 721  
***********************************

Fixed error that caused context menus on some elements to display incorrectly when Current Element toolbar visible and Fade menu style shosen
Fixed error with Activity and Action elements when wrapping long element names - name could overrun element boundary in some cases
Fixed foreign key association into column with a unique constraint.
Added "Action" support to the <Apply/> Element in the UML Profile XML.
Added check box on RTF document generator to allow exclusion of "Advanced Properties" - check box named "Extended Properties"
Space evenly - Vertical - problem corrected
Added check to "Move External" function on Element properties/Requirements tab. Checks for valid current record before allowing function to proceed
Corrected problem with diagram tab "Save All" function
Added check box to Swimlane dialog from diagrams - provides ability to suppress Classifier names when set
Fixed missing back slashes in file path when generating package DDL on a PostgreSQL reopository.
Modified display of Attribute and Operation "Alias" in diagrams to only show when Diagram Checkbox "Use Alias" checked.
Diagrams in "Diagram Only" report now supported by Name 
Added ability to move elements in project browser directly under View nodes using drag and drop.


Release Notes for EA 4.00 Build 720 (Official Release of Enterprise Architect 4.0) 
**********************************************************************************

Enterprise Architect 4.0 released. 
Includes comprehensive support for the new UML 2.0 standard as defined by the OMG (www.omg.org)

Support for all 13 UML 2.0 diagrams and associated diagram elements. Includes:
	Structural Diagrams:
		Class
		Object
		Composite
		Package
		Component
		Deployment
	
	Behavioral Diagrams:
		Use Case
		Communication
		Sequence
		Interaction Overview
		Activity
		State
		Timing
	Extensions:
		Analysis
		Custom (requirements, UI design)
		
See HelpFile for detailed information on all the new UML 2 elements	
Ability to display inherited operations, attributes, tagged values, constraints and requirements in a class within a diagram
Extended Tagged Value management
Extended UML 2.0 style UML Profiles
Support multiple open diagrams thru tabbed interface
New StartPage to assist opening and managaing Projects and Profile
Ability to customize UML Toolbox contents thru personal Profile
Update to RTF and HTML generator to handle embedded elements 
Automation Interface updates and extensions (see help file)
Add-In interface modified to support additional integration with EA user interface. See help file for more details on writing new add-ins.
Code Engineering updates and fixes
DDL and database modeling enhancements and fixes
Moveable partitions within State and Activity nodes using mouse
Improved context menus for Objects and Connectors in diagrams
XML import/export improvements
PostgreSQL support as a DBMS back-end repository 
Sybase ASA support as a DBMS back-end repository

** Many other bug fixes and enhancements

See BETA release notes below for additional fixes and enhancements made during the Beta release period



Release Notes for EA 4.00 Build 719 (Beta 05) 
*********************************************
Fixed error where Association dialog could be shown very narrow
Modified Sequence Message Properties dialog to streamline creation and selection of new Operations
Ensure simple filename on Version controlled package configuration dialog - when using "Find File" dialog
Additional Automation methods and Help documentation updates
Fixed error with Requirements when properties invoked from Project Tree not always being saved 
Fixed PHP import problem that prevented classes in files with import statements from being imported correctly.
Fixed PHP import problem that prevented function identifiers from being imported correctly.
Fixed bug which prevented HTML stylesheets from being made available to HTML documentation pages correctly.
Fixed ODBC DDL table import bug where could not stop import if there was a problem with the ODBC connection.
Fixed bug in HTML documentation templates which prevented non-english characters from being correctly displayed in the HTML documentation contents pages.
Fixed Delphi operation declaration template to properly generate abstract operation declarations.
Some changes to the Delphi code generation templates
Timelane range settings for non-Timing diagrams not being saved between XMI import/export - fixed


Release Notes for EA 4.00 Build 718 (Beta 04) 
*********************************************
Fixed issue with sequence element focus rectangles not updating when object name set to be very long
Prevent saving in Boundary element properties dialog when element locked
Prevent saving of Connection details by pressing Enter key when Connection locked
Prevent loss of focus in Project Tree when attempting to edit name of locked element
Reset position of Composite Diagram icon for Use Case when Use Case drawn in Rectangle notation
Show Swimlane classifier name in Diagram Swimlanes where classifier is set
Ensure Swimlanes are not moveable when "Lock" check box is ticked in Swimlane properties dialog.
Ensure Classifier GUID reset after XMI import/export cycle
Fixed error with re-used Ports not saving on first attempt
Added additional tagged values to XMI import/export for Connections - ensure all information is retained thru export/import cycle
Fixed error with Timeline range settings not being saved under some conditions
Fixed drawing of Component element shadow when using UML 2 style drawing of components
Modified Port naming to only show PortName:TzypeName. Classifier name not used.
Prevent drawing of Actor in rectangle format in Sequence diagrams
Fixed XMI export error with "Package" visibility
Multi-Object menu item and drawing behavior replaced with "Set Multiplicity" context menu option and UML 2.0 notation (exact multiplicity drawn in top right corner)
Prevent loading of model file if Upgrade to Version 4 is cancelled or fails
Modified output format of Model Tasks in HTML report to exclude invalid dates and HH:MM:SS component
Modified "Duplicate Object" function to rename constructor and destructor to name of new class if applicable
Save icon in toolbar now greys out after a 'Save All' call from the main tab context menu
Classes with long names are now drawn correctly on initial creation - instead of requiring an extra redraw to resize
Focus of control in Operation dialog now set to Name field when dialog first invoked from Project View
Fixed error with sequence diagrams - initial messages would not be added if a notelink connector pre-existed before adding the first sequence message


Release Notes for EA 4.00 Build 717 (Beta 03) 
*********************************************
Bug fixes and performance updates from last beta.
Fixed ordering of Glossary in HTML documentation such that its sorted by Item and Type.
Corrected context menu behavior which prevented embedded elements from being correctly inserted in a diagram
Corrected XMI import behavior for files with mixed single/multibyte characters which prevented non-western characters from being imported correctly
Removed "list of" on two strings on Export Reference data
Added "Model Authors", "Constraint Status Types" to Export Reference Data
Corrected XML import/export problem which prevented dates and float values from being imported correctly when using non-english regional settings
Corrected possible XMI import problem when multi-byte characters used on Sequence Message names (length limitation)
Fixed HTML report problem when deep package nesting repeats package names in a branch
Added LibraryVersion property to Repository Automation interface
Added support for printing Project Status information as a list
Added GUIDs to Code generation template elements (class, attribute, operation, package)
Added Font scaling to support standard diagram layout & size when large fonts are selected.
Minor corrections & performance optimisations



Release Notes for EA 4.00 Build 716 (Beta 02) 
*********************************************

Added support for displaying and managing inherited and overridden tagged values. 
Added support for displaying and managing inherited and overridden Ports and Parts values. 
Added support for displaying inherited constraints.
Added support for displaying inherited responsibilities.
Added support for displaying inherited operations. 
Added support for displaying inherited attributes. 
Added support for over-riding initial values on Attributes within an inheritance hierarchy
Added Guard and Weight settings to ControlFlow property dialog
Added <<hyperlink>> as a valid GUIElement stereotype (behaves like text hyperlink element)
Added support for named message endpoints and diagram gates
Modifications to Foreign Key dialog
Additional support for defining UML Profiles using UML 2.0 Profile notation
UML Profile Toolbox compartment added
DDL Generation - fixed default comment tag when none selected.
Foreign keys - fixed corruption of FK information when changing name of non-FK operaton.
Corrected error in object search when Scenarios, Tags, etc checked.
Corrected display and updating of Diagram Note Created and Updated dates.
Updated C++ code engineering to support type-definitions of the form: typedef struct foo {...} bar;
Fixed integrity checking bug where there are orphaned requirements.
Fixed saving object efforts, risks and metrics where Notes is empty string.
Fixed bug in synchronization of foreign keys during DDL ODBC import.
Added tidy shutdown if network connection broken.
Fixed missing DB2 Data Type display in table attributes dialog.
Fixed creation of duplicate issues on Oracle repository when closing issue and selecting OK on dialog.
Added check when opening project with incorrect connect string to avoid network error message.
Added check for valid filename when generating individual DDL scripts from Project View.
Altered order of messages on completion of Data Transfer of model.
Added 3 GUIDCols missing from GetGUIDCol function in Data Transfer.
Changed source and target database connect string fields on Data Transfer dialog to read only.
Altered PostgreSQL datatype details when importing PostgreSQL tables through ODBC.
Added option to reset GUIDs when creating a new model.
Added support for PostgreSQL repository.
Added ability to create foreign keys referencing unique columns as well as primary key columns.

Bug fixes.


Release Notes for EA 4.00 Build 715 (Beta 01) 
*********************************************
First Beta release of the new Enterprise Architect version 4.0
See Build 720 notes for information on new features in EA 4.0 (official release) 


Changes and Fixes in Version 3.60 - build 663
*********************************************
Fixed PHP import problem that prevented classes in files with import statements from being imported correctly.
Fixed PHP import problem that prevented function identifiers from being imported correctly.
Fixed bug which prevented HTML stylesheets from being made available to HTML documentation pages correctly.
Fixed ODBC DDL table import bug where could not stop import if there was a problem with the ODBC connection.
Fixed bug in HTML documentation templates which prevented non-english characters from being correctly displayed in the HTML documentation contents pages.
Fixed Delphi operation declaration template to properly generate abstract operation declarations.



Changes and Fixes in Version 3.60 - build 661
*********************************************

Fix Glossary export bug which prevented glossaries from being imported into a model.
Fix Glossary dialog bug which wrongly cleared user edits on change of glossary list view.
Added <<process>> (Applied to activity) stereotype to list of default stereotypes (as per help documentation)
Fixed issue with connector label direction arrow pointing wrong way when connector ends are moved
Fixed import from XML of Composite Elements which are exported as ClassifierRoles (eg. Requirements)


Changes and Fixes in Version 3.60 - build 660
*********************************************
Small change to XMI importer to preserve external relationships between packages being imported and exported 
Modified EA to prevent opening of version 4.0 DBMS based model files


Changes and Fixes in Version 3.60 - build 659
*********************************************
Fixed default test run date being entered when test not yet run.
Fixed issue with package code generation, which prevented some classes from appearing in the list
Fixed problem with Operation dialog and some other properties dialog which prevented Save button enabling under certain circumstances
Fixed issue with selection of Hyperlinks and states when embedded on top of another state or element

Changes and Fixes in Version 3.60 - build 658
*********************************************
Corrected issue with Unicode build that prevented use of JET 4.0 to access models or import MS Access 2000 or higher database schemas
Fixed VBNet function identifier behaviour which prevented keyword function identifiers to be properly imported.
Fixed UML Profile import process to correct an issue where SPEM profile images were not being properly imported.
Fixed XMI import error when reloading new XMI controlled packages.
Fixed issue with saving of decimal values in requirements types dialog when locale uses , for decimal point
Fixed problem with automation interface when reading IsStatic,IsSynchronized and IsAbstract properties of Method


Changes and Fixes in Version 3.60 - build 657
*********************************************
Modified UI to use Shift+Control+Tab as the key combination for moving between tabs in major dialogs - allows use of Control+Tab combination to enter tabs in note fields
Corrected problem with saved image rectangle in XMI sometimes not reflecting absolute diagram offsets
Allowed use of code Synchronize command from Project main menu when multiple selection is enabled
Modified HTML report generation to use ", " instead of "," in some instance, to allow browser to wrap long "See Also" lists
Modified XMI import/export to correct issue with diagrams containing instances of the root export package losing image of package on import
Fixed attributes dialog issue where the user would be mistakenly prompted to save changes when using the keyboard accelerator key to access the dialog.
Fixed issue with batch code generation and readonly files, causing the dialogue to lock.
Fixed issue with batch code generation and inner classes. 
Corrected display and updating of Diagram Note Created and Updated dates.
Fixed saving object efforts, risks and metrics where Notes is empty string.
Fixed bug in synchronization of foreign keys during DDL ODBC import.
Fixed missing DB2 Data Type display in table attributes dialog.


Changes and Fixes in Version 3.60 - build 656
*********************************************
Added search results count to the Search dialog.
Fixed Delphi import issue where statically defined functions would prevent a Delphi class to import correctly.
Fixed Delphi synchonization issue which prevented operation implementation signatures from being properly synchronised with that in the class body.
Excluded DDL Import of SQL Server 2000 dtproperties table.
Added option to show table owner on diagram - set option on Diagram Properties Dialog.
Fixed syntax of DDL table generated for PostgreSQL.
Added create sequence statement when DDL generating an autonumber attribute for PostgreSQL.
Fix deletion of association notes link during ODBC table import.
Fixed MSAccess Memo datatype specification for DDL generation.
Fixed missing guid when creating table owner.
DDL Generation - fixed default comment tag when none selected.
Foreign keys - fixed corruption of FK information when changing name of non-FK operaton.
Corrected error in object search when Scenarios, Tags, etc checked.
Fixed missing column comments and corrected foreign key syntax when generating MySQL DDL.
Fixed display error when 'Classes Honor Analysis Stereotypes' unchecked in options dialog (affected Class elements only)
Fixed display problem with connector labels sometimes displaying black background for Print Preview and Print
Modified XMI import/export to include message conditional
Added Entity element to Custom page of UML toolbox
Fixed error on code synchronization of C# and Java function names which could result in missing bracket
Fixed case sensitivity issue in class names, when reverse engineering nested classes.
Updated C++ import feature to include support for "typename" keyword in operation return and paramater types.


Changes and Fixes in Version 3.60 - build 655
*********************************************
Fixed problem with notes linked to element features or diagram note
Reverse engineering a locked file no longers disables UI
Removed the "Lock Package" menu option from all Project Root Nodes
CSV specification is checked for completeness before import


Changes and Fixes in Version 3.60 - build 654
*********************************************

Modified the image generation code to allow creation of larger in memory bitmaps for drawing. This avoids having larger images scaled down when saved to file in PNG, JPG & etc. format. This affects the Save Imge to File and HTML/RTF generated images. WMF and EMF format are not changed.
Added option in Tools/Options dialog - Diagram page to set the maximum amount of memory to allocate when creating memory bitmaps for images. This can be increased from the default where sufficient ram and pagefile space exist.
Fixed error with XMI package round tripping and "Virtual Documents" losing package identifiers
Instances of EA COM objects started from automation are now marked as single use to prevent inadvertent re-use of the same COM object when running multiple automation clients.
Fixed error with some toolbar images when Zicom Mentor add-in is active. 
Modified algorithm to determine font sizing when zooming in and out. Corrects issue with some blank space appearing at the end of diagram elements with many attributes and/or operations. Element appearance is now more consistent at all zoom levels.
Modified Zoom procedure to retain current diagram centre when zooming in or out, rather than retaining the upper left corner position. Generally only noteiceable when diagram exceeds size of visible window.
Fixed issue with Package "Note" of root package not being retained thru XMI round trip.
Fixed bug in Integrity Check when checking Object Features.
Change PostgreSQL auto increment DDL script to lower case.
Fixed bug in Foreign Key Dialog allowing duplicate names.
Updated C++ Import feature to accept inheritances as "virtual public"-previously only "public virtual" was accepted.
Fixed bug in C++ Synch, which caused implementation notes to lose a carriage return during synchronize.
Fixed bug which could prevent classifier type being saved properly, when retyped manually into combobox.
Code Generation for custom languages now excecutes only the "File" template- previously hardwired to execute the "Class" template.
Updated Java Parameter template use "final" keyword for fixed parameters.
Updated Java Class Inherits template to handle sub-interfaces.
Updated Java Operation Declaration template to correct the "throws" specification.
Updated C++ Operation Declaration templates to correct the "throws" specification and "const" stereotype.
Group permissions now flow through other members of the group.
Modified LockPackage dialog to prevent repeated display of warning message when locking on behalf of another group 
Fixed bug in Code generation which prevented VBNet namespace Import statements from being automatically generated.
Fixed bug in C# import feature which could prevent enums from being imported correctly.
Fixed bug in Code generation feature to allow Delphi export paths to be saved in the registry.
Updated the Image Manager Dialog for elements that causes the currently-selected alternate image to be selected in the list by default.
Updated the UML Profile Save/Import features to selectively save and import additional UML Profile options including:
  - Element Size fields (cx, cy)
  - Color and Appearance fields (bgcolor, fontcolor, bordercolor, borderwidth)
  - Alternate Image (metafile, or <Image/> Element, if there is an alternate metafile image defined for the element)
  - Code Templates (<Template /> Element, if there is a code template defined for the stereotype in the Profile)



Changes and Fixes in Version 3.60 - build 653
*********************************************
Fixed problem opening foreign key dialog for some earlier EA model files
Fixed display of default foreign key name when creating new foreign key
Modified saving of long foreign key names
Fixed support for importing and exporting multiple class/attribute/operation attributes in CSharp and VBNet
Added Support for generating the system issues and system tasks in the HTML Documentation
Added check to Foreign Key dialog to ensure target columns are Primary Keys.
Fixed problem with modifying PrimaryKey columns for a table class


Changes and Fixes in Version 3.60 - build 652
*********************************************
Modifed version control option dialog to allow disconnecting from version control even when packages in the model are under VC (useful when changing project location etc)
Modified behavior of main menu and context menu handler to correct a deficiency in a 3rd party library when using EA with Unicode on non-Englsih platforms
Allowed Version COntrolled packages to have relative paths specified instead of a single path (eg. source\java\classes.xml instead of just classes.xml. This applies to the Package Configuration dialog
Updated import of C++ operation parameters: array based parameters and more complex template-based parameters can be imported
Updated C++ Operation Declaration templates: removed redundant %opReturnArray% macro
Updated Linked Attribute templates: fixed problem with collection classes, when multiplicity set to "1"
Updated UML profile import - now includes support for "constraint" stereotypes
Fixed issue that could cause DAO error on package generation
Added Support for generating the glossary in the HTML Documentation
Fixed problem with selection of Use Cases in metrics dialog based on Keyword Like or Not Like search value
Fixed some errors with preservation of Package stereotype value for root nodes and views when round tripping using EA XMI export/import
Fixed search error when using SQL server in the find dialog and setting certain tagged value criteria
Auto element naming dialog now picks up changes in object type when using keyboard input only
Fix for problem with length limit on Foreign Key Names
Some changes to the Docked Element Browser window to ensure it is updated when tree and diagram changes occur
Changed drawing routine on composite element diagram icon
Default package behaviour in diagrams has been changed to automatically open the target rather than show properties (Ctrl+K behavior)
Correction to file writing routine that impacts CSV export
Some modifications to item selection in Attribute and Operations dialogs
Modified drawing code when saving images to file - better support for Win98/95/ME and improvements for XP/NT/2000 also. Impacts maximimum size of diagram that can be saved without scaling of image
Modified drawing code to redraw diagram when feature visibility dialog invoked to update display immediately
Modified mouse selection pf elements in diagram to prevent moving and sizing when Ctrl key is held down during mouse move.  Helps prevent inadvertent moving of elements when adding to selected list using Ctrl+Click
Foreign Keys...
	Improved saving of association details, loading of Source and Destination roles.
	Fixed association link to display source and destination roles as well as foreign key attributes							
	Fixed inconsistencies on deletion of association where there are multiple or composite foreign keys.
	Fixed Foreign Key dialog to improve handling of multiple and composite foreign keys.
	Fixed import of multiple and composite foreign keys.  
DDL Generation...
	Fixed lock up when DDL generation file path not valid.
	Restricted Oracle trigger and sequence name lengths to max 30 characters when generating DDL.
	Fixed generation of table and column multiline comments.	
Allowed for longer table/column/operation names.					 		
Fixed saving Tablespace in Table Properties/Class Detail when Tablespace is deleted.
Fixed saving of primary key name changes in association.
Fixed saving of attribute name changes in association.
Fixed updating of attribute from project tree where attribute is part of primary key.



Changes and Fixes in Version 3.60 - build 651
*********************************************
Support for PHP code generation and reverse engineering (beta release)
	. Code generation templates to support the PHP language
	. Importable standard datatypes package
	. Reverse engineering of PHP
	. Synchronization of PHP source code and syntax highlighting for source editor
Improved transaction handling around XMI import/export and version control check-in and check-out
Modified modality of dialog boxes shown when checking in and out packages to version control to prevent inadvertent interruption of the process
Improved speed of XMI import- especially in removing existing packages from model prior to import
Fixed issue with object Maintenance dialogs which treated name as key value. Also allowed multi-delete in docked list.
Fixed issue in C++ reverse engineering parameterized operation arguments
Fixed Synchronize options for package-level source code generation. Previously, class-level synchronize options were used
Modified RTF export to allow user entered line breaks in operation paramters to appear in documents
Modified behaviour of several dialogs in EA to better handle "Save" operation when initiated by pressing Enter key
Fixed issue with diagram icon in browser not changing immediately a diagram type is changed
Fixed diagram not saving Page Setup when invoked and set from the File menu
Corrected Status Types dialog query definitions for MySQL - problem with case sensitivity
Some minimisation of queries generated when moving diagram elements around to assist those using EA over a slower link
Fixed problem with Add-In menu when switching between user defined visual layouts
Fixed issue with Oracle and Implementation/Dependency report
Updated Scenario dialog behaviour to preserve list selection when a scenario is saved
Changed the default value of the "Show Stereotypes" option in the Options->General page to true
Fixed a gui issue with the attributes dialog that wrongly enabled the property checkbox after clicking the new button to add an attribute.

Changes and Fixes in Version 3.60 - build 650
*********************************************
Fixed problem with Auto-Layout diagram feature causing exception in some cases in non-unicode build of EA
Added initial supports for Ports to EA
Modified the Save as Profile function to support the more standard UML Profile modeling syntax
Modified calculation of bounding rectangle for Decision elements (text could be truncated in saved images in some conditions)


Changes and Fixes in Version 3.60 - build 649
*********************************************
Extended support for Composite Elements to Class, Object, Use Case etc. 
	- Can be set from context menu option on diagram element
	- Automatically adds a child diagram to the Composite Element
	- Adds a small icon to the lower right corner indicating Composite
	- Double click on Composite Element will open the child default diagram 
Added automation support for composite elements - Element now has an Elements and a Diagrams collection
Added App object to EA automation interface
EA Type Library updated to version 2.02. 
Fixed issue with source code editor prompting to save file after code generation
Changed package generation to ignore existing file paths by default, when auto generating directory structure
When running EA from external automation client, main windoww is now automatically hidden
When running EA from external automation client, add-ins are prevented from loading
Also added ability to retrieve App Object from the "Running Objects" table using constructs such as VB's GetObject() function. (see Help file for more information)
Added ability to add and work with  Nested Version Control packages in the Project Browser (ie. children of Version Controlled packages may now be Version Controlled as well.
Added Constraint Status Types Dialog & support code to provide user-customisable constraint status types.
Fixed problem with loss of Keyboard mappings when switching between Visual Layouts
Fixed problem with sequence diagrams when "New" message is preceded by a Return message to an other object
Fixed problem with diagram not being marked dirty when relation suppressed thru docked relations window
Re-worked Project/Issues dialog to be more in keeping with the System/Issues dialog
Fixed issue with Source Editor when using Local Paths as part of the filename
Allowed diagrams to be placed under Root node in project browser
Fixed error when deleting tablespace names
Added support for color and border style using the Format toolbar when editing Note elements
Modified System Issue dialog to replace "Save" with "Apply" and retain current record after saving
Corrected a couple of minor XSD generation issues
Disabled Version Control "Change User" button for Jalinda Igloo, which does not support the function.
Changed route behaviour for Association classes so that it routes in the user-specified default mode.
Added default property operation note values to new property creations (attribute notes)
Fixed diagram draw behaviour logic that refreshes a lollipop name of a realised interface when the interface's name is modified
Fixed Issue Dialog problem that did not set edit fields as dirty when user entered white space (space).
Fixed Property checkbox behaviour for Attribute Edit dialog that erroneously showed properties as unchecked	
Linked display of Delphi Tagged Values for Properties to visibility of Operations (hiding one hides the other)

Changes and Fixes in Version 3.60 - build 648
*********************************************
Added Sub-Activity and Sub-Machine elements to the UML Toolbar. Each automatically creates a new child diagram on creation.
Added ability to show a Use Case using 'rectangle' notation - displaying attributes, operations, constraints etc. in the same way as a Class
Added ability to drop an Operation from the Project View onto an Activity diagram and have it automatically create an Activity element
Added Artifact model element to the Deployment compartment of the UML Toolbar. Displays using artifact keyword and 'doc' icon in top right corner
Added ability to 'Show Realized Interfaces' to Class and Component (toggle on/off using element context menu. When enabled:
	- EA will show a lollipop style interface node for each Interface the class or component directly realizes
	- Connectors may be directly attached to the lollipop circle - inidcating usage of the interface part of the class or component 
Fixed problem with focus of control in Sequence diagrams on messages set as "New" (ie. create new instance)
Added ability to generate a complete directory structure of code from a model package and subpackage in one step using default values
Modified sort order of some collections in the automation interface to match the sequence shown in project browser
Fixed some issues with adding child diagrams to elements in the project browser 
Fixed issue with locking packages using Group locking
Fixed issue with context menu display in UML Toolbar
Fixed issue with associations between objects being deleted in collaboration diagrams when one object removed from diagram
Modified Issue dialog to set status to closed when issue resolved
Corrected case sensitivity issue of class scope in XMI import/export
Fixed issue with Association Class elements showing dotted link in images derived from only currently selected items
Added context menu option to single elements to include "Copy Selected Image to Clipboard)
Fixed import of XMLDoc <exception/> comment tags for languages not having explicit throws clauses
Fixed ExportXML dtd file copy problem for XMI 1.0 export



Changes and Fixes in Version 3.60 - build 647
*********************************************
Added Multi-Object appearance for sequence elements
Added context menu option to Connector "Hide in Other Diagrams" - allows batch Hiding/Showing of a connector in all but the current diagram
Unlocked "Launch" button on Files tab of Object Properties dialog when Object is locked - assume launching files is still OK when object is locked
Modified Project Tree to show package stereotypes when appropriate
Fixed error in Sequence diagram - Object could be displayed with circle notation
Fixed error in image generating code which could cause an error when creating large HTML documentation sets
Fixed issue with Add-Ins menu causing interference with standard menus in rare circumstances
Modified Add-In template (Addn_Templ.TLB) to include "Disconnect()" method (destructor). 
	- Used to allow Add-Ins to disconnect gracefully (see Help File)
 	- Solves problem of .NET based Add-Ins locking EA from exiting normally
 	- see Help file for more information
Modified XSD generator to ensure nested model groups generate correctly 
Modified standard C# Operation Body code generation templates to exclude curly braces for interface methods
Fixed issue with Version control settings when using Replicated .EAP files (settings could not be saved)


 	


Changes and Fixes in Version 3.60 - build 646
*********************************************

Added additional highlight for context element in diagrams - when selected has hatch border. 
	. Context element is one used for alignment operations not using mouse
	. Can be turned off on the Diagram/Behavior page of Options dialog
Modified Project Browser to improve context menu behavior and added warning before reloading model when changes by other user detected 
Changed Add-In template file from DLL format to Type Library format for improved language independence. See help file for details on writing Add-Ins using Add-In Template Type Library
Added option to Tools/Option dialog to not expand drop target packages when doing a node trasnfer in project browser
Fixed VBNet Comment parser behavior - XMLDoc, JavaDoc & standard comment
Fixed VB & VBNet processFunction arguments (multiple lines)
Various Code Generation Template updates 
Modified CreateProperty dialog behavior on Attributes dialog (to improve property creation & modification)
Modified diagram alignment behavior to use last selected element in group selection when aligning via main menu
Fixed issue with conditions on Collaboration messages caused when re-sequencing the collaboration messages
Corrected possible problem when printing or saving images with 'Display Watermark' ticked, but not text set to display
Modified some string resources to correct displayed tooltips
Modified RTF Report dialog to allow creation of new Template when started from <<Model Document>> class
Limited Extended Properties on Operations for Tables to Indexes and Foreign Keys
Improved Boundary, Text and Note behavior to retain font and color settings when pasting as new copy
Modified RTF format of Requirements/Linked Requirements to make them match
Modified RTF format of Requirements/Linked Requirements to hide status and advanced information when "Object Detail" unchecked
Corrected problem with Code Generation toolbar - which could cause exception when showing context menu under certain circumstances (affects XP and Win3K only)
Modified .EAP file repair functions to be grayed out when no EAP file loaded.
Modified XMI import/export to move connector end stereotypes from the attribute to tagged value level. Issue with DTD
Extended behavior of locking on View and Project roots to allow deletion of View or root when "Require User Lock to Edit" is the security mode
Fixed option for auto-generating interface methods
Updated C# operation templates: removed invalid modifiers on interface operations
Updated C++ FileImpl template: uses %fileNameImpl% instead of %fileName% in comment section
Added ability to bookmark (red triangle) alternate images and stereotyped metafiles 
Fixed issue with automation interface that could prevent "CreateObject" working in some instances



Changes and Fixes in Version 3.60 - build 645
*********************************************
Inclusion of first release of EA Add-Ins capability (see Help file under Automation/Scripting)
	- Ability to define ActiveX add-ins to appear in EA main menu
	- Allows creation of one menu branch (including submenus) per Add-In
	- Receive and respond to user menu selection
	- Interact with the EA Repository elements active within the current open Model

Fix for problem with CVS Source Code Control using Igloo bridge
Modifications to SCC interface to support PVCS SCC
Fix for relative names from Source Code Editor
Modified user interface to retain current User Tools when changing visual layouts
Added support for business process stereotypes such as "business worker" "business entity" "business actor" "business use case" etc.
Modified Space Evenly - Horizontal function to accomodate some elements which may have external text (eg. Actor)



Changes and Fixes in Version 3.60 - build 644
*********************************************
Modified Workspace Views toolbar to allow toggling of docked windows (on-off) 
Added Configure Appearance menu option to element context menu
Fixed problem with some docked windows first appearing with no "X" cloce button in the top right corner
Fixed issue where Rolenames on association between two tables were being suppressed, even when Foreign Keys were not defined
Modified  VB parser to treat Enums in .cls files as inner classes
Modified VB.Net parser to allow _ in op declaration
Added code in Override Implementation dialog to support VB implemented interfaces.
Fixed issue with Vb, VBNet operation implementation for inherited interfaces
Corrected problem with element properties dialog appearing offscreen in some instances
Modifed foreign key dialog to only show FK's associated with current association
Fixed problem with Print List function in several places causing exception in Unicode version
Released first version of SPEM UML Profile (see http://www.sparxsystems.com.au/spem_profile.htm)
Fixed problem in automation interfce with Aggregation property on ConnectorEnd Object
Fixed problem in automation interface when deleting a Connector from a Collection
Changes to XMI 1.0 imort/export to pick up EA tags when round tripping
Modified use of XMI local path setting for use with Version Control
Added "Parameter Impl" code generation template to allow for correct generation of operations having parameters with default values


Changes and Fixes in Version 3.60 - build 643
*********************************************
Generate namespace option is used in default templates
Packages set as root namespaces, now generate classes at file scope
The %synchNamespaceBodyIndent% is available for specifying namespace-level indentation during code synchronisation.
Updates to the XML Schema generator and to the associated UML Profile which may be obtained from our website
Fixed error when re-ordering Collaboration messages
Fixed error in XMI import/export to SQL Server - missing diagram hyperlinks
Improved some aspects of XMI import/export when linking back to internal elements
Added support for User Images in custom toolbars. Supplied some default icons in UserImages.bmp, which may be modified or replaced by end user
Fixed issue with importing Metafiles for Stereotypes, both in Stereotype dialog and in importing UML Profiles
Modifications to Code Templates to fix error with C# Public keyword
Added support for <<label>> stereotype on GUIElements - creates a transparent text field
Some fixes in the Delphi code generator
Fixed display of combined foreign and primary keys.
Fixed display of multiple primary keys.
Fixed bug on delete connector on MySQL.
Removed restrictions on creation of foreign keys.


Changes and Fixes in Version 3.60 - build 642
*********************************************

Fixed problem with import of WMF and EMF files for stereotypes in Unicode build
Modified self-reference sonnectors to allow moving down the full height of extended elements
Fixed error in Implementation report under Oracle
Modified behavior of Requirement elements when resizing using "auto-size"
Modified Configure Default Appearance to allow setting more than one element at a time
Fixed error in Save Diagram as Profile function which could cause incorrect XML
Modified code generation template for C++
Added ability to sort UML Profile elements in resource tree in different ways (context menu option)
Fixed error that could occur when closing Element property dialog using Alt+C



Changes and Fixes in Version 3.60 - build 641
*********************************************

Fixed C++ Rev Eng : Incorrectly parsed attributes with nested template types
Modified Use Case drawing to hide extension points when diagram option "Hide Attributes" is checked
Removed namspace blank line in DDL generation for Oracle
Fixed missing attribute name on associations with multiple primary keys
Fixed error in import of tables where more than one foreign key relationship existed between two tables
Fixed bug that could cause Operations and Attributes dialog to abort when Alt+C pressed
Fixed problem with buttons to move method params up and down being disabled 
Fixed issue with UI when changing visual layouts that have docked tear-off menus showing
Modified use of stereotype colors to work when base class type is not matched in target element
Fixed caption display of sequence diagram so that when diagram is scrolled, element captions in title are correclty positioned


Changes and Fixes in Version 3.60 - build 640
*********************************************

Added additional Attribute details to RTF reports
Fixed error in System docked window that could cause exception when no project loaded
Fixed C++ Rev Eng : Incorrectly parsed parents, if namespace resolved.
Added support for namespace of parent in C++ inheritance declaration
Fixed bug in Foreign Key Dialog allowing Update Cascade checkbox to show for Oracle tables
Improved DDL Import and DDL script generation.
Namespace Declaration fix for VBNet,
Generation options Dialog fix when using Japanese version of EA
Remove Comment style from VBNet Generation options,
Add advanced checkbox & supporting code to Template Editor ("Namespace *" "Class Base" "Class Interface" "Import Section" moved to advanced),
Template edits (added warning comments to advanced templates),
Fixed problem with Virtual Inherited parents not showing in 'Inherits' section of class caption when appropriate
Added some checks on Version Control before allowing changes to configuration
Tightened up some security items related to version control
Fixed C++ Rev Eng : Incorrectly parsed complex template-based attributes eg. vector< const TestType& > listConst
Modified Actor to allow use of Rectangle notation from Actor context menu - rather than from a single stereotype (<<system>>) as previosuly


Changes and Fixes in Version 3.60 - build 639
*********************************************

Added Configure Version Control and Use Version control permission types to Security Model in Coporate version of EA
Modified Apply Pattern function to allow setting both Rename and Link check boxes - and have EA only apply one
Modified apply pattern function to prevent doubling up of applied operations in some cases
Ctrl+Up and Ctrl+Down shortcut keys added to Project Browser (move elements up and down)
Fixed context menu on element properties dialog - Link page to be non-modal
Sub-Activities now handled correctly in XMI import/export
Fixed error in stereotype dialog which only allowed a stereotype for one base type instead of many
Fixed element search dialog to handle particular Japanese character(s) that were causing SQL errors.
Added a new check to Integrity dialog to update Foreign Key definitions to new mode in EA 3,60
Added 'Advanced' check box to Code Templates dialog to show all templates
Some minor fixes in VB.Net code generation and templates
Some additional code template macros for handling Parameterized and Instantiated classes



Changes and Fixes in Version 3.60 - build 638
*********************************************
Added ability to Save specially set-up diagrams as UML Profiles (see Help file)
Fixed issue with object font color set from Format Toolbar
Fixed error with multiple extension points being defned in Use Cases
Modified XMI importer to correct possible import error when importing a full model
Fixed problem with EA always opening maximized even with local option - Open Maximized -  unchecked
Fixed issue with use of refernce character when defining properties
Fixed issues with import of VB.Net nested classes
Fixed problem with multiple copies of operation pre- and post- conditions appearing in RTF documents


Changes and Fixes in Version 3.60 - build 637
*********************************************
Fixed problem of Local Paths dialog not saving paths
Fixed issue with saving scenarios and some reference types when regional settings use , (comma) as the decimal separator
Fixed issue with not being able to modify namespace root when Require User Lock to Edit enabled
Fixed error in MySQL when changing Locking Mode in Corporate version of EA
Fixed error in RTF output in Unicode version of EA - document could be corrupt when Scenarios included in output



Changes and Fixes in Version 3.60 - build 636
*********************************************
Fixed problem with useage of Apply/Release User lock in Corporate version of EA
Added Select Classifier dialog to Operations dialog for Return Type
Fixed problem with Operations Return Type combo losing contents after dialog canceled
Fixed problem with importing indexed properties in VB.Net


Changes and Fixes in Version 3.60 - build 635
*********************************************
User Interface Changes:
	Major changes to docked windows...
	Upgraded docking behavior - pull out and redock tabbed windows (eg. Notes docked window)
	Flexible docking algorithm allows a number of new docking methods
	Dock windows in a larger variety of places
	Autohide (slide away) enabled on all major docked windows
	Main menu reworked to include new functions and makes many features more accessible
	Addition of Element menu to handle Element functions on currently selected element
	Context menus for elements, diagram etc. reworked to limit complexity
	Toolbar added to docked property window	
	Added syntax highlighting source code editor as dockable window within EA
	Quick customization menu on toolbars (add/remove buttons)
	Improved graphical indication of version controlled and package controlled packages in browser
	Added scope icons to method and attribute nodes in browser
	Ability to display text below toolbar icons
	Keyboard accelerator map added to Help menu
	Added ability to save and load screen layouts (up to 5)
	Improved keyboard access to all windows. Ctrl+F4 hotkey to close current docked window
	Improved Hierarchy view to show more information
	Added ability to Select elements in a diagram by type (Edit menu)
	Improved Snap to Grid and Grid display function (now in View Menu)
	Made a selection of submenus 'tear off' - so they can be detached and docked like toolbars
	Clean up of many graphical elements within EA	

Code Generation Changes:
	Code generation templates for C#, C++, Delphi, Java, VB and VB.Net
	Ability to generate code for user languages using templates
	Inbuilt Source Code Editor with syntax highlighting
	Ability to synchronize and generate from the source editor
	Code template editor with syntax highlighting for template macros
	Extensive Code Template language for modifying all aspects of code generation
	Bug fixes and improvements to Parser

Version Control:
	Enabled SCC cmpatible version control
	Currently tested with Visual Source Safe and CVS (using Igloo). Generic support for SCC compliant providers
	Uses a local 'virtual repository' to store XMI text files from EA, which integrate with the SCC provider
	Project/Version Control menu option to configure. 
	Context menu option on package in Browser to use
	Improved XMI import/export for version control - relinking and control of cross package references
	Improved XMI export/import speed

Unicode Edition:
	A Unicode edition of EA is now available for users wishing to mix languages
	Unicode version enabled for WIn98/ME as well as NT, 2000 and XP
	
Database Engineering Changes:
	Added Dialog to streamline creation/editing of foreign keys.
	Added option to write a log file for Data Transfer errors and Remove Replication transfer errors.
	Specified a direction for the link between tables linked by a foreign key.
	Added foreign key details to table link.
	Fixed adding and removal of Foreign Key link.
	Fixed deleting foreign key operations when association deleted.
	Fixed DDL import of table default values from Oracle using Microsoft ODBC Oracle driver.
	Fixed missing header comments in DDL generation of Data Model package.
	Fixed sp_addextendedproperty DDL generation for SQL Server.
	Fixed syntax of drop table statement.
	Fixed creation of Primary Key operation where attribute allowed nulls.
	Fixed primary key in t_seclocks table in Oracle9i script.
	Fixed truncation of requirement type name.
	Fixed adding of extra columns to Primary Key.
	Fixed crash when saving operation on databases built with SQL Server 7 script.
	Fixed crash when cancelling data transfer.
	Reversed sort order of reference data types
	Display default DDL filename in file dialog when browsing to location to save DDL script.
	Warning against deleteing foreign key using Operations dialog.
	Additional fixes and updates

Document Generator:
	Added ability to create a 'Virtual Document' from s Class stereotyped as a <<Model Document>> (ie. 'Model Document' - case sensisitive)
	Drag packages from the Browser onto the virtual document to add packages as 'attributes'
	Sort the package order using the Attribute dialog
	Generate using the Element/Documentation dialog. EA will detect the <<document>> stereotype and generate the full document
	Added ability to generate RTF for a single element (Element/Documentation)

New Example Mode:
	A new example model is now distributed with the base EA application. This provides a more 'worked example' than the previous example	
	

Other:
	Modified function that applies a UML Pattern to the model. Provides ability to add pattern features to targets pattern is applied to
	Updated Help System. An extensive reworking, reformatting and tidy up of the Help system has been started. 
	Fixed problem with Message dialog when classifier of target had circular Realization graph
	Fixed display of Interface and Stereotyped elements in Sequence diagrams
	Elements retain selection status between generation and synchronization
	Imrpoved locking semantics and detection of locked elements when security is enabled
	Added function to export linked files in RTF as RTF Hyperlins
	Fixed some problems with Printing - especially a problem that caused a crash when page dialog accessed repeatedly
	Fixed some docked windows which were not being kept up to date when they were not visible.
	Default page size now set when EA first runs on a machine - detects Letter/A4 and printer resolution etc.
	Added a function to reset tagged values for intances of a class (to match the class tagged values)
	Modified Collaboration message arrows to match Sequence style
	Added ability to number collaboration messages in indented groups (eg. 1.1.2.1, 1.1.2.2 ... etc)
	Option to show sequence message numbers in Sequence diagram
	
	Numerous other bug fixes and tune-ups
 


Changes in Build 618
********************
Fixed problem introduced in 617 with Conditions and Constraints on Seqeunce messages not showing correctly
Fixed error in CSV import with delimeter specification not showing corectly in dialog
Added Collaboration diagrams to possible sub-activity types
Fixed problem with node elements having Tagged values causing drawing error when tag name wider than node body


Changes in Build 617
********************

Fixed problem with Nodes rendering Tagged Values twice when diagram dialog option to show tagged value compartment checked
Fixed error with C++ import of pointer variables (eg. A* pA;)
Added Sequence and State diagrams to those that appear as sub-activities in Activity diagrams
Fixed error with saving element Template Package in projects with replication enabled


Changes in Build 616
********************

Fixed error with import of source code directory when resolving generalizations. In some rare circumstances could cause an exception
Fixed error with import of Sequence diagrams from XMI causing intermittent problems with saving message positions in Sequence diagrams
Fixed error with Options dialog pages being offset to far to the left for uses using 'Large Fonts' in windows
Fixed C++ import error of typed operators : eg. TCHAR operator[] () ; 
Modified XMI exporter for Rose. Adding <<subsystem>> stereotype to a package will cause that model branch to be exported as a Component Model for Rose
Modified base .EAP file (EABase.EAP distributed with EA) to improve replication support.
Added 'compartment' support in diagrams for states and nodes.
Prevented EA prompting for 'Save' when exiting secure model with no user lock on current diagram
Modified order of word replacements in RTF language adjustment to prevent inadvertent overwrites
Improvements to DDL generation of:
	Column defaults, check constraints, 
	Table and column comments, 
	Referential integrity and check constraints,
Added option to select referential integrity constraints to table operations.
Added option to skip all rows of a table if an error occurs during data transfer of a model, and during removal of replication.
Fixed saving of association link names greater than 50 characters.
Fixed error on save of Local Options dialog when using .EAP files with replication enabled
Modified XMI export to write log file when requested
Fixed GUI ELements to show text even when stereotype not applied
Modified XMI importer to handle XMI 1.2 files where possible (some work still required)
Modified ECF and TCF dialogs to handle , as a decimal separator where regional settings are configured that way



Changes in Build 615
********************
Added support for picking up initializer lists in .CPP file and correctly re-synching the same on code generation
Fixed bug with pointer reference being reversed in C++ (*& becomes &*) 
Fixed bug in parser where many macros are defined in Refrence/Language Macros. Caused incorrect parsing of some tokens.
Fixed problem with output of Tagged Value notes in RTF
Fixed issue with import/synchronization of attributes delared as arrays eg. int x[100]; in C++
Added support for "volatile" keyword in Java and C++
Fixed issue with "unsigned long" data type in CPP imlpementation file paramter list
Added ability to define a system wide "Watermark" for diagrams when printed or output to image. See View/Options dialog - Diagram page
Fixed problem with Collaboration graphic element printing with solid border instead of dashed. Also cured similar problem when zoomed in on Collaboration
Added or improved support for ODBC import and DDL generation of:
	DB2, 
	Oracle,
	Interbase 6, 
	PostgreSQL, and 
	Sybase tables, 
	including index and foreign key constraints (where supported).
Added and modified existing Database Datatypes. See file ddl_datatypes.xml in EA install directory. Import using the Reference/Import Reference Datatypes dialog
Set index sort radio button to default to ascending in operation extended properties dialog.


Changes in Build 614
********************

Elements with parent names specified graphically now resize if name is longer than class name
Fixed error with UML:Diagram XMI being written out during export when Diagrams set to non-export
Added support for C# event keyword (field declaration and accessor) to C# parser. 
Added ability for ordinary user to 'View Current Locks' when security enabled. View Locks is a new Permission.
Fixed problem with Java parser misinterpreting default values of attributes when the default is a scoped name
Fixed error in automation interface which could cause Models collection to throw an exception
Changes to XSD Schema generator
	For complexTypes which contain an attributeGroup and are derived from
  	another complexType by extension or restriction, the attributeGroup is
  	placed within the extension element.
Duplicated objects now created with User Lock applied where 'Require User Lock to Edit' is enabled in security
Fixed problem in adding items to Glossary
Links page of Object Properties dialog now works with Locate Object when the target is a package type
Fixed some instances of case sensitive SQL which could cause issues on UNIX based version of MySQL
Added ability to define a default user diagram for corporate edition when security is enabled. 
	User may set any diagram to be their own default
	Function is available from the diagram context menu - when user security is turned on
Made 'New' button on Requirements page of Object Properties dialog always enabled - even when a linked requirement is selected



Changes in Build 613
********************
Added new diagram layout options:
	- Set from Diagram Dialog: see Set Layout button
	- Applies to current diagram only
	- Can be set as Project Default layout
	- Includes option to layout to left, right, up or down
	- Includes settings to control spacing and layout performance options
	- Also includes auto 'bending' of line links where possible to achieve a clean layout
Fixed 'Undo' of moved boundary where subelements are also moved
Fixed Undo of  diagram layout - Ctrl+Z will now reverse a layout
Added Connectors collection to Package element in Automation Interface	
Added TreePos property to Element in Automation interface
Fixed error in options dialog default value for wrap long comments option
Fixed spelling errors in Generate DDL dialog
Fixed C++ parser error when importing some inline functions from header file
Added Alias property to Package element in ActiveX interface
Fixed 'Locate Object' behavior in Implementation Report dialog
Fixed error with code generation progress dialog that could result in dialog been left open when a bad filename was encountered in output
Modified Instance State behavior to remove merged name when this option is unchecked and to not show [state] in instance graphically when name is merged
Changed 'hit test' on sequence elements to only include the 'head' of the element and 7 pixels either side of the lifeline. This is to improve element selection in sequence diagrams
Fixed error with arbitrary packages being opened when EA first loads a project (bug in 612 only)


Changes in Build 612
********************
Addition of support for using ORACLE 9i or greater as the repository for an EA project
	- Required scripts are located on Corporate resourse pages
	- Data transfer functions also modified to work with Oracle
Added check box to Set Instance State dialog to "Merge State with Instance Name" - will append [State] to instance name
Added menu option on Connector for Association Class link to automatically add the Association Class if it is not currently in the selected diagram
Fixed issue with RTF language substitution function - "Figure" was not being handled correctly
Added option (in View/Options Diagram page) to allow changing diagram created date. If checked, created date is editable on diagram dialog
Fixed problem with importing packages in XMI format to DBMS repositories. In some cases diagrams did not appear in Project Browser
Fixed problem with importing Delphi source code where class with many implemented interfaces could be imported without all interfaces
Fixed issue with Instance Classifier dialog not showing caption under certain circumstances
Fixed issue with Diagram Hyperlink not working when the default was not to generate pages for notes or text
Fixed duplication of mnemonic on Operations dialog (Const and Cancel)
Added option in RTF diagram to use 'Simple Names' for elements. This removes the scope and modifiers from the element name in the final document
Added option to add initializers to output source code in C++ implementation file. A tagged value of "initializer" will result in EA appending ":" + the initializer value to the source
Fixed autocounters for element task, issue, change etc.
Removed some autocounters in the list which were not relevant
Added drop list of 'owned states' to "Set Instance State" dialog. An owned state is one which appears under an element in the project browser
Modified local option 'Sequence message Vertical Gap" to now be saved on a per project basis - rather than a per person basis
Fixed error in generation of Package notes in RTF when using the <Basic> style 
Fixed problem with package Alias always being used in RTF output when set, and not when explicitly asked for only
Changes to the XSD Schema generator
	- Import elements are generated for each referenced package whose targetNamespace tagged value differs from the target package's targetNamespace.
	- Include elements are generated for each referenced package sharing the targetPackage's namespace.
	- Added "schemaLocation" as a tagged value for the XSDschema stereotype.  It is generated in the include and import elements.
	- TargetNamespace prefix gets included in the schema element, if targetNamespacePrefix tagged value is specified for an XSDschema package.
	- The Encoding value in the processing instruction is omitted if the encoding field in the GenXSD dialogue is empty.
	- TargetNamespace prefixes are used in ref elements for external types.
Fixed problem when generating VB6 source - class specific Advanced Options were being overridden by the global equivalents at run time
Added automation method to GetCurrentDiagram() from the open model
Added ability to hide or show 'Package' scoped features in a diagram to the Diagram Dialog
Fixed error in picking up project default language when showing the Import Source Directory dialog
Moving a Collaboration message now marks the current diagram as dirty
Fixed error with RTF Report dialog when saving template with all options and filters set. Length of opetions style string was too long.
Added ability to mark a collaboration message as 'Return' and have it show with 'dashed' line appearance
Length of Collaboration 'tails' increased and some small adjustments made to position of associated text
Changing a text font will now mark diagram as dirty
From search dialog, Locate Related Element in Browser now works for Package as well as other elements
Added Automation method to Repository to GetConnectorByID(long ConnectorID)
Added 'Apply' button to Diagram Properties dialog
Fixed problem with data transfer between MySQL and SQL Server (NULL able columns)
Fixed problem with Association Class - link to association was not draw if Association Class was off screen - but association was on screen



Changes in Build 611
********************

Fixed bug in EA running under Windows 2000 that could result in program termination when adding a new Project Root node
Fixed problem with UML Patterns when adding sequence objects and messages to an existing diagram - could result in duplicate messages being created
Fixed problem with Classifier dialog not showing correct classifiers for some intance types
Added option to View/Options/Diagram/Behaviour dialog to turn off Automatic Sub-Activities from dropped diagrams
Fixed issue with new Sub-Activities created from dropped diagrams not appearing in Project Browser until a reload occurred
Fixed issue with import of XMI - attribute and element contraints could cause an error if constraint type was not set in XML file
Modified export of 'position'tagged value in XMI 1.0 for attributes - used tag name ea_position instead to avoid conflict with XSD position tagged value
Modified RTF generator to sort connectors by connector type first, thereby grouping like connectors
Modified RTF generator to fix issue with line breaks in Test notes
Fixed issue with glossary dialog not warning if pending changes exist when moving between records or closing the dialog



Changes in Build 610
********************
Automation interface re-written to support both IDispatch and Type Library access to automation objects. 
	- TypeLibrary automatically registered on install of EA (Enterprise Architect Object Library 2.0)
	- Automation error handling improved to provide simpler and more convenient error messages
	- Intellisense for EA object model now supported thru type library reference
	- Code samples added to EA install directory (Sample Code)
	- AutomationInterface.PDF updated
	- Automation Interface ReadMe.PDF added to Program Group ... highlights recent changes
Added new behaviour on Ctrl+Drag of element from Project Browser to diagram. Source element may be dropped as Link, as Instance and as new Child (generalizes)
Added new options to UML Pattern function (from diagram 'Save as UML Pattern' option)
	- Option to link an object to an existing classifier at pattern instantiation time
	- Option to replace a pattern element with an existing model element of the same type at pattern instantiation time
3 more Properties added to the Connector automation element:
	- TransitionEvent
	- TransitionGuard
	- TransitionAction
Added an option to the HTML Generation dialog to optionally not generate separate pages for notes and text elements
Modifed Attributes and Operations dialogs pages - improved keyboard navigation and added additional mnemonics for each field
Modified Project Browser so that F9 and F10 shortcut keys to Attributes and Operations now work correctly in tree
Updated EA installer to new version. Added code samples directory to install and included registration of type library as part of install
Added support for SubActivity State. 
	- Dragging an Activity Diagram from the Project Browser onto an Activity diagram will create a SubActivity State node 
	- The SubActivity node will behave in the same fashion as a Diagram Hyperlink - ie. double click to go to target diagram			
Added ability to bookmark results in Search Dialog (places a red triangle above bookmarked elements in diagrams)


Changes in Build 609
********************
Added support for showing element and feature stereotypes in Project Browser (option is on View/Options dialog first page)
Made a number of modifications to the source code importer (including): 
	Improved support for importing hundreds or thousands of files in the same directory.
	Improved support for synchronising existing classes - rather than re-importing
Added support for 'default element templates' :
	Use the Project Main Menu - "Set Element Template Package" option to cofigure or change the template directory
	Place elements you wish to be the default templates for new elements in the package
	Configure the template size, appearance, notes, version etc.
	Add new elements from the toolbox - EA will check the templates directory first and if a template is found, will copy from there
Improved handling of drag and drop from the Project Browser:
	Cursor reverted to default explorer arrow
	When moving in tree, drag source is gived 'cut' appearance to indicate possibility of moving element within model
	When cursor is moved outside tree and over diagram, drag source is focused and drawn normal - inidcating it will be added to the current diagram
Added "Cancel Import/Generation" button to batch source import/generate dialog
Fixed problem with CreateProperty dialog. In some cases could revert to default language instead of element language.
Added display of table column number, scale and precision to HTML output
Fixed problem with XMI import/export and package scope of AssociationEnd's
Prevented EA from overwriting custom parameters in sequence messages when the underlying method was updated
Added support for Object State (context menu option on object element) allows setting of a single state for a class instance
Made the Matrix cells uneditable if user does not have permission to edit source and target objects
Fixed issue with applying user locks and element locks in tree. Lock applied immediately now.
Packages created in tree are created with user permissions
When moving a Boundary element, all contained custom line points for contained elements will be moved as well as the contained elements
Fixed error with newly created elements being moved between packages.
Added option to diagram dialog to suppress qualifiers (scope markers +-#~ etc) in a diagram
Fixed problem with report view of diagram scrolling to top after each edit
Made docked property window display object properties when selected in diagram Report View, and reflect changes to both
Added Methods and Interfaces to the list of replaceable word in RTF language customization
Dotted namespaces in C# and VB.Net now imported correctly
Fixed problem with import of VB.Net interfaces when each realised interface listed on a separate line
Added option (in Viuew/Options dialog) to have 'free sorting' of elements in project tree - so that element type is ignored
Collaboration diagram type added to context menu in project browser where appropriate
Fixed font dialog of Diagram Link element - not picking up underline correctly
Modified DataTypes dialog so that a product could be deleted when the last datatype it supported was deleted
Association-Class now suppressed in RTF when you suppress the Class type for the document
Fixed problem in CSV import - elements not appearing in import package when no current diagram is open
Changed text item minimum size to be 16x16 - the same as an icon with no text
Changed diagram link type so that element can have no text but background will still not show if it has iconic form
Ensured EA prompts to save any changes before changing projects
Fixed problem with setting link label alignment
Fixed error with getting default code generation language when flipping between projects which have different defaults
Changed EA default behavior to stop force loading of Association Classes in diagrams. Now the Association Class may be suppressed if desired
Added support for deleting multiple test cases in the Test Casew list in one action
Modified Java code generation - stopped writing out name of Namespace Root  where class resided in that namespace (ie. a global class)


Changes in Build 608
********************
Added 'Autosize Element' context menu option to single selected element
Fixed problme in Java generation of extends clause
Added notes section of linked requirement to RTF output - similar to notes for internal requirements
Prevented notes being modified and content lost when element is locked
Fixed cursor problem when connector type and then element type selected in toolbox - correct cursor shape now shown
Modified parameter type combo to mark record as dirty when type modified using arrow keys only
Checked size of run-state information when drawing elements and ensure element is wide enough to contain text
Fixed problem when adding additional Project Root nodes - sort order was reset to alphabetic instead of user configurable
Fixed problem where the 'constraint' field on a sequence message was not being written out to XMI
Fixed problem with print outs where Scale Image to One Page was selected. Often the font was being overly reduced.
Fixed display erro with Operation behaviour in class diagrams - behaviour notes now displayed correctly wrapped and next operation moved down a suitable amount
Fixed problem with NewElement Dialog (from Package contrext menu) being set invisible in some situations
Changed Diagram Hyperlink element so that it may have no text and the bounding box does not show - only the link icon
Changed wording of connector type in Connector dialog - now drop list contain Auto Routing as the second option instead of Routed
Schema generator modified:
	* EA now generates a complexType wrapper for attributes which are generated as elements and have a non-simple type.
    	* The default model group is now "sequence", instead of "all" 



Changes in Build 607
********************
Addition of XML Schema generation to Professional and Corporate versions of EA
	- Provides ability to generate complex XSD schema from UML models 
	- Use in conjunction with the XSD Profile that can be imported into EA
	- Also added XSD Datatypes XMI package for use with XSD generator
	- see: www.sparxsystems.com.au/xml_schema_generation.htm

Changed docked Property Grid component		
Fixed bug in Auto-counters for new diagrams which sometimes displayed wrong counter
Fixed bug that resulted in prompt to save modified diagram after diagram had already been deleted
Added option to View/Options/XML Specifications dialog to toggle timestamps in XMI on or off. This is useful when you wish to ensure two exports from a controlled package create identical files when there are no model changes
Fixed problem with Open Project menu and toolbar items not working after application application has lost and regained focus
Fixed code import (C++) error in eg. Func1(Foo<Msg&> prm1); The & was being lost.
Modified diagram 'Deep Copy' function such that a new CreateDate is created on copy
Fixed error with Components which could result in elements with a long (wrapped?) being drawn too large
Limited length of Requirement short description to 254 characters
Added ability to add RunState to Node Instances
New Packages created under User Lock will inherit the lock state
Added option to not generate/reverse code notes and comments
	- Added two check boxes to the View/Options/Code Generation dialog page. They are in a section called comments:
	1. Generate: default = true. Uncheck this to not generate any notes in code
	2. Reverse: default = true. Uncheck this to not pull in any notes from 	code.		

C++ generator now uses initial value of attribute in enum definitions
Fixed error where pressing ESC in docked Notes window could cause notes window to de-activate
Fixed problem in C# parser which could result when certain combination of commented out { and } characters occurred
Added current EA.tlb (type library) for those wishing to register EA automation interface in tools with Intellisense etc.
Fixed error in XMI generation where EA duplicated diagram notes in tagged value.
Fixed problem in Java parser - not importing multiply inherited interfaces
Added ability for Node to display attributes and operations - and for Node features to be exported to XMI
Added 'Sort Axes' method to Matrix Options menu. When disable, axes are displayed in package order, recursively ... rather than alphabetically


Changes in Build 606
********************
Modified ODBC import to correctly capture 'Currency' type in MS JET databases
Multiple changes to the XMI import facility when importing UML 1.3/XMI 1.1 from the Rose Unisys toolset
	-Improved diagram import and layout
	-Handles notes and notelinks better
	-Some changes to display of rrot/leaf indicators
	-Default cardinality changed to clarify diagrams
	-Notelinks to connectors 
	-Association Classes

Improved print preview and printing to better match printed output with screen output (font sizing problem)
Fixed problem with import from SQL Server to .EAP format of binary data (metafiles,images)
Fixed problem with default code language in View/Options dialog not always being saved
Added option in View/Options Code Generation to toggle auto diagram layout on and off when importing
Fixed error when closinf one model and opening another with pending changes and security enabled
Added ability for EA to autogenerate Foreign Key operations when using datamodeling capabiliuty:
	1. You create parent and child tables as normal
	2. Create attribute (columns) in both
	3. Set a target attribute to be the PK or <<unique>>
	4. Create an Association from the child to the parent
	5. Set the target role to the required PK (will be in drop list)
	6. Set the source role to a column name in the Source Role (will be in drop
	list)
	7. Press OK
	
	EA will generate the new <<FK>> operation automatically and convert the
	Source Role name to the generated <<FK>> name. I think this makes things a
	lot simpler as both the FK and PK operations are now being automatically
	generated from the column name. 
	
Fixed problem when reversing interface operations from C# code
Added ability to move in Attribute and Operations lists with arrow keys
Fixed bug in Issues dialog when modifying an existing item, a duplicate record could be created




Changes in Build 605
********************
Modified Operations and Attribute dialog to mark dirty when information pasted into notes field
Added Connector detail Heading and Row RTF to the RTF Style templates
Added a number of additional words to the 'Adjust Language' function in the RTF Documentation dialog
Fixed issue with saving comments in VB.NET where a ' was embedded in the text
XML Export option setting in View/Options dialog to make not exporting diagram details in XMI the default
Fixed issue with XMI export/import that could result in missing package in rare circumstances
Modified XMI 1.0 importer to better handle import of Model and Subsystem packages
Source and Target Role names added to RTF report on Connector Detail
Added Association start and end tagged values to XMI export using EA/XMI 1.1 style.
Fixed problem in Glossary dialog when using MySQL
Fixed problem in MySQL when invoking "convert linked element to local copy"
Fixed issue where imported property names in VB.Net always used "m_"<name>, and not option configured in View/Options Attributes/Operations
Fixed issue with Actor element causing problem when Attribute dialog invoked
Updated name wrapping routine to handle class names with embedded spaces
Updated Create New Project dialog to avoid resetting model filename after setting new filename
Stereotype dialog now re-sorts list on reload when a custom sort is in place
Modified code import to better handle use of Realization link to interfaces
Modified security subsystem to prevent one user viewing/altering another user's 'user locks'
Added "Exclude from RTF" option on Diagram Options Dialog to selectivey not show a diagram in and RTF export
Fixed problem that could result in sequence messages being re-wrapped to more than one line in Print Preview mode


Changes in Build 604
********************
Fixed problem in label sizing code that resulted in diagram being set dirty after opening
Fixed problem in label sizing code that could result in distortion of containing rectangle after zooming
Added ability to reset code type for elements in Package Code Gen update dialog to <none>
Modified default auto-tidy gap in options from 25 to 12 to allow finer control of custom lines in default mode
Modified drawing code to calculate bounding rectangle better where connector labels extended beyond bounds of objects and connectors


Changes in Build 603
********************
Fixed error in C# parser that could occur where unmatched strings in summary comments occurred
Fixed error in removal of classifier from Boundary still showing name of previous classifier
Modifed drawing code in sequence diagrams to underline full name of instances
Modified drawing code to force resize of connection labels to best fit of text
Modified C++ parser to correct problem with importing file with complex template definitions
Modified Delphi parser to correct problem with handling of quoted strings in certain comments
Fixed problem with EA on SQL Server when running test report and selecting "Passed, Failed, or Not Run"  option
Included attribute tag notes in RTF documentation
Added new interface to EA.Repository object "OpenFile2(Variant Filename, Variant Username, Variant Password)" - use to open a password protected model from automation
Fixed issue with handling of .EMF files which have been saved with .WMF extension



Changes in Build 602
********************
Fixed problem with drop menus for code gen and RTF reports in Workspace toolbar not being always enabled
Fixed problem with label on generic input dialog box being empty in some cases
Added support in Delphi for reintroduce keyword
Fixed problem with Association Class connector not being displayed after class edit
Added 'Stop' cutton to spell check dialog to allow cancel of spell check during execution
Fixed loss of open project name in caption bar after print preview
Added View menu option for animated menus - None, Slide, Unfold or Fade
Added XP style 'faded icons' for toolbars and menus
Fixed bug in Search dialog that caused problem when no search type was defined
Task dialog, percent complete 'spinner' direction reversed to Windows standard
New UseCase diagram from context menu was defaulting to Class in dialog - fixed
Using keys to manually resize an element now marks diagram as dirty
AssignedTo: field in Tas Detail dialog now correctly includes drop list of project resources/authors
Fixed problem with Zicom Mentor Add-In registration menu item (in Help) not always being avaiable in Desktop version of EA
Modified drawing code to correct slight increase in vertical gap between operations and attributes introduced in build 589
Modified C++ parser to prefer CPP comments for operations over .H ones if C++ options "Comments in Header" unchecked


Changes in Build 601
********************

Fixed bug with project workspace button on workspace views toolbar
Fixed error that prevented cancelling a database compact
Added delete constraint and delete requirements from docked properties window using "Delete" key
Modified RTF to better format Attribute constraints
Attribute constraints now use drop list defined in Reference/Types/Constraint Types
Add check box on diagram dialog to hide element stereotype names in current diagram
Fixed bug that caused model upgraded directly from 3.10 to 3.51 being marked as too recent for version 3.51
Fixed problem with label editing that caused difficulty on Right mouse click
Scenario Type dialog - details edit box now wraps multiline text
Fixed bug in Print Preview that renamed EA caption window to -EA (missing current project name)
Fixed bug with changing user login name - EA previously ignored changes
Fixed problem that could occur when security menu item accessed - but no model open
SQL Server now prompts for password when opening model if no password in connect string and login fails
Matrix profiles now accept names > 12 characters 



Changes in Build 600 (Release 3.51)
***********************************

Main UML toolbox modified to be dockable
Main UML toolbox folders and contents modified to better reflect UML naming conventions and process
Addition of context menu submenu on dependency added to support easy selection of dependency stereotypes
Ability to "click, place and drop" elements from the new toolbox (as well as drag and place as usual)
Addition of ability to select an object in docked property window/relations page and place on current diagram (context menu option)
Addition of ability to 'pin' start and end points on a connector line between elements (connector context menu option)
Editable tree labels
Active objects support. Objects which have an Active Class as their classifier now are draw with thick borders
Concurrent messages in sequence diagram. Allow setting of messages at same height to inidcate concurrency
User tools menu. Allows addition of custom user tools - supports additional paramters for current diagram, element and package
Customizable toolbars. Includes ability to place main menu items onto toolbars - including submenus as toolbar drop menu button
Open project dialog set to foreground on open - and EA application workspace loaded before open dialog shows
Additional detail in connector documentation (RTF) for connector source role and connector end role
Fixed some issues with case-sensitive tablenames in MySQL
Addition of 'Scenario' tab to docked properties window. Support quick addition and editing of element scenarios
Element position (x,y co-ordinates) missing in locked diagrams. Fixed.
Addition of extra complexity types (Extreme and Unknown) which can be activated in the View Options dialog. Affects Use Case estimation
Allow open project to be compacted using the Admin/Compact Project facility. Current project suggested by default
Additional menu icons
Additional Toolbar for turning on/off dockable windows such as project browser, properties, tests etc. 
Changed a few 'Cancel' buttons to read 'Close' where meaning was confusing
Collaboration messages now drawn with arrow stem as well as arrow head. Also, arrow head now treated as 'hit point' when selecting message.
Plus other minor bug fixes


Changes in Build 589
********************
Added CSV import/export capability for elements (basic properties only)
	- Set CSV Specifications in Project/CSV Specification
	- Import/Export from/to CSV on project browser, package right click menu - Import&Export/CSV Import-Export
	- Use GUID field to export / modify element in CSV file /  re-import and update exisiting classes (round trip with other tools)
	

Modified diagram layout and autosize routines to avoid problem of overlapping elements in large diagrams
Modified DiagramLayout function in automation interface to avoid overlapping elements
Modified UML Pattern function to ensure all pasted elements appear in project tree immediately (reload not required)
Modified 'Drop From Tree' function forSsequence diagrams, so that pasted elements appear where dropped, not in the leftmost position
Fixed bug which prevented Sceanrio notes being updated from the automation interface (Scenario object)
Modified RTF Style function to correctly include customized "Basic Style" when available and selected
Added underlining to Node and Component instance names
Modified Tagged Value drop list in Object, Attribute and Operation dialogs to allow scrolling of Value content
Modified Column Name edit box in Attribute dialog for tables to allow names up to 255
Added check when creating Generalization to take IsRoot and IsLeaf attributes into account 
Added support for Windows XP Themes. EA dialogs etc. now adopt theme specified in Windows XP Appearance dialog. (XP only)	



Changes in Build 588
********************
Modifed C# parser to handle @ symbol when used as a indicator of a literal string (ignore escaped characters sequences)
Fixed problem that could cause exception on closing EA when project browser was undocked
Check for dirty attribute data before changing current record in Attribute dialog
Modified generation of 'legacy' style bookmarks for RTF documents. 
Modified the way connectors are joined to Decision nodes - now the four points of the Decision are considered the only legal abchor points
Modified behaviour of Ctrl+Del key in diagram - now performs delete selected object(s) from diagram instead of deep delete of selected item in tree
Model Issues, Model Glossary and Model Tasks docked lists now support multiple delete of all currently selected items
Ctrl+Del in Model Issues, Model Tasks and Glossary lists now acts as shortcut to Delete selected item(s)
Modified handling of function parameter types declared as pointers eg. "double *" & "double*" 
Added ability to drag a top level view from one Project Root Folder to another Project Root Folder
Added 'Version' as an updatable option in the 'Update Package Status Dialog' available from the Project Tree context menu on a package
Fixed problem that occurred with display of attributes when View/Options/Diagram/'Zoom to Best Scale' options was unchecked.
Added check for modified element notes on exit and perform save if required
Added File/Save Menu option to be consistent with Windows UI guidelines. Function saves current diagram
Added Element Issues and Element To Do list to the docked Maintenance bar for a single element
Modified RTF document generator to include check boxes for new element issues and element to do lists
Modified key stroke handler to exclude some keystrokes from those that cause a record to become 'dirty' (eg. Alt-S)




Changes in Build 587
********************
Added 'Apply' button to standard element properties dialog
Modified View/Options/CodeGeneration dialog to support user defined language types
Fixed bug in VB.Net parser that caused multiple interfaces in a file to be read as single interface.
Fixed bug in Shallow Copy of diagram that could cause multiple instances of an association
Added integrity check for connectors associated with specific diagrams - eg. Sequence messages
Added fix for Shallow copy of sequence diagrams where messages could be duplicated under certain circumstances
Some improvements to import of XMI elements from XMI 1.0
Fixed problem in RTF document generation that could prevent details of package being displayed when 'Document Packages' ticked
Fixed problem with drop list for tagged values in Object Properties dialog


Changes in Build 586
********************
Modified way method behaviour was returned in the automation interface to cope with very large strings
Fixed bug in properties dialog of some objects which could cause a DAO error on open


Changes in Build 585
********************
Fixed bug in RTF generator that caused child elements of another element to not document correctly
Modified code generator and parser to better handle directed associations and aggregations when generating and synchronizing code
Fix for automation interface that resulted in error when refreshing newly created package
Added method to automation Project interface - BOOL LayoutDiagram(VARIANT DiagramGUID, LONG Style) - allows layout of diagram from automation
Added Stereotype field to Source and Target role tab pages of Association link
Modified UML Profile to populate Association End Role Stereotype when Appropriate
Modified XMI 1.0 generator-parser to handle association end role stereotypes
Modified C# code generator to create C# Attributes when set as a tagged value of Attribute for the UML attribute or UML operation
Modified copy diagram routines to:
	1. Copy swimlanes on shallow and deep copy
	2. Copy and resolve links between owned elements (eg. notes) and linked elements (eg. classes) when doing a shallow copy
Modified routine to save Scenario text. Presence of a '|' character could cause and error in MySQL
Added 'Select Classifier Type' button on Attribute dialog to allow finer selection of attribute type than supported in drop list
Added check box to Batch XMI Import dialog to prevent import from files that have the same file date as the previous import
Modified Controlled package dialog to support "Generic XMI 1.0" as an export format type (generally should only be used for export to other tools)

	 

Changes in Build 584
********************
Modified behaviour of code generator to take into account association direction when generating member variables
Modified C# parser to handle 'attributed' public variables in C# structs
Added option to View/Options/CodeGeneration - "Do not generate members where association direction is 'Unspecififed'" - false by default
Modified XMI 1.0 generator to place AssociationEnd Tags in global tag area instead of under AssociationEnd. EA will still read in both positions
Several modifications to XMI 1.0 import/export. Mainly concerned with Packages, Dependencies and tagged values.
Modified call made when clicking on Hyperlink and making other OS calls in EA - calls Default handler instead of default 'open' command.
Modified JDoc parser to include last character in comment - sometimes dropped.
Added routine to auto-name new elements with a numeric suffix to ensure unique names at creation time. Applies to all element types.
Added funtion to import .NET .XML library file. Accessible from right click on package in Project Browser - under Code Generation sub menu


Changes in Build 583
********************
Modified Collection Class source code generation from association end roles
Added Tagged Value support to Association and Aggregation Source and Target Roles, including XMI 1.0 and 1.1 import/export support


Changes in Build 582
********************
Changes to XMI 1.0 importer/exporter
Modified SQL Server date formatting for languages other than english
Modified Relationship Matrix: added TestCase as an option - differentiated UseCase and TestCase
Modified Relationship Matrix: added classifier name for instance variables
Modified way collection classes are used on association roles with multiplicity > 1
	1. Project level settings for each language in View/Options for each language
	2. Class level setting on Class Detail page of class property dialog
	3. Association level setting on Role page of link dialog 
	For level one and two, you can set a default collection class, a class to use
	when the multiplicity is ordered and one to use when it is qualified.
	When generating code, the precedence is 3,2,1 
	Search the help file for "Collection Classes" for more information

Modified the docked property 'requirements and constraints' property page - now allows adding, modifying and deleting of requirements and constraints directly from the context menu
Modified HTML generator to produce hyperlinks to cross referenced model elements
Added 'Is Linked From' section in Docked Property dialog 'Hierarchy' view
Added option to diagram dialog to suppress attribute compartment on a per diagram basis
Added option to diagram dialog to suppress operation compartment on a per diagram basis
Added option to diagram dialog to suppress stereotype name on attributes and operations on a per diagram basis	
Added global option to View/Options/Diagram to suppress constraints on Association links



Changes in Build 581
********************
Fixed problem with toggling line point on custom line with connector lines at some angles
Fixed problem when dragging element from tree onto diagram with modified connector positions, state. Connector state now retained after drop operation
Modified handling of dates in SQL Server for some non-English formats
Modifed deletion of connectors in SQL Server ... problem with association classes in some instances.
Fixed problem with generation of collaboration message documentation when using MySQL
Fixed problem with line continuation characters in VB parameter lists
Added support for indexers to C# code parser and generator
Added support for operator overloading to C# code parser and generator
Added support for 'dotted' method names in C# 
Fixed problem with color toolbar 'style drop list' not working correctly
Fixed problem with backspace and \ key not navigating thru 'locked' diagrams
Fixed problem where note and text elements could show & as _ 
Added check before locking diagram .. if diagram is 'dirty' message box pops up with chance to save or cancel before locking


Changes in Build 580
********************
Added support for TestCases in HTML and RTF documentation
Added support for Resource allocation in HTML and RTF documentation
Added support for element changes and defects in HTML report
Fixed bug in XMI 1.0 importer ... not picking up multiplicity
Fixed bug in XMI 1.0 importer ... not picking up nested classes
Fixed bug in auto counter for test scenarios
Added * indicator on Not Null table columns in diagram view
Fixed error when doing data transfer from MySQL to another destination (EA reports version conflict)



Changes in Build 579
********************
Added support for VB.Net 'Attributes' 
Added function to conver a linked class (from another package) into a local copy (linked class context menu). Any connectors in curent diagram will be assigned to new copy.
Fixed bug in assigning Default Database using View/Options dialog
Modified copy diagram function to provide improved handling of messages in sequence diagrams when 'shallow copying'
Fixed bug that could cause Speller to display evaluation message
Modifed the way RTF bookmarks are generated and handled. Copy RTF Bookmark to clipboard funciotn (context menu in browser) now returns correct bookmark string.
Added "List Header" to the list of customizable RTF style (Resource Tab/Templates/RTF Style Templates)
Fixed bug in selection of inbuilt RTF <Basic> style when generating RTF reports
Some modifications to the Undo function when editing diagrams
Modified 'Set Aggregation Strength' to be right click menu option on aggregation link (instead of dialog)
Fixed bug in deleting diagrams using Automation Interface
Modified XMI 1.0 importer to handle attribute classifier types correctly
Modified diagram zoom in and zoom out functions to provide a more consistent scaling effect of text and element details
Modified drag/drop handler for diagrams when droppig from tree to correctly place elements at large zoom levels and scroll offsets
Modified diagram drawing code to prevent packages becoming distorted in size after zooming out to very high levels
Modified snap to grid function to account for new zoom functions



Changes in Build 578
********************
Ability to disconnect an association class into association and class
Ability to import Constraints and Requirements and Scenarios into all Test Types for an element
Fixed bug when dropping requirement from tree onto another element, when diagram scrolled down or right
Added support for TestCase Icon (use case with black cross drawn internally)
Modified XMI importer to handle some specific data type import issues
Added support for batch XMI import
Added second Security Mode - 'Require User Lock to Edit' (see Admin/Security menu) - marks all elements as readonly until a lock acquired
Modified security to prevent applying package locks on top of exisiting locks
Modified security to prevent deletion of model elements from browser if locked by another user or group



Changes in Build 577
********************
Fixed bug in Desktop version that could cause exception when upgrading project file
Modified Aggregation to show Multiplicity values
FIxed error that prevented use of the File/Save As function in some situations


Changes in Build 576
********************
Added "ClassifierID" property to Element interface for automation
Modified sequence diagrams to include 'Continue Activation' feature (right click menu on Sequence message)
Modified sequence diagrams to include 'Stop Activation' feature (right click menu on Sequence message) terminates Forced Activation above
Modified VB.Net parser to handle Events with default scope in Interfaces especially). Same for Properties.
Modified Sequence diagram to allow messages from object after receiving delete message and before terminating X
Added dialog to allow setting of locks on package elements and diagrams - right click package in Browser
Check to ensure RTF - Save as Document feature returns an error if no RTF Template set up in RTF DOcument dialog
Fixed bug in VB Parser - missing parameters if ByRef or ByVal keyword used on some parameters
Hierarchy view modified to put association link in separate node (Is Linked To)
Added ability to update stereotyped elements with tagged values and constraints from asociated UML Profile item 
Fixed bug in UML PRofile function that didnt insert Constraints when Constraint type not specified in Porifle XML (made Invariant the default)
Added list of shortcut keys to Help file
Disabled ability to resize Test Dialog access from the docked Test toolbar
Added Object FIles to the list of related elements searched in Search Dialog when 'Scenario, Tags etc. ticked (does not apply to MySQL)
Where user ticks 'Remember ID in Login dialog, focus automatically set to password when Login dialog opens
Fixed error in Manage User Locks dialog that prvented limiting list display to only User or only Group locks working correctly
Modified default behaviour of Element toolbar to use 3D shadow colour for background instead of a specific colour
Modified Code Engineering "Import Source Directory" 
	- checking for duplicate classes improved (check done on package not diagram content)
	- ability to import source directory without generating diagrams improved
	- Local path replacements now update Package "Code Generation" path as well as object's 
Added support for UML Qualifiers graphically displayed as rectangle attached to one side of class or object. 
	- Qualifiers are set in the Associaiton source and target role dialogs
	- Qualifier rectangles may be suppressed for those wishing to continue using the current text based Qualifiers (see View/Options/Diagram)
	- Qualifers mays be highlighted with some shading (see View/Options/Diagram)
Fixed bugs in Associaton Class handling - Association class itself may now appear in other diagrams without the Association link
Fixed bug in drawing of connector end that had Aggreagtion diamond and arrowhead - arrowhead and diamond are now draw one after the other - instead of on top of each other
		

Changes in Build 575
********************

Parser modified to handle identifiers with extended characters (diacritical marks etc)
Installation modified to fix problem with registration of DAO350.DLL in some instances
Some minor changes to allow EA to 'degrade gracefully' if DAO library missing on start up


General Changes for Version 3.50
********************************
Introduction of new Corporate Edition of EA - provides extended functionality
XP Look and Feel
Ability to connect to MySQL and SQL Server DBMS systems (Corporate Version)
User security (Corporate Version)
Data transfer capability
Data compare dialog
Project health dialog
UML Pattern support
Upgrade license key dialog
Ability to set defaut phase and version for new objects
Changes to C# and VB.Net code generator
New Link toolbar
New toolbar on Project workspace
Ability to lock at user and group level (Corporate Version)
Ability to move notes and text as a group in sequence diagrams
Update sequence messages when associated operation signature changes
Added ability to run HTML report from ActiveX IProject interface
Fixed bug in HTML gen ... if .html was chosen as extension, a couple of links were brkoen in non-MSIE browsers
Diagram option to disable use of scoped object names in all diagrams
Modified HTML Gen to include Classifier name and hyperlink in object title if classifier is contained in HTML export
Several changes to RTF document generator
Z-Ordering elements now marks as dirty
Added Sequence object type to project browser
Added Batch XMI Export capability
Fixed bug generating read only properties in VB.Net and Delphi
Fixed bug in C++ parser, incorrect handling of some comments after Macro definitions
Fixed bug in C++ code generator - applied struct keyword to variables in struct
Added Override Operations dialog to allow easy implementing of parent Interfaces and Operations
Modifed JDOcParser to include markup in parameter and other JDoc tagged items (previously being deleted on import)
Realisation links now imported as such - not as Generalization links
Attribute type now optional
Additional fields in Model Tasks and Model Issues tables
Added Print List capability to System Tasks, Issues and Glossary
Fixed bug in Operations dialog that caused exception when Cancel pressed from Sequence message dialog
Added save XMI interface to Automation interface


Build 573
*********
Added ability to Locate Object Classifier in Browser from element context menu
Made several important lists sortable by column (eg. Classifiers, element tags, element files, element links)
Fixed title of Lite version (previously read 30 Day Trial Version)
Added 'Upgrade License Key' facility to allow Desktop and Professional licenses to be upgraded


Builds 568-572
**************
Some minor changes to data transfer and data integrity functions
Change to allow MySQL to handle upload of previously replicated .EAP files
Modifications to C# and VB.Net code generation to handle overriden methods
Modified Import source files dialog to select all available files by default
Small changes to help file 


Build 567
*********
Fixed bug that could cause EA to use 100% CPU when adding new message to sequence diagram
Modified HTML report generator to replace < and > characters with &lt and &gt in object,diagram,attribute and method notes


Build 566
*********
Added support for additional language dictionaries ... 
	Use Admin/Set Spellcheck language. 
	Requires download of additional dictionaries from Sparx Systems Registered User area.
Fixed missing menu items and disabled items in Desktop version
Modified several dialogs whch reported 'Pending changes exist" when none did


Build 565
*********
Fixed bug with anonymous enums causing repeated import for C++
Patched various spots in EA that could cause a problem when no model file is open
Added in support for Corporate Edition key and Lite Edition functionality 


Build 564
*********

Added simple password 'mangling' to security
Modified MySQL to fix error when notes and names contained [ or ] character
Modified SQL to handle 'and " characters in various element names and properties
Added Attribute Constraint details to HTML report
Added ability to show operation Behaviour in a diagram (indented under Method name) - see Operation/Behaviour dialog


Build 563
*********
Fixed bug that prevented realisation links being created on initial import of source directories
Fixed drawing problem with Actor instance name field being clipped in exported images
Node and Components dropped as instances from tree onto diagram now draw as Node or Component instead of object
Problem with last message on sequence diagram behaving erratically when moved fixed
Problem with comments in enumerations in VB.Net corrected
Import statements and Namespace declarations now imported into VB.Net and retained on generation
Modified text element such that left, centre and right aligning is possible (from context menu)
Modified Note element sych that double spaced lines are now possible.


Changes and fixes for EA 3.10 build 504
***************************************
Fixed bug in VB parser which faied to handle property methods with paramters having default values
Fixed height of interface markers in Component element
Added accelerators for View/workspace windows
Fixed bug that affected coloring of collaboration messages 7 & 8 
Modified sequence diagrams such that name of object in heading bar will be :<classifier> if the instance is otherwise unnamed
Fixed bug in properties window that resulted in Modified and Created dates being obscured
Fixed bug in sorting of Swimlanes in a diagram - problem with more than 9 swimlanes
Improved handling of parents and implemented interfaces in Delphi code generation
Added ability for Delphi parser to handle multiple attributes on one line
Fixed bug that displayed external requirements in top right corner of class image
Fixed bug that could cause exception when accessing Attributes or Operations from the Class Detail page of the Class/Table properties dialog

Changes and fixes for build 503

Added support for ByVal and ByRef keywords in VB - both forward and reverse 
Added support for array paramters in Visual Basic
Fixed bug in release version of EA that prevented menu option to 'Add to Favorites' on diagram object being shown
Fixed problem in Operations dialog that resulted in default return type always being set to first element in list on Add New
Fixed problem in Constraint dialog ... possible exception or no effect when updating existing constraint.
Fixed bug in 'drop object from tree' routine that could cause crash if drop failed due to 'duplicate element' message
Added code to check if bitmap images being saved to disk exceed Windows maximum and scale down where necessary. Affects very large diagrams only



Changes and fixes for build 502

Modified XMI importer to accept a wider variety of XMI files from various exporters. 
Modified object properties dialog to allow for user ordering of constraints
Modified New Element dialog (from right click on package) to allow populating name with auto-counter value
Modified RTF generator to allow heading selection of "Max 9 levels - elements are package + 1" in heading style combo
Fixed problem with scoped object name appearing in Project Browser in some cirumstances
Added a "Diagrams Only" reporting option to the Project Root node
Made C# interfaces members with no explicit scope in source import as "Public" rather than "Package"
Added 'Favorites' capability to Resource tab. Right click menu option on any diagram object to 'Add to Favorites'. Drag favorite from resource tab onto diagram to add to current.
Added option to View/Options/Code Generation page to use "Is" instead of "Get" for boolean attributes when creating properties
Interfaces implemented in VB class are now made Private by default
Fixed bug with parsing of Visual Basic "Event" declarations
Fixed bug with Report View that didnt refresh object details under some circumstances 
Added ability to set scope of new property getters/setters - see Create Property dialog from Attribute properties


Changes and fixes for build 501

Addition of new Automation Interface. The major change in this release of EA is the inclusion of a fully read/write automation interface for accessing and manipulating EA objects. The current version is an IDispatch based interface suitable for scripting using VB, VBA, VB.Net and any similar scripting style language. A Dual Interface will be added later in the year to accomodate other languages.

Note that the documentation for the automation is included as a separate PDF file in the latest install - and also on-line at:
www.sparxsystems.com.au/userdocs/AutoInterface/index.htm

We are also making the HTML version of the automation interface docs available as a zip file and as XMI for import into any EA project. 

Fix to bug that caused exception when undoing deletion of some elements (eg. Synch bar) in diagrams that also had connections
Fixed bug that allowed selection of hidden relationship in diagrams
Fixed bug in DDL generation that caused table name to be omitted during generation




Changes and fixes for build 500

Modifications and fixes to the Delphi parser. 
Modifications and fixes to VB.Net and C# parser - code generator
Added and improved support for XML style comments - supported in C#, C++, VB.Net
Extend JavaDoc style support to C++, VB.Net and Delphi
General improvements in comment synchronization in code engineering
Added menu option to package in Browser Tree to Synchronize all classes - either forward or reverse
Fixed bug in drawing code when creating file images that clipped text in wide diagrams
Fixed bug in Requirements element that could result in missing information


Changes and fixes for build 499

Maintenance release to upgrade MSI installer components in setup files
Small change to VB.Net code generator
Small change to operations dialog - Abstract and Pure check boxes were inadvertently being disabled


Changes and fixes for build 498

Added option to show 'hidden parents' in diagrams - for Class and Interface types. If an element has a parent or realisation that is not shown explicitly on the diagram via a link, the name of the target element is written in the top right of the class or interface
Added support for 'Tags' in Requirement, Change and Issue elements ... including support of tag compartment on diagram
Added support for the synchronisation of DDL information when doing ODBC import
Added support for the generation of Indexes, triggers, stored procedures in DDL
Added support for importing index information from ODBC source
Added support for auto number columns in DDL generation
Added support for 'COMMENT ON' for Oracle and DB2 DDL generation
Added support for multiple levels of comments in DDL generation
Added support for MySQL database
Added function such that depressing the control key while clicking on a connector will bypass the hit test on labels - allowing you to select a line behind a label
Fixed bug that could leave information about connector position in a diagram for deleted connectors in model
Disabled all controls on search dialog when 'Orphans' check box is ticked
Improved handling of Macros in C++ files
Fixed bug in Operations dialog that could cause exception in rare circumstances
Fixed bug in Docked Maintenance toolbar - Defect dialog caused error if Defect name contained an apostrophe
Modified the way the Hierarchy tab of the docked properties window is populated - changed 'RealizedBy' nodes
Modified operations dialog such that for C++ Interfaces operations MUST be Abstract and Pure
Modified C++ code gen such that Interface methods are generated abstract and pure always
Modified C++ code gen such that .cpp file is not created for interfaces
Modified way C++ code parser and generator handled <friend> methods
Fixed bug that caused error when new note attached to link is created but not given any text (content)
Fixed bug in Deep Copy of a diagram such that Notes attached to links did not get attached to the copied link
Ctrl+Del shortcut now deletes Attributes and Operations from the Project Browser in addition to the other elements
Removed Project/Maintenenace and Project/Tests dialogs from right click menu on diagram object. These are now accessed thru the dockable test and maintenance toolbars
Added "Import Scenario" option to Scenario Tests tab of docked Tests toolbar ... allows import of scenarios from object into test scenarios area
Added support for stereotype metafile appearance to Sequence objects in Sequence diagrams
Modifications to C++ parser to handle Macro definitions better
Initial and limited support for import of XMI 1.0/UML 1.3 XMI ... still under development


Changes and Fixes for Build 497
Addition of Swimlanes to diagrams as a configurable attribute of the diagram
	-configure from right click diagram context menu - use 'Swimlanes...' option
	-Add/modify/delete swimlanes. Associate each lane with a base classifier
	-Resize lane widths using mouse - drag and drop
	-When used in Activity diagram, correspond to UML Partition
	-When not used in Activity diagram, treated as diagram 'decoration'
Added check in importing UML Profiles to prevent import of file with Profile ID > 12 characters in length
Fixed bug that allowed Component attributes to overlap component name in some instances
Added code to Class element to draw 'information' stereotype as rhomboid  - as in the Eriksson-Penkar extensions
Added code to check size of EMF image when first loading from 'Choose Associated Image' and display at default size.
Modifications to the Hierarchy tab in Property window to better show an elements relationships to other elements - by type, composition and dependency
Prevented blank comments from Parameters reversed from code overwriting comments against parameters in EA 
Fixed bug in Issues dialog - running report could cause EA to crash
Modified behaviour of 'Move Diagram' function in Project Browser - owned pseudostates, boundaries and decisions are now moved with diagram to target package
Fixed bug in project browser that could cause problems with 'owned elements' (eg. states under a class) not 'holding' their position between reloads of the project
Number of changes to C# code generator and parser: support 'internal' and 'sealed' keywords better. Support attributes on parameters. Support 'params' keyword.
Some changes to code parsers to synchronise 'Abstract' 'Scope' and 'IsLeaf' attributes back into model from code
Modified element geometry in status bar to show correct size when element first clicked on
Added setting in element Feature Visibility dialog to hide runstate for an object
Added setting in element Feature Visibility dialog to hide attributes and operations based on stereotype
Added Decision, Start and End nodes to the Project Workspace tree.
Added ability to select a subset of all elements on diagram and save image for them only to clipboard (see right click menu for multi-selection)
Bug fix to import of C++ methods declared as "foo() const = 0;" pure indicator was being missed
Bug fix to Delphi code import ... in some cases method qualifiers spread over multiple lines caused a problem
Added ability to link note element type to the containing diagram's note - use note element context menu to set 


Changes and Fixes for Build 496
Added Interface, Class and Realisation icons to Component toolbar
Added ability to link Note element to Connector Tagged Values (using the Link Note to Connector feature)
Added suppoprt for PNG graphic format when exporting to image, RTF or HTML
Added support for JPG graphic format when exporting to image, RTF
Added support for TGA graphic format when exporting to image
Added support for linking a PNG, JPG, BMP, TGA, PCX, EMF or WMF image to an element in a diagram (overrides drawing)
	- not all elements support linking to graphic (eg. Decision does not)
	- image is stored internally in EA (in PNG format to save space) - link to external file is not maintained
	- image is first shown at default size - but may be resized as required
Added support for 'Package' scope (UML 1.4 compliance) 
	- added at element, attribute and method level
	- for Java acts as <default> visibility	
	- for VB.Net corresponds to Friend
	- not used (currently) in C++ or Delphi
	- CSharp treats like Java - and writes out no scope to code
	- XMI output translates 'Package' scope to 'Protected' (UML 1.3 does not support 'Package' scope)
	- XMI output to EA format includes tagged value of 'scope=package' where appropriate to ensure reverse is correct
Fixed a few minor resource leaks (unreleased menu handles)
Fixed drawing of Interface ... attribute name overlapping compartment top when stereotype, name and property  set (eg. "{root}")
Fixed display of long names in activities and events where height of wrapped text close to height of element - caused a blank line at top
Fixed a bug that prevented some check boxes holding their value - notably affected operation parameters, operations and controlled packages. This was caused by some changes introduced in build 495 to increase database access speed. If you currently have build 495 we recommend upgrading.
 


Changes and Fixes for Build 495
Reworked and updated the docked properties window extensively
Added support for Tagged Values to the Docked Property Browser
Added support for Delegates to C# parser/generator
Added ability to set the extension for all filenames generated in HTML report (eg. .htm, .asp, .html)
Added support in 'Link Note to Element Feature' for Tagged Values
Allow empty notes field in Scenario tab of object properties
Update HTML reporting to show icon for contained packages in lower left Contents pane
Changed 'Set Run State' shortcut key tot "Shift+Ctrl+R"
Added check box to search dialog - allows search to include scenarios, constraints, requirements and tagged values for object in search
Fixed bug in Delphi parser that caused problems with overloaded functions under some circumstances.
Added check in Operations dialog for unsaved changes when selecting another Operation from list. 

Changes and Fixes for Build 494
Fixed bug in VB.Net parser which could result in multiple return values for a method on synchronization
Added support for default parameter values in VB.Net - forces use of Optional keyword
Added support for updating parameter information(name, kind etc.)  on synchronization (reverse engineering)
Added support for C# "ref" and "out" keywords and functions
Support "struct" keyword in C#
Added support for C++ parameter default values having "(" and ")" - eg. _T("") 
Fixed problem with Attribute dialog not clearing property value when clicking between different objects
Fixed bug that affected ability to drop a requirement from tree onto a class in diagram and automatically create a realization link
Modified VB.Net code generator to format parameters slightly more elegantly (with regard to placement of comma)


Changes and Fixes for Build 493
Added support for moveable connector labels. Labels may now be freely placed and sized by the user.
Added support for connector label style of Bold -see right click context menu of label
Added support for aligning connector labels within their placement rectangle - left or centre or right (see right click context menu of label)
Added ability to hide inidividual labels on a connector - see right click context menu of label
Added dialog to manage hidden labels on a connection - see the context menu for a Connector (Set Label Visibility)
Split the View/Options Diagram Page into 2 pages - Main and Behaviour
Fixed bug in Java parser/code generator ... handling of "final" parameters
Fixed bug in drawing of Entity objects with Attributes ... could cause distortion of element size in diagrams
Fixed bug that caused exception if item double clicked in property/hierarchy pane, then Attribute or Operation dialog invoked
Fixed problem where two packages with the same name and same parent would show each other's contents when pasted into diagrams
Added ESC key processing to currentdiagram to cancel any pending links from toolset or elements dragged from toolset
When item clicked in small Element Toolbar, any pending action and selection in main toolbox is cancelled
Added "Insert Element" option in Diagram context menu to insert Note, Text, Hyperlink, Boundary or Diagram Details
When folder changed in toolbox, any pending action or selected item is cancelled
Added option to View/Options/Sequence diagram page. Allow specification of Font and Font Size for Sequence Diagram Heading bar.
Fixed bug that prevented overriden HTML Content template from being used instead of default one
Fixed bug where objects pasted into diagram that had x,y coordinates larger than size of diagram were inaccessible. Scroll bar sizes now rest on paste.
Added code in Java generator to accept "[]" as a container type when generating variables from associations
Added support in Java for "native" keyword. When reversed a tagged value of "native=true" is added to imported class
 


Changes and Fixes for Build 492
Added ability to define and modify HTML style templates. Templates are added in resource tree and selected in HTML report dialog.
Added ability to define and modify RTF style templates. Templates are created in Resource tree and selected in RTF dialog
Add Package contents to package page of HTML report
Added ability to set user defined Font type and style for Text, Boundary, GUI Element, Note and Diagram Text elements (see context menu 'Set Font...' option)
Added context menu option to Boundary element to allow ellipse, rounded rectangle or rectangle shape
Added handler for C++ macros of the style DECLARE_DYNCREATE(CView) ... define in Macro dialog as DECLARE_DYNCREATE() .. EA will ignore content between ( and )
Fixed bug in C++ code gen that could leave extra characters at end of CPP file
Improved support for const methods in C++ using the IsQuery property
Fixed bug in CPP parser that could cause out of memory error when parsing file with a variety of enums and/or structs
Fixed bug in Attribute dialog that could cause an exception under some circumstances
Fixed problem that could cause deletion of a package to fail when sub packages contained elements parenting multiple contained elements
General improvements to the VB.Net parser and code generator
General improvements in C++ parser and code generator
Added ability to import XMI package at View level when StripGUIDs selected
 

Changes and Fixes for Build 491
Added local setting to View/Options Code Generation page. Allows enable/disable capitalize of attribute name during Property generation
Fixed bug that prevented constraints being added to elements, operations, attributes and links when new elements created from UML Profile stereotype
Added Aggregation and Composition links to UML Profile. 
Fixed bug that prevented C# scope for attributes being generated correctly
Fixed ordering and type bug in HTML generation of method parameters for HTML reports
Added Files HREF to HTML generation - no modification is made to target - so HTTP or abosulte address expected in Filename
Added options to diagram dialog to show 'tag', 'requirement' and/or 'constraint' compartments in classes etc. on a per diagram basis
Fixed bug in code generation that prevented attribute generation for Composition relationships
Added HREF for all Hyperlink file types in diagrams when generating HTML Report 

Changes and Fixes for Build 490
Added 'Resource' tree to docked project browser - includes sections for UML Profiles, Documents, Matrix Profiles and Stylesheets
Added comprehensive and generic support for UML Profiles
	. Profiles are imported and managed in the new Resources tree view
	. Profiles may be imported from XML files describing the Profile content
	. Profiles include Stereotypes and tagged values for elements, attributes, methods, links, link ends and more
	. Profiles may include a metafile attached to the stereotype
	. Profile items may be dragged from the profile tree onto diagrams
	. Drag attribute and operation stereotypes over classes in diagram to add to element
	. Click on profile links and add connections as usual
	. Drag association end stereotypes over end of link to attach details
Added section in Resource tree for defined Matrix Profiles. Doble click on a profile to load matrix and display 	
Added function to post process XMI export XML with Stylesheet. Stylesheets are loaded in new 'Resource' tree
Added generation support for <<enumeration>> type in C++, VB.Net, VB 
Added reverse engineering support for <<enumeration>> in C++, C# and VB.Net
Added Attribute Tags to both the RTF documentation and HTML documentation
Added Method Tags to both the RTF documentation and HTML documentation
Limited display of Tagged values to those having a set 'Value' as future use of UML Profiles may define Tagged Values with no set 'Value'
Added highlight for Abstract classes and operations - set on View/Options dialog - Objects page "HIghlight {abstract} elements" . Adds "{abstract}" keyword to class drawing 
Added Read and Write check boxes to Create Property dialog (from Attributes dialog). Unchecking either will remove one of the paired accessor methods (get/set)
Added Abstract check box to the Create Property dialog. Check this to mark generated get/set methods or property as Abstract.
Revised Realization link such that if target object is an Interface drawn using Circle notation (lollipop) then the link renders as a solid line with no arrow (as per UML 1.4 spec)
Fixed bug that caused Visual Basic code generator to end Property blocks with 'End Function' instead of 'End Property'
Fixed bug in Aligning elements that could cause selected elements to align against an unselected element when called from the toolbar 'Align' buttons
Force close of Attribute and/or Operation dialog if package selected in Project Browser. Could cause exception under certain cirumstances.
Added 'Files' tab to requirement properties dialog



Changes and Fixes for Build 489
Addition of 'Lollipop' notation for Interfaces (see Interface context menu <Use Circle Notation>)
Removed small 'lollipop' adornments from Interface when displayed in Rectangle mode to make notation UML 1.4 compliant
Option for new instances of classes dropped from project browser onto diagram as instance to have same colour and style as original classifer (View/Options/Diagram Page)
Added method pre- and post- conditions to HTML report
Fixed bug in diagram drawing which could cause problems with border sizes when the "Print in Color" option was unchecked
Minor change to calculation of activation periods in Sequence diagrams
FIxed bug in sequence diagram that caused delete "X" to remain after a delete message had been modified to no loneger be a Delete - until next diagram reload.
Added check to prevent reverse engineering synchronization of Locked classes
Fixed bug in report View window that could result in two sets of scrollbars being shown and image corruption at view boundary


Changes and fixes for Build 487
***
Added HTML reporting. See menu option on packages in Project Browser. Current implementation is released as Beta ... additional functionality will be added to allow configurable templates and stylesheets.
***
Added option (View/Option Sequence diagram page) to turn off auto 'garbage collect' on sequence diagrams for created object instances
Added OLE Automation function to run an RTF report ... void RunReport(PackageGUID,TemplateName, FileName) 
		eg.  Call EAProject.RunReport("{DA3C7745-FB85-437e-A25B-44192CEE4D08}", "ArchitectureModel", "c:\temp\foo.rtf")
Fixed problem with sequence message when it is both a "New" call and the first message in a diagram having no activation rectangle
Added context menu option to sequence message - allows message to initiate a new activation sequence, ending all exisiting activations
Ability to lock an object in a diagram against further changes (to properties, attributes, operations etc.)
Fixed 'const' not being written to CPP imlpementation file for const method
Added Link Direction to elements saved in Matrix Profile
Corrected a small memory leak caused by unreleased menu handles 
Fixed bug that corrupted the end of notes in notes linked to operations, constraints etc. that were longer than 240 characters.		
Added a simple AutoCount function for auto naming new elements. See menu option under Reference/Configure Auto Counter. Supports Prefix-Counter-Suffix notation.
Fixed bug which affected 'Branching' in sequence diagrams when message first added ... menu option to branch was missing and/or branch was with wrong previous message
Fixed bug in C++ import which affected attributes like: "int foo[LENGTH];"  
Added support for C++ Macros that have a start and end definition, eg. BEGIN_COLUM_MAP ... END_COLUMN_MAP. Define in language macro dialog as "BEGIN ^ END" where begin = start macro and end = end macro. " ^ " <space>^<space> is treated as separator.
Removed generation of MustInherit keyword from Interface code in VB.Net
Fixed bug in C++ parser importing comma separated atttributes - eg.   int a,b,c;  - now creates 3 attributes of type int.
Added generation support for "struct" stereotype in C++
Added C++ support for scoped names of indeterminate length (eg; foo::bar::classtype Identifier) 
Added support for constructs such as "const int * const i;" in C++ parser
Fixed bug which occassionally prevented Workspace window from being shown after being hidden
Fixed issue with possible loss of data when making changes to object properties in dockable properties window, then by double click on element in browser
Fixed issue with EMF image type in Windows XP having corrupt images of packages, classes etc. in package contents
Fixed issue with .GIF image type having a slightly distorted package content images
Aggregation links now display solid diamond when Role aggregation set to 'composite'
"$" qualifier on attributes and operations removed as it has been superceded by the underline notation indicating a Static member



Changes and fixes for Build 485
Added option to Object page of View/Options dialog to not show Object or Message properties dialog automatically when adding new element
Sequence diagrams now support incremental method invocation (recursion) and the ability for messages to extend the recursive method activation (message context menu)
Sequence diagrams now support conditional messages (branching) and alternate execution paths
Fixed bug in Replication engine that caused problems with Access 2002 format projects
Size of selection rectangle for Synchronization element enlarged and 'hot points' also enlarged
Added support for XMI 1.0 when exporting model to XML format. XMI export dialog now has a 'XMI 1.0' check box. Check to output UML 1.3 in XMI 1.0 format. Still in beta testing, and does not yet include import support. 
Added Data Types to XMI export (XMI 1.1) plus some slight changes to Rose compatible XMI export
Modified Import Source Tree function so that Packages are not created if the directory contains no source or no child directory with source
Support for Windows Metafiles in RTF documents - provides compatibility with Wordpad and other simple RTF editors. 
	Use WMF image format and check the Embed image check box in RTF dialog
	EMF format with Embed image checked only works with MS Word and compatible	
	Note that editors based on the MS Rich Edit control (Wordpad etc.) do not correctly support text wrapping in table cells
Fixed C++ bug which affected import/synch of const unsigned datatype attributes
Added option to Object page of Options dialog to hide <<column>> stereotype in Table type elements
Improved the way datatype size fields are shown for blank datatypes on the Table Attribute screen
Additional support for early versions of the Oracle ODBC driver that reported database of 'Oracle'


Changes and fixes for Build 482
Improved support for JavaDoc style commenting within Java. Support Class, Attribute and Method JavaDocs.
Improved support for forward and reverse engineering C# comments
Added filter to RTF document generator - allow selection of elements based on Status
Added additional language support in RTF document  generator. Language setup dialog now has place for setting codepage, character set and language ID.
Reworded the Implementation and Dependency dialogs. Also added support for setting custom impementation targets
Changed XMI exporter for Rose/Unisys format. When DTD selected, output is forced to comply with UML13.DTD
Change/Maintenance dialog - preloaded lists with union of clients,authors and resources
Added setting to View/Options Diagram page to disable Shift-Mouse scrolling. Enabled is the default state
Default type of message to self in Sequence diagram change to 'not return'
Realization arrow changed to solid (unfilled) type
Issues docked window refreshed when project issues screen is updated
Default Sequence diagram Activation/Focus rectangle width increased to 10 from 6. Can be set back in View/Options on the sequence diagram page. 


Changes and fixes for Build 481
Linked note attachment point on connections to self corrected
Corruption of Use link connector line under some configurations corrected (erroneous lines at end point)
Static initializers in Java now processed correctly
Parameters in Java functions with fully qualified name (eg. java.SQL.Exception) now handled properly


Changes and fixes for Build 480
Changed dialog for State and Object Flow messages - previous version was conflicting with Event/Guard/Action fields
Changed handling of Package Phase filter in RTF generation dialog to fix generation problem
Fixed problem with specifying feature visibility - updating attriibute or operation details could corrupt specified feature visibility
Fixed problem with parsing CPP files that contained variable names using scope operator and current class name (eg. classname::attribute)


Changes and fixes for Build 479
Sequence diagram messages may now be offset vertically to open or close the gap between consecutive messages - drag into position with the mouse
Connectors of any type may now have an attached note - the notelink will attach at the link centrepoint and is currently fixed to that point. Use link context menu to attach a note
Connectors may have an attached constraint - use the context menu of a connector to create one - then check all relations that participate in constraint set
Added a Local Option to the Sequence page to set the default sequence diagram page layout as Landscape
Fixed a bug in the relationship matrix that prevented new 'X' characters showing when link created
Modified relationship matrix such that if the specified direction is 'Target->Source' then new links will follow this direction as well
Changed image name when generating RTF documents to derivative of diagram GUID - provides image independence to document version
Removed pichgoal and picwgoal settings from generated RTF for embedded image - was causing problems in Word XP documents
Automatically generated implementations of interfaces in C++ had wrong scope(namespace) - fixed
Run state dialog now fetches all attributes in the classifiers ancestry to choose from
Removed ' and ' characters from run state instance variables when displaying 
Diagram images could have erroneous white space when generating RTF documents - corrected
Prevent creation of duplicate realisation links when dropping requirements on other objects
VB.Net parser import of function parameters and types with array modifiers corrected
Added option to Object page of Local Settings dialog to show/hide arrowheads on Uses link 
Added code to permit bi-directional dependency and realisation links
When view window is scrolled away from (0,0), moving elements beyond left or top border is now handled more intuitively
Problem duplicating diagrams with JET 4 and replication enabled (s_ColLineage field causes diagram copy to fail) - corrected
Fixed problem with Delphi generation of Properties - public property being  skipped on first file generation
Sequence messages and collaboration messages now pick up the default parameter names from operations when  selected in message dialog
Added Node, Activity and Object to drop list of Stereotype 'Applies To' field 


Changes and Fixes for Build 477
Added support for branching/tree style generalization links - right click Generalization link and set style to 'Tree'
Fixed bug in NT 4 that caused Out of Memory error when displaying Report View 
Fixed bug in NT 4 that caused exception when right clicking in project window if no project loaded
Fixed bug where newly created links in Relationship Matrix could not be deleted without closing and opening the Matrix first
Delphi code generator updated to handle Interfaces correctly
Delphi code generator now supports Published scope. XMI import/export uses visibility of Public with tagged value of Published to handle non-UML scope of Published
Modified XMI export to include 'final' qualifier on End State nodes
C++ import of abstract methods could fail under some circumstances - fixed
Changing Zoom level on a diagram now causes the diagram to be marked as 'dirty' for saving purposes
Several bug fixes in VB.Net parser - especially for ReadOnly and WriteOnly Property statements
Fixed bug in parser code that could cause an error when unmatched string char - " - found in comments
Fixed bug in C++ parser that missed static qualifier on some attributes
Elements in Relationship matrix are now sorted alphabetically
Fixed small memory leak in relationship matrix
Added Scope edit box to docked properties window. Set scope
Added Filename edit box to docked properties window. Allows direct editing of implementation source filename		
Added Keywords edit box to docked properties window. Define user keywords on element	
Added Multiplicity edit box to docked properties window. Set multiplicity
Added support for MustInherit and NotInheritable to VB.Net code generation and parser
Properly mark VB.Net classes as abstract if containing MustOverride methods
Mark VB.Net classes as NotInheritable if IsLeaf setting is true for a class
Set 'Toggle Line Point at Cursor' hot-key as Ctrl+Q
Under some circumstances default values for parameters in C++ functions werent being picked up - fixed
Code generator did not wrap default value for function parameter in quotes in implementation file - fixed
Fixed bug that could cause exception when object deleted from tree with Attribute or Operation dialog open
Fixed bug that could cause associations to be generated twice when importing from source code
Added support for synchronizing Delphi inheritance section when forward generating code



Changes and Fixes for Build 475
VB.Net now supports Inner Classes
Added support for Delphi properties. These are stored as tagged values and can be displayed using the Set Feature Visibility function to show Tag Compartment
Added Delphi 'Property editor' ... can be activated from right click menu of class that has Delphi as its language
Generate Property function amended for Delphi to provide support for custom Delphi properties
Delphi parser now handles multiple classes in same file
Delphi parser/generator now handles Interfaces
Fixed bug in RTF language adjust that caused error if replacment string had ' or "  character embedded
Fixed bug that was causing some elements to display wrapped text incorrectly
Changed the icon displayed by diagram hyperlink to differentiate from file/web hyperlink
Fixed bug that executed diagram hyperlink when Properties menu option selected
Use case and Collaboration elements now support custom stereotype Metafiles
System and Maintenance docked toolbars now support sorting of list contents on any colum
C++ classes which include 'Friend' statement now import OK
Added 'Parameters' input text box to Message dialog. Add parameter names here when constructing sequence and collaboration messages
Increased length of fields for StateFlow Event, Guard and Action information
Increased length of message name field in Message dialog
List of names in drop downs for Project Issues, Maintenance and Task lists amended to include union of Authors and Resources
When reloading a diagram (after class synch or association changes etc) the current scroll position is retained rather than reverting to (0,0) 
When using the ShowUsage dialog and opening a new diagram - the current object of interest is selected and highlighted in the view window

Changes and Fixes for Build 470
Setting Grid size to 0 causes failure of EA to operate correctly ... minimum gridsize now 5
Java parser didnt handle '(' being on line after function name declaration - corrected
Role access not being updated in current diagram from Association dialog - corrected
Added line movements and custom lines to Undo capability in diagrams
Added a 'Tidy Line' feature for custom lines - automatically aligns lines horizontally and vertically if possible (see Diagram page of Local Options) 
Virtual inheritance in C++ could fail to be parsed correctly in some situations - corrected
Requirements now have their status correctly updated when using the Package 'Status Update' function
Added Phase, Status, Author and Complexity values to XMI output of package
Fixed ALT-S and ALT-O accelerators in Object properties dialog
Added additional 'Hierarchy' tab to properties window
Added support for 1..many association ends generating custom collections in Java
Added support for non-standard page sizes (eg. large plotter pages) when printing
Fixed bug that showed "Could not start print job" message when printing cancelled
Added "Print Setup" option to File menu - allows per session configuration of default printer


Changes & Fixes for Build 469
Saved diagram images now properly include Custom lines that are outside Object bounding rectangle
Added a Replication Conflict Manager dialog to Admin/Replication menu - use after synchronizing replicas (professional version only)
Saved diagram images now properly expand to include Diagram Details if they are shown
Added additional geometry settings to XMI export of diagram elements when images are also saved along with XMI. This is necessary for people wishing to build image maps from the XMI export - using to co-saved images
	-imgL - absolute postition of element left inside image
	-imgT - absolute postition of element top inside image
	-imgR -	absolute postition of element right inside image
	-imgB -	absolute postition of element bottom inside image
Fixed bug where adding additional elements to Sequence diagram increases initial right hand position exponentially
Fixed bug that resulted in connectors being drawn to 'phantom' object under some circumstances
Fixed bug that limited Views in additional projects to 1 view shown


Changes for Build 468
Connector lines now support user defined 'waypoints' ie. they are user routable
	- Use context menu or property dialog to set line style to Custom
	- Use context menu to add/delete waypoints (Toggle Line Point)
	- Highlight line and use Ctrl-Q to toggle line point at cursor position
	- Use Local Options dialog to set default line type to Custom if desired

Support element composition for Classes, Objects, Requirements, States. 
	- Nesting like types graphically automatically creates composition relationship
	- Nesting packages creates a Nesting relationship

Boundary element border now differentiates between dotted or dashed line	 
Sequence and Collaboration message dialog reworked to reflect UML 1.4 standards
Sequence and Collaboration message names reworked to UML 1.4 spec

Local Option added on Sequence page to use old message format (for diagrams specifically set up for old style)
XMI export dialog now includes option to export diagram images at same time as XMI generated

Automation Interface has added a new method to export a package to XMI - including diagram images
		The interface has an additional method: 
		
		BSTR CProject::ExportPackageXMI(const VARIANT FAR& PackageGUID, long XMIType, long DiagramXML, long DiagramImage, long FormatXML, long UseDTD, const VARIANT FAR& FileName) 
		
		Where PackageGUID	 = the GUID of the package to export 
		XMIType 			= Rose or EA, 1= EA 
		DiagramXML 			= Export XMI for diagrams
		DiagramImage		= Format of Diagram image to export : -1 = no images, o = metafile, 1 = bmp, 2 = gif
		FormatXML			= Format XML output, 1 = yes
		UseDTD				= Use a DTD in the XMI header, 1 = yes
		FileName			= Filename of XMI
		
		Images will be saved to a subdirectory called Images
		Images filenames will be constructed using DiagramGUID + image type extension

Relationship Matrix now has ability to save current setup as a profile for easy reloading
Void paramaters in C++ functions now rendered without parameter name
Unsigned parameter types now import/export correctly
Support for Virtual Inheritance in C++ added
Change to layout of diagram properties dialog 
Addition of Hide Property checkbox to diagram dialog - hides <<property>> operations
Fixed a bug that could cause a GPF after viewing the Source or Target properties in the Relationship Matrix
Fixed bug that could cause generation of multiple implmented interface functions




Changes for Build 467
Browser tree now supports objects being located under other objects ... 
	eg. State nodes can all be placed under an owning Class node
	eg. A Collaboration node may have diagrams and objects under it
	eg. A Class may have activities located under them
Elements created or droppped onto an 'owned' diagram will become owned by the diagram owner ...
	eg. If a class has a state diagram under it, then all elements dropped onto 
	state diagram automatically get located under that class as well.
Interfaces now display with name in italics (abstract class)
Interface operations now display in italics (abstract operations)
Static attributes (Class feature) are now displayed underlined
Static operations (Class feature) are now displayed underlined
Nesting relationship added (to Logical and Relation toolbars)
Added custom drawing of <<model>> and <<subsystem>> stereotype icon as per UML specification
Abstract class names in package contents rendered in italics
Bug fixed when viewing properties of element directly from tree then clicking on diagram straight after
Association end now displays Qualifier if set
Object instance now supports 'Role Played' as well as Name and classifier - <Name> / <Role> : <Class>
Added 'Iteration' element to Sequence diagram toolbar. Use to delimit iterative message passing
Inner classes linked with Nesting relationship instead of dependency
Activity and State elements now resize if text larger than visible element
C++ structs imported as stereotyped classes with <<struct>> stereotype
Underlining of Object name now correctly excludes /Role and :Classifier section 
Bug fixed that stopped throws clause being picked up in Java reverse if throws on new line
Outlook toolbar size now stored/re-stored between sessions
Gen filenames now updated in current diagram when Local Path Dialog used (avoid having to reload diagram)
New classes etc. are automaitcally set to the current default coding language
Ability to set code page for XMI output (Local Settings/XML page)
Const value in VB with no explicit scope previously marked public - should be private
Line continuation characters cause problems in VB - added support for line continuation
Corrected bug where RTF documentation prints package notes twice - for heading and content
Back/forward diagram navigation stopped responding after 50 items - upped limit to 300 and investigating cause
Fixed bug where class persistence not in XMI output
Added ability to set Object persistence - moved Persistence attribute to page one of property dialog
Fixed bug where association name not displayed (build 465) 
Some elements have minimum size set (eg. class, object, component...) to avoid bad drawing effects
Added 'IsQuery' property to operations dialog and XMI import/export
Added IsLeaf, IsRoot, IsSpecification and Multiplicity to class display as property string (when values set display under class name)
Use cases now support Extension Points ... access these from the Use Case context menu.
Use cases and Collaborations now display name in Bold if local setting Use Bold Names is set.


Changes for Build 465
Added ability to define additional Project Root Nodes (multiple projects in Tree Browser)
Added ability to define keyword substitution in RTF documents ('Adjust Language' button on RTF dialog)
Abstract classes now denoted with italic name, rather than dotted border (UML 1.4 convention)
Added 'Cardinality' dialog to Reference menu - define list of cardinality types
Display {ordered} constraint on association role end when IsOrdered checked
Abstract operations now displayed in italics (UML convention)
First association constraint now displayed as boolean expression on association link
Active Class (and Active Objects) now supported. Set Class to IsActive on Property/Advanced page. All instances displayed with thick border
Property dialog now renamed to Tagged Values dialog and moved to reference menu
Role changeability now displayed on association role end where applicabel .. supports {addOnly} and {frozen}
Added optional compartment for Responsibilities on some elements. Activate using the "Set Feature Visibility" menu option on element context menu
Added optional compartment for Constraints on some elements. Activate using the "Set Feature Visibility" menu option on element context menu
Added optional compartment for Tags on some elements. Activate using the "Set Feature Visibility" menu option on element context menu
Attribute stereotypes now display
Added Local Option (Local Settings dialog - page 1) to toggle Open Maximized or remember last position
Added .frm, .bas and .ctl files as options for Visual Basic import 
Fixed bug in EMF images that displayed Hyperlink icons in black
Fixed bug in .BMP generator that caused black stripe at bottom of image if view scrolled down
Fixed bug that caused crash under some circumstances when flipping between report and diagram view
Some fixes to VB code generator


Changes for Build 461
Some changes to Visual Basic code generator, notable to handle Const variables and implementation inheritance
Message scope dialog reverted to non-sorted drop lists to correct a selection problem


Changes for Build 460
Substantial changes to Code generation and parsing engines:
	-Method notes synchronized forward and reverse
	-Ability to update method type in code 
	-Ability to update method parameter names in code
	-Ability to update attribute type
	-Update method and attribute scope (except C++/Delphi)
	-Update attribute default value in code
	-Update .cpp files as well as .h files for CPP
	-Better facility for generating properties from attributes
	-Improved property support in all languages
	-Numerous bug fixes for code generation
	-Improvements to comment extraction
	-Ability to set comment style for C++
Correct bug where Nodes always dropped as instances onto diagrams
Fixed problem where diagram keyboard input could be lost after editing operations or attributes
RTF templates will now accept empty heading and intro - all other headings move up one level
Correct bug where Attribute dialog did not have correct focus on open
Source and Target drop downs in Message Dialog now sorted
Autosize all now works correctly with Zoom sizes > 120%
Fixed problem with element properties not updating until re-selected
'Shallow' copy in Sequence and Collaboration diagrams now copies messages
Windows Metafiles are converted to Enhanced format on import - not dynamically - prevents occasional load errors
Fixed a bug that caused a crash when swapping between diagrams (under special circumstances)
Fixed bug that caused collaboration diagrams to print extra blank pages
Fixed bug that caused some text elements to generate extra blank pages when printing
Fixed XMI bug: Attribute 'const' flag not imported from XML file
Option (diagram local setting) to show 'linked package contents' in packages on diagrams
Ability to save import headers from Code Gen dialog without actually generating code (for later batch generation)
Visual Basic code generator will now create implementation methods for inherited methods
Following accelerators added:
	-F9 - open Attribute dialog
	-F10 - open operation dialog
	-F11 - generated selected class
	-Shift/F11 -generate all selected classes
	-F12 - View selected class source



Changes for Build 457
ODBC import modifications. Limited support for DBASE files
Fixed a bug in the Java import which adversely affected the parsing of classes with no Parent
Java code generator now supports 'throws' clause - add a tagged value of type 'throws' to an operation to generate
Bug in DataTypes dialog fixed
Table attributes (columns) dialog now enables the Tagged  Values page correctly


Changes for Build 456
Addition of option in RTF dialog to 'Document all Elements' - this will include such items as Sequence objects, Boundaries etc.
JET 4.0 subsystem upgraded to support Replication of Access 2000 format projects
RTF report now sorts elements by Type, Custom position and then Name
Views can now be dragged onto a diagram (as a Package)
RTF Report has option to include Package details (status, constraints, requirements etc.)
If Phase filter set in RTF report, packages which are less than that are not included (nor their children)
Improved C++ parser handling of line breaks
Tagged Values table now enabled on Table Columns dialog


Changes for Build 455
Extensive changes to the Page Setup functionality and drawing of printed page
Option to Draw a border around printed pages
Fixed bug that lost page setup details after using "zoom to fit" function on diagram
Made 'Heading Style' a mandatory field in RTF report dialog
Display Build number in Open Project dialog
Allow 'auto-instance' of Nodes when dropping from tree onto diagram
Tighter linking of Sequence messages and target class operations
Ability to hide and show sequence message paramters (where linked to operation) using Diagram Dialog
Full method signature displayed in operation drop list in Message Dialog
Return type updated when selecting different operation in Message dialog
Options added to RTF Report dialog to exclude Hyperlinks from output

Changes for Build 452
Removed registry update at program start when user does not have update rights (restricted users)

Changes for Build 451
<changes & bug fixes>
Improvements to code import linking and link resolution
Realize relationship added to logical toolbar
Scenarios for Use Cases etc. now sortable according to user desire
C++ - import of class with Pure Virtual functions forces Abstract class
Improvements to handling of virtual functions in general
Option to locate object in current diagram and centre (from browser object context menu)
Further improvements to sequence diagram focus of control
Occassional error in link scope when generating code


Changes for Build 450

<changes>
Focus of control in sequence diagrams rewritten and updated to include finer control
Testing docked tool updated to include additional columns and sortable columns
Updates to C++ parser to handle some problems template classes 
Updates to C++ code generator 
Local option to set default association directedness
RTF Templates now save 'exclude element' details
Packages now reload last RTF template used for that package (if previously generated)
Objects dropped from browser onto sequence diagram now appear at right most position in sequence - not left most
Added ability to go to operations dialog directly from 'new message' dialog in sequence diagram
Hyperlinks now included in RTF generation .... they appear directly under the diagram they appear in 

<bugs fixed>
Hyperlinks caused blue text in state diagrams
Association constraints included in XMI input/output
Some fixes to the C# Parser
Include interfaces from an realized interface in drop list of new message dialog in sequence diagrams
Fixed bug with ReportView not repainting correctly under some circumstances
Import of FoxPro DDL from ODBC



Changes for Build 443

<changes>
Ability to associate a metafile with a stereotype and override the normal appearance of an object (see Stereotype Dialog in Reference section)
Ability to set the modified date for all elements in a model branch (from the Update Package Status dialog)
Ability to define a new method from the Message dialog for selection in Sequence diagrams
Modification of Sequence diagrams to include support for 'implicit returns' and focus of control - Local Setting to enable/disable
Set relation visibility window now resizable
Ability to set generation language directly on Code Generation dialog (drop list)
Transition names copied to 'Action' field for old style transitions
Added undo for AutoLayout
Some database changes for future enhancements
Set Element Parent option on context menu for generalizable elements (creates a generalization link to any element in model)
Autosize Selected elements in diagram option

<bug fixes>
Addition of VB.Net to object language droplist (on Object Properties dialog)
Use of '\' character in element names broke RTF generation
Tidied up name wrapping for classes
Fixed some import errors in C# parser caused by \" (escaped quote)
Ensure Interfaces listed in parameter drop lists
Modifications to sequence diagram
Additional UI fixes and consistency checks
Handling of interfaces in VB improved
Improved Import and Package statement handling in Java

Build 440

Release 3.10 is a minor version update which rolls up all the patches and refinements since the 3.00 release. 
Special note regarding replicated models: This version of EA will update your model files (.eap) when you open them. Do not try and update a Replica project - always update the Design Master first, then synchronize the Rreplicas with the Master to copy the changes to the Rreplica. You may also elect to create new Rreplicas from the updated Design Master and discard the old version 2.5 Replicas.

The main features are:

- Addition of a dockable 'tab bar' to provide easy access to testing scripts for an element
- Addition of a dockable 'tab bar' to provide easy access to system tasks, project issues and glossary
- Addition of a dockable 'tab bar' to to provide easy access to maintenance items (changes and defects) for and element
- Addition of 'Hyperlink' element for creating links to other documents and webpages and placing on diagram (element toolbar)
- RTF documents can now have heading levels up to 9 deep
- Provide ability to rename or delete the pre-defined model views (Use Case, Logical, Dynamic etc.)
- Ability to place 'diagram properties' in a text element on a diagram (freely moveable and formattable)
- VB.Net support
- Support for Association Classes (UML connection type)
- More UML support
- Property windows disabled when no valid element selected
- Registry hive for version 3.10 now separate from 2.50 and 3.00 (some quirky behaviour caused by shared registry settings)
- Attribute multiplicity now shown in diagrams
- Attribute initial value now shown in diagrams 
- Simple RTF report for ReportView
- Ability to set the Default Diagram for a project (EA opens to this if available)
- Last RTF template loaded is recalled when accessing RTF dialog
- Support for Changes and Defects in RTF documents
- Improved Focus of Control on sequence diagrams
- Transitions may have Event, Guard and Action attributes
- Associations now directed by default 
- Fixed bug which caused GPF when deleting certain kinds of elements and trying to undo
- Support for JET 4.0 data access (Access 2000/XP) - requires Jet 4.0 already installed on client - user must configure local option first
- Interface attributes required to be declared 'static'
- Updated type Generalisation to Generalization (spelling correction) 
- Plus bug fixes and general tidy ups.




New in Release 3.00
~~~~~~~~~~~~~~~~~~~ 
Release 3.00 features a large number of enhancements and refinements. A complete list is included at the bottom of this note. The main highlights are:
- improved GUI with dockable windows and more toolbars
- relationship matrix for managing requirements traceability
- improved reverse engineering of ODBC data sources
- foreign key information is now included DDL import/export
- ability to copy complete diagrams
- additional modeling elements
- an ActiveX read-only interface based on XMI

Once again, many thanks to all those who have supported EA and offered their ideas and encouragement. Also a special thanks to those who took the time to evaluate the beta version of this release and report back bugs and issues.
 
Please note:  For up to the minute details on the latest build of Enterprise Architect, check the Latest News section of the user forum at: http://www.sparxsystems.com.au

Special note regarding replicated models: This version of EA will update your model files (.eap) when you open them. Do not try and update a Replica project - always update the Design Master first, then synchronize the Rreplicas with the Master to copy the changes to the Rreplica. You may also elect to create new Rreplicas from the updated Design Master and discard the old version 2.5 Replicas.

********************************************************************************************************
 
New features, bug fixes and changes in Enterprise Architect 3.00
 
New to Version 3.00
~~~~~~~~~~~~~~~~~~~
- much improved 'Office Style' GUI with dockable windows, new look and feel and smooth performance
- dockable propeties browser and project browser windows
- improved reverse engineering of ODBC data sources
- foreign key information is now included DDL import/export
- ability to copy entire diagram with ease - either as shallow (linked objects) or deep (duplicate objects)
- tweaks and improvement to XMI import/export facility
- space objects evenly on a diagram, vertically or horizontally
- customize how the tree view responds to mouse clicks- 
- new 'appearance formatter' toolbar - with saveable styles - colorize multiple objects with a single click
- relationship matrix for managing requirements traceability and other uses. CSV export for Excel compatibility
- hot keys improved and added
- added 'Set Connector' function, allows existing connector to be moved to other objects
- added Tagged Values to attributes and operations
- added Tagged Values to class objects
- ability to set custom position of elements in the project browser (custom sorting)
- addition of structured 'issue' and 'change' elements for help in managing projects
- addition of 'hierarchy' page to requirement dialog to visualize composition and implmentation of requirements
- property dialog now supports internal and external responsobilities (requirements) 
- ability to move internal responsibilities to external requirements with a button push - makes working with system requirements much simpler
- ability to suppress collaboration numbering
- ability to customize toolbars (hide and show buttons) 
- set the visibility of element features (attributes and operations) on a per diagram basis
- Active X (read only) interface - based on XMI 
- ability to copy an attribute or operation from one element to another using drag and drop from the project browser to an element in a diagram
- ability to auto create a requirement/realization link by dropping a requirement from the browser on an element in a diagram
- addition of a 'diagram only' RTF report
- ability to link a note element in a diagram to an internal feature (attribute/operation etc) of another element - and auto display the feature notes etc. 
- support for defining C++ Macros that will be ignored during reverse engineering
- highlight operation parameters and return types that are passed by reference - set the highlighting character as an option (eg. & or *) 
- support for History states, Concurrent states and Synch states
- additional settings to customize overall behaviour
- some tweaks to the code engineering components


Added Since the Initial Release of version 2.50
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
- Added date criteria on search screen
- Support for Events in VB code generation
- Support for Behavior in code generation
- Intellimouse support for diagram window
- Support for object colors and styles
- Added Hotkey (Ctrl) to prevent Auto Instance
- Added Phase to requirement dialog
- Increase the size of Scenerio Notes on property screen
- Added Align middle
- Added Support for UI Table Elements
- Added Recursive Package Phase Update
- Added Synch(V) and Synch(H) to state chart toolbar
- Allow notelink to be routed
- New diagrams now receive focus automatically
- Allow hide/show of stereotype icons
- Scroll using Shift-MouseMove
- Append package name to related object in RTF associations
- Pre / Post-Constraints for attributes not in RTF
- Manual entry of RGB values in appearance dialog
- Select tree object when it receives focus after delete
- American spelling for Generalisation etc.
- Objects can be inserted directly into the tree, without belonging to a diagram
- Ability to add new elements by right clicking on package in tree view
- Allow parameter name to be modified in operations dialog
- Added support for /* */ and // comment statements in Delphi code generation
- Added support for constructor/destructor statements in Delphi code generation



Bugs fixed in Verion 3.00 since the Initial Release of version 2.50
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
- Items in the tree were being sorted incorrectly after drag
- Colour not working for interfaces and abstract classes
- Order test scripts by Use Case name 
- Hot keys Ctrl-V and Ctrl-Shift-V were swapped
- Missing Hot keys on screens
- Fixed GPF on RTF generation screen (when New is clicked)
- Save button on Properties screen (file tab) never became enabled
- Diagram property screen changes were lost when user selects PageSetup
- when doing bulk copy/paste boundary object don't get copied unless they have name
- when doing bulk copy/paste new object are insert in reverse z-order
- corrected minimum screen size of Table attributes screen
- CRLF were changed into CRCRLF during synchronizing of C++ code
- Package notes lost in XML import/export
- Cancel drag and drop
- XML import/export bug (friend visibility in C++) 
- Associations created by Code generation was incorrect
- Element name too long for context menu in some cases
- Diagram name not updated correctly in props when diagram not visible
- Scenario tests were not being included in RTF documentation
- Copying of Operations and Attributes bug patched
- RTF documentation includes parameter details for methods
- ECF dialog support for other regional settings
- Improved diagram locking - prevent connector moves and multiselects
- Operation and Attribute dialogs hold last selection in list when item saved
- Fix an occasional GPF loading operations dialog for element that has classifier which does not support operations
- Autolayout feature marks diagram as 'dirty' to prevent lost changes
- C++ copy constructor syntax changed
- fixed bug in remove replication process
- fixed save attribute bug

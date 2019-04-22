MCESDK_Guide02.doc

# K Developing Applications for Windows Media Center
Windows Media Center delivers full-featured software and experiences to your customers by using the Windows Media Center Presentation Layer, which allows applications to have access to the same rendering technologies that are used to create Windows Media Center itself. The Windows Media Center Presentation Layer provides dynamic layout capabilities, integrated animation support, rich text and graphics support, and automatic keyboard and remote navigation. In addition, applications using the Windows Media Center Presentation Layer run remotely with full fidelity on the Media Center Extender for Xbox 360.
A Windows Media Center Presentation Layer application is a managed Microsoft .NET fFramework assembly that runs inside Windows Media Center. A Windows Media Center Presentation Layer application uses the following technologies to control and extend features and capabilities of the Windows Media Center experience:
•	The Microsoft .NET Framework 2.0 is a development and execution environment that allows different programming languages and libraries to work together seamlessly to create Windows-based applications and services that are easier to build, manage, deploy, and integrate with other networked systems. A Windows Media Center Presentation Layer application has access to the .NET Framework's System namespace, and to namespaces provided by external assemblies.
•	The Windows Media Center Application Programming Interface (API) enables you to programmatically automate features and experiences of Windows Media Center, including media playback, queue management, tuning to live TV shows, scheduling recordings of future TV shows, parental controls, and navigation to Windows Media Center features from within a third-party application. For more information, see the Managed Code Object Model Reference.
•	The Windows Media Center Markup Language (MCML) to display the user interface. MCML is an XML-based declarative language that supports advanced concepts such as parameterization, private local storage, rich conditional-based data binding, composition-based animated visual content, and access to managed code assemblies from markup.
This section describes these basic concepts for developing Windows Media Center applications and services in the following topics.
Topic	Description
Development Tools for the Windows Media Center SDK
Describes the tools that are provided with the Windows Media Center SDK.
Understanding the Fundamentals
Describes basic concepts to help you get started developing Windows Media Center applications.
Debugging
Describes different debugging considerations.
MCML Basics
Describes basic concepts of MCML, such as the model-view approach, MCML syntax, using namespaces, and accessing libraries and assemblies.
Defining a UI
Describes the basics attributes of an MCML UI, which include Content, Properties, Locals, and Rules.
Working with View Items
Describes the visual primitives that you can use to create an MCML UI.
Creating a Layout
Describes the different options to use for laying out child elements in an MCML UI.
Working with Page Sessions
Not documented in this release.
Working with User Input and Text Entry
Discusses how to support text entry from users from both a 2-foot and 10-foot scenario.
Managing Navigation
Discusses navigation issues, such as managing pages, focus, scrolling, and so forth.
Working with Animations
Describes the basic concepts of creating animation in MCML.
Working with Live and Recorded TV
Describes how to tune to live TV and schedule recordings.
Developing iTV Framework Applications
Describes considerations for developing Interactive TV (iTV) Framework applications to combine traditional TV with interactivity similar to that of the Internet and personal computer.
Playing Media
Discusses how to implement the different types of media playback, working with view ports, streaming versus downloading content, and using playlists.
Installing Windows Media Center Applications
Describes installation and setup issues, such as how to register your application and how to create an entry point for it in the Windows Media Center user interface.
Building and Modifying the Sample Applications
Describes how to build the different sample applications that are included in the Windows Media Center SDK.
Displaying Content Based on Parental Controls
Describes how to retrieve the parental control settings for content to determine whether to prompt for the access code.

See Also
•	Programming Guide

# K Development Tools for the Windows Media Center SDK
This topic summarizes the development environment that is recommended for developing Windows Media Center applications, as well as some useful tools.
Development Environment
The following is the recommended setup for developing, testing, and deploying Windows Media Center applications:
•	Windows 7
•	Microsoft Visual C# 2008 Express Edition
•	.NET Framework 2.0
•	Windows Media Center Software Development Kit (SDK)
It is possible to develop and compile a Windows Media Center application using only a text editor (such as Notepad) and a compiler installed by the Microsoft .NET Framework 2.0 (such as csc.exe). However, because these tools do not provide features such as IntelliSense, they are not recommended. You can also use third-party development tools, but keep in mind that support for these tools is provided only by the vendor.
You can also develop applications using the full version of Visual Studio, or using other programming languages such as Microsoft Visual Basic. However, the project templates and sample code provided in this SDK are written for C#.
Note   When using Visual Studio to develop MCML documents, be aware that the IntelliSense feature does not provide all possible options in the completion list. Rather, it provides syntax options based on best practices and commonly used scenarios. Therefore, you can use elements and attributes that are not listed and Visual Studio will display wavy underlines, but the MCML code may still be valid.
Development Tools
The Windows Media Center SDK installs development tools that you can use to develop applications and services for Windows Media Center. In a default installation, the tools are located in the folder at the following path: %ProgramFiles%\Microsoft SDKs\Windows Media Center\v6.0\Tools.
The following tools are included in this release:
•	Media Center Markup Language Preview Tool
•	Preview Tool Launcher
•	Sample Explorer
•	Animation Explorer
•	Media Center Markup Language Verifier
See Also
•	Building and Modifying the Sample Applications
•	Developing Applications for Windows Media Center
•	Using the Visual Studio Project Templates for Windows Media Center Presentation Layer Applications

# K Media Center Markup Language Preview Tool
The Media Center Markup Language Preview Tool (McmlPad) is a Windows Media Center application that allows you to browse to and view MCML files. This tool can also be used for certain types of debugging (such as syntax checking, focus and input checking, and UI region boundary indications). This tool is only supported on a computer running Windows Media Center.
McmlPad is registered as a Windows Media Center application, so you can run McmlPad within Windows Media Center (on the Start page, go to Extras > Extras Library, and then select MCML Preview Tool).
You can also run McmlPad as a stand-alone application. The stand-alone version is useful for testing UI, but it cannot run code that depends on other Windows Media Center features or APIs.

McmlPad Command-Line Parameters
The stand-alone file mcmlpad.exe, located in the \Windows\ehome folder, can be run at the command line with the following parameters. All parameters must begin with a forward slash (/) or a dash (-).
Parameter	Description
/animations:false	This parameter starts McmlPad with animations disabled.
/animations:true	This parameter starts McmlPad with animations enabled.
/direction:ltr	This parameter starts McmlPad in left-to-right (LTR) display mode.
/direction:rtl	This parameter starts McmlPad in right-to-left (RTL) display mode.
/dx9	This parameter starts McmlPad in DirectX graphics mode. The DirectX graphics mode simulates rendering markup in a full-fidelity graphics environment that is typically used when Windows Media Center is rendered on the Media Center PC or on an Extender device such as an Xbox 360.
/folder:folder_path
	This parameter specifies a folder to watch for resource changes. McmlPad automatically refreshes as changes occur, or at a set interval if one was specified using the /interval parameter.
/gdi	This parameter starts McmlPad in Graphics Device Interface (GDI) graphics mode. The GDI graphics mode simulates rendering markup in a low-fidelity graphics environment that does not support DirectX graphics mode.
/interval:seconds	This parameter specifies the interval, in seconds, at which to refresh McmlPad when changes occur to resources in a specified folder (if the /folder parameter was used).
•	When set to a value less than or equal to zero, refreshes are performed in real time.
•	When set to a value greater than zero, refreshes are performed at the specified interval.
/load:file://mcml_file	This parameter starts McmlPad and attempts to navigate to the specified uniform resource identifier (URI). You can use this as a startup command in a debugging environment to more easily debug markup. Supported URIs for this parameter include file://, http://, res://, and resx://.
/position:xxxx,yyyy	This parameter starts McmlPad at the specified window location.
/size:xxxx,yyyy	This parameter starts McmlPad with the specified window size to test rendering markup at various display resolutions, and to simulate aspect ratios such as 4 × 3 and 16 × 9.
-assemblyredirect:full_path
	This switch specifies a local directory from which to load an assembly for debugging purposes. McmlPad searches this local directory before searching the Global Assembly Cache (GAC) and \windows\ehome.
For example:
-assemblyredirect:c:\directory
Notes   Only one directory can be passed in, and it must not contain a trailing backslash.
This switch does not work if the assembly is also installed into the GAC. The .NET Framework always loads the assembly from the GAC when possible.
-markupredirect:before_string,after_string,suffix_to_append_to_the_end
	This switch specifies a local directory from which to load resources for debugging purposes. McmlPad replaces all instances of before_string in res:// and resx:// resource strings in markup files with after_string, then appends the resource identifier, then appends the suffix_to_append_to_the_end.
suffix_to_append_to_the_end is optional.
Examples:
-markupredirect:resx://McmlSampler/,file://c:\directory\,.mcml
Causes the following replacements:
xmlns:spin="resx://McmlSampler/Scenarios.SimpleSpinner"
becomes
xmlns:spin="file://c:\directory\Scenarios.SimpleSpinner.mcml"
-markupredirect:res://McmlSampler/,file://c:\directory\
Causes the following replacement:
xmlns:spin="res://McmlSampler/Scenarios.SimpleSpinner.mcml"
becomes
xmlns:spin="file://c:\directory\Scenarios.SimpleSpinner.mcml"
You can specify multiple groups of before_string,after_string,suffix_to_append_to_the_end by separating each group by semicolons.

See Also
•	Building and Modifying the Sample Applications
•	Development Tools for the Windows Media Center SDK

# Preview Tool Launcher
The Preview Tool Launcher is a stand-alone application that provides a graphical user interface with the following features:
•	Browse, type, copy and paste, drag and drop, edit, and launch URIs in the Preview Tool (McmlPad).
•	Learn about and launch the Preview Tool with command-line switches.
•	Maintain and automatically save and restore the history of all opened URIs.
•	Double-click any item in the history to launch McmlPad with the selected item (and move to the top of your history).
•	Save a history to share with others or create resource groups for various projects.
•	Open histories you have saved or received from others.
•	View all samples in single or multiple instances of McmlPad.
•	Clear the history.

See Also
•	Developing Applications for Windows Media Center

# K Sample Explorer
The Sample Explorer allows you to navigate the individual MCML and C# sample files included with the Windows Media Center SDK and view them in the MCML Preview Tool or within Windows Media Center. The Sample Explorer is available as a stand-alone application and as a Windows Media Center application.
Sample Explorer (Stand-alone)
The stand-alone version (available from the Windows Start Menu) lets you view, copy, and paste the code and markup into your own projects. The samples remain read-only from the Sample Explore user interface to preserve the integrity of the samples.

Sample Explorer (Windows Media Center application)
The Sample Explorer is available as an application that runs within Windows Media Center (from the Windows Media Center Start menu, go to Extras > Extras Library > Sample Viewer). It is implemented as a real-world Windows Media Center application, complete with remote control interactivity.

These applications work in tandem. The stand-alone version can launch the individual sample files in the MCML Preview Tool or launch the Sample Viewer application within Windows Media Center directly to the seleected sample.
By default, the sample files are located in %ProgramFiles%\Microsoft SDKs\Windows Media Center\v6.0\Samples\Sampler.
Some samples implement features that require the full Windows Media Center functionality so they do not work properly in the stand-alone version of the tool. Other samples require a Web server.
Sample
Filename	Requires
Media Center	Requires a
Web Server
Fundamentals
Hello World	FundamentalsHelloWorld.mcml
Model-View Separation	FundamentalsModelViewSeparation.mcml
Model-View Separation - Code	FundamentalsModelViewSeparation.cs
XML Syntax	FundamentalsXMLSyntax.mcml
Object Paths	FundamentalsObjectPaths.mcml
Resource Access	FundamentalsResourceAccess.mcml
Markup Libraries	FundamentalsMarkupLibraries.mcml
Markup
Locals	MarkupLocals.mcml
Properties	MarkupProperties.mcml
BaseUI	MarkupBaseUIs.mcml
Host ViewItem	MarkupHostViewItem.mcml
Aggregates	MarkupAggregates.mcml
Accessibility	MarkupAccessibility.mcml
String Table Access	MarkupStringTableAccess.mcml
Color Schemes	MarkupColorSchemes.mcml
Debugging	MarkupDebugging.mcml
Globalization	MarkupGlobalization.mcml
Invoke Command	MarkupInvokeCommand.mcml
Rules
Default Rule	RulesDefault.mcml
Binding	RulesBinding.mcml
Condition	RulesCondition.mcml
Changed	RulesChanged.mcml
Rules Mixed Sample	RulesMixedSample.mcml
IsType Condition	RulesIsTypeCondition.mcml
IsValid Condition	RulesIsValidCondition.mcml
Custom Rules
Equality Condition	RulesCustomRuleEqualityCondition.mcml
Modified Condition	RulesCustomRuleModifiedCondition.mcml
Actions
Set	ActionsSet.mcml
Invoke	ActionsInvoke.mcml
PlaySound	ActionsPlaySound.mcml
PlayAnimation	ActionsPlayAnimation.mcml
View Items
Panel	ViewItemsPanel.mcml
Text	ViewItemsText.mcml
Graphic	ViewItemsGraphic.mcml
ColorFill	ViewItemsColorFill.mcml
ColorFill Colors	ViewItemsColorFillColors.mcml
Clip	ViewItemsClip.mcml
Video	ViewItemsVideo.mcml	X
Now Playing	ViewItemsNowPlaying.mcml	X
Layout
Default Layout	LayoutDefault.mcml
Anchor	LayoutAnchor.mcml
Form	LayoutForm.mcml
Center	LayoutCenter.mcml
Border	LayoutBorder.mcml
Fill	LayoutFill.mcml
HorizontalFlow	LayoutHorizontalFlow.mcml
VerticalFlow	LayoutVerticalFlow.mcml
Margins and Padding	LayoutMarginsPadding.mcml
MinimumSize and MaximumSize	LayoutMinimumSizeMaximumSize.mcml
AnchorToFocus	LayoutAnchorToFocus.mcml
Grid	LayoutGrid.mcml
Rotate Layout	LayoutRotate.mcml
Scale Layout	LayoutScale.mcml
Input
Mouse Focus	InputMouseFocus.mcml
Key Focus	InputKeyFocus.mcml
Input Handlers
Click	InputHandlersClickHandler.mcml
Key	InputHandlersKeyHandler.mcml
Mouse Wheel	InputHandlersMouseWheelHandler.mcml
Shortcut	InputHandlersShortcutHandler.mcml
Stage	InputHandlersStagesHandling.mcml
Typing	InputHandlersTypingHandler.mcml
Focus
FocusOrder	FocusFocusOrder.mcml
NavigateInto	FocusNavigateInto.mcml
Code and Data
Model Item - Code	CodeDataModelItems.cs
Model Item - MCML	CodeDataModelItems.mcml
Threading - Code	CodeDataThreading.cs
Threading - MCML	CodeDataThreading.mcml
Virtualization - Code	CodeDataVirtualization.cs
Virtualization - Code (Utility)	CodeDataVirtualizationUtility.cs
Virtualization - MCML	CodeDataVirtualization.mcml
Transformers
Boolean	TransformersBooleanTransformer.mcml
Date and Time	TransformersDateTimeTransformer.mcml
Format	TransformersFormatTransformer.mcml
Math	TransformersMathTransformer.mcml
Time Span	TransformersTimeSpanTransformer.mcml
Keyboard Navigation
Groups	KeyboardNavigationGroups.mcml
Row and Column	KeyboardNavigationRowColumn.mcml
Container Focus	KeyboardNavigationContainerFocus.mcml
Contain	KeyboardNavigationContain.mcml
Wrap	KeyboardNavigationWrap.mcml
Flow	KeyboardNavigationFlow.mcml
Page Navigation
Navigate and NavigateCommand	PageNavigationNavigateAndNavigateCommand.mcml
HistoryOrientedPageSession	ObjectModelHostingHistoryOrientedPageSession.mcml	X
Scrolling
Scroller ViewItem	ScrollingScrollerViewItem.mcml
Lists	ScrollingLists.mcml
Static Content	ScrollingStaticContent.mcml
Padding	ScrollingPadding.mcml
Locking	ScrollingLocking.mcml
Repeater
Repeater ViewItem	RepeaterRepeaterViewItem.mcml
ListDataSet and ArrayListDataSet	RepeaterListDataSet.mcml
Flow Layout	RepeaterFlowLayout.mcml
Grid Layout	RepeaterGridLayout.mcml
Dividers	RepeaterDividers.mcml
Content Selectors	RepeaterContentSelectors.mcml
Graphics
Image	GraphicsImage.mcml
Alignment	GraphicsAlignment.mcml
Cast String To Image	GraphicsImageStringCast.mcml
Animation - Keyframes
Position	AnimationsKeyframesPosition.mcml
Size	AnimationsKeyframesSize.mcml
Scale	AnimationsKeyframesScale.mcml
Rotate	AnimationsKeyframesRotate.mcml
Alpha	AnimationsKeyframesAlpha.mcml
Color	AnimationsKeyframesColor.mcml
Mixed Sample	AnimationsKeyframesMixedSample.mcml
Animation - Modifiers
RelativeTo	AnimationsRelativeTo.mcml
CenterPoint	AnimationsCenterPoint.mcml
Merge Animation	AnimationsMergeAnimation.mcml
Switch Animation	AnimationsSwitchAnimation.mcml
Animation - Interpolations
Types	AnimationsInterpolationsTypes.mcml
Weight	AnimationsInterpolationsWeight.mcml
Bezier Handles	AnimationsInterpolationsBezierHandles.mcml
EaseInOut	AnimationsInterpolationsEaseInOut.mcml
Animation - Types
Show and Hide	AnimationsTypesShowHide.mcml
Move	AnimationsTypesMove.mcml
Types - Size	AnimationsTypesSize.mcml
Types - Scale	AnimationsTypesScale.mcml
Types - Rotate	AnimationsTypesRotate.mcml
Types - Alpha	AnimationsTypesAlpha.mcml
Gain and Lose Focus	AnimationsTypesGainLoseFocus.mcml
Content Change Show and Hide	AnimationsTypesContentChangeShowHide.mcml
Idle	AnimationsTypesIdle.mcml
Animations Mixed Sample	AnimationsTypesMixedSample.mcml
Animation - Transform
Delay	AnimationsTransformAnimationDelay.mcml
TimeScale	AnimationsTransformAnimationTimeScale.mcml
Magnitude	AnimationsTransformAnimationMagnitude.mcml
Filter	AnimationsTransformAnimationFilter.mcml
Animation - Transform By Attribute
Attribute Delay	AnimationsTransformByAttributeAnimationDelay.mcml
Attribute TimeScale	AnimationsTransformByAttributeAnimationTimeScale.mcml
Attribute Magnitude	AnimationsTransformByAttributeAnimationMagnitude.mcml
Attribute Override	AnimationsTransformByAttributeAnimationOverride.mcml
ValueTransformer	AnimationsTransformByAttributeAnimationValueTransformer.mcml
Controls
Button	ControlsSimpleButton.mcml
Jelly Button	ControlsJellyButton.mcml
Green Ball Button	ControlsGreenBallButton.mcml
Check Box	ControlsSimpleCheckBox.mcml
Radio Group	ControlsSimpleRadioGroup.mcml
Editbox	ControlsSimpleEditbox.mcml
Spinner	ControlsSimpleSpinner.mcml
Color Picker	ControlsColorPicker.mcml
Color Picker With Constants	ControlsColorPickerWithConstants.mcml
Marquee	ControlsMarquee.mcml
List Marquee	ControlsListMarquee.mcml
Clock	ControlsSimpleClock.mcml
Fun
Alphabet Soup	FunAlphabetSoup.mcml
Helix	FunHelix.mcml
Melt	FunMelt.mcml
Movement	FunMovement.mcml
Othello	FunOthello.mcml
Column Expansion	FunColumnExpansion.mcml
.NET Framework Types
StringBuilder	SystemTextStringBuilder.mcml
Regular Expressions	SystemTextRegularExpressionsRegex.mcml
Web
Set Cookies	WebCookiesSet.asp		X
Get Cookies	WebCookiesGet.asp		X
Relative Paths.mcml	WebRelativePaths.mcml		X
Relative Paths (Another)	WebRelativePathsAnother.mcml		X
MediaCenterEnvironment
Dialog	ObjectModelMediaCenterEnvironmentDialog.mcml	X
DialogNotification	ObjectModelMediaCenterEnvironmentDialogNotification.mcml	X
NavigateToPage	ObjectModelMediaCenterEnvironmentNavigateToPage.mcml	X
PlayMedia - Audio	ObjectModelMediaCenterEnvironmentPlayMediaAudio.mcml	X
PlayMedia - Video	ObjectModelMediaCenterEnvironmentPlayMediaVideo.mcml	X
ShowOnScreenKeyboard	ObjectModelMediaCenterEnvironmentShowOnScreenKeyboard.mcml	X
Version	ObjectModelMediaCenterEnvironmentVersion.mcml	X
Capabilities	ObjectModelMediaCenterEnvironmentCapabilities.mcml	X
Media Collection Basic	ObjectModelMediaCenterMediaCollectionBasic.mcml	X
Media Collection Add Item	ObjectModelMediaCenterMediaCollectionAddItem.mcml	X
Media Collection Add Item Repeater	ObjectModelMediaCenterMediaCollectionAddItemRepeater.mcml	X
Background Modes	ObjectModelMediaCenterBackgroundModes.mcml	X
MediaExperience
MediaTransport	ObjectModelMediaExperienceTransport.mcml	X
MediaMetadata - Video	ObjectModelMediaExperienceMediaMetadataVideo.mcml	X
MediaMetadata - Song	ObjectModelMediaExperienceMediaMetadataSong.mcml	X
Url	ObjectModelMediaExperienceUrl.mcml	X
EntryPointID	ObjectModelMediaExperienceEntryPointID.mcml	X
ApplicationContext
Single Instance	ObjectModelApplicationContextSingleInstance.mcml	X
ReturnToApplication	ObjectModelApplicationContextReturnToApplication.mcml	X
InstallApplication	ObjectModelApplicationContextInstallApplication.mcml	X


See Also
•	Developing Applications for Windows Media Center

# Animation Explorer
The Animation Explorer is a tool that helps developers learn about animation keyframes in MCML. You can interact with this graphical user interface, see the resulting MCML, copy and paste the code, and examine the resulting visuals in the MCML Preview Tool.
Note   The tool is limited to a maximum of four keyframes. However, MCML can use an almost unlimited number of keyframes.

See Also
•	Developing Applications for Windows Media Center

# K Media Center Markup Language Verifier
The Windows Media Center Markup Language Verifier (Mcmlverifier.exe) is a command-line tool that verifies the syntax of an MCML file and requires the .NET Framework 2.0 and Microsoft.MediaCenter.UI.dll. Mcmlverifier supports the following command-line parameters:
Parameter	Description
-log:log_file_name	Logs output to the specified file.
-silent	Suppresses output to the console.
-verbose	Enables verbose output mode.
-assemblyredirect:full_path	Specifies a local directory from which to load an assembly to locate markup for verification. McmlVerifier searches this local directory before searching the Global Assembly Cache (GAC) and \windows\ehome.
Only one directory can be specified, and it must not contain a trailing backslash. For example:
-assemblyredirect:c:\directory
Note   This switch does not work if the assembly is also installed into the GAC. The .NET Framework always loads the assembly from the GAC when possible.
-assembly:assembly_that_contains_MCML_files	Specifies an assembly that contains MCML files to verify. All files with an .mcml extension contained as resources in the specified assembly will be verified.
-directory:path_that_contains_MCML_files	Specifies a directory that contains MCML files to verify. All files with an .mcml extension in the specified directory will be verified.
MCML_file_0 MCML_file_1 … MCML_file_N	Specifies a list of individual MCML files to verify, which can be specified with formats such as file://filename.mcml, resx://assemblyname/resourceID, or res://dllname!resourceID.

See Also
•	Development Tools for the Windows Media Center SDK

# K Using the Visual Studio Project Templates for Windows Media Center Presentation Layer Applications
The Windows Media Center SDK includes C# project templates for developing a Windows Media Center Presentation Layer application. The Windows Media Center SDK installs these project templates when Visual Studio 2008 or Visual C# 2008 Express Edition is already installed. However, if you install Visual Studio 2008, and then Visual C# 2008 Express Edition afterwards, you can add the project templates by repairing or reinstalling the Windows Media Center SDK.
The following templates are included:
•	Windows Media Center Application 6.0 creates a project that contains a page with four buttons, which open a Windows Media Center dialog box.
•	Windows Media Center Application - Background 6.0 creates a project for a background application.
•	Windows Media Center Application - Fundamental 6.0 creates a project that contains the minimum code and markup that is required for a Windows Media Center Presentation Layer application.
To learn more about using the application templates, see the Windows Media Center Application Step By Step document, which is located in [WMCSDK_InstallPath]\Docs\WindowsMediaCenterApplicationStepByStep.xps.
Important   For best results, you should read the Readme.htm in your new project before you attempt to modify an application created by the template.
To create a new application using Visual C# 2008 Express Edition:
1.	Start Visual C# 2008 Express Edition.
2.	On the File menu, click New Project.
3.	In the New Project dialog box under Templates, click Windows Media Center Application.
4.	In the Name box, enter a name for the application.
5.	Click OK.
To create a new application using Visual Studio 2008:
1.	Start Visual Studio 2008.
2.	On the File menu, point to New and select Project.
3.	In the Project Types pane, expand Visual C#, and then click Windows Media Center.
4.	In the Templates pane under Visual Studio installed templates, click Windows Media Center Application.
5.	In the Name box, enter a name for the application.
6.	Click OK.
See Also
•	Development Tools for the Windows Media Center SDK

# K Understanding the Fundamentals
This section describes basic concepts to understand before you begin developing Windows Media Center applications in the following topics:
Topic	Description
Overview of the Windows Media Center Platform
Provides an overview of the Windows Media Center platform.
Application Types
Describes the types of Windows Media Center Presentation Layer applications: local, Web, and background.
Creating a Strong-Named Assembly
Describes requirements for strong-name signing your assemblies.
Threads in Windows Media Center
Describes the thread process in Windows Media Center.
Understanding the Windows Media Center Back Stack
Not documented in this release.
Ensuring the Application Has a Single Instance
Describes how to ensure only one instance of the application can be running at a tiime.
Accessing the Windows Media Center APIs
Not documented in this release.
Identifying Windows Media Center Versions
Explains how to detect the presence of Windows Media Center and determine the version that the user is running.
Working with Windows Media Center Presentation Layer Web Applications
Describes the features and limitations of Windows Media Center Presentation Layer Web applications, and how to navigate to other pages.
Using McmlPad to Develop UI
Describes how to use the Media Center Markup Language Preview Tool.

See Also
•	Developing Applications for Windows Media Center

# Overview of the Windows Media Center Platform
The Windows Media Center Platform consists of two parts—the managed code object model and the Windows Media Center Presentation Layer.
Managed Code Object Model
The Windows Media Center managed code object model contains the following namespaces:
•	Microsoft.MediaCenter controls basic Windows Media Center features, such as media playback.
•	Microsoft.MediaCenter.Hosting controls the host process for applications, such as page sessions.
•	Microsoft.MediaCenter.UI works uses classes and model items to work with the Media Center Markup Language (MCML).
•	Microsoft.MediaCenter.DataAccess uses model items to work with RESTful web services to bind MCML UI to XML data directly on the Internet.
•	Microsoft.MediaCenter.TV.Epg retrieves information from the Electronic Program Guide (EPG).
•	Microsoft.MediaCenter.TV.Scheduling programmatically schedules the digital video recorder (DVR).
•	Microsoft.MediaCenter.ListMaker creates lists to be used for CD and DVD burning.
Windows Media Center Presentation Layer
The Windows Media Center Presentation Layer separates an application's visual presentation from its logic by employing a model/view approach:
•	The model provides the logic of the application (the code and data), and is developed using a managed code language, such as C# and the Microsoft .NET Framework. The model is non-visual.
•	The view provides the look and behavior of the application (the user interface), and is authored in Media Center Markup Language (MCML), which is an XML-based declarative language. MCML provides dynamic layout capabilities, integrated animation support, rich text and graphics support, automatic keyboard and remote navigation, parameterization, private local storage, conditional-based data binding, and access to managed code assemblies from markup.
This separation allows the UI to be developed separately from the model items. However, for anything to occur when interacting with the UI, the view must be associated with the model. For example, a button must be associated with code to handle a click event. This binding is achieved by parameters, which are named objects. The managed code object model is markup-accessible and can be called directly from MCML, enabling web application delivery with no need to install additional assemblies.
See Also
•	Developing Applications for Windows Media Center

# Application Types
There are three types of Windows Media Center Presentation Layer applications:
•	A local application consists of an installed managed code assembly and related files. As a locally-installed application, it has access to all computer resources.
•	A Web application uses MCML delivered using the HTTP protocol over the Internet to display rich client UI on the local PC without requiring installation of local files or assemblies. Windows Media Center provides an environment in which the MCML can be hosted and provides full access to Windows Media Center API methods and properties and a subset of Microsoft .NET Framework types to support common scenarios of Web-delivered experiences. A Windows Media Center Presentation Layer Web application has no access to local computer resources.
•	A background application has no user interface, launches soon after Windows Media Center is started, and continues to run until it closes on its own or is forced to close by Windows Media Center. A Windows Media Center Presentation Layer background application can run continuously and transcend individual Windows Media Center experiences and features.
The following are examples of background applications:
•	A sophisticated remote control, such as an application for a Tablet PC that acts as a powerful remote control for a running Windows Media Center on another PC. One way this could be architected could be as a Windows service running on the Windows Media Center PC, hosting a remoting server. The Tablet PC application could connect to the Windows service and issue commands, such as open Windows Media Center, change the channel, and so forth. The Windows service would need to access the Windows Media Center object model.
•	Tools support, such as an application that could start Windows Media Center, navigate to a TV station, take a screen capture, and then close Windows Media Center.
•	TV guide control, such as an application that receives an XMLTV feed for guide data. The application could then use the TV scheduling APIs to change the channel to something the user might like more, after first prompting the user with a dialog box.
See Also
•	Developing Applications for Windows Media Center

# Creating a Strong-Named Assembly
Windows Media Center loads only locally stored assemblies, which reside in the Global Assembly Cache (GAC). For security purposes, the GAC requires that all .NET assemblies, including Windows Media Center applications, have strong names. Therefore, Windows Media Center can only load a Windows Media Center application if it is a strong-named assembly.
The following is the minimum information required to create a strong-named assembly:
•	Assembly title in plain text.
•	Assembly version number.
•	Cryptographic key-pair file used to digitally sign the assembly.
The Strong Name tool (sn.exe) included with the Microsoft .NET Framework 2.0 SDK can also be used to create a strong name key file. This tool creates the key with the file name you specify. The following example creates a pair of cryptographic keys with this tool and stores them in a file called KeyPair.snk:
sn -k KeyPair.snk
Note   Anyone who has access to the key file can sign assemblies with your identity. After you create the strong name key (.snk) file, store the file in a secure location.
Delayed signing is another option for a Windows Media Center application assembly. Delayed signing reserves space in the assembly for the strong name signature, but defers actual signing until a later stage, typically just before shipping the assembly. This process allows you to closely guard your cryptographic key pair during the development stages of your Windows Media Center application.
For more information, see the following topics on the MSDN Web site:
•	Introduction to Code Signing
•	Building Secure Assemblies
•	Delay Signing an Assembly
•	Signing an Assembly with a Strong Name
See Also
•	Developing Applications for Windows Media Center

# Threads in Windows Media Center
Currently, Windows Media Center applications are hosted in an individual ehExtHost.exe process. Applications running on prior versions of Windows Media Center ran concurrent with the Windows Media Center process (ehShell.exe) in their own application domain. Windows Media Center runs each background application in a separate thread, and the application can create as many threads as it needs. Because foreground threads can prevent the application from terminating properly, a multithreaded application should use background threads whenever possible by setting the thread IsBackground property to true.
An application can create as many threads as it wants. However, the Windows Media Center object model is single-threaded. You cannot construct a ModelItem or raise change notifications from a thread other than the main application thread. Most of the methods in the Microsoft.MediaCenter.UI namespace can only be called from the main application thread, with the exception of the methods in the Application class.
The methods in the Microsoft.MediaCenter, Microsoft.MediaCenter.Hosting, and Microsoft.MediaCenter.ListMaker namespaces can be called on any thread, but some of them may block if the main application thread is blocked. Callbacks are supported only on the main application thread.
The methods in the Microsoft.MediaCenter.TV.Epg and Microsoft.MediaCenter.TV.Scheduling namespaces can be called on any thread or on as many as needed. Events are called back on the same thread as you called them from.
Note   Windows Media Center can host up to eight instances of ehExtHost.exe—for instance, if a user presses the Green Start button when navigating third-party applications and starts an application multiple times. If an application needs to share state across instances of ehExtHost.exe, you must implement your own way of determining that another instance of the application is running on the system.
A Windows Media Center application can implement all of the functionality it needs, or it can communicate with separate executables outside of Windows Media Center to implement certain tasks. For example, a Windows Media Center application could be used to manage a process for downloading or retrieving content while Windows Media Center is running, or it could rely on a separate executable running in Windows to retrieve content even when Windows Media Center is not running. Conversely, external applications running outside of the Windows Media Center process can use Windows Media Center applications to access the Windows Media Center object model.
See Also
•	Developing Applications for Windows Media Center

# Understanding the Windows Media Center Back Stack
Windows Media Center holds approximately eight pages in memory at any given time.
The Windows Media Center Start menu is always the base page and can increase the count as the user navigates forward.
An application and all of its pages count as a single Windows Media Center page.
The application has its own back stack, which uses the HistoryOrientedPageSession object. These pages do not count in the Windows Media Center page count.
The back stack is trimmed in two ways:
•	Back navigation: Windows Media Center Pages are discarded from the end of the back stack when the user presses the BACK button.
•	Forward navigation: Windows Media Center Pages are discarded one at a time from the beginning of the back stack each time the user navigates forward past the page count limit.
See Initializing, Launching, and Uninitializing the Application for an explanation of what happens when an application is trimmed from the back stack.
See Also
•	Developing Applications for Windows Media Center

# Ensuring the Application Has a Single Instance
If the application owns the current media experience, the user can return to the application at any time by selecting the Now Playing tile on the Windows Media Center Start menu as long as the application has been marked as single instance (only one instance of the application can be running).
If the application has not yet been trimmed from the Windows Media Center back stack and the user launches it again, ensuring the application is single instance will return to the current instance rather than launching a new instance.
For Web MCML applications, place the following in the landing page:
<Default Target="[AddInHost.ApplicationContext.SingleInstance]" Value="True" />
For installed applications, place the following in the Launch method:
public void Launch(AddInHost host)
{
host.ApplicationContext.SingleInstance = true;
}
See Also
•	ApplicationContext.SingleInstance
•	Developing Applications for Windows Media Center
•	Understanding the Fundamentals

# K Accessing the Windows Media Center APIs
Not documented in this release.
# Checking for Permission to Call APIs
Windows Media Center includes a page called Extras Library Options that lets the user place restrictions on Windows Media Center applications for reasons of security and privacy. These settings determine whether Windows Media Center applications are allowed to control Windows Media Center and retrieve its settings, and whether applications can retrieve Windows Media Center metadata.
Windows Media Center application developers should be aware of these settings and design applications to handle them appropriately.
To determine the current control level when using managed code, monitor the following exceptions that are thrown when you try to use an API, which indicate a restriction:
•	ApplicationAccessDisabledException
•	ApplicationControlDisabledException
•	MetadataAccessDisabledException
•	StateDetectionDisabledException
See Also
•	Managing User Account Control and Security Issues
# K Initializing, Launching, and Uninitializing the Application
Initializing the Application
All Windows Media Center applications must implement two interfaces: IAddInModule and IAddInEntryPoint. These interfaces expose methods that are called by Windows Media Center.
The IAddInModule interface exposes the Initialize and Uninitialize methods. Initialize is the first method that Windows Media Center calls when it loads the application, giving the application an opportunity to initialize internal variables and obtain any system resources that it needs.
Launching the Application
After calling IAddInModule.Initialize, Windows Media Center calls an application's IAddInEntryPoint.Launch method, passing an instance of the AddInHost object to the application. This object lets the application access objects in the Microsoft.MediaCenter namespace to retrieve information about Windows Media Center and to control certain aspects of the Windows Media Center experience.
The AddInHost object is guaranteed to be valid only until the Launch method returns. Therefore an application must make all calls to the Windows Media Center APIs within the context of the Launch method. Attempting to call the AddInHost object after the Launch method returns can result in a fatal error. Multiple threads spawned by the Launch method must be terminated before the Launch method returns.
After calling the Launch method, if you do not use the host object, the object could be released because .NET Remoting releases objects every five minutes if they are not used. To avoid this, use the host object or use the objects within five minutes to prevent them from being released.
Terminating the Application
Before terminating an application, Windows Media Center calls the application's IAddInModule.Uninitialize method and then briefly waits for the application to save its state, terminate any threads it created, and free any other system resources that it may have allocated. If the application's Uninitialize method does not return quickly enough, Windows Media Center unloads the application's application domain, terminating the application.
You should assume that your application can be interrupted at any time (for instance, if the user closes Windows Media Center). Design the application to perform lengthy operations in small steps, saving its state after each step if necessary. Using this approach, the application can continue if it was previously interrupted.
If your application needs a more deterministic environment, you should implement the application as an executable program that runs outside of Windows Media Center and use a helper application to manipulate the Windows Media Center aspects of the application.
Example Code
using System;
using System.Collections.Generic;

using Microsoft.MediaCenter;
using Microsoft.MediaCenter.Hosting;

namespace Microsoft.Samples
{
    public sealed class QAddIn : IAddInModule, IAddInEntryPoint
    {
        public void Initialize(Dictionary<string, object> appInfo, Dictionary<string, object> entryPointInfo)
        {
        }

        public void Uninitialize()
        {
        }

        public void Launch(AddInHost host)
        {
            s_session = new QPageSession();

            s_session.NavigateToFirstPage();
        }

        private QPageSession s_session;
    }

    internal class QPageSession : HistoryOrientedPageSession
    {
        public void NavigateToFirstPage()
        {
            GoToPage("resx://Q/Q.Resources/Main", null, null);
        }
    }
}

# K Accessing the Windows Media Center Object Model in Markup
To interact with Windows Media Center services (such as to play music and video), use the Windows Media Center managed code object model API. For more information, see the Managed Code Object Model Reference.
To access this API in MCML, you must reference the namespaces using xmlns statements. All Windows Media Center services start with the AddInHost class, which is located in the Microsoft.MediaCenter.Hosting namespace. The following example shows how to reference this in MCML:
xmlns:addin="assembly://Microsoft.MediaCenter/Microsoft.MediaCenter.Hosting"

Then, create the objects in the Locals section of the UI.
<Locals>
    <addin:AddInHost Name="AddInHost"/>
</Locals>

The following example shows how to access the Windows Media Center API to create a simple dialog box with two buttons. This example is also located in the MCMLSampler (see the example "MediaCenter Services" under Media Center Integration). For more information about the MCMLSampler, see Sample Explorer.
<Mcml
  xmlns="http://schemas.microsoft.com/2006/mcml"
  xmlns:cor="assembly://MSCorlib/System"
  xmlns:addin="assembly://Microsoft.MediaCenter/Microsoft.MediaCenter.Hosting"
  xmlns:mc="assembly://Microsoft.MediaCenter/Microsoft.MediaCenter"
  xmlns:sb="res://McmlSampler!Scenarios.SimpleButton.mcml">

    <!-- This sample demonstrates how to access MediaCenter services to -->
    <!-- display a dialog box and track the result of the dialog box. -->

    <UI Name="MediaCenterServices">

        <Locals>

            <!-- AddInHost is where all Media Center-specific services start. -->
            <!-- Create the object in the Locals section of a markup file. -->
            <addin:AddInHost Name="AddInHost"/>

            <!-- The dialog box result is stored here. The type is in another -->
            <!-- namespace, so it has a different xmlns prefix than the -->
            <!-- AddInHost type. -->
            <mc:DialogResultHandler Name="ResultHandler"/>


            <!-- These buttons will be displayed in the dialog box. -->
            <ArrayListDataSet Name="DialogButtons">
                <Source>
                    <cor:String cor:String="Hello"/>
                    <cor:String cor:String="Goodbye"/>
                </Source>
            </ArrayListDataSet>

        </Locals>

        <Rules>
            <!-- When the dialog box is closed, bind the result to the Text content. -->
            <Changed Source="[ResultHandler.DialogDismissed]">
                <Actions>
                    <Set Target="[Label.Content]" Value="[ResultHandler.Result.ToString]"/>
                </Actions>
            </Changed>

            <!-- Set the initial value of the text, which is empty. -->
            <Default Target="[Label.Content]" Value=" "/>

        </Rules>

        <Content>

            <Panel>
                <Layout>
                    <FlowLayout Orientation="Vertical" ItemAlignment="Center"/>
                </Layout>

                <Children>
                    <!-- The value is displayed. -->
                    <Text Name="Label" Color="White" Font="Verdana,80"/>

                    <!-- This button has a property called Command, which -->
                    <!-- accepts any command. -->
                    <sb:SimpleButton>
                        <Command>
                            <!-- InvokeCommand calls the Dialog method on the -->
                            <!-- AddInHost.MediaCenterEnvironment object. The dialog -->
                            <!-- box takes text, captions, buttons, timeout and isModal -->
                            <!-- parameters. This sample has hard-coded values for -->
                            <!-- these parameters. When the dialog box is dismissed, the -->
                            <!-- DialogClosed event on the ResultHandler is fired. -->
                            <!-- The Changed rule propagates the return value to the -->
                            <!-- Label text. -->
                            <!-- Since this is an InvokeCommand, object paths can be -->
                            <!-- used for any of the parameters and they will be -->
                            <!-- evaluated on every invocation. -->
                            <InvokeCommand Description="Click to show a dialog box"
                                           Target="[AddInHost.MediaCenterEnvironment.Dialog]"
                                           text="Hello!"
                                           caption="Media Center Dialog Box"
                                           buttons="[DialogButtons]"
                                           timeout="0"
                                           isModal="true"
                                           imagePath="null"
                                           callback="[ResultHandler.Callback]"/>

                        </Command>
                    </sb:SimpleButton>
                </Children>
            </Panel>
        </Content>
    </UI>
</Mcml>

See Also
•	Sample Explorer
•	Media Center Markup Language Verifier


See Also
•	Developing Applications for Windows Media Center
•	Understanding the Fundamentals

# K Identifying Windows Media Center Versions
Windows Media Center Presentation Layer Applications
If you are creating a setup package for a Windows Media Center application, you should detect the presence of Windows Media Center before allowing installation of your application. In addition, if your application has a dependency on a specific version of Windows Media Center, your setup package should also detect the presence of that specific version and block installation if it is not installed. You can detect the presence and version of Windows Media Center by looking at the following registry key:
Key: HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Media Center
Registry value name: Ident
Registry value data type: REG_SZ
The Ident value indicates the version of Windows Media Center that is present on the computer:
Windows Media Center Version	Ident value
Windows XP Media Center Edition 2002 	< 2.7
Windows XP Media Center Edition 2004	2.7 or 2.8
Windows XP Media Center Edition 2005 (incorporating Windows XP SP2)	3.0
Update Rollup 1 for Windows XP Media Center Edition 2005 	3.1
Update Rollup 2 for Windows XP Media Center Edition 2005 	4.0
Windows Media Center in Windows Vista 	5.0
Windows Media Center TV Pack	Not documented in this release.
Windows Media Center in Windows 7	Not documented in this release.

See Also
•	Understanding the Fundamentals

# K Working with Windows Media Center Presentation Layer Web Applications
Windows Media Center Presentation Layer Web applications have access to the same set of Windows Media Center APIs as local applications and support the following features:
•	MCML UI can be delivered over the Web, without requiring any deployment of code to the user's system.
•	Entry points can be registered and appear in all of the same places that other types of Windows Media Center applications can appear (such as the Extras Library).
•	Users can navigate to other MCML pages on the Web server.
•	Web applications can invoke actions on the server using form submission (GET and POST commands).
•	There are no restrictions on where you can load images, sounds, and videos. However, other MCML UI elements must be located in the same domain from which the original UI element is loaded.
This section contains the following topics.
Topic	Description
Limitations of Windows Media Center Presentation Layer Web Applications
Lists the limitations of Web-based applications.
Allowed Types for Web Applications
Lists the .NET Framework types that are supported by Web-based applications.
Web-Based Navigation
Describes how Web-based applications can navigate to other Web pages.
Navigating to Other Pages in a Windows Media Center Presentation Layer Web Application
Describes how to navigate to other pages within a Windows Media Center Presentation Layer Web application.
Binding to XML Data From the Web
Describes how applications can request XML data from RESTful Web services to bind a view item in MCML to XML data.
Updating Data in a Windows Media Center Presentation Layer Web Application
Describes how to update data in a Windows Media Center Presentation Layer Web application without reloading the entire page.
Cookie Support
Describes how to work with Web cookies.

See Also
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Limitations of Windows Media Center Presentation Layer Web Applications
Web-based applications have the following limitations:
•	Web applications must be launched from a registered entry point within Windows Media Center. An entry point can be registered by using RegisterMCEApp.exe or the RegisterApplication method.
•	To protect data sent to the server, Web applications must use Secure Sockets Layer (SSL) for POST commands.
•	Web applications can only reference other UI elements that are hosted in the domain from which the application was originally launched.
•	A local Windows Media Center Presentation Layer application cannot navigate directly to an HTTP address for a Windows Media Center Presentation Layer Web application.
See Also
•	Sample Explorer
•	Media Center Markup Language Verifier
•	Working with Windows Media Center Presentation Layer Web Applications

# K Allowed Types for Web Applications
Web applications are restricted to the following .NET Framework types:
•	Microsoft.MediaCenter.dll
•	All public types
•	Microsoft.MediaCenter.UI.dll
•	All public types
•	mscorlib.dll (System namespace)
•	System.Boolean
•	System.Byte
•	System.Char
•	System.Collections.IDictionary
•	System.Collections.IList
•	System.DateTime
•	System.DateTimeKind
•	System.DayOfWeek
•	System.Decimal
•	System.Double
•	System.Guid
•	System.Int16
•	System.Int32
•	System.Int64
•	System.Object
•	System.Random
•	System.SByte
•	System.Single
•	System.String
•	System.Text.RegularExpressions.Regex
•	System.Text.StringBuilder
•	System.TimeSpan
•	System.TimeZone
•	System.UInt16
•	System.UInt32
•	System.UInt64
•	System.Version
•	System.dll
•	System.Uri
See Also
•	Sample Explorer
•	Media Center Markup Language Verifier
•	Working with Windows Media Center Presentation Layer Web Applications

# K Web-Based Navigation
Both the Navigate and NavigateCommand elements in MCML support Web-based navigation in addition to resource-based and file-based navigation. You can pass properties to the resulting UI in Web-based navigations just as you can for resource-based and file-based navigations.
The Data attribute of the Navigate element for a Web-based navigation lets you pass data to the resulting UI. You can also specify the request method by using RequestMethod, which is a reserved keyword that can only be set to "GET" or "POST". The request method is set as part of the Data attribute for a Web-based navigation as follows:
<Navigate Source="http://play.mediacentersandbox.com/Greeting.asp">
    <Data>
        <cor:String Name="RequestMethod" String="GET"/>
        <ObjectPath Name="Name" ObjectPath="[YourName.Value]"/>
    </Data>
</Navigate>

If a request method is not specified, the default method is POST, which requires an SSL connection for security reasons. When passing sensitive data to the Web server, use a POST command because the data is not embedded in the URI of the Web request.
The example below shows how to invoke navigation after submitting data from an edit box. The source is set to an ASP page on a Web server. The request method is set to GET, so the data is passed as part of the URI. The data contains the value of the Name attribute, which corresponds to the text in the edit box. The actual query string passed to the Web server is as follows:
http://play.mediacentersandbox.com/Greeting.asp?Name=MyName
Because Web applications can only reference other UI elements that are hosted in the same domain from which the application was originally launched, you must load the sample from the Web site, or register it as an application in Windows Media Center.
•	To load the sample directly from the Web site, open McmlPad and enter the following path as the URI: http://play.mediacentersandbox.com/hello.mcml
•	To register the sample as an application, save the following XML, replacing the GUIDs with ones you generate:
<application title="Hello World Web Application" id="{PUT_APP_GUID_HERE}">
    <entrypoint id="{PUT_ENTRYPOINT_GUID_HERE}"
                addin="Microsoft.MediaCenter.Hosting.WebAddIn,Microsoft.MediaCenter"
                title="Hello World Web Application"
                description="Hello World Web Application"
                context="http://play.mediacentersandbox.com/hello.mcml">
        <category category="More Programs"/>
    </entrypoint>
</application>

Note   When registering Web-based applications, use the starting URI for the application as the value of the context attribute.
Then, run the following command to register the application, replacing the path and file name where you saved the XML:
C:\Windows\ehome\RegisterMCEApp.exe /allusers Path_and_Filename.xml
The sample code that shows Web-based navigation is as follows.
<Mcml
  xmlns="http://schemas.microsoft.com/2006/mcml"
  xmlns:ctl="http://play.mediacentersandbox.com/SimpleControls.mcml"
  xmlns:cor="assembly://MsCorLib/System"
  xmlns:me="Me">

  <UI Name="HelloMCML">

    <Locals>
      <EditableText Name="YourName"/>
    </Locals>

    <Rules>
      <Changed Source="[YourName.Submitted]">
        <Actions>
          <Navigate Source="http://play.mediacentersandbox.com/Greeting.asp">
            <Data>
              <cor:String Name="RequestMethod" String="GET"/>
              <ObjectPath Name="Name" ObjectPath="[YourName.Value]"/>
            </Data>
          </Navigate>
        </Actions>
      </Changed>
    </Rules>

    <Content>

      <Panel>
        <Layout>
          <FlowLayout Orientation="Vertical" ItemAlignment="Center"
                      Spacing="10,0"/>
        </Layout>
        <Children>

          <Text Content="Hello Codeless MCML!" Color="Gainsboro" Font="Tahoma,35"/>

          <Text Content="Please enter your name for a custom greeting:"
                Color="CornflowerBlue" Font="Tahoma,14"/>

          <ctl:Editbox EditableText="[YourName]"
                       BackgroundColor="Silver"
                       BackgroundFocusedColor="White"
                       LabelColor="CornflowerBlue"
                       LabelFocusedColor="CornflowerBlue"/>

        </Children>
      </Panel>
    </Content>
  </UI>
</Mcml>

See Also
•	Sample Explorer
•	Media Center Markup Language Verifier
•	Working with Windows Media Center Presentation Layer Web Applications

# K Navigating to Other Pages in a Windows Media Center Presentation Layer Web Application
You can use Windows Media Center objects to navigate to other pages:
•	PageSession does not implement a page stack. Invoking a Back navigation returns the user to Windows Media Center.
•	HistoryOrientedPageSession implements an internal page stack and tracks page navigation. Use this object for multi-page applications.
It is not necessary to create a Back button and add functionality to navigate back in the page stack—the remote control Back button automatically handles this behavior for your application.
By default, Windows Media Center creates a HistoryOrientedPageSession object for all Windows Media Center Presentation Layer Web applications. To use the HistoryOrientedPageSession object in a Windows Media Center Presentation Layer Web application, you must define a PageSession property in the Properties section of the UI element, and it must be named "Session". For example:
<Properties>
    <host:PageSession Name="Session" PageSession="$Required"/>
</Properties>

You can use this session to invoke the HistoryOrientedPageSession.BackPage action to navigate to the previous page that you navigated from. For example:
<InvokeCommand Description="Go back to previous page"
               Target="[Session!host:HistoryOrientedPageSession.BackPage]" />

This syntax only works within a multi-page Windows Media Center Presentation Layer Web application.
You cannot use the Back page action to fully exit your application. You must use a method such as ApplicationContext.CloseApplication or PageSession.Close to force a back navigation from the first page of the application to Windows Media Center.
The following example shows how to define a page session in an application and navigate to the previous page.
<Mcml
  xmlns="http://schemas.microsoft.com/2006/mcml"
  xmlns:host="assembly://Microsoft.MediaCenter/Microsoft.MediaCenter.Hosting"
  xmlns:cor="assembly://MsCorLib/System"
  xmlns:me="Me">

  <UI Name="CodelessPageSessionExample">

    <Properties>

      <host:PageSession Name="Session" PageSession="$Required"/>

    </Properties>

    <Content>

      <Panel Layout="Center">

        <Children>

          <me:Button>
            <Command>
              <InvokeCommand Description="Go back to previous page"
                             Target="[Session!host:HistoryOrientedPageSession.BackPage]"
              />
            </Command>
          </me:Button>

        </Children>

      </Panel>

    </Content>

  </UI>

  <!-- Simple button -->
  <UI Name="Button">

    <Properties>

      <!-- Command is a required parameter. -->
      <ICommand Name="Command" ICommand="$Required"/>

    </Properties>

    <Locals>

      <!-- React to "click" input. -->
      <ClickHandler Name="Clicker" Command="[Command]"/>

    </Locals>

    <Rules>

      <!-- The command's description is displayed by the text box. A -->
      <!-- binding is used in the event the description changes at   -->
      <!-- run time.                                                 -->
      <Binding Source="[Command.Description]" Target="[Label.Content]"/>

    </Rules>

    <Content>

      <!-- Solid background color. -->
      <ColorFill Name="Background" Content="DimGray" MouseInteractive="true" Padding="5,5,5,5">
        <Children>

          <!-- The label to display. -->
          <Text Name="Label" Color="White" Font="Arial,20"/>

        </Children>
      </ColorFill>
    </Content>
  </UI>
</Mcml>

See Also
•	Sample Explorer
•	Media Center Markup Language Verifier
•	Working with Windows Media Center Presentation Layer Web Applications

# Binding to XML Data From the Web
The Data Access API, defined in the Microsoft.MediaCenter.DataAccess namespace, allows Windows Media Center Presentation Layer applications to request XML data from RESTful Web services within MCML. This allows the application to bind a view item in MCML to XML data (a remote resource) from the Web.
•	A Uniform Resource Identifier (URI) specifies the location of the resource for the data request, which returns a response document.
•	An XPath query string is used to get data within the XML response document and map it to a view item. Because XML is not typed, mappings are used to specify the data type of the XML source data so that it can be bound to the view item.
Process Overview
The basic process is as follows.
1.	In the Properties section of the UI:
•	Specify the URI to the resource using the RemoteResourceUri class.
•	Set up the remote resource using the RemoteResource class.
•	Set up the mappings for the different remote values in the remote resource using the RemoteValue class.
•	For remote values of the same type (repeated data), you can create a remote value list using the RemoteValueList class. A remote value list contains the repeated remote values and possibly additional lists.
The following example shows the setup for a remote resource:
<Properties>
  <da:RemoteResourceUri Name="MyUri"/>
  <da:XmlRemoteResource Name="MyResource">
    <Mappings>
      <da:XmlRemoteValue Name="Artist"
                         Type="cor:String"
                         Source="/album/@artist" />
      <da:XmlRemoteValue Name="Title"
                         Type="cor:String"
                         Source="/album/@title" />
      <da:XmlRemoteValueList Name="Tracks"
                             RepeatedType="PropertySet"
                             Source="/album/tracks/track" >
        <Mappings>
          <da:XmlRemoteValue Property="Entries.#Title"
                             Type="cor:String"
                             Source="/@title" />
          <da:XmlRemoteValue Property="Entries.#Art"
                             Type="cor:String"
                             Source="/@art" />
        </Mappings>
      </da:XmlRemoteValueList>
    </Mappings>
  </da:XmlRemoteResource>
</Properties>
Note   For XML-specific parsing and mapping, applications can use the following classes:
•	XmlRemoteValue
•	XmlRemoteValueList
•	XmlRemoteResource
2.	Initiate the XML data request in the Rules section using the RemoteResource.GetDataFromResource method. For example:
<Rules>
    <Changed Source="[MyCommand.Invoked]">
        <Actions>
            <Invoke Target="[MyResource.GetDataFromResource]" InvokePolicy="Synchronous"/>
        </Actions>
      </Changed>
</Rules>
3.	The RemoteResource object processes the response and parses the data that is received.
4.	The application can set up rules to bind the source XML data to a target. The following example shows the correct syntax.
Note   Although the data type was already mapped in the Properties section, it must be cast again.
<Binding Target="[MyArtist.PropertyValue]"
    Source="[MyResource.Mappings.#Artist!da:XmlRemoteValue.String]" >
5.	The application can query several properties in the RemoteResource object for information about the request, such as whether the request is complete or has changed. Query the ResponseStatusCode and ResponseStatusDescription properties within a Changed rule for status information.
For more information about media collections, see the WebDataBasic.mcml and WebDataBasicData*.xml samples in the Sample Explorer.
See Also
•	Developing Applications for Windows Media Center
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Updating Data in a Windows Media Center Presentation Layer Web Application
This sample demonstrates how to use a Host view item to access data that is created dynamically on a Web server without requiring the page to reload. This process is useful when you want to update a page that contains numerous resources that you do not want to download again, or if you want to avoid visible flashing and transitions for page reloads.
The example below contains a UI that contains a data transfer object, which wraps a Host view item, a simple button to trigger the data transfer, a Text view item to relay status information, and a Repeater to display the retrieved data. The Repeater is not being replaced; rather, the data that is provided to the repeater is replaced with the updated contents.
Note   You must provide a URL for source data before using this sample.
<Mcml
    xmlns="http://schemas.microsoft.com/2006/mcml"
    xmlns:cor="assembly://MSCorLib/System"
    xmlns:me="Me">

  <UI Name="Main">

    <Properties>
      <Color Name="Color" Color="Blue"/>
    </Properties>

    <Rules>
      <Binding Target="[Repeater.Source]" Source="[DataSet]"/>
      <Binding Target="[StatusText.Content]" Source="[RequestStatus.Value]"/>
    </Rules>

    <Locals>
      <!-- The command that will invoke the refresh.   -->
      <Command Name="DataCommand" Description="Load New Data"/>

      <!-- The DataSet that will contain the ResultSet. -->
      <ArrayListDataSet Name="DataSet" />

      <!-- Text to contain reported status information. -->
      <EditableText Name="RequestStatus" />
    </Locals>

    <Content>
      <Panel Layout="Form">
        <Children>
          <ColorFill Content="[Color]" Layout="VerticalFlow">
            <Children>
              <!-- TO DO: Replace the TargetSource with a URL where the data should come from. -->
              <me:DataTransfer Name="DataHost" ResultSet="[DataSet]" RequestStatus="[RequestStatus]"
                               TargetSource="REPLACE_WITH_A_URL" RefreshCommand="[DataCommand]" />

                  <me:Button Command="[DataCommand]" />
                  <ColorFill Content="AliceBlue">
                    <Children>
                      <Text Name="StatusText" />
                    </Children>
                  </ColorFill>

                  <Repeater Name="Repeater" Layout="VerticalFlow">
                    <Content>
                      <Text Content="[RepeatedItem!cor:String]" />
                    </Content>
                  </Repeater>
                </Children>
          </ColorFill>
        </Children>
      </Panel>
    </Content>
  </UI>

  <!-- The DataTransfer UI can be used to load data from the TargetSource. Data will   -->
  <!-- be loaded when TargetSource is modified, or when the RefreshCommand is invoked. -->
  <!-- The status of the contained host is reported through RequestStatus. When the    -->
  <!-- Host status has changed to "Success", a rule will fire that will extract the    -->
  <!-- ResultSet property from the contained Host and pass the result up by setting it -->
  <!-- on the ArrayList passed by the user.                                            -->
  <UI Name="DataTransfer">

    <Properties>
      <cor:String Name="TargetSource" String="$Required"/>
      <ICommand Name="RefreshCommand" ICommand="$Required"/>
      <ArrayListDataSet Name="ResultSet" ArrayListDataSet="$Required"/>
      <EditableText Name="RequestStatus" EditableText="$Required"/>
    </Properties>

    <Rules>
      <!-- Force a Refresh of the Data. -->
      <Changed Source="[RefreshCommand.Invoked]">
        <Actions>
          <Invoke Target="[DataHost.ForceRefresh]" />
        </Actions>
      </Changed>

      <!-- Bind the Source for the DataHost. -->
      <Binding Target="[DataHost.Source]" Source="[TargetSource]" />

      <!-- Bind DataHost.Status to RequestStatus.Value to Filter up status info. -->
      <Binding Target="[RequestStatus.Value]" Source="[DataHost.Status]" >
        <Transformer>
          <FormatTransformer/>
        </Transformer>
      </Binding>

      <!-- If the status has changed and the value is not "Success," then we have -->
      <!-- completed a load. If so, grab the ResultSet and pass it up.            -->
      <Changed Source="[DataHost.Status]" InitialEvaluate="true">
        <Conditions>
          <Equality Source="[DataHost.Status]" Value="Success" />
        </Conditions>
        <Actions>
          <Set Target="[ResultSet.Source]" Value="[DataHost.ResultSet]" />
        </Actions>
      </Changed>
    </Rules>

    <Content>
      <me:ArrayListDataSetResultHost Name="DataHost" ThrowOnLoadError="false" />
    </Content>
  </UI>

  <!-- Any Data should conform to this format.  It should be valid MCML that -->
  <!-- contains a UI with a ResultSet Property.                              -->
  <UI Name="ArrayListDataSetResultHost">

    <Properties>
      <ArrayListDataSet Name="ResultSet"/>
    </Properties>

  </UI>


  <UI Name="Button">

    <Properties>
      <!-- Command is a required parameter. -->
      <ICommand Name="Command" ICommand="$Required"/>
    </Properties>

    <Locals>
      <!-- React to "click" input. -->
      <ClickHandler Name="Clicker" Command="[Command]"/>
    </Locals>

    <Rules>
      <!-- The command's description is displayed by the text box. A -->
      <!-- binding is used in the event the description changes at   -->
      <!-- runtime.                                                  -->
      <Binding Source="[Command.Description]" Target="[Label.Content]"/>
    </Rules>

    <Content>
      <!-- Solid background color. -->
      <ColorFill Name="Background" Content="DimGray" MouseInteractive="true" Padding="5,5,5,5">
        <Children>
          <!-- The label to display. -->
          <Text Name="Label" Color="White" Font="Arial,20"/>
        </Children>
      </ColorFill>
    </Content>

  </UI>
</Mcml>

For more information about the Host view item, see the AdvancedMarkup.HostViewItem.mcml sample in the Sample Explorer.
See Also
•	Sample Explorer
•	Media Center Markup Language Verifier
•	Working with Windows Media Center Presentation Layer Web Applications
# Cookie Support
Windows Media Center SDK supports persistent and session cookies, which you can use to save data such as user authentication and state information. Simply include scripting code within your MCML document.
The following example shows how to retrieve cookies.
<%
sessionCookie = Request.Cookies("McmlCookieTestSession")
persistentCookie = Request.Cookies("McmlCookieTestPersistent")
%>

<Mcml xmlns="http://schemas.microsoft.com/2008/mcml">

  <UI Name="GetCookies">

    <Content>
      <Panel Layout="VerticalFlow">
        <Children>
          <Text Content="Get Cookies" Color="White" />
          <Text Content="Session: <%=sessionCookie%>" Color="White" />
          <Text Content="Persistent: <%=persistentCookie%>" Color="White" />
        </Children>
      </Panel>
    </Content>
  </UI>
</Mcml>

For more information about supporting cookies, see the WebCookiesGet.asp and WebCookiesSet.asp samples in the Sample Explorer.
See Also
•	Developing Applications for Windows Media Center

# Using McmlPad to Develop UI
McmlPad lets you develop individual portions of a UI, and is specifically designed to not scale the MCML content when you view it in stand-alone mode. When you view the MCML content in Windows Media Center, McmlPad inherits the proportional scaling that is applied to all applications that run within Windows Media Center.
One reason for this design is for the authoring and preview cycle in UI design so that you can view the UI at full size (for example, when working on a small feature within the UI). Because Windows Media Center scales the content proportionally to the window, the visual elements can get quite small when you want to switch quickly between your MCML authoring environment and McmlPad. For example, compare the size of the button in each of the windows in the following figure. The window on the left shows McmlPad running in Windows Media Center and is scaled smaller. The window on the right shows the stand-alone version of McmlPad and the content is full size:

Evaluating Layout and Behavior
In stand-alone mode, McmlPad lets you see how your layout looks and works in different sizes and aspect ratios. Windows Media Center is mostly designed for widescreen (16:9) and standard (4:3) display. You can also set the screen resolution to a different size (such as 1920 × 1200 pixels for a 16:10 aspect ratio) and run Windows Media Center at full screen to view different aspect ratios. However, changing the screen resolution this way can be tedious during UI development. By contrast, you can run McmlPad with an arbitrary size. The following figure shows the snowflake sample gallery at a 4:1 aspect ratio:

When the size of the window is increased, the gallery grows to accommodate more rows and columns of data without having to change the panel that contains the snowflakes, recompiling, installing to the GAC, or registering it in Windows Media Center. Instead, because there is no proportional scaling, the item sizes remain unchanged and more snowflakes are displayed. The following figure shows the result:

The following tips are useful for working with McmlPad:
•	To view proportional scaling in McmlPad, use <ScaleLayout MaintainAspectRatio="true" AllowScaleUp="true" AllowScaleDown="true"/> in your test harness. For an example, see the <UI Name="TestWrapper"> markup in the Default.mcml file in the Z sample application.
•	To switch between 16:9 and 4:3 aspect ratios, select the top or bottom window frame, hold CTRL, and size the window up or down. The window snaps to the 16:9 aspect ratio. To reverse, select the right or left window frame, hold CTRL, and size the window up or down.
Testing Pages
McmlPad has a page concept, but it is distinctly different and simpler than the page concept (the PageSession and HistoryOrientedPageSession classes) within Windows Media Center. A page is basically a <UI Name="Pagename"> element in markup, but the underlying functionality for what a page does is provided by Windows Media Center. McmlPad is designed to work with the visual layer of the platform only. So, once you are ready to test page behavior, you should also use McmlPad within Windows Media Center (rather than the stand-alone version) to test the UI and application.
An even better approach is to test the page behavior early in the application development cycle using wire-frame resources. The simple button in the Sample Explorer provides an example of UI to use as a placeholder to implement and test the layout and data binding that involves your page variables. You can replace the simple button later with a button that is fully designed.
Testing UI
In stand-alone mode, McmlPad allows you the flexibility to create a test harness for your UI. The following figure shows an example of a simple test harness for a button:

McmlPad in Windows Media Center (the top right window) is running an application (a compiled assembly) for testing the button functionality. In this example, it calls a method to display a Windows Media Center dialog box.
McmlPad in stand-alone mode (the bottom right window) shows the result of pressing F5 in Visual Studio—the MCML code is loaded and shows the different ways to instantiate the button using different properties.
The following figure shows a test harness for the Z sample application, which takes advantage of MCML layouts and rules to step through all of the UI:

On the right, each UI defines an individual page within the Z sample application. Selecting an item loads an MCML <UI> into the larger, 4:3 area on the left. This test harness is defined by Default.mcml in the sample code, which is included with the Windows Media Center SDK.
Use the following procedure to use the F5 test harness functionality in Microsoft Visual C# 2008 Express Edition with the Z sample application (otherwise, McmlPad reports an exception and closes when you press F5 because the Z test harness can't find the data):
1.	Open a command prompt with administrator privileges.
2.	Navigate to C:\Program Files\Microsoft SDKs\Windows Media Center\v6.0\Samples\Windows Media Center Presentation Layer Samples\Z\.
3.	Run Command.CreateDevEnvironment.cmd.
4.	Make the following changes in Microsoft Visual C# 2008 Express Edition:
•	In Solution Explorer, select Solution 'Z' (2 Projects).
•	From the Project menu, select Set as Startup Projects.
•	From the Project menu, select Properties.
•	In Solution Z Property Pages, under Common Properties click Startup Project.
•	Select Single Startup Project, and then select Z from the drop-down list.
•	Click OK.
5.	From the Debug menu, select Start Debugging (or press F5) to start the Z test harness.
To start McmlPad from within Microsoft Visual C# 2008 Express Edition, you must edit the .csproj file for the solution because the Start Action setting is not available in the Visual C# 2008 Express Edition. The following example code from the Z.csproj file shows the additional XML code:
<PropertyGroup>
    <UseVSHostingProcess>true</UseVSHostingProcess>
    <StartWorkingDirectory>$(windir)\eHome</StartWorkingDirectory>
    <StartArguments>-load:"resx://Z/Z.Resources/Default" -assemblyredirect:"$(FullyQualifiedOutputPath)" -markupredirect:"resx://Z/Z.Resources/,file://$(MSBuildProjectDirectory)\Markup\,.mcml"</StartArguments>
    <StartAction>Program</StartAction>
    <StartProgram>$(windir)\eHome\McmlPad.exe</StartProgram>
</PropertyGroup>
The XML code contains the following McmlPad parameters:
•	-load:"resx://Z/Z.Resources/Default"
Loads the Z assembly and navigates to the Default.mcml resource. Default.mcml is never used by the application once installed—its only purpose is to provide the test harness.
•	-assemblyredirect:"$(FullyQualifiedOutputPath)"
Loads the assembly from a specific location. When $(FullyQualifiedOutputPath) is evaluated, it returns a path such as C:\Program Files\Microsoft SDKs\Windows Media Center\v6.0\Samples\Windows Media Center Presentation Layer Samples\Z\bin\Debug\. This does not work if the assembly is registered to the Global Assembly Cache, so be mindful of when you run Command.InstallAndRegister.cmd contained in the sample solution.
•	-markupredirect:"resx://Z/Z.Resources/,
file://$(MSBuildProjectDirectory)\Markup\,.mcml"
Replaces instances of resx:// with file:// and appends .mcml. This allows you to build the assembly once, load the Default.mcml test harness into McmlPad, make changes to the source MCML, and test the results of those changes by refreshing McmlPad without having to rebuild the assembly.
You can use these McmlPad parameters at the command line or by using the Media Center Markup Language (MCML) Preview Tool Launcher PowerToy. These parameters allow you to create a compiled assembly and open MCML files directly in McmlPad to edit and preview your changes in real time, and to view changes to markup by refreshing McmlPad. And, you avoid having to recompile, install to the GAC, and register the application in Windows Media Center. The following figure shows the MCML Preview Tool Launcher PowerToy:

In this example, the PowerToy sets the command-line parameters for McmlPad. After changing the markup, you can press F5 to refresh the McmlPad window without needing to recompile. This also allows you to make changes to the UI without committing them to the compiled assembly.
# K Debugging
This section discusses debugging considerations in the following topics.
Topic	Description
Debugging MCML
Discusses debugging considerations for Windows Media Center Presentation Layer applications.
Attaching a Debugger to a Windows Media Center Application using Visual Studio
Describes how to attach a debugger to a Windows Media Center Presentation Layer application process.
Enabling Stack Trace Details
Describes how to view detailed stack trace information.
Using Command Line Switches for ehShell.exe
Describes command-line switches that can be useful when debugging layout issues.

See Also
•	Developing Applications for Windows Media Center
•	Understanding the Fundamentals

# K Debugging MCML
Windows Media Center Markup Language (MCML) supports debug tracing, and the Media Center Markup Language Preview Tool supports runtime exception dumping.
MCML supports the ability to generate traces from your rule declarations by using the DebugTrace element. DebugTrace produces debug traces, which include dumping any state in your UI that is reachable from an object path. This feature is useful for checking whether rules are running as expected and for dumping an intermediate UI state.
The Media Center Markup Language Preview Tool supports dumping unhandled run-time exceptions. At parse time, the platform will attempt to verify the markup to ensure a stable run time. Run-time exceptions are not hidden because they indicate a design error (either in markup or code). The Media Center Markup Language Preview Tool signals errors as debug traces. For an example of debugging MCML files, see the AdvancedMarkup.Debugging.mcml file in the Sample Explorer.
To use these features, you must run a debug trace monitor. Running under a debugger (such as Visual Studio) displays traces in the debugger's output window. The disadvantage of this is that you must start your application under the debugger or attach it at run time (for more information, see Attaching a Debugger to a Windows Media Center Application using Visual Studio). An alternative is to run a stand-alone debugging monitor, such as the Debug Monitor tool (Dbmon.exe), which is available in the Windows SDK.
To help debug complex MCML, use the Debug Monitor tool available in the Platform SDK. Insert a DebugTrace statement to understand the flow of execution or to generate intermediate values of parameters or locals, as shown in the example below.
Note   .NET Framework events and exceptions cannot be caught and handled directly in MCML markup. However, you can create a .NET Framework class to catch exceptions in your Windows Media Center application and expose exceptions to MCML using standard mechanisms, such as the IPropertyObject interface.
<Rule>
  <Conditions>
  .
  .
  .
  </Conditions>
  <Actions>
    <DebugTrace Message="'Value'={0}">
      <Params>
        <ObjectPath ObjectPath="[Value]"/>
      </Params>
    </DebugTrace>
    .
    .
    .
  </Actions>
  .
  .
</Rule>

See Also
•	Debugging

# K Attaching a Debugger to a Windows Media Center Application using Visual Studio
You can use Visual Studio to debug Windows Media Center application code. Visual Studio 2008 Professional Edition or higher is required because other editions of Visual Studio 2008 (such as the Express Editions) do not include a debugger that allows you to attach to running processes.
Note   Only Windows Media Center Presentation Layer applications that are implemented as .NET assemblies can use this feature.
1.	Enable Windows Media Center to allow you to attach a debugger to your application process.
Windows Media Center can display a dialog box that displays your process ID when you run an application. Then, you can use Visual Studio to attach a debugger to the application process. To enable this feature, set the following registry key:
Path: HKCU\Software\Microsoft\Windows\CurrentVersion\Media Center\Settings\Extensibility
Key: EnableAddinLaunchDebugging
Data type: REG_DWORD
Value: 1
2.	Build and install the Windows Media Center application.
•	Compile your code in Visual Studio 2008.
•	Install the resulting assembly to the Global Assembly Cache (GAC).
•	Register the application so that it can be launched from within Windows Media Center. You can use RegisterMceApp.exe, or the ApplicationContext.RegisterApplication or MediaCenter.RegisterApplication methods.
3.	Enable Windows Media Center to launch application debugging.
Set the EnableAddInLaunchDebugging registry value on your computer, which displays a Windows Media Center dialog box when attempting to launch any application. The dialog box displays the process name and process ID that you can use to attach a debugger, set breakpoints, and step through the code in your application that is executed when Windows Media Center attempts to load and run it.
[HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Media Center\Settings\Extensibility]
EnableAddInLaunchDebugging = 1 (REG_DWORD)

4.	Launch Windows Media Center and start your application.
•	Launch Windows Media Center and click on the entry point for your application. A dialog box is displayed, which you can use to attach a debugger.

5.	Attach to the ehexthost process in Visual Studio.
•	Navigate away from the Debug Application dialog box without closing it, and then start Visual Studio. From the Tools menu, choose Attach to Process. A dialog box is displayed that lists all running processes on your system.

•	Locate the process name and process ID that were listed in the Debug Application dialog box in Windows Media Center. Select it, and then click the Attach button.
Note   If Visual Studio was already running when you started your Windows Media Center application, you might need to click the Refresh button in the Attach to Process dialog box so that your application process is listed.
6.	Configure symbol settings for the application assembly in Visual Studio.
You must configure symbol settings so that you can set breakpoints and debug your application assembly code.
•	In Visual Studio, from the Debug menu, choose Windows, and then choose Modules.
•	In the Modules window, locate the DLL that represents your application assembly, right-click it, and choose Symbol Settings.

•	In the Options dialog box, click the New Folder icon to add a symbol file (.pdb) location. Provide the full path to the \bin\<debug or release> directory for the built binary for your application assembly. Make sure that the check box next to the symbol path is selected, and then click OK.
You can verify that you chose the correct symbol location: in the Module window, verify that the Symbol Status for your application assembly says Symbols Loaded.
7.	Configure Visual Studio to allow setting breakpoints in managed code.
•	In Visual Studio, on the Tools menu, choose Options.
•	In the left pane, expand Debugging, and then select General
•	Verify that Enable Just My Code (Managed only) is checked.
•	Click OK.
8.	Set breakpoints and start debugging.
•	Open your source code files in the Visual Studio IDE and set breakpoints on the lines you want to debug.
•	Navigate back to Windows Media Center and click OK in the Debug Application dialog box to resume execution of your application.
The application should stop at the breakpoints you set, allowing you to use the Visual Studio debugger to step through your code.
If you need to start a new debugging session, start again at step 4. The process ID in the Debug Application dialog box changes each time you launch your application, so you must attach to the new instance of ehexthost.exe.
See Also
•	Debugging

# Using Exception Handling in Web Applications
Not documented in this release.
See Also
•	Sample Explorer
•	Media Center Markup Language Verifier
•	Working with Windows Media Center Presentation Layer Web Applications

# K Enabling Stack Trace Details
By enabling the Details button in the application Invalid Application dialog box, you can view detailed stack trace information if an application fails to load or if it crashes. You can enable this feature by setting the following key in the registry:
Path: HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Media Center\Settings\Extensibility
Key: EnableErrorDetails
Data type: REG_DWORD
Value: 0 (not enabled) or 1 (enabled)
By default, this value is only enabled on computers on which the Windows Media Center SDK has been installed.
See Also
•	Debugging

# K Using Command Line Switches for ehShell.exe
The Windows Media Center process (ehShell.exe) contains the following command-line switches that can be useful when debugging layout issues:
ehshell.exe /entrypoint:{application_guid}\{entrypoint_guid}
This switch starts Windows Media Center and navigates directly to a registered entry point, where application_guid and entrypoint_guid are strings that contain the GUIDs of the application and entry point identifiers for the entry point to launch.
ehshell.exe /url:url
This switch starts Windows Media Center and navigates directly to a Hosted HTML application that is specified by url.
ehshell.exe /homepage:url
This switch starts Windows Media Center and navigates directly to a Windows Media Center Presentation Layer Web application that is specified by url.
ehshell.exe /addinfallbackpath:path
This switch starts Windows Media Center and uses the location specified in path to locate and load application assemblies. This location is only used after Windows Media Center attempts to load application assemblies from the global assembly cache (GAC) and \windows\ehome.
ehshell.exe /gdi
This switch starts Windows Media Center in Graphics Device Interface (GDI) graphics mode, which simulates a low-fidelity graphics environment that does not support DirectX graphics mode.
ehshell.exe /widescreen
This switch starts Windows Media Center with a 16:9 aspect ratio to enable testing widescreen display resolutions on systems that only have a 4:3 monitor installed. This switch works when Windows Media Center is started in windowed mode, but will not work in full-screen mode.
ehshell.exe /rtl
This switch starts Windows Media Center in right-to-left (RTL) display mode.
ehshell.exe /directmedia:general
This switch starts Windows Media Center in full-screen mode.
ehshell.exe /directmedia:music
This switch starts Windows Media Center in full-screen mode and navigates to the Music Library.
ehshell.exe /directmedia:video
This switch starts Windows Media Center in full-screen mode and navigates to the Video Library.
ehshell.exe /directmedia:tv
This switch starts Windows Media Center in full-screen mode and navigates to Recorded TV.
ehshell.exe /directmedia:pictures
This switch starts Windows Media Center in full-screen mode and navigates to the Picture Library.
ehshell.exe /directmedia:discplayback
This switch starts Windows Media Center in full-screen mode and begins playback of the disc in the drive according to AutoPlay registration.
See Also
•	Debugging

# K MCML Basics
This section covers basic aspects of working with MCML.
Topic	Description
Model-View Separation
Describes the concept of separating the code and data of an application from its visual user interface.
MCML Syntax for Elements and Attributes
Describes the syntax of MCML, including nested structures, and the option of using expanded and inline forms.
Markup Namespaces
Explains how to reference namespaces.
Using Resources in MCML
Lists the resource types that are supported.
Accessing MCML Libraries
Describes how to access markup-defined resources.
Referencing Assemblies from Markup
Explains how to reference assemblies.
Reserved Keywords
Lists the keywords that are reserved in MCML.
Naming Elements
Describes the restrictions to MCML names.
Using Object Paths
Describes how to use object paths to access members of CLR objects.
Loading an MCML Page
Describes how to load an MCML page using different methods.
Binding Code and Data to MCML
Describes how to bind to members of .NET Framework objects, such as ModelItem objects and the types derived from it.

See Also
•	Developing Applications for Windows Media Center
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Model-View Separation
The Windows Media Center Presentation Layer separates an application's visual presentation from its logic by employing a model/view approach:
•	The model provides the logic of the application (the code and data), and is developed using a managed code language such as C# and the Microsoft .NET Framework. The model is non-visual.
•	The view provides the look and behavior of the application (the user interface), and is authored in Media Center Markup Language (MCML).
This separation allows the UI to be developed separately from the model items. However, for anything to occur when interacting with the UI, the view must be associated with the model. For example, a button must be associated with code to handle a click event. This binding is achieved by parameters, which are named objects.
See Also
•	MCML Basics
•	Sample Explorer
•	Media Center Markup Language Verifier

# K MCML Syntax for Elements and Attributes
MCML maps Common Language Runtime (CLR) objects to Extensible Markup Language (XML) elements, and CLR properties to XML attributes. MCML uses a nested structure, using inline or expanded syntax, in which an element contains an attribute, which in turn contains elements with their own nested attributes, and so forth:
<Element>
  <Attribute>
    <Element>
      <Attribute>
      ...

The following example shows how nested values can be attributes of elements, or values for attributes (for additional examples, see the Sample Explorer):
<Mcml xmlns="http://schemas.microsoft.com/2006/mcml">
  <UI Name="XMLSyntax">

    <!-- "Content" is an attribute of the UI element. -->
    <Content>

      <!-- "ColorFill" is an element and an attribute of "Content". -->
      <ColorFill Content="Firebrick">

        <!-- "Children" is an attribute of "ColorFill". -->
        <Children>

          <!-- "Text" is an element and an attribute of "Children". -->
          <Text Content="Content is an attribute of the Text element, which is an attribute of Children"
                Font ="Arial,12" Color="White" />

        </Children>
      </ColorFill>
    </Content>
  </UI>
</Mcml>

All attributes can be specified using expanded form, and certain attributes can use an inline form if one has been defined for it. For example, the Font element has both expanded and inline syntax definitions. So when an attribute takes another element as a value, you can pass in the inline syntax if it has been defined. We recommend using inline syntax whenever possible. Otherwise, use expanded form or pass in a reference to an object that has been defined elsewhere. The following example shows these variations (for additional examples, see the Sample Explorer):
<Mcml xmlns="http://schemas.microsoft.com/2006/mcml" >

  <UI Name="Example">

    <Properties >
      <Font Name="SampleFont" FontName="Verdana" FontSize="14" FontStyle="None" />
    </Properties >

    <Content>
      <ColorFill Layout="VerticalFlow" Content="Goldenrod" Padding="5,5,5,5" >
        <Children>

          <!-- Different ways to specify a font: -->

          <!-- Inline form -->
          <Text Content="Inline form 1" Font="Arial,14" />

          <!-- Inline form, variation -->
          <Text Content="Inline form 2" Font="Verdana,14,Italic" />

          <!-- Reference to a font defined in the UI Properties -->
          <Text Content="Inline reference" Font="[SampleFont]" />

          <!-- Expanded form -->
          <Text Content="Expanded form" >
            <Color>
              <Color A="255" R="255" G="255" B="225"/>
            </Color>
            <Font>
              <Font Font="Arial,12"/>
            </Font>
          </Text>

        </Children>
      </ColorFill>
    </Content>
  </UI>
</Mcml>

The following are the rules of syntax for MCML:
•	Element names, attribute names, and values are case-sensitive.
•	Markup libraries are not global. Namespaces are available to avoid name collisions. Libraries are per-MCML resource, so namespaced library access is required.
•	All types, including CLR and markup types, must be prefixed (except for built-in types such as xmlns). For example: <cor:String … >, <ctl:Button …>, <font://comm:MainFont>.
•	Indirection is indicated by brackets [], and requires a name to reference.
•	All named top-level tags can only be referenced by their given name rather than a namespace.
Note   When using Visual Studio 2008 to develop MCML documents, be aware that the IntelliSense feature does not provide all possible options in the completion list. Rather, it provides syntax options based on best practices and commonly-used scenarios. So, you can use elements and attributes that are not listed and Visual Studio will underline them with wavy colored lines, but the MCML code may still be valid.
•	You cannot index by a variable, property, or other object path. Only literal strings are supported. So, index by using a constant (for example, "abc.#xyz").
See Also
•	MCML Basics
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Markup Namespaces
MCML files contain a mapping to a Windows Media Center namespace, which is a reference to the Microsoft.MediaCenter.UI assembly. You can indicate the default namespace by using the xmlns attribute in the root <Mcml> tag. The alias for the Microsoft.MediaCenter.UI assembly is "http://schemas.microsoft.com/2006/mcml".
The following statement is typically how an MCML document begins:
<Mcml xmlns="http://schemas.microsoft.com/2006/mcml">

Any tag without a prefix is assumed to be from the default namespace.
The "me" namespace is used to reference other resources in the same markup document. For example:
<Mcml
  xmlns="http://schemas.microsoft.com/2006/mcml"
  xmlns:me="Me">

In the example below, the MainUI includes a reference to another UI that is defined later in the MCML document:
<Mcml xmlns="http://schemas.microsoft.com/2006/mcml"
      xmlns:me="Me">

  <UI Name="MainUI">
    <!-- The first UI is displayed. -->
    <Content>
      <!-- This is a reference to the next UI. -->
      <me:SimpleUI_1 />
    </Content>
  </UI>

  <UI Name="SimpleUI_1">
    <Content>
      <Text Content="This text is displayed because the first UI references it."
            Color="Red" Font="Verdana,12"/>
    </Content>
  </UI>

  <UI Name="SimpleUI_2">
    <Content>
      <Text Content="This text is not displayed."
            Color="Blue" Font="Verdana,12"/>
    </Content>
  </UI>

</Mcml>

See Also
•	MCML Basics
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Using Resources in MCML
In markup, you can refer to resources (such as images, sounds, MCML files, and Web sites) using a uniform resource identifier (URI). The following resource types are supported for MCML:
Type	Format	Description
file	file://DriveLetter:\FolderName\IdentifierName
file://IdentifierName	File system-based resource access. A full path can be supplied. Otherwise, the current working directory is used.
For example:
file://E:\MyButton.mcml
http/https	http://FullyQualifiedDomainName/IdentifierName	Web-based resource access.
For example:
http://www.mydomain.com/MyButton.mcml
Note   You must use absolute paths because relative paths are not supported.
res 	res://NativeDll!IdentifierName	Native Windows resource format that enables access to any resource stored as RCDATA within NativeDll's .RES.
For example:
res://McmlSampler!Scenarios.SimpleButton.mcml
resx 	resx://AssemblyName/ResourceContainerName/IdentifierName	Native resource format of .NET.
•	AssemblyName can be a partial or strong name.
•	ResourceContainerName is the name of the resources file within the assembly.
•	IdentifierName is the name of the resource.
For example:
resx://MyAssembly/MyResources/MyButton.mcml

External MCML markup can be referenced from an MCML file by specifying the resource path within your xmlns statements:
xmlns:sb="file://Scenarios.SimpleButton.mcml"
xmlns:sb="http://www.contoso.com/Scenarios.SimpleButton.mcml"

Markup access would be of the form: <sb:SimpleButton/>
The res:// protocol is designed to load Microsoft Win32 resources, with the following limitations:
•	The res:// protocol can be used to load resources from a managed binary, but that managed binary must be strong-name signed, and located in the global assembly cache (GAC).
•	The syntax is res://myassembly!myresource.extension. In this scenario, myassembly is not given a file extension, so you cannot have a managed DLL and EXE with the same name and be able to load resources from both of them.
•	In res://myassembly!myresource.extension, myassembly can be a short assembly name or a fully-qualified assembly identity.
•	The res:// protocol can also be used to load resources from an unmanaged binary, but it is limited to unmanaged DLLs. Loading resources from an unmanaged EXE using the res:// protocol is not supported.
The resx:// protocol is designed to load resources from .resx files that are embedded into managed assemblies, with the following limitations:
•	The resx:// protocol is used to load resources from a managed assembly, which must be strong-name signed and located in either %windir%\ehome or the global assembly cache (GAC).
•	In the syntax resx://myassembly/myresourcefile/myresourceidentifier, the myassembly parameter does not have a file extension, so you cannot have a managed DLL and EXE with the same name and be able to load resources from both of them.
When referencing types or methods in an assembly, you should define an xmlns prefix that represents the entire namespace that you want to use rather than only the assembly name.
For example, if you have an assembly named TestAssembly that has a class called TestClass, and TestClass has a method called TestMethod, you would use the following syntax to refer to the TestMethod:
xmlns:myclass="assembly://TestResource/TestClass"
...
<Text Content="[RepeatedItem!myclass:TestMethod.ToString]" />

As another example, if you want to use the .NET Framework System.String object, you would use the following syntax:
xmlns:cor="assembly://MSCorlib/System"
...
<cor:String Name="MyString" String="Hello World!"/>

The following example shows how to access resources in MCML (for additional examples, see the Sample Explorer):
<Mcml
  xmlns="http://schemas.microsoft.com/2006/mcml"
  xmlns:sb="res://McmlSampler!Scenarios.SimpleButton.mcml">
  <!-- The following sample demonstrates resource access in different scenarios. -->
  <UI Name="ResourceAccess">
    <Locals>
      <Command Name="PlayIt" Description="Let's hear it!"/>
    </Locals>
    <Rules>
      <Changed Source="[PlayIt.Invoked]">
        <Actions>
          <!-- Sound stored as a RESX resource. -->
          <PlaySound Sound="resx://McmlSampler/McmlSampler/Intro"/>
          <PlayAnimation Target="[Logo]">
            <Animation>
              <Animation CenterPointPercent=".5,.5,1">
                <Keyframes>
                  <ScaleKeyframe Time="0" Value="1,1,1"/>
                  <ScaleKeyframe Time=".35" Value=".5,.5,1"/>
                  <ScaleKeyframe Time=".4" Value="2,2,1"/>
                  <ScaleKeyframe Time="4" Value="1,1,1"/>
                  <RotateKeyframe Time="0" Value="0deg;0,0,1"/>
                  <RotateKeyframe Time="4" Value="720deg;0,0,1"/>
                </Keyframes>
              </Animation>
            </Animation>
          </PlayAnimation>
        </Actions>
      </Changed>
    </Rules>
    <Content>
      <Panel>
        <Layout>
          <FlowLayout Orientation="Vertical" ItemAlignment="Center" Spacing="20,0"/>
        </Layout>
        <Children>
          <!-- Image stored as a RESX resource. -->
          <Graphic Name="Logo" Content="resx://McmlSampler/McmlSampler/MediaCenter"/>
          <!-- SimpleButton MCML from a RES resource (using an xmlns statement from above). -->
          <sb:SimpleButton Command="[PlayIt]"/>
        </Children>
      </Panel>
    </Content>
  </UI>
</Mcml>

See Also
•	MCML Basics
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Accessing MCML Libraries
The most common top-level element within an MCML resource is the UI element. However, you can use any .NET object at the top level, which must be named and placed in a markup library. Markup libraries are typically used for accessing common objects, such as images, from one location.
Markup libraries are not global. Namespaces are available to avoid name collisions. Libraries are per-MCML resource, so namespaced library access is required. Use the following syntax to access a library:
library://namespace:identifier

You can use this syntax as a value to any property that accepts that type. For example, you can specify an image library (image://me:MyLogo), and then use it as a value in the Content property of the Graphic element, which specifies an image.
The following types are available:
•	All types from Microsoft.MediaCenter.UI.dll and Microsoft.MediaCenter.dll (the Microsoft.MediaCenter namespaces).
•	All primitive types (for example, Int32, Boolean, and so forth), String, DateTime, TimeSpan, and Random from MSCorLib.dll.
•	Uri classes from System.dll.
The following resource restrictions also apply:
•	MCML can only be served from the Web host of the page that is initially loaded.
•	Images can come from any Web source.
•	Sounds can come from any Web source.
The set of predefined libraries are as follows:
Library	Description
Image (image://)	Stores Image types.
Sound (sound://)	Stores Sound types.
Font (font://)	Stores Font types.
Color (color://)	Stores Color types.
Animation (animation://)	Stores Animation types.
Global (global://)	Stores all other types.

The following example shows how to access MCML libraries. This example is also located in the MCMLSampler (see the example "Markup Libraries" under Fundamentals). For more information about the MCMLSampler, see Sample Explorer.
<Mcml
  xmlns="http://schemas.microsoft.com/2006/mcml"
  xmlns:sb="res://McmlSampler!Scenarios.SimpleButton.mcml"
  xmlns:me="Me">

  <!-- Top-level Image. -->
  <Image Name="Logo" Source="resx://McmlSampler/McmlSampler/MediaCenter"/>
  <!-- Top-level Sound. -->
  <Sound Name="Intro" Source="resx://McmlSampler/McmlSampler/Intro"/>
  <!-- Top-level Animation. -->
  <Animation Name="Boing" CenterPointPercent=".5,.5,1">
    <Keyframes>
      <ScaleKeyframe Time="0" Value="1,1,1"/>
      <ScaleKeyframe Time=".35" Value=".5,.5,1"/>
      <ScaleKeyframe Time=".4" Value="2,2,1"/>
      <ScaleKeyframe Time="4" Value="1,1,1"/>
      <RotateKeyframe Time="0" Value="0deg;0,0,1"/>
      <RotateKeyframe Time="4" Value="720deg;0,0,1"/>
    </Keyframes>
  </Animation>
  <!-- Sample UI. -->
  <UI Name="MarkupLibraries">
    <Locals>
      <Command Name="PlayIt" Description="Let's hear it, again!"/>
    </Locals>
    <Rules>
      <Changed Source="[PlayIt.Invoked]">
        <Actions>
          <!-- Play a sound (reference to a Sound outside this scope). -->
          <PlaySound Sound="sound://me:Intro"/>
          <!-- Do animation (reference to Animation outside this scope). -->
          <PlayAnimation Target="[Logo]" Animation="animation://me:Boing"/>
        </Actions>
      </Changed>
    </Rules>
    <Content>
      <Panel>
        <Layout>
          <FlowLayout Orientation="Vertical" ItemAlignment="Center" Spacing="20,0"/>
        </Layout>
        <Children>
          <!-- Display image (reference Image outside this scope.) -->
          <Graphic Name="Logo" Content="image://me:Logo"/>
          <sb:SimpleButton Command="[PlayIt]"/>
        </Children>
      </Panel>
    </Content>
  </UI>
</Mcml>

See Also
•	MCML Basics
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Referencing Assemblies from Markup
To reference assemblies from markup, use assembly://. For example, the following statement maps the System namespace to the cor prefix:
xmlns:cor="assembly://MSCorLib/System"

You can also reference assemblies using the strong name, for example:
xmlns:btn="res://McmlSampler,Version=6.0.6000.0,Culture=neutral,PublicKeyToken=31bf3856ad364e35!Scenarios.SimpleButton.mcml"

Assemblies must meet the following requirements:
•	The assembly needs to be strong-name signed.
•	The assembly needs to be in the global assembly cache (GAC).
When to use strong and weak assembly references
A weak assembly reference is the assembly name, for example:
res://McmlSampler!Scenarios.SimpleButton.mcml

A strong assembly reference is the full assembly identity, for example:
res://McmlSampler,Version=6.0.6000.0,Culture=neutral,PublicKeyToken=31bf3856ad364e35!Scenarios.SimpleButton.mcml

MCML supports both types of syntax to refer to resources and assemblies.
A weak assembly reference can be replaced with a strong assembly reference, and the application will continue to work as expected. However, the reverse is not always true. Use strong and weak assembly references as follows:
•	When referring to resources within an assembly that is currently loaded, including your application assembly, you can use a weak or strong assembly reference.
•	When referring to resources that are within the same assembly as the code or markup, it is recommended you use weak assembly references for readability purposes.
•	When referring to resources in an assembly that is outside of the assembly that is currently loaded, use a strong reference.
•	When referring to code or markup that is located in an external assembly, use strong assembly names and ensure that those external assemblies are installed into the GAC.
See Also
•	MCML Basics
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Reserved Keywords
The following keywords are reserved and cannot be used to identify your own named objects (you cannot use them with the Name property in any element):
•	$Required
•	Accessible
•	Focus
•	Input
•	Me
•	Name
•	Parent
•	RepeatedItem
•	RepeatedItemIndex
•	RequestMethod
See Also
•	MCML Basics
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Naming Elements
Naming an element allows you to refer to it from another point in code. Some elements require a name, although you can specify a name for any element. You can use alpha-numeric characters as well as several punctuation characters and symbols:
<ColorFill Name="My*Named%ColorFill" Content="White" MinimumSize="10,10"/>

However, the following characters cannot be used in a name and will result in an error:
& " < > ! .

You should also set a name for an element explicitly, rather than setting it through a property. For example, use Name="MyName" rather than Name="[ReferenceToName]".
See Also
•	MCML Basics
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Using Object Paths
Object paths are the main form of data binding in MCML. Using object paths, you can dot into any common language runtime (CLR) object using the form [ObjectName.Member. ... .Member].
ObjectName is the first part of the path, and refers to a named object within the scope of the UI, with the following restrictions:
•	You cannot use object paths in a Properties section.
•	In a Locals section, object paths have access to objects in the Properties section.
•	In a Content section, object paths have access to objects in the Properties and Locals section.
•	In a Rules section, object paths have access to objects in the Properties, Locals, and Content sections.
Object paths can be used to access property, method, and indexer members.
The following example shows how to call a static property from the System.DateTime structure. First, declare the type in the Locals section (DateTime also requires a reference to the System namespace). Then, using object paths, you can access the DateTime properties in the Content section of the UI:
<Mcml
  xmlns="http://schemas.microsoft.com/2006/mcml"
  xmlns:cor="assembly://MSCorLib/System" >
  <UI Name="Statics">
    <Locals>
      <cor:DateTime Name="Display"/>
    </Locals>
    <Content>
      <Text Content="[Display.Now.ToString]" Color="White" />
    </Content>
  </UI>
</Mcml>

Indexers can be used to access dictionaries with the following syntax (where "#" indicates an indexer):
MyDictionary.#IndexerValue

Object paths support type-casting and type conversions to declare that the current member type is a different type. Use "!" to indicate a type cast as follows:
Data.Item!cor:String

The Item property is of type Object, and cor is a namespace prefix (for example, xmlns:cor="assembly://MSCorlib/System").
You can use type-casting in the following situations:
•	Casting to or from an interface
•	Casting to a valid derived type (up-cast)
•	Casting to a valid base type (down-cast).
Type conversions are used to convert an object to a different type. A type conversion uses the same casting syntax and is considered when type-casting is not allowed. For example, [MyString!Image] converts a string to an Image type using the built-in type converter for the Image object. Type casts and type conversions are validated at run time, and can result in fatal run-time errors.
Note   Type conversions are only allowed for primitive and string types.
Most object paths are evaluated when the UI is created and the resulting values are set on the associated properties. However, for the following elements, the object paths are re-evaluated at run-time as needed:
•	All elements used in rules
•	InvokeCommand element
•	NavigateCommand element
The following example shows how to use object paths in MCML. For additional examples, see the Sample Explorer.
<Mcml xmlns="http://schemas.microsoft.com/2006/mcml"
      xmlns:cor="assembly://MsCorLib/System" >

  <UI Name="ObjectPaths">

    <Locals>
      <cor:String Name="MyString" String="I love Windows Media Center!"/>
    </Locals>

    <Content>

      <ColorFill Content="Firebrick" Layout="VerticalFlow">

        <Children>

          <!-- The Content attribute references the string that was defined in Locals. -->
          <Text Content="[MyString]" Color="LightCyan" Font="Verdana,12"/>

          <!--This Content attribute calls the GetType method (which exists on all .NET Framework types)-->
          <!--and queries the FullName property on the returned type.-->
          <Text Content="[MyString.GetType.FullName]" Color="Gainsboro" Font="Verdana,12"/>

        </Children>
      </ColorFill>
    </Content>
  </UI>
</Mcml>

See Also
•	Sample Explorer
•	Media Center Markup Language Verifier
•	MCML Basics


# K Loading an MCML Page
Use the following to load a Windows Media Center Markup Language (MCML) page.
PageSession.GoToPage Method (managed code)
Most applications will use the PageSession.GoToPage method once to load the initial MCML page for the application. Although it can be called at any time from MCML, typically the application uses the Navigate element in MCML.
The PageSession.GoToPage method uses the page stack (puts pages on the back stack).
PageSession.LoadPage Method (managed code)
The PageSession.LoadPage method is similar to the PageSession.GoToPage method but without the page stack. This method is useful for single-page applications.
Navigate Element (MCML)
The Navigate element loads an MCML page from within MCML.
Source Attribute of the Host Element (MCML)
The Source attribute of the Host element is used to dynamically change a child UI element at run-time after parsing. It allows you to change the UI element without loading or reloading the entire page, without code. This attribute can be used to share data between peer and child UI elements. The Host element can contain other Host elements or view items.
Application.LoadMcml Method (managed code)
The Application.LoadMcml method is advanced and is rarely used. It is not designed to be used for visible UI.
This method does the following:
•	This method lets you get an object from within MCML.
•	This method gives you access to the McmlLoadResult class, of which the BuildGlobal method is the most useful.
•	This method is used for getting and building model items or non-visual objects, such as a tree of .NET types using MCML.
•	This method loads MCML (pre-parses) and checks for parser errors before using it within an application.
•	This method gives programmatic access to objects within MCML outside of a UI.
See Also
•	MCML Basics

# K Binding Code and Data to MCML
Data binding is the way in which you bind code and data to MCML. ModelItem objects are code-supported objects that represent the most common abstract data and callback concepts and are strictly non-visual. These objects should be used as the main interface to the UI controls that are defined in your MCML markup.
The ModelItem class implements the IPropertyObject interface, and provides the following features:
•	Change notifications.
•	Direct simple bindings, which allow you to associate a property on your ModelItem object with a property on another object, or vice versa. For the ModelItem object to detect property changes on a different object, the other object must implement the IPropertyObject interface.
For convenience, you can use the following ModelItem methods for binding to other code objects:
•	BindFromSource, which creates a binding between a remote source object and a ModelItem object.
•	BindToTarget, which creates a one-way binding from a ModelItem object to a target.
•	TwoWayBind, which creates a two-way binding between a ModelItem object and a target.
•	Lifetime management. ModelItem objects are typically connected to many other objects through event handlers and other methods. To prevent common leaks, each ModelItem must be owned by an IModelItemOwner object. That owner then takes responsibility for disposing the owned ModelItem objects.
The ModelItem class implements the IModelItemOwner interface; one ModelItem can own others, thereby ensuring that ModelItem objects that are being referenced by another ModelItem object are automatically disposed and released. For example, a page ModelItem object could own all of the ModelItem objects on the page.
Windows Media Center supports binding data from any .NET object, as well as generalized data sources through a set of data interfaces. If the source exposes IPropertyObject notifications, MCML rules can automatically respond.
Note   Your code cannot access UI elements—UI elements own the data binding relationship, rather than the code owning it.
You can derive custom classes from the ModelItem class and reference them from your MCML. The Microsoft.MediaCenter.UI namespace provides the ModelItem class and the following derived classes that you can use directly:
Type	Description
Choice
	Maintains a list and the item within it that is selected. This class is useful when you want to implement a radio button group.
BooleanChoice
Maintains a list of two options (True and False) and the item that is selected. This class is useful when you want to implement a check box.
Command
InvokeCommand (MCML)
NavigateCommand (MCML)
Provides callback functionality so you can connect the UI to the program state. For example, use one of these classes with a UI button to receive click notifications.
EditableText
Represents an editable string. This class is useful when you want to implement an edit box.
ListDataSet
ArrayListDataSet
Maintains a list of objects for a list or a gallery in the UI. These classes raise events for add, remove, and modified notifications, which are compatible with Repeater view items.

RangedValue
ByteRangedValue
IntRangedValue
Maintains a range of values. For example, use these classes to implement a spinner control or a slider control.
Timer
Creates a configurable timer that raises notifications on clock ticks (that is, specific intervals).
PropertySet
Provides a loosely-typed dictionary that raises notifications. However, when possible, use a strongly-typed structure instead. This class works well where data structures are required, but custom code is not possible (such as Web applications).

The following example shows a simple way of binding code to data:
Samples.Fundamentals.cs
This class creates a contact record using hard-coded data.
using System;
namespace Samples.Fundamentals
{
    public class SimpleContact
    {
        public string Name
        {
            get
            {
                return "John Doe";
            }
        }

        public string Email
        {
            get
            {
                return "johndoe@hotmail.com";
            }
        }
    }
}

This MCML file references the assembly created from the code above:
<Mcml xmlns="http://schemas.microsoft.com/2006/mcml"
      xmlns:fn="assembly://McmlSampler/Samples.Fundamentals" >

  <UI Name="CodeDataBinding">

    <Locals>
      <!-- Create an instance of the simple contact. -->
      <fn:SimpleContact Name="Contact"/>
    </Locals>

    <Content>
      <!-- Display a background image. -->
      <Graphic Content="file://CircuitBoard.png" Padding="2,2,8,8" MinimumSize="159,126">

        <Layout>
          <FlowLayout Orientation="Vertical" ItemAlignment="Center"/>
        </Layout>

        <Children>
          <!-- SimpleContact contains two String properties: Name and Email. -->
          <!-- Bind to the properties on the contact. -->
          <Text Content="[Contact.Name]" Font="Tahoma,25" Color="Navy"/>
          <Text Content="[Contact.Email]" Font="Tahoma,10" Color="Black"/>
        </Children>

      </Graphic>
    </Content>
  </UI>
</Mcml>

The following example shows a custom clock that is derived from ModelItem. This object sends a notification on every time change using a timer that is set to an interval of one second.

```csharp
using System;
using Microsoft.MediaCenter.UI;

namespace Samples.CodeData.ModelItems
{
    // Clock class derived from ModelItem.

    public class Clock : ModelItem
    {
        public Clock()
        {
            // Set up a timer to refresh the clock.
            // The clock is the owner of the timer, so when the clock is disposed,
            // the objects it owns are also disposed of automatically.

            _timer = new Timer(this);
            _timer.Interval = 1000;
            _timer.Tick += delegate { RefreshTime(); };
            _timer.Enabled = true;

            RefreshTime();
        }


        // Current time.
        public string Time
        {
            get
            {
                return _time;
            }

            set
            {
                if (_time != value)
                {
                    _time = value;

                    FirePropertyChanged("Time");
                }
            }
        }


        // Update the time.
        private void RefreshTime()
        {
            Time = DateTime.Now.ToString();
        }

        private string _time = String.Empty;
        private Timer _timer;
    }
}
```

The MCML markup creates an instance of a Clock class defined above. Using Rules, whenever the clock ticks, a text label is updated with the time and a sound file is played.

```xml
<Mcml
  xmlns="http://schemas.microsoft.com/2006/mcml"
  xmlns:c="assembly://McmlSampler/Samples.CodeData.ModelItems">

  <UI Name="ModelItems">

    <Locals>
      <!-- Create an instance of the Clock class. -->
      <c:Clock Name="Clock"/>
    </Locals>

    <Rules>
      <!-- Bind the clock's time value to a Text view item. -->
      <Binding Source="[Clock.Time]" Target="[Label.Content]">
        <Actions>
          <PlaySound Sound="file://Tick.wav"/>
        </Actions>
      </Binding>
    </Rules>

    <Content>
      <Text Name="Label" Color="PowderBlue" Font="Verdana,40"/>
    </Content>
  </UI>
</Mcml>
```
See Also
•	MCML Basics
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Defining a UI
The main purpose of MCML is to create a user interface (UI) for a Windows Media Center application. This process can be broken down by creating the UI components—the building blocks—of a more complex UI. Each UI component is self-contained; it can be as simple as a button or as complex as a top-level form. You can combine and reuse different UI components as needed.
The root element of an MCML document is Mcml. Within this element, each UI component is defined using the UI element. If an MCML document contains multiple UI elements, the first one in the document is displayed. A UI element must always be named, and it contains four important attributes: Content, Properties, Locals, and Rules.
You cannot display an MCML UI over a Windows Media Center experience, but you can display a dialog box or notification.
This section contains the following topics:
Topic	Description
Defining the Content of a UI
Describes the Content attribute of a UI.
Setting UI Properties
Describes the Properties attribute of a UI, and how these properties can be set.
Setting UI Locals
Describes the Locals attribute of a UI, and how these values are used.
Working with Resource Groups
Describes how applications can request XML data from Web services to create resource groups for a UI.
Inheriting from a Base UI
Describes how you can use inheritance to reuse the state and behavior of a base UI.
Setting Up Rules
Describes the Rules attribute of a UI, and how rules are used.
Using Transformers
Describes how to use transformer objects to convert values in MCML.
Adding Accessibility Support
Provides resources for adding accessibility support to your applications, describes how to determine which color scheme the user has selected for Windows Media Cente, and describes how to map certain UI functions to standard accessibility actions that can be used by external accessibility aides.
Planning for Localization and Globalization
Describes considerations for working with resources and implementing bi-directional (bidi) support.

See Also
•	Developing Applications for Windows Media Center
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Defining the Content of a UI
The Content attribute of a UI contains the visual aspect of the UI and is based on a tree of visual primitives, or view items, with standard data binding mechanisms. For example, the following Content attribute defines a panel layout container:
<Mcml xmlns="http://schemas.microsoft.com/2006/mcml" >
  <UI Name="SimpleUI">
    <Content>
      <Panel Layout="VerticalFlow">
        <Children>
          <Text Content="This is a panel layout with a vertical flow." Color="Red" Font="Tahoma,16"/>
          <Text Content="It contains two text children." Color="Blue" Font="Verdana,22"/>
        </Children>
      </Panel>
    </Content>
  </UI>
</Mcml>

For more information about the view items you can use, see Working with View Items.
See Also
•	Defining a UI
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Setting UI Properties
The Properties attribute of a UI allows you to parameterize a UI with properties, each of which consists of a type, a name, and a default value, thus allowing you to customize the UI. A property can be any MCML or user-defined type. Property default values are shared among all instances of the UI. These values are public and can be overridden. In the following example, the Properties attribute defines default values for the Color and Font attributes of a Text element:
<Mcml xmlns="http://schemas.microsoft.com/2006/mcml" >
  <UI Name="UsingProperties">
    <Properties>
      <Color Name="Foreground" Color="Blue"/>
      <Font Name="DocFont" Font="Verdana,22" />
    </Properties>

    <Content>
      <Text Content="Using Font and Color properties" Font="[DocFont]" Color="[Foreground]"/>
    </Content>
  </UI>
</Mcml>

You can require the parent UI to supply a value for any property by marking it as "$Required", and an error will occur if that property is not specified. The following example requires the parent UI to define a Label string:
<Mcml
    xmlns="http://schemas.microsoft.com/2006/mcml"
    xmlns:cor="assembly://MsCorLib/System"
    xmlns:me="Me">

  <UI Name="MainDisplay" BaseUI="me:LabelProperties">
    <Content>
      <Panel Layout="VerticalFlow">
        <Children>
          <me:LabelProperties Label="A 'Label' string is required." />
          <me:LabelProperties Label="If 'Label' is not specified, an error occurs." />
        </Children>
      </Panel>
    </Content>
  </UI>

  <UI Name="LabelProperties">
    <Properties>
      <!-- This property requires you to specify a string for 'Label' when referencing this UI. -->
      <cor:String Name="Label" String="$Required"/>
      <Color Name="ForeColor" Color="Red"/>
    </Properties>

    <Content>
      <Text Name="Display" Content="[Label]" Color="[ForeColor]" Font="Arial,20" />
    </Content>
  </UI>
</Mcml>

Note   Only reference types (such as classes) can be marked as $Required. Value types, such as structures or types, cannot be marked as $Required.
Any property that you define in the Properties block is saved when you navigate away from the page. When returning to the page, these properties are restored.
See Also
•	Defining a UI
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Setting UI Locals
The Locals attribute of a UI contains private values and objects that are instantiated for each instance of the UI. These values can be changed by the UI at run time. A local can be any MCML or user-defined type.
The following example defines locals to hold a current seconds count and host a timer (for additional examples, see the Sample Explorer):
<Mcml
    xmlns="http://schemas.microsoft.com/2006/mcml"
    xmlns:cor="assembly://MsCorLib/System">

  <UI Name="Locals">

    <Locals>
      <cor:Int32 Name="Seconds" Int32="0" />
      <Timer Name="Timer" Interval="1000" Enabled="true" />
    </Locals>

    <Rules>
      <Binding Source="[Seconds.ToString]" Target="[SecondsDisplay.Content]"/>
      <Changed Source="[Timer.Tick]">
        <Actions>
          <Set Target="[Seconds]" Value="[Seconds]">
            <Transformer>
              <MathTransformer Add="1"/>
            </Transformer>
          </Set>
        </Actions>
      </Changed>
    </Rules>

    <Content>
      <Panel Layout="VerticalFlow">
        <Children>
          <Text Name="SecondsDisplay" Color="Yellow"/>
        </Children>
      </Panel>
    </Content>

  </UI>
</Mcml>

See Also
•	Defining a UI
•	Sample Explorer
•	Media Center Markup Language Verifier

# Working with Resource Groups
A resource group is a set of resources (images and sounds) for a UI. By creating a resource group for a UI, you can preload the items for the UI before the page is displayed or rendered.
To create a resource group:
•	Set the items in the resource group within the Locals section of a UI using the ResourceGroup.Resources property. For example:
    <Locals>
      <ResourceGroup Name="Resources">
        <Resources>
          <Sound Name="MySound" Source="http://www.website.com/soundfile.wav" />
         <Image Name="MyImage" Source="http://www.website.com/imagefile.jpg" />
        </Resources>
      </ResourceGroup>
    </Locals>
•	Use the Acquire method in the Rules section to load the items from the resource group. For example:
      <Rule>
        <Actions>
          <Invoke Target="[Resources.Acquire]"/>
        </Actions>
      </Rule>
•	To get progress information, use the AcquisitionStatus property. This status applies to the group as a whole—the status does not reach "Done" until every item in the group has been loaded.
      <Rule>
        <Conditions>
          <Equality Source="[Resources.AcquisitionStatus]"
                    Value="Done" />
        </Conditions>
        <Actions>
            ...
        </Actions>
      </Rule>
•	To refer to an item in the resource group, such as to display or play it, use the following format:
ResourceGroupName.#ResourceName!ResourceType
ResourceType can be "Image" or "Sound".
For example:
      <Rule>
        <Conditions>
            ...
        </Conditions>
        <Actions>
          <PlaySound Sound="[Resources.#MySound!Sound]"/>
        </Actions>
      </Rule>
For more information about using resource groups, see the MarkupResourceGroup.mcml sample in the Sample Explorer.
See Also
•	Developing Applications for Windows Media Center
•	Microsoft.MediaCenter.DataAccess Namespace
•	ResourceGroup Class

# K Inheriting from a Base UI
UI descriptions have an inheritance model that allows you to take advantage of common functionality across multiple UIs. When you create one UI, you can inherit all of the properties, rules, and content blocks from another UI, the base UI. This feature enables you to reuse state and behavior without having to re-implement it.
•	Properties: A derived UI can simply override the inherited properties of the base UI by setting other default values.
•	Rules: Any rules specified in the derived UI are appended to the rules that were inherited from the base UI. Because rules frequently access Locals and Content blocks, be careful when adding rules because the base UI owns its own named Locals and Content blocks. Typically, you add rules to a derived UI in simple situations—for example, when accessing objects only in the derived UI. You can design your derived UI rules to access content in the base UI if you are familiar with the design of the base UI.
•	Content: Any content specified in the derived UI replaces that of the base UI. Use this feature with caution—the base UI is designed assuming its content exists. You should only override Content values when you are familiar with the base UI design.
Named Content blocks in the UI are used by Repeater elements. A derived UI can override a named Content block, or add a named Content block that the base UI is expecting to override.
The following example demonstrates property overrides (for additional examples, see the Sample Explorer):
<Mcml
  xmlns="http://schemas.microsoft.com/2006/mcml"
  xmlns:me="Me">

  <UI Name="MainUI" BaseUI="me:MyBaseUI">

    <!-- These properties override the base UI. -->
    <Properties>
      <Color Name="BackgroundColor" Color="DarkGreen" />
    </Properties>

    <Content>
      <Text Content="The background color from the base UI is overridden." Color="[TextColor]" BackColor="[BackgroundColor]" Font="[BasicFont]"/>
    </Content>
  </UI>

  <!-- The following UI defines basic properties for font and color.-->
  <UI Name="MyBaseUI" >
    <Properties>
      <Color Name="BackgroundColor" Color="DarkRed"/>
      <Color Name="TextColor" Color="PaleGoldenrod"/>
      <Font  Name="BasicFont" FontName="Verdana" FontSize="16" FontStyle="Italic"/>
    </Properties>
  </UI>

</Mcml>

See Also
•	Defining a UI
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Setting Up Rules
Rules provide priority-based data binding services that are evaluated at run time. They allow you to evaluate state in markup without having to write code.
Each rule consists of sources and targets, actions and conditions. If a set of conditions evaluates to true for a given source, a set of actions is applied to the target. The source of a condition should not be the same as the target of an action in the same rule. The following example shows how to change the color of a text string when you mouse over it:
<Mcml xmlns="http://schemas.microsoft.com/2006/mcml">
  <UI Name="RulesDemo">
    <!-- Mouse input is the source. Text color is the target. -->
    <!-- When the mouse focus is true, the text color changes. -->
    <Rules>
      <Condition Source="[Input.MouseFocus]" SourceValue="true"
                 Target="[Display.Color]" Value="White"/>
    </Rules>

    <Content>
      <Text Name="Display" Content="This text color changes when you mouse over it."
            Color="Red" Font="Arial,20" MouseInteractive="true"/>
    </Content>
  </UI>
</Mcml>

Rules are priority-based in that the first has highest priority; when determining a value for a target, the first applicable rule is applied. To continue to apply other rules, even after the first applicable rule has been applied, set the ExclusiveApply="false" attribute for the Set and Invoke actions.
Rules are shared among user interfaces, so the Source, Target, and Value properties take object paths as values to access objects that have been defined elsewhere in the markup. For more information, see Using Object Paths.
Rules run and get their initial update anytime the UI is created. When navigating away from the page, only the state that was passed in through Properties is retained (Locals are discarded). When returning to the page, the Properties are passed to the UI again, so the UI is recreated and rules run again.
You can use predefined convenience rules, or create custom rules when a convenience rule is not adequate.
# Convenience Rules
Convenience rules are predefined inline rules that are used for common condition-action combinations for one source and one target.
•	A Default rule has an action but no condition. Default rules are used to set a default state when no other rules apply. They can also be used to perform a one-time initialization of state when the UI is first created.
<Rules>
    <!-- Set the color of the text label to purple. -->
    <Default Target="[Label.Color]" Value="Purple"/>
</Rules>

Default rules are added for you automatically when you set a value in the view item and have another rule referring to the same target.
For example, you have a view item such as <Text Color="Yellow"/>. You also have a rule that reacts to focus and sets the text color to Red. You don't need to include a default rule to revert the text color to Yellow when the focus is gone because a default rule to do this was added for you automatically.
•	A Binding rule tracks changes to a Source value and applies it to a Target.
<Rules>
    <!-- Bind the Value value to Label so that when Value -->
    <!-- changes, it is automatically reflected in the Label text. -->
    <Binding Source="[Value.ToString]" Target="[Label.Content]"/>
</Rules>

•	A Condition rule checks a Source for a condition, and then applies an action to a Target if the condition evaluates to true.  In the example below, a text label indicates when a source value is greater than or less than 4.
<Rules>
    <!-- Compare Value against the number 4 and update Target accordingly. -->
    <Condition Source="[Value]" ConditionOp="GreaterThan" SourceValue="4"
               Target="[Label.Content]" Value="This is GREATER than 4."/>
    <Condition Source="[Value]" ConditionOp="LessThan" SourceValue="4"
               Target="[Label.Content]" Value="This is LESS than 4."/>
</Rules>

•	A Changed rule applies an action if a Source has changed. A condition or value is not specified.
<Rules>
    <!-- When Background color changes, update the text label. -->
    <Changed Source="[Background.Content]">
        <Actions>
            <Set Target="[Label.Content]" Value="The color changed!" />
        </Actions>
    </Changed>
</Rules>

# Custom Rules
A custom rule uses expanded form and allows more complexity. For example, you can set up multiple actions and multiple conditions. You can specify how multiple conditions are combined (with AND or OR clauses) by using the ConditionLogicalOp attribute. By default, this value is "And" and all conditions must be met unless you specify otherwise.
Each rule has two parts: a set of conditions and a set of actions.
Possible conditions:
•	Equality evaluates whether the source equals a given value. You can specify other operators in the ConditionOp attribute. The default value is "Equals".
•	IsType evaluates whether the source is a given type.
•	IsValid evaluates whether the source path can be evaluated without error and contains no null values in the path. For example, with a path of "[A.B.C]", IsValid fails if A or B returns null.
•	Modified evaluates whether the source has changed. A source for a Modified condition can be a property value, event, or dictionary.
Possible actions:
•	DebugTrace generates a debugging trace for the rule.
•	Invoke calls a method on any object. Invoke actions support methods with any number of parameters and handle return results. Invoke actions are a useful way to interact with data or code objects when a user interacts with the UI.
•	Navigate navigates to a specified MCML resource destination. Navigate supports http-based navigation targets, and http GET and POST requests.
•	PlayAnimation plays an animation.
•	PlaySound plays a sound.
•	Set defines an action. A target for a Set action can be a property value, a single-parameter method, or dictionaries.
The following example shows a simple counter using predefined convenience rules. The changing count is displayed, a text label changes when the count is 10, and then the timer is disabled.
<Mcml
    xmlns="http://schemas.microsoft.com/2006/mcml"
    xmlns:cor="assembly://MsCorLib/System">

  <UI Name="Locals">

    <Locals>
      <cor:Int32 Name="Seconds" Int32="0" />
      <Timer Name="Timer" Interval="1000" Enabled="true" />
    </Locals>

    <Rules>
      <Binding Source="[Seconds.ToString]" Target="[SecondsDisplay.Content]" />

      <!-- Display the number of seconds using the timer. -->
      <Changed Source="[Timer.Tick]">
        <Actions>
          <Set Target="[Seconds]" Value="[Seconds]">
            <Transformer>
              <MathTransformer Add="1"/>
            </Transformer>
          </Set>
        </Actions>
      </Changed>

      <!-- When the timer reaches 10 seconds, change the text label. -->
      <Condition Source="[Seconds]" SourceValue="10"
                 Target="[Feedback.Content]" Value="Made it to 10!" />
      <!-- When the number seconds is greater than 9, stop the timer. -->
      <Condition Source="[Seconds]" ConditionOp="GreaterThan" SourceValue="9"
                 Target="[Timer.Enabled]" Value="false"/>

    </Rules>

    <Content>
      <Panel Layout="VerticalFlow">
        <Children>
          <Text Name="Feedback" Content="Are we at 10 yet?" Color="Yellow"/>
          <Text Name="SecondsDisplay" Color="Yellow"/>
        </Children>
      </Panel>
    </Content>

  </UI>
</Mcml>

The following example shows how to create a default rule that sets default properties of a Text element.
<Mcml xmlns="http://schemas.microsoft.com/2006/mcml">

    <UI Name="Default">

        <Rules>
            <!-- Set the Label content and color. You could set Text properties -->
            <!-- directly. However, default rules should be used if higher priority -->
            <!-- conditional rules are in use and will manipulate the same Target. -->
            <Default Target="[Label.Color]" Value="Purple" />
            <Default Target="[Label.Content]" Value="This text is displayed" />
        </Rules>

        <Content>
            <Text Name="Label" Content="The default rule overrides this text."/>
        </Content>

    </UI>

</Mcml>

See Also
•	Defining a UI
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Using Transformers
Transformers are objects that provide a conversion from one value type to another. They implement the ITransformer interface. To use any of these transformers, the target must accept the type of value that is returned.
The following transformer elements are used to convert data:
•	The BooleanTransformer element converts data to a Boolean value. A common use for this conversion is for setting the Visible property for a view item; the UI is only displayed in a non-zero or non-null case.
•	The DateTimeTransformer element converts a date-time value to a string for display purposes. The formats you can use are members of the DateTimeFormats enumeration.
•	The FormatTransformer element converts an object to a string with a format that you specify. For example, you could display "4255550123" as a telephone number format such as "(425) 555-0123". For more information about extended format strings, see the Remarks section of the String.Format Method on the MSDN Web site.
•	The MathTransformer element performs a mathematical conversion on a numeric value by applying math operators (multiply, divide, add, subtract, modulo, absolute, and sign—in that order, regardless of the order you specify them). You can also apply a type conversion to the result.
•	The TimeSpanTransformer element transforms a TimeSpan value to a string for display purposes. The formats you can use are members of the TimeSpanFormats enumeration. For more information about TimeSpan format, see the TimeSpan Structure on the MSDN Web site.
You cannot perform one conversion after another on the same variable in a chain. To perform multiple conversions, you can transform the value to an intermediate local and then bind that value to your target using another transformer, or use multiple actions on the same variable using a rule. The example below shows how to perform two transforms on the same variable.
<Mcml
  xmlns="http://schemas.microsoft.com/2006/mcml"
  xmlns:cor="assembly://MSCorLib/System">

  <UI Name="MultipleTransforms">

    <Locals>
      <cor:Double Name="PhoneNumber" Double="4255551211"/>
    </Locals>

    <Rules>
      <Rule>
        <Actions>

          <!-- This example shows how to apply two transforms. -->

          <!-- This transform adds "1" to the phone number. -->
          <Set Target="[PhoneNumber]" Value="[PhoneNumber]">
            <Transformer>
              <MathTransformer Add="1"/>
            </Transformer>
          </Set>

          <!-- This transform formats the phone number. -->
          <Set Target="[Label.Content]" Value="[PhoneNumber]">
            <Transformer>
              <FormatTransformer Format="The phone number is {0}."
                                 ExtendedFormat="(###) ###-####"/>
            </Transformer>
          </Set>

        </Actions>
      </Rule>
    </Rules>

    <Content>
      <Text Name="Label" Color="Orchid" Font="Verdana,20"/>
    </Content>

  </UI>
</Mcml>

See Also
•	Defining a UI
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Adding Accessibility Support
Microsoft provides several resources on the Microsoft Web site for information about supporting accessibility in your applications:
•	For general information about accessibility features, resources, and training, see Accessibility.
•	For accessibility development, see Microsoft Accessibility.
•	For information about testing applications for accessibility issues, see Testing For Accessibility.
Color schemes for accessibility
As an accessibility feature, Windows Media Center provides three color schemes: standard, high contrast (white), and high contrast (black). End users can select the color scheme by going to the Windows Media Center Start page and going to Tasks > Settings > General > Visual and Sound Effects.
Applications written for Windows Media Center should comply with the color scheme setting by updating their own color schemes accordingly. In the Windows Media Center Presentation Layer application, check the value of the Environment element's ColorScheme attribute and then update the markup accordingly. For an example, see the AdvancedMarkup.ColorSchemes sample in the Sample Explorer.
Working with standard accessibility actions
To implement accessibility support within your MCML application, you can map certain UI functions to standard accessibility actions that can be used by external accessibility aides. MCML defines the reserved word Accessible, which is available through object paths for configuring accessibility support.
To allow accessibility tools to invoke the Accessible.DefaultActionCommand, you must create a rule Condition with a Source value of Command.Invoked:
•	Bind the DefaultActionCommand to the same Command object through which you report when commands are invoked.
•	In the same way a click handler invokes a command when you click, so can the DefaultActionCommand when the accessibility aide initiates a default action. How the command is invoked (due to a click or other action) is not known to the object that owns the command.
The example below shows the rules that bind the different actions to the Accessible element, and the way to invoke a default action that is defined in markup. For an example about creating accessibility metadata for MCML applications, see the AdvancedMarkup.Accessibility sample in the Sample Explorer. For additional information about accessibility, see Adding Accessibility Support.
    <Properties>
      <!-- Command is a required parameter. -->
      <Command Name="Command" Command="$Required"/>
    </Properties>

    <Locals>
      <!-- React to click input. -->
      <ClickHandler Name="Clicker" Command="[Command]"/>
    </Locals>

    <Rules>
      <!-- Bind the UI actions to the Accessible object. -->
      <Binding Target="[Accessible.IsPressed]" Source="[Clicker.Clicking]"/>
      <Binding Target="[Accessible.IsFocusable]" Source="[Input.KeyInteractive]"/>
      <Binding Target="[Accessible.IsFocused]" Source="[Input.KeyFocus]"/>
      <Binding Target="[Accessible.Name]" Source="[Command.Description]"/>
      <Default Target="[Accessible.DefaultActionCommand]" Value="[Command]"/>
      <Default Target="[Accessible.DefaultAction]" Value="Press"/>
      <Default Target="[Accessible.Role]" Value="PushButton"/>

      <!-- Perform an action when the Clicker object is clicked. -->
      <Condition Source="[Clicker.Clicking]" SourceValue="true">
        <Actions>
          ...
        </Actions>
      </Condition>

      <!-- Perform an action when the DefaultActionCommand is invoked -->
      <!-- by an accessibility tool. -->
      <Condition Source="[Command.Invoked]" SourceValue="true">
        <Actions>
          ...
        </Actions>
      </Condition>

    </Rules>
See Also
•	Displaying Text
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Planning for Localization and Globalization
When developing an application that you intend to localize for an international audience, we strongly recommend that you do not hard-code strings, images, sounds, videos, or other resources. Instead, load resources from a resource-only DLL. When you need to modify a resource, you modify it once in the resource DLL rather than needing to update your source code. In addition, the process of localization is much easier and more efficient.
# Enabling Bi-Directional Support
MCML sets bi-directional (bidi) support on images and user interfaces (UIs) using the Image.Flippable property for images and the Flippable attribute for the UI element.
When running on right-to-left (RTL) systems, for those UIs and images that have the Flippable property enabled, the layout coordinates for the UI are flipped across the y-axis and images are rendered flipped automatically.
By default, the Flippable attribute is true for UI elements and is false for Image objects. Typically, most images should not be flipped except when indicating direction (such as an arrow).
You can force Windows Media Center to run in RTL mode by starting it with the -rtl argument.
For an example of bidi support, see the AdvancedMarkup.Globalization.mcml file in the Sample Explorer.
# Additional Information and Guidelines
For more information and guidelines about localization and globalization, see Globalizing and Localizing Applications on the MSDN Web site.
In addition, some of the challenges in this area are described in the Planning World-Ready Applications topic on the MSDN Web site, including the following:
•	Determining the extent of world-readiness in the application.
•	Globalizing the application (such as how to accept and process various data formats and languages).
•	Enabling the application for localization.
•	Customizing the application for a given culture/locale.
See Also
•	Displaying Text
•	Media Center Markup Language Verifier

---

MCESDK_Guide03.doc

# K Working with View Items
View items are the different visual primitives that you can use to create a UI. The Content attribute of the UI element can contain only one direct child element, although each view item can contain child elements.
You can use the following view items to design a UI:
•	The Clip element defines a clipping region, which prevents drawing beyond its bounds. See the topic Using Clips for more information.
•	The ColorFill element draws a rectangle of a solid color, such as a background. See the topic Using ColorFills for more information.
•	The Graphic element displays an image. See the topic Working with Graphics for more information.
•	The Host element hosts another UI.
•	The NowPlaying element defines a placeholder item that indicates where to display the Now Playing inset. See the topic Working with NowPlaying for more information.
•	The Panel element is an invisible layout container. See the topic Using Panels for more information.
•	The Repeater element repeats a markup based on a given dataset. See the topic Using Repeaters for more information.
•	The Scroller element scrolls content that cannot fit within the space provided. See the topic Using Scrollers for more information.
•	The Text element displays text. See the topic Displaying Text for more information.
See Also
•	Defining a UI
•	Developing Applications for Windows Media Center
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Using Clips
The Clip view item is used for preventing drawing outside of the parent's constraints. It applies a gradient fade (horizontal or vertical) to the edge of a view item's bounds. Specify a fade size that is non-zero to enable clipping.
The example below shows a Clip view item. The MinimumSize and MaximumSize values are the same, indicating the clip must be exactly that size. If a layout type is not defined on the Clip element, the child follows the same constraints as the Clip element. The Padding property below allows the child to exceed the MaximumSize, while the parent is clipped to the size specified by the MinimumSize and MaximumSize properties.

<Mcml xmlns="http://schemas.microsoft.com/2006/mcml">

    <UI Name="Default">

        <Content>

            <ColorFill Content="Blue">

                <Children>

                    <!-- The parent (a blue colorfill) is clipped to the size specified by the -->
                    <!-- MinimumSize and MaximumSize values. -->
                    <!-- The Padding allows the child (a silver colorfill) to exceed this size. -->
                    <Clip FadeSize="25" MinimumSize="100,100" MaximumSize="100,100" Padding="-100,-100,-100,-100">

                        <Children>
                            <ColorFill Content="Silver" />
                        </Children>

                    </Clip>

                </Children>

            </ColorFill>

        </Content>

    </UI>

</Mcml>

See Also
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Using ColorFills
A ColorFill view item creates rectangles of solid color—for example, to add a background to another view item. The ColorFill is sized to the content, so if it does not have any child elements and a minimum size or padding are not set, the ColorFill will not be displayed.
The following example shows how ColorFill layouts are displayed with child elements, padding, and a minimum size (for additional examples, see the Sample Explorer):

<Mcml xmlns="http://schemas.microsoft.com/2006/mcml">
  <UI Name="Fill">
    <Content>
      <Panel>
        <Layout>
          <FlowLayout Orientation="Horizontal" ItemAlignment="Center" Spacing="20,20" />
        </Layout>
        <Children>
          <ColorFill Content="Red" MinimumSize="50,50" Padding="20,20,20,20"  />
          <ColorFill Content="Orange" MinimumSize="50,50" />
          <ColorFill Content="Yellow" Layout="HorizontalFlow">
            <Children>
              <Text Content="Color" />
              <Text Content="Fills!" />
            </Children>
          </ColorFill>
          <ColorFill Content="Blue" MinimumSize="50,50" />
          <ColorFill Content="Green" MinimumSize="50,50" Padding="20,20,20,20" />
        </Children>
      </Panel>
    </Content>
  </UI>
</Mcml>

See Also
•	Creating a Layout
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Using Panels
The Panel view item is a container that controls the layout of its child items, such as whether child items are displayed in a horizontal or vertical flow. The panel itself is not visible.
The following example shows a panel that displays text items in a vertical layout (for additional examples, see the Sample Explorer). For more information about layout options, see Creating a Layout.

<Mcml xmlns="http://schemas.microsoft.com/2006/mcml" >
  <UI Name="PanelUI">
    <Content>
      <Panel>
        <Layout >
          <FlowLayout Orientation="Vertical" Spacing="10,10" ItemAlignment="Center" />
        </Layout>
        <Children>
          <Text Content="This is an example" Color="White" />
          <Text Content="of a panel with"    Color="YellowGreen" />
          <Text Content="a vertical layout"  Color="Aquamarine" />
        </Children>
      </Panel>
    </Content>
  </UI>
</Mcml>

See Also
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Using Repeaters
The Repeater view item repeats a defined UI (for example, a collection of buttons), and it also manages the relationship between the data and the UI for each member of the collection.
Through virtualization, Repeater can accept data sources with just a few items, and scales efficiently to support millions of items. The Repeater accepts a list of data through its Source property. The child items are then defined by this data.
The Repeater also supports extended notifications from data sources, allowing intelligent handling of changes to the data set such as insertions, deletions, moves, and so forth. This support allows continuity of the UI state across a variety of data set permutations.
You can use any layout with a Repeater (the most common ones being FlowLayout and GridLayout) to display children according to the space available.
A Repeater has two properties (reserved keywords)—RepeatedItem and RepeatedItemIndex—that are available for each item in the collection. RepeatedItem corresponds to the current item in the collection, and RepeatedItemIndex corresponds to its index in the collection. You can pass these values to the child UI. You can also define a Content section to use as a divider between items. The example below shows how these properties are used.
<Mcml
  xmlns="http://schemas.microsoft.com/2006/mcml"
  xmlns:cor="assembly://MsCorLib/System"
  xmlns:me="Me">

  <UI Name="Text">
    <Content>
      <Repeater DividerName="Divider">
        <Layout>
          <FlowLayout Orientation="Vertical" Spacing="5,0"/>
        </Layout>
        <Source>
          <cor:String String="String 1"/>
          <cor:String String="String 2"/>
          <cor:String String="String 3"/>
          <cor:String String="String 4"/>
        </Source>

        <Content>
          <me:TextString Label="[RepeatedItem!cor:String]" MyIndex="[RepeatedItemIndex]"/>
        </Content>

      </Repeater>
    </Content>

    <Content Name="Divider">
        <Text Content="-----------" Color="LimeGreen" />
    </Content>
  </UI>

  <UI Name="TextString">
    <Properties>
      <cor:String Name="Label" cor:String="$Required"/>
      <Index Name="MyIndex" Index="$Required"/>
    </Properties>
    <Rules>
      <Binding Source="[MyIndex.Value]" Target="[IndexPrefix.Content]">
        <Transformer>
          <FormatTransformer Format="{0}"/>
        </Transformer>
      </Binding>
      <Binding Source="[Label]" Target="[LabelText.Content]"/>
    </Rules>
    <Content>
      <Panel>
        <Layout>
          <FlowLayout Orientation="Horizontal" Spacing="5,0"/>
        </Layout>
        <Children>
          <Text Color="Blue" Name="IndexPrefix"/>
          <Text Color="Green" Name="LabelText"/>
        </Children>
      </Panel>
    </Content>
  </UI>
</Mcml>

See Also
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Using Data Lists
To bind data to a Repeater, you need to store the data in an IList implementation. However, standard IList implementations have no way of notifying the Repeater when they've changed (when items are added or removed, the Repeater becomes out of sync). To solve this issue, use the ListDataSet and ArrayListDataSet classes. The ListDataSet class wraps an IList and sends notifications when its contents have changed. ArrayListDataSet is a ListDataSet subclass that uses an ArrayList as its backing store. If the data source for your Repeater is a ListDataSet, the Repeater monitors notifications of change. So when you call IList methods on the ListDataSet object, the content that is displayed in the Repeater is updated and kept in sync.
You can also use an ArrayListDataSet without using a Repeater. The indexing syntax works with string keys rather than integers, so use a dictionary to access it (object paths are not allowed). The following example shows how to use a dictionary such as PropertySet:
<PropertySet Name="Set">
    <Entries>
        <cor:String Name="Xyz" String="My Xyz string"/>
        <cor:String Name="Abc" String="My Abc string"/>
    </Entries>
</PropertySet>

To access this data, use the following syntax (where "#" indicates to use the dictionary indexer):
"[Set.#Xyz!cor:String]"

A data source can be located in a resource file that you reference in an xmlns statement to refer to it as a top-level global in your markup. For example:
<Mcml
...
xmlns:ds="http://www.YourSite.com/DataSource.mcml#DataSourceUI#DataSet">
    <UI Name="Default">
        <Locals>
            <!-- Array ready to be used in a Repeater -->
            <ArrayListDataSet ArrayListDataSet="global://ds:MyDataSet"/>
        </Locals>
    </UI>
...
</Mcml>

See Also
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Using Scrollers
The Scroller view item allows you to horizontally or vertically scroll text and images that cannot fit within the space provided.
A simple way to implement the Scroller is within the Content section of a UI, with a set of focusable interactive children. By default, the item that has focus is always in view. Items that do not fit within the scrolling region will be clipped.
The scrolling content can be interactive. For example, the user can mouse over a list of items, and the one that has focus changes appearance. The Scroller can be set to respond to different types of input, depending on the content. For example, a large block of text cannot receive focus, so the Scroller could be configured to respond to keyboard input (for example, by pressing the UP ARROW and DOWN ARROW keys) to scroll. The Scroller can also respond to mouse input to set focus on different items and to scroll.
You can configure the Scroller to display a fade on the vertical or horizontal edges of the scrolling region using the Orientation and FadeSize attributes. For example, a vertical orientation with a fade size of 20 will fade 20 pixels inside the top and bottom edges of the scrolling region. A negative fade size value fades the outside of the scrolling region. (The Scroller and Clip elements both provide edge fading. However, the Scroller element adds scrolling support.)
The following elements are used with the Scroller:
•	To specify how the scrolling data should behave, use the ScrollingData element, which tracks the current position of the scroll. You can also use its methods to change the scroll position—for example, if you want to create buttons that control scrolling.
•	To specify how the Scroller should respond to mouse and keyboard input, use the ScrollingInputHandler element. This handler works with ScrollingData to change the position of the current scroll position.
A useful implementation of the Scroller is to create a list of scrolling items. You can use the Repeater element to repeat a display of a defined UI. The Repeater element is required for list-based scrolling if you want to enable keyboard navigation through the list, and must be referenced by the ScrollingData element.
The following example displays static text within a small region. Because static text cannot receive focus, this example enables keyboard input (such as directional keys) to scroll through the text. For additional examples, see the Sample Explorer.
<Mcml xmlns="http://schemas.microsoft.com/2006/mcml">

  <UI Name="StaticTextScroller">

    <!-- Create the scrolling input handler and scrolling data objects. -->
    <Locals>
      <ScrollingHandler Name="ScrollingHandler" HandleHomeEndKeys="true"
                        HandleDirectionalKeys="true" HandlePageKeys="true"/>
      <ScrollingData Name="ScrollingData" />
    </Locals>

    <!-- Set ScrollingData into ScrollingHandler. -->
    <Rules>
      <Default Target="[ScrollingHandler.ScrollingData]" Value="[ScrollingData]"/>
    </Rules>

    <Content>
      <Panel Layout="VerticalFlow">
        <Children>
          <ColorFill Name="Background" Content="White" MouseInteractive="true"
                     Padding="30,30,30,30" MaximumSize="300,200" Margins="10,0,10,0">
            <Children>
              <Scroller Orientation="Vertical" FadeSize="-20" ScrollingData="[ScrollingData]" >
                <Children>
                  <Text Color="Blue" Font="Verdana,30" WordWrap="true"
                        Content="You can use the Up, Down, Home, End, PageUp, and PageDown keys to scroll through this text." />
                </Children>
              </Scroller>
            </Children>
          </ColorFill>
        </Children>
      </Panel>
    </Content>
  </UI>
</Mcml>

The following example shows a simple list that accepts mouse and directional-key input to scroll through the items, which change appearance when in focus.
<Mcml
  xmlns="http://schemas.microsoft.com/2006/mcml"
  xmlns:cor="assembly://MScorLib/System"
  xmlns:me="Me">

  <!-- This UI provides the content for the list. -->
  <UI Name="Scroller">
    <Content>
      <ColorFill Content="Honeydew" Padding="10,10,10,10" MaximumSize="0,300" >
        <Children>
          <Scroller Orientation="Vertical" FadeSize="-5">
            <Children>
              <Panel Layout="VerticalFlow">
                <Children>
                  <me:ListItem Description="One"/>
                  <me:ListItem Description="Two"/>
                  <me:ListItem Description="Three"/>
                  <me:ListItem Description="Four"/>
                  <me:ListItem Description="Five"/>
                  <me:ListItem Description="Six"/>
                  <me:ListItem Description="Seven"/>
                  <me:ListItem Description="Eight"/>
                  <me:ListItem Description="Nine"/>
                  <me:ListItem Description="Ten"/>
                </Children>
              </Panel>
            </Children>
          </Scroller>
        </Children>
      </ColorFill>
    </Content>
  </UI>

  <!-- This UI defines how to interact with mouse and keyboard input. -->
  <UI Name="ListItem">
    <Properties>
      <cor:String Name="Description" String="null"/>
    </Properties>

    <Rules>
      <!-- Set the UI to be mouse and keyboard interactive. -->
      <Default Target="[Input.KeyInteractive]" Value="true"/>

      <!-- Change the appearance of an item when it has focus. -->
      <Condition Source="[Input.KeyFocus]" SourceValue="true">
        <Actions>
          <Set Target="[Label.Color]" Value="White"/>
          <Set Target="[Label.BackColor]" Value="MediumSlateBlue"/>
        </Actions>
      </Condition>

    </Rules>

    <Content>
      <Text Name="Label" Content="[Description]" Font="Verdana,25"
            Color="MediumSlateBlue" BackColor="Transparent"/>
    </Content>
  </UI>
</Mcml>

The following example shows list-based scrolling using a Repeater, which provides more navigational options than the previous example. For additional examples, see the Sample Explorer.
<Mcml
  xmlns="http://schemas.microsoft.com/2006/mcml"
  xmlns:cor="assembly://MScorLib/System"
  xmlns:me="Me">

  <UI Name="ListBasedScroller">

    <Locals>
      <!-- The ScrollingHandler reacts to user keyboard input. Set the -->
      <!-- HandlerStage to "Bubbled" so that the Scroller doesn't get key focus. -->
      <ScrollingHandler Name="ScrollingHandler" HandlerStage="Bubbled"/>

      <!-- Use the default values for ScrollingData, although there are -->
      <!-- many options you can set to control scrolling behavior. -->
      <ScrollingData Name="ScrollingData" />
    </Locals>

    <Rules>

      <!-- Set ScrollingData into ScrollingHandler. -->
      <Default Target="[ScrollingHandler.ScrollingData]" Value="[ScrollingData]"/>

      <!-- Set the Repeater into the ScrollingData object. -->
      <Default Target="[ScrollingData.Repeater]" Value="[ListRepeater]"/>

    </Rules>

    <Content>
     <!-- This ColorFill container shows the edge fading specified in the Scroller. -->
      <ColorFill Padding="30,0,30,0" Content="Black" Margins="0,10,0,10">
        <Children>

         <!-- Define the Scroller and specify the ScrollingData object. -->
          <Scroller Orientation="Horizontal" MaximumSize="0,400" FadeSize="-30" ScrollingData="[ScrollingData]">
            <Children>

             <!-- The Repeater view item and its data source. -->
              <Repeater Name="ListRepeater" >
                <Layout>
                  <GridLayout Orientation="Vertical" AllowWrap="true" Spacing="10,10"/>
                </Layout>

                <Source>
                  <cor:String String="One"/>
                  <cor:String String="Two"/>
                  <cor:String String="Three"/>
                  <cor:String String="Four"/>
                  <cor:String String="Five"/>
                  <cor:String String="Six"/>
                  <cor:String String="Seven"/>
                  <cor:String String="Eight"/>
                  <cor:String String="Nine"/>
                  <cor:String String="Ten"/>
                  <cor:String String="One"/>
                  <cor:String String="Two"/>
                  <cor:String String="Three"/>
                  <cor:String String="Four"/>
                  <cor:String String="Five"/>
                  <cor:String String="Six"/>
                  <cor:String String="Seven"/>
                  <cor:String String="Eight"/>
                  <cor:String String="Nine"/>
                  <cor:String String="Ten"/>
                </Source>

                <Content>
                  <!-- Specifies the UI to repeat. -->
                  <me:ListItem Description="[RepeatedItem!cor:String]"/>
                </Content>

              </Repeater>

            </Children>
          </Scroller>
        </Children>
      </ColorFill>
    </Content>

  </UI>

  <!-- A key-interactive UI to repeat. -->
  <UI Name="ListItem">
    <Properties>
      <cor:String Name="Description" String="Hello!"/>
    </Properties>

    <!-- Initialize the input handler. -->
    <Locals>
      <ClickHandler Name="Clicker"/>
    </Locals>

    <!-- Change the appearance of the item when it has focus. -->
    <Rules>
      <Condition Source="[Input.KeyFocus]" SourceValue="true">
        <Actions>
          <Set Target="[Background.Content]" Value="LightGoldenrodYellow"/>
          <Set Target="[Label.Color]" Value="Firebrick"/>
        </Actions>
      </Condition>
    </Rules>

    <Content>
      <ColorFill Name="Background" Content="SlateGray" Padding="5,5,5,5" MinimumSize="150,100">
        <Layout>
          <FlowLayout Orientation="Vertical" ItemAlignment="Center"/>
        </Layout>
        <Children>
          <Text Name="Label" Content="[Description]" Color="White" Font="Verdana,10"/>
        </Children>
      </ColorFill>
    </Content>
  </UI>

</Mcml>

See Also
•	Creating a Layout
•	Sample Explorer
•	Media Center Markup Language Verifier
•	Using Clips
•	Using Repeaters

# K Displaying Text
You can display text in MCML using the Text view item, which allows you to specify fonts, colors, and additional text-related attributes such as whether to allow word wrapping. MCML supports RTF as multi-line formatted text in the Content field of a Text element.
Character and Entity References
To display characters that would otherwise be interpreted by the MCML parser as MCML code, use the following entity references in markup.
Character 	Entity Reference
< (less than)	&lt;
> (greater than)	&gt;
& (ampersand)	&amp;
' (apostrophe or single quote)	&apos;
" (double quote)	&quot;

For example, the MCML code below displays the following string: Specify your <username>
<cor:String String="Specify your &lt;username&gt;"/>
Text Layout
To create space between text items, you can use the FlowLayout layout, margins, or insert a Panel view item with a minimum size as a spacer. The following example shows how to create a basic text display with different ways of spacing text. This example also shows how to set fonts at the top level of the document for use by multiple user interfaces (UIs).

<Mcml
  xmlns="http://schemas.microsoft.com/2006/mcml"
  xmlns:me="Me">

  <Font Name="SmallFont" Font="Verdana,10" />
  <Font Name="BigFont" FontName="Verdana" FontSize="18"  FontStyle="Bold,Italic"/>

  <UI Name="TextDisplay">
    <!-- This UI displays the other UIs. -->
    <Content>
      <Panel>
        <Layout>
          <FlowLayout Orientation="Vertical" Spacing="50,0" />
        </Layout>
        <Children>
          <me:TextSettings/>
          <me:UsingMargins/>
          <me:UsingColorfillWithText/>
        </Children>
      </Panel>
    </Content>
  </UI>

  <UI Name="TextSettings">
    <!-- This UI provides an example for the MaximumLines and WordWrap settings. -->
    <Content>
      <Panel Layout="VerticalFlow" MaximumSize="140,0">
        <Children>
          <Text BackColor="Gold" Font="font://me:BigFont" MaximumLines="3" WordWrap="true"  
                Content="This large text will wrap.  This sentence won't be displayed because it exceeds the 3 line maximum." />
        </Children>
      </Panel>
    </Content>
  </UI>

  <UI Name="UsingMargins">
    <!-- This UI provides an example of using margins to create space between text items. -->
    <Content>
      <Panel Layout="VerticalFlow">
        <Children>
          <Text Color="Aquamarine" Font="font://me:SmallFont" Content="You can use margins to create space between text items:" />
          <Text Margins="0,20,0,0" Color="SkyBlue" Font="font://me:SmallFont" Content="This sentence has a top margin of 20 pixels." />
        </Children>
      </Panel>
    </Content>
  </UI>

  <UI Name="UsingColorfillWithText">
    <!-- This UI provides an example of placing text inside a ColorFill view item. -->
    <Content>
      <ColorFill Content="GreenYellow" MinimumSize="500,40" >
        <Children>
          <Text HorizontalAlignment="Center" Color="Maroon" Font="font://me:SmallFont" Content="This text is placed in a ColorFill view item." />
        </Children>
      </ColorFill>
    </Content>
  </UI>

</Mcml>

For an example of how to create edit boxes that accept triple-tap input, see the TripleTap Editbox example under Scenarios in the Sample Explorer.
See Also
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Concatenating Strings
MCML does not provide a way to concatenate strings, but you can do the following:
•	Use .NET APIs.
•	Use statics, as follows:
<Rule>
  <Actions>
    <Invoke Target="[cor:String.Concat]" str0="[Item1]" str1="[Item2]"
            ReturnTarget="[MyString]"/>
  </Actions>
</Rule>

•	Use System.Text.StringBuilder as follows:
<Mcml
  xmlns="http://schemas.microsoft.com/2006/mcml"
  xmlns:cor="assembly://MsCorLib/System"
  xmlns:text="assembly://MsCorLib/System.Text">
  <UI Name="Main">
    <Locals>
      <text:StringBuilder Name="StringBuilder"/>
      <cor:String Name="MyString" cor:String="Nothing"/>
      <cor:String Name="Item1" cor:String="Hello"/>
      <cor:String Name="Item2" cor:String=" World!"/>
    </Locals>
    <Rules>

      <Rule>
        <Actions>
          <Invoke Target="[StringBuilder.Append]" value="[Item1]" ExclusiveApply="false"/>
          <Invoke Target="[StringBuilder.Append]" value="[Item2]" ExclusiveApply="false"/>
          <Invoke Target="[StringBuilder.ToString]" ResultTarget="[MyString]"/>
        </Actions>
      </Rule>

      <Binding Source="[MyString]" Target="[IndexPrefix.Content]"/>

    </Rules>

    <Content>
      <Panel>
        <Layout>
          <FlowLayout Orientation="Horizontal" Spacing="5,0"/>
        </Layout>
        <Children>
          <Text Color="Blue" Name="IndexPrefix"/>
        </Children>
      </Panel>
    </Content>
  </UI>
</Mcml>
See Also
•	Displaying Text
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Creating an Edit Box
You can combine different view items to create standard controls, and then use the Microsoft.MediaCenter.UI API to manage the data. The following example shows how to create an edit box that limits the number of characters that are allowed, and uses the EditableText class to manage the text string.
<Mcml
    xmlns="http://schemas.microsoft.com/2006/mcml"
    xmlns:cor="assembly://MSCorlib/System"
    xmlns:me="Me">

  <!-- Test data for SimpleEditbox. -->
  <UI Name="TestSimpleEditbox">
    <Content>

      <!-- Simple edit box that limits the number of characters allowed. -->
      <me:SimpleEditbox MaxChars="10">

        <!-- Test EditableText. -->
        <EditableText>
          <EditableText Value=""/>
        </EditableText>

      </me:SimpleEditbox>
    </Content>
  </UI>

  <!-- Simple edit box -->
  <UI Name="SimpleEditbox">

    <Properties>

      <!-- EditableText is a required parameter. -->
      <EditableText Name="EditableText" EditableText="$Required"/>

      <!-- Limit the number of characters allowed. -->
      <cor:Int32 Name="MaxChars" Int32="5"/>

      <!-- Background color. -->
      <Color Name="BackgroundColor" Color="DimGray"/>
      <Color Name="BackgroundFocusedColor" Color="DarkGray"/>

      <!-- Label color. -->
      <Color Name="LabelColor" Color="White"/>
      <Color Name="LabelFocusedColor" Color="White"/>

    </Properties>

    <Locals>

      <!-- React to typing input. -->
      <TypingHandler Name="TypingHandler" EditableText="[EditableText]"/>

    </Locals>

    <Rules>

      <!-- The editable text value is bound to the label text value. -->
      <Binding Source="[EditableText.Value]" Target="[Label.Content]"/>

      <!-- Change color if in overtype mode. -->
      <Condition Source="[EditableText.Overtype]" SourceValue="true">
        <Actions>
          <Set Target="[Overtype.Visible]" Value="true"/>
          <Set Target="[Caret.Visible]" Value="false"/>
        </Actions>
      </Condition>

      <!-- Change color on key focus. -->
      <Condition Source="[Input.KeyFocus]" SourceValue="true">
        <Actions>
          <Set Target="[Background.Content]" Value="[BackgroundFocusedColor]"/>
          <Set Target="[Label.Color]" Value="[LabelFocusedColor]"/>
          <Set Target="[Caret.Visible]" Value="true"/>
        </Actions>
      </Condition>

      <!-- Stop typing when the maximum number of characters has been reached. -->
      <Changed Source="[EditableText.Value]">
        <Conditions>
          <Equality Source="[EditableText.Value.Length]" ConditionOp="GreaterThan" Value="[MaxChars]"/>
        </Conditions>
        <Actions>
          <Invoke Target="[EditableText.Value.Substring]" ResultTarget="[EditableText.Value]" startIndex="0" length="[MaxChars]"/>
        </Actions>
      </Changed>
    </Rules>

    <Content>

      <!-- Solid background color. -->
      <ColorFill Name="Background" Content="[BackgroundColor]"
                 MouseInteractive="true" Padding="5,5,5,5"
                  Layout="Anchor" MinimumSize="325,0" MaximumSize="325,0">

        <Children>

          <!-- Display the current value. -->
          <Text Name="Label" Color="[LabelColor]" Font="Arial,20"
                HorizontalAlignment="Far" Margins="0,0,10,0" MinimumSize="0,30"/>

          <!-- Display the caret. -->
          <ColorFill Name="Caret" Content="[LabelColor]" Visible="false" MinimumSize="12,4">

            <LayoutInput>
              <AnchorLayoutInput Left="Label,1,-10" Top="Label,0" Bottom="Label,1" Vertical="Far"/>
            </LayoutInput>

          </ColorFill>

          <!-- Overtype fill. -->

          <ColorFill Name="Overtype" Content="Black" Visible="false">

            <LayoutInput>
              <AnchorLayoutInput Left="Label,0" Right="Label,1" Top="Label,0" Bottom="Label,1"/>
            </LayoutInput>

          </ColorFill>
        </Children>
      </ColorFill>
    </Content>
  </UI>
</Mcml>

See Also
•	Displaying Text
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Working with Graphics
The Graphic element allows you to display images. MCML supports BMP, EMF, GIF, JPG, PNG, TIFF, and Windows Media formats. Using the layout settings in the Graphic element, you can specify the alignment, the maximum and minimum sizes, and specify whether to preserve the aspect ratio.
Notes   It is possible to apply settings that restrict the image so much that the image is not displayed at all. For more information, see Setting Minimum and Maximum Sizes.
To display dynamic images that are generated by code, write the image to a file first, and then reference the file.
Animated GIFs are not supported in MCML.
The following example displays an image that interactive. When you mouse over the image, it changes.
<Mcml xmlns="http://schemas.microsoft.com/2006/mcml"
      xmlns:me="Me">
  <Image Name="BlueFlower" Source="file://FlowerBlue.png"/>
  <Image Name="GreenFlower" Source="file://FlowerGreen.png"/>

  <UI Name="InteractiveImage">

    <Rules>
      <!-- When the image has mouse focus, change the Graphic. -->
      <Condition Source="[Input.MouseFocus]" SourceValue="true">
        <Actions>
          <Set Target="[Button.Content]" Value="image://me:BlueFlower"/>
          <Set Target="[Background.Content]" Value="Yellow"/>
        </Actions>
      </Condition>
    </Rules>

    <Content>
      <ColorFill Name="Background" Padding="15,15,15,15"
                 MouseInteractive="true" Content="DeepSkyBlue">
        <Children>
          <Graphic Name="Button" Content="image://me:GreenFlower"/>
        </Children>
      </ColorFill>
    </Content>

  </UI>
</Mcml>

When applying a scale or rotation to an image, the image is scaled or rotated based on the top-left (0,0) corner of the image. Then, the image can appear to be displayed off center, even if you specify a centered alignment. You can change the point of scale or rotation using the CenterPointPercent and CenterPointOffset attributes as follows:
•	CenterPointPercent moves the point of scale or rotation based on a percentage of X and Y from the top-left corner. For example, to move the center point to the exact center (50% of X and of Y), you specify CenterPointPercent=".5, .5, 0".
•	CenterPointOffset moves the point of scale or rotation based on a pixel offset of X and Y from the top-left corner. For example, to move the center point to 20 pixels in both X and Y directions, you would specify CenterPointOffset="20, 20, 0".
If you specify values for both attributes, CenterPointPercent is applied first.
The following example shows how to display an image, and how different settings affect the way the image is displayed:


<Mcml xmlns="http://schemas.microsoft.com/2006/mcml" >
  <UI Name="Images">
    <Content>
      <Panel Layout="HorizontalFlow" >
        <Layout>
          <FlowLayout Orientation="Horizontal" Spacing="50,0" />
        </Layout>
        <Children>

          <!-- A simple way to display a 100 x 100 pixel image with superimposed text. -->
          <Graphic Content="file://LayoutItem.png" Margins="20,0,20,0" >
            <Children>
              <Text Content="Simple image display" Color="White" Font="Tahoma,12" WordWrap="true"/>
            </Children>
          </Graphic>

          <!-- A simple way to display a 100 x 100 pixel image, scaled up. The child Text element is also -->
          <!-- rescaled. The CenterPointPercent setting keeps the image centered within the space given to it. -->
          <Graphic Content="file://LayoutItem.png" Scale="2,2,2" CenterPointPercent=".5, 0, .5" Margins="20,0,20,0" >
            <Children>
              <Text Content="Scaling" Color="White" Font="Tahoma,12" WordWrap="true"/>
            </Children>
          </Graphic>

          <!-- An image centered within a colorfill. -->
          <ColorFill Content="Gray" MinimumSize="200,200" Margins="20,0,20,0">
            <Children>
              <Graphic Content="file://LayoutItem.png"  HorizontalAlignment="Center" VerticalAlignment="Center">
                <Children>
                  <Text Content="Alignment within parent" Color="White" Font="Tahoma,12" WordWrap="true" MaximumSize="200,0"/>
                </Children>
              </Graphic>
            </Children>
          </ColorFill>

          <!-- An image within a colorfill. The vertical and horizontal alignments are set to "Fill", so the image -->
          <!-- is scaled to fill the parent. -->
          <ColorFill Content="Gray"  MinimumSize="200,200" >
            <Children>
              <Graphic Content="file://LayoutItem.png" HorizontalAlignment="Fill" VerticalAlignment="Fill" >
                <Children>
                  <Text Content="Scaled to parent" Color="White" Font="Tahoma,12" WordWrap="true" />
                </Children>
              </Graphic>
            </Children>
          </ColorFill>

          <!-- The parent is smaller than the image and is set to a different aspect ratio. The image is scaled -->
          <!-- but is not set to preserve the original aspect ratio. -->
          <ColorFill Content="Gray" MaximumSize="50,100" >
            <Children>
              <Graphic Content="file://LayoutItem.png" HorizontalAlignment="Fill" VerticalAlignment="Fill" MaintainAspectRatio="false"  >
                <Children>
                  <Text Content="New aspect ratio" Color="White" Font="Tahoma,12" WordWrap="true" />
                </Children>
              </Graphic>
            </Children>
          </ColorFill>

        </Children>
      </Panel>
    </Content>
  </UI>
</Mcml>

See Also
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Using Nine-Grid Rendering
When working with images, you can use nine-grid rendering to control how an image is resized. When an image is resized normally, the entire image is stretched evenly and linearly in both horizontal and vertical dimensions. When you use nine-grid rendering, you can specify how different segments of the image are stretched. This feature is useful for preserving the detail on image corners.
Nine-grid rendering divides an image into a grid of nine sections:

Nine-grid rendering allows you to preserve the original dimensions of the corners (boxes 1, 3, 7, and 9). The top and bottom (boxes 2 and 8) are stretched horizontally only, and the sides (boxes 4 and 6) are stretched vertically only. The center (box 5) is stretched in both dimensions.
To use nine-grid rendering, you must create an Image element and specify the nine-grid values—pixel values for the lengths of the left, top, right, and bottom sides of the grid:

The following is an example of an Image element:
<Image Name="9Grid" Source="file://9grid.bmp" NineGrid="30,30,30,30" />

The following example shows how an image appears when resized normally and using nine-grid rendering. Note that when the image is resized larger, the corners appear pixilated. When nine-grid rendering is used, the corners remain smooth with finer detail. For additional examples, see the Sample Explorer.

<Mcml xmlns="http://schemas.microsoft.com/2006/mcml"
 xmlns:me="Me" >

  <Image Name="9Grid" Source="file://9grid.bmp" NineGrid="30,30,30,30" />

  <UI Name="9GridImages">
    <Content>
      <Panel >
        <Layout>
          <FlowLayout Orientation="Vertical"  Spacing="20,0" />
        </Layout>
        <Children>

          <Text Margins="0,15,0,0" Color="White" Font="Verdana,12" Content="The original image:" />
          <me:Original/>

          <Text Margins="0,15,0,0" Color="White" Font="Verdana,12" Content="Stretched evenly 2x larger:" />
          <me:Doubled/>

          <Text Margins="0,15,0,0" Color="White" Font="Verdana,12" Content="Stretch 2x using NineGrid=30,30,30,30:" />
          <me:NineGrid/>
        </Children>
      </Panel>
    </Content>
  </UI>

  <UI Name="Original">
    <Content>
      <Panel  >
        <Children>
          <!-- The original image, which is 85 x 85 pixels. -->
          <Graphic HorizontalAlignment="Near" VerticalAlignment="Near" Content="file://9grid.bmp" />
        </Children>
      </Panel>
    </Content>
  </UI>

  <UI Name="Doubled">
    <Content>
      <Panel Layout="VerticalFlow" MaximumSize="170,170" >
        <Children>
          <!-- Scaled 2 x 2 larger. The corners are pixelated. -->
          <Graphic Content="file://9grid.bmp" HorizontalAlignment="Fill" VerticalAlignment="Fill" SizingPolicy="SizeToConstraint" />
        </Children>
      </Panel>
    </Content>
  </UI>

  <UI Name="NineGrid">
    <Content>
      <Panel Layout="VerticalFlow" MaximumSize="170,170" >
        <Children>
          <!-- Scaled 2 x 2 larger. The NineGrid values preserve the size of the corners. -->
          <Graphic Content="image://me:9Grid" HorizontalAlignment="Fill" VerticalAlignment="Fill" SizingPolicy="SizeToConstraint" />
        </Children>
      </Panel>
    </Content>
  </UI>

</Mcml>

See Also
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Creating Visual Effects
You can achieve various visual effects in MCML by creatively displaying images and using attribute settings. All view items are displayed within rectangles, and you cannot specify rounded edges or other shapes. If you want to display other shapes, you must create and display an image. You can also create a mask and display that over another image or colorfill area. In the example below, a black outline with a transparent center is displayed over another image. The result is an image with a rounded edge. You could also use graphic overlays with other view items, such as colorfills and videos.

To change the transparency of images, you can specify an alpha value for all view items, indicating a value for opacity based on percentage. For example, you specify 50% opacity by using the attribute Alpha=".5".

You can also set a FadeSize attribute when using the Scroller view item to control the way items are faded while scrolling. For more information, see Using Scrollers.
You can create effects simply by displaying multiple view items within a UI. The first item has the highest z-order; that is, the first item is displayed on top of the next item, and so forth.
To create other effects, such as an image that changes intensity (for example, a glowing effect), you can create animations that cycle through multiple images. For examples, see the Sample Explorer.
The following MCML code was used for the first example above:
<Mcml xmlns="http://schemas.microsoft.com/2006/mcml"
      xmlns:me="Me" >

  <UI Name="RoundedImages">
    <Content>
      <Panel Layout="HorizontalFlow">
        <Children>

          <!-- This UI displays two images on a white background. -->
          <me:Separate />

          <Text Margins="0,60,0,0" Content="  = " Font="Verdana,24,Bold" Color="White"/>

          <!-- This UI displays one image over the other. -->
          <me:Overlay />

        </Children>
      </Panel>
    </Content>
  </UI>

  <UI Name="Separate">
    <Content>
      <ColorFill Content="White" Layout="HorizontalFlow" Padding="5,5,5,5">
        <Children>
          <!-- This first image is transparent in the center. -->
          <Graphic Content="file://Mask.png" Margins="5,5,5,5" />
          <Text Margins="0,60,0,0" Content=" + " Font="Verdana,24,Bold" Color="Black"/>
          <Graphic Content="file://Circle.png" Margins="5,5,5,5" />
        </Children>
      </ColorFill>
    </Content>
  </UI>

  <UI Name="Overlay">
    <Content>
      <Panel >
        <Children>
          <!-- The images are superimposed. The mask is the same color as the background, -->
          <!-- and appears to create a rounded edge around the image underneath. -->
          <Graphic Content="file://Mask.png"   Margins="15,5,5,5" />
          <Graphic Content="file://Circle.png" Margins="15,5,5,5" />
        </Children>
      </Panel>
    </Content>
  </UI>
</Mcml>

See Also
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Working with Audio and Video
Audio
You can play sound effects in MCML by using a PlaySound action in a custom rule. In the following example, a sound is played in response to a click event. For a complete example, see the AdvancedMarkup.Sounds.PlaySoundAction.mcml sample in the Sample Explorer.
<Rules>

    <!-- Watch for the click event. -->
    <Changed Source="[Charge.Invoked]">

        <Actions>

            <!-- Play a sound. -->
            <PlaySound Sound="res://McmlSampler!ChaChing.wav"/>

        </Actions>
    </Changed>
</Rules>

Video
To display video in MCML, use the Video view item. The Video element does not provide a way to start, stop, or change the content that is playing, so to control video you must use the Windows Media Center Presentation Layer API.
The current video that is playing is displayed within a Video view item, although the size of the view item does not affect the size of the video. When configuring the layout, set a minimum size or use anchor points for Form or Anchor layout.
You can capture a video click event (the user clicks or selects a view port) by placing a Video view item within a UI that has implemented a ClickHandler, with HandlerStage set to "Routed" (if you want to intercept it before the video is displayed full screen).
You can create effects simply by displaying multiple view items within a UI. The first item has the highest z-order; that is, the first item is displayed on top of the next item, and so forth.
The following example creates a rotating video with an overlay that is an alpha-blended button. (Before you use this example, specify a path to a video file.)
<Mcml xmlns="http://schemas.microsoft.com/2006/mcml"
      xmlns:cor="assembly://MSCorLib/System"
      xmlns:mce="assembly://Microsoft.MediaCenter/Microsoft.MediaCenter.Hosting"
      xmlns:me="Me" >

  <UI Name="Default">

    <Locals>
      <mce:AddInHost Name="MCEHost"/>
    </Locals>

    <Content>
      <Panel Name="MyButtonPanel" Layout="Anchor">

        <Children>

          <me:Button>
            <MyCommand>
              <InvokeCommand Target="[MCEHost.MediaCenterEnvironment.PlayMedia]" mediaType="Video" addToQueue="false" Description="Play">
                <media>
                  <!-- Replace this string with a path to a sample video. -->
                  <cor:String String="c:\Video.wmv"/>
                </media>
              </InvokeCommand>
            </MyCommand>
          </me:Button>

          <Panel Name="MyPanel" Layout="Anchor">

            <Animations>
              <Animation Loop="-1" CenterPointPercent="0.5,0.5,0.5">
                <Keyframes>
                  <RotateKeyframe Time="0.0" Value="0deg;0.5,0.5,1.0"/>
                  <RotateKeyframe Time="20.0" Value="360deg;0.5,0.5,1.0"/>
                </Keyframes>
              </Animation>
            </Animations>

            <Children>
              <Video Name="MyVideo" MinimumSize="800,600"/>
            </Children>

          </Panel>

        </Children>
      </Panel>
    </Content>
  </UI>

  <!-- Simple button -->
  <UI Name="Button">

    <Locals>
      <ClickHandler Name="Clicker" Command="[MyCommand]"/>
    </Locals>

    <Properties>
      <ICommand Name="MyCommand" ICommand="$Required"/>
    </Properties>

    <Rules>
      <Binding Source="[MyCommand.Description]" Target="[MyLabel.Content]"/>
    </Rules>

    <Content>
      <ColorFill Name="Background" Content="Firebrick" MouseInteractive="true" Padding="20,1,20,20" Alpha=".5" MinimumSize="400,40">
        <Children>
          <Text Name="MyLabel" Color="White" Font="Calibri,80"/>
        </Children>
      </ColorFill>
    </Content>

  </UI>
</Mcml>
See Also
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Working with NowPlaying
To display the Now Playing inset in MCML, use the NowPlaying view item. This functionality is controlled by the Windows Media Center Presentation Layer API.
The NowPlaying element is used only for positioning and it does not respond to animations or transforms such as scaling or rotation. Rather, the NowPlaying view item indicates where Windows Media Center should place the Now Playing inset.
The NowPlaying element has a few configuration options:
•	The ShowFullMetadata attribute indicates whether to size the inset to display metadata. When this attribute is set to "Always", the minimum size of the inset is 735 × 132 pixels. When set to "Never", the inset requires 176 × 132 pixels. If you override the default minimum size, be careful to allow adequate space or the view item may not be displayed correctly or may not be displayed at all.
•	The SnapToDefaultPosition specifies whether to position the Now Playing inset in the same location, with the same size, as the Now Playing UI within Media Center.
The following example shows how to use the NowPlaying view item (for additional examples, see the Sample Explorer):
<Mcml xmlns="http://schemas.microsoft.com/2006/mcml">
  <UI Name="MediaCenterServices">
    <Content>
      <Panel Layout="Form">
        <Children>
          <!-- Place the Now Playing UI at the bottom left of the screen. -->
          <NowPlaying ShowFullMetadata="OnFocus" SnapToDefaultPosition="true">
            <LayoutInput>
              <FormLayoutInput Left="Parent,0" Bottom="Parent,1"/>
            </LayoutInput>
          </NowPlaying>
        </Children>
      </Panel>
    </Content>
  </UI>
</Mcml>

See Also
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Displaying Multiple Video and NowPlaying Items
You can have multiple Video and NowPlaying view items; however, the following limitations may affect your design:
•	The Windows Media Center shell can play only one video stream at a time. In most cases, multiple Video view items will be drawn, but will show the same content.
•	The Media Center shell has only one Now Playing inset for the NowPlaying placeholder for applications. Therefore, if you have more than one NowPlaying placeholder, the shell will choose just one location to display the inset.
•	Some Media Center Extender devices can only display video in a single screen location at a time, so only one Video view item will display video.
Therefore, consider the following as you implement Video and NowPlaying view items:
•	Extender scenarios vary with hardware, but implementations that support displaying video in only one place are likely in the foreseeable future.
•	The Extender implementation on Xbox 360 supports multiple Video elements and so can display video in multiple places at the same time.
•	The NowPlaying limit in the Media Center shell is not likely to change.
See Also
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Creating a Layout
Creating a layout is a process of positioning and sizing items given a set of constraints. The purpose of the layout is to position the direct children of the view item, and to determine the size of the view item as follows:
•	Size-to-content considers the sizes and positions of the view item's children, and then returns a size that is tight around the children.
•	Size-to-parent ignores the sizes and positions of the view item's children and sizes the view item to the parent.
The layout is defined per view item by specifying the kind of layout you want. You can use preset layout configurations with a simple inline statement, or you can use the expanded form if you want more control over configuration.
When you do not specify a layout, a default layout is applied. By default, the view item is sized to children, where the overall size is determined by the largest child element. All other children are stacked on top of each other in the same order as they appear in the MCML document (the first child is at the top of the stack, and the last child is at the bottom of the stack.)
MCML layout scales items rather than giving exact positions; everything is relative. Typically, size-to-content options are used, which works well with globalization issues. For example, buttons can adjust in size according to varying sizes of text labels.
When considering layout, think in general terms of where groups of items or containers should be anchored. For example, a title might be anchored to the top right, or a group of icons might be centered horizontally (left to right).
See Also
•	Developing Applications for Windows Media Center

# Layout Types
The following options are available for preset layouts:
•	Anchor: Arranges children by anchoring edges (sizes to children).
•	Center: Fills the space by centering children on top of each other (sizes to parent).
•	Dock: Arranges children along the border of the parent (sizes to parent).
•	Fill: Makes children the size of the parent (sizes to parent).
•	Form: Arranges children by anchoring edges (sizes to parent).
•	Grid: Arranges children in a grid (sizes to children).
•	HorizontalFlow: Flows children in a horizontal orientation (sizes to children).
•	Rotate: Rotates children and includes space in layout (sizes to children).
•	Scale: Scales children and includes space in the layout (sizes to parent).
•	VerticalFlow: Flows children in a vertical orientation (sizes to children).
Or, to create a custom layout, use the following layout elements:
•	AnchorLayout
•	DockLayout
•	FlowLayout
•	GridLayout
•	RotateLayout
•	ScaleLayout
The view item's margins and padding create a buffer around the view item, which also affects these layout options.
# Layout Inputs
Layout input provides for additional information for the parent to lay out the children. The following keywords are special values for identifying AnchorLayoutInput and FormLayoutInput objects:
•	Parent (refers to the parent element)
•	Focus (refers to the next item that has focus)
The following layout input elements allow you to further customize the layout:
•	The AnchorLayoutInput element lets you define the edges with respect to other items in the view item and the parent.
•	The DockLayoutInput element lets you specify alignment and position with respect to the borders of the view item.
•	The FormLayoutInput element lets you define the edges with respect to other items in the view item and the parent.
See Also
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Using Fill Layout
Fill layout uses the entire size of the parent, and sizes all of its children to the same size as well. If a child has a maximum size that is smaller than the size forced by the parent, this child is not displayed.
The example below shows how fill layout can be used and how it compares to another layout, such as center layout.

<Mcml
  xmlns="http://schemas.microsoft.com/2006/mcml">

  <UI Name="Fill">
    <Content>
      <Panel>
        <Layout>
          <FlowLayout Orientation="Vertical" Spacing="20,0" />
        </Layout>
        <Children>

          <!-- This colorfill uses Fill layout. The child fills up the parent area. -->
          <ColorFill Layout="Fill" Content="Green" MaximumSize="0,50" >
            <Children>
              <Text Content="Fill layout" BackColor="Firebrick" />
            </Children>
          </ColorFill>

          <!-- This colorfill uses Center layout to show the difference when a layout -->
          <!-- uses only the space it needs. -->
          <ColorFill Layout="Center" Content="Blue" MaximumSize="0,50" >
            <Children>
              <Text Content="Center layout" BackColor="Yellow" />
            </Children>
          </ColorFill>

          <!-- This colorfill uses Fill layout, but the child won't be displayed -->
          <!-- because its maximum size is smaller than the parent's. -->
          <ColorFill Content="Violet" Layout="Fill" MaximumSize="0,50">
            <Children>
              <Text Content="This won't be displayed" BackColor="Orange" MaximumSize="0,40" />
            </Children>
          </ColorFill>

        </Children>
      </Panel>
    </Content>
  </UI>
</Mcml>

See Also
•	Creating a Layout
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Using Form and Anchor Layouts
FormLayout and AnchorLayout allow you to position children in a parent container without a lot of nesting to achieve the results you want. Using the corresponding layout input (FormLayoutInput or AnchorLayoutInput) to provide more information, the edges of each child can be positioned relative to the other children or to the parent element. An edge of the child (top, bottom, left, and right) is anchored to another target child or parent based on percentages of the target's size, which creates an AnchorEdge. For example, you can anchor a child to a parent's top border, at 25% of the width (see the example below). The starting point (0 or 0%) is at the top left of the target item. You can also specify pixel offsets. For example, you can anchor a child to another child's edge plus 25 pixels.
To indicate which target to use as an anchor edge, specify the target's name as the AnchorEdge ID. To refer to the parent, you can use the Parent keyword. You can also use the Focus keyword to refer to the item that has focus.
FormLayout is identical to AnchorLayout, except in the way they size:
•	FormLayout sizes the layout to the parent. The layout uses the entire size of the parent and arranges children within that space. The Form layout is useful as a top-level layout. Use FormLayoutInput to provide edge anchor information.
•	AnchorLayout sizes the layout to children. The layout uses only the space that is needed to position the children within that space. Use AnchorLayoutInput to provide edge anchor information. You can also specify whether the size of child elements should affect the size of the parent's height and width.
Like all layout types, certain anchor layout constraints can lead to unpredictable results. By default, the anchor layout provides equal area around the starting reference for other sibling elements. If siblings run out of room—for instance if they are all anchored to one side of the starting reference—undesired clipping could occur. Also, be aware that the size of the parent is always relative to the full size of the layout container. When creating a layout, consider changing the parent to use Form layout; you can then see the area you are working with, make adjustments, and then switch back to Anchor layout.
The following example shows how to position one item with respect to another using a Form layout. The top and left edges of the first item (the orange colorfill) are positioned at 25% (.25) of the parent's height and width. The other items are placed with respect to the first child. For additional examples, see the Sample Explorer.

<Mcml xmlns="http://schemas.microsoft.com/2006/mcml">
  <UI Name="PositionSample">
    <Content>

      <!-- A Form layout. -->
      <ColorFill Content="White" Layout="Form">
        <Children>

          <!-- The top edge of this child element is anchored to 25% of -->
          <!-- the parent's height. The left edge of the child is anchored -->
          <!-- at 25% of the parent's width. -->
          <ColorFill Name="Orange" Content="Orange" MinimumSize="50,50" >
            <LayoutInput>
              <FormLayoutInput Left="Parent,.25" Top="Parent,.25"/>
            </LayoutInput>
          </ColorFill>

          <!-- This item is anchored to the Orange element. The left edge -->
          <!-- is the same. The top is aligned with the Orange element's -->
          <!-- bottom edge plus 10 pixels. -->
          <ColorFill Name="Green" Content="Green" MinimumSize="50,50" >
            <LayoutInput>
              <FormLayoutInput Left="Orange,0"  Top="Orange,1,10"/>
            </LayoutInput>
          </ColorFill>

          <!-- This item is anchored to the Orange element. The top edge -->
          <!-- is the same. The left is aligned with the Orange element's -->
          <!-- right edge plus 10 pixels. -->
          <ColorFill Name="Blue" Content="Blue" MinimumSize="50,50" >
            <LayoutInput>
              <FormLayoutInput Left="Orange,1, 10" Top="Orange,0"/>
            </LayoutInput>
          </ColorFill>

          <!-- This item is anchored to the Orange element. The top edge -->
          <!-- is the same. The right is aligned with the Orange element's -->
          <!-- left edge minus 10 pixels. -->
          <ColorFill Name="Red" Content="Red" MinimumSize="50,50" >
            <LayoutInput>
              <FormLayoutInput Right="Orange,0,-10" Top="Orange,0"/>
            </LayoutInput>
          </ColorFill>

          <!-- This item is anchored to the Orange element. The left edge -->
          <!-- is the same. The bottom is aligned with the Orange element's -->
          <!-- top edge minus 10 pixels. -->
          <ColorFill Name="Violet" Content="Violet" MinimumSize="50,50" >
            <LayoutInput>
              <FormLayoutInput Bottom="Orange,0,-10" Left="Orange,0"/>
            </LayoutInput>
          </ColorFill>

        </Children>
      </ColorFill>
    </Content>
  </UI>
</Mcml>

See Also
•	Creating a Layout
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Using Dock Layouts
DockLayout positions children in a docking manner along the parent borders. By default, DockLayout uses the entire size of the parent and arranges children within that space. This layout needs more information from the DockLayoutInput element to specify the borders to place the children. This process is subtractive: after a child has been placed, any remaining space is available to the next child, and so forth. In the example below, notice that the center-right position changes when additional child elements are added.

<Mcml xmlns="http://schemas.microsoft.com/2006/mcml">
  <UI Name="UsingDockLayout">
    <Content>
      <ColorFill Content="MidnightBlue" Layout="Dock" >
        <Children>

          <Text Name="One" Color="White" Content="Far+Top" >
            <LayoutInput>
              <DockLayoutInput Alignment="Far" Position="Top" />
            </LayoutInput>
          </Text>

          <Text Name="Two" Color="Red" Content="Near+Bottom" >
            <LayoutInput>
              <DockLayoutInput Alignment="Near" Position="Bottom"  />
            </LayoutInput>
          </Text>

          <Text Name="Three" Color="Yellow" Content="Center+Right" >
            <LayoutInput>
              <DockLayoutInput Alignment="Center" Position="Right"  />
            </LayoutInput>
          </Text>

          <Text Name="Four" Color="DarkGoldenrod" Content="Another Center+Right" >
            <LayoutInput>
              <DockLayoutInput Alignment="Center" Position="Right"  />
            </LayoutInput>
          </Text>

        </Children>
      </ColorFill>
    </Content>
  </UI>
</Mcml>

See Also
•	Creating a Layout
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Using Vertical and Horizontal Flow Layouts
VerticalFlow and HorzontalFlow positions children in a side-by-side flow (either top to bottom or left to right). By default, these layouts size to children and use only the space that is needed to position the children. If you use inline form (for example, Layout="VerticalFlow" or Layout="HorizontalFlow"), the default configuration is used: wrapping is not set, item alignment is "Near", and there is no space between items. If you want to create a custom configuration, use expanded form.
The example below displays two UI elements side by side in a horizontal flow layout. One UI uses the inline form of vertical flow layout with default settings, and the second UI uses expanded form of vertical flow layout with custom settings.

<Mcml
xmlns="http://schemas.microsoft.com/2006/mcml"
xmlns:me="Me" >

  <UI Name="VerticalAndHorizontalFlow">
    <Content>
      <!-- This UI display the two UIs (Inline and Expanded) in a horizontal layout. -->
      <!-- The expanded form is used to create a custom horizontal layout configuration. -->
      <ColorFill Content="White" Padding="10,10,10,10">

        <Layout>
          <FlowLayout Orientation="Horizontal" Spacing="15,15" />
        </Layout>

        <Children>
          <!-- These UIs are defined below. -->
          <me:Inline/>
          <me:Expanded/>
        </Children>

      </ColorFill>
    </Content>
  </UI>

  <!--This UI uses inline form with default settings for vertical flow. -->
  <UI Name="Inline">
    <Content>
      <ColorFill Content="CornflowerBlue" Layout="VerticalFlow">
        <Children>
          <Text Content="Inline Form" />
          <Text Content="Apple" />
          <Text Content="Banana" />
          <Text Content="Orange" />
        </Children>
      </ColorFill>
    </Content>
  </UI>

  <!--This UI uses expanded form with custom settings for spacing and alignment. -->
  <UI Name="Expanded">
    <Content>
      <ColorFill Content="Goldenrod" >
        <Layout>
          <FlowLayout Orientation="Vertical" Spacing="15,15" ItemAlignment="Far" />
        </Layout>
        <Children>
          <Text Content="Expanded Form" />
          <Text Content="Apple" />
          <Text Content="Banana" />
          <Text Content="Orange" />
        </Children>
      </ColorFill>
    </Content>
  </UI>

</Mcml>

See Also
•	Creating a Layout
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Using Centered Layouts
The Center layout centers all children. This layout uses the entire size of the parent and arranges children within that space. In the example below, three ColorFill elements are centered within a parent ColorFill element.

<Mcml
xmlns="http://schemas.microsoft.com/2006/mcml"
xmlns:me="Me" >

  <UI Name="Centered">
    <Content>
      <!-- This UI displays the  UIs defined below in a centered layout. -->
      <ColorFill Content="SlateGray" Layout="Center" >
        <Children>
          <!-- These UIs are defined below. -->
          <!-- Notice that the children are stacked in the order they appear here. -->
          <me:SmallBox/>
          <me:MediumBox/>
          <me:LargeBox/>
        </Children>
      </ColorFill>
    </Content>
  </UI>

  <!--This UI uses expanded form with custom settings for spacing and alignment. -->
  <UI Name="SmallBox">
    <Content>
      <ColorFill Content="Goldenrod" MinimumSize="15,15" />
    </Content>
  </UI>
  <UI Name="MediumBox">
    <Content>
      <ColorFill Content="CornflowerBlue" MinimumSize="50,50" />
    </Content>
  </UI>
  <UI Name="LargeBox">
    <Content>
      <ColorFill Content="Crimson" MinimumSize="100,100" />
    </Content>
  </UI>
</Mcml>

See Also
•	Creating a Layout
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Using Scale Layouts
Using ScaleLayout, you can position graphics and specify how they can be scaled. You can use expanded form for custom settings. Or, use the inline form (Layout="Scale") to use the default settings: scaling down is allowed, scaling up is not allowed, and the aspect ratio is maintained.
The following example shows different ways to use ScaleLayout. For additional examples, see the Sample Explorer.

<Mcml xmlns="http://schemas.microsoft.com/2006/mcml">
  <UI Name="ScaleLayout">
    <Content>
      <Panel>
        <Layout>
          <FlowLayout Orientation="Horizontal" Spacing="150,0"/>
        </Layout>
        <Children>

          <!-- This uses inline form for scale layout. -->
          <ColorFill Content="White"  Layout="Scale" MaximumSize="50,50" Padding="10,10,10,10" >
            <Children>
              <Graphic Content="file://LayoutItem.png"
                       HorizontalAlignment="Fill" VerticalAlignment="Fill" />
            </Children>
          </ColorFill>

          <!-- This uses expanded form for scale layout. Scaling down is not allowed, -->
          <!-- so the image is displayed at its original size beyond the parent. -->
          <ColorFill Content="White" MaximumSize="50,50" Padding="10,10,10,10" >
            <Layout>
              <ScaleLayout AllowScaleDown="false" />
            </Layout>
            <Children>
              <Graphic Content="file://LayoutItem.png"
                       HorizontalAlignment="Fill" VerticalAlignment="Fill" />
            </Children>
          </ColorFill>

          <!-- This uses expanded form for scale layout with custom settings. -->
          <!-- This layout is not square and allows the image to be displayed. -->
          <!-- in a different aspect ratio. -->
          <ColorFill Content="White" MaximumSize="150,350" Padding="10,10,10,10" >
            <Layout>
              <ScaleLayout AllowScaleDown="true" AllowScaleUp="false" MaintainAspectRatio="false"/>
            </Layout>
            <Children>
              <Graphic Content="file://LayoutItem.png"
                       HorizontalAlignment="Fill" VerticalAlignment="Fill" />
            </Children>
          </ColorFill>

        </Children>
      </Panel>
    </Content>
  </UI>
</Mcml>

See Also
•	Creating a Layout
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Using RotateLayout
Using RotateLayout, you can rotate items within a layout by specifying a rotation angle. You can specify one of the following values: 0, 90, 180, or 270 degrees.

<Mcml xmlns="http://schemas.microsoft.com/2006/mcml">
  <UI Name="RotateLayout">
    <Content>
      <Panel>
        <Layout>
          <FlowLayout Orientation="Horizontal" Spacing="50,0"/>
        </Layout>
        <Children>

          <!-- No rotation. -->
          <Graphic Content="file://Arrow.png" />

          <!-- 90 degree rotation. -->
          <Panel>
            <Layout>
              <RotateLayout AngleDegrees="90" />
            </Layout>
            <Children>
              <Graphic Content="file://Arrow.png" >
              </Graphic>
            </Children>
          </Panel>
        </Children>
      </Panel>
    </Content>
  </UI>
</Mcml>

See Also
•	Creating a Layout
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Using Grid Layouts
With GridLayout, you can specify rows and columns to display content in a tabular layout. This layout is typically used with the Repeater element to populate the data.
The following example shows how to use the Repeater element with a grid layout. For additional examples, see the Sample Explorer.
<Mcml xmlns="http://schemas.microsoft.com/2006/mcml"
      xmlns:cor="assembly://mscorlib/System"
      xmlns:me="Me">


    <UI Name="UsingGridLayout">

        <Properties>

            <Size Name="TestSize" Size="0,300"/>
            <Inset Name="TestSpacing" Inset="10,10,10,10"/>

        </Properties>

        <Content>

            <Panel Layout="VerticalFlow" Margins="20,10,20,10">
                <Layout>
                    <FlowLayout Orientation="Vertical"/>
                </Layout>
                <Children>

                    <!-- You can specify different values for a GridLayout so that it can -->
                    <!-- calculate the cell size. The possible values you can specify are: -->
                    <!-- * Column and row count -->
                    <!-- * ReferenceSize -->
                    <!-- * Implicit measurement -->
                    <!-- These values don't need to be used exclusively. A zero value for -->
                    <!-- Column, Row, ReferenceSize.Width, or ReferenceSize.Height means -->
                    <!-- the value is unspecified. You may combine a specified Column with -->
                    <!-- a ReferenceSize.Height, for example. -->

                    <!-- This grid layout specifies how many columns and rows you want. -->
                    <!-- The horizontal cell size is known. The vertical cell size is -->
                    <!-- determined by the first item. -->

                    <Text Font="Arial, 20" Color="White"
                          Content="Specified 7 columns, and 4 rows for the grid"/>

                    <me:AlphabetGrid Size="[TestSize]" Padding="[TestSpacing]"/>

                </Children>
            </Panel>

        </Content>

    </UI>


    <!-- This UI displays a grid of letters. -->
    <UI Name="AlphabetGrid">

        <Properties>

            <!-- The size to constrain this layout to. -->
            <Size Name="Size"/>

        </Properties>

        <Locals>

            <!-- The data source for the grid is the alphabet. -->
            <ArrayListDataSet Name="Alphabet">
                <Source>
                    <cor:String String="A"/>
                    <cor:String String="B"/>
                    <cor:String String="C"/>
                    <cor:String String="D"/>
                    <cor:String String="E"/>
                    <cor:String String="F"/>
                    <cor:String String="G"/>
                    <cor:String String="H"/>
                    <cor:String String="I"/>
                    <cor:String String="J"/>
                    <cor:String String="K"/>
                    <cor:String String="L"/>
                    <cor:String String="M"/>
                    <cor:String String="N"/>
                    <cor:String String="O"/>
                    <cor:String String="P"/>
                    <cor:String String="Q"/>
                    <cor:String String="R"/>
                    <cor:String String="S"/>
                    <cor:String String="T"/>
                    <cor:String String="U"/>
                    <cor:String String="V"/>
                    <cor:String String="W"/>
                    <cor:String String="X"/>
                    <cor:String String="Y"/>
                    <cor:String String="Z"/>
                </Source>
            </ArrayListDataSet>

        </Locals>

        <Content>

            <!-- Draw an outline to represent the constraint. -->
            <Graphic Content="image://me:Outline" MaximumSize="[Size]"
                     HorizontalAlignment="Fill" VerticalAlignment="Fill"
                     Layout="Center">
                <Children>


                    <!-- This color show the total size of the grid. -->
                    <ColorFill Content="DarkGray">
                        <Children>

                            <!-- Grid and Flow are the only layouts you should use with -->
                            <!-- Repeater. Use Grid where possible because it is more -->
                            <!-- efficient than Flow.-->

                            <!-- Repeat each letter of the alphabet. -->
                            <Repeater Source="[Alphabet]">
                                <Layout>
                                    <!-- The layout to display the alphabet. -->
                                    <!-- Note: GridLayout is always used -->
                                    <!-- with a Repeater. -->

                                    <GridLayout Orientation="Horizontal"
                                          Columns="7" Rows="4"
                                          AllowWrap="true" Spacing="10,10"
                                          MajorAlignment="Fill" MinorAlignment="Fill"/>
                                </Layout>

                                <Content>

                                    <!-- Each letter is displayed with this background. -->
                                    <Graphic Content="image://me:LayoutItemImage"
                                             HorizontalAlignment="Fill"
                                             VerticalAlignment="Fill"
                                             Padding="5,5,5,5"
                                             SizingPolicy="SizeToChildren">
                                        <Children>

                                            <!-- Display the letter. -->
                                            <Text Font="Arial, 20" Color="White"
                                                  Content="[RepeatedItem!cor:String]"/>
                                        </Children>
                                    </Graphic>
                                </Content>
                            </Repeater>
                        </Children>
                    </ColorFill>
                </Children>
            </Graphic>
        </Content>

    </UI>

    <!-- An image of an outline, created with nine-gridding to allow it to -->
    <!-- stretch well. -->
    <Image Name="Outline" Source="file://Outline.1.Rounded.png" NineGrid="6,6,6,6"/>

    <!-- The background image that is displayed behind each grid cell. -->
    <Image Name="LayoutItemImage" Source="file://LayoutItem.png" NineGrid="4,4,4,4"/>

</Mcml>

See Also
•	Creating a Layout
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Setting Minimum and Maximum Sizes
The MinimumSize and MaximumSize properties are available for all view items so that you can force the layout to meet certain sizing requirements for height and width (a zero value for either dimension indicates that there is no restriction on it). However, it is rarely necessary to need both a minimum and maximum size. When working with text that you intend to localize, use care when setting these properties to allow for varying word lengths.
It is possible to over-restrict these values. If the restrictions don't make sense (for example, the maximum size is smaller than the minimum size), or if they cannot be met, the view item will not be displayed. In the example below, the maximum size of the containing parent element is smaller than a child element's minimum size. The result is the child element cannot be displayed.
<Mcml xmlns="http://schemas.microsoft.com/2006/mcml">
  <UI Name="OverConstrainedSizes">
    <Content>
      <ColorFill Content="SlateGray" MaximumSize="200,200" Layout="Center" >
        <Children>

          <ColorFill Content="Crimson" MinimumSize="100,100" />

          <!-- This child cannot be displayed. -->
          <ColorFill Content="Violet" MinimumSize="300,300" />

        </Children>
      </ColorFill>
    </Content>
  </UI>
</Mcml>

See Also
•	Creating a Layout
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Using Margins, Padding, and Spacing
Margins and padding are used to add space around and inside view items. Margins and padding are always available regardless of the layout type, and are configured by setting pixel values for Left, Top, Right, and Bottom.
•	Margins add spacing around the outside of a view item, creating more space between it and its siblings and parent. Negative margins reduce this space, and can be used to force overlapping.
•	Padding adds space inside of the view item, creating more space between the boundaries of the view item and its children.
Spacing is used with FlowLayout, and is used to add space between child elements in a vertical or horizontal flow. Spacing is a good way to create space in text, for example.
The following example shows the effect of setting margins, padding, and spacing. For additional examples, see the Sample Explorer.

<Mcml xmlns="http://schemas.microsoft.com/2006/mcml">
  <UI Name="MarginsPadding">
    <Content>
      <ColorFill Content="Blue" >
        <Layout>
          <!-- Spacing is used to create distance between the child elements that follow. -->
          <FlowLayout Orientation="Vertical" ItemAlignment="Center" Spacing="30,30"/>
        </Layout>

        <Children>

          <!-- No margins and no padding. -->
          <ColorFill Content="Goldenrod" >
            <Children>
              <ColorFill Content="White" >
                <Layout>
                  <FlowLayout Orientation="Vertical" ItemAlignment="Center"/>
                </Layout>
                <Children>
                  <Text Content="No margins, no padding" Color="Firebrick" Font="Tahoma,12"/>
                </Children>
              </ColorFill>
            </Children>
          </ColorFill>

          <!-- Margins and no padding. -->
          <ColorFill Content="Goldenrod" >
            <Children>
              <ColorFill Content="White" Margins="5,5,5,5" Padding="0,0,0,0"  >
                <Layout>
                  <FlowLayout Orientation="Vertical" ItemAlignment="Center"/>
                </Layout>
                <Children>
                  <Text Content="Margins, no padding" Color="Firebrick"  Font="Tahoma,12"/>
                </Children>
              </ColorFill>
            </Children>
          </ColorFill>

          <!-- No margins and some padding. -->
          <ColorFill Content="Goldenrod" >
            <Children>
              <ColorFill Content="White" Margins="0,0,0,0" Padding="5,5,5,5"  >
                <Layout>
                  <FlowLayout Orientation="Vertical" ItemAlignment="Center" />
                </Layout>
                <Children>
                  <Text Content="Padding, no margins" Color="Firebrick" Font="Tahoma,12" />
                </Children>
              </ColorFill>
            </Children>
          </ColorFill>

          <!-- Margins and padding. -->
          <ColorFill Content="Goldenrod" >
            <Children>
              <ColorFill Content="White"  Margins="5,5,5,5" Padding="5,5,5,5">
                <Layout>
                  <FlowLayout Orientation="Vertical" ItemAlignment="Center" />
                </Layout>
                <Children>
                  <Text Content="Margins and padding"  Color="Firebrick" Font="Tahoma,12" />
                </Children>
              </ColorFill>
            </Children>
          </ColorFill>

          <!-- Negative margins and no padding. -->
          <ColorFill Content="Goldenrod" >
            <Children>
              <ColorFill Content="White" Margins="-5,-5,-5,-5" Padding="0,0,0,0" >
                <Layout>
                  <FlowLayout Orientation="Vertical" ItemAlignment="Center" />
                </Layout>
                <Children>
                  <Text Content="Neg margins, no padding" Color="Firebrick" Font="Tahoma,12" />
                </Children>
              </ColorFill>
            </Children>
          </ColorFill>

        </Children>
      </ColorFill>
    </Content>
  </UI>
</Mcml>

See Also
•	Creating a Layout
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Using Layers
You can use layers of UI to achieve different effects in your application. You can then determine which layer is on top according to focus by setting the MakeTopmostOnFocus property of the Input element to true for that view item. The following example shows how to use this property. For additional examples, see the Sample Explorer.
<Mcml xmlns="http://schemas.microsoft.com/2006/mcml"
      xmlns:cor="assembly://MSCorLib/System"
      xmlns:me="Me" >

  <UI Name="MakeTopmostOnFocusTest">
    <Content>
      <Panel Layout="Anchor">
        <Children>

          <me:KeyFocusIndicator>
            <LayoutInput>
              <AnchorLayoutInput Top="Parent,0.25" Left="Parent,0.45"/>
            </LayoutInput>
          </me:KeyFocusIndicator>

          <me:KeyFocusIndicator>
            <LayoutInput>
              <AnchorLayoutInput Top="Parent,0.24" Left="Parent,0.50"/>
            </LayoutInput>
          </me:KeyFocusIndicator>

          <me:KeyFocusIndicator>
            <LayoutInput>
              <AnchorLayoutInput Top="Parent,0.23" Left="Parent,0.55"/>
            </LayoutInput>
          </me:KeyFocusIndicator>

        </Children>
      </Panel>
    </Content>
  </UI>


  <!-- An item that changes outline color when it has key focus. -->
  <UI Name="KeyFocusIndicator">

    <Properties>
      <cor:String Name="Text" String=""/>
      <Size Name="MinimumTileSize" Size="100,100"/>
    </Properties>

    <Locals>
      <ClickHandler Name="Clicker"/>
    </Locals>

    <Rules>

      <Default Target="[Input.MakeTopmostOnFocus]" Value="true"/>

      <!-- Input.KeyFocus is true when the UI has key focus, so -->
      <!-- the UI will receive direct keyboard or remote control input. -->
      <!-- When it receives key focus, the outline color will change -->
      <!-- to Firebrick as a visual cue. -->
      <Condition Source="[Input.KeyFocus]" SourceValue="true">
        <Actions>
          <Set Target="[Outline.Content]" Value="Firebrick"/>
        </Actions>
      </Condition>

    </Rules>

    <Content>

      <ColorFill Name="Outline" Content="Green" Padding="5,5,5,5">
        <Children>

          <ColorFill Content="LawnGreen" MinimumSize="[MinimumTileSize]"
                     Alpha=".75" Padding="3,3,3,3">
            <Children>
              <Text Content="[Text]"/>
            </Children>
          </ColorFill>
        </Children>

      </ColorFill>

    </Content>
  </UI>
</Mcml>

See Also
•	Sample Explorer
•	Media Center Markup Language Verifier

# Working with Page Sessions
Not documented in this release.
See Also
•	Developing Applications for Windows Media Center

# Working with User Input and Text Entry
Windows Media Center applications need to consider different aspects of text entry, including the way that users enter text from a distance, and how to enter text in their own language.
To support all user conditions, including Media Center Extender, your application must enable the user to enter text where needed by using only the remote control. An application typically requires the user to enter text during the following scenarios:
•	Initial service sign-up
•	Logon
•	Search
This section discusses these considerations in the following topics:
Topic	Description
Displaying the Onscreen Keyboard
Explains how to use the onscreen keyboard for text entry.
Triple-Tap Text Entry
Describes the triple-tap method of text entry.
Understanding Mouse, Keyboard, and Remote Control Input
Lists the buttons, grouped by function, that may appear on a Windows Media Center remote control.
Working with Input Handlers
Describes how to work with input handlers to capture user input.
Editable Digits
Not documented in this release.
Secure Editable Text
Not documented in this release.
Secure Typing Handler
Not documented in this release.

See Also
•	Developing Applications for Windows Media Center

# Displaying the Onscreen Keyboard
To enable users to enter text with a remote control, applications can use the onscreen keyboard that is included with Windows Media Center, which is an image of a keyboard that allows the user to select letters by using the remote control's arrow buttons and the OK/Enter button.
The onscreen keyboard is modal and is displayed as an overlay at the bottom of the window. The user opens the onscreen keyboard to enter text, and then dismisses it when finished.
The onscreen keyboard automatically displays the appropriate keyboard according to the user's input language located in the Keyboards and Languages settings.
The application can limit the number of characters the user can enter for a given text string. The application can also mask the characters that are displayed for sensitive information, such as a password field.

The example below show a simple typing handler object that allows the user to enter text by clicking a button to open the onscreen keyboard.
<Mcml xmlns="http://schemas.microsoft.com/2008/mcml"
      xmlns:addin="assembly://Microsoft.MediaCenter/Microsoft.MediaCenter.Hosting"
      xmlns:b="file://ControlsSimpleButton.mcml">

  <UI Name="Default">
    <Locals>
      <addin:AddInHost Name="AddInHost"/>
      <EditableText Name="TextEditControl" Value="This is text" />
      <TypingHandler Name="myTypingHandler" PasswordMasked="false" MaxLength="10" />
    </Locals>

    <Rules>
      <Binding Source="[TextEditControl.Value]" Target="[DisplayText.Content]" />
      <Binding Source="[TextEditControl]" Target="[myTypingHandler.EditableText]" />
    </Rules>

    <Content>
      <Panel Layout="VerticalFlow">
        <Children>
          <Text Name="DisplayText" Color="White"/>
          <b:SimpleButton>
            <Command>
              <InvokeCommand Description="Open the Onscreen Keyboard"
                             Target="[AddInHost.MediaCenterEnvironment.ShowOnscreenKeyboard]"
                             editableText="[myTypingHandler.EditableText]"
                             passwordMasked="[myTypingHandler.PasswordMasked]"
                             maxLength="[myTypingHandler.MaxLength]"/>
            </Command>
          </b:SimpleButton>
        </Children>
      </Panel>
    </Content>
  </UI>
</Mcml>

For an example of how to create edit boxes that accept triple-tap input, see the TripleTap Editbox example under Scenarios in the Sample Explorer.
See Also
•	Sample Explorer
•	Media Center Markup Language Verifier

# K Triple-Tap Text Entry
The user enters letters by pressing number keys on the remote control. By repeatedly pressing a particular key, the user cycles through the set of letters associated with that key. Many mobile phones use this method to enable text entry for text messaging and phone book entries.
•	For an example of how to create edit boxes that accept triple-tap input using Windows Media Center Markup Language (MCML), see the TripleTap Editbox example under Scenarios in the Sample Explorer.
•	For an example of implementing triple-tap functionality in a Windows Media Center Presentation Layer application, see the Z sample application. For more information, see Building and Modifying the Sample Applications.
If you adhere to the guidelines mentioned above, your application will natively support text entry in the Media Center Extender session. However, it is best to direct the user to the host computer for one-time scenarios that require a large amount of text entry, such signing up for a service, or operations that include the caching of logon credentials.
See Also
•	Working with User Input and Text Entry

# K Understanding Mouse, Keyboard, and Remote Control Input
Users can navigate Windows Media Center using any of the following:
•	Mouse
•	Keyboard
•	Remote control
For mouse control, users can hover over and select items within Windows Media Center (and a well-designed application will account for this model at all times). When a mouse is used to navigate, Windows Media Center displays navigation and transport controls that overlay the current experience to help users control their experience when using a mouse, as shown in the following figure:

Users can navigate the Windows Media Center UI using keyboard navigation. See Keyboard Shortcuts for a list of keyboard shortcuts.
Windows Media Center also accepts user input from anywhere in the room through a remote control device. This device looks like a standard remote control for a television or other home entertainment device and has buttons for several specialized Windows Media Center functions. The following figure shows a remote control designed for use with a Windows Media Center PC. The appearance of the remote control may vary from manufacturer to manufacturer. However, the core functionality is constant.

The remote control interacts with an infrared sensor, which consists of the following hardware:
•	A receiver component that processes input from the remote control
•	A circuit for learning infrared commands
•	A universal serial bus (USB) connection that sends input notifications to software running on the computer
•	Two emitter ports
In addition, the sensor requires a device driver that supports the Plug and Play specification. A default driver is installed with the versions of the Microsoft Windows operating system that support the infrared sensor.
The USB cable enables users to place the sensor near the monitor so they can point the remote at the monitor when sending commands to the computer. Alternatively, the sensor might be mounted in the front panel of the computer by the manufacturer.
Input from the remote control is processed as follows:
1.	The sensor receives the signal and forwards it to a device driver on the computer.
2.	The device driver converts the input into a WM_INPUT, WM_APPCOMMAND, WM_KEYDOWN, WM_KEYPRESS, or WM_KEYUP message.
3.	Windows places these messages in the message queue to be processed by a program's main window procedure.
4.	The foreground program processes messages of interest. For example, a digital media streaming program could process the messages corresponding to the transport buttons (Pause, Play, Stop, Fast Forward, and Rewind) but ignore messages from the numeric keypad.
Trapping Events
Applications can trap certain mouse, keyboard, and remote control events. How you trap remote control button presses depends on the application's implementation.
For Windows Media Center Presentation Layer applications, you can trap remote control button presses using either the ShortcutHandler or KeyHandler element in Windows Media Center Markup Language (MCML).
For more information, see the following topics:
Topic	Description
Required Remote Control Buttons
Lists the remote control buttons that are required to appear on a Windows Media Center remote control.
Required Remote Control Buttons for Teletext
Lists the remote control buttons that are required in locales that support Teletext functionality.
Optional Remote Control Buttons
Lists the remote control buttons that are optional on a Windows Media Center remote control.
Keyboard Shortcuts
Lists the keyboard shortcuts for navigating the Windows Media Center UI.

See Also
•	Managing Navigation

# Required Remote Control Buttons
The following buttons are required to appear on a Windows Media Center remote control. The columns indicate whether a Windows Media Center Presentation Layer application type can trap for the button within code or markup.
Button	Can trap?
Green Start Button
Up	X
Down	X
Left	X
Right	X
OK	X
More Information
Back	X
Guide
Play *	X
Pause *	X
Stop	X
Rewind	X
Fast Forward	X
Skip Backward	X
Skip Forward	X
Record	X
Volume Up
Volume Down
Channel / Page Up	X
Channel / Page Down	X
Mute
Power **
Standby **
Power On **
Power Off **

* Play and Pause buttons may be combined into a single button.
** Only one of these buttons is required: Power, Standby, Power On and Power Off buttons.
See Also
•	Managing Navigation
•	Understanding Mouse, Keyboard, and Remote Control Input

# Required Remote Control Buttons for Teletext
The following buttons are required to appear on a Windows Media Center remote control in locales that support Teletext functionality, but applications cannot trap for the buttons within code or markup:
•	Red
•	Green
•	Blue
•	Yellow
•	Teletext On / Off
See Also
•	Managing Navigation
•	Understanding Mouse, Keyboard, and Remote Control Input

# Optional Remote Control Buttons
The following buttons are optional on a Windows Media Center remote control. The columns indicate whether a Windows Media Center Presentation Layer application can trap for the button within code or markup.
Button	Can trap?
0	X
1	X
2	X
3	X
4	X
5	X
6	X
7	X
8	X
9	X
10
11
12
Clear	X
Enter	X
#
*
DVD Menu
DVD Angle
DVD Audio
DVD Subtitle
Live TV
Recorded TV
Zoom
Music
Pictures
Videos
Radio
Online MediaExtras
OEM Application Shortcut
OEMExtensibility0	X
OEMExtensibility1	X
OEMExtensibility2	X
OEMExtensibility3	X
OEMExtensibility4	X
OEMExtensibility5	X
OEMExtensibility6	X
OEMExtensibility7	X
OEMExtensibility8	X
OEMExtensibility9	X
OEMExtensibility10	X
OEMExtensibility11	X
Print	X
Closed Captioning On / Off

See Also
•	Managing Navigation
•	Understanding Mouse, Keyboard, and Remote Control Input

# Keyboard Shortcuts
Use the following navigation shortcuts to move around in Windows Media Center:
To	Press
Move up	UP ARROW
Move down	DOWN ARROW
Move left	LEFT ARROW
Move right	RIGHT ARROW
Select	ENTER or SPACEBAR
Jump back one page at a time	PAGE UP
Jump ahead one page at a time	PAGE DOWN
Start Windows Media Center	Windows logo key+ALT+ENTER
Go back to the previous screen or backspace a single character in Search	BACKSPACE

Shortcuts to change channels:
To	Press
Change to a specific channel	The number for the channel you want
Move up one channel	EQUALS (=) or CTRL+EQUALS or PLUS (+ on the numerical keypad)
Move down one channel	HYPHEN (-) or CTRL+HYPHEN or MINUS (- on the numerical keypad)

Menu shortcuts that take you directly to the main menus for feature areas:
To go to top level menus for	Press
My TV	CTRL+SHIFT+T
My Music	CTRL+M
My Videos	CTRL+E
My Pictures	CTRL+I

Navigation shortcuts for TV and DVD menus:
To go to TV and DVD menus for	Press
Guide	CTRL+G
Record	CTRL+R
Details	CTRL+D
DVD Menu	CTRL+SHIFT+M
Recorded TV	CTRL+O
DVD Audio	CTRL+SHIFT+A
DVD Subtitle	CTRL+U

Transport controls for media playback:
To	Press
Pause	CTRL+P
Play	CTRL+SHIFT+P
Stop	CTRL+SHIFT+S
Replay	CTRL+B
Skip	CTRL+F
Rewind	CTRL+SHIFT+B
Fast Forward	CTRL+SHIFT+F
Mute	F8
Volume Down	F9
Volume Up	F10

See Also
•	Managing Navigation
•	Understanding Mouse, Keyboard, and Remote Control Input

# K Working with Input Handlers
For a Windows Media Center page to process input from the remote in a meaningful way, certain elements on the page must be able to receive the focus. The focus enables the user to target elements on the page one at a time for selection (by pressing the OK button on the remote), for text input, for scrolling, or for other interactions available from the remote. The page must always provide a distinct visual highlight to indicate which item has the focus. The focus must always be on exactly one element at a time, and it must move in a logical way from one focusable item to the next when the user presses the Up, Down, Left, or Right arrow buttons.
Managing the focus involves the following main tasks:
•	Keeping track of where the focus is at all times.
•	Moving the focus correctly and logically in response to user input.
•	Highlighting the focus so the user can tell where it is.
MCML can handle different types of user input (mouse, keyboard, and remote control). In simple cases, you can use rules to respond to input. Or, you can use input handlers to respond to different types of user input, and you can configure multiple handlers in a UI. For example, the UI can respond to both mouse input and remote control input.
You can specify which types of user input to allow with the Input element. For example, you can allow double-clicks and disallow mouse focus for a particular UI. You can set these properties by using default rules in the Rules section of a UI:
<Default Target="[Input.KeyInteractive]" Value="true" />

In general, if you use input handlers rather than rules, you won't need to use or set properties such as MouseInteractive or KeyInteractive because the input handlers set these properties for you.
If you want any part of the UI to be mouse interactive, you must set the MouseInteractive property to true for each of those view items. By default, mouse interactivity is enabled for the root view item in a UI when a mouse-based input handler is configured or key interactivity is enabled. You can also set individual view items to be mouse interactive, but then the root view item is not automatically configured. In addition, mouse interactivity is not inherited. You can disable mouse interactivity within a UI by setting Input.Enabled to false.
Key interactivity always references the root view item for operations such as directional navigation. Use the NavigateInto method on a view item to send focus to it or one of its children.
You can use simple rules to implement a check for mouse and keyboard focus, or you can use the following handlers, which are placed in the Locals section of a UI. Then configure rules to respond to the input handler properties.
•	ClickHandler: Handles button input from the primary mouse button and the SPACEBAR and ENTER keys.
•	KeyHandler: Handles keyboard input.
•	MouseWheelHandler: Handles input from the movement of the mouse wheel.
•	ScrollingHandler: Handles input that is associated with scrolling, such as directional keys.
•	ShortcutHandler: Handles button input from the remote control.
•	TypingHandler: Handles typing input to provide edit box-like behavior.
The following example is a simple way to use rules to show focus from mouse and keyboard input:
<Mcml xmlns="http://schemas.microsoft.com/2006/mcml"
      xmlns:me="Me">

  <UI Name="Grid">
    <Content>
      <Panel>
        <Layout>
          <FlowLayout Orientation="Vertical" Spacing="5,0" ItemAlignment="Center"/>
        </Layout>
        <Children>
          <me:Row />
          <me:Row />
        </Children>
      </Panel>
    </Content>
  </UI>

  <UI Name="Row">
    <Content>
      <Panel>
        <Layout>
          <FlowLayout Orientation="Horizontal" Spacing="5,0"/>
        </Layout>
        <Children>
          <me:Box />
          <me:Box />
        </Children>
      </Panel>
    </Content>
  </UI>

  <!-- The box changes color when it has key or mouse focus. -->
  <UI Name="Box">

    <Rules>
      <!-- Input.KeyInteractive determines whether this UI can receive key focus. -->
      <Default Target="[Input.KeyInteractive]" Value="true" />

      <!-- When the item has keyboard or mouse focus, change the color of the box outline. -->
      <Condition Source="[Input.KeyFocus]" SourceValue="true">
        <Actions>
          <Set Target="[Outline.Content]" Value="Firebrick"/>
        </Actions>
      </Condition>

    </Rules>

    <Content>
      <ColorFill Name="Outline" Content="Green" Padding="5,5,5,5">
        <Children>
          <ColorFill Content="White" MinimumSize="100,100" Alpha=".5" Padding="3,3,3,3" />
        </Children>
      </ColorFill>
    </Content>

  </UI>
</Mcml>

The following example uses a key handler to detect when the ENTER key is pressed. For additional examples, see the Sample Explorer.
<Mcml
  xmlns="http://schemas.microsoft.com/2006/mcml" >

  <UI Name="EnterUI">

    <!-- Define the properties for this object. -->
    <Properties>
      <Color Name="BackgroundColor" Color="DimGray"/>
      <Color Name="BackgroundPressedColor" Color="White"/>
      <Color Name="LabelColor" Color="White"/>
      <Color Name="LabelPressedColor" Color="Red"/>
    </Properties>

    <Locals>
      <!-- Use the key handler to handle key press events. -->
      <KeyHandler Name="EnterHandler" Key="Enter" />
    </Locals>

    <Rules>
      <!-- Rules to define the behavior when ENTER key is pressed. -->

      <!-- Change the background color while the ENTER key is pressed. -->
      <Condition Source="[EnterHandler.Pressing]" SourceValue="true">
        <Actions>
          <Set Target="[Background.Content]" Value="[BackgroundPressedColor]" />
        </Actions>
      </Condition>

      <!-- Change the label text to indicate that the ENTER key was pressed. -->
      <Changed Source="[EnterHandler.Invoked]">
        <Actions>
          <Set Target="[Label.Color]" Value="[LabelPressedColor]" />
          <Set Target="[Label.Content]" Value="Enter" />
        </Actions>
      </Changed>

    </Rules>

    <Content>
      <ColorFill Name="Background" Content="[BackgroundColor]" Padding="5,5,5,5"  Layout="VerticalFlow">
        <Children>
          <Text Name="Label" Content="Press Enter" Color="[LabelColor]" Font="Arial,20" Margins="30,30,30,30"/>
        </Children>
      </ColorFill>
    </Content>

  </UI>

</Mcml>

See Also
•	Sample Explorer
•	Media Center Markup Language Verifier

# Editable Digits
Not documented in this release.
See Also
•	Developing Applications for Windows Media Center

# Secure Editable Text
Not documented in this release.
See Also
•	Developing Applications for Windows Media Center

# Secure Typing Handler
Not documented in this release.
See Also
•	Developing Applications for Windows Media Center

---

MCESDK_Guide04.doc

# K Managing Navigation
This section describes the different considerations for implementing focus and navigation into a Windows Media Center application, and the API you need to use. For information about design considerations, see Designing Applications for Windows Media Center.
This section contains the following topics:
Topic	Description
Navigating Pages in Managed Code Applications
Describes the managed code API to use for navigating one page or a page stack.
Relative Paths for MCML
Describes support for using relative paths for HTTP resources.

See Also
•	Developing Applications for Windows Media Center

# K Navigating Pages in Managed Code Applications
Windows Media Center Presentation Layer applications can use the PageSession and HistoryOrientedPageSession classes to manage navigating through pages.
The PageSession class allows you to work with one page. If you need a page stack, use the HistoryOrientedPageSession class, which is derived from PageSession and implements an internal page stack for tracking page navigation. Using HistoryOrientedPageSession allows you to place pages from your application on a stack that can then be navigated back to by pressing the Back button on a Windows Media Center remote control or the BACKSPACE key on the keyboard. Windows Media Center manages this stack of pages for your application automatically as long as you use the HistoryOrientedPageSession object in your application.
Using the HistoryOrientedPageSession object provides users of your application with an easy way to drill into detailed views (such as plot summaries and artist information) and then return to the previous page. If you instead use PageSession, if a user presses the Back button at any point while using your application, they will be returned back to the point that they launched your application from within Windows Media Center (such as the Extras Library).
See Also
•	Managing Navigation

# Relative Paths for MCML
You can use relative paths for HTTP resources. The first HTTP response URI in the document is used as the base URI, and then the relative path is appended to it.
The following example shows an example of using a relative path:
<Mcml xmlns="http://schemas.microsoft.com/2008/mcml">
  <UI Name="RelPath">
    <Content>
      <!-- Relative image path -->
      <Graphic Content="file://./Images/FourBoxGraphic.png"/>
    </Content>
  </UI>
</Mcml>
For more information about relative paths, see the WebRelativePaths.mcml sample in the Sample Explorer.
See Also
•	Managing Navigation

# K Working with Animations
You can use dynamic animations in MCML to create a full-fidelity experience in your Windows Media Center Presentation Layer applications. MCML animation supports an event-driven model and provides a variety of effects so that you can integrate the animation with the rest of your layout.
At a simple level, an animation is based on a collection of keyframes, each of which is associated with a specific time and type-dependent value. For example, moving an image from one point to another, over a specific number of seconds.
You can create more complex animations by applying one or more of the following features:
•	Trigger animations in response to different types of events.
•	Use interpolation to describe how to transition from one keyframe to the next.
•	Apply transforms to create a new animation from a reference animation.
You can attach an animation to a view item by using the Animation element.
The following example shows a very simple animation that animates an image in a Graphic view item by moving it in a diamond pattern. Several position keyframes are defined, each of which specifies a time and a position; in other words, how long it takes to move the image from the position in the previous keyframe to the position in the next keyframe.

<Mcml xmlns="http://schemas.microsoft.com/2006/mcml">

  <UI Name="PositionKeyframes">

    <Content>

      <!-- The target of the animation: a green star graphic. -->
      <Graphic Name="AnimStar" Content="file://GreenStar.PNG">

        <Animations>

          <!-- Create an animation that will loop forever -->
          <Animation Loop="-1">
            <Keyframes>
              <!-- Move in a diamond pattern -->
              <PositionKeyframe Time="0.0" Value="-100,0,0"/>
              <PositionKeyframe Time="1.0" Value="0,-100,0"/>
              <PositionKeyframe Time="2.0" Value="100,0,0"/>
              <PositionKeyframe Time="3.0" Value="0,100,0"/>
              <PositionKeyframe Time="4.0" Value="-100,0,0"/>

            </Keyframes>
          </Animation>
        </Animations>
      </Graphic>
    </Content>
  </UI>
</Mcml>

For more information about animations, see the following topics.
Note   This section assumes a basic working knowledge of animation concepts.
Topic	Description
Using Keyframes in Animation
Describes the different types of keyframes you can use in animations.
Applying Interpolations to Keyframes
Describes the different types of interpolations you can apply between keyframes.
Setting the Weight on Interpolations
Describes how the interpolation weight affects the interpolation curve.
Playing Different Types of Animations in Response to Events
Describes the types of events that trigger animations.
Applying Transforms to Animations
Describes the transforms you apply to a source animation to produce a new animation.
Using Antialiasing and Transparent Borders for Animated Images
Explains how to adjust images to reduce pixelated edges during animation.
Using Switch Animation
Not documented in this release.
Best Practices for Animation
Lists guidelines for creating animations.
Best Practices for Background Animations
Lists guidelines for creating background animations.

See Also
•	Developing Applications for Windows Media Center
•	Sample Explorer
•	Media Center Markup Language Verifier
# Using Keyframes in Animation
In MCML, animations are an exercise in defining keyframes for a timeline. Windows Media Center fills in the gap between keyframes for smooth animation.
There are several types of keyframes you can use:
•	AlphaKeyframe animates an item's opacity (its alpha channel value), allowing you to make an item more opaque or more transparent over time.
<!-- Start at fully opaque. -->
    <AlphaKeyframe Time="0.0" Value="1.0"/>
<!-- Animate to fully transparent. -->
    <AlphaKeyframe Time="2.0" Value="0.0"/>

•	ColorKeyframe animates an item's color, allowing you to change an item's color over time.
<!-- Start at red. -->
    <ColorKeyframe Time="0.0" Value="0.0,1.0,1.0"/>
<!-- Animate to green. -->
    <ColorKeyframe Time="2.0" Value="1.0,0.0,1.0"/>
<!-- Animate to blue. -->
    <ColorKeyframe Time="4.0" Value="1.0,1.0,0.0"/>

•	PositionKeyframe animates an item's position over time.
<!-- Starting position. -->
    <PositionKeyframe Time="0.0" Value="0,0,0"/>
<!-- Animate to the right. -->
    <PositionKeyframe Time="2.0" Value="200,0,0"/>

•	RotateKeyframe animates an item by rotating it over time.
<!-- Starting rotation. -->
    <RotateKeyframe Time="0.0" Value="0deg;0,0,1"/>
<!-- Rotate to the left. -->
    <RotateKeyframe Time="2.0" Value="-360deg;0,0,1"/>

•	ScaleKeyframe animates an item by changing its scale over time.
<!-- Starting scale. -->
    <ScaleKeyframe Time="0.0" Value="1.0,1.0,1.0"/>
<!-- Scale up to double size. -->
    <ScaleKeyframe Time="2.0" Value="1.5,1.5,1.5"/>

Note   If you cannot click or select the item after playing the animation, check the Z-coordinate and make sure it is not 0. When using a Z-coordinate of 0 for the Value attribute, Windows Media Center may not recognize when the user mouses over the view item.
•	SizeKeyframe animates an item's size over time.
<!-- Starting size. -->
    <SizeKeyframe Time="0.0" Value="200,200,0"/>
<!-- Animate to a smaller size. -->
    <SizeKeyframe Time="2.0" Value="100,100,0"/>

You can combine multiple types of keyframes to be applied as a whole animation element. Each grouping of animation keyframes can have different timelines, completely independent of each other. But note that animations require at least two keyframes of the same type (for example, two AlphaKeyFrames). With only one keyframe, there is no beginning or end and therefore nothing to animate. In addition, the first keyframe must start at Time="0".
The following example combines several types of keyframes in one animation.
<Mcml xmlns="http://schemas.microsoft.com/2006/mcml">

  <UI Name="MultipleKeyframes">

    <Content>
      <Graphic Name="AnimStar" Content="file://GreenStar.PNG">
        <Animations>

          <!-- Create an animation that will loop forever -->
          <Animation Loop="-1">

            <Keyframes>
              <!-- Move the image in a diamond pattern. -->
              <PositionKeyframe Time="0.0" Value="-100,0,0"/>
              <PositionKeyframe Time="2.0" Value="0,-100,0"/>
              <PositionKeyframe Time="4.0" Value="100,0,0"/>
              <PositionKeyframe Time="6.0" Value="0,100,0"/>
              <PositionKeyframe Time="8.0" Value="-100,0,0"/>

              <!-- Fade the image in and out. -->
              <AlphaKeyframe Time="0.0" Value="1.0"/>
              <AlphaKeyframe Time="1.0" Value="0.2"/>
              <AlphaKeyframe Time="2.0" Value="1.0"/>

              <!-- Rotate the image. -->
              <RotateKeyframe Time="0.0" Value="0deg;1,1,1"/>
              <RotateKeyframe Time="4.0" Value="360deg;5,5,1"/>
              <RotateKeyframe Time="8.0" Value="0deg;1,1,1"/>

              <!-- Change the scale up and down. -->
              <ScaleKeyframe Time="0.0" Value="0.5,0.5,0.5"/>
              <ScaleKeyframe Time="4.0" Value="4.0,4.0,4.0"/>
              <ScaleKeyframe Time="8.0" Value="0.5,0.5,0.5"/>

            </Keyframes>
          </Animation>
        </Animations>
      </Graphic>
    </Content>
  </UI>
</Mcml>

You can also apply a granular control over the keyframe settings by using the following options:
•	Interpolation specifies the transition between one keyframe to the next. For more information, see Applying Interpolations to Keyframes.
•	RelativeTo specifies how to interpret the keyframe's value relative to other keyframes.  
•	Weight specifies the strength of the interpolation curve with respect to a Linear interpolation. For more information, see Setting the Weight on Interpolations.
For in-depth animation samples, see the Sample Explorer.
See Also
•	Sample Explorer
•	Media Center Markup Language Verifier
•	Working with Animations
# Applying Interpolations to Keyframes
Interpolations are used to specify how one keyframe transitions to the next keyframe of the same type. You don't need to set an interpolation for the last keyframe because there is no transition to follow. Even if the animation loops, an interpolation for the last keyframe is not used.
Several curves, or interpolation types, are available that determine the rate at which the transition occurs. For example, a constant, unchanging transition uses a Linear interpolation type; a transition that changes quickly at first and then slows down might use a Log interpolation type.  
The following table summarizes the types of interpolations you can use.
Type	Shape	Description
Linear	 
A constant transition.
Log	 
A transition with a logarithmic curve.
Exp	 
A transition with an exponential curve.
Cosine	 
A transition in a cosine curve.
Sine	 
A transition in a sine curve.
SCurve	 
A transition in an S-curve.
Bezier	 
A transition in a Bézier curve, where you specify the handles that shape the curve.
EaseIn	 
A transition that starts as a linear curve and "eases in" to a logarithmic curve, where you specify weight and time percentages.
EaseOut	 
A transition that starts as an exponential curve and "eases out" to a linear curve, where you specify weight and time percentages.

The following example shows each of the interpolation types applied to the same animation. Each animation starts and ends at the same points at the same times, yet the transition from start to end are each different.
<Mcml xmlns="http://schemas.microsoft.com/2006/mcml">
  <UI Name="Interpolations">
    <Content>
      <Panel Layout="VerticalFlow">
        <Children>
          <Panel>
            <Children>
              <Text Color="DarkRed" Font="Verdana,18" Content="Linear"  />
              <Graphic Name="AnimStar1" Content="file://GreenStar.PNG">
                <Animations>
                  <Animation Loop="-1">
                    <Keyframes>
                      <PositionKeyframe Time="0.0" Value="-275,0,0" Interpolation="Linear" />
                      <PositionKeyframe Time="2.0" Value=" 275,0,0" Interpolation="Linear" />
                      <PositionKeyframe Time="4.0" Value="-275,0,0" />
                    </Keyframes>
                  </Animation>
                </Animations>
              </Graphic>
            </Children>
          </Panel>
          <Panel>
            <Children>
              <Text Color="Red"      Font="Verdana,18" Content="EaseIn (Linear > Log) using weight 70% at time 40%" />
              <Graphic Name="AnimStar2" Content="file://GreenStar.PNG">
                <Animations>
                  <Animation Loop="-1">
                    <Keyframes>
                      <PositionKeyframe Time="0.0" Value="-275,0,0" Interpolation="EaseIn,.7,.4" />
                      <PositionKeyframe Time="2.0" Value=" 275,0,0" Interpolation="EaseIn,.7,.4" />
                      <PositionKeyframe Time="4.0" Value="-275,0,0" />
                    </Keyframes>
                  </Animation>
                </Animations>
              </Graphic>
            </Children>
          </Panel>
          <Panel>
            <Children>
              <Text Color="DarkRed"  Font="Verdana,18" Content="Log" />
              <Graphic Name="AnimStar3" Content="file://GreenStar.PNG">
                <Animations>
                  <Animation Loop="-1">
                    <Keyframes>
                      <PositionKeyframe Time="0.0" Value="-275,0,0" Interpolation="Log" />
                      <PositionKeyframe Time="2.0" Value=" 275,0,0" Interpolation="Log" />
                      <PositionKeyframe Time="4.0" Value="-275,0,0" />
                    </Keyframes>
                  </Animation>
                </Animations>
              </Graphic>
            </Children>
          </Panel>
          <Panel>
            <Children>
              <Text Color="DarkGoldenrod"  Font="Verdana,18" Content="Exp" />
              <Graphic Name="AnimStar4" Content="file://GreenStar.PNG">
                <Animations>
                  <Animation Loop="-1">
                    <Keyframes>
                      <PositionKeyframe Time="0.0" Value="-275,0,0" Interpolation="Exp" />
                      <PositionKeyframe Time="2.0" Value=" 275,0,0" Interpolation="Exp" />
                      <PositionKeyframe Time="4.0" Value="-275,0,0" />
                    </Keyframes>
                  </Animation>
                </Animations>
              </Graphic>
            </Children>
          </Panel>
          <Panel>
            <Children>
              <Text Color="Yellow" Font="Verdana,18" Content="EaseOut (Exp > Linear) using weight 30% at time 70%" />
              <Graphic Name="AnimStar5" Content="file://GreenStar.PNG">
                <Animations>
                  <Animation Loop="-1">
                    <Keyframes>
                      <PositionKeyframe Time="0.0" Value="-275,0,0" Interpolation="EaseOut,.7,.3" />
                      <PositionKeyframe Time="2.0" Value=" 275,0,0" Interpolation="EaseOut,.7,.3" />
                      <PositionKeyframe Time="4.0" Value="-275,0,0" />
                    </Keyframes>
                  </Animation>
                </Animations>
              </Graphic>
            </Children>
          </Panel>
          <Panel>
            <Children>
              <Text Color="DarkGoldenrod"  Font="Verdana,18" Content="Linear" />
              <Graphic Name="AnimStar6" Content="file://GreenStar.PNG">
                <Animations>
                  <Animation Loop="-1">
                    <Keyframes>
                      <PositionKeyframe Time="0.0" Value="-275,0,0" Interpolation="Linear" />
                      <PositionKeyframe Time="2.0" Value=" 275,0,0" Interpolation="Linear" />
                      <PositionKeyframe Time="4.0" Value="-275,0,0" />
                    </Keyframes>
                  </Animation>
                </Animations>
              </Graphic>
            </Children>
          </Panel>
        </Children>
      </Panel>
    </Content>
  </UI>
</Mcml>

Interpolation types are not restricted to position—you can apply them to any of the types of keyframes. The following example shows how a Log interpolation affects transitions for all of the keyframe types.
<Mcml xmlns="http://schemas.microsoft.com/2006/mcml">

  <UI Name="InterpolationOnKeyframes">

    <Content>
      <Panel>
        <Layout >
          <FlowLayout Orientation="Vertical" Spacing="50,0" ItemAlignment="Center" />
        </Layout>

        <Children>

          <Text Color="Yellow" Content="These text elements are all animated using a Log interpolation" />

          <Text Color="Red" Content="PositionKeyframe">
            <Animations>
              <Animation Loop="-1">
                <Keyframes>
                  <PositionKeyframe Time="0.0" Value="-400,0,0" Interpolation="Log,2" />
                  <PositionKeyframe Time="2.0" Value=" 400,0,0" Interpolation="Log,2" />
                  <PositionKeyframe Time="4.0" Value="-400,0,0" />
                </Keyframes>
              </Animation>
            </Animations>
          </Text>

          <Text Color="Blue" Content="RotateKeyframe">
            <Animations>
              <Animation Loop="-1">
                <Keyframes>
                  <RotateKeyframe Time="0.0" Value="0deg;1,1,1" Interpolation="Log,2" />
                  <RotateKeyframe Time="2.0" Value="360deg;5,5,1" Interpolation="Log,2"/>
                  <RotateKeyframe Time="4.0" Value="0deg;1,1,1"/>
                </Keyframes>
              </Animation>
            </Animations>
          </Text>

          <Text Color="White" Content="AlphaKeyframe">
            <Animations>
              <Animation Loop="-1">
                <Keyframes>
                  <AlphaKeyframe Time="0.0" Value="1.0" Interpolation="Log,2"/>
                  <AlphaKeyframe Time="2.0" Value="0.2" Interpolation="Log,2"/>
                  <AlphaKeyframe Time="4.0" Value="1.0"/>
                </Keyframes>
              </Animation>
            </Animations>
          </Text>

          <Text Color="Yellow" Content="ColorKeyframe">
            <Animations>
              <Animation Loop="-1">
                <Keyframes>
                  <ColorKeyframe Time="0.0" Value="0.0,1.0,1.0" Interpolation="Log,2" />
                  <ColorKeyframe Time="2.0" Value="1.0,0.0,1.0" Interpolation="Log,2" />
                  <ColorKeyframe Time="4.0" Value="1.0,1.0,0.0"/>
                </Keyframes>
              </Animation>
            </Animations>
          </Text>

          <Text Color="Green" Content="ScaleKeyframe">
            <Animations>
              <Animation Loop="-1">
                <Keyframes>
                  <ScaleKeyframe Time="0.0" Value="0.5,0.5,0.5" Interpolation="Log,2"/>
                  <ScaleKeyframe Time="2.0" Value="2.0,2.0,2.0" Interpolation="Log,2"/>
                  <ScaleKeyframe Time="4.0" Value="0.5,0.5,0.5"/>
                </Keyframes>
              </Animation>
            </Animations>
          </Text>

        </Children>
      </Panel>
    </Content>
  </UI>
</Mcml>

The EaseIn and EaseOut interpolation types are a combination of two interpolation types to create a varied rate of change:
•	EaseIn starts as Linear and then becomes Log.
•	EaseOut starts as Exp and then becomes Linear.
In addition, you specify values for weight percentage (the strength of the interpolation type compared to Linear) and a time percentage (when the transition occurs). For example, Interpolation="EaseOut,0.7,0.3" means to use a weight of 70% for the Exp curve, and transition to Linear at 30% into the duration of the keyframe transition.
The following example shows EaseIn and EaseOut interpolations, along with the Linear, Log, and Exp interpolations they are blended from.
<Mcml xmlns="http://schemas.microsoft.com/2006/mcml">

  <UI Name="EaseInOut">

    <Content>
      <Panel>
        <Layout >
          <FlowLayout Orientation="Horizontal" Spacing="0,50" ItemAlignment="Center" />
        </Layout>
        <Children>

          <Panel>
            <Layout >
              <FlowLayout Orientation="Vertical" Spacing="50,0" ItemAlignment="Center" />
            </Layout>

            <Children>
              <Text Color="DarkRed" Font="Verdana,18" Content="Linear"  />
              <Text Color="Red"      Font="Verdana,18" Content="EaseIn (Linear > Log) using weight 70% at time 40%" />
              <Text Color="DarkRed"  Font="Verdana,18" Content="Log" />
              <Text Color="DarkGoldenrod"  Font="Verdana,18" Content="Exp" />
              <Text Color="Yellow" Font="Verdana,18" Content="EaseOut (Exp > Linear) using weight 30% at time 70%" />
              <Text Color="DarkGoldenrod"  Font="Verdana,18" Content="Linear" />
            </Children>
          </Panel>

          <Panel>
            <Layout >
              <FlowLayout Orientation="Vertical" Spacing="0,50" ItemAlignment="Center" />
            </Layout>
            <Children>

              <Graphic Name="AnimStar1" Content="file://GreenStar.PNG">
                <Animations>
                  <Animation Loop="-1">
                    <Keyframes>
                      <PositionKeyframe Time="0.0" Value="-400,0,0" Interpolation="Linear" />
                      <PositionKeyframe Time="2.0" Value=" 400,0,0" Interpolation="Linear" />
                      <PositionKeyframe Time="4.0" Value="-400,0,0" />
                    </Keyframes>
                  </Animation>
                </Animations>
              </Graphic>

             <Graphic Name="AnimStar2" Content="file://GreenStar.PNG">
                <Animations>
                  <Animation Loop="-1">
                    <Keyframes>
                      <PositionKeyframe Time="0.0" Value="-400,0,0" Interpolation="EaseIn,.7,.4" />
                      <PositionKeyframe Time="2.0" Value=" 400,0,0" Interpolation="EaseIn,.7,.4" />
                      <PositionKeyframe Time="4.0" Value="-400,0,0" />
                    </Keyframes>
                  </Animation>
                </Animations>
              </Graphic>

              <Graphic Name="AnimStar3" Content="file://GreenStar.PNG">
                <Animations>
                  <Animation Loop="-1">
                    <Keyframes>
                      <PositionKeyframe Time="0.0" Value="-400,0,0" Interpolation="Log" />
                      <PositionKeyframe Time="2.0" Value=" 400,0,0" Interpolation="Log" />
                      <PositionKeyframe Time="4.0" Value="-400,0,0" />
                    </Keyframes>
                  </Animation>
                </Animations>
              </Graphic>

              <Graphic Name="AnimStar4" Content="file://GreenStar.PNG">
                <Animations>
                  <Animation Loop="-1">
                    <Keyframes>
                      <PositionKeyframe Time="0.0" Value="-400,0,0" Interpolation="Exp" />
                      <PositionKeyframe Time="2.0" Value=" 400,0,0" Interpolation="Exp" />
                      <PositionKeyframe Time="4.0" Value="-400,0,0" />
                    </Keyframes>
                  </Animation>
                </Animations>
              </Graphic>

              <Graphic Name="AnimStar5" Content="file://GreenStar.PNG">
                <Animations>
                  <Animation Loop="-1">
                    <Keyframes>
                      <PositionKeyframe Time="0.0" Value="-400,0,0" Interpolation="EaseOut,.7,.3" />
                      <PositionKeyframe Time="2.0" Value=" 400,0,0" Interpolation="EaseOut,.7,.3" />
                      <PositionKeyframe Time="4.0" Value="-400,0,0" />
                    </Keyframes>
                  </Animation>
                </Animations>
              </Graphic>

              <Graphic Name="AnimStar6" Content="file://GreenStar.PNG">
                <Animations>
                  <Animation Loop="-1">
                    <Keyframes>
                      <PositionKeyframe Time="0.0" Value="-400,0,0" Interpolation="Linear" />
                      <PositionKeyframe Time="2.0" Value=" 400,0,0" Interpolation="Linear" />
                      <PositionKeyframe Time="4.0" Value="-400,0,0" />
                    </Keyframes>
                  </Animation>
                </Animations>
              </Graphic>

            </Children>
          </Panel>
        </Children>
      </Panel>
    </Content>
  </UI>
</Mcml>

For in-depth animation samples, see the Sample Explorer.
See Also
•	Sample Explorer
•	Media Center Markup Language Verifier
•	Working with Animations
# Setting the Weight on Interpolations
The Weight attribute (for EaseIn, EaseOut, Exp, Log, and SCurve types) controls the blending between your specified interpolation type and a Linear interpolation. Weight is specified as a percentage, where 1 indicates 100%. A value of 1 has no effect on the interpolation. A weight of 0 produces the same effect as if you were using a Linear interpolation (0% of the interpolation type). Values greater than 1 create a more extreme curve of your specified interpolation type.  
The following example shows how the Weight attribute affects an animation that transitions between position keyframes using an Exp interpolation.
<Mcml xmlns="http://schemas.microsoft.com/2006/mcml">

  <UI Name="InterpolationWeight">

    <Content>
      <Panel>

        <Layout >
          <FlowLayout Orientation="Horizontal" Spacing="0,50" ItemAlignment="Center" />
        </Layout>

        <Children>

          <Panel>

            <Layout >
              <FlowLayout Orientation="Vertical" Spacing="50,0" ItemAlignment="Center" />
            </Layout>

            <Children>
              <Text Color="Red" Content="Linear" />
              <Text Color="Red" Content="Exp, weight 0.2" />
              <Text Color="Red" Content="Exp, weight 1 (default)" />
              <Text Color="Red" Content="Exp, weight 2" />
              <Text Color="Red" Content="Exp, weight 4" />
            </Children>

          </Panel>

          <Panel>

            <Layout >
              <FlowLayout Orientation="Vertical" Spacing="0,50" ItemAlignment="Center" />
            </Layout>

            <Children>

              <!-- Display the same animation with different values for weight. -->
              <Graphic Name="AnimStar0" Content="file://GreenStar.PNG">
                <Animations>
                  <Animation Loop="-1">
                    <Keyframes>
                      <PositionKeyframe Time="0.0" Value="-275,0,0" Interpolation="Linear" />
                      <PositionKeyframe Time="2.0" Value=" 275,0,0" Interpolation="Linear" />
                      <PositionKeyframe Time="4.0" Value="-275,0,0" />
                    </Keyframes>
                  </Animation>
                </Animations>
              </Graphic>

              <Graphic Name="AnimStar1" Content="file://GreenStar.PNG">
                <Animations>
                  <Animation Loop="-1">
                    <Keyframes>
                      <PositionKeyframe Time="0.0" Value="-275,0,0" Interpolation="Exp,.2" />
                      <PositionKeyframe Time="2.0" Value=" 275,0,0" Interpolation="Exp,.2" />
                      <PositionKeyframe Time="4.0" Value="-275,0,0" />
                    </Keyframes>
                  </Animation>
                </Animations>
              </Graphic>

              <Graphic Name="AnimStar2" Content="file://GreenStar.PNG">
                <Animations>
                  <Animation Loop="-1">
                    <Keyframes>
                      <!-- If weight is not specified, the default value is 1. -->
                      <PositionKeyframe Time="0.0" Value="-275,0,0" Interpolation="Exp" />
                      <PositionKeyframe Time="2.0" Value=" 275,0,0" Interpolation="Exp" />
                      <PositionKeyframe Time="4.0" Value="-275,0,0" />
                    </Keyframes>
                  </Animation>
                </Animations>
              </Graphic>

              <Graphic Name="AnimStar3" Content="file://GreenStar.PNG">
                <Animations>
                  <Animation Loop="-1">
                    <Keyframes>
                      <PositionKeyframe Time="0.0" Value="-275,0,0" Interpolation="Exp,2.0" />
                      <PositionKeyframe Time="2.0" Value=" 275,0,0" Interpolation="Exp,2.0" />
                      <PositionKeyframe Time="4.0" Value="-275,0,0" />
                    </Keyframes>
                  </Animation>
                </Animations>
              </Graphic>

              <Graphic Name="AnimStar4" Content="file://GreenStar.PNG">
                <Animations>
                  <Animation Loop="-1">
                    <Keyframes>
                      <PositionKeyframe Time="0.0" Value="-275,0,0" Interpolation="Exp,4.0" />
                      <PositionKeyframe Time="2.0" Value=" 275,0,0" Interpolation="Exp,4.0" />
                      <PositionKeyframe Time="4.0" Value="-275,0,0" />
                    </Keyframes>
                  </Animation>
                </Animations>
              </Graphic>

            </Children>
          </Panel>
        </Children>
      </Panel>
    </Content>
  </UI>
</Mcml>
For in-depth animation samples, see the Sample Explorer.
See Also
•	Sample Explorer
•	Media Center Markup Language Verifier
•	Working with Animations
# Playing Different Types of Animations in Response to Events
You can use different types of animations to play in response to the following events.
•	Alpha plays the animation when an alpha value for a view item changes. Typically, alpha animations use AlphaKeyframes using the RelativeTo attribute set to "Current" for the first keyframe and "Final" for the last keyframe.
The following example shows an image that uses an Alpha animation—when you hover over or away from the star, its alpha value changes and triggers the Alpha event.
<Mcml xmlns="http://schemas.microsoft.com/2006/mcml"
      xmlns:me="Me">

  <UI Name="AlphaEvent">
    <Rules>
      <Default Target="[Input.KeyInteractive]" Value="true"/>
    </Rules>
    <Content>
      <Panel>
        <Layout>
          <FlowLayout Orientation="Vertical" Spacing="10,10" ItemAlignment="Center"/>
        </Layout>
        <Children>
          <Text Color="DarkGoldenrod"  Content="The star uses an alpha animation in response to a change in focus."  WordWrap="true"/>
          <me:Anim_BlueStar />
        </Children>
      </Panel>
    </Content>
  </UI>

  <UI Name="Anim_BlueStar">
    <Rules>
      <Default Target="[Input.KeyInteractive]" Value="true"/>

      <!-- If the star gets focus, increase its Alpha value to 1. -->
      <Condition Source="[Input.KeyFocus]" SourceValue="true">
        <Actions>
          <Set Target="[BlueStar.Alpha]" Value="1.0" />
        </Actions>
      </Condition>
    </Rules>

    <Content>
      <Panel>
        <Layout>
          <FlowLayout Orientation="Horizontal" Spacing="10,10"/>
        </Layout>
        <Children>

          <Graphic Name="BlueStar" Content="file://BlueStar.PNG" MouseInteractive="true" Alpha="0.2">
            <Animations>
              <Animation Type="Alpha" Loop="0">
                <Keyframes>
                  <AlphaKeyframe Time="0.0" RelativeTo="Current"  />
                  <AlphaKeyframe Time="0.5" RelativeTo="Final" />
                </Keyframes>
              </Animation>
            </Animations>
          </Graphic>

        </Children>
      </Panel>
    </Content>
  </UI>
</Mcml>
•	ContentChangeShow and ContentChangeHide play the animation when the Content attribute of a Graphic, Text, or ColorFill element or the Source attribute of a Host element changes. For example, the content would be an image in a Graphic view item or a string in a Text view item. These events can be used to create a crossfade transition when content changes; for example, you can use ContentChangeShow on the new content to fade in, and to ContentChangeHide on the old content to fade out.
These animations only play when the content changes, but you can repeat the same animation by invoking the ForceContentChange method on the view item.
The following example shows a UI with a Graphic element that changes from a green star image to a yellow star image (and back again) when clicked. ContentChangeShow is used to animate the new image. ContentChangeHide animates the old image that is being replaced. Each type is displayed separately and combined so you can compare the effects.
<Mcml xmlns="http://schemas.microsoft.com/2006/mcml" xmlns:me="Me">
    <UI Name="Anim_ContentChange">
        <Content>
            <Panel>
                <Layout>
                    <FlowLayout Orientation="Vertical" Spacing="5,0" ItemAlignment="Center" />
                </Layout>
                <Children>
                    <Text Color="White" Content="Click a star to change images." Margins="0,0,0,10" />
                    <Text Color="White" Content="Animate ContentChangeShow + ContentChangeHide:" />
                    <me:ContentChangeAnimations />
                    <Text Color="White" Content="Animate ContentChangeShow only:" />
                    <me:ContentChangeAnimations_Show />
                    <Text Color="White" Content="Animate ContentChangeHide only:" />
                    <me:ContentChangeAnimations_Hide />
                </Children>
            </Panel>
        </Content>
    </UI>
    <UI Name="ContentChangeAnimations">
        <Properties>
            <Image Name="GreenStar" Image="file://GreenStar.png" />
            <Image Name="YellowStar" Image="file://YellowStar.png" />
        </Properties>
        <Locals>
            <BooleanChoice Name="Toggle" Value="true" />
            <ClickHandler Name="Clicker" />
        </Locals>
        <Rules>
            <Condition Source="[Toggle.Value]" SourceValue="true" Target="[Image.Content]" Value="[GreenStar]" />
            <Condition Source="[Toggle.Value]" SourceValue="false" Target="[Image.Content]" Value="[YellowStar]" />
            <!-- When the image is clicked, swap the images using the Boolean value. -->
            <Changed Source="[Clicker.Invoked]">
                <Actions>
                    <Set Target="[Toggle.Value]" Value="[Toggle.Value]">
                        <Transformer>
                            <BooleanTransformer Inverse="true" />
                        </Transformer>
                    </Set>
                </Actions>
            </Changed>
        </Rules>
        <Content>
            <Graphic Name="Image">
                <Animations>
                    <Animation Type="ContentChangeShow">
                    <!-- This animates the new image (the one being shown). -->
                        <Keyframes>
                            <PositionKeyframe Time="0.0" Value="-300,0,0" Interpolation="Exp" />
                            <PositionKeyframe Time="1.0" Value="0,0,0" />
                            <AlphaKeyframe Time="0.0" Value="0.0" Interpolation="Exp" />
                            <AlphaKeyframe Time="1.0" Value="1.0" />
                        </Keyframes>
                    </Animation>
                    <Animation Type="ContentChangeHide">
                    <!-- This animates the old image (the one being hidden). -->
                        <Keyframes>
                            <PositionKeyframe Time="0.0" Value="0,0,0" Interpolation="Log" />
                            <PositionKeyframe Time="1.0" Value="300,0,0" />
                            <AlphaKeyframe Time="0.0" Value="1.0" Interpolation="Log" />
                            <AlphaKeyframe Time="1.0" Value="0.0" />
                        </Keyframes>
                    </Animation>
                </Animations>
            </Graphic>
        </Content>
    </UI>
    <UI Name="ContentChangeAnimations_Show">
        <Properties>
            <Image Name="GreenStar" Image="file://GreenStar.png" />
            <Image Name="YellowStar" Image="file://YellowStar.png" />
        </Properties>
        <Locals>
            <BooleanChoice Name="Toggle" Value="true" />
            <ClickHandler Name="Clicker" />
        </Locals>
        <Rules>
            <Condition Source="[Toggle.Value]" SourceValue="true" Target="[Image.Content]" Value="[GreenStar]" />
            <Condition Source="[Toggle.Value]" SourceValue="false" Target="[Image.Content]" Value="[YellowStar]" />
            <Changed Source="[Clicker.Invoked]">
                <Actions>
                    <Set Target="[Toggle.Value]" Value="[Toggle.Value]">
                        <Transformer>
                            <BooleanTransformer Inverse="true" />
                        </Transformer>
                    </Set>
                </Actions>
            </Changed>
        </Rules>
        <Content>
            <Graphic Name="Image">
                <Animations>
                    <Animation Type="ContentChangeShow">
                        <Keyframes>
                            <PositionKeyframe Time="0.0" Value="-300,0,0" Interpolation="Exp" />
                            <PositionKeyframe Time="1.0" Value="0,0,0" />
                            <AlphaKeyframe Time="0.0" Value="0.0" Interpolation="Exp" />
                            <AlphaKeyframe Time="1.0" Value="1.0" />
                        </Keyframes>
                    </Animation>
                </Animations>
            </Graphic>
        </Content>
    </UI>
    <UI Name="ContentChangeAnimations_Hide">
        <Properties>
            <Image Name="GreenStar" Image="file://GreenStar.png" />
            <Image Name="YellowStar" Image="file://YellowStar.png" />
        </Properties>
        <Locals>
            <BooleanChoice Name="Toggle" Value="true" />
            <ClickHandler Name="Clicker" />
        </Locals>
        <Rules>
            <Condition Source="[Toggle.Value]" SourceValue="true" Target="[Image.Content]" Value="[GreenStar]" />
            <Condition Source="[Toggle.Value]" SourceValue="false" Target="[Image.Content]" Value="[YellowStar]" />
            <Changed Source="[Clicker.Invoked]">
                <Actions>
                    <Set Target="[Toggle.Value]" Value="[Toggle.Value]">
                        <Transformer>
                            <BooleanTransformer Inverse="true" />
                        </Transformer>
                    </Set>
                </Actions>
            </Changed>
        </Rules>
        <Content>
            <Graphic Name="Image">
                <Animations>
                    <Animation Type="ContentChangeHide">
                        <Keyframes>
                            <PositionKeyframe Time="0.0" Value="0,0,0" Interpolation="Log" />
                            <PositionKeyframe Time="1.0" Value="300,0,0" />
                            <AlphaKeyframe Time="0.0" Value="1.0" Interpolation="Log" />
                            <AlphaKeyframe Time="1.0" Value="0.0" />
                        </Keyframes>
                    </Animation>
                </Animations>
            </Graphic>
        </Content>
    </UI>
</Mcml>
•	GainFocus and LoseFocus play the animation when the UI that contains the view item gains or loses mouse or keyboard focus. When Input.Keyfocus="true", GainFocus plays the animation. When Input.KeyFocus="false", LoseFocus plays the animation. For more information about input focus, see Working with Input Handlers.
The following example shows an image that responds to gaining and losing focus events with animation.
<Mcml xmlns="http://schemas.microsoft.com/2006/mcml" xmlns:me="Me">

  <UI Name="Anim_Event">
    <Rules>
      <Default Target="[Input.KeyInteractive]" Value="true" />
    </Rules>
    <Content>
      <Panel>
        <Layout>
          <FlowLayout Orientation="Vertical" Spacing="5,0" ItemAlignment="Center" />
        </Layout>
        <Children>
          <Text Color="DarkGoldenrod" Content="Hover over a star to put focus on it"/>
          <me:AnimStar />
          <me:AnimStar />
        </Children>
      </Panel>
    </Content>
  </UI>

  <UI Name="AnimStar">
    <Rules>
      <Default Target="[Input.KeyInteractive]" Value="true" />
    </Rules>

    <Content>

      <Graphic Name="GreenStar" Content="file://GreenStar.PNG" MouseInteractive="true">
        <Animations>
          <Animation Type="GainFocus" Loop="1">
            <Keyframes>
              <PositionKeyframe Time="0.0" Value="-3,0,0" />
              <PositionKeyframe Time="0.1" Value=" 3,0,0" />
              <PositionKeyframe Time="0.2" Value="-3,0,0" />
              <AlphaKeyframe Time="0.0" Value="0.6" />
              <AlphaKeyframe Time="0.2" Value="1.0" />
            </Keyframes>
          </Animation>

          <Animation Type="LoseFocus" Loop="1">
            <Keyframes>
              <AlphaKeyframe Time="0.0" Value="0.3" />
              <AlphaKeyframe Time="0.5" Value="0.2" />
              <AlphaKeyframe Time="1.0" Value="0.3" />
            </Keyframes>
          </Animation>

        </Animations>
      </Graphic>
    </Content>
  </UI>
</Mcml>
•	Idle plays the animation when a view item is idle; that is, when no other animation event is active. This animation represents the "rest state" of your view item.
•	Show and Hide play the animation when a view item becomes visible or hidden (the view item's Visible attribute is true or false). You can apply the Show and Hide transitions however you want. However, at the end of a Show animation, the item is located at the position specified by its layout and is visible.
The following example shows an animation that triggers the Show and Hide events when clicked, and has an animation for the Idle state.
<Mcml xmlns="http://schemas.microsoft.com/2006/mcml">

  <UI Name="ShowHideStar">

    <Locals>

      <BooleanChoice Name="StarVisible" Value="true" Description="Visible" />

      <ClickHandler Name="Clicker" />

    </Locals>

    <Rules>

      <Binding Source="[StarVisible.Value]" Target="[Image.Visible]" />

      <Changed Source="[Clicker.Invoked]">
        <Actions>
          <Set Target="[StarVisible.Value]" Value="[StarVisible.Value]">
            <Transformer>
              <BooleanTransformer Inverse="true" />
            </Transformer>
          </Set>
        </Actions>
      </Changed>

    </Rules>

    <Content>
      <Panel>
        <Layout>
          <FlowLayout Orientation="Vertical" ItemAlignment="Center" />
        </Layout>

        <Children>

          <Panel >
            <Layout>
              <FlowLayout Orientation="Vertical" ItemAlignment="Center"/>
            </Layout>
            <Children>
              <Text Name="Desc" Color="White" Content="Click this text to show or hide the star." />
            </Children>
          </Panel>

          <Panel MinimumSize="100,100" MaximumSize="100,100">
            <Children>
              <Graphic Name="Image" Content="file://greenstar.png" >
                <Animations>
                  <Animation Type="Show">
                    <Keyframes>
                      <AlphaKeyframe Time="0.0" Value="0.0" />
                      <AlphaKeyframe Time="1.0" Value="1.0" />
                    </Keyframes>
                  </Animation>
                  <Animation Type="Hide">
                    <Keyframes>
                      <AlphaKeyframe Time="0.0" Value="1.0" />
                      <AlphaKeyframe Time="1.0" Value="0.0" />
                    </Keyframes>
                  </Animation>
                  <Animation Type="Idle" Loop="-1">
                    <Keyframes>
                      <PositionKeyframe Time="0.00" Value="0,2,0" />
                      <PositionKeyframe Time="0.05" Value="-2,0,0" />
                      <PositionKeyframe Time="0.10" Value="0,-2,0" />
                      <PositionKeyframe Time="0.15" Value="2,0,0" />
                    </Keyframes>
                  </Animation>
                </Animations>
              </Graphic>
            </Children>
          </Panel>

        </Children>
      </Panel>
    </Content>
  </UI>
</Mcml>
•	Move plays the animation when a view item is moved. Typically, Move animations use PositionKeyframes using the RelativeTo attribute set to "Current" for the first keyframe and "Final" for the last keyframe.
•	Rotate plays the animation when a view item is rotated. Typically, Rotate animations use RotateKeyframes, using the RelativeTo attribute set to "Current" for the first keyframe and "Final" for the last keyframe.
•	Scale plays the animation when a view item changes scale. Typically, Scale animations use ScaleKeyframes, using the RelativeTo attribute set to "Current" for the first keyframe and "Final" for the last keyframe.
•	Size plays the animation when a view item changes size. This changes the item's size with an animation rather than applying an abrupt change. Typically, Size animations use SizeKeyframes, using the RelativeTo attribute set to "Current" for the first keyframe and "Final" for the last keyframe.
For in-depth animation samples, see the Sample Explorer.
See Also
•	Sample Explorer
•	Media Center Markup Language Verifier
•	Working with Animations
# Applying Transforms to Animations
You can apply two types of transforms to animations:
•	A TransformAnimation produces a new animation based on a source animation.
•	A TransformByAttributeAnimation applies the source animation differently to an item depending on its index, allowing you to create index-skewed time and value transformations.
With transforms, you can:
•	Shift the time of all keyframes by a given offset value.
•	Filter which keyframes to apply the transform to by type.
•	Modify the magnitude of all the keyframe values.
•	Scale the time value of all keyframes by a value (the animation will take more or less time).
For in-depth animation samples, see the Sample Explorer.
See Also
•	Sample Explorer
•	Media Center Markup Language Verifier
•	Working with Animations
# Using Antialiasing and Transparent Borders for Animated Images
During animation, the borders around images can appear jagged and pixelated:

To avoid this and to create a smooth visual transition from the image to the background, add antialiasing and transparent borders around images to soften the edges. To avoid transparency artifacts (for example, a gray or white "ghosting" around the image), fill the transparent parts of the image with 100% black (alpha is 0%).
See Also
•	Sample Explorer
•	Media Center Markup Language Verifier
•	Working with Animations
# Using Switch Animation
Not documented in this release.
See Also
•	Developing Applications for Windows Media Center

# K Best Practices for Animation
For best results, abide by the following guidelines for using animation:
•	First, design and implement your UI without animations or transformations to ensure the UI works as expected. For example, ensure the UI responds correctly to user input and that the UI is displayed correctly in widescreen format.
Next, add transformations such as static scales and rotations, and ensure everything continues to work correctly.
Finally, add animations as follows:
•	For "Show" animations, you typically set the last keyframe to be RelativeTo="Final".
•	For "Hide" animations, you typically set the first keyframe to be RelativeTo="Current".
•	For "Idle" and other animation types (such as "Move", "Scale", "Size" and "Rotation"), you typically set the first keyframe to be RelativeTo="Current", and your last to be RelativeTo="Final".
•	When designing your application, rather than using animation to move navigation panels and z-ordering to clip them, consider using a layout-based approach by displaying the panels in a flowing layout. When a panel is selected, make its sub-content visible (set Visible to true), and hide that content when the panel is not selected. This approach means that the panels are not clipped or overlapping. After ensuring that the panels work as expected without using animation, you can introduce animation to polish the appearance.
See Also
•	Sample Explorer
•	Media Center Markup Language Verifier
•	Working with Animations
# Best Practices for Background Animations
When designing background animations, you can implement different solutions, but you should consider the impact these solutions have on system resources. Consider the following:
•	A flipbook-style animation (cycling through images that play continuously) seems to be an easy solution to an animated background image. However, doing a full-screen flipbook animation is not recommended because of the impact on video memory. To compensate, you may have to use a low frame rate or use small source images, which may result in a poor background animation.
•	A sprite-style animation (displaying small animations over a static background) is preferable to a full-screen flipbook animation; however the same issues may arise. Sprites can be memory intensive, so compensating by reducing the size of images and lowering the frame rate may reduce the quality of the animation.
•	The preferred approach to a background animation is to composite as much of the background effect as possible, using separate images and animations. This solution allows you to use a higher frame rate and higher-quality images. Implementing a composite-style background animation is more complex, but will produce a better result.
See Also
•	Sample Explorer
•	Media Center Markup Language Verifier
•	Working with Animations

# K Working with Live and Recorded TV
Windows Media Center enables applications to programmatically schedule the recording of TV programs. This section discusses working with live and recorded TV through Windows Media Center and third-party applications; however, this functionality is heavily dependent on reliable data from the Electronic Program Guide (EPG). This section includes the following topics:
Topic	Description
Scheduling Recorded TV with Click-To-Record
Describes the click-to-record feature, which enables applications to programmatically schedule the recording of TV programs.
Electronic Program Guide
Lets you scan an on-screen listing of available channels and television program data for an extended time period.
Working with WTV Files
Describes the WTV file format, which is used for recorded TV programs.

See Also
•	Developing Applications for Windows Media Center

# K Scheduling Recorded TV with Click-To-Record
Click-to-record is a feature that enables applications to programmatically schedule the recording of TV programs. Click-to-record can be invoked in the following ways:
•	By a Windows Media Center Presentation Layer application running inside the Windows Media Center shell.
•	By an external application using the managed click-to-record application programming interface (API).
•	By the user launching a click-to-record document from the Windows shell.
Each method of invoking click-to-record involves passing Extensible Markup Language (XML) markup to Windows Media Center. The XML defines the criteria that Windows Media Center uses to locate, schedule, and record the TV programs. This documentation assumes that you are already familiar with XML in general and XML schemas in particular. For more information, see XML Developer Center on the MSDN Web site.
Note   The click-to-record API (the Microsoft.MediaCenter.TV.Epg and Microsoft.MediaCenter.TV.Scheduling namespaces) are supported on x86 and AMD64 platforms, but are not supported when called from 32-bit applications that are running in a 32-bit emulator on an AMD64 platform (also known as WOW64). If your application is a combination of managed and unmanaged code, you must compile two versions to support both platforms. If your code is entirely managed, it is platform neutral and the compiled binary can be run on both x86 and AMD64 platforms.
This section describes the XML schema that supports the Windows Media Center click-to-record feature and describes the XML elements used specify TV programs for Windows Media Center to record. This section discusses the following topics.
Topic	Description
XML Documents for Click-To-Record
Describes how to create XML documents for submitting TV recording requests to Windows Media Center.
Types of Recording Requests
Describes the various types of TV recording requests that Windows Media Center recognizes.
Valid Combinations of Recording Elements
Describes the combinations of XML elements that Windows Media Center interprets as valid TV recording requests.
Sample Click-To-Record XML Document
Provides a sample XML document that shows how to use the click-to-record elements to create a TV recording request.
Invoking the Click-To-Record Feature
Describes the ways in which TV recording requests can be submitted to Windows Media Center.
Creating a Click-To-Record Request with the CreateScheduleRequest Method
Describes how to create XML documents using the click-to-record API.

See Also
•	Working with Live and Recorded TV

# K XML Documents for Click-To-Record
An XML document that implements click-to-record begins with the following XML code:
<?xml version="1.0" encoding="utf-8" ?>
<clickToRecord xmlns="urn:schemas-microsoft-com:ehome:clicktorecord">
<body>
<metadata>
<description>Describe the recording scenario here</description>
<expires>2004-06-12T19:00:00Z</expires>
</metadata>

The clickToRecord element is the top-level schema element in the clicktorecord namespace. Every click-to-record XML document must include this as the top-level element.
The body element can contain a single, optional metadata element that encapsulates the description and expires elements. These describe the recording request and specify the date and time when the click-to-record XML document expires. Windows Media Center ignores recording requests that have expired.
The body element must contain a single programRecord element, meaning that only one recording request at a time can be submitted to Windows Media Center. The programRecord element includes several attributes and child elements. Together, these attributes and child elements define the criteria that Windows Media Center uses to find, schedule, and record TV programs. The following example shows the hierarchy of a programRecord element and its child tags.
<programRecord>
    <program>
        <key></key>
    </program>
    <service>
        <key></key>
    </service>
    <airing>
        <key></key>
    </airing>
</programRecord>

The child elements of programRecord include program, service, and airing, each of which can occur more than once. At a minimum, a click-to-record request must include at least one program element or one pair of service and airing elements.
The program element identifies a program to record. It specifies the title of a program, the title of the program episode, and, optionally, the year in which the program was released. The service element identifies the broadcasting service that provides the TV program to record. It can specify the name, call sign, affiliate call sign, or channel number of the service. The airing element specifies the starting date and time for a TV program.
When a click-to-record request is submitted, Windows Media Center searches through the Electronic Program Guide (EPG) for TV programs that match the information specified in the program, service, and airing elements. When Windows Media Center finds a match, it schedules a TV recording session.
If a click-to-record request includes multiple program elements, Windows Media Center begins its search with the first one. If no matching program is found, Windows Media Center uses the next program element. The search continues in this manner until Windows Media Center finds a matching TV program, at which point the search ends and any remaining program elements are left unused. Windows Media Center uses this same search pattern with the service and airing elements.
To specify search criteria, each program, service, and airing element contains one or more key elements. These specify the fields in the EPG that Windows Media Center should examine when it searches for the requested TV programs. The key elements also specify the rules that Windows Media Center should use in determining whether a particular program matches the search criteria. Multiple key elements are interpreted as logical ANDs; all of them must be satisfied to qualify as a match.
See Also
•	Managed Code Object Model Reference
•	Scheduling Recorded TV with Click-To-Record

# K Types of Recording Requests
Windows Media Center recognizes the following types of recording requests:
•	one-time: Windows Media Center records a particular program once.
•	series: Windows Media Center records a particular program at regular intervals.
•	manual: Windows Media Center records a particular service at a particular time.
•	keyword: Windows Media Center records a program that matches the search criteria when and if such a program becomes available.
The content and structure of the click-to-record XML document and the user's current EPG data determine the type of the recording request that Windows Media Center adds to the recording schedule.
To request a one-time recording, set the isRecurring attribute of the programRecord element to "false" and include one or more program elements in the XML document.
To further refine the search criteria for Windows Media Center, you can also include corresponding service and airing elements. Windows Media Center uses all available search criteria to find and record the specified program once.
Requesting a series recording is similar to requesting a one-time recording, except that you must set the isRecurring attribute of the programRecord element to "true".
To request a manual recording, include matching service and airing elements in the XML document, but no program elements.
Windows Media Center treats a click-to-record submission as a keyword request if the request criteria are valid and both of the following conditions exist:
•	No service is specified, or the specified service does exist in the user's current program guide
•	No airing time is specified, or the specified airing time exists in the future beyond the scope of current EPG.
See Also
•	Managed Code Object Model Reference
•	Scheduling Recorded TV with Click-To-Record

# K Valid Combinations of Recording Elements
Click-to-record creates one-time, series, or manual recordings. Manual recordings are generated when the service and airing elements occur together (such as time, duration, and channel). All other valid combinations of elements result in a one-time or series recording depending on the isRecurring attribute.
Certain combinations of the program, service, and airing elements are not valid because they do not provide Windows Media Center with enough information to fulfill a recording request. For example, a click-to-record definition with only a service element is not valid unless there is a corresponding program or airing element.
The following table shows the valid combinations of the program, service, and airing elements.
Combination	Description
program	Record this program whenever it is on, and from any service that provides it.
program, service	Record this program whenever it is on, but only from the specified service.
program, airing	Record this program at the specified time and from any service.
program, service, airing	Record this program at the specified time, and from the specified service.
service, airing	Record the named service at the specified time.

For example, if the program element is specified, the fields are required to match based on the given criteria (such as the title, episode title, and release year) and on the match level (Exact, Contains, or StartsWith).
The service and airing elements, when provided, are more flexible. As with the program element, the given criteria must be met for these elements as well—if there is no match, the request is not fulfilled. However, to make the service and airing elements a preference rather than a requirement, you can specify the following, and then programs might be selected that do not match the given criteria:
•	For service: allowAlternateServices="true"
•	For airing: allowAlternateAirings="true"
See Also
•	Managed Code Object Model Reference
•	Scheduling Recorded TV with Click-To-Record

# K Sample Click-To-Record XML Document
The following example shows the contents of an XML document used to request a one-time recording of a single episode of a TV program:
<?xml version="1.0" encoding="utf-8" ?>
<!-- Sample click-to-record (MSNBC Single-Episode Scenario) -->
<clickToRecord xmlns="urn:schemas-microsoft-com:ehome:clicktorecord">
<body>
<metadata>
<description>Record tonight's news on MSNBC</description>
</metadata>

<!-- Include 5 minutes of hard prepadding and postpadding. If the
specified airing is not found, allow an alternate to be scheduled. -->
<programRecord prepadding="-300" postpadding="300" allowAlternateAirings="true" allowAlternateService="false">
    <program>
        <key field="urn:schemas-microsoft-com:ehome:epg:program#title" match="exact">MSNBC News Live</key>
    </program>
    <service>
        <key field="urn:schemas-microsoft-com:ehome:epg:service#callsign" match="exact">MSNBC</key>
    </service>

    <!-- For the EST time zone (-300 minutes from UTC), specify an explicit time. -->
    <airing timeZone="-300">
        <key field="urn:schemas-microsoft-com:ehome:epg:airing#starttime">2004-04-17T18:00:00Z</key>
    </airing>

    <!-- In other time zones, record if the program is found within
         three hours (180 minutes) of the specified UTC time. -->
    <airing searchSpan="180">
        <key field="urn:schemas-microsoft-com:ehome:epg:airing#starttime">2004-04-17T18:00:00Z</key>
    </airing>
</programRecord>
</body>
</clickToRecord>

See Also
•	Managed Code Object Model Reference
•	Scheduling Recorded TV with Click-To-Record

# K Invoking the Click-To-Record Feature
The Windows Media Center click-to-record feature can be invoked by a Windows Media Center Presentation Layer application, by an external application, or by the user launching a click-to-record XML document from the Windows shell.
Invoking from a Windows Media Center Presentation Layer Application
A Windows Media Center Presentation Layer application makes a click-to-record request by passing the appropriate XML code to the EventSchedule.CreateScheduleRequest method. Windows Media Center responds by displaying a dialog box prompting the user to confirm the recording request. If the user approves the request, Windows Media Center attempts to fulfill the request, resulting in one of the following outcomes:
•	The recording request succeeds and Windows Media Center displays a confirmation dialog box.
•	The recording request fails. Windows Media Center displays a dialog box indicating that no matching TV program was found and recording was not scheduled.
•	The recording request results in a conflict. Windows Media Center displays a dialog box prompting the user to either resolve the conflict or cancel the recording request. In a system with a single TV tuner, a conflict occurs when the user tries to record two different channels at the same time. In a two-tuner system, a conflict occurs when the user tries to record three different channels at the same time.
Invoking from an External Application
An external application can make a click-to-record request by calling the EventSchedule.CreateScheduleRequest method in the Microsoft.MediaCenter.TV.Epg namespace. This method is defined in the following assembly:
%windir%\ehome\ehrecobj.dll

External click-to-record applications have special privileges and can schedule recordings without the user's direct involvement. Because of this, the EventSchedule.CreateScheduleRequest method includes the conflictPolicy parameter, which specifies how Windows Media Center should resolve any scheduling conflicts that may occur.
For an example, see Creating a Click-To-Record Request with the CreateScheduleRequest Method.
Invoking from the Windows Shell
The user can invoke the click-to-record feature from anywhere from the Windows shell by double-clicking an XML document that contains elements from the Click-To-Record XML Reference. For example, the user can launch a click-to-record document attached to an e-mail message simply by double-clicking the document.
A click-to-record XML document must have the .c2r file extension. The system registry contains a file association for the .c2r file extension.
Click-to-record documents downloaded from a Web server must be defined with the following MIME type:
text/vnd-ms.click2record+xml

Note   Only the EventSchedule.CreateScheduleRequest method can correctly interpret these features of the input XML file. The deprecated ClickToRecord.Submit and TVSchedule.ScheduleRecordingmethods for managed code, the MediaCenter.ScheduleRecording method for hosted HTML, and invoking the click-to-record feature from the Windows shell cannot accept this XML and may simply ignore these features.
See Also
•	Developing Applications for Windows Media Center
•	Scheduling Recorded TV with Click-To-Record

# K Creating a Click-To-Record Request with the CreateScheduleRequest Method
The following attributes can be used when creating the XML request using the EventSchedule.CreateScheduleRequest method.
Note   Only the EventSchedule.CreateScheduleRequest method can correctly interpret these features of the input XML file. The deprecated ClickToRecord.Submit and TVSchedule.ScheduleRecording methods for managed code, the MediaCenter.ScheduleRecording method for hosted HTML, and invoking the click-to-record feature from the Windows shell cannot accept this XML and may simply ignore these features.
•	The service element inside the key element can specify the service ID of the expecting service:
<key field="urn:schemas-microsoft-com:ehome:epg:service#id">

You can also specify a call sign (service#callsign), which is a string that is displayed in the EPG page in Windows Media Center. In some countries or regions, the service name is displayed in this field rather than an official call sign, or the service name may be left blank.
•	The keepUntil attribute of the programRecord element specifies how long to keep the recorded files. The following values are possible (if no value is specified, the computer's default value is used):
-3: Latest recordings
-2: Keep until I watch
-1: Keep until space needed
0: Keep until I delete
•	The quality attribute of the programRecord element specifies the quality of recording. The following values are possible (if no value is specified, the computer's default value is used):
0: Fair
1: Good
2: Better
3: Best
Example Code
// Example of Microsoft.MediaCenter.TV.Scheduling.EventSchedule.CreateScheduleRequest method.
// Create a recording request from "example.xml".

using Microsoft.MediaCenter.TV.Scheduling;
using System.IO;
using System.Collections.Generic;
using System.Xml;
using System;

namespace Microsoft.MediaCenter.TV.Scheduling.Example {

    public class ExampleClass {

        public static void Main()
        {           
            // Open XML file
            FileStream fsXml;
            XmlReader readerXml;
            try
            {
                fsXml = new FileStream("example.xml", FileMode.Open, FileAccess.Read);
                readerXml = XmlReader.Create(fsXml);
            }
            catch (Exception e)
            {
                Console.WriteLine("example.xml could not be read");
                Console.WriteLine(e.Message);
                return;
            }

            // Create EventSchedule object and create ScheduleRequest from XML.
            EventSchedule scheduler;
            ScheduleRequest request = null;
            CreateScheduleRequestResult result;
            try
            {
                scheduler = new EventSchedule();
                result = scheduler.CreateScheduleRequest(readerXml, ConflictResolutionPolicy.AllowConflict, "example", out request);
                Console.WriteLine("Result: " + result.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception from EventSchedule.CreateScheduleRequest()");
                Console.WriteLine(e.Message);
            }

            // Close the XML file.
            readerXml.Close();
            fsXml.Close();

            // Print the information about created ScheduleRequest.
            if (request != null)
            {
                try
                {
                    // ID of created ScheduleRequest.
                    Console.WriteLine("ScheduleRequest Id=" + request.Id);

                    // ScheduleEvent(s) included in this ScheduleRequest.
                    ICollection<ScheduleEvent> events = request.GetScheduleEvents();
                    foreach (ScheduleEvent se in events)
                    {
                        Console.WriteLine("ScheduleEvent Id=" + se.Id);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception when getting ScheduleRequest information");
                    Console.WriteLine(e.Message);
                }                
            }
        }
    }
}

The following XML example specifies a manual one-time recording of channel 4 from 11:00 A.M. to 11:30 A.M. on May 15, 2006 (in UTC + 9 hours time zone).
<?xml version="1.0" encoding="utf-8" ?>
<clickToRecord xmlns="urn:schemas-microsoft-com:ehome:clicktorecord">
    <body>
        <programRecord programDuration="30">
            <service>
                <key field="urn:schemas-microsoft-com:ehome:epg:service#mappedChannelNumber" match="exact">4</key>
            </service>
            <airing>
                <key field="urn:schemas-microsoft-com:ehome:epg:airing#starttime">2006-05-15T11:00:00+09:00</key>
            </airing>
        </programRecord>
    </body>
</clickToRecord>

See Also
•	Scheduling Recorded TV with Click-To-Record
# K Electronic Program Guide
The Electronic Program Guide (EPG) is a feature that lets you scan an on-screen listing of available channels and television program data for an extended time period. Using a remote control, the user can select specific listings from the on-screen display to tune to a current broadcast and select programs to record.
There are multiple ways to programmatically access guide data using the Windows Media Center API.
For Windows Media Center Presentation Layer applications, see the following APIs:
•	Microsoft.MediaCenter.TV.Epg.Lineup class
•	Microsoft.MediaCenter.TV.Scheduling.ScheduleEvent class
•	MediaCenterEnvironment.PlayMedia method
For creating the XML document, see the clickToRecord element.
For more information about scheduling TV programs, see Scheduling Recorded TV with Click-To-Record.
See Also
•	Developing Applications for Windows Media Center
•	Working with Live and Recorded TV
# K Working with WTV Files
Windows Media Center takes advantage of the Stream Buffer Engine (SBE), which enables an application to seek, pause, and record a live video stream without interrupting the stream. Transitions between live and recorded content are seamless. Currently, the SBE supports MPEG-2 video and digital video (DV) sources, at capture rates of up to 30 megabits per second (Mbps). When Windows Media Center records a television show, the audio and video elementary streams are encrypted. The SBE then writes the file to a directory (by default, to \Users\public\Recorded TV\) as a file with the .wtv extension.
The ability to access .wtv files depends on the copy protection policy set by the content owner and/or broadcaster. Windows Media Center determines the copy protection policy by reading the broadcaster's copy protection flag (CGMS-A). If the content owner and/or broadcaster has set the policy to protect the content, playback is restricted to the Windows Media Center PC used to record the content.
For information about playing and editing .wtv files in DirectShow, see Consumption of a WTV file in DirectShow on the MSDN Web site.
See Also
•	Developing Applications for Windows Media Center
•	Working with Live and Recorded TV

# Developing iTV Framework Applications
The Interactive TV (iTV) Framework in Windows Media Center provides third parties the ability to develop Windows Media Center applications that combine traditional TV with interactivity similar to that of the Internet and personal computer. The iTV functionality in Windows Media Center in Windows 7 enables media and broadcasting companies to deliver this rich content and services to their customers.
While the popularity of television is unquestionable, keeping viewers tuned in has grown more challenging. Interactive television programs using the Windows Media Center iTV Framework make it possible for programmers and broadcasters to capture and retain the attention of elusive viewers.
From live sports programs to reality TV to game shows and beyond, audiences everywhere are using their existing remote controls to interact. Broadcasters can now allow viewers to vote for their favorite contestants and instantly see the results, play along with game shows, change camera angles on sporting events, and view exclusive, behind-the-scenes content related to their programs. Viewers can interact with television content they are viewing in three ways:
•	Interaction with the television itself
•	Interaction with TV program content
•	Interaction with TV-related content
ITV applications are associated with broadcast content and are triggered by tag packets that have been inserted in the content stream by one of two sources: via the tuner or via the headend.
ITV is an integral part of many digital TV services and provides a browser- like experience for users. For example, iTV applications might allow end customers to view the latest new headlines, local weather conditions and forecasts, stock quotes, sports scores, or many other types of enhanced content while watching television.
See Also
•	Developing Applications for Windows Media Center

# Architecture Overview
The following diagram illustrates the architecture of iTV applications:

As the diagram shows, you need to build two components to interact with the iTV runtime. The managed component will interact with all iTV runtime classes and events except the data interfaces. For the data interfaces, iTV applications use a native dynamic-link library (DLL). The platform does not prescribe communications between the two components, and they can use any of the .NET interoperability technologies including platform invoke and COM interop.
Code in both of these components runs in the ehexthost.exe process.
See Also
•	Developing iTV Framework Applications

# iTV Examples
The following table lists several of the interactive TV features that you can implement using the Windows Media Center iTV Framework:
Feature	Examples
Enhancements	Camera views, statistics, chat, highlights, polls, commentary channels; chat on top of broadcast TV; Mosaic.
Video on demand (VOD)	Linked to current broadcast (highlights/replays); sports features: live table, commentaries, comparisons, insider information, voting, player rating; recommend related, on demand/pay-per-view (PPV).
Overlay	Live public discussion, polls/voting, bookmarking, tags; shared bookmarks; invite friends to view.
Interaction with the TV program	Pause launches overlay with options: resume TV, interact, chapters/bookmarks; reviews; cast and crew; community ratings; related on-demand content; write reviews; recommend other VOD/broadcast.
Interaction with TV related content	View trailers and VOD content; planner; reminders; interact – speculation, instant messaging (IM)-related enhancements; voice over IP (VOIP); back stories and related links; link to record series; recommendations; store integration.

See Also
•	Developing iTV Framework Applications

# iTV General Considerations
For a compelling user experience, keep the design:
•	Clean
•	Simple
•	Attractive
•	Relevant
•	Consistent
•	Direct
Font size, legibility, readability, color, remote control navigation, resolution, flicker, contrast, layout, graphics, and content all impact the usability and design of your iTV application or service.
Overall, your design should follow a simple philosophy called user-centered design, which incorporates user concerns and advocacy from the beginning of the design process. The needs of the user should be foremost in any design decisions.
See Also
•	Developing iTV Framework Applications

# iTV Audience
Knowing your audience is probably the most important aspect of planning and designing an iTV application. The tendencies and interests of your target audience should be reflected in your application.
Developing for the TV experience must also take into consideration how end users will be viewing the content. Because an increasing number of consumers watch television on their PCs, your design should take both the 2' (PC) and 10' (living room) viewing distances into consideration. While the goal of your application may not change between these two viewing methods, end users will interact with your application differently; using a keyboard and mouse from the 2' PC experience or a remote control from the 10' living room experience. Design your application to function well for either experience.
See Also
•	Developing iTV Framework Applications

# iTV Business Considerations
Consider the following challenges when creating an iTV application:
•	Ease of content discovery and use.
•	Sharing content.
•	Browsing content.
•	Rich experiences that differentiate from competitors.
•	Interactive and on-demand features.
•	Not all parts of a business contribute to a great user experience with a distance user interface. When creating an application that works well from a distance (rather than from the desktop), try to incorporate the more visually-exciting and content-rich parts of your design into the iTV runtime application, and streamline the management portions as much as possible.
•	Maintain your brand; when choosing a color scheme, try to create a design that incorporates your brand identity. Avoid a look that is too similar to that of the main Windows Media Center user interface. If your application looks like the rest of Windows Media Center, users may fail to understand that they are in a separate application and may become confused.
•	Don't copy the Windows Media Center brand.
•	Maintain a consistent look with your Web site, your network package, or both.
•	Adapt to the requirements of distance viewing.
•	The user should be able to visit your Web site and Windows Media Center experience and instantly know they are provided by the same company. Not all elements of your user interface will work from a distance, but all the parts should feel related.
See Also
•	Developing iTV Framework Applications

# Testing iTV Applications
ITV applications are standard Windows Media Center extensibility applications in many respects. Therefore, this section does not discuss general principles for testing Windows Media Center extensibility applications, but rather details the specific testing requirements that arise from writing software that augments television.
UI Concerns for iTV Applications
Take care to test the interaction of any UI elements that the application displays using the rendering APIs from the iTV Framework. Testing should ensure that the UI does not inhibit, and is not inhibited by, the standard Windows Media Center UIs. These elements are particularly important to test:
•	Navigation buttons along the bottom of the screen (including Play, Pause, and Record).
•	The green button along with the "back" button in the top left corner of the screen.
•	The clickable seek bar.
The iTV application's UI elements should not cover Windows Media Center UI elements, and the application's UI should be designed so that its elements can be hidden without making it difficult for users to navigate.
Recorded vs. Live
Test iTV applications both by launching the application from a recorded TV file and in a live-streaming environment. The iTV launch mechanism works for recorded TV, so a recording carries the information needed to launch any embedded iTV application. However, a recorded-TV launch succeeds only if the application is installed at the time the recording is played back.
If the application is installed, testing should verify that the UI displayed, the application's behavior, and the interactions between the application and the broadcast make sense even if they are time shifted: for example, call-in phone numbers displayed on screen might not be available anymore, or online surveys may have closed.
To make sure the application will work correctly for multi-PC households, you need to install the application on all Windows Media Center PCs if it will be launched from a recorded TV file that gets transferred from one PC to the other (for example, over a network).
For applications launched from recordings, if the channel lineup changes between the time the recording is made and the time it is played back, relevant XML tuning strings for the iTV tuning API may need to be adjusted. Testing should verify that these adjustments are made correctly.
Stream Selection
The stream selection APIs allow applications to disable all video and audio streams. This feature is useful, but it can be confusing to end-users because its effect is so similar to a lost signal. Testing should verify that the application always keeps one audio and one video stream active, or verify that the application notifies the end-user if audio or video streams are missing.
See Also
•	Developing iTV Framework Applications

# Supportability
Supportability doesn't happen by accident. It must be an explicit effort at the design stage of your iTV application development. Without a comprehensive approach with explicit goals, some areas of supportability may improve but other areas may actually worsen. When planning for your application, be sure that you take into consideration what it will be required to respond to customer inquiries and issues with your iTV application, what may be required of the end user during a support call and how you provide updates to your application in an ongoing basis.
See Also
•	Developing iTV Framework Applications

# iTV Design Considerations
In the past, users interacted with applications on personal computers primarily by using the keyboard and the mouse. Prior versions of Windows Media Center enabled another option: interaction with a computer that worked like interaction with a television, by using a remote control. Now, new functionality enables media and broadcasting companies to deliver interactive television applications to further enhance end users' viewing experience while watching TV.
Interactive TV (iTV) combines traditional TV with interactivity similar to that of the Internet and personal computer. Interactivity offers richer entertainment and additional information about television shows and programs by allowing viewers to interact with the television content as they view it. The iTV Framework provides mechanisms to embed an entire video window within an application-drawn user interface or to overlay graphics on top of the video.
To create a user experience that is related to and works well with the content being viewed, you need to consider the interactions between the two more deeply than you might for an application that runs independently from broadcasters' content. While iTV applications allow viewers to interact with the television content during viewing it also requires a design approach that successfully integrates the interactive elements the broadcast content.
In adapting the principles of information design for this new medium, it is important to consider the user's and broadcasters expectations.
The Windows Media Center iTV experience takes the traditional television viewing experience and combines it with the interactive experience of using a PC. Users will expect the traditional viewing experience with the ability and power to obtain additional relevant information as they would with the PC.
The basic steps in the design process are as follows:
1.	Define the user scenarios. Brainstorm and sketch ideas. Make sure you have a clear, technical understanding of both the flexibility and constraints of the Windows Media Center platform.
2.	Create prototypes. Test and refine. Repeat until you have a final design. Prototypes of the design can be implemented as wire frames using only simple color blocks to evaluate navigation models early on while the design is still fluid and adjustable.
Note   iTV applications in Windows Media Center in Windows 7 are associated with broadcast content and are triggered by tag packets that have been inserted in the content stream by the tuner or the headend. Consequently the iTV application developer must have access to tools that allow them to insert a tag packet into the stream.
3.	Implement the design in working code. Always start with layout and data binding. The experience should be highly usable before any animations are added to polish the look and feel of the experience.
4.	Fix the bugs and refine the design (fit and finish). Typically, animations are added at this stage of the design.
See Also
•	Developing iTV Framework Applications

# Usability
Consider the following challenges for implementing simplicity and ease of use:
•	A simple UI in the style of consumer devices.
•	Understandable UI at first glance.
•	A minimal learning curve.
•	The fewest steps to accomplish a task.
For applications that take the end user away from the broadcast a "return to broadcast" capability should be intuitive.
Distance user experiences test very well when they are simple and the interface is clear and consistent.
Rather than thinking about developing software for a computer, approach the design more from a traditional consumer electronics standpoint. Whatever you develop should be as easy and intuitive to use as turning on a TV set and changing channels.
See Also
•	Developing iTV Framework Applications

# iTV Navigation
In the past, interaction with televised content was minimal, often limited to channel change, volume control and display adjustments. With iTV applications the end user now has the ability to interact with the television shows and programs as they are viewing them.
Creating a user interface that works well with the remote control without interfering with the viewing experience requires deeper thinking about how to present computer-based information. Compared to an application that is not tied to the broadcast content an iTV application must work in harmony with the broadcast content while providing an easy method for the end user to identify and utilize its functionality.
In adapting the principles of information design for iTV applications it is important to consider the user's expectations. With the advent of iTV applications end users expect a richer, enhanced television viewing experience. At the same time they expect that the navigation of the iTV application is convenient, simple and comprehensive while using their standard Windows Media Center remote control. They will also expect applications to "just work", and be convenient, simpler to learn, and easier to use than applications controlled by the keyboard or mouse.
Here are some key principles for keeping navigation simple when designing for a remote control experience:
•	Navigation and all feature usage should require only the Up, Down, Left, Right, Select (OK or Enter), and Back buttons when the user uses the remote control.
•	Design your navigation so that Left, Right, Up, and Down arrows can be used instead of having no action for some of the arrow keys on some pages. For example, when you group items based on functionality, you may only need to use Left or Right arrows to move focus along those items aligned in a horizontal layout. In such case, use Up and Down arrows to move to the next group.
•	Distance viewing of remote-controlled experiences shrinks the amount of screen real estate available to the user interface. Split tasks into multiple pages rather than trying to squeeze them in to a single page.
•	Definite Up, Down, Left, Right, Select, and Back navigation models work well. When using Context Overlay diagonal movements or actions plus navigations may be appropriate in some instances, but run the risk of confusing the user.
•	Multiple scrolling sections (even if they are in sync with each other) typically do not test well.
The term "navigation" must apply not only to movement between pages or screens, but also to movement between selectable elements within a page. Users navigate by using the arrow buttons on the remote control to move the input focus and pressing the Enter button to act on the focused item. One item on the screen always has the focus.
At any time, the user can switch between input modes, keyboard or remote control. Special care should be taken at the very early stages of design to respect each type of usage and provide the UI necessary to enable elegant handling of each input model.
Note   Mouse support is currently not a feature in the iTV platform.
•	Consider the following challenges when the primary input device is a remote control:
•	Different interaction models are used. The iTV Framework does not currently support mouse navigation. A mouse can move focus arbitrarily to any location on the screen. The Windows Media Center remote control does not provide the same granularity.
•	Traditional user interface (UI) elements can be hard to use, such as a selectable text hyperlink denoted only by an underline. Sliders and drop-down menus (combo boxes) are also difficult to use with a remote control.
•	Navigation and usage of all features should always be limited to use of the Up, Down, Left, Right, Select and Back buttons on the remote control. A focus highlight must always be present.
The first challenge is to limit the input device to the remote control, which affects how you lay out UI items and pages. A good start is to align elements to a logical grid so that they map to the strict requirement of up, down, left, and right navigation.
See Also
•	Developing iTV Framework Applications

# Integration
Special consideration must be taken when developing an iTV runtime application that will run in "overlay" mode with the broadcast content. This scenario requires that the application be easily identifiable without overwhelming the viewing experience of the broadcast content. To ensure the best end user experience it is suggested that the iTV runtime application not take up too much of the viewing surface. Ensure that your application:
•	Is easily identifiable on the screen.
•	Provides a method for the end user to "hide" or "show" your application.
See Also
•	Developing iTV Framework Applications

# Distance
General design principles used for traditional desktop UI (such as interface scale, density, and navigation) are too complex for use with the remote control from a distance. Consider the following:
•	Most conventional desktop display design principles fail when viewed from a distance.
•	The design for Windows Media Center is related to all other distance designs.
•	Keep it clean and simple—avoid density.
For examples of good designs that allow you to view full screens of information from a distance, consider pedestrian and traffic signs, posters, billboards, and DVD menus.
See Also
•	Developing iTV Framework Applications

# Developing iTV Applications
See the following topics to learn about developing iTV applications.
See Also
•	Developing iTV Framework Applications

# Creating an iTV Application
To start building iTV applications you will need the following:
•	Vista Windows Media Center Software Development Kit (SDK) version 6.0
•	Microsoft Visual Studio 2008 Express Edition
•	Tuner Simulator for injecting tag packets into the broadcast stream
You build iTV applications like any other Windows Media Center background applications. The HelloWorld sample shows the most minimal iTV application; use this as a guide to building your own iTV application. The Windows Media Center SDK provides Visual Studio templates to help you begin your development.
Windows Media Center iTV applications typically need to reference the Microsoft.MediaCenter.ITVVM assembly to build and run. This assembly resides in the %windir%\ehome directory.
Once you have installed the required software, use the following procedure to create an extensibility application:
1.	Open Visual Studio 2008.
2.	On the File menu, click New Project.
3.	In the New Project dialog box under Templates, click Windows Media Center Application - Fundamental.
4.	 Update the project name and directory details to something appropriate for your project.
After you create the application, follow the steps required to sign the application. These steps should automatically appear from the Readme.htm file included in the project. If you skip this step the application will not run.
See Also
•	Developing iTV Framework Applications

# Registering and Installing an iTV Runtime Application
The standard Windows Media Center extensibility application that Visual Studio creates doesn't know anything about the iTV framework API, so you need to set that framework up by adding references to it to your C# project. Use the following procedure:
1.	In Solution Explorer, right click your project and click Add Reference.
2.	Switch to the Browse tab on the dialog box that appears, browse to [%Windir%\ehome, and click the file name Microsoft.MediaCenter.iTv.Hosting.dll.
3.	Repeat the process, but select the file ehiiTV.dll.
The DLLs you select in steps 2 and 3 contain all the interfaces your application need to use the iTV framework.
To identify an application as an iTV Framework application, set the category field in the registration XML to iTV\app:{ ITV Addin guid id }. As the author of the iTV application you must generate this GUID. To do so, select Create GUID from the Tools menu in Visual Studio.
This following XML code shows a sample extensibility registration script for an iTV application:
<?xml version="1.0" encoding="utf-8"?>
<ITV VM Addin title="ITV VM X" id="{646FD62A-CF44-48b7-A995-B43855B75F15}">
    <entrypoint
id="{1A1A7C5D-468A-45d9-84C2-BDEA3E2F6126}"
    addin="Microsoft.MediaCenter.iTV.VMX, VirtMachX"
    title="Sample VM"
    description="Renderer for iTV format X">
        <category category="iTV\app:{91edb1f6-4574-41ec-ae77-71dff5517968}"/>
    </entrypoint>
</ITV VM Addin>
After you create a template Windows Media Center application, you must change it so that the iTV Framework launches it in response to an in-band data stream. To do this, add the GUID for the data stream that you plan to use for the application to the registration XML. Use the following procedure:
•	In Solution Explorer locate and open the file named Registration.xml. Locate the line containing the category entry and modify it to look like the following.
<category category="iTV\app:{91edb1f6-4574-41ec-ae77-71dff5517968}" />
Substitute your application's GUID for the GUID used in this example and in the remaining examples for this section.
When Windows Media Center detects the presence of an incoming data stream matching the registered GUID it launches the application through the standard launching mechanism by calling the Launch method on the IAddInEntryPoint interface. In the standard Windows Media Center applications that Visual Studio 2008 creates this method is in the Launch.cs file under the Code directory.
See Also
•	Developing iTV Framework Applications

# Debugging with the iTV Framework
As mentioned in Attaching a Debugger to a Windows Media Center Application using Visual Studio, you can set a registry key that allows Windows Media Center to pause before starting an application. During this pause, Windows Media Center displays an on-screen message, and you can attach the debugger of your choice to the ehexthost.exe process (where the application is hosted). The Windows Media Center message includes the process ID (to distinguish it from other ehexthost.exe processes that may be running). From this point on, you can debug your application as you would any other application.
For stability Windows Media Center extensibility applications and iTV Framework applications run within a virtual machine environment. Although this environment provides a good user experience for Windows Media Center users it complicates debugging considerably. To familiarize yourself with all available debugging options, see Debugging.
Because it isn't possible to pick up debug messages within Visual Studio, you should use of the Debug Output console to debug your application. Another recommendation is to use DebugView from SysInternals (available at http://technet.microsoft.com/en-us/sysinternals/bb896647.aspx). To see how to send messages to DebugView from an iTV application, try adding the following code to the HelloWorld:
using System.Diagnostics;
…
Debug.WriteLine("itvSample: Hello");
See Also
•	Developing iTV Framework Applications

# iTV Development Issues
See the following topics for more information about development issues.
See Also
•	Developing iTV Framework Applications

# iTV Application Lifetime
The TVVMbase class automatically handles all the details of lifetime management for your application. All applications that use the iTV runtime API must derive from TVVMbase and override the following methods:
protected virtual void Launch();
protected virtual void CleanUp();
The Launch method should contain all initialization code, and the CleanUp method should contain all cleanup code. Both these methods are called from different threads. Unlike Windows Media Center background applications, an iTV application does not terminate when the Launch method returns. Instead, the iTV runtime normally ends the application. The application and ehexthost process should exit in any of the following cases:
•	The user stops Windows Media Center video playback. In this event, the application should be notified to clean up and end. A transition between live and recorded content does not constitute an end of video playback.
•	The iTV runtime detects an application GUID in a tag packet, then shuts down the current application and launches of the application associated with the new GUID.
•	The application itself calls Exit. This method initiates the shutdown of the current application and process.
In each case, the CleanUp method in your application is called so that the application can perform any required actions during cleanup. After the CleanUp method exits, the application should not call any iTV runtime APIs.
An application can call IAddInModule.Uninitialize to request shutdown of the iTV VM.
See Also
•	Developing iTV Framework Applications

# Retrieving the In-band Data
Before your iTV application can do anything it needs to retrieve the in-band data from the data stream. Two interfaces in the iTV framework handle this retrieval: IiTvDataSource and IiTvDataReceiver.
An application uses methods implemented in IiTvDataSource to register to receive in-band data. It uses the methods implemented in IiTvDataReceiver to receive callbacks containing that packetized data stream.
The following code illustrates how to set up the connection:
// Obtain the interface
Guid guid = typeof(IiTvDataSource).GUID;
IiTvDataSource iTvDataSource = (IiTvDataSource)
                                  iTvHost.QueryService(ref guid);

// Connect callback to the data stream
iTvDataSource.Connect(this);
The object receiving the connection should derive from IiTvDataReceiver and implement the following methods:
public class DataStream : IiTvDataReceiver
{
    public void Initialize(IiTvDataStreamControl dataReceiver) {}
    public void Terminate() {}
    public void Start() {}
    public void Stop() {}
    public void Receive(IntPtr piTVData, uint dwoTVDataLength,
                     IntPtr pAttributes, uint dwAttributesLength) {}
}
The Receive method gets the packetized stream data. The packets come with a header attached and payload data as detailed in a previous section.
When your application has finished receiving the data stream, it can disconnect using the following call:
// Disconnect callback from the data stream
iTvDataSource.Disconnect();
See Also
•	Developing iTV Framework Applications

# Stream Manipulation
ITV applications use two main classes to interact with streams: StreamSelector and StreamInfo classes. The StreamType enumeration lists all stream types that can be manipulated. Currently the only supported stream types are Video, Audio, Teletext, and Subtitles.
Before manipulating streams of types Audio, Teletext, and Subtitles, your application must call the StreamSelector.SetModifyingStreams method to notify Windows Media Center that it intends to manipulate those stream types. Video streams are always assumed to be modifiable.
StreamSelector.SelectStream and StreamSelector.DeselectStream operate on a cached set of new streams until the application calls StreamSelector.CommitSelection.
See Also
•	Developing iTV Framework Applications

# Tuning
Tuning requires XML strings to designate the correct tune parameters. The PBDA spec identifies the schema for the tune XML For more information about PBDA, download the specification from http://go.microsoft.com/fwlink/?LinkId=132926. For XML tuning string samples, see "PART 1 – Tuning Schemas – Core Schemas".
If you suppress non-critical components of the Windows Media Center TV user interface (UI) using the suppressUI parameter to the Tune method, the Windows Media Center UI does not get notified that the current channel has changed, which may lead to a confusing situation for the end user.
To improve performance and data throughput, your application should not use managed code to parse or consume data. Managed code causes unnecessary overhead because data needs to be copied (memory copy). The iTV data APIs (implemented by the IiTvDataAttribute, IiTvDataReceiver, IiTvDataSource, and IiTvDataStreamControl interfaces) are streamlined for performance and iTV applications should use native C++ as much as possible to use this data. All but one of the data APIs are COM-based, and the type library for these APIs is embedded in the dynamic-link library (DLL) McITvVmData.dll as a resource.
The only C-style iTV data method, GetITVDataSource, also resides in McITvVmData.dll. This method gets the COM interface pointer to IiTvDataSource. One way to use this method in your application is to include the McITvVmData.h header file in your application and link to the static-link library McITvVmData.lib. However, this technique can lead to unexpected problems. If you compile and link as described, your native DLL depends on and implicitly loads McITvVmData.dll. Because McITvVmData.dll resides in the %windir%\ehome folder, you must install your application into this directory or change the path to include it. If you don't, the implicit load of McITvVmData.dll at run time fails because the application is unable to find it.
The solution is to explicitly load and resolve the address of the GetITVDataSource method at run time, eliminating the need for McITvVmData.h and McITvVmData.lib. The following code sample illustrates how to resolve the method call at run time:

```
CAtlString EnvStr;
IiTvDataSource* pDataSource;
typedef HRESULT (*GetITVDataSourcePTR)(IiTvDataSource**);
GetITVDataSourcePTR GetITVDataSourceptr
EnvStr.GetEnvironmentVariable(_T("windir"));
EnvStr+= _T(\\ehome\McITvVmData.dll);
HMODULE hDllHandle = ::LoadLibrary(EnvStr);
GetITVDataSourceptr  = (GetITVDataSourcePTR) (GetITVDataSourcePTR)::GetProcAddress(hDllHandle,"GetITVDataSource");

HRESULT hr = tvvmDataSource(&pDataSource);
```

Once you have the IiTvDataSource pointer you have access to the remaining iTV data interfaces. The call to IiTvDataSource->Connect starts the process of interacting with the data interfaces, while the IiTvDataSource->Disconnect call ends the session.
Finally, if your application calls the InvalidateDataSource method from a class derived from the managed class TVVMbase, the application must reacquire the IiTvDataSource pointer and not use any methods or interfaces acquired through the previous IiTvDataSource pointer.
See Also
•	Developing iTV Framework Applications

# Threading
The following diagram shows how threads are created and run in the iTV framework:

Each color in the diagram represents a different thread. As the diagram shows, the same thread is used to deliver managed events and the call the CleanUp method for an iTV Framework application. Data events and the Launch method are delivered on their own threads. In summary, the iTV runtime uses only two threads communicate with iTV Framework applications.
See Also
•	Developing iTV Framework Applications

# Handling Managed Events
Managed events (indicating property changes) are delivered to an iTV Framework application synchronously, but on separate threads from Windows Media Center. Your application should not call the rendering APIs (see Rendering a User InterfaceDevelopingiTVApplicationsDevelopmentIssuesRenderingaUserInterface on any event thread or while an event thread is blocked. Also, in general, it is wise not to perform lengthy operations on event threads. No events except keyboard and command events require a return code, so there is no reason that event threads cannot return immediately. iTV Framework applications can receive events other than keyboard or command events (on different threads) while they are still processing the current event.
Keyboard and command events require a return code that indicates whether the event should be propagated up to the next handler or whether the application should process or use the event. Keyboard and command events are always delivered sequentially and one at a time. If an application does not return from a keyboard or command event handler within two seconds, the iTV Framework determines that the application cannot process keyboard and command events fast enough and stops delivering them. In this case, the iTV Framework notifies the application by firing a PropertyChanged event for the PlaybackSession.KeyCommandEvent property and setting the KeyboardCommandEventState property to KeyboardCommandEventState.DoneListening.
See Also
•	Developing iTV Framework Applications

# Rendering a User Interface
Windows Media Center composites multiple surfaces to render images on screen. The rendering APIs in the iTV Framework offer access to the Windows Media Center OverlaySurface and VideoSurface classes and their methods and events, as well as to related objects that those methods and events return. The following diagram shows a simplified example of Windows Media Center rendering using these objects:

As the diagram illustrates, the renderer composites the Now Playing inset (consisting of an overlay surface composited with a video surface) into Windows Media Center. Applications can use the iTV APIs to control the placement of the composited surfaces in the Now Playing inset. Windows Media Center typically renders the Now Playing inset to the full size of the Windows Media Center window.
The OverlaySurface object also contains an alpha channel so that the application can hide or blend with the video as desired. Because the overlay surface is a bitmap in ARGB32 format, it offers an 8-bit-per-pixel alpha channel. (For the same reason, it the overlay surface cannot render any HTMLT, MCML or other user interface constructs ) The application can also set the OverlaySurface.Visible property to make the entire overlay surface fully opaque or fully transparent.
The Windows Media Center rendering engine does not allow calls to rendering APIs while the engine is blocked. The only effective way to use a rendering API in this case is to call the APIs on another thread. Furthermore the Windows Media Center thread cannot be blocked while the other thread is making the call. As described in Threading, the Launch method does not run on a Windows Media Center thread, but all events do.
In summary, an iTV Framework application should not call a rendering API on any thread that was not created in the application except for the thread that runs Launch.
The Windows Media Center rendering engine does not cache images in the overlay surface when transitioning between different rendering modes (for example, between full-screen and windowed rendering modes). Unless the application refreshes the overlay surface image, there is no image to render. An OverlaySurface.PropertyChanged event signals rendering mode transitions. As previously described, you cannot update the overlay surface on this event thread, nor can you block the event thread and render on another thread. The following code from the HelloWorld sample application shows how to register for and process for such an event:

```
//register for the Overlay Surface Property Change Event
_OverlaySurface.PropertyChanged += new Microsoft.MediaCenter.UI.PropertyChangedEventHandler(_OverlaySurface_PropertyChanged);

// Event Handler for the Overlay Surface Property Change Event
public void _OverlaySurface_PropertyChanged(Microsoft.MediaCenter.UI.IPropertyObject sender, string property)
{
// Queue a thread pool thread to update the overlay surface when the event occurs.
System.Threading.ThreadPool.QueueUserWorkItem(delegate(Object state) { UpdateOverlaySurfaeWithBitmap(); }, null);
}
```
See Also
•	Developing iTV Framework Applications

# iTV Framework Tools - PBDA Device Simulator
The PBDA Device Simulator is a tool to help developers test and validate the iTV applications that they have developed to run on Windows Media Center. The tool is a software tuner that simulates a PBDA device and allows a developer to:
•	Simulate a PBDA tuner device.
•	Insert tag packet data into the stream.
•	Create additional channels and transport streams.
Use the following procedure to download the PBDA Device Simulator:
Note   You must be a registered member of Microsoft Connect to download the device simulator.
1.	Go to the http://connect.microsoft.com website.
2.	Select CONNECTION DIRECTORY.
3.	Under Categories, select Developer Tools.
4.	Locate PBDA Software Tuner.
5.	Follow the steps to download the executable file and documentation.
See Also
•	Developing iTV Framework Applications

# K Playing Media
This section describes how to play audio and video content in the shared and custom view ports, summarizes the types of media content that are supported, and other playback-related considerations in the following topics:
Topic	Description
Using the Now Playing and Video View Items
Describes the insets for playing video.
Working with a Media Collection
Describes how to work with media collections to create and manage dynamic playlists.
Creating Full Screen Video
Describes the considerations of displaying video in full screen.
Retrieving Playback Information
Describes how to retrieve information about the current media, including the buffering progress, play state, and play rate.
Supported Media Types for Windows Media Center
Lists the types of media content that are supported by Windows Media Center.

See Also
•	Developing Applications for Windows Media Center

# K Using the Now Playing and Video View Items
The Now Playing and Video view items are windows for media content.
•	The Now Playing inset is the small media window sometimes visible at the lower left of the screen. It can contain video or TV content, or it can contain metadata for audio or radio content such as cover art and song titles.
•	The Video inset is an optional video window with customizable dimensions and placement on your page. It can contain video content, but no metadata for video or audio.
The following image shows the Now Playing inset, in the lower left corner of the Windows Media Center window:

To include audio or video as part of the user interface, use the appropriate inset as follows.
Now Playing
•	Is a non-customizable media window.
•	Is always located at the lower-left corner of the page.
•	Displays video or audio (the song title and cover art) content.
•	Can take and lose focus.
•	Can be hidden while media playback continues.
•	Dimensions and aspect ratio cannot be changed.
•	Can be selected by the user to be displayed in full screen.
•	Is always displayed when the user leaves an extensibility application and returns to Windows Media Center with a media experience playing.
Use the Now Playing inset when the current media experience is secondary in nature to the other content on the page.
Video
•	Is a fully-customizable media window.
•	Contains video content only (you can display the view port for audio content, but a black square or rectangle is displayed).
•	Can take or lose focus.
•	Can be hidden while media playback continues.
•	Dimensions (height and width) and aspect ratio can be changed.
•	Can be positioned anywhere on the screen.
Use a Video inset when the content is highly relevant to other metadata or action items on the page.
Programming Elements
To include audio or video as part of the user interface, use the Video or NowPlaying elements in MCML combined with the AddInHost.MediaCenterEnvironment property and MediaCenterEnvironment.PlayMedia method.
With the Video element, the current video playing in Windows Media Center will be displayed within the bounds of the Video view item, but this doesn't affect the video size. The item must be given a MinimumSize or a full set of anchor points if it is displayed within a form or anchor layout. As with any other view item, the Video view item can be animated. The result of the Video element is a rectangle with no other visible UI to denote focus—this UI must be added with additional MCML code.
The NowPlaying element is a Windows Media Center object that contains the behaviors and UI of Windows Media Center (the chrome, the full-screen behavior when selecting an item with the remote, keyboard, and mouse). The NowPlaying view item is essentially a separate item from the rest of the third-party user interface (for example, you cannot rotate it with the other items on the page). You do not need to manage focus between the NowPlaying view item and other focusable objects in MCML because this functionality is implemented automatically.
The NowPlaying element is used only for positioning purposes. So unlike all other view items, NowPlaying does not respond to animations and other transforms (such as scaling and rotation). The Windows Media Center Now Playing inset is placed wherever the NowPlaying view item is placed, and supports some configuration (such as what information to display about the currently playing media).
See Also
•	Playing Media
•	Working with Audio and Video
# Working with a Media Collection
Applications can create media collections of audio and video items to play, similar to a playlist. These media collections can be created and modified dynamically, in real time, offering basic queue management features.
Using a media collection, applications can:
•	Specify the order in which items are played.
•	Play an item at any location within the collection.
•	Append, insert, and remove items from the collection.
•	Determine which item is currently playing.
•	Specify the playback modes (fast forward, rewind, previous, next, and seek) that are allowed for each item in the collection.
•	Specify a time index from which to start playback of an item (for example, start playback of a video at an offset of five minutes from the beginning.)
•	Specify the length of time for which to play an item.
•	Play any of the video types that are supported natively in Windows Media Center (WMV, WTV, DVR-MS).
•	Override the title, creation time, and duration fields that are included in the media item with "friendly" data.
•	Use mixed http:// and file:// protocols within the same collection.
Creating and Modifying a Media Collection
Two classes are used to create and modify media collections:
•	The MediaCollectionItem class manages individual media items. The application can get or set various properties for a media item (such as its playback capabilities, length, URI, and so forth).
•	The MediaCollection class manages the overall media collection. The application can add, insert, and remove media items from the collection; determine which item is currently active; and indicate whether to continue playback if an error occurs.
Media items can be created with a MediaCollectionItem object and by setting individual properties for the media item, or by calling the MediaCollection.AddItem method and using the parameters to specify the properties.
The following example shows a button that adds a media item to a collection using variables for the media item URI and index, which were defined in the Locals section of the UI:
<ctrl:Button ButtonLabel="Add Item">
    <Command>
        <InvokeCommand Target="[TestCollection.AddItem]"
            media="[RandomUri.Value!cor:String]"
            index="[AddIndex.Value!cor:Int32]"/>
    </Command>
</ctrl:Button>
Playing a Media Collection
To play a media collection, use the MediaCenterEnvironment.PlayMedia method using the "MediaCollection" parameter for mediaType, and the name of the media collection for media: :
<ctrl:Button ButtonLabel="Play Collection">
    <Command>
        <InvokeCommand Target="[AddInHost.MediaCenterEnvironment.PlayMedia]"
            mediaType="MediaCollection"
            media="[TestCollection]"
            addToQueue="false"/>
    </Command>
</ctrl:Button>
The media collection is played from the first item in the collection index, and IsActive property for the media collection is true.
To start playback at a specific index (in other words, to play a particular item), set the MediaCollection.CurrentIndex property to the index of the item to play before calling PlayMedia.
The application can make other calls during playback, but calls are ignored if they attempt to modify the active item. For example, you can remove any item in the media collection except the item that is currently playing.
Events
A PropertyChanged event is fired whenever a property changes for the MediaCollection or MediaCollectionItem objects.
The MediaCollectionItemEventArgs class contains information about events associated with a media collection. Query the MediaCollectionItemEventArgs.Index property to retrieve the index of the media item that raised the event. Query the MediaCollectionItemEventArgs.Item property to retrieve the media item object.
Lifetime
If the user leaves and then returns to the application, the application can use the MediaExperience.GetMediaCollection method to retrieve the media collection that was last played. Only the application that created this media collection can modify it.
For more information about media collections, see the ObjectModelMediaCenterMediaCollection samples in the Sample Explorer.
See Also
•	Developing Applications for Windows Media Center
•	Playing Media

# K Creating Full Screen Video
Windows Media Center will display currently-playing content in full-screen mode to occupy the entire Windows Media Center UI if the user either focuses on a Now Playing or Video inset and presses the OK/Enter button on the remote control or uses the mouse to click on one.
Displaying Full Screen
Programmatically, the UI can call the MediaExperience.GoToFullScreen method to move the playback to full-screen mode. (This does not size the Windows Media Center UI to full-screen, but rather sizes the content to the full Windows Media Center UI.)
If the user presses the Back button when the video content is in full-screen mode, Windows Media Center navigates back to the UI page and the content appears in the Now Playing or Video inset.
The Windows Media Center GoToFullscreen methods can use the physical display type and signal format to line up overscan regions. Windows Media Center also ensures that signals that match the output hardware get a clean pass-through, increasing video quality substantially.  
Applications should always use GoToFullscreen for full-screen video display rather than trying to display a large Video element in MCML.
Background Modes
Windows Media Center provides several automatic background modes that the application can display by using the MediaCenterEnvironment.BackgroundMode property.
For example, the application can display the standard Windows Media Center backgrounds (animated or static) or an ARGB color.
When audio is playing, the application can display a mosaic of the user's album art the standard Windows Media Center audio background.
When video is playing, the video can be displayed full screen, as a background watermark or masked in different ways.
For more information, see the BackgroundModes enumeration.
Overlaying
It is not possible to overlay anything other than a dialog box or a prompt over the Windows Media Center full-screen video experience. If you need to interact with the user, consider the following options:
•	For simple interaction, you can use the MediaCenterEnvironment.DialogNotification  method to display a prompt with a small icon and text.
•	For urgent interruptions, you can use the MediaCenterEnvironment.Dialog  method to create either modal or non-modal dialog boxes that appear over the Windows Media Center full-screen video experience.
See Also
•	Developing Applications for Windows Media Center
•	Playing Media

# Retrieving Playback Information
You can retrieve additional information about the currently-playing media, such as:
•	Buffering progress. Use the MediaTransport.BufferingProgress property to retrieve a value that indicates the buffering progress as a percentage. For example, when streaming large videos, you can provide feedback to end users informing them of the buffering progress.
•	Play state. Use the MediaTransport.PlayState property to determine the playback state. For example, you can find out whether the current item is playing, stopped, buffering, paused, or finished.
•	Play rate. Use the MediaTransport.PlayRate to determine the current rate and direction of playback. For example, find out if the item is being fast-forwarded at high speed.
•	Position. Use the MediaTransport.Position to determine the current position in the media stream.
For more information, see the samples in the the Sample Explorer.
See Also
•	Developing Applications for Windows Media Center

# K Supported Media Types for Windows Media Center
The following media types are natively supported on all Windows Media Center platforms, which include all Media Center Extender devices. Additional media types may be supported on the PC only by installing a third-party codec. File formats not listed below may not work on Media Center Extenders and thus when designing for Windows Media Center, we highly recommend using only the following media formats:
Media Types Supported by all Windows Media Center Platforms
Video
•	Windows Media Video (WMV) 9
•	Maximum resolution of 1920 × 1080 (1080p) at 30 frames per second
•	Windows Media digital rights management (DRM) support up to level 2000
•	MPEG-1
•	MPEG-1 layer I and II audio
•	MPEG-2
•	Maximum resolution of 1920 × 1080 (1080i)
•	MPEG-1 layer I and II or AC-3 audio
Audio
•	Windows Media Audio (WMA) 7, 8, and 9, WMA Professional
•	Windows Media DRM support up to Level 2000
•	WMA Lossless
•	MP3
•	WAV-PCM

Additional Media Types Supported by certain Media Center Extenders
Additionally, some Media Center Extender devices such as the Xbox 360 may also support the following media:
Video
•	WMV 7 & 8
•	WMV Image 1 & 2
•	Maximum resolution of 800 × 600
Audio
•	WMA Lossless with DRM support
•	Windows Media DRM support up to Level 2000
Playlists
•	Limited ASX playlist support. Extender devices support Windows Media Player playlists (ASX playlists) only for basic playing of files.
Of the elements available for Windows Media metafiles, only ASX, ENTRY, and REF are supported. Elements that specify additional ASX functionality, such as DURATION, EVENT, ENDMARKER, or PARAM, are ignored in the Extender session. If you create your playlists to include ignored elements, the files specified in your REF elements should still play in order, but you might lose some functionality. If you try to nest a metafile using the ENTRYREF element, this may result in a video or audio error on the Extender device.
If your application provides content that is not listed above, it may not be playable on a Media Center Extender device and the application should inform the user that the content can be played only on the host computer. The application can inform the user by displaying a message when the user starts a downloading or streaming operation from a Media Center Extender session, or by providing UI tags for each content file. To detect whether the user is in a Media Center Extender session or on the host computer, see Detecting a Media Center Extender Session.
Supporting Digital Rights Management
Windows Media Digital Rights Management (DRM) is a proven platform that protects content for playback on a computer, portable device, or network device. A license, which is required to play protected content, is issued separately and contains the terms for playback, such as an expiration date. Windows Media DRM supports a range of business models from single downloads to subscription services for audio and video content.
Windows Media Center supports playback of protected Windows Media-based content. If the user acquires protected content, Windows Media Center can decrypt the content if a license is present, and then plays the content according to the terms of the license. If a license is not present, Windows Media Center attempts to acquire a license by opening the license acquisition URL that is specified in the content header.
Windows Media Center does not provide a way for you to protect your own content using DRM. For information about protecting content and issuing licenses, see the following topics on the Microsoft Web site:
•	Digital Rights Management (DRM)
•	Windows Media Rights Manager SDK
We recommend that you have your license provider issue licenses silently whenever possible to avoid displaying any user interface to the end user.
Working with Playlists
The Windows Media Center SDK does not provide any methods for creating playlists. However, you can create playlists outside of Windows Media Center and play them. For example, you can create a Windows Media Player playlist file in .ASX or .WPL format, and your application can play the playlist within Windows Media Center.
You can play audio and video playlists, although Windows Media Center cannot play nested playlists (a playlist in which one or more entries is another playlist). For a playlist to work, each entry in that playlist must be a media file. Furthermore, we strongly recommend against the use of server-side playlists because server-side playlists are not supported on Media Center Extender devices.
DirectShow Filters
Windows Media Center supports the same codecs that are supported by Windows Media Player. Windows Media Center relies on Microsoft DirectShow filters to render audio and video content, and includes a set of default filters that support a wide variety of audio and video formats.
If your application's audio or video format is not supported by the default filters, you can add support by installing and registering a custom DirectShow source filter on the Windows Media Center PC, thereby allowing the MediaCenterEnvironment.PlayMedia  method to play the media without the need for you to write any additional code.
By adding a custom filter, your application automatically receives the following support from Windows Media Center:
•	An on-screen seek bar that appears when the user pauses or rewinds the content.
•	Full integration with the remote control (transport controls, navigation, and so on).
•	Seamless playback in the Windows Media Center shared view port (as when viewing a TV show in Windows Media Center) when the user navigates to another place in Windows Media Center.
•	On-screen transport controls for mouse users.
•	Improved performance for playback.
•	Use of the Now Playing page for audio content (album art, song lists, and so on).
For more information about DirectShow filters, see the following topics on the MSDN Web site:
•	Registering a Custom File Type
•	About DirectShow Filters
•	Writing DirectShow Filters
•	Filter Samples

See Also
•	Developing Applications for Windows Media Center
•	Playing Media

# K Installing Windows Media Center Applications
Before end users can run your application, you must install and register it in Windows Media Center. Registering adds information about the application and its entry points into the Windows Media Center UI to the system registry, enabling Windows Media Center to locate, load, and run the application, and to display its entry points in the Windows Media Center shell.
This section includes the following topics:
Topic	Description
Integrating your Application into Windows Media Center
Describes the different integration points in Windows Media Center you can use for your application.
Associating Application Entry Points with Integration Locations
Explains different ways to register an application, customize the Start menu, use multi-language features, and remove the registration.
Handling Installation from within Windows Media Center
Describes considerations for installing Windows Media Center applications.

See Also
•	Developing Applications for Windows Media Center
# K Integrating your Application into Windows Media Center
When you register your application, you'll need to decide where in the Windows Media Center UI you want users to find your application by specifying one or more application entry points. Entry points are specific locations within an application where the user enters the application experience. A tile icon appears for your application entry points at the corresponding integration locations.
The integration locations you choose should launch your application with the correct context, depending on the type of functionality you want to provide. For example:
•	A tile located in the Extras > Extras Library > Programs By Name category should always launch the application at its main menu.
•	A tile located in the Music > More Music category should launch the application from its music feature.
This design allows users to spend more time browsing content and available services in context.
The following table shows how different Windows Media Center integration points can correspond to an application's entry points:
Windows Media Center
integration point	Application entry point
More Programs	Application main menu
More Music	Application music feature
More With This Artist	Artist details page

This section describes the basic integration points into Windows Media Center in the following topics:
Topic	Description
Integrating into the Extras Library
Describes the main integration location for all Windows Media Center applications.
Integrating into Radio
Describes the integration points for the Internet Radio integration location.
Integrating into More With This
Describes how to register applications for the context-sensitive More menu option.
Integrating into the Start Menu
Describes the integration points for the horizontal menu strips for top-level menu options.
Registering for AutoPlay Events
Describes the integration points for AutoPlay.
Integrating a Background Application
Describes the integration point for background applications.
Integrating an OEM Extensibility Application
Describes the integration point for OEM extensibility applications.

See Also
•	Installing Windows Media Center Applications
# K Integrating into the Extras Library
The Extras Library (Windows Media Center Start menu > Extras > Extras Library) is the single place where all Windows Media Center applications should appear by default.

Applications should always register for the appropriate subcategory, or pivot. That is, if your application is a music or podcast application, you should register it for the Music + Radio pivot. The following image shows a selected application in the Extras Library > Programs By Name pivot:

The last entry point that was registered for a particular media type is also displayed on the Windows Media Center Start menu strip for that corresponding media type. For example, in the figure below, the last application that was registered for a movies integration location is displayed on the Movies Start menu strip.

The following categories register an application for Extras Library pivots:
•	Services\Audio
•	Services\Games
•	Services\HomeControl
•	Services\MediaChanger
•	Services\Movies
•	Services\News
•	Services\Pictures
•	Services\Radio
•	Services\Shopping
•	Services\Sports
•	Services\TV
•	Settings\DiscChanger
•	Settings\DVD
•	Settings\Extender
•	Settings\Music
•	Settings\Other
•	Settings\TV
•	Settings\Tasks
•	More Programs
See Also
•	Installing Windows Media Center Applications
•	Integrating your Application into Windows Media Center
# K Integrating into Radio
Under Music > Radio, Windows Media Center includes FM tuning and Internet radio. Use this integration location to place your Internet radio applications with others the user has chosen.
The following image shows the Music > Radio > Sources integration location:

The following categories register an application for Internet Radio:
•	Internet Radio
•	Internet Radio\Presets
See Also
•	Installing Windows Media Center Applications
•	Integrating your Application into Windows Media Center
# K Integrating into More With This
When the user opens the context-sensitive menu on a selected media item by pressing the More Information button on the remote control or right-clicking the media item with the mouse, Windows Media Center includes a More menu option. When More is selected, Windows Media Center provides a page of applications that are registered for the corresponding media type. For example, your application can provide additional actions for a photo in the Windows Media Center UI, such as sharing the photo over the Internet. The user can start an application from this list with the additional contextual information about the current media.
In the image below, the user has opened the context-sensitive menu for a picture:

The following image shows an example of what might be displayed when selecting More:

The following categories register an application for More With This integration locations:
•	More With This\Audio\Album
•	More With This\Audio\Artist
•	More With This\Audio\Playlist
•	More With This\Audio\Song
•	More With This\Audio\Genre
•	More With This\DVD
•	More With This\Picture
•	More With This\Video
Because an application can include entry points in several More With This contexts, an application needs a way to determine the context from which the user started the application. To determine the context, an application can query the AddInHost.MediaContext property.
See Also
•	Installing Windows Media Center Applications
•	Integrating your Application into Windows Media Center
# K Integrating into the Start Menu
The Windows Media Center Start menu contains horizontal menu strips that correspond to the top-level menu options. Each tile in the menu strip corresponds to a single entry point for an application. The image below shows the top-level TV + Movies option and its menu strip.

At any given time, two custom Start menu strips can be displayed, each containing up to five tiles. As a general rule, the application should have at least three entry points to make use of a custom Start menu strip. The following image shows an example:

See Also
•	Installing Windows Media Center Applications
•	Integrating your Application into Windows Media Center
# K Registering for AutoPlay Events
You can register your applications for AutoPlay, so that when a disc is inserted into a Blu-ray or HD-DVD drive on the user's PC, the user can choose to launch your application to play the disc. The AutoPlay integration point does not have a visual representation within the Windows Media Center UI.
The following categories register an application for AutoPlay events:
•	AutoPlay\Blu-ray
•	AutoPlay\HD DVD
See Also
•	Installing Windows Media Center Applications
•	Integrating your Application into Windows Media Center
•	Registering AutoPlay Event Handlers for HD DVD and Blu-ray Disc
# K Integrating a Background Application
Managed code background applications can run and persist simultaneously with Windows Media Center to provide additional value and features. The background integration point does not have a visual representation within the Windows Media Center UI.
The following category registers an application as a background application:
•	Background
See Also
•	Installing Windows Media Center Applications
•	Integrating your Application into Windows Media Center
# Integrating an OEM Extensibility Application
Windows Media Center will launch and navigate to the first application registered to the following category any time it receives Hid Usage 0x3d (#61):
•	OEM Extensibility 1
See Also
•	Installing Windows Media Center Applications
•	Integrating your Application into Windows Media Center
# K Associating Application Entry Points with Integration Locations
Entry points are specific locations within an application where the end user enters the application experience. An entry point consists of several UI elements that you provide, including a PNG-format image, a title string, and a descriptive string that describes the purpose of the application. An entry point also has an associated category that determines the location in the Windows Media Center user interface where the entry point appears. Each application can have multiple entry points in various integration locations in the Windows Media Center UI if you specify the locations when the application is registered.
The basics rules for entry points are as follows:
•	An application can have one or more entry points.
•	At a minimum, an application has a single entry point that typically opens the application's main menu.
•	An application can respond contextually to metadata provided by Windows Media Center about the currently playing media or to a string specified as part of the registration information.
•	An application can be launched with the same entry point from multiple locations within Windows Media Center—although, in general, this isn't helpful for the end user.
•	You should always register applications and their entry points for all users so that they are available to any user on the Windows Media Center PC, as well as to all Media Center Extender devices. The registration samples in this SDK assume registration for all users.
There are two basic approaches for registering applications:
•	Use the registration API or utility with XML. This is the recommended approach. It uses XML code that contains the registration information with either the registration API (for Windows Media Center Presentation Layer applications) or the RegisterMCEApp utility.
•	Write registry keys directly. This is an alternative method when you are using a Visual Studio setup project.
Windows Media Center Presentation Layer Web application types only need to use the registration APIs or utilities and registration XML.
The following types of application require a full installation using Windows Installer 2.0 or later technologies to create a setup MSI file.
•	Windows Media Center Presentation Layer local application
•	Windows Media Center Presentation Layer background application
•	Installed controls
An example of registering an application for all integration points in Windows Media Center, including custom Start menu strips, can be found at [WMCSDK_InstallPath]\Samples\Register Application\. Running install.bat in this folder automates the registration process, while uninstall.bat reverses the changes.
See the following topics for more information:
Topic	Description
Using the Registration API or Utility with XML
Describes the registration method and utility to register application entry points.
Creating the XML Registration Information
Describes how to create the XML code that contains the registration information.
Creating Custom Start Menu Strips
Explains how to create a custom Start menu strip.
Using Multi-language User Interface Features
Describes how to support a multi-language UI using resources.
Providing Contextual Information for Launching an Entry Point
Describes how to provide additional startup information for your entry points.
Removing Application Registration
Explains how to unregister applications.
Writing Registry Keys Directly
Explains how to register entry points by creating registry keys.

See Also
•	Installing Windows Media Center Applications
•	Integrating your Application into Windows Media Center
# K Using the Registration API or Utility with XML
The recommended approach to register applications is to use the registration API or utility with XML code.
First, you must create XML code containing registration information and pass it to the registration API (see Creating the XML Registration Information). The registration API creates or deletes registry keys according to the XML information. Access the registration API as follows:
•	Call the ApplicationContext.RegisterApplication method.
The user is prompted with a confirmation dialog box because you cannot register your application on a client computer without permission, and this dialog box allows the user to cancel. The Add Link to More Programs dialog box displays the source URL, not the destination URL. If the user accepts, the application entry points appear as specified in Windows Media Center.
•	From a command line, use the %windir%\ehome\RegisterMCEApp.exe utility.
Using this utility results in a Success or Failure response at the command prompt. It also results in a return value of 0 to indicate success and non-zero to indicate failure. There is no prompt for the user in the Windows Media Center user interface.
•	Using the Windows Installer XML Toolset (WiX), create a custom action for your Windows Installer 2.0-based setup program (MSI) to use the %windir%\ehome\RegisterMCEApp.exe utility.
You can verify that an entry point has been registered by using the ApplicationContext.IsEntryPointRegistered method. Verification is based on the ID (GUID) for the entry point.
For Web applications, the best way to suggest registration to users is to provide a button with an appropriate label, such as "Add To Windows Media Center".
Registering for All Users
You should register for All Users so that your shortcut appears for any user on the Windows Media Center PC or on a connected Media Center Extender device. If you register without providing an instruction to register for All Users, your shortcut will appear only for the user who completes the registration.
To register for All Users using the RegisterMCEApp.exe executable at the command line, include the /allusers switch, for example:
%windir%\ehome\registermceapp.exe /allusers myXMLFile.xml
Keep in mind that in Windows Vista and later, the /allusers switch causes RegisterMceApp.exe to create registry entries under HKEY_LOCAL_MACHINE, an administrative task that requires the user to accept a User Account Control dialog box for elevated permissions.
If you are enabling users to register within your application using the ApplicationContext.RegisterApplication method, the All Users instruction is a Boolean parameter that you pass when you call the method. To register for All Users, set the allUsers parameter to true. This setting also requires the user to accept an elevated permissions dialog box.
Important   Your application cannot be registered for All Users from a Media Center Extender session. When calling the RegisterApplication method, it is necessary for developers to treat Windows Media Center PC users and Media Center Extender users differently.
First, detect whether the user is using a Windows Media Center PC or a Media Center Extender.
•	For users on the Windows Media Center PC, set the allUsers parameter to true.
•	On Media Center Extender devices, all User Account Control dialog boxes are automatically cancelled, so the Extender user cannot register for all users. You should set the allUsers parameter to false, or the registration process will fail altogether. When your application is registered from the Extender, your shortcut will appear only to the Extender user.
See Also
•	Associating Application Entry Points with Integration Locations
# K Creating the XML Registration Information
To connect the integration locations with your application entry points, you must create the XML code that contains the registration information to pass to the Windows Media Center registration API.
Use the following XML elements to create the XML:
•	application element specifies the path to your application and several application attributes
•	entrypoint element contains the parameters for the application
•	category element specifies the integration locations for a given entry point
•	capabilitiesRequired element specifies values that indicate the environment that the application needs to run correctly
The RegisterMCEApp.exe utility takes the XML code in the form of a file, while the RegisterApplication methods take the XML code as a string. The XML consists of an application element and one or more nested entrypoint elements. Each entrypoint element can contain one or more nested category elements, one for each category in which the entry point is to appear.
To prevent errors during registration when you create your XML and/or registry keys:
•	Be sure to correctly nest single and double quotes, and to correctly escape them.
•	Do not attempt to register a file on a local machine.
•	The XML must be well formed; avoid XML syntax errors.
•	Be sure to include all of the attributes that are required.
•	Be sure to include at least one application element, one entrypoint element, and one category element.
See Also
•	Associating Application Entry Points with Integration Locations
# K Creating Custom Start Menu Strips
The following steps provide an outline of how to create a custom Start menu strip in Windows Media Center:
1.	Register the application (see Using the Registration API or Utility with XML and Writing Registry Keys Directly).
2.	Create a registry entry for the registration XML at [HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Media Center\Start Menu\Applications\{AppGUID}] to include the following keys:
Name	Type	Description
Title 	REG_SZ	The display name for the custom Start menu strip.
Category 	REG_SZ	The category name that you used in the registration XML.
OnStartMenu 	REG_SZ	Set to true to display the menu strip.
TimeStamp 	DWORD	Set to a hexadecimal value to indicate the number of seconds that have elapsed since midnight on January 1, 2000 C.E.

Note   When two custom Start menu strips are registered, Windows Media Center displays the newer application first (the one with the higher TimeStamp value).
3.	To modify the order in which tiles are displayed on the custom Start menu strip, edit the TimeStamp values generated by the registration API for each custom category entry point in the registry information at [HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Media Center\Extensibility\Categories\CustomCategory\ApplicationName\{EntryPointGUID}].
Note   Windows Media Center orders the tiles according to the TimeStamp values, with newer timestamps after older ones.
You can also directly add TimeStamp registry values in sequential order in the Registry table of an MSI to control the order in which the tiles are displayed.
For more information, see the following samples (located in [WMCSDK_InstallPath]\Samples\Register Application):
•	Register.Application.1.xml
•	Registry.Application.1.reg
•	Register.Application.2.xml
•	Registry.Application.2.reg
See Also
•	Associating Application Entry Points with Integration Locations
# K Using Multi-language User Interface Features
You can register a Windows Media Center application so that it supports a multi-language UI. The display name and description for the application dynamically changes on a multi-lingual system when the user changes the operating system UI language in the Regional and Language Options control panel. This method is only valid for locally installed managed-code assemblies.
The title and description attributes of the application and entrypoint elements in the registration XML can be dynamically changed as follows:
1.	Create a series of multi-lingual resource strings and include them in a binary that is included with your application.
•	The resource strings must be stored as Win32 resources.
•	Managed resources are not supported.
2.	Register your application using the RegisterApplication methods or the RegisterMceApp.exe utility. The syntax for referring to a multi-lingual resource in the entrypoint title and description attributes is as follows:
@<resourceFile>,-<resourceID>

•	<resourceFile> is a fully-qualified path to the binary that contains the Win32 resource strings. This path can be an absolute path such as c:\Program Files\MyApp\myResources.dll, or it can use environment variables such as %ProgramFiles%\MyApp\myResources.dll.
•	<resourceID> is the exact ID in the string table of the resource binary that contains the string for the attribute.
The following code shows an example of registration XML:
<application title="@c:\Program Files\MyApp\myResources.dll,-101"…>
    <entrypoint title="@c:\Program Files\MyApp\myResources.dll,-102"
                description="@%ProgramFiles%\MyApp\myResources.dll,-103"…
    <category…/>
    </entrypoint>
</application>

See Also
•	Associating Application Entry Points with Integration Locations
# K Providing Contextual Information for Launching an Entry Point
The entry point can determine contextual information when it is launched using the following information:
•	The context attribute of the entrypoint element from the application registration XML provides an arbitrary string of data.
Windows Media Center Presentation Layer Web applications use the context attribute to specify the URL of the entry point. To use the context attribute in this scenario, use and parse arguments in the http URL.
•	The AddInHost.MediaContext property provides an array of metadata associated with the media playing when the entry point is launched.
See Also
•	Associating Application Entry Points with Integration Locations
# K Removing Application Registration
Removing a registered action depends on the method used to register the application. In each case, the exact same registration XML must be used with the exact same parameter set to remove an application registration.
•	Use the ApplicationContext.RegisterApplication method with the UnRegister argument set to true.
•	From a command line, use the %windir%\ehome\RegisterMCEApp.exe utility with /u switch.
•	When writing registry keys directly, delete the appropriate registry keys.
Unregistering an application does not delete any of the application files or remove any of its registry entries other than those related to its entry points. Registry keys that were created for custom Start menu strips are not removed using the registration API.
See Also
•	Associating Application Entry Points with Integration Locations
# K Writing Registry Keys Directly
An alternative approach to registration is to bypass the registration API and write registry keys directly using a Windows Installer-based setup program. This approach is necessary when you are using a Visual Studio setup project to build your setup program.
Registry values are placed into a 32-bit or 64-bit registry, depending on the system. However, if you install an application using a 32-bit setup program on an x64-based system, the registry values are created in the 32-bit registry and the entry points to the application are not displayed in Windows Media Center. To avoid this issue, do one of the following:
•	Create two versions of the setup program (32-bit and 64-bit).
•	Use the RegisterMCEApp utility.
When writing registry keys directly using a Visual Studio setup project to build your setup program:
•	In the Solution Explorer pane, right-click the name of your setup project, point to View, and then click Registry.
•	Add the registry keys and values necessary to register your application with Windows Media Center. For an example of the registry keys you can use, see the sample registration files in [WMCSDK_InstallPath]\Samples\Register Application.
•	You can also import an .reg file with the necessary keys. For example, you could register the application on a local computer using the registration API, export the registry keys and values to a .reg file, and import the registry keys and values in the .reg file onto a different computer.
•	You must enter the fully-qualified path to images.
•	The registry information should always be written to HKEY_LOCAL_MACHINE, which registers the application for all users.
You can verify that an entry point has been registered by using the ApplicationContext.IsEntryPointRegistered method. Verification is based on the ID (GUID) for the entry point.
See Also
•	Associating Application Entry Points with Integration Locations
# Handling Installation from within Windows Media Center
Installing software from within Windows Media Center is not practical for the following reasons:
•	The Windows Installer is not designed for distance viewing or use with a remote control.
•	Installation requires administrative permissions.
•	Installation cannot occur on Media Center Extender devices.
To ensure that your installation process runs smoothly on Windows XP Media Center Edition 2005 and later and on the Media Center Extender, specify the path to the Web page with the installation instructions in a call to the MediaCenterEnvironment.CreateDesktopShortcut method. The following example shows the installation process used by the Z sample application. For more information about Z, see Building and Modifying the Sample Applications.
1.	Display a page that uses a timer to determine whether the application is installed by checking the ApplicationContext.IsApplicationRegistered property. If the application is not installed, display an Install Now button that calls the MediaCenterEnvironment.CreateDesktopShortcut method.

2.	The user clicks Install Now, which displays a prompt to open the Web site or save the link.

3.	The user chooses to open the Web site, which displays a Web page of instructions and a link to the setup program.

4.	The user installs the application.

5.	When the user returns to Windows Media Center, the installation page reflects the change in the ApplicationContext.IsApplicationRegistered property by displaying a Launch Now button. This button calls the MediaCenterEnvironment.LaunchEntryPoint method so that the end user can start the application.

See Also
•	Installing Windows Media Center Applications

# K Building and Modifying the Sample Applications
The Windows Media Center SDK includes several sample applications. In a default installation, the applications are located in the folder at the following path: %ProgramFiles%\Microsoft SDKs\Windows Media Center\v6.0\Samples\. The following sample applications are included:
Sample	Description
McmlSampler	Windows Media Center Markup Language (MCML) samples that contain the source files (MCML documents, sounds, and images) for the Sample Explorer.

Z	A Windows Media Center Presentation Layer application written in C# and MCML that shows basic controls and features (such as buttons, galleries, and pivots), an on-screen keyboard, and animation techniques. Z uses many common Windows Media Center APIs, and shows the architecture and data binding concepts of MCML. You can also use Z for testing your own code and data.
Register Application	A set of XML files and registry files that demonstrate various techniques for registering applications for use in Windows Media Center.

Attempting to build the projects or modify the source code from the default installation location without running Visual Studio with elevated privileges will fail due to permission issues. However, the error messages may not convey information indicating the nature of the issue or its solution.
You can avoid this issue by doing one of the following:
•	Run Visual Studio with elevated privileges.
•	Copy the sample applications to a folder where you have write permissions, and then modify and build the applications from that location.
See Also
•	Development Tools for the Windows Media Center SDK

# K Displaying Content Based on Parental Controls
Windows Media Center maintains settings that enable parents to control access to the types of movie and TV content that children are allowed to view. The parent specifies maximum allowable ratings for movie and TV content and sets up an access code. Subsequently, Windows Media Center prompts for the access code before showing any content that exceeds the specified content ratings. Windows Media Center maintains different parental control settings for movies and TV programs.
The Windows Media Center object model includes a number of application programming interface (API) elements that enable applications to retrieve the current parental control settings. Before playing a particular movie or TV show, an application can check the parental control settings and, if the content exceeds the specified ratings, prompt for the access code.
To retrieve the parental control settings for a particular category, an application must first query the MediaCenterEnvironment.ParentalControls property to retrieve a ParentalControls object. Next, the application passes a category string to the ParentalControls.GetAvailableRatingSystems method to retrieve the current parental control settings for either the movie or TV category.
Windows Media Center maintains a separate group of settings that enable parents to specify maximum ratings for violence, suggestive dialog, offensive language, and sexual content in TV content. An application can access these advanced TV ratings through the USTVRatings class.
To enforce the parental control settings, Windows Media Center displays a page that requires the user to enter the four-digit parental control code before allowing access to restricted content. Applications can use this same page to restrict access to content by calling the ParentalControls.PromptForPin method.
See Also
•	Developing Applications for Windows Media Center

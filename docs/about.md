# About the Windows Media Center SDK

The Microsoft Windows Media Center Software Development Kit (SDK) provides documentation and sample code that developers can use to create software that extends Windows Media Center in various ways. The SDK also enables developers to customize certain features that are included with Windows Media Center.

This section provides detailed information about the SDK. It consists of the following topics.

Topics|Description
---|---
[What's New](#whats-new)|Describes the changes to this SDK since the last release.
[Windows Media Center SDK Overview](#overview)|Describes the ways you can use the SDK to extend Windows Media Center and customize certain Windows Media Center features.
[History and Versions](#history-and-versions)|Describes the version history of the Windows Media Center SDK.

## <a name="whats-new"></a>What's New

Windows Media Center in Windows 7 provides an enhanced Windows Media Center application platform and support for hosting Windows Media Center Presentation Layer applications and services.  

The following list summarizes the changes that have been made to the Windows Media Center SDK.

### Data Access—Binding View Items to XML Web Data

* Data access model items facilitate binding to Resource Oriented Architecture (ROA) Web services most commonly associated with the Representational State Transfer (REST) style of Web development. RESTful web development is based on the fundamental building blocks of HTTP verbs (such as GET, PUT, and POST), headers, and entity documents. For more information, see Binding to XML Data From the Web and the Microsoft.MediaCenter.DataAccess namespace.

### Media Collections—Working with Dynamic Playlists

* New media collection objects provide a rich, dynamic representation of an audio or video playlist that can be manipulated by an application. These objects are tailored for content and ad delivery, and allow the application to manage play states that are related to that content. But they are also flexible for other scenarios such as interactive content. Buffering and metadata retrieval have also been improved. For more information, see Working with a Media Collection.

### Running a Single Instance of an Application

* Applications can now run as a single instance, rather than allowing multiple instances. For example, if the user tries to start the application a second time while another instance of the application is already running, Windows Media Center returns to the first instance of the application rather than starting another instance. For more information, see Ensuring the Application Has a Single Instance.

### Incorporating Standard Windows Media Center UI Features

* Applications can use the new onscreen keyboard that is included with Windows Media Center. This feature provides a consistent method of text entry for users, regardless of whether they are using Windows Media Center or a Windows Media Center application. For more information, see Displaying the Onscreen Keyboard.
* New background modes allow applications to achieve a true full-screen background. Applications can use the many built-in animated backgrounds, including full-screen video, which respects overscan. An additional benefit is the seamless transition from the application to a native Windows Media Center experience (such as the Start menu overlay with video in the background). For more information, see Creating Full Screen Video.
* The Zoom Mode button and its modes (normal, zoom, stretch, and panoramic) are now available when the user opens the More Information context menu for a full-screen video in an application.

### Improved Page Model, Page Navigation, and State Information

* Windows Media Center now includes a true page model that provides the ability for pages that were authored in MCML to persist their state and discern between navigation direction (forward or back in the page stack and history). Pages can also be omitted from the backstack. For more information, see Working with Page Sessions.
* Applications can now truly determine whether they are on the page stack. The ApplicationContext.IsCurrentlyVisible property indicates whether the application page is currently the active page that is being viewed by the user.

### Improved Application Installation

* Users can now install Windows Media Center applications using a remote control. For more information, see the ApplicationContext.InstallApplication method.
New Features for Media Center Markup Language (MCML)
* Resource groups are supported. A resource group can be used, for example, to pre-load images before displaying a page (see Working with Resource Groups).
* Relative paths are supported (see Relative Paths for MCML).
* Persistent and session cookies are supported (see Cookie Support).
* Switch animation has been added (see Using Switch Animation).
* More .NET Framework types are allowed (see Allowed Types for Web Applications).
* Exception handling has been added (see Using Exception Handling in Web Applications).

### Interactive TV

* The Interactive TV (iTV) Framework in Windows Media Center provides third parties the ability to develop Windows Media Center applications that combine traditional TV with interactivity similar to that of the Internet and personal computer. For more information, see Developing iTV Framework Applications and the iTV Reference.

### New API in the Managed Code Object Model

* AcquisitionStatus enumeration
* ApplicationSession class
* BackgroundModes enumeration
* ClosedReason enumeration
* ContinueOnErrorEventArgs class
* CreateFileListHelper class
* EditableDigits class
* EventArgs class
* ICreateFileListHelper interface
* IndexEventArgs class
* InitialListType enumeration
* InstallationOptions enumeration
* IQueryPlaybackCapabilities interface
* ListItemState enumeration
* MediaCollectionItemEventArgs class
* MediaCollectionItem class
* MediaCollection class
* MediaItemPlaybackCapabilities enumeration
* Page class
* PanelSession class
* RemoteResource class
* RemoteResourceStatus enumeration
* RemoteResourceUri class
* RemoteValueList class
* RemoteValue class
* ResourceGroup class
* SecureEditableText class
* SortableList class
* XmlRemoteResource class
* XmlRemoteValueList class
* XmlRemoteValue class

### New API in MCML

* Caught event
* ExceptionHandler element
* HandleException element
* NavigationDirection enumeration
* SecureTypingHandler element
* SwitchAnimation element
* TypingInputRejected event

### Changes to the Existing API

* AddInHost.ApplicationControlEnabled property
* AddInHost.MetadataAccessEnabled property
* ApplicationContext.InstallApplication method
* ApplicationContext.IsCurrentlyVisible property
* ApplicationContext.PropertyChanged event
* ApplicationContext.Relaunch event
* ApplicationContext.SingleInstance property
* HistoryOrientedPageSession.CurrentPage property
* MediaCenterEnvironment.BackgroundColor2 property
* MediaCenterEnvironment.BackgroundMode property
* MediaCenterEnvironment.CreateFileList method
* MediaCenterEnvironment.DirectXExclusive property
* MediaCenterEnvironment.MediaTypesFromOriginalList property
* MediaCenterEnvironment.ScreensaverEnabledHint property
* MediaCenterEnvironment.ShowOnscreenKeyboard method
* MediaExperience.GetMediaCollection method
* MediaTransport.BufferingProgress property
* ModelItem.RaiseEvent method
* PageSession.CreateUiHost method
* PageSession.OnNavigate method

### Deprecated APIs

* Hosted HTML

All new platform features for this release are in the Managed Code Object Model and the Windows Media Center Presentation Layer. While there are no new features for hosted HTML, it is still available for application compatibility. If you still want to develop a hosted HTML application or update an existing application, you can download and use the previous version of the Windows Media Center SDK from the Microsoft Download Center.

* Media State Aggregation Service
* Input Method Editor Module

Instead, developers can use the native onscreen keyboard in Windows Media Center that provides support for international text input.

## <a name="overview"></a>Windows Media Center SDK Overview

Microsoft Windows Media Center is a feature of certain SKUs of the Windows 7 operating system that includes enhanced capabilities for consolidating digital entertainment and media content and delivering it, on demand, to the user. Windows Media Center is a sophisticated application designed to provide easy access to the entertainment services and digital media content that are available through the Windows Media Center PC. It has a user interface that is easy to use from a distance and designed to be accessed primarily through a TV-style remote control.

Windows Media Center is extensible, meaning that you can create new applications and services that integrate with it, providing additional capabilities and experiences to the user. By using the Windows Media Center SDK, developers can do the following:

* Create a Windows Media Center Presentation Layer application, which is a Microsoft .NET Framework assembly. It extends the functionality of Windows Media Center by using the programming interfaces exposed by the Windows Media Center application object model, the .NET Framework's System namespace, and namespaces that are provided by external assemblies. For more information, see the Programming Guide.
* Use the click-to-record feature in Windows Media Center applications and external Windows applications. This programmatically directs Windows Media Center to schedule the recording of TV programs. For more information, see Scheduling Recorded TV with Click-To-Record.
See Also
* About the Windows Media Center SDK

## <a name="history-and-versions"></a>History and Versions

Each release of Windows Media Center builds upon features introduced in previous versions. Each release also has a corresponding software development kit (SDK). The current Windows Media Center SDK is designed for Windows Media Center version 9.0 in Windows 7.

The following chart summarizes the releases of Windows Media Center and the corresponding versions of the platform and development environment.

Media Center Version|Platform Version|.NET Framework Version|Development Model
---|---|---|---
6.0|Windows XP Media Center Edition 2004|NA|Hosted HTML application
7.0|Windows XP Media Center Edition 2005|1.0|Hosted HTML application<br>Media Center add-in
7.5|Update Rollup 2 for Windows XP Media Center Edition 2005|1.1|Hosted HTML application<br>Media Center add-in
8.0|Windows Vista Ultimate<br>Windows Vista Home Premium|2.0|Hosted HTML application<br>Windows Media Center Presentation Layer application
8.1|Windows Media Center TV Pack for Windows Vista|2.0|Hosted HTML application<br>Windows Media Center Presentation Layer application
9.0|Windows 7|2.0|Windows Media Center Presentation Layer application

Note: In the Windows Media Center Presentation Layer, the Windows Media Center version corresponds to the MediaCenterEnvironment.Version property.

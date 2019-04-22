MCESDK_Ref01.doc

# Programming Reference
This section contains reference information for all of the application programming interfaces (APIs) exposed by Windows Media Center. For more information, see the following topics:
Topic	Description
Managed Code Object Model Reference
Describes the Windows Media Center object model that is used by Windows Media Center Presentation Layer applications.
Media Center Markup Language Reference
Describes the Extensible Markup Language (XML) elements for the Media Center Markup Language (MCML) used to work with the Windows Media Center Presentation Layer.
Click-To-Record XML Reference
Describes the XML elements used to specify TV programs for Windows Media Center to record.
Entry Point Registration XML Reference
Describes the XML elements for registering Windows Media Center applications using the RegisterMCEApp.exe command-line tool and the ApplicationContext.RegisterApplication method.

iTV Reference
Describes the managed and unmanaged API for creating Interactive TV (iTV) applications.
Hosted HTML Object Model Reference
Describes the Windows Media Center object model that is used by hosted HTML applications.
Note   This API has been deprecated.
Input Method Editor Module Reference
Describes the object model used by the input method editor (IME) module.
Note   This API has been deprecated.
Media State Aggregation Service Reference
Describes the object model used by the media state aggregation service (MSAS).
Note   This API has been deprecated.

See Also
•	About the Windows Media Center SDK
•	Programming Guide

# Managed Code Object Model Reference
Windows Media Center Presentation Layer applications use the API elements exposed by the Windows Media Center object model to access Windows Media Center settings, control various aspects of the Windows Media Center experience, and extend the capabilities of Windows Media Center.
The object model consists of the following namespaces:
•	Microsoft.MediaCenter
•	Microsoft.MediaCenter.Hosting
•	Microsoft.MediaCenter.ListMaker
•	Microsoft.MediaCenter.TV.Epg
•	Microsoft.MediaCenter.TV.Scheduling
•	Microsoft.MediaCenter.UI
Windows Media Center Presentation Layer applications also have access to the Microsoft .NET Framework's System namespace, and to namespaces provided by external assemblies.
Note   With a few exceptions, the Windows Media Center object model is not accessible from a Windows service or any other process other than those started by Windows Media Center.
This reference describes all of the programming elements that make up the Windows Media Center object model. For more information, see the following sections:
Section	Description
Microsoft.MediaCenter Namespace
Describes the API elements exposed by the Microsoft.MediaCenter namespace.
Microsoft.MediaCenter.DataAccess Namespace
Describes the API elements exposed by the Microsoft.MediaCenter.DataAccess namespace.
Microsoft.MediaCenter.Hosting Namespace
Describes the API elements exposed by the Microsoft.MediaCenter.Hosting namespace.
Microsoft.MediaCenter.ListMaker Namespace
Describes the API elements exposed by the Microsoft.MediaCenter.ListMaker namespace.
Microsoft.MediaCenter.TV.Epg Namespace
Describes the API elements exposed by the Microsoft.MediaCenter.TV.Epg namespace.
Microsoft.MediaCenter.TV.Scheduling Namespace
Describes the API elements exposed by the Microsoft.MediaCenter.TV.Scheduling namespace.
Microsoft.MediaCenter.UI Namespace
Describes the API elements exposed by the Microsoft.MediaCenter.UI namespace.

See Also
•	Programming Guide

# Microsoft.MediaCenter Namespace
The following types are in the Microsoft.MediaCenter namespace, which is in the microsoft.mediacenter.dll assembly.
The Microsoft.MediaCenter namespace exposes the following classes:
Class	Description
ApplicationAccessDisabledException
Contains information about an exception that was raised because an application tried to access Windows Media Center properties, but the user has chosen to block access to the properties.
ApplicationAlreadyRegisteredException
Contains information about an exception that was raised when trying to register because an application was already registered.
ApplicationControlDisabledException
Contains information about an exception that was raised because an application tried to control some aspect of Windows Media Center, but the user has chosen to block applications from controlling Windows Media Center.
ApplicationNoPermissionException
Contains information about an exception that was raised because the user does not have permission to register the application for All Users.
ApplicationNotForegroundException
Contains information about an exception that was raised because an HTML page called a Windows Media Center API element at an inappropriate time.
ApplicationNotRegisteredException
Contains information about an exception that was raised when trying to unregister an application that is not registered.
ApplicationRegistrationCancelledException
Contains information about an exception that was raised because the user has denied the request to register the application.
AudioMixer
Enables applications to control the Windows Media Center mute state and volume level.
BroadcastService
Provides access to information about a TV broadcast service.
ContinueOnErrorEventArgs
Indicates whether to proceed to the next media item in a media collection if a playback error occurs.
DiscData
Enables applications to get information about a disc in a changer.
FeatureNotConfiguredException
Contains information about an exception that was raised because the application is trying to work with a Windows Media Center experience such as TV, but that experience is not configured.
IndexEventArgs
Not documented in this release.
MediaCenterEnvironment
Enables applications to get device information, gain access to disc changers, and control various aspects of Windows Media Center. Provides information about Windows Media Center, including its current capabilities and version number.
MediaChanger
Enables applications to control the disc changer.
MediaChangerException
Contains information about an exception that was raised because a media changer operation failed.
MediaCollection
A collection of media items that make up a playlist (media collection).
MediaCollectionItem
Used to add an audio or video item to the media collection and specify properties for playback.
MediaCollectionItemEventArgs
Contains information about events that are raised for items in a media collection.
MediaExperience
Enables applications to retrieve information about the current Windows Media Center experience.
MediaMetadata
Provides an index into the media metadata properties that have been defined.
MediaTransport
Enables applications to control playback of the current content.
MetadataAccessDisabledException
Contains information about an exception that was raised because an application tried to access Windows Media Center metadata, but the user has chosen to block access to metadata.
ParentalControls
Enables applications to select the type of parental control settings to query.
ParentalControlSetting
Enables applications to query the various parental control settings for movie or TV viewing.
StateDetectionDisabledException
Contains information about an exception that was raised because an application tried to access Windows Media Center state information, but the user has chosen to block access to state information.
UserInfo
Gets the user's postal code, if available.
USTVRatings
Enables applications to query the extended TV content ratings.

The Microsoft.MediaCenter namespace exposes the following interface:
Interface	Description
IQueryPlaybackCapabilities
Gets values that indicate the playback capabilities for media.

The Microsoft.MediaCenter namespace exposes the following enumeration types:
Enumeration type	Description
BackgroundModes
Contains values that indicate the type of background to display when audio or video is playing.
DialogButtons
Contains values that identify the buttons that can be used in a dialog box.
DialogResult
Contains values that indicate how a dialog box was dismissed.
DiscType
Contains values that identify the type of disc in a changer.
MediaItemPlaybackCapabilities
Contains bitflag values that indicate which actions are allowed during playback.
MediaType
Contains values that identify the type of media that is currently playing.
PageId
Contains the identifiers (GUIDs) of important locations within the Windows Media Center user interface.
PlayState
Contains values that indicate the play state of the current media.
ShortcutStatus
Contains values that indicate the user's response to the dialog box created by the CreateDesktopShortcut method.


The Microsoft.MediaCenter namespace exposes the following delegates:
Delegate	Description
DialogClosedCallback
Specifies the method that is invoked when a Windows Media Center dialog box is closed.
ParentalPromptCompletedCallback
Represents the method that handles the result of calling the ParentalControls.PromptForPin method, indicating whether the user entered the correct parental control code.

See Also
•	Managed Code Object Model Reference

# ApplicationAccessDisabledException Class
Contains information about an exception that was raised because an application tried to access Windows Media Center properties, but the user has chosen to block access to the properties.
Syntax
public class ApplicationAccessDisabledException : System.InvalidOperationException

Public Instance Constructors
Constructor	Description
ApplicationAccessDisabledException()	Initializes an instance of the ApplicationAccessDisabledException class.
ApplicationAccessDisabledException(string)	Initializes an instance of the ApplicationAccessDisabledException class.
ApplicationAccessDisabledException(string, Exception)	Initializes an instance of the ApplicationAccessDisabledException class.

Protected Instance Constructors
Constructor	Description
ApplicationAccessDisabledException(SerializationInfo, StreamingContext)	Initializes an instance of the ApplicationAccessDisabledException class.

See Also
•	Managed Code Object Model Reference
# ApplicationAccessDisabledException.ApplicationAccessDisabledException Constructor
Initializes an instance of the ApplicationAccessDisabledException class.
Overload List
public ApplicationAccessDisabledException();

public ApplicationAccessDisabledException(string)

public ApplicationAccessDisabledException(string, Exception)

protected ApplicationAccessDisabledException(SerializationInfo, StreamingContext)

# ApplicationAccessDisabledException.ApplicationAccessDisabledException Constructor
Initializes an instance of the ApplicationAccessDisabledException class.
Syntax
public ApplicationAccessDisabledException();

# ApplicationAccessDisabledException.ApplicationAccessDisabledException Constructor
Initializes an instance of the ApplicationAccessDisabledException class.
Syntax
public ApplicationAccessDisabledException(
   string message
);
Parameters
message
System.String. A description of the exception.
# ApplicationAccessDisabledException.ApplicationAccessDisabledException Constructor
Initializes an instance of the ApplicationAccessDisabledException class.
Syntax
public ApplicationAccessDisabledException(
   string message,
   Exception inner
);
Parameters
message
System.String. A description of the exception.
inner
System.Exception. The object on which this exception is based.
# ApplicationAccessDisabledException.ApplicationAccessDisabledException Constructor
Initializes an instance of the ApplicationAccessDisabledException class.
Syntax
protected ApplicationAccessDisabledException(
   SerializationInfo info,
   StreamingContext context
);
Parameters
info
System.Runtime.Serialization.SerializationInfo. An instance of the class containing the information needed to serialize the new ApplicationAccessDisabledException instance.
context
System.Runtime.Serialization.StreamingContext. A structure that contains contextual information about the source of the serialized stream associated with the new ApplicationAccessDisabledException instance.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ApplicationAccessDisabledException Class

# ApplicationAlreadyRegisteredException Class
Contains information about an exception that was raised when trying to register because an application was already registered. You cannot add an entry point to an application that is already registered; unregister the application, and then you can re-register the application.
Syntax
public class ApplicationAlreadyRegisteredException : System.InvalidOperationException

Public Instance Constructors
Constructor	Description
ApplicationAlreadyRegisteredException()
Initializes an instance of the ApplicationAlreadyRegisteredException class.
ApplicationAlreadyRegisteredException(string)
Initializes an instance of the ApplicationAlreadyRegisteredException class.
ApplicationAlreadyRegisteredException(string, Exception)
Initializes an instance of the ApplicationAlreadyRegisteredException class.

Protected Instance Constructors
Constructor	Description
ApplicationAlreadyRegisteredException(SerializationInfo, StreamingContext)
Initializes an instance of the ApplicationAlreadyRegisteredException class.

See Also
•	Managed Code Object Model Reference

# ApplicationAlreadyRegisteredException.ApplicationAlreadyRegisteredException Constructor
Initializes an instance of the ApplicationAlreadyRegisteredException class.
Overload List
public ApplicationAlreadyRegisteredException()

public ApplicationAlreadyRegisteredException(string)

public ApplicationAlreadyRegisteredException(string, Exception)

protected ApplicationAlreadyRegisteredException(SerializationInfo, StreamingContext)

# ApplicationAlreadyRegisteredException Constructor
Initializes an instance of the ApplicationAlreadyRegisteredException class.
Syntax
public ApplicationAlreadyRegisteredException();

# ApplicationAlreadyRegisteredException Constructor
Initializes an instance of the ApplicationAlreadyRegisteredException class.
Syntax
public ApplicationAlreadyRegisteredException(
   string message
);

Parameters
message
System.String. A description of the exception.
# ApplicationAlreadyRegisteredException Constructor
Initializes an instance of the ApplicationAlreadyRegisteredException class.
Syntax
public ApplicationAlreadyRegisteredException(
   string message,
   Exception inner
);
Parameters
message
System.String. A description of the exception.
inner
System.Exception. The class on which this exception is based.
# ApplicationAlreadyRegisteredException Constructor
Initializes an instance of the ApplicationAlreadyRegisteredException class.
Syntax
protected ApplicationAlreadyRegisteredException(
   SerializationInfo info,
   StreamingContext context
);
Parameters
info
System.Runtime.Serialization.SerializationInfo. An instance of the class containing the information needed to serialize the new ApplicationAlreadyRegisteredException instance.
context
System.Runtime.Serialization.StreamingContext. A structure that contains contextual information about the source of the serialized stream associated with the new ApplicationAlreadyRegisteredException instance.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ApplicationAlreadyRegisteredException Class

# ApplicationControlDisabledException Class
Contains information about an exception that was raised because an application tried to control some aspect of Windows Media Center, but the user has chosen to block applications from controlling Windows Media Center.
Syntax
public class ApplicationControlDisabledException : System.InvalidOperationException

Public Instance Constructors
Constructor	Description
ApplicationControlDisabledException()
Initializes an instance of the ApplicationControlDisabledException class.
ApplicationControlDisabledException(string)
Initializes an instance of the ApplicationControlDisabledException class.
ApplicationControlDisabledException(string, Exception)
Initializes an instance of the ApplicationControlDisabledException class.

Protected Instance Constructors
Constructor	Description
ApplicationControlDisabledException(SerializationInfo, StreamingContext)	Initializes an instance of the ApplicationControlDisabledException class.

See Also
•	Managed Code Object Model Reference

# ApplicationControlDisabledException.ApplicationControlDisabledException Constructor
Initializes an instance of the ApplicationControlDisabledException class.
Overload List
public ApplicationControlDisabledException()

public ApplicationControlDisabledException(string)

public ApplicationControlDisabledException(string, Exception)

protected ApplicationControlDisabledException(SerializationInfo, StreamingContext)

# ApplicationControlDisabledException.ApplicationControlDisabledException Constructor
Initializes an instance of the ApplicationControlDisabledException class.
Syntax
public ApplicationControlDisabledException();

# ApplicationControlDisabledException.ApplicationControlDisabledException Constructor
Initializes an instance of the ApplicationControlDisabledException class.
Syntax
public ApplicationControlDisabledException(
   string message
);
Parameters
message
System.String. A description of the exception.
# ApplicationControlDisabledException.ApplicationControlDisabledException Constructor
Initializes an instance of the ApplicationControlDisabledException class.
Syntax
public ApplicationControlDisabledException(
   string message,
   Exception inner
);
Parameters
message
System.String. A description of the exception.
inner
System.Exception. The class on which this exception is based.
# ApplicationControlDisabledException.ApplicationControlDisabledException Constructor
Initializes an instance of the ApplicationControlDisabledException class.
Syntax
protected ApplicationControlDisabledException(
   SerializationInfo info,
   StreamingContext context
);
Parameters
info
System.Runtime.Serialization.SerializationInfo. An instance of the class containing the information needed to serialize the new ApplicationControlDisabledException instance.
context
System.Runtime.Serialization.StreamingContext. A structure that contains contextual information about the source of the serialized stream associated with the new ApplicationControlDisabledException instance.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ApplicationControlDisabledException Class

# ApplicationNoPermissionException Class
Contains information about an exception that was raised because the user does not have permission to register the application for All Users.
Syntax
public class ApplicationNoPermissionException : System.InvalidOperationException

Public Instance Constructors
Constructor	Description
ApplicationNoPermissionException()
Initializes an instance of the ApplicationNoPermissionException class.
ApplicationNoPermissionException(string)	Initializes an instance of the ApplicationNoPermissionException class.
ApplicationNoPermissionException(string, Exception)	Initializes an instance of the ApplicationNoPermissionException class.

Protected Instance Constructors
Constructor	Description
ApplicationNoPermissionException(SerializationInfo, StreamingContext)	Initializes an instance of the ApplicationNoPermissionException class.

See Also
•	Managed Code Object Model Reference

# ApplicationNoPermissionException.ApplicationNoPermissionException Constructor
Initializes an instance of the ApplicationNoPermissionException class.
Overload List
public ApplicationNoPermissionException()

public ApplicationNoPermissionException(string)

public ApplicationNoPermissionException(string, Exception)

protected ApplicationNoPermissionException(SerializationInfo, StreamingContext)

# ApplicationNoPermissionException Constructor
Initializes an instance of the ApplicationNoPermissionException class.
Syntax
public ApplicationNoPermissionException();

# ApplicationNoPermissionException Constructor
Initializes an instance of the ApplicationNoPermissionException class.
Syntax
public ApplicationNoPermissionException(
   string message
);
Parameters
message
System.String. A description of the exception.
# ApplicationNoPermissionException Constructor
Initializes an instance of the ApplicationNoPermissionException class.
Syntax
public ApplicationNoPermissionException(
   string message,
   Exception inner
);
Parameters
message
System.String. A description of the exception.
inner
System.Exception. The class on which this exception is based.
# ApplicationNoPermissionException Constructor
Initializes an instance of the ApplicationNoPermissionException class.
Syntax
protected ApplicationNoPermissionException(
   SerializationInfo info,
   StreamingContext context
);
Parameters
info
System.Runtime.Serialization.SerializationInfo. An instance of the class containing the information needed to serialize the new ApplicationNoPermissionException instance.
context
System.Runtime.Serialization.StreamingContext. A structure that contains contextual information about the source of the serialized stream associated with the new ApplicationNoPermissionException instance.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ApplicationNoPermissionException Class

# ApplicationNotForegroundException Class
Contains information about an exception that was raised because an HTML page called a Windows Media Center API element at an inappropriate time. By throwing this exception, Windows Media Center ensures that only the page that starts playing media content can affect the media experience after the user has left the page.
Syntax
public class ApplicationNotForegroundException : System.InvalidOperationException

Public Instance Constructors
Constructor	Description
ApplicationNotForegroundException()	Initializes an instance of the ApplicationNotForegroundException class.
ApplicationNotForegroundException(string)	Initializes an instance of the ApplicationNotForegroundException class.
ApplicationNotForegroundException(string, Exception)	Initializes an instance of the ApplicationNotForegroundException class.

Protected Instance Constructors
Constructor	Description
ApplicationNotForegroundException(SerializationInfo, StreamingContext)	Initializes an instance of the ApplicationNotForegroundException class.

Remarks
An HTML page can call Windows Media Center API elements only when one or both of the following conditions are true:
•	The HTML page is currently being displayed in Windows Media Center.
•	The HTML page invoked the currently playing media content, even if the user is watching full-screen video or used the Windows Media Center (green) button on the remote control to navigate away from the HTML application.
See Also
•	Managed Code Object Model Reference

# ApplicationNotForegroundException.ApplicationNotForegroundException Constructor
Initializes an instance of the ApplicationNotForegroundException class.
Overload List
public ApplicationNotForegroundException()

public ApplicationNotForegroundException(string)

public ApplicationNotForegroundException(string, Exception)

protected ApplicationNotForegroundException(SerializationInfo, StreamingContext)

# ApplicationNotForegroundException.ApplicationNotForegroundException Constructor
Initializes an instance of the ApplicationNotForegroundException class.
Syntax
public ApplicationNotForegroundException();

# ApplicationNotForegroundException.ApplicationNotForegroundException Constructor
Initializes an instance of the ApplicationNotForegroundException class.
Syntax
public ApplicationNotForegroundException(
   string message
);
Parameters
message
System.String.  A description of the exception.
# ApplicationNotForegroundException.ApplicationNotForegroundException Constructor
Initializes an instance of the ApplicationNotForegroundException class.
Syntax
public ApplicationNotForegroundException(
   string message,
   Exception inner
);
Parameters
message
System.String.  A description of the exception.
inner
System.Exception.  The class on which this exception is based.
# ApplicationNotForegroundException.ApplicationNotForegroundException Constructor
Initializes an instance of the ApplicationNotForegroundException class.
Syntax
protected ApplicationNotForegroundException(
   SerializationInfo info,
   StreamingContext context
);
Parameters
info
System.Runtime.Serialization.SerializationInfo.  An instance of the class containing the information needed to serialize the new ApplicationNotForegroundException instance.
context
System.Runtime.Serialization.StreamingContext.  A structure that contains contextual information about the source of the serialized stream associated with the new ApplicationNotForegroundException instance.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ApplicationNotForegroundException Class

# ApplicationNotRegisteredException Class
Contains information about an exception that was raised when trying to unregister an application that is not registered.
Syntax
public class ApplicationNotRegisteredException : System.InvalidOperationException

Public Instance Constructors
Constructor	Description
ApplicationNotRegisteredException()
Initializes an instance of the ApplicationNotRegisteredException class.
ApplicationNotRegisteredException(string)	Initializes an instance of the ApplicationNotRegisteredException class.
ApplicationNotRegisteredException(string, Exception)	Initializes an instance of the ApplicationNotRegisteredException class.

Protected Instance Constructors
Constructor	Description
ApplicationNotRegisteredException(SerializationInfo, StreamingContext)	Initializes an instance of the ApplicationNotRegisteredException class.

See Also
•	Managed Code Object Model Reference

# ApplicationNotRegisteredException.ApplicationNotRegisteredException Constructor
Initializes an instance of the ApplicationNotRegisteredException class.
Overload List
public ApplicationNotRegisteredException()

public ApplicationNotRegisteredException(string)

public ApplicationNotRegisteredException(string, Exception)

protected ApplicationNotRegisteredException(SerializationInfo, StreamingContext)

# ApplicationNotRegisteredException Constructor
Initializes an instance of the ApplicationNotRegisteredException class.
Syntax
public ApplicationNotRegisteredException();

# ApplicationNotRegisteredException Constructor
Initializes an instance of the ApplicationNotRegisteredException class.
Syntax
public ApplicationNotRegisteredException(
   string message
);
Parameters
message
System.String. A description of the exception.
# ApplicationNotRegisteredException Constructor
Initializes an instance of the ApplicationNotRegisteredException class.
Syntax
public ApplicationNotRegisteredException(
   string message,
   Exception inner
);
Parameters
message
System.String. A description of the exception.
inner
System.Exception. The class on which this exception is based.
# ApplicationNotRegisteredException Constructor
Initializes an instance of the ApplicationNotRegisteredException class.
Syntax
protected ApplicationNotRegisteredException(
   SerializationInfo info,
   StreamingContext context
);
Parameters
info
System.Runtime.Serialization.SerializationInfo. An instance of the class containing the information needed to serialize the new ApplicationNotRegisteredException instance.
context
System.Runtime.Serialization.StreamingContext. A structure that contains contextual information about the source of the serialized stream associated with the new ApplicationNotRegisteredException instance.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ApplicationNotRegisteredException Class

# ApplicationRegistrationCancelledException Class
Contains information about an exception that was raised because the user has denied the request to register the application.
Syntax
public class ApplicationRegistrationCancelledException : System.InvalidOperationException

Public Instance Constructors
Constructor	Description
ApplicationRegistrationCancelledException()
Initializes an instance of the ApplicationRegistrationCancelledException class.
ApplicationRegistrationCancelledException(string)
Initializes an instance of the ApplicationRegistrationCancelledException class.
ApplicationRegistrationCancelledException(string, Exception)
Initializes an instance of the ApplicationRegistrationCancelledException class.

Protected Instance Constructors
Constructor	Description
ApplicationRegistrationCancelledException(SerializationInfo, StreamingContext)	Initializes an instance of the ApplicationRegistrationCancelledException class.

See Also
•	Managed Code Object Model Reference

# ApplicationRegistrationCancelledException.ApplicationRegistrationCancelledException Constructor
Initializes an instance of the ApplicationRegistrationCancelledException class.
Overload List
public ApplicationRegistrationCancelledException()

public ApplicationRegistrationCancelledException(string)

public ApplicationRegistrationCancelledException(string, Exception)

protected ApplicationRegistrationCancelledException(SerializationInfo, StreamingContext)

# ApplicationRegistrationCancelledException Constructor
Initializes an instance of the ApplicationRegistrationCancelledException class.
Syntax
public ApplicationRegistrationCancelledException();

# ApplicationRegistrationCancelledException Constructor
Initializes an instance of the ApplicationRegistrationCancelledException class.
Syntax
public ApplicationRegistrationCancelledException(
   string message
);
Parameters
message
System.String. A description of the exception.
# ApplicationRegistrationCancelledException Constructor
Initializes an instance of the ApplicationRegistrationCancelledException class.
Syntax
public ApplicationRegistrationCancelledException(
   string message,
   Exception inner
);
Parameters
message
System.String. A description of the exception.
inner
System.Exception. The class on which this exception is based.
# ApplicationRegistrationCancelledException Constructor
Initializes an instance of the ApplicationRegistrationCancelledException class.
Syntax
protected ApplicationRegistrationCancelledException(
   SerializationInfo info,
   StreamingContext context
);
Parameters
info
System.Runtime.Serialization.SerializationInfo. An instance of the class containing the information needed to serialize the new ApplicationRegistrationCancelledException instance.
context
System.Runtime.Serialization.StreamingContext. A structure that contains contextual information about the source of the serialized stream associated with the new ApplicationRegistrationCancelledException instance.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ApplicationRegistrationCancelledException Class

# AudioMixer Class
Enables applications to control the Windows Media Center mute state and volume level. To retrieve this class, use the MediaCenterEnvironment.AudioMixer property.
Syntax
public sealed class AudioMixer : Microsoft.MediaCenter.UI.IPropertyObject

Public Instance Methods
Method	Description
VolumeDown
Decreases the current volume level.
VolumeUp
Increases the current volume level.

Public Instance Properties
Property	Description
Mute
Gets or sets the current mute state.
Volume
Gets the current volume level.

Public Instance Events
Event	Description
PropertyChanged
Raised when the Mute or Volume properties change.

See Also
•	Microsoft.MediaCenter Namespace

# AudioMixer.Mute Property
Gets or sets the current mute state.
Syntax
public Boolean Mute {get; set;}

Property Value
System.Boolean  It is true if mute is on, and false if it is off.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	AudioMixer Class

# AudioMixer.PropertyChanged Event
Raised when the Mute or Volume properties change.
Syntax
public override Microsoft.MediaCenter.UI.PropertyChangedEventHandler PropertyChanged;

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	AudioMixer Class
•	Microsoft.MediaCenter Namespace

# AudioMixer.Volume Property
Gets the current volume level.
Syntax
public int Volume {get;}

Property Value
System.Int32  A value ranging from 0 (softest) to 65,535 (loudest).
This property is read-only.
Remarks
An application can change the volume level by following these steps:
1.	Retrieve the current level from the Volume property.
2.	Call the AudioMixer.VolumeUp or AudioMixer.VolumeDown method to raise or lower the volume.
3.	Check the Volume property. If the current volume level is not equal to the desired level, repeat step 2. Otherwise, end the procedure.
An application should use the same procedure to restore the user's previous volume level.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	AudioMixer Class
•	AudioMixer.VolumeDown Method
•	AudioMixer.VolumeUp Method

# AudioMixer.VolumeDown Method
Decreases the current volume level.
Syntax
public void VolumeDown();

Parameters
This method takes no parameters.
Return Value
This method does not return a value.
Remarks
For more information about setting the current volume level, see the Remarks for the AudioMixer.Volume method.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	AudioMixer Class
•	AudioMixer.VolumeUp Method
•
# AudioMixer.VolumeUp Method
Increases the current volume level.
Syntax
public void VolumeUp();

Parameters
This method takes no parameters.
Return Value
This method does not return a value.
Remarks
For more information about setting the current volume level, see the Remarks for the AudioMixer.Volume property.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	AudioMixer Class
•	AudioMixer.VolumeDown Method

# BackgroundModes Enumeration
Contains values that indicate the type of background to display when audio or video is playing.
public enum BackgroundModes

Members
Value	Description
AlbumArtMosaic	While a song is playing, displays an animated mosaic of the album art from the Music library.
Animated	Not documented in this release.
Audio	Plays an audio file.
AudioAnimated	While a song is playing, displays the standard animated sine wave background.
Color
Displays a specified color (as specified in MediaCenterEnvironment.BackgroundColor2).

Complex	Not documented in this release.
CustomMaskedVideo	Not documented in this release.
HeavyMask	Not documented in this release.
HeavyMaskedVideo	Displays the video as a background watermark, where the video fills the upper quarter of the screen and the lower portion displays the standard image.
Image	Displays a specified image.
LightMask	Not documented in this release.
LightMaskedAlbumArtMosaic	Displays the album art mosaic as a background watermark, where the mosaic fills the screen.
LightMaskedVideo	Displays the video as a background watermark, where the video fills the screen.
None	Displays no background (a black colorfill).
Standard	Not documented in this release.
StandardAnimated	Displays the standard animated blue background video used throughout Windows Media Center. If the computer's graphics card renderer does not support animation, StandardImage mode is used.
StandardImage	Displays the standard static blue background image used throughout Windows Media Center.
Video	Displays the current video as full screen.

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter Namespace


# BroadcastService Class
Provides access to information about a TV broadcast service.
Syntax
public class BroadcastService

Public Instance Properties
Property	Description
ServiceID
Gets the service ID of a TV broadcast service.

See Also
•	Managed Code Object Model Reference

# BroadcastService.ServiceID Property
Gets the service ID of a TV broadcast service.
Syntax
public string ServiceID {get;}

Property Value
System.String.  The service ID.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	BroadcastService Class

# ContinueOnErrorEventArgs Class
Indicates whether to proceed to the next media item in a media collection if a playback error occurs.
public sealed class ContinueOnErrorEventArgs : EventArgs

Members
Public Instance Constructor
Method	Description
ContinueOnErrorEventArgs
Initializes a new instance of the ContinueOnErrorEventArgs class.

Public Instance Properties
Property	Description
ContinueOnError
Gets a value that indicates whether to proceed to the next media item in the collection if a playback error occurs.

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter Namespace

# ContinueOnErrorEventArgs Constructor
Initializes a new instance of the ContinueOnErrorEventArgs class.
Syntax
public ContinueOnErrorEventArgs(
  bool  continueOnError
);

Parameters
continueOnError
System.Boolean.  Indicates whether to proceed to the next media item in the collection if a playback error occurs.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	ContinueOnErrorEventArgs Class
•	Microsoft.MediaCenter Namespace

# ContinueOnErrorEventArgs.ContinueOnError Property
Gets a value that indicates whether to proceed to the next media item in the collection if a playback error occurs.
Syntax
public bool ContinueOnError {get;}

Property Value
System.Boolean.  If true, advances to the next item in the media collection if a playback occurs; otherwise, false.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	ContinueOnErrorEventArgs Class
•	Microsoft.MediaCenter Namespace

# DialogButtons Enumeration
Specifies the buttons to place on a dialog box.
Syntax
public enum DialogButtons

The DialogButtons enumeration defines the following constants:
Constant	Description
Cancel	Cancel button.
No	No button.
None	No buttons.
Ok	OK button.
Yes	Yes button.

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Managed Code Object Model Reference

# DialogClosedCallback Delegate
Specifies the method that is invoked when a Windows Media Center dialog box is closed.
Syntax
public delegate void DialogClosedCallback(
  DialogResult  dialogResult
);

Parameters
dialogResult
Microsoft.MediaCenter.DialogResult.  A member of the DialogResult enumeration that indicates how the dialog box was dismissed.
Remarks
You can use custom buttons in a dialog box. Windows Media Center assigns integer values to custom buttons; the first custom button has a value of 100, the second has a value of 101, and so on. When the user clicks a custom button, the event handler receives an integer value greater than or equal to 100, and the parameter to your callback will be an invalid DialogResult value. To determine which button was pressed, cast the parameter value to int.
Return Value
This method does not return a value.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter Namespace

# DialogResult Enumeration
Contains values that identify the way in which the dialog box was closed.
Syntax
public enum DialogResult

The DialogResult enumeration defines the following constants:
Constant	Description
Active	The dialog box is active (for modeless dialog boxes).
Cancel	The Cancel button was selected.
Closed	The dialog box was closed (for modeless dialog boxes).
No	The No button was selected.
Ok	The OK button was selected.
Timeout	The dialog box timed out.
Yes	The Yes button was selected.

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Managed Code Object Model Reference

# DiscData Class
Enables applications to retrieve information about a disc in a disc changer.
Syntax
public class DiscData

Public Instance Properties
Property		Description
Address
Gets the index of the changer slot that holds the disc.
DiscId
Gets the disc identifier.
DiscType
Gets the disc type.
DrivePath
Gets the path to the disc drive.
MediaMetadata
Gets properties describing the disc.
VolumeLabel
Gets the volume label of the disc.

See Also
•	Microsoft.MediaCenter Namespace

# DiscData.Address Property
Gets the index of the changer slot that holds the disc.
Syntax
public int Address {get;}

Property Value
System.Int32  The zero-based index of the changer slot.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	DiscData Class

# DiscData.DiscId Property
Gets the disc identifier.
Syntax
public string DiscId {get;}

Property Value
System.String  The disc identifier. For DVDs, this is a string representation of the 64-bit checksum value. For CDs, it is a table of contents. For all other types, it is an empty string.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	DiscData Class

# DiscData.DiscType Property
Gets the disc type.
Syntax
public DiscType DiscId {get;}

Property Value
Microsoft.MediaCenter.DiscType. Identifier of the disc type, such as audio CD or movie DVD.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	DiscData Class

# DiscData.DrivePath Property
Gets the path to the disc drive.
Syntax
public string DrivePath {get;}

Property Value
System.String  Path to the disc drive.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
Remarks
This property is valid only for the MediaChanger.GetDriveDiscData method.
See Also
•	DiscData Class

# DiscData.MediaMetadata Property
Gets properties describing the disc.
Syntax
public MediaMetadata MediaMetadata {get;}

Property Value
Microsoft.MediaCenter.MediaMetadata   A collection of string values describing the disc.
This property is read-only.
Remarks
Different properties are supported for different types of discs. The following disc types will expose, at minimum, the following properties (other properties might also be exposed):
MovieDVD
•	Director
•	Title
•	ReleaseDate
•	MPAARating
•	Duration
AudioCD
•	AlbumArtist
•	AlbumTitle
•	Genre
•	Label
•	ReleaseDate
Other disc types can expose other properties.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	DiscData Class

# DiscData.VolumeLabel Property
Gets the volume label of the disc.
Syntax
public string VolumeLabel {get;}

Property Value
System.String  The volume label.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	DiscData Class

# DiscType Enumeration
Contains values that identify the types of discs in a disc changer.
Syntax
public enum DiscType

The DiscType enumeration defines the following constants:
Constant	Description
AudioCD	Audio CD
BlankCD	Blank CD
BlankDvd	Blank DVD
DataCD	Data (non-media) CD
DataDvd	Data (non-media) DVD
Empty	No disc
Error	Error
MovieDvd	Movie DVD
Unknown	Unknown disc type
Vcd	Video CD
Svcd	Super VideoCD
WmvHD	Microsoft Windows Media High Definition Video DVD disc

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	DiscData.DiscType Property
•	Microsoft.MediaCenter Namespace

# FeatureNotConfiguredException Class
Contains information about an exception that was raised because the application is trying to work with a Windows Media Center experience such as TV, but that experience is not configured. For example, the application tried to navigate to the Electronic Program Guide.
Syntax
public class FeatureNotConfiguredException : InvalidOperationException

Public Instance Constructors
Constructor	Description
FeatureNotConfiguredException()
Initializes an instance of the FeatureNotConfiguredException class.
FeatureNotConfiguredException(string)	Initializes an instance of the FeatureNotConfiguredException class.
FeatureNotConfiguredException(string, Exception)	Initializes an instance of the FeatureNotConfiguredException class.

Protected Instance Constructors
Constructor	Description
FeatureNotConfiguredException(SerializationInfo, StreamingContext)	Initializes an instance of the FeatureNotConfiguredException class.

See Also
•	Microsoft.MediaCenter Namespace

# FeatureNotConfiguredException Constructor
Initializes an instance of the FeatureNotConfiguredException class.
Overload List
public FeatureNotConfiguredException()

public FeatureNotConfiguredException(string)

public FeatureNotConfiguredException(string, Exception)

protected FeatureNotConfiguredException(SerializationInfo, StreamingContext)


# FeatureNotConfiguredException.FeatureNotConfiguredException Constructor
Initializes an instance of the FeatureNotConfiguredException class.
Syntax
public FeatureNotConfiguredException();
# FeatureNotConfiguredException.FeatureNotConfiguredException Constructor
Initializes an instance of the FeatureNotConfiguredException class.
Syntax
public FeatureNotConfiguredException( string
   message
);
Parameters
message
System.String.  A description of the exception.
# FeatureNotConfiguredException.FeatureNotConfiguredException Constructor
Initializes an instance of the FeatureNotConfiguredException class.
Syntax
public FeatureNotConfiguredException(
   string  message
   Exception innerException
);

Parameters
message
System.String.  A description of the exception.
innerException
System.Exception.  The class on which this exception is based.
# FeatureNotConfiguredException.FeatureNotConfiguredException Constructor
Initializes an instance of the FeatureNotConfiguredException class.
Syntax
protected FeatureNotConfiguredException(
   System.Runtime.Serialization.SerializationInfo  info,
   System.Runtime.Serialization.StreamingContext  context);
);
Parameters
info
System.Runtime.Serialization.SerializationInfo.  An instance of the class that contains the information that is needed to serialize the new FeatureNotConfiguredException instance.
context
System.Runtime.Serialization.StreamingContext.  A structure that contains contextual information about the source of the serialized stream that is associated with the new FeatureNotConfiguredException instance.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	FeatureNotConfiguredException Class

# IndexEventArgs Class
Not documented in this release.
public sealed class IndexEventArgs : EventArgs

Members
Public Instance Constructor
Method	Description
IndexEventArgs
Initializes a new instance of the IndexEventArgs class.

Public Instance Properties
Property	Description
Index
Not documented in this release.

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter Namespace

# IndexEventArgs Constructor
Initializes a new instance of the IndexEventArgs class.
Syntax
public IndexEventArgs(
  int  index
);

Parameters
index
System.Int32.  Not documented in this release.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	IndexEventArgs Class
•	Microsoft.MediaCenter Namespace

# IndexEventArgs.Index Property
Not documented in this release.
Syntax
public int Index {get;}

Property Value
System.Int32.  Not documented in this release.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	IndexEventArgs Class
•	Microsoft.MediaCenter Namespace

# IQueryPlaybackCapabilities Interface
Gets values that indicate the playback capabilities for media.
public interface IQueryPlaybackCapabilities

Members
Public Instance Properties
Property	Description
AllowFastForward
Gets a value that indicates whether the user is allowed to fast forward during playback of the current item.
AllowNext
Gets a value that indicates whether the user is allowed to advance to the next item in the media collection during playback of the current item.
AllowPrevious
Gets a value that indicates whether the user is allowed to go back to the previous item in the media collection during playback of the current item.
AllowRewind
Gets a value that indicates whether the user is allowed to rewind to the beginning during playback of the current item.
AllowSeekBack
Gets a value that indicates whether the user is allowed to use the seek slider to move to a previous point (replay or frame step backward) during playback of the current item.
AllowSeekForward
Gets a value that indicates whether the user is allowed to use the seek slider to move to a later point (skip forward or frame step forward) during playback of the current item.

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter Namespace

# IQueryPlaybackCapabilities.AllowFastForward Property
Gets a value that indicates whether the user is allowed to fast forward during playback of the current item.
Syntax
public bool AllowFastForward {get;}

Property Value
System.Boolean.  If true, the user is allowed to fast forward during playback of this item; otherwise, false.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	IQueryPlaybackCapabilities Interface
•	Microsoft.MediaCenter Namespace

# IQueryPlaybackCapabilities.AllowNext Property
Gets a value that indicates whether the user is allowed to advance to the next item in the media collection during playback of the current item.
Syntax
public bool AllowNext {get;}

Property Value
System.Boolean.  If true, the user is allowed to advance to the next item during playback of this item; otherwise, false.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	IQueryPlaybackCapabilities Interface
•	Microsoft.MediaCenter Namespace

# IQueryPlaybackCapabilities.AllowPrevious Property
Gets a value that indicates whether the user is allowed to go back to the previous item in the media collection during playback of the current item.
Syntax
public bool AllowPrevious {get;}

Property Value
System.Boolean.  If true, the user is allowed to go back to the previous item during playback of the current item; otherwise, false.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	IQueryPlaybackCapabilities Interface
•	Microsoft.MediaCenter Namespace

# IQueryPlaybackCapabilities.AllowRewind Property
Gets a value that indicates whether the user is allowed to rewind to the beginning during playback of the current item.
Syntax
public bool AllowRewind {get;}

Property Value
System.Boolean.  If true, the user is allowed to rewind during playback of the current item; otherwise, false.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	IQueryPlaybackCapabilities Interface
•	Microsoft.MediaCenter Namespace

# IQueryPlaybackCapabilities.AllowSeekBack Property
Gets a value that indicates whether the user is allowed to use the seek slider to move to a previous point (replay or frame step backward) during playback of the current item.
Syntax
public bool AllowSeekBack {get;}

Property Value
System.Boolean.  If true, the user is allowed to seek to a previous point during playback of the current item; otherwise, false.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	IQueryPlaybackCapabilities Interface
•	Microsoft.MediaCenter Namespace

# IQueryPlaybackCapabilities.AllowSeekForward Property
Gets a value that indicates whether the user is allowed to use the seek slider to move to a later point (skip forward or frame step forward) during playback of the current item.
Syntax
public bool AllowSeekForward {get;}

Property Value
System.Boolean.  If true, the user is allowed to seek to a later point during playback of the current item; otherwise, false.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	IQueryPlaybackCapabilities Interface
•	Microsoft.MediaCenter Namespace

# MediaCenterEnvironment Class
Enables applications to retrieve device information, gain access to disc changers, and control various aspects of Windows Media Center. The MediaCenterEnvironment class provides information about Windows Media Center, including its current capabilities and version number. For example, an application can use this class to display dialog boxes, play media, navigate to particular locations in Windows Media Center, and so on.
Syntax
public class MediaCenterEnvironment : Microsoft.MediaCenter.UI.IPropertyObject

Public Instance Methods
Method	Description
CreateDesktopShortcut
Displays a dialog box explaining that the user has invoked an operation that must be performed from the Web browser on the Windows Media Center computer, and not from within the Windows Media Center shell.
CreateFileList
Starts a list of media items for CD/DVD recording applications to Windows Media Center.
Dialog
Displays a Windows Media Center-style dialog box.
DialogNotification
Displays a modeless notification dialog box.
LaunchEntryPoint
Starts the application associated with the entry point.
NavigateToPage
Directs Windows Media Center to navigate to the specified page in the Windows Media Center user interface.
PlayMedia
Loads a new media item into Windows Media Center as the currently playing media.
ShowOnscreenKeyboard
Displays the onscreen keyboard that is included with Windows Media Center.

Public Instance Properties
Property	Description
AudioMixer
Gets an AudioMixer object used to set and retrieve the Windows Media Center volume level and mute state.
BackgroundColor
Gets and sets the background color as a System.Drawing.Color value.
BackgroundColor2
Gets and sets the background color as a Microsoft.MediaCenter.UI.Color value.
BackgroundMode
Gets or sets the type of background to display while audio or video is playing
Capabilities
Gets a collection of key-value pairs that indicates the current capabilities of the system.
DirectXExclusive
Gets or sets a value that indicates whether Windows Media Center is running in DirectX exclusive mode.
MediaChangers
Gets a list of disc changers.
MediaExperience
Gets a MediaExperience object used to put a Windows Media Center experience into full-screen mode, and to retrieve information about the current experience.
MediaTypesFromOriginalList
Indicates which types of media are supported by the CD/DVD recording.
ParentalControls
Gets a ParentalControls object used to select the type of parental control settings to query.
ScreensaverEnabledHint
Gets or sets a value indicating whether the current HTML page allows the screen saver to interrupt the media experience.
UserInfo
Gets a UserInfo object used to retrieve information about the user from Windows Media Center.
Version
Gets the version number of the MediaCenter object.


Public Instance Events
Event	Description
PropertyChanged
Raised when a MediaCenterEnvironment property changes.
ResumedFromStandby
Raised when the computer resumes from standby.

See Also
•	Managed Code Object Model Reference

# MediaCenterEnvironment.AudioMixer Property
Gets an AudioMixer object used to set and retrieve the Windows Media Center volume level and mute state.
Syntax
public AudioMixer AudioMixer {get;}

Property Value
Microsoft.MediaCenter.AudioMixer. The class used to set and retrieve the volume level and mute state.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MediaCenterEnvironment Class

# MediaCenterEnvironment.BackgroundColor Property
Gets and sets the background color.
Syntax
public System.Drawing.Color BackgroundColor {get; set;}

Property Value
System.Drawing.Color.  An Alpha Red Green Blue (ARGB) color.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MediaCenterEnvironment Class
•	MediaCenterEnvironment.BackgroundColor2 Property
•	Microsoft.MediaCenter Namespace

# MediaCenterEnvironment.BackgroundColor2 Property
Gets and sets the background color.
Syntax
public Microsoft.MediaCenter.UI.Color BackgroundColor2 {get; set;}

Property Value
Microsoft.MediaCenter.UI.Color.  An Alpha Red Green Blue (ARGB) color.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	MediaCenterEnvironment Class
•	MediaCenterEnvironment.BackgroundColor Property
•	Microsoft.MediaCenter Namespace

# MediaCenterEnvironment.BackgroundMode Property
Gets or sets the type of background to display while audio or video is playing.
Syntax
public BackgroundModes BackgroundMode {get; set;}

Property Value
Microsoft.MediaCenter.BackgroundModes.  A value that indicates the background mode to display.
This property is read/write.
Remarks
The background that is displayed depends on whether the Now Playing view item is audio or video. For example, album art can be displayed for an audio view item. A masked video can be displayed for a video view item.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	MediaCenterEnvironment Class
•	Microsoft.MediaCenter Namespace

# MediaCenterEnvironment.Capabilities Property
Gets a collection of key-value pairs that indicates the current capabilities of the system.
Syntax
public Dictionary Capabilities {get;}

Property Value
System.Collections.Generic.Dictionary<string, object>. A collection of key-value pairs.
This property is read-only.
Remarks
Possible values can include, but are not limited to, "directx", "audio", "video", "intensiverendering", "console", and "cdburning".
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MediaCenterEnvironment Class

# MediaCenterEnvironment.CreateDesktopShortcut Method
Displays a dialog box explaining that the user has invoked an operation that must be performed from the Web browser on the Windows Media Center PC, and not from within the Windows Media Center shell. Depending on the user's response, the method can begin the operation immediately by switching control to the user's default Web browser, or it can create a shortcut in the Windows Media Center Links folder on the desktop of the Windows Media Center PC, allowing the user to perform the operation at a later time.
Syntax
public ShortcutStatus CreateDesktopShortcut(string title, uri target);

Parameters
title
System.String.  The title of the desktop shortcut.
target
System.Uri.  Contains the uniform resource identifier (URI).
Return Value
Microsoft.MediaCenter.ShortcutStatus. A value from the ShortcutStatus enumeration indicating the user's response to the dialog box.
Remarks
This method allows your application to guide the user to a traditional "two-foot" Web browser to perform an operation such as downloading and installing an executable or ActiveX component, or filling out forms that require a lot of typing.
The dialog box contains either two or three buttons, depending on whether the user is using a Windows Media Center Extender device. With an Extender, the dialog box contains the Cancel and Save Link To Desktop buttons. Without the Extender, the dialog box provides a third button, Open Website in Browser.
Based on the return value, your application should provide the user with appropriate instructions on how to proceed with the operation. Also, by checking the capabilities of the Windows Media Center session using the MediaCenterEnvironment.Capabilities property, you can determine whether the user is running in a Windows Media Center Extender session and, if so, instruct the user to return to the computer to complete the task.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MediaCenterEnvironment Class
•	ShortcutStatus Enumeration

# MediaCenterEnvironment.CreateFileList Method
Starts a list of media items for CD/DVD recording applications to Windows Media Center.
Syntax
public void CreateFileList(
  ICreateFileListHelper  createFileListHelper,
  InitialListType  initialListType
);
Parameters
createFileListHelper
Microsoft.MediaCenter.ListMaker.ICreateFileListHelper.  A delegate used to handle recording operations.
initialListType
Microsoft.MediaCenter.ListMaker.InitialListType.  An enumeration type that indicates the type of list to start with.
Return Value
This method does not return a value.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	MediaCenterEnvironment Class
•	Microsoft.MediaCenter.ListMaker Namespace
# MediaCenterEnvironment.Dialog Method
Displays a Windows Media Center-style dialog box.
Overload List
public DialogResult Dialog(string, string, DialogButtons, int, bool)

public DialogResult Dialog(string, string, IEnumerable, int, bool, string, DialogClosedCallback)
public DialogResult Dialog(string, string, IEnumerable, int, bool, string)


# MediaCenterEnvironment.Dialog Method
The MediaCenterEnvironment.Dialog method displays a modal or modeless Windows Media Center-style dialog box. The dialog box has a caption, body text, buttons, and a timeout duration.
Syntax
public DialogResult Dialog(
   string text,
   string caption,
   DialogButtons buttons,
   int timeout,
   bool isModal
);

Parameters
text
System.String.  The text for the body of the dialog box.
caption
System.String.  The text for the caption.
buttons
DialogButtons.  The types of buttons to add to the dialog box.
To specify multiple buttons on a dialog box, add the numbers for the individual buttons. The complete list is in the following table. Descriptions show resulting buttons in the left-to-right order, as they will appear in the dialog box.
Value	Description
1	OK
2	Cancel
3	OK, Cancel
4	Yes
5	OK, Yes
6	Yes, Cancel
7	OK, Cancel, Yes
8	No
9	OK, No
10	No, Cancel
11	OK, No, Cancel
12	Yes, No
13	OK, Yes, No
14	Yes, No, Cancel
15	OK, Yes, No, Cancel

Although you can specify any combination, it is best to avoid the following combinations because they may be unclear to the user:
•	OK, Yes
•	OK, Cancel, Yes
•	No, Cancel
•	OK, Yes, No
•	OK, Yes, No, Cancel
•	Yes
•	No
timeout
System.Int32.  The time-out duration, in seconds, for the dialog box, at the end of which the dialog box will automatically close. A value of -1 or 0 for a modal dialog box indicates an infinite time-out duration. For modeless dialog boxes, Windows Media Center does not allow infinite time-out. Modeless dialog boxes have a time-out duration range between 5-120 seconds.
isModal
System.Boolean.  Indicates whether the dialog box is modal (true) or modeless (false). A modal dialog box must be closed by the user or time out before you can continue working with the rest of the application. A modeless dialog box lets you change focus away from it without having to close the dialog box.
This overloaded version of the Dialog method can create a modeless dialog box to present information to the user, but it does not return a value to indicate what button was selected to close the dialog box.
To ensure that a dialog box is displayed, an on-demand application should use a modal dialog box. Note that when an on-demand application creates a modal dialog box, Windows Media Center stops executing until the user dismisses the dialog box.
Return Value
DialogResult. A member of the DialogResult enumeration that indicates how the dialog box was dismissed.
Remarks
These dialog boxes are specially designed to integrate with the Windows Media Center user experience; they should be used instead of standard Windows dialog boxes.
You can specify Unicode characters using \uNNNN notation, where NNNN indicates the Unicode character.
Modeless dialog boxes do not return a value indicating what button is selected to close the dialog box. If your application needs to get information from the user (Yes, No, OK, or Cancel), you should set the isModal parameter to true to make your dialog box modal. Or, use the overload of Dialog that takes a DialogClosedCallback delegate.
# MediaCenterEnvironment.Dialog Method
Shows a Windows Media Center-style dialog box that can contain custom buttons and images, and can pass a result code to an application-defined event handler.
Syntax
public DialogResult Dialog(
   string text,
   string caption,
   IEnumerable buttons,
   int timeout,
   bool isModal,
   string imagePath
   DialogClosedCallback callback,
);

Parameters
text
System.String.  The text for the body of the dialog box.
caption
System.String.  The text for the caption.
buttons
System.Collections.IEnumerable. A collection of strings and integers that defines the buttons to include in the dialog box. For each string in the collection, the method adds a custom button that contains the string. For each number, the method creates a standard button. The standard buttons have the following values:
Value	Description
1	OK button
2	Cancel button
4	Yes button
8	No button

timeout
System.Int32.  The time-out duration, in seconds, for the dialog box, at the end of which the dialog box will automatically close. A value of -1 or 0 for a modal dialog box indicates an infinite time-out duration. For modeless dialog boxes, Windows Media Center does not allow infinite time-out. Modeless dialog boxes have a time-out duration range between 5-120 seconds.
isModal
System.Boolean.  Indicates whether the dialog box is modal (true) or modeless (false). A modal dialog box must be closed by the user or time out before you can continue working with the rest of the application. A modeless dialog box lets you change focus away from it without having to close the dialog box.
To ensure that a dialog box is displayed, an on-demand application should use a modal dialog box. Note that when an on-demand application creates a modal dialog box, Windows Media Center stops executing until the user dismisses the dialog box.
imagePath
System.String.  The path to the image to display in the dialog box.
callback
Microsoft.MediaCenter.DialogClosedCallback.  For modeless dialog boxes, this parameter specifies the DialogClosedCallback delegate that Windows Media Center invokes when the dialog box is dismissed. Windows Media Center passes a value to the delegate that indicates how the dialog box was dismissed. For modal dialog boxes, use the return value to determine how the dialog box was dismissed.
Return Value
DialogResult. A member of the DialogResult enumeration that indicates how the dialog box was dismissed. For a modal dialog box, the return value is one of the values listed in the description of the onClose parameter. For a modeless dialog box, the return value is always DialogResult.Active, indicating that the dialog box is active. Regardless of the dialog box type, if no valid buttons are specified, the dialog box does not appear and an exception is thrown.
Remarks
These dialog boxes are specially designed to integrate with the Windows Media Center user experience; they should be used instead of standard Windows dialog boxes.
You can specify Unicode characters using \uNNNN notation, where NNNN indicates the Unicode character.
If an on-demand application uses this method to display a modal dialog box, Windows Media Center ignores the onClose parameter. This is because the application would need to block execution while waiting for the result to be passed to its DialogClosedCallback delegate. However, the application cannot block its execution without also blocking the execution of Windows Media Center, meaning that the result would never reach the delegate.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	DialogClosedCallback Delegate
•	MediaCenterEnvironment Class

# MediaCenterEnvironment.Dialog Method
Shows a Windows Media Center-style dialog box that can contain custom buttons and images, and can pass a result code to an application-defined event handler.
Syntax
public DialogResult Dialog(
   string text,
   string caption,
   IEnumerable buttons,
   int timeout,
   bool isModal,
   string imagePath
);

Parameters
text
System.String.  The text for the body of the dialog box.
caption
System.String.  The text for the caption.
buttons
System.Collections.IEnumerable. A collection of strings and integers that defines the buttons to include in the dialog box. For each string in the collection, the method adds a custom button that contains the string. For each number, the method creates a standard button. The standard buttons have the following values:
Value	Description
1	OK button
2	Cancel button
4	Yes button
8	No button

timeout
System.Int32.  The time-out duration, in seconds, for the dialog box, at the end of which the dialog box will automatically close. A value of -1 or 0 for a modal dialog box indicates an infinite time-out duration. For modeless dialog boxes, Windows Media Center does not allow infinite time-out. Modeless dialog boxes have a time-out duration range between 5-120 seconds.
isModal
System.Boolean.  Indicates whether the dialog box is modal (true) or modeless (false). A modal dialog box must be closed by the user or time out before you can continue working with the rest of the application. A modeless dialog box lets you change focus away from it without having to close the dialog box.
To ensure that a dialog box is displayed, an on-demand application should use a modal dialog box. Note that when an on-demand application creates a modal dialog box, Windows Media Center stops executing until the user dismisses the dialog box.
imagePath
System.String.  The path to the image to display in the dialog box.
Return Value
DialogResult. A member of the DialogResult enumeration that indicates how the dialog box was dismissed. For a modal dialog box, the return value is one of the values listed in the description of the onClose parameter. For a modeless dialog box, the return value is always DialogResult.Active, indicating that the dialog box is active. Regardless of the dialog box type, if no valid buttons are specified, the dialog box does not appear and an exception is thrown.
Remarks
These dialog boxes are specially designed to integrate with the Windows Media Center user experience; they should be used instead of standard Windows dialog boxes.
You can specify Unicode characters using \uNNNN notation, where NNNN indicates the Unicode character.
If an on-demand application uses this method to display a modal dialog box, Windows Media Center ignores the onClose parameter. This is because the application would need to block execution while waiting for the result to be passed to its DialogClosedCallback delegate. However, the application cannot block its execution without also blocking the execution of Windows Media Center, meaning that the result would never reach the delegate.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	DialogClosedCallback Delegate
•	MediaCenterEnvironment Class

# MediaCenterEnvironment.DialogNotification Method
Displays a modeless notification dialog box.
Syntax
public DialogResult DialogNotification(
   string text,
   IEnumerable buttons,
   int timeout,
   string imagePath
);

public DialogResult DialogNotification(
   string text,
   IEnumerable buttons,
   int timeout,
   string imagePath
   DialogClosedCallback callback,
);

Parameters
text
System.String.  The text for the body of the dialog box.
buttons
System.Collections.IEnumerable.  A collection of strings and integers that defines the buttons to include in the dialog box. For each string in the collection, the method adds a custom button that contains the string. For each number, the method creates a standard button. The standard buttons have the following values:
Value	Description
1	OK button
2	Cancel button
4	Yes button
8	No button

timeout
System.Int32.  The time-out duration, in seconds, for the dialog box, at the end of which the dialog box will automatically close. Modeless dialog boxes have a time-out duration range between 5-120 seconds.
imagePath
System.String.  The path to the image to display in the dialog box.
callback
Microsoft.MediaCenter.DialogClosedCallback.  For modeless dialog boxes, this parameter specifies the DialogClosedCallback delegate that Windows Media Center invokes when the dialog box is dismissed. Windows Media Center passes a value to the delegate that indicates how the dialog box was dismissed. For modal dialog boxes, use the return value to determine how the dialog box was dismissed.
Return Value
DialogResult. A member of the DialogResult enumeration that indicates how the dialog box was dismissed. This method returns DialogResult.Active when it succeeds, indicating that the dialog box is active. If a different value is returned, this method failed.
Remarks
A notification dialog box is a window that appears briefly to notify the user of a particular event. It displays an image, text, and the specified buttons. The dialog box disappears when the user clicks a button, or when the associated time-out duration expires.
You can specify Unicode characters using \uNNNN notation, where NNNN indicates the Unicode character.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	DialogClosedCallback Delegate
•	MediaCenterEnvironment Class

# MediaCenterEnvironment.DirectXExclusive Property
Gets or sets a value that indicates whether Windows Media Center is running in DirectX exclusive mode.
Syntax
public bool DirectXExclusive {get; set;}

Property Value
System.Boolean.  If true,  Windows Media Center is running in DirectX exclusive mode; otherwise, false.
This property is read/write.
Remarks
DirectX exclusive mode is a feature of the Microsoft DirectX API that enables the windowing system to be suspended so that drawing can be done directly to the screen. Exclusive mode allows Windows Media Center to take advantage of hardware acceleration for enhanced video performance.
Moving in or out of DirectX exclusive mode can take a second or two. When a mode change is initiated, the DirectXExclusive property may indicate the new state prematurely (before the video card has completed the mode switch) because of latencies in the DirectX system. For this reason, simply checking the DirectXExclusive property may return inaccurate results. For pages that enter or exit exclusive mode when they are loaded, any code requiring the page to be in a particular mode should be performed after a delay, to allow for the transition to complete.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	MediaCenterEnvironment Class

# MediaCenterEnvironment.LaunchEntryPoint Method
Starts the application associated with the entry point.
Syntax
public void LaunchEntryPoint(
   Guid appId,
   Guid entryPointId,
   params object[] parameters
);

Parameters
appId
System.Guid.  Unique identifier of the application to start.
entryPointId
System.Guid.  A GUID for the entry point.
parameters
System.Object[].  An array of parameters that is passed to the application. For more information, see the AddInHost.EntryPointParameters property.
Return Value
This method does not return a value.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MediaCenterEnvironment Class

# MediaCenterEnvironment.MediaChangers Property
Gets a list of MediaChanger objects that represent disc changers.
Syntax
public System.Collections.ObjectModel.Collection<MediaChanger> MediaChangers {get;}

Property Value
System.Collections.ObjectModel.Collection<Microsoft.MediaCenter.MediaChanger>. A list of MediaChanger objects.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MediaCenterEnvironment Class

# MediaCenterEnvironment.MediaExperience Property
Gets a MediaExperience object used to put a Windows Media Center experience into full-screen mode, and to retrieve information about the current experience.
Syntax
public MediaExperience MediaExperience {get;}

Property Value
Microsoft.MediaCenter.MediaExperience. The interface used to put an experience into full-screen mode, and to retrieve information about the current experience.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MediaCenterEnvironment Class

# MediaCenterEnvironment.MediaTypesFromOriginalList Property
Indicates which types of media are supported by the CD/DVD recording.
Syntax
public Microsoft.MediaCenter.ListMaker.MediaTypes MediaTypesFromOriginalList {get; }
Property Value
Microsoft.MediaCenter.ListMaker.MediaTypes.  Types of supported media.
This property is read-only.
Remarks
Windows Media Center uses this property to limit the types of media that are offered to the user.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MediaCenterEnvironment Class
•	Microsoft.MediaCenter.ListMaker Namespace

# MediaCenterEnvironment.NavigateToPage Method
Directs Windows Media Center to navigate to the specified page in the Windows Media Center user interface.
Syntax
public void NavigateToPage(
   PageId pageId,
   object pageParameters
);

Parameters
pageId
Microsoft.MediaCenter.PageId.  The identifier of a Windows Media Center page.
pageParameters
System.Object.  Additional parameters. For more information, see the Remarks section.
Return Value
This method does not return a value.
Remarks
The value of the pageId parameter determines the value of the pageParameters parameter, as shown in the following table:
PageId field	pageParameters
PageId.ExtensibilityUrl	URL of the destination page.
PageId.FMRadio	Null
PageId.InternetRadio	Null
PageId.LiveTV	Null
PageId.ManageDisks	Null
PageId.MorePrograms	Null
PageId.MovieLibrary	Null
PageId.MusicAlbums	Null
PageId.MusicArtists	Null
PageId.MusicSongs	Null
PageId.MyMusic	Null
PageId.MyPictures	Path to folder
PageId.MyTV	Null
PageId.MyVideos	Path to folder
PageId.PhotoDetails	Path to the photo for which the application should show details.
PageId.RecordedTV	Null
PageId.RecorderStorageSettings	Null
PageId.ScheduledTVRecordings	Null
PageId.Slideshow	Path to folder
PageId.SlideshowSettings	Null
PageId.Start	Null
PageId.TVGuide	Null
PageId.Visualizations	visualizationName:preset
PageId.WebAddIn	URL of the destination page.

If pageId is PageId.Visualizations, pageParameters is a string containing the visualization name (from the registry) and preset, separated by a colon. For example, "Ambience:Swirl". If a visualization name is specified, but not a preset, Windows Media Center uses the previously selected preset. Similarly, if a preset is specified, but not a visualization name, Windows Media Center uses the previously selected visualization.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MediaCenterEnvironment Class

# MediaCenterEnvironment.ParentalControls Property
Gets a ParentalControls object used to select the type of parental control settings to query.
Syntax
public ParentalControls ParentalControls {get;}

Property Value
Microsoft.MediaCenter.ParentalControls. The class that contains the parental control settings.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MediaCenterEnvironment Class
•	ParentalControls Class

# MediaCenterEnvironment.PlayMedia Method
Loads a new media item into Windows Media Center as the currently playing media.
Syntax
public bool PlayMedia(
   MediaType mediaType,
   object media,
   bool addToQueue
);

Parameters
mediaType
Microsoft.MediaCenter.MediaType.  Indicates the type of the media.
media
System.Object.  Indicates the location of the media. The meaning of this parameter depends on the value of mediaType, as shown in the following table:
mediaType	media
Audio	The URL of the audio to play. Local file paths require escaped (double) backslashes.
DVD	A string in the following format: [//<path>?] [<address>]. For more information, see the Remarks section.
Radio	A string in the following format: [band:nn.n] or [band:nn,n], depending on the locale. For example, "fm:103.1" or "fm:103,1". For band, only FM is currently supported.
TV	A string representing the call sign of the service to play, or a service ID retrieved by the Lineup or ScheduleEvent class.
Video	The URL of the video or recorded TV file to play. Local file paths require escaped (double) backslashes.

addToQueue
System.Boolean.  If true, the media is added to the queue and is played in turn. If false, the media immediately begins playing, preempting the currently playing media, if any. This parameter is valid only when mediaType is set to Audio; otherwise, it is ignored.
Return Value
System.Boolean. It is true if the media was loaded, and false otherwise.
Remarks
If the specified media type is DVD, media is a string in the following format:
DVD:[//<path>?] [<address>]

where <path> specifies the location of the DVD, in the following format:
<unc_path> | <drive_letter>:/<directory_path>

and <address> specifies the start and end points within the DVD, in the following format:
<title> | <title>/<chapter>[-<end_chapter>] | <title>/<time>[-<end_time>]

The <title> value identifies a title within the DVD, in the following format:
[digit] digit

The <chapter> and <end chapter> values identify the first and last chapters to play within the specified title, in the following format:
[ [digit] digit] digit

The <time> and <end time> values identify the start and end points, in the following format:
[<hours>:] [<minutes>:] [<seconds>:] <frames>

The <hours>, <minutes>, <seconds>, and <frames> values are specified using the following format:
[digit | 0]  digit

If the <path> is not specified, Windows Media Center searches for and plays the first DVD it finds. If the <address> is not specified, Windows Media Center starts playing the DVD from the beginning.
The examples in the following table show several ways to specify the mediaLocation parameter:
mediaLocation	Description
2	Plays title 2 in the first DVD found.
5/13	Plays chapter 13 of title 5 in the first DVD found.
7/9:05-13:23	Plays from 9 seconds, 5 frames to 13 seconds, 23 frames in title 7.
//myshare/dvd?9	Plays title 9 from the DVD-Video volume stored in the dvd directory of myshare.
//f:/video_ts	Plays the DVD-Video volume in the video_ts directory of drive F.
DVD://c:/dvdstorage/mydvd/video_ts?5/13	Plays the DVD in c:\dvdstorage\mydvd\ at chapter 13 of title 5.

FM radio tuning is subject to many regional restrictions as to which frequencies can be tuned to and which decimal point character is allowed. You will need to test your Web application thoroughly to be sure that this method succeeds for the stations and regions in which you intend it to be used.
Be sure to unescape your URL if it contains slashes that could be read as escape characters. If you were to assign your URL as the value for the variable myURL, the syntax to unescape would be: myUrl = unescape(myUrl).
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MediaCenterEnvironment Class

# MediaCenterEnvironment.PropertyChanged Event
Raised when a MediaCenterEnvironment property changes.
Syntax
public override Microsoft.MediaCenter.UI.PropertyChangedEventHandler PropertyChanged;

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MediaCenterEnvironment Class
•	Microsoft.MediaCenter Namespace

# MediaCenterEnvironment.ResumedFromStandby Event
Raised when the computer resumes from stand by.
Syntax
public event System.EventHandler ResumedFromStandby;

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MediaCenterEnvironment Class

# MediaCenterEnvironment.ScreensaverEnabledHint Property
Gets or sets a value indicating whether the current HTML page allows the screen saver to interrupt the media experience.
Syntax
public bool ScreensaverEnabledHint {get; set;}

Property Value
System.Boolean.  If true, the current HTML page allows the screen saver to interrupt the media experience; otherwise, false.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	MediaCenterEnvironment Class
•	Microsoft.MediaCenter Namespace

# MediaCenterEnvironment.ShowOnscreenKeyboard Method
Displays the onscreen keyboard that is included with Windows Media Center.
Syntax
public void ShowOnscreenKeyboard(
  Microsoft.MediaCenter.UI.EditableText  editableText,
  bool  passwordMasked,
  int  maxLength
);

Parameters
editableText
Microsoft.MediaCenter.UI.EditableText.  The text string, which is also displayed above the onscreen keyboard as the user enters text.
passwordMasked
System.Boolean.  If true, masks the text that is displayed above the onscreen keyboard; otherwise, displays regular characters.
maxLength
System.Int32.  The maximum length of the text string.
Return Value
This method does not return a value.
Remarks
The onscreen keyboard is an image of a keyboard that allows the user to select letters by using the remote control's arrow buttons and the OK/Enter button.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	MediaCenterEnvironment Class
•	Microsoft.MediaCenter Namespace

# MediaCenterEnvironment.UserInfo Property
Gets a UserInfo interface used to retrieve information about the user from Windows Media Center.
Syntax
public UserInfo UserInfo {get;}

Property Value
Microsoft.MediaCenter.UserInfo. The interface used to retrieve information about the user.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	AddInHost Class

# MediaCenterEnvironment.Version Property
Gets the version number of the MediaCenter object.
Syntax
public Version Version {get;}

Property Value
Version. The version number of the MediaCenter object.
Release	Media Center Version
Windows XP Media Center Edition 2004	6.0
Windows XP Media Center Edition 2005	7.0
Update Rollup 2 for Windows XP Media Center Edition 2005	7.5
Windows Media Center in Windows Vista Ultimate or Windows Vista Home Premium	8.0

This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MediaCenterEnvironment Class

# MediaChanger Class
Enables applications to control the disc changer and get information about discs in the changer slots and in the drives. Applications can retrieve this class by using the Microsoft.MediaCenter.MediaCenterEnvironment.MediaChangers property.
Syntax
public class MediaChanger

Note   .NET remoting releases objects (other than host objects) every five minutes if they are not used, and calls made to the object result in an exception error. To prevent the MediaChanger object from being released prematurely, create a timer with a frequency of less than five minutes that calls the IsLocked property. Or, provide a sponsor object for the object you want to keep.
Public Instance Methods
Method	Description
EjectDisc
Ejects the disc from the specified slot.
GetDriveDiscData
Gets information about the discs in the drives.
GetSlotDiscData
Gets information about the discs in slots.
LoadDisc
Loads the disc in the specified slot into the specified drive.
Lock
Locks the media changer for use by this application only.
RescanDisc
Causes Windows Media Center to rescan the disc in the specified drive.
UnloadDisc
Unloads the disc in the specified drive.
Unlock
Unlocks the media changer if this application locked it.

Public Instance Properties
Property	Description
IsLocked
Gets a value that indicates whether the media changer is currently locked by any application.

See Also
•	Microsoft.MediaCenter Namespace

# MediaChanger.EjectDisc Method
Ejects the disk from the specified slot.
Syntax
public void EjectDisc(int slotAddress);

Parameters
slotAddress
System.Int32.  Zero-based slot index from which to eject the disc.
Return Value
This method does not return a value.
Remarks
To disable the prompt that is displayed to the user when a disc is ejected, add the following registry key to your setup application:
Path: HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Media Center\Settings\DvdSettings
Key: SuppressExtensibilityEjectPrompt
Value: 1
Note   If the SuppressExtensibilityEjectPrompt key is set to 0 or if the key does not exist, the user is prompted when an application calls the EjectDisc method. If the key exists and is set to any value other than 0, the prompt is disabled.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MediaChanger Class

# MediaChanger.GetDriveDiscData Method
Gets information about the discs in the drives.
Syntax
public System.Collections.ObjectModel.Collection<DiscData> GetDriveDiscData();

Return Value
System.Collections.ObjectModel.Collection<Microsoft.MediaCenter.DiscData>.  A collection of DiscData classes, one for each drive.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MediaChanger Class
•	MediaChanger.GetSlotDiscData Property
# MediaChanger.GetSlotDiscData Method
Gets information about the discs in changer slots.
Syntax
public System.Collections.ObjectModel.Collection<DiscData> GetSlotDiscData();

Return Value
System.Collections.ObjectModel.Collection<Microsoft.MediaCenter.DiscData>.  A collection of DiscData classes, one for each disc in the changer slots.

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MediaChanger Class
•	MediaChanger.GetDriveDiscData Property

# MediaChanger.IsLocked Property
Gets a value that indicates whether the media changer is currently locked by any application.
Syntax
public bool IsLocked {get;}

Property Value
System.Boolean. It is true if the media changer is locked, otherwise it is false.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MediaChanger Class

# MediaChanger.LoadDisc Method
Loads the disc in the specified slot into the specified drive.
Syntax
public void LoadDisc(int slotAddress, int driveAddress);

Parameters
slotAddress
System.Int32.  Zero-based slot index to load the disc from.
driveAddress
System.Int32.  Zero-based drive index to load the disc into.
Return Value
This method does not return a value.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MediaChanger Class

# MediaChanger.Lock Method
Locks the media changer for use by this application only.
Syntax
public void Lock();

Parameters
This method takes no parameters.
Return Value
This method does not return a value.
This method raises an InvalidOperationException if the media changer is already locked. The text passed with the exception indicates whether the media changer is already locked by either this or another application.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MediaChanger Class

# MediaChanger.RescanDisc Method
Causes Windows Media Center to rescan the disc in the specified drive.
Syntax
public void RescanDisc(int driveAddress);

Parameters
driveAddress
System.Int32.  Zero-based index of the drive to rescan.
Return Value
This method does not return a value.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MediaChanger Class

# MediaChanger.UnloadDisc Method
Unloads the disc in the specified drive.
Syntax
public int UnloadDisc(int driveAddress);

Parameters
driveAddress
System.Int32.  Zero-based index of the drive to unload.
Return Value
Zero-based index of the slot the disc was unloaded into.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MediaChanger Class

# MediaChanger.Unlock Method
Unlocks the media changer if this application locked it.
Syntax
public void Unlock();

Parameters
This method takes no parameters.
Return Value
This method does not return a value.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MediaChanger Class

# MediaChangerException Class
Contains information about an exception that was raised because a media changer operation failed.
Syntax
public class MediaChangerException : Exception

Public Instance Constructors
Constructor	Description
MediaChangerException()
Initializes an instance of the MediaChangerException class.
MediaChangerException(string)
Initializes an instance of the MediaChangerException class.
MediaChangerException(string, Exception)	Initializes an instance of the MediaChangerException class.

Protected Instance Constructors
Constructor	Description
MediaChangerException(SerializationInfo, StreamingContext)	Initializes an instance of the MediaChangerException class.

See Also
•	MediaChanger Class
•	Microsoft.MediaCenter Namespace

# MediaChangerException Constructor
Initializes an instance of the MediaChangerException class.
Overload List
public MediaChangerException()

public MediaChangerException(string)

public MediaChangerException(string, Exception)

protected MediaChangerException(SerializationInfo, StreamingContext)


# MediaChangerException.MediaChangerException Constructor
Initializes an instance of the MediaChangerException class.
Syntax
public MediaChangerException(
);
# MediaChangerException.MediaChangerException Constructor
Initializes an instance of the MediaChangerException class.
Syntax
public MediaChangerException(
  string  message
);
Parameters
message
System.String.  A description of the exception.
# MediaChangerException.MediaChangerException Constructor
Initializes an instance of the MediaChangerException class.
Syntax
public MediaChangerException(
  string  message,
  Exception  innerException
);
Parameters
message
System.String.  A description of the exception.
innerException
System.Exception.  The class on which this exception is based.
# MediaChangerException.MediaChangerException Constructor
Initializes an instance of the MediaChangerException class.
Syntax
protected MediaChangerException(
  System.Runtime.Serialization.SerializationInfo  info,
  System.Runtime.Serialization.StreamingContext  context
);
Parameters
info
System.Runtime.Serialization.SerializationInfo.  An instance of the class containing the information needed to serialize the new MediaChangerException instance.
context
System.Runtime.Serialization.StreamingContext.  A structure that contains contextual information about the source of the serialized stream associated with the new MediaChangerException instance.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MediaChangerException Class

# MediaCollection Class
A collection of media items that make up a playlist (media collection). This class fires notifications when the object is modified.
public sealed class MediaCollection : Microsoft.MediaCenter.Utility.NotifyCollection<MediaCollectionItem>, IDisposable

Members
Protected Instance Constructor
Method	Description
MediaCollection
Initializes a new instance of the MediaCollection class.

Public Instance Methods
Method	Description
AddItem
Adds a media item to the current media collection.
Dispose
Not documented in this release.

Protected Instance Methods
Method	Description
ClearItems
Removes all media items from the current media collection.
InsertItem
Adds an item at a specific index location in the current media collection.
RemoveItem
Removes a media item from the current media collection.
SetItem
Specifies the item in the collection that is active.

Public Instance Properties
Property	Description
ContinueOnError
Gets or sets a value that indicates whether to proceed to the next media item in the collection if a playback error occurs.
CurrentIndex
Gets or sets the index of the current item in the media collection.
IsActive
Gets a value that indicates whether the current media collection is being played.

Public Instance Events
Event	Description
PropertyChanged
Fires when a property in the current MediaCollection object changes.

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter Namespace

# MediaCollection Constructor
Initiates an instance of the MediaCollection class.
Syntax
public MediaCollection();

Remarks
None.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	MediaCollection Class
•	Microsoft.MediaCenter Namespace

# MediaCollection.AddItem Method
Adds a media item to the current media collection.
Overload List
public void AddItem(
  object  media
);
public void AddItem(
  object  media,
  int  index
);
public void AddItem(
  object  media,
  int  index,
  int  playbackFlags
);
public void AddItem(
  object  media,
  int  index,
  int  playbackFlags,
  object  tag
);
public void AddItem(
  object  media,
  int  index,
  int  playbackFlags,
  object  tag,
  System.Collections.IDictionary  friendlyData
);
public void AddItem(
  object  media,
  int  index,
  int  playbackFlags,
  object  tag,
  System.Collections.IDictionary  friendlyData,
  TimeSpan  start,
  TimeSpan  length
);

Parameters
media
System.Object.  Contains the URI to the media item.
index
System.Int32.  A value that indicates the index location within the collection. Specify an index value to insert an item at that point and to push existing items down the list.
playbackFlags
System.Int32.  A bitflag value that indicates which members of the MediaItemPlaybackCapabilities enumeration are enabled, indicating the playback capabilities of the media item.
tag
System.Object.  An application-specific object that can be associated with the media item.
friendlyData
System.Collections.IDictionary.  A collection of name-value pairs that override the metadata included in the media item (title, date, and duration).
start
System.TimeSpan.  The time offset from which to start playing the media item.
length
System.TimeSpan.  The duration to play the media item.
Return Value
This method does not return a value.
Remarks
If an index is not specified, the item is appended to the end of the list.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	MediaCollection Class
•	Microsoft.MediaCenter Namespace

# MediaCollection.ClearItems Method
Removes all media items from the current media collection.
Syntax
protected virtual void ClearItems();

Return Value
This method does not return a value.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	MediaCollection Class
•	Microsoft.MediaCenter Namespace

# MediaCollection.ContinueOnError Property
Gets or sets a value that indicates whether to proceed to the next media item in the collection if a playback error occurs.
Syntax
public bool ContinueOnError {get; set;}

Property Value
System.Boolean.  If true, advances to the next item in the media collection if a playback occurs; otherwise, false.
This property is read/write.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	MediaCollection Class
•	Microsoft.MediaCenter Namespace

# MediaCollection.CurrentIndex Property
Gets or sets the index of the current item in the media collection.
Syntax
public int CurrentIndex {get; set;}

Property Value
System.Int32.  The index of the current media item.
This property is read/write.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	MediaCollection Class
•	Microsoft.MediaCenter Namespace

# MediaCollection.Dispose Method
Not documented in this release.
Syntax
public override void Dispose();

Return Value
This method does not return a value.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	MediaCollection Class
•	Microsoft.MediaCenter Namespace

# MediaCollection.InsertItem Method
Adds an item at a specific index location in the current media collection.
Syntax
protected virtual void InsertItem(
  int  index,
  MediaCollectionItem  item
);

Parameters
index
System.Int32.  Specifies the index location in the location where the media item should be added. Specify index=-1 to append the item to the end of the collection, and index=n inserts the item after location n.
item
Microsoft.MediaCenter.MediaCollectionItem.  An object that contains the media item to add.
Return Value
This method does not return a value.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	MediaCollection Class
•	Microsoft.MediaCenter Namespace

# MediaCollection.IsActive Property
Gets a value that indicates whether the current media collection is being played.
Syntax
public bool IsActive {get;}

Property Value
System.Boolean.  If true, the current media collection is being played; otherwise, false.
This property is read-only.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	MediaCollection Class
•	Microsoft.MediaCenter Namespace

# MediaCollection.PropertyChanged Event
Fires when a property in the current MediaCollection object changes.
Syntax
public Microsoft.MediaCenter.UI.PropertyChangedEventHandler PropertyChanged;

Remarks
None.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	MediaCollection Class
•	Microsoft.MediaCenter Namespace

# MediaCollection.RemoveItem Method
Removes a media item from the current media collection.
Syntax
protected virtual void RemoveItem(
  int  index
);

Parameters
index
System.Int32.  Specifies the index location of the media item to remove.
Return Value
This method does not return a value.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	MediaCollection Class
•	Microsoft.MediaCenter Namespace

# MediaCollection.SetItem Method
Specifies the item in the collection that is active.
Syntax
protected virtual void SetItem(
  int  index,
  MediaCollectionItem  item
);

Parameters
index
System.Int32.  The index location of the media item. Specify index=-1 to append the item to the end of the collection, and index=n inserts the item after location n.
item
Microsoft.MediaCenter.MediaCollectionItem.  An object that contains a media item.
Return Value
This method does not return a value.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	MediaCollection Class
•	Microsoft.MediaCenter Namespace

# MediaCollectionItem Class
Used to add an audio or video item to the media collection and specify properties for playback.
public sealed class MediaCollectionItem : Microsoft.MediaCenter.UI.IPropertyObject, IQueryPlaybackCapabilities

Members
Public Instance Constructor
Method	Description
MediaCollectionItem
Initializes a new instance of the MediaCollectionItem class.

Public Instance Properties
Property	Description
AllowFastForward
Gets a value that indicates whether the user is allowed to fast forward during playback of the current item.
AllowNext
Gets a value that indicates whether the user is allowed to advance to the next item in the media collection during playback of the current item.
AllowPrevious
Gets a value that indicates whether the user is allowed to go back to the previous item in the media collection during playback of the current item.
AllowRewind
Gets a value that indicates whether the user is allowed to rewind to the beginning during playback of the current item.
AllowSeekBack
Gets a value that indicates whether the user is allowed to use the seek slider to move to a previous point (replay or frame step backward) during playback of the current item.
AllowSeekForward
Gets a value that indicates whether the user is allowed to use the seek slider to move to a later point (skip forward or frame step forward) during playback of the current item.
FriendlyData
Gets data strings to display in Now Playing in place of the metadata that is included in the media file.
Length
Gets or sets the duration for which the current item is played.
Media
Gets or sets the URI for the current media item.
PlaybackFlags
Gets or sets a value that indicates which playback capabilities are allowed for the current media item.
Start
Gets or sets the time offset from which the current item should start playing.
Tag
Gets or sets an application-specific object for the current media item.

Public Instance Events
Event	Description
PropertyChanged
Fires when a property of the current MediaCollectionItem object changes.

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter Namespace

# MediaCollectionItem Constructor
Initializes an instance of the MediaCollectionItem class.
Syntax
public MediaCollectionItem();

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	MediaCollectionItem Class
•	Microsoft.MediaCenter Namespace

# MediaCollectionItem.AllowFastForward Property
Gets a value that indicates whether the user is allowed to fast forward during playback of the current item.
Syntax
public override bool AllowFastForward {get;}

Property Value
System.Boolean.  If true, the user is allowed to fast forward during playback of this item; otherwise, false.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	MediaCollectionItem Class
•	Microsoft.MediaCenter Namespace

# MediaCollectionItem.AllowNext Property
Gets a value that indicates whether the user is allowed to advance to the next item in the media collection during playback of the current item.
Syntax
public override bool AllowNext {get;}

Property Value
System.Boolean.  If true, the user is allowed to advance to the next item during playback of this item; otherwise, false.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	MediaCollectionItem Class
•	Microsoft.MediaCenter Namespace

# MediaCollectionItem.AllowPrevious Property
Gets a value that indicates whether the user is allowed to go back to the previous item in the media collection during playback of the current item.
Syntax
public override bool AllowPrevious {get;}

Property Value
System.Boolean.  If true, the user is allowed to go back to the previous item during playback of the current item; otherwise, false.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	MediaCollectionItem Class
•	Microsoft.MediaCenter Namespace

# MediaCollectionItem.AllowRewind Property
Gets a value that indicates whether the user is allowed to rewind to the beginning during playback of the current item.
Syntax
public override bool AllowRewind {get;}

Property Value
System.Boolean.  If true, the user is allowed to rewind during playback of the current item; otherwise, false.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	MediaCollectionItem Class
•	Microsoft.MediaCenter Namespace

# MediaCollectionItem.AllowSeekBack Property
Gets a value that indicates whether the user is allowed to use the seek slider to move to a previous point (replay or frame step backward) during playback of the current item.
Syntax
public override bool AllowSeekBack {get;}

Property Value
System.Boolean.  If true, the user is allowed to seek to a previous point during playback of the current item; otherwise, false.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	MediaCollectionItem Class
•	Microsoft.MediaCenter Namespace

# MediaCollectionItem.AllowSeekForward Property
Gets a value that indicates whether the user is allowed to use the seek slider to move to a later point (skip forward or frame step forward) during playback of the current item.
Syntax
public override bool AllowSeekForward {get;}

Property Value
System.Boolean.  If true, the user is allowed to seek to a later point during playback of the current item; otherwise, false.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	MediaCollectionItem Class
•	Microsoft.MediaCenter Namespace

# MediaCollectionItem.FriendlyData Property
Gets data strings to display in Now Playing in place of the metadata that is included in the media file.
Syntax
public System.Collections.IDictionary FriendlyData {get;}

Property Value
System.Collections.IDictionary.  A collection of data strings (name-value pairs) that override the metadata for the current media item. These strings correspond to the following:
•	Title: A string that contains the title.
•	CreationTime: A DateTime value that contains the date created.
•	Duration: A TimeSpan value that contains the playback duration.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	MediaCollectionItem Class
•	Microsoft.MediaCenter Namespace

# MediaCollectionItem.Length Property
Gets or sets the duration for which the current item is played.
Syntax
public TimeSpan Length {get; set;}

Property Value
System.TimeSpan.  The length of time for which to play the current item. To play to the end of the media item, specify TimeSpan.MaxValue.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	MediaCollectionItem Class
•	Microsoft.MediaCenter Namespace

# MediaCollectionItem.Media Property
Gets or sets the URI for the current media item.
Syntax
public object Media {get; set;}

Property Value
System.Object.  The URI of the current media item.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	MediaCollectionItem Class
•	Microsoft.MediaCenter Namespace

# MediaCollectionItem.PlaybackFlags Property
Gets or sets a value that indicates which playback capabilities are allowed for the current media item.
Syntax
public MediaItemPlaybackCapabilities PlaybackFlags {get; set;}

Property Value
Microsoft.MediaCenter.MediaItemPlaybackCapabilities.  A bitflag value that indicates the playback capabilities of the current media item.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	MediaCollectionItem Class
•	Microsoft.MediaCenter Namespace

# MediaCollectionItem.PropertyChanged Event
Fires when a property of the current MediaCollectionItem object changes.
Syntax
public override Microsoft.MediaCenter.UI.PropertyChangedEventHandler PropertyChanged;

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	MediaCollectionItem Class
•	Microsoft.MediaCenter Namespace

# MediaCollectionItem.Start Property
Gets or sets the time offset from which the current item should start playing.
Syntax
public TimeSpan Start {get; set;}

Property Value
System.TimeSpan.  The time offset that indicates when the current item should start playing. A value less than or equal to zero indicates that playback should start from the beginning of the item.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	MediaCollectionItem Class
•	Microsoft.MediaCenter Namespace

# MediaCollectionItem.Tag Property
Gets or sets an application-specific object for the current media item.
Syntax
public object Tag {get; set;}

Property Value
System.Object.  An application-specific object. This object must be serializable; otherwise, this property will be set to null.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	MediaCollectionItem Class
•	Microsoft.MediaCenter Namespace

# MediaCollectionItemEventArgs Class
Contains information about events that are raised for items in a media collection.
public sealed class MediaCollectionItemEventArgs : EventArgs

Members
Public Instance Constructor
Method	Description
MediaCollectionItemEventArgs
Initializes a new instance of the MediaCollectionItemEventArgs class.

Public Instance Properties
Property	Description
Index
Gets the index of the media item that raised the event.
Item
Gets the object that contains the media item that raised the event.

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter Namespace

# MediaCollectionItemEventArgs Constructor
Initializes a new instance of the MediaCollectionItemEventArgs class.
Syntax
public MediaCollectionItemEventArgs(
  int  index,
  MediaCollectionItem  item
);

Parameters
index
System.Int32.  The index location of the media item in the media collection.
item
Microsoft.MediaCenter.MediaCollectionItem.  An object that contains a media item.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	MediaCollectionItemEventArgs Class
•	Microsoft.MediaCenter Namespace

# MediaCollectionItemEventArgs.Index Property
Gets the index of the media item that raised the event.
Syntax
public int Index {get;}

Property Value
System.Int32.  A value that indicates the index location of the media item.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	MediaCollectionItemEventArgs Class
•	Microsoft.MediaCenter Namespace

# MediaCollectionItemEventArgs.Item Property
Gets the object that contains the media item that raised the event.
Syntax
public MediaCollectionItem Item {get;}

Property Value
Microsoft.MediaCenter.MediaCollectionItem.  An object that contains a media item.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	MediaCollectionItemEventArgs Class
•	Microsoft.MediaCenter Namespace

# MediaExperience Class
Enables applications to retrieve information about the current Windows Media Center experience.
Syntax
public sealed class MediaExperience : Microsoft.MediaCenter.UI.IPropertyObject

Public Instance Methods
Method	Description
GetMediaCollection
Retrieves the media collection that was last played.
GoToFullScreen
Moves the current media playback experience into full-screen mode.

Public Instance Properties
Property	Description
EntryPointId
Gets or sets the GUIDs that uniquely identify an application entry point, which is launched when the user selects Now Playing.
IsFullScreen
Gets a value that iIndicates whether the current Windows Media Center experience is in full-screen mode.
MediaMetadata
Gets a collection of key-value pairs that provide information about the currently playing media.
Transport
Gets the MediaTransport class that enables an application to control playback of the current media.
Url
Gets or sets the URL of an application, which is launched when the user selects Now Playing.

Public Instance Events
Event	Description
PropertyChanged
Raised when a MediaExperience property changes.

See Also
•	Managed Code Object Model Reference

# MediaExperience.EntryPointId Property
Gets or sets the GUIDs that uniquely identify an application entry point, which is launched when the user selects Now Playing.
Syntax
public string EntryPointId {get; set;}

Property Value
System.String.  The two GUIDs that uniquely identify an application entry point. The format of the string is "applicationguid\entrypointguid".
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MediaExperience Class
•	Microsoft.MediaCenter Namespace

# MediaExperience.GetMediaCollection Method
Retrieves the media collection that was last played. Applications can restore the collection and continue playback.
Syntax
public void GetMediaCollection(
  MediaCollection  destination
);

Parameters
destination
Microsoft.MediaCenter.MediaCollection.  The last media collection that was played.
Return Value
This method does not return a value.
Remarks
This method only returns media collections that were created by Windows Media Center Presentation Layer applications. This method does not return playlists that the user created in the main Windows Media Center experience.
Only the application that created the media collection can modify it. The collection is read-only for other applications.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	MediaExperience Class
•	Microsoft.MediaCenter Namespace
# MediaExperience.GoToFullScreen Method
Moves the current media playback experience into full-screen mode.
Syntax
public void GoToFullScreen();

Parameters
This method takes no parameters.
Return Value
This method does not return a value.
Remarks
By default, playback for media content will appear in whatever view port (shared or custom) is open on your page. Use this method to move the playback to full-screen mode.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MediaExperience Class

# MediaExperience.IsFullScreen Property
Gets a value that indicates whether the current Windows Media Center experience is in full-screen mode.
Syntax
public Boolean IsFullScreen {get;}

Property Value
System.Boolean. It is true if the current experience is in full-screen mode, and false otherwise.
This property is read-only.
Remarks
An application can use this property to determine whether a call to the ApplicationContext.ReturnToApplication method would be appropriate.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MediaExperience Class

# MediaExperience.MediaMetadata Property
Gets a collection of key-value pairs that provides information about the current media experience.
Syntax
public MediaMetadata MediaMetadata {get;}

Property Value
MediaMetadata. A collection of key-value pairs. Each key is a string that identifies the corresponding value. For more information, see the Remarks section.
This property is read-only.
Remarks
For examples of the available properties, see the MediaMetadata class.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MediaExperience Class
•	MediaMetadata Class

# MediaExperience.PropertyChanged Event
Raised when a MediaExperience property changes.
Syntax
public override Microsoft.MediaCenter.UI.PropertyChangedEventHandler PropertyChanged;

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MediaExperience Class
•	Microsoft.MediaCenter Namespace

# MediaExperience.Transport Property
Gets the MediaTransport class that enables an application to control playback of the current media.
Syntax
public MediaTransport Transport {get;}

Property Value
Microsoft.MediaCenter.MediaTransport. The class that is used to control media playback.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MediaExperience Class
•	MediaTransport Class

# MediaExperience.Url Property
Gets or sets the URL of an application, which is launched when the user selects Now Playing.
Syntax
public Uri Url {get; set;}

Property Value
System.Uri.  The uniform resource identifier (URI) of the application.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MediaExperience Class
•	Microsoft.MediaCenter Namespace

# MediaItemPlaybackCapabilities Enumeration
Contains bitflag values that indicate which actions are allowed during playback. The application specifies a value that corresponds to a combination of the actions to allow.
public enum MediaItemPlaybackCapabilities

Members
Value	Description	Bitflag value
None	No playback action are allowed.	0x0000
AllowFastForward	Fast forward is allowed.	0x0001
AllowRewind	Rewind is allowed.	0x0002
AllowSeekForward	Seeking forward is allowed.	0x0004
AllowSeekBack	Seeking back is allowed.	0x0008
AllowNext	Advancing to the next item is allowed.	0x0010
AllowPrevious	Going back to the previous item is allowed.	0x0020
All	All playback actions are allowed.	0xffff

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter Namespace

# MediaMetadata Class
Provides an index into the media metadata properties that have been defined.
Syntax
public sealed class MediaMetadata : System.Collections.Generic.Dictionary<string,object>

Remarks
The information that is retrieved depends on the current media experience. If the current experience is Live TV or Recorded TV, the property is null.
The properties in the collection vary depending on the current media context, as shown in the following table:
Context	Property	Description
album	AlbumArtist	Name of the album artist.
	AlbumName	Name of the album.
	Genre	Name of the musical genre.
	Label	Name of the recording label.
	ReleaseDate	Release date of the album.
artist	Artist	Name of the recording artist.
genre	Genre	Name of the musical genre.
playlist	Name	Name of the playlist.
	URL	Name of the playlist file.
song	AlbumArtist	Name of the album recording artist
	AlbumTitle	Title of the album
	Genre	Genre of the music
	Label	Name of the recording label
	ProductionCompany	Name of the music production company
	ReleaseDate	Date when the album was released
	TrackArtist	Name of the artist who recorded the currently playing track
	TrackComposer	Name of the composer of the currently playing track
	TrackDuration	Total length, in seconds, of the currently playing track
	TrackNumber	Number of the currently playing track
	TrackTitle	Title of the currently playing track
DVD	ChapterTitle	Title of the currently playing chapter
	Director	Director of the video
	Duration	Total length, in seconds, of the video
	MPAARating	Parental advisory rating of the video
	ProductionCompany	Name of the video production company
	ReleaseDate	Date when the video was released
	Title	Title of the video
video	Duration	Total length, in seconds, of the video
	MPAARating	Parental advisory rating of the video
	Title	Title of the video
picture	Name	The path and file name of the image.

See Also
•	Managed Code Object Model Reference

# MediaTransport Class
Enables applications to control playback of the current media.
Syntax
public sealed class MediaTransport : Microsoft.MediaCenter.UI.IPropertyObject

Public Instance Methods
Method	Description
SkipBack
Invokes the skip-back action on the current media, moving the playback back by seven seconds. For music files, it moves the playback to the beginning of the file.
SkipForward
Invokes the skip-forward action on the current media, moving the playback forward by 29 seconds. For music files, it moves the playback to the end of the file.

Public Instance Properties
Property	Description
BufferingProgress
Gets a value that indicates the buffering progress of the media that is currently active.
PlayRate
Gets or sets the current play rate and direction of the current media.
PlayState
Gets the play state of the current media.
Position
Gets or sets the current position in the media stream, relative to a starting point.

Public Instance Events
Event	Description
PropertyChanged
Raised when the PlayRate, PlayState, or Position property changes.

See Also
•	Managed Code Object Model Reference

# MediaTransport.BufferingProgress Property
Gets a value that indicates the buffering progress of the media that is currently active.
Syntax
public float BufferingProgress {get;}

Property Value
System.Single.  A value that indicates the buffering progress. A value of 1 is 100%, .5 is 50%, and so forth. A value of -1 indicates there was an internal problem retrieving the value.
This property is read-only.
Remarks
When this property changes, the Microsoft.MediaCenter.MediaTransport.PropertyChanged event is fired.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	MediaTransport Class
•	Microsoft.MediaCenter Namespace

# MediaTransport.PlayRate Property
Gets or sets the current play rate and direction of the current media.
Syntax
public Single PlayRate {get; set;}

Property Value
System.Single. The current play rate. It must be one of the following values:
Value	Description
0	Stop
1	Pause
2	Play
3	FF1 (fast)
4	FF2 (faster)
5	FF3 (fastest)
6	Rewind1 (fast)
7	Rewind2 (faster)
8	Rewind3 (fastest)
9	SlowMotion1 (slow)
10	SlowMotion2 (slower)
11	SlowMotion3 (slowest)

This property is read/write.
Remarks
Use the PlayState property to retrieve the state of the current media.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MediaTransport Class

# MediaTransport.PlayState Property
Gets the play state of the current media.
Syntax
public PlayState PlayState {get;}

Property Value
Microsoft.MediaCenter.PlayState. The play state.
This property is read-only.
Remarks
Use the PlayRate property to retrieve the rate and direction of the current media.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MediaTransport Class
•	PlayState Enumeration

# MediaTransport.Position Property
Gets or sets the current position in the media stream, relative to a starting point.
Syntax
public System.TimeSpan Position {get; set;}

Property Value
System.TimeSpan. The current position of the media playback relative to a starting point. The starting point varies according to the medium as follows.
Medium	Description
DVD	Gets or sets the offset from the start of the video, in milliseconds.
FM Radio	Gets or sets the offset from the start of the radio program, in milliseconds. Radio programs are presumed to start in half-hour intervals on the hour or half hour (for example, 4:00 and 4:30).
TV	Gets or sets the offset from the start of the currently playing TV program, in milliseconds.
Video	Gets or sets the offset from the start of the video, in milliseconds.

This property is read/write.
Remarks
The pause buffer for TV or FM radio is up to 30 minutes long, starting from the time the user tunes in. If you specify a value for this property, the new value sets the playback position to a particular point in the buffer. You can set the position to any time that is later than the time the user tuned in the current channel, up to the current time. Setting the position to a time that occurred before the user tuned in the current channel moves the playback position to the beginning of the buffer. Setting the position to a time that is later than the current time returns Windows Media Center to live playback.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MediaTransport Class

# MediaTransport.PropertyChanged Event
Raised when the PlayRate, PlayState, or Position properties change.
Syntax
public override Microsoft.MediaCenter.UI.PropertyChangedEventHandler PropertyChanged;

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MediaTransport Class
•	Microsoft.MediaCenter Namespace

# MediaTransport.SkipBack Method
Invokes the skip-back action on the current media, moving the playback back by seven seconds. For music files, it moves the playback to the beginning of the file.
Syntax
public void SkipBack();

Parameters
This method takes no parameters.
Return Value
This method does not return a value.
Remarks
The pause buffer for TV or FM radio is up to 30 minutes long, starting from the time the user tunes in. You can skip back as far as the beginning of the buffer. For music files, the SkipBack method will start the music file from the beginning.
In the Windows Media Center UI in DVD settings, users have the option of setting the Skip and Replay buttons on the remote control to skip to the previous or next chapter, or to skip backward and forward by time increments. The SkipBack method will perform the same action the user has chosen.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MediaTransport Class
•	MediaTransport.SkipForward Method

# MediaTransport.SkipForward Method
Invokes the skip-forward action on the current media, moving the playback forward by 29 seconds. For music files, it moves the playback to the end of the file.
Syntax
public void SkipForward();

Parameters
This method takes no parameters.
Return Value
This method does not return a value.
Remarks
The pause buffer for TV or FM radio is up to 30 minutes long, starting from the time that the user tunes in. From any earlier point in the pause buffer, you can continuously skip forward up to the present "live" playback.
In the Windows Media Center UI in DVD settings, users have the option of setting the Skip and Replay buttons on the remote control to skip to the previous or next chapter, or to skip backward and forward by time increments. The SkipForward method will perform the same action the user has chosen.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MediaTransport Class
•	MediaTransport.SkipBack Method

# MediaType Enumeration
Contains values that identify the types of media content that can be played in Windows Media Center.
Syntax
public enum MediaType

The MediaType enumeration defines the following constants:
Constant	Description
Audio	Audio content
Datacast	Datacast content
Dvd	DVD content
Dvr	DVR content
MediaCollection	A collection of media content
Radio	Radio content
TV	TV content
Unknown	Unknown content
Video	Video content

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter Namespace

# MetadataAccessDisabledException Class
Contains information about an exception that was raised because an application tried to access Windows Media Center metadata, but the user has chosen to block access to metadata.
Syntax
public class MetadataAccessDisabledException : System.InvalidOperationException

Public Instance Constructors
Constructor	Description
MetadataAccessDisabledException()
Initializes an instance of the MetadataAccessDisabledException class.
MetadataAccessDisabledException(string)	Initializes an instance of the MetadataAccessDisabledException class.
MetadataAccessDisabledException(string, Exception)	Initializes an instance of the MetadataAccessDisabledException class.

Protected Instance Constructors
Constructor	Description
MetadataAccessDisabledException(SerializationInfo, StreamingContext)	Initializes an instance of the MetadataAccessDisabledException class.

See Also
•	Managed Code Object Model Reference

# MetadataAccessDisabledException.MetadataAccessDisabledException Constructor
Initializes an instance of the MetadataAccessDisabledException class.
Overload List
public MetadataAccessDisabledException()

public MetadataAccessDisabledException(string)

public MetadataAccessDisabledException(string, Exception)

protected MetadataAccessDisabledException(SerializationInfo, StreamingContext)

# MetadataAccessDisabledException.MetadataAccessDisabledException Constructor
Initializes an instance of the MetadataAccessDisabledException class.
Syntax
public MetadataAccessDisabledException();
# MetadataAccessDisabledException.MetadataAccessDisabledException Constructor
Initializes an instance of the MetadataAccessDisabledException class.
Syntax
public MetadataAccessDisabledException(
   string message
);
Parameters
message
System.String.  A description of the exception.
# MetadataAccessDisabledException.MetadataAccessDisabledException Constructor
Initializes an instance of the MetadataAccessDisabledException class.
Syntax
public MetadataAccessDisabledException(
   string message,
   Exception inner
);

Parameters
message
System.String.  A description of the exception.
inner
System.Exception.  The class on which this exception is based.
# MetadataAccessDisabledException.MetadataAccessDisabledException Constructor
Initializes an instance of the MetadataAccessDisabledException class.
Syntax
protected MetadataAccessDisabledException(
   SerializationInfo info,
   StreamingContext context
);

Parameters
info
System.Runtime.Serialization.SerializationInfo.  An instance of the class that contains the information needed to serialize the new MetadataAccessDisabledException object.
context
System.Runtime.Serialization.StreamingContext.  A structure that contains contextual information about the source of the serialized stream associated with the new MetadataAccessDisabledException object.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MetadataAccessDisabledException Class

# PageId Enumeration
Contains the identifiers (GUIDs) of various locations (pages) within the Windows Media Center user interface. An application uses these identifiers to specify the destination page when calling the MediaCenterEnvironment.NavigateToPage method.
Syntax
public enum PageId

The PageId enumeration exposes the following constants, which correspond to a feature within Windows Media Center:
Constant	Feature
ExtensibilityUrl	Hosted HTML application
FMRadio	Radio
InternetRadio	Radio
LiveTV	Live TV
ManageDisks	Manage Discs
MorePrograms	Extras Library
MovieLibrary	Movies
MusicAlbums	Albums
MusicArtists	Artists
MusicSongs	Songs
MyMusic	Music Library
MyPictures	Picture Library
MyTV	Recorded TV
MyVideos	Video Library
PhotoDetails	Picture Details
RecordedTV	Recorded TV
RecorderStorageSettings	Recorder Storage
ScheduledTVRecordings	Scheduled
Slideshow	Picture Slide Show
SlideshowSettings	Pictures Settings
Start	Start
TVGuide	Guide
Visualizations	Visualizations
WebAddIn	Windows Media Center Presentation Layer application

See Also
•	Managed Code Object Model Reference
•	MediaCenterEnvironment.NavigateToPage Method

# ParentalControls Class
Provides a way for Windows Media Center applications to select the type of parental control settings to query. An application can query the current parental control settings for movie or TV viewing. To get this class, use the MediaCenterEnvironment.ParentalControls property.
Syntax
public sealed class ParentalControls : Dictionary<string, ParentalControlSetting>

Public Instance Methods
Method	Description
GetAvailableRatingSystems
Gets a collection of strings containing the names of the parental control settings that are currently supported.
PromptForPin
Displays a page that requires the user to enter the four-digit parental control code before allowing access to restricted content.

See Also
•	Microsoft.MediaCenter Namespace
•	ParentalControlSetting Class

# ParentalControls.GetAvailableRatingSystems Method
Gets a collection of strings containing the names of the parental control settings that are currently supported.
Syntax
public System.Collections.ObjectModel.Collection<string> GetAvailableRatingSystems();

Return Value
System.Collections.ObjectModel.Collection<System.String>.  The setting names. These strings can be used with the indexer function of the ParentalsControls object to retrieve individual ParentalControlSetting objects for the specified rating system.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ParentalControls Class

# ParentalControls.PromptForPin Method
Displays a page that requires the user to enter the four-digit parental control code before allowing access to restricted content.
Syntax
public void PromptForPin(
   ParentalPromptCompletedCallback parentalControlCallback
);

Parameters
parentalControlCallback
Microsoft.MediaCenter.ParentalPromptCompletedCallback.  The name of a ParentalPromptCompletedCallback delegate. Windows Media Center calls this delegate, passing a value that indicates whether the user entered the correct parental control code.
Return Value
This method does not return a value.
Remarks
When the page is dismissed, Windows Media Center passes one of the following values to the parentalControlCallback parameter:
Value	Description
0	The user entered an incorrect parental control code.
1	The user entered the correct parental control code.

Important   An on-demand application must not use this method. The application would need to block execution while waiting for the result to be passed to its delegate. However, the application cannot block execution without also blocking the execution of Windows Media Center, meaning that the result would never reach the delegate.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ParentalControls Class

# ParentalControlSetting Class
Provides a way for Windows Media Center applications to query the various parental control settings for movie or TV viewing. Applications retrieve this class by using the properties and methods of the ParentalControls class.
Syntax
public class ParentalControlSetting
Public Instance Properties
Property	Description
BlockUnrated
Gets a value that indicates whether the user has chosen to prevent viewing of unrated content.
Enabled
Gets a value that indicates whether the user has turned on the parental control feature.
MaxAllowed
Gets a value that indicates the overall maximum content rating allowed.
RatingSystem
Gets the name of the content rating system associated with this ParentalControlSetting class.

See Also
•	Microsoft.MediaCenter Namespace
•	ParentalControls Class
•	USTVRatings Class

# ParentalControlSetting.BlockUnrated Property
Gets a value that indicates whether the user has chosen to prevent viewing of unrated content.
Syntax
public bool BlockUnrated {get;}

Property Value
System.Boolean  It is true if unrated content is blocked, and false if it is not.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ParentalControlSetting Class

# ParentalControlSetting.Enabled Property
Gets a value that indicates whether the user has turned on the parental control feature.
Syntax
public bool Enabled {get;}

Property Value
System.Boolean  It is true if parental controls are enabled, and false if not.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ParentalControlSetting Class

# ParentalControlSetting.MaxAllowed Property
Gets a value that indicates the overall maximum content rating allowed.
Syntax
public int MaxAllowed {get;}

Property Value
System.Int32. The maximum rating. For more information, see the Remarks section.
This property is read-only.
Remarks
The meaning of this property value depends on the type of content being queried. For US TV content, this property is a number that maps to a TV content rating. It can be any of the following values:
Value	TV rating
0 (default)	unrated content
1	TV-Y
2	Y7
3	G
4	PG
5	14
6	MA

For movie or DVD content, this property is a number that maps to a Motion Picture Association of America (MPAA) content rating. It can be any of the following values:
Value	MPAA
0	unrated content
1	G
2	not used
3	PG
4	PG-13
5	not used
6	R
7	NC-17
8	not used

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ParentalControlSetting Class

# ParentalControlSetting.RatingSystem Property
Gets the name of the content rating system associated with this ParentalControlSetting class.
Syntax
public string RatingSystem {get;}

Property Value
System.String. The name of the content rating system. It must be one of the following values:
Value	Description
"EN-US-MOVIE"	Movie settings
"EN-US-TV"	TV settings

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ParentalControlSetting Class

# ParentalPromptCompletedCallback Delegate
Represents the method that handles the result of calling the ParentalControls.PromptForPin method, indicating whether the user entered the correct parental control code.
Syntax
public delegate void ParentalPromptCompletedCallback(
  bool  pinEnteredCorrectly
);

Parameters
pinEnteredCorrectly
System.Boolean.  It is true when the parental control code is entered correctly, and false when incorrect.
Return Value
This method does not return a value.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter Namespace

# PlayState Enumeration
Defines values that indicate the play state of the current media. These values are used by the MediaTransport.PlayState property.
Syntax
public enum PlayState

The PlayState enumeration defines the following constants:
Constant	Description
Buffering	The media is buffering.
Finished	The media has finished playing.
Paused	The media is paused.
Playing	The media is playing.
Stopped	The media is stopped.
Undefined	The play state of the media is unknown.

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Managed Code Object Model Reference
•	MediaTransport.PlayState Property

# ShortcutStatus Enumeration
Contains values that indicate the user's response to the dialog box created by the CreateDesktopShortcut method.
Syntax
public enum ShortcutStatus

The ShortcutStatus enumeration defines the following constants:
Constant	Description
Cancelled	The user clicked the Cancel button.
InstallLater	The user clicked the Save Link To Desktop button.
InstallNow	The user clicked the Open Website in Browser button.

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	CreateDesktopShortcut Method
•	Microsoft.MediaCenter Namespace

# StateDetectionDisabledException Class
Contains information about an exception that was raised because an application tried to access Windows Media Center state information, but the user has chosen to block access to state information.
Syntax
public class StateDetectionDisabledException : System.InvalidOperationException

Public Instance Constructors
Constructor	Description
StateDetectionDisabledException()
Initializes an instance of the StateDetectionDisabledException class.
StateDetectionDisabledException(string)	Initializes an instance of the StateDetectionDisabledException class.
StateDetectionDisabledException(string, Exception)	Initializes an instance of the StateDetectionDisabledException class.

Protected Instance Constructors
Constructor	Description
StateDetectionDisabledException(SerializationInfo, StreamingContext)	Initializes an instance of the StateDetectionDisabledException class.

See Also
•	Managed Code Object Model Reference

# StateDetectionDisabledException.StateDetectionDisabledException Constructor
Initializes an instance of the StateDetectionDisabledException class.
Overload List
public StateDetectionDisabledException()

public StateDetectionDisabledException(string)

public StateDetectionDisabledException(string, Exception)

protected StateDetectionDisabledException(SerializationInfo, StreamingContext)


# StateDetectionDisabledException.StateDetectionDisabledException Constructor
Initializes an instance of the StateDetectionDisabledException class.
Syntax
public StateDetectionDisabledException();
# StateDetectionDisabledException.StateDetectionDisabledException Constructor
Initializes an instance of the StateDetectionDisabledException class.
Syntax
public StateDetectionDisabledException(
   string message
);
Parameters
message
System.String.  A description of the exception.
# StateDetectionDisabledException.StateDetectionDisabledException Constructor
Initializes an instance of the StateDetectionDisabledException class.
Syntax
public StateDetectionDisabledException(
   string message,
   Exception inner
);
Parameters
message
System.String.  A description of the exception.
inner
System.Exception.  The class on which this exception is based.
# StateDetectionDisabledException.StateDetectionDisabledException Constructor
Initializes an instance of the StateDetectionDisabledException class.
Syntax
protected StateDetectionDisabledException(
   SerializationInfo info,
   StreamingContext context
);

Parameters
info
System.Runtime.Serialization.SerializationInfo. An instance of the class containing the information needed to serialize the new StateDetectionDisabledException object.
context
System.Runtime.Serialization.StreamingContext. A structure that contains contextual information about the source of the serialized stream associated with the new StateDetectionDisabledException object.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	StateDetectionDisabledException Class

# UserInfo Class
Provides information about the current Windows Media Center user.
Syntax
public class UserInfo

Public Instance Properties
Property	Description
PostalCode
Gets the user's postal code (ZIP Code), if available.

See Also
•	Managed Code Object Model Reference

# UserInfo.PostalCode Property
Gets the user's postal code (ZIP Code), if available.
Syntax
public string PostalCode {get;}

Property Value
System.String  The user's postal code. If the user has not provided a postal code, the property value is null. If the user's privacy settings block access to the postal code, attempting to read this property causes an exception.
This property is read-only.
Remarks
This property enables applications to be customized according to the user's location. For example, a news provider could use the postal code to determine what local news, sports, and weather information to provide.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	UserInfo Class

# USTVRatings Class
Provides a way for applications to query the extended TV content ratings.
Syntax
public class USTVRatings : ParentalControlSetting
Public Instance Properties
Property	Description
FantasyViolenceAllowed
Gets a value that indicates whether the user has chosen to allow viewing of content containing fantasy violence.
MaxDialogueAllowed
Gets a value that indicates the maximum allowed TV rating for content containing suggestive dialog.
MaxLanguageAllowed
Gets a value that indicates the maximum allowed TV rating for content containing offensive language.
MaxSexAllowed
Gets a value that indicates the maximum allowed TV rating for sexual content.
MaxViolenceAllowed
Gets a value that indicates the maximum allowed TV rating for violent content.

See Also
•	Microsoft.MediaCenter Namespace

# USTVRatings.FantasyViolenceAllowed Property
Gets a value that indicates whether the user has chosen to allow viewing of TV content containing fantasy violence.
Syntax
public bool FantasyViolenceAllowed {get;}

Property Value
System.Boolean. It is true if viewing of fantasy violence is allowed, or false if not.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	USTVRatings Class

# USTVRatings.MaxDialogueAllowed Property
Gets a value that indicates the maximum allowed TV rating for content containing suggestive dialog.
Syntax
public int MaxDialogueAllowed {get;}

Property Value
System.Int32. The maximum rating. It must be one of the following values:
Value	TV Rating
0 (default)	unrated content
1	TV-Y
2	Y7
3	G
4	PG
5	14
6	MA

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	USTVRatings Class

# USTVRatings.MaxLanguageAllowed Property
Gets a value that indicates the maximum allowed TV rating for content containing offensive language.
Syntax
public int MaxLanguageAllowed {get;}

Property Value
System.Int32. The maximum rating. For more information, see the Remarks for the MaxDialogueAllowed property.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	USTVRatings Class

# USTVRatings.MaxSexAllowed Property
Gets a value that indicates the maximum allowed TV rating for sexual content.
Syntax
public int MaxSexAllowed {get;}

Property Value
System.Int32. The maximum rating. For more information, see the Remarks for the MaxDialogueAllowed property.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	USTVRatings Class

# USTVRatings.MaxViolenceAllowed Property
Gets a value that indicates the maximum allowed TV rating for violent content.
Syntax
public int MaxViolenceAllowed {get;}

Property Value
System.Int32. The maximum rating. For more information, see the Remarks for the MaxDialogueAllowed property.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	USTVRatings Class

# Microsoft.MediaCenter.DataAccess Namespace
The following types are in the Microsoft.MediaCenter.DataAccess namespace, which is in the microsoft.mediacenter.dll assembly.
The Microsoft.MediaCenter.DataAccess namespace exposes the following classes:
Class	Description
RemoteResource
Works with data from a remote resource. Use this class to construct a data request, process the response, and parse the data that is received.
RemoteResourceUri
Used to construct and access a Uniform Resource Identifier (URI) that identifies a remote resource.
RemoteValue
Defines how RemoteResource data is parsed, mapped (bound) to view items, and typed.
RemoteValueList
Represents a list of RemoteResource objects.
SortableList
Provides sorting functionality for RemoteValueList and XmlRemoteValueList objects to sort the list of returned data.
XmlRemoteResource
Works with XML data from a remote resource. Use this class to construct a data request, process the response, and parse the data that is received. This class applies XML-specific parsing and mapping.
XmlRemoteValue
Defines how XmlRemoteResource data is parsed, mapped (bound) to view items, and typed. This class applies XML-specific parsing and mapping.
XmlRemoteValueList
Represents a list of XmlRemoteResource objects. This class applies XML-specific parsing and mapping.

The Microsoft.MediaCenter.DataAccess namespace exposes the following enumerations:
Enumeration	Description
ListItemState
Not documented in this release.
RemoteResourceStatus
Contains values that indicate the result of processing a data access request to a remote resource.

See Also
•	Programming Reference
•	Binding to XML Data From the Web

# ListItemState Enumeration
Not documented in this release.
public enum ListItemState

Value	Description
Available	Not documented in this release.
Initialized	Not documented in this release.
Pending	Not documented in this release.

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace

# RemoteResource Class
Works with data from a remote resource. Use this class to construct a data request, process the response, and parse the data that is received.
public abstract class RemoteResource : Microsoft.MediaCenter.UI.ModelItem

Protected Instance Constructor
Method	Description
RemoteResource
Initializes a new instance of the RemoteResource class.

Public Instance Methods
Method	Description
GetDataFromResource
Begins the data request.
PerformRedirect
Redirects the response to a specified URI.
Validate
Validates the response data.

Public Instance Properties
Property	Description
DefaultRequestMethod
Gets the default request method.
HasError
Indicates whether the data contains errors.
Mappings
Gets or sets a collection of RemoteValue objects that indicate how to map the data.
RequestChanged
Gets or sets a value that indicates whether the data request has changed.
RequestComplete
Gets a value that indicates whether the data request is complete.
RequestDocument
Gets or sets the request document.
RequestGeneration
Not documented in this release.
RequestHeaders
Gets or sets the headers in the data request.
RequestMethod
Gets or sets the request method.
RequestUri
Gets or sets the URI to the remote resource.
ResponseDocument
Gets the response document.
ResponseHeaders
Gets the response headers.
ResponseStatusCode
Gets the status code of the response.
ResponseStatusDescription
Gets the description of the status code.
Status
Gets a value that indicates the status of the data request.

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace

# RemoteResource Constructor
Initializes a new instance of the RemoteResource class.
Syntax
protected RemoteResource();

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteResource Class

# RemoteResource.DefaultRequestMethod Property
Gets the default request method.
Syntax
public string DefaultRequestMethod {get;}

Property Value
System.String.  The default request method.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteResource Class

# RemoteResource.GetDataFromResource Method
Begins the data request.
Syntax
public virtual bool GetDataFromResource();

Return Value
System.Boolean.  Indicates whether the request was successful.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteResource Class

# RemoteResource.HasError Property
Indicates whether the data contains errors.
Syntax
public bool HasError {get;}

Property Value
System.Boolean.  If true, the data contains an error; otherwise, false.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteResource Class

# RemoteResource.Mappings Property
Gets or sets a collection of RemoteValue objects that indicate how to map the data.
Syntax
public Microsoft.MediaCenter.UI.PropertySet Mappings {get; set;}

Property Value
Microsoft.MediaCenter.UI.PropertySet.  Contains the RemoteValue objects.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteResource Class

# RemoteResource.PerformRedirect Method
Redirects the response to a specified URI.
Syntax
public virtual bool PerformRedirect(
  Uri  redirectUri
);

Parameters
redirectUri
System.Uri.  The URI.
Return Value
System.Boolean.  If true, the request was succesful; otherwise, false.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteResource Class

# RemoteResource.RequestChanged Property
Gets or sets a value that indicates whether the data request has changed.
Syntax
public bool RequestChanged {get; set;}

Property Value
System.Boolean.  If true, the request has changed; otherwise, false.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteResource Class

# RemoteResource.RequestComplete Property
Gets a value that indicates whether the data request is complete.
Syntax
public bool RequestComplete {get;}

Property Value
System.Boolean.  If true, the data request is complete; otherwise, false.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteResource Class

# RemoteResource.RequestDocument Property
Gets or sets the request document.
Syntax
public string RequestDocument {get; set;}

Property Value
System.String.  The request document.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteResource Class

# RemoteResource.RequestGeneration Property
Not documented in this release.
Syntax
public int RequestGeneration {get;}

Property Value
System.Int32.  Not documented in this release.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteResource Class

# RemoteResource.RequestHeaders Property
Gets or sets the headers in the data request.
Syntax
public System.Collections.IDictionary RequestHeaders {get; set;}

Property Value
System.Collections.IDictionary.  The header data.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteResource Class

# RemoteResource.RequestMethod Property
Gets or sets the request method.
Syntax
public string RequestMethod {get; set;}

Property Value
System.String.  The request method.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteResource Class

# RemoteResource.RequestUri Property
Gets or sets the URI to the remote resource.
Syntax
public RemoteResourceUri RequestUri {get; set;}

Property Value
Microsoft.MediaCenter.DataAccess.RemoteResourceUri.  Not documented in this release.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteResource Class

# RemoteResource.ResponseDocument Property
Gets the response document.
Syntax
public string ResponseDocument {get;}

Property Value
System.String.  The response document.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteResource Class

# RemoteResource.ResponseHeaders Property
Gets the response headers.
Syntax
public System.Collections.IDictionary ResponseHeaders {get;}

Property Value
System.Collections.IDictionary.  The response header data.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteResource Class

# RemoteResource.ResponseStatusCode Property
Gets the status code of the response.
Syntax
public int ResponseStatusCode {get;}

Property Value
System.Int32.  The status code.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteResource Class

# RemoteResource.ResponseStatusDescription Property
Gets the description of the status code.
Syntax
public string ResponseStatusDescription {get;}

Property Value
System.String.  The status code description.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteResource Class

# RemoteResource.Status Property
Gets a value that indicates the status of the data request.
Syntax
public RemoteResourceStatus Status {get;}

Property Value
Microsoft.MediaCenter.DataAccess.RemoteResourceStatus.  A value that indicates the status of the data request.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteResource Class

# RemoteResource.Validate Method
Validates the response data.
Syntax
public virtual bool Validate();

Return Value
System.Boolean.  If true, the data is valid; otherwise, false.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteResource Class

# RemoteResourceStatus Enumeration
Contains values that indicate the result of processing a data access request to a remote resource.
public enum RemoteResourceStatus

Value	Description
Complete	The response has been sucessfully processed.
Error	An error occurred.
ErrorAborted	An error occurred and the request has been stopped.
ErrorBaseMax
ErrorCodelessLockdown
ErrorMappings	An error occurred in the data mapping.
ErrorParsing	An error occurred while  parsing the response.
ErrorRequest	An error occurred while submitting the request.
ErrorRequestDocument	An error occurred in the request document.
ErrorRequestHeaders	An error occurred in the request headers.
ErrorRequestScheme	An error occurred in the request scheme.
ErrorRequestSecurity	An error occurred in the request security.
ErrorRequestUri	An error occurred in the URI to the remote resource.
ErrorResponse	An error occurred in the response.
ErrorResponseRedirect	An error occurred while redirecting the response.
Initialized	The data request has been created but has not yet been processed.
ParsingData	The response is being processed.
RequestingData	The data request is being submitted.

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace

# RemoteResourceUri Class
Used to construct and access a Uniform Resource Identifier (URI) that identifies a remote resource. A URI string can contain the following segments:
scheme://username:password@host:port/path;parameter?query#fragment
You can set the full string and the other properties will parsed from it. Or, set the individual properties to construct the URI in segments.
public class RemoteResourceUri : Microsoft.MediaCenter.UI.ModelItem

Public Instance Constructor
Method	Description
RemoteResourceUri
Initializes a new instance of the RemoteResourceUri class.

Public Instance Properties
Property	Description
Fragment
Gets or sets the fragment segment of the URI string.
FullString
Gets or sets the entire URI as a string.
Host
Gets or sets the host segment of the URI string.
Password
Gets or sets the password segment of the URI string.
Path
Gets or sets the path segment of the URI string.
PathSegments
Gets or sets a list of path segments of the URI string.
Port
Gets or sets the port segment of the URI string.
Query
Gets or sets the query segment of the URI string.
QueryPairs
Gets or sets query name-value pairs in the URI string.
Scheme
Gets or sets the scheme segment of the URI string.
Uri
Gets or sets the entire URI as a System.URI object.
UserName
Gets or sets the username segment of the URI string.

Public Instance Events
Event	Description
UriChanged
Raised when the remote resource URI changes.

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace

# RemoteResourceUri Constructor
Initializes a new instance of the RemoteResourceUri class.
Syntax
public RemoteResourceUri();

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteResourceUri Class

# RemoteResourceUri.Fragment Property
Gets or sets the fragment segment of the URI string.
Syntax
public string Fragment {get; set;}

Property Value
System.String.  The fragment segment of the URI.
This property is read/write.
Remarks
A URI consists of the following segments:
scheme://username:password@host:port/path;parameter?query#fragment
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteResourceUri Class

# RemoteResourceUri.FullString Property
Gets or sets the URI as a string.
Syntax
public string FullString {get; set;}

Property Value
System.String.  The complete URI.
This property is read/write.
Remarks
When the FullString property is set, the other RemoteResourceURI properties are parsed from it.
A URI consists of the following segments:
scheme://username:password@host:port/path;parameter?query#fragment
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteResourceUri Class

# RemoteResourceUri.Host Property
Gets or sets the host segment of the URI string.
Syntax
public string Host {get; set;}

Property Value
System.String.  The host segment of the URI.
This property is read/write.
Remarks
A URI consists of the following segments:
scheme://username:password@host:port/path;parameter?query#fragment
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteResourceUri Class

# RemoteResourceUri.Password Property
Gets or sets the password segment of the URI string.
Syntax
public string Password {get; set;}

Property Value
System.String.  The password segment of the URI.
This property is read/write.
Remarks
A URI consists of the following segments:
scheme://username:password@host:port/path;parameter?query#fragment
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteResourceUri Class

# RemoteResourceUri.Path Property
Gets or sets the path segment of the URI string.
Syntax
public string Path {get; set;}

Property Value
System.String.  The path segment of the URI.
This property is read/write.
Remarks
A URI consists of the following segments:
scheme://username:password@host:port/path;parameter?query#fragment
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteResourceUri Class

# RemoteResourceUri.PathSegments Property
Gets or sets a list of path segments of the URI string.
Syntax
public System.Collections.IList PathSegments {get; set;}

Property Value
System.Collections.IList.  A list of path segments.
This property is read/write.
Remarks
A URI consists of the following segments:
scheme://username:password@host:port/path;parameter?query#fragment
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteResourceUri Class

# RemoteResourceUri.Port Property
Gets or sets the port segment of the URI string.
Syntax
public int Port {get; set;}

Property Value
System.Int32.  The port segment of the URI.
This property is read/write.
Remarks
A URI consists of the following segments:
scheme://username:password@host:port/path;parameter?query#fragment
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteResourceUri Class

# RemoteResourceUri.Query Property
Gets or sets the query segment of the URI string.
Syntax
public string Query {get; set;}

Property Value
System.String.  The query segment of the URI.
This property is read/write.
Remarks
A URI consists of the following segments:
scheme://username:password@host:port/path;parameter?query#fragment
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteResourceUri Class

# RemoteResourceUri.QueryPairs Property
Gets or sets query name-value pairs in the URI string.
Syntax
public System.Collections.IDictionary QueryPairs {get; set;}

Property Value
System.Collections.IDictionary.  Contains name-value pairs for the query segment of the URI.
This property is read/write.
Remarks
A URI consists of the following segments:
scheme://username:password@host:port/path;parameter?query#fragment
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteResourceUri Class

# RemoteResourceUri.Scheme Property
Gets or sets the scheme segment of the URI string.
Syntax
public string Scheme {get; set;}

Property Value
System.String.  The scheme segment of the URI.
This property is read/write.
Remarks
A URI consists of the following segments:
scheme://username:password@host:port/path;parameter?query#fragment
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteResourceUri Class

# RemoteResourceUri.Uri Property
Gets or sets the URI as a System.URI object.
Syntax
public Uri Uri {get; set;}

Property Value
System.Uri.  The URI.
This property is read/write.
Remarks
A URI consists of the following segments:
scheme://username:password@host:port/path;parameter?query#fragment
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteResourceUri Class

# RemoteResourceUri.UriChanged Event
Raised when the URI to the remote resource changes.
Syntax
public EventHandler UriChanged;

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteResourceUri Class

# RemoteResourceUri.UserName Property
Gets or sets the username segment of the URI string.
Syntax
public string UserName {get; set;}

Property Value
System.String.  The username segment of the URI.
This property is read/write.
Remarks
A URI consists of the following segments:
scheme://username:password@host:port/path;parameter?query#fragment
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteResourceUri Class

# RemoteValue Class
Defines how RemoteResource data is parsed, mapped (bound) to view items, and typed.
public abstract class RemoteValue : Microsoft.MediaCenter.UI.ModelItem

Protected Instance Constructor
Method	Description
RemoteValue
Initializes a new instance of the RemoteValue class.

Public Instance Methods
Method	Description
Validate
Validates the mapping.
ValidateSource
Validates the source data.

Public Instance Properties
Property
Description
Bool
Indicates that the value is parsed as Boolean.
DateTime
Indicates that the value is parsed as DateTime.
Double
Indicates that the value is parsed as Double.
FullSource
Gets the source of the remote value.
Int32
Indicates that the value is parsed as Int32.
ParentList
Gets the RemoteValueList or XmlRemoteValueList to which this value belongs.
Property
If part of a remote value list, gets the repeating type of the parent list.
Source
Gets the path to the remote value source as an XPath.
String
Indicates that the value is parsed as a string.
TimeSpan
Indicates that the value is parsed as TimeSpan.
Type
Gets the type that corresponds to the remote value.

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace

# RemoteValue Constructor
Initializes a new instance of the RemoteValue class.
Overload List
protected RemoteValue();
protected RemoteValue(
  RemoteValueList  parent
);

Parameters
parent
Microsoft.MediaCenter.DataAccess.RemoteValueList.  The remote value list that the value belongs to.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteValue Class

# RemoteValue.Bool Property
Indicates that the value is parsed as Boolean.
Syntax
public bool Bool {get;}

Property Value
System.Boolean.  Parses the value as type Boolean.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteValue Class

# RemoteValue.DateTime Property
Indicates that the value is parsed as DateTime.
Syntax
public DateTime DateTime {get;}

Property Value
System.DateTime.  Parses the value as type DateTime.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteValue Class

# RemoteValue.Double Property
Indicates that the value is parsed as Double.
Syntax
public double Double {get;}

Property Value
System.Double.  Parses the value as type Double.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteValue Class

# RemoteValue.FullSource Property
Gets the source of the remote value.
Syntax
public string FullSource {get;}

Property Value
System.String.   The remote value's source.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteValue Class

# RemoteValue.Int32 Property
Indicates that the value is parsed as Int32.
Syntax
public int Int32 {get;}

Property Value
System.Int32.  Parses the value as type Int32.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteValue Class

# RemoteValue.ParentList Property
Gets the RemoteValueList or XmlRemoteValueList to which this value belongs.
Syntax
public RemoteValueList ParentList {get; set;}

Property Value
Microsoft.MediaCenter.DataAccess.RemoteValueList.  The remote value list object.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteValue Class

# RemoteValue.Property Property
If part of a remote value list, gets the repeating type of the parent list.
Syntax
public string Property {get; set;}

Property Value
System.String.  The repeating type.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteValue Class

# RemoteValue.Source Property
Gets the path to the remote value source as an XPath.
Syntax
public string Source {get;}

Property Value
System.String.  The XPath to the source.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteValue Class

# RemoteValue.String Property
Indicates that the value is parsed as a string.
Syntax
public string String {get;}

Property Value
System.String.  Parses the value as type String.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteValue Class

# RemoteValue.TimeSpan Property
Indicates that the value is parsed as TimeSpan.
Syntax
public TimeSpan TimeSpan {get;}

Property Value
System.TimeSpan.  Parses the value as type TimeSpan.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteValue Class

# RemoteValue.Type Property
Gets the type that corresponds to the remote value.
Syntax
public Type Type {get;}

Property Value
System.Type.  The value's type.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteValue Class

# RemoteValue.Validate Method
Validates the mapping.
Syntax
public virtual bool Validate();

Return Value
System.Boolean.  If true, the validation succeeded; otherwise, false.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteValue Class

# RemoteValue.ValidateSource Method
Validates the source data.
Syntax
public virtual bool ValidateSource();

Return Value
System.Boolean.  If true, the validation succeeded; otherwise, false.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteValue Class

# RemoteValueList Class
Represents a list of RemoteResource objects.
public abstract class RemoteValueList : RemoteValue

Protected Instance Constructor
Method	Description
RemoteValueList
Initializes a new instance of the RemoteValueList class.

Public Instance Methods
Method	Description
Validate
Validates the data.

Public Instance Properties
Property	Description
List
Not documented in this release.
Mappings
Gets or sets a list of remote values and mappings.
RepeatedType
Gets or sets the type of the data in this list.
SortBy
Gets or sets the property by which to sort the data in the list.

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace

# RemoteValueList Constructor
Initializes a new instance of the RemoteValueList class.
Syntax
protected RemoteValueList();

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteValueList Class

# RemoteValueList.List Property
Not documented in this release.
Syntax
public SortableList List {get; set;}

Property Value
Microsoft.MediaCenter.DataAccess.SortableList.  Not documented in this release.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteValueList Class

# RemoteValueList.Mappings Property
Gets or sets a list of remote values and mappings.
Syntax
public System.Collections.IList Mappings {get; set;}

Property Value
System.Collections.IList.  A list of remote values.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteValueList Class

# RemoteValueList.RepeatedType Property
Gets or sets the type of the data in this list.
Syntax
public Type RepeatedType {get; set;}

Property Value
System.Type.  The data type.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteValueList Class

# RemoteValueList.SortBy Property
Gets or sets the property by which to sort the data in the list.
Syntax
public string SortBy {get; set;}

Property Value
System.String.  The name of the property.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteValueList Class

# RemoteValueList.Validate Method
Validates the data.
Syntax
public virtual bool Validate();

Return Value
System.Boolean.  If true, the validation succeeded; otherwise, false.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	RemoteValueList Class

# SortableList Class
Provides sorting functionality for RemoteValueList and XmlRemoteValueList objects to sort the list of returned data.
public class SortableList : Microsoft.MediaCenter.UI.VirtualList

Public Instance Constructor
Method	Description
SortableList
Initializes a new instance of the SortableList class.

Public Instance Methods
Method	Description
GetItemState
Not documented in this release.
SetItemState
Not documented in this release.

Public Instance Properties
Property	Description
RemoteValueList
Not documented in this release.

Protected Instance Methods
Method	Description
OnRequestItem
Not documented in this release.

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace

# SortableList Constructor
Initializes a new instance of the SortableList class.
Syntax
public SortableList();

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	SortableList Class

# SortableList.GetItemState Method
Not documented in this release.
Syntax
public ListItemState GetItemState(
  int  index
);

Parameters
index
System.Int32.  Not documented in this release.
Return Value
Microsoft.MediaCenter.DataAccess.ListItemState.  Not documented in this release.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	SortableList Class

# SortableList.OnRequestItem Method
Not documented in this release.
Syntax
protected virtual void OnRequestItem(
  int  index,
  Microsoft.MediaCenter.UI.ItemRequestCallback  callback
);

Parameters
index
System.Int32.  Not documented in this release.
callback
Microsoft.MediaCenter.UI.ItemRequestCallback.  Not documented in this release.
Return Value
This method does not return a value.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	SortableList Class

# SortableList.RemoteValueList Property
Not documented in this release.
Syntax
public RemoteValueList RemoteValueList {get; set;}

Property Value
Microsoft.MediaCenter.DataAccess.RemoteValueList.  Not documented in this release.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	SortableList Class

# SortableList.SetItemState Method
Not documented in this release.
Syntax
public void SetItemState(
  int  index,
  ListItemState  itemState
);

Parameters
index
System.Int32.  Not documented in this release.
itemState
Microsoft.MediaCenter.DataAccess.ListItemState.  Not documented in this release.
Return Value
This method does not return a value.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	SortableList Class

# XmlRemoteResource Class
Works with XML data from a remote resource. Use this class to construct a data request, process the response, and parse the data that is received. This class applies XML-specific parsing and mapping.
public class XmlRemoteResource : RemoteResource

Public Instance Constructor
Method	Description
XmlRemoteResource
Initializes a new instance of the XmlRemoteResource class.

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace

# XmlRemoteResource Constructor
Initializes a new instance of the XmlRemoteResource class.
Syntax
public XmlRemoteResource();

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	XmlRemoteResource Class

# XmlRemoteValue Class
Defines how XmlRemoteResource data is parsed, mapped (bound) to view items, and typed. This class applies XML-specific parsing and mapping.
public class XmlRemoteValue : RemoteValue

Public Instance Constructor
Method	Description
XmlRemoteValue
Initializes a new instance of the XmlRemoteValue class.

Public Instance Methods
Method	Description
ValidateSource
Validates the source data.

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace

# XmlRemoteValue Constructor
Initializes a new instance of the XmlRemoteValue class.
Syntax
public XmlRemoteValue();

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	XmlRemoteValue Class

# XmlRemoteValue.ValidateSource Method
Validates the source data.
Syntax
public virtual bool ValidateSource();

Return Value
System.Boolean.  If true, the validation succeeded; otherwise, false.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	XmlRemoteValue Class

# XmlRemoteValueList Class
Represents a list of XmlRemoteResource objects. This class applies XML-specific parsing and mapping.
public class XmlRemoteValueList : RemoteValueList

Public Instance Constructor
Method	Description
XmlRemoteValueList
Initializes a new instance of the XmlRemoteValueList class.

Public Instance Methods
Method	Description
ValidateSource
Validates the source data.

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace

# XmlRemoteValueList Constructor
Initializes a new instance of the XmlRemoteValueList class.
Syntax
public XmlRemoteValueList();

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	XmlRemoteValueList Class

# XmlRemoteValueList.ValidateSource Method
Validates the source data.
Syntax
public virtual bool ValidateSource();

Return Value
System.Boolean.  If true, the validation succeeded; otherwise, false.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.DataAccess
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	XmlRemoteValueList Class

# Microsoft.MediaCenter.Hosting Namespace
The following types are in the Microsoft.MediaCenter.Hosting namespace, which is in the microsoft.mediacenter.dll assembly.
The Microsoft.MediaCenter.Hosting namespace exposes the following classes:
Class	Description
AddInHost
Enables applications to retrieve information about Windows Media Center and extend Windows Media Center's capabilities.
ApplicationContext
Enables applications to be registered and unregistered. This interface also enables an application to determine whether it is the current foreground application in Windows Media Center.
ApplicationSession
Not documented in this release.
HistoryOrientedPageSession
Enables applications to navigate to other pages. Contains an internal page stack that enables applications to track page navigation.
Page
Not documented in this release.
PageSession
Enables applications to navigate to other pages.
PanelSession
Not documented in this release.
ViewPort
Enables applications to set and retrieve information for the shared Now Playing or custom video view port.
ViewPorts
Enables the application to retrieve the shared Now Playing or custom video view port.

The Microsoft.MediaCenter.Hosting namespace exposes the following interfaces:
Interface	Description
IAddInEntryPoint
Defines the entry point for a Windows Media Center application.
IAddInModule
Enables applications to initialize when they start running, and to uninitialize before they close.

The Microsoft.MediaCenter.Hosting namespace exposes the following enumeration:
Enumeration	Description
InstallationOptions
Contains values that indicate any installation options for installing the application package.

See Also
•	Managed Code Object Model Reference

# AddInHost Class
Enables applications to retrieve information about Windows Media Center and extend Windows Media Center's capabilities.
Syntax
public sealed class AddInHost : Microsoft.MediaCenter.UI.IPropertyObject

Public Static Properties
Property	Description
Current
Gets the current AddInHost object.

Public Instance Properties
Property	Description
ApplicationContext
Gets an ApplicationContext object used to register a Windows Media Center application and retrieve information about applications.
ApplicationControlEnabled
Gets a value that indicates whether application control is enabled.
EntryPointParameters
Gets an array of parameters that is passed to the application. If the application is launched directly from Windows Media Center, this value is null.
MediaCenterEnvironment
Gets a MediaCenterEnvironment class that an application can use to control the Windows Media Center experience.
MediaContext
Gets a collection containing all of the properties for the current media context.
MetadataAccessEnabled
Gets a value that indicates whether metadata access is enabled.
ViewPorts
Gets an object that allows access to the shared Now Playing and custom video view ports.

Public Instance Events
Event	Description
PropertyChanged
Raised when an AddInHost property changes.

See Also
•	Managed Code Object Model Reference

# AddInHost.ApplicationContext Property
Gets an ApplicationContext object used to register a Windows Media Center application and retrieve information about applications.
Syntax
public ApplicationContext ApplicationContext {get;}

Property Value
Microsoft.MediaCenter.ApplicationContext. The interface used to register a Windows Media Center application and retrieve application information.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	AddInHost Class

# AddInHost.ApplicationControlEnabled Property
Gets a value that indicates whether application control is enabled.
Syntax
public bool ApplicationControlEnabled {get;}

Property Value
System.Boolean.  If true, application control is enabled; otherwise, false.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	AddInHost Class
•	Microsoft.MediaCenter.Hosting Namespace

# AddInHost.Current Property
Gets the current AddinHost object.
Syntax
public AddInHost Current {get;}

Property Value
Microsoft.MediaCenter.Hosting.AddInHost. The current AddinHost object.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	AddInHost Class

# AddInHost.EntryPointParameters Property
Gets an array of parameters that is passed to the application. If the application is launched directly from Windows Media Center, this value is null.
Syntax
public IList EntryPointParameters {get;}

Property Value
System.Collections.IList. A list of entry point parameters to be interpreted by the application.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	AddInHost Class

# AddInHost.MediaCenterEnvironment Property
Gets a MediaCenterEnvironment class that an application can use to control the Windows Media Center experience.
Syntax
public MediaCenterEnvironment MediaCenterEnvironment {get;}

Property Value
Microsoft.MediaCenter.MediaCenterEnvironment. The class used to control the Windows Media Center experience.
This property is read-only.
Remarks
An application can use this interface to display dialog boxes, play media content, browse to other locations, and so on.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	AddInHost Class
•	MediaMetadata Class

# AddInHost.MediaContext Property
Gets a collection containing all of the properties for the current media context.
Syntax
public MediaMetadata MediaContext {get;}

Property Value
Microsoft.MediaCenter.MediaMetadata. A collection of property-value pairs for the current media.
This property is read-only.
Remarks
An application can register entry points in various More With This categories within Windows Media Center. When the user selects one of these entry points, the current media context is the More With This category that contains the selected entry point. For more information, see Integrating into More With This.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MediaCenterEnvironment Class

# AddInHost.MetadataAccessEnabled Property
Gets a value that indicates whether metadata access is enabled.
Syntax
public bool MetadataAccessEnabled {get;}

Property Value
System.Boolean.  If true, metadata access is enabled; otherwise, false.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	AddInHost Class
•	Microsoft.MediaCenter.Hosting Namespace

# AddInHost.PropertyChanged Event
Raised when an AddInHost property changes.
Syntax
public override Microsoft.MediaCenter.UI.PropertyChangedEventHandler PropertyChanged;

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	AddInHost Class
•	Microsoft.MediaCenter.Hosting Namespace

# AddInHost.ViewPorts Property
Gets an object that allows access to the shared Now Playing and custom video view ports.
Syntax
public ViewPorts ViewPorts {get;}

Property Value
Microsoft.MediaCenter.Hosting.ViewPorts.  The ViewPorts object.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	AddInHost Class
•	Microsoft.MediaCenter.Hosting Namespace

# ApplicationContext Class
Enables an application to register and unregister other Windows Media Center applications. This class also enables an application to determine whether it is the current foreground application in Windows Media Center.
Syntax
public class ApplicationContext : Microsoft.MediaCenter.UI.IPropertyObject

Public Static Methods
Method	Description
RegisterApplication
Registers an application and its supported entry points with Windows Media Center.


Public Instance Methods
Method	Description
CloseApplication
Closes the current application.
InstallApplication
Runs the application installation package.
IsApplicationRegistered
Indicates whether a particular application is registered with Windows Media Center.
IsEntryPointRegistered
Indicates whether a particular entry point in the current application is registered with Windows Media Center.
ReturnToApplication
Navigates Windows Media Center back to the application that called this method.

Public Instance Properties
Property	Description
ApplicationInfo
Gets the application properties from the XML that was used to register the application.
EntryPointInfo
Gets the entry point information from the XML that was used to register the application. This information is returned only for the current entry point.
IsCurrentlyVisible
Gets a value that indicates whether the application is currently visible.
IsForegroundApplication
Gets a value that indicates whether the application is the current Windows Media Center foreground application.
SingleInstance
Gets a value that indicates whether only one instance of the application can be running.

Public Instance Events
Event	Description
PropertyChanged
Raised when an ApplicationContext property changes.
Relaunch
Not documented in this release.

See Also
•	Managed Code Object Model Reference

# ApplicationContext.ApplicationInfo Property
Gets the application properties from the XML that was used to register the application.
Syntax
public Dictionary<string,object> ApplicationInfo {get;}

Property Value
System.Collections.Generic.Dictionary<System.String, System.Object>. A list of the application properties.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ApplicationContext Class

# ApplicationContext.CloseApplication Method
Closes the application that corresponds to the current entry point.
Syntax
public void CloseApplication();

Return Value
This method does not return a value.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ApplicationContext Class

# ApplicationContext.EntryPointInfo Property
Gets the entry point information from the XML that was used to register the application. This information is returned only for the current entry point.
Syntax
public Dictionary<string,object> EntryPointInfo {get;}

Property Value
System.Collections.Generic.Dictionary<System.String, System.Object>. A list of entry point properties.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ApplicationContext Class

# ApplicationContext.InstallApplication Method
Runs the application installation package.
Syntax
public void InstallApplication(
  string  package,
  InstallationOptions  options
);

Parameters
package
System.String.  The URI to the installation package.
options
Microsoft.MediaCenter.Hosting. InstallationOptions.  Specifies any installation options.
Return Value
This method does not return a value.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	ApplicationContext Class
•	Microsoft.MediaCenter.Hosting Namespace

# ApplicationContext.IsApplicationRegistered Method
Indicates whether a particular application is registered with Windows Media Center.
Syntax
public bool IsApplicationRegistered(
  Guid  guidApplication
);

Parameters
guidApplication
System.Guid.  A string that specifies the globally unique identifier (GUID) for the application.
Return Value
System.Boolean.  Indicates whether the specified entry point is registered.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ApplicationContext Class
•	Microsoft.MediaCenter.Hosting Namespace

# ApplicationContext.IsCurrentlyVisible Property
Gets a value that indicates whether the application is currently visible.
Syntax
public bool IsCurrentlyVisible {get;}

Property Value
System.Boolean.  If true, the application is currently visible; otherwise, false.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	ApplicationContext Class
•	Microsoft.MediaCenter.Hosting Namespace

# ApplicationContext.IsEntryPointRegistered Method
Indicates whether a particular entry point in the current application is registered with Windows Media Center.
Syntax
public bool IsEntryPointRegistered(
   Guid guidEntryPoint
);

Parameters
guidEntryPoint
System.Guid.  Globally unique identifier (GUID) of an entry point.
Return Value
System.Boolean. It is true if the entry point is registered, and false otherwise.
Remarks
An application registers its entry points by calling the ApplicationContext.RegisterApplication method.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ApplicationContext Class
•	ApplicationContext.RegisterApplication Method

# ApplicationContext.IsForegroundApplication Property
Gets a value that indicates whether the application is the current Windows Media Center foreground application.
Syntax
public bool IsForegroundApplication {get;}

Property Value
System.Boolean. It is true if the application is the current foreground application, and false otherwise.
This property is read-only.
Remarks
This property is intended to be used by a background application to determine whether another entry point of the same application is currently the foreground application.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ApplicationContext Class

# ApplicationContext.PropertyChanged Event
Raised when an ApplicationContext property changes.
 Syntax
public override Microsoft.MediaCenter.UI.PropertyChangedEventHandler PropertyChanged;

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	ApplicationContext Class
•	Microsoft.MediaCenter.Hosting Namespace

# ApplicationContext.RegisterApplication Method
Registers an application and its entry points with Windows Media Center, or unregisters an application, removing all of its entry points from Windows Media Center.
Overload List
public static void RegisterApplication(
  Uri  uri,
  bool  unRegister,
  bool  allUsers
);
public static void RegisterApplication(
  System.Xml.XmlReader  reader,
  bool  unRegister,
  bool  allUsers,
  string  basePath
);

Parameters
uri
System.Uri.  The uniform resource identifier (URI) of the XML file that contains the registration information. This URI must use HTTP or HTTPS.
unRegister
System.Boolean.  Indicates whether to register or unregister the application. Set this parameter to false to register, or true to unregister.
allUsers
System.Boolean.  Indicates whether to register or unregister the application for all users, or just for the current user. Set this parameter to true to register for all users, or false to register for the current user only.
Note   Extender users cannot register entry points for all users, and attempting to do so results in a User Account Control (UAC) prompt.
reader
System.Xml.XmlReader.  An implementation of an XML reader that returns XML information for the application registration.
basePath
System.String.  A String that contains a path used to resolve relative paths specified in the registration information.
Return Value
This method does not return a value.
If this method fails, the following exceptions are possible:
Exception	Description
ApplicationAlreadyRegisteredException
The application is already registered and unRegister is false.
ApplicationNotRegisteredException
The application isn't registered and unRegister is true.
ApplicationNoPermissionException
The user does not have permission to register applications (in particular when allUsers is true).
ApplicationRegistrationCancelledException
The user has denied the registration request.

Remarks
To register, a previously registered application must call this method on behalf of another Windows Media Center application.
The XML that is specified must contain a single application element with one or more nested entrypoint elements. Each entrypoint element must have one or more nested category elements.
An entry point is a link to a particular Windows Media Center Presentation Layer page, and consists of an identifier, a URL, a title, a description, and an image. Each entry point must be associated with at least one Windows Media Center category, which determines the locations in the Windows Media Center user interface (UI) where the entry point is placed.
To unregister an application, use the same XML as was used to register the application.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	application Element
•	ApplicationContext Class
•	category Element
•	entrypoint Element

# ApplicationContext.Relaunch Event
Not documented in this release.
Syntax
public EventHandler Relaunch;

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	ApplicationContext Class
•	Microsoft.MediaCenter.Hosting Namespace

# ApplicationContext.ReturnToApplication Method
Navigates Windows Media Center back to the application that called this method.
Syntax
public void ReturnToApplication();

Parameters
This method takes no parameters.
Return Value
This method does not return a value.
Remarks
An application that plays video in full-screen mode can use this method to regain the focus after full-screen playback concludes.
Before calling this method, background applications can use the ApplicationContext.IsForegroundApplication property to determine whether the application is being displayed, and the MediaExperience.IsFullScreen property to determine whether the current media is in full-screen mode.
Foreground applications can use this method to have Windows Media Center return to their application, for example after playing full-screen video.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.AddIn
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ApplicationContext.IsForegroundApplication Property
•	MediaCenterEnvironment Class
•	MediaExperience.IsFullScreen Property

# ApplicationContext.SingleInstance Property
Gets a value that indicates whether only one instance of the application can be running at a time.
Syntax
public bool SingleInstance {get; set;}

Property Value
System.Boolean.  If true, only one instance of the application can be running; otherwise, false.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	ApplicationContext Class
•	Microsoft.MediaCenter.Hosting Namespace

# ApplicationSession Class
Not documented in this release.
public abstract class ApplicationSession

Members
Public Instance Constructor
Method	Description
ApplicationSession
Initializes a new instance of the ApplicationSession class.

Public Static Properties
Property	Description
Current
Retrieves the current application session.

Public Instance Properties
Property	Description
Source
Not documented in this release.
TargetHost
Not documented in this release.

Protected Instance Methods
Method	Description
CreateUiHost
Not documented in this release.
EnsureUiHost
Not documented in this release.
LoadTargetUi
Not documented in this release.
OnNavigate
Not documented in this release.

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.Hosting Namespace

# ApplicationSession Constructor
Initializes a new instance of the ApplicationSession class.
Syntax
public ApplicationSession();

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	ApplicationSession Class
•	Microsoft.MediaCenter.Hosting Namespace

# ApplicationSession.CreateUiHost Method
Not documented in this release.
Syntax
protected abstract void CreateUiHost();

Return Value
This method does not return a value.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	ApplicationSession Class
•	Microsoft.MediaCenter.Hosting Namespace

# ApplicationSession.Current Property
Retrieves the current application session.
Syntax
public static ApplicationSession Current {get;}

Property Value
Microsoft.MediaCenter.Hosting. ApplicationSession.  The current application session.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	ApplicationSession Class
•	Microsoft.MediaCenter.Hosting Namespace

# ApplicationSession.EnsureUiHost Method
Not documented in this release.
Syntax
protected void EnsureUiHost();

Return Value
This method does not return a value.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	ApplicationSession Class
•	Microsoft.MediaCenter.Hosting Namespace

# ApplicationSession.LoadTargetUi Method
Not documented in this release.
Syntax
protected void LoadTargetUi(
  object  target,
  string  source,
  IDictionary<string, object>  sourceData,
  IDictionary<string, object>  uiProperties,
  bool  setDefaultFocus
);

Parameters
target
System.Object.  Not documented in this release.
source
System.String.  Not documented in this release.
sourceData
System.Collections.Generic.IDictionary<System.String, System.Object>.  Not documented in this release.
uiProperties
System.Collections.Generic.IDictionary<System.String, System.Object>.  Not documented in this release.
setDefaultFocus
System.Boolean.  Not documented in this release.
Return Value
This method does not return a value.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	ApplicationSession Class
•	Microsoft.MediaCenter.Hosting Namespace

# ApplicationSession.OnNavigate Method
Not documented in this release.
Syntax
protected abstract void OnNavigate(
  string  source,
  Dictionary<string, object>  sourceData,
  Dictionary<string, object>  uiProperties
);

Parameters
source
System.String.  Not documented in this release.
sourceData
System.Collections.Generic.Dictionary<System.String, System.Object>.  Not documented in this release.
uiProperties
System.Collections.Generic.Dictionary<System.String, System.Object>.  Not documented in this release.
Return Value
This method does not return a value.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	ApplicationSession Class
•	Microsoft.MediaCenter.Hosting Namespace

# ApplicationSession.Source Property
Not documented in this release.
Syntax
public string Source {get; set;}

Property Value
System.String.  Not documented in this release.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	ApplicationSession Class
•	Microsoft.MediaCenter.Hosting Namespace

# ApplicationSession.TargetHost Property
Not documented in this release.
Syntax
public object TargetHost {get; set;}

Property Value
System.Object.  Not documented in this release.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	ApplicationSession Class
•	Microsoft.MediaCenter.Hosting Namespace

# HistoryOrientedPageSession Class
A derived class of the PageSession class with an internal page stack for tracking page navigation. For example, you can navigate back one page.
This class is similar to the PageSession class, which is simpler and requires you to maintain your own page stack for page navigation.
Syntax
public class HistoryOrientedPageSession : PageSession

Public Instance Constructors
Constructor	Description
HistoryOrientedPageSession
Initializes a new instance of this class.

Public Instance Methods
Method	Description
BackPage
Navigates back to the previous page within the current application.
GoToPage
Navigates to a specific page.

Public Instance Properties
Property	Description
CurrentPage
Retrieves the current page.

See Also
•	Managed Code Object Model Reference

# HistoryOrientedPageSession.BackPage Method
Navigates back to the previous page within the current application.
Syntax
public bool BackPage();

Return Value
System.Boolean.  It is true if the method succeeds, and false if it fails.
Remarks
If Windows Media Center is currently on the first page of the application, this method does nothing and returns false. To close the application and navigate back to Windows Media Center, use the ApplicationContext.CloseApplication method.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	HistoryOrientedPageSession Class

# HistoryOrientedPageSession.CurrentPage Property
Retrieves the current page.
Syntax
public Page CurrentPage {get;}

Property Value
Microsoft.MediaCenter.Hosting.Page.  The current page.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	HistoryOrientedPageSession Class
•	Microsoft.MediaCenter.Hosting Namespace

# HistoryOrientedPageSession.GoToPage Method
Navigates to a specific page.
Syntax
public void GoToPage(
   string source,
   IDictionary<string,object> sourceData
   IDictionary<string, object> uiProperties
);

Parameters
source
System.String. The uniform resource identifier (URI) that points to the page. For more information, see Using Resources in MCML.
sourceData
System.Collections.Generic.IDictionary<string,object>. Contains parameters passed in the Web request that are used to fetch the page if the source URI is an HTTP or HTTPS URI.
uiProperties
System.Collections.Generic.IDictionary<string,object>. Contains parameters passed to the new page.
Return Value
This method does not return a value.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	HistoryOrientedPageSession Class

# HistoryOrientedPageSession.HistoryOrientedPageSession Constructor
Initializes a new instance of the HistoryOrientedPageSession class.
Syntax
public HistoryOrientedPageSession();

Return Value
This method does not return a value.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	HistoryOrientedPageSession Class

# IAddInEntryPoint Interface
Defines the entry point for a Windows Media Center application. Windows Media Center uses this interface when it needs to start running an application. All applications must implement this interface.
Syntax
public interface IAddInEntryPoint

Public Instance Methods
Method	Description
Launch
Starts running an application.

See Also
•	Managed Code Object Model Reference
•
# IAddInEntryPoint.Launch Method
Starts running an application.
Syntax
public void Launch(
   AddInHost host
);

Parameters
host
Microsoft.MediaCenter.AddInHost.  An application uses this interface to access other interfaces provided by the Microsoft.MediaCenter namespace.
Return Value
This method does not return a value.
Remarks
Because the Windows Media Center object is guaranteed to be valid only until the Launch method returns, an on-demand application must make all calls to the Windows Media Center API within the context of the application's Launch method. Calling the Windows Media Center object after the Launch method returns can result in a fatal error. If your application's Launch method spawns multiple threads, those threads must all be terminated before your Launch method returns.
After calling the Launch method, if you do not call any method directly from the host object, .NET remoting releases unused objects every five minutes. To avoid this, use the host object or use the objects within five minutes to prevent them from being released.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IAddInEntryPoint Interface

# IAddInModule Interface
Enables applications to initialize when they start running, and to uninitialize before they close. Windows Media Center calls the methods of this interface.
Syntax
public interface IAddInModule

Public Instance Methods
Method	Description
Initialize
Initializes private variables and allocates system resources.
Uninitialize
Saves state information and frees system resources.

See Also
•	Managed Code Object Model Reference
•
# IAddInModule.Initialize Method
Enables an application to initialize its private variables and allocate system resources.
Syntax
public void Initialize(
   Dictionary<string, object> appInfo,
   Dictionary<string, object> entryPointInfo
);

Parameters
appInfo
System.Collections.Dictionary<string,object>.  A collection of the attributes and corresponding values that were specified in the application element used to register the application. For more information, see Associating Application Entry Points with Integration Locations.
entryPointInfo
System.Collections.Dictionary<string,object>.  A collection of the attributes and corresponding values that were specified in the entrypoint element used to register the application's entry points. For more information, see Associating Application Entry Points with Integration Locations.
Return Value
This method does not return a value.
Remarks
This method is only for quick initialization. No lengthy operations such as disk or network access should be done while calling this method. If this method does not return within a few seconds, Windows Media Center terminates the application.
Windows Media Center calls this method before calling the IAddInEntryPoint.Launch method.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	application Element
•	entrypoint Element
•	IAddInModule Interface

# IAddInModule.Uninitialize Method
Enables an application to save its state information and free system resources.
Syntax
public void Uninitialize();

Parameters
This method takes no parameters.
Return Value
This method does not return a value.
Remarks
Because Windows Media Center is not always able to call this method, an application should not rely on Uninitialize as its only means of saving state information.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IAddInModule Interface

# InstallationOptions Enumeration
Contains values that indicate any installation options for installing the application package.
public enum InstallationOptions

Members
Value	Description
None	No installation options.
Update	The installation is an update.


Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.Hosting Namespace

# Page Class
Not documented in this release.
public sealed class Page : Microsoft.MediaCenter.UI. ModelItem

Members
Public Instance Properties
Property	Description
PushOnStack
Indicates whether the current page can go on the back stack.
Source
Not documented in this release.
State
Not documented in this release.

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.Hosting Namespace

# Page.PushOnStack Property
Indicates whether the current page can go on the back stack.
Syntax
public bool PushOnStack {get; set;}

Property Value
System.Boolean.  If true, the page can go on the back stack; otherwise, false.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.Hosting Namespace
•	Page Class

# Page.Source Property
Not documented in this release.
Syntax
public string Source {get;}

Property Value
System.String.  Not documented in this release.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.Hosting Namespace
•	Page Class

# Page.State Property
Not documented in this release.
Syntax
public Microsoft.MediaCenter.UI.PropertySet State {get;}

Property Value
Microsoft.MediaCenter.UI.PropertySet.  Not documented in this release.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.Hosting Namespace
•	Page Class

# PageSession Class
Used for navigating to other pages. This class does not implement a page stack but rather allows you to work with one page. If you need a page stack, use the HistoryOrientedPageSession class, which is derived from PageSession and implements an internal page stack for tracking page navigation.
Syntax
public class PageSession : ApplicationSession

Public Instance Constructors
Constructor	Description
PageSession
Initializes a new instance of the PageSession class.

Public Instance Methods
Method	Description
Close
Closes the application.
GoToPage
Navigates to a specific page.

Protected Instance Methods
Method	Description
CreateUiHost
Not documented in this release.
OnNavigate
Not documented in this release.
LoadPage
Loads a page.

Public Static Properties
Property	Description
Current
Gets the current page.

See Also
•	Managed Code Object Model Reference

# PageSession.Close Method
Closes the application.
Syntax
public void Close();

Return Value
This method does not return a value.
Remarks
This method is the proper way to exit an application.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	PageSession Class

# PageSession.CreateUiHost Method
Not documented in this release.
Syntax
protected virtual void CreateUiHost();

Return Value
This method does not return a value.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.Hosting Namespace
•	PageSession Class

# PageSession.Current Property
Gets the current page session.
Syntax
public static PageSession Current {get;}

Property Value
Microsoft.MediaCenter.Hosting.PageSession. The current page session.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	PageSession Class

# PageSession.GoToPage Method
Navigates to a specific page.
Syntax
public void GoToPage(
   string source
);

Syntax
public void GoToPage(
   string source,
   IDictionary<string, object> uiProperties
);

Syntax
public virtual void GoToPage(
   string  source,
   IDictionary<string, object> sourceData,
   IDictionary<string, object> uiProperties
);

Parameters
source
System.String. The uniform resource identifier (URI) that points to the page. For more information, see Using Resources in MCML.
sourceData
System.Collections.Generic.IDictionary<string,object>. Contains parameters passed in the Web request that are used to fetch the page if the source URI is an HTTP or HTTPS URI.
uiProperties
System.Collections.Generic.IDictionary<string,object>. Contains parameters passed to the new page.
Return Value
This method does not return a value.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	PageSession Class

# PageSession.LoadPage Method
Loads a page.
Overload List
protected void LoadPage(
  string  source,
  IDictionary<string, object>  sourceData,
  IDictionary<string, object>  uiProperties
);
protected void LoadPage(
  string  source,
  IDictionary<string, object>  sourceData,
  IDictionary<string, object>  uiProperties,
  bool  navigateForward
);
protected virtual void LoadPage(
  object  target,
  string  source,
  IDictionary<string, object>  sourceData,
  IDictionary<string, object>  uiProperties,
  bool  navigateForward
);

Parameters
source
System.String. The uniform resource identifier (URI) that points to the page. For more information, see Using Resources in MCML.
sourceData
System.Collections.Generic.IDictionary<string,object>. Contains parameters passed in the Web request that are used to fetch the page if the source URI is an HTTP or HTTPS URI.
uiProperties
System.Collections.Generic.IDictionary<string,object>. Contains parameters passed to the new page.
navigateForward
System.Boolean.  Used by classes that implement a page stack to determine whether the current page should be pushed on the stack.
target
System.Object.  Reserved for future use. Use null for this value.
Return Value
This method does not return a value.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	PageSession Class

# PageSession.OnNavigate Method
Not documented in this release.
Syntax
protected virtual void OnNavigate(
  string  source,
  Dictionary<string, object>  sourceData,
  Dictionary<string, object>  uiProperties
);

Parameters
source
System.String.  Not documented in this release.
sourceData
System.Collections.Generic.Dictionary<System.String, System.Object>.  Not documented in this release.
uiProperties
System.Collections.Generic.Dictionary<System.String, System.Object>.  Not documented in this release.
Return Value
This method does not return a value.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.Hosting Namespace
•	PageSession Class

# PageSession.PageSession Constructor
Initializes a new instance of the PageSession class.
Syntax
public PageSession();

Return Value
This method does not return a value.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	PageSession Class

# PanelSession Class
Not documented in this release.
public class PanelSession : ApplicationSession

Members
Public Instance Methods
Method	Description
PanelSession
Not documented in this release.
LoadUi
Not documented in this release.

Protected Instance Methods
Method	Description
CreateUiHost
Not documented in this release.
OnNavigate
Not documented in this release.

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.Hosting Namespace

# PanelSession Constructor
Not documented in this release.
Syntax
public PanelSession(
  string  connectionId
);

Parameters
connectionId
System.String.  Not documented in this release.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.Hosting Namespace
•	PanelSession Class

# PanelSession.CreateUiHost Method
Not documented in this release.
Syntax
protected virtual void CreateUiHost();

Return Value
This method does not return a value.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.Hosting Namespace
•	PanelSession Class

# PanelSession.LoadUi Method
Not documented in this release.
Syntax
public void LoadUi(
  string  source,
  IDictionary<string, object>  sourceData,
  IDictionary<string, object>  uiProperties
);

Parameters
source
System.String.  Not documented in this release.
sourceData
System.Collections.Generic.IDictionary<System.String, System.Object>.  Not documented in this release.
uiProperties
System.Collections.Generic.IDictionary<System.String, System.Object>.  Not documented in this release.
Return Value
This method does not return a value.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.Hosting Namespace
•	PanelSession Class

# PanelSession.OnNavigate Method
Not documented in this release.
Syntax
protected virtual void OnNavigate(
  string  source,
  Dictionary<string, object>  sourceData,
  Dictionary<string, object>  uiProperties
);

Parameters
source
System.String.  Not documented in this release.
sourceData
System.Collections.Generic.Dictionary<System.String, System.Object>.  Not documented in this release.
uiProperties
System.Collections.Generic.Dictionary<System.String, System.Object>.  Not documented in this release.
Return Value
This method does not return a value.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.Hosting Namespace
•	PanelSession Class

# ViewPort Class
Provides a way to control and retrieve information about the shared Now Playing view port, or the custom video view port.
Syntax
public sealed class ViewPort

Public Instance Methods
Method	Description
Focus
Requests that Windows Media Center place the focus on the view port.

Public Instance Properties
Property	Description
BorderColor
Gets or sets the color of the view port border.
FocusBorderColor
Gets or sets the color of the view port border when it is in focus.
Rectangle
Gets or sets the rectangle representing the bounding box for the view port.
Visible
Gets a value that indicates whether the view port is hidden or visible.

See Also
•	Microsoft.MediaCenter.Hosting Namespace

# ViewPort.BorderColor Property
Gets or sets the color of the view port border.
Syntax
public System.Drawing.Color BorderColor  {get; set;}

Property Value
System.Drawing.Color.  An ARGB color.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.Hosting Namespace
•	ViewPort Class

# ViewPort.Focus Method
Requests that Windows Media Center place the focus on the view port.
Syntax
public void Focus();

Return Value
This method does not return a value.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.Hosting Namespace
•	ViewPort Class

# ViewPort.FocusBorderColor Property
Gets and sets the color of the view port border when it is in focus.
Syntax
public System.Drawing.Color FocusBorderColor {get; set;}

Property Value
System.Drawing.Color.  An ARGB color.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.Hosting Namespace
•	ViewPort Class

# ViewPort.Rectangle Property
Gets or sets the rectangle representing the bounding box for the view port.
Syntax
public System.Drawing.Rectangle Rectangle {get; set;}

Property Value
System.Drawing.Rectangle.  A rectangle that indicates the size and location of the view port.
This property is read/write.
Note   Trying to write this value for the shared Now Playing view port results in an InvalidOperationException.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.Hosting Namespace
•	ViewPort Class

# ViewPort.Visible Property
Gets a value that indicates whether the view port is hidden or visible.
Syntax
public bool Visible {get; set;}

Property Value
System.Boolean.  It is true if the view port is visible, and false if hidden.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.Hosting Namespace
•	ViewPort Class

# ViewPorts Class
Provides a way for applications to control and retrieve information about the shared Now Playing view port, or the custom video view port.
Syntax
public sealed class ViewPorts

Public Instance Properties
Property	Description
NowPlaying
Gets the shared Now Playing view port.
Video
Gets the custom video view port.

See Also
•	Microsoft.MediaCenter.Hosting Namespace

# ViewPorts.NowPlaying Property
Gets the shared Now Playing view port.
Syntax
public ViewPort NowPlaying {get;}

Property Value
Microsoft.MediaCenter.Hosting.ViewPort.  The view port.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.Hosting Namespace
•	ViewPorts Class

# ViewPorts.Video Property
Gets the custom video view port.
Syntax
public ViewPort Video  {get;}

Property Value
Microsoft.MediaCenter.Hosting.ViewPort.  The view port.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.Hosting
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.Hosting Namespace
•	ViewPorts Class

# Microsoft.MediaCenter.ListMaker Namespace
The Windows Media Center application object model provides the following API elements to support CD/DVD recording applications. The following types are in the Microsoft.MediaCenter.ListMaker namespace, which is in the microsoft.mediacenter.dll assembly.
The Microsoft.MediaCenter.ListMaker namespace exposes the following classes:
Class	Description
CreateFileListHelper
Enables an MCML-based CD/DVD recording application to access a collection of list items provided by Windows Media Center.
ListMakerItem
Enables a CD/DVD recording application to access individual items from a list of files provided by Windows Media Center.
ListMakerList
Enables a CD/DVD recording application to access a collection of list items provided by Windows Media Center.

The Microsoft.MediaCenter.ListMaker namespace exposes the following interfaces:
Interface	Description
IDiscWriterApp
Enables the exchange of disc-related information between Windows Media Center and a CD/DVD recording application.
ICreateFileListHelper
Enables a CD/DVD recording application to customize the list-making portion of the Windows Media Center user interface and to receive user-created lists of files from Windows Media Center.
IListMakerApp
Enables a CD/DVD recording application to customize the list-making portion of the Windows Media Center user interface and to receive user-created lists of files from Windows Media Center.

The Microsoft.MediaCenter.ListMaker namespace exposes the following enumeration types:
Enumeration type	Description
CapacityFormat
Defines the format in which the CD/DVD recording application provides status information.
ClosedReason
Defines the action for when the user interacts with the CD/DVD recording application.
DiscFormats
Defines the disc recording formats that a CD/DVD recording application supports.
InitialListType
Indicates the type of list to use when initializing the CD/DVD recording application.
MediaTypes
Defines the types of media that a CD/DVD recording application can support.

The Microsoft.MediaCenter.ListMaker namespace exposes the following delegates and event arguments:
Delegate or event argument	Description
CompletionCallback
Handles completion events from CD/DVD recording applications.

The Microsoft.MediaCenter.ListMaker namespace defines the following exceptions:
Exception	Description
AppendNotSupportedException
Contains information about an exception raised because the CD/DVD recording application does not support appending files to the current medium.
CgmsNoRightsException
Contains information about an exception raised because an attempt was made to copy broadcast media content protected by Copy General Management System Analog (CGMS-A).
DeviceInUseException
Contains information about an exception raised because another process is using the required recording device.
DiscSpaceException
Contains information about an exception raised by a CD/DVD recording application, indicating that the amount of available disc space is not adequate to complete the recording operation.
DrmNoRightsException
Contains information about an exception raised because an attempt was made to copy DRM-protected content, but the user has not been granted the right to copy the content.
FileAlreadyExistsException
Contains information about an exception raised because the file list contains a duplicate file.
FileCorruptException
Contains information about an exception raised because a file contains corrupted data.
FileNotFoundException
Contains information about an exception raised because a file could not be located.
FitToDiscException
Contains information about an exception raised by a CD/DVD recording application, indicating that an error occurred during a recording operation in which the fit-to-disc feature is being used.
InstallationException
Contains information about an exception raised because of problems with the installation of the application.
ListMakerException
Contains information about an exception raised by a CD/DVD recording application while processing files from Windows Media Center.
NoDeviceException
Contains information about an exception raised because no recording device exists.
NoMediaException
Contains information about an exception raised by a CD/DVD recording application, indicating that the recording device contains no recording medium.
NotEnoughDiskForStashException
Contains information about an exception raised because the hard disk does not have enough space available to store temporary files.
UnsupportedFileException
Contains information about an exception raised by a CD recording application, indicating that the file is corrupted or is in an unsupported file format.
UserAbortException
Contains information about an exception raised because the user ended a recording operation before it was finished.
WrongMediaTypeException
Contains information about an exception raised by a CD/DVD recording application, indicating that the application does not support the specified type of recording medium.

See Also
•	CD and DVD Content Burning
•	Managed Code Object Model Reference

# AppendNotSupportedException Class
Contains information about an exception raised because the CD/DVD recording application does not support appending files to the current medium.
Syntax
public class AppendNotSupportedException : ListMakerException

Public Instance Constructors
Constructor	Description
AppendNotSupportedException()
Initializes an instance of the AppendNotSupportedException class.
AppendNotSupportedException(string)	Initializes an instance of the AppendNotSupportedException class.
AppendNotSupportedException(string, Exception)	Initializes an instance of the AppendNotSupportedException class.

Protected Instance Constructors
Constructor	Description
AppendNotSupportedException(SerializationInfo, StreamingContext)	Initializes an instance of the AppendNotSupportedException class.

See Also
•	Microsoft.MediaCenter.ListMaker Namespace

# AppendNotSupportedException.AppendNotSupportedException Constructor
Initializes an instance of the AppendNotSupportedException class.
Overload List
public AppendNotSupportedException()

public AppendNotSupportedException(string)

public AppendNotSupportedException(string, Exception)

protected AppendNotSupportedException(SerializationInfo, StreamingContext)


# AppendNotSupportedException.AppendNotSupportedException Constructor
Initializes an instance of the AppendNotSupportedException class.
Syntax
public AppendNotSupportedException();
# AppendNotSupportedException.AppendNotSupportedException Constructor
Initializes an instance of the AppendNotSupportedException class.
Syntax
public AppendNotSupportedException(
   string message
);

Parameters
message
System.String.  A description of the exception.
# AppendNotSupportedException.AppendNotSupportedException Constructor
Initializes an instance of the AppendNotSupportedException class.
Syntax
public AppendNotSupportedException(
   string message,
   Exception inner
);

Parameters
message
System.String.  A description of the exception.
inner
System.Exception.  The class on which this exception is based.
# AppendNotSupportedException.AppendNotSupportedException Constructor
Initializes an instance of the AppendNotSupportedException class.
Syntax
protected AppendNotSupportedException(
   SerializationInfo info,
   StreamingContext context
);

Parameters
info
System.Runtime.Serialization.SerializationInfo.  An instance of the class containing the information needed to serialize the new AppendNotSupportedException instance.
context
System.Runtime.Serialization.StreamingContext.  A structure that contains contextual information about the source of the serialized stream associated with the new AppendNotSupportedException instance.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	AppendNotSupportedException Class
# CapacityFormat Enumeration
Defines the format in which the CD/DVD recording application provides status information.
Syntax
public enum CapacityFormat

The CapacityFormat enumeration defines the following constants:
Constant	Description
Byte	A number of bytes.
Item	A number of items.
Time	An amount of time, expressed as a System.TimeSpan structure.
Unknown	The status format is not known.

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IListMakerApp.CapacityFormat Property
•	Microsoft.MediaCenter.ListMaker Namespace

# CgmsNoRightsException Class
Contains information about an exception raised because an attempt was made to copy broadcast media content protected by Copy General Management System Analog (CGMS-A).
Syntax
public class CgmsNoRightsException : ListMakerException

Public Instance Constructors
Constructor	Description
CgmsNoRightsException()
Initializes an instance of the CgmsNoRightsException class.
CgmsNoRightsException(string)
Initializes an instance of the CgmsNoRightsException class.
CgmsNoRightsException(string, Exception)	Initializes an instance of the CgmsNoRightsException class.

Protected Instance Constructors
Constructor	Description
CgmsNoRightsException(SerializationInfo, StreamingContext)	Initializes an instance of the CgmsNoRightsException class.

See Also
•	Microsoft.MediaCenter.ListMaker Namespace

# CgmsNoRightsException.CgmsNoRightsException Constructor
Initializes an instance of the CgmsNoRightsException class.
Overload List
public CgmsNoRightsException()

public CgmsNoRightsException(string)

public CgmsNoRightsException(string, Exception)

protected CgmsNoRightsException(SerializationInfo, StreamingContext)


# CgmsNoRightsException.CgmsNoRightsException Constructor
Initializes an instance of the CgmsNoRightsException class.
Syntax
public CgmsNoRightsException();
# CgmsNoRightsException.CgmsNoRightsException Constructor
Initializes an instance of the CgmsNoRightsException class.
Syntax
public CgmsNoRightsException(
   string message
);
Parameters
message
System.String.  A description of the exception.
# CgmsNoRightsException.CgmsNoRightsException Constructor
Initializes an instance of the CgmsNoRightsException class.
Syntax
public CgmsNoRightsException(
   string message,
   Exception inner
);
Parameters
message
System.String.  A description of the exception.
inner
System.Exception.  The class on which this exception is based.
# CgmsNoRightsException.CgmsNoRightsException Constructor
Initializes an instance of the CgmsNoRightsException class.
Syntax
protected CgmsNoRightsException(
   SerializationInfo info,
   StreamingContext context
);
Parameters
info
System.Runtime.Serialization.SerializationInfo.  An instance of the class containing the information needed to serialize the new CgmsNoRightsException instance.
context
System.Runtime.Serialization.StreamingContext.  A structure that contains contextual information about the source of the serialized stream associated with the new CgmsNoRightsException instance.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	CgmsNoRightsException Class
# ClosedReason Enumeration
Defines the possible user actions that caused the CD/DVD recording application to be closed.
public enum ClosedReason
Members
Value	Description
Cancelled	A value of Cancelled

None	A value of None
Saved	A value of Saved

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.ListMaker Namespace

# CompletionCallback Delegate
Represents the method that handles completion events from CD/DVD recording applications.
Syntax
public delegate void CompletionCallback(
    Exception ex
);

Parameters
ex
System.Exception.  The object on which this exception is based.
Return Value
This method does not return a value.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.ListMaker Namespace

# CreateFileListHelper Class
Enables an MCML-based CD/DVD recording application to access a collection of list items provided by Windows Media Center.
public sealed class CreateFileListHelper : MarshalByRefObject, Microsoft.MediaCenter.UI.IPropertyObject, ICreateFileListHelper

Members
Public Instance Methods
Method	Description
CreateFileListHelper
Initializes an instance of a CreateFileListHelper object.
OnClosed
Informs a CD/DVD recording application that the user has closed a list of items.
OnItemAdded
Informs a CD/DVD recording application that the user has added a new file to the list.
OnItemRemoved
Informs a CD/DVD recording application that the user has removed a file from the list.
OnItemsCleared
Informs a CD/DVD recording application that the user has clicked the Remove All button to remove all previously selected items from the list.
Reset
Informs a CD/DVD recording application that the user has reset the list of items.

Public Instance Properties
Property	Description
ByteCapacity
Indicates the capacity of the CD or DVD, in bytes.
BytesUsed
Indicates the amount of CD or DVD space, in bytes, that has been used so far.
CancelDialogMessage
Gets and sets the string that Windows Media Center uses as the message in the cancel dialog box.

CancelDialogTitle
Gets and sets the string that Windows Media Center uses as the title of the cancel dialog box.
CapacityFormat
Indicates the format in which the CD/DVD recording application provides status information.
ClosedReason
Indicates the action for when the user interacts with the CD/DVD recording application.
CreatePageTitle
Gets and sets the string that Windows Media Center uses as the title of the CD or DVD creation page.
FileList
Gets the list of items.
IsOrderImportant
Indicates whether the user is allowed to control the order of the files in the list.
ItemCapacity
Indicates the capacity of the CD or DVD, in items.
ItemsUsed
Indicates the amount of CD or DVD space, in items, that has been used so far.
SaveListButtonTitle
Gets and sets the string for the button label that is used to finish the CD or DVD recording operation.
ShowCapacityAsPercentage
Indicates whether the status is expressed as a percentage.
ShowRemainingCapacity
Indicates whether the status message should reflect the total capacity or the remaining space on the CD or DVD.
SupportedMediaTypes
Indicates the types of media supported by the CD/DVD recording applications.
TimeCapacity
Gets or sets a value that indicates the total amount of available recording time on the CD or DVD.
TimeUsed
Indicates the amount of recording time that has been used on the CD or DVD.
ViewListPageTitle
Gets and sets the string for the title of the view-list page.

Public Instance Events
Event	Description
Closed
Raised when the user closes the list of items.
ItemAdded
Raised when the user adds a new file to the list.
ItemRemoved
Raised when the user removes a file from the list.
ItemsCleared
Raised when the user clears all files from the list.

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.ListMaker Namespace

# CreateFileListHelper Constructor
Initializes an instance of a CreateFileListHelper object.
Syntax
public CreateFileListHelper();
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	CreateFileListHelper Class

# CreateFileListHelper.ByteCapacity Property
Indicates the capacity of the CD or DVD, in bytes.
Syntax
public override Int64 ByteCapacity {get; set;}
Property Value
System.Int64.  The capacity of the CD or DVD, in bytes.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	CreateFileListHelper Class

# CreateFileListHelper.BytesUsed Property
Indicates the amount of CD or DVD space, in bytes, that has been used so far.
Syntax
public override Int64 BytesUsed {get; set;}
Property Value
System.Int64.  The amount of space used so far.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	CreateFileListHelper Class

# CreateFileListHelper.CancelDialogMessage Property
Gets and sets the string that Windows Media Center uses as the message in the cancel dialog box.
Syntax
public override string CancelDialogMessage {get; set;}
Property Value
System.String.  Contains the dialog box message string.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	CreateFileListHelper Class

# CreateFileListHelper.CancelDialogTitle Property
Gets and sets the string that Windows Media Center uses as the title of the cancel dialog box.
Syntax
public override string CancelDialogTitle {get; set;}
Property Value
System.String.  Contains the dialog box title string.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	CreateFileListHelper Class

# CreateFileListHelper.CapacityFormat Property
Indicates the format in which the CD/DVD recording application provides status information.
Syntax
public override CapacityFormat CapacityFormat {get; set;}
Property Value
Microsoft.MediaCenter.ListMaker.CapacityFormat.  Indicates the format of the status information.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	CreateFileListHelper Class

# CreateFileListHelper.Closed Event
Raised when the user closes the list of items.
Syntax
public EventHandler Closed;
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	CreateFileListHelper Class

# CreateFileListHelper.ClosedReason Property
Indicates the user action that closed the CD/DVD recording application.
Syntax
public ClosedReason ClosedReason {get;}
Property Value
Microsoft.MediaCenter.ListMaker.ClosedReason.  The action that the user has taken.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	CreateFileListHelper Class

# CreateFileListHelper.CreatePageTitle Property
Gets and sets the string that Windows Media Center uses as the title of the CD or DVD creation page.
Syntax
public override string CreatePageTitle {get; set;}
Property Value
System.String.  Contains the title string.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	CreateFileListHelper Class

# CreateFileListHelper.FileList Property
Gets the list of items.
Syntax
public ListMakerList FileList {get;}
Property Value
Microsoft.MediaCenter.ListMaker.ListMakerList.  Provides access to a collection of list items.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	CreateFileListHelper Class

# CreateFileListHelper.IsOrderImportant Property
Indicates whether the user is allowed to control the order of the files in the list.
Syntax
public override bool IsOrderImportant {get; set;}
Property Value
System.Boolean.  If true, the user should be allowed to control the order; otherwise, false.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	CreateFileListHelper Class

# CreateFileListHelper.ItemAdded Event
Raised when the user adds a new file to the list.
Syntax
public EventHandler ItemAdded;
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	CreateFileListHelper Class

# CreateFileListHelper.ItemCapacity Property
Indicates the capacity of the CD or DVD, in items.
Syntax
public override int ItemCapacity {get; set;}
Property Value
System.Int32.  The capacity of the CD or DVD, in items.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	CreateFileListHelper Class

# CreateFileListHelper.ItemRemoved Event
Raised when the user removes a file from the list.
Syntax
public EventHandler ItemRemoved;
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	CreateFileListHelper Class

# CreateFileListHelper.ItemsCleared Event
Raised when the user clears all files from the list.
Syntax
public EventHandler ItemsCleared;
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	CreateFileListHelper Class

# CreateFileListHelper.ItemsUsed Property
Indicates the amount of CD or DVD space, in items, that has been used so far.
Syntax
public override int ItemsUsed {get; set;}
Property Value
System.Int32.  The amount of space, in items, used so far.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	CreateFileListHelper Class

# CreateFileListHelper.OnClosed Method
Informs a CD/DVD recording application that the user has closed a list of items.
Syntax
public override void OnClosed(
  ClosedReason  closedReason,
  ListMakerList  fileList
);
Parameters
closedReason
Microsoft.MediaCenter.ListMaker.ClosedReason.  The action that the user took when closing a list of items.
fileList
Microsoft.MediaCenter.ListMaker.ListMakerList.  Provides access to a collection of list items.
Return Value
This method does not return a value.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	CreateFileListHelper Class

# CreateFileListHelper.OnItemAdded Method
Informs a CD/DVD recording application that the user has added a new file to the list.
Syntax
public override void OnItemAdded(
  ListMakerItem  item
);
Parameters
item
Microsoft.MediaCenter.ListMaker.ListMakerItem.  An instance of the ListMakerItem class.
Return Value
This method does not return a value.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	CreateFileListHelper Class

# CreateFileListHelper.OnItemRemoved Method
Informs a CD/DVD recording application that the user has removed a file from the list.
Syntax
public override void OnItemRemoved(
  ListMakerItem  item
);
Parameters
item
Microsoft.MediaCenter.ListMaker.ListMakerItem.  An instance of the ListMakerItem class.
Return Value
This method does not return a value.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	CreateFileListHelper Class

# CreateFileListHelper.OnItemsCleared Method
Informs a CD/DVD recording application that the user has clicked the Remove All button to remove all previously selected items from the list.
Syntax
public override void OnItemsCleared();
Return Value
This method does not return a value.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	CreateFileListHelper Class

# CreateFileListHelper.Reset Method
Informs a CD/DVD recording application that the user has reset the list of items.
Syntax
public void Reset(
  bool  resetCapacity,
  bool  resetConfig
);
Parameters
resetCapacity
System.Boolean.  If true, resets the capacity of the list of items, and false otherwise.
resetConfig
System.Boolean.  If true, resets the configuration of the list of items, and false otherwise.
Return Value
This method does not return a value.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	CreateFileListHelper Class

# CreateFileListHelper.SaveListButtonTitle Property
Gets and sets the string for the button label that is used to finish the CD or DVD recording operation.
Syntax
public override string SaveListButtonTitle {get; set;}
Property Value
System.String.  The string for the finish button.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	CreateFileListHelper Class

# CreateFileListHelper.ShowCapacityAsPercentage Property
Indicates whether the status is expressed as a percentage.
Syntax
public override bool ShowCapacityAsPercentage {get; set;}
Property Value
System.Boolean.  If true, the status is a percentage, and false otherwise.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	CreateFileListHelper Class

# CreateFileListHelper.ShowRemainingCapacity Property
Indicates whether the status message should reflect the total capacity or the remaining space on the CD or DVD.
Syntax
public override bool ShowRemainingCapacity {get; set;}
Property Value
System.Boolean.  If true, the status message reflects remaining space on the disc, and false if it reflects the disc capacity.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	CreateFileListHelper Class

# CreateFileListHelper.SupportedMediaTypes Property
Indicates the types of media supported by the CD/DVD recording applications.
Syntax
public override MediaTypes SupportedMediaTypes {get; set;}
Property Value
Microsoft.MediaCenter.ListMaker.MediaTypes.  The types of supported media.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	CreateFileListHelper Class

# CreateFileListHelper.TimeCapacity Property
Gets or sets a value that indicates the total amount of available recording time on the CD or DVD.
Syntax
public override TimeSpan TimeCapacity {get; set;}
Property Value
System.TimeSpan.  The total amount of available recording time.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	CreateFileListHelper Class

# CreateFileListHelper.TimeUsed Property
Indicates the amount of recording time that has been used on the CD or DVD.
Syntax
public override TimeSpan TimeUsed {get; set;}
Property Value
System.TimeSpan.  The amount of recording time that has been used.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	CreateFileListHelper Class

# CreateFileListHelper.ViewListPageTitle Property
Gets and sets the string for the title of the view-list page.
Syntax
public override string ViewListPageTitle {get; set;}
Property Value
System.String.  The title string of the view-list page.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	CreateFileListHelper Class

# DeviceInUseException Class
Contains information about an exception raised by a CD/DVD recording application, indicating that another process is using the required recording device.
Syntax
public class DeviceInUseException : ListMakerException

Public Instance Constructors
Constructor	Description
DeviceInUseException()
Initializes an instance of the DeviceInUseException class.
DeviceInUseException(string)
Initializes an instance of the DeviceInUseException class.
DeviceInUseException(string, Exception)	Initializes an instance of the DeviceInUseException class.

Protected Instance Constructors
Constructor	Description
DeviceInUseException(SerializationInfo, StreamingContext)	Initializes an instance of the DeviceInUseException class.

See Also
•	Microsoft.MediaCenter.ListMaker Namespace

# DeviceInUseException.DeviceInUseException Constructor
Initializes an instance of the DeviceInUseException class.
Overload List
public DeviceInUseException()

public DeviceInUseException(string)

public DeviceInUseException(string, Exception)

protected DeviceInUseException(SerializationInfo, StreamingContext)


# DeviceInUseException.DeviceInUseException Constructor
Initializes an instance of the DeviceInUseException class.
Syntax
public DeviceInUseException();
# DeviceInUseException.DeviceInUseException Constructor
Initializes an instance of the DeviceInUseException class.
Syntax
public DeviceInUseException(
   string message
);
Parameters
message
System.String.  A description of the exception.
# DeviceInUseException.DeviceInUseException Constructor
Initializes an instance of the DeviceInUseException class.
Syntax
public DeviceInUseException(
   string message,
   Exception inner
);
Parameters
message
System.String.  A description of the exception.
inner
System.Exception.  The class on which this exception is based.
# DeviceInUseException.DeviceInUseException Constructor
Initializes an instance of the DeviceInUseException class.
Syntax
protected DeviceInUseException(
   SerializationInfo info,
   StreamingContext context
);
Parameters
info
System.Runtime.Serialization.SerializationInfo.  An instance of the class containing the information needed to serialize the new DeviceInUseException instance.
context
System.Runtime.Serialization.StreamingContext.  A structure that contains contextual information about the source of the serialized stream associated with the new DeviceInUseException instance.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	DeviceInUseException Class

# DiscFormats Enumeration
Defines the disc recording formats that a CD/DVD recording application supports.
Syntax
public enum DiscFormats

The DiscFormats enumeration defines the following constants:
Constant	Description
AudioCD	Audio on CD
DataCD	Data on CD
DataDvd	Data on DVD
HighMat	High-Performance Media Access Technology
SlideshowDvd	Slide show on DVD
SlideshowVcd	Slide show on VCD
Unknown	Unknown recording format
VideoCD	Video on CD
VideoDvd	Video on DVD

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IDiscWriterApp.SelectedFormat Property
•	IDiscWriterApp.SupportedFormat Property
•	Microsoft.MediaCenter.ListMaker Namespace

# DiscSpaceException Class
Contains information about an exception raised by a CD/DVD recording application, indicating that the amount of disc space is not adequate to complete the recording operation.
Syntax
public class DiscSpaceException : ListMakerException

Public Instance Constructors
Constructor	Description
DiscSpaceException()
Initializes an instance of the DiscSpaceException class.
DiscSpaceException(string)
Initializes an instance of the DiscSpaceException class.
DiscSpaceException(string, Exception)
Initializes an instance of the DiscSpaceException class.

Protected Instance Constructors
Constructor	Description
DiscSpaceException(SerializationInfo, StreamingContext)	Initializes an instance of the DiscSpaceException class.

See Also
•	Microsoft.MediaCenter.ListMaker Namespace

# DiscSpaceException.DiscSpaceException Constructor
Initializes an instance of the DiscSpaceException class.
Overload List
public DiscSpaceException()

public DiscSpaceException(string)

public DiscSpaceException(string, Exception)

protected DiscSpaceException(SerializationInfo, StreamingContext)


# DiscSpaceException.DiscSpaceException Constructor
Initializes an instance of the DiscSpaceException class.
Syntax
public DiscSpaceException();
# DiscSpaceException.DiscSpaceException Constructor
Initializes an instance of the DiscSpaceException class.
Syntax
public DiscSpaceException(
   string message
);
Parameters
message
System.String.  A description of the exception.
# DiscSpaceException.DiscSpaceException Constructor
Initializes an instance of the DiscSpaceException class.
Syntax
public DiscSpaceException(
   string message,
   Exception inner
);
Parameters
message
System.String.  A description of the exception.
inner
System.Exception.  The class on which this exception is based.
# DiscSpaceException.DiscSpaceException Constructor
Initializes an instance of the DiscSpaceException class.
Syntax
protected DiscSpaceException(
   SerializationInfo info,
   StreamingContext context
);
Parameters
info
System.Runtime.Serialization.SerializationInfo.  An instance of the class containing the information needed to serialize the new DiscSpaceException instance.
context
System.Runtime.Serialization.StreamingContext.  A structure that contains contextual information about the source of the serialized stream associated with the new DiscSpaceException instance.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	DiscSpaceException Class
# DrmNoRightsException Class
Contains information about an exception raised because a CD/DVD recording application attempted to copy DRM-protected content, but the user has not been granted copying privileges.
Syntax
public class DrmNoRightsException : ListMakerException

Public Instance Constructors
Constructor	Description
DrmNoRightsException()
Initializes an instance of the DrmNoRightsException class.
DrmNoRightsException(string)
Initializes an instance of the DrmNoRightsException class.
DrmNoRightsException(string, Exception)	Initializes an instance of the DrmNoRightsException class.

Protected Instance Constructors
Constructor	Description
DrmNoRightsException(SerializationInfo, StreamingContext)	Initializes an instance of the DrmNoRightsException class.

See Also
•	Microsoft.MediaCenter.ListMaker Namespace

# DrmNoRightsException.DrmNoRightsException Constructor
Initializes an instance of the DrmNoRightsException class.
Overload List
public DrmNoRightsException()

public DrmNoRightsException(string)

public DrmNoRightsException(string, Exception)

protected DrmNoRightsException(SerializationInfo, StreamingContext)


# DrmNoRightsException.DrmNoRightsException Constructor
Initializes an instance of the DrmNoRightsException class.
Syntax
public DrmNoRightsException();
# DrmNoRightsException.DrmNoRightsException Constructor
Initializes an instance of the DrmNoRightsException class.
Syntax
public DrmNoRightsException(
   string message
);
Parameters
message
System.String.  A description of the exception.
# DrmNoRightsException.DrmNoRightsException Constructor
Initializes an instance of the DrmNoRightsException class.
Syntax
public DrmNoRightsException(
   string message,
   Exception inner
);
Parameters
message
System.String.  A description of the exception.
inner
System.Exception.  The class on which this exception is based.
# DrmNoRightsException.DrmNoRightsException Constructor
Initializes an instance of the DrmNoRightsException class.
Syntax
protected DrmNoRightsException(
   SerializationInfo info,
   StreamingContext context
);
Parameters
info
System.Runtime.Serialization.SerializationInfo.  An instance of the class containing the information needed to serialize the new DrmNoRightsException instance.
context
System.Runtime.Serialization.StreamingContext. A structure that contains contextual information about the source of the serialized stream associated with the new DrmNoRightsException instance.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	DrmNoRightsException Class
# FileAlreadyExistsException Class
Contains information about an exception raised by a CD/DVD recording application, indicating that the file list contains a duplicate file.
Syntax
public class FileAlreadyExistsException : ListMakerException

Public Instance Constructors
Constructor	Description
FileAlreadyExistsException()
Initializes an instance of the FileAlreadyExistsException class.
FileAlreadyExistsException(string)
Initializes an instance of the FileAlreadyExistsException class.
FileAlreadyExistsException(string, Exception)	Initializes an instance of the FileAlreadyExistsException class.

Protected Instance Constructors
Constructor	Description
FileAlreadyExistsException(SerializationInfo, StreamingContext)	Initializes an instance of the FileAlreadyExistsException class.

See Also
•	Microsoft.MediaCenter.ListMaker Namespace

# FileAlreadyExistsException.FileAlreadyExistsException Constructor
Initializes an instance of the FileAlreadyExistsException class.
Overload List
public FileAlreadyExistsException()

public FileAlreadyExistsException(string)

public FileAlreadyExistsException(string, Exception)

protected FileAlreadyExistsException(SerializationInfo, StreamingContext)


# FileAlreadyExistsException.FileAlreadyExistsException Constructor
Initializes an instance of the FileAlreadyExistsException class.
Syntax
public FileAlreadyExistsException();

# FileAlreadyExistsException.FileAlreadyExistsException Constructor
Initializes an instance of the FileAlreadyExistsException class.
Syntax
public FileAlreadyExistsException(
   string message
);

Parameters
message
System.String.  A description of the exception.
# FileAlreadyExistsException.FileAlreadyExistsException Constructor
Initializes an instance of the FileAlreadyExistsException class.
Syntax
public FileAlreadyExistsException(
   string message,
   Exception inner
);

Parameters
message
System.String.  A description of the exception.
inner
System.Exception.  The class on which this exception is based.
# FileAlreadyExistsException.FileAlreadyExistsException Constructor
Initializes an instance of the FileAlreadyExistsException class.
Syntax
protected FileAlreadyExistsException(
   SerializationInfo info,
   StreamingContext context
);

Parameters
info
System.Runtime.Serialization.SerializationInfo.  An instance of the class containing the information needed to serialize the new FileAlreadyExistsException instance.
context
System.Runtime.Serialization.StreamingContext.  A structure that contains contextual information about the source of the serialized stream associated with the new FileAlreadyExistsException instance.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	FileAlreadyExistsException Class

# FileCorruptException Class
Contains information about an exception raised by a CD/DVD recording application, indicating that it encountered a file that contains corrupted data.
Syntax
public class FileCorruptException : ListMakerException

Public Instance Constructors
Constructor	Description
FileCorruptException()
Initializes an instance of the FileCorruptException class.
FileCorruptException(string)
Initializes an instance of the FileCorruptException class.
FileCorruptException(string, Exception)	Initializes an instance of the FileCorruptException class.

Protected Instance Constructors
Constructor	Description
FileCorruptException(SerializationInfo, StreamingContext)	Initializes an instance of the FileCorruptException class.

See Also
•	Microsoft.MediaCenter.ListMaker Namespace

# FileCorruptException.FileCorruptException Constructor
Initializes an instance of the FileCorruptException class.
Overload List
public FileCorruptException()

public FileCorruptException(string)

public FileCorruptException(string, Exception)

protected FileCorruptException(SerializationInfo, StreamingContext)


# FileCorruptException.FileCorruptException Constructor
Initializes an instance of the FileCorruptException class.
Syntax
public FileCorruptException();

# FileCorruptException.FileCorruptException Constructor
Initializes an instance of the FileCorruptException class.
Syntax
public FileCorruptException(
   string message
);

Parameters
message
System.String.  A description of the exception.
# FileCorruptException.FileCorruptException Constructor
Initializes an instance of the FileCorruptException class.
Syntax
public FileCorruptException(
   string message,
   Exception inner
);

Parameters
message
System.String.  A description of the exception.
inner
System.Exception.  The class on which this exception is based.
# FileCorruptException.FileCorruptException Constructor
Initializes an instance of the FileCorruptException class.
Syntax
protected FileCorruptException(
   SerializationInfo info,
   StreamingContext context
);

Parameters
info
System.Runtime.Serialization.SerializationInfo.  An instance of the class containing the information needed to serialize the new FileCorruptException instance.
context
System.Runtime.Serialization.StreamingContext.  A structure that contains contextual information about the source of the serialized stream associated with the new FileCorruptException instance.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	FileCorruptException Class

# FileNotFoundException Class
Contains information about an exception raised by a CD/DVD recording application, indicating that it could not locate a file.
Syntax
public class FileNotFoundException : ListMakerException

Public Instance Constructors
Constructor	Description
FileNotFoundException()
Initializes an instance of the FileNotFoundException class.
FileNotFoundException(string)
Initializes an instance of the FileNotFoundException class.
FileNotFoundException(string, string)
Initializes an instance of the FileNotFoundException class.
FileNotFoundException(string, Exception)	Initializes an instance of the FileNotFoundException class.
FileNotFoundException(string, string, Exception)	Initializes an instance of the FileNotFoundException class.

Protected Instance Constructors
Constructor	Description
FileNotFoundException(SerializationInfo, StreamingContext)	Initializes an instance of the FileNotFoundException class.

Public Instance Properties
Property	Description
FileName
Contains the name of the file that could not be located.

See Also
•	Microsoft.MediaCenter.ListMaker Namespace
# FileNotFoundException.FileName Property
Contains the name of the file that could not be found.
Syntax
public string FileName {get;}

Property Value
System.String.  The name of the file.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	FileNotFoundException Class

# FileNotFoundException.FileNotFoundException Constructor
Initializes an instance of the FileNotFoundException class.
Overload List
public FileNotFoundException()

public FileNotFoundException(string)

public FileNotFoundException(string, string)

public FileNotFoundException(string, string, Exception)

public FileNotFoundException(string, Exception)

protected FileNotFoundException(SerializationInfo, StreamingContext)


# FileNotFoundException.FileNotFoundException Constructor
Initializes an instance of the FileNotFoundException class.
Syntax
public FileNotFoundException();

# FileNotFoundException.FileNotFoundException Constructor
Initializes an instance of the FileNotFoundException class.
Syntax
public FileNotFoundException(
   string message
);

Parameters
message
System.String.  A description of the exception.
# FileNotFoundException.FileNotFoundException Constructor
Initializes an instance of the FileNotFoundException class.
Syntax
public FileNotFoundException(
   string message
   string filename
);

Parameters
message
System.String.  A description of the exception.
filename
System.String.  The name of the file that could not be located.
# FileNotFoundException.FileNotFoundException Constructor
Initializes an instance of the FileNotFoundException class.
Syntax
public FileNotFoundException(
   string message,
   string filename
   Exception inner
);

Parameters
message
System.String.  A description of the exception.
filename
System.String.  The name of the file that could not be located.
inner
System.Exception.  The class on which this exception is based.
# FileNotFoundException.FileNotFoundException Constructor
Initializes an instance of the FileNotFoundException class.
Syntax
public FileNotFoundException(
   string message,
   Exception inner
);

Parameters
message
System.String.  A description of the exception.
inner
System.Exception.  The class on which this exception is based.
# FileNotFoundException.FileNotFoundException Constructor
Initializes an instance of the FileNotFoundException class.
Syntax
protected FileNotFoundException(
   SerializationInfo info,
   StreamingContext context
);

Parameters
info
System.Runtime.Serialization.SerializationInfo.  An instance of the class containing the information needed to serialize the new FileNotFoundException instance.
context
System.Runtime.Serialization.StreamingContext.  A structure that contains contextual information about the source of the serialized stream associated with the new FileNotFoundException instance.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	FileNotFoundException Class

# FitToDiscException Class
Contains information about an exception raised by a CD/DVD recording application, indicating that an error occurred during a recording operation in which the fit-to-disc feature is being used.
If the IDiscWriterApp.FitToDisc property is false, an application can raise this exception to cause Windows Media Center to display a dialog box that prompts the user to choose whether to turn fit-to-disc on.
Syntax
public class FitToDiscException : ListMakerException

Public Instance Constructors
Constructor	Description
FitToDiscException()
Initializes an instance of the FitToDiscException class.
FitToDiscException(string)
Initializes an instance of the FitToDiscException class.
FitToDiscException(string, Exception)
Initializes an instance of the FitToDiscException class.

Protected Instance Constructors
Constructor	Description
FitToDiscException(SerializationInfo, StreamingContext)	Initializes an instance of the FitToDiscException class.

See Also
•	Microsoft.MediaCenter.ListMaker Namespace

# FitToDiscException.FitToDiscException Constructor
Initializes an instance of the FitToDiscException class.
Overload List
public FitToDiscException()

public FitToDiscException(string)

public FitToDiscException(string, Exception)

protected FitToDiscException(SerializationInfo, StreamingContext)


# FitToDiscException.FitToDiscException Constructor
Initializes an instance of the FitToDiscException class.
Syntax
public FitToDiscException();

# FitToDiscException.FitToDiscException Constructor
Initializes an instance of the FitToDiscException class.
Syntax
public FitToDiscException(
   string message
);

Parameters
message
System.String.  A description of the exception.
# FitToDiscException.FitToDiscException Constructor
Initializes an instance of the FitToDiscException class.
Syntax
public FitToDiscException(
   string message,
   Exception inner
);

Parameters
message
System.String.  A description of the exception.
inner
System.Exception.  The class on which this exception is based.
# FitToDiscException.FitToDiscException Constructor
Initializes an instance of the FitToDiscException class.
Syntax
protected FitToDiscException(
   SerializationInfo info,
   StreamingContext context
);

Parameters
info
System.Runtime.Serialization.SerializationInfo.  An instance of the class containing the information needed to serialize the new FitToDiscException instance.
context
System.Runtime.Serialization.StreamingContext.  A structure that contains contextual information about the source of the serialized stream associated with the new FitToDiscException instance.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	FitToDiscException Class

# ICreateFileListHelper Interface
Windows Media Center has the ability to gather lists of files from the user and provide them to a CD/DVD recording application. To get file lists from Windows Media Center, an application must implement the ICreateFileListHelper interface. Windows Media Center uses this interface to provide list items to the application, and to retrieve information from the application about the recording medium. In particular, Windows Media Center gets the total capacity of the medium and the amount of unused space remaining on the medium. Windows Media Center communicates this information to the user during the file selection process.
This interface also provides strings and icons that Windows Media Center uses to customize the list-making part of the user interface. This interface enables your application to establish your brand's identity inside Windows Media Center.
public interface ICreateFileListHelper

Members
Public Instance Methods
Method	Description
OnClosed
Informs a CD/DVD recording application that the user has closed a list of items.
OnItemAdded
Informs a CD/DVD recording application that the user has added a new file to the list.
OnItemRemoved
Informs a CD/DVD recording application that the user has removed a file from the list.
OnItemsCleared
Informs a CD/DVD recording application that the user has clicked the Remove All button to remove all previously selected items from the list.

Public Instance Properties
Property	Description
ByteCapacity
Indicates the capacity of the CD or DVD, in bytes.
BytesUsed
Indicates the amount of CD or DVD space, in bytes, that has been used so far.
CancelDialogMessage
Gets and sets the string that Windows Media Center uses as the message in the cancel dialog box.

CancelDialogTitle
Gets and sets the string that Windows Media Center uses as the title of the cancel dialog box.
CapacityFormat
Indicates the format in which the CD/DVD recording application provides status information.
CreatePageTitle
Gets and sets the string that Windows Media Center uses as the title of the CD or DVD creation page.
IsOrderImportant
Indicates whether the user is allowed to control the order of the files in the list.
ItemCapacity
Indicates the capacity of the CD or DVD, in items.
ItemsUsed
Indicates the amount of CD or DVD space, in items, that has been used so far.
SaveListButtonTitle
Gets and sets the string for the button label that is used to finish the CD or DVD recording operation.
ShowCapacityAsPercentage
Indicates whether the status is expressed as a percentage.
ShowRemainingCapacity
Indicates whether the status message should reflect the total capacity or the remaining space on the CD or DVD.
SupportedMediaTypes
Indicates the types of media supported by the CD/DVD recording applications.
TimeCapacity
Gets or sets a value that indicates the total amount of available recording time on the CD or DVD.
TimeUsed
Indicates the amount of recording time that has been used on the CD or DVD.
ViewListPageTitle
Gets and sets the string for the title of the view-list page.

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista
See Also
•	Microsoft.MediaCenter.ListMaker Namespace

# ICreateFileListHelper.ByteCapacity Property
Gets a value that indicates the capacity of the CD or DVD, in bytes.
Syntax
public Int64 ByteCapacity {get;}
Property Value
System.Int64.  The capacity of the CD or DVD.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	ICreateFileListHelper Interface

# ICreateFileListHelper.BytesUsed Property
Gets a value that indicates the amount of CD or DVD space, in bytes, that has been used so far.
Syntax
public Int64 BytesUsed {get;}
Property Value
System.Int64.  The amount of space used so far.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	ICreateFileListHelper Interface

# ICreateFileListHelper.CancelDialogMessage Property
Gets and sets the string that Windows Media Center uses as the message in the cancel dialog box.
Syntax
public string CancelDialogMessage {get;}
Property Value
System.String.  Contains the dialog box message string.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	ICreateFileListHelper Interface

# ICreateFileListHelper.CancelDialogTitle Property
Gets and sets the string that Windows Media Center uses as the title of the cancel dialog box.
Syntax
public string CancelDialogTitle {get;}
Property Value
System.String.  Contains the dialog box title string.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	ICreateFileListHelper Interface

# ICreateFileListHelper.CapacityFormat Property
Indicates the format in which the CD/DVD recording application provides status information.
Syntax
public CapacityFormat CapacityFormat {get;}
Property Value
Microsoft.MediaCenter.ListMaker.CapacityFormat.  Indicates the format of the status information.
This property is read-only.
Remarks
Windows Media Center uses this property to determine the format (byte, time, or item) in which it presents status messages to the user.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	ICreateFileListHelper Interface

# ICreateFileListHelper.CreatePageTitle Property
Gets and sets the string that Windows Media Center uses as the title of the CD or DVD creation page.
Syntax
public string CreatePageTitle {get;}
Property Value
System.String.  Contains the title string.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	ICreateFileListHelper Interface

# ICreateFileListHelper.IsOrderImportant Property
Indicates whether the user is allowed to control the order of the files in the list.
Syntax
public bool IsOrderImportant {get;}
Property Value
System.Boolean.  If true, the user should be allowed to control the order; otherwise, false.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	ICreateFileListHelper Interface

# ICreateFileListHelper.ItemCapacity Property
Indicates the capacity of the CD or DVD, in items.
Syntax
public int ItemCapacity {get;}
Property Value
System.Int32.  The capacity of the CD or DVD, in items.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	ICreateFileListHelper Interface

# ICreateFileListHelper.ItemsUsed Property
Indicates the amount of CD or DVD space, in items, that has been used so far.
Syntax
public int ItemsUsed {get;}
Property Value
System.Int32.  The amount of space used so far.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	ICreateFileListHelper Interface

# ICreateFileListHelper.OnClosed Method
Informs a CD/DVD recording application that the user has closed a list of items.
Syntax
public void OnClosed(
  ClosedReason  closedReason,
  ListMakerList  fileList
);
Parameters
closedReason
Microsoft.MediaCenter.ListMaker.ClosedReason.  The action that the user took when closing a list of items.
fileList
Microsoft.MediaCenter.ListMaker.ListMakerList.  Provides access to a collection of list items.
Return Value
This method does not return a value.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	ICreateFileListHelper Interface

# ICreateFileListHelper.OnItemAdded Method
Informs a CD/DVD recording application that the user has added a new file to the list.
Syntax
public void OnItemAdded(
  ListMakerItem  item
);
Parameters
item
Microsoft.MediaCenter.ListMaker.ListMakerItem.  An instance of the ListMakerItem class.
Return Value
This method does not return a value.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	ICreateFileListHelper Interface

# ICreateFileListHelper.OnItemRemoved Method
Informs a CD/DVD recording application that the user has removed a file from the list.
Syntax
public void OnItemRemoved(
  ListMakerItem  item
);
Parameters
item
Microsoft.MediaCenter.ListMaker.ListMakerItem.  An instance of the ListMakerItem class.
Return Value
This method does not return a value.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	ICreateFileListHelper Interface

# ICreateFileListHelper.OnItemsCleared Method
Informs a CD/DVD recording application that the user has clicked the Remove All button to remove all previously selected items from the list.
Syntax
public void OnItemsCleared();
Return Value
This method does not return a value.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	ICreateFileListHelper Interface

# ICreateFileListHelper.SaveListButtonTitle Property
Gets the string for the button label that is used to finish the CD or DVD recording operation.
Syntax
public string SaveListButtonTitle {get;}
Property Value
System.String.  The string for the finish button.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	ICreateFileListHelper Interface

# ICreateFileListHelper.ShowCapacityAsPercentage Property
Indicates whether the status is expressed as a percentage.
Syntax
public bool ShowCapacityAsPercentage {get;}
Property Value
System.Boolean.  If true, the status is a percentage, and false otherwise.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	ICreateFileListHelper Interface

# ICreateFileListHelper.ShowRemainingCapacity Property
Indicates whether the status message should reflect the total capacity or the remaining space on the CD or DVD.
Syntax
public bool ShowRemainingCapacity {get;}
Property Value
System.Boolean.  If true, the status message reflects remaining space on the disc, and false if it reflects the disc capacity.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	ICreateFileListHelper Interface

# ICreateFileListHelper.SupportedMediaTypes Property
Indicates the types of media supported by the CD/DVD recording applications.
Syntax
public MediaTypes SupportedMediaTypes {get;}
Property Value
Microsoft.MediaCenter.ListMaker.MediaTypes.  The types of supported media.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	ICreateFileListHelper Interface

# ICreateFileListHelper.TimeCapacity Property
Gets a value that indicates the total amount of available recording time on the CD or DVD.
Syntax
public TimeSpan TimeCapacity {get;}
Property Value
System.TimeSpan.  The total amount of available recording time.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	ICreateFileListHelper Interface

# ICreateFileListHelper.TimeUsed Property
Indicates the amount of recording time that has been used on the CD or DVD.
Syntax
public TimeSpan TimeUsed {get;}
Property Value
System.TimeSpan.  The amount of recording time that has been used.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	ICreateFileListHelper Interface

# ICreateFileListHelper.ViewListPageTitle Property
Gets and sets the string for the title of the view-list page.
Syntax
public string ViewListPageTitle {get;}
Property Value
System.String.  The title string of the view-list page.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	ICreateFileListHelper Interface

# IDiscWriterApp Interface
A CD/DVD recording application for Windows Media Center must implement the IDiscWriterApp interface. Windows Media Center uses this interface to retrieve information from the application, including the available drives, the supported recording formats, the currently selected drive, and so on. Windows Media Center also provides disc-related information to the application through this interface.
Syntax
public interface IDiscWriterApp : IListMakerApp

Public Instance Methods
Method	Description
Erase
Causes a CD/DVD recording application to erase the contents of the currently selected disc.

Public Instance Properties
Property	Description
AvailableDrives
Gets an array of strings, each containing the drive letter of a disc drive capable of writing data to a CD or DVD.
FitToDisc
Gets or sets a value that indicates whether the user has selected the Fit To Disc recording option.
InUseDriveLetter
Gets a value that indicates the letter of the disc drive that is currently in use.
IsBlank
Gets a value that indicates whether the recording medium is blank.
IsDiscViable
Gets a value that indicates whether the recording medium is still usable.
IsErasable
Gets a value that indicates whether the current medium is erasable—that is, whether it is a read/write medium that contains content.
SelectedDrive
Gets a value that indicates the drive letter of the currently selected drive.
SelectedFormat
Gets a value that indicates the currently selected disc format.
SupportedFormat
Gets an array of flags that indicates the disc recording formats that a CD/DVD recording application supports.
SupportsFitToDisc
Gets a value that indicates whether the fit-to-disc feature is on or off.

See Also
•	Microsoft.MediaCenter.ListMaker Namespace

# IDiscWriterApp.AvailableDrives Property
Gets an array of strings, each containing the drive letter of a disc drive capable of writing data to a CD or DVD.
Syntax
public IEnumerableAvailableDrives {get;}

Property Value
IEnumerable  An array of strings containing drive letters.
This property is read-only.
Remarks
This property enables the user to select from a list of available drives.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IDiscWriterApp Interface

# IDiscWriterApp.Erase Method
Causes a CD/DVD recording application to erase the contents of the currently selected disc.
Syntax
public bool Erase(
   CompletionCallback ce
);

Parameters
ce
Microsoft.MediaCenterMicrosoft.MediaCenter.ListMaker.CompletionCallback.  A delegate that the application calls to convey the success or failure of the erase operation.
Return Value
System.Boolean. It is true if the erase operation succeeded, and false otherwise.
Remarks
When Windows Media Center calls this method, the application should immediately begin erasing the disc, preferably as an asynchronous operation.
This method can raise list-maker exceptions.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	CompletionCallback Delegate
•	IDiscWriterApp Interface

# IDiscWriterApp.FitToDisc Property
Gets or sets a value that indicates whether the fit-to-disc feature is on or off.
Syntax
public bool FitToDisc {get; set;}

Property Value
System.Boolean. It is true if fit-to-disc is on, and false if it is off.
This property is read/write.
Remarks
Fit-to-disc is a DVD-V/VCD feature that enables the CD/DVD recording application to re-transcode files to make more content fit on the disc. The application should set this property to false so that fit-to-disc is off by default. At the appropriate time, Windows Media Center will prompt the user to choose whether to turn fit-to-disc on. The application can cause this prompt by raising the FitToDiscException in response to the IListMakerApp.ItemAdded method.
The application should prompt the user only when the space constraints of the disc have been exceeded. If the user chooses to enable fit-to-disc, Windows Media Center sets the FitToDisc property to true and adds the list item again. Also, Windows Media Center queries the IListMakerApp.CapacityFormat property again, so the application can to change to a "Counting Up" format, if needed.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IDiscWriterApp Interface

# IDiscWriterApp.InUseDriveLetter Property
Gets a value that indicates the letter of the disc drive that is currently in use.
Syntax
public string InUseDriveLetter {get;}

Property Value
System.String. The drive letter of the disc in use.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IDiscWriterApp Interface

# IDiscWriterApp.IsBlank Property
Gets a value that indicates whether the recording medium is blank.
Syntax
public bool IsBlank {get;}

Property Value
System.Boolean. It is true if the recording medium is blank, and false otherwise.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IDiscWriterApp Interface

# IDiscWriterApp.IsDiscViable Property
Gets a value that indicates whether the recording medium is still usable.
Syntax
public bool IsDiscViable {get;}

Property Value
System.Boolean. It is true if the recording medium is still usable, and false otherwise.
This property is read-only.
Remarks
If a CD or DVD recording operation fails or is canceled by the user, Windows Media Center queries this property to determine whether the currently selected recording medium is still usable.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IDiscWriterApp Interface

# IDiscWriterApp.IsErasable Property
Gets a value that indicates whether the current medium is erasable; that is, whether it is a read/write medium that contains content.
Syntax
public bool IsErasable {get;}

Property Value
System.Boolean. It is true if the current medium is read/write and contains content, and false if the medium is not read/write or does not contain content.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IDiscWriterApp Interface

# IDiscWriterApp.SelectedDrive Property
Gets a value that indicates the drive letter of the currently selected drive.
Syntax
public string SelectedDrive {set;}

Property Value
System.String  The drive letter of the currently selected drive.
This property is write-only.
Remarks
After the user selects a drive, Windows Media Center passes the drive letter of the selected drive to the CD/DVD recording application by setting this property.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IDiscWriterApp Interface

# IDiscWriterApp.SelectedFormat Property
Gets a value that indicates the currently selected disc format.
Syntax
public DiscFormats SelectedFormat {get; set;}

Property Value
Microsoft.MediaCenter.ListMakerMicrosoft.MediaCenter.ListMaker.DiscFormats. The currently selected disc format.
This property is read/write.
Remarks
After the user selects a disc format, Windows Media Center passes the format to the CD/DVD recording application by setting this property.
The application can set this property itself. This enables Windows Media Center to pre-select the correct format.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	DiscFormats Enumeration
•	IDiscWriterApp Interface

# IDiscWriterApp.SupportedFormat Property
Gets an array of flags that indicates the disc recording formats that the CD/DVD recording application supports.
Syntax
public DiscFormats SupportedFormat {get;}

Property Value
Microsoft.MediaCenter.ListMakerMicrosoft.MediaCenter.ListMaker.DiscFormats. An array of flags indicating the supported disc recording formats.
This property is read-only.
Remarks
Windows Media Center uses this property to enable the user to select from a list of available recording formats.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	DiscFormats Enumeration
•	IDiscWriterApp Interface

# IDiscWriterApp.SupportsFitToDisc Property
Gets a value that indicates whether the CD/DVD recording application supports the fit-to-disc recording option.
Syntax
public bool SupportsFitToDisc {get;}

Property Value
System.Boolean. It is true if fit-to-disc is supported, and false otherwise.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IDiscWriterApp Interface

# IListMakerApp Interface
Windows Media Center has the ability to gather lists of files from the user and provide them to a CD/DVD recording application. To get file lists from Windows Media Center, an application must implement the IListMakerApp interface. Windows Media Center uses this interface to provide list items to the application, and to retrieve information from the application about the recording medium. In particular, Windows Media Center gets the total capacity of the medium and the amount of unused space remaining on the medium. Windows Media Center communicates this information to the user during the file selection process.
This interface also provides strings and icons that Windows Media Center uses to customize the list-making part of the user interface. This interface enables your application to establish your brand's identity inside Windows Media Center.
Syntax
public interface IListMakerApp

Public Instance Methods
Method	Description
Cancel
Informs a CD/DVD recording application that the user canceled the list-making operation.
ItemAdded
Informs a CD/DVD recording application that the user added a new file to the list.
ItemRemoved
Informs a CD/DVD recording application that the user removed a file from the list.
Launch
Starts a CD/DVD recording application.
RemoveAllItems
Informs an application that the user clicked the Remove All button to remove all previously selected items from the list.
Repeat
Causes the CD/DVD recording application to repeat the previous recording operation.

Public Instance Properties
Property	Description
ByteCapacity
Gets a value that indicates the capacity of the CD or DVD, in bytes.
ByteUsed
Gets a value that indicates the amount of CD or DVD space, in bytes, that has been used so far.
CanProceed
Gets a value that indicates whether the CD/DVD recording application can proceed with a recording operation.
CapacityFormat
Gets a value that indicates the format in which the CD/DVD recording application provides status information.
CreatePageTitle
Gets the string that Windows Media Center uses as the title of the list creation page.
FailureReason
Gets information about an exception raised when an operation failed.
IsPercentCompleteKnown
Gets a value that indicates whether the percentage completed is known.
IsTimeRemainingKnown
Gets a value that indicates whether the amount of time remaining until completion is known.
ItemCapacity
Gets a value that indicates the capacity of the CD or DVD, in items.
ItemUsed
Gets a value that indicates the amount of CD or DVD space, in items, that has been used so far.
IsOrderImportant
Gets a value that indicates whether the user should be allowed to control the order of the files in the list.
PageTitle
Gets the string that Windows Media Center places in the upper-right corner of CD/DVD creation pages.
PercentComplete
Gets a value that indicates the progress that the CD/DVD recording application has made in the recording operation.
Repeatable
Gets a value that indicates whether to let the user repeat the previous CD or DVD recording operation.
SaveListButtonTitle
Gets the string that Windows Media Center places on the button that is used to finish the CD or DVD recording operation.
ShowCapacityAsPercentage
Gets a value that indicates whether the status is expressed as a percentage.
ShowRemainingCapacity
Gets a value that indicates whether the status message should reflect the capacity of, or space remaining on, the CD or DVD.
Succeeded
Gets a value that indicates whether the operation finished successfully.
SupportedMediaTypes
Gets a value that indicates the types of media that the CD/DVD recording application supports.
TimeCapacity
Gets a value that indicates the capacity of the CD or DVD, in recording time.
TimeRemaining
Gets a value that indicates the estimated time remaining before the recording operation is completed.
TimeUsed
Gets a value that indicates the amount of recording time that has been used on CD or DVD.
ViewListButtonTitle
Gets the string that Windows Media Center places on the button that is used to view the media items to be copied to the CD or DVD.
ViewListPageTitle
Gets the string that Windows Media Center uses as the title of the view-list page.

Public Instance Events
Event	Description
Completed
Raised when the operation has completed.
ProgressChanged
Raised when the progress of the operation has changed.

See Also
•	Microsoft.MediaCenter.ListMaker Namespace

# IListMakerApp.ByteCapacity Property
Gets a value that indicates the capacity of the CD or DVD, in bytes.
Syntax
public long ByteCapacity {get;}

Property Value
System.Int64. The capacity of the CD or DVD.
This property is read-only.
Remarks
Windows Media Center gets this property if the CapacityFormat property is set to Byte. This property, combined with ByteUsed and the formatting properties, are used to create the final status message.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IListMakerApp Interface

# IListMakerApp.ByteUsed Property
Gets a value that indicates the amount of CD or DVD space, in bytes, that has been used so far.
Syntax
public long ByteUsed {get;}

Property Value
System.Int64. The amount of space used so far.
This property is read-only.
Remarks
Windows Media Center gets this property if the CapacityFormat property is set to Byte. This property, combined with ByteCapacity and the formatting properties, are used to create the final status message.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IListMakerApp Interface

# IListMakerApp.Cancel Method
Informs a CD/DVD recording application that the user canceled the list-making operation.
Syntax
public void Cancel();

Parameters
This method takes no parameters.
Return Value
This method does not return a value.
Remarks
Windows Media Center calls this method if the user exits the list-making operation, or cancels the recording operation after Windows Media Center starts copying files to the CD or DVD. An application can use the CompletionCallback delegate to report errors.
If the user cancels a recording operation after copying has begun, Windows Media Center queries the IDiscWriterApp.IsDiscViable property to determine whether the disc is still usable.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	CompletionCallback Delegate
•	IDiscWriterApp.IsDiscViable Property
•	IListMakerApp Interface

# IListMakerApp.CanProceed Property
Gets a value that indicates whether the CD/DVD recording application can proceed with a recording operation.
Syntax
public bool CanProceed {get;}

Property Value
System.Boolean. It is true if the application can proceed with a recording operation, and false otherwise.
This property is read-only.
Remarks
Before invoking the application, Windows Media Center checks this property to determine whether the application can perform a recording operation. If the application cannot perform the operation (for example, the required hardware or medium is not present), it should set this property to false.
The application should raise a ListMakerException if it encounters a problem.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IListMakerApp Interface
•	ListMakerException Class

# IListMakerApp.CapacityFormat Property
Gets a value that indicates the format in which the CD/DVD recording application provides status information.
Syntax
public CapacityFormat CapacityFormat {get;}

Property Value
Microsoft.MediaCenterMicrosoft.MediaCenter.ListMaker.CapacityFormat. The format of the status information.
This property is read-only.
Remarks
Windows Media Center uses this property to determine the format (byte, time, or item) in which it presents status messages to the user.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	CapacityFormat Enumeration
•	IListMakerApp Interface

# IListMakerApp.Completed Event
Raised when the operation has completed.
Syntax
public event System.EventHandler Completed;

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IListMakerApp Interface

# IListMakerApp.CreatePageTitle Property
Gets the string that Windows Media Center uses as the title of the CD or DVD creation page.
Syntax
public string CreatePageTitle {get;}

Property Value
System.String. Contains the title string.
This property is read-only.
Remarks
If this property is null, Windows Media Center uses the default title string on the list creation page ("Name this CD" or "Name this DVD," depending on the recording medium). Windows Media Center provides a string that is localized for the current locale. If your application uses a custom title string, be sure the CreatePageTitle property provides an appropriately localized version of the string.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IDiscWriterApp Interface

# IListMakerApp.FailureReason Property
Gets information about an exception raised when an operation failed.
Syntax
public Exception FailureReason {get;}

Property Value
System.Exception.  The object on which this exception is based.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IListMakerApp Interface

# IListMakerApp.IsOrderImportant Property
Gets a value that indicates whether the user should be allowed to control the order of the files in the list.
Syntax
public bool IsOrderImportant {get;}

Property Value
System.Boolean. It is true if the user should be allowed to control the order, and false otherwise.
This property is read-only.
Remarks
Windows Media Center uses this property to determine whether to display up-down arrows that enable the user to control the file order. Typically, the user should be allowed to control the order of files in an audio playlist.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IListMakerApp Interface

# IListMakerApp.IsPercentCompleteKnown Property
Gets a value that indicates whether the percentage completed is known.
Syntax
public bool IsPercentCompleteKnown {get;}

Property Value
System.Boolean. It is true if the percentage completed is known, and false otherwise.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IListMakerApp Interface

# IListMakerApp.IsTimeRemainingKnown Property
Gets a value that indicates whether the amount of time remaining until completion is known.
Syntax
public bool IsTimeRemainingKnown {get;}

Property Value
System.Boolean. It is true if the time remaining until completion is known.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IListMakerApp Interface

# IListMakerApp.ItemAdded Method
Informs a CD/DVD recording application that the user added a new file to the list.
Syntax
public void ItemAdded(
   ListMakerItem item
);

Parameters
item
Microsoft.MediaCenter.ListMaker.ListMakerItem.  An instance of the ListMakerItem class.
Return Value
This method does not return a value.
Remarks
The members of the ListMakerItem class provide information about the new item. An application can use this information to determine the appropriate value to return in its ByteUsed property.
This method should raise a ListMakerException if it encounters a problem.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IListMakerApp Interface

# IListMakerApp.ItemCapacity Property
Gets a value that indicates the capacity of the CD or DVD, in items.
Syntax
public int ItemCapacity {get;}

Property Value
System.Int32. The capacity of the CD or DVD.
This property is read-only.
Remarks
Windows Media Center gets this property if the CapacityFormat property is set to Item. This property, combined with the ItemUsed property and the formatting properties, are used to create the final status message.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IListMakerApp Interface

# IListMakerApp.ItemRemoved Method
Informs a CD/DVD recording application that the user removed a file from the list.
Syntax
public void ItemRemoved(
   ListMakerItem item
);

Parameters
item
Microsoft.MediaCenter.ListMaker.ListMakerItem.  An instance of the ListMakerItem class.
Return Value
This method does not return a value.
Remarks
The members of the ListMakerItem class provide information about the item that was removed. An application can use this information to determine the appropriate value to return in its ItemUsed property.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IListMakerApp Interface

# IListMakerApp.ItemUsed Property
Gets a value that indicates the amount of CD or DVD space, in items, that has been used so far.
Syntax
public int ItemUsed {get;}

Property Value
System.Int32. The amount of space used so far.
This property is read-only.
Remarks
Windows Media Center gets this property if the CapacityFormat property is set to Item. This property, combined with ItemCapacity and the formatting properties, are used to create the final status message.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IListMakerApp Interface

# IListMakerApp.Launch Method
Starts a CD/DVD recording application.
Syntax
public void Launch(
   ListMakerList lml);

Parameters
lml
Microsoft.MediaCenterMicrosoft.MediaCenter.ListMaker.ListMakerList.  An instance of the ListMakerList class. The application uses this interface to retrieve the list items.
Return Value
This method does not return a value.
Remarks
Windows Media Center calls this method to launch a CD/DVD recording application. After calling this method, Windows Media Center closes ListMaker and returns the user to the shell. When the CD/DVD recording application finishes the recording operation, it should call the CompletionCallback delegate.
If the Repeatable property is true, Windows Media Center prompts the user to repeat the operation when the recording operation is completed. If the user indicates yes, Windows Media Center calls the application's Repeat method.
This method should raise a ListMakerException if it encounters a problem.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	CompletionCallback Delegate
•	IListMakerApp Interface

# IListMakerApp.PageTitle Property
Gets the string that Windows Media Center places in the upper-right corner of CD/DVD creation pages.
Syntax
public string PageTitle {get;}

Property Value
System.String. The page title string.
This property is read-only.
Remarks
If this property is null, Windows Media Center uses the default page-title string ("create cd" or "create dvd", depending on the recording medium). Windows Media Center provides a string that is localized for the current locale. If your application uses a custom page-title string, be sure the PageTitle property provides an appropriately localized version of the string.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IDiscWriterApp Interface

# IListMakerApp.PercentComplete Property
Gets a value that indicates the amount of progress that the CD/DVD recording application has made in the recording operation.
Syntax
public float PercentComplete {get;}

Property Value
System.Single. A value from 0.0 (not started) to 1.0 (operation completed).
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IListMakerApp Interface

# IListMakerApp.ProgressChanged Event
Raised when the progress of the operation has changed.
Syntax
public event System.EventHandler ProgressChanged;

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IListMakerApp Interface

# IListMakerApp.RemoveAllItems Method
Informs an application that the user has clicked the Remove All button to remove all previously selected items from the list.
Syntax
public void RemoveAllItems();

Parameters
This method takes no parameters.
Return Value
This method does not return a value.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IListMakerApp Interface

# IListMakerApp.Repeat Method
Causes the CD/DVD recording application to repeat the previous recording operation.
Syntax
public void Repeat(
   ListMakerList lml);

Parameters
lml
Microsoft.MediaCenterMicrosoft.MediaCenter.ListMaker.ListMakerList.  An instance of the ListMakerList class. The application uses this interface to retrieve the list items.
Return Value
This method does not return a value.
Remarks
If the Repeatable property is true, Windows Media Center prompts the user to repeat the operation when the previous recording operation is completed. If the user indicates yes, Windows Media Center calls this method.
This method is similar to IListMakerApp.Launch method, except that the application can re-use any setup parameters that it previously gathered from the user.
This method should raise a ListMakerException if it encounters a problem.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IListMakerApp Interface

# IListMakerApp.Repeatable Property
Gets a value that indicates whether to let the user repeat the previous CD or DVD recording operation.
Syntax
public bool Repeatable {get;}

Property Value
System.Boolean. It is true if the user is allowed to repeat the recording operation, and false otherwise.
This property is read-only.
Remarks
If this property is true, Windows Media Center prompts the user to repeat the operation when the recording operation is completed. If the user indicates yes, Windows Media Center calls the application's Repeat method.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IListMakerApp Interface

# IListMakerApp.SaveListButtonTitle Property
Gets the string that Windows Media Center places on the button that is used to finish the CD or DVD recording operation.
Syntax
public string SaveListButtonTitle {get;}

Property Value
System.String. The string for the finish button.
This property is read-only.
Remarks
If this property is null, Windows Media Center uses the default string ("Burn CD" or "Burn DVD," depending on the recording medium). Windows Media Center provides a string that is localized for the current locale. If your application uses a custom page-title string, be sure the SaveListButtonTitle property provides an appropriately localized version of the string.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IDiscWriterApp Interface

# IListMakerApp.ShowCapacityAsPercentage Property
Gets a value that indicates whether the status is expressed as a percentage.
Syntax
public bool ShowCapacityAsPercentage {get;}

Property Value
System.Boolean. It is true if status is a percentage, and false otherwise.
This property is read-only.
Remarks
Windows Media Center uses this property and the CapacityFormat property to determine whether to express status as a percentage of space, time, or number of items.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IListMakerApp Interface

# IListMakerApp.ShowRemainingCapacity Property
Gets a value that indicates whether the status message should reflect the capacity of, or space remaining on, the CD or DVD.
Syntax
public bool ShowRemainingCapacity {get;}

Property Value
System.Boolean. It is true if the status message should reflect remaining space, and false if it should reflect the capacity.
This property is read-only.
Remarks
Windows Media Center uses this property in conjunction with the ShowCapacityAsPercentage and CapacityFormat properties to create the final status message. For example, setting the ShowRemainingCapacity property to true, ShowCapacityAsPercentage to false and CapacityFormat to Bytes would result in a message such as "512 Mb Remaining".
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IListMakerApp Interface

# IListMakerApp.Succeeded Property
Gets a value that indicates whether the operation finished successfully.
Syntax
public bool Succeeded {get;}

Property Value
System.Boolean. It is true if the recording finished successfully, and false otherwise.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IListMakerApp Interface

# IListMakerApp.SupportedMediaTypes Property
Gets a value that indicates the types of media supported by the CD/DVD recording applications.
Syntax
public MediaTypes SupportedMediaTypes {get;}

Property Value
Microsoft.MediaCenterMicrosoft.MediaCenter.ListMaker.MediaTypes. The types of supported media.
This property is read-only.
Remarks
Windows Media Center uses this property to limit the types of media that it offers to the user.
For a list of valid media types, see the MediaTypes enumeration.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IListMakerApp Interface

# IListMakerApp.TimeCapacity Property
Gets a value that indicates the total amount of recording time available on the CD or DVD, expressed as a TimeSpan structure.
Syntax
public TimeSpan TimeCapacity {get;}

Property Value
System.TimeSpan. The total amount of recording time available.
This property is read-only.
Remarks
Windows Media Center gets this property if the CapacityFormat property is set to Time. This property, combined with the TimeUsed property and the formatting properties, are used to create the final status message.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IListMakerApp Interface

# IListMakerApp.TimeRemaining Property
Gets a value that indicates the estimated amount of time remaining before the CD or DVD recording operation is completed.
Syntax
public TimeSpan TimeRemaining {get;}

Property Value
System.TimeSpan. The estimated amount of time remaining.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IListMakerApp Interface

# IListMakerApp.TimeUsed Property
Gets a value that indicates the amount of recording time that has been used on the CD or DVD.
Syntax
public TimeSpan TimeUsed {get;}

Property Value
System.TimeSpan. The amount of recording time that has been used.
This property is read-only.
Remarks
Windows Media Center gets this property if the CapacityFormat property is set to Time. This property, combined with the TimeCapacity property and the formatting properties, are used to create the final status message.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IListMakerApp Interface

# IListMakerApp.ViewListButtonTitle Property
Gets the string that Windows Media Center places on the button that is used to view the media items to be copied to the CD or DVD.
Syntax
public string ViewListButtonTitle {get;}

Property Value
System.String. The string for the view-list button.
This property is read-only.
Remarks
If this property is null, Windows Media Center uses the default string ("View CD" or "View DVD," depending on the recording medium). Windows Media Center provides a string that is localized for the current locale. If your application uses a custom string, be sure the ViewListButtonTitle property provides an appropriately localized version of the string.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IDiscWriterApp Interface

# IListMakerApp.ViewListPageTitle Property
Gets the string that Windows Media Center uses as the title of the view-list page.
Syntax
public string ViewListPage {get;}

Property Value
System.String. The title string.
This property is read-only.
Remarks
If this property is null, Windows Media Center uses the default string ("View CD" or "View DVD," depending on the recording medium). Windows Media Center provides a string that is localized for the current locale. If your application uses a custom string, be sure the ViewListPageTitle property provides an appropriately localized version of the string.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IDiscWriterApp Interface

# InitialListType Enumeration
Indicates the type of list to use when initializing the CD/DVD recording application.
public enum InitialListType
Members
Value	Description
Empty	An empty list.
LastSaved	The last saved list.
Original	The original list.

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.ListMaker Namespace

# InstallationException Class
Contains information about an exception raised because of problems with the installation of the application.
Syntax
public class InstallationException : ListMakerException

Public Instance Constructors
Constructor	Description
InstallationException()
Initializes an instance of the InstallationException class.
InstallationException(string)
Initializes an instance of the InstallationException class.
InstallationException(string, Exception)	Initializes an instance of the InstallationException class.

Protected Instance Constructors
Constructor	Description
InstallationException(SerializationInfo, StreamingContext)	Initializes an instance of the InstallationException class.

See Also
•	Microsoft.MediaCenter.ListMaker Namespace

# InstallationException.InstallationException Constructor
Initializes an instance of the InstallationException class.
Overload List
public InstallationException()

public InstallationException(string)

public InstallationException(string, Exception)

protected InstallationException(SerializationInfo, StreamingContext)


# InstallationException.InstallationException Constructor
Initializes an instance of the InstallationException class.
Syntax
public InstallationException();

# InstallationException.InstallationException Constructor
Initializes an instance of the InstallationException class.
Syntax
public InstallationException(
   string message
);

Parameters
message
System.String.  A description of the exception.
# InstallationException.InstallationException Constructor
Initializes an instance of the InstallationException class.
Syntax
public InstallationMakerException(
   string message,
   Exception inner
);

Parameters
message
System.String.  A description of the exception.
inner
System.Exception.  The class on which this exception is based.
# InstallationException.InstallationException Constructor
Initializes an instance of the InstallationException class.
Syntax
protected InstallationException(
   SerializationInfo info,
   StreamingContext context
);

Parameters
info
System.Runtime.Serialization.SerializationInfo.  An instance of the class containing the information needed to serialize the new InstallationException instance.
context
System.Runtime.Serialization.StreamingContext.  A structure that contains contextual information about the source of the serialized stream associated with the new InstallationException instance.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	InstallationException Class
# ListMakerException Class
Contains information about an exception raised by a CD/DVD recording application while processing files from Windows Media Center.
Syntax
public class ListMakerException : System.Exception

Public Instance Constructors
Constructor	Description
ListMakerException()
Initializes an instance of the ListMakerException class.

ListMakerException(string)
Initializes an instance of the ListMakerException class.

ListMakerException(string, Exception)
Initializes an instance of the ListMakerException class.


Protected Instance Constructors
Constructor	Description
ListMakerException(SerializationInfo, StreamingContext)	Initializes an instance of the ListMakerException class.


See Also
•	Microsoft.MediaCenter.ListMaker Namespace

# ListMakerException.ListMakerException Constructor
Initializes an instance of the ListMakerException class.
Overload List
public ListMakerException()

public ListMakerException(string)

public ListMakerException(string, Exception)

protected ListMakerException(SerializationInfo, StreamingContext)


# ListMakerException.ListMakerException Constructor
Initializes an instance of the ListMakerException class.
Syntax
public ListMakerException();

# ListMakerException.ListMakerException Constructor
Initializes an instance of the ListMakerException class.
Syntax
public ListMakerException(
   string message
);

Parameters
message
System.String.  A description of the exception.
# ListMakerException.ListMakerException Constructor
Initializes an instance of the ListMakerException class.
Syntax
public ListMakerException(
   string message,
   Exception inner
);

Parameters
message
System.String.  A description of the exception.
inner
System.Exception.  The class on which this exception is based.
# ListMakerException.ListMakerException Constructor
Initializes an instance of the ListMakerException class.
Syntax
protected ListMakerException(
   SerializationInfo info,
   StreamingContext context
);

Parameters
info
System.Runtime.Serialization.SerializationInfo.  An instance of the class containing the information needed to serialize the new ListMakerException instance.
context
System.Runtime.Serialization.StreamingContext.  A structure that contains contextual information about the source of the serialized stream associated with the new ListMakerException instance.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ListMakerException Class
# ListMakerItem Class
Enables a CD/DVD recording application to access individual items from a list provided by Windows Media Center. An application receives this class when Windows Media Center calls the application's IListMakerApp.ItemAdded and IListMakerApp.ItemRemoved methods.
Syntax
public class ListMakerItem

Public Instance Properties
Property	Description
AppData
Gets or sets application-defined data that is associated with a list item.
ByteSize
Gets a value that indicates the size of a list item, in bytes.
Children
Exposes an enumerator that the CD/DVD recording application can use to retrieve the child items, if any.
Duration
Gets a value that indicates the duration of the list item.
Filename
Gets a string containing the item's file name.
MediaTypes
Gets a value that indicates the media type of the list item.
Name
Gets a string containing the name of the list item.
Title
Gets a string containing the title of the list item.

See Also
•	Microsoft.MediaCenter.ListMaker Namespace

# ListMakerItem.AppData Property
Gets or sets application-defined data that is associated with a list item.
Syntax
public object AppData {get; set;}

Property Value
System.Object. The object containing the data.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ListMakerItem Class

# ListMakerItem.ByteSize Property
Gets a value that indicates the size of a list item, in bytes.
Syntax
public long ByteSize {get;}

Property Value
System.Int64. The size of a list item.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ListMakerItem Class

# ListMakerItem.Children Property
Exposes an enumerator that the CD/DVD recording application can use to retrieve the child items, if any.
Syntax
public ListMakerList Children {get;}

Property Value
ListMakerList.  An enumerator that the CD/DVD recording application can use to retrieve the child items.
This property is read-only.
Remarks
This property is null if the item contains no child items.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ListMakerItem Class

# ListMakerItem.Duration Property
Gets a value that indicates the amount of recording time that the list item uses on the medium, expressed as a TimeSpan structure.
Syntax
public TimeSpan Duration {get;}

Property Value
System.TimeSpan. The amount of recording time that the list item uses on the medium.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ListMakerItem Class

# ListMakerItem.Filename Property
Gets a string containing the item's file name.
Syntax
public string Filename {get;}

Property Value
System.String. The file name.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ListMakerItem Class

# ListMakerItem.MediaTypes Property
Gets a value that indicates the media type of the list item.
Syntax
public MediaTypes MediaTypes {get;}

Property Value
Microsoft.MediaCenterMicrosoft.MediaCenter.ListMaker.MediaTypes. The media type of the list item.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ListMakerItem Class
•	MediaTypes Enumeration

# ListMakerItem.Name Property
Gets a string containing the name of the list item.
Syntax
public string Name {get; set;}

Property Value
System.String. The name of the list item.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ListMakerItem Class

# ListMakerItem.Title Property
Gets a string containing the title of the list item.
Syntax
public string Title {get;}

Property Value
System.String. The title of the list item.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ListMakerItem Class

# ListMakerList Class
Enables a CD/DVD recording application to access a collection of list items provided by Windows Media Center. An application receives this class when Windows Media Center calls the application's IListMakerApp.Launch and IListMakerApp.Repeat methods.
Syntax
public sealed class ListMakerList : System.Collections.ObjectModel.Collection<ListMakerItem>

Public Instance Properties
Property	Description
DeepCount
Gets a value that indicates the number of ListMakerItem entries, including child items, represented by the ListMakerList.this property.
ListTitle
Gets a string containing the title of the list.

See Also
•	Microsoft.MediaCenter.ListMaker Namespace

# ListMakerList.DeepCount Property
Gets a value that indicates the number of ListMakerItem entries, including child items.
Syntax
public int DeepCount {get;}

Property Value
System.Int32. The number of ListMakerItem entries.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ListMakerList class

# ListMakerList.ListTitle Property
Gets a string containing the title of the list.
Syntax
public string ListTitle {get;}

Property Value
System.String. The title of the list.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ListMakerList class

# MediaTypes Enumeration
Defines the types of media that a CD/DVD recording application can support.
Syntax
public enum MediaTypes

The MediaTypes enumeration defines the following constants:
Constant	Description
Folder	Media folders
Music	Recorded music
None	None
Pictures	Pictures and images
RecordedTV	Recorded TV shows
Videos	Video recordings

Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IListMakerApp.SupportedMediaTypes Property
•	ListMakerItem.MediaTypes Property
•	Microsoft.MediaCenter.ListMaker Namespace

# NoDeviceException Class
Contains information about an exception raised by a CD/DVD recording application, indicating that no recording device exists.
Syntax
public class NoDeviceException : ListMakerException

Public Instance Constructors
Constructor	Description
NoDeviceException()
Initializes an instance of the NoDeviceException class.
NoDeviceException(string)
Initializes an instance of the NoDeviceException class.
NoDeviceException(string, Exception)
Initializes an instance of the NoDeviceException class.

Protected Instance Constructors
Constructor	Description
NoDeviceException(SerializationInfo, StreamingContext)	Initializes an instance of the NoDeviceException class.

See Also
•	Microsoft.MediaCenter.ListMaker Namespace

# NoDeviceException.NoDeviceException Constructor
Initializes an instance of the NoDeviceException class.
Overload List
public NoDeviceException()

public NoDeviceException(string)

public NoDeviceException(string, Exception)

protected NoDeviceException(SerializationInfo, StreamingContext)


# NoDeviceException.NoDeviceException Constructor
Initializes an instance of the NoDeviceException class.
Syntax
public NoDeviceException();

# NoDeviceException.NoDeviceException Constructor
Initializes an instance of the NoDeviceException class.
Syntax
public NoDeviceException(
   string message
);

Parameters
message
System.String.  A description of the exception.
# NoDeviceException.NoDeviceException Constructor
Initializes an instance of the NoDeviceException class.
Syntax
public NoDeviceException(
   string message,
   Exception inner
);

Parameters
message
System.String.  A description of the exception.
inner
System.Exception.  The class on which this exception is based.
# NoDeviceException.NoDeviceException Constructor
Initializes an instance of the NoDeviceException class.
Syntax
protected NoDeviceException(
   SerializationInfo info,
   StreamingContext context
);

Parameters
info
System.Runtime.Serialization.SerializationInfo.  An instance of the class containing the information needed to serialize the new NoDeviceException instance.
context
System.Runtime.Serialization.StreamingContext.  A structure that contains contextual information about the source of the serialized stream associated with the new NoDeviceException instance.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	NoDeviceException Class
# NoMediaException Class
Contains information about an exception raised by a CD/DVD recording application, indicating that the recording device contains no recording medium.
Syntax
public class NoMediaException : ListMakerException

Public Instance Constructors
Constructor	Description
NoMediaException()
Initializes an instance of the NoMediaException class.
NoMediaException(string)
Initializes an instance of the NoMediaException class.
NoMediaException(string, Exception)
Initializes an instance of the NoMediaException class.

Protected Instance Constructors
Constructor	Description
NoMediaException(SerializationInfo, StreamingContext)	Initializes an instance of the NoMediaException class.

See Also
•	Microsoft.MediaCenter.ListMaker Namespace

# NoMediaException.NoMediaException Constructor
Initializes an instance of the NoMediaException class.
Overload List
public NoMediaException()

public NoMediaException(string)

public NoMediaException(string, Exception)

protected NoMediaException(SerializationInfo, StreamingContext)


# NoMediaException.NoMediaException Constructor
Initializes an instance of the NoMediaException class.
Syntax
public NoMediaException();

# NoMediaException.NoMediaException Constructor
Initializes an instance of the NoMediaException class.
Syntax
public NoMediaException(
   string message
);

Parameters
message
System.String.  A description of the exception.
# NoMediaException.NoMediaException Constructor
Initializes an instance of the NoMediaException class.
Syntax
public NoMediaException(
   string message,
   Exception inner
);

Parameters
message
System.String.  A description of the exception.
inner
System.Exception.  The class on which this exception is based.
# NoMediaException.NoMediaException Constructor
Initializes an instance of the NoMediaException class.
Syntax
protected NoMediaException(
   SerializationInfo info,
   StreamingContext context
);

Parameters
info
System.Runtime.Serialization.SerializationInfo.  An instance of the class containing the information needed to serialize the new NoMediaException instance.
context
System.Runtime.Serialization.StreamingContext.  A structure that contains contextual information about the source of the serialized stream associated with the new NoMediaException instance.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	NoMediaException Class
# NotEnoughDiskForStashException Class
Contains information about an exception raised because the hard disk does not have enough space available to store temporary files.
Syntax
public class NotEnoughDiskForStashException : ListMakerException

Public Instance Constructors
Constructor	Description
NotEnoughDiskForStashException()
Initializes an instance of the NotEnoughDiskForStashException class.
NotEnoughDiskForStashException(string)	Initializes an instance of the NotEnoughDiskForStashException class.
NotEnoughDiskForStashException(string, Exception)	Initializes an instance of the NotEnoughDiskForStashException class.

Protected Instance Constructors
Constructor	Description
NotEnoughDiskForStashException(SerializationInfo, StreamingContext)	Initializes an instance of the NotEnoughDiskForStashException class.

See Also
•	Microsoft.MediaCenter.ListMaker Namespace

# NotEnoughDiskForStashException.NotEnoughDiskForStashException Constructor
Initializes an instance of the NotEnoughDiskForStashException class.
Overload List
public NotEnoughDiskForStashException()

public NotEnoughDiskForStashException(string)

public NotEnoughDiskForStashException(string, Exception)

protected NotEnoughDiskForStashException(SerializationInfo, StreamingContext)


# NotEnoughDiskForStashException.NotEnoughDiskForStashException Constructor
Initializes an instance of the NotEnoughDiskForStashException class.
Syntax
public NotEnoughDiskForStashException();

# NotEnoughDiskForStashException.NotEnoughDiskForStashException Constructor
Initializes an instance of the NotEnoughDiskForStashException class.
Syntax
public NotEnoughDiskForStashException(
   string message
);

Parameters
message
System.String.  A description of the exception.
# NotEnoughDiskForStashException.NotEnoughDiskForStashException Constructor
Initializes an instance of the NotEnoughDiskForStashException class.
Syntax
public NotEnoughDiskForStashException(
   string message,
   Exception inner
);

Parameters
message
System.String.  A description of the exception.
inner
System.Exception.  The class on which this exception is based.
# NotEnoughDiskForStashException.NotEnoughDiskForStashException Constructor
Initializes an instance of the NotEnoughDiskForStashException class.
Syntax
protected NotEnoughDiskForStashException(
   SerializationInfo info,
   StreamingContext context
);

Parameters
info
System.Runtime.Serialization.SerializationInfo.  An instance of the class containing the information needed to serialize the new NotEnoughDiskForStashException instance.
context
System.Runtime.Serialization.StreamingContext.  A structure that contains contextual information about the source of the serialized stream associated with the new NotEnoughDiskForStashException instance.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later

# UnsupportedFileException Class
Contains information about an exception raised by a CD/DVD recording application indicating that the file is corrupted or is in an unsupported file format.
Syntax
public class UnsupportedFileException : ListMakerException

Public Instance Constructors
Constructor	Description
UnsupportedFileException()
Initializes an instance of the UnsupportedFileException class.
UnsupportedFileException(string)
Initializes an instance of the UnsupportedFileException class.
UnsupportedFileException(string, string)	Initializes an instance of the UnsupportedFileException class.
UnsupportedFileException(string, string, Exception)	Initializes an instance of the UnsupportedFileException class.

Protected Instance Constructors
Constructor	Description
UnsupportedFileException(SerializationInfo, StreamingContext)	Initializes an instance of the UnsupportedFileException class.

Public Instance Properties
Property	Description
FileName
Gets the name of the file that is corrupted or in an unsupported format.

See Also
•	Microsoft.MediaCenter.ListMaker Namespace

# UnsupportedFileException.FileName Property
Gets the name of the file that is corrupted or in an unsupported format.
Syntax
public string FileName {get;}

Property Value
System.String.  The name of the file.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	UnsupportedFileException Class

# UnsupportedFileException.UnsupportedFileException Constructor
Initializes an instance of the UnsupportedFileException class.
Overload List
public UnsupportedFileException()

public UnsupportedFileException(string)

public UnsupportedFileException(string, string)

public UnsupportedFileException(string, string, Exception)

public UnsupportedFileException(string, string, Exception)

protected UnsupportedFileException(SerializationInfo, StreamingContext)


See Also
•	UnsupportedFileException Class
# UnsupportedFileException.UnsupportedFileException Constructor
Initializes an instance of the UnsupportedFileException class.
Syntax
public UnsupportedFileException();

# UnsupportedFileException.UnsupportedFileException Constructor
Initializes an instance of the UnsupportedFileException class.
Syntax
public UnsupportedFileException(
   string message
);

Parameters
message
System.String.  A description of the exception.
# UnsupportedFileException.UnsupportedFileException Constructor
Initializes an instance of the UnsupportedFileException class.
Syntax
public UnsupportedFileException(
   string message
   string filename
);

Parameters
message
System.String.  A description of the exception.
filename
System.String.  The name of the file that is corrupted or in an unsupported format.
# UnsupportedFileException.UnsupportedFileException Constructor
Initializes an instance of the UnsupportedFileException class.
Syntax
public UnsupportedFileException(
   string message,
   string filename
   Exception inner
);

Parameters
message
System.String.  A description of the exception.
filename
System.String.  The name of the file that is corrupted or in an unsupported format.
inner
System.Exception.  The class on which this exception is based.
# UnsupportedFileException.UnsupportedFileException Constructor
Initializes an instance of the UnsupportedFileException class.
Syntax
public UnsupportedFileException(
   string message,
   Exception inner
);

Parameters
message
System.String.  A description of the exception.
inner
System.Exception.  The class on which this exception is based.
# UnsupportedFileException.UnsupportedFileException Constructor
Initializes an instance of the UnsupportedFileException class.
Syntax
protected UnsupportedFileException(
   SerializationInfo info,
   StreamingContext context
);

Parameters
info
System.Runtime.Serialization.SerializationInfo.  An instance of the class containing the information needed to serialize the new UnsupportedFileException instance.
context
System.Runtime.Serialization.StreamingContext.  A structure that contains contextual information about the source of the serialized stream associated with the new UnsupportedFileException instance.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later

# UserAbortException Class
Contains information about an exception raised by a CD/DVD recording application indicating that the user ended the CD or DVD recording operation before it was finished.
Syntax
public class UserAbortException : ListMakerException

Public Instance Constructors
Constructor	Description
UserAbortException()
Initializes an instance of the UserAbortException class.
UserAbortException(string)
Initializes an instance of the UserAbortException class.
UserAbortException(string, Exception)
Initializes an instance of the UserAbortException class.

Protected Instance Constructors
Constructor	Description
UserAbortException(SerializationInfo, StreamingContext)	Initializes an instance of the UserAbortException class.

See Also
•	Microsoft.MediaCenter.ListMaker Namespace

# UserAbortException.UserAbortException Constructor
Initializes an instance of the UserAbortException class.
Overload List
public UserAbortException()

public UserAbortException(string)

public UserAbortException(string, Exception)

protected UserAbortException(SerializationInfo, StreamingContext)


# UserAbortException.UserAbortException Constructor
Initializes an instance of the UserAbortException class.
Syntax
public UserAbortException();

# UserAbortException.UserAbortException Constructor
Initializes an instance of the UserAbortException class.
Syntax
public UserAbortException(
   string message
);

Parameters
message
System.String.  A description of the exception.
# UserAbortException.UserAbortException Constructor
Initializes an instance of the UserAbortException class.
Syntax
public UserAbortException(
   string message,
   Exception inner
);

Parameters
message
System.String.  A description of the exception.
inner
System.Exception.  The class on which this exception is based.
# UserAbortException.UserAbortException Constructor
Initializes an instance of the UserAbortException class.
Syntax
protected UserAbortException(
   SerializationInfo info,
   StreamingContext context
);

Parameters
info
System.Runtime.Serialization.SerializationInfo.  An instance of the class containing the information needed to serialize the new UserAbortException instance.
context
System.Runtime.Serialization.StreamingContext.  A structure that contains contextual information about the source of the serialized stream associated with the new UserAbortException instance.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later

# WrongMediaTypeException Class
Contains information about an exception raised by a CD/DVD recording application, indicating that the application does not support the specified type of recording medium.
Syntax
public class WrongMediaTypeException : ListMakerException

Public Instance Constructors
Constructor	Description
WrongMediaTypeException()
Initializes an instance of the WrongMediaTypeException class.
WrongMediaTypeException(string)
Initializes an instance of the WrongMediaTypeException class.
WrongMediaTypeException(string, Exception)	Initializes an instance of the WrongMediaTypeException class.

Protected Instance Constructors
Constructor	Description
WrongMediaTypeException(SerializationInfo, StreamingContext)	Initializes an instance of the WrongMediaTypeException class.

See Also
•	Microsoft.MediaCenter.ListMaker Namespace

# WrongMediaTypeException.WrongMediaTypeException Constructor
Initializes an instance of the WrongMediaTypeException class.
Overload List
public WrongMediaTypeException()

public WrongMediaTypeException(string)

public WrongMediaTypeException(string, Exception)

protected WrongMediaTypeException(SerializationInfo, StreamingContext)


# WrongMediaTypeException.WrongMediaTypeException Constructor
Initializes an instance of the WrongMediaTypeException class.
Syntax
public WrongMediaTypeException();

# WrongMediaTypeException.WrongMediaTypeException Constructor
Initializes an instance of the WrongMediaTypeException class.
Syntax
public WrongMediaTypeException(
   string message
);

Parameters
message
System.String.  A description of the exception.
# WrongMediaTypeException.WrongMediaTypeException Constructor
Initializes an instance of the WrongMediaTypeException class.
Syntax
public WrongMediaTypeException(
   string message,
   Exception inner
);

Parameters
message
System.String.  A description of the exception.
inner
System.Exception.  The class on which this exception is based.
# WrongMediaTypeException.WrongMediaTypeException Constructor
Initializes an instance of the WrongMediaTypeException class.
Syntax
protected WrongMediaTypeException(
   SerializationInfo info,
   StreamingContext context
);

Parameters
info
System.Runtime.Serialization.SerializationInfo.  An instance of the class containing the information needed to serialize the new WrongMediaTypeException instance.
context
System.Runtime.Serialization.StreamingContext.  A structure that contains contextual information about the source of the serialized stream associated with the new WrongMediaTypeException instance.
Requirements
Reference: Microsoft.MediaCenter
Namespace: Microsoft.MediaCenter.ListMaker
Assembly: Microsoft.MediaCenter.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
# Microsoft.MediaCenter.TV.Epg Namespace
This namespace is part of the Click-to-Record API, which enables applications to programmatically schedule the recording of TV programs.
Note   The Click-to-Record API (the Microsoft.MediaCenter.TV.Epg and Microsoft.MediaCenter.TV.Scheduling namespaces) are supported on x86 and AMD64 platforms, but are not supported when called from 32-bit applications that are running in a 32-bit emulator on an AMD64 platform (also known as WOW64). If your application is a combination of managed and unmanaged code, you must compile two versions to support both platforms. If your code is entirely managed, it is platform neutral and the compiled binary can be run on both x86 and AMD64 platforms.
The following types are in the Microsoft.MediaCenter.TV.Epg namespace, which is in the ehRecObj.dll assembly.
Note   When compiling an application that uses any class in the Microsoft.MediaCenter.TV.Epg namespace, the BDATunePIA.dll and stdole.dll files may be copied to your binary directory. However, you should not include these files in your application package.
The Microsoft.MediaCenter.TV.Epg namespace exposes the following classes:
Class	Description
Lineup
Provides channel lineup information.
LineupException
Contains information about an exception that was raised when using the Lineup class.

See Also
•	Managed Code Object Model Reference
•	Working with Live and Recorded TV

# Lineup Class
Provides channel lineup information.
Syntax
public class Lineup

Public Instance Constructors
Constructor	Description
Lineup
Initializes a new instance of the Lineup class.

Public Instance Methods
Method	Description
GetCallSigns
Returns the map of service IDs and call signs.
GetHeadends
Returns a collection of head ends that are configured for the Media Center session.
GetServiceIds
Returns the map of channel numbers and service IDs of mapped services.

See Also
•	Microsoft.MediaCenter.TV.Epg Namespace
•	Working with Live and Recorded TV

# Lineup Constructor
Initializes a new instance of the Lineup Class class.
Syntax
public Lineup();

Remarks
Although you can create multiple instances of the Lineup class, it is not recommended unless absolutely needed.
Requirements
Reference: ehRecObj
Namespace: Microsoft.MediaCenter.TV.Epg
Assembly: ehRecObj.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.TV.Epg Namespace
•	Working with Live and Recorded TV

# Lineup.GetCallSigns Method
Returns the map of service IDs and call signs.
Syntax
public IDictionary<string, string> GetCallSigns();

Return Value
System.Collections.Generic.IDictionary<System.String, System.String>.  A collection of key-value pairs. The key is a string that represents the service ID. The value is a string that represents the call sign of the service.
This method should raise an EventScheduleException or LineupException if it encounters an error.
Remarks
In a typical scenario, a client gets a service ID for the target service at first, and then uses this ID to specify the target service in the request XML with the EventSchedule.CreateScheduleRequest method.
Requirements
Reference: ehRecObj
Namespace: Microsoft.MediaCenter.TV.Epg
Assembly: ehRecObj.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Lineup Class
•	Microsoft.MediaCenter.TV.Epg Namespace
•	Working with Live and Recorded TV

# Lineup.GetHeadends Method
Returns a collection of head ends that are configured for the Windows Media Center session.
Syntax
public ICollection<string> GetHeadends();

Return Value
System.Collections.Generic.ICollection<System.String>.  A collection of string IDs that represent a head end. If the Electronic Program Guide is not configured, the returned collection is empty.
This method should raise an EventScheduleException or LineupException if it encounters an error.
Remarks
At this time, Windows Media Center can be configured with only one head end, so the maximum number of elements in the collection is 1.
Requirements
Reference: ehRecObj
Namespace: Microsoft.MediaCenter.TV.Epg
Assembly: ehRecObj.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Lineup Class
•	Microsoft.MediaCenter.TV.Epg Namespace
•	Working with Live and Recorded TV

# Lineup.GetServiceIds Method
Returns the map of channel numbers and service IDs of mapped services.
Syntax
public IDictionary<string, string> GetServiceIds();

Return Value
System.Collections.Generic.IDictionary<System.String, System.String>.  A collection of key-value pairs:
•	The key is a string that contains the channel number.
•	The value is a string that contains the service ID mapped to the channel.
This method should raise an EventScheduleException or LineupException if it encounters an error.
Requirements
Reference: ehRecObj
Namespace: Microsoft.MediaCenter.TV.Epg
Assembly: ehRecObj.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Lineup Class
•	Microsoft.MediaCenter.TV.Epg Namespace
•	Working with Live and Recorded TV

# LineupException Class
Contains information about an exception that was raised when using the Lineup class.
Syntax
public class LineupException : Exception, System.Runtime.Serialization.ISerializable

Public Instance Constructors
Constructor	Description
LineupException()
Initializes a new instance of the LineupException class.
LineupException(string)
Initializes a new instance of the LineupException class.
LineupException(string, Exception)
Initializes a new instance of the LineupException class.

Protected Instance Constructors
Constructor	Description
LineupException(SerializationInfo, StreamingContext)	Initializes a new instance of the LineupException class.

See Also
•	Microsoft.MediaCenter.TV.Epg Namespace
•	Working with Live and Recorded TV

# LineupException Constructor
Initializes a new instance of the LineupException Class.
Overload List
public LineupException()

public LineupException(string)

public LineupException(string, Exception)

protected LineupException(SerializationInfo, StreamingContext)



# LineupException.LineupException Constructor
Initializes a new instance of the LineupException Class.
Syntax
public LineupException();
# LineupException.LineupException Constructor
Initializes a new instance of the LineupException Class.
Syntax
public LineupException(
  string  msg
);
Parameters
msg
System.String.  A description of the exception.
# LineupException.LineupException Constructor
Initializes a new instance of the LineupException Class.
Syntax
public LineupException(
  string  msg,
  Exception  innerException
);
Parameters
msg
System.String.  A description of the exception.
innerException
System.Exception.  The object on which this exception is based.
# LineupException.LineupException Constructor
Initializes a new instance of the LineupException Class.
Syntax
protected LineupException(
  System.Runtime.Serialization.SerializationInfo  info,
  System.Runtime.Serialization.StreamingContext  context
);
info
System.Runtime.Serialization.SerializationInfo.  An instance of the class containing the information needed to serialize the new LineupException instance.
context
System.Runtime.Serialization.StreamingContext.  A structure that contains contextual information about the source of the serialized stream associated with the new LineupException instance.
Requirements
Reference: ehRecObj
Namespace: Microsoft.MediaCenter.TV.Epg
Assembly: ehRecObj.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.TV.Epg Namespace
•	Working with Live and Recorded TV

# Microsoft.MediaCenter.TV.Scheduling Namespace
This namespace is part of the Click-to-Record API, which enables applications to programmatically schedule the recording of TV programs.
Note   The Click-to-Record API (the Microsoft.MediaCenter.TV.Epg and Microsoft.MediaCenter.TV.Scheduling namespaces) are supported on x86 and AMD64 platforms, but are not supported when called from 32-bit applications that are running in a 32-bit emulator on an AMD64 platform (also known as WOW64). If your application is a combination of managed and unmanaged code, you must compile two versions to support both platforms. If your code is entirely managed, it is platform neutral and the compiled binary can be run on both x86 and AMD64 platforms.
The following types are in the Microsoft.MediaCenter.TV.Scheduling namespace, which is in the ehRecObj.dll assembly.
Note   When compiling an application that uses any class in the Microsoft.MediaCenter.TV.Scheduling namespace, the BDATunePIA.dll and stdole.dll files may be copied to your binary directory. However, you should not include these files in your application package.
The Microsoft.MediaCenter.TV.Scheduling namespace exposes the following classes:
Class	Description
EventSchedule
Handles scheduled recordings and recorded items, and creates and retrieves requests. This class can also be used as an event source.
EventScheduleException
Contains information about an exception raised by the EventSchedule API.

ExtendedPropertyExceededLimitException
This exception is thrown by the ScheduleEvent.GetExtendedProperty method when a property is queried too many times.
ScheduleEvent
Represents a scheduled recording event.
ScheduleEventChangedEventArgs
Contains arguments that are passed to the delegate of the ScheduleEventStateChanged event.
ScheduleRequest
Provides information about a recording request.

The Microsoft.MediaCenter.TV.Scheduling namespace exposes the following structure:
Structure	Description
ScheduleEventChange
Contains information about changes to scheduled recording events.

The Microsoft.MediaCenter.TV.Scheduling namespace exposes the following eumeration types:
Enumeration	Description
ConflictResolutionPolicy
Contains values that indicate how the CreateScheduleRequest method should handle conflicts.
CreateScheduleRequestResult
Contains values that indicate the result of a recording request from the EventSchedule.CreateScheduleRequest method.

ScheduleEventStates
Contains the possible states of a scheduled recording event.

See Also
•	Managed Code Object Model Reference
•	Working with Live and Recorded TV

# ConflictResolutionPolicy Enumeration
Contains values that indicate how the EventSchedule.CreateScheduleRequest method should handle conflicts.
Syntax
public enum ConflictResolutionPolicy

The ConflictResolutionPolicy enumeration defines the following constants:
Member	Description
AllowConflict	Indicates that a scheduled recording event overlaps an existing recording event, such that there are fewer resources (available tuners) than recording events. The overlapping events have the lowest priority.
OverrideConflict	Gives a "best effort" at resolving conflicts in favor of a new recording request. The scheduled recordings with the lowest priorty in a conflict are moved to a conflict state. The OverrideConflict state does not always result in an override, such as when a tuner is used exclusively by a third party, or if the user is viewing live TV and chooses to cancel a scheduled recording event.

Requirements
Reference: ehRecObj
Namespace: Microsoft.MediaCenter.TV.Scheduling
Assembly: ehRecObj.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.TV.Scheduling Namespace
•	Working with Live and Recorded TV

# CreateScheduleRequestResult Enumeration
Contains values that indicate the result of a recording request from the EventSchedule.CreateScheduleRequest method.
Syntax
public enum CreateScheduleRequestResult

The CreateScheduleRequestResult enumeration defines the following constants:
Member	Description
AllProgramsInPast	The specified program has already been aired.
AlreadyScheduled	The specified program was already scheduled and the request was not created.
ConflictNotScheduled	This value is not used in Windows Media Center for Windows Vista.
ExceededMaxRequests	The request was not created because the number of recording events from this request would exceed the maximum allowed value of 50.
Expired	The request XML has expired.
GuideNotConfigured	The Electronic Program Guide is not configured.
NoConfiguredResource	This value is not used in Windows Media Center for Windows Vista.
NotFound	The specified program was not found and the request was not created.
Scheduled	The specified program was scheduled but there is a conflict.
ScheduledNoConflict	The specified program was scheduled without conflict.

Requirements
Reference: ehRecObj
Namespace: Microsoft.MediaCenter.TV.Scheduling
Assembly: ehRecObj.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.TV.Scheduling Namespace
•	Working with Live and Recorded TV

# EventSchedule Class
Handles scheduled recordings and recorded items, and creates and retrieves requests. This class can also be used as an event source.
Syntax
public class EventSchedule : IDisposable

Public Instance Constructors
Constructor	Description
EventSchedule
Initializes a new instance of the EventSchedule class.

Public Instance Methods
Method	Description
CreateScheduleRequest
Creates a new recording request.
Dispose
Not documented in this release.
GetScheduleEvents
Gets the scheduled recording events in Windows Media Center that meet the specified date-time range and state.
GetScheduleEventWithId
Gets a scheduled recording event that matches a specified ID.
GetScheduleRequests
Gets all recording requests.
GetScheduleRequestWithId
Gets a recording request that matches a specified ID.

Public Instance Events
Event	Description
ScheduleEventStateChanged
Raised when any scheduled recording event changes.

See Also
•	Microsoft.MediaCenter.TV.Scheduling Namespace
•	Working with Live and Recorded TV

# EventSchedule Constructor
Initializes a new instance of the EventSchedule class.
Syntax
public EventSchedule();

Remarks
A client can create multiple instances of this class, although it is not recommended unless absolutely necessary.
Requirements
Reference: ehRecObj
Namespace: Microsoft.MediaCenter.TV.Scheduling
Assembly: ehRecObj.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	EventSchedule Class
•	Microsoft.MediaCenter.TV.Scheduling Namespace
•	Working with Live and Recorded TV

# EventSchedule.CreateScheduleRequest Method
Creates a new recording request.
Syntax
public CreateScheduleRequestResult CreateScheduleRequest(
  System.Xml.XmlReader  requestConstraints,
  ConflictResolutionPolicy  conflictPolicy,
  string  originatorDescription,
  [out] ScheduleRequest  scheduleRequest
);

Parameters
requestConstraints
System.Xml.XmlReader.  Specifies the XML reader for request XML. For more information about the schema of the request XML, see Scheduling Recorded TV with Click-To-Record.
conflictPolicy
Microsoft.MediaCenter.TV.Scheduling.ConflictResolutionPolicy.  Specifies a member of the ConflictResolutionPolicy enumeration that specifies how to resolve scheduling conflicts.
originatorDescription
System.String.  Represents the name of the component that is creating the recording request.
scheduleRequest
Microsoft.MediaCenter.TV.Scheduling.ScheduleRequest.  A ScheduleRequest object that represents the request created by this method. This value is null if the request is not scheduled.
Return Value
Microsoft.MediaCenter.TV.Scheduling.CreateScheduleRequestResult.  A member of the CreateScheduleRequestResult enumeration that indicates the result of this request.
This method raises an ArgumentNullException if either the requestConstraints or originatorDescription parameter is null. This method raises an EventScheduleException for any other errors except the cases defined by the CreateResult enumeration.
Remarks
If the specified program has already been reserved, the result of the CreateScheduleRequest method is "AlreadyScheduled". Such a request is not treated as a new request with conflicts, and a new request is not generated.
Requirements
Reference: ehRecObj
Namespace: Microsoft.MediaCenter.TV.Scheduling
Assembly: ehRecObj.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	EventSchedule Class
•	Microsoft.MediaCenter.TV.Scheduling Namespace
•	Working with Live and Recorded TV

# EventSchedule.Dispose Method
Not documented in this release.
Syntax
public override void Dispose();

Return Value
This method does not return a value.
Requirements
Reference:
Namespace: Microsoft.MediaCenter.TV.Scheduling
Assembly: .dll
Platform: Windows 7
See Also
•	EventSchedule Class
•	Microsoft.MediaCenter.TV.Scheduling Namespace

# EventSchedule.GetScheduleEvents Method
Gets the scheduled recording events in Windows Media Center that meet the specified date-time range and state.
Syntax
public ICollection<ScheduleEvent> GetScheduleEvents(
  DateTime  beginRange,
  DateTime  endRange,
  ScheduleEventStates  state
);

Parameters
beginRange
System.DateTime.  The beginning of the date range in which to search. Any scheduled recording events that are partially or fully in this range are returned.
endRange
System.DateTime.  The end of the date range in which to search. Any scheduled recording events that are partially or fully in this range are returned.
state
Microsoft.MediaCenter.TV.Scheduling.ScheduleEventStates.  A member or bit-wise OR combination of members of the ScheduleEventStates enumeration that specify the state of the events to search for.
Return Value
System.Collections.Generic.ICollection<Microsoft.MediaCenter.TV.Scheduling.ScheduleEvent>.  Collection of scheduled recording events represented by ScheduleEvent objects.
This method raises an ArgumentException if the specified range is invalid. This method raises an EventScheduleException for any other errors.
Requirements
Reference: ehRecObj
Namespace: Microsoft.MediaCenter.TV.Scheduling
Assembly: ehRecObj.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	EventSchedule Class
•	Microsoft.MediaCenter.TV.Scheduling Namespace
•	Working with Live and Recorded TV

# EventSchedule.GetScheduleEventWithId Method
Gets a scheduled recording event that matches a specified ID.
Syntax
public ScheduleEvent GetScheduleEventWithId(
  string  id
);

Parameters
id
System.String.  The ID of the scheduled recording event to retrieve.
Return Value
Microsoft.MediaCenter.TV.Scheduling.ScheduleEvent.  A ScheduleEvent object representing the specified scheduled recording event.
This method raises an EventScheduleException for any error.
Requirements
Reference: ehRecObj
Namespace: Microsoft.MediaCenter.TV.Scheduling
Assembly: ehRecObj.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	EventSchedule Class
•	Microsoft.MediaCenter.TV.Scheduling Namespace
•	Working with Live and Recorded TV

# EventSchedule.GetScheduleRequests Method
Gets all recording requests.
Syntax
public ICollection<ScheduleRequest> GetScheduleRequests();

Return Value
System.Collections.Generic.ICollection<Microsoft.MediaCenter.TV.Scheduling.ScheduleRequest>.  Collection of recording requests represented by ScheduleRequest objects.
This method raises an EventScheduleException for any error.
Requirements
Reference: ehRecObj
Namespace: Microsoft.MediaCenter.TV.Scheduling
Assembly: ehRecObj.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	EventSchedule Class
•	Microsoft.MediaCenter.TV.Scheduling Namespace
•	Working with Live and Recorded TV

# EventSchedule.GetScheduleRequestWithId Method
Gets a recording request that matches a specified ID.
Syntax
public ScheduleRequest GetScheduleRequestWithId(
  string  id
);

Parameters
id
System.String.  The ID of the recording request to retrieve.
Return Value
Microsoft.MediaCenter.TV.Scheduling.ScheduleRequest.  A ScheduleRequest object that represents the recording request.
This method raises an ArgumentNullException if the ID is null. This method raises an EventScheduleException when the specified request is not found and for any other errors.
Requirements
Reference: ehRecObj
Namespace: Microsoft.MediaCenter.TV.Scheduling
Assembly: ehRecObj.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	EventSchedule Class
•	Microsoft.MediaCenter.TV.Scheduling Namespace
•	Working with Live and Recorded TV

# EventSchedule.ScheduleEventStateChanged Event
Raised when any scheduled recording event changes.
Syntax
public EventSchedule.EventStateChangedEventHandler ScheduleEventStateChanged;

Remarks
You may be notified of multiple changes that happen at the same time in a single event. For more information, see ScheduleEventChangedEventArgs Class.
The following state changes are not notified:
•	State change from None to any other state when creating a scheduled recording event.
•	State change from Canceled, Deleted, or Error to None when removing a scheduled recording event.
Requirements
Reference: ehRecObj
Namespace: Microsoft.MediaCenter.TV.Scheduling
Assembly: ehRecObj.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	EventSchedule Class
•	Microsoft.MediaCenter.TV.Scheduling Namespace
•	Working with Live and Recorded TV

# EventScheduleException Class
Contains information about an exception raised by the EventSchedule API.
Syntax
public class EventScheduleException : Exception, System.Runtime.Serialization.ISerializable

Public Instance Constructors
Constructor	Description
EventScheduleException()
Initializes a new instance of the EventScheduleException class.
EventScheduleException(string)
Initializes a new instance of the EventScheduleException class.
EventScheduleException(string, Exception)	Initializes a new instance of the EventScheduleException class.

Protected Instance Constructors
Constructor	Description
EventScheduleException(SerializationInfo, StreamingContext)	Initializes a new instance of the EventScheduleException class.

See Also
•	Microsoft.MediaCenter.TV.Scheduling Namespace
•	Working with Live and Recorded TV

# EventScheduleException Constructor
Initializes an instance of the EventScheduleException Class.
Overload List
public EventScheduleException()

public EventScheduleException(string)

public EventScheduleException(string, Exception)

protected EventScheduleException(SerializationInfo, StreamingContext)


# EventScheduleException.EventScheduleException Constructor
Initializes an instance of the EventScheduleException Class.
Syntax
public EventScheduleException(
);
# EventScheduleException.EventScheduleException Constructor
Initializes an instance of the EventScheduleException Class.
Syntax
public EventScheduleException(
  string  msg
);
Parameters
msg
System.String.  A description of the exception.
# EventScheduleException.EventScheduleException Constructor
Initializes an instance of the EventScheduleException Class.
Syntax
public EventScheduleException(
  string  msg,
  Exception  innerException
);
Parameters
msg
System.String.  A description of the exception.
innerException
System.Exception.  The object on which this exception is based.
# EventScheduleException.EventScheduleException Constructor
Initializes an instance of the EventScheduleException Class.
Syntax
protected EventScheduleException(
  System.Runtime.Serialization.SerializationInfo  info,
  System.Runtime.Serialization.StreamingContext  context
);
Parameters
info
System.Runtime.Serialization.SerializationInfo.  An instance of the class containing the information needed to serialize the new EventScheduleException instance.
context
System.Runtime.Serialization.StreamingContext.  A structure that contains contextual information about the source of the serialized stream associated with the new EventScheduleException instance.
Requirements
Reference: ehRecObj
Namespace: Microsoft.MediaCenter.TV.Scheduling
Assembly: ehRecObj.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.TV.Scheduling Namespace
•	Working with Live and Recorded TV

# ExtendedPropertyExceededLimitException Class
Thrown by the ScheduleEvent.GetExtendedProperty method when a property is queried too many times.
Syntax
public class ExtendedPropertyExceededLimitException : Exception, System.Runtime.Serialization.ISerializable

Public Instance Constructors
Constructor	Description
ExtendedPropertyExceededLimitException()
Initializes a new instance of the ExtendedPropertyExceededLimitException class.
ExtendedPropertyExceededLimitException(string)
Initializes a new instance of the ExtendedPropertyExceededLimitException class.
ExtendedPropertyExceededLimitException(string, Exception)
Initializes a new instance of the ExtendedPropertyExceededLimitException class.

Protected Instance Constructors
Constructor	Description
ExtendedPropertyExceededLimitException(SerializationInfo, StreamingContext)	Initializes a new instance of the ExtendedPropertyExceededLimitException class.

See Also
•	Microsoft.MediaCenter.TV.Scheduling Namespace
•	Working with Live and Recorded TV

# ExtendedPropertyExceededLimitException Constructor
Initializes a new instance of the ExtendedPropertyExceededLimitException class.
Overload List
public ExtendedPropertyExceededLimitException()

public ExtendedPropertyExceededLimitException(string)

public ExtendedPropertyExceededLimitException(string, Exception)

protected ExtendedPropertyExceededLimitException(SerializationInfo, StreamingContext)

# ExtendedPropertyExceededLimitException.ExtendedPropertyExceededLimitException Constructor
Initializes a new instance of the ExtendedPropertyExceededLimitException class.
Syntax
public ExtendedPropertyExceededLimitException (
);
# ExtendedPropertyExceededLimitException.ExtendedPropertyExceededLimitException Constructor
Initializes a new instance of the ExtendedPropertyExceededLimitException class.
Syntax
public ExtendedPropertyExceededLimitException (
  string  msg
);
Parameters
msg
System.String.  A description of the exception.
# ExtendedPropertyExceededLimitException.ExtendedPropertyExceededLimitException Constructor
Initializes a new instance of the ExtendedPropertyExceededLimitException class.
Syntax
public ExtendedPropertyExceededLimitException (
  string  msg,
  Exception  innerException
);
Parameters
msg
System.String.  A description of the exception.
innerException
System.Exception.  The object on which this exception is based.
# ExtendedPropertyExceededLimitException.ExtendedPropertyExceededLimitException Constructor
Initializes a new instance of the ExtendedPropertyExceededLimitException class.
Syntax
protected ExtendedPropertyExceededLimitException (
  System.Runtime.Serialization.SerializationInfo  info,
  System.Runtime.Serialization.StreamingContext  context
);
Parameters
info
System.Runtime.Serialization.SerializationInfo.  An instance of the class containing the information needed to serialize the new EventScheduleException instance.
context
System.Runtime.Serialization.StreamingContext.  A structure that contains contextual information about the source of the serialized stream associated with the new EventScheduleException instance.
Requirements
Reference: ehRecObj
Namespace: Microsoft.MediaCenter.TV.Scheduling
Assembly: ehRecObj.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.TV.Scheduling Namespace
•	Working with Live and Recorded TV

# ScheduleEvent Class
Represents a scheduled recording event. Multiple instances of the ScheduleEvent object may be created and returned for one specific scheduled recording event. To determine whether multiple instances of the class are pointing to the same event, compare their Id properties.
Syntax
public class ScheduleEvent

Public Instance Methods
Method	Description
Cancel
Cancels a future or ongoing scheduled recording event.
GetConflictingScheduleEvents
Gets any scheduled recording events that conflict with the current recording event.
GetExtendedProperty
Gets the value of a specified property for the current scheduled recording event.
GetScheduleRequest
Gets a recording request.

Public Instance Properties
Property	Description
EndTime
Gets the ending time of a scheduled recording event.
Id
Gets a unique string ID for a scheduled recording event.
StartTime
Gets the starting time of a scheduled recording event.
State
A member of the ScheduleEventStates enumeration, which indicates the current state of a scheduled recording event.

See Also
•	Microsoft.MediaCenter.TV.Scheduling Namespace
•	Working with Live and Recorded TV

# ScheduleEvent.Cancel Method
Cancels a future or ongoing scheduled recording event.
Syntax
public void Cancel();

Return Value
This method does not return a value.
Remarks
This method does not affect past scheduled recording events.
Requirements
Reference: ehRecObj
Namespace: Microsoft.MediaCenter.TV.Scheduling
Assembly: ehRecObj.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.TV.Scheduling Namespace
•	ScheduleEvent Class
•	Working with Live and Recorded TV

# ScheduleEvent.EndTime Property
Gets the ending time of a scheduled recording event.
Syntax
public DateTime EndTime {get;}

Property Value
System.DateTime.  The end time of a scheduled recording event.
This property is read-only.
Requirements
Reference: ehRecObj
Namespace: Microsoft.MediaCenter.TV.Scheduling
Assembly: ehRecObj.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.TV.Scheduling Namespace
•	ScheduleEvent Class
•	Working with Live and Recorded TV

# ScheduleEvent.GetConflictingScheduleEvents Method
Gets any scheduled recording events that conflict with the current recording event.
Syntax
public ICollection<ScheduleEvent> GetConflictingScheduleEvents();

Return Value
System.Collections.Generic.ICollection<Microsoft.MediaCenter.TV.Scheduling.ScheduleEvent>.  A collection of conflicting ScheduleEvent objects.
This method should raise an EventScheduleException for any error.
Requirements
Reference: ehRecObj
Namespace: Microsoft.MediaCenter.TV.Scheduling
Assembly: ehRecObj.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.TV.Scheduling Namespace
•	ScheduleEvent Class
•	Working with Live and Recorded TV

# ScheduleEvent.GetExtendedProperty Method
Gets the value of a specified property for the current scheduled recording event.
Syntax
public object GetExtendedProperty(
  string  name
);

Parameters
name
System.String.  The name of the property to retrieve. The following properties can be retrieved:
Name	Description	Object type
Title	Title of the scheduled recording event.	string
ServiceID	Unique identifier representing the broadcast service.	string
ChannelID	Unique identifier representing the channel.	string
Description	Description of the program that is being recorded.	string
KeepUntil	Indicates how long to keep the recorded file from this TV recording event. The following values are possible:
-2: Keep until I watch
-1: Keep until space needed
0: Keep until I delete
1 or more: Number of days to keep	int
Quality	The recording quality, which can be one of the following values:
0: Fair
1: Good
2: Better
3: Best	int
Partial	Indicates whether the recording is incomplete. "True" indicates the program has been partially recorded or the recording has started later in the program. 	bool
ProviderCopyright	Copyright information from the provider. 	string
OriginalAirDate	The original air date of the program.	DateTime
Repeat	Indicates whether the airing of a program is a repeat airing. If the current air date is more than one week after the original air date, this value is True.	bool
Genre	Genre of this program. This information is provided by the Electronic Program Guide and the categorization is subject to change. 	string
FileName	The path of the recording file. This value is empty before the recording starts. 	string

Return Value
System.Object.  The object representing the property. The object type depends on the property. If the specified property does not exist, this method returns null. This method raises an ArgumentNullException if the name is null. This method raises an ExtendedPropertyExceededLimitException if the property data was queried too many times recently. This method raises an EventScheduleException for any other errors.
Remarks
An ExtendedPropertyExceededLimitException is thrown for "Title" and "Description" properties of scheduled recording events after the number of queries to those properties exceeds about 1200 times in one day.
Requirements
Reference: ehRecObj
Namespace: Microsoft.MediaCenter.TV.Scheduling
Assembly: ehRecObj.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.TV.Scheduling Namespace
•	ScheduleEvent Class
•	Working with Live and Recorded TV

# ScheduleEvent.GetScheduleRequest Method
Gets a recording request.
Syntax
public ScheduleRequest GetScheduleRequest();

Return Value
Microsoft.MediaCenter.TV.Scheduling.ScheduleRequest.  A ScheduleRequest object that is generating the request. If no request is associated with this recording event, such as if the recording event happened in the past or for any other errors, this method raises an EventScheduleException.
Requirements
Reference: ehRecObj
Namespace: Microsoft.MediaCenter.TV.Scheduling
Assembly: ehRecObj.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.TV.Scheduling Namespace
•	ScheduleEvent Class
•	Working with Live and Recorded TV

# ScheduleEvent.Id Property
Gets a unique string identifier (ID) for a scheduled recording event.
Syntax
public string Id {get;}

Property Value
System.String.  A unique string ID for this scheduled recording event.
This property is read-only.
Remarks
The client can use this ID to specify a particular scheduled recording event. The client can also use this ID to determine whether different operations point to the same scheduled recording event.
Requirements
Reference: ehRecObj
Namespace: Microsoft.MediaCenter.TV.Scheduling
Assembly: ehRecObj.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.TV.Scheduling Namespace
•	ScheduleEvent Class
•	Working with Live and Recorded TV

# ScheduleEvent.StartTime Property
Gets the starting time of a scheduled recording event.
Syntax
public DateTime StartTime {get;}

Property Value
System.DateTime.  The starting time of a scheduled recording event.
This property is read-only.
Requirements
Reference: ehRecObj
Namespace: Microsoft.MediaCenter.TV.Scheduling
Assembly: ehRecObj.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.TV.Scheduling Namespace
•	ScheduleEvent Class
•	Working with Live and Recorded TV

# ScheduleEvent.State Property
Indicates the current state of a scheduled recording event.
Syntax
public ScheduleEventStates State {get;}

Property Value
Microsoft.MediaCenter.TV.Scheduling.ScheduleEventStates.  A member of the ScheduleEventStates enumeration that indicates the current state of a scheduled recording event.
This property is read-only.
Requirements
Reference: ehRecObj
Namespace: Microsoft.MediaCenter.TV.Scheduling
Assembly: ehRecObj.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.TV.Scheduling Namespace
•	ScheduleEvent Class
•	Working with Live and Recorded TV

# ScheduleEventChange Structure
Contains information about changes to scheduled recording events.
Syntax
public struct ScheduleEventChange

The ScheduleEventChange structure contains the following properties:
Property	Description
NewState
Gets a value that indicates the state after change.
PreviousState
Gets a value that indicates the state before change.
ScheduleEventId
Gets an identifier (ID) of scheduled recording event that has changed state.

Requirements
Reference: ehRecObj
Namespace: Microsoft.MediaCenter.TV.Scheduling
Assembly: ehRecObj.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.TV.Scheduling Namespace
•	Working with Live and Recorded TV

# ScheduleEventChange.NewState Property
Gets a value that indicates the state after change.
Syntax
public ScheduleEventStates NewState {get;}

Property Value
Microsoft.MediaCenter.TV.Scheduling.ScheduleEventStates.  A member of the ScheduleEventStates enumeration indicating the state.
This property is read-only.
Requirements
Reference: ehRecObj
Namespace: Microsoft.MediaCenter.TV.Scheduling
Assembly: ehRecObj.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.TV.Scheduling Namespace
•	ScheduleEventChange Structure
•	Working with Live and Recorded TV

# ScheduleEventChange.PreviousState Property
Gets a value that indicates the state before change.
Syntax
public ScheduleEventStates PreviousState {get;}

Property Value
Microsoft.MediaCenter.TV.Scheduling.ScheduleEventStates.  A member of the ScheduleEventStates enumeration indicating the state.
This property is read-only.
Requirements
Reference: ehRecObj
Namespace: Microsoft.MediaCenter.TV.Scheduling
Assembly: ehRecObj.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.TV.Scheduling Namespace
•	ScheduleEventChange Structure
•	Working with Live and Recorded TV

# ScheduleEventChange.ScheduleEventId Property
Gets an identifier (ID) of a scheduled recording event that has changed state.
Syntax
public string ScheduleEventId {get;}

Property Value
System.String.  The recording event ID.
This property is read-only.
Requirements
Reference: ehRecObj
Namespace: Microsoft.MediaCenter.TV.Scheduling
Assembly: ehRecObj.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.TV.Scheduling Namespace
•	ScheduleEventChange Structure
•	Working with Live and Recorded TV

# ScheduleEventChangedEventArgs Class
Contains arguments that are passed to the delegate of the ScheduleEventStateChanged event.
Syntax
public class ScheduleEventChangedEventArgs : EventArgs

Public Instance Constructors
Constructor	Description
ScheduleEventChangedEventArgs
Initializes a new instance of the ScheduleEventChangedEventArgs class.

Public Instance Properties
Property	Description
Changes
Gets the properties of this class as an array of the state change information. Each member is a ScheduleEventChange structure that represents a single state change event.

See Also
•	Microsoft.MediaCenter.TV.Scheduling Namespace
•	Working with Live and Recorded TV

# ScheduleEventChangedEventArgs Constructor
Initializes a new instance of the ScheduleEventChangedEventArgs class.
Syntax
public ScheduleEventChangedEventArgs();

Requirements
Reference: ehRecObj
Namespace: Microsoft.MediaCenter.TV.Scheduling
Assembly: ehRecObj.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.TV.Scheduling Namespace
•	ScheduleEventChangedEventArgs Class
•	Working with Live and Recorded TV

# ScheduleEventChangedEventArgs.Changes Property
Gets the properties of this class as an array of the state change information. Each member is a ScheduleEventChange structure that represents a single state change event.
Syntax
public ScheduleEventChange Changes {get;}

Property Value
Microsoft.MediaCenter.TV.Scheduling.ScheduleEventChange.  A structure that indicates the state change of a scheduled recording event.
This property is read-only.
Requirements
Reference: ehRecObj
Namespace: Microsoft.MediaCenter.TV.Scheduling
Assembly: ehRecObj.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.TV.Scheduling Namespace
•	ScheduleEventChangedEventArgs Class
•	Working with Live and Recorded TV

# ScheduleEventStates Enumeration
Contains the possible states of a scheduled recording event.
Syntax
public enum ScheduleEventStates

The ScheduleEventStates enumeration defines the following constants:
Members	Description
All	This value is used only to specify all states for the GetScheduleEvents method. This value is not used as a state for any actual scheduled recording event.
Alternate	Indicates an alternative airing of a specific program. The state occurs only when an "IsOccuring" scheduled recording event of the same TV recording event fails.
Canceled	The scheduled recording event has been canceled before it starts, typically due to a user request.
Conflict	The scheduled recording event exists, but it will not occur due to another scheduled recording event with a higher priority.
Deleted	The scheduled recording event has finished, but the recorded media for it has been deleted.
Error	The scheduled recording event exists, but it will not occur or it failed to start because of an error, such as insufficient disk space or the tuner was not available at the scheduled time.
HasOccurred	The scheduled recording event has finished and the recorded file is available.
IsOccurring	The scheduled recording event is in progress.
None	The initial state in which the scheduled recording event does not exist or does not have any state.
WillOccur	The scheduled recording event is scheduled to occur.

Remarks
This enumeration is bit-field flag. You can specify or receive values of this enumeration combined by a bitwise OR.
An application should not handle scheduled recording events with the following states because they may disappear without notification:
•	None
•	Canceled
•	Deleted
If a future scheduled recording event might not be recorded due to insufficient disk space, that possibility is not reflected in this state information.
Requirements
Reference: ehRecObj
Namespace: Microsoft.MediaCenter.TV.Scheduling
Assembly: ehRecObj.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.TV.Scheduling Namespace
•	Working with Live and Recorded TV

# ScheduleRequest Class
Provides information about a recording request. Multiple instances of the ScheduleRequest object may be created and returned for one specific scheduled recording event. To determine whether multiple instances of the class are pointing to the same event, compare their Id properties.
Syntax
public class ScheduleRequest

Public Instance Methods
Method	Description
Cancel
Cancels the recording request.
GetExtendedProperty
Gets the value of a specified property from the recording request.
GetScheduleEvents
Gets all scheduled recording events that were generated from a recording request.

Public Instance Properties
Property	Description
Id
Gets a unique identifier (ID) string that identifies a recording request.
OriginatorId
Gets a unique ID string that identifies the origin of a recording request.

See Also
•	Microsoft.MediaCenter.TV.Scheduling Namespace
•	Working with Live and Recorded TV

# ScheduleRequest.Cancel Method
Cancels the recording request.
Syntax
public void Cancel();

Return Value
This method does not return a value.
Requirements
Reference: ehRecObj
Namespace: Microsoft.MediaCenter.TV.Scheduling
Assembly: ehRecObj.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.TV.Scheduling Namespace
•	ScheduleRequest Class
•	Working with Live and Recorded TV

# ScheduleRequest.GetExtendedProperty Method
Gets the value of a specified property from the recording request.
Syntax
public object GetExtendedProperty(
  string  name
);

Parameters
name
System.String.  Specifies the name of the property to retrieve. The following properties can be retrieved:
Name	Description	Object type
Title	Title of the recording request.	string
ServiceID	Unique identifier representing the service. 	string
ChannelID	Unique identifier representing the channel.	string
KeepUntil	Indicates how long to keep the recorded files from this recording request. The following values are possible:
-3: Latest recordings
-2: Keep until I watch
-1: Keep until space needed
0: Keep until I delete
1 or more: Number of days to keep	int
Quality	The recording quality, which can be one of the following values:
0: Fair
1: Good
2: Better
3: Best	int
Priority	Unique value representing the priority. The highest priority is 0.	int
RequestType	Type of request (such as Manual, Keyword, Series, or Onetime)	string

Return Value
System.Object.  The object representing the property. The object type depends on the property. If the specified property does not exist, this method returns null. This method raises an ArgumentNullException if the name is null. This method raises an EventScheduleException for any other errors.
Requirements
Reference: ehRecObj
Namespace: Microsoft.MediaCenter.TV.Scheduling
Assembly: ehRecObj.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.TV.Scheduling Namespace
•	ScheduleRequest Class
•	Working with Live and Recorded TV

# ScheduleRequest.GetScheduleEvents Method
Gets all scheduled recording events that were generated from a recording request.
Syntax
public ICollection<ScheduleEvent> GetScheduleEvents();

Return Value
System.Collections.Generic.ICollection<Microsoft.MediaCenter.TV.Scheduling.ScheduleEvent>.  A collection of ScheduleEvent objects.
This method raises an EventScheduleException for any error.
Requirements
Reference: ehRecObj
Namespace: Microsoft.MediaCenter.TV.Scheduling
Assembly: ehRecObj.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.TV.Scheduling Namespace
•	ScheduleRequest Class
•	Working with Live and Recorded TV

# ScheduleRequest.Id Property
Gets a unique identifier (ID) string that identifies a recording request.
Syntax
public string Id {get;}

Property Value
System.String.  The recording request ID.
This property is read-only.
Remarks
The client can use this ID to specify a particular recording request. The client can also use this ID to determine whether different operations point to the same recording request.
Requirements
Reference: ehRecObj
Namespace: Microsoft.MediaCenter.TV.Scheduling
Assembly: ehRecObj.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.TV.Scheduling Namespace
•	ScheduleRequest Class
•	Working with Live and Recorded TV

# ScheduleRequest.OriginatorId Property
Gets a unique ID string that identifies the origin of a recording request.
Syntax
public string OriginatorId {get;}

Property Value
System.String. The origin ID string.
This property is read-only.
Remarks
If the EventSchedule.CreateScheduleRequest method created the recording request, this property is the string that was passed as the originatorDescription parameter.
Requirements
Reference: ehRecObj
Namespace: Microsoft.MediaCenter.TV.Scheduling
Assembly: ehRecObj.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.TV.Scheduling Namespace
•	ScheduleRequest Class
•	Working with Live and Recorded TV

---

MCESDK_Ref02.doc

# Microsoft.MediaCenter.UI Namespace
The following types are in the Microsoft.MediaCenter.UI namespace, which is in the Microsoft.Mediacenter.UI.dll assembly.
The Microsoft.MediaCenter.UI namespace exposes the following classes:
Class	Description
Application
Provides services for applications.
ArrayListDataSet
Specifies an array-based data set that is used to provide a list of data. This class is used primarily by the Repeater view item.
BooleanChoice
Allows a choice of true or false.
ByteRangedValue
Defines a byte value within a minimum and maximum range.
Choice
Defines a list of exclusive options that the application can work with. The application can use an index or access options by advancing through them in either direction.
Command
Represents a ModelItem object that can be invoked.
EditableDigits
Represents a user-editable string of digits.
EditableText
Represents a user-editable string.
EventArgs
Contains event data.
Image
Creates an image object.
ImageRequirements
Defines the requirements for loading an image.
IntRangedValue
Defines an integer value within a minimum and maximum range.
ListDataSet
Creates a collection of data that can change and be manipulated. This class wraps an IList and sends notifications when its contents have changed.
LoadResult
Provides status when loading markup.
MarkupVisibleAttribute
Defines an attribute to apply to non-public members that may be accessible from markup.
McmlLoadResult
Provides status when loading a Windows Media Center Markup Language (MCML) resource.
ModelItem
Represents the main base object in which the model (code and data) is created. The object that owns the ModelItem object is responsible for disposing of it.
ObjectPropertyPair
Groups objects and properties.
PropertySet
Defines an arbitrary collection of property values and raises property change notifications when you add, remove, or modify property values.
RangedValue
Defines a value within a minimum and maximum range.
ResourceGroup
Acquires a set of XML data from a Web service for displaying a UI, such as a set of images, sounds, and text.
SecureEditableText
Represents a secure user-editable string.

Sound
Creates a sound object.
Timer
Creates a timer object, which allows you to set properties and start and stop the timer.
VirtualList
Creates a collection of very large data sets, slow-acquiring data, or a combination of both.

The Microsoft.MediaCenter.UI namespace exposes the following interfaces:
Interface	Description
ICommand
Provides base command functionality.
IModelItem
Provides base functionality for a ModelItem.
IModelItemOwner
Takes ownership of the lifetime of a set of ModelItem objects.
IPropertyObject
Provides a mechanism for receiving property-change notifications.
ITransformer
Creates a data transformation object.
ITransformerEx
Creates a data transformation object and allows you to apply a pretransformation object first.
IValueRange
Provides base functionality for a value set.

The Microsoft.MediaCenter.UI namespace exposes the following structures:
Structure	Description
Color
Represents an Alpha Red Green Blue (ARGB) color.
Inset
Defines the sides of an inset (left, top, right, and bottom).
Point
Defines a point.
Rectangle
Defines a rectangle.
Rotation
Defines an axis of rotation.
Size
Defines a size as height and width.
Vector3
Defines a vector.

The Microsoft.MediaCenter.UI namespace exposes the following enumerations:
Enumeration	Description
AcquisitionStatus
Contains values that indicate the status of acquiring a resource group.
Colors
Contains a list of system-defined colors.
InvokePolicy
Specifies the ways in which a call can be invoked.
LoadResultStatus
Contains the types of status when loading markup.
ModelItemDisposeMode
Contains options for disposing of a ModelItem object.
ReleaseBehavior
Contains the possible actions to take with a data item when the VisualReleaseBehavior property is called.

The Microsoft.MediaCenter.UI namespace exposes the following delegates:
Delegate	Description
DeferredHandler
Represents the callback method to invoke when you call the Application.DeferredInvoke or Application.DeferredInvokeOnWorkerThread methods to schedule work to be done on the thread.
ItemCountHandler
Represents a delayed callback method that queries the count, so that the count does not need to be specified when the VirtualList object is created.
ItemRequestCallback
Represents a callback method that is invoked in response to a VirtualList item query after the data item is available.
PropertyChangedEventHandler
Represents the method that handles property changes in the IPropertyObject object.

RequestItemHandler
Represents the method to handle requests from a VirtualList to get and create an item if it is not available.
RequestSlowDataHandler
Represents the method to handle requests from a VirtualList to fill in slow data (data that takes a long time to load) on a list item that has already been created.

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Managed Code Object Model Reference
•	Programming Reference
# AcquisitionStatus Enumeration
Contains values that indicate the status of acquiring a resource group.
public enum AcquisitionStatus

The AcquisitionStatus enumeration defines the following constants:
Constant	Description
Acquiring	Retrieving the objects in the resource group is in progress.
Done	All of the objects in the resource group have been retrieved.
NeedsAcquire	The objects in the resource group have not been acquired.


Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	ResourceGroup Class
•	Working with Resource Groups
# Application Class
Provides services for applications.
public class Application

Public Static Methods
Method	Description
DeferredInvoke
Schedules a callback to occur at a future time on the application thread.
DeferredInvokeOnWorkerThread
Schedules two callbacks to occur at a future time on the worker thread.
IsMcmlLoaded
Determines whether the specified Windows Media Center Markup Language (MCML) is loaded.
LoadMcml
Loads MCML markup from the specified URI.
UnloadMcml
Unloads markup that was previously loaded from the specified URI.

Public Static Properties
Property	Description
ApplicationThread
Gets the application thread.
IsApplicationThread
Gets a value that indicates whether the current thread is the application thread.

Public Static Events
Event	Description
Idle
Raised when the application is in idle mode.

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
# Application.ApplicationThread Property
Gets the application thread.
Syntax
public static System.Threading.Thread ApplicationThread {get;}

Property Value
System.Threading.Thread.  The application thread.
This property is read-only.
Remarks
This method is safe to call from any thread.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Application Class
# Application.DeferredInvoke Method
Schedules a callback to occur at a future time on the application thread.
Overload List
public static void DeferredInvoke(
  DeferredHandler  method
);
public static void DeferredInvoke(
  DeferredHandler  method,
  object  args
);
public static void DeferredInvoke(
  DeferredHandler  method,
  TimeSpan  delay
);
public static void DeferredInvoke(
  DeferredHandler  method,
  object  args,
  TimeSpan  delay
);

Parameters
method
Microsoft.MediaCenter.UI.DeferredHandler.  The callback method.
args
System.Object.  The arguments to the callback method.
delay
System.TimeSpan.  The delay before the callback.
Remarks
Background threads use this method. This method is safe to call from any thread.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Application Class
# Application.DeferredInvokeOnWorkerThread Method
Schedules two callbacks to occur at a future time—one callback on a background thread, and another callback on the application thread after the first callback has completed.
Syntax
public static void DeferredInvokeOnWorkerThread(
  DeferredHandler  workerMethod,
  DeferredHandler  notifyMethod,
  object  args
);

Parameters
workerMethod
Microsoft.MediaCenter.UI.DeferredHandler.  The callback method to be called on the worker thread.
notifyMethod
Microsoft.MediaCenter.UI.DeferredHandler.  The callback method to be called on the application thread when the work is done.
args
System.Object. The objects to be passed as parameters to both delegates.
Remarks
This method is useful when you have data to load on a background thread, and then need to act on that data on the application thread.
This method is safe to call from any thread.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Application Class
# Application.Idle Event
Raised when the application is in idle mode.
Syntax
public static event System.EventHandler Idle;

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Application Class
# Application.IsApplicationThread Property
Gets a value that indicates whether the current thread is the application thread.
Syntax
public static bool IsApplicationThread {get;}

Property Value
System.Boolean.  true if it is an application thread; otherwise false.
This property is read-only.
Remarks
This method is safe to call from any thread.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Application Class
# Application.IsMcmlLoaded Method
Determines whether the specified Windows Media Center Markup Language (MCML) is loaded.
Syntax
public static bool IsMcmlLoaded(
  string  uri
);

Parameters
uri
System.String.  A Uniform Resource Identifier (URI) that specifies the MCML.
Return Value
System.Boolean.  true if the MCML was loaded; otherwise false.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Application Class
# Application.LoadMcml Method
Loads Windows Media Center Markup Language (MCML) markup from the specified URI.
Syntax
public static McmlLoadResult LoadMcml(
  string  uri
);

Parameters
uri
System.String.  The Uniform Resource Identifier (URI) that specifies the MCML.
Return Value
Microsoft.MediaCenter.UI.McmlLoadResult.  The results of the load operation.
Remarks
Typically, MCML files are loaded automatically and it isn't necessary to load them manually.
The following are examples of URIs:
•	resx://MyAssembly/MyMarkup
•	res://MyDll!MyMarkup
•	file://C:\MyMarkup.mcml
•	http://www.contoso.com/MyMarkup.mcml
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Application Class
# Application.UnloadMcml Method
Unloads Windows Media Center Markup Language (MCML) markup that was previously loaded from the specified URI.
Syntax
public static void UnloadMcml(
  string  uri
);

Parameters
uri
System.String.  The Uniform Resource Identifier (URI) that specifies the MCML.
Remarks
When unloading markup, any future loads from the URI will fully acquire and load the resource. Any existing LoadResult to the specified URI is still valid.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Application Class
# ArrayListDataSet Class
Specifies an array-based data set that is used to provide a list of data. The ArrayListDataSet class provides notifications when the list contents change so that your UI can automatically refresh itself. This class is used primarily by the Repeater view item.
public class ArrayListDataSet : ListDataSet

Public Instance Constructors
Constructor	Description
ArrayListDataSet()
Initializes a new instance of the ArrayListDataSet class.
ArrayListDataSet(IModelItemOwner)
Initializes a new instance of the ArrayListDataSet class.

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ListDataSet Class
•	Microsoft.MediaCenter.UI Namespace
•	Repeater Element
# ArrayListDataSet Constructor
Initializes a new instance of the ArrayListDataSet Class.
Overload List
public ArrayListDataSet()
public ArrayListDataSet(IModelItemOwner)
# ArrayListDataSet.ArrayListDataSet Constructor
Initializes a new instance of the ArrayListDataSet Class.
public ArrayListDataSet();

# ArrayListDataSet.ArrayListDataSet Constructor
Initializes a new instance of the ArrayListDataSet Class.
public ArrayListDataSet(
  IModelItemOwner  owner
);

Parameters
owner
Microsoft.MediaCenter.UI.IModelItemOwner.  The owner of the ModelItem.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
# BooleanChoice Class
Provides a choice of true or false.
public class BooleanChoice : Choice

Public Instance Constructors
Constructor	Description
BooleanChoice()
Initializes a new instance of the BooleanChoice class.
BooleanChoice(IModelItemOwner)
Initializes a new instance of the BooleanChoice class.
BooleanChoice(IModelItemOwner, string)	Initializes a new instance of the BooleanChoice class.
BooleanChoice(IModelItemOwner, string, IList)	Initializes a new instance of the BooleanChoice class.

Protected Instance Methods
Method	Description
ValidateOptionList
Validates that the given Options list is acceptable for this Choice object. If not, an exception will be thrown.

Public Instance Properties
Property	Description
Value
Gets or sets the value of the choice.

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Choice Class
•	Microsoft.MediaCenter.UI Namespace
# BooleanChoice Constructor
Initializes a new instance of the BooleanChoice class.
Overload List
public BooleanChoice()
public BooleanChoice(IModelItemOwner)
public BooleanChoice(IModelItemOwner, string)
public BooleanChoice(IModelItemOwner, string, IList)
# BooleanChoice.BooleanChoice Constructor
Initializes a new instance of the BooleanChoice class.
public BooleanChoice();

# BooleanChoice.BooleanChoice Constructor
Initializes a new instance of the BooleanChoice class.
public BooleanChoice(
  IModelItemOwner  owner
);

Parameters
owner
Microsoft.MediaCenter.UI.IModelItemOwner.  The owner of the ModelItem.
# BooleanChoice.BooleanChoice Constructor
Initializes a new instance of the BooleanChoice class.
public BooleanChoice(
  IModelItemOwner  owner,
  string  description
);

Parameters
owner
Microsoft.MediaCenter.UI.IModelItemOwner.  The owner of the ModelItem.
description
System.String.  The description of the object.
# BooleanChoice.BooleanChoice Constructor
Initializes a new instance of the BooleanChoice class.
public BooleanChoice(
  IModelItemOwner  owner,
  string  description,
  System.Collections.IList  options
);

Parameters
owner
Microsoft.MediaCenter.UI.IModelItemOwner.  The owner of the ModelItem.
description
System.String.  The description of the object.
options
System.Collections.IList.  A list of exactly two options.
Remarks
The first (index 0) options corresponds to false; the second item (index 1) corresponds to true. For example, the BooleanChoice.Value property returns false if item 0 is selected.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	BooleanChoice Class
# BooleanChoice.ValidateOptionList Method
Validates that the given Options list is acceptable for this Choice object (for BooleanChoice, the list must contain exactly two items). If not, an exception will be thrown.
Syntax
protected void ValidateOptionList(
  System.Collections.IList  potentialOptions
);

Parameters
potentialOptions
System.Collections.IList.  The list to validate.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	BooleanChoice Class
# BooleanChoice.Value Property
Gets or sets the value of the choice.
Syntax
public bool Value {get; set;}

Property Value
System.Boolean.  true if the selected index is 1; false if the selected index is 0.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	BooleanChoice Class
# ByteRangedValue Class
Defines a byte value within a minimum and maximum range.
public class ByteRangedValue : RangedValue

Public Instance Constructors
Constructor	Description
ByteRangedValue()
Initializes a new instance of the ByteRangedValue class.
ByteRangedValue(IModelItemOwner)
Initializes a new instance of the ByteRangedValue class.
ByteRangedValue(IModelItemOwner, string) 	Initializes a new instance of the ByteRangedValue class.

Public Instance Properties
Property	Description
MaxValue
Gets or sets the maximum value of the range.
MinValue
Gets or sets the minimum value of the range.
Step
Gets or sets the value of the increment or decrement value when the NextValue or PreviousValue method is called.
Value
Gets or sets the current value.

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
# ByteRangedValue Constructor
Initializes a new instance of the ByteRangedValue class.
Overload List
public ByteRangedValue();
public ByteRangedValue(IModelItemOwner)
public ByteRangedValue(IModelItemOwner, string)
# ByteRangedValue.ByteRangedValue Constructor
Initializes a new instance of the ByteRangedValue class.
public ByteRangedValue();

# ByteRangedValue.ByteRangedValue Constructor
Initializes a new instance of the ByteRangedValue class.
public ByteRangedValue(
  IModelItemOwner  owner
);

Parameters
owner
Microsoft.MediaCenter.UI.IModelItemOwner.  The owner of the ModelItem.
# ByteRangedValue.ByteRangedValue Constructor
Initializes a new instance of the ByteRangedValue class.
public ByteRangedValue(
  IModelItemOwner  owner,
  string  description
);

Parameters
owner
Microsoft.MediaCenter.UI.IModelItemOwner.  The owner of the ModelItem.
description
System.String.  A description of the object.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ByteRangedValue Class

# ByteRangedValue.MaxValue Property
Gets or sets the maximum value of the range.
Syntax
public byte MaxValue {get; set;}

Property Value
System.UInt8.  The maximum value allowed.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ByteRangedValue Class
•	Microsoft.MediaCenter.UI Namespace

# ByteRangedValue.MinValue Property
Gets or sets the minimum value of the range.
Syntax
public byte MinValue {get; set;}

Property Value
System.UInt8.  The minimum value allowed.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ByteRangedValue Class
•	Microsoft.MediaCenter.UI Namespace

# ByteRangedValue.Step Property
Gets or sets the value of the increment or decrement value when the NextValue or PreviousValue method is called.
Syntax
public byte Step {get; set;}

Property Value
System.UInt8.  The value of the increment or decrement.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ByteRangedValue Class
•	Microsoft.MediaCenter.UI Namespace

# ByteRangedValue.Value Property
Gets or sets the current value.
Syntax
public byte Value {get; set;}

Property Value
System.UInt8.  The current value.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ByteRangedValue Class
# Choice Class
Defines a list of exclusive options that the application can work with. The application can use an index or access options by advancing through them in either direction.
public class Choice : ModelItem, IValueRange, IModelItem, IPropertyObject, IModelItemOwner

Public Instance Constructors
Constructor	Description
Choice()
Choice(IModelItemOwner)
Initializes a new instance of the Choice class.
Choice(IModelItemOwner, string)
Initializes a new instance of the Choice class.
Choice(IModelItemOwner, string, IList)
Initializes a new instance of the Choice class.

Public Instance Methods
Method	Description
DefaultValue
Changes the selected option to the default item.
NextValue
Changes the selected option to the next one in the Options list.
PreviousValue
Changes the selected option to the previous one in the Options list.

Protected Instance Methods
Method	Description
GetIndexOfOption
Gets the index of the selected option in the Options array.

OnChosenChanged
Notifies derived classes when the selected option has changed.
ValidateOptionList
Verifies that the given Options list is acceptable for this Choice object.

Public Instance Properties
Property	Description
Chosen
Gets or sets the object that is selected from the Options list.
ChosenIndex
Gets or sets the index of the object that is selected from the Options list.
Default
Gets or sets the default object within the Options list.
DefaultIndex
Gets or sets the index of the default object within the Options list.
HasNextValue
Determines whether a call to the NextValue method will succeed.
HasPreviousValue
Determines whether a call to the PreviousValue method will succeed.
Options
Gets or sets the list of Options.
Wrap
Gets or sets a value that indicates whether the list should wrap when the PreviousValue or NextValue methods are called at the beginning or end of the list.

Public Instance Events
Event	Description
ChosenChanged
Raised when the chosen item has changed.

Remarks
Only one item can be chosen at a time. A typical user interface element for this object is a radio group or a spinner control.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	BooleanChoice Class
•	Microsoft.MediaCenter.UI Namespace
# Choice Constructor
Initializes a new instance of the Choice class.
Overload List
public Choice()
public Choice(IModelItemOwner)
public Choice(IModelItemOwner, string)
public Choice(IModelItemOwner, string, IList)
# Choice.Choice Constructor
Initializes a new instance of the Choice class.
public Choice();

# Choice.Choice Constructor
Initializes a new instance of the Choice class.
public Choice(
  IModelItemOwner  owner
);

Parameters
owner
Microsoft.MediaCenter.UI.IModelItemOwner.  The owner of the ModelItem.
# Choice.Choice Constructor
Initializes a new instance of the Choice class.
public Choice(
  IModelItemOwner  owner,
  string  description
);

Parameters
owner
Microsoft.MediaCenter.UI.IModelItemOwner.  The owner of the ModelItem.
description
System.String.  The description of the object.
# Choice.Choice Constructor
Initializes a new instance of the Choice class.
public Choice(
  IModelItemOwner  owner,
  string  description,
  System.Collections.IList  options
);

Parameters
owner
Microsoft.MediaCenter.UI.IModelItemOwner.  The owner of the ModelItem.
description
System.String.  The description of the object.
options
System.Collections.IList.  A list of options that will be available in the Choice object.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Choice Class
# Choice.Chosen Property
Gets or sets the object that is selected from the Options list.
Syntax
public object Chosen {get; set;}

Property Value
System.Object.  The selected object.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Choice Class
# Choice.ChosenChanged Event
Raised when the chosen item has changed.  
Syntax
public event System.EventHandler ChosenChanged;

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Choice Class
# Choice.ChosenIndex Property
Gets or sets the index of the object that is selected from the Options list.
Syntax
public int ChosenIndex {get; set;}

Property Value
System.Int32.  The index value.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Choice Class
# Choice.Default Property
Gets or sets the default object within the Options list.
Syntax
public object Default {get; set;}

Property Value
System.Object.  The default object.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Choice Class
# Choice.DefaultIndex Property
Gets or sets the index of the default object within the Options list.
Syntax
public int DefaultIndex {get; set;}

Property Value
System.Int32.  The index value.
This property is read/write.
Remarks
By default, the first option (index=0) is selected as the initial value. You can choose a different initial value using the DefaultIndex property by creating a rule.
For example, the following markup defines a list of options, but the DefaultIndex property is not yet used, and the initial value is set to Option1:
<Choice Name="Options" DefaultIndex="3">
    <Options>
        <cor:String String="Option1"/>
        <cor:String String="Option2"/>
        <cor:String String="Option3"/>
        <cor:String String="Option4"/>
    </Options>
</Choice>

To set the default index value when the UI is created, create a rule that does not have a condition, but has an Invoke action to call Choice.DefaultValue:
<Actions>
    <Invoke Target="[Options.DefaultValue]" />
</Actions>

You can reset the default value at any time by using the Choice.DefaultValue method.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Choice Class
# Choice.DefaultValue Method
Changes the selected option to the default item.
Syntax
public void DefaultValue();

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Choice Class
•	Choice.Default Property
# Choice.GetIndexOfOption Method
Gets the index of the selected option in the Options array.
Syntax
protected int GetIndexOfOption(
  object  option
);

Parameters
option
System.Object.  The option to retrieve.
Return Value
System.Int32.  The index of the selected option. A value of -1 indicates that the option was not found.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Choice Class
# Choice.HasNextValue Property
Gets a value that indicates whether a call to the NextValue method will succeed.
Syntax
public bool HasNextValue {get;}

Property Value
System.Boolean.  true if there is a next value; otherwise, false.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Choice Class
•	Choice.NextValue Method
# Choice.HasPreviousValue Property
Gets a value that indicates whether a call to the PreviousValue method will succeed.
Syntax
public bool HasPreviousValue {get;}

Property Value
System.Boolean.  true if there is a previous value; otherwise false.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Choice Class
•	Choice.PreviousValue Method
# Choice.NextValue Method
Changes the selected option to the next one in the Options list.
Overload List
public void NextValue();
public void NextValue(
  bool  allowWrap
);

Parameters
allowWrap
System.Boolean.  true to allow wrapping if the selected option is at the end of the list; otherwise, false.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Choice Class
# Choice.OnChosenChanged Method
Notifies derived classes when the selected option has changed.
Syntax
protected void OnChosenChanged();

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Choice Class
•	Choice.Chosen Property
# Choice.Options Property
Gets or sets the list of Options.
Syntax
public System.Collections.IList Options {get; set;}

Property Value
System.Collections.IList.  The list of options.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Choice Class
# Choice.PreviousValue Method
Changes the selected option to the previous one in the Options list.
Overload List
public void PreviousValue();
public void PreviousValue(
  bool  allowWrap
);

Parameters
allowWrap
System.Boolean.  true to allow wrapping if the selected option is at the beginning of the list; otherwise, false.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Choice Class
# Choice.ValidateOptionList Method
Verifies that the given Options list is acceptable for this Choice object. If not, an exception will be thrown.
Syntax
protected void ValidateOptionList(
  System.Collections.IList  potentialOptions
);

Parameters
potentialOptions
System.Collections.IList.  The list to validate.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Choice Class
# Choice.Wrap Property
Gets or sets a value that indicates whether the list should wrap when the PreviousValue or NextValue methods are called at the beginning or end of the list.
Syntax
public bool Wrap {get; set;}

Property Value
System.Boolean.  true if the list should wrap; otherwise, false.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Choice Class
# Color Structure
Represents an Alpha Red Green Blue (ARGB) color.
public struct Color

Public Instance Constructors
Constructor	Description
Color(Colors)
Initializes a new instance of the Color structure
Color(float, float, float)
Initializes a new instance of the Color structure
Color(int, int, int);
Initializes a new instance of the Color structure

Public Operators
Operator	Description
Equality
Tests whether two specified Color structures are equivalent.
Inequality
Tests whether two Color structures are different.

Public Instance Methods
Method	Description
Equals
Tests whether the specified object is a Color structure and is equivalent to the current Color structure.
GetHashCode
Returns a hash code for this structure.
ToString
Converts this structure to a human-readable string.


Public Instance Properties
Property	Description
A
Gets or sets the alpha component value of the current Color structure
B
Gets or sets the blue component value of the current Color structure.
G
Gets or sets the green component value of the current Color structure.
R
Gets or sets the red component value of the current Color structure.

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
# Color Constructor
Initializes a new instance of the Color structure.
Overload List
public Color(Colors)
public Color(float, float, float)
public Color(int, int, int);
MCML Inline Syntax
# Color.Color Constructor
Initializes a new instance of the Color structure.
public Color(
  Colors  color
);

Parameters
color
Microsoft.MediaCenter.UI.Colors.  A system-defined color.
# Color.Color Constructor
Initializes a new instance of the Color structure.
public Color(
  float  red,
  float  green,
  float  blue
);

Parameters
red
System.Int32.  The red component value of this color. This value must be between 0 and 255.
green
System.Int32.  The green component of this color. This value must be between 0 and 255.
blue
System.Int32.  The blue component of this color. This value must be between 0 and 255.
# Color.Color Constructor
Initializes a new instance of the Color structure.
public Color(
  int  red,
  int  green,
  int  blue
);

Parameters
red
System.Int32.  The red component value of this color. This value must be between 0 and 255.
green
System.Int32.  The green component of this color. This value must be between 0 and 255.
blue
System.Int32.  The blue component of this color. This value must be between 0 and 255.
# MCML Inline Syntax
Color="red,green,blue"
Color="alpha,red,green,blue"
Color="color"

Parameters
red
System.Int32.  The red component value of this color. This value must be between 0 and 255.
green
System.Int32.  The green component of this color. This value must be between 0 and 255.
blue
System.Int32.  The blue component of this color. This value must be between 0 and 255.
alpha
System.Int32.  The alpha component of this color. When this value is not specified, a value of 0 is assumed, and a transparent color is created. For an opaque color, set this value to 255.
color
Microsoft.MediaCenter.UI.Colors.  A system-defined color.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Color Structure
•	GetColor Method
# Color.A Property
Gets or sets the alpha component value of the current Color structure.
Syntax
public byte A {get; set;}

Property Value
System.UInt8.  The value of the alpha component.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Color Structure
# Color.B Property
Gets or sets the blue component value of the current Color structure.
Syntax
public byte B {get; set;}

Property Value
System.UInt8.  The value of the blue componenet.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Color Structure
# Color.Equality Operator
Tests whether two specified Color structures are equivalent.
Syntax
public static bool operator==(
  Color  left,
  Color  right
);

Parameters
left
Microsoft.MediaCenter.UI.Color.  The Color structure that is to the left of the equality operator.
right
Microsoft.MediaCenter.UI.Color.  The Color structure that is to the right of the equality operator.
Return Value
System.Boolean.  true if these structures are equal; otherwise, false.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Color Structure
# Color.Equals Method
Tests whether the specified object is a Color structure and is equivalent to the current Color structure.
Syntax
public bool Equals(
  object  obj
);

Parameters
obj
System.Object.  The object to test.
Return Value
System.Boolean.  true if the structures are equal; otherwise, false.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Color Structure
# Color.G Property
Gets or sets the green component value of the current Color structure.
Syntax
public byte G {get; set;}

Property Value
System.UInt8.  The value of the green component.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Color Structure
# Color.GetHashCode Method
Gets a hash code for this Color structure.
Syntax
public int GetHashCode();

Return Value
System.Int32.  The structure's hash code.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Color Structure
# Color.Inequality Operator
Tests whether two Color structures are different.
Syntax
public static bool operator!=(
  Color  left,
  Color  right
);

Parameters
left
Microsoft.MediaCenter.UI.Color.  The Color structure that is to the left of the inequality operator.
right
Microsoft.MediaCenter.UI.Color.  The Color structure that is to the right of the inequality operator.
Return Value
System.Boolean.  true if the structures are not equal; otherwise, false.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Color Structure
# Color.R Property
Gets or sets the red component value of the current Color structure.
Syntax
public byte R {get; set;}

Property Value
System.UInt8.  The value of the red component.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Color Structure
# Color.ToString Method
Converts this Color structure to a human-readable string.
Syntax
public string ToString();

Return Value
System.String.  A string that consists of the Alpha Red Green Blue (ARGB) component names and their values.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Color Structure
# Colors Enumeration
Contains a list of system-defined colors.
public enum Colors

The Colors enumeration defines the following constants:
Constant	Description
AliceBlue	Name of a system-defined color.
AntiqueWhite	Name of a system-defined color.
Aqua	Name of a system-defined color.
Aquamarine	Name of a system-defined color.
Azure	Name of a system-defined color.
Beige	Name of a system-defined color.
Bisque	Name of a system-defined color.
Black	Name of a system-defined color.
BlanchedAlmond	Name of a system-defined color.
Blue	Name of a system-defined color.
BlueViolet	Name of a system-defined color.
Brown	Name of a system-defined color.
BurlyWood	Name of a system-defined color.
CadetBlue	Name of a system-defined color.
Chartreuse	Name of a system-defined color.
Chocolate	Name of a system-defined color.
Coral	Name of a system-defined color.
CornflowerBlue	Name of a system-defined color.
Cornsilk	Name of a system-defined color.
Crimson	Name of a system-defined color.
Cyan	Name of a system-defined color.
DarkBlue	Name of a system-defined color.
DarkCyan	Name of a system-defined color.
DarkGoldenrod	Name of a system-defined color.
DarkGray	Name of a system-defined color.
DarkGreen	Name of a system-defined color.
DarkKhaki	Name of a system-defined color.
DarkMagenta	Name of a system-defined color.
DarkOliveGreen	Name of a system-defined color.
DarkOrange	Name of a system-defined color.
DarkOrchid	Name of a system-defined color.
DarkRed	Name of a system-defined color.
DarkSalmon	Name of a system-defined color.
DarkSeaGreen	Name of a system-defined color.
DarkSlateBlue	Name of a system-defined color.
DarkSlateGray	Name of a system-defined color.
DarkTurquoise	Name of a system-defined color.
DarkViolet	Name of a system-defined color.
DeepPink	Name of a system-defined color.
DeepSkyBlue	Name of a system-defined color.
DimGray	Name of a system-defined color.
DodgerBlue	Name of a system-defined color.
Feldspar	Name of a system-defined color.
Firebrick	Name of a system-defined color.
FloralWhite	Name of a system-defined color.
ForestGreen	Name of a system-defined color.
Fuchsia	Name of a system-defined color.
Gainsboro	Name of a system-defined color.
GhostWhite	Name of a system-defined color.
Gold	Name of a system-defined color.
Goldenrod	Name of a system-defined color.
Gray	Name of a system-defined color.
Green	Name of a system-defined color.
GreenYellow	Name of a system-defined color.
Honeydew	Name of a system-defined color.
HotPink	Name of a system-defined color.
IndianRed	Name of a system-defined color.
Indigo	Name of a system-defined color.
Ivory	Name of a system-defined color.
Khaki	Name of a system-defined color.
Lavender	Name of a system-defined color.
LavenderBlush	Name of a system-defined color.
LawnGreen	Name of a system-defined color.
LemonChiffon	Name of a system-defined color.
LightBlue	Name of a system-defined color.
LightCoral	Name of a system-defined color.
LightCyan	Name of a system-defined color.
LightGoldenrodYellow	Name of a system-defined color.
LightGray	Name of a system-defined color.
LightGreen	Name of a system-defined color.
LightPink	Name of a system-defined color.
LightSalmon	Name of a system-defined color.
LightSeaGreen	Name of a system-defined color.
LightSkyBlue	Name of a system-defined color.
LightSlateBlue	Name of a system-defined color.
LightSlateGray	Name of a system-defined color.
LightSteelBlue	Name of a system-defined color.
LightYellow	Name of a system-defined color.
Lime	Name of a system-defined color.
LimeGreen	Name of a system-defined color.
Linen	Name of a system-defined color.
Magenta	Name of a system-defined color.
Maroon	Name of a system-defined color.
MediumAquamarine	Name of a system-defined color.
MediumBlue	Name of a system-defined color.
MediumOrchid	Name of a system-defined color.
MediumPurple	Name of a system-defined color.
MediumSeaGreen	Name of a system-defined color.
MediumSlateBlue	Name of a system-defined color.
MediumSpringGreen	Name of a system-defined color.
MediumTurquoise	Name of a system-defined color.
MediumVioletRed	Name of a system-defined color.
MidnightBlue	Name of a system-defined color.
MintCream	Name of a system-defined color.
MistyRose	Name of a system-defined color.
Moccasin	Name of a system-defined color.
NavajoWhite	Name of a system-defined color.
Navy	Name of a system-defined color.
OldLace	Name of a system-defined color.
Olive	Name of a system-defined color.
OliveDrab	Name of a system-defined color.
Orange	Name of a system-defined color.
OrangeRed	Name of a system-defined color.
Orchid	Name of a system-defined color.
PaleGoldenrod	Name of a system-defined color.
PaleGreen	Name of a system-defined color.
PaleTurquoise	Name of a system-defined color.
PaleVioletRed	Name of a system-defined color.
PapayaWhip	Name of a system-defined color.
PeachPuff	Name of a system-defined color.
Peru	Name of a system-defined color.
Pink	Name of a system-defined color.
Plum	Name of a system-defined color.
PowderBlue	Name of a system-defined color.
Purple	Name of a system-defined color.
Red	Name of a system-defined color.
RosyBrown	Name of a system-defined color.
RoyalBlue	Name of a system-defined color.
SaddleBrown	Name of a system-defined color.
Salmon	Name of a system-defined color.
SandyBrown	Name of a system-defined color.
SeaGreen	Name of a system-defined color.
SeaShell	Name of a system-defined color.
Sienna	Name of a system-defined color.
Silver	Name of a system-defined color.
SkyBlue	Name of a system-defined color.
SlateBlue	Name of a system-defined color.
SlateGray	Name of a system-defined color.
Snow	Name of a system-defined color.
SpringGreen	Name of a system-defined color.
SteelBlue	Name of a system-defined color.
Tan	Name of a system-defined color.
Teal	Name of a system-defined color.
Thistle	Name of a system-defined color.
Tomato	Name of a system-defined color.
Transparent	Name of a system-defined color.
Turquoise	Name of a system-defined color.
TVBlack	Name of a system-defined color.
TVWhite	Name of a system-defined color.
Violet	Name of a system-defined color.
VioletRed	Name of a system-defined color.
Wheat	Name of a system-defined color.
White	Name of a system-defined color.
WhiteSmoke	Name of a system-defined color.
Yellow	Name of a system-defined color.
YellowGreen	Name of a system-defined color.

Remarks
The following diagram shows the available colors:

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
# Command Class
Represents a ModelItem object that can be invoked.
public class Command : ModelItem, ICommand, IModelItem, IPropertyObject, IModelItemOwner

Public Instance Constructors
Constructor	Description
Command()
Initializes a new instance of the Command class.
Command(IModelItemOwner)
Initializes a new instance of the Command class.
Command(IModelItemOwner, EventHandler)	Initializes a new instance of the Command class.
Command(IModelItemOwner, string, EventHandler)	Initializes a new instance of the Command class.

Public Instance Methods
Method	Description
OnInvoked
Notifies derived classes when the command is invoked.

Public Instance Properties
Property	Description
Available
Gets or sets a value indicating whether the command is available.

Public Instance Events
Event	Description
Invoked
Raised when the ModelItem object is invoked.


Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
# Command Constructor
Initializes a new instance of the Command class.
Overload List
public Command()
public Command(IModelItemOwner)
public Command(IModelItemOwner, EventHandler)
public Command(IModelItemOwner, string, EventHandler)
# Command.Command Constructor
Initializes a new instance of the Command class.
public Command();

# Command.Command Constructor
Initializes a new instance of the Command class.
public Command(
  IModelItemOwner  owner
);

Parameters
owner
Microsoft.MediaCenter.UI.IModelItemOwner.  The owner of the ModelItem.
# Command.Command Constructor
Initializes a new instance of the Command class.
public Command(
  IModelItemOwner  owner,
  EventHandler  invokedHandler
);

Parameters
owner
Microsoft.MediaCenter.UI.IModelItemOwner.  The owner of the ModelItem.
invokedHandler
System.EventHandler.  An event handler for this object.
# Command.Command Constructor
Initializes a new instance of the Command class.
public Command(
  IModelItemOwner  owner,
  string  description,
  EventHandler  invokedHandler
);

Parameters
owner
Microsoft.MediaCenter.UI.IModelItemOwner.  The owner of the ModelItem.
description
System.String.  The description of the object.
invokedHandler
System.EventHandler.  An event handler for this object.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Command Class
# Command.Available Property
Gets or sets a value indicating whether this Command class is available.
Syntax
public bool Available {get; set;}

Property Value
System.Boolean.  true if the command is available; otherwise, false.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Command Class
# Command.Invoke Method
Invokes this Command class.
Overload List
public void Invoke();
public void Invoke(
  InvokePolicy  invokePolicy
);

Parameters
invokePolicy
Microsoft.MediaCenter.UI.InvokePolicy.  Specifies the policy on how to invoke the command.
Remarks
For an example of how to invoke a command, see the Scenarios.SimpleButton.mcml sample in the Sample Explorer.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Command Class
# Command.Invoked Event
Raised when the ModelItem object is invoked.
Syntax
public event System.EventHandler Invoked;

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Command Class
# Command.OnInvoked Method
Notifies derived classes when the command is invoked.
Syntax
protected void OnInvoked();

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Command Class
# DeferredHandler Delegate
Represents the callback method to invoke when you call Application.DeferredInvoke or Application.DeferredInvokeOnWorkerThread to schedule work to be done on the thread.
Syntax
public delegate void DeferredHandler(
  object  args
);

Parameters
args
System.Object.  The object that is supplied to the callback method (for instance, to provide application-specific state or context).
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
# EditableDigits Class
Represents a user-editable string of digits.
public class EditableDigits : EditableText

Public Instance Constructors
Constructor	Description
EditableDigits()
Initializes a new instance of the EditableDigits class.
EditableDigits(IModelItemOwner)
Initializes a new instance of the EditableDigits class.
EditableDigits(IModelItemOwner, string)
Initializes a new instance of the EditableDigits class.

Public Instance Methods
Method	Description
AllowCharacter
Applies a character filter.

Public Instance Properties
Property	Description
Value
Gets or sets the current value.

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.UI Namespace
# EditableDigits Constructor
Initializes a new instance of the EditableDigits class.
Overload List
public EditableDigits()
public EditableDigits(IModelItemOwner)
public EditableDigits(IModelItemOwner, string)
# EditableDigits.EditableDigits Constructor
Initializes a new instance of the EditableDigits class.
public EditableDigits();

# EditableDigits.EditableDigits Constructor
Initializes a new instance of the EditableDigits class.
public EditableDigits(
  IModelItemOwner  owner
);

Parameters
owner
Microsoft.MediaCenter.UI.IModelItemOwner.  The owner of the ModelItem.
# EditableDigits.EditableDigits Constructor
Initializes a new instance of the EditableDigits class.
public EditableDigits(
  IModelItemOwner  owner,
  string  description
);

Parameters
owner
Microsoft.MediaCenter.UI.IModelItemOwner.  The owner of the ModelItem.
description
System.String.  The description of the object.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows 7
See Also
•	EditableDigits Class
# EditableDigits.AllowCharacter Method
Applies a character filter.
Syntax
public bool AllowCharacter(
  char  ch
);

Parameters
ch
System.Char.  The character to filter.
Return Value
System.Boolean.  true if the character is allowed; otherwise, false.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows 7
See Also
•	EditableDigits Class
# EditableDigits.Value Property
Gets or sets the current text value.
Syntax
public string Value {get; set;}

Property Value
System.String.  The text string.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows 7
See Also
•	EditableDigits Class
# EditableText Class
Represents a user-editable string.
public class EditableText : ModelItem

Public Instance Constructors
Constructor	Description
EditableText()
Initializes a new instance of the EditableText class.
EditableText(IModelItemOwner)
Initializes a new instance of the EditableText class.
EditableText(IModelItemOwner, string)
Initializes a new instance of the EditableText class.

Public Instance Methods
Method	Description
AllowCharacter
Applies a character filter.
Submit
Notifies derived classes when the EditableText object should raise its Submitted event.

Protected Instance Methods
Method	Description
OnActivity
Notifies derived classes when there is input activity.
OnSubmitted
Notifies derived classes when an edit is submitted.

Public Instance Properties
Property	Description
Overtype
Gets or sets a value that indicates whether overtype is enabled.
Value
Gets or sets the current text value.

Public Instance Events
Event	Description
Activity
Raised when the user presses a key.
Submitted
Raised when an edit is submitted.

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
# EditableText Constructor
Initializes a new instance of the EditableText class.
Overload List
public EditableText()
public EditableText(IModelItemOwner)
public EditableText(IModelItemOwner, string)
# EditableText.EditableText Constructor
Initializes a new instance of the EditableText class.
public EditableText();

# EditableText.EditableText Constructor
Initializes a new instance of the EditableText class.
public EditableText(
  IModelItemOwner  owner
);

Parameters
owner
Microsoft.MediaCenter.UI.IModelItemOwner.  The owner of the ModelItem.
# EditableText.EditableText Constructor
Initializes a new instance of the EditableText class.
public EditableText(
  IModelItemOwner  owner,
  string  description
);

Parameters
owner
Microsoft.MediaCenter.UI.IModelItemOwner.  The owner of the ModelItem.
description
System.String.  The description of the object.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	EditableText Class
# EditableText.Activity Event
Raised when the user presses a key.
Syntax
public event System.EventHandler Activity;

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	EditableText Class
# EditableText.AllowCharacter Method
Applies a character filter.
Syntax
public bool AllowCharacter(
  char  ch
);

Parameters
ch
System.Char.  The character to filter.
Return Value
System.Boolean.  true if the character is allowed; otherwise, false.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	EditableText Class
# EditableText.OnActivity Method
Notifies derived classes when there is input activity.
Syntax
protected void OnActivity();

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	EditableText Class
# EditableText.OnSubmitted Method
Notifies derived classes when an edit is submitted.
Syntax
protected void OnSubmitted();

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	EditableText Class
# EditableText.Overtype Property
Gets or sets a value that indicates whether overtype is enabled.
Syntax
public bool Overtype {get; set;}

Property Value
System.Boolean.  true if overtype is enabled; otherwise, false.
This property is read/write.
Remarks
The overtype feature indicates whether typing should overwrite the existing value. It is up to the developer to implement the overtype feature. For an example of overtype, see the Scenarios.SimpleEditbox.mcml sample in the Sample Explorer.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	EditableText Class
# EditableText.Submit Method
Notifies derived classes when the EditableText object should raise its Submitted event.
Syntax
public void Submit();

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	EditableText Class
# EditableText.Submitted Event
Raised when an edit is submitted.
Syntax
public event System.EventHandler Submitted;

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	EditableText Class
# EditableText.Value Property
Gets or sets the current text value.
Syntax
public string Value {get; set;}

Property Value
System.String.  The text string.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	EditableText Class
# EventArgs Class
The EventArgs class is the base class for classes containing event data.
public class EventArgs<A,B,C,D> : EventArgs<A,B,C>
public class EventArgs<A,B,C> : EventArgs<A,B>
public class EventArgs<A,B> : EventArgs<A>
public class EventArgs<A> : System.EventArgs

Public Instance Constructors
Constructor	Description
EventArgs	Initializes a new instance of the EventArgs class.

Public Instance Properties
Constructor	Description
Value	Gets the value of value.
Value1	Gets the value of value1.
Value2	Gets the value of value2.
Value3	Gets the value of value3.

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.UI Namespace

# EventArgs Constructor
Initializes a new instance of the EventArgs class.
Syntax
public EventArgs(A value, B value1, C value2, D value3)
public EventArgs(A value, B value1, C value2)
public EventArgs(A value, B value1)
public EventArgs(A value)

Parameters
value
A.  Not documented in this release.
value1
B.  Not documented in this release.
value2
C.  Not documented in this release.
value3
D.  Not documented in this release.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows 7
See Also
•	EventArgs Class

# EventArgs.Value3 Property
Gets the value of value3.
Syntax
public D Value3 {get;}

Property Value
D.  Not documented in this release.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows 7
See Also
•	EventArgs Class

# EventArgs.Value2 Property
Gets the value of value2.
Syntax
public C Value2 {get;}

Property Value
C.  Not documented in this release.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows 7
See Also
•	EventArgs Class
# EventArgs.Value1 Property
Gets the value of value1.
Syntax
public B Value1 {get;}

Property Value
B.  Not documented in this release.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows 7
See Also
•	EventArgs Class
# EventArgs.Value Property
Gets the value of value.
Syntax
public A Value {get;}

Property Value
A.  Not documented in this release.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows 7
See Also
•	EventArgs Class
# ICommand Interface
Provides base command functionality.
public interface ICommand : IModelItem, IPropertyObject, IModelItemOwner

Public Instance Methods
Method	Description
Invoke
Invokes the command.

Public Instance Properties
Property	Description
Available
Gets or sets a value that indicates whether the command is available.

Public Instance Events
Event	Description
Invoked
Raised when the command is invoked.

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Command Class
•	Microsoft.MediaCenter.UI Namespace
# ICommand.Available Property
Gets or sets a value that indicates whether the command is available.
Syntax
public bool Available {get; set;}

Property Value
System.Boolean.  true if the command is available; otherwise, false.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ICommand Interface
# ICommand.Invoke Method
Invokes the command.
Syntax
public void Invoke();

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ICommand Interface
# ICommand.Invoked Event
Raised when the command is invoked.
Syntax
public event System.EventHandler Invoked;

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ICommand Interface
# Image Class
Creates an image object.
public class Image

Public Instance Constructors
Constructor	Description
Image(string)
Initializes a new instance of the Image class.
Image(string, ImageRequirements)
Initializes a new instance of the Image class.

Public Instance Methods
Method	Description
ToString
Converts this object to a human-readable string.


Public Instance Properties
Property	Description
Flippable
Gets or sets a value that indicates whether the image should be mirrored on right-to-left (RTL) systems.
NineGrid
Gets or sets the insets for a nine-grid drawing.

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
# Image Constructor
Initializes a new instance of the Image class.
Overload List
public Image(string)
public Image(string, ImageRequirements)
# Image.Image Constructor
Initializes a new instance of the Image class.
public Image(
  string  source
);

Parameters
source
System.String.  A Uniform Resource Identifier (URI) that specifies the path (file://, res://, resx://, or http://) to the image.
# Image.Image Constructor
Initializes a new instance of the Image class.
public Image(
  string  source,
  ImageRequirements  requirements
);

Parameters
source
System.String.  A Uniform Resource Identifier (URI) that specifies the path (file://, res://, resx://, or http://) to the image.
requirements
Microsoft.MediaCenter.UI.ImageRequirements.  The image requirements.
Remarks
Rather than leaving the image source empty, you can specify "null" as follows:
<Image  Name="Image" Image="null"/>

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Image Class
# Image.Flippable Property
Gets or sets a value that indicates whether the image should be mirrored on RTL systems.
Syntax
public bool Flippable {get; set;}

Property Value
System.Boolean.  true if the image should be mirrored; otherwise, false.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Image Class
# Image.NineGrid Property
Gets or sets the insets for a nine-grid drawing.
Syntax
public Inset NineGrid {get; set;}

Property Value
Microsoft.MediaCenter.UI.Inset.  The inset value.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Image Class
# Image.ToString Method
Converts this object to a human-readable string.
Syntax
public string ToString();

Return Value
System.String.  The string representation.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Image Class
# ImageRequirements Class
Defines the requirements for loading an image.
public class ImageRequirements

Public Instance Constructors
Constructor	Description
ImageRequirements(bool)
Initializes a new instance of the ImageRequirements class.
ImageRequirements(Size)
Initializes a new instance of the ImageRequirements class.
ImageRequirements(bool, Size)
Initializes a new instance of the ImageRequirements class.

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
# ImageRequirements Constructor
Initializes a new instance of the ImageRequirements class.
Overload List
public ImageRequirements(bool)
public ImageRequirements(Size)
public ImageRequirements(bool, Size)
# ImageRequirements.ImageRequirements Constructor
Initializes a new instance of the ImageRequirements class.
public ImageRequirements(
  bool  flippable
);

Parameters
flippable
System.Boolean.  true if the image can be mirrored on RTL systems; otherwise, false.
# ImageRequirements.ImageRequirements Constructor
Initializes a new instance of the ImageRequirements class.
public ImageRequirements(
  Size  maximumSize
);

Parameters
maximumSize
Microsoft.MediaCenter.UI.Size.  The maximum size for the image.
# ImageRequirements.ImageRequirements Constructor
Initializes a new instance of the ImageRequirements class.
public ImageRequirements(
  bool  flippable,
  Size  maximumSize
);

Parameters
flippable
System.Boolean.  true if the image can be mirrored on RTL systems; otherwise, false.
maximumSize
Microsoft.MediaCenter.UI.Size.  The maximum size for the image.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ImageRequirements Class
# IModelItem Interface
Provides base functionality for a ModelItem.
public interface IModelItem : IPropertyObject, IModelItemOwner

Public Instance Properties
Property	Description
Description
Gets or sets the description of the ModelItem.
Selected
Gets or sets a value that indicates whether the ModelItem is selected.
UniqueId
Gets or sets the unique identifier of the ModelItem.

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
# IModelItem.Description Property
Gets or sets the description of the ModelItem.
Syntax
public string Description {get; set;}

Property Value
System.String.  The description string.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IModelItem Interface
# IModelItem.Selected Property
Gets or sets a value that indicates whether the ModelItem is selected.
Syntax
public bool Selected {get; set;}

Property Value
System.Boolean.  true if selected; otherwise, false.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IModelItem Interface
# IModelItem.UniqueId Property
Gets or sets the globally unique identifier (GUID) of the ModelItem.
Syntax
public Guid UniqueId {get; set;}

Property Value
System.Guid.  The GUID that represents the unique identifier.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IModelItem Interface
# IModelItemOwner Interface
Takes ownership of the lifetime of a set of ModelItem objects.
public interface IModelItemOwner

Public Instance Methods
Method	Description
RegisterObject
Registers the specified ModelItem to be tracked for disposal.
UnregisterObject
Indicates that the specified ModelItem is not to be tracked for disposal.

Remarks
It is the responsibility of whatever implements this interface to dispose all ModelItem objects passed to it through the RegisterObject method.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
# IModelItemOwner.RegisterObject Method
Registers the specified ModelItem object to be tracked for disposal.
Syntax
public void RegisterObject(
  ModelItem  modelItem
);

Parameters
modelItem
Microsoft.MediaCenter.UI.ModelItem.  The ModelItem object to track.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IModelItemOwner Interface
# IModelItemOwner.UnregisterObject Method
Indicates that the specified ModelItem object is not to be tracked for disposal.
Syntax
public void UnregisterObject(
  ModelItem  modelItem
);

Parameters
modelItem
Microsoft.MediaCenter.UI.ModelItem.  The ModelItem that should not be tracked for disposal.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IModelItemOwner Interface
# Inset Structure
Defines the sides of an inset (left, top, right, and bottom). An inset is used to define the margins or padding around a UI item.
public struct Inset

Public Instance Constructors
Constructor	Description
Inset
Initializes a new instance of the Inset structure.

Public Operators
Operator	Description
Addition Operator
Combines two Inset structures.
Equality Operator
Tests whether two specified Inset structures are equivalent.
Inequality Operator
Tests whether two Inset structures are different.
Subtraction Operator
Subtracts one Inset structure from another.

Public Static Methods
Method	Description
Add
Combines two Inset structures.
Subtract
Subtracts one Inset structure from another.

Public Instance Methods
Method	Description
Equals
Tests whether the specified object is an Inset structure and is equivalent to the current Inset structure.
GetHashCode
Returns a hash code for this structure.
ToString
Converts this structure to a human-readable string.

Public Instance Properties
Property	Description
Bottom
Gets or sets the length of the bottom side of the inset.
Left
Gets or sets the length of the left side of the inset.
Right
Gets or sets the length of the right side of the inset.
Top
Gets or sets the length of the top side of the inset.

Public Static Fields
Field	Description
Zero
Represents a zero inset.

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
# Inset Constructor
Initializes a new instance of the Inset class.
public Inset(
  int  left,
  int  top,
  int  right,
  int  bottom
);

MCML Inline Syntax
Inset="left,top,right,bottom"

Parameters
left
System.Int32.  The length of the left side.
top
System.Int32.  The length of the top side.
right
System.Int32.  The length of the right side.
bottom
System.Int32.  The length of the bottom side.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Inset Structure
# Inset.Add Method
Combines two Inset structures.
Syntax
public static Inset Add(
  Inset  left,
  Inset  right
);

Parameters
left
Microsoft.MediaCenter.UI.Inset.  The first structure.
right
Microsoft.MediaCenter.UI.Inset.  The second structure.
Return Value
Microsoft.MediaCenter.UI.Inset.  The result of the addition.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Inset Structure
# Inset.Addition Operator
Combines two Inset structures.
Syntax
public static Inset operator+(
  Inset  left,
  Inset  right
);

Parameters
left
Microsoft.MediaCenter.UI.Inset.  The first structure.
right
Microsoft.MediaCenter.UI.Inset.  The second structure.
Return Value
Microsoft.MediaCenter.UI.Inset.  The result of the addition.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Inset Structure
# Inset.Bottom Property
Gets or sets the length of the bottom side of the inset.
Syntax
public int Bottom {get; set;}

Property Value
System.Int32.  The value of the bottom side of the inset.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Inset Structure
# Inset.Equality Operator
Tests whether two specified Inset structures are equivalent.
Syntax
public static bool operator==(
  Inset  left,
  Inset  right
);

Parameters
left
Microsoft.MediaCenter.UI.Inset.  The Inset structure that is to the left of the equality operator.
right
Microsoft.MediaCenter.UI.Inset.  The Inset structure that is to the right of the equality operator.
Return Value
System.Boolean.  true if the structures are equal; otherwise, false.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Inset Structure
# Inset.Equals Method
Tests whether the specified object is an Inset structure and is equivalent to the current Inset structure.
Syntax
public bool Equals(
  object  obj
);

Parameters
obj
System.Object.  The object to test.
Return Value
System.Boolean. true if the structures are equal; otherwise, false.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Inset Structure
# Inset.GetHashCode Method
Returns a hash code for this structure.
Syntax
public int GetHashCode();

Return Value
System.Int32.  The hash code.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Inset Structure
# Inset.Inequality Operator
Tests whether two Inset structures are different.
Syntax
public static bool operator!=(
  Inset  left,
  Inset  right
);

Parameters
left
Microsoft.MediaCenter.UI.Inset.  The Inset structure that is to the left of the inequality operator.
right
Microsoft.MediaCenter.UI.Inset.  The Inset structure that is to the right of the inequality operator.
Return Value
System.Boolean.  true if the structures are not equal; otherwise, false.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Inset Structure
# Inset.Left Property
Gets or sets the length of the left side of the Inset.
Syntax
public int Left {get; set;}

Property Value
System.Int32.  The value of the left side of the inset.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Inset Structure
# Inset.Right Property
Gets or sets the length of the right side of the Inset.
Syntax
public int Right {get; set;}

Property Value
System.Int32.  The value of the right side of the inset.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Inset Structure
# Inset.Subtract Method
Subtracts one Inset structure from another.
Syntax
public static Inset Subtract(
  Inset  left,
  Inset  right
);

Parameters
left
Microsoft.MediaCenter.UI.Inset.  The first structure.
right
Microsoft.MediaCenter.UI.Inset.  The structure to subtract.
Return Value
Microsoft.MediaCenter.UI.Inset.  The result of the subtraction.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Inset Structure
# Inset.Subtraction Operator
Subtracts one Inset structure from another.
Syntax
public static Inset operator-(
  Inset  left,
  Inset  right
);

Parameters
left
Microsoft.MediaCenter.UI.Inset.  The first structure.
right
Microsoft.MediaCenter.UI.Inset.  The structure to subtract.
Return Value
Microsoft.MediaCenter.UI.Inset.  The result of the subtraction.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Inset Structure
# Inset.Top Property
Gets or sets the length of the top side of the inset.
Syntax
public int Top {get; set;}

Property Value
System.Int32.  The value of the top side of the inset.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Inset Structure
# Inset.ToString Method
Converts this structure to a human-readable string.
Syntax
public string ToString();

Return Value
System.String.  The string representation.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Inset Structure
# Inset.Zero Field
Represents a zero inset.
Syntax
public static readonly Microsoft.MediaCenter.UI.Inset Zero;

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
See Also
•	Inset Structure

# IntRangedValue Class
Defines an integer value within a minimum and maximum range.
public class IntRangedValue : RangedValue

Public Instance Constructors
Constructor	Description
IntRangedValue()
Initializes a new instance of the IntRangedValue class.
IntRangedValue(IModelItemOwner)
Initializes a new instance of the IntRangedValue class.
IntRangedValue(IModelItemOwner, string)	Initializes a new instance of the IntRangedValue class.

Public Instance Properties
Property	Description
MaxValue
Gets or sets the maximum value of the range.
MinValue
Gets or sets the minimum value of the range.
Step
Gets or sets the value of the increment or decrement value when the NextValue or PreviousValue methods are called.

Value
Gets or sets the current value.

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
# IntRangedValue Constructor
Initializes a new instance of the IntRangedValue class.
Overload List
public IntRangedValue()
public IntRangedValue(IModelItemOwner)
public IntRangedValue(IModelItemOwner, string)
# IntRangedValue.IntRangedValue Constructor
Initializes a new instance of the IntRangedValue class.
public IntRangedValue();

# IntRangedValue.IntRangedValue Constructor
Initializes a new instance of the IntRangedValue class.
public IntRangedValue(
  IModelItemOwner  owner
);

Parameters
owner
Microsoft.MediaCenter.UI.IModelItemOwner.  The owner of the ModelItem.
# IntRangedValue.IntRangedValue Constructor
Initializes a new instance of the IntRangedValue class.
public IntRangedValue(
  IModelItemOwner  owner,
  string  description
);

Parameters
owner
Microsoft.MediaCenter.UI.IModelItemOwner.  The owner of the ModelItem.
description
System.String.  The description of the object.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IntRangedValue Class
# IntRangedValue.MaxValue Property
Gets or sets the maximum value of the range.
Syntax
public int MaxValue {get; set;}

Property Value
System.Int32.  The maximum value allowed.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IntRangedValue Class
# IntRangedValue.MinValue Property
Gets or sets the minimum value of the range.
Syntax
public int MinValue {get; set;}

Property Value
System.Int32.  The minimum value allowed.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IntRangedValue Class
# IntRangedValue.Step Property
Gets or sets the value of the increment or decrement value when the NextValue or PreviousValue methods are called.
Syntax
public int Step {get; set;}

Property Value
System.Int32.  The value of the increment or decrement.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IntRangedValue Class
•	Microsoft.MediaCenter.UI Namespace

# IntRangedValue.Value Property
Gets or sets the current value.
Syntax
public int Value {get; set;}

Property Value
System.Int32.  The current value.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IntRangedValue Class
# InvokePolicy Enumeration
Specifies the ways in which a call can be invoked.
public enum InvokePolicy

The InvokePolicy enumeration defines the following constants:
Constant	Description
AsynchronousLowPri	Invoke asynchronously at low priority.
AsynchronousNormal	Invoke asynchronously at normal priority.
Synchronous	Invoke synchronously.

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
# IPropertyObject Interface
Provides a mechanism for receiving property-change notifications.
public interface IPropertyObject

Public Instance Events
Event	Description
PropertyChanged
Raised when a property has changed.

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
# IPropertyObject.PropertyChanged Event
Raised when a property has changed.
Syntax
public event Microsoft.MediaCenter.UI.PropertyChangedEventHandler PropertyChanged;

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IPropertyObject Interface
# ItemCountHandler Delegate
Represents a delayed callback method that queries the count so that the count does not need to be specified when the VirtualList object is created.
Syntax
public delegate void ItemCountHandler(
  VirtualList  list
);

Parameters
list
Microsoft.MediaCenter.UI.VirtualList.  The virtual list that is requesting the VirtualList.Count property to be set.
Remarks
To use this delegate, pass an instance of it to the VirtualList constructor, and then your callback should set the count before returning.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace

# ItemRequestCallback Delegate
Represents a callback method that is invoked in response to a VirtualList item query after the data item is available.
Syntax
public delegate void ItemRequestCallback(
  object  sender,
  int  index,
  object  item
);

Parameters
sender
System.Object.   The object on which the OnRequestItem callback was invoked.
index
System.Int32.  The index of the data item.
item
System.Object.  The data item object that is provided in response to the VirtualList request.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace

# ITransformer Interface
Creates a data transformation object.
public interface ITransformer

Public Instance Methods
Method	Description
Transform
Applies a transform to the specified object.

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
# ITransformer.Transform Method
Applies a transform to the specified object.
Syntax
public object Transform(
  object  value
);

Parameters
value
System.Object.  The object to convert.
Return Value
System.Object.  The result of the conversion.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ITransformer Interface
# ITransformerEx Interface
Creates a data transformation object that allows you to first apply a pretransformation object to the target.
public interface ITransformerEx : ITransformer

Public Instance Methods
Method	Description
PreTransform
Calls your pretransformation function with the current value of the transformation target before calling the transform function.

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
# ITransformerEx.PreTransform Method
Calls your pretransformation function with the current value of the transformation target before calling the transform function.
Syntax
public void PreTransform(
  object  oldValue
);

Parameters
oldValue
System.Object.  The current value of the transformation target.
Remarks
The PreTransform method is called on the value of the target. Then, the ITransformer.Transform method is called on a source value, and the return value is stored in the target.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ITransformerEx Interface
# IValueRange Interface
Provides base functionality for a value set.
public interface IValueRange : IModelItem, IPropertyObject, IModelItemOwner

Public Instance Methods
Method	Description
NextValue
Increases the value by one increment.
PreviousValue
Decreases the value by one decrement.

Public Instance Properties
Property	Description
HasNextValue
Gets a value that indicates whether a call to the NextValue method will succeed.

HasPreviousValue
Gets a value that indicates whether a call to the PreviousValue method will succeed.
Value
Gets the current value.

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Choice Class
•	Microsoft.MediaCenter.UI Namespace
•	RangedValue Class
# IValueRange.HasNextValue Property
Gets a value that indicates whether a call to the NextValue method will succeed.
Syntax
public bool HasNextValue {get;}

Property Value
System.Boolean.  true if there is a next value; otherwise, false.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IValueRange Interface
•	IValueRange.NextValue Method
# IValueRange.HasPreviousValue Property
Gets a value that indicates whether a call to the PreviousValue method will succeed.
Syntax
public bool HasPreviousValue {get;}

Property Value
System.Boolean.  true if there is a previous value; otherwise, false.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IValueRange Interface
•	IValueRange.PreviousValue Method
# IValueRange.NextValue Method
Increases the value by one increment.
Syntax
public void NextValue();

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IValueRange Interface
# IValueRange.PreviousValue Method
Decreases the value by one decrement.
Syntax
public void PreviousValue();

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IValueRange Interface
# IValueRange.Value Property
Gets the current value.
Syntax
public object Value {get;}

Property Value
System.Object.  The current value.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	IValueRange Interface
# ListDataSet Class
Creates a collection of data that can change and be manipulated. This class wraps an IList and sends notifications when its contents have changed.
public class ListDataSet : ModelItem, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable

Public Instance Constructors
Constructor	Description
ListDataSet(IList)
Initializes a new instance of the ListDataSet class.
ListDataSet(IModelItemOwner, IList)
Initializes a new instance of the ListDataSet class.

Protected Instance Constructors
Constructor	Description
ListDataSet()
Initializes a new instance of the ListDataSet class.

Public Instance Methods
Method	Description
Add
Adds an item to the end of the ListDataSet.
Clear
Clears all ListDataSet entries.
Contains
Determines whether a given item is in the ListDataSet.
CopyFrom
Copies the contents of an IEnumerable object into this ListDataSet.
CopyTo
Copies the contents of this ListDataSet to an array.
GetEnumerator
Retrieves an IEnumerator object for this ListDataSet.
IndexOf
Returns the index of a specific item in the ListDataSet.
Insert
Inserts an item into the ListDataSet.
Move
Moves an item to a different location within the ListDataSet.
Remove
Removes the specified item from the ListDataSet.
RemoveAt
Removes an item at a specified index from the ListDataSet.
Sort
Sorts the ListDataSet.

Public Instance Properties
Property	Description
Count
Gets the number of items in the ListDataSet.
IsFixedSize
Gets a value that indicates whether the ListDataSet has a fixed size.
IsReadOnly
Gets a value that indicates whether the ListDataSet is read-only.
IsSynchronized
Gets a value that indicates whether the ListDataSet is thread-safe.
Item
Gets or sets an item in the ListDataSet.
Source
Gets or sets the list that is used to populate the ListDataSet.
SyncRoot
Gets the object to use to synchronize access to the current ListDataSet.

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Repeater Element
# ListDataSet Constructor
Initializes a new instance of the ListDataSet class.
Overload List
public ListDataSet(IList)
public ListDataSet(IModelItemOwner, IList)
protected ListDataSet()
# ListDataSet.ListDataSet Constructor
Initializes a new instance of the ListDataSet class.
public ListDataSet(
  System.Collections.IList  source
);

Parameters
source
System.Collections.IList.  A list of items to add to the data set.
# ListDataSet.ListDataSet Constructor
Initializes a new instance of the ListDataSet class.
public ListDataSet(
  IModelItemOwner  owner,
  System.Collections.IList  source
);

Parameters
source
System.Collections.IList.  A list of items to add to the data set.
owner
Microsoft.MediaCenter.UI.IModelItemOwner.  The owner of the ModelItem.
# ListDataSet.ListDataSet Constructor
Initializes a new instance of the ListDataSet class.
protected ListDataSet();

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ListDataSet Class
# ListDataSet.Add Method
Adds an item to the end of the ListDataSet.
Syntax
public int Add(
  object  item
);

Parameters
item
System.Object.  The object to append.
Return Value
System.Int32.  The index of the new item.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ListDataSet Class
# ListDataSet.Clear Method
Clears all ListDataSet entries.
Syntax
public void Clear();

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ListDataSet Class
# ListDataSet.Contains Method
Determines whether a given item is in the ListDataSet.
Syntax
public bool Contains(
  object  item
);

Parameters
item
System.Object.  The object to search for.
Return Value
System.Boolean.  true if the item is in the list; otherwise, false.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ListDataSet Class
# ListDataSet.CopyFrom Method
Copies the contents of an IEnumerable object into this ListDataSet.
Syntax
public void CopyFrom(
  System.Collections.IEnumerable  source
);

Parameters
source
System.Collections.IEnumerable.  The source enumeration to copy from.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ListDataSet Class
# ListDataSet.CopyTo Method
Copies the contents of this ListDataSet class to an array.
Syntax
public void CopyTo(
  Array  array,
  int  index
);

Parameters
array
System.Array.  The source array.
index
System.Int32.  The starting index that indicates where to copy the array.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ListDataSet Class
# ListDataSet.Count Property
Gets the number of items in the ListDataSet.
Syntax
public int Count {get;}

Property Value
System.Int32.  The count of items.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ListDataSet Class
# ListDataSet.GetEnumerator Method
Gets an IEnumerator object for this ListDataSet collection.
Syntax
public System.Collections.IEnumerator GetEnumerator();

Return Value
System.Collections.IEnumerator.  The enumerator.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ListDataSet Class
# ListDataSet.IndexOf Method
Returns the index of a specific item in the ListDataSet.
Syntax
public int IndexOf(
  object  item
);

Parameters
item
System.Object.  The object to search for.
Return Value
System.Int32.  The item index.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ListDataSet Class
# ListDataSet.Insert Method
Inserts an item into the ListDataSet.
Syntax
public void Insert(
  int  index,
  object  item
);

Parameters
index
System.Int32.  The index at which to insert the item.
item
System.Object.  The object to insert into the list.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ListDataSet Class
# ListDataSet.IsFixedSize Property
Gets a value that indicates whether the list has a fixed size.
Syntax
public bool IsFixedSize {get;}

Property Value
System.Boolean.  true if it has a fixed size; otherwise, false.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ListDataSet Class
# ListDataSet.IsReadOnly Property
Gets a value that indicates whether the ListDataSet is read-only.
Syntax
public bool IsReadOnly {get;}

Property Value
System.Boolean.  true if the list is read-only; otherwise, false.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ListDataSet Class
# ListDataSet.IsSynchronized Property
Gets a value that indicates whether the ListDataSet is thread-safe.
Syntax
public bool IsSynchronized {get;}

Property Value
System.Boolean.  true if the list is thread-safe; otherwise, false.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ListDataSet Class
# ListDataSet.Item Property
Gets or sets an item in the ListDataSet.
Syntax
public object Item[int] {get; set;}

Property Value
System.Object.  The item from the data set.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ListDataSet Class
# ListDataSet.Move Method
Moves an item to a different location within the ListDataSet.
Syntax
public void Move(
  int  oldIndex,
  int  newIndex
);

Parameters
oldIndex
System.Int32.  The index to move from.
newIndex
System.Int32.  The index to move to.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ListDataSet Class
# ListDataSet.Remove Method
Removes the specified item from the ListDataSet.
Syntax
public void Remove(
  object  item
);

Parameters
item
System.Object.  The object to remove.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ListDataSet Class
# ListDataSet.RemoveAt Method
Removes an item at a specified index from the ListDataSet.
Syntax
public void RemoveAt(
  int  index
);

Parameters
index
System.Int32.  The index of the object to remove.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ListDataSet Class
# ListDataSet.Sort Method
Sorts the ListDataSet.
Overload List
public void Sort(
  System.Collections.IComparer  comparer
);
public void Sort();

Parameters
comparer
System.Collections.IComparer.  IComparer object to use to compare the objects in the list.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ListDataSet Class
# ListDataSet.Source Property
Gets or sets the list that is used to populate the ListDataSet.
Syntax
public System.Collections.IList Source {get; set;}

Property Value
System.Collections.IList.  The list of data items.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ListDataSet Class
# ListDataSet.SyncRoot Property
Gets the object to use to synchronize access to the current ListDataSet.
Syntax
public object SyncRoot {get;}

Property Value
System.Object.  The object to synchronize access.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ListDataSet Class
# LoadResult Class
Provides status when loading markup.
public abstract class LoadResult

Public Instance Methods
Method	Description
ToString
Converts the object to a human-readable string.

Public Instance Properties
Property	Description
Errors
Gets a list of error strings if the load operation did not succeed.
Status
Gets the current load status.
Uri
Gets the Uniform Resource Identifier (URI) of the resource that was loaded.

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
# LoadResult.Errors Property
Gets a list of error strings if the load operation did not succeed.
Syntax
public System.Collections.IList Errors {get;}

Property Value
System.Collections.IList.  The list of error strings.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	LoadResult Class
# LoadResult.Status Property
Gets the current load status.
Syntax
public LoadResultStatus Status {get;}

Property Value
Microsoft.MediaCenter.UI.LoadResultStatus.  The status of the load operation.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	LoadResult Class
# LoadResult.ToString Method
Converts the LoadResult object to a human-readable string.
Syntax
public string ToString();

Return Value
System.String.  The string representation.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	LoadResult Class
# LoadResult.Uri Property
Gets the Uniform Resource Identifier (URI) of the resource that was loaded.
Syntax
public string Uri {get;}

Property Value
System.String.  The URI.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	LoadResult Class
# LoadResultStatus Enumeration
Contains the types of status when loading markup.
public enum LoadResultStatus

The LoadResultStatus enumeration defines the following constants:
Constant	Description
Error	There were errors when the markup was loaded.
Loading	The markup is loading.
Success	The markup was loaded without errors.

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
# MarkupVisibleAttribute Class
Defines an attribute to apply to non-public members that may be accessible from markup.
public class MarkupVisibleAttribute : Attribute

Public Instance Constructors
Constructor	Description
MarkupVisibleAttribute
Initializes a new instance of the MarkupVisibleAttribute class.

Remarks
Public members do not need this attribute.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
# MarkupVisibleAttribute Constructor
Initializes a new instance of the MarkupVisibleAttribute class.
Syntax
public MarkupVisibleAttribute();

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	MarkupVisibleAttribute Class
# McmlLoadResult Class
Provides status when loading a Windows Media Center Markup Language (MCML) resource.
public class McmlLoadResult : LoadResult

Public Instance Methods
Method	Description
BuildGlobal
Builds a new instance of a global object (if one exists) from the Global library.
GetColor
Gets a shared color (if one exists) from the Color library.
GetGlobal
Gets a shared global object (if one exists) from the Global library.
GetImage
Gets a shared image (if one exists) from the Image library.
GetSound
Gets a shared sound (if one exists) from the Sound library.

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
# McmlLoadResult.BuildGlobal Method
Builds a new instance of a global object (if one exists) from the Global library.
Syntax
public object BuildGlobal(
  string  name
);

Parameters
name
System.String.  The name of the markup resource.
Return Value
System.Object.  The resulting global object.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	McmlLoadResult Class
# McmlLoadResult.GetColor Method
Gets a shared color (if one exists) from the Color library.
Syntax
public Color GetColor(
  string  name
);

Parameters
name
System.String.  The name of the markup resource.
Return Value
Microsoft.MediaCenter.UI.Color.  The shared color.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	McmlLoadResult Class
# McmlLoadResult.GetGlobal Method
Gets a shared global object (if one exists) from the Global library.
Syntax
public object GetGlobal(
  string  name
);

Parameters
name
System.String.  The name of the markup resource.
Return Value
System.Object.  The shared global object.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	McmlLoadResult Class
# McmlLoadResult.GetImage Method
Gets a shared image (if one exists) from the Image library.
Syntax
public Image GetImage(
  string  name
);

Parameters
name
System.String.  The name of the markup resource.
Return Value
Microsoft.MediaCenter.UI.Image.  The shared image.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	McmlLoadResult Class
# McmlLoadResult.GetSound Method
Gets a shared sound (if one exists) from the Sound library.
Syntax
public Sound GetSound(
  string  name
);

Parameters
name
System.String.  Name of the markup resource
Return Value
Microsoft.MediaCenter.UI.Sound.  The shared sound.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	McmlLoadResult Class
# ModelItem Class
Represents the main base object in which the model (code and data) is created. The objects that own the ModelItem object is responsible for disposing of it.
public class ModelItem : IModelItem, IPropertyObject, IModelItemOwner, IDisposable

Public Instance Constructors
Constructor	Description
ModelItem()
Initializes a new instance of the ModelItem class.
ModelItem(IModelItemOwner)
Initializes a new instance of the ModelItem class.
ModelItem(IModelItemOwner, string)
Initializes a new instance of the ModelItem class.

Public Instance Methods
Method	Description
BindFromSource
Creates a binding from a source object.
BindToTarget
Creates a binding to a target.
Dispose
Disposes the ModelItem object, optionally unregistering it from its owner beforehand.
ToString
Converts the object to a human-readable string.
TwoWayBind
Creates a two-way binding.

Protected Instance Methods
Method	Description
Dispose
Releases all the resources used by ModelItem.
FirePropertyChanged
Raises the PropertyChanged event for a property that has changed.
OnOwnerChanged
Notifies derived classes when the owner changes.
OnPropertyChanged
Notifies derived classes when a property changes.
RaiseEvent
Not documented in this release.

Public Instance Properties
Property	Description
Data
Gets the data for the ModelItem object.

Description
Gets or sets the description of the current ModelItem object.

IsDisposed
Gets a value that indicates whether the ModelItem object is disposed.

Owner
Gets or sets the owner of the ModelItem object. The owner is responsible for disposing this object.
Selected
Gets a value that indicates whether the ModelItem object is selected.

UniqueId
Gets or sets the unique identifier of this ModelItem object.


Public Instance Events
Event	Description
PropertyChanged
Raised when a property has changed.

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
# ModelItem Constructor
Initializes a new instance of the ModelItem class.
Overload List
public ModelItem()
public ModelItem(IModelItemOwner)
public ModelItem(IModelItemOwner, string)
# ModelItem.ModelItem Constructor
Initializes a new instance of the ModelItem class.
public ModelItem();

# ModelItem.ModelItem Constructor
Initializes a new instance of the ModelItem class.
public ModelItem(
  IModelItemOwner  owner
);

Parameters
owner
Microsoft.MediaCenter.UI.IModelItemOwner.  The owner of the ModelItem.
# ModelItem.ModelItem Constructor
Initializes a new instance of the ModelItem class.
public ModelItem(
  IModelItemOwner  owner,
  string  description
);

Parameters
owner
Microsoft.MediaCenter.UI.IModelItemOwner.  The owner of the ModelItem.
description
System.String.  The description of the object.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ModelItem Class
# ModelItem.BindFromSource Method
Creates a binding from a source object.
Overload List
public void BindFromSource(
  IPropertyObject  source,
  string  sourceProperty,
  string  property
);
public void BindFromSource(
  ObjectPropertyPair  source,
  string  property
);
public void BindFromSource(
  ObjectPropertyPair  source,
  ITransformer  transformer,
  string  property
);
public void BindFromSource(
  IPropertyObject  source,
  string  sourceProperty,
  ITransformer  transformer,
  string  property
);

Parameters
source
Microsoft.MediaCenter.UI.IPropertyObject.  The source object.
sourceProperty
System.String.  The source property.
property
System.String.  The local (target) property.
transformer
Microsoft.MediaCenter.UI.ITransformer.  The transform object.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ModelItem Class
# ModelItem.BindToTarget Method
Creates a binding to a target.
Overload List
public void BindToTarget(
  object  target,
  string  targetProperty,
  string  property
);
public void BindToTarget(
  ObjectPropertyPair  target,
  string  property
);
public void BindToTarget(
  ObjectPropertyPair  target,
  ITransformer  transformer,
  string  property
);
public void BindToTarget(
  object  target,
  string  targetProperty,
  ITransformer  transformer,
  string  property
);

Parameters
target
System.Object.  The target object.
targetProperty
System.String.  The remote property.
property
System.String.  The local (source) property.
transformer
Microsoft.MediaCenter.UI.ITransformer.  The transform object.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ModelItem Class
# ModelItem.Data Property
Gets the data for the ModelItem object.
Syntax
public System.Collections.IDictionary Data {get;}

Property Value
System.Collections.IDictionary.  The data for the ModelItem.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ModelItem Class
# ModelItem.Description Property
Gets or sets the description of the current ModelItem object.
Syntax
public string Description {get; set;}

Property Value
System.String.  The description.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ModelItem Class
# ModelItem.Dispose Method
Releases all the resources used by the ModelItem object, optionally unregistering it from its owner beforehand.
Overload List
public void Dispose();
public void Dispose(
  ModelItemDisposeMode  disposeMode
);
protected void Dispose(
  bool  disposing
);

Parameters
disposeMode
Microsoft.MediaCenter.UI.ModelItemDisposeMode.  The owner unregistration option.
disposing
System.Boolean.  true if the origin of the call is the Dispose method; otherwise, false.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ModelItem Class
# ModelItem.FirePropertyChanged Method
Raises the ModelItem.PropertyChanged event for a property that has changed.
Syntax
protected void FirePropertyChanged(
  string  property
);

Parameters
property
System.String.  The name of the property that changed.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ModelItem Class
# ModelItem.IsDisposed Property
Gets a value that indicates whether the ModelItem object is disposed.
Syntax
public bool IsDisposed {get;}

Property Value
System.Boolean.  true if the ModelItem.Dispose method was called on this object; otherwise, false.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ModelItem Class
# ModelItem.OnOwnerChanged Method
Notifies derived classes when the owner changes.
Syntax
protected void OnOwnerChanged(
  IModelItemOwner  newOwner,
  IModelItemOwner  oldOwner
);

Parameters
newOwner
Microsoft.MediaCenter.UI.IModelItemOwner.  The new owner.
oldOwner
Microsoft.MediaCenter.UI.IModelItemOwner.  The previous owner.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ModelItem Class
# ModelItem.OnPropertyChanged Method
Notifies derived classes when a property changes.
Syntax
protected void OnPropertyChanged(
  string  property
);

Parameters
property
System.String.  The name of the property.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ModelItem Class
# ModelItem.Owner Property
Gets or sets the owner of the ModelItem object . The owner is responsible for disposing this object.
Syntax
public IModelItemOwner Owner {get; set;}

Property Value
Microsoft.MediaCenter.UI.IModelItemOwner.  The owner of the ModelItem.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ModelItem Class
# ModelItem.PropertyChanged Event
Raised when a property has changed.
Syntax
public event Microsoft.MediaCenter.UI.PropertyChangedEventHandler PropertyChanged;

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ModelItem Class
# ModelItem.RaiseEvent Method
Not documented in this release.
Overload List
protected void RaiseEvent(
  System.EventHandler handler,
  string propertyName
)

protected void RaiseEvent<T>(
  T value,
  System.EventHandler<EventArgs<T>> handler,
  string propertyName
)
protected void RaiseEvent<T0, T1, T2, T3>(
  T0 param0,
  T1 param1,
  T2 param2,
  T3 param3,
  System.EventHandler<EventArgs<T0,T1,T2,T3>> handler,
  string propertyName
)
protected void RaiseEvent<T0, T1, T2>(
  T0 param0,
  T1 param1,
  T2 param2,
  System.EventHandler<EventArgs<T0,T1,T2>> handler,
  string propertyName
)
protected void RaiseEvent<T0, T1>(
  T0 param0,
  T1 param1,
  System.EventHandler<EventArgs<T0,T1>> handler,
  string propertyName
)

Parameters
propertyName
string  Not documented in this release.
handler
System.EventHandler  Not documented in this release.
handler
System.EventHandler<EventArgs<T>>  Not documented in this release.
handler
System.EventHandler<EventArgs<T0,T1>>  Not documented in this release.
handler
System.EventHandler<EventArgs<T0,T1,T2>>  Not documented in this release.
handler
System.EventHandler<EventArgs<T0,T1,T2,T3>>  Not documented in this release.
value
T  Not documented in this release.
param0
T0  Not documented in this release.
param1
T1  Not documented in this release.
param2
T2  Not documented in this release.
param3
T3  Not documented in this release.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ModelItem Class
# ModelItem.Selected Property
Gets a value that indicates whether the ModelItem object is selected.
Syntax
public bool Selected {get; set;}

Property Value
System.Boolean.  true if selected; otherwise, false.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ModelItem Class
# ModelItem.ToString Method
Converts the object to a human-readable string.
Syntax
public string ToString();

Return Value
System.String.  The string representation.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ModelItem Class
# ModelItem.TwoWayBind Method
Creates a two-way binding.
Overload List
public void TwoWayBind(
  IPropertyObject  remote,
  string  remoteProperty,
  string  property
);
public void TwoWayBind(
  ObjectPropertyPair  remote,
  string  property
);
public void TwoWayBind(
  ObjectPropertyPair  remote,
  ITransformer  forwardTransformer,
  ITransformer  reverseTransformer,
  string  property
);
public void TwoWayBind(
  IPropertyObject  remote,
  string  remoteProperty,
  ITransformer  forwardTransformer,
  ITransformer  reverseTransformer,
  string  property
);

Parameters
remote
Microsoft.MediaCenter.UI.IPropertyObject.  The remote object or property.
remoteProperty
System.String.  The remote property.
property
System.String.  The local property.
forwardTransformer
Microsoft.MediaCenter.UI.ITransformer.  The forward transformation.
reverseTransformer
Microsoft.MediaCenter.UI.ITransformer.  The reverse transformation.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ModelItem Class
# ModelItem.UniqueId Property
Gets or sets the unique identifier of this ModelItem object.
Syntax
public Guid UniqueId {get; set;}

Property Value
System.Guid.  A GUID that is used as the unique identifier.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ModelItem Class
# ModelItemDisposeMode Enumeration
Contains options for disposing of a ModelItem object.
public enum ModelItemDisposeMode

The ModelItemDisposeMode enumeration defines the following constants:
Constant	Description
KeepOwnerReference	The ModelItem object should not remove the reference to itself from its owner.
This option is typically used as an optimization as owners clear disposal lists.
RemoveOwnerReference	The ModelItem object should remove the reference to itself from its owner.

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
# ObjectPropertyPair Class
Groups objects and properties.
public class ObjectPropertyPair

Public Instance Constructors
Method	Description
ObjectPropertyPair
Initializes a new instance of the ObjectPropertyPair class.

Public Instance Properties
Property	Description
Object
Gets the object reference.
PropertyName
Gets the property name.

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
# ObjectPropertyPair Constructor
Initializes a new instance of the ObjectPropertyPair class.
Syntax
public ObjectPropertyPair(
  object  obj,
  string  property
);

Parameters
obj
System.Object.  An object reference.
property
System.String.  A property name.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ObjectPropertyPair Class
# ObjectPropertyPair.Object Property
Gets the object reference.
Syntax
public object Object {get;}

Property Value
System.Object.  A reference to the object.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ObjectPropertyPair Class
# ObjectPropertyPair.PropertyName Property
Gets the property name.
Syntax
public string PropertyName {get;}

Property Value
System.String.  The property name.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ObjectPropertyPair Class
# Point Structure
Defines a point.
public struct Point

Public Instance Constructors
Method	Description
Point
Initializes a new instance of the Point structure.

Public Static Methods
Method	Description
Add
Combines two Point structures.
Subtract
Subtracts one Point structure from another.

Public Instance Methods
Method	Description
Equals
Tests whether the specified object is a Point structure and is equivalent to the current Point structure.
GetHashCode
Returns a hash code for this structure.
ToString
Converts this structure to a human-readable string.

Public Operators
Operator	Description
Addition
Combines two Point structures.
Equality
Tests whether two specified Point structures are equivalent.
Inequality
Tests whether two Point structures are different.
Subtraction
Subtracts one Point structure from another.

Public Static Fields
Field	Description
Zero
Represents a zero point.

Public Instance Properties
Property	Description
X
Gets or sets the value of point X.
Y
Gets or sets the value of point Y.

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Microsoft.MediaCenter.UI Namespace

# Point Constructor
Initializes a new instance of the Point structure.
Syntax
public Point(
  int  x,
  int  y
);

Parameters
x
System.Int32.  Specifies point x.
y
System.Int32.  Specifies point y.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Point Structure

# Point.Add Method
Combines two Point structures.
Syntax
public static Point Add(
  Point  left,
  Point  right
);

Parameters
left
Microsoft.MediaCenter.UI.Point.  The first structure.
right
Microsoft.MediaCenter.UI.Point.  The second structure.
Return Value
Microsoft.MediaCenter.UI.Point.  The result of the addition.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Point Structure

# Point.Addition Operator
Combines two Point structures.
Syntax
public static Point operator+(
  Point  left,
  Point  right
);

Parameters
left
Microsoft.MediaCenter.UI.Point.  The first structure.
right
Microsoft.MediaCenter.UI.Point.  The second structure.
Return Value
Microsoft.MediaCenter.UI.Point.  The result of the addition.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Point Structure

# Point.Equality Operator
Tests whether two specified Point structures are equivalent.
Syntax
public static bool operator==(
  Point  left,
  Point  right
);

Parameters
left
Microsoft.MediaCenter.UI.Point.  The Point structure that is to the left of the equality operator.
right
Microsoft.MediaCenter.UI.Point.  The Point structure that is to the right of the equality operator.
Return Value
System.Boolean.  true if these structures are equal; otherwise, false.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Point Structure

# Point.Equals Method
Tests whether the specified object is a Point structure and is equivalent to the current Point structure.
Syntax
public virtual bool Equals(
  object  obj
);

Parameters
obj
System.Object.  The object to test.
Return Value
System.Boolean.  true if the structures are equal; otherwise, false.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Point Structure

# Point.GetHashCode Method
Returns a hash code for this structure.
Syntax
public virtual int GetHashCode();

Return Value
System.Int32.  The hash code.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Point Structure

# Point.Inequality Operator
Tests whether two Point structures are different.
Syntax
public static bool operator!=(
  Point  left,
  Point  right
);

Parameters
left
Microsoft.MediaCenter.UI.Point.  The Point structure that is to the left of the inequality operator.
right
Microsoft.MediaCenter.UI.Point.  The Point structure that is to the right of the inequality operator.
Return Value
System.Boolean.  true if the structures are not equal; otherwise false.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Point Structure

# Point.Offset Method
Offsets a Point structure by specified X and Y values.
Syntax
public static Point Offset(
  Point  point,
  int  x,
  int  y
);

Parameters
point
Microsoft.MediaCenter.UI.Point.  The Point structure to offset.
x
System.Int32.  Specifies the X offset.
y
System.Int32.  Specifies the Y offset.
Return Value
Microsoft.MediaCenter.UI.Point.  The resulting Point structure.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Point Structure

# Point.Subtract Method
Subtracts one Point structure from another.
Syntax
public static Point Subtract(
  Point  left,
  Point  right
);

Parameters
left
Microsoft.MediaCenter.UI.Point.  The first structure.
right
Microsoft.MediaCenter.UI.Point.  The structure to subtract.
Return Value
Microsoft.MediaCenter.UI.Point.  The result of the subtraction.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Point Structure

# Point.Subtraction Operator
Subtracts one Point structure from another.
Syntax
public static Point operator-(
  Point  left,
  Point  right
);

Parameters
left
Microsoft.MediaCenter.UI.Point.  The first structure.
right
Microsoft.MediaCenter.UI.Point.  The structure to subtract.
Return Value
Microsoft.MediaCenter.UI.Point.  The result of the subtraction.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Point Structure

# Point.ToString Method
Converts this Point structure to a human-readable string.
Syntax
public virtual string ToString();

Return Value
System.String.  The string representation.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Point Structure

# Point.X Property
Gets or sets the value of point X.
Syntax
public int X {get; set;}

Property Value
System.Int32.  The value of point X.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Point Structure

# Point.Y Property
Gets or sets the value of point Y.
Syntax
public int Y {get; set;}

Property Value
System.Int32.  The value of point Y.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Point Structure

# Point.Zero Field
Represents a zero point.
Syntax
public static readonly Point Zero;

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Point Structure

# PropertyChangedEventHandler Delegate
Represents the method that handles the property changes in the IPropertyObject object.
Syntax
public delegate void PropertyChangedEventHandler(
  IPropertyObject  sender,
  string  property
);

Parameters
sender
Microsoft.MediaCenter.UI.IPropertyObject.  The object whose property has changed.
property
System.String.  The name of the property that has changed.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace

# PropertySet Class
Defines an arbitrary collection of property values, and raises property change notifications when you add, remove, and modify property values.
public class PropertySet : ModelItem, System.Collections.IDictionary, System.Collections.ICollection, System.Collections.IEnumerable

Public Instance Constructors
Constructor	Description
PropertySet()
Initializes a new instance of the PropertySet class.
PropertySet(IModelItemOwner)
Initializes a new instance of the PropertySet class.
PropertySet(IModelItemOwner, string)
Initializes a new instance of the PropertySet class.

Public Instance Properties
Property	Description
Entries
Gets the set of properties and their values.

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace

# PropertySet Constructor
Initializes a new instance of the PropertySet class.
Overload List
public PropertySet()
public PropertySet(IModelItemOwner)
public PropertySet(IModelItemOwner, string)
# PropertySet.PropertySet Constructor
Initializes a new instance of the PropertySet class.
public PropertySet();

# PropertySet.PropertySet Constructor
Initializes a new instance of the PropertySet class.
public PropertySet(
  IModelItemOwner  owner
);

Parameters
owner
Microsoft.MediaCenter.UI.IModelItemOwner.  The owner of the ModelItem.
# PropertySet.PropertySet Constructor
Initializes a new instance of the PropertySet class.
public PropertySet(
  IModelItemOwner  owner,
  string  description
);

Parameters
owner
Microsoft.MediaCenter.UI.IModelItemOwner.  The owner of the ModelItem.
description
System.String.  The description of the object.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	PropertySet Class

# PropertySet.Entries Property
Gets the set of properties and their values.
Syntax
public System.Collections.IDictionary Entries {get;}

Property Value
System.Collections.IDictionary.  The list of properties and values.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	PropertySet Class

# RangedValue Class
Defines a value within a minimum and maximum range.
public class RangedValue : ModelItem, IValueRange, IModelItem, IPropertyObject, IModelItemOwner

Public Instance Constructors
Constructor	Description
RangedValue()
Initializes a new instance of the RangedValue class.
RangedValue(IModelItemOwner)
Initializes a new instance of the RangedValue class.
RangedValue(IModelItemOwner, string)
Initializes a new instance of the RangedValue class.

Public Instance Methods
Method	Description
NextValue
Increases the value by one increment.
PreviousValue
Decreases the value by one decrement.

Public Instance Properties
Property	Description
HasNextValue
Gets a value that indicates whether a call to the NextValue method will succeed.
HasPreviousValue
Gets a value that indicates whether a call to the PreviousValue method will succeed.
MaxValue
Gets or sets the maximum value of the range.
MinValue
Gets or sets the minimum value of the range.
Range
Gets the length of the range.
Step
Gets or sets the value of the increment or decrement value when the NextValue or PreviousValue methods are called.
Value
Gets or sets the current value.

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
# RangedValue Constructor
Initializes a new instance of the RangedValue class.
Overload List
public RangedValue()
public RangedValue(IModelItemOwner)
public RangedValue(IModelItemOwner, string)
# RangedValue.RangedValue Constructor
Initializes a new instance of the RangedValue class.
public RangedValue();

# RangedValue.RangedValue Constructor
Initializes a new instance of the RangedValue class.
public RangedValue(
  IModelItemOwner  owner
);

Parameters
owner
Microsoft.MediaCenter.UI.IModelItemOwner.  The owner of the ModelItem.
# RangedValue.RangedValue Constructor
Initializes a new instance of the RangedValue class.
public RangedValue(
  IModelItemOwner  owner,
  string  description
);

Parameters
owner
Microsoft.MediaCenter.UI.IModelItemOwner.  The owner of the ModelItem.
description
System.String.  The description of the object.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	RangedValue Class
# RangedValue.HasNextValue Property
Gets a value that indicates whether a call to the NextValue method will succeed.
Syntax
public bool HasNextValue {get;}

Property Value
System.Boolean.  true if there is a next value; otherwise, false.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	RangedValue Class
•	RangedValue.NextValue Method
# RangedValue.HasPreviousValue Property
Gets a value that indicates whether a call to the PreviousValue method will succeed.
Syntax
public bool HasPreviousValue {get;}

Property Value
System.Boolean.  true if there is a previous value; otherwise, false.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	RangedValue Class
•	RangedValue.PreviousValue Method
# RangedValue.MaxValue Property
Gets or sets the maximum value of the range.
Syntax
public float MaxValue {get; set;}

Property Value
System.Single.  The maximum value allowed.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	RangedValue Class
# RangedValue.MinValue Property
Gets or sets the minimum value of the range.
Syntax
public float MinValue {get; set;}

Property Value
System.Single.  The minimum value allowed.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	RangedValue Class
# RangedValue.NextValue Method
Increases the value by one increment.
Syntax
public void NextValue();

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	RangedValue Class
# RangedValue.PreviousValue Method
Decreases the value by one decrement.
Syntax
public void PreviousValue();

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	RangedValue Class
# RangedValue.Range Property
Gets the length of the range.
Syntax
public float Range {get;}

Property Value
System.Single.  The value indicating the length of the range of values.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	RangedValue Class
# RangedValue.Step Property
Gets or sets the value of the increment or decrement value when the NextValue or PreviousValue methods are called.
Syntax
public float Step {get; set;}

Property Value
System.Single.  The value of the increment or decrement.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	RangedValue Class
•	RangedValue.NextValue Method
•	RangedValue.PreviousValue Method
# RangedValue.Value Property
Gets or sets the current value.
Syntax
public float Value {get; set;}

Property Value
System.Single.  The current value.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	RangedValue Class
# ResourceGroup Class
Acquires a set of XML data from a Web service as a resource group. A resource group contains items for displaying a UI, such as a set of images, sounds, and text.
public class ResourceGroup : Microsoft.MediaCenter.UI.ModelItem

Public Instance Constructors
Method	Description
ResourceGroup()
Initializes a new instance of the ResourceGroup class.
ResourceGroup(owner)
Initializes a new instance of the ResourceGroup class.
ResourceGroup(owner, description)
Initializes a new instance of the ResourceGroup class.

Public Instance Methods
Method	Description
Acquire
Retrieves the objects that have been defined for the resource group.

Public Instance Properties
Property	Description
AcquisitionStatus
Indicates the status of the acquisition process.
Resources
Gets the objects in the resource group.


Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	Microsoft.MediaCenter.UI Namespace
•	Working with Resource Groups

# ResourceGroup Constructor
Initializes a new instance of the ResourceGroup class.
Overload List
public ResourceGroup()
public ResourceGroup(IModelItemOwner)
public ResourceGroup(IModelItemOwner, string)
# ResourceGroup.ResourceGroup Constructor
Initializes a new instance of the ResourceGroup class.
public ResourceGroup();

# ResourceGroup.ResourceGroup Constructor
Initializes a new instance of the ResourceGroup class.
public ResourceGroup(
  IModelItemOwner  owner
);

Parameters
owner
Microsoft.MediaCenter.UI.IModelItemOwner.  The owner of the ModelItem.
# ResourceGroup.ResourceGroup Constructor
Initializes a new instance of the ResourceGroup class.
public ResourceGroup(
  IModelItemOwner  owner,
  string  description
);

Parameters
owner
Microsoft.MediaCenter.UI.IModelItemOwner.  The owner of the ModelItem.
description
System.String.  The description of the object.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	ResourceGroup Class
•	Working with Resource Groups

# ResourceGroup.Acquire Method
Retrieves the objects that have been defined for the resource group.
Syntax
public void Acquire();

Remarks
Use the Resources property to specify the items in the resource group.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	ResourceGroup Class
•	Working with Resource Groups

# ResourceGroup.AcquisitionStatus Property
Gets a value that indicates the status of the acquisition process.
Syntax
public AcquisitionStatus AcquisitionStatus {get;}

Property Value
Microsoft.MediaCenter.UI.AcquisitionStatus.  A value that indicates the status of the acquisition process.
This property is read-only.
Remarks
This property returns Done only when all of the items in the resource group have been retrieved.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	ResourceGroup Class
•	Working with Resource Groups

# ResourceGroup.Resources Property
Gets the objects in the resource group.
Syntax
public System.Collections.IDictionary Resources {get;}

Property Value
System.Collections.IDictionary.  The resources that are part of the resource group.
This property is read-only.
Remarks
Use this property in the Locals section of a UI to specify the objects that are members of a resource group.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.DataAccess Namespace
•	ResourceGroup Class
•	Working with Resource Groups

# Rectangle Structure
Defines a rectangle.
public struct Rectangle

Public Instance Constructors
Method	Description
Rectangle(int, int, int, int)
Initializes a new instance of the Rectangle structure.
Rectangle(Point, Size)
Initializes a new instance of the Rectangle structure.

Public Operators
Operator	Description
Addition
Combines two Rectangle structures.
Equality
Tests whether two specified Rectangle structures are equivalent.
Inequality
Tests whether two Rectangle structures are different.
Subtraction
Subtracts one Rectangle structure from another.

Public Static Methods
Method	Description
Add
Combines two Rectangle structures.
Inflate
Increases the size of the Rectangle structure by specified X and Y values.
Intersect
Creates a Rectangle that is the intersection of two Rectangle structures.
Subtract
Subtracts one Rectangle structure from another.
Union
Creates a Rectangle structure that is the union of two Rectangle structures.

Public Instance Methods
Method	Description
Contains
Determines whether a Point is located within a given Rectangle structure.
Equals
Tests whether the specified object is a Rectangle structure and is equivalent to the current Rectangle structure.
GetHashCode
Returns a hash code for this structure.
ToString
Converts this structure to a human-readable string.

Public Static Fields
Field	Description
Zero
Represents a zero Rectangle structure.

Public Instance Properties
Property	Description
Height
Gets or sets the height of the rectangle.
Width
Gets or sets the width of the rectangle.
X
Gets or sets the X-value.
Y
Gets or sets the Y-value.

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Microsoft.MediaCenter.UI Namespace

# Rectangle Constructor
Initializes a new instance of the Rectangle structure.
Overload List
public Rectangle(int, int, int, int)
public Rectangle(Point, Size)
# Rectangle.Rectangle Constructor
Initializes a new instance of the Rectangle structure.
public Rectangle(
  Point offset,
  Size  extent
);

Parameters
offset
Microsoft.MediaCenter.UI.Point.  A point offset indicating the location.
extent
Microsoft.MediaCenter.UI.Size.  The size of the rectangle.
# Rectangle.Rectangle Constructor
Initializes a new instance of the Rectangle structure.
public Rectangle(
  int  x,
  int  y,
  int  width,
  int  height
);

Parameters
x
System.Int32.  Specifies point x, indicating the location.
y
System.Int32.  Specifies point y, indicating the location.
width
System.Int32.  Specifies the rectangle width, indicating the size.
height
System.Int32.  Specifies the rectangle height, indicating the size.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Rectangle Structure

# Rectangle.Add Method
Combines two Rectangle structures.
Syntax
public static Rectangle Add(
  Rectangle  left,
  Rectangle  right
);

Parameters
left
Microsoft.MediaCenter.UI.Rectangle.  The first structure.
right
Microsoft.MediaCenter.UI.Rectangle.  The second structure.
Return Value
Microsoft.MediaCenter.UI.Rectangle.  The result of the addition.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Rectangle Structure

# Rectangle.Addition Operator
Combines two Rectangle structures.
Syntax
public static Rectangle operator+(
  Rectangle  left,
  Rectangle  right
);

Parameters
left
Microsoft.MediaCenter.UI.Rectangle.  The first structure.
right
Microsoft.MediaCenter.UI.Rectangle.  The second structure.
Return Value
Microsoft.MediaCenter.UI.Rectangle.  The result of the addition.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Rectangle Structure

# Rectangle.Contains Method
Determines whether a Point is located within a given Rectangle structure.
Syntax
public bool Contains(
  Point  point
);

Parameters
point
Microsoft.MediaCenter.UI.Point.  A Point structure.
Return Value
System.Boolean.  true if the point is within the rectangle; otherwise, false.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Rectangle Structure

# Rectangle.Equality Operator
Tests whether two specified Rectangle structures are equivalent.
Syntax
public static bool operator==(
  Rectangle  left,
  Rectangle  right
);

Parameters
left
Microsoft.MediaCenter.UI.Rectangle.  The Rectangle structure that is to the left of the equality operator.
right
Microsoft.MediaCenter.UI.Rectangle.  The Rectangle structure that is to the right of the equality operator.
Return Value
System.Boolean.  true if these structures are equal; otherwise, false if not.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Rectangle Structure

# Rectangle.Equals Method
Tests whether the specified object is a Rectangle structure and is equivalent to the current Rectangle structure.
Syntax
public virtual bool Equals(
  object  obj
);

Parameters
obj
System.Object.  The object to test.
Return Value
System.Boolean.  true if the structures are equal; otherwise, false.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Rectangle Structure

# Rectangle.GetHashCode Method
Returns a hash code for this Rectangle structure.
Syntax
public virtual int GetHashCode(
);

Return Value
System.Int32.  The hash code.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Rectangle Structure

# Rectangle.Height Property
Gets or sets the height of the rectangle.
Syntax
public int Height {get; set;}

Property Value
System.Int32.  The height of the rectangle.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Rectangle Structure

# Rectangle.Inequality Operator
Tests whether two Rectangle structures are different.
Syntax
public static bool operator!=(
  Rectangle  left,
  Rectangle  right
);

Parameters
left
Microsoft.MediaCenter.UI.Rectangle.  The Rectangle structure that is to the left of the inequality operator.
right
Microsoft.MediaCenter.UI.Rectangle.  The Rectangle structure that is to the right of the inequality operator.
Return Value
System.Boolean.  true if the structures are not equal; otherwise, false.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Rectangle Structure

# Rectangle.Inflate Method
Increases the size of the Rectangle structure by the specified X and Y values.
Syntax
public static Rectangle Inflate(
  Rectangle  rectangle,
  int  x,
  int  y
);

Parameters
rectangle
Microsoft.MediaCenter.UI.Rectangle.  The Rectangle structure to increase.
x
System.Int32.  The X value.
y
System.Int32.  The Y value.
Remarks
If either x or y is negative, the Rectangle structure is deflated in the corresponding direction.
Return Value
Microsoft.MediaCenter.UI.Rectangle.  The resulting Rectangle structure.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Rectangle Structure

# Rectangle.Intersect Method
Creates a Rectangle structure that is the intersection of two Rectangle structures.
Syntax
public static Rectangle Intersect(
  Rectangle  left,
  Rectangle  right
);

Parameters
left
Microsoft.MediaCenter.UI.Rectangle.  The first structure.
right
Microsoft.MediaCenter.UI.Rectangle.  The second structure.
Return Value
Microsoft.MediaCenter.UI.Rectangle.  The Rectangle structure that represents the intersection.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Rectangle Structure

# Rectangle.Subtract Method
Subtracts one Rectangle structure from another.
Syntax
public static Rectangle Subtract(
  Rectangle  left,
  Rectangle  right
);

Parameters
left
Microsoft.MediaCenter.UI.Rectangle.  The first structure.
right
Microsoft.MediaCenter.UI.Rectangle.  The structure to subtract.
Return Value
Microsoft.MediaCenter.UI.Rectangle.  The result of the subtraction.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Rectangle Structure

# Rectangle.Subtraction Operator
Subtracts one Rectangle structure from another.
Syntax
public static Rectangle operator-(
  Rectangle  left,
  Rectangle  right
);

Parameters
left
Microsoft.MediaCenter.UI.Rectangle.  The first structure.
right
Microsoft.MediaCenter.UI.Rectangle.  The structure to subtract.
Return Value
Microsoft.MediaCenter.UI.Rectangle.  The result of the subtraction.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Rectangle Structure

# Rectangle.ToString Method
Converts this Rectangle structure to a human-readable string.
Syntax
public virtual string ToString(
);

Return Value
System.String.  The string representation.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Rectangle Structure

# Rectangle.Union Method
Creates a Rectangle structure that is the union of two Rectangle structures.
Syntax
public static Rectangle Union(
  Rectangle  left,
  Rectangle  right
);

Parameters
left
Microsoft.MediaCenter.UI.Rectangle.  The first structure.
right
Microsoft.MediaCenter.UI.Rectangle.  The second structure.
Return Value
Microsoft.MediaCenter.UI.Rectangle.  The Rectangle structure that represents the union.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Rectangle Structure

# Rectangle.Width Property
Gets or sets the width of the rectangle.
Syntax
public int Width {get; set;}

Property Value
System.Int32.  The width of the rectangle.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Rectangle Structure

# Rectangle.X Property
Gets or sets the X value.
Syntax
public int X {get; set;}

Property Value
System.Int32.  The X value.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Rectangle Structure

# Rectangle.Y Property
Gets or sets the Y value.
Syntax
public int Y {get; set;}

Property Value
System.Int32.  The Y value.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Rectangle Structure

# Rectangle.Zero Field
Represents a zero Rectangle structure.
Syntax
public static readonly Rectangle Zero;

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Rectangle Structure

# ReleaseBehavior Enumeration
Contains the possible actions to take with a data item when the VisualReleaseBehavior property is called.
public enum ReleaseBehavior

The ReleaseBehavior enumeration defines the following constants:
Constant	Description
Dispose	Disposes the data item.
KeepReference	Caches the item, leaving it alone.
ReleaseReference	Releases the reference to the item.

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
# RequestItemHandler Delegate
Represents the method to handle requests from a VirtualList to get and create an item if it is not available.
Syntax
public delegate void RequestItemHandler(
  VirtualList  list,
  int  index,
  ItemRequestCallback  callbackItem
);

Parameters
list
Microsoft.MediaCenter.UI.VirtualList.  The list that is requesting the item.
index
System.Int32.  The index of the item this is requested.
callbackItem
Microsoft.MediaCenter.UI.ItemRequestCallback.  The method to call back when the item is available.
Remarks
When an item is requested from a VirtualList, the internal storage is checked using VirtualList.IsItemAvailable to determine whether the item is available. If it is not, a RequestItemHandler delegate is specified to create the specified item.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	VirtualList.RequestItemHandler Property

# RequestSlowDataHandler Delegate
Represents the method to handle requests from a VirtualList to fill in slow data (data that takes a long time to load) on a list item that has already been created.
Syntax
public delegate void RequestSlowDataHandler(
  VirtualList  list,
  int  index
);

Parameters
list
Microsoft.MediaCenter.UI.VirtualList.  The list containing the item for which slow data should be retrieved.
index
System.Int32.  The index of the item for which to retrieve the slow data.
Remarks
This method is a priority-based notification for items that are in focus or on screen. If the items have data that require a slow operation to retrieve (for example, thumbnail images), you can use this notification as an indication of when to initiate the operation.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	VirtualList.RequestSlowDataHandler Property

# Rotation Structure
Defines an axis of rotation.
public struct Rotation

Public Instance Constructors
Constructor	Description
Rotation(float)
Initializes a new instance of the Rotation structure.
Rotation(float, Vector3)
Initializes a new instance of the Rotation structure.

Public Operators
Operator	Description
Equality
Tests whether two specified Rotation structures are equivalent.
Inequality
Tests whether two Rotation structures are different.

Public Instance Methods
Method	Description
Equals
Tests whether the specified object is a Rotation structure and is equivalent to the current Rotation structure.
GetHashCode
Returns a hash code for this structure.
ToString
Converts this structure to a human-readable string.

Public Static Fields
Field	Description
Default
Represents a default rotation.

Public Instance Properties
Property	Description
AngleDegrees
Gets or sets the angle of rotation, in degrees.
AngleRadians
Gets or sets the angle of rotation, in radians.
Axis
Gets or sets the three-dimensional axis to use for the rotation.

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Microsoft.MediaCenter.UI Namespace

# Rotation Constructor
Initializes a new instance of the Rotation structure.
Overload List
public Rotation(float)
public Rotation(float, Vector3)
MCML Inline Syntax
# Rotation.Rotation Constructor
Initializes a new instance of the Rotation structure.
public Rotation(
  float  angleRadians
);

Parameters
angleRadians
System.Single.  The angle of rotation, in radians.
# Rotation.Rotation Constructor
Initializes a new instance of the Rotation structure.
public Rotation(
  float  angleRadians,
  Vector3  axis
);

Parameters
angleRadians
System.Single.  The angle of rotation, in radians.
axis
Microsoft.MediaCenter.UI.Vector3.  Specifies the axis of rotation, as follows: AngleDegrees | AngleRadians;X rotation,Y rotation,Z rotation. For example: 0deg;0,0,1.
# MCML Inline Syntax
Initializes a new instance of the Rotation structure in MCML.
Rotate="AngleDegrees | AngleRadians;X rotation,Y rotation,Z rotation"

Parameters
AngleDegrees | AngleRadians
System.Single.  The angle of rotation, in degrees or radians.
axis
Microsoft.MediaCenter.UI.Vector3.  Specifies the axis of rotation.
Remarks
The following example shows how to specify a Rotation structure: "0deg;0,0,1".
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Rotation Structure

# Rotation.AngleDegrees Property
Gets or sets the angle of rotation, in degrees.
Syntax
public int AngleDegrees {get; set;}

Property Value
System.Int32.  The angle of rotation, in degrees.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Rotation Structure

# Rotation.AngleRadians Property
Gets or sets the angle of rotation, in radians.
Syntax
public float AngleRadians {get; set;}

Property Value
System.Single.  The angle of rotation, in radians.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Rotation Structure

# Rotation.Axis Property
Gets or sets the three-dimensional axis to use for the rotation.
Syntax
public Vector3 Axis {get; set;}

Property Value
Microsoft.MediaCenter.UI.Vector3.  Specifies the axis of rotation, as follows: AngleDegrees | AngleRadians;X rotation,Y rotation,Z rotation. For example: 0deg;0,0,1.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Rotation Structure

# Rotation.Default Field
Represents a default rotation.
Syntax
public static readonly Rotation Default;

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Rotation Structure

# Rotation.Equality Operator
Tests whether two specified Rotation structures are equivalent.
Syntax
public static bool operator==(
  Rotation  left,
  Rotation  right
);

Parameters
left
Microsoft.MediaCenter.UI.Rotation.  The Rotation structure that is to the left of the equality operator.
right
Microsoft.MediaCenter.UI.Rotation.  The Rotation structure that is to the right of the equality operator.
Return Value
System.Boolean.  true if the structures are equal; otherwise, false.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Rotation Structure

# Rotation.Equals Method
Tests whether the specified object is a Rotation structure and is equivalent to the current Rotation structure.
Syntax
public virtual bool Equals(
  object  obj
);

Parameters
obj
System.Object.  The object to test.
Return Value
System.Boolean.  true if the structures are equal; otherwise, false.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Rotation Structure

# Rotation.GetHashCode Method
Returns a hash code for this Rotation structure.
Syntax
public virtual int GetHashCode(
);

Return Value
System.Int32.  The hash code.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Rotation Structure

# Rotation.Inequality Operator
Tests whether two Rotation structures are different.
Syntax
public static bool operator!=(
  Rotation  left,
  Rotation  right
);

Parameters
left
Microsoft.MediaCenter.UI.Rotation.  The Rotation structure that is to the left of the inequality operator.
right
Microsoft.MediaCenter.UI.Rotation.  The Rotation structure that is to the right of the inequality operator.
Return Value
System.Boolean.  true if the structures are not equal; otherwise, false.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Rotation Structure

# Rotation.ToString Method
Converts this Rotation structure to a human-readable string.
Syntax
public virtual string ToString(
);

Return Value
System.String.  The string representation.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Rotation Structure

# SecureEditableText Class
Represents a secure user-editable string.
public class SecureEditableText : EditableText

Public Instance Constructors
Constructor	Description
SecureEditableText()
Initializes a new instance of the SecureEditableText class.
SecureEditableText(IModelItemOwner)
Initializes a new instance of the SecureEditableText class.
SecureEditableText(IModelItemOwner, string)	Initializes a new instance of the SecureEditableText class.

Public Instance Methods
Method	Description
AllowCharacter
Applies a character filter.

Public Instance Properties
Property	Description
Value
Gets or sets the current value.

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.UI Namespace
# SecureEditableText Constructor
Initializes a new instance of the SecureEditableText class.
Overload List
public SecureEditableText()
public SecureEditableText(IModelItemOwner)
public SecureEditableText(IModelItemOwner, string)
# SecureEditableText.SecureEditableText Constructor
Initializes a new instance of the SecureEditableText class.
public SecureEditableText();

# SecureEditableText.SecureEditableText Constructor
Initializes a new instance of the SecureEditableText class.
public SecureEditableText(
  IModelItemOwner  owner
);

Parameters
owner
Microsoft.MediaCenter.UI.IModelItemOwner.  The owner of the ModelItem.
# SecureEditableText.SecureEditableText Constructor
Initializes a new instance of the SecureEditableText class.
public SecureEditableText(
  IModelItemOwner  owner,
  string  description
);

Parameters
owner
Microsoft.MediaCenter.UI.IModelItemOwner.  The owner of the ModelItem.
description
System.String.  The description of the object.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows 7
See Also
•	SecureEditableText Class
# SecureEditableText.AllowCharacter Method
Applies a character filter.
Syntax
public bool AllowCharacter(
  char  ch
);

Parameters
ch
System.Char.  The character to filter.
Return Value
System.Boolean.  true if the character is allowed; otherwise, false.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows 7
See Also
•	SecureEditableText Class
# SecureEditableText.Value Property
Gets or sets the current text value.
Syntax
public string Value {get; set;}

Property Value
System.String.  The text string.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows 7
See Also
•	SecureEditableText Class
# Size Structure
Defines a size as height and width.
public struct Size

Public Instance Constructors
Constructor	Description
Size
Initializes a new instance of the Size structure.

Public Operators
Operator	Description
Addition Operator
Combines two Size structures.
Equality Operator
Tests whether two specified Size structures are equivalent.
Inequality Operator
Tests whether two Size structures are different.
Subtraction Operator
Subtracts one Size structure from another.

Public Static Methods
Method	Description
Add
Combines two Size structures.
Subtract
Subtracts one Size structure from another.

Public Instance Methods
Method	Description
Equals
Determines whether two Size structures have the same height and width.
GetHashCode
Returns a hash code for this structure.
ToString
Converts this structure to a human-readable string.

Public Static Fields
Field	Description
Zero
Represents a zero size.

Public Instance Properties
Property	Description
Height
Gets or sets the vertical component of the size.
Width
Gets or sets the horizontal component of the size.

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
# Size Constructor
Initializes a new instance of the Size structure.
Syntax
public Size(
  int  width,
  int  height
);

MCML Inline Syntax
Size="width,height"

Parameters
width
System.Int32.  The width.
height
System.Int32.  The height.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Size Structure
# Size.Add Method
Combines two Size structures.
Syntax
public static Size Add(
  Size  left,
  Size  right
);

Parameters
left
Microsoft.MediaCenter.UI.Size.  The first structure.
right
Microsoft.MediaCenter.UI.Size.  The second structure.
Return Value
Microsoft.MediaCenter.UI.Size.  The result of the addition.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Size Structure
# Size.Addition Operator
Combines two Size structures.
Syntax
public static Size operator+(
  Size  left,
  Size  right
);

Parameters
left
Microsoft.MediaCenter.UI.Size.  The first structure.
right
Microsoft.MediaCenter.UI.Size.  The second structure.
Return Value
Microsoft.MediaCenter.UI.Size.  The result of the addition.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Size Structure
# Size.Equality Operator
Tests whether two specified Size structures are equivalent.
Syntax
public static bool operator==(
  Size  left,
  Size  right
);

Parameters
left
Microsoft.MediaCenter.UI.Size.  The Size structure that is to the left of the equality operator
right
Microsoft.MediaCenter.UI.Size.  The Size structure that is to the right of the equality operator
Return Value
System.Boolean.  true if these structures are equal; otherwise, false.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Size Structure
# Size.Equals Method
Determines whether two Size structures have the same height and width.
Syntax
public bool Equals(
  object  obj
);

Parameters
obj
System.Object.  The object to test.
Return Value
System.Boolean.  true if the structures are equal; otherwise, false.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Size Structure
# Size.GetHashCode Method
Returns a hash code for this Size structure.
Syntax
public int GetHashCode();

Return Value
System.Int32.  The hash code.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Size Structure
# Size.Height Property
Gets or sets the vertical component of the size.
Syntax
public int Height {get; set;}

Property Value
System.Int32.  Specifies the height, in pixels.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Size Structure
# Size.Inequality Operator
Tests whether two Size structures are different.
Syntax
public static bool operator!=(
  Size  left,
  Size  right
);

Parameters
left
Microsoft.MediaCenter.UI.Size.  The Size structure that is to the left of the inequality operator.
right
Microsoft.MediaCenter.UI.Size.  The Size structure that is to the right of the inequality operator.
Return Value
System.Boolean.  true if the structures are not equal; otherwise, false.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Size Structure
# Size.Subtract Method
Subtracts one Size structure from another.
Syntax
public static Size Subtract(
  Size  left,
  Size  right
);

Parameters
left
Microsoft.MediaCenter.UI.Size.  The first structure.
right
Microsoft.MediaCenter.UI.Size.  The structure to subtract.
Return Value
Microsoft.MediaCenter.UI.Size.  The result of the subtraction.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Size Structure
# Size.Subtraction Operator
Subtracts one Size structure from another.
Syntax
public static Size operator-(
  Size  left,
  Size  right
);

Parameters
left
Microsoft.MediaCenter.UI.Size.  The first structure.
right
Microsoft.MediaCenter.UI.Size.  The structure to subtract.
Return Value
Microsoft.MediaCenter.UI.Size.  The result of the subtraction.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Size Structure
# Size.ToString Method
Converts this Size structure to a human-readable string.
Syntax
public string ToString();

Return Value
System.String.  The string representation.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Size Structure
# Size.Width Property
Gets or sets the horizontal component of the size.
Syntax
public int Width {get; set;}

Property Value
System.Int32.  Specifies the width, in pixels.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Size Structure
# Size.Zero Field
The Size.Zero field represents a zero size.
Syntax
public static readonly Microsoft.MediaCenter.UI.Size Zero;

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
See Also
•	Size Structure

# Sound Class
Creates a sound object.
public class Sound

Public Instance Constructors
Constructor	Description
Sound
Initializes a new instance of the Sound class.

Public Instance Methods
Method	Description
Play
Plays the sound.

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
# Sound Constructor
Initializes a new instance of the Sound class.
Syntax
public Sound(
  string  source
);

Parameters
source
System.String.  A Uniform Resource Identifier (URI) that specifies the path (file://, res://, resx://, or http://) to the sound source.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	GetSound
•	Sound Class
# Sound.Play Method
Plays the sound.
Syntax
public void Play();

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Sound Class
# Timer Class
Creates a timer object, which allows you to set properties and start and stop the timer.
public class Timer : ModelItem

Public Instance Constructors
Constructor	Description
Timer()
Initializes a new instance of the Timer class.
Timer(IModelItemOwner)
Initializes a new instance of the Timer class.
Timer(IModelItemOwner, string)
Initializes a new instance of the Timer class.

Public Instance Methods
Method	Description
Start
Starts the timer.
Stop
Stops the timer.
ToString
Converts this object to a human-readable string.

Public Instance Methods
Method	Description
Dispose
Releases all the resources used by the Timer class.

Public Instance Properties
Property	Description
AutoRepeat
Gets a value that indicates whether the timer runs repeatedly, or whether it runs one time.
Enabled
Gets a value that indicates whether the timer is enabled. Enabling the timer starts it; disabling the timer stops it.
Interval
Gets or sets the interval between ticks, in milliseconds.
TimeSpanInterval
Gets or sets the interval between ticks, as a TimeSpan value.

Public Instance Events
Event	Description
Tick
Raised for a timer tick.

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
# Timer Constructor
Initializes a new instance of the Timer class.
Overload List
public Timer()
public Timer(IModelItemOwner)
public Timer(IModelItemOwner, string)
# Timer.Timer Constructor
Initializes a new instance of the Timer class.
public Timer();

# Timer.Timer Constructor
Initializes a new instance of the Timer class.
public Timer(
  IModelItemOwner  owner
);

Parameters
owner
Microsoft.MediaCenter.UI.IModelItemOwner.  The owner of the ModelItem.
# Timer.Timer Constructor
Initializes a new instance of the Timer class.
public Timer(
  IModelItemOwner  owner,
  string  description
);

Parameters
owner
Microsoft.MediaCenter.UI.IModelItemOwner.  The owner of the ModelItem.
description
System.String.  The description of the object.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Timer Class
# Timer.AutoRepeat Property
Gets a value that indicates whether the timer runs repeatedly or whether it runs one time.
Syntax
public bool AutoRepeat {get; set;}

Property Value
System.Boolean.  true if the timer runs repeatedly; otherwise, false.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Timer Class
# Timer.Dispose Method
Releases all the resources used by the Timer class.
Syntax
protected void Dispose(
  bool  disposing
);

Parameters
disposing
System.Boolean.  true if the origin of the call is Dispose; otherwise, false.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Timer Class
# Timer.Enabled Property
Gets or sets a value that indicates whether the timer is enabled. Enabling the timer starts it; disabling the timer stops it.
Syntax
public bool Enabled {get; set;}

Property Value
System.Boolean.  true if the timer is enabled; otherwise, false.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Timer Class
# Timer.Interval Property
Gets or sets the interval between ticks, in milliseconds.
Syntax
public int Interval {get; set;}

Property Value
System.Int32.  The interval between ticks, in milliseconds.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Timer Class
# Timer.Start Method
The Timer.Start method starts the timer.
Syntax
public void Start();

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Timer Class
# Timer.Stop Method
Stops the timer.
Syntax
public void Stop();

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Timer Class
# Timer.Tick Event
Raised with each timer tick.
Syntax
public event System.EventHandler Tick;

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Timer Class
# Timer.TimeSpanInterval Property
Gets or sets the interval between ticks, as a TimeSpan value.
Syntax
public TimeSpan TimeSpanInterval {get; set;}

Property Value
System.TimeSpan.  The interval between ticks, using a TimeSpan value.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Timer Class
# Timer.ToString Method
Converts this object to a human-readable string.
Syntax
public string ToString();

Return Value
System.String.  The string representation.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Timer Class
# Vector3 Structure
Defines a vector.
public struct Vector3

Public Instance Constructors
Constructor	Description
Vector3
Initializes a new instance of the Vector3 structure.

Public Operators
Operator	Description
Addition
Combines two Vector3 structures.
Division
Divides a Vector3 structure by another structure, or by a scalar value.
Equality
Tests whether two specified Vector3 structures are equivalent.
Inequality
Tests whether two Vector3 structures are different.
Multiply
Multiplies a Vector3 structure by another Vector3 structure, or by a scalar value.
Subtraction
Subtracts one Vector3 structure from another.

Public Static Methods
Method	Description
Add
Combines two Vector3 structures.
Divide
Divides a Vector3 structure by another structure, or by a scalar value.
Multiply
Multiplies a Vector3 structure by another Vector3 structure, or by a scalar value.
Subtract
Subtracts one Vector3 structure from another.

Public Instance Methods
Method	Description
Equals
Tests whether the specified object is a Vector3 structure and is equivalent to the current Vector3 structure.
GetHashCode
Returns a hash code for this structure.
ToString
Converts this structure to a human-readable string.

Public Static Fields
Field	Description
UnitVector
Represents a unit vector.
Zero
Represents a zero vector.

Public Instance Properties
Property	Description
X
Gets or sets the x-coordinate of the vector.
Y
Gets or sets the y-coordinate of the vector.
Z
Gets or sets the z-coordinate of the vector.

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Microsoft.MediaCenter.UI Namespace

# Vector3 Constructor
Initializes a new instance of the Vector3 structure.
Syntax
public Vector3(
  float  x,
  float  y,
  float  z
);

Parameters
x
System.Single.  Specifies the x-coordinate of the vector.
y
System.Single.  Specifies the y-coordinate of the vector.
z
System.Single.  Specifies the z-coordinate of the vector.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Vector3 Structure

# Vector3.Add Method
Combines two Vector3 structures.
Syntax
public static Vector3 Add(
  Vector3  left,
  Vector3  right
);

Parameters
left
Microsoft.MediaCenter.UI.Vector3.  The first structure.
right
Microsoft.MediaCenter.UI.Vector3.  The second structure.
Return Value
Microsoft.MediaCenter.UI.Vector3.  The result of the addition.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Vector3 Structure

# Vector3.Addition Operator
Combines two Vector3 structures.
Syntax
public static Vector3 operator+(
  Vector3  left,
  Vector3  right
);

Parameters
left
Microsoft.MediaCenter.UI.Vector3.  The first structure.
right
Microsoft.MediaCenter.UI.Vector3.  The second structure.
Return Value
Microsoft.MediaCenter.UI.Vector3.  The result of the addition.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Vector3 Structure

# Vector3.Divide Method
Divides a Vector3 structure by another structure, or by a scalar value.
Overload List
public static Vector3 Divide(
  Vector3  left,
  Vector3  right
);
public static Vector3 Divide(
  Vector3  vector,
  float  scalar
);

Parameters
left
Microsoft.MediaCenter.UI.Vector3.  The first structure.
right
Microsoft.MediaCenter.UI.Vector3.  The second structure.
vector
Microsoft.MediaCenter.UI.Vector3.  A Vector3 structure.
scalar
System.Single.  A scalar.
Return Value
Microsoft.MediaCenter.UI.Vector3.  The Vector3 structure that represents the division.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Vector3 Structure

# Vector3.Division Operator
Divides a Vector3 structure by another structure, or by a scalar value.
Overload List
public static Vector3 !!op_Division!!(
  Vector3  left,
  Vector3  right
);
public static Vector3 !!op_Division!!(
  Vector3  vector,
  float  scalar
);

Parameters
left
Microsoft.MediaCenter.UI.Vector3.  Specifies the first vector.
right
Microsoft.MediaCenter.UI.Vector3.  Specifies the second vector.
vector
Microsoft.MediaCenter.UI.Vector3.  Specifies a vector.
scalar
System.Single.  Specifies a scalar.
Return Value
Microsoft.MediaCenter.UI.Vector3.  A vector structure.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Vector3 Structure

# Vector3.Equality Operator
Tests whether two specified Vector3 structures are equivalent.
Syntax
public static bool operator==(
  Vector3  left,
  Vector3  right
);

Parameters
left
Microsoft.MediaCenter.UI.Vector3.  The Vector3 structure that is to the left of the equality operator.
right
Microsoft.MediaCenter.UI.Vector3.  The Vector3 structure that is to the right of the equality operator.
Return Value
System.Boolean.  true if these structures are equal; otherwise, false.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Vector3 Structure

# Vector3.Equals Method
Tests whether the specified object is a Vector3 structure and is equivalent to the current Vector3 structure.
Syntax
public virtual bool Equals(
  object  obj
);

Parameters
obj
System.Object.  The object to test.
Return Value
System.Boolean.  true if the structures are equal; otherwise, false.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Vector3 Structure

# Vector3.GetHashCode Method
Returns a hash code for this Vector3 structure.
Syntax
public virtual int GetHashCode(
);

Return Value
System.Int32.  The hash code.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Vector3 Structure

# Vector3.Inequality Operator
Tests whether two Vector3 structures are different.
Syntax
public static bool operator!=(
  Vector3  left,
  Vector3  right
);

Parameters
left
Microsoft.MediaCenter.UI.Vector3.  The Vector3 structure that is to the left of the inequality operator.
right
Microsoft.MediaCenter.UI.Vector3.  The Vector3 structure that is to the right of the inequality operator.
Return Value
System.Boolean.  true if the structures are not equal; otherwise, false.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Vector3 Structure

# Vector3.Multiply Method
Multiplies a Vector3 structure by another Vector3 structure, or by a scalar value.
Overload List
public static Vector3 Multiply(
  Vector3  left,
  Vector3  right
);
public static Vector3 Multiply(
  Vector3  vector,
  float  scalar
);

Parameters
left
Microsoft.MediaCenter.UI.Vector3.  The first structure.
right
Microsoft.MediaCenter.UI.Vector3.  The second structure.
vector
Microsoft.MediaCenter.UI.Vector3.  A Vector3 structure.
scalar
System.Single.  A scalar.
Return Value
Microsoft.MediaCenter.UI.Vector3.  The Vector3 structure that represents the multiplication.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Vector3 Structure

# Vector3.Multiply Operator
Multiplies a Vector3 structure by another Vector3 structure, or by a scalar value.
Overload List
public static Vector3 !!op_Multiply!!(
  Vector3  left,
  Vector3  right
);
public static Vector3 !!op_Multiply!!(
  Vector3  vector,
  float  scalar
);

Parameters
left
Microsoft.MediaCenter.UI.Vector3.  Specifies the first vector.
right
Microsoft.MediaCenter.UI.Vector3.  Specifies the second vector.
vector
Microsoft.MediaCenter.UI.Vector3.  Specifies a vector.
scalar
System.Single.  Specifies a scalar.
Return Value
Microsoft.MediaCenter.UI.Vector3.  A vector structure.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Vector3 Structure

# Vector3.Subtract Method
Subtracts one Vector3 structure from another.
Syntax
public static Vector3 Subtract(
  Vector3  left,
  Vector3  right
);

Parameters
left
Microsoft.MediaCenter.UI.Vector3.  The first structure.
right
Microsoft.MediaCenter.UI.Vector3.  The structure to subtract.
Return Value
Microsoft.MediaCenter.UI.Vector3.  The result of the subtraction.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Vector3 Structure

# Vector3.Subtraction Operator
Subtracts one Vector3 structure from another.
Syntax
public static Vector3 operator-(
  Vector3  left,
  Vector3  right
);

Parameters
left
Microsoft.MediaCenter.UI.Vector3.  The first structure.
right
Microsoft.MediaCenter.UI.Vector3.  The structure to subtract.
Return Value
Microsoft.MediaCenter.UI.Vector3.  The result of the subtraction.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Vector3 Structure

# Vector3.ToString Method
Converts this Vector3 structure to a human-readable string.
Syntax
public virtual string ToString(
);

Return Value
System.String.  The string representation.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Vector3 Structure

# Vector3.UnitVector Field
Represents a unit vector.
Syntax
public static readonly Vector3 UnitVector;

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Vector3 Structure

# Vector3.X Property
Gets or sets the x-coordinate of the vector.
Syntax
public float X {get; set;}

Property Value
System.Single.  The vector's x-coordinate.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Vector3 Structure

# Vector3.Y Property
Gets or sets the y-coordinate of the vector.
Syntax
public float Y {get; set;}

Property Value
System.Single.  The vector's y-coordinate
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Vector3 Structure

# Vector3.Z Property
Gets or sets the z-coordinate of the vector.
Syntax
public float Z {get; set;}

Property Value
System.Single.  The vector's z-coordinate
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Vector3 Structure

# Vector3.Zero Field
Represents a zero vector.
Syntax
public static readonly Vector3 Zero;

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	Vector3 Structure

# VirtualList Class
Creates a collection of very large data sets, slow-acquiring data, or a combination of both. A virtual list is request based; the entire list is not loaded, but rather portions of it are loaded, allowing you to work with very large sets of data.
public class VirtualList : ModelItem, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable

Public Instance Constructors
Constructor	Description
VirtualList()
Initializes a new instance of the VirtualList class.
VirtualList(ItemCountHandler)
Initializes a new instance of the VirtualList class.
VirtualList(IModelItemOwner, ItemCountHandler)	Initializes a new instance of the VirtualList class.

Public Instance Methods
Method	Description
Add
Adds an item to the end of the list.
Clear
Empties the contents of the list.
Contains
Determines whether a given item is in the list.
CopyTo
Copies the contents of this list to an array.
GetEnumerator
Gets an IEnumerator object for this collection.
IndexOf
Determines the index of a specific item in the list.
Insert
Inserts an item at the specified index.
IsItemAvailable
Determines whether an item at the specified index is available for query (the item can be located by index).
Modified
Indicates that the item at the given index has been modified, but the new value is not yet known.
Move
Moves an item to a different location within the list.
Remove
Removes the specified item from the list.
RemoveAt
Removes the item at the specified index.
RequestItem
Requests an item from the specified index.

Protected Instance Methods
Method	Description
ContainsDataForIndex
Determines whether a specified index has a corresponding data item in the list.
Dispose
Releases all the resources used by VirtualList.
OnRequestItem
Gets the item at the specified index.
OnRequestSlowData
Gets an item that is slow to acquire.
OnVisualsCreated
Notifies derived classes that the visual elements associated with the item in the specified index have been created.
OnVisualsReleased
Notifies derived classes that the visual elements associated with the item in the specified index have been released.

Public Instance Properties
Property	Description
Count
Gets or sets the number of items in the VirtualList object.

EnableSlowDataRequests
Gets or sets a value that indicates whether the slow data requests feature is enabled.
IsFixedSize
Gets a value that indicates whether the VirtualList object is a fixed size.

IsReadOnly
Gets a value that indicates whether the VirtualList object is read-only.

IsSynchronized
Gets a value that indicates whether the VirtualList object is thread-safe.

Item
Gets or sets an item from the VirtualList object.
RequestItemHandler
Gets or sets the item query handler, which allows for customized "get" logic without deriving and overriding the OnRequestItem method.

RequestSlowDataHandler
Gets or sets the event handler, which is raised when one of the items has been displayed on screen and is ready for deferred (partial) data updates.
StoreQueryResults
Determines whether the result of a RequestItem query should be stored in the VirtualList, which causes future queries to be faster.
SyncRoot
Gets the thread synchronization root.
UnavailableItem
Gets the object from a RequestItem query to inform the caller that the item cannot be retrieved.
VisualReleaseBehavior
Gets or sets the policy for data items after the visual items that were created for that item have been released.

Remarks
This class also includes services for slow partial data loads.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	FlowLayout Element
•	GridLayout Element
•	Microsoft.MediaCenter.UI Namespace
•	Repeater Element
# VirtualList Constructor
Initializes a new instance of the VirtualList class.
Overload List
public VirtualList()
public VirtualList(ItemCountHandler)
public VirtualList(IModelItemOwner, ItemCountHandler)
# VirtualList.VirtualList Constructor
Initializes a new instance of the VirtualList class.
public VirtualList();

# VirtualList.VirtualList Constructor
Initializes a new instance of the VirtualList class.
public VirtualList(
  ItemCountHandler  countHandler
);

Parameters
countHandler
Microsoft.MediaCenter.UI.ItemCountHandler.  A delayed-count callback method.
# VirtualList.VirtualList Constructor
Initializes a new instance of the VirtualList class.
public VirtualList(
  IModelItemOwner  owner,
  ItemCountHandler  countHandler
);

Parameters
owner
Microsoft.MediaCenter.UI.IModelItemOwner.  The owner of the ModelItem object.
countHandler
Microsoft.MediaCenter.UI.ItemCountHandler.  A delayed-count callback method.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	VirtualList Class
# VirtualList.Add Method
Adds an item to the end of the list.
Overload List
public int Add();
public int Add(
  object  item
);

Parameters
item
System.Object.  The object to add.
Return Value
System.Int32.  The index of the new item.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	VirtualList Class
# VirtualList.Clear Method
Empties the contents of the list.
Syntax
public void Clear();

Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	VirtualList Class
# VirtualList.Contains Method
Determines whether a given item is in the list.
Syntax
public bool Contains(
  object  item
);

Parameters
item
System.Object.  The object to search for
Return Value
System.Boolean.  true if the item is in the list; otherwise, false.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	VirtualList Class
# VirtualList.ContainsDataForIndex Method
Determines whether a specified index has a corresponding data item in the list.
Syntax
protected bool ContainsDataForIndex(
  int  index
);

Parameters
index
System.Int32.  The index to search for.
Return Value
System.Boolean.  true if there is data at the index specified; otherwise, false.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	VirtualList Class
# VirtualList.CopyTo Method
Copies the contents of this list to an array.
Syntax
public void CopyTo(
  Array  array,
  int  index
);

Parameters
array
System.Array.  The source array
index
System.Int32.  The starting index at which to copy the data.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	VirtualList Class
# VirtualList.Count Property
Gets or sets the number of items in the VirtualList object.
Syntax
public int Count {get; set;}

Property Value
System.Int32.  The count of items.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	VirtualList Class
# VirtualList.Dispose Method
Releases all the resources used by VirtualList.
Syntax
protected void Dispose(
  bool  disposing
);

Parameters
disposing
System.Boolean.  true if the origin of the call is Dispose; otherwise, false.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	VirtualList Class
# VirtualList.EnableSlowDataRequests Property
Gets or sets a value that indicates whether the slow data requests feature is enabled. This feature notifies clients when an item's visual items have been created, and allows for additional, and usually very slow, data acquisition while displaying partial data for an item.
Syntax
public bool EnableSlowDataRequests {get; set;}

Property Value
System.Boolean.  true if the slow data requests feature is enabled; otherwise, false.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	VirtualList Class
•	VirtualList.RequestSlowDataHandler Property
# VirtualList.GetEnumerator Method
Gets an IEnumerator object for this collection.
Syntax
public System.Collections.IEnumerator GetEnumerator();

Return Value
System.Collections.IEnumerator.  The enumerator.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	VirtualList Class
# VirtualList.IndexOf Method
Determines the index of a specific item in the list.
Syntax
public int IndexOf(
  object  item
);

Parameters
item
System.Object.  The object for which to get the index.
Return Value
System.Int32.  The index value.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	VirtualList Class
# VirtualList.Insert Method
Inserts an item at the specified index.
Overload List
public void Insert(
  int  index,
  object  item
);
public void Insert(
  int  index
);

Parameters
index
System.Int32.  The index at which to insert the item.
item
System.Object.  The object to insert into the list.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	VirtualList Class
# VirtualList.IsFixedSize Property
Gets a value that indicates whether the VirtualList object is a fixed size.
Syntax
public bool IsFixedSize {get;}

Property Value
System.Boolean.  true if the list is a fixed size; otherwise, false.
This property is read-only.
Note   This value is always false for virtual lists.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	VirtualList Class
# VirtualList.IsItemAvailable Method
Determines whether an item at the specified index is available for query (the item can be located by index).
Syntax
public bool IsItemAvailable(
  int  index
);

Parameters
index
System.Int32.  The index of the item to retrieve.
Return Value
System.Boolean.  true if the item is available; otherwise, false.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	VirtualList Class
# VirtualList.IsReadOnly Property
Gets a value that indicates whether the VirtualList object is read-only.
Syntax
public bool IsReadOnly {get;}

Property Value
System.Boolean.  true if the list is read-only; otherwise, false.
This property is read-only.
Note   This value is always false for virtual lists.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	VirtualList Class
# VirtualList.IsSynchronized Property
Gets a value that indicates whether the VirtualList object is thread safe.
Syntax
public bool IsSynchronized {get;}

Property Value
System.Boolean.  true if the list is thread safe; otherwise, false.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	VirtualList Class
# VirtualList.Item Property
Gets or sets an item from the VirtualList object.
Syntax
public object Item[int] {get; set;}

Property Value
System.Object.  The item from the list at the specified index.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	VirtualList Class
# VirtualList.Modified Method
Indicates that the item at the given index has been modified, but the new value is not yet known.
Syntax
public void Modified(
  int  index
);

Parameters
index
System.Int32.  The index of the item.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	VirtualList Class
# VirtualList.Move Method
Moves an item to a different location within the list.
Syntax
public void Move(
  int  oldIndex,
  int  newIndex
);

Parameters
oldIndex
System.Int32.  The index to move from.
newIndex
System.Int32.  The index to move to.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	VirtualList Class
# VirtualList.OnRequestItem Method
Gets the item at the specified index.
Syntax
protected void OnRequestItem(
  int  index,
  ItemRequestCallback  callback
);

Parameters
index
System.Int32.  The index of the item to retrieve.
callback
Microsoft.MediaCenter.UI.ItemRequestCallback.  A callback method that is used to notify the list that the item is available.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	VirtualList Class
# VirtualList.OnRequestSlowData Method
Gets an item that is slow to acquire.  
Syntax
protected virtual void OnRequestSlowData(
  int  index
);

Parameters
index
System.Int32.  The index of the item to retrieve.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	VirtualList Class
•	VirtualList.EnableSlowDataRequests Property

# VirtualList.OnVisualsCreated Method
Notifies derived classes that the visual elements associated with the item in the specified index have been created.
Syntax
protected void OnVisualsCreated(
  int  index
);

Parameters
index
System.Int32.  The index of the item.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	VirtualList Class
# VirtualList.OnVisualsReleased Method
Notifies derived classes that the visual elements associated with the item in the specified index have been released.
Syntax
protected void OnVisualsReleased(
  int  index
);

Parameters
index
System.Int32.  The index of the item.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	VirtualList Class
# VirtualList.Remove Method
Removes the specified item from the list.
Syntax
public void Remove(
  object  item
);

Parameters
item
System.Object.  The object to remove.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	VirtualList Class
# VirtualList.RemoveAt Method
Removes the item at the specified index.
Syntax
public void RemoveAt(
  int  index
);

Parameters
index
System.Int32.  The index of item to remove.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	VirtualList Class
# VirtualList.RequestItem Method
Requests an item from the specified index.
Syntax
public void RequestItem(
  int  index,
  ItemRequestCallback  callback
);

Parameters
index
System.Int32.  The index of the item to retrieve.
callback
Microsoft.MediaCenter.UI.ItemRequestCallback.  A callback method that is used to notify that list that the item is available.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	VirtualList Class
# VirtualList.RequestItemHandler Property
Gets or sets the item query handler, which allows for customized "get" logic without deriving and overriding the OnRequestItem method.
Syntax
public RequestItemHandler RequestItemHandler {get; set;}

Property Value
Microsoft.MediaCenter.UI.RequestItemHandler.  The item query handler.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	VirtualList Class

# VirtualList.RequestSlowDataHandler Property
Gets or sets the event handler, which is raised when one of the items has been displayed on screen and is ready for deferred (partial) data updates.
Syntax
public RequestSlowDataHandler RequestSlowDataHandler {get; set;}

Property Value
Microsoft.MediaCenter.UI.RequestSlowDataHandler.  The event handler.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Microsoft.MediaCenter.UI Namespace
•	VirtualList Class

# VirtualList.StoreQueryResults Property
Determines whether the result of a RequestItem query should be stored in the VirtualList, which causes future queries to be faster.
Syntax
public bool StoreQueryResults {get; set;}

Property Value
System.Boolean.  true if the return value should be stored; otherwise, false.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	VirtualList Class
# VirtualList.SyncRoot Property
Gets the thread synchronization root.
Syntax
public object SyncRoot {get;}

Property Value
System.Object.  The thread synchronization root.
This property is read-only.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	VirtualList Class
# VirtualList.UnavailableItem Property
Gets the object from a RequestItem query to inform the caller that the item cannot be retrieved.
Syntax
public static object UnavailableItem {get;}

Property Value
System.Object.  The item that is not available.
This property is read-only.
Remarks
This property is not the same as being unable to complete the data request. This property is returned when a data item cannot be acquired because of a state change that made the query irrelevant or unanswerable.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	VirtualList Class
# VirtualList.VisualReleaseBehavior Property
Gets or sets the policy for data items after the visual items that were created for that item have been released.
Syntax
public ReleaseBehavior VisualReleaseBehavior {get; set;}

Property Value
Microsoft.MediaCenter.UI.ReleaseBehavior.  The release policy.
This property is read/write.
Requirements
Reference: Microsoft.MediaCenter.UI
Namespace: Microsoft.MediaCenter.UI
Assembly: Microsoft.MediaCenter.UI.dll
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	VirtualList Class

---

MCESDK_Ref03.doc

# Media Center Markup Language Reference
This section describes the Windows Media Center Markup Language (MCML), which is used for developing user interfaces (UIs) for Windows Media Center Presentation Layer applications.
Topic	Description
MCML Types
Describes the elements that are used in MCML.
MCML Enumerations
Describes the enumerations that are used in MCML.
MCML Methods
Describes the methods that are used in MCML.
MCML Events
Describes the events that are used in MCML.

See Also
•	Sample Explorer
•	Media Center Markup Language Verifier
•	Programming Reference

# MCML Types
This section describes the view items and other elements that you can use in MCML markup.
Element	Description
Accessible
Implements accessibility support by mapping certain UI functions to standard accessibility actions that can be used by external accessibility aides.
Aggregate
Imports an MCML resource and its markup types and resources through the MCML container.
AlphaKeyframe
Specifies an alpha keyframe for an animation.
AnchorEdge
Specifies an edge anchor for anchor layouts.
AnchorLayout
Specifies an anchor layout.
AnchorLayoutInput
Specifies input for an anchor layout element.
Animation
Describes an animation associated with a view item.
Binding
Defines a rule that binds a source to a target. The target is updated whenever the source changes.
BooleanTransformer
Converts data to a Boolean value.
Changed
Defines a rule that invokes actions based on a source change.
ClickHandler
An event handler that provides button-like input behavior to a UI object.
Clip
Defines a clipping region, which prevents drawing beyond its bounds.
ColorFill
Displays a solid fill.
ColorKeyframe
Defines a color keyframe for an animation.
Condition
Defines a rule that invokes actions based on a logical condition.
DateTimeTransformer
Converts date-time data to a string for display purposes.
DebugTrace
Debugs rules by displaying the output on the debug console.
Default
Defines a rule for a default action if no other higher-priority rules apply.
DockLayout
Defines a dock layout.
DockLayoutInput
Defines input for a dock layout element.
Environment
Tracks the state of the current host.
Equality
Defines a rule condition based on whether a source equals a given value.
ExceptionHandler
An event handler that catches exceptions for Invoke, Set, and Command objects.
FlowLayout
Defines a layout in which items flow one after another.
Font
Specifies the font of an object.
FormatTransformer
Converts an object to a string with a specified format.
FormLayoutInput
Defines a form layout.
Graphic
Displays an image.
GridLayout
Defines a layout that arranges children in a grid fashion.
HandleException
Defines an exception handler for an Invoke, Set, or Command object.
Host
Hosts a child UI.
Index
Represents the current data and virtual index when repeating a data set.
Input
Used to access input-related state and events within a UI.
Interpolation
Estimates intermediate values between two keyframes.
InvokeCommand
Invokes an arbitrary method.
Invoke
Invokes an action as the result of a rule.
IsType
Defines a rule condition based on whether a source is a given type.
IsValid
Defines a rule condition based on whether a source can be queried without error (for example, there are no null values).
KeyHandler
Provides keystroke input behavior to a UI element.
MajorMinor
Defines a two-dimensional vector.
MathTransformer
Defines a mathematical conversion.
Mcml
The top-level root tag of a Windows Media Center Presentation Layer markup document.
MergeAnimation
Combines multiple source animations into one.
Modified
Determines whether a given source was modified.
MouseWheelHandler
Sets up an event handler that provides mouse/wheel input behavior to a UI element.
NavigateCommand
Defines an action to navigate to a specified destination MCML resource in response to a command.
Navigate
Defines an action to navigate to a specified destination MCML resource in response to a rule.
NowPlaying
Defines a placeholder item that indicates where to display the Now Playing inset.
ObjectPath
Represents an artibrary object path with dot-into object support.
Panel
Defines a non-drawing layout container.
PlayAnimation
Defines an action to play animation.
PlaySound
Defines an action to play sound.
PositionKeyframe
Defines a position keyframe for an animation.
Repeater
Repeats a markup based on a given dataset.
RotateKeyframe
Defines a rotation keyframe for an animation.
RotateLayout
Defines a rotation of 0, 90, 180, or 270 degrees for child elements.
Rule
Defines the base rule for other rules. This element allows you to construct custom lists of conditions and actions.
ScaleKeyframe
Defines a scale keyframe for an animation.
ScaleLayout
Scales child elements up or down as specified.
Scroller
Scrolls content.
ScrollingData
Defines the data used for scrolling.
ScrollingHandler
Defines common scrolling input behavior for a UI element.
SecureTypingHandler
An event handler that provides secure editbox-like input behavior to a UI object. String values are encrypted. Display values are always masked.
Set
Defines an action that sets a property value for a target.
ShortcutHandler
An event handler that provides shortcut command-input behavior to a UI element.
SizeKeyframe
Defines a size keyframe for an animation.
SwitchAnimation
Not documented in this release.
Text
Draws text.
TimeSpanTransformer
Converts a TimeSpan value to a string for display purposes.
TransformAnimation
Enables simple time- and value-based transformations on all of the keyframes in a reference animation.
TransformByAttributeAnimation
Performs time and value transformations to a reference animation based on a visual attribute such as width or index.
TripleTapKeyInfo
Provides header and label information for triple-tap keys.
TypeSelector
Repeater content selector that matches based on type.
TypingHandler
Event handler that provides edit box-like input behavior to a UI element.
UI
Defines a UI—how it appears visually, how it behaves, and how it interacts with code/data objects.
ValueSelector
Selects content for a repeater by comparing the result of an arbitrary object path to a value.
Video
Displays video.

See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier

# Accessible Element
An accessibility object that implements accessibility support by mapping certain UI functions to standard accessibility actions that can be used by external accessibility aides.
Syntax
<Accessible
    DefaultAction="string"
    DefaultActionCommand="ICommand object"
    Description="string"
    HasPopup="{true | false}"
    Help="string"
    HelpTopic="int"
    IsChecked="{true | false}"
    IsDefault="{true | false}"
    IsExpanded="{true | false}"
    IsFocusable="{true | false}"
    IsFocused="{true | false}"
    IsHotTracked="{true | false}"
    IsInvisible="{true | false}"
    IsMarquee="{true | false}"
    IsOffScreen="{true | false}"
    IsPressed="{true | false}"
    IsProtected="{true | false}"
    IsSelectable="{true | false}"
    IsSelected="{true | false}"
    IsUnavailable="{true | false}"
    KeyboardShortcut="string"
    Name="string"
    Role="AccessibleRole enumeration"
    UniqueId="GUID"
    Value="string"
/>

Attributes
DefaultAction
Contains a description of the default action.
DefaultActionCommand
Specifies an ICommand object to invoke for default action.
Description
Contains a description.
HasPopup
Indicates whether the object has pop-up text.
Help
Contains help text.
HelpTopic
Identifies the help topic.
IsChecked
Indicates whether the object is checked.
IsDefault
Indicates whether the object is the default.
IsExpanded
Indicates whether the object is expanded.
IsFocusable
Indicates whether the object is focusable.
IsFocused
Indicates whether the object is focused.
IsHotTracked
Indicates whether the mouse is over the object.
IsInvisible
Indicates whether the object is invisible.
IsMarquee
Indicates whether to display the object as a marquee.
IsOffScreen
Indicates whether the object is offscreen.
IsPressed
Indicates whether the object is pressed.
IsProtected
Indicates whether the object is protected.
IsSelectable
Indicates whether the object is selectable.
IsSelected
Indicates whether the object is selected.
IsUnavailable
Indicates whether the object is unavailable.
KeyboardShortcut
Contains a keyboard shortcut.
Name
Contains the name.
Role
Identifies the accessibility role. This value must be a member of the AccessibleRole enumeration.
UniqueId
Specifies a globally unique identifier (GUID).
Value
Contains a value.
Remarks
State set on this object will be exposed via IAccessible for accessibility aides. For more information, see the following topics on the MSDN Web site:
•	Active Accessibility User Interface Services
•	IAccessible
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Adding Accessibility Support
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
•	UI Element

# Aggregate Element
Imports an MCML resource and its markup types and resources through the MCML container.
Syntax
<Aggregate
    Source="string"
/>

Attributes
Source
Contains the URI of the MCML resource to import.
Remarks
The Aggregate element makes all top-level markup resources (UIs, Images, Sounds, Animations, and so forth) available through the local MCML file's namespace. Aggregates are typically used for grouping many MCML files under a single namespace.
For example, if you have several controls defined within several MCML files (such as buttons and editboxes), you could create a file called "Control.mcml" and reference each of your individual controls using Aggregate tags. Then, all of your controls can be accessed using the Controls.mcml file with a single xmlns statement.
Aggregates increase the potential of name collisions because the contents of the referenced MCML resources may not be known. When importing markup types and resources that have the same name as container resources, the imported versions override the local versions.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# AlphaKeyframe Element
Specifies an alpha keyframe for an animation.
Syntax
<AlphaKeyframe
    Interpolation="Interpolation element"
    RelativeTo="{Absolute | Current | Final}"
    Time="float"
    Value="float"
/>

Attributes
Interpolation
Specifies the Interpolation from this keyframe to the next. You must use the inline construction of this element.
RelativeTo
A member of the KeyframeValueReference enumeration that specifies how to interpret the keyframe's value.
Time
Specifies the time, in seconds, at which this keyframe occurs.
Value
Specifies the keyframe value, which corresponds to the opacity of the view item. This value must be between 0.0 and 1.0.
Remarks
Animations require at least two keyframes of the same type (for example, two AlphaKeyFrames). With only one keyframe, there is no beginning or end and therefore nothing to animate. In addition, the first keyframe must start at Time="0".
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# AnchorEdge Element
Specifies an edge anchor.
Syntax
<AnchorEdge
    Id="string"
    MaximumOffset="int"
    MaximumPercent="float"
    MinimumOffset="int"
    MinimumPercent="float"
    Offset="int"
    Percent="float"
/>

Inline Syntax
AnchorEdge="Id,Percent"
AnchorEdge="Id,Percent,Offset"

Attributes
Id
Dependency reference of edge. This value can be parent (to indicate the parent element), focus (to indicate the next item that has focus), or the name of another peer in the view item.
MaximumOffset
Specifies the maximum edge value offset, in pixels, relative to the parent.
MaximumPercent
Specifies the maximum edge value relative to the parent. A value of 1 is 100%, .5 is 50%, and so forth.
MinimumOffset
Specifies the minimum edge value offset, in pixels, relative to the parent.
MinimumPercent
Specifies the minimum edge value relative to the parent. A value of 1 is 100%, .5 is 50%, and so forth.
Offset
Specifies the additional offset value, in pixels, for the edge.
Percent
Specifies the edge value relative to the reference. A value of 1 is 100%, .5 is 50%, and so forth.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# AnchorLayout Element
Specifies an anchor layout.
Syntax
<AnchorLayout
    SizeToHorizontalChildren="{true | false}"
    SizeToVerticalChildren="{true | false}"
/>

Attributes
SizeToHorizontalChildren
Indicates whether the reported size is the horizontal space the child elements occupy.
SizeToVerticalChildren
Indicates whether the reported size is the vertical space the child elements occupy.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# AnchorLayoutInput Element
Specifies input for an anchor layout element.
Syntax
<AnchorLayoutInput
    Bottom="AnchorEdge element"
    ContributesToHeight="{true | false}"
    ContributesToWidth="{true | false}"
    Horizontal="{Center | Far | Fill | Near}"
    Left="AnchorEdge element"
    Right="AnchorEdge element"
    Top="AnchorEdge element"
    Vertical="{Center | Far | Fill | Near}"
/>

Attributes
Bottom
An AnchorEdge element indicating the bottom anchor edge. You must use the inline construction of this element.
ContributesToHeight
Specifies whether the view item's height is included in the height of the AnchorLayout (this setting is applicable when SizeToVerticalChildren is true).
ContributesToWidth
Specifies whether the view item's width is included in the width of the AnchorLayout (this setting is applicable when SizeToHorizontalChildren is true).
Horizontal
Specifies the horizontal alignment between edge anchors, which must be a member of the AnchorAlignment enumeration.
Left
An AnchorEdge element indicating the left anchor edge. You must use the inline construction of this element.
Right
An AnchorEdge element indicating the right anchor edge. You must use the inline construction of this element.
Top
An AnchorEdge element indicating the top anchor edge. You must use the inline construction of this element.
Vertical
Specifies the vertical alignment between edge anchors, which must be a member of the AnchorAlignment enumeration.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	AnchorLayout Element
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# Animation Element
Describes an animation associated with a view item.
Syntax
<Animation
    CenterPointOffset="Vector3"
    CenterPointPercent="Vector3"
    DisableMouseInput="{true | false}"
    Loop="int"
    RotationAxis="Vector3"
    Type="{Alpha | ContentChangeHide | ContentChangeShow | GainFocus | Hide | Idle | LoseFocus | Move | Rotate | Scale | Show | Size}"
>
    <Keyframes />
</Animation>

Attributes
CenterPointOffset
Specifies a center point adjustment based on a pixel-offset value when applying a scale or rotation to the view item. This value is applied after the CenterPointPercent value has been applied if both are provided. Use the inline construction for the Vector3 structure.
CenterPointPercent
Specifies a center point adjustment based on a percentage value when applying a scale or rotation to the view item. This value must be between 0 and 1, where a value of 1 equals 100%. Use the inline construction for the Vector3 structure.
DisableMouseInput
Indicates whether to disable mouse input for the view item when an animation is playing.
Keyframes
Contains the keyframes of the animation.
Include one or more of the following elements to define keyframes:
AlphaKeyframe
ColorKeyframe
PositionKeyframe
RotateKeyframe
ScaleKeyframe
SizeKeyframe
Note   Animations require at least two keyframes of the same type (for example, two AlphaKeyFrames). With only one keyframe, there is no beginning or end, and therefore nothing to animate.
Loop
Specifies the animation repeat count (negative means infinite). The loop count is zero-based. For example, a value of 0 loops the animation once, a value of 1 loops the animation twice, and so forth.
RotationAxis
Specifes a Vector3 of rotation for the animation. Use the inline construction for the Vector3 structure.
Type
Indicates the type of event that this animation will respond to. This value must be a member of the AnimationEventType enumeration.
Remarks
You cannot programmatically stop an animation while it is running.
ContentChangeShow and ContentChangeHide animations are triggered as follows:
•	The Graphic content changes, such as when an image is downloaded.
•	The ColorFill content attribute changes.
•	The Text content attribute changes.
•	The Host source changes.
When using ContentChangeShow and ContentChangeHide animations, if the content hasn't changed, the animation is not performed. However, you can repeat the same animation by invoking the ForceContentChange method on the view item.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Animation Element
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
•	MergeAnimation Element
•	TransformAnimation Element
•	TransformByAttributeAnimation Element

# Binding Element
Defines a rule that binds a source to a target. The target is updated whenever the source changes.
Syntax
<Binding
    ConditionLogicalOp="{And | Or}"
    Source="ObjectPath element"
    Target="ObjectPath element"
    Transformer="object"
>
    <Actions />
    <Conditions />
    <Transformer />
</Binding>

Attributes
Actions
Specifies actions for this rule. Possible actions include:
DebugTrace
Invoke
Navigate
PlayAnimation
PlaySound
Set
ConditionLogicalOp
Specifies a ConditionLogicalOp logical operator for rule-matching behavior.
Conditions
Lists the conditions for a rule. Possible conditions include:
Equality
IsType
IsValid
Modified
Source
An object path in the form [ObjectName.Member] that indicates the source of the binding.
Target
An object path in the form [ObjectName.Member] that indicates the target of the binding.
Transformer
Optional. Indicates a data converter. You can use inline or expanded construction. Possible transformer elements include:
BooleanTransformer
DateTimeTransformer
FormatTransformer
MathTransformer
TimeSpanTransformer
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# BooleanTransformer Element
Converts data to a Boolean value.
Syntax
<BooleanTransformer
    Inverse="{true | false}"
/>

Attributes
Inverse
Returns the inverse result of the conversion.
Remarks
The following types are supported:
•	Int32: true if non-zero; false if zero.
•	Single: true if non-zero; false if zero.
•	Double: true if non-zero; false if zero.
•	String: true if non-zero; false if zero.
•	Boolean: Returns the current value.
•	ICollection: true for a non-zero count; false for a zero count.
The target of a BooleanTransformer must accept a Boolean value.
You cannot perform one conversion after another on the same variable in a chain. To perform multiple conversions, you can transform the value to an intermediate local and then bind that value to your target using another transformer, or use multiple actions on the same variable using a rule.
Example Code
<Mcml
  xmlns="http://schemas.microsoft.com/2006/mcml"
  xmlns:cor="assembly://MSCorLib/System">

  <UI Name="BooleanTransformer">

    <!-- Two values: one is non-zero, one is zero. -->
    <Locals>
      <cor:Int32  Name="ValueT" Int32="1" />
      <cor:Single Name="ValueF" Single="0" />
    </Locals>

    <!-- These rules bind the Boolean values to the Visible properties of the Text elements. -->
    <Rules>
      <Binding Source="[ValueT]" Target="[LabelT.Visible]">
        <Transformer>
          <BooleanTransformer />
        </Transformer>
      </Binding>
      <Binding Source="[ValueF]" Target="[LabelF.Visible]">
        <Transformer>
          <BooleanTransformer />
        </Transformer>
      </Binding>
    </Rules>

    <Content>
      <Panel Layout="VerticalFlow">
        <Children>

          <!-- These are invisible by default (Visible="false"). -->
          <Text Name="LabelT" Content="This is visible because the value is non-zero"
                Color="BlanchedAlmond" Font="Verdana,30" Visible="false"/>

          <Text Name="LabelF" Content="This is not visible because the value is zero"
                Color="BlanchedAlmond" Font="Verdana,30" Visible="false"/>

        </Children>
      </Panel>
    </Content>

  </UI>
</Mcml>

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# Changed Element
Defines a rule that invokes actions based on a source change.
Syntax
<Changed
    ConditionLogicalOp="{And | Or}"
    InitialEvaluate="{true | false}"
    Source="ObjectPath element"
>
    <Actions />
    <Conditions />
</Changed>

Attributes
Actions
Specifies actions for this rule. Possible actions include:
DebugTrace
Invoke
Navigate
PlayAnimation
PlaySound
Set
ConditionLogicalOp
Specifies a ConditionLogicalOp logical operator for rule-matching behavior.
Conditions
Lists the conditions for a rule. Possible conditions include:
Equality
IsType
IsValid
Modified
InitialEvaluate
Indicates the initial evaluation value during startup.
Source
An object path in the form [ObjectName.Member] that indicates the source to track for changes.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# ClickHandler Element
An event handler that provides button-like input behavior to a UI object.
Syntax
<ClickHandler
    Clicking="{true | false}"
    Command="ICommand object"
    HandleEnterSpaceKeys="{true | false}"
    HandlePrimaryMouseButton="{true | false}"
    HandlerStage="{Bubbled | Direct | Routed}"
/>

Attributes
Clicking
Indicates whether the UI is currently experiencing a click action. This value is read-only.
Command
Specifies an ICommand object associated with the click handler. The Invoke method for the command will be called when a click event occurs.
HandleEnterSpaceKeys
Indicates whether to handle the SPACEBAR and ENTER keys.
HandlePrimaryMouseButton
Indicates whether to handle the primary mouse button.
HandlerStage
A member of the InputHandlerStage enumeration indicating the stage in the event handling process at which the event will be handled.
Public Instance Events
Event	Description
Invoked
Notification that is sent when the UI is clicked.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# Clip Element
Defines a clipping region, which prevents drawing beyond its bounds.
Syntax
<Clip
    Alpha="float"
    CenterPointOffset="Vector3"
    CenterPointPercent="Vector3"
    ColorFilter="Color"
    ColorMask="Color"
    DebugOutline="Color"
    FadeAmount="float"
    FadeSize="float"
    FarOffset="float"
    FocusOrder="int"
    Layout="{Anchor | Center | Dock | Fill | Form | Grid | HorizontalFlow | Rotate | Scale | VerticalFlow}"
    LayoutInput="LayoutInput"
    Margins="Inset"
    MaximumSize="Size"
    MinimumSize="Size"
    MouseInteractive="{true | false}"
    Name="string"
    Navigation="NavigationPolicies enumeration"
    NearOffset="float"
    Orientation="{Horizontal | Vertical}"
    Padding="Inset"
    Rotation="Rotation"
    Scale="Vector3"
    ShowFar="{true | false}"
    ShowNear="{true | false}"
    Visible="{true | false}"
>
    <Animations />
    <Children />
    <Layout />
    <LayoutInput />
</Clip>

Attributes
Alpha
Specifies the opacity value for the view item. This value must be between 0.0 and 1.0.
Animations
Contains a list of elements that describe an animation. Possible elements are:
Animation
MergeAnimation
SwitchAnimation
TransformAnimation
TransformByAttributeAnimation
CenterPointOffset
Specifies a center point adjustment based on a pixel-offset value when applying a scale or rotation to the view item. This value is applied after the CenterPointPercent value has been applied if both are provided. Use the inline construction for the Vector3 structure.
CenterPointPercent
Specifies a center point adjustment based on a percentage value when applying a scale or rotation to the view item. This value must be between 0 and 1, where a value of 1 equals 100%. Use the inline construction for the Vector3 structure.
Children
Specifies the child elements for a view item. Possible child elements are:
Clip
ColorFill
Graphic
Host
Panel
Repeater
Scroller
Text
Video
ColorFilter
Indicates the Color filter to apply on top of the color of the view item.
ColorMask
Indicates the Color that defines the effect the fade will have, which is an alpha fade by default.
DebugOutline
Enables and sets the Color of the debugging outline of the view item.
FadeAmount
Defines the severity of the fade based on a percentage value. This value must be between 0 and 1, where a value of 1 equals 100%.
FadeSize
Indicates the size of the clip fade, in pixels.
FarOffset
Specifies the offset for the far edge of the gradient (dependent on the orientation).
FocusOrder
Specifies relative priorities to sibling view items within the container for determining which item has default focus when entering a UI. Values can range from 0 (the highest priority) to Int32.MaxValue (the lowest priority and the default).
Layout
Specifies the current layout associated with this view item. You can use the inline construction or expanded syntax with the following child elements that define a layout:
AnchorLayout
DockLayout
FlowLayout
GridLayout
RotateLayout
ScaleLayout
LayoutInput
Specifies the layout input for use by parent layouts. You can use the inline construction to specify a reference to a layout element, or use expanded syntax with the following child elements that define input:
AnchorLayoutInput
DockLayoutInput
FormLayoutInput
Margins
Inset structure that specifies extra spacing outside the boundaries of the view item.
MaximumSize
Specifies the maximum Size, in pixels. If a maximum size is not specified or the maximum size is set to zero, the size will not be restricted.
MinimumSize
Specifies the minimum Size, in pixels. If a maximum size is not specified or the maximum size is set to zero, the size will not be restricted.
MouseInteractive
Determines whether the view item can receive and react to mouse input.
Name
Identifies this element.
Navigation
Specifies how the view item should behave during directional navigation. This value must be a member of the NavigationPolicies enumeration.
NearOffset
Specifies the offset for the near edge of the gradient (dependent on the orientation).
Orientation
Specifies the orientation of the clipping fade, which must be a member of the Orientation enumeration.
Padding
An Inset structure that specifies the extra spacing, in pixels, between the view item and its child elements.
Rotation
Applies a Rotation to the view item. Use the inline construction for this attribute.
Scale
A Vector3 structure that applies a scaling factor to the view item. Use the inline construction for this element.
ShowFar
Indicates whether to display the far fade.
ShowNear
Indicates whether to display the near fade.
Visible
Indicates whether the view item is visible.
Public Instance Methods
Method	Description
AttachAnimation
Dynamically adds an animation to the view item. An animation of the same type is replaced by the new one.
DetachAnimation
Dynamically removes an animation from the view item.
ForceContentChange
Manually forces a content change for animations.
NavigateInto
Requests navigation into the view item to send focus to the view item or one of its children.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# ColorFill Element
Displays a solid fill.
Syntax
<ColorFill
    Alpha="float"
    CenterPointOffset="Vector3"
    CenterPointPercent="Vector3"
    ColorFilter="Color"
    Content="Color"
    DebugOutline="Color"
    FocusOrder="int"
    Layout="{Anchor | Center | Dock | Fill | Form | Grid | HorizontalFlow | Rotate | Scale | VerticalFlow}"
    LayoutInput="LayoutInput"
    Margins="Inset"
    MaximumSize="Size"
    MinimumSize="Size"
    MouseInteractive="{true | false}"
    Name="string"
    Navigation="NavigationPolicies enumeration"
    Padding="Inset"
    Rotation="Rotation"
    Scale="Vector3"
    Visible="{true | false}"
>
    <Animations />
    <Children />
    <Layout />
    <LayoutInput />
</ColorFill>

Attributes
Alpha
Specifies the opacity value for the view item. This value must be between 0.0 and 1.0.
Animations
Contains a list of elements that describe an animation. Possible elements are:
Animation
MergeAnimation
SwitchAnimation
TransformAnimation
TransformByAttributeAnimation
CenterPointOffset
Specifies a center point adjustment based on a pixel-offset value when applying a scale or rotation to the view item. This value is applied after the CenterPointPercent value has been applied if both are provided. Use the inline construction for the Vector3 structure.
CenterPointPercent
Specifies a center point adjustment based on a percentage value when applying a scale or rotation to the view item. This value must be between 0 and 1, where a value of 1 equals 100%. Use the inline construction for the Vector3 structure.
Children
Specifies the child elements for a view item. Possible child elements are:
Clip
ColorFill
Graphic
Host
Panel
Repeater
Scroller
Text
Video
ColorFilter
Indicates the Color filter to apply on top of the color of the view item.
Content
Specifies the fill Color.
DebugOutline
Enables and sets the Color of the debugging outline of the view item.
FocusOrder
Specifies relative priorities to sibling view items within the container for determining which item has default focus when entering a UI. Values can range from 0 (the highest priority) to Int32.MaxValue (the lowest priority and the default).
Layout
Specifies the current layout associated with this view item. You can use the inline construction, or expanded syntax with the following child elements that define a layout:
AnchorLayout
DockLayout
FlowLayout
GridLayout
RotateLayout
ScaleLayout
LayoutInput
Specifies the layout input for use by parent layouts. You can use the inline construction to specify a reference to a layout element, or use expanded syntax with the following child elements that define input:
AnchorLayoutInput
DockLayoutInput
FormLayoutInput
Margins
An Inset structure that specifies extra spacing around the view item.
MaximumSize
Specifies the maximum Size, in pixels. If a maximum size is not specified or the maximum size is set to zero, the size will not be restricted.
MinimumSize
Specifies the minimum Size, in pixels. If a maximum size is not specified or the maximum size is set to zero, the size will not be restricted.
MouseInteractive
Determines whether the view item can receive and react to mouse input.
Name
Identifies this element.
Navigation
Specifies how the view item should behave during directional navigation. This value must be a member of the NavigationPolicies enumeration.
Padding
An Inset structure that specifies the extra spacing, in pixels, between the view item and its child elements.
Rotation
Applies a Rotation to the view item. Use the inline construction for this element.
Scale
A Vector3 structure that applies a scaling factor to the view item. Use the inline construction for this element.
Visible
Indicates whether the view item is visible.
Public Instance Methods
Method	Description
AttachAnimation
Dynamically adds an animation.
DetachAnimation
Dynamically removes an animation from the view item.
ForceContentChange
Manually forces a content change for animations.
NavigateInto
Requests navigation into the view item to send focus to the view item or one of its children.

Remarks
ColorFill elements are used to draw rectangles of a solid color, typically for adding background color to view items. ColorFill elements that don't have any children and have no padding or minimum size will not be displayed because a colorfill (which is a color) has no intrinsic size.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# ColorKeyframe Element
Defines a color keyframe for an animation.
Syntax
<ColorKeyframe
    Interpolation="Interpolation element"
    RelativeTo="{Absolute | Current}"
    Time="float"
    Value="Color"
/>

Attributes
Interpolation
Specifies the Interpolation from this keyframe to the next. Use the inline construction for this element.
RelativeTo
A member of the KeyframeValueReference enumeration that specifies how to interpret the keyframe's value.
Time
Specifies the time, in seconds, at which this keyframe occurs.
Value
Specifies the Color of this keyframe.
Remarks
Animations require at least two keyframes of the same type (for example, two AlphaKeyFrames). With only one keyframe, there is no beginning or end and therefore nothing to animate. In addition, the first keyframe must start at Time="0".
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# Condition Element
Defines a rule that invokes actions based on a logical condition.
Syntax
<Condition
    ConditionLogicalOp="{And | Or}"
    ConditionOp="{ChangedTo | Equals | GreaterThan | GreaterThanOrEquals | LessThan | LessThanOrEquals | NotEquals}"
    Source="ObjectPath element"
    SourceValue="object"
    Target="ObjectPath element"
    Value="object"
>
    <Actions />
    <Conditions />
</Condition>

Attributes
Actions
Specifies actions for this rule. Possible actions include:
DebugTrace
Invoke
Navigate
PlayAnimation
PlaySound
Set
You can use the ArrayListDataSet class to populate a list from markup. This method works well with repeaters because changes to the list are automatically directed to the repeater.
ConditionLogicalOp
Specifies a ConditionLogicalOp logical operator for rule-matching behavior.
ConditionOp
Specifies the type of condition operation, which must be a member of the ConditionOp enumeration.
Conditions
Lists the conditions for a rule. Possible conditions include:
Equality
IsType
IsValid
Modified
Source
An object path in the form [ObjectName.Member] that indicates the source of the condition.
ConditionValue
Specifies the value to check against the source.
Target
Optional. An object path in the form [ObjectName.Member] that indicates the target to set if the condition is true.
Value
Optional. The value of the target to set if the condition is true.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# DateTimeTransformer Element
Converts date-time data to a string for display purposes.
Syntax
<DateTimeTransformer
    Format="DateTimeFormats enumeration"
/>

Attributes
Format
Specifies a date-time format. This value must be a member of the DateTimeFormats enumeration.
Remarks
The target of the DateTimeTransformer element must accept a string.
You cannot perform one conversion after another on the same variable in a chain. To perform multiple conversions, you can transform the value to an intermediate local and then bind that value to your target using another transformer, or use multiple actions on the same variable using a rule.
Example Code
<Mcml
  xmlns="http://schemas.microsoft.com/2006/mcml"
  xmlns:cor="assembly://MSCorLib/System"
  xmlns:me="Me">

  <UI Name="DateTimeTransformer">

    <Locals>
      <cor:DateTime Name="DateTimeValue" cor:DateTime="2006-01-26 15:32:54"/>
    </Locals>

    <Rules>
      <!-- This rule converts the date-time value to a short date + short time string. -->
      <Binding Source="[DateTimeValue]" Target="[Example1.DateTimeString]">
        <Transformer>
          <DateTimeTransformer Format="ShortDate,ShortTime"/>
        </Transformer>
      </Binding>
      <!-- This rule converts the date-time value to a long date with an abbreviated day string. -->
      <Binding Source="[DateTimeValue]" Target="[Example2.DateTimeString]">
        <Transformer>
          <DateTimeTransformer Format="LongDate,AbbreviateNames"/>
        </Transformer>
      </Binding>
    </Rules>

    <Content>
      <Panel Layout="VerticalFlow">
        <Children>
          <Panel Layout="HorizontalFlow">
            <Children>
              <me:LabelText LabelString="This example shows a short date + time: "/>
              <me:ValueText Name="Example1"/>
            </Children>
          </Panel>
          <Panel Layout="HorizontalFlow">
            <Children>
              <me:LabelText LabelString="This example shows a long date + abbreviated name: "/>
              <me:ValueText Name="Example2"/>
            </Children>
          </Panel>

        </Children>
      </Panel>
    </Content>

  </UI>

  <UI Name="LabelText">

    <Properties>
      <cor:String Name="LabelString" String=""/>
    </Properties>

    <Content>
      <Text Content="[LabelString]" Font="Verdana,16" Color="LightCoral"
        Margins="10,5,10,5" MinimumSize="400,0" MaximumSize="600,0" WordWrap="true"/>
    </Content>

  </UI>

  <UI Name="ValueText">

    <Properties>
      <cor:String Name="DateTimeString" String=""/>
    </Properties>

    <Content>
      <Text Content="[DateTimeString]" Font="Verdana,16" Color="Khaki" Margins="10,5,10,5"/>
    </Content>

  </UI>
</Mcml>

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# DebugTrace Element
Debugs rules.
Syntax
<DebugTrace
    Message="string"
>
    <Params />
</DebugTrace>

Attributes
Message
Specifies a string to format trace output.
Params
Contains ObjectPath elements that contain parameters to use with formatted messages.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# Default Element
Defines a rule for a default action if no other higher-priority rules apply.
Syntax
<Default
    ConditionLogicalOp="{And | Or}"
    Target="ObjectPath element"
    Transformer="object"
    Value="object"
>
    <Actions />
    <Conditions />
    <Transformer />
</Default>

Attributes
Actions
Specifies actions for this rule. Possible actions include:
DebugTrace
Invoke
Navigate
PlayAnimation
PlaySound
Set
You can use the ArrayListDataSet class to populate a list from markup. This method works well with repeaters because changes to the list are automatically directed to the repeater.
ConditionLogicalOp
Specifies a ConditionLogicalOp logical operator for rule-matching behavior.
Conditions
Lists the conditions for a rule. Possible conditions include:
Equality
IsType
IsValid
Modified
Target
An object path in the form [ObjectName.Member] that specifies the target.
Transformer
Optional. Indicates a data converter. You can use inline or expanded construction. Possible transformer elements include:
BooleanTransformer
DateTimeTransformer
FormatTransformer
MathTransformer
TimeSpanTransformer
Value
Specifies the value of the target.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# DockLayout Element
Defines a dock layout.
Syntax
<DockLayout
    SizeToChildren="{true | false}"
/>

Attributes
SizeToChildren
Indicates whether to size the layout to the contents.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# DockLayoutInput Element
Defines input for a dock layout element.
Syntax
<DockLayoutInput
    Alignment="{Center | Far | Fill | Near}"
    Position="{Bottom | Client | Left | Right | Top}"
/>
Attributes
Alignment
Specifies the dock layout alignment, which must be a member of the DockLayoutAlignment enumeration.
Position
Specifies the dock layout position, which must be a member of the DockLayoutPosition enumeration.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	DockLayout Element
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# Environment Element
Tracks the state of the current host.
Syntax
<Environment
    ColorScheme="{Default | HighContrast1 | HighContrast2}"
    DebugOutlines="DebugOutlines element"
    IsNavigating="{true | false}"
    IsRightToLeft="{true | false}"
    IsWidescreen="{true | false}"
    NavigationDirection="{Backward | Forward}"
/>

Attributes
ColorScheme
Indicates a member of the ColorScheme enumeration that determines current active color scheme. This value is read-only.
DebugOutlines
Indicates a reference to a DebugOutlines element from which to use the configuration. This value is read-only.
IsNavigating
Indicates whether a page navigation is in progress. This value is read-only.
IsRightToLeft
Determines whether the system is right-to-left (RTL) reading order. This value is read-only.
IsWidescreen
Indicates whether Windows Media Center is in widescreen mode. This value is read-only.
NavigationDirection
A member of the NavigationDirection enumeration that indicates the direction of the most recent page navigation. This value is read-only.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# Equality Element
Defines an equality condition of a rule.
Syntax
<Equality
    ConditionOp="{ChangedTo | Equals | GreaterThan | GreaterThanOrEquals | LessThan | LessThanOrEquals | NotEquals}"
    Source="ObjectPath element"
    SourceTransformer="object"
    Value="object"
>
    <SourceTransformer />
</Equality>

Attributes
ConditionOp
Specifies a logical condition operator, which must be a member of the ConditionOp enumeration.
Source
An object path in the form [ObjectName.Member] that indicates the source of the condition.
SourceTransformer
Indicates a source conversion. You can use inline or expanded construction. Possible transformer elements include:
BooleanTransformer
DateTimeTransformer
FormatTransformer
MathTransformer
Value
Value to compare against.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier

# ExceptionHandler Element
An event handler that catches exceptions for Invoke, Set, or Command actions.
Syntax
<ExceptionHandler
    CaughtException="Exception"
    CaughtExceptionType="string"
    Command="ICommand object"
/>

Attributes
CaughtException
Indicates the exception that was caught. This value is read-only.
CaughtExceptionType
Indicates the name of the exception that was caught. This value is read-only.
Command
Specifies an ICommand object associated with the click handler. The Invoke method for the command will be called when a click event occurs.
Public Instance Events
Event	Description
Caught
Notification that is sent when the event is fired.

Remarks
When an Invoke, Set, or Command action is called, any exceptions are caught. If an ExceptionHandler has been provided for the action, the Caught event is fired on the exception.
Requirements
Platform: Windows 7
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# FlowLayout Element
Defines a layout in which items flow one after another.
Syntax
<FlowLayout
    AllowWrap="{true | false}"
    FillStrip="{true | false}"
    ItemAlignment="{Center | Far | Fill | Near}"
    MinimumSampleSize="int"
    MissingItemPolicy="{SizeToAverage | SizeToLargest | SizeToSmallest | Wait}"
    Orientation="{Horizontal | Vertical}"
    Repeat="{Always | Never | WhenTooBig | WhenTooSmall}"
    RepeatGap="MajorMinor element"
    Spacing="MajorMinor element"
    StripAlignment="{Center | Far | Near}"
/>

Attributes
AllowWrap
Enables item wrapping.
FillStrip
Enables the strip fill.
ItemAlignment
Specifies the alignment of an item inside the strip, which must be a member of the ItemAlignment enumeration.
MinimumSampleSize
Specifies the minimum amount of available items required before the MissingItemPolicy can be applied. Before this number of items is available, MissingItemPolicy defaults to Wait.
MissingItemPolicy
Specifies the size the layout should assume for missing items. This must be a member of the MissingItemPolicy enumeration.
Orientation
Specifies the layout flow orientation, which must be a member of the Orientation enumeration.
Repeat
Specifies when to repeat items. This value must be a member of the RepeatPolicy enumeration. When enabled, items being flowed will infinitely repeat in either direction, preventing the user from reaching the end of the list.
RepeatGap
When Repeat is enabled, specifies the distance between repeated instances as a MajorMinor element. Use the inline construction for this element.
Spacing
Specifies the space between items in the flow as a MajorMinor element. Use the inline construction for this element.
StripAlignment
Specifies the alignment of a strip, which must be a member of the StripAlignment enumeration.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
•	Repeater Element
•	VirtualList Class
# Font Element
Specifies the font of an object.
Syntax
<Font
    FontName="string"
    FontSize="float"
    FontStyle="{Bold | Italic | None}"
/>

Inline Syntax
Font="FontName"
Font="FontName,FontSize"
Font="FontName,FontSize,FontStyle"

Attributes
FontName
Contains the font face name.
FontSize
Specifies the size of the font, in points. Points are relative to 96 dots per inch (dpi).
FontStyle
Specifies the style of the font, which must be a member of the FontStyles enumeration. You can also include multiple styles by separating them with a comma (for example, FontStyle="Bold,Italic").
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# FormatTransformer Element
Converts an object to a string with a specified format.
Syntax
<FormatTransformer
    ExtendedFormat="string"
    Format="string"
    ToLower="{true | false}"
    ToUpper="{true | false}"
/>

Attributes
ExtendedFormat
Contains the extended format string.
Format
Contains the format string. This string must contain a "{0}" to denote the location of the string representation.
ToLower
Indicates whether to convert the result to lower case.
ToUpper
Indicates whether to convert the result to upper case.
Remarks
The FormatTransformer element supports extended formatting on objects that implement IFormattable.
For more information about extended format strings, see the Remarks section of the String.Format Method on the MSDN Web site.
The target of the FormatTransformer must accept a string.
You cannot perform one conversion after another on the same variable in a chain. To perform multiple conversions, you can transform the value to an intermediate local and then bind that value to your target using another transformer, or use multiple actions on the same variable using a rule.
Example Code
<Mcml
  xmlns="http://schemas.microsoft.com/2006/mcml"
  xmlns:cor="assembly://MSCorLib/System">

  <UI Name="FormatTransformer">

    <Locals>
      <cor:Double Name="PhoneNumber" Double="4255551212"/>
    </Locals>

    <Rules>
      <!-- The target is Content on a Text element, which expects a string. -->
      <Binding Source="[PhoneNumber]" Target="[Label.Content]">
        <Transformer>
          <FormatTransformer Format="The phone number is {0}."  ExtendedFormat="(###) ###-####"/>
        </Transformer>
      </Binding>
    </Rules>

    <Content>
      <Text Name="Label" Color="Orchid" Font="Verdana,30"/>
    </Content>

  </UI>
</Mcml>

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# FormLayoutInput Element
Defines a form layout.
Syntax
<FormLayoutInput
    Bottom="AnchorEdge element"
    ContributesToHeight="{true | false}"
    ContributesToWidth="{true | false}"
    Horizontal="{Center | Far | Fill | Near}"
    Left="AnchorEdge element"
    Right="AnchorEdge element"
    Top="AnchorEdge element"
    Vertical="{Center | Far | Fill | Near}"
/>

Attributes
Bottom
An AnchorEdge element indicating the bottom anchor edge. Use the inline construction for this element.
ContributesToHeight
Specifies whether the view item's height is included in the height of the AnchorLayout (this setting is applicable when SizeToVerticalChildren is true).
ContributesToWidth
Specifies whether the view item's width is included in the width of the AnchorLayout (this setting is applicable when SizeToHorizontalChildren is true).
Horizontal
Specifies the horizontal alignment between edge anchors. This value must be a member of the AnchorAlignment enumeration.
Left
An AnchorEdge element indicating the left anchor edge. Use the inline construction for this element.
Right
An AnchorEdge element indicating the right anchor edge. Use the inline construction for this element.
Top
An AnchorEdge element indicating the top anchor edge. Use the inline construction for this element.
Vertical
Specifies the vertical alignment between edge anchors, which must be a member of the AnchorAlignment enumeration.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# Graphic Element
Displays an image.
Syntax
<Graphic
    AcquiringImage="Image object"
    Alpha="float"
    CenterPointOffset="Vector3"
    CenterPointPercent="Vector3"
    ColorFilter="Color"
    Content="Image object"
    DebugOutline="Color"
    ErrorImage="Image object"
    FocusOrder="int"
    HorizontalAlignment="{Center | Far | Fill | Near}"
    Layout="{Anchor | Center | Dock | Fill | Form | Grid | HorizontalFlow | Rotate | Scale | VerticalFlow}"
    LayoutInput="LayoutInput"
    MaintainAspectRatio="{true | false}"
    Margins="Inset"
    MaximumSize="Size"
    MinimumSize="Size"
    MouseInteractive="{true | false}"
    Name="string"
    Navigation="NavigationPolicies enumeration"
    Padding="Inset"
    Rotation="Rotation"
    Scale="Vector3"
    SizingPolicy="{SizeToChildren | SizeToConstraint | SizeToContent}"
    VerticalAlignment="{Center | Far | Fill | Near}"
    Visible="{true | false}"
>
    <Animations />
    <Children />
    <Layout />
    <LayoutInput />
</Graphic>

Attributes
AcquiringImage
Specifies an Image object to display in place of an image that is being acquired asynchronously. The image must be a local resource that is referenced using the res://, resx://, or file:// protocol.
Note   There is no event that indicates when a graphic has finished loading.
Alpha
Specifies the opacity value for the view item. This value must be between 0.0 and 1.0.
Animations
Contains a list of elements that describe an animation. Possible elements are:
Animation
MergeAnimation
SwitchAnimation
TransformAnimation
TransformByAttributeAnimation
CenterPointOffset
Specifies a center point adjustment based on a pixel-offset value when applying a scale or rotation to the view item. This value is applied after the CenterPointPercent value has been applied if both are provided. Use the inline construction for the Vector3 structure.
CenterPointPercent
Specifies a center point adjustment based on a percentage value when applying a scale or rotation to the view item. This value must be between 0 and 1, where a value of 1 equals 100%. Use the inline construction for the Vector3 structure.
Children
Specifies the child elements for a view item. Possible child elements are:
Clip
ColorFill
Graphic
Host
Panel
Repeater
Scroller
Text
Video
ColorFilter
Indicates the Color filter to apply on top of the color of the view item.
Content
Specifies an Image object to display. To display an image that is generated by code, write the image to a file and then specify a reference to it.
DebugOutline
Enables and sets the Color of the debugging outline of the view item.
ErrorImage
Specifies an Image to display in place of an image that failed to be acquired. The image must be a local resource that is referenced using the res://, resx://, or file:// protocol.
FocusOrder
Specifies relative priorities to sibling view items within the container for determining which item has default focus when entering a UI. Values can range from 0 (the highest priority) to Int32.MaxValue (the lowest priority and the default).
HorizontalAlignment
Specifies the horizontal alignment of the content image within the layout rectangle. This value must be a member of the ItemAlignment enumeration.
When set to Fill, the image is stretched horizontally to fill the maximum constraint (or the maximum width that maintains the aspect ratio if the MaintainAspectRatio property is true). When set to Near, Far, or Center, and the image is larger than the layout rectangle, the image is cropped to fit and the alignment value determines which region of the image to preserve.
Layout
Specifies the current layout associated with this view item. You can use the inline construction or expanded syntax with the following child elements that define a layout:
AnchorLayout
DockLayout
FlowLayout
GridLayout
RotateLayout
ScaleLayout
LayoutInput
Specifies the layout input for use by parent layouts. You can use the inline construction to specify a reference to a layout element, or use expanded syntax with the following child elements that define input:
AnchorLayoutInput
DockLayoutInput
FormLayoutInput
MaintainAspectRatio
Indicates whether to maintain relative width and height ratio when displaying the image.
Margins
An Inset structure that specifies extra spacing around the view item.
MaximumSize
Specifies the maximum Size, in pixels. If a maximum size is not specified or the maximum size is set to zero, the size will not be restricted.
MinimumSize
Specifies the minimum Size, in pixels. If a maximum size is not specified or the maximum size is set to zero, the size will not be restricted.
MouseInteractive
Determines whether the view item can receive and react to mouse input.
Name
Identifies this element.
Navigation
Specifies how the view item should behave during directional navigation. This value must be a member of the NavigationPolicies enumeration.
Padding
An Inset structure that specifies the extra spacing, in pixels, between the view item and its child elements.
Rotation
Applies a Rotation to the view item. Use the inline construction for this element.
Scale
A Vector3 structure that applies a scaling factor to the view item. Use the inline construction for this element.
SizingPolicy
Specifies how to size the image based on content. This value must be a member of the SizingPolicy enumeration.
VerticalAlignment
Specifies the vertical alignment of the image within the layout rectangle. This value must be a member of the ItemAlignment enumeration.
Visible
Indicates whether the view item is visible.
Public Instance Methods
Method	Description
AttachAnimation
Dynamically adds an animation to the view item.
DetachAnimation
Dynamically removes an animation from the view item.
ForceContentChange
Manually forces a content change for animations.
NavigateInto
Requests navigation into the view item to send focus to the view item or one of its children.

Remarks
Windows Media Center displays default placeholder images when images are being downloaded and when an error occurs during download. Windows Media Center Presentation Layer applications can use the AcquiringImage and ErrorImage attributes of the Graphic element to specify custom images, provided these images are referenced locally.
Windows Media Center Presentation Layer Web applications must use the default placeholder images because these applications cannot access local resources due to security concerns. These applications also cannot specify custom Web images because they would need to be downloaded first; that is when the placeholders are displayed. However, you can choose to turn off the default placeholders and display something other than an image, such as a colorfill.
Locally-installed Windows Media Center Presentation Layer applications can choose to specify local files or Web-based files for error and acquiring images, or not specify anything and rely on default error and acquiring images. When specifying local files, if the files do not exist, the MCML parser displays an error and the application fails to start. When specifiying Web-based files, if the files do not exist, the MCML parser automatically substitutes the default error and acquiring images.
Animated GIFs are not supported in MCML.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# GridLayout Element
Defines a virtual flow that enables a layout of virtualized content. This element supports item reference sizes to allocate room for content that is not yet available.
Syntax
<GridLayout
    AllowWrap="{true | false}"
    Columns="int"
    MajorAlignment="{Center | Far | Near}"
    MinorAlignment="{Center | Far | Near}"
    Orientation="{Horizontal | Vertical}"
    ReferenceSize="Size"
    Repeat="{Always | Never | WhenTooBig | WhenTooSmall}"
    RepeatGap="int"
    Rows="int"
    Spacing="Size"
/>

Attributes
AllowWrap
Indicates whether to allow wrapping.
FocusReferenceSize
Specifies the number of columns for this grid.
MajorAlignment
Specifies the alignment within the ReferenceSize along the major axis, which must be a member of the StripAlignment enumeration.
MinorAlignment
Specifies the alignment for items within the ReferenceSize along the minor axis, which must be a member of the StripAlignment enumeration.
Orientation
Specifies the layout flow orientation, which must be a member of the Orientation enumeration.
ReferenceSize
Indicates the maximum Size of an individual item.
Repeat
Specifies when to repeat items. This value must be a member of the RepeatPolicy enumeration. When enabled, items being flowed will infinitely repeat in either direction, preventing the user from reaching the end of the list.
RepeatGap
When Repeat is enabled, specifies the distance between repeated instances.
Rows
Specifies the number of rows for this grid.
Spacing
Specifies a Size structure that indicates the spacing between each item in the flow.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
•	Repeater Element
•	VirtualList Class
# HandleException Element
Defines an exception handler for an Invoke, Set, or Command object.
Syntax
<HandleException
    ExceptionHandler="ObjectPath element"
    ExceptionType="string"
/>

Attributes
ExceptionHandler
An object path in the form [ObjectName.Member] that indicates the object that is associated with the exception handler.
ExceptionType
Indicates the full namespace-qualified name of the exception to catch.
Requirements
Platform: Windows 7
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# Host Element
Hosts a child UI.
Syntax
<Host
    Alpha="float"
    CenterPointOffset="Vector3"
    CenterPointPercent="Vector3"
    ColorFilter="Color"
    DebugOutline="Color"
    FocusOrder="int"
    InputEnabled="{true | false}"
    Layout="{Anchor | Center | Dock | Fill | Form | Grid | HorizontalFlow | Rotate | Scale | VerticalFlow}"
    LayoutInput="LayoutInput"
    Margins="Inset"
    MaximumSize="Size"
    MinimumSize="Size"
    MouseInteractive="{true | false}"
    Name="string"
    Navigation="NavigationPolicies enumeration"
    Padding="Inset"
    Rotation="Rotation"
    Scale="Vector3"
    Source="string"
    Status="{Error | Loading | Success}"
    ThrowOnLoadError="{true | false}"
    Visible="{true | false}"
>
    <Animations />
    <Children />
    <Errors />
    <Layout />
    <LayoutInput />
</Host>

Attributes
Alpha
Specifies the opacity value for the view item. This value must be between 0.0 and 1.0.
Animations
Contains a list of elements that describe an animation. Possible elements are:
Animation
MergeAnimation
SwitchAnimation
TransformAnimation
TransformByAttributeAnimation
CenterPointOffset
Specifies a center point adjustment based on a pixel-offset value when applying a scale or rotation to the view item. This value is applied after the CenterPointPercent value has been applied if both are provided. Use the inline construction for the Vector3 structure.
CenterPointPercent
Specifies a center point adjustment based on a percentage value when applying a scale or rotation to the view item. This value must be between 0 and 1, where a value of 1 equals 100%. Use the inline construction for the Vector3 structure.
Children
Specifies the child elements for a view item. Possible child elements are:
Clip
ColorFill
Graphic
Host
Panel
Repeater
Scroller
Text
Video
ColorFilter
Indicates the Color filter to apply on top of the color of the view item.
DebugOutline
Enables and sets the Color of the debugging outline of the view item.
Errors
Lists reported error strings if the source failed to load.
FocusOrder
Specifies relative priorities to sibling view items within the container for determining which item has default focus when entering a UI. Values can range from 0 (the highest priority) to Int32.MaxValue (the lowest priority and the default).
InputEnabled
Indicates whether the hosted UI input is enabled.
Layout
Specifies the current layout associated with this view item. You can use the inline construction, or expanded syntax with the following child elements that define a layout:
AnchorLayout
DockLayout
FlowLayout
GridLayout
RotateLayout
ScaleLayout
LayoutInput
Specifies the layout input for use by parent layouts. You can use the inline construction to specify a reference to a layout element, or use expanded syntax with the following child elements that define input:
AnchorLayoutInput
DockLayoutInput
FormLayoutInput
Margins
An Inset structure that specifies extra spacing around the view item.
MaximumSize
Specifies the maximum Size, in pixels. If a maximum size is not specified or the maximum size is set to zero, the size will not be restricted.
MinimumSize
Specifies the minimum Size, in pixels. If a maximum size is not specified or the maximum size is set to zero, the size will not be restricted.
MouseInteractive
Determines whether the view item can receive and react to mouse input.
Name
Identifies this element.
Navigation
Specifies how the view item should behave during directional navigation. This value must be a member of the NavigationPolicies enumeration.
Padding
An Inset structure that specifies the extra spacing, in pixels, between the view item and its child elements.
Rotation
Applies a Rotation to the view item. Use the inline construction for this element.
Scale
A Vector3 structure that applies a scaling factor to the view item. Use the inline construction for this element.
Source
Contains the prefixed name or URI of the UI to create and host.
Status
Indicates the load status of the current source. This value is a member of the LoadResultStatus enumeration. This value is read-only.
ThrowOnLoadError
Indicates whether to throw an exception on failure to load source.
Visible
Indicates whether the view item is visible.
Public Instance Methods
Method	Description
AttachAnimation
Dynamically adds an animation to the view item.
Cancel
Cancels the current load of the source.
DetachAnimation
Dynamically removes an animation from the view item.
ForceContentChange
Manually forces a content change for animations.
ForceRefresh
Forces the UI to reload.
NavigateInto
Requests navigation into the view item to send focus to the view item or one of its children.

Remarks
Host is a frequently used view item, although it is not typically used explicitly as <Host/>. Any child UI placed within the Content attribute of a UI is a Host view item.
For example, this type of markup is very common:
<Mcml xmlns:ctl="file://Scenarios.SimpleButton.mcml">
...
    <ctl:SimpleButton Command="[Command]"/>

In reality, it is actually the following:
<Host
    Source="file://Scenarios.SimpleButton.mcml#SimpleButton"
    Command="[Command]"/>

Accessing the Source property on a Host element at run-time enables you to dynamically swap out child UIs at run-time.
Note   Unless dynamic source swapping is intended, it is never recommended to use the full Host syntax. When the full Host syntax is used, all parse-time validation is lost for that Host (such as source and parameter type validation) as well as load-time Host source optimizations.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# Index Element
Represents the current data and virtual index when repeating a data set.
Syntax
<Index
    SourceValue="int"
    Value="int"
/>

Attributes
SourceValue
Indicates the integer index within the original repeated data set. This value is read-only.
Value
Indicates the integer index value (this is a virtual index that accounts for repeat wrapping). This value is read-only.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
•	Repeater Element

# Input Element
Used to access input-related state and events within a UI.
Syntax
<Input
    AllowDoubleClicks="{true | false}"
    CreateInterestOnFocus="{true | false}"
    CreateInterestTarget="string"
    DeepKeyFocus="{true | false}"
    DeepMouseFocus="{true | false}"
    Enabled="{true | false}"
    FullyEnabled="{true | false}"
    KeyFocus="{true | false}"
    KeyFocusOnMouseDown="{true | false}"
    KeyFocusOnMouseEnter="{true | false}"
    KeyInteractive="{true | false}"
    KeyRepeatThreshold="uint"
    MakeTopmostOnFocus="{true | false}"
    MouseFocus="{true | false}"
/>

Attributes
AllowDoubleClicks
Specifies whether double-clicks should be tracked.
CreateInterestOnFocus
Specifies whether this is an "area of interest" when focused.
CreateInterestTarget
Specifies the UI to apply interest to when CreateInterestOnFocus is enabled.
DeepKeyFocus
Indicates whether the current view item has deep key focus (this object or any of its children has key focus). This value is read-only.
DeepMouseFocus
Indicates whether the current view item has deep mouse focus (this object or any of its children has mouse focus). This value is read-only.
Enabled
Specifies whether the UI is enabled for mouse and keyboard input.
FullyEnabled
Indicates whether the current UI is fully enabled (this and all parents are enabled). This value is read-only.
KeyFocus
Indicates whether the current view item has key focus. This value is read-only.
KeyFocusOnMouseDown
Determines whether the current view item should try to automatically take key focus whenever a mouse button is pressed.
KeyFocusOnMouseEnter
Determines whether the current view item should try to automatically take key focus whenever mouse focus is gained.
KeyInteractive
Specifies whether this view item can accept key focus.
KeyRepeatThreshold
Specifies the threshold for the minimum number of milliseconds allowed to occur between repeated key events. Repeats that occur before the threshold has passed are ignored.
MakeTopmostOnFocus
Specifies whether, when the keyboard is focused, the focused item will be painted on top of all others on the top-most layer.
Note   This setting is only applied to view items for which KeyFocus is true; that is, when the view item has focus but not when any of its children gain focus.
MouseFocus
Indicates whether the current view item has mouse focus. This value is read-only.
Remarks
If a view item has key focus, it also has deep key focus. If a child of the view item has focus, it has deep key focus but not key focus.
Input is a reserved word and the Input element tag is not used directly. The Input element is always used as a source or a target in a rule, and you must use object paths to access its properties. For an example of how the Input element is used, see Working with Input Handlers and the Sample Explorer.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# Interpolation Element
Estimates intermediate values between two keyframes.
Syntax
<Interpolation
    BezierHandle1="float"
    BezierHandle2="float"
    EasePercent="float"
    Type="{Bezier | Cosine | EaseIn | EaseOut | Exp | Linear | Log | SCurve | Sine}"
    Weight="float"
/>

Inline Syntax
Interpolation="Type"
Interpolation="Type,Weight"
Interpolation="Type,Value1,Value2"

Attributes
BezierHandle1
Specifies Bezier interpolation handle 1.
BezierHandle2
Specifies Bezier interpolation handle 2.
EasePercent
Specifies the time at which to transition between keyframes, defined as a percentage.
Type
Specifies the interpolation type, which must be a member of the InterpolationType enumeration.
Weight
Specifies the weight of this interpolation as compared to a Linear interpolation. This attribute can be applied to Exp, Log, SCurve, EaseIn, and EaseOut interpolation types.
Requirements
This value is based on a percentage value between 0 and 1, where a value of 1 equals 100%.  
Value1
Specifies Bezier interpolation handle 1 or the EaseIn/Out interpolation weight.
Value2
Specifies Bezier interpolation handle 2 or the EaseIn/Out time percentage.
Remarks
A Weight of 0 for any interpolation is the same as a Linear interpolation. A Weight of 1 has no effect and is the same as the unmodified interpolation. Values greater than 1 exaggerate the interpolation.
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# Invoke Element
Specifies a rule action that invokes a method.
Syntax
<Invoke
    ExclusiveApply="{true | false}"
    InvokePolicy="InvokePolicy enumeration"
    ResultTarget="ObjectPath element"
    Target="ObjectPath element"
    Transformer="object"
 >
    <HandleExceptions />
    <Transformer />
</Invoke>

Attributes
ExclusiveApply
Specifies whether to continue applying actions to this target after an application of this action.
HandleExceptions
Indicates the HandleException exception handler defined for this object.
InvokePolicy
Specifies how to invoke the target. This value must be a member of the InvokePolicy enumeration.
ResultTarget
An object path in the form [ObjectName.Member] that specifies the location to store results.
Target
An object path in the form [ObjectName.Member] that specifies the action target.
Transformer
Indicates a data converter for the result value before it is set on the result target. You can use inline or expanded construction. Possible transformer elements include:
BooleanTransformer
DateTimeTransformer
FormatTransformer
MathTransformer
TimeSpanTransformer
Remarks
If a command is passed in as a property, you can invoke it by calling the Command.Invoke method.
For example, the following property contains a command:
<me:Menu Command="[somecommand]"/>

The Target attribute of the Invoke element invokes the command as follows:
    <Actions>
        <Invoke Target="[Command.Invoke]"/>
    </Actions>

For an example of how to pass parameters to the command, see the Markup.Rules.CustomRule.InvokeAction.mcml sample in the Sample Explorer.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# InvokeCommand Element
Invokes an arbitrary method and can be used wherever commands are accepted.
Syntax
<InvokeCommand
    ResultTarget="ObjectPath element"
    Target="ObjectPath element"
    Transformer="object"
 >
    <HandleExceptions />
    <Transformer />
</InvokeCommand>

Attributes
HandleExceptions
Indicates the HandleException exception handler defined for this object.
ResultTarget
An object path in the form [ObjectName.Member] that specifies the location to store the result.
Target
An object path in the form [ObjectName.Member] that specifies the method to invoke.
Transformer
Indicates a data converter for the result value before it is set on the result target. You can use inline or expanded construction. Possible transformer elements include:
BooleanTransformer
DateTimeTransformer
FormatTransformer
MathTransformer
TimeSpanTransformer
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier

# IsType Element
Defines a rule condition based on whether a source is a given type.
Syntax
<IsType
    Source="ObjectPath element"
    Type="Type object"
/>

Attributes
Source
An object path in the form [ObjectName.Member] that indicates the source of the condition.
Type
Type object to check against. For more information, see Type Class on the MSDN Web site.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# IsValid Element
Defines a rule condition based on whether a source can be queried without error (for example, there are no null values).
Syntax
<IsValid
    Source="ObjectPath element"
/>

Attributes
Source
An object path in the form [ObjectName.Member] that indicates the source of the condition.
Remarks
Check to make sure that the entire path can be evaluated (without encountering nulls mid-path).
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# KeyHandler Element
An event handler that provides keystroke input behavior to a UI object.
Syntax
<KeyHandler
    Command="ICommand object"
    Handle="{true | false}"
    HandlerStage="{Bubbled | Direct | Routed}"
    Key="KeyHandlerKey enumeration"
    Modifiers="{Alt | Control | None | Shift | Windows}"
    Pressing="{true | false}"
    Repeat="{true | false}"
/>

Attributes
Command
An ICommand object associated with the key handler. The invoke method for the command is called when a keystroke event occurs.
Handle
Indicates whether the handler will allow the event to pass on to other event handlers after handling the event. A value of true prevents the event from being passed on to other event handlers, and a value of false allows the event to continue.
HandlerStage
A member of the InputHandlerStage enumeration that indicates the stage in the event handling process when the event will be handled.
Key
Specifies the key to handle events for. This value must be a member of the KeyHandlerKey enumeration.
Modifiers
Modifier that must be pressed along with the key to invoke the command associated with the key handler. This must be a value from the KeyHandlerModifiers enumeration.
Pressing
Indicates whether the key is currently being pressed. This value is read-only.
Note   This attribute does not clear its state when its UI loses key focus. For more information, see the Remarks section.
Repeat
Indicates whether the key handler will be invoked multiple times when the key is held down.
Public Instance Events
Event	Description
Invoked
Notification that is sent for the keystroke event.

Remarks
The Pressing event should be used when you want to change state while a key is being pressed. However, if you want to take an action that is based on a key being pressed, such as navigation, you should use the Invoked event instead. The KeyHandler element maintains a flag that indicates whether the key is currently being pressed. However, if an action such as focus navigation occurs during the Pressing event, the KeyHandler does not update the flag, and it may require two key presses to raise the Pressing event again. For an example of using the Pressing and Invoked events with a KeyHandler, see Working with Input Handlers.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# MajorMinor Element
Defines a two-dimensional vector.
Syntax
<MajorMinor
    Major="int"
    Minor="int"
/>

Inline Syntax
MajorMinor="Major,Minor"

Attributes
Major
Specifies the major value.
Minor
Specifies the minor value.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# MathTransformer Element
Defines a mathematical conversion.
Syntax
<MathTransformer
    Absolute="{true | false}"
    Add="float"
    AddInt="int"
    Divide="float"
    DivideInt="int"
    Mod="float"
    ModInt="int"
    Multiply="float"
    MultiplyInt="int"
    Sign="{true | false}"
    Subtract="float"
    SubtractInt="int"
    Type="TypeCode enumeration"
/>

Attributes
Absolute
Indicates whether the result is an absolute value.
Add
Specifies a float value to add.
AddInt
Specifies an int value to add.
Divide
Specifies a float value to divide by.
DivideInt
Specifies an int value to divide by.
Mod
Specifies a float value for the modulo operation.
ModInt
Specifies an int value for the modulo operation.
Multiply
Specifies a float value to multiply by.
MultiplyInt
Specifies an int value to multiply by.
Sign
Indicates whether to include the sign.
Subtract
Specifies a float value to subtract.
SubtractInt
Specifies an int value to subtract.
Type
Sets the return type. This value must be a member of the TypeCode enumeration. For more information, see TypeCode Enumeration on the MSDN Web site.
Remarks
The MathTransformer element allows you to manipulate numeric values by applying math operators (Add, Subtract, Multiply, Divide, Modulo, Absolute, and Sign). The MathTransformer element can also apply a numeric type conversion to the end result. There are "int" versions of these properties to support integer operations.
MathTransformer applies the operators you specify in the following order:
1.	Multiplication
2.	Division
3.	Addition
4.	Subtraction
5.	Modulus
6.	Absolute
7.	Sign
8.	Type
The target of the MathTransformer must accept the same type as the original value or the converted type if a conversion was specified.
You cannot perform one conversion after another on the same variable in a chain. To perform multiple conversions, you can transform the value to an intermediate local and then bind that value to your target using another transformer, or use multiple actions on the same variable using a rule.
Example Code
<Mcml
  xmlns="http://schemas.microsoft.com/2006/mcml"
  xmlns:cor="assembly://MSCorLib/System">

  <UI Name="MathTransformer">
    <Locals>
      <cor:Int32  Name="Value" Int32="6" />
    </Locals>

    <Rules>
      <!-- This performs the following operation: -->
      <!-- (6 * 4) / 8 = 3 -->
      <!-- Note that multiplication precedes division, regardless of the order you specify them. -->
      <Binding Source="[Value]" Target="[Label.MaximumLines]">
        <Transformer>
          <MathTransformer DivideInt="8" MultiplyInt="4" />
        </Transformer>
      </Binding>
    </Rules>

    <Content>
      <ColorFill Content="Firebrick" MaximumSize="200,200">
        <Children>
          <Text Name="Label" Content="Only three lines worth of this text will be displayed."
                Color="White" Font="Verdana, 20" MaximumLines="[Value]" WordWrap="true"/>
        </Children>
      </ColorFill>
    </Content>

  </UI>
</Mcml>

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# Mcml Element
The top-level root tag of a Windows Media Center Presentation Layer markup document.
Syntax
<Mcml
    xmlns:namespace="resource"
/>

Attributes
xmlns
Specifies a resource to load. For example, to load a particular UI from another MCML file, use the statement xmlns:xyz="filename.mcml#UIName".
Remarks
The most common top-level element within an MCML resource is the UI element. However, you can use any .NET object at the top level. The object must be named and placed in a markup library. Markup libraries are typically used for accessing common objects, such as images, from one location.
Markup libraries are not global. Namespaces are available to avoid name collisions. Libraries are per-MCML resource, so namespaced library access is required. Use the following syntax to access a library:
library://namespace:identifier

You can use this syntax as a value to any property that accepts that type. For example, you can specify an image library (image://me:MyLogo), and then use it as a value in the Content property of the Graphic element, which specifies an image.
The set of predefined libraries are as follows.
Library	Description
Image (image://)	Stores Image types.
Sound (sound://)	Stores Sound types.
Font (font://)	Stores Font types.
Color (color://)	Stores Color types.
Animation (animation://)	Stores Animation types.
Global (global://)	Stores all other types.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# MergeAnimation Element
Combines multiple source animations into one.
Syntax
<MergeAnimation
    Type="{Alpha | ContentChangeHide | ContentChangeShow | GainFocus | Hide | Idle | LoseFocus | Move | Rotate | Scale | Show | Size}"
>
    <Sources />
</MergeAnimation>

Attributes
Sources
Contains the list of elements that will be merged together, which can be of the following types:
Animation
MergeAnimation
TransformAnimation
TransformByAttributeAnimation
Type
Indicates the type of event that this animation will respond to. This value must be a member of the AnimationEventType enumeration.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier

# Modified Element
Determines whether a given source was modified.
Syntax
<Modified
    InitialEvaluate="{true | false}"
    Source="ObjectPath element"
/>

Attributes
InitialEvaluate
Indicates the initial evaluation value during startup.
Source
An object path in the form [ObjectName.Member] that indicates the source of the condition.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# MouseWheelHandler Element
An event handler that provides mouse/wheel input behavior to a UI object.
Syntax
<MouseWheelHandler
    Handle="{true | false}"
    HandlerStage="{Bubbled | Direct | Routed}"
/>

Attributes
Handle
Indicates whether the handler will allow the event to pass on to other event handlers after handling the event.
HandlerStage
A member of the InputHandlerStage enumeration indicating the stage in the event handling process when the event will be handled.
Public Instance Events
Event	Description
DownInvoked
Notification that is sent for the wheel down event.
UpInvoked
Notification that is sent for the wheel up event.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# Navigate Element
Defines an action to navigate to a specified destination MCML resource in response to a rule.
Syntax
<Navigate
    Data="IDictionary"
    Source="object"
/>

Attributes
Data
Specifies additional data for the URI request. This value is read-only.
Source
Specifies an MCML URI to navigate to.
Remarks
Both the Navigate and NavigateCommand elements support http-based navigation targets. In addition, you can specify GET and POST http requests, and, using object paths, you can refer to data from anywhere in your UI.
Because an MCML file can contain multiple UIs, you can navigate to a specific UI within that file using the # syntax, which identifes a UI by name. If no specific UI is called out, the first in the file is used.
<Navigate Source="@file://Filename.mcml#UIName" />

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
•	Web-Based Navigation

# NavigateCommand Element
Defines an action to navigate to a specified destination MCML resource in response to a command. This element is similar to the Navigate element, but NavigateCommand can be used wherever commands are accepted.
Syntax
<NavigateCommand
    Source="object"
/>

Attributes
Source
Specifies an MCML URI to navigate to.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
•	Web-Based Navigation
# NowPlaying Element
Defines a placeholder item that indicates where to display the Now Playing inset.
Syntax
<NowPlaying
    IsActive="{true | false}"
    ShowFullMetadata="{Always | Default | Never | OnFocus}"
    SnapToDefaultPosition="{true | false}"
/>

Attributes
IsActive
Indicates whether there is currently an active Now Playing inset. This value is read-only.
ShowFullMetadata
Specifies the metadata display policy. This value must be a member of the MetadataVisibility enumeration.
When this attribute is set to "Always", the minimum size of the inset is 735 x 132 pixels. When set to "Never", the inset requires 176 x 132 pixels. If you override the default minimum size, be careful to allow adequate space or the view item may not be displayed correctly or may not be displayed at all.
SnapToDefaultPosition
Determines whether the Now Playing inset should snap to its default location (the same position that Media Center uses for the Now Playing inset). If set to true and the Now Playing inset was laid out to a position close to it, the Now Playing inset will be placed in its default position.
Remarks
The placeholder itself has no visual appearance. The Now Playing inset will automatically track the placeholder's visibility and position.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier

# ObjectPath Element
Represents an artibrary object path with dot-into object support.
Syntax
<ObjectPath
    ObjectPath="object path"
/>

Attributes
ObjectPath
Specifies the object path in the form [ObjectName.Member].
Remarks
Object paths are most often referred to using the inline syntax such as "[A.B.C]", rather than using the expanded syntax.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier

# Panel Element
Defines a non-drawing layout container.
Syntax
<Panel
    Alpha="float"
    CenterPointOffset="Vector3"
    CenterPointPercent="Vector3"
    ColorFilter="Color"
    DebugOutline="Color"
    FocusOrder="int"
    Layout="{Anchor | Center | Dock | Fill | Form | Grid | HorizontalFlow | Rotate | Scale | VerticalFlow}"
    LayoutInput="LayoutInput"
    Margins="Inset"
    MaximumSize="Size"
    MinimumSize="Size"
    MouseInteractive="{true | false}"
    Name="string"
    Navigation="NavigationPolicies enumeration"
    Padding="Inset"
    Rotation="Rotation"
    Scale="Vector3"
    Visible="{true | false}"
>
    <Animations />
    <Children />
    <Layout />
    <LayoutInput />
</Panel>

Attributes
Alpha
Specifies the opacity value for the view item. This value must be between 0.0 and 1.0.
Animations
Contains a list of elements that describe an animation. Possible elements are:
Animation
MergeAnimation
SwitchAnimation
TransformAnimation
TransformByAttributeAnimation
CenterPointOffset
Specifies a center point adjustment based on a pixel-offset value when applying a scale or rotation to the view item. This value is applied after the CenterPointPercent value has been applied if both are provided. Use the inline construction for the Vector3 structure.
CenterPointPercent
Specifies a center point adjustment based on a percentage value when applying a scale or rotation to the view item. This value must be between 0 and 1, where a value of 1 equals 100%. Use the inline construction for the Vector3 structure.
Children
Specifies the child elements for a view item. Possible child elements are:
Clip
ColorFill
Graphic
Host
Panel
Repeater
Scroller
Text
Video
ColorFilter
Indicates the Color filter to apply on top of the color of the view item.
DebugOutline
Enables and sets the Color of the debugging outline of the view item.
FocusOrder
Specifies relative priorities to sibling view items within the container for determining which item has default focus when entering a UI. Values can range from 0 (the highest priority) to Int32.MaxValue (the lowest priority and the default).
Layout
Specifies the current layout associated with this view item. You can use the inline construction or expanded syntax with the following child elements that define a layout:
AnchorLayout
DockLayout
FlowLayout
GridLayout
RotateLayout
ScaleLayout
LayoutInput
Specifies the layout input for use by parent layouts. You can use the inline construction to specify a reference to a layout element, or use expanded syntax with the following child elements that define input:
AnchorLayoutInput
DockLayoutInput
FormLayoutInput
Margins
An Inset structure that specifies extra spacing outside the boundaries of the view item.
MaximumSize
Specifies the maximum Size, in pixels. If a maximum size is not specified or the maximum size is set to zero, the size will not be restricted.
MinimumSize
Specifies the minimum Size, in pixels. If a maximum size is not specified or the maximum size is set to zero, the size will not be restricted.
MouseInteractive
Determines whether the view item can receive and react to mouse input.
Name
Identifies this element.
Navigation
Specifies how the view item should behave during directional navigation. This value must be a member of the NavigationPolicies enumeration.
Padding
An Inset structure that specifies the extra spacing, in pixels, between the view item and its child elements.
Rotation
Applies a Rotation to the view item. Use the inline construction for this element.
Scale
A Vector3 structure that applies a scaling factor to the view item. Use the inline construction for this element.
Visible
Indicates whether the view item is visible.
Public Instance Methods
Method	Description
AttachAnimation
Dynamically adds an animation.
DetachAnimation
Dynamically removes an animation from the view item.
ForceContentChange
Manually forces a content change for animations.
NavigateInto
Requests navigation into the view item to send focus to the view item or one of its children.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# PlayAnimation Element
Defines a rule action to play animation.
Syntax
<PlayAnimation
    ExclusiveApply="{true | false}"
    Target="ObjectPath element"
>
    <Animation />
</PlayAnimation>

Attributes
Animation
Specifies the animation to play.
The following child element is possible:
Animation
ExclusiveApply
Specifies whether to continue applying actions to this target after an application by this action.
Target
An ObjectPath obect that specifies the action target.
Remarks
To ensure that rules match conditions for PlayAnimation and PlaySound actions, only put these actions within a Condition that uses ConditionOp="ChangedTo".
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# PlaySound Element
Defines an action to play a sound.
Syntax
<PlaySound
    Sound="object"
/>

Attributes
Sound
Specifies the sound to play.
Remarks
To ensure that rules match conditions for PlayAnimation and PlaySound actions, only put these actions within a Condition that uses ConditionOp="ChangedTo".
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# PositionKeyframe Element
Defines a position keyframe for an animation.
Syntax
<PositionKeyframe
    Interpolation="Interpolation element"
    RelativeTo="{Absolute | Current | Final}"
    Time="float"
    Value="Vector3"
/>

Attributes
Interpolation
Specifies the Interpolation from this keyframe to the next. Use the inline construction for this element.
RelativeTo
A member of the KeyframeValueReference enumeration that specifies how to interpret the keyframe's value.
Time
Specifies the time, in seconds, at which this keyframe occurs.
Value
A Vector3 obect that specifies the keyframe value.
Remarks
Animations require at least two keyframes of the same type (for example, two AlphaKeyFrames). With only one keyframe, there is no beginning or end and therefore nothing to animate. In addition, the first keyframe must start at Time="0".
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# Repeater Element
Repeats a markup based on a given dataset.
Syntax
<Repeater
    Alpha="float"
    CenterPointOffset="Vector3"
    CenterPointPercent="Vector3"
    ColorFilter="Color"
    ContentName="string"
    ContentSelectors="IList"
    DebugOutline="Color"
    DefaultFocusIndex="int"
    DiscardOffscreenVisuals="{true | false}"
    DividerName="string"
    FocusOrder="int"
    Layout="{Anchor | Center | Dock | Fill | Form | Grid | HorizontalFlow | Rotate | Scale | VerticalFlow}"
    LayoutInput="LayoutInput"
    Margins="Inset"
    MaximumSize="Size"
    MinimumSize="Size"
    MouseInteractive="{true | false}"
    Name="string"
    Navigation="NavigationPolicies enumeration"
    Padding="Inset"
    Rotation="Rotation"
    Scale="Vector3"
    Source="IList"
    Visible="{true | false}"
>
    <Animations />
    <Children />
    <Content />
    <Divider />
    <Layout />
    <LayoutInput />
</Repeater>

Attributes
Alpha
Specifies the opacity value for the view item. This value must be between 0.0 and 1.0.
Animations
Contains a list of elements that describe an animation. Possible elements are:
Animation
MergeAnimation
SwitchAnimation
TransformAnimation
TransformByAttributeAnimation
CenterPointOffset
Specifies a center point adjustment based on a pixel-offset value when applying a scale or rotation to the view item. This value is applied after the CenterPointPercent value has been applied if both are provided. Use the inline construction for the Vector3 structure.
CenterPointPercent
Specifies a center point adjustment based on a percentage value when applying a scale or rotation to the view item. This value must be between 0 and 1, where a value of 1 equals 100%. Use the inline construction for the Vector3 structure.
Children
Specifies the child elements for a view item. Possible child elements are:
Clip
ColorFill
Graphic
Host
Panel
Repeater
Scroller
Text
Video
ColorFilter
Indicates the Color of the filter to apply on top of the color of the view item.
Content
A property that specifies the visual content to repeat, which can be one of the following elements (only one direct child of a Content element is allowed):
Clip
ColorFill
Graphic
Host
NowPlaying
Panel
Repeater
Scroller
Text
Video
ContentName
Contains the visual content to repeat (non-inline form). Content comes from a named Content element elsewhere in the UI.
ContentSelectors
List of content selectors for non-homogeneous repeating. The list is read-only (although you can modify the contents of the list).
DebugOutline
Enables and sets the Color of the debugging outline of the view item.
DefaultFocusIndex
Specifies the item that should be given a preferential focus order when repeated. Setting this property does not force the specified item to be repeated.
DiscardOffscreenVisuals
Specifies to remove visuals that go offscreen.
Divider
The visual content to insert between repeated items. Divider is the root of a tree of visual primitives:
Clip
ColorFill
Graphic
Host
Panel
Scroller
Text
DividerName
Contains the visual content to insert between repeated items (non-inline form). Divider comes from a named Content element.
FocusOrder
Specifies relative priorities to sibling view items within the container for determining which item has default focus when entering a UI. Values can range from 0 (the highest priority) to Int32.MaxValue (the lowest priority and the default).
Layout
Specifies the current layout associated with this view item. You can use the inline construction, or expanded syntax with the following child elements that define a layout:
AnchorLayout
DockLayout
FlowLayout
GridLayout
RotateLayout
ScaleLayout
LayoutInput
Specifies the layout input for use by parent layouts. You can use the inline construction to specify a reference to a layout element, or use expanded syntax with the following child elements that define input:
AnchorLayoutInput
DockLayoutInput
FormLayoutInput
Margins
An Inset structure that specifies extra spacing outside the boundaries of the view item.
MaximumSize
Specifies the maximum Size, in pixels. If a maximum size is not specified or the maximum size is set to zero, the size will not be restricted.
MinimumSize
Specifies the minimum Size, in pixels. If a maximum size is not specified or the maximum size is set to zero, the size will not be restricted.
MouseInteractive
Determines whether the view item can receive and react to mouse input.
Name
Identifies this element.
Navigation
Specifies how the view item should behave during directional navigation. This value must be a member of the NavigationPolicies enumeration.
Padding
An Inset structure that specifies the extra spacing, in pixels, between the view item and its child elements.
Rotation
Applies a Rotation to the view item. Use the inline construction for this element.
Scale
A Vector3 structure that applies a scaling factor to the view item. Use the inline construction for this element.
Source
Specifies the data to repeat.
Visible
Specifies whether the view item is visible.
Public Instance Methods
Method	Description
AttachAnimation
Dynamically adds an animation.
DetachAnimation
Dynamically removes an animation from the view item.
ForceContentChange
Manually forces a content change for animations.
NavigateInto
Requests navigation into the view item to send focus to the view item or one of its children.
NavigateIntoIndex
Sends keyboard focus to the child with the specified virtual index. This method attempts to create the item if it hasn't already been repeated.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# RotateKeyframe Element
Defines a rotation keyframe for an animation.
Syntax
<RotateKeyframe
    Interpolation="Interpolation element"
    RelativeTo="{Absolute | Current | Final}"
    Time="float"
    Value="Rotation"
/>

Attributes
Interpolation
Specifies the Interpolation from this keyframe to the next. Use the inline construction for this element.
RelativeTo
A member of the KeyframeValueReference enumeration that specifies how to interpret the keyframe's value.
Time
Specifies the time, in seconds, at which this keyframe occurs.
Value
Specifies a Rotation structure that indicates the axis rotation value. Use the inline construction for this element. For example: Value="0deg;0,0,1".
Remarks
Animations require at least two keyframes of the same type (for example, two AlphaKeyFrames). With only one keyframe, there is no beginning or end and therefore nothing to animate. In addition, the first keyframe must start at Time="0".
To avoid jagged edges around the edge of an image when you rotate it, create transparent borders on the image first. For more information, see Using Antialiasing and Transparent Borders for Animated Images.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# RotateLayout Element
Defines a rotation of 0, 90, 180, or 270 degrees for child elements.
Syntax
<RotateLayout
    AngleDegrees="{0 | 90 | 180 | 270}"
/>

Attributes
AngleDegrees
Specifies a rotation of 0, 90, 180, or 270 degrees.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# Rule Element
Defines the base rule for other rules. This element allows you to construct custom lists of conditions and actions.
Syntax
<Rule
    ConditionLogicalOp="{And | Or}"
>
    <Actions />
    <Conditions />
</Rule>

Attributes
Actions
Specifies actions for this rule. Possible actions include:
DebugTrace
Invoke
Navigate
PlayAnimation
PlaySound
Set
You can use the ArrayListDataSet class to populate a list from markup.
ConditionLogicalOp
Specifies a ConditionLogicalOp logical operator for rule-matching behavior.
Conditions
Lists the conditions for a rule. Possible conditions include:
Equality
IsType
IsValid
Modified
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# ScaleKeyframe Element
Defines a scale keyframe for an animation.
Syntax
<ScaleKeyframe
    Interpolation="Interpolation element"
    RelativeTo="{Absolute | Current | Final}"
    Time="float"
    Value="Vector3"
/>

Attributes
Interpolation
Specifies the Interpolation from this keyframe to the next. Use the inline construction for this element.
RelativeTo
A member of the KeyframeValueReference enumeration that specifies how to interpret the keyframe's value.
Time
Specifies the time, in seconds, at which this keyframe occurs.
Value
A Vector3 structure that specifies the keyframe value.
Note   When using a Z-coordinate of 0, Windows Media Center may not recognize when the user mouses over the view item. For example, a mouse click may not be captured.
Remarks
Animations require at least two keyframes of the same type (for example, two AlphaKeyFrames). With only one keyframe, there is no beginning or end and therefore nothing to animate. In addition, the first keyframe must start at Time="0".
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# ScaleLayout Element
Scales child elements up or down as specified.
Syntax
<ScaleLayout
    AllowScaleDown="{true | false}"
    AllowScaleUp="{true | false}"
    MaintainAspectRatio="{true | false}"
/>

Attributes
AllowScaleDown
Specifies whether large content should scale down to fit the constraint.
AllowScaleUp
Specifies whether small content should scale up to fit the constraint.
MaintainAspectRatio
Specifies whether x and y should scale equally.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# Scroller Element
Scrolls content.
Syntax
<Scroller
    Alpha="float"
    CenterPointOffset="Vector3"
    CenterPointPercent="Vector3"
    ColorFilter="Color"
    ColorMask="Color"
    DebugOutline="Color"
    FadeAmount="float"
    FadeSize="float"
    FarOffset="float"
    FocusOrder="int"
    FocusPadding="int"
    Layout="{Anchor | Center | Dock | Fill | Form | Grid | HorizontalFlow | Rotate | Scale | VerticalFlow}"
    LayoutInput="LayoutInput"
    Margins="Inset"
    MaximumSize="Size"
    MinimumSize="Size"
    MouseInteractive="{true | false}"
    Name="string"
    Navigation="NavigationPolicies enumeration"
    NearOffset="float"
    Orientation="{Horizontal | Vertical}"
    Padding="Inset"
    Prefetch="float"
    Rotation="Rotation"
    Scale="Vector3"
    ScrollingData="ScrollingData element"
    ShowFar="{true | false}"
    ShowNear="{true | false}"
    Visible="{true | false}"
>
    <Animations />
    <Children />
    <Layout />
    <LayoutInput />
</Scroller>

Attributes
Alpha
Specifies the opacity value for the view item. This value must be between 0.0 and 1.0.
Animations
Contains a list of elements that describe an animation. Possible elements are:
Animation
MergeAnimation
SwitchAnimation
TransformAnimation
TransformByAttributeAnimation
CenterPointOffset
Specifies a center point adjustment based on a pixel-offset value when applying a scale or rotation to the view item. This value is applied after the CenterPointPercent value has been applied if both are provided. Use the inline construction for the Vector3 structure.
CenterPointPercent
Specifies a center point adjustment based on a percentage value when applying a scale or rotation to the view item. This value must be between 0 and 1, where a value of 1 equals 100%. Use the inline construction for the Vector3 structure.
Children
Specifies the child elements for a view item. Only one child is allowed. Possible child elements are:
Clip
ColorFill
Graphic
Host
Panel
Repeater
Scroller
Text
Video
ColorFilter
Indicates the Color filter to apply on top of the color of the view item.
ColorMask
Defines what sort of Color effect the edge fade will have. By default it is an alpha fade.
DebugOutline
Enables and sets the Color of the debugging outline of the view item.
FadeAmount
Defines the severity of the fade based on a percentage value. This value must be between 0 and 1, where a value of 1 equals 100%.
FadeSize
Indicates the size of the clip fade, in pixels.
FarOffset
Specifies the offset for the far edge of the gradient (dependent on the orientation).
FocusOrder
Specifies relative priorities to sibling view items within the container for determining which item has default focus when entering a UI. Values can range from 0 (the highest priority) to Int32.MaxValue (the lowest priority and the default).
FocusPadding
Specifies the amount of space around the focus area to ensure it is in view.
Layout
Specifies the current layout associated with this view item. You can use the inline construction or expanded syntax with the following child elements that define a layout:
AnchorLayout
DockLayout
FlowLayout
GridLayout
RotateLayout
ScaleLayout
LayoutInput
Specifies the layout input for use by parent layouts. You can use the inline construction to specify a reference to a layout element, or use expanded syntax with the following child elements that define input:
AnchorLayoutInput
DockLayoutInput
FormLayoutInput
Margins
An Inset structure that specifies extra spacing outside the boundaries of the view item.
MaximumSize
Specifies the maximum Size, in pixels. If a maximum size is not specified or the maximum size is set to zero, the size will not be restricted.
MinimumSize
Specifies the minimum Size, in pixels. If a maximum size is not specified or the maximum size is set to zero, the size will not be restricted.
MouseInteractive
Determines whether the view item can receive and react to mouse input.
Name
Identifies this element.
Navigation
Specifies how the view item should behave during directional navigation. This value must be a member of the NavigationPolicies enumeration.
NearOffset
Specifies the offset for the near edge of the gradient (dependent on the orientation).
Orientation
Specifies the orientation of the scrolling. This value must be a member of the Orientation enumeration.
Padding
An Inset structure that specifies the extra spacing, in pixels, between the view item and its child elements.
Prefetch
Amount of area beyond the visible scrolling area to have content ready.
Rotation
Applies a Rotation to the view item. Use the inline construction for this element.
Scale
A Vector3 structure that applies a scaling factor to the view item. Use the inline construction for this element.
ScrollingData
Specifies a reference to a ScrollingData element that defines the scroller configuration.
ShowFar
Indicates whether to display the far fade.
ShowNear
Indicates whether to display the near fade.
Visible
Indicates whether the view item is visible.
Public Instance Methods
Method	Description
AttachAnimation
Dynamically adds an animation.
DetachAnimation
Dynamically removes an animation from the view item.
ForceContentChange
Manually forces a content change for animations.
NavigateInto
Requests navigation into the view item to send focus to the view item or one of its children.

Remarks
A Scroller view item can have only one child.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# ScrollingData Element
Defines the data used for scrolling.
Syntax
<ScrollingData
    BeginPadding="int"
    BeginPaddingRelativeTo="{Far | Near}"
    CanScrollDown="{true | false}"
    CanScrollUp="{true | false}"
    CurrentPage="float"
    EndPadding="int"
    EndPaddingRelativeTo="{Far | Near}"
    LockedAlignment="float"
    LockedPosition="float"
    PageSizedScrollStep="{true | false}"
    PageStep="float"
    Repeater="Repeater element"
    ScrollStep="int"
    TotalPages="float"
/>

Attributes
BeginPadding
Specifies the amount of space around the beginning focus area to ensure it is in view.
BeginPaddingRelativeTo
Specifies the edge tothat BeginPadding is relative to. This value must be a member of the RelativeEdge enumeration.
CanScrollDown
Indicates whether the area allows scrolling down. This value is read-only.
CanScrollUp
Indicates whether the area allows scrolling up. This value is read-only.
CurrentPage
Indicates the current page. This value is read-only.
EndPadding
Specifies the amount of space around the end of the focus area to ensure it is in view.
EndPaddingRelativeTo
Specifies the edge that EndPadding is relative to. This value must be a member of the RelativeEdge enumeration.
LockedAlignment
Specifies the percentage of the focus rectangle to use when in LockedPosition mode.
LockedPosition
Specifies the percentage position within the viewing area that the focus will be locked to. For example, to fix the scrolling item to appear 30% away from the left of the scroller, specify ".3".
PageSizedScrollStep
Specifies whether to scroll a page at a time.
PageStep
Specifies the percentage of a page to scroll when using PAGE UP or PAGE DOWN.
Repeater
Specifies a reference to a Repeater element that specifies the target for focus-based keyboard-supported scrolling.
ScrollStep
Specifies the size of a single scroll step. This value is only applicable if the scroller contains non-focusable content (such as a block of text). The ScrollStep value is not used if the scroller contains view items that can receive focus individually.
TotalPages
Indicates the total number of pages. This value is read-only.
Public Instance Methods
Method	Description
End
Scrolls to the end.
Home
Scrolls to the beginning.
PageDown
Scrolls down one page.
PageUp
Scrolls up one page.
Scroll
Scrolls by exact amount.
ScrollDown
Scrolls down one step.
ScrollUp
Scrolls up one step.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# ScrollingHandler Element
Defines common scrolling input behavior for a UI object.
Syntax
<ScrollingHandler
    HandleDirectionalKeys="{true | false}"
    HandleHomeEndKeys="{true | false}"
    HandleMouseWheel="{true | false}"
    HandlePageCommands="{true | false}"
    HandlePageKeys="{true | false}"
    HandlerStage="{Bubbled | Direct | Routed}"
    ScrollingData="ScrollingData element"
/>

Attributes
HandleDirectionalKeys
Specifies whether to handle the UP, DOWN, LEFT, and RIGHT keys.
HandleHomeEndKeys
Specifies whether to handle the HOME and END keys.
HandleMouseWheel
Specifies whether to handle the mouse wheel.
HandlePageCommands
Specifies whether to handle the PAGE UP and PAGE DOWN commands.
HandlePageKeys
Specifies whether to handle the PAGE UP and PAGE DOWN keys.
HandlerStage
A member of the InputHandlerStage enumeration indicating the stage in the event handling process when the event will be handled.
This value should be Direct (the default) if the scroller does not contain focusable content. It should be Bubbled when using focus-based scrolling to interact with the child items of the scroller.
ScrollingData
Specifies a reference to a ScrollingData element that provides information to the handler.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# SecureTypingHandler Element
An event handler that provides secure editbox-like input behavior to a UI object. String values are encrypted. Display values are always masked.
Syntax
<SecureTypingHandler
    DisplayValue="string"
    EditableText="EditableText object"
    HandlerStage="{Bubbled | Direct | Routed}"
    MaxLength="int"
    Name="string"
    Value="string"
/>

Attributes
DisplayValue
Returns the current value and is always password masked. This value is read-only.
EditableText
EditableText object associated with the typing handler. The typing handler uses an EditableText object for configuration and storage.
HandlerStage
A member of the InputHandlerStage enumeration indicating the stage in the event handling process when the event will be handled.
MaxLength
Specifies the maximum number of characters.
Name
Contains the name.
Value
The value of the edit control, which is the confirmed value if TypingPolicy is TripleTap. When PasswordMasked is true, this value is the actual string that is entered.
Public Instance Events
Event	Description
TypingInputRejected
Notification that is sent when the typing input is rejected.

Requirements
Platform: Windows 7
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier

# Set Element
Defines an action in a rule that sets a value for a target.
Syntax
<Set
    ExclusiveApply="{true | false}"
    InvokePolicy="InvokePolicy enumeration"
    Target="ObjectPath element"
    Transformer="object"
    Value="object"
>
    <HandleExceptions />
    <Transformer />
</Set>

Attributes
ExclusiveApply
Specifies whether to continue applying actions to this target after an application by this action.
HandleExceptions
Indicates the HandleException exception handler defined for this object.
InvokePolicy
Policy on how the target should be set (default is synchronous), which must be a member of the InvokePolicy enumeration.
Target
An object path in the form [ObjectName.Member] that specifies the action target.
Transformer
Indicates a data converter. You can use inline or expanded construction. Possible transformer elements include:
BooleanTransformer
DateTimeTransformer
FormatTransformer
MathTransformer
TimeSpanTransformer
Value
Specifies the value to set.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# ShortcutHandler Element
An event handler that provides shortcut command-input behavior to a UI object.
Syntax
<ShortcutHandler
    Command="ICommand object"
    Handle="{true | false}"
    HandlerStage="{Bubbled | Direct | Routed}"
    Shortcut="ShortcutHandlerCommand enumeration"
/>

Attributes
Command
Specifies an ICommand object that is associated with the shortcut handler. The invoke method for the command is called when a shortcut command event occurs.
Handle
Indicates whether the handler will allow the event to pass on to other event handlers after handling the event.
HandlerStage
A member of the InputHandlerStage enumeration indicating the stage in the event handling process when the event will be handled.
Shortcut
Shortcut command to handle events for. This value must be a member of the ShortcutHandlerCommand enumeration.
Public Instance Events
Event	Description
Invoked
Notification that is sent when the shortcut command is issued.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# SizeKeyframe Element
Defines a size keyframe for an animation.
Syntax
<SizeKeyframe
    Interpolation="Interpolation element"
    RelativeTo="{Absolute | Current | Final}"
    Time="float"
    Value="Vector3"
/>

Attributes
Interpolation
Specifies the Interpolation from this keyframe to the next. Use the inline construction for this element.
RelativeTo
A member of the KeyframeValueReference enumeration that specifies how to interpret the keyframe's value.
Time
Specifies the time, in seconds, at which this keyframe occurs.
Value
A Vector3 structure that specifies the keyframe value indicating size.
Remarks
Animations require at least two keyframes of the same type (for example, two AlphaKeyFrames). With only one keyframe, there is no beginning or end and therefore nothing to animate. In addition, the first keyframe must start at Time="0".
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# SwitchAnimation Element
Not documented in this release.
Syntax
<SwitchAnimation
    Expression="IValueRange object"
    Options="IDictionary object"
    Type="{Alpha | ContentChangeHide | ContentChangeShow | GainFocus | Hide | Idle | LoseFocus | Move | Rotate | Scale | Show | Size}"
/>

Attributes
Expression
Specifies an IValueRange object that is queried to get the key into the Options dictionary.
Options
Specifies a dictionary of animations to choose from. The expression result maps to the dictionary key.
Type
Indicates the type of event that this animation will respond to. This value must be a member of the AnimationEventType enumeration.
Requirements
Platform: Windows 7
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# Text Element
Draws text.
Syntax
<Text
    Alpha="float"
    BackColor="Color"
    CenterPointOffset="Vector3"
    CenterPointPercent="Vector3"
    Color="Color"
    ColorFilter="Color"
    Content="string"
    DebugOutline="Color"
    FadeSize="float"
    FocusOrder="int"
    Font="Font element"
    HorizontalAlignment="{Center | Far | Near}"
    Layout="{Anchor | Center | Dock | Fill | Form | Grid | HorizontalFlow | Rotate | Scale | VerticalFlow}"
    LayoutInput="LayoutInput"
    Margins="Inset"
    MaximumLines="int"
    MaximumSize="Size"
    MinimumSize="Size"
    MouseInteractive="{true | false}"
    Name="string"
    Navigation="NavigationPolicies enumeration"
    Padding="Inset"
    Rotation="Rotation"
    Scale="Vector3"
    Visible="{true | false}"
    WordWrap="{true | false}"
>
    <Animations />
    <Children />
    <Layout />
    <LayoutInput />
</Text>

Attributes
Alpha
Specifies the opacity value for the view item. This value must be between 0.0 and 1.0.
Animations
Contains a list of elements that describe an animation. Possible elements are:
Animation
MergeAnimation
SwitchAnimation
TransformAnimation
TransformByAttributeAnimation
BackColor
Indicates the backgrond Color of the text.
CenterPointOffset
Specifies a center point adjustment based on a pixel-offset value when applying a scale or rotation to the view item. This value is applied after the CenterPointPercent value has been applied if both are provided. Use the inline construction for the Vector3 structure.
CenterPointPercent
Specifies a center point adjustment based on a percentage value when applying a scale or rotation to the view item. This value must be between 0 and 1, where a value of 1 equals 100%. Use the inline construction for the Vector3 structure.
Children
Specifies the child elements for a view item. Possible child elements are:
Clip
ColorFill
Graphic
Host
Panel
Repeater
Scroller
Text
Video
Color
Indicates the foreground Color of the text.
ColorFilter
Indicates the Color filter to apply on top of the color of the view item.
Content
Contains the text content. Rich Text Format (RTF) support is limited to multi-line formatted text.
DebugOutline
Enables and sets the Color of the debugging outline of the view item.
FadeSize
Indicates the size of the text ellipses fade, in pixels.
FocusOrder
Specifies relative priorities to sibling view items within the container for determining which item has default focus when entering a UI. Values can range from 0 (the highest priority) to Int32.MaxValue (the lowest priority and the default).
Font
Specifies the text Font. Use the inline construction for this element.
HorizontalAlignment
Specifies horizontal text alignment, which must be a member of the HorizontalAlignment enumeration.
Layout
Specifies the current layout associated with this view item. You can use the inline construction or expanded syntax with the following child elements that define a layout:
AnchorLayout
DockLayout
FlowLayout
GridLayout
RotateLayout
ScaleLayout
LayoutInput
Specifies the layout input for use by parent layouts. You can use the inline construction to specify a reference to a layout element, or use expanded syntax with the following child elements that define input:
AnchorLayoutInput
DockLayoutInput
FormLayoutInput
Margins
An Inset structure that specifies extra spacing around the view item.
MaximumLines
Specifies the maximum number of visible lines.
MaximumSize
Specifies the maximum Size, in pixels. If a maximum size is not specified or the maximum size is set to zero, the size will not be restricted.
MinimumSize
Specifies the minimum Size, in pixels. If a maximum size is not specified or the maximum size is set to zero, the size will not be restricted.
MouseInteractive
Determines whether the view item can receive and react to mouse input.
Name
Identifies this element.
Navigation
Specifies how the view item should behave during directional navigation. This value must be a member of the NavigationPolicies enumeration.
Padding
An Inset structure that specifies the extra spacing, in pixels, between the view item and its child elements.
Rotation
Applies a Rotation to the view item. Use the inline construction for this element.
Scale
A Vector3 structure that applies a scaling factor to the view item. Use the inline construction for this element.
Visible
Indicates whether the view item is visible.
WordWrap
Specifies whether word wrapping is enabled.
Public Instance Methods
Method	Description
AttachAnimation
Dynamically adds an animation.
DetachAnimation
Dynamically removes an animation from the view item.
ForceContentChange
Manually forces a content change for animations.
NavigateInto
Requests navigation into the view item to send focus to the view item or one of its children.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
•	UI Element
# TimeSpanTransformer Element
Converts a TimeSpan value to a string for display purposes.
Syntax
<TimeSpanTransformer
    Format="{Abbreviate | Long | RoundToMinute | Short | Words}"
/>

Attributes
Format
Specifies the time span format. This value must be a member of the TimeSpanFormats enumeration.
Remarks
For more information about TimeSpan format, see the TimeSpan Structure on the MSDN Web site.
The target of the TimeSpanTransformer element must accept a string.
You cannot perform one conversion after another on the same variable in a chain. To perform multiple conversions, you can transform the value to an intermediate local and then bind that value to your target using another transformer, or use multiple actions on the same variable using a rule.
Example Code
<Mcml
  xmlns="http://schemas.microsoft.com/2006/mcml"
  xmlns:cor="assembly://MSCorLib/System"
  xmlns:me="Me">

  <!-- TimeSpan values are being bound to the value properties of several -->
  <!-- Text items as strings.                                             -->

  <UI Name="TimeSpanTransformer">

    <Locals>
      <cor:TimeSpan Name="TimeSpanValue" cor:TimeSpan="3:46:35"/>
    </Locals>

    <Rules>
      <Binding Source="[TimeSpanValue]" Target="[Long.Content]">
        <Transformer>
          <TimeSpanTransformer Format="Long"/>
        </Transformer>
      </Binding>

      <Binding Source="[TimeSpanValue]" Target="[Long_RoundToMinute.Content]">
        <Transformer>
          <TimeSpanTransformer Format="Long,RoundToMinute"/>
        </Transformer>
      </Binding>

      <Binding Source="[TimeSpanValue]" Target="[Short.Content]">
        <Transformer>
          <TimeSpanTransformer Format="Short"/>
        </Transformer>
      </Binding>

      <Binding Source="[TimeSpanValue]" Target="[Words.Content]">
        <Transformer>
          <TimeSpanTransformer Format="Words"/>
        </Transformer>
      </Binding>

      <Binding Source="[TimeSpanValue]" Target="[Words_Abbreviate.Content]">
        <Transformer>
          <TimeSpanTransformer Format="Words,Abbreviate"/>
        </Transformer>
      </Binding>

    </Rules>

    <Content>
      <Panel Layout="VerticalFlow">
        <Children>
          <me:ValueText Name="Long" />
          <me:ValueText Name="Long_RoundToMinute" />
          <me:ValueText Name="Short" />
          <me:ValueText Name="Words" />
          <me:ValueText Name="Words_Abbreviate" />
        </Children>
      </Panel>
    </Content>
  </UI>

  <UI Name="ValueText">
    <Properties>
      <cor:String Name="Content" String=""/>
    </Properties>

    <Content>
      <Text Content="[Content]" Font="Verdana,16" Color="Yellow" Margins="10,5,10,5" />
    </Content>

  </UI>
</Mcml>

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# TransformAnimation Element
Enables you to perform simple time- and value-based transformations on all of the keyframes in a reference animation.
Syntax
<TransformAnimation
    Delay="float"
    Filter="{All | Alpha | Color | Position | Rotate | Scale | Size}"
    Magnitude="float"
    Source="Animation element"
    TimeScale="float"
    Type="AnimationEventType enum"
/>

Attributes
Delay
Specifes the amount by which all keyframes from the source past time 0.0 will have their time offset.
Filter
When processing the keyframes from the source, only keyframes that match this filter will be transformed. This value must be a member of the KeyframeFilter enumeration.
Magnitude
Specifies the value by which all keyframes from the source will have their value multiplied.
Source
Specifies the reference to an Animation element.
TimeScale
Specifies the value by which all keyframes from the source will have their time multiplied.
Type
Indicates the type of event that this animation will respond to. This value is a member of the AnimationEventType enumeration. This value is read-only.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier

# TransformByAttributeAnimation Element
Enables you to perform index-skewed time and value transformations to a referenced animation.
Syntax
<TransformByAttributeAnimation
    Attribute="{Height | Index | Width | X | Y}"
    Delay="float"
    Filter="{All | Alpha | Color | Position | Rotate | Scale | Size}"
    Magnitude="float"
    MaxDelay="float"
    MaxMagnitude="float"
    MaxTimeScale="float"
    Override="float"
    Source="Animation element"
    TimeScale="float"
    Type="AnimationEventType enum"
    ValueTransformer="MathTransformer element"
/>

Attributes
Attribute
Specifies the value used as the source of the transform. This value must be a member of the TransformAttribute enumeration.
Delay
Specifies the amount by which all keyframes from the source past time 0.0 will have their time offset. This value must be a member of the AnimationEventType enumeration.
Filter
When processing the keyframes from the source, only keyframes that match this filter will be transformed. This value must be a member of the KeyframeFilter enumeration.
Index
If this value is set, this index determines the transform instead of the index of the item relative to its peers.
Magnitude
Specifies the amount by which all keyframes from the source will have their value multiplied.
MaxDelay
When determining the per-index delay, specifies the maximum delay value that will be applied.
MaxMagnitude
When determining the per-index magnitude, specifies the maximum scalar value that will be applied.
MaxTimeScale
When determining the per-index time scale, specifies the maximum delay value that will be applied.
Override
When set, this value determines the transform rather than using the dynamically determined attribute.
Source
Specifies the reference to an Animation element.
TimeScale
Specifies the amount by which all keyframes from the source will have their time multiplied.
Type
Indicates the type of event that this animation will respond to. This value is a member of the AnimationEventType enumeration. This value is read-only.
ValueTransformer
Specifies a reference to a MathTransformer element that lets you modify the value used to determine the animation transformations.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# TripleTapKeyInfo Element
Provides header and label information for triple-tap keys.
Syntax
<TripleTapKeyInfo
    KeyCode="string"
    Label="string"
/>

Attributes
KeyCode
Contains the key code for the triple-tap key. This value is read-only.
Label
Contains the label for the triple-tap key. This value is read-only.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# TypeSelector Element
A repeater content selector that matches repeated items based on type.
Syntax
<TypeSelector
    ContentName="string"
    Type="System.Type"
/>

Attributes
ContentName
Contains the content name.
Type
Contains the type to match.
Remarks
For an example, see the AdvancedMarkup.Repeater.ContentSelectors.mcml sample in the Sample Explorer.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
•	Repeater Element

# TypingHandler Element
An event handler that provides editbox-like input behavior to a UI object.
Syntax
<TypingHandler
    Candidates="IList"
    Confirmed="{true | false}"
    DisplayValue="string"
    EditableText="EditableText object"
    HandlerStage="{Bubbled | Direct | Routed}"
    KeyInfos="IList"
    MaxLength="int"
    PasswordMasked="{true | false}"
    SelectCandidate="int"
    SupportsCandidates="{true | false}"
    TypingPolicy="{Default | TripleTap}"
    Value="string"
/>

Attributes
Candidates
List of candidates for the current input. This attribute is only applicable when TypingPolicy is set to TripleTap.
Confirmed
Indicates whether the current state is confirmed. This value is read-only.
DisplayValue
Returns the confirmed value if the text is confirmed, or the unconfirmed value if the text is not confirmed. This value is read-only.
EditableText
EditableText object associated with the typing handler. The typing handler uses an EditableText object for configuration and storage.
HandlerStage
A member of the InputHandlerStage enumeration indicating the stage in the event handling process when the event will be handled.
KeyInfos
Lists TripleTapKeyInfo elements for the current mode.
MaxLength
Specifies the maximum number of characters.
PasswordMasked
Specifies whether user input should be hidden.
SelectCandidate
Specifies the index of the selected item from the candidate list.
SupportsCandidates
Indicates whether the current triple-tap handler supports the candidate list. This value is false when TypingPolicy is not set to TripleTap. This value is read-only.
TypingPolicy
A member of the TypingPolicy enumeration indicating whether triple-tap support is enabled.
Value
The value of the edit control, which is the confirmed value if TypingPolicy is TripleTap. When PasswordMasked is true, this value is the actual string that is entered.
Public Instance Events
Event	Description
TypingInputRejected
Notification that is sent when the typing input is rejected.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier

# UI Element
Defines a UI—how it appears visually, how it behaves, and how it interacts with code/data objects.
Syntax
<UI
    BaseUI="string"
    Flippable="{true | false}"
    Name="string"
>
    <Content />
    <Locals />
    <Properties />
    <Rules />
</UI>

Attributes
BaseUI
Contains the base UI configuration from which this UI will inherit all properties, rules, and content.
Content
Specifies the type of content item, which must be one of the following elements (only one direct child of a Content element is allowed):
Clip
ColorFill
Graphic
Host
NowPlaying
Panel
Repeater
Scroller
Text
Video
Flippable
Specifies whether this UI should mirror on right-to-left (RTL) systems. If content is specified in the derived class, that content will entirely replace the content of the same name defined in the base class of the same name.
Locals
Specifies a set of private objects for use by the UI. A local consists of a type, a name, and a value. A local can be any type. Every instance of the UI will get its own instance of the locals. Use these variables when you need to store data pertinent to the scope of the current UI element only.
The following child elements are typical, but not limited to this set:
ArrayListDataSet
BooleanChoice
BooleanTransformer
ByteRangedValue
Choice
ClickHandler
Command
DateTimeTransformer
EditableText
Environment
FormatTransformer
IntRangedValue
KeyHandler
ListDataSet
MathTransformer
ModelItem
MouseWheelHandler
RangedValue
ScrollingData
ScrollingHandler
SecureTypingHandler
ShortcutHandler
Timer
TimeSpanTransformer
TypingHandler
Name
Specifies the name of the UI markup.
Properties
Specifies a set of input parameters to the UI. A property consists of a type, a name, and a default value. A property can be any type. Property defaults are shared among all instances of the UI markup; set properties when you want to parameterize values for a particular UI to be used by other UIs.
The following child elements are typical, but not limited to this set:
AnchorEdge
AnchorLayoutInput
Animation
ArrayListDataSet
BooleanChoice
ByteRangedValue
Choice
Color
Command
DockLayoutInput
EditableText
FormLayoutInput
Font
ICommand
Image
IModelItem
Index
Inset
IntRangedValue
ITransformer
ITransformerEx
IValueRange
ListDataSet
MajorMinor
ModelItem
Point
RangedValue
Rotation
ScrollingData
Size
Sound
Timer
Vector3
VirtualList
If additional properties are specified in the derived class, those values will override any of the same name in the base class.
You can use the ArrayListDataSet class to populate a list from markup.
Rules
Specifies a set of rules that provides priority-based data binding services. Rules have sources and targets. Rules can be condition-based, where the rule will not apply unless the conditions evaluate to true. Rules are priority-based in that the first rule has highest priority.
Includes any of the following elements to define the conditions of the rule:
Binding
Changed
Condition
Default
Rule
If rules are specified in the derived class, those rules will be appended to the list of rules specified by the base class.
Remarks
A UI is a self-contained and reusable component that can be used to create something as simple as a button and as complex as a top-level form. A UI element can only exist as a child of an Mcml element and must be named. If there are multiple UI elements in an MCML document, the first UI element is displayed.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier

# ValueSelector Element
The repeater content selector that matches by comparing the result of an arbitrary object path to a value.
Syntax
<ValueSelector
    ContentName="string"
    Source="ObjectPath element"
    Value="object"
/>

Attributes
ContentName
Contains the content name.
Source
Specifies the path to the object (by using a property, method, or indexer) to compare the value against.
Value
Specifies the value to check for.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
•	Repeater Element

# Video Element
Displays video.
Syntax
<Video
    Alpha="float"
    CenterPointOffset="Vector3"
    CenterPointPercent="Vector3"
    ColorFilter="Color"
    DebugOutline="Color"
    FocusOrder="int"
    IsFullWindow="{true | false}"
    Layout="{Anchor | Center | Dock | Fill | Form | Grid | HorizontalFlow | Rotate | Scale | VerticalFlow}"
    LayoutInput="LayoutInput"
    LetterboxColor="Color"
    Margins="Inset"
    MaximumSize="Size"
    MinimumSize="Size"
    MouseInteractive="{true | false}"
    Name="string"
    Navigation="NavigationPolicies enumeration"
    Padding="Inset"
    Rotation="Rotation"
    Scale="Vector3"
    Visible="{true | false}"
>
    <Animations />
    <Children />
    <Layout />
    <LayoutInput />
</Video>

Attributes
Alpha
Specifies the opacity value for the view item. This value must be between 0.0 and 1.0.
Animations
Contains a list of elements that describe an animation. Possible elements are:
Animation
MergeAnimation
SwitchAnimation
TransformAnimation
TransformByAttributeAnimation
CenterPointOffset
Specifies a center point adjustment based on a pixel-offset value when applying a scale or rotation to the view item. This value is applied after the CenterPointPercent value has been applied if both are provided. Use the inline construction for the Vector3 structure.
CenterPointPercent
Specifies a center point adjustment based on a percentage value when applying a scale or rotation to the view item. This value must be between 0 and 1, where a value of 1 equals 100%. Use the inline construction for the Vector3 structure.
Children
Specifies the child elements for a view item. Possible child elements are:
Clip
ColorFill
Graphic
Host
Panel
Repeater
Scroller
Text
Video
ColorFilter
Indicates the Color filter to apply on top of the color of the view item.
DebugOutline
Enables and sets the Color of the debugging outline of the view item.
FocusOrder
Specifies relative priorities to sibling view items within the container for determining which item has default focus when entering a UI. Values can range from 0 (the highest priority) to Int32.MaxValue (the lowest priority and the default).
IsFullWindow
Indicates whether the view item is full screen (true), or in a window (false).
Layout
Specifies the current layout associated with this view item. You can use the inline construction or expanded syntax with the following child elements that define a layout:
AnchorLayout
DockLayout
FlowLayout
GridLayout
RotateLayout
ScaleLayout
LayoutInput
Specifies the layout input for use by parent layouts. You can use the inline construction to specify a reference to a layout element, or use expanded syntax with the following child elements that define input:
AnchorLayoutInput
DockLayoutInput
FormLayoutInput
LetterboxColor
Specifies the Color of the letterbox region.
Margins
An Inset structure that specifies extra spacing outside the boundaries of the view item.
MaximumSize
Specifies the maximum Size, in pixels. If a maximum size is not specified or the maximum size is set to zero, the size will not be restricted.
MinimumSize
Specifies the minimum Size, in pixels. If a maximum size is not specified or the maximum size is set to zero, the size will not be restricted.
MouseInteractive
Determines whether the view item can receive and react to mouse input.
Name
Identifies this element.
Navigation
Specifies how the view item should behave during directional navigation. This value must be a member of the NavigationPolicies enumeration.
Padding
An Inset structure that specifies the extra spacing, in pixels, between the view item and its child elements.
Rotation
Applies a Rotation to the view item. Use the inline construction for this element.
Scale
A Vector3 structure that applies a scaling factor to the view item. Use the inline construction for this element.
Visible
Indicates whether the view item is visible.
Public Instance Methods
Method	Description
AttachAnimation
Dynamically adds an animation.
DetachAnimation
Dynamically removes an animation from the view item.
ForceContentChange
Manually forces a content change for animations.
NavigateInto
Requests navigation into the view item to send focus to the view item or one of its children.

Remarks
The Video element does not provide a way to start, stop, or change the content that is playing, so to control video you must use the Windows Media Center Presentation Layer API. For an example of using the Video view item, see the Sample Explorer.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# MCML Enumerations
MCML exposes the following enumerations.
Enumeration	Description
AccessibleRole
Contains categories of accessibility roles.
AnchorAlignment
Contains values that indicate the anchor edge alignment.
AnimationEventType
Contains categories of events that an animation will respond to.
ColorScheme
Contains color scheme variations.
ConditionLogicalOp
Contains logical operators that describe how multiple conditions should be combined.
ConditionOp
Contains operators to use within a single condition when comparing two values.
DateTimeFormats
Contains formats supported by the DateTimeTransformer element.

DockLayoutAlignment
Contains values that indicate dock layout alignment.
DockLayoutPosition
Contains values that indicate dock layout positioning.
FontStyles
Contains font style options.
HorizontalAlignment
Contains horizontal alignment options.
InputHandlerStage
Contains the stages in the event handling process that indicate when the event will be handled.
InterpolationType
Contains the interpolation types.
ItemAlignment
Contains values that indicate alignment.
KeyframeFilter
Contains the types of keyframes that can be filtered to and from a TransformAnimation.
KeyframeValueReference
Contains values that determine how to interpret the value of the keyframe.
KeyHandlerKey
Contains the keys that can be registered for KeyHandler handling.
KeyHandlerModifiers
Contains modifiers that must be pressed along with the key to invoke the command associated with the key handler.
MetadataVisibility
Contains values that specify the visibility of extended metadata on Now Playing.
MissingItemPolicy
Contains values that describe the policy for how a flow layout should handle a missing item.
NavigationDirection
Contains values that indicate the direction of navigation through pages.
NavigationPolicies
Contains values that indicate navigation mode.
Orientation
Contains values that indicate the orientation for gradients.
RelativeEdge
Contains values that indicate whether the value is relative the near end (top-left) or the far end (bottom-right).
RepeatPolicy
Contains values that describe when the layout should infinitely repeat the data set in either direction.
ShortcutHandlerCommand
Contains shortcuts that can be registered for the shortcut event handler.
SizingPolicy
Contains values that describe how a graphic will be stretched.
StripAlignment
Contains values that indicate the flow strip alignment.
TimeSpanFormats
Contains formats supported by the TimeSpanTransformer element.

TransformAttribute
Contains attributes that may be used for a TransformByAttributeAnimation element.
TypingInputRejectCause
Specifies the reason for rejecting typing input.
TypingPolicy
Contains the typing policies for the TypingHandler element.

See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier

# AccessibleRole Enumeration
Contains categories of accessibility roles.
Member Name	Description
Alert	An alert or condition that you can notify a user about. Use this role only for objects that embody an alert but are not associated with another user interface element, such as a message box, graphic, text, or sound.
Animation	An animation control, which contains content that is changing over time, such as a control that displays a series of bitmap frames like a filmstrip. Animation controls are usually displayed when files are being copied, or when some other time-consuming task is being performed.
Application	The main window for an application.
Border	A window border. The entire border is represented by a single object, rather than by separate objects for each side.
ButtonDropDown	A button that drops down a list of items.
ButtonDropDownGrid	A button that drops down a grid.
ButtonMenu	A button that drops down a menu.
Caret	A caret, which is a flashing line, block, or bitmap that marks the location of the insertion point in a window's client area.
Cell	A cell within a table.
Character	A cartoon-like graphic object, such as Microsoft Office Assistant, which is typically displayed to provide help to users of an application.
Chart	A graphical image used to represent data.
CheckButton	A check box control, which is an option that can be turned on or off independent of other options.
Client	A window's user area.
Clock	A control that displays the time.
Column	A column of cells within a table.
ColumnHeader	A column header, which provides a visual label for a column in a table.
ComboBox	A combo box, which is an edit control with an associated list box that provides a set of predefined choices.
Cursor	A mouse pointer.
Diagram	A graphical image used to diagram data.
Dial	A dial or knob. This can also be a read-only object, like a speedometer.
Dialog	A dialog box or message box.
Document	A document window, which is always contained within an application window. This role applies only to multiple-document interface (MDI) windows and refers to an object that contains the MDI title bar.
DropList	A drop-down list box. This control shows one item and allows the user to display and select another from a list of alternative choices.
Equation	A mathematical equation.
Graphic	A picture.
Grip	A special mouse pointer, which allows a user to manipulate user interface elements such as a window. For example, a user can click and drag a sizing grip in the lower-right corner of a window to resize it.
Grouping	The objects grouped in a logical manner. There can be a parent-child relationship between the grouping object and the objects it contains.
HelpBalloon	A Help display in the form of a ToolTip or Help balloon, which contains buttons and labels that users can click to open custom Help topics.
HotkeyField	A keyboard shortcut field that allows the user to enter a combination or sequence of keystrokes to be used as a keyboard shortcut, which enables users to perform an action quickly. A keyboard shortcut control displays the keystrokes entered by the user and ensures that the user selects a valid key combination.
Indicator	An indicator, such as a pointer graphic, that points to the current item.
IPAddress	An IP address.
Link	A link, which is a connection between a source document and a destination document. This object might look like text or a graphic, but it acts like a button.
List	A list box, which allows the user to select one or more items.
ListItem	An item in a list box or the list portion of a combo box, drop-down list box, or drop-down combo box.
MenuBar	A menu bar, usually beneath the title bar of a window, from which users can select menus.
MenuItem	A menu item, which is an entry in a menu that a user can choose to carry out a command, select an option, or display another menu. Functionally, a menu item can be equivalent to a push button, radio button, check box, or menu.
MenuPopup	A menu, which presents a list of options from which the user can make a selection to perform an action. All menu types must have this role, including drop-down menus that are displayed by selection from a menu bar, and shortcut menus that are displayed when the right mouse button is clicked.
None	No role.
Outline	An outline or tree structure, such as a tree view control, which displays a hierarchical list and usually allows the user to expand and collapse branches.
OutlineButton	The Outline button.
OutlineItem	An item in an outline or tree structure.
PageTab	A property page that allows a user to view the attributes for a page, such as the page's title, whether it is a home page, or whether the page has been modified. Normally, the only child of this control is a grouped object that contains the contents of the associated page.
PageTabList	A container of page tab controls.
Pane	A separate area in a frame, a split document window, or a rectangular area of the status bar that can be used to display information. Users can navigate between panes and within the contents of the current pane, but cannot navigate between items in different panes. Thus, panes represent a level of grouping lower than frame windows or documents, but above individual controls. Typically, the user navigates between panes by pressing TAB, F6, or CTRL+TAB, depending on the context.
ProgressBar	A progress bar, which indicates the progress of a lengthy operation by displaying colored lines inside a horizontal rectangle. The length of the lines in relation to the length of the rectangle corresponds to the percentage of the operation that is complete. This control does not take user input.
PropertyPage	A property page, which is a dialog box that controls the appearance and the behavior of an object, such as a file or resource. A property page's appearance differs according to its purpose.
PushButton	A push button control, which is a small rectangular control that a user can turn on or off. A push button, also known as a command button, has a raised appearance in its default off state and a sunken appearance when it is turned on.
RadioButton	An option button, also known as a radio button. All objects that share a parent and have this attribute are assumed to be part of a single mutually exclusive group. You can use grouped objects to divide option buttons into separate groups when necessary.
Row	A row of cells within a table.
RowHeader	A row header, which provides a visual label for a table row.
ScrollBar	A vertical or horizontal scroll bar, which can be either part of the client area or used in a control.
Separator	A space divided visually into two regions, such as a separator menu item or a separator dividing split panes within a window.
Slider	A control, sometimes called a trackbar, that enables a user to adjust a setting in given increments between minimum and maximum values by moving a slider. For example, the volume controls in the Windows operating system are slider controls.
Sound	A system sound that is associated with various system events.
SpinButton	A spin box, also known as an up-down control, that contains a pair of arrow buttons. A user clicks the arrow buttons with a mouse to increment or decrement a value. A spin button control is most often used with a companion control, called a buddy window, where the current value is displayed.
SplitButton	The Split button.
StaticText	The read-only text, such as in a label, for other controls or instructions in a dialog box. Static text cannot be modified or selected.
StatusBar	A status bar, which is an area typically at the bottom of an application window that displays information about the current operation, state of the application, or selected object. The status bar can have multiple fields that display different kinds of information, such as an explanation of the currently selected menu command in the status bar.
Table	A table containing rows and columns of cells and, optionally, row headers and column headers.
Text	The selectable text that can be editable or read-only.
TitleBar	A title or caption bar for a window.
ToolBar	A toolbar, which is a grouping of controls that provide easy access to frequently used features.
ToolTip	A tool tip, which is a small rectangular pop-up window that displays a brief description of the purpose of a button.
Whitespace	A blank space between other objects.
Window	A window frame, which usually contains child objects such as a title bar, client, and other objects typically contained in a window.

Remarks
For more information about accessibility, see the following topics on the MSDN Web site:
•	Active Accessibility User Interface Services
•	IAccessible
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Accessible Element
•	Adding Accessibility Support
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# AnchorAlignment Enumeration
Contains values that indicate the anchor edge alignment.
Member Name	Description
Center	Center between edges.
Far	Position to far edge.
Fill	Fill between edges (child will be forced to the size).
Near	Position to near edge.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# AnimationEventType Enumeration
Contains categories of events that an animation will respond to.
Member Name	Description
Alpha	Indicates animation will be played when the alpha value for a view item changes.
ContentChangeHide	Indicates animation will be played when the content hosted by a view item becomes hidden.
ContentChangeShow	Indicates animation will be played when the content hosted by a view item becomes visible.
GainFocus	Indicates animation will be played when the UI that contains the view item gains input focus.
Hide	Indicates animation will be played when a view item becomes hidden.
Idle	Indicates animation will be played when a view item is idle.
LoseFocus	Indicates animation will be played when the UI that contains the view item loses input focus.
Move	Indicates animation will be played when a view item is moved.
Rotate	Indicates animation will be played when a view item is rotated.
Scale	Indicates animation will be played when a view item changes scale.
Show	Indicates animation will be played when a view item becomes visible.
Size	Indicates animation will be played when a view item changes size.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# ColorScheme Enumeration
Contains color scheme variations.
Member	Description
Default	Default color scheme.
HighContrast1	Accessible High Contrast 1.
HighContrast2	Accessible High Contrast 2.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier

# ConditionLogicalOp Enumeration
Contains logical operators to use when matching conditions on a rule.
Member Name	Description
And	AND logical operator.
Or	OR logical operator.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# ConditionOp Enumeration
Contains operators to use within a single condition when comparing two values.
Member Name	Description
ChangedTo	Changed to value.
Equals	Equals.
GreaterThan	Greater than.
GreaterThanOrEquals	Greater than or equals.
LessThan	Less than.
LessThanOrEquals	Less than or equals.
NotEquals	Does not equal.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# DateTimeFormats Enumeration
Contains formats supported by the DateTimeTransformer element.
Member Name	Description
AbbreviatedLongDate	Use the long date format with year removed and abbreviated names.
AbbreviatedShortDate	Use the short date format with year removed and abbreviated names.
AbbreviateNames	Abbreviate the name of the month or day-of-week.
AbbreviateYear	Abbreviate the year from four digits to two digits.
ConvertLocalToUtc	Convert the local time zone to Universal Time Coordinate (UTC).
ConvertUtcToLocal	Convert UTC to the local time zone.

Date	Format as a date.
ForceDayOfWeek	Force the date format to include day-of-week.
LongDate	Use the long date format.
LongTime	Use the long time format.
MonthDay	Use the month day format.
NoAMPM	Remove the AM/PM indicator, if any.
NoDayOfWeek	Remove the day-of-week, if any.
None	No format; empty string is returned.
NoYear	Remove the year (and era, if any).
ShortDate	Use the short date format.
ShortTime	Use the short time format.
Time	Format as a time.
YearMonth	Use the year month format.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# DockLayoutAlignment Enumeration
Contains values that indicate dock layout alignment.
Member Name	Description
Center	Center alignment.
Far	Aligned to the far position. In a left-to-right layout, the far position is right. In a right-to-left layout, the far position is left.
Fill	Fill alignment.
Near	Aligned to the near position. In a left-to-right layout, the near position is left. In a right-to-left layout, the near position is right.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	DockLayoutInput Element
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# DockLayoutPosition Enumeration
Contains values that indicate dock layout positioning.
Member Name	Description
Bottom	Bottom positioning.
Client	Remaining space positioning.
Left	Left positioning.
Right	Right positioning.
Top	Top positioning.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	DockLayoutInput Element
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# FontStyles Enumeration
Contains font style options.
Member Name	Description
Bold	Bold formatting.
Italic	Italic formatting.
None	No extra formatting.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# HorizontalAlignment Enumeration
Contains horizontal alignment options.
Member Name	Description
Center	Center aligned.
Far	Far aligned.
Near	Near aligned.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# InputHandlerStage Enumeration
Contains the stages in the event handling process that indicate when the event will be handled.
Member Name	Description
Bubbled	Event will be processed when it is traveling up the tree from the destination with input focus.
Direct	Event will be processed when it arrives at the destination with input focus.
Routed	Event will be processed when it is traveling down the tree to the destination with input focus.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# InterpolationType Enumeration
Contains the interpolation types, which indicate the type of curve between keyframes of the same type.
Member Name	Description
Bezier	A Bézier curve.
Cosine	A cosine curve.
EaseIn	A linear and logarithmic curve, with a definable point where the animation changes from one interpolation to the other.
EaseOut	An exponential and linear curve, with a definable point where the animation changes from one interpolation to the other.
Exp	An exponential curve.
Linear	A linear curve.
Log	A logarithmic curve.
SCurve	An S-curve curve.
Sine	A sine curve.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# ItemAlignment Enumeration
Contains values that indicate alignment.
Member Name	Description
Center	Center alignment.
Far	Far alignment.
Fill	Fill.
Near	Near alignment.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# KeyframeFilter Enumeration
Contains the types of keyframes that can be filtered to and from a TransformAnimation.
Member	Description
All	Include all keyframes.
Alpha	Include alpha keyframes.
Color	Include color keyframes.
Position	Include position keyframes.
Rotate	Include rotate keyframes.
Scale	Include scale keyframes.
Size	Include size keyframes.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# KeyframeValueReference Enumeration
Contains values that determine how to interpret the value of the keyframe.
Member Name	Description
Absolute	Value is absolute.
Current	Value is an offset from the current in-progress value.
Final	Value is an offset from the final end value.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# KeyHandlerKey Enumeration
Contains the keys that can be registered for KeyHandler handling.
Member name	Value
A	The A key.
Add	The add key.
Any	Any key.
B	The B key.
Backslash	The \ (backslash) key.
Backspace	The BACKSPACE key.
C	The C key.
CapsLock	The CAPS LOCK key.
CloseBrace	The ] (close brace) key.
Comma	The , (comma) key.
Control	The CTRL modifier key.
D	The D key.
D0	The 0 key.
D1	The 1 key.
D2	The 2 key.
D3	The 3 key.
D4	The 4 key.
D5	The 5 key.
D6	The 6 key.
D7	The 7 key.
D8	The 8 key.
D9	The 9 key.
Delete	The DELETE key.
Divide	The divide key.
Down	The DOWN ARROW key.
E	The E key.
End	The END key.
Enter	The ENTER key.
Equals	The equals key.
Escape	The ESC key.
F	The F key.
F1	The F1 key.
F10	The F10 key.
F11	The F11 key.
F12	The F12 key.
F13	The F13 key.
F14	The F14 key.
F15	The F15 key.
F16	The F16 key.
F17	The F17 key.
F18	The F18 key.
F19	The F19 key.
F2	The F2 key.
F20	The F20 key.
F21	The F21 key.
F22	The F22 key.
F23	The F23 key.
F24	The F24 key.
F3	The F3 key.
F4	The F4 key.
F5	The F5 key.
F6	The F6 key.
F7	The F7 key.
F8	The F8 key.
F9	The F9 key.
G	The G key.
H	The H key.
Home	The HOME key.
I	The I key.
Insert	The INSERT key.
J	The J key.
K	The K key.
L	The L key.
Left	The LEFT ARROW key.
M	The M key.
Multiply	The multiply key.
N	The N key.
None	No key pressed.
NumLock	The NUM LOCK key.
NumPad0	The 0 key on the numeric keypad.
NumPad1	The 1 key on the numeric keypad.
NumPad2	The 2 key on the numeric keypad.
NumPad3	The 3 key on the numeric keypad.
NumPad4	The 4 key on the numeric keypad.
NumPad5	The 5 key on the numeric keypad.
NumPad6	The 6 key on the numeric keypad.
NumPad7	The 7 key on the numeric keypad.
NumPad8	The 8 key on the numeric keypad.
NumPad9	The 9 key on the numeric keypad.
O	The O key.
OpenBrace	The [ (open brace) key.
P	The P key.
PageDown	The PAGE DOWN key.
PageUp	The PAGE UP key.
Period	The . (period) key.
Pipe	The | (pipe) key.
PrintScreen	The PRINT SCREEN key.
Q	The Q key.
QuestionMark	The ? (question mark) key.
Quotes	The " (quotes) key.
R	The R key.
Right	The RIGHT ARROW key.
S	The S key.
Semicolon	The ; (semicolon) key.
Shift	The SHIFT modifier key.
Space	The SPACEBAR key.
Subtract	The subtract key.
T	The T key.
Tilde	The ~ (tilde) key.
U	The U key.
Underscore	The _ (underscore) key.
Up	The UP ARROW key.
V	The V key.
W	The W key.
X	The X key.
Y	The Y key.
Z	The Z key.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# KeyHandlerModifiers Enumeration
Contains modifiers that must be pressed along with the key to invoke the command associated with the key handler.
Member Name	Description
Alt	The ALT key.
Control	The CTRL key.
None	No key is required.
Shift	The SHIFT key.
Windows	The Windows logo key.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# MetadataVisibility Enumeration
Contains values that specify the visibility of extended metadata on Now Playing.
Member Name	Description
Always	Always show extended metadata.
Default	Default behavior (same as OnFocus).
Never	Never show extended metadata.
OnFocus	Only show extended metadata when containing UI gains focus.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# MissingItemPolicy Enumeration
Contains values that describe the policy for how a flow layout should handle a missing item.
Member Name	Description
SizeToAverage	Take the average of all items.
SizeToLargest	Assume the size of the largest existing item.
SizeToSmallest	Assume the size of the smallest existing item.
Wait	Stop the flow until this item is available.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# NavigationDirection Enumeration
Indicates the direction of navigation.
Member Name	Description
Backward	Navigation is backward from the current page
Forward	Navigation is forward to the next page.

Requirements
Platform: Windows 7
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# NavigationPolicies Enumeration
Contains values that indicate navigation mode.
Member Name	Description
Column	Creates a group that has single-column vertical arrangement. Navigations up or down compare Y positions. Navigations left and right exit the group.
ContainAll	Shorthand for both ContainDirectional and ContainTabOrder. No navigations of any kind will leave this container.
ContainDirectional	Shorthand for both ContainVertical and ContainHorizontal. Directional navigations will not leave this container.
ContainHorizontal	Creates a group that contains navigations horizontally. Navigations to the left or right will not leave this container.
ContainTabOrder	Creates a group that contains tab order. Navigations previous or next will not leave this container.
ContainVertical	Creates a group that contains navigations vertically. Navigations upward or downward will not leave this container.
FlowHorizontal	Provides a hint to the navigation system that this item is flowed out into rows. When navigating within this item, the navigation system will automatically group the child items into horizontal strips.
Note   FlowHorizontal assumes all items within a single row are of a uniform height.
FlowVertical	Provides a hint to the navigation system that this item is flowed out into columns. When navigating within this item, the navigation system will automatically group the child items into vertical strips.  
Note   It assumes all items within a single column are of a uniform width.
Group	Overrides the default navigation behavior by defining this container as a logical group of items. Where possible, focus navigations prefer items in the same group over items in different groups.
None	Default. The navigation system decides how to group items.
PreferFocusOrder	Creates a group that will always use focus order rather than spatial location to determine who should receive focus when entering the group. Navigations into the group will prefer the child with the lowest focus order unless the container is also a RememberFocus container and has a saved focus.
RememberFocus	Creates a group that remembers its most recent focus. Future navigations returning focus to the group will automatically restore the prior focus.
Row	Creates a group that has single-row horizontal arrangement. Navigations left or right will compare X positions. Navigations up and down will exit the group.
TabGroup	Creates a group that functions as a logical tabstop. Tab order navigations from within this group will immediately leave for another tabstop.
WrapAll	Shorthand for both WrapDirectional and WrapTabOrder. Any navigation that would leave this container will wrap to the other end of the container.
WrapDirectional	Shorthand for both WrapVertical and WrapHorizontal. Directional navigations that would leave this container will wrap to the other end of the container.
WrapHorizontal	Creates a group that wraps horizontally. Navigations left or right that would leave this container will instead wrap to the other end of the container.
WrapTabOrder	Creates a group that wraps in tab order. Navigations previous or next that would leave this container will instead wrap to the other end of the container.
WrapVertical	Creates a group that wraps vertically. Navigations up or down that would leave this container will instead wrap to the other end of the container.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# Orientation Enumeration
Contains values that indicate the orientation for gradients.
Member Name	Description
Horizontal	Horizontal orientation.
Vertical	Vertical orientation.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# RelativeEdge Enumeration
Contains values that indicate whether the value is relative the near end (top-left) or the far end (bottom-right).
Member Name	Description
Far	The far end (bottom-right).
Near	The near end (top-left).

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# RepeatPolicy Enumeration
Contains values that describe when the layout should infinitely repeat the data set in either direction.
Member Name	Description
Always	Always repeat the data.
Never	Only display the data set once.
WhenTooBig	Repeat the data set if it does not fit in the constraint.
WhenTooSmall	Repeat the data set if it fits in the constraint.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# ShortcutHandlerCommand Enumeration
Contains shortcuts that can be registered for the shortcut event handler.
Member Name	Description
Back	The Back button.
Blue	The Blue button.
ChannelDown	The ChannelDown button.
ChannelUp	The ChannelUp button.
Clear	The Clear button.
DVDMenu	The DVD Menu button.
Enter	The Enter button.
FastForward	The Fast Forward button.
Green	The Green button.
Hold	The Hold button.
Interactive	The Interactive button.
None
No button was pressed.
OEMExtensibility0	The OEMExtensibility0 button.
OEMExtensibility1	The OEMExtensibility1 button.
OEMExtensibility10	The OEMExtensibility10 button.
OEMExtensibility11	The OEMExtensibility11 button.
OEMExtensibility2	The OEMExtensibility2 button.
OEMExtensibility3	The OEMExtensibility3 button.
OEMExtensibility4	The OEMExtensibility4 button.
OEMExtensibility5	The OEMExtensibility5 button.
OEMExtensibility6	The OEMExtensibility6 button.
OEMExtensibility7	The OEMExtensibility7 button.
OEMExtensibility8	The OEMExtensibility8 button.
OEMExtensibility9	The OEMExtensibility9 button.
PageDown	The PageDown button.
PageUp	The PageUp button.
Pause	The Pause button.
Play	The Play button.
PlayPause	The PlayPause button.
Record	The Record button.
Red	The Red button.
Reveal	The Reveal button.
Rewind	The Rewind button.
SkipBack	The SkipBack button.
SkipForward	The SkipForward button.
Stop	The Stop button.
Yellow	The Yellow button.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# SizingPolicy Enumeration
Contains values that describe how a graphic will be stretched.
Member Name	Description
SizeToChildren	Default to the used size of its children.
SizeToConstraint	Default to the maximum possible size.
SizeToContent	Default to actual size of the image.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier

# StripAlignment Enumeration
Contains values that indicate the flow strip alignment.
Member Name	Description
Center	Center alignment.
Far	Far alignment.
Near	Near alignment.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# TimeSpanFormats Enumeration
Contains formats supported by the TimeSpanTransformer element.
Member Name	Description
Abbreviate	Abbreviate words in formatted TimeSpan.
Long	Long TimeSpan format. Includes hours, minutes, and seconds (or just minutes and seconds if less than 60 minutes).
RoundToMinute	Format the TimeSpan rounded to the nearest minute.
Short	Short TimeSpan format. Includes hours and minutes only.
Words	TimeSpan formatted as words.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# TransformAttribute Enumeration
Contains attributes that may be used for a TransformByAttributeAnimation element.
Member Name	Description
Height	Height
Index	Index
Width	Width
X	Position along the x-axis.
Y	Position along the y-axis.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier

# TypingInputRejectCause Enumeration
Specifies the reason for rejecting the typing input.
Member Name	Description
InputNotAllowable	The input is not an allowed character.
MaxLengthExceeded	The input exceeded the maximum length.
None	The input is not rejected.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier

# TypingPolicy Enumeration
Contains the typing policies for the TypingHandler element.
Member	Description
Default	Accepts raw input. No triple-tap support.
TripleTap	Uses the registered IME for the current locale to provide triple-tap support.

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier
# MCML Methods
MCML exposes the following methods.
Method	Description
AttachAnimation
Dynamically adds an animation to the view item.
Cancel
Cancels the current load of the source.
DetachAnimation
Dynamically removes an animation from the view item.
End
Scrolls to the end.
ForceContentChange
Manually forces a content change for animations.
ForceRefresh
Forces a reload of a UI.
Home
Scrolls to the beginning.
NavigateInto
Requests navigation into the view item to send focus to the view item or one of its children.
NavigateIntoIndex
Sends keyboard focus to the child with the specified virtual index. This method attempts to create the item if it hasn't already been repeated.
PageDown
Scrolls down one page.
PageUp
Scrolls up one page.
Scroll
Scrolls by exact amount.
ScrollDown
Scrolls down one step.
ScrollUp
Scrolls up one step.

See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier

# AttachAnimation Method
Dynamically adds an animation to the view item.
Syntax
public void AttachAnimation(
    Animation  animation
);

Parameters
animation
Animation. Specifies an animation element.
Remarks
Only one animation can be provided per AnimationEventType.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	AnimationEventType Enumeration
•	Clip Element
•	Sample Explorer
•	Media Center Markup Language Verifier
# Cancel Method
Cancels the current load of the source.
Syntax
public void Cancel();

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Host Element
•	Sample Explorer
•	Media Center Markup Language Verifier
# DetachAnimation Method
Dynamically removes an animation from the view item.
Syntax
public void DetachAnimation(
    AnimationEventType  type
);

Parameters
type
AnimationEventType. Specifies the type of animation event.
Remarks
Only one animation can be provided per AnimationEventType.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Clip Element
•	Sample Explorer
•	Media Center Markup Language Verifier
# End Method
Scrolls to the end.
Syntax
public void End();

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Sample Explorer
•	Media Center Markup Language Verifier
•	ScrollingData Element
# ForceContentChange Method
Manually forces a content change for animations.
Syntax
public void ForceContentChange();

Remarks
Content-change animations are played when visual content within a view item changes. This process occurs automatically for Content properties on view items—for example when a displayed image changes in a Graphic element. However, this process can be forced for changes that are not included automatically, such as for color changes in a Text element.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Sample Explorer
•	Media Center Markup Language Verifier
•	Video Element

# ForceRefresh Method
Forces a reload of a UI.
Syntax
Overload List
public void ForceRefresh();

public void ForceRefresh(
  bool  unloadMarkup
);

Parameters
unloadMarkup
System.Boolean. Indicates whether to refresh the referenced markup.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Host Element
•	Sample Explorer
•	Media Center Markup Language Verifier
# Home Method
Scrolls to the beginning.
Syntax
public void Home();

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Sample Explorer
•	Media Center Markup Language Verifier
•	ScrollingData Element
# NavigateInto Method
Requests navigation into the view item to send focus to the view item or one of its children.
Syntax
Overload List
public void NavigateInto();
public void NavigateInto(
  bool  isDefault
);

Parameters
isDefault
System.Boolean.  true to indicate whether this view item should have default focus (for example, the default focus when the page first loads rather than sending focus in response to a user action); otherwise false.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Clip Element
•	Sample Explorer
•	Media Center Markup Language Verifier
# NavigateIntoIndex Method
Sends keyboard focus to the child with the specified virtual index. This method attempts to create the item if it hasn't already been repeated.
Syntax
public void NavigateIntoIndex(
  int  index
);

Parameters
index
System.Int32.  Virtual index of the item on which to call the NavigateInto method.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Sample Explorer
•	Media Center Markup Language Verifier
•	Repeater Element

# PageDown Method
Scrolls down one page.
Syntax
public void PageDown();

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Sample Explorer
•	Media Center Markup Language Verifier
•	ScrollingData Element
# PageUp Method
Scrolls up one page.
Syntax
public void PageUp();

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Sample Explorer
•	Media Center Markup Language Verifier
•	ScrollingData Element
# Scroll Method
Scrolls by exact amount.
Syntax
public void Scroll(
    int  amount
);

Parameters
amount
System.Int32. Indicates the amount to scroll.
Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Sample Explorer
•	Media Center Markup Language Verifier
•	ScrollingData Element
# ScrollDown Method
Scrolls down one step.
Syntax
public void ScrollDown();

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Sample Explorer
•	Media Center Markup Language Verifier
•	ScrollingData Element
# ScrollUp Method
Scrolls up one step.
Syntax
public void ScrollUp();

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Sample Explorer
•	Media Center Markup Language Verifier
•	ScrollingData Element
# MCML Events
MCML defines the following events.
Event	Description
Caught
Raised when an exception is caught.

DownInvoked
Raised for the wheel-down event.
Invoked
Raised when a UI feature is clicked, a keystroke event occurs, or the shortcut command is issued.
TypingInputRejected
Notification that is sent when the typing input is rejected.
UpInvoked
Raised for the wheel-up event.

See Also
•	Media Center Markup Language Reference
•	Sample Explorer
•	Media Center Markup Language Verifier

# Caught Event
Raised for an exception that is defined in the exception handler for the object.
Syntax
public event System.EventHandler Caught;

Requirements
Platform: Windows 7
See Also
•	ExceptionHandler Element
•	Sample Explorer
•	Media Center Markup Language Verifier

# DownInvoked Event
Raised for the wheel-down event.
Syntax
public event System.EventHandler DownInvoked;

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Sample Explorer
•	Media Center Markup Language Verifier
•	MouseWheelHandler Element
# Invoked Event
Raised when a UI feature is clicked, a keystroke event occurs, or the shortcut command is issued.
Syntax
public event System.EventHandler Invoked;

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	ClickHandler Element
•	Sample Explorer
•	Media Center Markup Language Verifier
# TypingInputRejected Event
Notification that is sent when the typing input is rejected.
Syntax
public event System.EventHandler TypingInputRejected;

Requirements
Platform: Windows 7
See Also
•	Sample Explorer
•	SecureTypingHandler Element
•	TypingHandler Element
•	Media Center Markup Language Verifier

# UpInvoked Event
Raised for the wheel-up event.
Syntax
public event System.EventHandler UpInvoked;

Requirements
Platform: Windows Vista Ultimate, Windows Vista Home Premium, and later
See Also
•	Sample Explorer
•	Media Center Markup Language Verifier
•	MouseWheelHandler Element

---

MCESDK_Ref04.doc

# K Click-To-Record XML Reference
This section describes the XML elements used to specify TV programs for Windows Media Center to record.
Element	Description
airing
Identifies the airing times at which TV programs are to be recorded through the click-to-record feature of Windows Media Center.
clickToRecord
Indicates the beginning of click-to-record content in an XML document.
description
Describes a request for a click-to-record recording session.
expires
Specifies the date and time, in Universal Time Coordinate (UTC) format, at which the click-to-record document expires.
key
Defines fields and matching rules that Windows Media Center uses to locate the TV programs to record through the click-to-record feature.
program
Identifies TV programs to be recorded through the click-to-record feature of Windows Media Center.
programRecord
Defines a recording request being made through the click-to-record feature of Windows Media Center.
service
Identifies the broadcast services that are potential providers of a TV program to be recorded through the click-to-record feature of Windows Media Center.

See Also
•	Managed Code Object Model Reference

# airing Element
Identifies the times at which TV programs are to be recorded through the click-to-record feature of Windows Media Center.
Syntax
<airing
    timeZone="timezone"
    searchSpan="minutes"
>
</airing>

Attributes
timeZone
Optional. Specifies the standard time zone of the user—as the number of minutes offset from Universal Time Coordinate (UTC) time—to which this recording criteria applies. If this attribute is not specified, Windows Media Center considers all time zones. If this attribute is present and the user is not within this time zone, the element is ignored.
searchSpan
Specifies a number of minutes before or after the given UTC time. If the specified recording start time falls within this span, Windows Media Center considers the recording start time to be a match.
Remarks
Windows Media Center uses this element along with the program and service elements to identify the TV programs to record.
This element must contain one or more key elements, one for each airing time.
This element must be nested inside the programRecord element.
Requirements
Platform: Windows XP Media Center Edition 2005 and later
See Also
•	Click-To-Record XML Reference
•	key Element
•	program Element
•	programRecord Element
•	service Element

# clickToRecord Element
Indicates the beginning of the click-to-record content in an XML document. It is the top-level schema element in the clicktorecord namespace.
Syntax
<clickToRecord
    xmlns="urn:schemas-microsoft-com:ehome:clicktorecord"
>
</clickToRecord>

Attributes
xmlns
Required. Specifies the schema that defines the XML elements supporting the click-to-record feature.
Requirements
Platform: Windows XP Media Center Edition 2005 and later
See Also
•	Click-To-Record XML Reference

# description Element
Describes a request for a click-to-record recording session.
Syntax
<description>description string
</description>

Attributes
This element has no attributes.
Remarks
This element must be nested inside the metadata element.
Requirements
Platform: Windows XP Media Center Edition 2005 and later
See Also
•	Click-To-Record XML Reference

# expires Element
Specifies the date and time—in Universal Time Coordinate (UTC) format—at which the click-to-record document expires.
Syntax
<expires>"UTC date and time"
</expires>

Attributes
This element has no attributes.
Remarks
Windows Media Center will not schedule recording requests that have expired.
This element must be nested inside the metadata element.
Requirements
Platform: Windows XP Media Center Edition 2005 and later
See Also
•	Click-To-Record XML Reference

# key Element
Defines fields and matching rules that Windows Media Center uses to locate the TV programs to record through the click-to-record feature.
Syntax
<key
    field="URI"
    match="{contains | exact | startswith}"
>
</key>

Attributes
field
Specifies a URI that uniquely identifies the field to be matched against. The valid values for this attribute depend on the parent of the key element. For more information, see the Remarks section.
match
Defines the method by which string terms are matched. It must be one of the following values:
Value	Description
contains	The field must contain a word that matches or begins with the specified string. An occurrence of the specified string in the middle or at the end of a word is not considered to be a match.
exact	The field and the specified string must be an exact match.
startswith	The field must start with the specified string.

Remarks
This element must be nested inside the airing, program, or service elements. Each of these elements must contain one or more key elements. Windows Media Center interprets multiple key elements as logical ANDs—all of them must be satisfied to qualify as a match.
If the parent element is program, the field attribute must be one of the following values:
Value	Description
urn:schemas-microsoft-com:ehome:epg:program#title	A string containing the program title.
urn:schemas-microsoft-com:ehome:epg:program#episodetitle	A string containing the episode title.
urn:schemas-microsoft-com:ehome:epg:program#releaseyear	An int specifying the year that the program was released.

If the program element of a keyword recording request specifies a match on the program title field (urn:schemas-microsoft-com:ehome:epg:program#title), only the "contains" and "exact" match values are supported. The "startswith" match value is treated as "contains". For more information, see Types of Recording Requests.
Note that releaseyear must be combined with another value. For example, the following request is valid:
<program>
    <key field="urn:schemas-microsoft-com:ehome:epg:program#title">Azati</key>
    <key field="urn:schemas-microsoft-com:ehome:epg:program#releaseyear">1963</key>
</program>

However, this request is not:
<program>
    <key field="urn:schemas-microsoft-com:ehome:epg:program#releaseyear">1963</key>
</program>

If the parent element is service, the field attribute must be one of the following values:
Value	Description
urn:schemas-microsoft-com:ehome:epg:service#name	A string containing the name of the service.
urn:schemas-microsoft-com:ehome:epg:service#callsign	A string containing the call sign of the service.
urn:schemas-microsoft-com:ehome:epg:service#affiliate	A string containing the name of the service affiliate.
urn:schemas-microsoft-com:ehome:epg:service#mappedChannelNumber	A string specifying the channel number. To specify an Advanced Television Systems Committee (ATSC) channel number, use the following format:
"major-minor"

where major and minor are integers separated by a hyphen.
Because channel positions vary greatly from one user to another, you should avoid using this key criterion, if possible.
urn:schemas-microsoft-com:ehome:epg:service#id	A string that is displayed in the Electronic Program Guide page in Windows Media Center. In some countries or regions, the service name is displayed in this field rather than an official call sign, or the service name may be left blank.

If the parent element is airing, the field attribute must be one of the following values:
Value	Description
urn:schemas-microsoft-com:ehome:epg:airing#starttime	A value of the dateTime XML data type containing the date and starting time when the program will be broadcast.

A dateTime value represents a specific instance of time. The format for specifying the date and time is a follows.
CCYY-MM-DDThh:mm:ssTZD

The following table describes the dateTime syntax:
Syntax	Description
CC	Two-digit century.
YY	Two-digit year.
MM	Two-digit month (01=January).
DD	Two-digit day of month (01 through 31).
T	A literal "T" to indicate the beginning of the time element.
hh	Two-digit hour (00 through 23; A.M. and P.M. are not allowed).
mm	Two-digit minute (00 through 59).
ss	Two-digit second (00 through 59). Additional digits can be used to increase the precision of fractional seconds. For example, the format ss.ss... with any number of digits after the decimal point is supported.
TZD	Time zone designator.

The following table shows values for the Time Zone Designator (TZD):
Syntax	Description
Z	Specifies coordinated Universal Time Coordinate (UTC). The Z must be uppercase.
+hh:mm	Specifies that the time is hh hours and mm minutes ahead of UTC.
-hh:mm	Specifies that the time is hh hours and mm minutes behind UTC.

If the Z is included, both hours and minutes must be specified. To designate exactly UTC, use Z+00:00.
Requirements
Platform: Windows XP Media Center Edition 2005 and later
See Also
•	airing Element
•	Click-To-Record XML Reference
•	key Element
•	program Element
•	service Element

# program Element
Identifies TV programs to be recorded through the click-to-record feature of Windows Media Center.
Syntax
<program>
</program>

Attributes
This element has no attributes.
Remarks
Windows Media Center uses this element along with the service and airing elements to identify the TV programs to record.
This element must contain one or more key elements.
This element must be nested inside the programRecord element.
Requirements
Platform: Windows XP Media Center Edition 2005 and later
See Also
•	airing Element
•	Click-To-Record XML Reference
•	key Element
•	programRecord Element
•	service Element

# programRecord Element
Defines a recording request being made through the Windows Media Center click-to-record feature.
Syntax
<programRecord
    prepadding="seconds"
    postpadding="seconds"
    allowAlternateAirings="{true | false}"
    allowAlternateServices="{true | false}"
    programDuration="minutes"
    firstRunOnly="{true | false}"
    daysOfWeek="bitflags"
    isRecurring="{true | false}"
    keepUntil="int"
    quality="int"
>
</programRecord>

Attributes
prepadding
Optional. Specifies the pre-padding time, in seconds, with respect to the start time. To begin recording before the start time, specify a negative value. To begin recording after the start time, specify a positive value. The default value is 0.
postpadding
Optional. Specifies the post-padding time, in seconds, with respect to the end time. To stop recording before the end time, specify a negative value. To stop recording after the end time, specify a positive value. The default value is 0.
allowAlternateAirings
Optional. Indicates how Windows Media Center should respond when it cannot find the specified airing of a program.
A value of "true" indicates that Windows Media Center can schedule the recording at an alternate time. A series will target a specific time for the first item that is found chronologically in the Electronic Program Guide (EPG).
A value of "false" indicates that if Windows Media Center cannot find the program within the specified time period, it should fail the request and inform the user. The default value is "false".
allowAlternateServices
Optional. Indicates how Windows Media Center should respond when it cannot find the specified airing of a program on a particular broadcast service. A value of "true" indicates that Windows Media Center can look for the same program on a different broadcast service. A value of "false" indicates that if Windows Media Center cannot find the program on the specified broadcast service, it should fail the request. The default value is "false".
programDuration
Optional. Specifies the duration of the program, in minutes. This attribute is used only if the document does not specify any program elements, and results in a manual recording. This attribute must specify a positive, non-zero number to create a manual recording.
firstRunOnly
Optional. Indicates whether to allow recording of TV programs that are marked as reruns in the program guide. A value of "true" prevents recording of reruns, and "false" allows it. The default value is "false".
daysOfWeek
Optional. Specifies an array of seven bit flags, expressed as a decimal value, indicating the days of the week that a program can be recorded for manual and generic "keyword" requests. Bit 0 is set to indicate Sunday, bit 1 Monday, and so on. The default value is 127 (every day).
isRecurring
Optional. Indicates whether the request is for a series of recordings, or just a one-time recording. A value of "true" indicates a recurring (series) recording, and "false" indicates a one-time recording. The default value is "false".
keepUntil
Optional. Specifies how long to keep the recorded files. The following values are possible (if no value is specified, the computer's default value is used):
-3: Latest recordings
-2: Keep until I watch
-1: Keep until space needed
0: Keep until I delete
Note   Only the EventSchedule.CreateScheduleRequest method can correctly interpret these features of the input XML file. The deprecated ClickToRecord.Submit and TVSchedule.ScheduleRecording methods for managed code, the MediaCenter.ScheduleRecording method for hosted HTML, and invoking the click-to-record feature from the Windows shell cannot accept this XML and may simply ignore these features.
quality
Optional. Specifies the quality of recording. The following values are possible (if no value is specified, the computer's default value is used):
0: Fair
1: Good
2: Better
3: Best
Note   Only the EventSchedule.CreateScheduleRequest method can correctly interpret these features of the input XML file. The deprecated ClickToRecord.Submit and TVSchedule.ScheduleRecording methods for managed code, the MediaCenter.ScheduleRecording method for hosted HTML, and invoking the click-to-record feature from the Windows shell cannot accept this XML and may simply ignore these features.
Remarks
This element has three child elements: program, service, and airing. Each can occur more than once. These elements serve as search criteria to target a specific program, optionally airing on a particular service at a particular time.
If the isRecurring attribute is "true", the daysOfWeek attribute applies only to the first program in a series. Subsequent episodes are scheduled based on the built-in series scheduling logic of Windows Media Center, regardless of the daysOfWeek attribute.
Requirements
Platform: Windows XP Media Center Edition 2005 and later
See Also
•	airing Element
•	Click-To-Record XML Reference
•	program Element
•	service Element

# service Element
Identifies the broadcast services that are potential providers of a TV program to be recorded through the click-to-record feature of Windows Media Center.
Syntax
<service>
</service>

Attributes
This element has no attributes.
Remarks
Windows Media Center uses this element along with the program and airing elements to identify the TV programs to record.
This element must contain one or more key elements.
This element must be nested inside the programRecord element.
Requirements
Platform: Windows XP Media Center Edition 2005 and later
See Also
•	airing Element
•	Click-To-Record XML Reference
•	key Element
•	program Element
•	programRecord Element
# Entry Point Registration XML Reference
Windows Media Center exposes XML elements that are used to add a tile for your application to the Windows Media Center Extras Library. You can add your application to Windows Media Center by passing XML code to the ApplicationContext.RegisterApplication method or by using the RegisterMCEApp.exe command-line tool. Older applications use XML code in Media Center link (MCL) files, which are deprecated. This section describes the XML elements used to add applications to Windows Media Center.
Element	Description
application
Specifies the path to your application and sets several application attributes.
capabilitiesRequired
Specifies the capabilities that are needed to successfully run your application.
category
Specifies the Windows Media Center category for an application entry point.
entrypoint
Specifies an entry point into an application.

See Also
•	Installing Windows Media Center Applications

# application Element
Specifies the path to your application and several application attributes. Attributes specified in the application element do not appear within the Windows Media Center UI, but are used to associate the application entry points with the integration locations within Windows Media Center.
Syntax
<application
    title="title"
    id="GUID of application"
    companyName="company name"
    description="description of application"
>
</application>

Attributes
title
Required. A string that specifies the title of the application.
id
Required. A string in the form of a globally unique identifier (GUID). This should be different from the GUID created for the entrypoint element and not a slight variation of another GUID. To generate GUIDs for your application, use a GUID-generating utility such as guidgen.exe from Microsoft.
companyName
Optional. A string that specifies the name of the company that authored the application. Before adding the application, Windows Media Center uses this name in a dialog box asking the user whether to add a new application item from the specified company. If no company name is specified, Windows Media Center uses the string, "Unknown Company".
description
Optional. A string that briefly describes the application.
Remarks
The following attributes from previous versions of Windows Media Center are deprecated:
•	bgColor
•	companyLogoUrl
•	name
•	sharedViewport
•	startImage
•	thumbnailImage
•	UiFlags
•	url
Requirements
Platform: Windows XP Media Center Edition 2005 and later
See Also
•	ApplicationContext.RegisterApplication
•	Installing Windows Media Center Applications

# capabilitiesRequired Element
Specifies the capabilities that are needed to successfully run the application. The tile for the entry point will not appear on devices that do not support the necessary capabilities. This element is a child of the entrypoint element.
Syntax
<capabilitiesRequired
    directX="{true | false}"
    audio="{true | false}"
    video="{true | false}"
    intensiveRendering="{true | false}"
    console="{true | false}"
    cdBurning="{true | false}"
>
</capabilitiesRequired>

Attributes
directX
Optional. A string that indicates whether the application requires DirectX support. A value of "true" indicates that DirectX support is required; a value of "false" indicates that it is not.
audio
Optional. A string that indicates whether the application requires audio support. A value of "true" indicates that audio support is required; a value of "false" indicates that it is not.
video
Optional. A string that indicates whether the application requires video support. A value of "true" indicates that video support is required; a value of "false" indicates that it is not.
intensiveRendering
Optional. A string that indicates whether the application contains graphics that require high-end rendering capabilities. A value of "true" indicates that high-end rendering capabilities are required; a value of "false" indicates that they are not.
console
Optional. A string that indicates whether the application requires resources that are only available or meaningful from the computer's console (the host PC), rather than from a remote session. An example of this might be an LCD projector application that turns the projector on and off through the COM port. A value of "true" indicates that computer console resources are required; a value of "false" indicates that they are not.
cdBurning
Optional. A string that indicates whether the application requires a CD or DVD burner to be present. A value of "true" indicates that a burner is required; a value of "false" indicates that it is not.
Requirements
Platform: Windows XP Media Center Edition 2005 and later
See Also
•	Installing Windows Media Center Applications

# category Element
Specifies the Windows Media Center integration location for an application entry point. Each entry point may appear in multiple integration locations within the Windows Media Center UI. Include one category element inside the entrypoint element for each category in which you want the entry point to appear, and ensure each category element has exactly one category attribute. This element is a child of the entrypoint element.
Syntax
<category
    category="Windows Media Center category"
>
</category>

Attributes
category
Required. A string that identifies the Windows Media Center integration location for an application entry point. See Remarks for valid category strings.
Remarks
The following table summarizes the integration locations and categories in Windows Media Center:
Category string	Location	Start Menu Strip
Services\MediaChanger	—	—
	Music > Radio > Sources	Music
	Music > Radio > Presets	Music
Internet Radio	Music > Radio	NA
Internet Radio\Presets	Music > Radio	NA
More Programs	Extras > Extras Library	Extras
More With This\Audio\Album	Music > Music Library > Albums > Album > More Information > More
Music > Music Library > Years > Album > More Information > More
Music > Music Library > Album Artists > Album > More Information > More	—
More With This\Audio\Artist	Music > Music Library > Artists > Artist > More Information > More
Music > Music Library > Composers > Artist > More Information > More	—
More With This\Audio\Playlist	Music > Music Library > Playlists > Playlist > More Information > More	—
More With This\Audio\Song	Music > Music Library > Songs > Song > More Information > More	—
More With This\Audio\Genre	Music > Music Library > Genres > Genre > More Information > More	—
More With This\DVD	TV + Movies > Play DVD > More Information > More
TV + Movies > Play DVD > More Information > Movie Details > More	—
More With This\Picture	Picture Library > Picture > More Information > More	—
More With This\Video	Video Library > Video > More Information > More	—
AutoPlay\Blu-ray	—	—
AutoPlay\HD DVD	—	—
Background	—	—
OEM Extensibility 1	—	—

Note   The Services\* and Settings\* strings have been deprecated, although they are still valid to support previous versions.
Requirements
Platform: Windows XP Media Center Edition 2005 and later
See Also
•	entrypoint Element
•	Installing Windows Media Center Applications

# entrypoint Element
Defines an entry point into an application designed to be used within Windows Media Center. This element is a child of the application element.
Syntax
<entrypoint
    id="entry point GUID"

    <!-- This element can have only one of the following attributes:
    addin="AssemblyInfo"
    url="URL of entry-point page"
    run="path of EXE file"
    -->

    title="title"
    nowPlayingDirective="{close | pause | stop | mute}"
    description="description"
    imageUrl="URL of image"
    inactiveImageURL="URL of image"
    context="context"
    UiFlags="HideTransportToolbar"
>
</entrypoint>

Attributes
id
Required. A string in the form of a globally unique identifier (GUID). This should be different from the GUID created for the application element and not a slight variation of another GUID. To generate GUIDs for your application, use a GUID-generating utility such as guidgen.exe from Microsoft.
addin
A comma-separated string that defines the attributes of a managed code assembly. For a Windows Media Center Presentation Layer application (local or background), the string is in the following format:
"className,assemblyName,Version=version,PublicKeyToken=publicKey,Culture=culture"
where:
className is the full name (assembly and class) of the application's implementation of a class that inherits from the IAddInModule interface.
assemblyName is the name of the application's assembly.
version is the version number of the application's assembly.
publicKey is the public portion of the cryptographic key used to sign the application's assembly. Use the Strong Name tool (sn.exe) with the -p option to extract the public portion of the cryptographic key from your .snk file. For more information, see Strong Name Tool (Sn.exe) on the MSDN Web site.
culture is the cultural designation of the application's assembly.
The version, publicKey, and culture values must be an exact match with the strong-name information stored in the application's assembly. For more information, see Creating a Strong-Named Assembly.
For a Windows Media Center Presentation Layer Web application, this attribute must be "Microsoft.MediaCenter.Hosting.WebAddIn,Microsoft.MediaCenter".
url
A string that specifies the path to an entry point page in the application. The value for url must contain "http://".
run
A string that specifies the full or relative path to an executable file on the local computer.
title
Required. A string that identifies the entry point in the Windows Media Center UI and contains a short summary of the entry point (for example, "New Releases"). It appears at the top of the Extras Library page when the entry point is selected.
nowPlayingDirective
Optional. A string that sets the state of the currently playing media/Now Playing view item (NowPlaying element in MCML) when the entry point is launched. Whenever possible, an application should set these values from code, script, or MCML. Choose from the following values:
Value	Description
close	The shared view port/Now Playing experience is closed.
pause	The media is paused.
stop	The media is stopped.
mute	The media is muted.

description
Optional. A string that describes the purpose of the entry point to provide additional information to the user (for example, "The latest tracks from your favorite artists").
imageUrl
Optional. A string that specifies the path to a Portable Network Graphics (PNG) format image displayed in the Windows Media Center UI. The application image is a 186 × 186 pixel PNG bitmap with support for alpha transparency. Windows Media Center automatically and proportionally scales this image as appropriate within the UI. If you do not specify an image, a Windows Media Center generic image or the title of the application is used instead. While it is possible for the same image to be used for any number of entry points, best practice recommends a customized image for each entry point that is specific to the type (differentiate between disparate media types, for example).
inactiveImageURL
Optional. A string that specifies the path to a Portable Network Graphics (PNG) format image displayed in the Windows Media Center UI with the same characteristics as imageURL. The inactive image appears on the Windows Media Center Start menu strip when the tile is not selected. If this image is not specified, a grayscale version of imageURL is used instead.
context
Optional. An application-defined string that Windows Media Center provides to the application when the entry point is selected. This can be an arbitrary set of parameters for the application. For a Windows Media Center Presentation Layer Web application, this attribute is set to the HTTP URL of the application.
UiFlags
Optional. A comma-delimited string used to affect certain Windows Media Center UI features. The only option is "HideTransportToolbar", which hides the mouse transport controls (this toolbar is located in the lower-right corner of the Windows Media Center UI, which appears when the user moves the mouse, includes buttons to perform actions such as pausing, stopping, and rewinding). This flag should be used only in extremely rare cases, because when this toolbar is hidden, mouse-only users will be unable to control media playback while using the application.
Remarks
This element can have only one of the following attributes, which determines how it behaves:
•	addin
•	url
•	run
This element is for use with the ApplicationContext.RegisterApplication method.
The following attributes are deprecated from previous versions of Windows Media Center:
•	thumbnailUrl
Requirements
Platform: Windows XP Media Center Edition 2005 and later
See Also
•	ApplicationContext.RegisterApplication Method
•	category Element
•	IAddInModule Interface
•	Installing Windows Media Center Applications

---

MCESDK_Ref05.doc

# iTV Reference
Interactive TV (iTV) is an integral part of many digital TV services and provides a browser-like experience for users. Interactive TV applications can be developed that would allow users to read the latest new headlines, view local weather conditions and forecasts, stock quotes, sports scores, and many other enhanced viewing experiences.
Topic	Description
Microsoft.MediaCenter.TVVM Namespace
Describes the managed code API for iTV.
iTV C++ Reference
Describes the unmanaged code API for iTV.

See Also
•	Programming Reference

# Microsoft.MediaCenter.TVVM Namespace
The TVVM namespace exposes the interfaces needed to build an Interactive TV application.
Members
Classes
Class	Description
FrameFormat
Describes the frame format of the video surface.
KeyCommandEventArgs
Describes the event data for key and command events.
OverlaySurface
Allows applications to access a drawing surface above the video surface.
PlaybackSession
Enables applications to retrieve information about the current playback session.
RenderingMode
Enables applications to retrieve information about the rendering mode and coordinate system in which the application runs.
StreamInfo
Enables applications to retrieve information about a particular stream.
StreamSelector
Enables applications to select streams.
Tuning
Enables applications to retrieve information about tuning.
TVVMbase
The base class from which all iTVVM applications are derived.
VideoSurface
Enables applications to work with the video surface.

Enumerations
Enumeration	Description
ChannelState
Contains values that indicate whether a tune request is currently in progress.
CommandCode
Contains values that describe command codes that Windows Media Center can return.
InputModifiers
Contains values that identify which additional key was pressed, if any.
KeyboardCommandEventState
Contains values that identify whether further events will be delivered to the application.
KeyCommandState
Contains values that indicate whether a key is being pressed.
KeyHandlerKey
Contains values that identify which key an event is for.
StreamType
Contains values that identify the stream types.
ZoomMode
Contains values that identify the zoom modes.

Delegates
Delegate	Description
KeyCommandEventHandler
Handles the key and command events.

Exceptions
Exception	Description
TuningFormatException
Thown to indicate that the application issued a tune request with an invalid XML format.
TuningInProgressException
Thown to indicate that the application issued a tune request before the prior tune request was completed.
TuningSameChannelException
Thrown to indicate that the application issued a tune request to the same channel it currently is tuned to.

See Also
•	Programming Reference

# ChannelState Enumeration
Contains values that indicate whether a tune request is currently in progress. These values indicate only the state and do not imply success or failure.
public enum ChannelState

Members
Value	Description
Tuned	Indicates that a tune request is not currently in progress.
TuneInProgress	Indicates that a tune request is currently being acted upon and is incomplete.

Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace

# CommandCode Enumeration
Contains the command codes that can be returned by Windows Media Center.
public enum CommandCode

Members
Value	Description
Blue	The code for the Blue command.
ChannelDown	The code for the ChannelDown command.
ChannelUp	The code for the ChannelUp command.
Clear	The code for the Clear command.
ClosedCaption	The code for the ClosedCaption command.
Copy	The code for the Copy command.
EndOfList	The code for the EndOfList command.
Enter	The code for the Enter command.
FF	The code for the FF command.
Forward	The code for the Forward command.
GoToBeginning	The code for the GoToBeginning command.
GoToEnd	The code for the GoToEnd command.
Green	The code for the Green command.
Home	The code for the Home command.
Interactive	The code for the Interactive command.
PageDown	The code for the PageDown command.
PageUp	The code for the PageUp command.
Paste	The code for the Paste command.
Pause	The code for the Pause command.
Play	The code for the Play command.
PlayPause	The code for the PlayPause command.
Red	The code for the Red command.
Refresh	The code for the Refresh command.
Rewind	The code for the Rewind command.
SkipBack	The code for the SkipBack command.
SkipForward	The code for the SkipForward command.
StartOfList	The code for the StartOfList command.
Stop	The code for the Stop command.
Yellow	The code for the Yellow command.

Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace

# FrameFormat Class
Describes the frame format of the video surface.
public sealed class FrameFormat

Members
Public Instance Properties
Property	Description
VideoPixelAspect
Gets the aspect ratio of pixels in the video.
VideoSize
Gets the size of the video frames to be rendered.

Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace

# FrameFormat.VideoPixelAspect Property
Gets the aspect ratio of pixels in the video.
Syntax
public Microsoft.MediaCenter.UI.Size VideoPixelAspect {get;}

Property Value
Microsoft.MediaCenter.UI.Size. The size (height and width) of the video pixel.
This property is read-only.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	FrameFormat Class
•	Microsoft.MediaCenter.TVVM Namespace

# FrameFormat.VideoSize Property
Gets the size of the video frames to be rendered.
Syntax
public Microsoft.MediaCenter.UI.Size VideoSize {get;}

Property Value
Microsoft.MediaCenter.UI.Size. The size, in pixels, of the video frames to be rendered.
This property is read-only.
Remarks
The player may adjust the video that is being played. This size does not necessarily match the broadcast size.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	FrameFormat Class
•	Microsoft.MediaCenter.TVVM Namespace

# InputModifiers Enumeration
Contains values that indicate which additional key was pressed when a keystroke action occurred.
public enum InputModifiers

Members
Value	Description
AltKey	The ALT key.
ControlKey	The CTRL key.
None	No other key was pressed.
ShiftKey	The SHIFT key.
WindowsKey	The Windows logo key.

Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace

# KeyboardCommandEventState Enumeration
Contains values that indicate whether new events will be delivered to the PlaybackSession.KeyCommandEvent event. If the application does not process events quickly enough, the PlaybackSession.KeyboardCommandEventState property notifies the application that no further events will be delivered.
public enum KeyboardCommandEventState

Members
Value	Description
DoneListening	No more events will be delivered.
Listening	Events are being delivered.

Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace

# KeyCommandEventArgs Class
Describes the event data for key and command events. The application can register for the event by adding its event handler to the KeyCommandEvent event of an PlaybackSession object.
The event can represent a keystroke (the EventType property is true) or a command (EventType is false).
For a keystroke, the Key property contains an appropriate keycode, the State property indicates whether the key is currently pressed, and the InputModifiers property indicates whether an additional key (such as CTRL) was also pressed when the keystroke action occurred.
For a command, the Command property indicates the associated system command being processed (a key might translate to a command). The State property indicates whether a key is currently pressed.
public sealed class KeyCommandEventArgs : EventArgs

Members
Public Instance Methods
Method	Description
KeyCommandEventArgs
Initializes a new instance of the KeyCommandEventArgs class.

Public Instance Properties
Property	Description
Command
Gets a value that indicates which command is being sent.
EventType
Gets a value that indicates whether the event is a keystroke or command.
InputModifiers
Gets a value that indicates whether any additional keys were pressed when a keystroke action occurred.
Key
Gets a value that indicates which key the event is for.
State
Gets a value that identifies whether a key is being pressed.

Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace

# KeyCommandEventArgs Constructor
Initializes a new instance of the KeyCommandEventArgs class.
Overload List
public KeyCommandEventArgs(
  KeyHandlerKey  key,
  KeyCommandState  state,
  InputModifiers  inputModifiers
);
public KeyCommandEventArgs(
  CommandCode  Command
);

Parameters
key
Microsoft.MediaCenter.TVVM.KeyHandlerKey. Indicates which key the event is for.
state
Microsoft.MediaCenter.TVVM.KeyCommandState. Indicates whether a key is being pressed.
inputModifiers
Microsoft.MediaCenter.TVVM.InputModifiers. Indicates whether any additional keys were pressed when the keystroke action occurred.
Command
Microsoft.MediaCenter.TVVM.CommandCode. Indicates a command code that was returned by Windows Media Center.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	KeyCommandEventArgs Class
•	Microsoft.MediaCenter.TVVM Namespace

# KeyCommandEventArgs.Command Property
Gets a value that indicates which command is being sent.
Syntax
public CommandCode Command {get;}

Property Value
Microsoft.MediaCenter.TVVM.CommandCode. A command code that was returned by Windows Media Center.
This property is read-only.
Remarks
This property is only valid for a command event (the EventType property is false).
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	KeyCommandEventArgs Class
•	Microsoft.MediaCenter.TVVM Namespace

# KeyCommandEventArgs.EventType Property
Gets a value that indicates whether the event is for a keystroke or a command.
Syntax
public bool EventType {get;}

Property Value
System.Boolean. When true, the event represents a keystroke. When false, the event represents a command.
This property is read-only.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	KeyCommandEventArgs Class
•	Microsoft.MediaCenter.TVVM Namespace

# KeyCommandEventArgs.InputModifiers Property
Gets a value that indicates whether any additional keys were pressed when the keystroke action was received.
Syntax
public InputModifiers InputModifiers {get;}

Property Value
Microsoft.MediaCenter.TVVM.InputModifiers. Indicates whether an additional key was pressed when the keystroke action occurred.
This property is read-only.
Remarks
This property is only valid for a keystroke event (the EventType property is true).
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	KeyCommandEventArgs Class
•	Microsoft.MediaCenter.TVVM Namespace

# KeyCommandEventArgs.Key Property
Gets a value that indicates which key the event is for.
Syntax
public KeyHandlerKey Key {get;}

Property Value
Microsoft.MediaCenter.TVVM.KeyHandlerKey. The key the event is for.
This property is read-only.
Remarks
This property is only valid for a keystroke event (the EventType property is true).
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	KeyCommandEventArgs Class
•	Microsoft.MediaCenter.TVVM Namespace

# KeyCommandEventArgs.State Property
Gets a value that identifies whether a key is being pressed.
Syntax
public KeyCommandState State {get;}

Property Value
Microsoft.MediaCenter.TVVM.KeyCommandState. Indicates whether a key is being pressed.
This property is read-only.
Remarks
Key repetition may be encountered by multiple Down values before encountering an Up value.
This property is only valid for a keystroke event (the EventType property is true).
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	KeyCommandEventArgs Class
•	Microsoft.MediaCenter.TVVM Namespace

# KeyCommandEventHandler Delegate
Represents the method that will handle the key and command events.
public delegate bool KeyCommandEventHandler(
  Object sender,
  KeyCommandEventArgs e
);
Parameters
sender
System.Object.  The source of the event.
e
KeyCommandEventArgs.  A KeyCommandEventArgs that contains the event data.
Remarks
When you create a KeyCommandEventHandler delegate, you identify the method that will handle the event. To associate the event with your event handler, add an instance of the delegate to the event. The event handler is called whenever the event occurs, unless you remove the delegate.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace

# KeyCommandState Enumeration
Contains values that indicate whether a key is being pressed during a keystroke event.
public enum KeyCommandState

Members
Value	Description
Down	The key is being pressed.
Up	The key has been released and is not pressed.

Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace

# KeyHandlerKey Enumeration
Contains values that identify which key an event is for.
public enum KeyHandlerKey

Members
Value	Description
A	The A key.
Add	The Add key.
Attn	The Attn key.
B	The B key.
Back	The Back key.
BrowserBack	The BrowserBack key.
BrowserFavorites	The BrowserFavorites key.
BrowserForward	The BrowserForward key.
BrowserHome	The BrowserHome key.
BrowserRefresh	The BrowserRefresh key.
BrowserSearch	The BrowserSearch key.
BrowserStop	The BrowserStop key.
C	The C key.
Cancel	The Cancel key.
Capital	The Capital key.
CapsLock	The CapsLock key.
Clear	The Clear key.
ControlKey	The ControlKey key.
Crsel	The Crsel key.
D	The D key.
D0	The D0 key.
D1	The D1 key.
D2	The D2 key.
D3	The D3 key.
D4	The D4 key.
D5	The D5 key.
D6	The D6 key.
D7	The D7 key.
D8	The D8 key.
D9	The D9 key.
DBEDBCSChar	The DBEDBCSChar key.
DBEHiragana	The DBEHiragana key.
DBEKatakana	The DBEKatakana key.
DBENoroman	The DBENoroman key.
DBERoman	The DBERoman key.
DBESBCSChar	The DBESBCSChar key.
Decimal	The Decimal key.
Delete	The Delete key.
Divide	The Divide key.
Down	The Down key.
E	The E key.
End	The End key.
Enter	The Enter key.
EraseEof	The EraseEof key.
Escape	The Escape key.
Excel	The Excel key.
Execute	The Execute key.
F	The F key.
F1	The F1 key.
F10	The F10 key.
F11	The F11 key.
F12	The F12 key.
F13	The F13 key.
F14	The F14 key.
F15	The F15 key.
F16	The F16 key.
F17	The F17 key.
F18	The F18 key.
F19	The F19 key.
F2	The F2 key.
F20	The F20 key.
F21	The F21 key.
F22	The F22 key.
F23	The F23 key.
F24	The F24 key.
F3	The F3 key.
F4	The F4 key.
F5	The F5 key.
F6	The F6 key.
F7	The F7 key.
F8	The F8 key.
F9	The F9 key.
FinalMode	The FinalMode key.
G	The G key.
H	The H key.
HangulMode	The HangulMode key.
HanjaMode	The HanjaMode key.
Home	The Home key.
I	The I key.
IMEAccept	The IMEAccept key.
IMEConvert	The IMEConvert key.
IMEModeChange	The IMEModeChange key.
IMENonconvert	The IMENonconvert key.
Insert	The Insert key.
J	The J key.
JunjaMode	The JunjaMode key.
K	The K key.
KanaMode	The KanaMode key.
KanjiMode	The KanjiMode key.
L	The L key.
LaunchApplication1	The LaunchApplication1 key.
LaunchApplication2	The LaunchApplication2 key.
LaunchMail	The LaunchMail key.
LButton	The LButton key.
LControlKey	The LControlKey key.
Left	The Left key.
Linefeed	The Linefeed key.
LMenu	The LMenu key.
LShiftKey	The LShiftKey key.
LWin	The LWin key.
M	The M key.
MButton	The MButton key.
MediaNextTrack	The MediaNextTrack key.
MediaPlayPause	The MediaPlayPause key.
MediaPreviousTrack	The MediaPreviousTrack key.
MediaStop	The MediaStop key.
Menu	The Menu key.
Multiply	The Multiply key.
N	The N key.
Next	The Next key.
NoName	The NoName key.
None	The None key.
NumLock	The NumLock key.
NumPad0	The NumPad0 key.
NumPad1	The NumPad1 key.
NumPad2	The NumPad2 key.
NumPad3	The NumPad3 key.
NumPad4	The NumPad4 key.
NumPad5	The NumPad5 key.
NumPad6	The NumPad6 key.
NumPad7	The NumPad7 key.
NumPad8	The NumPad8 key.
NumPad9	The NumPad9 key.
O	The O key.
Oem8	The Oem8 key.
OemBackslash	The OemBackslash key.
OemClear	The OemClear key.
OemCloseBrackets	The OemCloseBrackets key.
OemComma	The OemComma key.
OemMinus	The OemMinus key.
OemOpenBrackets	The OemOpenBrackets key.
OemPeriod	The OemPeriod key.
OemPipe	The OemPipe key.
OemPlus	The OemPlus key.
OemQuestion	The OemQuestion key.
OemQuotes	The OemQuotes key.
OemSemicolon	The OemSemicolon key.
OemTilde	The OemTilde key.
P	The P key.
Pa1	The Pa1 key.
PageDown	The PageDown key.
PageUp	The PageUp key.
Pause	The Pause key.
Play	The Play key.
Print	The Print key.
PrintScreen	The PrintScreen key.
Prior	The Prior key.
ProcessKey	The ProcessKey key.
Q	The Q key.
R	The R key.
RButton	The RButton key.
RControlKey	The RControlKey key.
Return	The Return key.
Right	The Right key.
RMenu	The RMenu key.
RShiftKey	The RShiftKey key.
RWin	The RWin key.
S	The S key.
Scroll	The Scroll key.
Select	The Select key.
SelectMedia	The SelectMedia key.
Separator	The Separator key.
ShiftKey	The ShiftKey key.
Snapshot	The Snapshot key.
Space	The Space key.
Subtract	The Subtract key.
T	The T key.
Tab	The Tab key.
U	The U key.
Up	The Up key.
V	The V key.
VolumeDown	The VolumeDown key.
VolumeMute	The VolumeMute key.
VolumeUp	The VolumeUp key.
W	The W key.
X	The X key.
XButton1	The XButton1 key.
XButton2	The XButton2 key.
Y	The Y key.
Z	The Z key.
Zoom	The Zoom key.

Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace

# OverlaySurface Class
Allows applications to access a drawing (overlay) surface above the video surface. ARGB bitmaps can be rendered into this drawing surface. Both surfaces are composited together to show an alpha-blended bitmap over video.
public class OverlaySurface : Microsoft.MediaCenter.UI.IPropertyObject

Members
Public Instance Methods
Method	Description
Allocate
Allocates the memory for the bitmap on the drawing surface.
BeginRegionUpdates
Starts a logical grouping of region updates.
EndRegionUpdates
Ends the sequence of region updates on the overlay surface.
Free
Frees the memory associated with the drawing overlay surface.
UpdateRegion
Updates a region on the overlay surface.

Public Instance Properties
Property	Description
AnimationLevel
Gets a value that indicates the recommended animation level for the overlay surface.
RenderingMode
Gets an object that describes the current rendering mode and coordinate system in which the application runs.
Visible
Gets or sets a value indicating whether to enable or disable rendering of the overlay surface.

Public Instance Events
Event	Description
PropertyChanged Event
Fires when the RenderingMode property changes.

Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace

# OverlaySurface.Allocate Method
Allocates the memory for the bitmap of the drawing surface.
Syntax
public void Allocate(
  Microsoft.MediaCenter.UI.Size  size,
  bool  widescreen,
  bool  scaleToViewport
);

Parameters
size
Microsoft.MediaCenter.UI.Size. The size (height and width) of the overlay surface, in pixels.
widescreen
System.Boolean. Indicates whether the overlay surface will be displayed in widescreen format.
scaleToViewport
System.Boolean. Indicates whether to scale the overlay surface to the player view port.
Return Value
This method does not return a value.
Remarks
This method is the first method called for the OverlaySurface object.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	OverlaySurface Class

# OverlaySurface.AnimationLevel Property
Gets a value that indicates the recommended animation level for the overlay surface.
Syntax
public Int64 AnimationLevel {get;}

Property Value
System.Int64. The recommended animation level for the overlay surface.
This property is read-only.
Remarks
This value reflects an aggregate of the bandwidth and processing power of the rendering target, and is intended to be used by an application to determine the extent of animation to use. The AnimationLevel can be one of the following values:
Value	Description
0	Animations not recommended.
1	Minimal animations recommended.
255	Regular/full animations (local rendering).
Other	Reserved for future use.

Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	OverlaySurface Class

# OverlaySurface.BeginRegionUpdates Method
Starts a logical grouping of region updates.
Syntax
public void BeginRegionUpdates();

Return Value
This method does not return a value.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	OverlaySurface Class

# OverlaySurface.EndRegionUpdates Method
Ends the sequence of region updates on the overlay surface.
Syntax
public void EndRegionUpdates();

Return Value
This method does not return a value.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	OverlaySurface Class

# OverlaySurface.Free Method
Frees the memory associated with the drawing overlay surface.
Syntax
public void Free();

Return Value
This method does not return a value.
Remarks
This should be the last method to call on the OverlaySurface object.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	OverlaySurface Class

# OverlaySurface.PropertyChanged Event
Fires when the RenderingMode property changes.
Syntax
public override Microsoft.MediaCenter.UI.PropertyChangedEventHandler PropertyChanged;

Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	OverlaySurface Class

# OverlaySurface.RenderingMode Property
Gets an object that describes the current rendering mode and coordinate system in which the application runs.
Syntax
public RenderingMode RenderingMode {get;}

Property Value
Microsoft.MediaCenter.TVVM.RenderingMode. An object that contains data describing the current rendering mode and coordinate system.
This property is read-only.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	OverlaySurface Class

# OverlaySurface.UpdateRegion Method
Updates a region on the overlay surface.
Overload List
public void UpdateRegion(
  Microsoft.MediaCenter.UI.Point  pt,
  Microsoft.MediaCenter.UI.Size  bitmapSize,
  byte  bmpBits
);
public void UpdateRegion(
  Microsoft.MediaCenter.UI.Point  pt,
  System.Drawing.Bitmap  image
);

Parameters
pt
Microsoft.MediaCenter.UI.Point. The location to update.
bitmapSize
Microsoft.MediaCenter.UI.Size. The size (height and width) of the bitmap, in pixels.
bmpBits
System.UInt8. The bitmap to be updated.
image
System.Drawing.Bitmap. The bitmap to be updated.
Return Value
This method does not return a value.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	OverlaySurface Class

# OverlaySurface.Visible Property
Gets or sets a value indicating whether to enable or disable rendering of the overlay surface. The application should disable rendering when possible.
Syntax
public bool Visible {get; set;};

Property Value
System.Boolean. When true, enables rendering of the overlay surface. When false, rendering is disabled.
This property is read/write.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	OverlaySurface Class

# PlaybackSession Class
Allows the caller to obtain information about the current TV playback session, such as whether playback is from live TV or from a recording, the time difference between current playback and live TV, and the current state of tuning (whether a tune request is pending). A PropertyChanged event notifies callers when any of the session properties have changed.
public class PlaybackSession : Microsoft.MediaCenter.UI.IPropertyObject

Members
Public Instance Properties
Property	Description
BeingRecorded
Gets a value that indicates whether a recording is in progress.
KeyboardCommandEventState
Gets a value that indicates whether further keyboard command events will be delivered to the application.
PlaybackActive
Gets a value that indicates whether playback is active.
PlaybackOffset
Gets a value that indicates the current playback position in the stream, in seconds, with respect to the beginning of the stream.
PreferredLanguage
Gets the ISO-defined code that represents the user's preferred language.

Public Instance Events
Event	Description
KeyCommandEvent Event
Fires for keystroke and command events.
PropertyChanged Event
Fires when a property changes.

Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace

# PlaybackSession.BeingRecorded Property
Gets a value that indicates whether a recording is in progress.
Syntax
public bool BeingRecorded {get;}

Property Value
System.Boolean. When true, a recording is in progress.
This property is read-only.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	PlaybackSession Class

# PlaybackSession.KeyboardCommandEventState Property
Gets a value that indicates whether further keyboard command events will be delivered to the application.
Syntax
public KeyboardCommandEventState KeyboardCommandEventState {get;}

Property Value
Microsoft.MediaCenter.TVVM.KeyboardCommandEventState. Indicates whether further key command events will be delivered to the application.
This property is read-only.
Remarks
Several actions or situations can change this property. The default situation is to not deliver events to the application (this property returns DoneListening). Once the application has requested the events by adding the KeyCommandEventHandler delegate to the assembly’s KeyCommandEvent event, this property immediately returns Listening. If the handler takes too long to process the key or command event, it is assumed that the process will delay the Windows Media Center system and will have a negative impact on the user experience. So, due to the requirements of the KeyCommandEventHandler to process the event quickly, the handler will be automatically removed from the KeyCommandEvent event, this property is set to DoneListening, and the Session.PropertyChanged event is triggered to identify that this property changed.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	PlaybackSession Class

# PlaybackSession.KeyCommandEvent Event
Fires for keystroke and command events. Applications that need to receive keystroke and command events add a KeyCommandEventHandler delegate to this event. When events arrive, the KeyCommandEventArgs object in the event callback indicates the type of event and additional details.

Syntax
public KeyCommandEventHandler KeyCommandEvent;

Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	PlaybackSession Class

# PlaybackSession.PlaybackActive Property
Gets a value that indicates whether playback is active.
Syntax
public bool PlaybackActive {get;}

Property Value
System.Boolean. When true, playback is currently active.
This property is read-only.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	PlaybackSession Class

# PlaybackSession.PlaybackOffset Property
Gets a value that indicates the current playback position in the stream, in seconds, with respect to the beginning of the stream.
Syntax
public float PlaybackOffset {get;}

Property Value
System.Single. The time difference, in seconds, between the beginning of the stream to the current position.
This property is read-only.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	PlaybackSession Class

# PlaybackSession.PreferredLanguage Property
Gets the ISO-defined code that represents the user's preferred language.
Syntax
public string PreferredLanguage {get;}

Property Value
System.String. An ISO-defined language code.
This property is read-only.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	PlaybackSession Class

# PlaybackSession.PropertyChanged Event
Fires when any of the following PlaybackSession properties change: KeyboardCommandEventState, BeingRecorded, and PlaybackActive.
Syntax
public override Microsoft.MediaCenter.UI.PropertyChangedEventHandler PropertyChanged;

Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	PlaybackSession Class

# RenderingMode Class
Enables applications to retrieve information about the rendering mode and coordinate system in which the application runs.
public sealed class RenderingMode

Members
Public Instance Properties
Property	Description
Overscan
Gets a value that indicates the recommended overscan standoffs to use from each margin for any UI elements.
PixelAspect
Gets a value that indicates the aspect ratio of a pixel on the coordinate system.
PlayerViewportSize
Gets a value that indicates the recommended rendering surface size to use.
Viewport
Gets a value that indicates the final rendering size of the player view port.

Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace

# RenderingMode.Overscan Property
Gets a value that indicates the recommended overscan standoffs to use from each margin for any UI elements.
Syntax
public Microsoft.MediaCenter.UI.Rectangle Overscan {get;}

Property Value
Microsoft.MediaCenter.UI.Rectangle. The margins for any UI element.
This property is read-only.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	RenderingMode Class

# RenderingMode.PixelAspect Property
Gets a value that indicates the aspect ratio of pixels in the coordinate system.
Syntax
public Microsoft.MediaCenter.UI.Size PixelAspect {get;}

Property Value
Microsoft.MediaCenter.UI.Size. The size (height and width) of the pixels.
This property is read-only.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	RenderingMode Class

# RenderingMode.PlayerViewportSize Property
Gets a value that indicates the size of the player view port.
Syntax
public Microsoft.MediaCenter.UI.Size PlayerViewportSize {get;}

Property Value
Microsoft.MediaCenter.UI.Size. The size (height and width) of the player view port.
This property is read-only.
Remarks
This size is the recommended size of the rendering surface to use. This size also supplies the maximum X and Y values of the coordinate system.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	RenderingMode Class

# RenderingMode.Viewport Property
Gets a value that indicates the final rendering size of the player view port.
Syntax
public Microsoft.MediaCenter.UI.Rectangle Viewport {get;}

Property Value
Microsoft.MediaCenter.UI.Rectangle. The rendering size of the player view port.
This property is read-only.
Remarks
This size may be different from the recommended PlayerViewportSize property. If smaller, the application is being displayed in an inset within Windows Media Center. If it is the same size, the application is being displayed over the Windows Media Center window.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	RenderingMode Class

# StreamInfo Class
Enables applications to retrieve information about a particular stream.
public class StreamInfo

Members
Public Instance Methods
Method	Description
GetProperty
Retrieves a property from this stream.

Public Instance Properties
Property	Description
Id
Gets a value that indicates the identifier for this stream.
IsActive
Gets a value that indicates whether the stream is currently selected for presentation.
PID
Gets a value that indicates the packet identifier (PID) for this stream.
StreamType
Gets a value that indicates the stream type.

Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace

# StreamInfo.GetProperty Method
Retrieves a property from this stream.
This may be any property in the underlying stream that Windows Media Center has tagged .
Syntax
public object GetProperty(
  string  requestProperty
);

Parameters
requestProperty
System.String. The name of the property to retrieve.
Return Value
System.Object. An object that contains the value of the property.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	StreamInfo Class

# StreamInfo.Id Property
Gets a value that indicates the identifier for this stream.
Syntax
public UInt64 Id {get;}

Property Value
System.UInt64. The identifier value for this stream.
This property is read-only.
Remarks
This value is a sequential number.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	StreamInfo Class

# StreamInfo.IsActive Property
Gets a value that indicates whether the stream is currently selected for presentation.
Syntax
public bool IsActive {get;}

Property Value
System.Boolean. When true, this stream is currently selected for presentation.
This property is read-only.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	StreamInfo Class

# StreamInfo.PID Property
Gets a value that indicates the packet identifier (PID) for this stream.
Syntax
public uint PID {get;}

Property Value
System.UInt32. The PID value for this stream.
This property is read-only.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	StreamInfo Class

# StreamInfo.StreamType Property
Gets a value that indicates the stream type.
Syntax
public StreamType StreamType {get;}

Property Value
Microsoft.MediaCenter.TVVM.StreamType. The stream type.
This property is read-only.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	StreamInfo Class

# StreamSelector Class
Enables applications to enumerate the streams that are currently available, determine which streams are currently active, select one or more available streams, and determine the type of each available or active stream. Because audio and video are separate streams, several streams may need to be selected.
public class StreamSelector : Microsoft.MediaCenter.UI.IPropertyObject

Members
Public Instance Methods
Method	Description
CommitSelection
Applies the changes made by DeselectStream and SelectStream methods.
DeselectStream
Passes a list of streams to deselect for presentation.
GetModifyingStreams
Gets the list of stream types that the application will modify.
SelectStream
Passes a list of streams to select for presentation.
SetModifyingStreams
Indicates to the platform which types of streams the application will modify.

Public Instance Properties
Property	Description
AvailableStreams
Gets a list of all streams that are available for selection.

Public Instance Events
Event	Description
PropertyChanged Event
Fires when the AvailableStreams property changes.

Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace

# StreamSelector.AvailableStreams Property
Gets a list of all streams that are available for selection.
Syntax
public StreamInfo AvailableStreams {get;}

Property Value
Microsoft.MediaCenter.TVVM.StreamInfo. An object that contains a list of all streams that are available for selection.
This property is read-only.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	StreamSelector Class

# StreamSelector.CommitSelection Method
Applies the changes made by DeselectStream and SelectStream methods.
Syntax
public void CommitSelection();

Return Value
This method does not return a value.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	StreamSelector Class

# StreamSelector.DeselectStream Method
Passes a list of streams to deselect for presentation.
Syntax
public void DeselectStream(
  StreamInfo  streams
);

Parameters
streams
Microsoft.MediaCenter.TVVM.StreamInfo. An object that contains a list of streams to deselect for presentation.
Return Value
This method does not return a value.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	StreamSelector Class

# StreamSelector.GetModifyingStreams Method
Gets the list of stream types that the application will modify.
Syntax
public StreamType GetModifyingStreams();

Return Value
Microsoft.MediaCenter.TVVM.StreamType. A member of the StreamType enumeration, treated as a bitmask. Multiple streams can be selected and returned.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	StreamSelector Class
# StreamSelector.PropertyChanged Event
Fires when the AvailableStreams property changes.
Syntax
public override Microsoft.MediaCenter.UI.PropertyChangedEventHandler PropertyChanged;

Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	StreamSelector Class

# StreamSelector.SelectStream Method
Passes a list of streams to select for presentation.
Syntax
public void SelectStream(
  StreamInfo  streams
);

Parameters
streams
Microsoft.MediaCenter.TVVM.StreamInfo. An object that contains a list of streams to select for presentation.
Return Value
This method does not return a value.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	StreamSelector Class

# StreamSelector.SetModifyingStreams Method
Indicates to the platform which types of streams the application will modify.
Syntax
public void SetModifyingStreams(
  StreamType streamType
);

Parameters
streamType
Microsoft.MediaCenter.TVVM.StreamType. A member of the StreamType enumeration, treated as a bitmask. Multiple streams can be selected.
Return Value
This method does not return a value.
Remarks
The valid values of stream types are:
•	Microsoft.MediaCenter.TVVM.StreamType.Audio
•	Microsoft.MediaCenter.TVVM.StreamType.Teletext
•	Microsoft.MediaCenter.TVVM.StreamType.Subtitles
Calling this method is not required when modifying video streams.
Without calling this method, the platform will determine the correct selection of streams by its default processing. Selecting the stream types to modify indicates to the platform not do its default processing on those stream types.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	StreamSelector Class

# StreamType Enumeration
Contains values that identify the stream type. This is a System.Flags attributed type.
public enum StreamType

Members
Value	Description
Audio	An audio stream.
Caption	A closed caption stream.
Carousel	A carousel stream.
None	No stream.
Subtitles	A subtitles stream.
Superimpose	A super-imposed stream.
Teletext	A Teletext stream.
Video	A video stream.

Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace

# Tuning Class
Enables applications to issue detailed XML-based requests to the current tuner. Optionally, applications can also suppress certain non-critical components of the Windows Media Center TV user interface (UI).
Tuning requests are asynchronous, and the combination of a PropertyChanged event and the Tuning.ChannelState property allow an application to recognize when a tune request is no longer pending.
public class Tuning : MarshalByRefObject, Microsoft.MediaCenter.UI.IPropertyObject

Members
Public Instance Methods
Method	Description
Tune
Issues XML requests to the tuner and requests that non-critical Windows Media Center TV UI be suppressed.

Public Instance Properties
Property	Description
ChannelState
Gets a value that indicates whether a tune request is currently in progress.

Public Instance Events
Event	Description
PropertyChanged Event
Fires when the ChannelState property changes.

Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace

# Tuning.ChannelState Property
Gets a value that indicates whether a tune request is currently in progress.
Syntax
public ChannelState ChannelState {get;}

Property Value
Microsoft.MediaCenter.TVVM.ChannelState. Indicates whether a tune request is currently in progress.
This property is read-only.
Remarks
The initial state before any requests are made and a completed request are considered not pending, and return a value of Tuned.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	Tuning Class

# Tuning.PropertyChanged Event
Fires when the Tuning.ChannelState property changes.
Syntax
public override Microsoft.MediaCenter.UI.PropertyChangedEventHandler PropertyChanged;

Remarks
The ChannelState property changes when a previously-queued tune request changes from in progress to no longer pending.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	Tuning Class

# Tuning.Tune Method
Issues XML requests to the tuner and requests that non-critical Windows Media Center TV UI be suppressed.
Syntax
public void Tune(
  string  xmlTune,
  bool  suppressUI
);

Parameters
xmlTune
System.String. An XML string that represents the new tune request.
suppressUI
System.Boolean. Indicates whether the system should suppress its non-critical TV user interface components. A value of false requests that the system not suppress these components and render these components as it would by default.
Return Value
This method does not return a value.
Remarks
This method queues an asynchronous XML-encoded request to the current tuner, to change some characteristic of its tuning qualities. Conceptually, this is used to change the channel. However, due to tuners having many technical details that indirectly relate channels to specific technical characteristics (such as frequency, transponder, or multicast address), the XML request may require a significant amount of detail.
The request is asynchronous in nature, and will be completed at some point after the initial call is made. The application should make use of the Tuning.PropertyChanged event and the Tuning.ChannelState property to determine when a queued asynchronous request has ceased processing.
A final component of this method allows the application to request that Windows Media Center begin suppressing non-critical portions of its TV graphical user interface (where critical should be perceived as things such as emergency access messages or window management controls).
The application developer should be aware that only a single tune request is allowed to be pending at a time, and attempts to queue a new request while one is already pending will generate a TuningInProgressException.
The Tuning.ChannelState property indicates whether a tune is in progress at any given time.
Unless you receive an exception, the tune request is assumed to succeed, although the time to complete the request is dependent on the tuner.
The schema for tuning can be found at in the Protected Broadcast Driver Architecture (PBDA) Specification, which is available on the Developing Protected Broadcast Drivers in Windows page on the Microsoft website.
The following excpetions are possible from this method:
•	TuningSameChannelException
•	TuningFormatException
•	TuningInProgressException
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	Tuning Class

# TuningFormatException Exception
Thown to indicate that the application issued a tune request with an invalid XML format.
public class TuningFormatException: Exception

Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace

# TuningInProgressException Exception
Thown to indicate that the application issued a tune request before the prior tune request was completed.
public class TuningInProgressException: Exception

Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace


# TuningSameChannelException Exception
Thrown to indicate that the application issued a tune request to the same channel it currently is tuned to.
public class TuningSameChannelException : Exception

Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace

# TVVMbase Class
The base class from which all iTVVM applications are derived.
public class TVVMbase : MarshalByRefObject, Microsoft.MediaCenter.Hosting.IAddInModule, ITVVMAddInEntryPoint, Microsoft.MediaCenter.Hosting.IAddInEntryPoint, IDisposable

Members
Public Instance Methods
Method	Description
TVVMbase
Initializes a new instance of the TVVMbase class.
Dispose
Performs the tasks associated with freeing, releasing, and resetting resources.
Exit
Starts the shutdown process and ends the lifetime of the iTVVM application.
Initialize
Required by AddInModule. This can be replaced in the derived class for custom initialization. For more information, see IAddInModule.Initialize.
InvalidateDataSource
Called when the IiTvDataSource pointer is invalid and tells the application to reaquire a new pointer. This should be overridden if the derived application uses IiTvDataSource.
Launch
Required by IAddInEntryPoint. This should not be replaced in the derived class because this controls the lifetime and does the required initialization for iTVVM applications.
Uninitialize
Required by AddInModule. This can be replaced in the derived class for custom uninitialization. For more information, see IAddInModule.Uninitialize.

Protected Instance Methods
Method	Description
CleanUp
Gives the derived application a place to perform the cleanup work. This should be overridden in the derived class.
Dispose
Performs the tasks associated with freeing, releasing, and resetting resources. This is part of the standard dispose pattern. This method can be overridden for the derived class that is disposing of managed and unmanaged resources.
Launch
Gives the derived application a place to perform the initialization work. This method should be overridden in the derived class.

Public Instance Properties
Property	Description
OverlaySurface
Gets an OverlaySurface object.
Session
Gets a PlaybackSession object.
StreamSelector
Gets a StreamSelector object.
Tuning
Gets a Tuning object.
VideoSurface
Gets a VideoSurface object.

Protected Instance Fields
Field	Description
`_addinHost`
The AddinHost member passed to the IAddInEntryPoint.Launch method. For more information, see the AddinHost class.

Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace

# TVVMbase Constructor
Initializes a new instance of the TVVMbase class.
Syntax
public TVVMbase();

Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	TVVMbase Class

# `TVVMbase._addinHost` Field
The AddinHost member passed to the IAddInEntryPoint.Launch method. For more information, see the AddinHost class.
Syntax
`protected Microsoft.MediaCenter.Hosting.AddInHost _addinHost;`

Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	TVVMbase Class

# TVVMbase.CleanUp Method
Gives the derived application a place to perform the cleanup work. This should be overridden in the derived class.
Syntax
protected virtual void CleanUp();

Return Value
This method does not return a value.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	TVVMbase Class

# TVVMbase.Dispose Method
Performs the tasks associated with freeing, releasing, and resetting resources. This is part of the standard dispose pattern. This method can be overridden for the derived class that is disposing of managed and unmanaged resources.
Overload List
public virtual void Dispose();
protected virtual void Dispose(
  bool  disposing
);

Parameters
disposing
System.Boolean. If true, the method has been called directly or indirectly by the iTVVM application code. Managed and unmanaged resources can be disposed.
If false, the method has been called by the .NET runtime from inside the finalizer and you should not reference other objects. Only unmanaged resources can be disposed.
Return Value
This method does not return a value.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	TVVMbase Class

# TVVMbase.Exit Method
Starts the shutdown process and ends the lifetime of the iTVVM application.
Syntax
public override void Exit();

Return Value
This method does not return a value.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	TVVMbase Class

# TVVMbase.Initialize Method
Required by AddInModule. This can be replaced in the derived class for custom initialization. For more information, see IAddInModule.Initialize.
Syntax
public override void Initialize(
  Dictionary<string, object>  appInfo,
  Dictionary<string, object>  entryPointInfo
);

Parameters
appInfo
System.Collections.Dictionary<string,object>.  A collection of the attributes and corresponding values that were specified in the application element used to register the application. For more information, see Associating Application Entry Points with Integration Locations.
entryPointInfo
System.Collections.Dictionary<string,object>.  A collection of the attributes and corresponding values that were specified in the entrypoint element used to register the application's entry points. For more information, see Associating Application Entry Points with Integration Locations.
Return Value
This method does not return a value.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	TVVMbase Class

# TVVMbase.InvalidateDataSource Method
Called when the IiTvDataSource pointer is invalid and tells the application to reaquire a new pointer. This should be overridden if the derived application uses the IiTvDataSource interface.
Syntax
public virtual void InvalidateDataSource();

Return Value
This method does not return a value.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	TVVMbase Class

# TVVMbase.Launch Method
Performs initialization work.
Overload List
public override void Launch(
  Microsoft.MediaCenter.Hosting.AddInHost  host
);
protected virtual void Launch();

Parameters
host
Microsoft.MediaCenter.Hosting.AddInHost. The current AddinHost object.
Return Value
This method does not return a value.
Remarks
The public instance method is required by IAddInEntryPoint. This should not be replaced in the derived class because this controls the lifetime and does the required initialization for iTVVM applications.
The protected instance method gives the derived application a place to perform the initialization work. This method should be overridden in the derived class.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	TVVMbase Class

# TVVMbase.OverlaySurface Property
Gets an OverlaySurface object.
Syntax
public OverlaySurface OverlaySurface {get;}

Property Value
Microsoft.MediaCenter.TVVM.OverlaySurface. An OverlaySurface object.
This property is read-only.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	TVVMbase Class

# TVVMbase.Session Property
Gets a PlaybackSession object.
Syntax
public PlaybackSession Session {get;}

Property Value
Microsoft.MediaCenter.TVVM.PlaybackSession. A PlaybackSession object.
This property is read-only.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	TVVMbase Class

# TVVMbase.StreamSelector Property
Gets a StreamSelector object.
Syntax
public StreamSelector StreamSelector {get;}

Property Value
Microsoft.MediaCenter.TVVM.StreamSelector. A StreamSelector object
This property is read-only.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	TVVMbase Class

# TVVMbase.Tuning Property
Gets a Tuning object
Syntax
public Tuning Tuning {get;}

Property Value
Microsoft.MediaCenter.TVVM.Tuning. A Tuning object.
This property is read-only.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	TVVMbase Class

# TVVMbase.Uninitialize Method
Required by AddInModule. This can be replaced in the derived class for custom uninitialization. For more information, see IAddInModule.Uninitialize.
Syntax
public override void Uninitialize();

Return Value
This method does not return a value.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	TVVMbase Class
# TVVMbase.VideoSurface Property
Gets a VideoSurface object.

Syntax
public VideoSurface VideoSurface {get;}

Property Value
Microsoft.MediaCenter.TVVM.VideoSurface. A VideoSurface object.
This property is read-only.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	TVVMbase Class

# VideoSurface Class
Enables applications to query, obtain, and manipulate the characteristics of the video being rendered. Applications can determine the frame size of the video image, the aspect ratio, set one of several zoom modes, determine whether video is being rendered full-screen or in a window, and set a rectangle on the screen in which to render the video.
public class VideoSurface : Microsoft.MediaCenter.UI.IPropertyObject

Members
Public Instance Methods
Method	Description
ResetVideoToDefaultSettings
Resets the state of the video size and position (modified by SetVideo) to the user’s current preferences and rules for default video presentation.
SetSolidColor
Displays a solid color instead of video.
SetVideo
Sets the size and scaling of the video.

Public Instance Properties
Property	Description
AvailableZoomModes
Gets the available zoom modes.
FrameFormat
Gets a FrameFormat object containing the pixel aspect ratio and size of the current video.
ZoomMode
Gets or sets the zoom mode.

Public Instance Events
Event	Description
PropertyChanged Event
Fires when the FrameFormat property changes.

Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace

# VideoSurface.AvailableZoomModes Property
Gets the available zoom modes.
Syntax
public ZoomMode AvailableZoomModes {get;}

Property Value
Microsoft.MediaCenter.TVVM.ZoomMode. The available zoom modes.
This property is read-only.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	VideoSurface Class

# VideoSurface.FrameFormat Property
Gets a FrameFormat object containing the pixel aspect ratio and size of the current video.
Syntax
public FrameFormat FrameFormat {get;}

Property Value
Microsoft.MediaCenter.TVVM.FrameFormat. A FrameFormat object
This property is read-only.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	VideoSurface Class

# VideoSurface.PropertyChanged Event
Fires when the FrameFormat property changes.
Syntax
public override Microsoft.MediaCenter.UI.PropertyChangedEventHandler PropertyChanged;

Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	VideoSurface Class

# VideoSurface.ResetVideoToDefaultSettings Method
Resets the state of the video size and position (modified by SetVideo) to the user’s current preferences and rules for default video presentation.
Syntax
public void ResetVideoToDefaultSettings();

Return Value
This method does not return a value.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	VideoSurface Class

# VideoSurface.SetSolidColor Method
Displays a solid color instead of video.
Syntax
public void SetSolidColor(
  System.Drawing.Color  color
);

Parameters
color
System.Drawing.Color. A solid color.
Return Value
This method does not return a value.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	VideoSurface Class

# VideoSurface.SetVideo Method
Sets the size and scaling of the video.
Syntax
public void SetVideo(
  Microsoft.MediaCenter.UI.Rectangle  rect,
  bool  scaleToViewport
);

Parameters
rect
Microsoft.MediaCenter.UI.Rectangle. The rectangle of video on the video surface.
scaleToViewport
System.Boolean. Indicates whether to scale the video to the size of the player view port.
Return Value
This method does not return a value.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	VideoSurface Class

# VideoSurface.ZoomMode Property
Gets or sets the current zoom mode.
Syntax
public ZoomMode ZoomMode {get; set;}

Property Value
Microsoft.MediaCenter.TVVM.ZoomMode. The current zoom mode.
This property is read/write.
Remarks
None.
Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace
•	VideoSurface Class

# ZoomMode Enumeration
Contains values that indicate the available zoom modes.
public enum ZoomMode

Members
Value	Description
NonLinear	Nonlinear zoom mode.
Normal	Normal zoom mode.
Stretched	Stretched zoom mode.
Zoomed	Zoomed zoom mode.

Requirements
Reference: Microsoft.MediaCenter.ITVVM
Namespace: Microsoft.MediaCenter.TVVM
Assembly: Microsoft.MediaCenter.ITVVM.dll
Platform: Windows 7
See Also
•	Microsoft.MediaCenter.TVVM Namespace

# iTV C++ Reference
The interfaces and methods here are used to get and parse the embedded data in the TV stream, including tag packets and DSMCC sections.
The iTV API exposes the following function.
Function	Description
GetITVDataSource
Main entry point function to get the main interface for all data handling.

The iTV API exposes the following interfaces.
Interface	Description
IiTvDataAttribute
Deserializes data sample attributes from the iTVVM Data Sink filter.
IiTvDataReceiver
Represents the low level data receiver/processor object in the application.  
IiTvDataSource
This interface is the main interface to ITV VM data.
IiTvDataStreamControl
Used to control which streams will be sent to the application.

The iTV API exposes the following structures and enumerations.
Structure or Enumeration	Description
ITV_PBDA_TAG_ATTRIBUTE
Structure that defines a PBDA TAG.
ITV_TRANSPORT_PROPERTIES
Structure that defines the ITV Transport properties.
ITVDATA_FILTERING_METHOD_PID
A value that indicates streams are filtered by packet identifier (PID).
ITVDATA_FILTERING_METHOD_TAG_TABLE_UUID
A value that indicates streams are filtered by TAG TABLE UUID.
ITVDATA_FILTERING_NONE
A value that indicates streams are not filtered.

See Also
•	Programming Reference

# GetITVDataSource Function
The GetITVDataSource function is the main entry-point function to get the main interface for all data handling and returns the IiTvDataSource COM interface pointer. You must adhere to the standard COM rules of reference counting when interacting with this unmanaged resource.
Syntax
HRESULT GetITVDataSource(
  LPVOID*  ppVoid
);

Parameters
ppVoid
Pointer to a pointer to a void object. This is a pointer to an IiTvDataSource interface.
Return Values
The function returns an HRESULT. Possible values include, but are not limited to, those in the following table.
Return code	Description
S_OK	The function succeeded.

Remarks
None.
Requirements
Header: TVVMData.idl
Platform: Windows 7
See Also
•	iTV C++ Reference

# IiTvDataAttribute Interface
Used to deserialize data sample attributes coming from the iTVVM Data Sink filter.
In addition to the methods inherited from IUnknown, the IiTvDataAttribute interface exposes the following methods.
Method	Description
Deserialize
Starts the deserialization process, but does not return a value.
get_Count
Returns the count of attributes.
GetAttribByGUID
Returns the attribute by GUID.
GetAttribByIndex
Returns the attribute by index number.

Requirements
Header: TVVMData.idl
Platform: Windows 7
See Also
•	iTV C++ Reference

# IiTvDataAttribute::Deserialize Method
The Deserialize method starts the deserialization process, but does not return a value. This method should be called first. This method reflects the minimum and maximum attribute length.
Syntax
HRESULT Deserialize(
  BYTE*  pSerializedAttr,
  DWORD  dwLength
);

Parameters
pSerializedAttr
[in] Pointer to an attributes object. This is typically the pointer, passed into the IiTvDataReceiver::Receive method as the pAttributes parameter.
dwLength
[in] Double word containing the length. This is typically the attribute length, passed into the IiTvDataReceiver::Receive method as the dwAttributesLength parameter.
Return Values
The method returns an HRESULT. Possible values include, but are not limited to, those in the following table.
Return code	Description
S_OK	The method succeeded.

Remarks
This reflects the minimum and maximum attribute length.
Requirements
Header: TVVMData.idl
Platform: Windows 7
See Also
•	IiTvDataAttribute Interface

# IiTvDataAttribute::get_Count Method
The get_Count method retrieves the number of attributes.
Syntax
HRESULT get_Count();

Parameters
This method takes no parameters.
Return Values
The method returns an HRESULT. Possible values include, but are not limited to, those in the following table.
Return code	Description
S_OK	The method succeeded.

Remarks
None.
Requirements
Header: TVVMData.idl
Platform: Windows 7
See Also
•	IiTvDataAttribute Interface

# IiTvDataAttribute::GetAttribByGUID Method
The GetAttribByGUID method returns an attribute by GUID. Each attribute is identified by a GUID.
Syntax
HRESULT GetAttribByGUID(
  GUID  guidAttribute,
  BYTE*  pbAttribute,
  RANGED_DWORD*  pdwAttributeLength
);

Parameters
guidAttribute
[in] GUID object specifying the attribute.
pbAttribute
[out] Pointer to a byte containing the attribute.
pdwAttributeLength
[in, out] On input, indicates the size of the buffer pointed to by pbAttribute. On output, pointer to a double word containing the attribute length.
Return Values
The method returns an HRESULT. Possible values include, but are not limited to, those in the following table.
Return code	Description
S_OK	The method succeeded.
ERROR_INSUFFICIENT_BUFFER	Buffer to small.

Remarks
If the value of pdwAttributeLength is not large enough to hold the attribute, the function returns ERROR_INSUFFICIENT_BUFFER and the value of pdwAttributeLength is set to the size of the attribute.
Requirements
Header: TVVMData.idl
Platform: Windows 7
See Also
•	IiTvDataAttribute Interface

# IiTvDataAttribute::GetAttribByIndex Method
The GetAttribByIndex method returns the attribute by index.
Syntax
HRESULT GetAttribByIndex(
  LONG  lIndex,
  GUID*  pguidAttribute,
  BYTE*  pbAttribute,
  RANGED_DWORD*  pdwAttributeLength
);

Parameters
lIndex
[in] Long integer containing the index.
pguidAttribute
[out] Pointer to a GUID specifying the attribute.
pbAttribute
[out] Pointer to a byte containing the attribute.
pdwAttributeLength
[in, out] On input, indicates the size of the buffer pointed to by pbAttribute. On output, pointer to a double word containing the attribute length.
Return Values
The method returns an HRESULT. Possible values include, but are not limited to, those in the following table.
Return code	Description
S_OK	The method succeeded.
ERROR_INSUFFICIENT_BUFFER	Buffer to small.

Remarks
If the value of pdwAttributeLength is not large enough to hold the attribute, the function returns ERROR_INSUFFICIENT_BUFFER and the value of pdwAttributeLength is set to the size of the attribute.
Requirements
Header: TVVMData.idl
Platform: Windows 7
See Also
•	IiTvDataAttribute Interface

# IiTvDataReceiver Interface
This interface is implemented by the application. The purpose of this interface is to represent the low level data receiver/processor object in the application. This object provides its needs to the iTVVM Data Sink filter, receives control if requested of the stream filtering by stream ID, configures cache, and receives data along with any attributes. The iTVVM Data Sink filter also provides the object implementing this interface with state, synced with incoming data.
In addition to the methods inherited from IUnknown, the IiTvDataReceiver interface exposes the following methods.
Method	Description
get_CachingLength
Allows the application to specify the length of caching.
get_StreamControlByType
Allows the application to filter by type of stream.
Initialize
Allows the application to initialize before data starts flowing.
Receive
The main callback to the application with the data.
Start
Notifies the application that data will start flowing to it.
Stop
Notifies the application that data will stop flowing to it.
Terminate
Notifies the application that the ITVDataSource is terminating and no further calls should be made to it.

Requirements
Header: TVVMData.idl
Platform: Windows 7
See Also
•	iTV C++ Reference

# IiTvDataReceiver::get_CachingLength Method
The get_CachingLength method allows the application to specify the length of caching. A value of 0 means no caching.
Syntax
HRESULT get_CachingLength(
  DWORD* pCachingLength;
);

Parameters
pCachingLength
[out] Specifies the caching length.
Return Values
The method returns an HRESULT. Possible values include, but are not limited to, those in the following table.
Return code	Description
S_OK	The method succeeded.

Remarks
None.
Requirements
Header: TVVMData.idl
Platform: Windows 7
See Also
•	IiTvDataReceiver Interface

# IiTvDataReceiver::get_StreamControlByType Method
The get_StreamControlByType method allows the application to filter by type of streams.
Syntax
HRESULT get_StreamControlByType(
  GUID*  pGuidType;
);

Parameters
pGuidType
[out] Set to the stream filtering type. The following values are valid:
ITVDATA_FILTERING_METHOD_PID. Indicates that streams are filtered by packet identifier (PID).
ITVDATA_FILTERING_METHOD_TAG_TABLE_UUID. Indicates that streams are filtered by TAG TABLE UUID.
ITVDATA_FILTERING_NONE. Indicates that streams are not filtered.
Return Values
The method returns an HRESULT. Possible values include, but are not limited to, those in the following table.
Return code	Description
S_OK	The method succeeded.

Remarks
None.
Requirements
Header: TVVMData.idl
Platform: Windows 7
See Also
•	IiTvDataReceiver Interface

# IiTvDataReceiver::Initialize Method
The Initialize method allows the application to initialize before data starts flowing.
Syntax
HRESULT Initialize(
  IiTvDataStreamControl* IiTvDataStreamControl
);

Parameters
IiTvDataStreamControl
[in] Pointer to the IiTvDataStreamControl interface, which is a valid pointer if the application returned ITVDATA_FILTERING_METHOD_PID in response to its IiTvDataReceiver::get_StreamControlByType method. Otherwise, specify NULL.
Return Values
The method returns an HRESULT. Possible values include, but are not limited to, those in the following table.
Return code	Description
S_OK	The method succeeded.

Remarks
None.
Requirements
Header: TVVMData.idl
Platform: Windows 7
See Also
•	IiTvDataReceiver Interface
•	Start
•	Stop

# IiTvDataReceiver::Receive Method
The Receive method is the main callback to the application with the data. The application puts all of its data processing in this method.
Syntax
HRESULT Receive(
  BYTE*  piTVData,
  DWORD  dwiTVDataLength,
  BYTE*  pAttributes,
  DWORD  dwAttributesLength
);

Parameters
piTVData
[in] Pointer to a memory buffer containing the TV data.
dwiTVDataLength
[in] Specifies the amount of data in the buffer.
pAttributes
[in] Pointer to one or more attribute objects.
dwAttributesLength
[in] Double word containing the attributes length.
Return Values
The method returns an HRESULT. Possible values include, but are not limited to, those in the following table.
Return code	Description
S_OK	The method succeeded.

Remarks
None.
Requirements
Header: TVVMData.idl
Platform: Windows 7
See Also
•	IiTvDataReceiver Interface

# IiTvDataReceiver::Start Method
The Start method notifies the application that data will start flowing to it.
Syntax
HRESULT Start();

Parameters
This method takes no parameters.
Return Values
The method returns an HRESULT. Possible values include, but are not limited to, those in the following table.
Return code	Description
S_OK	The method succeeded.

Remarks
None.
Requirements
Header: TVVMData.idl
Platform: Windows 7
See Also
•	IiTvDataReceiver Interface
•	Initialize
•	Stop

# IiTvDataReceiver::Stop Method
The Stop method notifies the application that data will stop flowing to it.
Syntax
HRESULT Stop();

Parameters
This method takes no parameters.
Return Values
The method returns an HRESULT. Possible values include, but are not limited to, those in the following table.
Return code	Description
S_OK	The method succeeded.

Remarks
None.
Requirements
Header: TVVMData.idl
Platform: Windows 7
See Also
•	IiTvDataReceiver Interface
•	Initialize
•	Start

# IiTvDataReceiver::Terminate Method
The Terminate method notifies the application that the ITVDataSource interface is terminating and no further calls should be made to it.
Syntax
HRESULT Terminate();

Parameters
This method takes no parameters.
Return Values
The method returns an HRESULT. Possible values include, but are not limited to, those in the following table.
Return code	Description
S_OK	The method succeeded.

Remarks
None.
Requirements
Header: TVVMData.idl
Platform: Windows 7
See Also
•	IiTvDataReceiver Interface

# IiTvDataSource Interface
This interface is the main interface to ITV VM data. In addition to the methods inherited from IUnknown, the IiTvDataSource interface exposes the following methods.
Method	Description
Connect
Starts data flowing, providing the callback interface.
Disconnect
Causes the platform to stop sending data.

Requirements
Header: TVVMData.idl
Platform: Windows 7
See Also
•	iTV C++ Reference

# IiTvDataSource::Connect Method
The Connect method starts data flowing, providing the callback interface.
Syntax
HRESULT Connect();

Parameters
This method takes no parameters.
Return Values
The method returns an HRESULT. Possible values include, but are not limited to, those in the following table.
Return code	Description
S_OK	The method succeeded.

Remarks
None.
Requirements
Header: TVVMData.idl
Platform: Windows 7
See Also
•	IiTvDataSource Interface

# IiTvDataSource::Disconnect Method
The Disconnect method causes the platform to stop sending data.
Syntax
HRESULT Disconnect();

Parameters
This method takes no parameters.
Return Values
The method returns an HRESULT. Possible values include, but are not limited to, those in the following table.
Return code	Description
S_OK	The method succeeded.

Remarks
None.
Requirements
Header: TVVMData.idl
Platform: Windows 7
See Also
•	IiTvDataSource Interface

# IiTvDataStreamControl Interface
Used to control which streams (identified by either packet ID or other stream ID) that will be sent to the application. The streams selection and deselection may happen at any time during valid data connection.
Type of the stream ID by which packets are filtered, and is determined during connection of the callback interface IiTvDataReceiver. Specifically, the IiTvDataReceiver::get_StreamControlByType method will be called to ask which filtering method to use. The application must return a value to indicate the filtering method.
In addition to the methods inherited from IUnknown, the IiTvDataStreamControl interface exposes the following methods.
Method	Description
AddStream
Selects the stream to be sent to callback.
RemoveStream
Deselects the stream to be sent to callback.

Requirements
Header: TVVMData.idl
Platform: Windows 7
See Also
•	iTV C++ Reference

# IiTvDataStreamControl::AddStream Method
The AddStream method selects the stream by packet identifier (PID) to be sent to callback.
Syntax
HRESULT AddStream(
  VARIANT  StreamId
);

Parameters
StreamId
Specifies the stream ID.
Return Values
The method returns an HRESULT. Possible values include, but are not limited to, those in the following table.
Return code	Description
S_OK	The method succeeded.

Remarks
If the application returns ITVDATA_FILTERING_METHOD_PID in response to its IiTvDataReceiver::get_StreamControlByType method, the IiTvDataStreamControl interface is passed to IiTvDataReceiver::Initialize. Otherwise, this method returns NULL.
Requirements
Header: TVVMData.idl
Platform: Windows 7
See Also
•	IiTvDataStreamControl Interface
•	RemoveStream

# IiTvDataStreamControl::RemoveStream Method
The RemoveStream method deselects the stream by packet identifier (PID) to be sent to callback.
Syntax
HRESULT RemoveStream(
  VARIANT  StreamId
);

Parameters
StreamId
Specifies the stream ID.
Return Values
The method returns an HRESULT. Possible values include, but are not limited to, those in the following table.
Return code	Description
S_OK	The method succeeded.

Remarks
If the application returns ITVDATA_FILTERING_METHOD_PID in response to its IiTvDataReceiver::get_StreamControlByType method, the IiTvDataStreamControl interface is passed to IiTvDataReceiver::Initialize. Otherwise, this method returns NULL.
Requirements
Header: TVVMData.idl
Platform: Windows 7
See Also
•	AddStream
•	IiTvDataStreamControl Interface

# ITV_PBDA_TAG_ATTRIBUTE Structure
The ITV_PBDA_TAG_ATTRIBUTE structure is used to represent the data that is parsed from calls to the GetAttribByGUID and GetAttribByIndex methods of the IiTvDataAttribute interface.
Syntax
typedef struct ITV_PBDA_TAG_ATTRIBUTE{
  GUID  TableUUId;
  BYTE  TableId;
  WORD  VersionNo;
  DWORD  TableDataSize;
  BYTE  TableData;
};

Members
TableUUId
Specifies the table UUID.
TableId
Specifies the table ID.
VersionNo
Specifies the version number.
TableDataSize
Specifies the table data size.
TableData
Specifies table data.
Remarks
None.
Requirements
Header: TVVMData.idl
Platform: Windows 7
See Also
•	iTV C++ Reference

# ITV_TRANSPORT_PROPERTIES Structure
The ITV_TRANSPORT_PROPERTIES structure  is used to represent the data that is parsed from calls to the GetAttribByGUID and GetAttribByIndex methods of the IiTvDataAttribute interface.
Syntax
typedef struct ITV_TRANSPORT_PROPERTIES{
  ULONG  PID;
  LONGLONG  PCR;
  BYTE  TransportScramblingControl;
  BYTE  Reserved[3];
};

Members
PID
Specifies the packet identifier (PID) of the transport stream this data was transmitted on.
PCR
Specifies the most recent program clock reference (PCR) seen on this transport stream, before data contained in this buffer was parsed or handled.
TransportScramblingControl
Specifies the most recent transport scrambling control value set on packets carrying the payload of the data in this buffer.
Reserved[3]
Reserved.
Remarks
None.
Requirements
Header: TVVMData.idl
Platform: Windows 7
See Also
•	iTV C++ Reference

# ITVDATA_FILTERING_METHOD_PID Enumeration

The ITVDATA_FILTERING_METHOD_PID is a value that can be returned when a call to the IiTvDataReceiver::get_StreamControlByType method is called and indicates that streams are filtered by packet identifier (PID).

Syntax

```
enum __declspec(uuid("b5a94dec-c916-448c-be01-f526556c9df3"))
ITVDATA_FILTERING_METHOD_PID
{
    unused_B5A94DEC_C916_448c_BE01_F526556C9DF3 = 0
};
```

Members
unused_B5A94DEC_C916_448c_BE01_F526556C9DF3
This member is not used. See Remarks for more information.
Remarks
This GUID is the value for the constant ITVDATA_FILTERING_METHOD_PID. To use it, refer to the GUID value by `__uuidof(ITVDATA_FILTERING_METHOD_PID)`.
Requirements
Library: McITvVmData.dll
Platform: Windows 7
See Also
•	iTV C++ Reference

# ITVDATA_FILTERING_METHOD_TAG_TABLE_UUID Enumeration
The ITVDATA_FILTERING_METHOD_TAG_TABLE_UUID is a value that can be returned when a call to the IiTvDataReceiver::get_StreamControlByType method is called and indicates that streams are filtered by TAG TABLE UUID.
Syntax

```
enum __declspec(uuid("42949a19-d4dd-4eb7-923a-aa5b77773b0d"))
ITVDATA_FILTERING_METHOD_TAG_TABLE_UUID
{
    unused_42949A19_D4DD_4eb7_923A_AA5B77773B0D = 0
};
```

Members
unused_42949A19_D4DD_4eb7_923A_AA5B77773B0D
This member is not used. See Remarks for more information.
Remarks
This GUID is the value for the constant ITVDATA_FILTERING_METHOD_TAG_TABLE_UUID. To use it, refer to the GUID value by `__uuidof(ITVDATA_FILTERING_METHOD_TAG_TABLE_UUID)`.
Requirements
Library: McITvVmData.dll
Platform: Windows 7
See Also
•	iTV C++ Reference

# ITVDATA_FILTERING_NONE Enumeration
The ITVDATA_FILTERING_NONE is a value that can be returned when a call to the IiTvDataReceiver::get_StreamControlByType method is called and indicates that streams are not filtered.
Syntax

```
enum __declspec(uuid("3333ec50-a610-11db-befa-0800200c9a66"))
ITVDATA_FILTERING_NONE
{
    unused_3333EC50_A610_11db_BEFA_0800200C9A66 = 0
};
```

Members
unused_3333EC50_A610_11db_BEFA_0800200C9A66
This member is not used. See Remarks for more information.
Remarks
This GUID is the value for the constant ITVDATA_FILTERING_NONE. To use it, refer to the GUID value by `__uuidof(ITVDATA_FILTERING_NONE)`.
Requirements
Library: McITvVmData.dll
Platform: Windows 7
See Also
•	iTV C++ Reference

---

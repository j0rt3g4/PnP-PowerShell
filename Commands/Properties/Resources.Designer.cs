﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SharePointPnP.PowerShell.Commands.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SharePointPnP.PowerShell.Commands.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SharePoint PnP PowerShell Library.
        /// </summary>
        internal static string ApplicationName {
            get {
                return ResourceManager.GetString("ApplicationName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Command not executed due to healthscore value of {0}.
        /// </summary>
        internal static string CommandNotExecutedDueToHealthscoreValueOf0 {
            get {
                return ResourceManager.GetString("CommandNotExecutedDueToHealthscoreValueOf0", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Confirm.
        /// </summary>
        internal static string Confirm {
            get {
                return ResourceManager.GetString("Confirm", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Current site is not a tenant administration site.
        /// </summary>
        internal static string CurrentSiteIsNoTenantAdminSite {
            get {
                return ResourceManager.GetString("CurrentSiteIsNoTenantAdminSite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delete &apos;{0}&apos;?.
        /// </summary>
        internal static string Delete0 {
            get {
                return ResourceManager.GetString("Delete0", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delete field &apos;{0}&apos;?.
        /// </summary>
        internal static string DeleteField0 {
            get {
                return ResourceManager.GetString("DeleteField0", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Enter your credentials.
        /// </summary>
        internal static string EnterYourCredentials {
            get {
                return ResourceManager.GetString("EnterYourCredentials", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File {0} exists, overwrite?.
        /// </summary>
        internal static string File0ExistsOverwrite {
            get {
                return ResourceManager.GetString("File0ExistsOverwrite", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to File does not exist.
        /// </summary>
        internal static string FileDoesNotExist {
            get {
                return ResourceManager.GetString("FileDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Unified Group with MailNickname of {0} already exists. Do you want to create another one?.
        /// </summary>
        internal static string ForceCreationOfExistingGroup0 {
            get {
                return ResourceManager.GetString("ForceCreationOfExistingGroup0", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to This request can take a long time to execute. Continue?.
        /// </summary>
        internal static string GetTenantSite_ExecuteCmdlet_This_request_can_take_a_long_time_to_execute__Continue_ {
            get {
                return ResourceManager.GetString("GetTenantSite_ExecuteCmdlet_This_request_can_take_a_long_time_to_execute__Continu" +
                        "e_", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Health score not sufficient.
        /// </summary>
        internal static string HealthScoreNotSufficient {
            get {
                return ResourceManager.GetString("HealthScoreNotSufficient", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to List not found.
        /// </summary>
        internal static string ListNotFound {
            get {
                return ResourceManager.GetString("ListNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The Azure AD OAuth 2.0 Access Token has expired. Authenticate again using the Connect-PnPMicrosoftGraph cmdlet..
        /// </summary>
        internal static string MicrosoftGraphOAuthAccessTokenExpired {
            get {
                return ResourceManager.GetString("MicrosoftGraphOAuthAccessTokenExpired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No Azure AD connection, please connect first with Connect-PnPMicrosoftGraph.
        /// </summary>
        internal static string NoAzureADAccessToken {
            get {
                return ResourceManager.GetString("NoAzureADAccessToken", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No connection, please connect first with Connect-PnPOnline.
        /// </summary>
        internal static string NoConnection {
            get {
                return ResourceManager.GetString("NoConnection", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No connection to disconnect.
        /// </summary>
        internal static string NoConnectionToDisconnect {
            get {
                return ResourceManager.GetString("NoConnectionToDisconnect", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No context present. Connect first with Connect-PnPOnline.
        /// </summary>
        internal static string NoContextPresent {
            get {
                return ResourceManager.GetString("NoContextPresent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SharePoint PnP PowerShell Library ({0}).
        /// </summary>
        internal static string OfficeDevPnPPowerShellLibrary0 {
            get {
                return ResourceManager.GetString("OfficeDevPnPPowerShellLibrary0", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        /// </summary>
        internal static System.Drawing.Icon pnp {
            get {
                object obj = ResourceManager.GetObject("pnp", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove content type?.
        /// </summary>
        internal static string RemoveContentType {
            get {
                return ResourceManager.GetString("RemoveContentType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove custom action?.
        /// </summary>
        internal static string RemoveCustomAction {
            get {
                return ResourceManager.GetString("RemoveCustomAction", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove event receiver?.
        /// </summary>
        internal static string RemoveEventReceiver {
            get {
                return ResourceManager.GetString("RemoveEventReceiver", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove Group &apos;{0}&apos;.
        /// </summary>
        internal static string RemoveGroup0 {
            get {
                return ResourceManager.GetString("RemoveGroup0", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove JavaScript (&apos;{0}&apos;)?.
        /// </summary>
        internal static string RemoveJavaScript0 {
            get {
                return ResourceManager.GetString("RemoveJavaScript0", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove key and value from property bag?.
        /// </summary>
        internal static string RemoveKeyAndValueFromPropertyBag {
            get {
                return ResourceManager.GetString("RemoveKeyAndValueFromPropertyBag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove list?.
        /// </summary>
        internal static string RemoveList {
            get {
                return ResourceManager.GetString("RemoveList", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove list item with ID {0}?.
        /// </summary>
        internal static string RemoveListItemWithId0 {
            get {
                return ResourceManager.GetString("RemoveListItemWithId0", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove Navigation Node &apos;{0}&apos;.
        /// </summary>
        internal static string RemoveNavigationNode0 {
            get {
                return ResourceManager.GetString("RemoveNavigationNode0", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove propertybag value.
        /// </summary>
        internal static string RemovePropertyBagValue {
            get {
                return ResourceManager.GetString("RemovePropertyBagValue", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove site collection &apos;{0}&apos;?.
        /// </summary>
        internal static string RemoveSiteCollection0 {
            get {
                return ResourceManager.GetString("RemoveSiteCollection0", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove Term &apos;{0}&apos; and all underlying Terms?.
        /// </summary>
        internal static string RemoveTerm0AndAllUnderlyingTerms {
            get {
                return ResourceManager.GetString("RemoveTerm0AndAllUnderlyingTerms", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove Termgroup &apos;{0}&apos; and all underlying Termsets and Terms? .
        /// </summary>
        internal static string RemoveTermGroup0AndAllUnderlyingTermSetsAndTerms {
            get {
                return ResourceManager.GetString("RemoveTermGroup0AndAllUnderlyingTermSetsAndTerms", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove Termset &apos;{0}&apos; and it&apos;s underlying Terms?.
        /// </summary>
        internal static string RemoveTermSet0 {
            get {
                return ResourceManager.GetString("RemoveTermSet0", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove the {0} key and its value from the property bag?.
        /// </summary>
        internal static string RemoveThe0KeyAndItsValueFromThePropertyBag {
            get {
                return ResourceManager.GetString("RemoveThe0KeyAndItsValueFromThePropertyBag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove view &apos;{0}&apos;?.
        /// </summary>
        internal static string RemoveView0 {
            get {
                return ResourceManager.GetString("RemoveView0", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove Web &apos;{0}&apos; ? .
        /// </summary>
        internal static string RemoveWeb0 {
            get {
                return ResourceManager.GetString("RemoveWeb0", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Retry {0}: Server not healthy, waiting {1} seconds (Server Health Score: {2}).
        /// </summary>
        internal static string Retry0ServerNotHealthyWaiting1seconds {
            get {
                return ResourceManager.GetString("Retry0ServerNotHealthyWaiting1seconds", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Uninstall app {0}?.
        /// </summary>
        internal static string UninstallApp0 {
            get {
                return ResourceManager.GetString("UninstallApp0", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Web &apos;{0}&apos; created at {1}.
        /// </summary>
        internal static string Web0CreatedAt1 {
            get {
                return ResourceManager.GetString("Web0CreatedAt1", resourceCulture);
            }
        }
    }
}

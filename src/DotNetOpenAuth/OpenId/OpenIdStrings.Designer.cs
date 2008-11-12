﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DotNetOpenAuth.OpenId {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class OpenIdStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal OpenIdStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DotNetOpenAuth.OpenId.OpenIdStrings", typeof(OpenIdStrings).Assembly);
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
        ///   Looks up a localized string similar to The private data supplied does not meet the requirements of any known Association type.  Its length may be too short, or it may have been corrupted..
        /// </summary>
        internal static string BadAssociationPrivateData {
            get {
                return ResourceManager.GetString("BadAssociationPrivateData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The following properties must be set before the Diffie-Hellman algorithm can generate a public key: {0}.
        /// </summary>
        internal static string DiffieHellmanRequiredPropertiesNotSet {
            get {
                return ResourceManager.GetString("DiffieHellmanRequiredPropertiesNotSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot encode &apos;{0}&apos; because it contains an illegal character for Key-Value Form encoding.  (line {1}: &apos;{2}&apos;).
        /// </summary>
        internal static string InvalidCharacterInKeyValueFormInput {
            get {
                return ResourceManager.GetString("InvalidCharacterInKeyValueFormInput", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot decode Key-Value Form because a line was found without a &apos;{0}&apos; character.  (line {1}: &apos;{2}&apos;).
        /// </summary>
        internal static string InvalidKeyValueFormCharacterMissing {
            get {
                return ResourceManager.GetString("InvalidKeyValueFormCharacterMissing", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The list of keys do not match the provided dictionary..
        /// </summary>
        internal static string KeysListAndDictionaryDoNotMatch {
            get {
                return ResourceManager.GetString("KeysListAndDictionaryDoNotMatch", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unless using transport layer encryption, &quot;no-encryption&quot; MUST NOT be used..
        /// </summary>
        internal static string NoEncryptionSessionRequiresHttps {
            get {
                return ResourceManager.GetString("NoEncryptionSessionRequiresHttps", resourceCulture);
            }
        }
    }
}

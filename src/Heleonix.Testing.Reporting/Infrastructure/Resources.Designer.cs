﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Heleonix.Testing.Reporting.Infrastructure {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Heleonix.Testing.Reporting.Infrastructure.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to :root {
        ///    --color-border: lightgray;
        ///    --color-start: lightblue;
        ///    --color-end: lightgreen;
        ///    --color-duration: lightgray;
        ///    --color-hover: lightgray;
        ///    --color-selected: darkgray;
        ///    --color-link: darkblue;
        ///    --color-passed: green;
        ///    --color-failed: red;
        ///    --color-error: darkred;
        ///    --color-warning: orange;
        ///    --color-skipped: lightblue;
        ///    --color-undefined: lightgray;
        ///    --gap-default: 0.5rem;
        ///    --font-family: arial, helvetica, sans-serif;
        ///}
        ///
        ///* {
        ///    font-famil [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Css {
            get {
                return ResourceManager.GetString("Css", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ﻿@using System
        ///@using Heleonix.Testing.Reporting.Domain
        ///
        ///@inherits RazorEngineCore.RazorEngineTemplateBase&lt;Report&gt;
        ///
        ///&lt;!DOCTYPE html&gt;
        ///&lt;html&gt;
        ///&lt;head&gt;
        ///    &lt;meta charset=&quot;utf-8&quot; /&gt;
        ///    &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1&quot; /&gt;
        ///    &lt;style&gt;
        ///        @**@
        ///    &lt;/style&gt;
        ///    &lt;script&gt;
        ///        @**@
        ///    &lt;/script&gt;
        ///    &lt;title&gt;@Model.Result.Summary.Title&lt;/title&gt;
        ///&lt;/head&gt;
        ///&lt;body class=&quot;main-page&quot;&gt;
        ///    &lt;header class=&quot;main-header&quot;&gt;
        ///        &lt;span&gt;@Model.Result.Summary.Owner&lt;/span&gt;
        ///  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Html {
            get {
                return ResourceManager.GetString("Html", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to document.addEventListener(&apos;DOMContentLoaded&apos;, function () {
        ///    var assemblies = document.querySelectorAll(&apos;data-role=&quot;item-assembly&quot;&apos;)
        ///    var classes = document.querySelectorAll(&apos;data-role=&quot;item-class&quot;&apos;)
        ///    var testCases = document.querySelectorAll(&apos;data-role=&quot;item-testcase&quot;&apos;)
        ///
        ///    var assembliesSummary = document.querySelector(&apos;[data-role=&quot;summary-assemblies&quot;]&apos;)
        ///    var classesSummary = document.querySelector(&apos;[data-role=&quot;summary-classes&quot;]&apos;)
        ///    var testCasesSummary = document.querySelector(&apos;[dat [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Js {
            get {
                return ResourceManager.GetString("Js", resourceCulture);
            }
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GUI.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=LAPTOP-VS13VLD8;Initial Catalog=QL_SHOPTHUCUNG1;Persist Security Info" +
            "=True;User ID=sa;Password=sa")]
        public string QL_SHOPTHUCUNG {
            get {
                return ((string)(this["QL_SHOPTHUCUNG"]));
            }
            set {
                this["QL_SHOPTHUCUNG"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-H370V7G;Initial Catalog=QL_SHOPTHUCUNG1;Persist Security Info" +
            "=True;User ID=sa;Password=123")]
        public string QL_SHOPTHUCUNG1 {
            get {
                return ((string)(this["QL_SHOPTHUCUNG1"]));
            }
            set {
                this["QL_SHOPTHUCUNG1"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-H370V7G;Integrated Security=True")]
        public string ConnectionString {
            get {
                return ((string)(this["ConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-H370V7G;Initial Catalog=QL_SHOPTHUCUNG1;Persist Security Info" +
            "=True;User ID=sa;Password=123")]
        public string QL_SHOPTHUCUNG1ConnectionString {
            get {
                return ((string)(this["QL_SHOPTHUCUNG1ConnectionString"]));
            }
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Live_Netease_Music_Title.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.6.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Drawing.Font G_displayFont {
            get {
                return ((global::System.Drawing.Font)(this["G_displayFont"]));
            }
            set {
                this["G_displayFont"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Black")]
        public global::System.Drawing.Color G_displayColor {
            get {
                return ((global::System.Drawing.Color)(this["G_displayColor"]));
            }
            set {
                this["G_displayColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool G_customBackground {
            get {
                return ((bool)(this["G_customBackground"]));
            }
            set {
                this["G_customBackground"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Control")]
        public global::System.Drawing.Color G_customDisplayBackColor {
            get {
                return ((global::System.Drawing.Color)(this["G_customDisplayBackColor"]));
            }
            set {
                this["G_customDisplayBackColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public int G_customDisplayBackTransValue {
            get {
                return ((int)(this["G_customDisplayBackTransValue"]));
            }
            set {
                this["G_customDisplayBackTransValue"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool G_displayModeRolling {
            get {
                return ((bool)(this["G_displayModeRolling"]));
            }
            set {
                this["G_displayModeRolling"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("400")]
        public int G_displayRollingSize {
            get {
                return ((int)(this["G_displayRollingSize"]));
            }
            set {
                this["G_displayRollingSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool G_topMost {
            get {
                return ((bool)(this["G_topMost"]));
            }
            set {
                this["G_topMost"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool Changed {
            get {
                return ((bool)(this["Changed"]));
            }
            set {
                this["Changed"] = value;
            }
        }
    }
}

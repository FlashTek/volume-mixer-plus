﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VolumeMixerPlus.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.3.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Control+VolumeUp")]
        public string IncreaseCurrentVolumeKeyCombinationAsString {
            get {
                return ((string)(this["IncreaseCurrentVolumeKeyCombinationAsString"]));
            }
            set {
                this["IncreaseCurrentVolumeKeyCombinationAsString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Control+VolumeDown")]
        public string DecreaseCurrentVolumeKeyCombinationAsString {
            get {
                return ((string)(this["DecreaseCurrentVolumeKeyCombinationAsString"]));
            }
            set {
                this["DecreaseCurrentVolumeKeyCombinationAsString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Control+VolumeMute")]
        public string MuteCurrentKeyCombinationAsString {
            get {
                return ((string)(this["MuteCurrentKeyCombinationAsString"]));
            }
            set {
                this["MuteCurrentKeyCombinationAsString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Control+PageUp")]
        public string SwitchAudioDeviceKeyCombinationAsString {
            get {
                return ((string)(this["SwitchAudioDeviceKeyCombinationAsString"]));
            }
            set {
                this["SwitchAudioDeviceKeyCombinationAsString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Alt+VolumeUp")]
        public string IncreaseAllVolumeKeyCombinationAsString {
            get {
                return ((string)(this["IncreaseAllVolumeKeyCombinationAsString"]));
            }
            set {
                this["IncreaseAllVolumeKeyCombinationAsString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Alt+VolumeDown")]
        public string DecreaseAllVolumeKeyCombinationAsString {
            get {
                return ((string)(this["DecreaseAllVolumeKeyCombinationAsString"]));
            }
            set {
                this["DecreaseAllVolumeKeyCombinationAsString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Alt+VolumeMute")]
        public string MuteAllKeyCombinationAsString {
            get {
                return ((string)(this["MuteAllKeyCombinationAsString"]));
            }
            set {
                this["MuteAllKeyCombinationAsString"] = value;
            }
        }
    }
}

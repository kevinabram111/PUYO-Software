﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PUYO.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-VJD692D;Initial Catalog=ERDPUYO;Integrated Security=True;Encr" +
            "ypt=False;TrustServerCertificate=True")]
        public string ERDPUYOConnectionString {
            get {
                return ((string)(this["ERDPUYOConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-VJD692D;Initial Catalog=CashierPUYO;Integrated Security=True;" +
            "Encrypt=False;TrustServerCertificate=True")]
        public string CashierPUYOConnectionString {
            get {
                return ((string)(this["CashierPUYOConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-VJD692D;Initial Catalog=WarehousePUYO;Integrated Security=Tru" +
            "e;Encrypt=False;TrustServerCertificate=True")]
        public string WarehousePUYOConnectionString {
            get {
                return ((string)(this["WarehousePUYOConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=KEVINABRAM6EED\\SQLEXPRESS;Initial Catalog=PUYO_WAREHOUSE;Integrated S" +
            "ecurity=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False")]
        public string PUYO_WAREHOUSEConnectionString {
            get {
                return ((string)(this["PUYO_WAREHOUSEConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=KEVINABRAM6EED\\SQLEXPRESS;Initial Catalog=PUYO_CASHIER;Integrated Sec" +
            "urity=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False")]
        public string PUYO_CASHIERConnectionString {
            get {
                return ((string)(this["PUYO_CASHIERConnectionString"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=KEVINABRAM6EED\\SQLEXPRESS;Initial Catalog=PUYO_WAREHOUSE;Integrated S" +
            "ecurity=True;Connect Timeout=30;TrustServerCertificate=False")]
        public string PUYO_WAREHOUSEConnectionString1 {
            get {
                return ((string)(this["PUYO_WAREHOUSEConnectionString1"]));
            }
        }
    }
}

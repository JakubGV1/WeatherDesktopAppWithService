﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WeatherAppClient.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.8.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Akcja")]
        public string Action {
            get {
                return ((string)(this["Action"]));
            }
            set {
                this["Action"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("O autorze")]
        public string Author {
            get {
                return ((string)(this["Author"]));
            }
            set {
                this["Author"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Zamknij")]
        public string Close {
            get {
                return ((string)(this["Close"]));
            }
            set {
                this["Close"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Pełna informacja")]
        public string Information {
            get {
                return ((string)(this["Information"]));
            }
            set {
                this["Information"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Wybrane miasto")]
        public string City {
            get {
                return ((string)(this["City"]));
            }
            set {
                this["City"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Mapa Polski")]
        public string MapPolish {
            get {
                return ((string)(this["MapPolish"]));
            }
            set {
                this["MapPolish"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://localhost:7054")]
        public string BaseUrl {
            get {
                return ((string)(this["BaseUrl"]));
            }
            set {
                this["BaseUrl"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("/api/PublicData")]
        public string WeatherController {
            get {
                return ((string)(this["WeatherController"]));
            }
            set {
                this["WeatherController"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Pobierz aktualne dane pogodowe")]
        public string GetAllWeather {
            get {
                return ((string)(this["GetAllWeather"]));
            }
            set {
                this["GetAllWeather"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Wybierz miasto:")]
        public string ChoseCityName {
            get {
                return ((string)(this["ChoseCityName"]));
            }
            set {
                this["ChoseCityName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Wczytaj aktualne dane")]
        public string LoadCurrentData {
            get {
                return ((string)(this["LoadCurrentData"]));
            }
            set {
                this["LoadCurrentData"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Stan")]
        public string Status {
            get {
                return ((string)(this["Status"]));
            }
            set {
                this["Status"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Wilgotność")]
        public string Humidity {
            get {
                return ((string)(this["Humidity"]));
            }
            set {
                this["Humidity"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Temperatura")]
        public string Temperature {
            get {
                return ((string)(this["Temperature"]));
            }
            set {
                this["Temperature"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Ciśnienie")]
        public string Pressure {
            get {
                return ((string)(this["Pressure"]));
            }
            set {
                this["Pressure"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2e9cdfa3-1bbb-4419-b0f6-ab9640f2d520")]
        public string ClientToken {
            get {
                return ((string)(this["ClientToken"]));
            }
            set {
                this["ClientToken"] = value;
            }
        }
    }
}

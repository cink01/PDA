﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pujcovna.Properties {
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Pujcovna.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Tlačítko potvrdit se umožní použít jen tehdy, kdy budou splněny všechny požadavky:
        ///
        ///-Ujistě te se, že Název, Režie, Žánr není prázdný
        ///-Ujistě te se, že Režie a Žánr neobsahuje čísla
        ///-Ujistě te se, že film se stejným názvem již není pridán
        ///-Ujistě te se, že Počet filmů neni vyšší jak Celkový počet filmů.
        /// </summary>
        internal static string Chyba_MESSAGE {
            get {
                return ResourceManager.GetString("Chyba_MESSAGE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Chyba.
        /// </summary>
        internal static string Chyba_TITTLE {
            get {
                return ResourceManager.GetString("Chyba_TITTLE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap downo {
            get {
                object obj = ResourceManager.GetObject("downo", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to     Opravdu chcete ukončit program?
        ///Veškerý neuložený postup bude ztracen!.
        /// </summary>
        internal static string EXIT_MESSAGE {
            get {
                return ResourceManager.GetString("EXIT_MESSAGE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Ukončit?.
        /// </summary>
        internal static string EXIT_TITLE {
            get {
                return ResourceManager.GetString("EXIT_TITLE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Pro přidání sady dat otevřete xml soubor a nebo zvolte backup file.
        ///Pakliže chcete vyhledávat zadejte přesný název filmu.
        ///Pro zobrazení tlačítek sežazení stačit zvolit volbu v Upravit/Seřadit/..
        ///Seřazení v seznamu v dialogu Půjčit/Vrátit má podle seznamu v hlavním okně
        ///Program vypracován jako Semestrální Práce
        ///předmět Programování Desktopových Aplikací
        ///Vypracoval: Tomaš Cink - cink01@student.vspj.cz.
        /// </summary>
        internal static string HINT_MESSAGE {
            get {
                return ResourceManager.GetString("HINT_MESSAGE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nápověda.
        /// </summary>
        internal static string HINT_TITLE {
            get {
                return ResourceManager.GetString("HINT_TITLE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to .
        /// </summary>
        internal static string INFO_MESSAGE {
            get {
                return ResourceManager.GetString("INFO_MESSAGE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Informace o půjčce.
        /// </summary>
        internal static string INFO_TITTLE {
            get {
                return ResourceManager.GetString("INFO_TITTLE", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized resource of type System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap upto {
            get {
                object obj = ResourceManager.GetObject("upto", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}

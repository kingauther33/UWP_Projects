<<<<<<< HEAD
<<<<<<< HEAD
﻿#pragma checksum "D:\Documents\UWP_Projects\Project_FastFood\Project_FastFood\Pages\Layout.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C7E6BB4C0A6CBEC743DC3B85D8A54B3C8EE8BE938E8F2588C4DA951DFD1BD33E"
=======
﻿#pragma checksum "D:\Documents\UWP_Projects\Project_FastFood\Project_FastFood\Pages\Layout.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2AB066648C916DAD9D2AEF909DA04BA3DD9F08D647382154552011BF67E2718D"
>>>>>>> parent of 6875e9f (update)
=======
﻿#pragma checksum "D:\Documents\UWP_Projects\Project_FastFood\Project_FastFood\Pages\Layout.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2AB066648C916DAD9D2AEF909DA04BA3DD9F08D647382154552011BF67E2718D"
>>>>>>> parent of ae6be87 (Update)
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_FastFood.Pages
{
    partial class Layout : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
<<<<<<< HEAD
<<<<<<< HEAD
=======
=======
>>>>>>> parent of ae6be87 (Update)
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_FontIcon_Glyph(global::Windows.UI.Xaml.Controls.FontIcon obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Glyph = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class Layout_obj5_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            ILayout_Bindings
        {
            private global::Project_FastFood.Models.MenuItem dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj5;
            private global::Windows.UI.Xaml.Controls.FontIcon obj6;
            private global::Windows.UI.Xaml.Controls.TextBlock obj7;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj6GlyphDisabled = false;
            private static bool isobj7TextDisabled = false;

            public Layout_obj5_Bindings()
            {
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 73 && columnNumber == 130)
                {
                    isobj6GlyphDisabled = true;
                }
                else if (lineNumber == 74 && columnNumber == 70)
                {
                    isobj7TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 5: // Pages\Layout.xaml line 71
                        this.obj5 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.ListViewItem)target);
                        break;
                    case 6: // Pages\Layout.xaml line 73
                        this.obj6 = (global::Windows.UI.Xaml.Controls.FontIcon)target;
                        break;
                    case 7: // Pages\Layout.xaml line 74
                        this.obj7 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj5.Target as global::Windows.UI.Xaml.Controls.ListViewItem).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::Project_FastFood.Models.MenuItem) item, 1 << phase);
            }

            public void Recycle()
            {
            }

            // ILayout_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::Project_FastFood.Models.MenuItem)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::Project_FastFood.Models.MenuItem obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Icon(obj.Icon, phase);
                        this.Update_Name(obj.Name, phase);
                    }
                }
            }
            private void Update_Icon(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Pages\Layout.xaml line 73
                    if (!isobj6GlyphDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_FontIcon_Glyph(this.obj6, obj, null);
                    }
                }
            }
            private void Update_Name(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // Pages\Layout.xaml line 74
                    if (!isobj7TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj7, obj, null);
                    }
                }
            }
        }
<<<<<<< HEAD
>>>>>>> parent of 6875e9f (update)
=======
>>>>>>> parent of ae6be87 (Update)
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
<<<<<<< HEAD
            case 2: // Pages\Layout.xaml line 10
=======
            case 2: // Pages\Layout.xaml line 11
>>>>>>> parent of ae6be87 (Update)
                {
                    this.splitV = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
<<<<<<< HEAD
            case 3: // Pages\Layout.xaml line 19
                {
                    global::Windows.UI.Xaml.Controls.Button element3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element3).Click += this.HomeNavigate;
                }
                break;
            case 4: // Pages\Layout.xaml line 101
=======
            case 3: // Pages\Layout.xaml line 68
                {
                    this.menuList = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    ((global::Windows.UI.Xaml.Controls.ListView)this.menuList).Loaded += this.menuList_Loaded;
                }
                break;
            case 5: // Pages\Layout.xaml line 71
                {
                    global::Windows.UI.Xaml.Controls.ListViewItem element5 = (global::Windows.UI.Xaml.Controls.ListViewItem)(target);
                    ((global::Windows.UI.Xaml.Controls.ListViewItem)element5).Tapped += this.menuList_Tapped;
                }
                break;
            case 8: // Pages\Layout.xaml line 117
>>>>>>> parent of ae6be87 (Update)
                {
                    this.MainFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
<<<<<<< HEAD
=======
            switch(connectionId)
            {
            case 5: // Pages\Layout.xaml line 71
                {                    
                    global::Windows.UI.Xaml.Controls.ListViewItem element5 = (global::Windows.UI.Xaml.Controls.ListViewItem)target;
                    Layout_obj5_Bindings bindings = new Layout_obj5_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element5.DataContext);
                    element5.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element5, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element5, bindings);
                }
                break;
            }
>>>>>>> parent of ae6be87 (Update)
            return returnValue;
        }
    }
}


using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorComponent;

public  class SInput1: SDomComponentBase
{
    private readonly ComponentCssProvider _wrapperCls = new ComponentCssProvider();
    
    private string value = string.Empty;
    private string cacheValue = string.Empty;
    private bool isFocus = false;
    private bool isHovering = false;
    private bool eyeClosed => Mode == InputMode.Password;
    
    #region parameter/property

    /// <summary>
    /// allow clear
    /// </summary>
    public bool IsAllowClear { get; set; } = false;
    
    /// <summary>
    /// min length
    /// </summary>
    [Parameter]
    public int? MinLength { get; set; }
    
    
    /// <summary>
    /// placeholder
    /// </summary>
    [Parameter]
    public string Placeholder { get; set; } = string.Empty;

    /// <summary>
    /// prefix
    /// </summary>
    [Parameter]
    public RenderFragment? PreFix { get; set; }

    /// <summary>
    /// suffix
    /// </summary>
    [Parameter]
    public RenderFragment? Suffix { get; set; }
    
    /// <summary>
    /// before tag
    /// </summary>
    [Parameter]
    public RenderFragment? AddonBefore { get; set; }
    
    /// <summary>
    /// after tag
    /// </summary>
    [Parameter]
    public RenderFragment? AddonAfter { get; set; }
    
    /// <summary>
    /// mode 
    /// </summary>
    [Parameter]
    public InputMode Mode { get; set; } = InputMode.Normal;
    

    /// <summary>
    /// default value
    /// </summary>
    [Parameter]
    public string? DefaultValue { get; set; }

    /// <summary>
    /// value
    /// </summary>
    [Parameter]
    public string? Value { get; set; }

    /// <summary>
    /// disabled
    /// </summary>
    public bool Disabled { get; set; } = false;

    /// <summary>
    /// read only
    /// </summary>
    [Parameter]
    public bool ReadOnly { get; set; } = false;

    /// <summary>
    /// auto focused
    /// </summary>
    public bool AutoFocus { get; set; } = false;

    /// <summary>
    /// show clear
    /// </summary>
    [Parameter]
    public bool ShowClear { get; set; } = false;

    /// <summary>
    /// hidden suffix
    /// </summary>
    [Parameter]
    public bool HiddenSuffix { get; set; } = false;


    /// <summary>
    /// inset label
    /// </summary>
    [Parameter]
    public RenderFragment? InsetLabel { get; set; }

    /// <summary>
    /// inset label id
    /// </summary>
    [Parameter]
    public string InsetLabelId { get; set; } = default;


    /// <summary>
    /// clear button icon
    /// </summary>
    [Parameter]
    public RenderFragment? ClearIcon { get; set; }
    
    /// <summary>
    /// size
    /// </summary>
    [Parameter]
    public SizeType Size { get; set; } = SizeType.Default;

    /// <summary>
    /// validate status
    /// </summary>
    [Parameter]
    public ValidateStatus ValidateStatus { get; set; } = ValidateStatus.Default;
    
    #endregion parameter/property

    #region event 

    [Parameter]
    public EventCallback<MouseEventArgs> OnClear { get; set; }
    

    [Parameter]
    public EventCallback<MouseEventArgs> OnChange { get; set; }

    
    [Parameter]
    public EventCallback<MouseEventArgs> OnBlur { get; set; }
    
    [Parameter]
    public EventCallback<MouseEventArgs> onFocus { get; set; }
    
    [Parameter]
    public EventCallback<MouseEventArgs> onInput { get; set; }
    
    [Parameter]
    public EventCallback<MouseEventArgs> onKeyDown { get; set; }
    
    [Parameter]
    public EventCallback<MouseEventArgs> onKeyUp { get; set; }
    
    [Parameter]
    public EventCallback<MouseEventArgs> onKeyPress { get; set; }
    
    [Parameter]
    public EventCallback<MouseEventArgs> onEnterPress { get; set; }
    #endregion event

    internal RenderFragment? RenderPrepend
    {
        get
        {
            if (AddonBefore != null)
            {
                var prefixWrapperCls = new ComponentCssProvider();
                prefixWrapperCls.StyleApply(SInputCons.PrependWrapperStyle.Prepend);
            
                // if(AddonBefore.IsSemiIcon()){
                //   prefixWrapperCls.StyleApply(SInputCons.PrefixWrapperStyle.PrependIcon);
                // }
                // if(AddonBefore.IsString()){
                //   prefixWrapperCls.StyleApply(SInputCons.PrefixWrapperStyle.PrependText);
                // }
                return builder =>
                {
                    builder.OpenElement(0, "div");
                    builder.AddAttribute(1, "class", prefixWrapperCls.GetClass());
                    builder.AddAttribute(2, "x-semi-prop","addonBefore" );
                    builder.AddContent(3, AddonBefore);
                    builder.CloseElement();
                };
            }

            return null;
        }
    }

    internal RenderFragment? RenderAppend
    {
        get
        {
            if (AddonBefore != null)
            {
                var prefixWrapperCls = new ComponentCssProvider();
                prefixWrapperCls.StyleApply(SInputCons.PrependWrapperStyle.Prepend);
            
                // if(AddonBefore.IsSemiIcon()){
                //   prefixWrapperCls.StyleApply(SInputCons.PrefixWrapperStyle.PrependIcon);
                // }
                // if(AddonBefore.IsString()){
                //   prefixWrapperCls.StyleApply(SInputCons.PrefixWrapperStyle.PrependText);
                // }
                return builder =>
                {
                    builder.OpenElement(0, "div");
                    builder.AddAttribute(1, "class", prefixWrapperCls.GetClass());
                    builder.AddAttribute(2, "x-semi-prop","addonBefore" );
                    builder.AddContent(3, AddonBefore);
                    builder.CloseElement();
                };
            }

            return null;
        }
    }

    internal RenderFragment? RenderClearBtn
    {
        get
        {
            if (!this.IsAllowClear)
                return null;
            var clearCls = new ComponentCssProvider();
            clearCls.StyleApply(SInputCons.ClearBtnStyle);
            return builder =>
            {
                builder.OpenElement(0, "div");
                builder.AddAttribute(1, "class", clearCls.GetClass());
                // builder.AddAttribute(2, "onMouseDown", OnHandleClear);
                if(ClearIcon != null)
                    builder.AddContent(2, clearCls);
                // else
                    // builder.Add(2,  new SIconClear());
                builder.CloseElement();
            };
        }
    }

    internal RenderFragment RenderModeBtn
    {
        get
        {
            var showModeBtn = Mode == InputMode.Password && !Disabled;
            if (!showModeBtn)
                return null;
            var ariaLabel = eyeClosed ? "Show password" : "Hidden password";
            
            var modeCls = new ComponentCssProvider();
            modeCls.StyleApply(SInputCons.ModeBtnStyle);
            return builder =>
            {
                builder.OpenElement(0, "div");
                builder.AddAttribute(1, "class", modeCls.GetClass());
                builder.AddAttribute(2, "role", "button");
                builder.AddAttribute(2, "tabIndex", "0");
                builder.AddAttribute(2, "aria-label", ariaLabel);
                // builder.AddAttribute(2, "onClick", handleClickEye);
                // builder.AddAttribute(2, "onMouseDown", handleMouseDown);
                // builder.AddAttribute(2, "onMouseUp", handleMouseUp);
                // builder.AddAttribute(2, "onKeyPress", handleModeEnterPress);
                builder.AddContent(2, modeCls);
                builder.CloseElement();
            };
        }
    }
    
    

    protected override Task OnInitializedAsync()
    {
        if (!string.IsNullOrWhiteSpace(Style))
        {
            CssProvider?.StyleApply(Style);
        }
            
        if (!string.IsNullOrWhiteSpace(Class))
        {
            CssProvider?.CssApply(Class);
        }


        #region wrapper

        if (PreFix != null)
            _wrapperCls.CssApply(SInputCons.WrapperStyle.Prefix);

        if (Suffix != null)
            _wrapperCls.CssApply(SInputCons.WrapperStyle.Suffix);
        
        
        

        #endregion
        
        

        return base.OnInitializedAsync();
    }
}

internal static class SInputCons
{
    public const string DefaultPrefixCls = "semi-input";
    public const string WrapperPrefixCls = $"{DefaultPrefixCls}-wrapper";
    
    public static class WrapperStyle
    {
        public const string Prefix = $"{DefaultPrefixCls}-wrapper__with-prefix";
        public const string Suffix = $"{DefaultPrefixCls}-wrapper__with-suffix";
        public const string SuffixHidden = $"{DefaultPrefixCls}-wrapper__with-suffix-hidden";
        public const string SuffixIcon = $"{DefaultPrefixCls}-wrapper__with-suffix-icon";
        public const string WithAppend = $"{DefaultPrefixCls}-wrapper__with-append";
        public const string WithPrepend = $"{DefaultPrefixCls}-wrapper__with-prepend";
        public const string WithAppendOnly = $"{DefaultPrefixCls}-wrapper__with-append-only";
        public const string WithPrependOnly = $"{DefaultPrefixCls}-wrapper__with-prepend-only";
        public const string Readonly = $"{WrapperPrefixCls}-readonly";
        public const string Disabled = $"{WrapperPrefixCls}-disabled";
        public const string Warning = $"{WrapperPrefixCls}-warning";
        public const string Error = $"{WrapperPrefixCls}-error";
        public const string Focus = $"{WrapperPrefixCls}-focus";
        public const string Clearable = $"{WrapperPrefixCls}-clearable";
        public const string ModeBtn = $"{WrapperPrefixCls}-modebtn";
        public const string Hidden = $"{WrapperPrefixCls}-hidden";
        public const string Default = $"{WrapperPrefixCls}-default";
        public const string Large = $"{WrapperPrefixCls}-large";
        public const string Small = $"{WrapperPrefixCls}-small";
    }

    public static class DefaultStyle
    {
        public const string Default = $"{DefaultPrefixCls}-default";
        public const string Large = $"{DefaultPrefixCls}-large";
        public const string Small = $"{DefaultPrefixCls}-small";
        public const string Disabled = $"{DefaultPrefixCls}-disabled";
        public const string SiblingClearBtn = $"{DefaultPrefixCls}-sibling-clearbtn";
        public const string SiblingModeBtn = $"{DefaultPrefixCls}-sibling-modebtn";
    }
    
    public static class PrependWrapperStyle
    {
        public const string Prepend = $"{DefaultPrefixCls}-prepend";
        public const string PrependText = $"{DefaultPrefixCls}-prepend-text";
        public const string PrependIcon = $"{DefaultPrefixCls}-prepend-icon";
    }

    public static class AppendWrapperStyle
    {
        public const string Prepend = $"{DefaultPrefixCls}-append";
        public const string PrependText = $"{DefaultPrefixCls}-append-text";
        public const string PrependIcon = $"{DefaultPrefixCls}-append-icon";
    }

    public static string ClearBtnStyle = $"{DefaultPrefixCls}-clearbtn";
    public static string ModeBtnStyle = $"{DefaultPrefixCls}-modebtn";
    

    public static class PrefixWrapperStyle
    {
        public const string Prefix = $"{DefaultPrefixCls}-prefix";
        public const string InsetLabel = $"{DefaultPrefixCls}-inset-label";
        public const string PrefixText = $"{DefaultPrefixCls}-prefix-text";
        public const string PrefixIcon = $"{DefaultPrefixCls}-prefix-icon";
    }
    
    public static class SuffixWrapperStyle
    {
        public const string Suffix = $"{DefaultPrefixCls}-suffix";
        public const string SuffixHidden = $"{DefaultPrefixCls}-suffix-hidden";
        public const string SuffixText = $"{DefaultPrefixCls}-suffix-text";
        public const string SuffixIcon = $"{DefaultPrefixCls}-suffix-icon";
    }
}



public enum InputMode
{
    Normal = 0,
    Password = 1,
}

public enum SizeType
{
    Default = 0,
    Large = 1,
    Small = 2
}

public enum ValidateStatus
{
    Default = 0,
    Error= 1,
    Warning = 2,
    Success  =3,
}
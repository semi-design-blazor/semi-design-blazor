using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Components.Web;

namespace BlazorComponent;

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
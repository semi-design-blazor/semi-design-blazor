# 基于Semi.Design实现的Blazor Ui组件


**注入当前服务**

```c#
builder.Services.AddSemiDesignBlazor();
```

## 使用组件

```html
<div className="btn-margin-right">
    <SButton>主要按钮</SButton>
    <SButton Secondary>次要按钮</SButton>
    <SButton Tertiary>第三按钮</SButton>
    <SButton Warning>警告按钮</SButton>
    <SButton Danger>危险按钮</SButton>
</div>
```

<p align="center">
  <a href="https://semi-design-blazor.cn" target="_blank">
    <img alt="Semi Design Blazor Logo" width="150" src="img/logo.png">
  </a>
</p>

<h1 align="center">Semi Design Blazor</h1>


一套基于`semi-design`设计规范和`Blazor`的交互能力提供标准的基础组件库


## Semi Design Blazor？

基于`semi-design`设计规范和`Blazor`的交互能力提供标准的基础组件库。 提供如布局、弹框标准、Loading、全局异常处理等标准场景的预置组件。从更多实际场景出发，满足更多用户和场景的需求，最大的减少开发者的时间成本。缩短开发周期提高开发效率。并提供一套Web解决方案示例 有多种常见场景和预设布局等精彩内容。

# 🎉 特性

- 💪 60+高质量组件
- 💕 完善的无障碍支持，为所有组件提供遵循 W3C 标准的键盘交互、焦点管理和语义化
- 🎨 设计系统管理工具 Semi DSM，多达2000+ Design Token，快速定制你的专属设计系统


# 🔥 安装

```sh
dotnet add package Semi.Design.Blazor
```


# 👍 使用

先注入服务

```c#
builder.Services.AddSemiDesignBlazor();
```

添加css引用
`server`模式 需要将引用添加到`_Host.cshtml` 文件中 `wasm`模式需要添加到`index.html`中

```
<link rel="stylesheet" href="https://unpkg.com/@douyinfe/semi-ui@2.27.0/dist/css/semi.css">
<link rel="stylesheet" href="https://unpkg.com/@douyinfe/semi-icons@latest/dist/css/semi-icons.css">
```

这是一个快速开始的例子：

```razor
<div className="btn-margin-right">
    <SButton>主要按钮</SButton>
    <SButton Secondary>次要按钮</SButton>
    <SButton Tertiary>第三按钮</SButton>
    <SButton Warning>警告按钮</SButton>
    <SButton Danger>危险按钮</SButton>
</div>
```
# 👐 贡献指南

阅读贡献指南了解我们的开发流程，包括开发规范、测试规范和构建规范等。

[CONTRIBUTING](CONTRIBUTING.md)

# 💖 Thanks

感谢 [semi.design](https://github.com/DouyinFE/semi-design)。

# 🎈 协议

Semi UI 使用 [MIT 协议](LICENSE)

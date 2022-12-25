# Semi.Design.Docs 文档

项目结构 

wwwroot 
	- pages 页面展示
		- button 
			- index.txt 组件的源码

1. 需要在navigaton中添加您的组件路由
2.在Component下新增组件文件夹
3.在文件夹中新建`Index.razor`，这个将是在界面渲染的组件
4.可以将示例写出其他的razor组件,然后使用`SMonacoEditor`组件将其包括,

	- 示例：
```html

<SMonacoEditor Component="divider/BasicUse.txt"> // Component 指向的是在wwwroot/pages/的组件的源码文件
    <BasicUse/> // 渲染的组件
</SMonacoEditor>

```
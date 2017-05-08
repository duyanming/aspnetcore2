﻿using System;

namespace @Model.NameSpace
{
    /// <summary>
    /// 实体类@(Model.ClassName)。(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    public  class @Model.ClassName
    {
@foreach(var item in Model.Columns)
{
		@:/// <summary>
		@:/// @(item.DeText)
		@:/// </summary>
		@:public @item.TypeName @item.ColumnName { get; set; }
}
		 public string table="@Model.ClassName";
	}
}
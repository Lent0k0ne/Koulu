/*
 * XenForo acp_quicksearch.min.js
 * Copyright 2010-2018 XenForo Ltd.
 * Released under the XenForo License Agreement: http://xenforo.com/license-agreement
 */
var $jscomp=$jscomp||{};$jscomp.scope={};$jscomp.findInternal=function(a,d,b){a instanceof String&&(a=String(a));for(var c=a.length,e=0;e<c;e++){var h=a[e];if(d.call(b,h,e,a))return{i:e,v:h}}return{i:-1,v:void 0}};$jscomp.ASSUME_ES5=!1;$jscomp.ASSUME_NO_NATIVE_MAP=!1;$jscomp.ASSUME_NO_NATIVE_SET=!1;$jscomp.defineProperty=$jscomp.ASSUME_ES5||"function"==typeof Object.defineProperties?Object.defineProperty:function(a,d,b){a!=Array.prototype&&a!=Object.prototype&&(a[d]=b.value)};
$jscomp.getGlobal=function(a){return"undefined"!=typeof window&&window===a?a:"undefined"!=typeof global&&null!=global?global:a};$jscomp.global=$jscomp.getGlobal(this);$jscomp.polyfill=function(a,d,b,c){if(d){b=$jscomp.global;a=a.split(".");for(c=0;c<a.length-1;c++){var e=a[c];e in b||(b[e]={});b=b[e]}a=a[a.length-1];c=b[a];d=d(c);d!=c&&null!=d&&$jscomp.defineProperty(b,a,{configurable:!0,writable:!0,value:d})}};
$jscomp.polyfill("Array.prototype.find",function(a){return a?a:function(a,b){return $jscomp.findInternal(this,a,b).v}},"es6","es3");
!function(a,d,b,c){XenForo.AdminSearchForm=function(b){var c=a("#AdminSearchInput"),e=a(b.data("target")),k=null,g=null,l="";c.attr("autocomplete","off").bind({keyup:function(f){f=c.strval();f!=l&&2<=f.length?(l=f,clearTimeout(k),k=setTimeout(function(){console.log('The input now reads "%s"',c.strval());g&&g.abort();g=XenForo.ajax(b.attr("action"),b.serializeArray(),function(b,c){if(XenForo.hasResponseError(b))return!1;XenForo.hasTemplateHtml(b)&&(e.empty().append(b.templateHtml),e.find("li").mouseleave(function(b){a(this).removeClass("kbSelect")}),
e.find("li:first").addClass("kbSelect"))})},250)):""==f&&e.empty()},paste:function(a){setTimeout(function(){c.trigger("keyup")},0)},keydown:function(a){switch(a.which){case 38:case 40:var b=e.find("li"),c=b.filter(".kbSelect"),d=0;c.length&&(d=b.index(c.get(0)),d+=40==a.which?1:-1,0>d||d>=b.length)&&(d=0);b.removeClass("kbSelect").eq(d).addClass("kbSelect");return!1}}});c.closest("form").submit(function(a){a.preventDefault();a=e.find("li.kbSelect a");a.length&&(d.location=a.attr("href"));return!1})};
XenForo.register("#AdminSearchForm","XenForo.AdminSearchForm")}(jQuery,this,document);

﻿/*
* Ext JS Library 2.0.2
* Copyright(c) 2006-2008, Ext JS, LLC.
* licensing＠extjs.com
* 
* extjs.com/license
*/

Ext.ux.PortalColumn = Ext.extend(Ext.Container, {
    layout: 'anchor',
    autoEl: 'div',
    defaultType: 'portlet',
    cls: 'x-portal-column'
});
Ext.reg('portalcolumn', Ext.ux.PortalColumn);
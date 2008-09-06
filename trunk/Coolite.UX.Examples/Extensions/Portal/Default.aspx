<%@ Page Language="C#" %>
<%@ Import Namespace="Coolite.Utilities" %>

<%@ Register assembly="Coolite.Ext.UX" namespace="Coolite.Ext.UX" tagprefix="ux" %>
<%@ Register assembly="Coolite.Ext.Web" namespace="Coolite.Ext.Web" tagprefix="ext" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">
    protected void Page_Load(object sender, EventArgs e)
    {
        string text = @"Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Sed metus nibh, sodales a, porta at, vulputate eget, dui. Pellentesque ut nisl. Maecenas tortor turpis, interdum non, sodales non, iaculis ac, lacus. Vestibulum auctor, tortor quis iaculis malesuada, libero lectus bibendum purus, sit amet tincidunt quam turpis vel lacus. In pellentesque nisl non sem. Suspendisse nunc sem, pretium eget, cursus a, fringilla vel, urna.";

        this.ScriptManager1.RegisterClientScriptBlock("text", string.Format("var text=\"{0}\";", text));

        foreach (Portlet portlet in ControlUtils.FindAllControls<Portlet>(this.ViewPort1))
        {
            portlet.Html = "={text}";
        }
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Portal in TabPanel</title>
</head>
<body>
    <form id="form1" runat="server">
        <ext:ScriptManager ID="ScriptManager1" runat="server" StateProvider="None" Theme="Gray" />
        <ext:ViewPort ID="ViewPort1" runat="server">
            <Content>
                <ext:BorderLayout ID="BorderLayout1" runat="server">
                    <West 
                        Collapsible="true" 
                        Split="true" 
                        MinWidth="175" 
                        MaxWidth="400" 
                        MarginsSummary="35 0 5 5" 
                        CMarginsSummary="35 5 5 5">
                        <ext:Panel 
                            runat="server" 
                            Title="West" 
                            Width="200" 
                            ID="west_panel">
                            <Content>
                                <ext:Accordion ID="Accordion1" runat="server" Animate="true">
                                    <ext:Panel ID="Panel1" 
                                        runat="server" 
                                        Border="false" 
                                        Collapsed="True" 
                                        Icon="FolderGo"
                                        AutoScroll="true"
                                        Title="Navigation"
                                        />
                                    <ext:Panel ID="Panel2" 
                                        runat="server" 
                                        Border="false" 
                                        Collapsed="true" 
                                        Icon="FolderWrench" 
                                        AutoScroll="true"
                                        Title="Settings" 
                                        />
                                </ext:Accordion>
                            </Content>
                        </ext:Panel>
                    </West>
                    <Center MarginsSummary="35 5 5 0">
                        <ext:TabPanel ID="TabPanel1" runat="server" ActiveTab="0" Title="TabPanel">
                            <Tabs>
                                <ext:Tab ID="Tab1" runat="server" Title="Tab 1">
                                    <Content>
                                        <ext:FitLayout ID="FitLayout1" runat="server">
                                            <ux:Portal ID="Portal1" runat="server" Border="false">
                                                <Content>
                                                    <ext:ColumnLayout ID="ColumnLayout1" runat="server">
                                                    
                                                        <ext:LayoutColumn ColumnWidth=".33">
                                                            <ux:PortalColumn 
                                                                ID="PortalColumn1" 
                                                                runat="server" 
                                                                StyleSpec="padding:10px 0 10px 10px">
                                                                <Content>
                                                                    <ext:AnchorLayout ID="AnchorLayout1" runat="server">
                                                                        <ext:Anchor Horizontal="100%">
                                                                            <ux:Portlet ID="Portlet1" Title="Another Panel 1" runat="server" />
                                                                        </ext:Anchor>
                                                                    </ext:AnchorLayout>
                                                                </Content>
                                                            </ux:PortalColumn>
                                                        </ext:LayoutColumn>
                                                        
                                                        <ext:LayoutColumn ColumnWidth=".33">
                                                            <ux:PortalColumn 
                                                                ID="PortalColumn2" 
                                                                runat="server" 
                                                                StyleSpec="padding:10px 0 10px 10px">
                                                                <Content>
                                                                    <ext:AnchorLayout ID="AnchorLayout2" runat="server">
                                                                        <ext:Anchor Horizontal="100%">
                                                                            <ux:Portlet ID="Portlet2" Title="Panel 2" runat="server" />
                                                                        </ext:Anchor>
                                                                        <ext:Anchor Horizontal="100%">
                                                                            <ux:Portlet ID="Portlet3" Title="Another Panel 2" runat="server" />
                                                                        </ext:Anchor>
                                                                    </ext:AnchorLayout>
                                                                </Content>
                                                            </ux:PortalColumn>
                                                        </ext:LayoutColumn>
                                                        
                                                        <ext:LayoutColumn ColumnWidth=".33">
                                                            <ux:PortalColumn 
                                                                ID="PortalColumn3" 
                                                                runat="server" 
                                                                StyleSpec="padding:10px">
                                                                <Content>
                                                                    <ext:AnchorLayout ID="AnchorLayout3" runat="server">
                                                                        <ext:Anchor Horizontal="100%">
                                                                            <ux:Portlet ID="Portlet4" Title="Panel 3" runat="server" />
                                                                        </ext:Anchor>
                                                                        <ext:Anchor Horizontal="100%">
                                                                            <ux:Portlet ID="Portlet5" Title="Another Panel 3" runat="server" />
                                                                        </ext:Anchor>
                                                                    </ext:AnchorLayout>
                                                                </Content>
                                                            </ux:PortalColumn>
                                                        </ext:LayoutColumn>
                                                        
                                                    </ext:ColumnLayout>    
                                                </Content>
                                            </ux:Portal>
                                        </ext:FitLayout>
                                    </Content>
                                </ext:Tab>
                                <ext:Tab ID="Tab2" runat="server" Title="Tab 2">
                                    <Content>
                                        <ext:FitLayout ID="FitLayout2" runat="server">
                                            <ux:Portal ID="Portal2" runat="server" Border="false">
                                                <Content>
                                                    <ext:ColumnLayout ID="ColumnLayout2" runat="server">
                                                    
                                                        <ext:LayoutColumn ColumnWidth=".33">
                                                            <ux:PortalColumn 
                                                                ID="PortalColumn6" 
                                                                runat="server" 
                                                                StyleSpec="padding:10px">
                                                                <Content>
                                                                    <ext:AnchorLayout ID="AnchorLayout6" runat="server">
                                                                        <ext:Anchor Horizontal="100%">
                                                                            <ux:Portlet ID="Portlet9" Title="Panel 3" runat="server" />
                                                                        </ext:Anchor>
                                                                        <ext:Anchor Horizontal="100%">
                                                                            <ux:Portlet ID="Portlet10" Title="Another Panel 3" runat="server" />
                                                                        </ext:Anchor>
                                                                    </ext:AnchorLayout>
                                                                </Content>
                                                            </ux:PortalColumn>
                                                        </ext:LayoutColumn>
                                                        
                                                        <ext:LayoutColumn ColumnWidth=".33">
                                                            <ux:PortalColumn 
                                                                ID="PortalColumn5" 
                                                                runat="server" 
                                                                StyleSpec="padding:10px 0 10px 10px">
                                                                <Content>
                                                                    <ext:AnchorLayout ID="AnchorLayout5" runat="server">
                                                                        <ext:Anchor Horizontal="100%">
                                                                            <ux:Portlet ID="Portlet7" Title="Panel 2" runat="server" />
                                                                        </ext:Anchor>
                                                                        
                                                                        <ext:Anchor Horizontal="100%">
                                                                            <ux:Portlet ID="Portlet8" Title="Another Panel 2" runat="server" />
                                                                        </ext:Anchor>
                                                                    </ext:AnchorLayout>
                                                                </Content>
                                                            </ux:PortalColumn>
                                                        </ext:LayoutColumn>
                                                        
                                                        <ext:LayoutColumn ColumnWidth=".33">
                                                            <ux:PortalColumn 
                                                                ID="PortalColumn4" 
                                                                runat="server" 
                                                                StyleSpec="padding:10px 0 10px 10px">
                                                                <Content>
                                                                    <ext:AnchorLayout ID="AnchorLayout4" runat="server">
                                                                        <ext:Anchor Horizontal="100%">
                                                                            <ux:Portlet ID="Portlet6" Title="Another Panel 1" runat="server" />
                                                                        </ext:Anchor>
                                                                    </ext:AnchorLayout>
                                                                </Content>
                                                            </ux:PortalColumn>
                                                        </ext:LayoutColumn>
                                                        
                                                    </ext:ColumnLayout>    
                                                </Content>
                                            </ux:Portal>                                    
                                        </ext:FitLayout>
                                    </Content>
                                </ext:Tab>
                            </Tabs>
                        </ext:TabPanel> 
                    </Center>
                </ext:BorderLayout>
            </Content>
        </ext:ViewPort>
    </form>
</body>
</html>

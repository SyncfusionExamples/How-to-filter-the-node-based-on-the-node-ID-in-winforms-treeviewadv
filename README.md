# How to filter the node based on the node ID in WinForms TreeViewAdv

This session describes how to filter the node based on the nodeID in [WinForms TreeViewAdv](https://www.syncfusion.com/winforms-ui-controls/treeview).

In the `TreeViewAdv`, [TreeNodeAdv](https://help.syncfusion.com/cr/windowsforms/Syncfusion.Tools.Windows~Syncfusion.Windows.Forms.Tools.TreeNodeAdv.html) can be filtered based on its value by performing the iteration process. The following code example demonstrates the same.

``` csharp
for(int nodeId = 0; nodeId <= 10000; nodeId++)
{
     //Custom node for ID propety
    CustomTreeNodeAdv customNode = new CustomTreeNodeAdv();
    customNode.ID = nodeId;
    customNode.Text = "Node" + nodeId.ToString();
    this.treeViewAdv1.Nodes.Add(customNode);
}
//Iterates the nodes in the TreeViewAdv
foreach (CustomTreeNodeAdv item in this.treeViewAdv1.Nodes)
{
    //Gets the TextBox value
    string textvalue = item.ID.ToString();
    if(this.integerTextBox1.Text == textvalue)
    {
       //Gets the node by its ID
       MessageBox.Show(item.Text);
    }
}
```
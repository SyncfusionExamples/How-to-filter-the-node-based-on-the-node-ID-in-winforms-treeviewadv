# How to Filter the Node Based on the NodeID in WinForms TreeView?

This sample describes how to filter the node based on the nodeID in [WinForms TreeView](https://www.syncfusion.com/winforms-ui-controls/treeview) (TreeViewAdv).

In the `TreeViewAdv`, TreeNodeAdv can be filtered based on its value by performing the iteration process. The following code example demonstrates the same.

#### C#

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

#### Vb

``` vb
For nodeId As Integer = 0 To 10000
    'Custom node for ID propety
    Dim customNode As New CustomTreeNodeAdv()
    customNode.ID = nodeId
    customNode.Text = "Node" & nodeId.ToString()
    Me.treeViewAdv1.Nodes.Add(customNode)
Next nodeId
'Iterates the nodes in the TreeViewAdv
For Each item As CustomTreeNodeAdv In Me.treeViewAdv1.Nodes
    'Gets the TextBox value
    Dim textvalue As String = item.ID.ToString()
    If Me.integerTextBox1.Text = textvalue Then
       'Gets the node by its ID
       MessageBox.Show(item.Text)
    End If
Next item
```

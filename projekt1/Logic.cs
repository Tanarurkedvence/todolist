using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace projekt1
{
    internal class Logic
{
    List<string> Entries = new List<string>();
   
    public void addEntry(string entryLabel, Panel targetPanel)
    {
        Entries.Add(entryLabel);
        showEntries(targetPanel);
    }

    private void showEntries(Panel targetPanel)
    {
        targetPanel.Controls.Clear();
        int i = 0;
        foreach (var entry in Entries)
        {
            Label newLabel = new Label();
            newLabel.Text = entry;
            newLabel.Location = new Point(0, i * 30);
            newLabel.Size = new Size(100, 20);

            Button action = new Button();
            action.Text = "✓";
            action.Location = new Point(110, i * 30);
            action.Size = new Size(20, 20);
            action.Tag = i; 


            action.Click += removeEntry;

            targetPanel.Controls.Add(newLabel);
            targetPanel.Controls.Add(action);
            i++;
        }
    }

    private void removeEntry(object sender, EventArgs e)
    {
        Button clicked = sender as Button;
        int entryIndex = int.Parse(clicked.Tag.ToString());
        if (entryIndex >= 0 && entryIndex < Entries.Count)
        {
            Entries.RemoveAt(entryIndex);
            showEntries(clicked.Parent as Panel);
        }
    }
}

}

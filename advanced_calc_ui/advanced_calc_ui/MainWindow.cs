using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void button_click(object sender, EventArgs e)
    {
        if (output.Text == "0")
        {
            output.Text = "0";
        }
        Button button = (Button)sender;


    }
}

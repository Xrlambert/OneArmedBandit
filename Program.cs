using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

static class Program
{
    [STAThread]
    static void Main()
    {
        Assembly asm = Assembly.GetExecutingAssembly();
        Debug.WriteLine("Manifest resource names:");
        foreach (var name in asm.GetManifestResourceNames())
            Debug.WriteLine(name);

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Form1());
    }
}
using System;

namespace Task3
{
    public class Presenter
    {
        Model model;
        MainWindow mainWindow;
        private int result;

        public Presenter(MainWindow mainWindow)
        {
            this.model=new Model();
            this.mainWindow = mainWindow;
            this.mainWindow.Delit += MainWindow_Delit;
            this.mainWindow.Umnozit += MainWindow_Umnozit;
            this.mainWindow.Plus += MainWindow_Plus;
            this.mainWindow.Minus += MainWindow_Minus;
            this.mainWindow.Result += MainWindow_Result;
        }

        private void MainWindow_Result(object sender, System.EventArgs e)
        {
            mainWindow.TboxResult.Text=result.ToString();
        }

        private void MainWindow_Minus(object sender, System.EventArgs e)
        {
            result = model.Minus(Convert.ToInt32(mainWindow.TboxAVar.Text), 
                Convert.ToInt32(mainWindow.TboxBVar.Text));
        }

        private void MainWindow_Plus(object sender, System.EventArgs e)
        {
            result = model.Plus(Convert.ToInt32(mainWindow.TboxAVar.Text), 
                Convert.ToInt32(mainWindow.TboxBVar.Text));
        }

        private void MainWindow_Umnozit(object sender, System.EventArgs e)
        {
            result = model.Umnozit(Convert.ToInt32(mainWindow.TboxAVar.Text),
                Convert.ToInt32(mainWindow.TboxBVar.Text));
        }

        private void MainWindow_Delit(object sender, System.EventArgs e)
        {
            result = model.Delit(Convert.ToInt32(mainWindow.TboxAVar.Text),
                Convert.ToInt32(mainWindow.TboxBVar.Text));
        }
    }
}
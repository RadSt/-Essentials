namespace Task3
{
    public class Presenter
    {
        Model model;
        MainWindow mainWindow;

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
            throw new System.NotImplementedException();
        }

        private void MainWindow_Minus(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void MainWindow_Plus(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void MainWindow_Umnozit(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void MainWindow_Delit(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
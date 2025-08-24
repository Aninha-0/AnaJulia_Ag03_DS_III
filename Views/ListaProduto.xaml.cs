namespace Anajulia_Ag3_DS_III.Views;

public partial class ListaProduto : ContentPage
{
	public ListaProduto()
	{
		InitializeComponent();
	}

    private void ToolbarItem_Cliked(object sender, EventArgs e)

    {
        try
		{
			Navigation.PushAsync(new Views.NovoProduto());

		}catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "OK");
		}
	}
}
namespace Xamarin.Forms_Button;

///<Summary>
///<Createddate> 2023/07/11 </Createddate>
///<company> INDEL </company>
///<lastmodificationdate> 2023/07/11 </lastmodificationdate>
///<lastmodificationdescription>
/// Se realizo el diseño y se configuró el código cs de la app
///</lastmodificationdescription>
///<lastmodifierautor> Natasha Navarro </lastmodifierautor>
///</Summary>

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
    private void Button_Clicked(object sender, EventArgs e)
    {
        (sender as Button).Text = "Presioname de nuevo";
    }


}


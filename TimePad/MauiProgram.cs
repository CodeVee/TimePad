namespace TimePad;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
                fonts.AddFont("Rubik-Regular.ttf", "RubikRegular");
                fonts.AddFont("Rubik-Medium.ttf", "RubikMedium");
            });

		return builder.Build();
	}
}

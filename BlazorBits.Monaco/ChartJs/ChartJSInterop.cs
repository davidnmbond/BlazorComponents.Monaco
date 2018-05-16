using Microsoft.AspNetCore.Blazor.Browser.Interop;

namespace BlazorComponents.ChartJs
{
	public static class ChartJsInterop
	{
		public static bool InitializeLineChart(ChartJsChart<ChartJsLineDataset> lineChart)
		{
			return RegisteredFunction.Invoke<bool>("BlazorComponents.ChartJsInterop.InitializeLineChart", new[] { lineChart });
		}

		public static bool UpdateLineChart(ChartJsChart<ChartJsLineDataset> lineChart)
		{
			return RegisteredFunction.Invoke<bool>("BlazorComponents.ChartJsInterop.UpdateLineChart", new[] { lineChart });
		}
	}
}

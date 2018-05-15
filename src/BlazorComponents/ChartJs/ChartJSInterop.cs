using Microsoft.AspNetCore.Blazor.Browser.Interop;

namespace BlazorComponents.ChartJs
{
	public static class ChartJsInterop
	{
		public static bool InitializeLineChart(ChartJsChart<ChartJsLineDataset> lineChart)
		{
			return RegisteredFunction.Invoke<bool>("BlazorComponents.ChartJsInterop.InitializeLineChart", new[] { lineChart });
		}

		public static bool InitializeBarChart(ChartJsChart<ChartJsBarDataset> barChart)
		{
			return RegisteredFunction.Invoke<bool>("BlazorComponents.ChartJsInterop.InitializeBarChart", new[] { barChart });
		}

		public static bool UpdateLineChart(ChartJsChart<ChartJsLineDataset> lineChart)
		{
			return RegisteredFunction.Invoke<bool>("BlazorComponents.ChartJsInterop.UpdateLineChart", new[] { lineChart });
		}

		public static bool UpdateBarChart(ChartJsChart<ChartJsBarDataset> barChart)
		{
			return RegisteredFunction.Invoke<bool>("BlazorComponents.ChartJsInterop.UpdateBarChart", new[] { barChart });
		}

		public static bool InitializeRadarChart(ChartJsChart<ChartJsRadarDataset> radarChart)
		{
			return RegisteredFunction.Invoke<bool>("BlazorComponents.ChartJsInterop.InitializeRadarChart", new[] { radarChart });
		}

		public static bool UpdateRadarChart(ChartJsChart<ChartJsRadarDataset> radarChart)
		{
			return RegisteredFunction.Invoke<bool>("BlazorComponents.ChartJsInterop.UpdateRadarChart", new[] { radarChart });
		}
	}
}

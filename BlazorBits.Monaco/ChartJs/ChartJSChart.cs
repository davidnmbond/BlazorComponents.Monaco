using System;

namespace BlazorComponents.ChartJs
{
	public class ChartJsChart<T> where T : ChartJsDataset
	{
		public string ChartType { get; set; } = "bar";
		public ChartJsData<T> Data { get; set; }
		public ChartJsOptions Options { get; set; }
		public string CanvasId { get; set; } = $"BlazorChartJs_{new Random().Next(0, 1000000).ToString()}";
	}
}

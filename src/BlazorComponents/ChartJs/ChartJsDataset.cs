using System.Collections.Generic;

namespace BlazorComponents.ChartJs
{
	public abstract class ChartJsDataset
	{
		/// <summary>
		/// The label for the dataset which appears in the legend and tool-tips.
		/// </summary>
		public string Label { get; set; } = "";

		/// <summary>
		/// Actual data. This is an int array.
		/// TO-DO: Explore if it makes any sense to have this as decimal.
		/// </summary>
		public List<int> Data { get; set; } = new List<int>();

		/// <summary>
		/// The fill color under the line.
		/// AS-IS: We only accept colors as string values. Normal colors and HTML Hex colors are ok to use.
		/// TODO: Accept some form of actual color information rather than strings.
		/// </summary>
		public string BackgroundColor { get; set; }

		/// <summary>
		/// The color of the line
		/// AS-IS: We only accept string colors.
		/// TODO: Accept some form of actual color information rather than strings.
		/// </summary>
		public string BorderColor { get; set; }
	}
}

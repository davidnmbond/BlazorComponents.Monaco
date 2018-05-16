﻿var BlazorCharts = [];
Blazor.BlazorCharts = BlazorCharts;

Blazor.registerFunction('BlazorComponents.ChartJsInterop.InitializeLineChart', (data) => {
	data = toCamel(data);

	let thisChart = initializeChartjsChart(data, 'line');

	if (!BlazorCharts.find(currentChart => currentChart.id === data.canvasId)) {
		BlazorCharts.push({ id: data.canvasId, chart: thisChart });
	}
	return true;
});

Blazor.registerFunction('BlazorComponents.ChartJsInterop.UpdateLineChart', (data) => {
	data = toCamel(data);

	if (!BlazorCharts.find(currentChart => currentChart.id === data.canvasId)) {
		throw `Could not find a chart with the given id. ${data.canvasId}`;
	}

	let myChart = BlazorCharts.find(currentChart => currentChart.id === data.canvasId);
	let myChartIndex = BlazorCharts.findIndex(currentChart => currentChart.id === data.canvasId);

	myChart.chart = {};
	let newChart = initializeChartjsChart(data, 'line');
	myChart.chart = newChart;

	return true;
});

function initializeChartjsChart(data, type) {
	let ctx = document.getElementById(data.canvasId);
	let myChart = new Chart(ctx, {
		type: type,
		data: data.data,
		options: data.options
	});

	return myChart;
}

var BlazorEditors = [];
Blazor.BlazorEditors = BlazorEditors;

Blazor.registerFunction('BlazorComponents.MonacoInterop.EditorInitialize', (editorModel) => {
	console.debug(`Registering new editor ${editorModel.Id}...`);
	let thisEditor = monaco.editor.create(document.getElementById(editorModel.Id), {
		value: editorModel.Script,
		language: editorModel.Language
	});

	if (BlazorEditors.find(e => e.id === editorModel.Id)) {
		console.error(`Refused to register duplicate editor ${editorModel.Id}`);
	}
	else {
		console.debug(`Registered new editor ${editorModel.Id}`);
		BlazorEditors.push({ id: editorModel.Id, editor: thisEditor });
	}

	return true;
});

Blazor.registerFunction('BlazorComponents.MonacoInterop.EditorGet', (editorModel) => {
	console.debug(`Getting editor for ${editorModel.Id}...`);
	let myEditor = BlazorEditors.find(e => e.id === editorModel.Id);
	console.debug(`Found: ${myEditor}`);
	if (!myEditor) {
		throw `Could not find a editor with id: '${editorModel.Id}'`;
	}

	// Update the model
	editorModel.Script = myEditor.editor.getValue();

	return editorModel;
});

Blazor.registerFunction('BlazorComponents.MonacoInterop.EditorSet', (editorModel) => {
	console.debug(`Setting editor for ${editorModel.Id}...`);
	let myEditor = BlazorEditors.find(e => e.id === editorModel.Id);
	console.debug(`Found: ${myEditor}`);
	if (!myEditor) {
		throw `Could not find a editor with id: '${editorModel.Id}'`;
	}

	// Update the editor
	myEditor.editor.setValue(editorModel.Script);
	console.debug(`Setting value to success.`);

	return editorModel;
});

// current JSON utility within Blazor is bare-bone and does not camelCase the response JSON.
// using the below snippet to perform camelCasing.
// source: https://stackoverflow.com/questions/12931828/convert-returned-json-object-properties-to-lower-first-camelcase/12932771
function toCamel(o) {
	var newO, origKey, newKey, value;
	if (o instanceof Array) {
		return o.map(function (value) {
		if (typeof value === "object") {
			value = toCamel(value);
			}
			return value;
		});
	}
	else
	{
		newO = {};
		for (origKey in o) {
			if (o.hasOwnProperty(origKey)) {
				newKey = (origKey.charAt(0).toLowerCase() + origKey.slice(1) || origKey).toString();
				value = o[origKey];
				if (value instanceof Array || (value !== null && value.constructor === Object)) {
					value = toCamel(value);
				}
			newO[newKey] = value;
			}
		}
	}
	return newO;
}
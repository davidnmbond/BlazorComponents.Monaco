using Microsoft.AspNetCore.Blazor.Browser.Interop;

namespace BlazorComponents.Monaco
{
	public static class MonacoInterop
	{
		public static bool InitializeEditor(EditorModel editorOptions)
			=> RegisteredFunction.Invoke<bool>("BlazorComponents.MonacoInterop.InitializeEditor", new[] { editorOptions });

		public static EditorModel UpdateEditor(EditorModel editorOptions)
			=> RegisteredFunction.Invoke<EditorModel>("BlazorComponents.MonacoInterop.UpdateEditor", new[] { editorOptions });
	}
}

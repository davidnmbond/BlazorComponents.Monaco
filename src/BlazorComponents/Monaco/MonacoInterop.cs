using Microsoft.AspNetCore.Blazor.Browser.Interop;

namespace BlazorComponents.Monaco
{
	public static class MonacoInterop
	{
		public static bool InitializeEditor(EditorOptions editorOptions)
			=> RegisteredFunction.Invoke<bool>("BlazorComponents.MonacoInterop.InitializeEditor", new[] { editorOptions });

		public static EditorOptions UpdateEditor(EditorOptions editorOptions)
			=> RegisteredFunction.Invoke<EditorOptions>("BlazorComponents.MonacoInterop.UpdateEditor", new[] { editorOptions });
	}
}

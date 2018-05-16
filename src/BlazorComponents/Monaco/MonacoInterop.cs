using Microsoft.AspNetCore.Blazor.Browser.Interop;

namespace BlazorComponents.Monaco
{
	public static class MonacoInterop
	{
		public static bool EditorInitialize(EditorModel editorModel)
			=> RegisteredFunction.Invoke<bool>("BlazorComponents.MonacoInterop.EditorInitialize", new[] { editorModel });

		public static EditorModel EditorGet(EditorModel editorModel)
			=> RegisteredFunction.Invoke<EditorModel>("BlazorComponents.MonacoInterop.EditorGet", new[] { editorModel });

		public static EditorModel EditorSet(EditorModel editorModel)
			=> RegisteredFunction.Invoke<EditorModel>("BlazorComponents.MonacoInterop.EditorSet", new[] { editorModel });
	}
}

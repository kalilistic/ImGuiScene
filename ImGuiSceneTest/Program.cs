using ImGuiNET;
using ImGuiScene;

namespace ImGuiSceneTest
{
    internal static class Program
    {
        static void Main()
        {
            using var scene = SimpleImGuiScene.CreateOverlay(RendererFactory.RendererBackend.DirectX11);
            scene.OnBuildUI += ImGui.ShowDemoWindow;
            scene.Run();
        }
    }
}

using UnityEngine;

namespace Kode_Unity
{
    public class KodeUnity : PartModule
    {
        private Rect WindowPosition = new Rect();

        public override void OnStart(StartState state)
        {
            if (state != StartState.Editor)
                RenderingManager.AddToPostDrawQueue(0, OnDraw);
        }

        private void OnDraw()
        {
            if (this.vessel == FlightGlobals.ActiveVessel)
                WindowPosition = GUILayout.Window(10, WindowPosition, OnWindow, "This is a title");
        }

        private void OnWindow(int windowId)
        {
            GUILayout.BeginHorizontal(GUILayout.Width(250f));
            GUILayout.Label("This is a label");
            GUILayout.EndHorizontal();

            GUI.DragWindow();
        }
    }
}

using UnityEditor;
using UnityEngine;

namespace FolderIcons
{

    public static class FolderIconGUI
    {

        public static void DrawFolderPreview(Rect rect, Texture folder, Texture overlay)
        {
            if (folder == null && overlay == null)
            {
                return;
            }

            if (folder != null)
            {
                GUI.DrawTexture (rect, folder, ScaleMode.ScaleToFit);
            }

            rect.size *= 0.5f;
            rect.position += rect.size * 0.5f;

            if (overlay != null)
            {
                GUI.DrawTexture (rect, overlay, ScaleMode.ScaleToFit);
            }
        }


        public static void DrawFolderTexture(Rect rect, Texture folder, string guid)
        {
            if (folder == null)
            {
                return;
            }

            EditorGUI.DrawRect (rect, FolderIconConstants.BackgroundColour);
            GUI.DrawTexture (rect, folder, ScaleMode.ScaleAndCrop);
        }


        public static void DrawOverlayTexture(Rect rect, Texture overlay)
        {
            if (overlay == null)
            {
                return;
            }

            rect.size *= 0.5f;
            rect.position += rect.size * 0.5f;

            GUI.DrawTexture (rect, overlay);
        }


        public static bool IsSideView(Rect rect)
        {
#if UNITY_2019_3_OR_NEWER
            return rect.x != 14;
#else
            return rect.x != 13;
#endif
        }


        public static bool IsTreeView(Rect rect)
        {
            return rect.width > rect.height;
        }
    }
}
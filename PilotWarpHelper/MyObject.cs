using System;
using PulsarModLoader.Utilities;
using UnityEngine;

namespace PilotWarpHelper
{
	internal class MyObject : MonoBehaviour
	{
		public void OnRenderObject()
		{
			try
			{
				if (PLUIOutsideWorldUI.Instance.NextWaypointSector.IsActive())
				{
					target = PLUIOutsideWorldUI.Instance.NextWaypointSector.transform.position;
				}
				else
				{
					target = Vector3.zero;
				}
			}
			catch (Exception ex)
			{
				PulsarModLoader.Utilities.Logger.Info(ex.ToString());
			}
			if (MyObject.target != Vector3.zero)
			{
				MyObject.DrawMaterail.SetPass(0);
				GL.PushMatrix();
				GL.Begin(1);
				GL.Color(this.clr);
				GL.Vertex(PLUIOutsideWorldUI.Instance.Crosshair_Forward.transform.position);
				GL.Vertex(MyObject.target);
				GL.End();
				GL.PopMatrix();
			}
		}

		internal static Material DrawMaterail;

		internal static Vector3 target;

		private Color32 clr = new Color32(0, 117, byte.MaxValue, byte.MaxValue);
	}
}

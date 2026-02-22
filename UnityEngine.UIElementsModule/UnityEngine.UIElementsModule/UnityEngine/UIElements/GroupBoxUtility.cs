using System;

namespace UnityEngine.UIElements
{
	// Token: 0x02000103 RID: 259
	public static class GroupBoxUtility
	{
		// Token: 0x06000DAB RID: 3499 RVA: 0x00008AB7 File Offset: 0x00006CB7
		public static void RegisterGroupBoxOptionCallbacks<T>(T option) where T : VisualElement
		{
			option.RegisterCallback<AttachToPanelEvent>(new EventCallback<AttachToPanelEvent>(GroupBoxUtility.OnOptionAttachToPanel), TrickleDown.NoTrickleDown);
			option.RegisterCallback<DetachFromPanelEvent>(new EventCallback<DetachFromPanelEvent>(GroupBoxUtility.OnOptionDetachFromPanel), TrickleDown.NoTrickleDown);
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x00008AEC File Offset: 0x00006CEC
		public static void OnOptionSelected<T>(T selectedOption) where T : VisualElement
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x00008AF9 File Offset: 0x00006CF9
		public static IGroupBoxOption GetSelectedOption(IGroupBox groupBox)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x00008B06 File Offset: 0x00006D06
		public static IGroupManager GetGroupManager(IGroupBox groupBox)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x00008B13 File Offset: 0x00006D13
		public static void OnOptionAttachToPanel(AttachToPanelEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x00008B20 File Offset: 0x00006D20
		public static void OnOptionDetachFromPanel(DetachFromPanelEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x00008B2D File Offset: 0x00006D2D
		public static IGroupManager FindOrCreateGroupManager(IGroupBox groupBox)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x00008B3A File Offset: 0x00006D3A
		public static void OnGroupBoxDetachedFromPanel(DetachFromPanelEvent evt)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x00008B47 File Offset: 0x00006D47
		public static void OnPanelDestroyed(BaseVisualElementPanel panel)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
